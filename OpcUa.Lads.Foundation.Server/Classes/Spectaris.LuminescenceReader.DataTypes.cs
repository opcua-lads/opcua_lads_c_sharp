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
using Opc.Ua.AMB;
using Opc.Ua.Machinery;
using Opc.Ua.LADS;

namespace Spectaris.LuminescenceReader
{
    #region InjectorModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_InjectorModeEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Spectaris.LuminescenceReader.Namespaces.LuminescenceReader)]
    public enum InjectorModeEnum
    {
        /// <remarks />
        [EnumMember(Value = "PerPlate_0")]
        PerPlate = 0,

        /// <remarks />
        [EnumMember(Value = "PerWell_1")]
        PerWell = 1,
    }

    #region InjectorModeEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfInjectorModeEnum", Namespace = Spectaris.LuminescenceReader.Namespaces.LuminescenceReader, ItemName = "InjectorModeEnum")]
    public partial class InjectorModeEnumCollection : List<InjectorModeEnum>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public InjectorModeEnumCollection() {}

        /// <remarks />
        public InjectorModeEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public InjectorModeEnumCollection(IEnumerable<InjectorModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator InjectorModeEnumCollection(InjectorModeEnum[] values)
        {
            if (values != null)
            {
                return new InjectorModeEnumCollection(values);
            }

            return new InjectorModeEnumCollection();
        }

        /// <remarks />
        public static explicit operator InjectorModeEnum[](InjectorModeEnumCollection values)
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
            return (InjectorModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            InjectorModeEnumCollection clone = new InjectorModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((InjectorModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ShakerModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ShakerModeEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Spectaris.LuminescenceReader.Namespaces.LuminescenceReader)]
    public enum ShakerModeEnum
    {
        /// <remarks />
        [EnumMember(Value = "Linear_0")]
        Linear = 0,

        /// <remarks />
        [EnumMember(Value = "Orbital_1")]
        Orbital = 1,

        /// <remarks />
        [EnumMember(Value = "DoubleOrbital_2")]
        DoubleOrbital = 2,
    }

    #region ShakerModeEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfShakerModeEnum", Namespace = Spectaris.LuminescenceReader.Namespaces.LuminescenceReader, ItemName = "ShakerModeEnum")]
    public partial class ShakerModeEnumCollection : List<ShakerModeEnum>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public ShakerModeEnumCollection() {}

        /// <remarks />
        public ShakerModeEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ShakerModeEnumCollection(IEnumerable<ShakerModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ShakerModeEnumCollection(ShakerModeEnum[] values)
        {
            if (values != null)
            {
                return new ShakerModeEnumCollection(values);
            }

            return new ShakerModeEnumCollection();
        }

        /// <remarks />
        public static explicit operator ShakerModeEnum[](ShakerModeEnumCollection values)
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
            return (ShakerModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ShakerModeEnumCollection clone = new ShakerModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ShakerModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}