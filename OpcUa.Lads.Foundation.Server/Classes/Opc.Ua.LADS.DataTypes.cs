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
using Opc.Ua.Machinery;
using Opc.Ua.AMB;

namespace Opc.Ua.LADS
{
    #region KeyValueType Class
    #if (!OPCUA_EXCLUDE_KeyValueType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.LADS.Namespaces.LADS)]
    public partial class KeyValueType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public KeyValueType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_key = null;
            m_value = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Key", IsRequired = false, Order = 1)]
        public string Key
        {
            get { return m_key;  }
            set { m_key = value; }
        }

        /// <remarks />
        [DataMember(Name = "Value", IsRequired = false, Order = 2)]
        public string Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.KeyValueType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.KeyValueType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.KeyValueType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.KeyValueType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.LADS.Namespaces.LADS);

            encoder.WriteString("Key", Key);
            encoder.WriteString("Value", Value);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.LADS.Namespaces.LADS);

            Key = decoder.ReadString("Key");
            Value = decoder.ReadString("Value");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            KeyValueType value = encodeable as KeyValueType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_key, value.m_key)) return false;
            if (!Utils.IsEqual(m_value, value.m_value)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (KeyValueType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            KeyValueType clone = (KeyValueType)base.MemberwiseClone();

            clone.m_key = (string)Utils.Clone(this.m_key);
            clone.m_value = (string)Utils.Clone(this.m_value);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_key;
        private string m_value;
        #endregion
    }

    #region KeyValueTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfKeyValueType", Namespace = Opc.Ua.LADS.Namespaces.LADS, ItemName = "KeyValueType")]
    public partial class KeyValueTypeCollection : List<KeyValueType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public KeyValueTypeCollection() {}

        /// <remarks />
        public KeyValueTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public KeyValueTypeCollection(IEnumerable<KeyValueType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator KeyValueTypeCollection(KeyValueType[] values)
        {
            if (values != null)
            {
                return new KeyValueTypeCollection(values);
            }

            return new KeyValueTypeCollection();
        }

        /// <remarks />
        public static explicit operator KeyValueType[](KeyValueTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (KeyValueTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            KeyValueTypeCollection clone = new KeyValueTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((KeyValueType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SampleInfoType Class
    #if (!OPCUA_EXCLUDE_SampleInfoType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.LADS.Namespaces.LADS)]
    public partial class SampleInfoType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public SampleInfoType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_containerId = null;
            m_sampleId = null;
            m_position = null;
            m_customData = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "ContainerId", IsRequired = false, Order = 1)]
        public string ContainerId
        {
            get { return m_containerId;  }
            set { m_containerId = value; }
        }

        /// <remarks />
        [DataMember(Name = "SampleId", IsRequired = false, Order = 2)]
        public string SampleId
        {
            get { return m_sampleId;  }
            set { m_sampleId = value; }
        }

        /// <remarks />
        [DataMember(Name = "Position", IsRequired = false, Order = 3)]
        public string Position
        {
            get { return m_position;  }
            set { m_position = value; }
        }

        /// <remarks />
        [DataMember(Name = "CustomData", IsRequired = false, Order = 4)]
        public string CustomData
        {
            get { return m_customData;  }
            set { m_customData = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.SampleInfoType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.SampleInfoType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.SampleInfoType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.SampleInfoType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.LADS.Namespaces.LADS);

            encoder.WriteString("ContainerId", ContainerId);
            encoder.WriteString("SampleId", SampleId);
            encoder.WriteString("Position", Position);
            encoder.WriteString("CustomData", CustomData);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.LADS.Namespaces.LADS);

            ContainerId = decoder.ReadString("ContainerId");
            SampleId = decoder.ReadString("SampleId");
            Position = decoder.ReadString("Position");
            CustomData = decoder.ReadString("CustomData");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SampleInfoType value = encodeable as SampleInfoType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_containerId, value.m_containerId)) return false;
            if (!Utils.IsEqual(m_sampleId, value.m_sampleId)) return false;
            if (!Utils.IsEqual(m_position, value.m_position)) return false;
            if (!Utils.IsEqual(m_customData, value.m_customData)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (SampleInfoType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleInfoType clone = (SampleInfoType)base.MemberwiseClone();

            clone.m_containerId = (string)Utils.Clone(this.m_containerId);
            clone.m_sampleId = (string)Utils.Clone(this.m_sampleId);
            clone.m_position = (string)Utils.Clone(this.m_position);
            clone.m_customData = (string)Utils.Clone(this.m_customData);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_containerId;
        private string m_sampleId;
        private string m_position;
        private string m_customData;
        #endregion
    }

    #region SampleInfoTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSampleInfoType", Namespace = Opc.Ua.LADS.Namespaces.LADS, ItemName = "SampleInfoType")]
    public partial class SampleInfoTypeCollection : List<SampleInfoType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public SampleInfoTypeCollection() {}

        /// <remarks />
        public SampleInfoTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public SampleInfoTypeCollection(IEnumerable<SampleInfoType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator SampleInfoTypeCollection(SampleInfoType[] values)
        {
            if (values != null)
            {
                return new SampleInfoTypeCollection(values);
            }

            return new SampleInfoTypeCollection();
        }

        /// <remarks />
        public static explicit operator SampleInfoType[](SampleInfoTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (SampleInfoTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SampleInfoTypeCollection clone = new SampleInfoTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SampleInfoType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MaintenanceTaskResultEnum Enumeration
    #if (!OPCUA_EXCLUDE_MaintenanceTaskResultEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.LADS.Namespaces.LADS)]
    public enum MaintenanceTaskResultEnum
    {
        /// <remarks />
        [EnumMember(Value = "Success_0")]
        Success = 0,

        /// <remarks />
        [EnumMember(Value = "Failure_1")]
        Failure = 1,

        /// <remarks />
        [EnumMember(Value = "Undetermined_2")]
        Undetermined = 2,
    }

    #region MaintenanceTaskResultEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMaintenanceTaskResultEnum", Namespace = Opc.Ua.LADS.Namespaces.LADS, ItemName = "MaintenanceTaskResultEnum")]
    public partial class MaintenanceTaskResultEnumCollection : List<MaintenanceTaskResultEnum>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public MaintenanceTaskResultEnumCollection() {}

        /// <remarks />
        public MaintenanceTaskResultEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public MaintenanceTaskResultEnumCollection(IEnumerable<MaintenanceTaskResultEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator MaintenanceTaskResultEnumCollection(MaintenanceTaskResultEnum[] values)
        {
            if (values != null)
            {
                return new MaintenanceTaskResultEnumCollection(values);
            }

            return new MaintenanceTaskResultEnumCollection();
        }

        /// <remarks />
        public static explicit operator MaintenanceTaskResultEnum[](MaintenanceTaskResultEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (MaintenanceTaskResultEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MaintenanceTaskResultEnumCollection clone = new MaintenanceTaskResultEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MaintenanceTaskResultEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}