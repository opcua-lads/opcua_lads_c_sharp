/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;

namespace Opc.Ua.Machinery
{
    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MachineComponentsType_Component = 5002;

        /// <remarks />
        public const uint MachineComponentsType_Component_Identification = 5003;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_Executing = 5006;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToExecuting = 5023;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToNotAvailable = 5020;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToNotExecuting = 5022;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToOutOfService = 5021;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToExecuting = 5010;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable = 5011;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting = 5009;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToOutOfService = 5008;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToExecuting = 5018;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable = 5016;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting = 5019;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToOutOfService = 5017;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToExecuting = 5014;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable = 5012;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting = 5013;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService = 5015;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_NotAvailable = 5005;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_NotExecuting = 5007;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_OutOfService = 5004;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance = 5035;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToNone = 5032;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToProcessing = 5034;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToSetup = 5033;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToMaintenance = 5028;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToNone = 5031;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToProcessing = 5030;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToSetup = 5029;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToMaintenance = 5041;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToNone = 5040;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToProcessing = 5043;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToSetup = 5042;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToMaintenance = 5037;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToNone = 5036;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToProcessing = 5038;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToSetup = 5039;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_Maintenance = 5025;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_None = 5024;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_Processing = 5026;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_Setup = 5027;

        /// <remarks />
        public const uint Machines = 1001;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint IMachineTagNameplateType = 1011;

        /// <remarks />
        public const uint IMachineryItemVendorNameplateType = 1003;

        /// <remarks />
        public const uint IMachineVendorNameplateType = 1010;

        /// <remarks />
        public const uint MachineryItemIdentificationType = 1004;

        /// <remarks />
        public const uint MachineIdentificationType = 1012;

        /// <remarks />
        public const uint MachineryComponentIdentificationType = 1005;

        /// <remarks />
        public const uint MachineryOperationCounterType = 1009;

        /// <remarks />
        public const uint MachineryLifetimeCounterType = 1015;

        /// <remarks />
        public const uint MachineComponentsType = 1006;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType = 1002;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType = 1008;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint IMachineTagNameplateType_Location = 6028;

        /// <remarks />
        public const uint IMachineryItemVendorNameplateType_Manufacturer = 6022;

        /// <remarks />
        public const uint IMachineryItemVendorNameplateType_SerialNumber = 6024;

        /// <remarks />
        public const uint IMachineryItemVendorNameplateType_InitialOperationDate = 6027;

        /// <remarks />
        public const uint IMachineryItemVendorNameplateType_MonthOfConstruction = 6026;

        /// <remarks />
        public const uint IMachineryItemVendorNameplateType_YearOfConstruction = 6025;

        /// <remarks />
        public const uint IMachineVendorNameplateType_ProductInstanceUri = 6023;

        /// <remarks />
        public const uint MachineryItemIdentificationType_AssetId = 6013;

        /// <remarks />
        public const uint MachineryItemIdentificationType_ComponentName = 6014;

        /// <remarks />
        public const uint MachineryItemIdentificationType_DefaultInstanceBrowseName = 6088;

        /// <remarks />
        public const uint MachineryItemIdentificationType_DeviceClass = 6012;

        /// <remarks />
        public const uint MachineryItemIdentificationType_HardwareRevision = 6010;

        /// <remarks />
        public const uint MachineryItemIdentificationType_InitialOperationDate = 6006;

        /// <remarks />
        public const uint MachineryItemIdentificationType_Manufacturer = 6002;

        /// <remarks />
        public const uint MachineryItemIdentificationType_ManufacturerUri = 6007;

        /// <remarks />
        public const uint MachineryItemIdentificationType_Model = 6008;

        /// <remarks />
        public const uint MachineryItemIdentificationType_MonthOfConstruction = 6005;

        /// <remarks />
        public const uint MachineryItemIdentificationType_ProductCode = 6009;

        /// <remarks />
        public const uint MachineryItemIdentificationType_ProductInstanceUri = 6001;

        /// <remarks />
        public const uint MachineryItemIdentificationType_SerialNumber = 6003;

        /// <remarks />
        public const uint MachineryItemIdentificationType_SoftwareRevision = 6011;

        /// <remarks />
        public const uint MachineryItemIdentificationType_YearOfConstruction = 6004;

        /// <remarks />
        public const uint MachineIdentificationType_DefaultInstanceBrowseName = 6030;

        /// <remarks />
        public const uint MachineIdentificationType_ProductInstanceUri = 6015;

        /// <remarks />
        public const uint MachineIdentificationType_Location = 6029;

        /// <remarks />
        public const uint MachineryComponentIdentificationType_DefaultInstanceBrowseName = 6016;

        /// <remarks />
        public const uint MachineryComponentIdentificationType_DeviceRevision = 6017;

        /// <remarks />
        public const uint MachineryOperationCounterType_DefaultInstanceBrowseName = 6082;

        /// <remarks />
        public const uint MachineryOperationCounterType_OperationCycleCounter = 6081;

        /// <remarks />
        public const uint MachineryOperationCounterType_OperationDuration = 6080;

        /// <remarks />
        public const uint MachineryOperationCounterType_PowerOnDuration = 6079;

        /// <remarks />
        public const uint MachineryLifetimeCounterType_LifetimeVariable = 6083;

        /// <remarks />
        public const uint MachineryLifetimeCounterType_LifetimeVariable_EngineeringUnits = 6086;

        /// <remarks />
        public const uint MachineryLifetimeCounterType_LifetimeVariable_StartValue = 6085;

        /// <remarks />
        public const uint MachineryLifetimeCounterType_LifetimeVariable_LimitValue = 6084;

        /// <remarks />
        public const uint MachineryLifetimeCounterType_DefaultInstanceBrowseName = 6087;

        /// <remarks />
        public const uint MachineComponentsType_Component_Identification_Manufacturer = 6019;

        /// <remarks />
        public const uint MachineComponentsType_Component_Identification_SerialNumber = 6020;

        /// <remarks />
        public const uint MachineComponentsType_DefaultInstanceBrowseName = 6018;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_DefaultInstanceBrowseName = 6021;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_Executing_StateNumber = 6040;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToExecuting_TransitionNumber = 6057;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToNotAvailable_TransitionNumber = 6054;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToNotExecuting_TransitionNumber = 6056;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromExecutingToOutOfService_TransitionNumber = 6055;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToExecuting_TransitionNumber = 6044;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable_TransitionNumber = 6045;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting_TransitionNumber = 6043;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotAvailableToOutOfService_TransitionNumber = 6042;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToExecuting_TransitionNumber = 6052;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable_TransitionNumber = 6050;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting_TransitionNumber = 6053;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromNotExecutingToOutOfService_TransitionNumber = 6051;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToExecuting_TransitionNumber = 6048;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable_TransitionNumber = 6046;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting_TransitionNumber = 6047;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService_TransitionNumber = 6049;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_NotAvailable_StateNumber = 6039;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_NotExecuting_StateNumber = 6041;

        /// <remarks />
        public const uint MachineryItemState_StateMachineType_OutOfService_StateNumber = 6038;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_DefaultInstanceBrowseName = 6058;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber = 6070;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber = 6067;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber = 6069;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber = 6068;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber = 6063;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToNone_TransitionNumber = 6066;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber = 6065;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromNoneToSetup_TransitionNumber = 6064;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber = 6076;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToNone_TransitionNumber = 6075;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber = 6078;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber = 6077;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber = 6072;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToNone_TransitionNumber = 6071;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber = 6073;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_FromSetupToSetup_TransitionNumber = 6074;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_Maintenance_StateNumber = 6060;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_None_StateNumber = 6059;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_Processing_StateNumber = 6061;

        /// <remarks />
        public const uint MachineryOperationModeStateMachineType_Setup_StateNumber = 6062;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MachineComponentsType_Component = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineComponentsType_Component, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineComponentsType_Component_Identification = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineComponentsType_Component_Identification, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_Executing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_Executing, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToNotAvailable, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToNotExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToOutOfService, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToOutOfService, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToOutOfService, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_NotAvailable, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_NotExecuting, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_OutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_OutOfService, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToNone, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToProcessing, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToSetup, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToMaintenance, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToNone, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToProcessing, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToSetup, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToMaintenance, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToNone, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToProcessing, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToSetup, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToMaintenance, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToNone, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToProcessing, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToSetup, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Maintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_Maintenance, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_None = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_None, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Processing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_Processing, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Setup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_Setup, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId Machines = new ExpandedNodeId(Opc.Ua.Machinery.Objects.Machines, Opc.Ua.Machinery.Namespaces.MBBB);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IMachineTagNameplateType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineTagNameplateType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineryItemVendorNameplateType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineVendorNameplateType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineVendorNameplateType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryItemIdentificationType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineIdentificationType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineIdentificationType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryComponentIdentificationType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryComponentIdentificationType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationCounterType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryOperationCounterType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryLifetimeCounterType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryLifetimeCounterType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineComponentsType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineComponentsType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryItemState_StateMachineType, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryOperationModeStateMachineType, Opc.Ua.Machinery.Namespaces.MBBB);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IMachineTagNameplateType_Location = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineTagNameplateType_Location, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_Manufacturer = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_Manufacturer, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_SerialNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_InitialOperationDate = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_InitialOperationDate, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_MonthOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_MonthOfConstruction, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_YearOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_YearOfConstruction, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId IMachineVendorNameplateType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineVendorNameplateType_ProductInstanceUri, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_AssetId = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_AssetId, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_ComponentName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ComponentName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_DeviceClass = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_DeviceClass, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_HardwareRevision = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_HardwareRevision, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_InitialOperationDate = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_InitialOperationDate, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_Manufacturer = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_Manufacturer, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ManufacturerUri, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_Model = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_Model, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_MonthOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_MonthOfConstruction, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_ProductCode = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ProductCode, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ProductInstanceUri, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_SerialNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_SoftwareRevision, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemIdentificationType_YearOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_YearOfConstruction, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineIdentificationType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineIdentificationType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineIdentificationType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineIdentificationType_ProductInstanceUri, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineIdentificationType_Location = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineIdentificationType_Location, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryComponentIdentificationType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryComponentIdentificationType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryComponentIdentificationType_DeviceRevision = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryComponentIdentificationType_DeviceRevision, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationCounterType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationCounterType_OperationCycleCounter = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_OperationCycleCounter, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationCounterType_OperationDuration = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_OperationDuration, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationCounterType_PowerOnDuration = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_PowerOnDuration, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_EngineeringUnits = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_EngineeringUnits, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_StartValue = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_StartValue, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_LimitValue = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_LimitValue, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryLifetimeCounterType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineComponentsType_Component_Identification_Manufacturer = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineComponentsType_Component_Identification_Manufacturer, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineComponentsType_Component_Identification_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineComponentsType_Component_Identification_SerialNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineComponentsType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineComponentsType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_Executing_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_Executing_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotAvailable_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_NotAvailable_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotExecuting_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_NotExecuting_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_OutOfService_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_OutOfService_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Maintenance_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_Maintenance_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_None_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_None_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Processing_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_Processing_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);

        /// <remarks />
        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Setup_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_Setup_StateNumber, Opc.Ua.Machinery.Namespaces.MBBB);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Component = "<Component>";

        /// <remarks />
        public const string Components = "Components";

        /// <remarks />
        public const string Executing = "Executing";

        /// <remarks />
        public const string FromExecutingToExecuting = "FromExecutingToExecuting";

        /// <remarks />
        public const string FromExecutingToNotAvailable = "FromExecutingToNotAvailable";

        /// <remarks />
        public const string FromExecutingToNotExecuting = "FromExecutingToNotExecuting";

        /// <remarks />
        public const string FromExecutingToOutOfService = "FromExecutingToOutOfService";

        /// <remarks />
        public const string FromMaintenanceToMaintenance = "FromMaintenanceToMaintenance";

        /// <remarks />
        public const string FromMaintenanceToNone = "FromMaintenanceToNone";

        /// <remarks />
        public const string FromMaintenanceToProcessing = "FromMaintenanceToProcessing";

        /// <remarks />
        public const string FromMaintenanceToSetup = "FromMaintenanceToSetup";

        /// <remarks />
        public const string FromNoneToMaintenance = "FromNoneToMaintenance";

        /// <remarks />
        public const string FromNoneToNone = "FromNoneToNone";

        /// <remarks />
        public const string FromNoneToProcessing = "FromNoneToProcessing";

        /// <remarks />
        public const string FromNoneToSetup = "FromNoneToSetup";

        /// <remarks />
        public const string FromNotAvailableToExecuting = "FromNotAvailableToExecuting";

        /// <remarks />
        public const string FromNotAvailableToNotAvailable = "FromNotAvailableToNotAvailable";

        /// <remarks />
        public const string FromNotAvailableToNotExecuting = "FromNotAvailableToNotExecuting";

        /// <remarks />
        public const string FromNotAvailableToOutOfService = "FromNotAvailableToOutOfService";

        /// <remarks />
        public const string FromNotExecutingToExecuting = "FromNotExecutingToExecuting";

        /// <remarks />
        public const string FromNotExecutingToNotAvailable = "FromNotExecutingToNotAvailable";

        /// <remarks />
        public const string FromNotExecutingToNotExecuting = "FromNotExecutingToNotExecuting";

        /// <remarks />
        public const string FromNotExecutingToOutOfService = "FromNotExecutingToOutOfService";

        /// <remarks />
        public const string FromOutOfServiceToExecuting = "FromOutOfServiceToExecuting";

        /// <remarks />
        public const string FromOutOfServiceToNotAvailable = "FromOutOfServiceToNotAvailable";

        /// <remarks />
        public const string FromOutOfServiceToNotExecuting = "FromOutOfServiceToNotExecuting";

        /// <remarks />
        public const string FromOutOfServiceToOutOfService = "FromOutOfServiceToOutOfService";

        /// <remarks />
        public const string FromProcessingToMaintenance = "FromProcessingToMaintenance";

        /// <remarks />
        public const string FromProcessingToNone = "FromProcessingToNone";

        /// <remarks />
        public const string FromProcessingToProcessing = "FromProcessingToProcessing";

        /// <remarks />
        public const string FromProcessingToSetup = "FromProcessingToSetup";

        /// <remarks />
        public const string FromSetupToMaintenance = "FromSetupToMaintenance";

        /// <remarks />
        public const string FromSetupToNone = "FromSetupToNone";

        /// <remarks />
        public const string FromSetupToProcessing = "FromSetupToProcessing";

        /// <remarks />
        public const string FromSetupToSetup = "FromSetupToSetup";

        /// <remarks />
        public const string Identification = "Identification";

        /// <remarks />
        public const string IMachineryItemVendorNameplateType = "IMachineryItemVendorNameplateType";

        /// <remarks />
        public const string IMachineTagNameplateType = "IMachineTagNameplateType";

        /// <remarks />
        public const string IMachineVendorNameplateType = "IMachineVendorNameplateType";

        /// <remarks />
        public const string InitialOperationDate = "InitialOperationDate";

        /// <remarks />
        public const string LifetimeCounters = "LifetimeCounters";

        /// <remarks />
        public const string LifetimeVariable = "<LifetimeVariable>";

        /// <remarks />
        public const string Location = "Location";

        /// <remarks />
        public const string MachineComponentsType = "MachineComponentsType";

        /// <remarks />
        public const string MachineIdentificationType = "MachineIdentificationType";

        /// <remarks />
        public const string MachineryComponentIdentificationType = "MachineryComponentIdentificationType";

        /// <remarks />
        public const string MachineryItemIdentificationType = "MachineryItemIdentificationType";

        /// <remarks />
        public const string MachineryItemState = "MachineryItemState";

        /// <remarks />
        public const string MachineryItemState_StateMachineType = "MachineryItemState_StateMachineType";

        /// <remarks />
        public const string MachineryLifetimeCounterType = "MachineryLifetimeCounterType";

        /// <remarks />
        public const string MachineryOperationCounterType = "MachineryOperationCounterType";

        /// <remarks />
        public const string MachineryOperationMode = "MachineryOperationMode";

        /// <remarks />
        public const string MachineryOperationModeStateMachineType = "MachineryOperationModeStateMachineType";

        /// <remarks />
        public const string Machines = "Machines";

        /// <remarks />
        public const string Maintenance = "Maintenance";

        /// <remarks />
        public const string MonthOfConstruction = "MonthOfConstruction";

        /// <remarks />
        public const string None = "None";

        /// <remarks />
        public const string NotAvailable = "NotAvailable";

        /// <remarks />
        public const string NotExecuting = "NotExecuting";

        /// <remarks />
        public const string OperationCounters = "OperationCounters";

        /// <remarks />
        public const string OutOfService = "OutOfService";

        /// <remarks />
        public const string Processing = "Processing";

        /// <remarks />
        public const string Setup = "Setup";

        /// <remarks />
        public const string YearOfConstruction = "YearOfConstruction";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the MBBB namespace (.NET code namespace is 'Opc.Ua.Machinery').
        /// </summary>
        public const string MBBB = "http://opcfoundation.org/UA/Machinery/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";
    }
    #endregion
}