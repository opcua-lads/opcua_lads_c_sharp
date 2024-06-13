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
using Opc.Ua.Di;

namespace Opc.Ua.Machinery
{
    #region IMachineTagNameplateTypeState Class
    #if (!OPCUA_EXCLUDE_IMachineTagNameplateTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IMachineTagNameplateTypeState : ITagNameplateTypeState
    {
        #region Constructors
        /// <remarks />
        public IMachineTagNameplateTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.IMachineTagNameplateType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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

            if (Location != null)
            {
                Location.Initialize(context, Location_InitializationString);
            }
        }

        #region Initialization String
        private const string Location_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAIAAAATG9jYXRpb24BAYwXAwAAAAAsAQAA" +
           "VG8gYmUgdXNlZCBieSBlbmQgdXNlcnMgdG8gc3RvcmUgdGhlIGxvY2F0aW9uIG9mIHRoZSBtYWNoaW5l" +
           "IGluIGEgc2NoZW1lIHNwZWNpZmljIHRvIHRoZSBlbmQgdXNlciBTZXJ2ZXJzIHNoYWxsIHN1cHBvcnQg" +
           "YXQgbGVhc3QgNjAgVW5pY29kZSBjaGFyYWN0ZXJzIGZvciB0aGUgY2xpZW50cyB3cml0aW5nIHRoaXMg" +
           "dmFsdWUsIHRoaXMgbWVhbnMgY2xpZW50cyBjYW4gZXhwZWN0IHRvIGJlIGFibGUgdG8gd3JpdGUgc3Ry" +
           "aW5ncyB3aXRoIGEgbGVuZ3RoIG9mIDYwIFVuaWNvZGUgY2hhcmFjdGVycyBpbnRvIHRoYXQgZmllbGQu" +
           "AC4ARIwXAAAADP////8DA/////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAgAAAASU1hY2hpbmVUYWdOYW1lcGxhdGVU" +
           "eXBlSW5zdGFuY2UBAfMDAQHzA/MDAAABAAAAAQDDRAEBAfQDAQAAADVgiQoCAAAAAQAIAAAATG9jYXRp" +
           "b24BAYwXAwAAAAAsAQAAVG8gYmUgdXNlZCBieSBlbmQgdXNlcnMgdG8gc3RvcmUgdGhlIGxvY2F0aW9u" +
           "IG9mIHRoZSBtYWNoaW5lIGluIGEgc2NoZW1lIHNwZWNpZmljIHRvIHRoZSBlbmQgdXNlciBTZXJ2ZXJz" +
           "IHNoYWxsIHN1cHBvcnQgYXQgbGVhc3QgNjAgVW5pY29kZSBjaGFyYWN0ZXJzIGZvciB0aGUgY2xpZW50" +
           "cyB3cml0aW5nIHRoaXMgdmFsdWUsIHRoaXMgbWVhbnMgY2xpZW50cyBjYW4gZXhwZWN0IHRvIGJlIGFi" +
           "bGUgdG8gd3JpdGUgc3RyaW5ncyB3aXRoIGEgbGVuZ3RoIG9mIDYwIFVuaWNvZGUgY2hhcmFjdGVycyBp" +
           "bnRvIHRoYXQgZmllbGQuAC4ARIwXAAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Location
        {
            get
            {
                return m_location;
            }

            set
            {
                if (!Object.ReferenceEquals(m_location, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_location = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_location != null)
            {
                children.Add(m_location);
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
                case Opc.Ua.Machinery.BrowseNames.Location:
                {
                    if (createOrReplace)
                    {
                        if (Location == null)
                        {
                            if (replacement == null)
                            {
                                Location = new PropertyState<string>(this);
                            }
                            else
                            {
                                Location = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Location;
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
        private PropertyState<string> m_location;
        #endregion
    }
    #endif
    #endregion

    #region IMachineryItemVendorNameplateTypeState Class
    #if (!OPCUA_EXCLUDE_IMachineryItemVendorNameplateTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IMachineryItemVendorNameplateTypeState : IVendorNameplateTypeState
    {
        #region Constructors
        /// <remarks />
        public IMachineryItemVendorNameplateTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.IMachineryItemVendorNameplateType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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

            if (InitialOperationDate != null)
            {
                InitialOperationDate.Initialize(context, InitialOperationDate_InitializationString);
            }

            if (MonthOfConstruction != null)
            {
                MonthOfConstruction.Initialize(context, MonthOfConstruction_InitializationString);
            }

            if (YearOfConstruction != null)
            {
                YearOfConstruction.Initialize(context, YearOfConstruction_InitializationString);
            }
        }

        #region Initialization String
        private const string InitialOperationDate_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAUAAAASW5pdGlhbE9wZXJhdGlvbkRhdGUB" +
           "AYsXAwAAAABpAAAAVGhlIGRhdGUsIHdoZW4gdGhlIE1hY2hpbmVyeUl0ZW0gd2FzIHN3aXRjaGVkIG9u" +
           "IHRoZSBmaXJzdCB0aW1lIGFmdGVyIGl0IGhhcyBsZWZ0IHRoZSBtYW51ZmFjdHVyZXIgcGxhbnQuAC4A" +
           "RIsXAAAADf////8BAf////8AAAAA";

        private const string MonthOfConstruction_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQATAAAATW9udGhPZkNvbnN0cnVjdGlvbgEB" +
           "ihcDAAAAAK0AAABUaGUgbW9udGggaW4gd2hpY2ggdGhlIG1hbnVmYWN0dXJpbmcgcHJvY2VzcyBvZiB0" +
           "aGUgTWFjaGluZXJ5SXRlbSBoYXMgYmVlbiBjb21wbGV0ZWQuIEl0IHNoYWxsIGJlIGEgbnVtYmVyIGJl" +
           "dHdlZW4gMSBhbmQgMTIsIHJlcHJlc2VudGluZyB0aGUgbW9udGggZnJvbSBKYW51YXJ5IHRvIERlY2Vt" +
           "YmVyLgAuAESKFwAAAAP/////AQH/////AAAAAA==";

        private const string YearOfConstruction_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQASAAAAWWVhck9mQ29uc3RydWN0aW9uAQGJ" +
           "FwMAAAAAxAAAAFRoZSB5ZWFyIChHcmVnb3JpYW4gY2FsZW5kYXIpIGluIHdoaWNoIHRoZSBtYW51ZmFj" +
           "dHVyaW5nIHByb2Nlc3Mgb2YgdGhlIE1hY2hpbmVyeUl0ZW0gaGFzIGJlZW4gY29tcGxldGVkLiBJdCBz" +
           "aGFsbCBiZSBhIGZvdXItZGlnaXQgbnVtYmVyIGFuZCBuZXZlciBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZl" +
           "LWN5Y2xlIG9mIGEgTWFjaGluZXJ5SXRlbS4ALgBEiRcAAAAF/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQApAAAASU1hY2hpbmVyeUl0ZW1WZW5kb3JO" +
           "YW1lcGxhdGVUeXBlSW5zdGFuY2UBAesDAQHrA+sDAAABAAAAAQDDRAEBAewDBQAAADVgiQoCAAAAAgAM" +
           "AAAATWFudWZhY3R1cmVyAQGGFwMAAAAASgAAAEEgaHVtYW4tcmVhZGFibGUsIGxvY2FsaXplZCBuYW1l" +
           "IG9mIHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARIYXAAAAFf////8BAf//" +
           "//8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAYgXAwAAAAAXAQAAQSBzdHJpbmcgY29udGFp" +
           "bmluZyBhIHVuaXF1ZSBwcm9kdWN0aW9uIG51bWJlciBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBN" +
           "YWNoaW5lcnlJdGVtLiBUaGUgZ2xvYmFsIHVuaXF1ZW5lc3Mgb2YgdGhlIHNlcmlhbCBudW1iZXIgaXMg" +
           "b25seSBnaXZlbiBpbiB0aGUgY29udGV4dCBvZiB0aGUgbWFudWZhY3R1cmVyLCBhbmQgcG90ZW50aWFs" +
           "bHkgdGhlIG1vZGVsLiBUaGUgdmFsdWUgc2hhbGwgbm90IGNoYW5nZSBkdXJpbmcgdGhlIGxpZmUtY3lj" +
           "bGUgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARIgXAAAADP////8BAf////8AAAAANWCJCgIAAAABABQA" +
           "AABJbml0aWFsT3BlcmF0aW9uRGF0ZQEBixcDAAAAAGkAAABUaGUgZGF0ZSwgd2hlbiB0aGUgTWFjaGlu" +
           "ZXJ5SXRlbSB3YXMgc3dpdGNoZWQgb24gdGhlIGZpcnN0IHRpbWUgYWZ0ZXIgaXQgaGFzIGxlZnQgdGhl" +
           "IG1hbnVmYWN0dXJlciBwbGFudC4ALgBEixcAAAAN/////wEB/////wAAAAA1YIkKAgAAAAEAEwAAAE1v" +
           "bnRoT2ZDb25zdHJ1Y3Rpb24BAYoXAwAAAACtAAAAVGhlIG1vbnRoIGluIHdoaWNoIHRoZSBtYW51ZmFj" +
           "dHVyaW5nIHByb2Nlc3Mgb2YgdGhlIE1hY2hpbmVyeUl0ZW0gaGFzIGJlZW4gY29tcGxldGVkLiBJdCBz" +
           "aGFsbCBiZSBhIG51bWJlciBiZXR3ZWVuIDEgYW5kIDEyLCByZXByZXNlbnRpbmcgdGhlIG1vbnRoIGZy" +
           "b20gSmFudWFyeSB0byBEZWNlbWJlci4ALgBEihcAAAAD/////wEB/////wAAAAA1YIkKAgAAAAEAEgAA" +
           "AFllYXJPZkNvbnN0cnVjdGlvbgEBiRcDAAAAAMQAAABUaGUgeWVhciAoR3JlZ29yaWFuIGNhbGVuZGFy" +
           "KSBpbiB3aGljaCB0aGUgbWFudWZhY3R1cmluZyBwcm9jZXNzIG9mIHRoZSBNYWNoaW5lcnlJdGVtIGhh" +
           "cyBiZWVuIGNvbXBsZXRlZC4gSXQgc2hhbGwgYmUgYSBmb3VyLWRpZ2l0IG51bWJlciBhbmQgbmV2ZXIg" +
           "Y2hhbmdlIGR1cmluZyB0aGUgbGlmZS1jeWNsZSBvZiBhIE1hY2hpbmVyeUl0ZW0uAC4ARIkXAAAABf//" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<DateTime> InitialOperationDate
        {
            get
            {
                return m_initialOperationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_initialOperationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_initialOperationDate = value;
            }
        }

        /// <remarks />
        public PropertyState<byte> MonthOfConstruction
        {
            get
            {
                return m_monthOfConstruction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_monthOfConstruction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_monthOfConstruction = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> YearOfConstruction
        {
            get
            {
                return m_yearOfConstruction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yearOfConstruction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yearOfConstruction = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_initialOperationDate != null)
            {
                children.Add(m_initialOperationDate);
            }

            if (m_monthOfConstruction != null)
            {
                children.Add(m_monthOfConstruction);
            }

            if (m_yearOfConstruction != null)
            {
                children.Add(m_yearOfConstruction);
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
                case Opc.Ua.Machinery.BrowseNames.InitialOperationDate:
                {
                    if (createOrReplace)
                    {
                        if (InitialOperationDate == null)
                        {
                            if (replacement == null)
                            {
                                InitialOperationDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                InitialOperationDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = InitialOperationDate;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.MonthOfConstruction:
                {
                    if (createOrReplace)
                    {
                        if (MonthOfConstruction == null)
                        {
                            if (replacement == null)
                            {
                                MonthOfConstruction = new PropertyState<byte>(this);
                            }
                            else
                            {
                                MonthOfConstruction = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = MonthOfConstruction;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.YearOfConstruction:
                {
                    if (createOrReplace)
                    {
                        if (YearOfConstruction == null)
                        {
                            if (replacement == null)
                            {
                                YearOfConstruction = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                YearOfConstruction = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = YearOfConstruction;
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
        private PropertyState<DateTime> m_initialOperationDate;
        private PropertyState<byte> m_monthOfConstruction;
        private PropertyState<ushort> m_yearOfConstruction;
        #endregion
    }
    #endif
    #endregion

    #region IMachineVendorNameplateTypeState Class
    #if (!OPCUA_EXCLUDE_IMachineVendorNameplateTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IMachineVendorNameplateTypeState : IMachineryItemVendorNameplateTypeState
    {
        #region Constructors
        /// <remarks />
        public IMachineVendorNameplateTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.IMachineVendorNameplateType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAjAAAASU1hY2hpbmVWZW5kb3JOYW1lcGxh" +
           "dGVUeXBlSW5zdGFuY2UBAfIDAQHyA/IDAAABAAAAAQDDRAEBAfQDAwAAADVgiQoCAAAAAgAMAAAATWFu" +
           "dWZhY3R1cmVyAQGGFwMAAAAASgAAAEEgaHVtYW4tcmVhZGFibGUsIGxvY2FsaXplZCBuYW1lIG9mIHRo" +
           "ZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARIYXAAAAFf////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAYgXAwAAAAAXAQAAQSBzdHJpbmcgY29udGFpbmluZyBh" +
           "IHVuaXF1ZSBwcm9kdWN0aW9uIG51bWJlciBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBNYWNoaW5l" +
           "cnlJdGVtLiBUaGUgZ2xvYmFsIHVuaXF1ZW5lc3Mgb2YgdGhlIHNlcmlhbCBudW1iZXIgaXMgb25seSBn" +
           "aXZlbiBpbiB0aGUgY29udGV4dCBvZiB0aGUgbWFudWZhY3R1cmVyLCBhbmQgcG90ZW50aWFsbHkgdGhl" +
           "IG1vZGVsLiBUaGUgdmFsdWUgc2hhbGwgbm90IGNoYW5nZSBkdXJpbmcgdGhlIGxpZmUtY3ljbGUgb2Yg" +
           "dGhlIE1hY2hpbmVyeUl0ZW0uAC4ARIgXAAAADP////8BAf////8AAAAANWCJCgIAAAACABIAAABQcm9k" +
           "dWN0SW5zdGFuY2VVcmkBAYcXAwAAAABRAAAAQSBnbG9iYWxseSB1bmlxdWUgcmVzb3VyY2UgaWRlbnRp" +
           "ZmllciBwcm92aWRlZCBieSB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBtYWNoaW5lAC4ARIcXAAAADP//" +
           "//8BAf////8AAAAA";
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

    #region MachineryItemIdentificationTypeState Class
    #if (!OPCUA_EXCLUDE_MachineryItemIdentificationTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineryItemIdentificationTypeState : FunctionalGroupTypeState
    {
        #region Constructors
        /// <remarks />
        public MachineryItemIdentificationTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineryItemIdentificationType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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

            if (AssetId != null)
            {
                AssetId.Initialize(context, AssetId_InitializationString);
            }

            if (ComponentName != null)
            {
                ComponentName.Initialize(context, ComponentName_InitializationString);
            }

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (HardwareRevision != null)
            {
                HardwareRevision.Initialize(context, HardwareRevision_InitializationString);
            }

            if (InitialOperationDate != null)
            {
                InitialOperationDate.Initialize(context, InitialOperationDate_InitializationString);
            }

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (MonthOfConstruction != null)
            {
                MonthOfConstruction.Initialize(context, MonthOfConstruction_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (ProductInstanceUri != null)
            {
                ProductInstanceUri.Initialize(context, ProductInstanceUri_InitializationString);
            }

            if (SoftwareRevision != null)
            {
                SoftwareRevision.Initialize(context, SoftwareRevision_InitializationString);
            }

            if (YearOfConstruction != null)
            {
                YearOfConstruction.Initialize(context, YearOfConstruction_InitializationString);
            }
        }

        #region Initialization String
        private const string AssetId_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgqQoCAAAAAgAHAAAAQXNzZXRJZAEBfRcDAAAAADABAABU" +
           "byBiZSB1c2VkIGJ5IGVuZCB1c2VycyB0byBzdG9yZSBhIHVuaXF1ZSBpZGVudGlmaWNhdGlvbiBpbiB0" +
           "aGUgY29udGV4dCBvZiB0aGVpciBvdmVyYWxsIGFwcGxpY2F0aW9uLiBTZXJ2ZXJzIHNoYWxsIHN1cHBv" +
           "cnQgYXQgbGVhc3QgNDAgVW5pY29kZSBjaGFyYWN0ZXJzIGZvciB0aGUgY2xpZW50cyB3cml0aW5nIHRo" +
           "aXMgdmFsdWUsIHRoaXMgbWVhbnMgY2xpZW50cyBjYW4gZXhwZWN0IHRvIGJlIGFibGUgdG8gd3JpdGUg" +
           "c3RyaW5ncyB3aXRoIGEgbGVuZ3RoIG9mIDQwIFVuaWNvZGUgY2hhcmFjdGVycyBpbnRvIHRoYXQgZmll" +
           "bGQuAC4ARH0XAAAMAAAAAAAM/////wMD/////wAAAAA=";

        private const string ComponentName_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgqQoCAAAAAgANAAAAQ29tcG9uZW50TmFtZQEBfhcDAAAA" +
           "AHoBAABUbyBiZSB1c2VkIGJ5IGVuZCB1c2VycyB0byBzdG9yZSBhIGh1bWFuLXJlYWRhYmxlIGxvY2Fs" +
           "aXplZCB0ZXh0IGZvciB0aGUgTWFjaGluZXJ5SXRlbS4gVGhlIG1pbmltdW0gbnVtYmVyIG9mIGxvY2Fs" +
           "ZXMgc3VwcG9ydGVkIGZvciB0aGlzIHByb3BlcnR5IHNoYWxsIGJlIHR3by4gU2VydmVycyBzaGFsbCBz" +
           "dXBwb3J0IGF0IGxlYXN0IDQwIFVuaWNvZGUgY2hhcmFjdGVycyBmb3IgdGhlIGNsaWVudHMgd3JpdGlu" +
           "ZyB0aGUgdGV4dCBwYXJ0IG9mIGVhY2ggbG9jYWxlLCB0aGlzIG1lYW5zIGNsaWVudHMgY2FuIGV4cGVj" +
           "dCB0byBiZSBhYmxlIHRvIHdyaXRlIHRleHRzIHdpdGggYSBsZW5ndGggb2YgNDAgVW5pY29kZSBjaGFy" +
           "YWN0ZXJzIGludG8gdGhhdCBmaWVsZC4ALgBEfhcAABUAABX/////AwP/////AAAAAA==";

        private const string DeviceClass_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgALAAAARGV2aWNlQ2xhc3MBAXwXAwAAAABI" +
           "AAAASW5kaWNhdGVzIGluIHdoaWNoIGRvbWFpbiBvciBmb3Igd2hhdCBwdXJwb3NlIHRoZSBNYWNoaW5l" +
           "cnlJdGVtIGlzIHVzZWQuAC4ARHwXAAAADP////8BAf////8AAAAA";

        private const string HardwareRevision_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBehcD" +
           "AAAAACQBAABBIHN0cmluZyByZXByZXNlbnRhdGlvbiBvZiB0aGUgcmV2aXNpb24gbGV2ZWwgb2YgdGhl" +
           "IGhhcmR3YXJlIG9mIGEgTWFjaGluZXJ5SXRlbS4gSGFyZHdhcmUgaXMgcGh5c2ljYWwgZXF1aXBtZW50" +
           "LCBhcyBvcHBvc2VkIHRvIHByb2dyYW1zLCBwcm9jZWR1cmVzLCBydWxlcyBhbmQgYXNzb2NpYXRlZCBk" +
           "b2N1bWVudGF0aW9uLiBNYW55IG1hY2hpbmVzIHdpbGwgbm90IHByb3ZpZGUgc3VjaCBpbmZvcm1hdGlv" +
           "biBkdWUgdG8gdGhlIG1vZHVsYXIgYW5kIGNvbmZpZ3VyYWJsZSBuYXR1cmUgb2YgdGhlIG1hY2hpbmUu" +
           "AC4ARHoXAAAADP////8BAf////8AAAAA";

        private const string InitialOperationDate_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAUAAAASW5pdGlhbE9wZXJhdGlvbkRhdGUB" +
           "AXYXAwAAAABpAAAAVGhlIGRhdGUsIHdoZW4gdGhlIE1hY2hpbmVyeUl0ZW0gd2FzIHN3aXRjaGVkIG9u" +
           "IHRoZSBmaXJzdCB0aW1lIGFmdGVyIGl0IGhhcyBsZWZ0IHRoZSBtYW51ZmFjdHVyZXIgcGxhbnQuAC4A" +
           "RHYXAAAADf////8BAf////8AAAAA";

        private const string ManufacturerUri_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAPAAAATWFudWZhY3R1cmVyVXJpAQF3FwMA" +
           "AAAARgAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgb2YgdGhlIG1hbnVmYWN0dXJlciBvZiB0" +
           "aGUgTWFjaGluZXJ5SXRlbS4ALgBEdxcAAAAM/////wEB/////wAAAAA=";

        private const string Model_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAFAAAATW9kZWwBAXgXAwAAAABDAAAAQSBo" +
           "dW1hbi1yZWFkYWJsZSwgbG9jYWxpemVkIG5hbWUgb2YgdGhlIG1vZGVsIG9mIHRoZSBNYWNoaW5lcnlJ" +
           "dGVtLgAuAER4FwAAABX/////AQH/////AAAAAA==";

        private const string MonthOfConstruction_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQATAAAATW9udGhPZkNvbnN0cnVjdGlvbgEB" +
           "dRcDAAAAAK0AAABUaGUgbW9udGggaW4gd2hpY2ggdGhlIG1hbnVmYWN0dXJpbmcgcHJvY2VzcyBvZiB0" +
           "aGUgTWFjaGluZXJ5SXRlbSBoYXMgYmVlbiBjb21wbGV0ZWQuIEl0IHNoYWxsIGJlIGEgbnVtYmVyIGJl" +
           "dHdlZW4gMSBhbmQgMTIsIHJlcHJlc2VudGluZyB0aGUgbW9udGggZnJvbSBKYW51YXJ5IHRvIERlY2Vt" +
           "YmVyLgAuAER1FwAAAAP/////AQH/////AAAAAA==";

        private const string ProductCode_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgALAAAAUHJvZHVjdENvZGUBAXkXAwAAAAD7" +
           "AAAAQSBtYWNoaW5lLXJlYWRhYmxlIHN0cmluZyBvZiB0aGUgbW9kZWwgb2YgdGhlIE1hY2hpbmVyeUl0" +
           "ZW0sIHRoYXQgbWlnaHQgaW5jbHVkZSBvcHRpb25zIGxpa2UgdGhlIGhhcmR3YXJlIGNvbmZpZ3VyYXRp" +
           "b24gb2YgdGhlIG1vZGVsLiBUaGlzIGluZm9ybWF0aW9uIG1pZ2h0IGJlIHByb3ZpZGVkIGJ5IHRoZSBF" +
           "UlAgc3lzdGVtIG9mIHRoZSB2ZW5kb3IuIEZvciBleGFtcGxlLCBpdCBjYW4gYmUgdXNlZCBhcyBvcmRl" +
           "ciBpbmZvcm1hdGlvbi4ALgBEeRcAAAAM/////wEB/////wAAAAA=";

        private const string ProductInstanceUri_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQFx" +
           "FwMAAAAAWAAAAEEgZ2xvYmFsbHkgdW5pcXVlIHJlc291cmNlIGlkZW50aWZpZXIgcHJvdmlkZWQgYnkg" +
           "dGhlIG1hbnVmYWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEcRcAAAAM/////wEB/////wAA" +
           "AAA=";

        private const string SoftwareRevision_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBexcD" +
           "AAAAANABAABBIHN0cmluZyByZXByZXNlbnRhdGlvbiBvZiB0aGUgcmV2aXNpb24gbGV2ZWwgb2YgYSBN" +
           "YWNoaW5lcnlJdGVtLiBJbiBtb3N0IGNhc2VzLCBNYWNoaW5lcnlJdGVtcyBjb25zaXN0IG9mIHNldmVy" +
           "YWwgc29mdHdhcmUgY29tcG9uZW50cy4gSW4gdGhhdCBjYXNlLCBpbmZvcm1hdGlvbiBhYm91dCB0aGUg" +
           "c29mdHdhcmUgY29tcG9uZW50cyBtaWdodCBiZSBwcm92aWRlZCBhcyBhZGRpdGlvbmFsIGluZm9ybWF0" +
           "aW9uIGluIHRoZSBhZGRyZXNzIHNwYWNlLCBpbmNsdWRpbmcgaW5kaXZpZHVhbCByZXZpc2lvbiBpbmZv" +
           "cm1hdGlvbi4gSW4gdGhhdCBjYXNlLCB0aGlzIHByb3BlcnR5IGlzIGVpdGhlciBub3QgcHJvdmlkZWQg" +
           "b3IgcHJvdmlkZXMgYW4gb3ZlcmFsbCBzb2Z0d2FyZSByZXZpc2lvbiBsZXZlbC4gVGhlIHZhbHVlIG1p" +
           "Z2h0IGNoYW5nZSBkdXJpbmcgdGhlIGxpZmUtY3ljbGUgb2YgYSBNYWNoaW5lcnlJdGVtLgAuAER7FwAA" +
           "AAz/////AQH/////AAAAAA==";

        private const string YearOfConstruction_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQASAAAAWWVhck9mQ29uc3RydWN0aW9uAQF0" +
           "FwMAAAAAxAAAAFRoZSB5ZWFyIChHcmVnb3JpYW4gY2FsZW5kYXIpIGluIHdoaWNoIHRoZSBtYW51ZmFj" +
           "dHVyaW5nIHByb2Nlc3Mgb2YgdGhlIE1hY2hpbmVyeUl0ZW0gaGFzIGJlZW4gY29tcGxldGVkLiBJdCBz" +
           "aGFsbCBiZSBhIGZvdXItZGlnaXQgbnVtYmVyIGFuZCBuZXZlciBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZl" +
           "LWN5Y2xlIG9mIGEgTWFjaGluZXJ5SXRlbS4ALgBEdBcAAAAF/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAnAAAATWFjaGluZXJ5SXRlbUlkZW50aWZp" +
           "Y2F0aW9uVHlwZUluc3RhbmNlAQHsAwEB7APsAwAAAgAAAAEAw0QAAQHrAwEAw0QAAQLIOg4AAAA1YKkK" +
           "AgAAAAIABwAAAEFzc2V0SWQBAX0XAwAAAAAwAQAAVG8gYmUgdXNlZCBieSBlbmQgdXNlcnMgdG8gc3Rv" +
           "cmUgYSB1bmlxdWUgaWRlbnRpZmljYXRpb24gaW4gdGhlIGNvbnRleHQgb2YgdGhlaXIgb3ZlcmFsbCBh" +
           "cHBsaWNhdGlvbi4gU2VydmVycyBzaGFsbCBzdXBwb3J0IGF0IGxlYXN0IDQwIFVuaWNvZGUgY2hhcmFj" +
           "dGVycyBmb3IgdGhlIGNsaWVudHMgd3JpdGluZyB0aGlzIHZhbHVlLCB0aGlzIG1lYW5zIGNsaWVudHMg" +
           "Y2FuIGV4cGVjdCB0byBiZSBhYmxlIHRvIHdyaXRlIHN0cmluZ3Mgd2l0aCBhIGxlbmd0aCBvZiA0MCBV" +
           "bmljb2RlIGNoYXJhY3RlcnMgaW50byB0aGF0IGZpZWxkLgAuAER9FwAADAAAAAAADP////8DA/////8A" +
           "AAAANWCpCgIAAAACAA0AAABDb21wb25lbnROYW1lAQF+FwMAAAAAegEAAFRvIGJlIHVzZWQgYnkgZW5k" +
           "IHVzZXJzIHRvIHN0b3JlIGEgaHVtYW4tcmVhZGFibGUgbG9jYWxpemVkIHRleHQgZm9yIHRoZSBNYWNo" +
           "aW5lcnlJdGVtLiBUaGUgbWluaW11bSBudW1iZXIgb2YgbG9jYWxlcyBzdXBwb3J0ZWQgZm9yIHRoaXMg" +
           "cHJvcGVydHkgc2hhbGwgYmUgdHdvLiBTZXJ2ZXJzIHNoYWxsIHN1cHBvcnQgYXQgbGVhc3QgNDAgVW5p" +
           "Y29kZSBjaGFyYWN0ZXJzIGZvciB0aGUgY2xpZW50cyB3cml0aW5nIHRoZSB0ZXh0IHBhcnQgb2YgZWFj" +
           "aCBsb2NhbGUsIHRoaXMgbWVhbnMgY2xpZW50cyBjYW4gZXhwZWN0IHRvIGJlIGFibGUgdG8gd3JpdGUg" +
           "dGV4dHMgd2l0aCBhIGxlbmd0aCBvZiA0MCBVbmljb2RlIGNoYXJhY3RlcnMgaW50byB0aGF0IGZpZWxk" +
           "LgAuAER+FwAAFQAAFf////8DA/////8AAAAANWCJCgIAAAACAAsAAABEZXZpY2VDbGFzcwEBfBcDAAAA" +
           "AEgAAABJbmRpY2F0ZXMgaW4gd2hpY2ggZG9tYWluIG9yIGZvciB3aGF0IHB1cnBvc2UgdGhlIE1hY2hp" +
           "bmVyeUl0ZW0gaXMgdXNlZC4ALgBEfBcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3" +
           "YXJlUmV2aXNpb24BAXoXAwAAAAAkAQAAQSBzdHJpbmcgcmVwcmVzZW50YXRpb24gb2YgdGhlIHJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiBhIE1hY2hpbmVyeUl0ZW0uIEhhcmR3YXJlIGlzIHBo" +
           "eXNpY2FsIGVxdWlwbWVudCwgYXMgb3Bwb3NlZCB0byBwcm9ncmFtcywgcHJvY2VkdXJlcywgcnVsZXMg" +
           "YW5kIGFzc29jaWF0ZWQgZG9jdW1lbnRhdGlvbi4gTWFueSBtYWNoaW5lcyB3aWxsIG5vdCBwcm92aWRl" +
           "IHN1Y2ggaW5mb3JtYXRpb24gZHVlIHRvIHRoZSBtb2R1bGFyIGFuZCBjb25maWd1cmFibGUgbmF0dXJl" +
           "IG9mIHRoZSBtYWNoaW5lLgAuAER6FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAUAAAASW5pdGlh" +
           "bE9wZXJhdGlvbkRhdGUBAXYXAwAAAABpAAAAVGhlIGRhdGUsIHdoZW4gdGhlIE1hY2hpbmVyeUl0ZW0g" +
           "d2FzIHN3aXRjaGVkIG9uIHRoZSBmaXJzdCB0aW1lIGFmdGVyIGl0IGhhcyBsZWZ0IHRoZSBtYW51ZmFj" +
           "dHVyZXIgcGxhbnQuAC4ARHYXAAAADf////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAXIXAwAAAABKAAAAQSBodW1hbi1yZWFkYWJsZSwgbG9jYWxpemVkIG5hbWUgb2YgdGhlIG1hbnVm" +
           "YWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEchcAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADwAAAE1hbnVmYWN0dXJlclVyaQEBdxcDAAAAAEYAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlm" +
           "aWVyIG9mIHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARHcXAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBeBcDAAAAAEMAAABBIGh1bWFuLXJlYWRhYmxlLCBs" +
           "b2NhbGl6ZWQgbmFtZSBvZiB0aGUgbW9kZWwgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARHgXAAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAABABMAAABNb250aE9mQ29uc3RydWN0aW9uAQF1FwMAAAAArQAAAFRo" +
           "ZSBtb250aCBpbiB3aGljaCB0aGUgbWFudWZhY3R1cmluZyBwcm9jZXNzIG9mIHRoZSBNYWNoaW5lcnlJ" +
           "dGVtIGhhcyBiZWVuIGNvbXBsZXRlZC4gSXQgc2hhbGwgYmUgYSBudW1iZXIgYmV0d2VlbiAxIGFuZCAx" +
           "MiwgcmVwcmVzZW50aW5nIHRoZSBtb250aCBmcm9tIEphbnVhcnkgdG8gRGVjZW1iZXIuAC4ARHUXAAAA" +
           "A/////8BAf////8AAAAANWCJCgIAAAACAAsAAABQcm9kdWN0Q29kZQEBeRcDAAAAAPsAAABBIG1hY2hp" +
           "bmUtcmVhZGFibGUgc3RyaW5nIG9mIHRoZSBtb2RlbCBvZiB0aGUgTWFjaGluZXJ5SXRlbSwgdGhhdCBt" +
           "aWdodCBpbmNsdWRlIG9wdGlvbnMgbGlrZSB0aGUgaGFyZHdhcmUgY29uZmlndXJhdGlvbiBvZiB0aGUg" +
           "bW9kZWwuIFRoaXMgaW5mb3JtYXRpb24gbWlnaHQgYmUgcHJvdmlkZWQgYnkgdGhlIEVSUCBzeXN0ZW0g" +
           "b2YgdGhlIHZlbmRvci4gRm9yIGV4YW1wbGUsIGl0IGNhbiBiZSB1c2VkIGFzIG9yZGVyIGluZm9ybWF0" +
           "aW9uLgAuAER5FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJp" +
           "AQFxFwMAAAAAWAAAAEEgZ2xvYmFsbHkgdW5pcXVlIHJlc291cmNlIGlkZW50aWZpZXIgcHJvdmlkZWQg" +
           "YnkgdGhlIG1hbnVmYWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEcRcAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBcxcDAAAAABcBAABBIHN0cmluZyBjb250YWlu" +
           "aW5nIGEgdW5pcXVlIHByb2R1Y3Rpb24gbnVtYmVyIG9mIHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1h" +
           "Y2hpbmVyeUl0ZW0uIFRoZSBnbG9iYWwgdW5pcXVlbmVzcyBvZiB0aGUgc2VyaWFsIG51bWJlciBpcyBv" +
           "bmx5IGdpdmVuIGluIHRoZSBjb250ZXh0IG9mIHRoZSBtYW51ZmFjdHVyZXIsIGFuZCBwb3RlbnRpYWxs" +
           "eSB0aGUgbW9kZWwuIFRoZSB2YWx1ZSBzaGFsbCBub3QgY2hhbmdlIGR1cmluZyB0aGUgbGlmZS1jeWNs" +
           "ZSBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEcxcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAA" +
           "AFNvZnR3YXJlUmV2aXNpb24BAXsXAwAAAADQAQAAQSBzdHJpbmcgcmVwcmVzZW50YXRpb24gb2YgdGhl" +
           "IHJldmlzaW9uIGxldmVsIG9mIGEgTWFjaGluZXJ5SXRlbS4gSW4gbW9zdCBjYXNlcywgTWFjaGluZXJ5" +
           "SXRlbXMgY29uc2lzdCBvZiBzZXZlcmFsIHNvZnR3YXJlIGNvbXBvbmVudHMuIEluIHRoYXQgY2FzZSwg" +
           "aW5mb3JtYXRpb24gYWJvdXQgdGhlIHNvZnR3YXJlIGNvbXBvbmVudHMgbWlnaHQgYmUgcHJvdmlkZWQg" +
           "YXMgYWRkaXRpb25hbCBpbmZvcm1hdGlvbiBpbiB0aGUgYWRkcmVzcyBzcGFjZSwgaW5jbHVkaW5nIGlu" +
           "ZGl2aWR1YWwgcmV2aXNpb24gaW5mb3JtYXRpb24uIEluIHRoYXQgY2FzZSwgdGhpcyBwcm9wZXJ0eSBp" +
           "cyBlaXRoZXIgbm90IHByb3ZpZGVkIG9yIHByb3ZpZGVzIGFuIG92ZXJhbGwgc29mdHdhcmUgcmV2aXNp" +
           "b24gbGV2ZWwuIFRoZSB2YWx1ZSBtaWdodCBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZlLWN5Y2xlIG9mIGEg" +
           "TWFjaGluZXJ5SXRlbS4ALgBEexcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAEgAAAFllYXJPZkNv" +
           "bnN0cnVjdGlvbgEBdBcDAAAAAMQAAABUaGUgeWVhciAoR3JlZ29yaWFuIGNhbGVuZGFyKSBpbiB3aGlj" +
           "aCB0aGUgbWFudWZhY3R1cmluZyBwcm9jZXNzIG9mIHRoZSBNYWNoaW5lcnlJdGVtIGhhcyBiZWVuIGNv" +
           "bXBsZXRlZC4gSXQgc2hhbGwgYmUgYSBmb3VyLWRpZ2l0IG51bWJlciBhbmQgbmV2ZXIgY2hhbmdlIGR1" +
           "cmluZyB0aGUgbGlmZS1jeWNsZSBvZiBhIE1hY2hpbmVyeUl0ZW0uAC4ARHQXAAAABf////8BAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> AssetId
        {
            get
            {
                return m_assetId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_assetId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetId = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> ComponentName
        {
            get
            {
                return m_componentName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentName = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceClass
        {
            get
            {
                return m_deviceClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }

        /// <remarks />
        public PropertyState<string> HardwareRevision
        {
            get
            {
                return m_hardwareRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hardwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hardwareRevision = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> InitialOperationDate
        {
            get
            {
                return m_initialOperationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_initialOperationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_initialOperationDate = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ManufacturerUri
        {
            get
            {
                return m_manufacturerUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturerUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturerUri = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <remarks />
        public PropertyState<byte> MonthOfConstruction
        {
            get
            {
                return m_monthOfConstruction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_monthOfConstruction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_monthOfConstruction = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProductCode
        {
            get
            {
                return m_productCode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productCode = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProductInstanceUri
        {
            get
            {
                return m_productInstanceUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productInstanceUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productInstanceUri = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SoftwareRevision
        {
            get
            {
                return m_softwareRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_softwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareRevision = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> YearOfConstruction
        {
            get
            {
                return m_yearOfConstruction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yearOfConstruction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yearOfConstruction = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_assetId != null)
            {
                children.Add(m_assetId);
            }

            if (m_componentName != null)
            {
                children.Add(m_componentName);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            if (m_hardwareRevision != null)
            {
                children.Add(m_hardwareRevision);
            }

            if (m_initialOperationDate != null)
            {
                children.Add(m_initialOperationDate);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_manufacturerUri != null)
            {
                children.Add(m_manufacturerUri);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_monthOfConstruction != null)
            {
                children.Add(m_monthOfConstruction);
            }

            if (m_productCode != null)
            {
                children.Add(m_productCode);
            }

            if (m_productInstanceUri != null)
            {
                children.Add(m_productInstanceUri);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_softwareRevision != null)
            {
                children.Add(m_softwareRevision);
            }

            if (m_yearOfConstruction != null)
            {
                children.Add(m_yearOfConstruction);
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
                case Opc.Ua.Di.BrowseNames.AssetId:
                {
                    if (createOrReplace)
                    {
                        if (AssetId == null)
                        {
                            if (replacement == null)
                            {
                                AssetId = new PropertyState<string>(this);
                            }
                            else
                            {
                                AssetId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AssetId;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ComponentName:
                {
                    if (createOrReplace)
                    {
                        if (ComponentName == null)
                        {
                            if (replacement == null)
                            {
                                ComponentName = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ComponentName = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ComponentName;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.HardwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (HardwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                HardwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                HardwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HardwareRevision;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.InitialOperationDate:
                {
                    if (createOrReplace)
                    {
                        if (InitialOperationDate == null)
                        {
                            if (replacement == null)
                            {
                                InitialOperationDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                InitialOperationDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = InitialOperationDate;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ManufacturerUri:
                {
                    if (createOrReplace)
                    {
                        if (ManufacturerUri == null)
                        {
                            if (replacement == null)
                            {
                                ManufacturerUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ManufacturerUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ManufacturerUri;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Model = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.MonthOfConstruction:
                {
                    if (createOrReplace)
                    {
                        if (MonthOfConstruction == null)
                        {
                            if (replacement == null)
                            {
                                MonthOfConstruction = new PropertyState<byte>(this);
                            }
                            else
                            {
                                MonthOfConstruction = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = MonthOfConstruction;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ProductCode:
                {
                    if (createOrReplace)
                    {
                        if (ProductCode == null)
                        {
                            if (replacement == null)
                            {
                                ProductCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductCode;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ProductInstanceUri:
                {
                    if (createOrReplace)
                    {
                        if (ProductInstanceUri == null)
                        {
                            if (replacement == null)
                            {
                                ProductInstanceUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductInstanceUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductInstanceUri;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.SoftwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareRevision;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.YearOfConstruction:
                {
                    if (createOrReplace)
                    {
                        if (YearOfConstruction == null)
                        {
                            if (replacement == null)
                            {
                                YearOfConstruction = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                YearOfConstruction = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = YearOfConstruction;
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
        private PropertyState<string> m_assetId;
        private PropertyState<LocalizedText> m_componentName;
        private PropertyState<string> m_deviceClass;
        private PropertyState<string> m_hardwareRevision;
        private PropertyState<DateTime> m_initialOperationDate;
        private PropertyState<LocalizedText> m_manufacturer;
        private PropertyState<string> m_manufacturerUri;
        private PropertyState<LocalizedText> m_model;
        private PropertyState<byte> m_monthOfConstruction;
        private PropertyState<string> m_productCode;
        private PropertyState<string> m_productInstanceUri;
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_softwareRevision;
        private PropertyState<ushort> m_yearOfConstruction;
        #endregion
    }
    #endif
    #endregion

    #region MachineIdentificationTypeState Class
    #if (!OPCUA_EXCLUDE_MachineIdentificationTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineIdentificationTypeState : MachineryItemIdentificationTypeState
    {
        #region Constructors
        /// <remarks />
        public MachineIdentificationTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineIdentificationType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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

            if (Location != null)
            {
                Location.Initialize(context, Location_InitializationString);
            }
        }

        #region Initialization String
        private const string Location_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAIAAAATG9jYXRpb24BAY0XAwAAAAAtAQAA" +
           "VG8gYmUgdXNlZCBieSBlbmQgdXNlcnMgdG8gc3RvcmUgdGhlIGxvY2F0aW9uIG9mIHRoZSBtYWNoaW5l" +
           "IGluIGEgc2NoZW1lIHNwZWNpZmljIHRvIHRoZSBlbmQgdXNlci4gU2VydmVycyBzaGFsbCBzdXBwb3J0" +
           "IGF0IGxlYXN0IDYwIFVuaWNvZGUgY2hhcmFjdGVycyBmb3IgdGhlIGNsaWVudHMgd3JpdGluZyB0aGlz" +
           "IHZhbHVlLCB0aGlzIG1lYW5zIGNsaWVudHMgY2FuIGV4cGVjdCB0byBiZSBhYmxlIHRvIHdyaXRlIHN0" +
           "cmluZ3Mgd2l0aCBhIGxlbmd0aCBvZiA2MCBVbmljb2RlIGNoYXJhY3RlcnMgaW50byB0aGF0IGZpZWxk" +
           "LgAuAESNFwAAAAz/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAhAAAATWFjaGluZUlkZW50aWZpY2F0aW9u" +
           "VHlwZUluc3RhbmNlAQH0AwEB9AP0AwAAAgAAAAEAw0QAAQHzAwEAw0QAAQHyAwQAAAA1YIkKAgAAAAIA" +
           "DAAAAE1hbnVmYWN0dXJlcgEBchcDAAAAAEoAAABBIGh1bWFuLXJlYWRhYmxlLCBsb2NhbGl6ZWQgbmFt" +
           "ZSBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBNYWNoaW5lcnlJdGVtLgAuAERyFwAAABX/////AQH/" +
           "////AAAAADVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQF/FwMAAAAAUQAAAEEgZ2xvYmFs" +
           "bHkgdW5pcXVlIHJlc291cmNlIGlkZW50aWZpZXIgcHJvdmlkZWQgYnkgdGhlIG1hbnVmYWN0dXJlciBv" +
           "ZiB0aGUgbWFjaGluZQAuAER/FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVt" +
           "YmVyAQFzFwMAAAAAFwEAAEEgc3RyaW5nIGNvbnRhaW5pbmcgYSB1bmlxdWUgcHJvZHVjdGlvbiBudW1i" +
           "ZXIgb2YgdGhlIG1hbnVmYWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4gVGhlIGdsb2JhbCB1bmlx" +
           "dWVuZXNzIG9mIHRoZSBzZXJpYWwgbnVtYmVyIGlzIG9ubHkgZ2l2ZW4gaW4gdGhlIGNvbnRleHQgb2Yg" +
           "dGhlIG1hbnVmYWN0dXJlciwgYW5kIHBvdGVudGlhbGx5IHRoZSBtb2RlbC4gVGhlIHZhbHVlIHNoYWxs" +
           "IG5vdCBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZlLWN5Y2xlIG9mIHRoZSBNYWNoaW5lcnlJdGVtLgAuAERz" +
           "FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAIAAAATG9jYXRpb24BAY0XAwAAAAAtAQAAVG8gYmUg" +
           "dXNlZCBieSBlbmQgdXNlcnMgdG8gc3RvcmUgdGhlIGxvY2F0aW9uIG9mIHRoZSBtYWNoaW5lIGluIGEg" +
           "c2NoZW1lIHNwZWNpZmljIHRvIHRoZSBlbmQgdXNlci4gU2VydmVycyBzaGFsbCBzdXBwb3J0IGF0IGxl" +
           "YXN0IDYwIFVuaWNvZGUgY2hhcmFjdGVycyBmb3IgdGhlIGNsaWVudHMgd3JpdGluZyB0aGlzIHZhbHVl" +
           "LCB0aGlzIG1lYW5zIGNsaWVudHMgY2FuIGV4cGVjdCB0byBiZSBhYmxlIHRvIHdyaXRlIHN0cmluZ3Mg" +
           "d2l0aCBhIGxlbmd0aCBvZiA2MCBVbmljb2RlIGNoYXJhY3RlcnMgaW50byB0aGF0IGZpZWxkLgAuAESN" +
           "FwAAAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Location
        {
            get
            {
                return m_location;
            }

            set
            {
                if (!Object.ReferenceEquals(m_location, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_location = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_location != null)
            {
                children.Add(m_location);
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
                case Opc.Ua.Machinery.BrowseNames.Location:
                {
                    if (createOrReplace)
                    {
                        if (Location == null)
                        {
                            if (replacement == null)
                            {
                                Location = new PropertyState<string>(this);
                            }
                            else
                            {
                                Location = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Location;
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
        private PropertyState<string> m_location;
        #endregion
    }
    #endif
    #endregion

    #region MachineryComponentIdentificationTypeState Class
    #if (!OPCUA_EXCLUDE_MachineryComponentIdentificationTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineryComponentIdentificationTypeState : MachineryItemIdentificationTypeState
    {
        #region Constructors
        /// <remarks />
        public MachineryComponentIdentificationTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineryComponentIdentificationType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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

            if (DeviceRevision != null)
            {
                DeviceRevision.Initialize(context, DeviceRevision_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceRevision_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAYEXAwAA" +
           "AAAIAQAAQSBzdHJpbmcgcmVwcmVzZW50YXRpb24gb2YgdGhlIG92ZXJhbGwgcmV2aXNpb24gbGV2ZWwg" +
           "b2YgdGhlIGNvbXBvbmVudC4gT2Z0ZW4sIGl0IGlzIGluY3JlYXNlZCB3aGVuIGVpdGhlciB0aGUgU29m" +
           "dHdhcmVSZXZpc2lvbiBhbmQgLyBvciB0aGUgSGFyZHdhcmVSZXZpc2lvbiBvZiB0aGUgY29tcG9uZW50" +
           "IGlzIGluY3JlYXNlZC4gQXMgYW4gZXhhbXBsZSwgaXQgY2FuIGJlIHVzZWQgaW4gRVJQIHN5c3RlbXMg" +
           "dG9nZXRoZXIgd2l0aCB0aGUgUHJvZHVjdENvZGUuAC4ARIEXAAAADP////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAsAAAATWFjaGluZXJ5Q29tcG9uZW50SWRl" +
           "bnRpZmljYXRpb25UeXBlSW5zdGFuY2UBAe0DAQHtA+0DAAD/////AwAAADVgiQoCAAAAAgAMAAAATWFu" +
           "dWZhY3R1cmVyAQFyFwMAAAAASgAAAEEgaHVtYW4tcmVhZGFibGUsIGxvY2FsaXplZCBuYW1lIG9mIHRo" +
           "ZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARHIXAAAAFf////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAXMXAwAAAAAXAQAAQSBzdHJpbmcgY29udGFpbmluZyBh" +
           "IHVuaXF1ZSBwcm9kdWN0aW9uIG51bWJlciBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBNYWNoaW5l" +
           "cnlJdGVtLiBUaGUgZ2xvYmFsIHVuaXF1ZW5lc3Mgb2YgdGhlIHNlcmlhbCBudW1iZXIgaXMgb25seSBn" +
           "aXZlbiBpbiB0aGUgY29udGV4dCBvZiB0aGUgbWFudWZhY3R1cmVyLCBhbmQgcG90ZW50aWFsbHkgdGhl" +
           "IG1vZGVsLiBUaGUgdmFsdWUgc2hhbGwgbm90IGNoYW5nZSBkdXJpbmcgdGhlIGxpZmUtY3ljbGUgb2Yg" +
           "dGhlIE1hY2hpbmVyeUl0ZW0uAC4ARHMXAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZp" +
           "Y2VSZXZpc2lvbgEBgRcDAAAAAAgBAABBIHN0cmluZyByZXByZXNlbnRhdGlvbiBvZiB0aGUgb3ZlcmFs" +
           "bCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgY29tcG9uZW50LiBPZnRlbiwgaXQgaXMgaW5jcmVhc2VkIHdo" +
           "ZW4gZWl0aGVyIHRoZSBTb2Z0d2FyZVJldmlzaW9uIGFuZCAvIG9yIHRoZSBIYXJkd2FyZVJldmlzaW9u" +
           "IG9mIHRoZSBjb21wb25lbnQgaXMgaW5jcmVhc2VkLiBBcyBhbiBleGFtcGxlLCBpdCBjYW4gYmUgdXNl" +
           "ZCBpbiBFUlAgc3lzdGVtcyB0b2dldGhlciB3aXRoIHRoZSBQcm9kdWN0Q29kZS4ALgBEgRcAAAAM////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> DeviceRevision
        {
            get
            {
                return m_deviceRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceRevision = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceRevision != null)
            {
                children.Add(m_deviceRevision);
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
                case Opc.Ua.Di.BrowseNames.DeviceRevision:
                {
                    if (createOrReplace)
                    {
                        if (DeviceRevision == null)
                        {
                            if (replacement == null)
                            {
                                DeviceRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceRevision;
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
        private PropertyState<string> m_deviceRevision;
        #endregion
    }
    #endif
    #endregion

    #region MachineryOperationCounterTypeState Class
    #if (!OPCUA_EXCLUDE_MachineryOperationCounterTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineryOperationCounterTypeState : FunctionalGroupTypeState
    {
        #region Constructors
        /// <remarks />
        public MachineryOperationCounterTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineryOperationCounterType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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

            if (OperationCycleCounter != null)
            {
                OperationCycleCounter.Initialize(context, OperationCycleCounter_InitializationString);
            }

            if (OperationDuration != null)
            {
                OperationDuration.Initialize(context, OperationDuration_InitializationString);
            }

            if (PowerOnDuration != null)
            {
                PowerOnDuration.Initialize(context, PowerOnDuration_InitializationString);
            }
        }

        #region Initialization String
        private const string OperationCycleCounter_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAVAAAAT3BlcmF0aW9uQ3ljbGVDb3VudGVy" +
           "AQHBFwMAAAAAMwEAAE9wZXJhdGlvbkN5Y2xlQ291bnRlciBpcyBjb3VudGluZyB0aGUgdGltZXMgdGhl" +
           "IGNvbXBvbmVudCBzd2l0Y2hlcyBmcm9tIG5vdCBwZXJmb3JtaW5nIGFuIGFjdGl2aXR5IHRvIHBlcmZv" +
           "cm1pbmcgYW4gYWN0aXZpdHkuIEZvciBleGFtcGxlLCBlYWNoIHRpbWUgYSB2YWx2ZSBzdGFydHMgbW92" +
           "aW5nLCBpcyBjb3VudGVkLiBUaGlzIHZhbHVlIHNoYWxsIG9ubHkgaW5jcmVhc2UgZHVyaW5nIHRoZSBs" +
           "aWZldGltZSBvZiB0aGUgY29tcG9uZW50IGFuZCBzaGFsbCBub3QgYmUgcmVzZXQgd2hlbiB0aGUgY29t" +
           "cG9uZW50IGlzIHJlc3RhcnRlZC4ALgBEwRcAAAAc/////wMD/////wAAAAA=";

        private const string OperationDuration_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgARAAAAT3BlcmF0aW9uRHVyYXRpb24BAcAX" +
           "AwAAAAD6AgAAT3BlcmF0aW9uRHVyYXRpb24gaXMgdGhlIGR1cmF0aW9uIHRoZSBNYWNoaW5lcnlJdGVt" +
           "IGhhcyBiZWVuIHBvd2VyZWQgYW5kIHBlcmZvcm1pbmcgYW4gYWN0aXZpdHkuIFRoaXMgY291bnRlciBp" +
           "cyBpbnRlbmRlZCBmb3IgbWFjaGluZXMgYW5kIGNvbXBvbmVudHMgd2hlcmUgYSBkaXN0aW5jdGlvbiBp" +
           "cyBtYWRlIGJldHdlZW4gc3dpdGNoZWQgb24gYW5kIGluIG9wZXJhdGlvbi4gRm9yIGV4YW1wbGUsIGEg" +
           "ZHJpdmUgbWlnaHQgYmUgcG93ZXJlZCBvbiBidXQgbm90IG9wZXJhdGluZy4gSXQgaXMgbm90IGludGVu" +
           "ZGVkIGZvciBtYWNoaW5lcyBvciBjb21wb25lbnRzIGFsd2F5cyBwZXJmb3JtaW5nIGFuIGFjdGl2aXR5" +
           "IGxpa2Ugc2Vuc29ycyBhbHdheXMgbWVhc3VyaW5nIGRhdGEuIFRoaXMgdmFsdWUgc2hhbGwgb25seSBp" +
           "bmNyZWFzZSBkdXJpbmcgdGhlIGxpZmV0aW1lIG9mIHRoZSBNYWNoaW5lcnlJdGVtIGFuZCBzaGFsbCBu" +
           "b3QgYmUgcmVzZXQgd2hlbiBpdCBpcyByZXN0YXJ0ZWQuIFRoZSBPcGVyYXRpb25EdXJhdGlvbiBpcyBw" +
           "cm92aWRlZCBhcyBEdXJhdGlvbiwgaS5lLiwgaW4gbWlsbGlzZWNvbmRzIG9yIGV2ZW4gZnJhY3Rpb25z" +
           "IG9mIGEgbWlsbGlzZWNvbmQuIEhvd2V2ZXIsIHRoZSBTZXJ2ZXIgaXMgbm90IGV4cGVjdGVkIHRvIHVw" +
           "ZGF0ZSB0aGUgdmFsdWUgaW4gc3VjaCBhIGhpZ2ggZnJlcXVlbmN5LCBidXQgbWF5YmUgb25jZSBhIG1p" +
           "bnV0ZSBvciBvbmNlIGFuIGhvdXIsIGRlcGVuZGluZyBvbiB0aGUgYXBwbGljYXRpb24uAC4ARMAXAAAB" +
           "ACIB/////wMD/////wAAAAA=";

        private const string PowerOnDuration_InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAgAPAAAAUG93ZXJPbkR1cmF0aW9uAQG/FwMA" +
           "AAAARQMAAFBvd2VyT25EdXJhdGlvbiBpcyB0aGUgZHVyYXRpb24gdGhlIE1hY2hpbmVyeUl0ZW0gaGFz" +
           "IGJlZW4gcG93ZXJlZC4gVGhlIG1haW4gcHVycG9zZSBpcyB0byBkZXRlcm1pbmUgdGhlIHRpbWUgaW4g" +
           "d2hpY2ggZGVncmFkYXRpb24gb2YgdGhlIE1hY2hpbmVyeUl0ZW0gb2NjdXJyZWQuIFRoZSBkZXRhaWxz" +
           "LCB3aGVuIHRoZSB0aW1lIGlzIGNvdW50ZWQsIGlzIGltcGxlbWVudGF0aW9uLXNwZWNpZmljLiBDb21w" +
           "YW5pb24gc3BlY2lmaWNhdGlvbnMgbWlnaHQgZGVmaW5lIHNwZWNpZmljIHJ1bGVzLiBUeXBpY2FsbHks" +
           "IHdoZW4gdGhlIE1hY2hpbmVyeUl0ZW0gaGFzIHN1cHBseSB2b2x0YWdlIGFuZCB0aGUgbWFpbiBDUFUg" +
           "aXMgcnVubmluZywgdGhlIHRpbWUgaXMgY291bnRlZC4gVGhpcyBtYXkgaW5jbHVkZSBhbnkga2luZCBv" +
           "ZiBzbGVlcCBtb2RlLCBidXQgbWF5IG5vdCBpbmNsdWRlIHB1cmUgV2FrZSBvbiBMQU4uIFRoaXMgdmFs" +
           "dWUgc2hhbGwgb25seSBpbmNyZWFzZSBkdXJpbmcgdGhlIGxpZmV0aW1lIG9mIHRoZSBNYWNoaW5lcnlJ" +
           "dGVtIGFuZCBzaGFsbCBub3QgYmUgcmVzZXQgd2hlbiBpdCBpcyByZXN0YXJ0ZWQuIFRoZSBQb3dlck9u" +
           "RHVyYXRpb24gaXMgcHJvdmlkZWQgYXMgRHVyYXRpb24sIGkuZS4sIGluIG1pbGxpc2Vjb25kcyBvciBl" +
           "dmVuIGZyYWN0aW9ucyBvZiBhIG1pbGxpc2Vjb25kLiBIb3dldmVyLCB0aGUgU2VydmVyIGlzIG5vdCBl" +
           "eHBlY3RlZCB0byB1cGRhdGUgdGhlIHZhbHVlIGluIHN1Y2ggYSBoaWdoIGZyZXF1ZW5jeSwgYnV0IG1h" +
           "eWJlIG9uY2UgYSBtaW51dGUgb3Igb25jZSBhbiBob3VyLCBkZXBlbmRpbmcgb24gdGhlIGFwcGxpY2F0" +
           "aW9uLgAuAES/FwAAAQAiAf////8DA/////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAlAAAATWFjaGluZXJ5T3BlcmF0aW9uQ291" +
           "bnRlclR5cGVJbnN0YW5jZQEB8QMBAfED8QMAAAEAAAABAMNEAAEC4AEDAAAANWCJCgIAAAACABUAAABP" +
           "cGVyYXRpb25DeWNsZUNvdW50ZXIBAcEXAwAAAAAzAQAAT3BlcmF0aW9uQ3ljbGVDb3VudGVyIGlzIGNv" +
           "dW50aW5nIHRoZSB0aW1lcyB0aGUgY29tcG9uZW50IHN3aXRjaGVzIGZyb20gbm90IHBlcmZvcm1pbmcg" +
           "YW4gYWN0aXZpdHkgdG8gcGVyZm9ybWluZyBhbiBhY3Rpdml0eS4gRm9yIGV4YW1wbGUsIGVhY2ggdGlt" +
           "ZSBhIHZhbHZlIHN0YXJ0cyBtb3ZpbmcsIGlzIGNvdW50ZWQuIFRoaXMgdmFsdWUgc2hhbGwgb25seSBp" +
           "bmNyZWFzZSBkdXJpbmcgdGhlIGxpZmV0aW1lIG9mIHRoZSBjb21wb25lbnQgYW5kIHNoYWxsIG5vdCBi" +
           "ZSByZXNldCB3aGVuIHRoZSBjb21wb25lbnQgaXMgcmVzdGFydGVkLgAuAETBFwAAABz/////AwP/////" +
           "AAAAADVgiQoCAAAAAgARAAAAT3BlcmF0aW9uRHVyYXRpb24BAcAXAwAAAAD6AgAAT3BlcmF0aW9uRHVy" +
           "YXRpb24gaXMgdGhlIGR1cmF0aW9uIHRoZSBNYWNoaW5lcnlJdGVtIGhhcyBiZWVuIHBvd2VyZWQgYW5k" +
           "IHBlcmZvcm1pbmcgYW4gYWN0aXZpdHkuIFRoaXMgY291bnRlciBpcyBpbnRlbmRlZCBmb3IgbWFjaGlu" +
           "ZXMgYW5kIGNvbXBvbmVudHMgd2hlcmUgYSBkaXN0aW5jdGlvbiBpcyBtYWRlIGJldHdlZW4gc3dpdGNo" +
           "ZWQgb24gYW5kIGluIG9wZXJhdGlvbi4gRm9yIGV4YW1wbGUsIGEgZHJpdmUgbWlnaHQgYmUgcG93ZXJl" +
           "ZCBvbiBidXQgbm90IG9wZXJhdGluZy4gSXQgaXMgbm90IGludGVuZGVkIGZvciBtYWNoaW5lcyBvciBj" +
           "b21wb25lbnRzIGFsd2F5cyBwZXJmb3JtaW5nIGFuIGFjdGl2aXR5IGxpa2Ugc2Vuc29ycyBhbHdheXMg" +
           "bWVhc3VyaW5nIGRhdGEuIFRoaXMgdmFsdWUgc2hhbGwgb25seSBpbmNyZWFzZSBkdXJpbmcgdGhlIGxp" +
           "ZmV0aW1lIG9mIHRoZSBNYWNoaW5lcnlJdGVtIGFuZCBzaGFsbCBub3QgYmUgcmVzZXQgd2hlbiBpdCBp" +
           "cyByZXN0YXJ0ZWQuIFRoZSBPcGVyYXRpb25EdXJhdGlvbiBpcyBwcm92aWRlZCBhcyBEdXJhdGlvbiwg" +
           "aS5lLiwgaW4gbWlsbGlzZWNvbmRzIG9yIGV2ZW4gZnJhY3Rpb25zIG9mIGEgbWlsbGlzZWNvbmQuIEhv" +
           "d2V2ZXIsIHRoZSBTZXJ2ZXIgaXMgbm90IGV4cGVjdGVkIHRvIHVwZGF0ZSB0aGUgdmFsdWUgaW4gc3Vj" +
           "aCBhIGhpZ2ggZnJlcXVlbmN5LCBidXQgbWF5YmUgb25jZSBhIG1pbnV0ZSBvciBvbmNlIGFuIGhvdXIs" +
           "IGRlcGVuZGluZyBvbiB0aGUgYXBwbGljYXRpb24uAC4ARMAXAAABACIB/////wMD/////wAAAAA1YIkK" +
           "AgAAAAIADwAAAFBvd2VyT25EdXJhdGlvbgEBvxcDAAAAAEUDAABQb3dlck9uRHVyYXRpb24gaXMgdGhl" +
           "IGR1cmF0aW9uIHRoZSBNYWNoaW5lcnlJdGVtIGhhcyBiZWVuIHBvd2VyZWQuIFRoZSBtYWluIHB1cnBv" +
           "c2UgaXMgdG8gZGV0ZXJtaW5lIHRoZSB0aW1lIGluIHdoaWNoIGRlZ3JhZGF0aW9uIG9mIHRoZSBNYWNo" +
           "aW5lcnlJdGVtIG9jY3VycmVkLiBUaGUgZGV0YWlscywgd2hlbiB0aGUgdGltZSBpcyBjb3VudGVkLCBp" +
           "cyBpbXBsZW1lbnRhdGlvbi1zcGVjaWZpYy4gQ29tcGFuaW9uIHNwZWNpZmljYXRpb25zIG1pZ2h0IGRl" +
           "ZmluZSBzcGVjaWZpYyBydWxlcy4gVHlwaWNhbGx5LCB3aGVuIHRoZSBNYWNoaW5lcnlJdGVtIGhhcyBz" +
           "dXBwbHkgdm9sdGFnZSBhbmQgdGhlIG1haW4gQ1BVIGlzIHJ1bm5pbmcsIHRoZSB0aW1lIGlzIGNvdW50" +
           "ZWQuIFRoaXMgbWF5IGluY2x1ZGUgYW55IGtpbmQgb2Ygc2xlZXAgbW9kZSwgYnV0IG1heSBub3QgaW5j" +
           "bHVkZSBwdXJlIFdha2Ugb24gTEFOLiBUaGlzIHZhbHVlIHNoYWxsIG9ubHkgaW5jcmVhc2UgZHVyaW5n" +
           "IHRoZSBsaWZldGltZSBvZiB0aGUgTWFjaGluZXJ5SXRlbSBhbmQgc2hhbGwgbm90IGJlIHJlc2V0IHdo" +
           "ZW4gaXQgaXMgcmVzdGFydGVkLiBUaGUgUG93ZXJPbkR1cmF0aW9uIGlzIHByb3ZpZGVkIGFzIER1cmF0" +
           "aW9uLCBpLmUuLCBpbiBtaWxsaXNlY29uZHMgb3IgZXZlbiBmcmFjdGlvbnMgb2YgYSBtaWxsaXNlY29u" +
           "ZC4gSG93ZXZlciwgdGhlIFNlcnZlciBpcyBub3QgZXhwZWN0ZWQgdG8gdXBkYXRlIHRoZSB2YWx1ZSBp" +
           "biBzdWNoIGEgaGlnaCBmcmVxdWVuY3ksIGJ1dCBtYXliZSBvbmNlIGEgbWludXRlIG9yIG9uY2UgYW4g" +
           "aG91ciwgZGVwZW5kaW5nIG9uIHRoZSBhcHBsaWNhdGlvbi4ALgBEvxcAAAEAIgH/////AwP/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState OperationCycleCounter
        {
            get
            {
                return m_operationCycleCounter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationCycleCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationCycleCounter = value;
            }
        }

        /// <remarks />
        public PropertyState<double> OperationDuration
        {
            get
            {
                return m_operationDuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationDuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationDuration = value;
            }
        }

        /// <remarks />
        public PropertyState<double> PowerOnDuration
        {
            get
            {
                return m_powerOnDuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerOnDuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerOnDuration = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_operationCycleCounter != null)
            {
                children.Add(m_operationCycleCounter);
            }

            if (m_operationDuration != null)
            {
                children.Add(m_operationDuration);
            }

            if (m_powerOnDuration != null)
            {
                children.Add(m_powerOnDuration);
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
                case Opc.Ua.Di.BrowseNames.OperationCycleCounter:
                {
                    if (createOrReplace)
                    {
                        if (OperationCycleCounter == null)
                        {
                            if (replacement == null)
                            {
                                OperationCycleCounter = new PropertyState(this);
                            }
                            else
                            {
                                OperationCycleCounter = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = OperationCycleCounter;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.OperationDuration:
                {
                    if (createOrReplace)
                    {
                        if (OperationDuration == null)
                        {
                            if (replacement == null)
                            {
                                OperationDuration = new PropertyState<double>(this);
                            }
                            else
                            {
                                OperationDuration = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = OperationDuration;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.PowerOnDuration:
                {
                    if (createOrReplace)
                    {
                        if (PowerOnDuration == null)
                        {
                            if (replacement == null)
                            {
                                PowerOnDuration = new PropertyState<double>(this);
                            }
                            else
                            {
                                PowerOnDuration = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = PowerOnDuration;
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
        private PropertyState m_operationCycleCounter;
        private PropertyState<double> m_operationDuration;
        private PropertyState<double> m_powerOnDuration;
        #endregion
    }
    #endif
    #endregion

    #region MachineryLifetimeCounterTypeState Class
    #if (!OPCUA_EXCLUDE_MachineryLifetimeCounterTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineryLifetimeCounterTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public MachineryLifetimeCounterTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineryLifetimeCounterType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAATWFjaGluZXJ5TGlmZXRpbWVDb3Vu" +
           "dGVyVHlwZUluc3RhbmNlAQH3AwEB9wP3AwAA/////wAAAAA=";
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

    #region MachineComponentsTypeState Class
    #if (!OPCUA_EXCLUDE_MachineComponentsTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineComponentsTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MachineComponentsTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineComponentsType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAdAAAATWFjaGluZUNvbXBvbmVudHNUeXBl" +
           "SW5zdGFuY2UBAe4DAQHuA+4DAAD/////AAAAAA==";
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

    #region MachineryItemState_StateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_MachineryItemState_StateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineryItemState_StateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public MachineryItemState_StateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineryItemState_StateMachineType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQArAAAATWFjaGluZXJ5SXRlbVN0YXRlX1N0" +
           "YXRlTWFjaGluZVR5cGVJbnN0YW5jZQEB6gMBAeoD6gMAAP////8BAAAAFWCJCAIAAAAAAAwAAABDdXJy" +
           "ZW50U3RhdGUBAQAAAC8BAMgKABX/////AQH/////AQAAABVgiQgCAAAAAAACAAAASWQBAQAAAC4ARAAR" +
           "/////wEB/////wAAAAA=";
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

    #region MachineryOperationModeStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_MachineryOperationModeStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineryOperationModeStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public MachineryOperationModeStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Machinery.ObjectTypes.MachineryOperationModeStateMachineType, Opc.Ua.Machinery.Namespaces.MBBB, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAuAAAATWFjaGluZXJ5T3BlcmF0aW9uTW9k" +
           "ZVN0YXRlTWFjaGluZVR5cGVJbnN0YW5jZQEB8AMBAfAD8AMAAP////8BAAAAFWCJCAIAAAAAAAwAAABD" +
           "dXJyZW50U3RhdGUBAQAAAC8BAMgKABX/////AQH/////AQAAABVgiQgCAAAAAAACAAAASWQBAQAAAC4A" +
           "RAAR/////wEB/////wAAAAA=";
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
}