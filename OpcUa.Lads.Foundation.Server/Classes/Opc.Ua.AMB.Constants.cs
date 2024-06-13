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

namespace Opc.Ua.AMB
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint MaintenanceMethodEnum = 3004;

        /// <remarks />
        public const uint NameNodeIdDataType = 3003;

        /// <remarks />
        public const uint RootCauseDataType = 3002;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint DocumentationLinksType_AddLink = 7004;

        /// <remarks />
        public const uint DocumentationLinksType_RemoveLink = 7005;

        /// <remarks />
        public const uint Assets_FindAlias = 7001;

        /// <remarks />
        public const uint AssetsByAssetId_FindAlias = 7003;

        /// <remarks />
        public const uint AssetsByProductInstanceUri_FindAlias = 7002;

        /// <remarks />
        public const string DocumentationLinksType_AddLinkMethodType = "";

        /// <remarks />
        public const string DocumentationLinksType_RemoveLinkMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint IMaintenanceEventType_MaintenanceState = 5014;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_Executing = 5007;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_Finished = 5008;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_FromExecutingToFinished = 5010;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_FromFinishedToPlanned = 5011;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_FromPlannedToExecuting = 5009;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_Planned = 5006;

        /// <remarks />
        public const uint Assets = 5002;

        /// <remarks />
        public const uint AssetsByAssetId = 5004;

        /// <remarks />
        public const uint AssetsByProductInstanceUri = 5003;

        /// <remarks />
        public const uint HierarchicalLocations = 5021;

        /// <remarks />
        public const uint OperationalLocations = 5022;

        /// <remarks />
        public const uint RootCauseDataType_Encoding_DefaultBinary = 5001;

        /// <remarks />
        public const uint RootCauseDataType_Encoding_DefaultXml = 5005;

        /// <remarks />
        public const uint NameNodeIdDataType_Encoding_DefaultBinary = 5012;

        /// <remarks />
        public const uint NameNodeIdDataType_Encoding_DefaultXml = 5013;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint CalibrationDueConditionClassType = 1005;

        /// <remarks />
        public const uint ExternalCheckConditionClassType = 1015;

        /// <remarks />
        public const uint FlashUpdateInProgressConditionClassType = 1007;

        /// <remarks />
        public const uint ImprovementConditionClassType = 1018;

        /// <remarks />
        public const uint InspectionConditionClassType = 1014;

        /// <remarks />
        public const uint RepairConditionClassType = 1017;

        /// <remarks />
        public const uint ServicingConditionClassType = 1016;

        /// <remarks />
        public const uint BadConfigurationConditionClassType = 1008;

        /// <remarks />
        public const uint ConnectionFailureConditionClassType = 1003;

        /// <remarks />
        public const uint FlashUpdateFailedConditionClassType = 1019;

        /// <remarks />
        public const uint OutOfResourcesConditionClassType = 1009;

        /// <remarks />
        public const uint OutOfMemoryConditionClassType = 1010;

        /// <remarks />
        public const uint OverTemperatureConditionClassType = 1004;

        /// <remarks />
        public const uint SelfTestFailureConditionClassType = 1006;

        /// <remarks />
        public const uint IMaintenanceEventType = 1012;

        /// <remarks />
        public const uint IRootCauseIndicationType = 1002;

        /// <remarks />
        public const uint DocumentationLinksType = 1011;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType = 1013;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <remarks />
        public const uint Contains = 4002;

        /// <remarks />
        public const uint HierarchicalContains = 4003;

        /// <remarks />
        public const uint OperationalContains = 4004;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint MaintenanceMethodEnum_EnumValues = 6029;

        /// <remarks />
        public const uint IMaintenanceEventType_ConfigurationChanged = 6042;

        /// <remarks />
        public const uint IMaintenanceEventType_EstimatedDowntime = 6036;

        /// <remarks />
        public const uint IMaintenanceEventType_MaintenanceMethod = 6041;

        /// <remarks />
        public const uint IMaintenanceEventType_MaintenanceState_CurrentState = 6033;

        /// <remarks />
        public const uint IMaintenanceEventType_MaintenanceState_CurrentState_Id = 6034;

        /// <remarks />
        public const uint IMaintenanceEventType_MaintenanceSupplier = 6037;

        /// <remarks />
        public const uint IMaintenanceEventType_PartsOfAssetReplaced = 6039;

        /// <remarks />
        public const uint IMaintenanceEventType_PartsOfAssetServiced = 6040;

        /// <remarks />
        public const uint IMaintenanceEventType_PlannedDate = 6035;

        /// <remarks />
        public const uint IMaintenanceEventType_QualificationOfPersonnel = 6038;

        /// <remarks />
        public const uint IRootCauseIndicationType_PotentialRootCauses = 6015;

        /// <remarks />
        public const uint DocumentationLinksType_Link = 6017;

        /// <remarks />
        public const uint DocumentationLinksType_AddLink_InputArguments = 6018;

        /// <remarks />
        public const uint DocumentationLinksType_AddLink_OutputArguments = 6019;

        /// <remarks />
        public const uint DocumentationLinksType_DefaultInstanceBrowseName = 6016;

        /// <remarks />
        public const uint DocumentationLinksType_RemoveLink_InputArguments = 6020;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_Executing_StateNumber = 6022;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_Finished_StateNumber = 6023;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_FromExecutingToFinished_TransitionNumber = 6025;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_FromFinishedToPlanned_TransitionNumber = 6026;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_FromPlannedToExecuting_TransitionNumber = 6024;

        /// <remarks />
        public const uint MaintenanceEventStateMachineType_Planned_StateNumber = 6021;

        /// <remarks />
        public const uint Assets_FindAlias_InputArguments = 6001;

        /// <remarks />
        public const uint Assets_FindAlias_OutputArguments = 6002;

        /// <remarks />
        public const uint AssetsByAssetId_FindAlias_InputArguments = 6006;

        /// <remarks />
        public const uint AssetsByAssetId_FindAlias_OutputArguments = 6007;

        /// <remarks />
        public const uint AssetsByProductInstanceUri_FindAlias_InputArguments = 6003;

        /// <remarks />
        public const uint AssetsByProductInstanceUri_FindAlias_OutputArguments = 6004;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceMethodEnum = new ExpandedNodeId(Opc.Ua.AMB.DataTypes.MaintenanceMethodEnum, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId NameNodeIdDataType = new ExpandedNodeId(Opc.Ua.AMB.DataTypes.NameNodeIdDataType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId RootCauseDataType = new ExpandedNodeId(Opc.Ua.AMB.DataTypes.RootCauseDataType, Opc.Ua.AMB.Namespaces.AMB);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_AddLink = new ExpandedNodeId(Opc.Ua.AMB.Methods.DocumentationLinksType_AddLink, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_RemoveLink = new ExpandedNodeId(Opc.Ua.AMB.Methods.DocumentationLinksType_RemoveLink, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId Assets_FindAlias = new ExpandedNodeId(Opc.Ua.AMB.Methods.Assets_FindAlias, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByAssetId_FindAlias = new ExpandedNodeId(Opc.Ua.AMB.Methods.AssetsByAssetId_FindAlias, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByProductInstanceUri_FindAlias = new ExpandedNodeId(Opc.Ua.AMB.Methods.AssetsByProductInstanceUri_FindAlias, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_AddLinkMethodType = new ExpandedNodeId(Opc.Ua.AMB.Methods.DocumentationLinksType_AddLinkMethodType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_RemoveLinkMethodType = new ExpandedNodeId(Opc.Ua.AMB.Methods.DocumentationLinksType_RemoveLinkMethodType, Opc.Ua.AMB.Namespaces.AMB);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_MaintenanceState = new ExpandedNodeId(Opc.Ua.AMB.Objects.IMaintenanceEventType_MaintenanceState, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_Executing = new ExpandedNodeId(Opc.Ua.AMB.Objects.MaintenanceEventStateMachineType_Executing, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_Finished = new ExpandedNodeId(Opc.Ua.AMB.Objects.MaintenanceEventStateMachineType_Finished, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_FromExecutingToFinished = new ExpandedNodeId(Opc.Ua.AMB.Objects.MaintenanceEventStateMachineType_FromExecutingToFinished, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_FromFinishedToPlanned = new ExpandedNodeId(Opc.Ua.AMB.Objects.MaintenanceEventStateMachineType_FromFinishedToPlanned, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_FromPlannedToExecuting = new ExpandedNodeId(Opc.Ua.AMB.Objects.MaintenanceEventStateMachineType_FromPlannedToExecuting, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_Planned = new ExpandedNodeId(Opc.Ua.AMB.Objects.MaintenanceEventStateMachineType_Planned, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId Assets = new ExpandedNodeId(Opc.Ua.AMB.Objects.Assets, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByAssetId = new ExpandedNodeId(Opc.Ua.AMB.Objects.AssetsByAssetId, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByProductInstanceUri = new ExpandedNodeId(Opc.Ua.AMB.Objects.AssetsByProductInstanceUri, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId HierarchicalLocations = new ExpandedNodeId(Opc.Ua.AMB.Objects.HierarchicalLocations, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId OperationalLocations = new ExpandedNodeId(Opc.Ua.AMB.Objects.OperationalLocations, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId RootCauseDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AMB.Objects.RootCauseDataType_Encoding_DefaultBinary, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId RootCauseDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AMB.Objects.RootCauseDataType_Encoding_DefaultXml, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId NameNodeIdDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.AMB.Objects.NameNodeIdDataType_Encoding_DefaultBinary, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId NameNodeIdDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.AMB.Objects.NameNodeIdDataType_Encoding_DefaultXml, Opc.Ua.AMB.Namespaces.AMB);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId CalibrationDueConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.CalibrationDueConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId ExternalCheckConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.ExternalCheckConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId FlashUpdateInProgressConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.FlashUpdateInProgressConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId ImprovementConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.ImprovementConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId InspectionConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.InspectionConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId RepairConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.RepairConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId ServicingConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.ServicingConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId BadConfigurationConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.BadConfigurationConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionFailureConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.ConnectionFailureConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId FlashUpdateFailedConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.FlashUpdateFailedConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId OutOfResourcesConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.OutOfResourcesConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId OutOfMemoryConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.OutOfMemoryConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId OverTemperatureConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.OverTemperatureConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId SelfTestFailureConditionClassType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.SelfTestFailureConditionClassType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.IMaintenanceEventType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IRootCauseIndicationType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.IRootCauseIndicationType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.DocumentationLinksType, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType = new ExpandedNodeId(Opc.Ua.AMB.ObjectTypes.MaintenanceEventStateMachineType, Opc.Ua.AMB.Namespaces.AMB);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Contains = new ExpandedNodeId(Opc.Ua.AMB.ReferenceTypes.Contains, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId HierarchicalContains = new ExpandedNodeId(Opc.Ua.AMB.ReferenceTypes.HierarchicalContains, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId OperationalContains = new ExpandedNodeId(Opc.Ua.AMB.ReferenceTypes.OperationalContains, Opc.Ua.AMB.Namespaces.AMB);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceMethodEnum_EnumValues = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceMethodEnum_EnumValues, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_ConfigurationChanged = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_ConfigurationChanged, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_EstimatedDowntime = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_EstimatedDowntime, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_MaintenanceMethod = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_MaintenanceMethod, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_MaintenanceState_CurrentState = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_MaintenanceState_CurrentState, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_MaintenanceState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_MaintenanceState_CurrentState_Id, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_MaintenanceSupplier = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_MaintenanceSupplier, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_PartsOfAssetReplaced = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_PartsOfAssetReplaced, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_PartsOfAssetServiced = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_PartsOfAssetServiced, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_PlannedDate = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_PlannedDate, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IMaintenanceEventType_QualificationOfPersonnel = new ExpandedNodeId(Opc.Ua.AMB.Variables.IMaintenanceEventType_QualificationOfPersonnel, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId IRootCauseIndicationType_PotentialRootCauses = new ExpandedNodeId(Opc.Ua.AMB.Variables.IRootCauseIndicationType_PotentialRootCauses, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_Link = new ExpandedNodeId(Opc.Ua.AMB.Variables.DocumentationLinksType_Link, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_AddLink_InputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.DocumentationLinksType_AddLink_InputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_AddLink_OutputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.DocumentationLinksType_AddLink_OutputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.AMB.Variables.DocumentationLinksType_DefaultInstanceBrowseName, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId DocumentationLinksType_RemoveLink_InputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.DocumentationLinksType_RemoveLink_InputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_Executing_StateNumber = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceEventStateMachineType_Executing_StateNumber, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_Finished_StateNumber = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceEventStateMachineType_Finished_StateNumber, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_FromExecutingToFinished_TransitionNumber = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceEventStateMachineType_FromExecutingToFinished_TransitionNumber, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_FromFinishedToPlanned_TransitionNumber = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceEventStateMachineType_FromFinishedToPlanned_TransitionNumber, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_FromPlannedToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceEventStateMachineType_FromPlannedToExecuting_TransitionNumber, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceEventStateMachineType_Planned_StateNumber = new ExpandedNodeId(Opc.Ua.AMB.Variables.MaintenanceEventStateMachineType_Planned_StateNumber, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId Assets_FindAlias_InputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.Assets_FindAlias_InputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId Assets_FindAlias_OutputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.Assets_FindAlias_OutputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByAssetId_FindAlias_InputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.AssetsByAssetId_FindAlias_InputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByAssetId_FindAlias_OutputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.AssetsByAssetId_FindAlias_OutputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByProductInstanceUri_FindAlias_InputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.AssetsByProductInstanceUri_FindAlias_InputArguments, Opc.Ua.AMB.Namespaces.AMB);

        /// <remarks />
        public static readonly ExpandedNodeId AssetsByProductInstanceUri_FindAlias_OutputArguments = new ExpandedNodeId(Opc.Ua.AMB.Variables.AssetsByProductInstanceUri_FindAlias_OutputArguments, Opc.Ua.AMB.Namespaces.AMB);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AddLink = "AddLink";

        /// <remarks />
        public const string AddLinkMethodType = "AddLinkMethodType";

        /// <remarks />
        public const string Assets = "Assets";

        /// <remarks />
        public const string AssetsByAssetId = "AssetsByAssetId";

        /// <remarks />
        public const string AssetsByProductInstanceUri = "AssetsByProductInstanceUri";

        /// <remarks />
        public const string BadConfigurationConditionClassType = "BadConfigurationConditionClassType";

        /// <remarks />
        public const string CalibrationDueConditionClassType = "CalibrationDueConditionClassType";

        /// <remarks />
        public const string ConfigurationChanged = "ConfigurationChanged";

        /// <remarks />
        public const string ConnectionFailureConditionClassType = "ConnectionFailureConditionClassType";

        /// <remarks />
        public const string Contains = "Contains";

        /// <remarks />
        public const string DocumentationLinks = "DocumentationLinks";

        /// <remarks />
        public const string DocumentationLinksType = "DocumentationLinksType";

        /// <remarks />
        public const string EstimatedDowntime = "EstimatedDowntime";

        /// <remarks />
        public const string Executing = "Executing";

        /// <remarks />
        public const string ExternalCheckConditionClassType = "ExternalCheckConditionClassType";

        /// <remarks />
        public const string Finished = "Finished";

        /// <remarks />
        public const string FlashUpdateFailedConditionClassType = "FlashUpdateFailedConditionClassType";

        /// <remarks />
        public const string FlashUpdateInProgressConditionClassType = "FlashUpdateInProgressConditionClassType";

        /// <remarks />
        public const string FromExecutingToFinished = "FromExecutingToFinished";

        /// <remarks />
        public const string FromFinishedToPlanned = "FromFinishedToPlanned";

        /// <remarks />
        public const string FromPlannedToExecuting = "FromPlannedToExecuting";

        /// <remarks />
        public const string HierarchicalContains = "HierarchicalContains";

        /// <remarks />
        public const string HierarchicalLocations = "HierarchicalLocations";

        /// <remarks />
        public const string IMaintenanceEventType = "IMaintenanceEventType";

        /// <remarks />
        public const string ImprovementConditionClassType = "ImprovementConditionClassType";

        /// <remarks />
        public const string InspectionConditionClassType = "InspectionConditionClassType";

        /// <remarks />
        public const string IRootCauseIndicationType = "IRootCauseIndicationType";

        /// <remarks />
        public const string Link = "<Link>";

        /// <remarks />
        public const string MaintenanceEventStateMachineType = "MaintenanceEventStateMachineType";

        /// <remarks />
        public const string MaintenanceMethod = "MaintenanceMethod";

        /// <remarks />
        public const string MaintenanceMethodEnum = "MaintenanceMethodEnum";

        /// <remarks />
        public const string MaintenanceState = "MaintenanceState";

        /// <remarks />
        public const string MaintenanceSupplier = "MaintenanceSupplier";

        /// <remarks />
        public const string NameNodeIdDataType = "NameNodeIdDataType";

        /// <remarks />
        public const string OperationalContains = "OperationalContains";

        /// <remarks />
        public const string OperationalLocations = "OperationalLocations";

        /// <remarks />
        public const string OutOfMemoryConditionClassType = "OutOfMemoryConditionClassType";

        /// <remarks />
        public const string OutOfResourcesConditionClassType = "OutOfResourcesConditionClassType";

        /// <remarks />
        public const string OverTemperatureConditionClassType = "OverTemperatureConditionClassType";

        /// <remarks />
        public const string PartsOfAssetReplaced = "PartsOfAssetReplaced";

        /// <remarks />
        public const string PartsOfAssetServiced = "PartsOfAssetServiced";

        /// <remarks />
        public const string Planned = "Planned";

        /// <remarks />
        public const string PlannedDate = "PlannedDate";

        /// <remarks />
        public const string PotentialRootCauses = "PotentialRootCauses";

        /// <remarks />
        public const string QualificationOfPersonnel = "QualificationOfPersonnel";

        /// <remarks />
        public const string RemoveLink = "RemoveLink";

        /// <remarks />
        public const string RemoveLinkMethodType = "RemoveLinkMethodType";

        /// <remarks />
        public const string RepairConditionClassType = "RepairConditionClassType";

        /// <remarks />
        public const string RootCauseDataType = "RootCauseDataType";

        /// <remarks />
        public const string SelfTestFailureConditionClassType = "SelfTestFailureConditionClassType";

        /// <remarks />
        public const string ServicingConditionClassType = "ServicingConditionClassType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the AMB namespace (.NET code namespace is 'Opc.Ua.AMB').
        /// </summary>
        public const string AMB = "http://opcfoundation.org/UA/AMB/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";
    }
    #endregion
}