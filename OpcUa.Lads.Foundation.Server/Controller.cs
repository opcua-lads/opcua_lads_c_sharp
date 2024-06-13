using Opc.Ua;
using Opc.Ua.LADS;

namespace OpcUa.Lads.Foundation.Server
{
    /// <summary>
    /// Simple controller to manipulate
    /// different nodes of the luminescence reader
    /// </summary>
    public class Controller
    {
        private const double Damping = 0.8;

        private AnalogControlFunctionTypeState _tempController;
        private AnalogArraySensorFunctionTypeState _sensor;
        private readonly Random _random = new();
        private double _currentTemperature = 25.0;
        private readonly Thread _sensorThread;
        private readonly ManualResetEvent _exitEvent = new(false);
        private readonly ISystemContext _context;

        public Controller(ISystemContext context)
        {
            _context = context;

            // Thread handling the temperature and luminescence sensor update
            _sensorThread = new Thread(SensorLogic) { Name = "Sensor update logic", IsBackground = true };
        }

        private void SensorLogic(object obj)
        {
            while (!_exitEvent.WaitOne(1000))
            {
                // temperature with 1st order low pass filter and noise
                var targetTemp = _tempController.IsEnabled.Value ? _tempController.TargetValue.Value : 25;
                _currentTemperature = Damping * _currentTemperature + (1 - Damping) * targetTemp;
                var currentTemperatureWithNoise = _currentTemperature + 0.2 * (_random.NextDouble() - 0.5);

                // array of luminescence readings with some noise
                var luminescenceWithNoise = new double[96];
                for (var i = 0; i < luminescenceWithNoise.Length; i++)
                {
                    luminescenceWithNoise[i] = i * i + (_random.NextDouble() - 0.5);
                }

                // update the OPC model
                WriteValue(_tempController.CurrentValue, currentTemperatureWithNoise);
                WriteValue(_sensor.SensorValue, luminescenceWithNoise);
            }
        }

        public void Init(AnalogControlFunctionTypeState tempController, AnalogArraySensorFunctionTypeState sensor)
        {
            _tempController = tempController;
            _sensor = sensor;

            // Initialize some values
            _tempController.CurrentValue.Historizing = true;
            WriteValue(_tempController.IsEnabled, false);
            WriteValue(_tempController.TargetValue, 37.0);

            // Subscribe to method calls (to control the temperature)
            _tempController.ControlFunctionState.Start.OnCallMethod2 += OnStartTemperatureControl;
            _tempController.ControlFunctionState.StartWithTargetValue.OnCallMethod2 += OnStartTemperatureControlWithTargetValue;
            _tempController.ControlFunctionState.Stop.OnCallMethod2 += OnStopTemperatureControl;
        }

        private ServiceResult OnStartTemperatureControl(ISystemContext context, MethodState method, NodeId objectId,
            IList<object> inputArguments, IList<object> outputArguments)
        {
            WriteValue(_tempController.IsEnabled, true);
            return ServiceResult.Good;
        }

        private ServiceResult OnStartTemperatureControlWithTargetValue(ISystemContext context, MethodState method,
            NodeId objectId, IList<object> inputArguments, IList<object> outputArguments)
        {
            if (inputArguments.Count == 1 && double.TryParse(inputArguments[0].ToString(), out var targetTemp))
            {
                WriteValue(_tempController.IsEnabled, true);
                WriteValue(_tempController.TargetValue, targetTemp);
                return ServiceResult.Good;
            }

            return new ServiceResult(StatusCodes.BadInvalidArgument);
        }

        private ServiceResult OnStopTemperatureControl(ISystemContext context, MethodState method, NodeId objectId,
            IList<object> inputArguments, IList<object> outputArguments)
        {
            WriteValue(_tempController.IsEnabled, false);
            return ServiceResult.Good;
        }

        public void Start()
        {
            _sensorThread.Start();
        }

        public void Stop()
        {
            _exitEvent.Set();
            _sensorThread.Join();
        }

        private void WriteValue(BaseVariableState variable, object value)
        {
            variable.Value = value;
            variable.Timestamp = DateTime.Now;
            variable.ClearChangeMasks(_context, false);
        }
    }
}
