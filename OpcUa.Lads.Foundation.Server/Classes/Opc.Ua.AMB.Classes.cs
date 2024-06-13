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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.AMB
{
    #region CalibrationDueConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_CalibrationDueConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CalibrationDueConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public CalibrationDueConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.CalibrationDueConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKAAAAENh" +
           "bGlicmF0aW9uRHVlQ29uZGl0aW9uQ2xhc3NUeXBlSW5zdGFuY2UBAe0DAQHtA+0DAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ExternalCheckConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_ExternalCheckConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExternalCheckConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public ExternalCheckConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.ExternalCheckConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJwAAAEV4" +
           "dGVybmFsQ2hlY2tDb25kaXRpb25DbGFzc1R5cGVJbnN0YW5jZQEB9wMBAfcD9wMAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FlashUpdateInProgressConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_FlashUpdateInProgressConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlashUpdateInProgressConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public FlashUpdateInProgressConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.FlashUpdateInProgressConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEALwAAAEZs" +
           "YXNoVXBkYXRlSW5Qcm9ncmVzc0NvbmRpdGlvbkNsYXNzVHlwZUluc3RhbmNlAQHvAwEB7wPvAwAA////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ImprovementConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_ImprovementConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ImprovementConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public ImprovementConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.ImprovementConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJQAAAElt" +
           "cHJvdmVtZW50Q29uZGl0aW9uQ2xhc3NUeXBlSW5zdGFuY2UBAfoDAQH6A/oDAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region InspectionConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_InspectionConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InspectionConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public InspectionConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.InspectionConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJAAAAElu" +
           "c3BlY3Rpb25Db25kaXRpb25DbGFzc1R5cGVJbnN0YW5jZQEB9gMBAfYD9gMAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region RepairConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_RepairConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RepairConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public RepairConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.RepairConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIAAAAFJl" +
           "cGFpckNvbmRpdGlvbkNsYXNzVHlwZUluc3RhbmNlAQH5AwEB+QP5AwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ServicingConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_ServicingConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ServicingConditionClassTypeState : MaintenanceConditionClassState
    {
        #region Constructors
        /// <remarks />
        public ServicingConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.ServicingConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIwAAAFNl" +
           "cnZpY2luZ0NvbmRpdGlvbkNsYXNzVHlwZUluc3RhbmNlAQH4AwEB+AP4AwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BadConfigurationConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_BadConfigurationConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BadConfigurationConditionClassTypeState : SystemConditionClassState
    {
        #region Constructors
        /// <remarks />
        public BadConfigurationConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.BadConfigurationConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKgAAAEJh" +
           "ZENvbmZpZ3VyYXRpb25Db25kaXRpb25DbGFzc1R5cGVJbnN0YW5jZQEB8AMBAfAD8AMAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConnectionFailureConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_ConnectionFailureConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionFailureConditionClassTypeState : SystemConditionClassState
    {
        #region Constructors
        /// <remarks />
        public ConnectionFailureConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.ConnectionFailureConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKwAAAENv" +
           "bm5lY3Rpb25GYWlsdXJlQ29uZGl0aW9uQ2xhc3NUeXBlSW5zdGFuY2UBAesDAQHrA+sDAAD/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FlashUpdateFailedConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_FlashUpdateFailedConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlashUpdateFailedConditionClassTypeState : SystemConditionClassState
    {
        #region Constructors
        /// <remarks />
        public FlashUpdateFailedConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.FlashUpdateFailedConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKwAAAEZs" +
           "YXNoVXBkYXRlRmFpbGVkQ29uZGl0aW9uQ2xhc3NUeXBlSW5zdGFuY2UBAfsDAQH7A/sDAAD/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region OutOfResourcesConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_OutOfResourcesConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OutOfResourcesConditionClassTypeState : SystemConditionClassState
    {
        #region Constructors
        /// <remarks />
        public OutOfResourcesConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.OutOfResourcesConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKAAAAE91" +
           "dE9mUmVzb3VyY2VzQ29uZGl0aW9uQ2xhc3NUeXBlSW5zdGFuY2UBAfEDAQHxA/EDAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region OutOfMemoryConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_OutOfMemoryConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OutOfMemoryConditionClassTypeState : OutOfResourcesConditionClassTypeState
    {
        #region Constructors
        /// <remarks />
        public OutOfMemoryConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.OutOfMemoryConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJQAAAE91" +
           "dE9mTWVtb3J5Q29uZGl0aW9uQ2xhc3NUeXBlSW5zdGFuY2UBAfIDAQHyA/IDAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region OverTemperatureConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_OverTemperatureConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OverTemperatureConditionClassTypeState : SystemConditionClassState
    {
        #region Constructors
        /// <remarks />
        public OverTemperatureConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.OverTemperatureConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKQAAAE92" +
           "ZXJUZW1wZXJhdHVyZUNvbmRpdGlvbkNsYXNzVHlwZUluc3RhbmNlAQHsAwEB7APsAwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SelfTestFailureConditionClassTypeState Class
    #if (!OPCUA_EXCLUDE_SelfTestFailureConditionClassTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SelfTestFailureConditionClassTypeState : SystemConditionClassState
    {
        #region Constructors
        /// <remarks />
        public SelfTestFailureConditionClassTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.SelfTestFailureConditionClassType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKQAAAFNl" +
           "bGZUZXN0RmFpbHVyZUNvbmRpdGlvbkNsYXNzVHlwZUluc3RhbmNlAQHuAwEB7gPuAwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region IMaintenanceEventTypeState Class
    #if (!OPCUA_EXCLUDE_IMaintenanceEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IMaintenanceEventTypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IMaintenanceEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.IMaintenanceEventType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ConfigurationChanged != null)
            {
                ConfigurationChanged.Initialize(context, ConfigurationChanged_InitializationString);
            }

            if (EstimatedDowntime != null)
            {
                EstimatedDowntime.Initialize(context, EstimatedDowntime_InitializationString);
            }

            if (MaintenanceMethod != null)
            {
                MaintenanceMethod.Initialize(context, MaintenanceMethod_InitializationString);
            }

            if (MaintenanceSupplier != null)
            {
                MaintenanceSupplier.Initialize(context, MaintenanceSupplier_InitializationString);
            }

            if (PartsOfAssetReplaced != null)
            {
                PartsOfAssetReplaced.Initialize(context, PartsOfAssetReplaced_InitializationString);
            }

            if (PartsOfAssetServiced != null)
            {
                PartsOfAssetServiced.Initialize(context, PartsOfAssetServiced_InitializationString);
            }

            if (PlannedDate != null)
            {
                PlannedDate.Initialize(context, PlannedDate_InitializationString);
            }

            if (QualificationOfPersonnel != null)
            {
                QualificationOfPersonnel.Initialize(context, QualificationOfPersonnel_InitializationString);
            }
        }

        #region Initialization String
        private const string ConfigurationChanged_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEAFAAAAENv" +
           "bmZpZ3VyYXRpb25DaGFuZ2VkAQGaFwAuAESaFwAAAAH/////AwP/////AAAAAA==";

        private const string EstimatedDowntime_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEAEQAAAEVz" +
           "dGltYXRlZERvd250aW1lAQGUFwAuAESUFwAAAQAiAf////8DA/////8AAAAA";

        private const string MaintenanceMethod_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEAEQAAAE1h" +
           "aW50ZW5hbmNlTWV0aG9kAQGZFwAuAESZFwAAAQG8C/////8DA/////8AAAAA";

        private const string MaintenanceSupplier_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEAEwAAAE1h" +
           "aW50ZW5hbmNlU3VwcGxpZXIBAZUXAC4ARJUXAAABAbsL/////wMD/////wAAAAA=";

        private const string PartsOfAssetReplaced_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8XYIkKAgAAAAEAFAAAAFBh" +
           "cnRzT2ZBc3NldFJlcGxhY2VkAQGXFwAuAESXFwAAAQG7CwEAAAABAAAAAAAAAAMD/////wAAAAA=";

        private const string PartsOfAssetServiced_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8XYIkKAgAAAAEAFAAAAFBh" +
           "cnRzT2ZBc3NldFNlcnZpY2VkAQGYFwAuAESYFwAAAQG7CwEAAAABAAAAAAAAAAMD/////wAAAAA=";

        private const string PlannedDate_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEACwAAAFBs" +
           "YW5uZWREYXRlAQGTFwAuAESTFwAAAQAmAf////8DA/////8AAAAA";

        private const string QualificationOfPersonnel_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEAGAAAAFF1" +
           "YWxpZmljYXRpb25PZlBlcnNvbm5lbAEBlhcALgBElhcAAAEBuwv/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHQAAAElN" +
           "YWludGVuYW5jZUV2ZW50VHlwZUluc3RhbmNlAQH0AwEB9AP0AwAA/////wkAAAAVYIkKAgAAAAEAFAAA" +
           "AENvbmZpZ3VyYXRpb25DaGFuZ2VkAQGaFwAuAESaFwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAR" +
           "AAAARXN0aW1hdGVkRG93bnRpbWUBAZQXAC4ARJQXAAABACIB/////wMD/////wAAAAAVYIkKAgAAAAEA" +
           "EQAAAE1haW50ZW5hbmNlTWV0aG9kAQGZFwAuAESZFwAAAQG8C/////8DA/////8AAAAABGCACgEAAAAB" +
           "ABAAAABNYWludGVuYW5jZVN0YXRlAQGWEwAvAQH1A5YTAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3Vy" +
           "cmVudFN0YXRlAQGRFwAvAQDICpEXAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBkhcA" +
           "LgBEkhcAAAAR/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAE1haW50ZW5hbmNlU3VwcGxpZXIBAZUX" +
           "AC4ARJUXAAABAbsL/////wMD/////wAAAAAXYIkKAgAAAAEAFAAAAFBhcnRzT2ZBc3NldFJlcGxhY2Vk" +
           "AQGXFwAuAESXFwAAAQG7CwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAFAAAAFBhcnRzT2ZB" +
           "c3NldFNlcnZpY2VkAQGYFwAuAESYFwAAAQG7CwEAAAABAAAAAAAAAAMD/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAFBsYW5uZWREYXRlAQGTFwAuAESTFwAAAQAmAf////8DA/////8AAAAAFWCJCgIAAAABABgAAABR" +
           "dWFsaWZpY2F0aW9uT2ZQZXJzb25uZWwBAZYXAC4ARJYXAAABAbsL/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> ConfigurationChanged
        {
            get
            {
                return m_configurationChanged;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configurationChanged, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configurationChanged = value;
            }
        }

        /// <remarks />
        public PropertyState<double> EstimatedDowntime
        {
            get
            {
                return m_estimatedDowntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_estimatedDowntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_estimatedDowntime = value;
            }
        }

        /// <remarks />
        public PropertyState<MaintenanceMethodEnum> MaintenanceMethod
        {
            get
            {
                return m_maintenanceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenanceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenanceMethod = value;
            }
        }

        /// <remarks />
        public MaintenanceEventStateMachineTypeState MaintenanceState
        {
            get
            {
                return m_maintenanceState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenanceState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenanceState = value;
            }
        }

        /// <remarks />
        public PropertyState<NameNodeIdDataType> MaintenanceSupplier
        {
            get
            {
                return m_maintenanceSupplier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenanceSupplier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenanceSupplier = value;
            }
        }

        /// <remarks />
        public PropertyState<NameNodeIdDataType[]> PartsOfAssetReplaced
        {
            get
            {
                return m_partsOfAssetReplaced;
            }

            set
            {
                if (!Object.ReferenceEquals(m_partsOfAssetReplaced, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_partsOfAssetReplaced = value;
            }
        }

        /// <remarks />
        public PropertyState<NameNodeIdDataType[]> PartsOfAssetServiced
        {
            get
            {
                return m_partsOfAssetServiced;
            }

            set
            {
                if (!Object.ReferenceEquals(m_partsOfAssetServiced, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_partsOfAssetServiced = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> PlannedDate
        {
            get
            {
                return m_plannedDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_plannedDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_plannedDate = value;
            }
        }

        /// <remarks />
        public PropertyState<NameNodeIdDataType> QualificationOfPersonnel
        {
            get
            {
                return m_qualificationOfPersonnel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_qualificationOfPersonnel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_qualificationOfPersonnel = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_configurationChanged != null)
            {
                children.Add(m_configurationChanged);
            }

            if (m_estimatedDowntime != null)
            {
                children.Add(m_estimatedDowntime);
            }

            if (m_maintenanceMethod != null)
            {
                children.Add(m_maintenanceMethod);
            }

            if (m_maintenanceState != null)
            {
                children.Add(m_maintenanceState);
            }

            if (m_maintenanceSupplier != null)
            {
                children.Add(m_maintenanceSupplier);
            }

            if (m_partsOfAssetReplaced != null)
            {
                children.Add(m_partsOfAssetReplaced);
            }

            if (m_partsOfAssetServiced != null)
            {
                children.Add(m_partsOfAssetServiced);
            }

            if (m_plannedDate != null)
            {
                children.Add(m_plannedDate);
            }

            if (m_qualificationOfPersonnel != null)
            {
                children.Add(m_qualificationOfPersonnel);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AMB.BrowseNames.ConfigurationChanged:
                {
                    if (createOrReplace)
                    {
                        if (ConfigurationChanged == null)
                        {
                            if (replacement == null)
                            {
                                ConfigurationChanged = new PropertyState<bool>(this);
                            }
                            else
                            {
                                ConfigurationChanged = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = ConfigurationChanged;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.EstimatedDowntime:
                {
                    if (createOrReplace)
                    {
                        if (EstimatedDowntime == null)
                        {
                            if (replacement == null)
                            {
                                EstimatedDowntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                EstimatedDowntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = EstimatedDowntime;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.MaintenanceMethod:
                {
                    if (createOrReplace)
                    {
                        if (MaintenanceMethod == null)
                        {
                            if (replacement == null)
                            {
                                MaintenanceMethod = new PropertyState<MaintenanceMethodEnum>(this);
                            }
                            else
                            {
                                MaintenanceMethod = (PropertyState<MaintenanceMethodEnum>)replacement;
                            }
                        }
                    }

                    instance = MaintenanceMethod;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.MaintenanceState:
                {
                    if (createOrReplace)
                    {
                        if (MaintenanceState == null)
                        {
                            if (replacement == null)
                            {
                                MaintenanceState = new MaintenanceEventStateMachineTypeState(this);
                            }
                            else
                            {
                                MaintenanceState = (MaintenanceEventStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = MaintenanceState;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.MaintenanceSupplier:
                {
                    if (createOrReplace)
                    {
                        if (MaintenanceSupplier == null)
                        {
                            if (replacement == null)
                            {
                                MaintenanceSupplier = new PropertyState<NameNodeIdDataType>(this);
                            }
                            else
                            {
                                MaintenanceSupplier = (PropertyState<NameNodeIdDataType>)replacement;
                            }
                        }
                    }

                    instance = MaintenanceSupplier;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.PartsOfAssetReplaced:
                {
                    if (createOrReplace)
                    {
                        if (PartsOfAssetReplaced == null)
                        {
                            if (replacement == null)
                            {
                                PartsOfAssetReplaced = new PropertyState<NameNodeIdDataType[]>(this);
                            }
                            else
                            {
                                PartsOfAssetReplaced = (PropertyState<NameNodeIdDataType[]>)replacement;
                            }
                        }
                    }

                    instance = PartsOfAssetReplaced;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.PartsOfAssetServiced:
                {
                    if (createOrReplace)
                    {
                        if (PartsOfAssetServiced == null)
                        {
                            if (replacement == null)
                            {
                                PartsOfAssetServiced = new PropertyState<NameNodeIdDataType[]>(this);
                            }
                            else
                            {
                                PartsOfAssetServiced = (PropertyState<NameNodeIdDataType[]>)replacement;
                            }
                        }
                    }

                    instance = PartsOfAssetServiced;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.PlannedDate:
                {
                    if (createOrReplace)
                    {
                        if (PlannedDate == null)
                        {
                            if (replacement == null)
                            {
                                PlannedDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                PlannedDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = PlannedDate;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.QualificationOfPersonnel:
                {
                    if (createOrReplace)
                    {
                        if (QualificationOfPersonnel == null)
                        {
                            if (replacement == null)
                            {
                                QualificationOfPersonnel = new PropertyState<NameNodeIdDataType>(this);
                            }
                            else
                            {
                                QualificationOfPersonnel = (PropertyState<NameNodeIdDataType>)replacement;
                            }
                        }
                    }

                    instance = QualificationOfPersonnel;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<bool> m_configurationChanged;
        private PropertyState<double> m_estimatedDowntime;
        private PropertyState<MaintenanceMethodEnum> m_maintenanceMethod;
        private MaintenanceEventStateMachineTypeState m_maintenanceState;
        private PropertyState<NameNodeIdDataType> m_maintenanceSupplier;
        private PropertyState<NameNodeIdDataType[]> m_partsOfAssetReplaced;
        private PropertyState<NameNodeIdDataType[]> m_partsOfAssetServiced;
        private PropertyState<DateTime> m_plannedDate;
        private PropertyState<NameNodeIdDataType> m_qualificationOfPersonnel;
        #endregion
    }
    #endif
    #endregion

    #region IRootCauseIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_IRootCauseIndicationTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IRootCauseIndicationTypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IRootCauseIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.IRootCauseIndicationType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIAAAAElS" +
           "b290Q2F1c2VJbmRpY2F0aW9uVHlwZUluc3RhbmNlAQHqAwEB6gPqAwAA/////wEAAAAXYIkKAgAAAAEA" +
           "EwAAAFBvdGVudGlhbFJvb3RDYXVzZXMBAX8XAC4ARH8XAAABAboLAQAAAAEAAAAAAAAAAwP/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<RootCauseDataType[]> PotentialRootCauses
        {
            get
            {
                return m_potentialRootCauses;
            }

            set
            {
                if (!Object.ReferenceEquals(m_potentialRootCauses, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_potentialRootCauses = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_potentialRootCauses != null)
            {
                children.Add(m_potentialRootCauses);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AMB.BrowseNames.PotentialRootCauses:
                {
                    if (createOrReplace)
                    {
                        if (PotentialRootCauses == null)
                        {
                            if (replacement == null)
                            {
                                PotentialRootCauses = new PropertyState<RootCauseDataType[]>(this);
                            }
                            else
                            {
                                PotentialRootCauses = (PropertyState<RootCauseDataType[]>)replacement;
                            }
                        }
                    }

                    instance = PotentialRootCauses;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<RootCauseDataType[]> m_potentialRootCauses;
        #endregion
    }
    #endif
    #endregion

    #region DocumentationLinksTypeState Class
    #if (!OPCUA_EXCLUDE_DocumentationLinksTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DocumentationLinksTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public DocumentationLinksTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.DocumentationLinksType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (AddLink != null)
            {
                AddLink.Initialize(context, AddLink_InitializationString);
            }

            if (RemoveLink != null)
            {
                RemoveLink.Initialize(context, RemoveLink_InitializationString);
            }
        }

        #region Initialization String
        private const string AddLink_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYYIKBAAAAAEABwAAAEFk" +
           "ZExpbmsBAVwbAwAAAABSAAAATWV0aG9kIHRvIGFkZCBhbiBlbmQtdXNlciBzcGVjaWZpYyBsaW5rIHRo" +
           "YXQgaXMgc3RvcmVkIHBlcnNpc3RlbnRseSBpbiB0aGUgc2VydmVyLgAvAQFcG1wbAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBghcALgBEghcAAJYEAAAAAQAqAQGsAAAAFAAAAExp" +
           "bmtUb0V4dGVybmFsU291cmNlAQDHXP////8AAAAAAoMAAABMaW5rIHRvIGFuIGV4dGVybmFsIHNvdXJj" +
           "ZS4gVGhlIHNlcnZlciBtaWdodCBvciBtaWdodCBub3QgY2hlY2sgaWYgYSBjb3JyZWN0IFVSSSBpcyBw" +
           "cm92aWRlZCwgb3IgaWYgdGhlIFVSSSBpcyBhdmFpbGFibGUvcmVhY2hhYmxlLgEAKgEBiAAAAAoAAABC" +
           "cm93c2VOYW1lABT/////AAAAAAJrAAAAVGhlIEJyb3dzZU5hbWUgb2YgdGhlIG5ldyBjcmVhdGVkIE5v" +
           "ZGUuIE1ldGhvZCBmYWlscyBpZiBhIFZhcmlhYmxlIHdpdGggdGhlIHNhbWUgQnJvd3NlTmFtZSBhbHJl" +
           "YWR5IGV4aXN0cy4BACoBAdgAAAALAAAARGlzcGxheU5hbWUAFf////8AAAAAAroAAABUaGUgRGlzcGxh" +
           "eU5hbWUgb2YgdGhlIG5ldyBjcmVhdGVkIE5vZGUuIElmIHRoZSBzZXJ2ZXIgc3VwcG9ydHMgbXVsdGlw" +
           "bGUgbG9jYWxlcywgYW5kIHRoZSBDbGllbnQgd2FudHMgdG8gcHJvdmlkZSBtb3JlIHRoYW4gb25lIGxv" +
           "Y2FsZSwgdGhlIFdyaXRlIG9wZXJhdGlvbiBvbiB0aGUgVmFyaWFibGUgc2hhbGwgYmUgdXNlZC4BACoB" +
           "AdgAAAALAAAARGVzY3JpcHRpb24AFf////8AAAAAAroAAABUaGUgRGVzY3JpcHRpb24gb2YgdGhlIG5l" +
           "dyBjcmVhdGVkIE5vZGUuIElmIHRoZSBzZXJ2ZXIgc3VwcG9ydHMgbXVsdGlwbGUgbG9jYWxlcywgYW5k" +
           "IHRoZSBDbGllbnQgd2FudHMgdG8gcHJvdmlkZSBtb3JlIHRoYW4gb25lIGxvY2FsZSwgdGhlIFdyaXRl" +
           "IG9wZXJhdGlvbiBvbiB0aGUgVmFyaWFibGUgc2hhbGwgYmUgdXNlZC4BACgBAQAAAAEAAAAEAAAAAQH/" +
           "////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGDFwAuAESDFwAAlgEAAAABACoBAUgA" +
           "AAAMAAAATGlua1ZhcmlhYmxlABH/////AAAAAAIpAAAAVGhlIE5vZGVJZCBvZiB0aGUgbmV3bHkgY3Jl" +
           "YXRlZCBWYXJpYWJsZS4BACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";

        private const string RemoveLink_InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYYIKBAAAAAEACgAAAFJl" +
           "bW92ZUxpbmsBAV0bAwAAAABJAAAATWV0aG9kIHRvIHJlbW92ZSBhbiBlbmQtdXNlciBzcGVjaWZpYyBs" +
           "aW5rIHRoYXQgaXMgbWFuYWdlZCBpbiB0aGUgc2VydmVyLgAvAQFdG10bAAABAf////8BAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBhBcALgBEhBcAAJYBAAAAAQAqAQHRAAAAEwAAAFZhcmlhYmxl" +
           "VG9CZURlbGV0ZWQAEf////8AAAAAAqsAAABOb2RlSWQgb2YgdGhlIFZhcmlhYmxlIGNvbnRhaW5pbmcg" +
           "YSBsaW5rLCB0aGF0IHNob3VsZCBiZSBkZWxldGVkLiBWYXJpYWJsZSBzaGFsbCBiZSByZWZlcmVuY2Vk" +
           "IGZyb20gdGhlIE9iamVjdCB3aXRoIGEgSGFzQ29tcG9uZW50IFJlZmVyZW5jZSB3aGVyZSB0aGUgTWV0" +
           "aG9kIGlzIGNhbGxlZCBvbi4BACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHgAAAERv" +
           "Y3VtZW50YXRpb25MaW5rc1R5cGVJbnN0YW5jZQEB8wMBAfMD8wMAAP////8CAAAAJGGCCgQAAAABAAcA" +
           "AABBZGRMaW5rAQFcGwMAAAAAUgAAAE1ldGhvZCB0byBhZGQgYW4gZW5kLXVzZXIgc3BlY2lmaWMgbGlu" +
           "ayB0aGF0IGlzIHN0b3JlZCBwZXJzaXN0ZW50bHkgaW4gdGhlIHNlcnZlci4ALwEBXBtcGwAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYIXAC4ARIIXAACWBAAAAAEAKgEBrAAAABQA" +
           "AABMaW5rVG9FeHRlcm5hbFNvdXJjZQEAx1z/////AAAAAAKDAAAATGluayB0byBhbiBleHRlcm5hbCBz" +
           "b3VyY2UuIFRoZSBzZXJ2ZXIgbWlnaHQgb3IgbWlnaHQgbm90IGNoZWNrIGlmIGEgY29ycmVjdCBVUkkg" +
           "aXMgcHJvdmlkZWQsIG9yIGlmIHRoZSBVUkkgaXMgYXZhaWxhYmxlL3JlYWNoYWJsZS4BACoBAYgAAAAK" +
           "AAAAQnJvd3NlTmFtZQAU/////wAAAAACawAAAFRoZSBCcm93c2VOYW1lIG9mIHRoZSBuZXcgY3JlYXRl" +
           "ZCBOb2RlLiBNZXRob2QgZmFpbHMgaWYgYSBWYXJpYWJsZSB3aXRoIHRoZSBzYW1lIEJyb3dzZU5hbWUg" +
           "YWxyZWFkeSBleGlzdHMuAQAqAQHYAAAACwAAAERpc3BsYXlOYW1lABX/////AAAAAAK6AAAAVGhlIERp" +
           "c3BsYXlOYW1lIG9mIHRoZSBuZXcgY3JlYXRlZCBOb2RlLiBJZiB0aGUgc2VydmVyIHN1cHBvcnRzIG11" +
           "bHRpcGxlIGxvY2FsZXMsIGFuZCB0aGUgQ2xpZW50IHdhbnRzIHRvIHByb3ZpZGUgbW9yZSB0aGFuIG9u" +
           "ZSBsb2NhbGUsIHRoZSBXcml0ZSBvcGVyYXRpb24gb24gdGhlIFZhcmlhYmxlIHNoYWxsIGJlIHVzZWQu" +
           "AQAqAQHYAAAACwAAAERlc2NyaXB0aW9uABX/////AAAAAAK6AAAAVGhlIERlc2NyaXB0aW9uIG9mIHRo" +
           "ZSBuZXcgY3JlYXRlZCBOb2RlLiBJZiB0aGUgc2VydmVyIHN1cHBvcnRzIG11bHRpcGxlIGxvY2FsZXMs" +
           "IGFuZCB0aGUgQ2xpZW50IHdhbnRzIHRvIHByb3ZpZGUgbW9yZSB0aGFuIG9uZSBsb2NhbGUsIHRoZSBX" +
           "cml0ZSBvcGVyYXRpb24gb24gdGhlIFZhcmlhYmxlIHNoYWxsIGJlIHVzZWQuAQAoAQEAAAABAAAABAAA" +
           "AAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBgxcALgBEgxcAAJYBAAAAAQAq" +
           "AQFIAAAADAAAAExpbmtWYXJpYWJsZQAR/////wAAAAACKQAAAFRoZSBOb2RlSWQgb2YgdGhlIG5ld2x5" +
           "IGNyZWF0ZWQgVmFyaWFibGUuAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAkYYIKBAAAAAEACgAAAFJl" +
           "bW92ZUxpbmsBAV0bAwAAAABJAAAATWV0aG9kIHRvIHJlbW92ZSBhbiBlbmQtdXNlciBzcGVjaWZpYyBs" +
           "aW5rIHRoYXQgaXMgbWFuYWdlZCBpbiB0aGUgc2VydmVyLgAvAQFdG10bAAABAf////8BAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBhBcALgBEhBcAAJYBAAAAAQAqAQHRAAAAEwAAAFZhcmlhYmxl" +
           "VG9CZURlbGV0ZWQAEf////8AAAAAAqsAAABOb2RlSWQgb2YgdGhlIFZhcmlhYmxlIGNvbnRhaW5pbmcg" +
           "YSBsaW5rLCB0aGF0IHNob3VsZCBiZSBkZWxldGVkLiBWYXJpYWJsZSBzaGFsbCBiZSByZWZlcmVuY2Vk" +
           "IGZyb20gdGhlIE9iamVjdCB3aXRoIGEgSGFzQ29tcG9uZW50IFJlZmVyZW5jZSB3aGVyZSB0aGUgTWV0" +
           "aG9kIGlzIGNhbGxlZCBvbi4BACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AddLinkMethodState AddLink
        {
            get
            {
                return m_addLinkMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_addLinkMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addLinkMethod = value;
            }
        }

        /// <remarks />
        public RemoveLinkMethodState RemoveLink
        {
            get
            {
                return m_removeLinkMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_removeLinkMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_removeLinkMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_addLinkMethod != null)
            {
                children.Add(m_addLinkMethod);
            }

            if (m_removeLinkMethod != null)
            {
                children.Add(m_removeLinkMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.AMB.BrowseNames.AddLink:
                {
                    if (createOrReplace)
                    {
                        if (AddLink == null)
                        {
                            if (replacement == null)
                            {
                                AddLink = new AddLinkMethodState(this);
                            }
                            else
                            {
                                AddLink = (AddLinkMethodState)replacement;
                            }
                        }
                    }

                    instance = AddLink;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.RemoveLink:
                {
                    if (createOrReplace)
                    {
                        if (RemoveLink == null)
                        {
                            if (replacement == null)
                            {
                                RemoveLink = new RemoveLinkMethodState(this);
                            }
                            else
                            {
                                RemoveLink = (RemoveLinkMethodState)replacement;
                            }
                        }
                    }

                    instance = RemoveLink;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AddLinkMethodState m_addLinkMethod;
        private RemoveLinkMethodState m_removeLinkMethod;
        #endregion
    }
    #endif
    #endregion

    #region MaintenanceEventStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_MaintenanceEventStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MaintenanceEventStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public MaintenanceEventStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.AMB.ObjectTypes.MaintenanceEventStateMachineType, Opc.Ua.AMB.Namespaces.AMB, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKAAAAE1h" +
           "aW50ZW5hbmNlRXZlbnRTdGF0ZU1hY2hpbmVUeXBlSW5zdGFuY2UBAfUDAQH1A/UDAAD/////AQAAABVg" +
           "iQgCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEAAAAvAQDICgAV/////wEB/////wEAAAAVYIkIAgAAAAAA" +
           "AgAAAElkAQEAAAAuAEQAEf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AddLinkMethodState Class
    #if (!OPCUA_EXCLUDE_AddLinkMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AddLinkMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public AddLinkMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new AddLinkMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEQAAAEFk" +
           "ZExpbmtNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public AddLinkMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string linkToExternalSource = (string)_inputArguments[0];
            QualifiedName browseName = (QualifiedName)_inputArguments[1];
            LocalizedText displayName = (LocalizedText)_inputArguments[2];
            LocalizedText description = (LocalizedText)_inputArguments[3];

            NodeId linkVariable = (NodeId)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    linkToExternalSource,
                    browseName,
                    displayName,
                    description,
                    ref linkVariable);
            }

            _outputArguments[0] = linkVariable;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult AddLinkMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string linkToExternalSource,
        QualifiedName browseName,
        LocalizedText displayName,
        LocalizedText description,
        ref NodeId linkVariable);
    #endif
    #endregion

    #region RemoveLinkMethodState Class
    #if (!OPCUA_EXCLUDE_RemoveLinkMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RemoveLinkMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RemoveLinkMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RemoveLinkMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAFAAAAFJl" +
           "bW92ZUxpbmtNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RemoveLinkMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId variableToBeDeleted = (NodeId)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    variableToBeDeleted);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RemoveLinkMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId variableToBeDeleted);
    #endif
    #endregion
}