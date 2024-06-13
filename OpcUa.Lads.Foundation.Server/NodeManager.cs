using Opc.Ua.Server;
using Opc.Ua;
using Opc.Ua.Export;
using System.Reflection;
using Opc.Ua.LADS;
using ObjectIds = Opc.Ua.ObjectIds;

namespace OpcUa.Lads.Foundation.Server
{
    public sealed class NodeManager : CustomNodeManager2
    {
        private Controller _controller;

        public NodeManager(IServerInternal server, ApplicationConfiguration configuration,
            params string[] namespaceUris) : base(server, configuration, namespaceUris)
        {
            SystemContext.NodeIdFactory = this;
            NamespaceUris =
            [
                "http://opcfoundation.org/UA/DI/",
                "http://opcfoundation.org/UA/AMB/",
                "http://opcfoundation.org/UA/Machinery/",
                "http://opcfoundation.org/UA/LADS/",
                "http://spectaris.de/LuminescenceReader/"
            ];
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                if (!externalReferences.TryGetValue(ObjectIds.ObjectsFolder, out _))
                {
                    externalReferences[ObjectIds.ObjectsFolder] = [];
                }

                ImportXml(externalReferences, "OpcUa.Lads.Foundation.Server.NodeSet.Opc.Ua.DI.NodeSet2.xml");
                ImportXml(externalReferences, "OpcUa.Lads.Foundation.Server.NodeSet.Opc.Ua.AMB.NodeSet2.xml");
                ImportXml(externalReferences, "OpcUa.Lads.Foundation.Server.NodeSet.Opc.Ua.Machinery.NodeSet2.xml");
                ImportXml(externalReferences, "OpcUa.Lads.Foundation.Server.NodeSet.Opc.Ua.LADS.NodeSet2.xml");
                ImportXml(externalReferences, "OpcUa.Lads.Foundation.Server.NodeSet.LuminescenceReader.xml");

                // Attach children to parent (missing when not using the builtin load function)
                foreach (var node in PredefinedNodes)
                {
                    if (node.Value.Handle != null && PredefinedNodes.TryGetValue((NodeId)node.Value.Handle, out var parent))
                    {
                        parent.AddChild((BaseInstanceState)node.Value);
                    }
                }

                var passiveTemp = (BaseObjectState)PredefinedNodes.First(n =>
                    (uint)n.Key.Identifier == Spectaris.LuminescenceReader.Objects
                        .LuminescenceReaderDevice_FunctionalUnitSet_LuminescenceReaderUnit_FunctionSet_TemperatureController &&
                    n.Value.DisplayName == "Temperature Controller").Value;
                var activeTemp = new AnalogControlFunctionTypeState(passiveTemp.Parent);
                UpdateInstance(passiveTemp, activeTemp);

                var passiveSensor = (BaseObjectState)PredefinedNodes.First(n =>
                    (uint)n.Key.Identifier == Spectaris.LuminescenceReader.Objects
                        .LuminescenceReaderDevice_FunctionalUnitSet_LuminescenceReaderUnit_FunctionSet_LuminescenceSensor &&
                    n.Value.DisplayName == "Luminescence Sensor").Value;
                var activeSensor = new AnalogArraySensorFunctionTypeState(passiveSensor.Parent);
                UpdateInstance(passiveSensor, activeSensor);

                _controller = new Controller(SystemContext);
                _controller.Init(activeTemp, activeSensor);
                _controller.Start();
            }
        }

        private void UpdateInstance(BaseObjectState passive, BaseObjectState active)
        {
            active.Create(SystemContext, passive);
            passive.Parent?.ReplaceChild(SystemContext, active);
            AddPredefinedNode(SystemContext, active);
        }

        private void ImportXml(IDictionary<NodeId, IList<IReference>> externalReferences, string resourcePath)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
            var nodeSet = UANodeSet.Read(stream);
            foreach (var nameSpace in nodeSet.NamespaceUris)
            {
                SystemContext.NamespaceUris.GetIndexOrAppend(nameSpace);
            }

            var predefinedNodes = new NodeStateCollection();
            nodeSet.Import(SystemContext, predefinedNodes);
            
            var toImportNodes = new List<NodeState>();
            foreach (var node in predefinedNodes)
            {
                // The LADS node set is not ordered :(
                if (node is BaseTypeState state && state.SuperTypeId != null &&
                    node.NodeId.NamespaceIndex == state.SuperTypeId.NamespaceIndex &&
                    !PredefinedNodes.ContainsKey(state.SuperTypeId))
                {
                    toImportNodes.Add(node);
                }
                else
                {
                    AddPredefinedNode(SystemContext, node);
                }
            }

            foreach (var node in toImportNodes)
            {
                AddPredefinedNode(SystemContext, node);
            }

            // Ensure the reverse references exist.
            AddReverseReferences(externalReferences);
        }

        protected override void Dispose(bool disposing)
        {
            _controller.Stop();
            base.Dispose(disposing);
        }
    }
}
