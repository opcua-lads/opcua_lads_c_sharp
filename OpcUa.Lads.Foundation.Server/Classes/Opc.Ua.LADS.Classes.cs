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
    #region ActiveProgramTypeState Class
    #if (!OPCUA_EXCLUDE_ActiveProgramTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActiveProgramTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ActiveProgramTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ActiveProgramType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (CurrentPauseTime != null)
            {
                CurrentPauseTime.Initialize(context, CurrentPauseTime_InitializationString);
            }

            if (CurrentRuntime != null)
            {
                CurrentRuntime.Initialize(context, CurrentRuntime_InitializationString);
            }

            if (CurrentStepName != null)
            {
                CurrentStepName.Initialize(context, CurrentStepName_InitializationString);
            }

            if (CurrentStepNumber != null)
            {
                CurrentStepNumber.Initialize(context, CurrentStepNumber_InitializationString);
            }

            if (CurrentStepRuntime != null)
            {
                CurrentStepRuntime.Initialize(context, CurrentStepRuntime_InitializationString);
            }

            if (EstimatedRuntime != null)
            {
                EstimatedRuntime.Initialize(context, EstimatedRuntime_InitializationString);
            }

            if (EstimatedStepNumbers != null)
            {
                EstimatedStepNumbers.Initialize(context, EstimatedStepNumbers_InitializationString);
            }

            if (EstimatedStepRuntime != null)
            {
                EstimatedStepRuntime.Initialize(context, EstimatedStepRuntime_InitializationString);
            }

            if (DeviceProgramRunId != null)
            {
                DeviceProgramRunId.Initialize(context, DeviceProgramRunId_InitializationString);
            }

            if (CurrentProgramTemplate != null)
            {
                CurrentProgramTemplate.Initialize(context, CurrentProgramTemplate_InitializationString);
            }
        }

        #region Initialization String
        private const string CurrentPauseTime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEAAAAEN1cnJlbnRQ" +
           "YXVzZVRpbWUBASQYAwAAAAAMAQAAQ3VycmVudFBhdXNlVGltZSBpcyB0aGUgY3VycmVudCBwYXVzZS10" +
           "aW1lIG9mIHRoZSBwcm9ncmFtLSBydW4uIFRoZSBDdXJyZW50UGF1c2VUaW1lIGlzIHNldCB0byAwIGF0" +
           "IHRoZSBzdGFydCBvZiB0aGUgcHJvZ3JhbSBhbmQgaXMgY291bnRlZCB1cHdhcmRzIHdoZW4gdGhlIHBy" +
           "b2dyYW0gcnVuIGlzIGluIGEgUGF1c2VkIHN0YXRlLiBUaGUgUGF1c2VkIHN0YXRlIGlzIGFuIGFnZ3Jl" +
           "Z2F0aW9uIG9mIHRoZSBTdXNwZW5kZWQgc3RhdGUgYW5kIHRoZSBIZWxkIFN0YXRlLgAuAEQkGAAAAQAi" +
           "Af////8BAf////8AAAAA";

        private const string CurrentRuntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEADgAAAEN1cnJlbnRS" +
           "dW50aW1lAQETGAMAAAAAEAEAAEN1cnJlbnRSdW50aW1lIGlzIHRoZSBjdXJyZW50IHJ1bi10aW1lIG9m" +
           "IHRoZSBwcm9ncmFtIC1ydW4uIFRoZSBDdXJyZW50UnVuVGltZSBpcyBzZXQgdG8gMCBhdCB0aGUgc3Rh" +
           "cnQgb2YgdGhlIHByb2dyYW0gYW5kIGlzIGNvdW50ZWQgdXB3YXJkcyBhcyBsb25nIGFzIHRoZSBwcm9n" +
           "cmFtIHJ1biBpcyBub3QgaW4gYSBQYXVzZWQgc3RhdGUuIFRoZSBQYXVzZWQgc3RhdGUgaXMgYW4gYWdn" +
           "cmVnYXRpb24gb2YgdGhlIFN1c3BlbmRlZCBzdGF0ZSBhbmQgdGhlIEhlbGQgc3RhdGUuAC4ARBMYAAAB" +
           "ACIB/////wEB/////wAAAAA=";

        private const string CurrentStepName_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEADwAAAEN1cnJlbnRT" +
           "dGVwTmFtZQEBKBgDAAAAADAAAABDdXJyZW50U3RlcE5hbWUgaXMgdGhlIG5hbWUgb2YgdGhlIGN1cnJl" +
           "bnQgc3RlcC4ALgBEKBgAAAAV/////wEB/////wAAAAA=";

        private const string CurrentStepNumber_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEQAAAEN1cnJlbnRT" +
           "dGVwTnVtYmVyAQEpGAMAAAAAjwAAAEN1cnJlbnRTdGVwTnVtYmVyIGlzIHRoZSBudW1iZXIvaW5kZXgg" +
           "b2YgdGhlIGN1cnJlbnQgc3RlcCAoaW5jcmVtZW50ZWQgd2hlbmV2ZXIgdGhlIG5leHQgc3RlcCBpcyBl" +
           "bnRlcmVkKS4gVGhlIEN1cnJlbnRTdGVwTnVtYmVyIHN0YXJ0cyB3aXRoIDEuAC4ARCkYAAAAB/////8B" +
           "Af////8AAAAA";

        private const string CurrentStepRuntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEgAAAEN1cnJlbnRT" +
           "dGVwUnVudGltZQEBKhgDAAAAABIBAABDdXJyZW50U3RlcFJ1bnRpbWUgaXMgdGhlIHJ1bnRpbWUgb2Yg" +
           "dGhlIGN1cnJlbnQgc3RlcC4gVGhlIEN1cnJlbnRTdGVwUnVuVGltZSBpcyBzZXQgdG8gMCBhdCB0aGUg" +
           "c3RhcnQgb2YgdGhlIGN1cnJlbnQgc3RlcCBhbmQgaXMgY291bnRlZCB1cHdhcmRzIGFzIGxvbmcgYXMg" +
           "dGhlIHByb2dyYW0gcnVuIGlzIG5vdCBpbiBQYXVzZWQgc3RhdGUuIFRoZSBQYXVzZWQgc3RhdGUgaXMg" +
           "YW4gYWdncmVnYXRpb24gb2YgdGhlIFN1c3BlbmRlZCBzdGF0ZSBhbmQgdGhlIEhlbGQgU3RhdGUuAC4A" +
           "RCoYAAABACIB/////wEB/////wAAAAA=";

        private const string EstimatedRuntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEAAAAEVzdGltYXRl" +
           "ZFJ1bnRpbWUBAQ8YAwAAAACTAAAARXN0aW1hdGVkUnVudGltZSBpcyB0aGUgZXN0aW1hdGVkIHJ1bi10" +
           "aW1lIG9mIHRoZSBjdXJyZW50IHByb2dyYW0gcnVuLiBJZiB0aGUgcnVudGltZSBjYW5ub3QgYmUgZXN0" +
           "aW1hdGVkLCB0aGUgU3RhdHVzQ29kZSBCYWROb0RhdGEgc2hvdWxkIGJlIHNlbnQuAC4ARA8YAAABACIB" +
           "/////wEB/////wAAAAA=";

        private const string EstimatedStepNumbers_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAFAAAAEVzdGltYXRl" +
           "ZFN0ZXBOdW1iZXJzAQESGAMAAAAAqgAAAEVzdGltYXRlZFN0ZXBOdW1iZXJzIGFyZSB0aGUgZXN0aW1h" +
           "dGVkIHRvdGFsIG51bWJlciBvZiBzdGVwcyBvZiB0aGUgY3VycmVudCBwcm9ncmFtIHJ1bi4gSWYgdGhl" +
           "IHRvdGFsIG51bWJlciBjYW5ub3QgYmUgZXN0aW1hdGVkLCB0aGUgU3RhdHVzQ29kZSBCYWROb0RhdGEg" +
           "c2hvdWxkIGJlIHNlbnQuAC4ARBIYAAAAB/////8BAf////8AAAAA";

        private const string EstimatedStepRuntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAFAAAAEVzdGltYXRl" +
           "ZFN0ZXBSdW50aW1lAQEnGAMAAAAAkgAAAEVzdGltYXRlZFN0ZXBSdW50aW1lIGlzIHRoZSBlc3RpbWF0" +
           "ZWQgcnVuLXRpbWUgb2YgdGhlIGN1cnJlbnQgcHJvZ3JhbS1zdGVwLiBJZiB0aGUgcnVuLXRpbWUgY2Fu" +
           "bm90IGVzdGltYXRlLCB0aGUgU3RhdHVzQ29kZSBCYWROb0RhdGEgc2hvdWxkIHNlbnQuAC4ARCcYAAAB" +
           "ACIB/////wEB/////wAAAAA=";

        private const string DeviceProgramRunId_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEgAAAERldmljZVBy" +
           "b2dyYW1SdW5JZAEB7hcDAAAAAEgBAABEZXZpY2VQcm9ncmFtUnVuSWQgcmVwcmVzZW50cyBhIGRldmlj" +
           "ZS1zcGVjaWZpYyB1bmlxdWUgaW50ZXJuYWwgaWRlbnRpZmllciBmb3IgdGhpcyBwcm9ncmFtIHJ1bi4g" +
           "SXRzIHZhbHVlIHNoYWxsIGJlIGlkZW50aWNhbCB0byB0aGUgcmV0dXJuIHZhbHVlIG9mIHRoZSBsYXN0" +
           "IGNhbGwgdG8gdGhlIEZ1bmN0aW9uYWxVbml04oCZcyBTdGFydFByb2dyYW0oKSBNZXRob2QuIEl0IGlz" +
           "IHVzZWQgdG8gaWRlbnRpZnkgdGhlIHJlc3VsdCBvYmplY3QgY29ycmVzcG9uZGluZyB0byB0aGlzIHBy" +
           "b2dyYW0gcnVuIHdpdGhpbiB0aGUgRnVuY3Rpb25hbFVuaXTigJlzIHJlc3VsdCBzZXQuAC4ARO4XAAAA" +
           "DP////8BAf////8AAAAA";

        private const string CurrentProgramTemplate_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAFgAAAEN1cnJlbnRQ" +
           "cm9ncmFtVGVtcGxhdGUBAasYAwAAAABpAAAAQ3VycmVudFByb2dyYW1UZW1wbGF0ZSBwcm92aWRlcyB0" +
           "aGUgdGVtcGxhdGUtaWQgYXMgd2VsbCBhcyB0aGUgbm9kZS1pZCBvZiB0aGUgY3VycmVudGx5IGV4ZWN1" +
           "dGVkIHByb2dyYW0uAC4ARKsYAAABBLsL/////wMD/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGQAAAEFjdGl2ZVBy" +
           "b2dyYW1UeXBlSW5zdGFuY2UBARAEAQEQBBAEAAD/////CgAAADVgiQoCAAAAAQAQAAAAQ3VycmVudFBh" +
           "dXNlVGltZQEBJBgDAAAAAAwBAABDdXJyZW50UGF1c2VUaW1lIGlzIHRoZSBjdXJyZW50IHBhdXNlLXRp" +
           "bWUgb2YgdGhlIHByb2dyYW0tIHJ1bi4gVGhlIEN1cnJlbnRQYXVzZVRpbWUgaXMgc2V0IHRvIDAgYXQg" +
           "dGhlIHN0YXJ0IG9mIHRoZSBwcm9ncmFtIGFuZCBpcyBjb3VudGVkIHVwd2FyZHMgd2hlbiB0aGUgcHJv" +
           "Z3JhbSBydW4gaXMgaW4gYSBQYXVzZWQgc3RhdGUuIFRoZSBQYXVzZWQgc3RhdGUgaXMgYW4gYWdncmVn" +
           "YXRpb24gb2YgdGhlIFN1c3BlbmRlZCBzdGF0ZSBhbmQgdGhlIEhlbGQgU3RhdGUuAC4ARCQYAAABACIB" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEADgAAAEN1cnJlbnRSdW50aW1lAQETGAMAAAAAEAEAAEN1cnJl" +
           "bnRSdW50aW1lIGlzIHRoZSBjdXJyZW50IHJ1bi10aW1lIG9mIHRoZSBwcm9ncmFtIC1ydW4uIFRoZSBD" +
           "dXJyZW50UnVuVGltZSBpcyBzZXQgdG8gMCBhdCB0aGUgc3RhcnQgb2YgdGhlIHByb2dyYW0gYW5kIGlz" +
           "IGNvdW50ZWQgdXB3YXJkcyBhcyBsb25nIGFzIHRoZSBwcm9ncmFtIHJ1biBpcyBub3QgaW4gYSBQYXVz" +
           "ZWQgc3RhdGUuIFRoZSBQYXVzZWQgc3RhdGUgaXMgYW4gYWdncmVnYXRpb24gb2YgdGhlIFN1c3BlbmRl" +
           "ZCBzdGF0ZSBhbmQgdGhlIEhlbGQgc3RhdGUuAC4ARBMYAAABACIB/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEADwAAAEN1cnJlbnRTdGVwTmFtZQEBKBgDAAAAADAAAABDdXJyZW50U3RlcE5hbWUgaXMgdGhlIG5h" +
           "bWUgb2YgdGhlIGN1cnJlbnQgc3RlcC4ALgBEKBgAAAAV/////wEB/////wAAAAA1YIkKAgAAAAEAEQAA" +
           "AEN1cnJlbnRTdGVwTnVtYmVyAQEpGAMAAAAAjwAAAEN1cnJlbnRTdGVwTnVtYmVyIGlzIHRoZSBudW1i" +
           "ZXIvaW5kZXggb2YgdGhlIGN1cnJlbnQgc3RlcCAoaW5jcmVtZW50ZWQgd2hlbmV2ZXIgdGhlIG5leHQg" +
           "c3RlcCBpcyBlbnRlcmVkKS4gVGhlIEN1cnJlbnRTdGVwTnVtYmVyIHN0YXJ0cyB3aXRoIDEuAC4ARCkY" +
           "AAAAB/////8BAf////8AAAAANWCJCgIAAAABABIAAABDdXJyZW50U3RlcFJ1bnRpbWUBASoYAwAAAAAS" +
           "AQAAQ3VycmVudFN0ZXBSdW50aW1lIGlzIHRoZSBydW50aW1lIG9mIHRoZSBjdXJyZW50IHN0ZXAuIFRo" +
           "ZSBDdXJyZW50U3RlcFJ1blRpbWUgaXMgc2V0IHRvIDAgYXQgdGhlIHN0YXJ0IG9mIHRoZSBjdXJyZW50" +
           "IHN0ZXAgYW5kIGlzIGNvdW50ZWQgdXB3YXJkcyBhcyBsb25nIGFzIHRoZSBwcm9ncmFtIHJ1biBpcyBu" +
           "b3QgaW4gUGF1c2VkIHN0YXRlLiBUaGUgUGF1c2VkIHN0YXRlIGlzIGFuIGFnZ3JlZ2F0aW9uIG9mIHRo" +
           "ZSBTdXNwZW5kZWQgc3RhdGUgYW5kIHRoZSBIZWxkIFN0YXRlLgAuAEQqGAAAAQAiAf////8BAf////8A" +
           "AAAANWCJCgIAAAABABAAAABFc3RpbWF0ZWRSdW50aW1lAQEPGAMAAAAAkwAAAEVzdGltYXRlZFJ1bnRp" +
           "bWUgaXMgdGhlIGVzdGltYXRlZCBydW4tdGltZSBvZiB0aGUgY3VycmVudCBwcm9ncmFtIHJ1bi4gSWYg" +
           "dGhlIHJ1bnRpbWUgY2Fubm90IGJlIGVzdGltYXRlZCwgdGhlIFN0YXR1c0NvZGUgQmFkTm9EYXRhIHNo" +
           "b3VsZCBiZSBzZW50LgAuAEQPGAAAAQAiAf////8BAf////8AAAAANWCJCgIAAAABABQAAABFc3RpbWF0" +
           "ZWRTdGVwTnVtYmVycwEBEhgDAAAAAKoAAABFc3RpbWF0ZWRTdGVwTnVtYmVycyBhcmUgdGhlIGVzdGlt" +
           "YXRlZCB0b3RhbCBudW1iZXIgb2Ygc3RlcHMgb2YgdGhlIGN1cnJlbnQgcHJvZ3JhbSBydW4uIElmIHRo" +
           "ZSB0b3RhbCBudW1iZXIgY2Fubm90IGJlIGVzdGltYXRlZCwgdGhlIFN0YXR1c0NvZGUgQmFkTm9EYXRh" +
           "IHNob3VsZCBiZSBzZW50LgAuAEQSGAAAAAf/////AQH/////AAAAADVgiQoCAAAAAQAUAAAARXN0aW1h" +
           "dGVkU3RlcFJ1bnRpbWUBAScYAwAAAACSAAAARXN0aW1hdGVkU3RlcFJ1bnRpbWUgaXMgdGhlIGVzdGlt" +
           "YXRlZCBydW4tdGltZSBvZiB0aGUgY3VycmVudCBwcm9ncmFtLXN0ZXAuIElmIHRoZSBydW4tdGltZSBj" +
           "YW5ub3QgZXN0aW1hdGUsIHRoZSBTdGF0dXNDb2RlIEJhZE5vRGF0YSBzaG91bGQgc2VudC4ALgBEJxgA" +
           "AAEAIgH/////AQH/////AAAAADVgiQoCAAAAAQASAAAARGV2aWNlUHJvZ3JhbVJ1bklkAQHuFwMAAAAA" +
           "SAEAAERldmljZVByb2dyYW1SdW5JZCByZXByZXNlbnRzIGEgZGV2aWNlLXNwZWNpZmljIHVuaXF1ZSBp" +
           "bnRlcm5hbCBpZGVudGlmaWVyIGZvciB0aGlzIHByb2dyYW0gcnVuLiBJdHMgdmFsdWUgc2hhbGwgYmUg" +
           "aWRlbnRpY2FsIHRvIHRoZSByZXR1cm4gdmFsdWUgb2YgdGhlIGxhc3QgY2FsbCB0byB0aGUgRnVuY3Rp" +
           "b25hbFVuaXTigJlzIFN0YXJ0UHJvZ3JhbSgpIE1ldGhvZC4gSXQgaXMgdXNlZCB0byBpZGVudGlmeSB0" +
           "aGUgcmVzdWx0IG9iamVjdCBjb3JyZXNwb25kaW5nIHRvIHRoaXMgcHJvZ3JhbSBydW4gd2l0aGluIHRo" +
           "ZSBGdW5jdGlvbmFsVW5pdOKAmXMgcmVzdWx0IHNldC4ALgBE7hcAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEAFgAAAEN1cnJlbnRQcm9ncmFtVGVtcGxhdGUBAasYAwAAAABpAAAAQ3VycmVudFByb2dyYW1U" +
           "ZW1wbGF0ZSBwcm92aWRlcyB0aGUgdGVtcGxhdGUtaWQgYXMgd2VsbCBhcyB0aGUgbm9kZS1pZCBvZiB0" +
           "aGUgY3VycmVudGx5IGV4ZWN1dGVkIHByb2dyYW0uAC4ARKsYAAABBLsL/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> CurrentPauseTime
        {
            get
            {
                return m_currentPauseTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentPauseTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentPauseTime = value;
            }
        }

        /// <remarks />
        public PropertyState<double> CurrentRuntime
        {
            get
            {
                return m_currentRuntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentRuntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentRuntime = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> CurrentStepName
        {
            get
            {
                return m_currentStepName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentStepName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentStepName = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> CurrentStepNumber
        {
            get
            {
                return m_currentStepNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentStepNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentStepNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<double> CurrentStepRuntime
        {
            get
            {
                return m_currentStepRuntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentStepRuntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentStepRuntime = value;
            }
        }

        /// <remarks />
        public PropertyState<double> EstimatedRuntime
        {
            get
            {
                return m_estimatedRuntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_estimatedRuntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_estimatedRuntime = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> EstimatedStepNumbers
        {
            get
            {
                return m_estimatedStepNumbers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_estimatedStepNumbers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_estimatedStepNumbers = value;
            }
        }

        /// <remarks />
        public PropertyState<double> EstimatedStepRuntime
        {
            get
            {
                return m_estimatedStepRuntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_estimatedStepRuntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_estimatedStepRuntime = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceProgramRunId
        {
            get
            {
                return m_deviceProgramRunId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceProgramRunId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceProgramRunId = value;
            }
        }

        /// <remarks />
        public PropertyState<NameNodeIdDataType> CurrentProgramTemplate
        {
            get
            {
                return m_currentProgramTemplate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentProgramTemplate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentProgramTemplate = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentPauseTime != null)
            {
                children.Add(m_currentPauseTime);
            }

            if (m_currentRuntime != null)
            {
                children.Add(m_currentRuntime);
            }

            if (m_currentStepName != null)
            {
                children.Add(m_currentStepName);
            }

            if (m_currentStepNumber != null)
            {
                children.Add(m_currentStepNumber);
            }

            if (m_currentStepRuntime != null)
            {
                children.Add(m_currentStepRuntime);
            }

            if (m_estimatedRuntime != null)
            {
                children.Add(m_estimatedRuntime);
            }

            if (m_estimatedStepNumbers != null)
            {
                children.Add(m_estimatedStepNumbers);
            }

            if (m_estimatedStepRuntime != null)
            {
                children.Add(m_estimatedStepRuntime);
            }

            if (m_deviceProgramRunId != null)
            {
                children.Add(m_deviceProgramRunId);
            }

            if (m_currentProgramTemplate != null)
            {
                children.Add(m_currentProgramTemplate);
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
                case Opc.Ua.LADS.BrowseNames.CurrentPauseTime:
                {
                    if (createOrReplace)
                    {
                        if (CurrentPauseTime == null)
                        {
                            if (replacement == null)
                            {
                                CurrentPauseTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                CurrentPauseTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = CurrentPauseTime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CurrentRuntime:
                {
                    if (createOrReplace)
                    {
                        if (CurrentRuntime == null)
                        {
                            if (replacement == null)
                            {
                                CurrentRuntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                CurrentRuntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = CurrentRuntime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CurrentStepName:
                {
                    if (createOrReplace)
                    {
                        if (CurrentStepName == null)
                        {
                            if (replacement == null)
                            {
                                CurrentStepName = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                CurrentStepName = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = CurrentStepName;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CurrentStepNumber:
                {
                    if (createOrReplace)
                    {
                        if (CurrentStepNumber == null)
                        {
                            if (replacement == null)
                            {
                                CurrentStepNumber = new PropertyState<uint>(this);
                            }
                            else
                            {
                                CurrentStepNumber = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = CurrentStepNumber;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CurrentStepRuntime:
                {
                    if (createOrReplace)
                    {
                        if (CurrentStepRuntime == null)
                        {
                            if (replacement == null)
                            {
                                CurrentStepRuntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                CurrentStepRuntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = CurrentStepRuntime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.EstimatedRuntime:
                {
                    if (createOrReplace)
                    {
                        if (EstimatedRuntime == null)
                        {
                            if (replacement == null)
                            {
                                EstimatedRuntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                EstimatedRuntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = EstimatedRuntime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.EstimatedStepNumbers:
                {
                    if (createOrReplace)
                    {
                        if (EstimatedStepNumbers == null)
                        {
                            if (replacement == null)
                            {
                                EstimatedStepNumbers = new PropertyState<uint>(this);
                            }
                            else
                            {
                                EstimatedStepNumbers = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = EstimatedStepNumbers;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.EstimatedStepRuntime:
                {
                    if (createOrReplace)
                    {
                        if (EstimatedStepRuntime == null)
                        {
                            if (replacement == null)
                            {
                                EstimatedStepRuntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                EstimatedStepRuntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = EstimatedStepRuntime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.DeviceProgramRunId:
                {
                    if (createOrReplace)
                    {
                        if (DeviceProgramRunId == null)
                        {
                            if (replacement == null)
                            {
                                DeviceProgramRunId = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceProgramRunId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceProgramRunId;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CurrentProgramTemplate:
                {
                    if (createOrReplace)
                    {
                        if (CurrentProgramTemplate == null)
                        {
                            if (replacement == null)
                            {
                                CurrentProgramTemplate = new PropertyState<NameNodeIdDataType>(this);
                            }
                            else
                            {
                                CurrentProgramTemplate = (PropertyState<NameNodeIdDataType>)replacement;
                            }
                        }
                    }

                    instance = CurrentProgramTemplate;
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
        private PropertyState<double> m_currentPauseTime;
        private PropertyState<double> m_currentRuntime;
        private PropertyState<LocalizedText> m_currentStepName;
        private PropertyState<uint> m_currentStepNumber;
        private PropertyState<double> m_currentStepRuntime;
        private PropertyState<double> m_estimatedRuntime;
        private PropertyState<uint> m_estimatedStepNumbers;
        private PropertyState<double> m_estimatedStepRuntime;
        private PropertyState<string> m_deviceProgramRunId;
        private PropertyState<NameNodeIdDataType> m_currentProgramTemplate;
        #endregion
    }
    #endif
    #endregion

    #region LADSComponentsTypeState Class
    #if (!OPCUA_EXCLUDE_LADSComponentsTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSComponentsTypeState : MachineComponentsTypeState
    {
        #region Constructors
        /// <remarks />
        public LADSComponentsTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.LADSComponentsType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (NodeVersion != null)
            {
                NodeVersion.Initialize(context, NodeVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string NodeVersion_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYKkKAgAAAAAACwAAAE5vZGVWZXJz" +
           "aW9uAQHFFwAuAETFFwAADAMAAABOYU4ADP////8DA/////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGgAAAExBRFNDb21w" +
           "b25lbnRzVHlwZUluc3RhbmNlAQEBBAEBAQQBBAAAAQAAAAApAAEAVQgBAAAAFWCpCgIAAAAAAAsAAABO" +
           "b2RlVmVyc2lvbgEBxRcALgBExRcAAAwDAAAATmFOAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> NodeVersion
        {
            get
            {
                return m_nodeVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nodeVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nodeVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_nodeVersion != null)
            {
                children.Add(m_nodeVersion);
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
                case Opc.Ua.BrowseNames.NodeVersion:
                {
                    if (createOrReplace)
                    {
                        if (NodeVersion == null)
                        {
                            if (replacement == null)
                            {
                                NodeVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                NodeVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NodeVersion;
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
        private PropertyState<string> m_nodeVersion;
        #endregion
    }
    #endif
    #endregion

    #region LADSOperationCountersTypeState Class
    #if (!OPCUA_EXCLUDE_LADSOperationCountersTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSOperationCountersTypeState : MachineryOperationCounterTypeState
    {
        #region Constructors
        /// <remarks />
        public LADSOperationCountersTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.LADSOperationCountersType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (LifeTime != null)
            {
                LifeTime.Initialize(context, LifeTime_InitializationString);
            }
        }

        #region Initialization String
        private const string LifeTime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAEACAAAAExpZmVUaW1l" +
           "AQGLFwAvAQLUAYsXAAAAGv////8DA/////8DAAAAFWCJCAIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AQEAAAAuAEQBAHcD/////wEB/////wAAAAA1YIkKAgAAAAIACgAAAFN0YXJ0VmFsdWUBAdUBAwAAAABT" +
           "AAAAU3RhcnRWYWx1ZSBpbmRpY2F0ZXMgdGhlIGluaXRpYWwgdmFsdWUsIHdoZW4gdGhlcmUgaXMgc3Rp" +
           "bGwgdGhlIGZ1bGwgbGlmZXRpbWUgbGVmdC4ALgBE1QEAAAAa/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "CgAAAExpbWl0VmFsdWUBAdYBAwAAAAA/AAAATGltaXRWYWx1ZSBpbmRpY2F0ZXMgd2hlbiB0aGUgZW5k" +
           "IG9mIGxpZmV0aW1lIGhhcyBiZWVuIHJlYWNoZWQuAC4ARNYBAAAAGv////8BAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIQAAAExBRFNPcGVy" +
           "YXRpb25Db3VudGVyc1R5cGVJbnN0YW5jZQEBCgQBAQoECgQAAAEAAAABAMNEAAEC4AEBAAAAFWCJCgIA" +
           "AAABAAgAAABMaWZlVGltZQEBixcALwEC1AGLFwAAABr/////AwP/////AwAAABVgiQgCAAAAAAAQAAAA" +
           "RW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf////8AAAAANWCJCgIAAAACAAoAAABTdGFy" +
           "dFZhbHVlAQHVAQMAAAAAUwAAAFN0YXJ0VmFsdWUgaW5kaWNhdGVzIHRoZSBpbml0aWFsIHZhbHVlLCB3" +
           "aGVuIHRoZXJlIGlzIHN0aWxsIHRoZSBmdWxsIGxpZmV0aW1lIGxlZnQuAC4ARNUBAAAAGv////8BAf//" +
           "//8AAAAANWCJCgIAAAACAAoAAABMaW1pdFZhbHVlAQHWAQMAAAAAPwAAAExpbWl0VmFsdWUgaW5kaWNh" +
           "dGVzIHdoZW4gdGhlIGVuZCBvZiBsaWZldGltZSBoYXMgYmVlbiByZWFjaGVkLgAuAETWAQAAABr/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LifetimeVariableTypeState LifeTime
        {
            get
            {
                return m_lifeTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lifeTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lifeTime = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_lifeTime != null)
            {
                children.Add(m_lifeTime);
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
                case Opc.Ua.LADS.BrowseNames.LifeTime:
                {
                    if (createOrReplace)
                    {
                        if (LifeTime == null)
                        {
                            if (replacement == null)
                            {
                                LifeTime = new LifetimeVariableTypeState(this);
                            }
                            else
                            {
                                LifeTime = (LifetimeVariableTypeState)replacement;
                            }
                        }
                    }

                    instance = LifeTime;
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
        private LifetimeVariableTypeState m_lifeTime;
        #endregion
    }
    #endif
    #endregion

    #region FunctionalUnitSetTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalUnitSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalUnitSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public FunctionalUnitSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.FunctionalUnitSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHQAAAEZ1bmN0aW9u" +
           "YWxVbml0U2V0VHlwZUluc3RhbmNlAQH/AwEB/wP/AwAA/////wAAAAA=";
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

    #region FunctionSetTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public FunctionSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.FunctionSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAFwAAAEZ1bmN0aW9u" +
           "U2V0VHlwZUluc3RhbmNlAQECBAEBAgQCBAAA/////wAAAAA=";
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

    #region ProgramTemplateSetTypeState Class
    #if (!OPCUA_EXCLUDE_ProgramTemplateSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramTemplateSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public ProgramTemplateSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ProgramTemplateSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHgAAAFByb2dyYW1U" +
           "ZW1wbGF0ZVNldFR5cGVJbnN0YW5jZQEB+wMBAfsD+wMAAP////8BAAAANWCpCgIAAAAAAAsAAABOb2Rl" +
           "VmVyc2lvbgEB9RcDAAAAAKUAAABOb2RlVmVyc2lvbiBhbmQgdGhlIEdlbmVyYWxNb2RlbENoYW5nZUV2" +
           "ZW50VHlwZSBhcmUgbWVjaGFuaXNtcyB0byBub3RpZnkgY2xpZW50cyB0aGF0IHRoZSBjb250ZW50IG9m" +
           "IHRoZSBzZXQgaGFzIGNoYW5nZWQgYW5kIHNoYWxsIGJlIHVzZWQgYXMgZGVmaW5lZCBpbiBPUEMgMTAw" +
           "MDAtMy4ALgBE9RcAAAwDAAAATmFOAAz/////AwP/////AAAAAA==";
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

    #region ProgramTemplateTypeState Class
    #if (!OPCUA_EXCLUDE_ProgramTemplateTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramTemplateTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ProgramTemplateTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ProgramTemplateType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (SupervisoryTemplateId != null)
            {
                SupervisoryTemplateId.Initialize(context, SupervisoryTemplateId_InitializationString);
            }
        }

        #region Initialization String
        private const string SupervisoryTemplateId_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAFQAAAFN1cGVydmlz" +
           "b3J5VGVtcGxhdGVJZAEByhcDAAAAAJMAAABTdXBlcnZpc29yeVRlbXBsYXRlSWQgaXMgYW4gb3B0aW9u" +
           "YWwgZW50ZXJwcmlzZS13aWRlIHVuaXF1ZSBJRCBmb3IgdGhlIHRlbXBsYXRlLiBUaGlzIGNhbiBiZSB1" +
           "dGlsaXplZCB0byByZWZlciB0aGUgdGVtcGxhdGUgdG8gc3VwZXJ2aXNvcnkgc3lzdGVtcy4ALgBEyhcA" +
           "AAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGwAAAFByb2dyYW1U" +
           "ZW1wbGF0ZVR5cGVJbnN0YW5jZQEB+gMBAfoD+gMAAP////8HAAAANWCJCgIAAAABAAYAAABBdXRob3IB" +
           "AcwYAwAAAAAsAAAAQXV0aG9yIGlzIHRoZSB1c2VyIHdobyBjcmVhdGVkIHRoZSB0ZW1wbGF0ZS4ALgBE" +
           "zBgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEABwAAAENyZWF0ZWQBAcUYAwAAAAAxAAAAQ3JlYXRl" +
           "ZCBpcyB0aGUgdGltZSBvZiB0aGUgdGVtcGxhdGXigJlzIGNyZWF0aW9uLgAuAETFGAAAAA3/////AQH/" +
           "////AAAAADVgiQoCAAAAAQALAAAARGVzY3JpcHRpb24BAcQYAwAAAAA8AAAARGVzY3JpcHRpb24gaXMg" +
           "YSBodW1hbi1yZWFkYWJsZSBkZXNjcmlwdGlvbiBvZiB0aGUgdGVtcGxhdGUuAC4ARMQYAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAABAAgAAABNb2RpZmllZAEByBgDAAAAACoAAABNb2RpZmllZCBpcyB0aGUg" +
           "dGltZSBvZiBsYXN0IG1vZGlmaWNhdGlvbi4ALgBEyBgAAAAN/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "EAAAAERldmljZVRlbXBsYXRlSWQBAXMYAwAAAABcAAAARGV2aWNlVGVtcGxhdGVJZCBpcyB0aGUgcHJv" +
           "Z3JhbSB0ZW1wbGF0ZSdzIGlkZW50aWZpZXIgdW5pcXVlIHdpdGhpbiB0aGUgc2NvcGUgb2YgdGhlIGRl" +
           "dmljZS4ALgBEcxgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEABwAAAFZlcnNpb24BAcoYAwAAAABS" +
           "AAAAVmVyc2lvbiBpcyB0aGUgdmVyc2lvbiBvZiB0aGUgdGVtcGxhdGUgKHRoZSBmb3JtYXQgaXMgYXQg" +
           "dGhlIHVzZXLigJlzIGRpc2NyZXRpb24pLgAuAETKGAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAV" +
           "AAAAU3VwZXJ2aXNvcnlUZW1wbGF0ZUlkAQHKFwMAAAAAkwAAAFN1cGVydmlzb3J5VGVtcGxhdGVJZCBp" +
           "cyBhbiBvcHRpb25hbCBlbnRlcnByaXNlLXdpZGUgdW5pcXVlIElEIGZvciB0aGUgdGVtcGxhdGUuIFRo" +
           "aXMgY2FuIGJlIHV0aWxpemVkIHRvIHJlZmVyIHRoZSB0ZW1wbGF0ZSB0byBzdXBlcnZpc29yeSBzeXN0" +
           "ZW1zLgAuAETKFwAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Author
        {
            get
            {
                return m_author;
            }

            set
            {
                if (!Object.ReferenceEquals(m_author, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_author = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Created
        {
            get
            {
                return m_created;
            }

            set
            {
                if (!Object.ReferenceEquals(m_created, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_created = value;
            }
        }

        /// <remarks />
        public new PropertyState<LocalizedText> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Modified
        {
            get
            {
                return m_modified;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modified, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modified = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceTemplateId
        {
            get
            {
                return m_deviceTemplateId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceTemplateId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceTemplateId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Version
        {
            get
            {
                return m_version;
            }

            set
            {
                if (!Object.ReferenceEquals(m_version, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_version = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SupervisoryTemplateId
        {
            get
            {
                return m_supervisoryTemplateId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supervisoryTemplateId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supervisoryTemplateId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_author != null)
            {
                children.Add(m_author);
            }

            if (m_created != null)
            {
                children.Add(m_created);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_modified != null)
            {
                children.Add(m_modified);
            }

            if (m_deviceTemplateId != null)
            {
                children.Add(m_deviceTemplateId);
            }

            if (m_version != null)
            {
                children.Add(m_version);
            }

            if (m_supervisoryTemplateId != null)
            {
                children.Add(m_supervisoryTemplateId);
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
                case Opc.Ua.LADS.BrowseNames.Author:
                {
                    if (createOrReplace)
                    {
                        if (Author == null)
                        {
                            if (replacement == null)
                            {
                                Author = new PropertyState<string>(this);
                            }
                            else
                            {
                                Author = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Author;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Created:
                {
                    if (createOrReplace)
                    {
                        if (Created == null)
                        {
                            if (replacement == null)
                            {
                                Created = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                Created = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Created;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Description = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Modified:
                {
                    if (createOrReplace)
                    {
                        if (Modified == null)
                        {
                            if (replacement == null)
                            {
                                Modified = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                Modified = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Modified;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.DeviceTemplateId:
                {
                    if (createOrReplace)
                    {
                        if (DeviceTemplateId == null)
                        {
                            if (replacement == null)
                            {
                                DeviceTemplateId = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceTemplateId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceTemplateId;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Version:
                {
                    if (createOrReplace)
                    {
                        if (Version == null)
                        {
                            if (replacement == null)
                            {
                                Version = new PropertyState<string>(this);
                            }
                            else
                            {
                                Version = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Version;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.SupervisoryTemplateId:
                {
                    if (createOrReplace)
                    {
                        if (SupervisoryTemplateId == null)
                        {
                            if (replacement == null)
                            {
                                SupervisoryTemplateId = new PropertyState<string>(this);
                            }
                            else
                            {
                                SupervisoryTemplateId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SupervisoryTemplateId;
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
        private PropertyState<string> m_author;
        private PropertyState<DateTime> m_created;
        private PropertyState<LocalizedText> m_description;
        private PropertyState<DateTime> m_modified;
        private PropertyState<string> m_deviceTemplateId;
        private PropertyState<string> m_version;
        private PropertyState<string> m_supervisoryTemplateId;
        #endregion
    }
    #endif
    #endregion

    #region SupportedPropertiesSetTypeState Class
    #if (!OPCUA_EXCLUDE_SupportedPropertiesSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SupportedPropertiesSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public SupportedPropertiesSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.SupportedPropertiesSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIgAAAFN1cHBvcnRl" +
           "ZFByb3BlcnRpZXNTZXRUeXBlSW5zdGFuY2UBAQkEAQEJBAkEAAD/////AAAAAA==";
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

    #region SupportedPropertyTypeState Class
    #if (!OPCUA_EXCLUDE_SupportedPropertyTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SupportedPropertyTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public SupportedPropertyTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.SupportedPropertyType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHQAAAFN1cHBvcnRl" +
           "ZFByb3BlcnR5VHlwZUluc3RhbmNlAQELBAEBCwQLBAAA/////wAAAAA=";
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

    #region ResultFileSetTypeState Class
    #if (!OPCUA_EXCLUDE_ResultFileSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResultFileSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public ResultFileSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ResultFileSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGQAAAFJlc3VsdEZp" +
           "bGVTZXRUeXBlSW5zdGFuY2UBAf4DAQH+A/4DAAD/////AAAAAA==";
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

    #region ResultFileTypeState Class
    #if (!OPCUA_EXCLUDE_ResultFileTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResultFileTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ResultFileTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ResultFileType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (URL != null)
            {
                URL.Initialize(context, URL_InitializationString);
            }

            if (File != null)
            {
                File.Initialize(context, File_InitializationString);
            }
        }

        #region Initialization String
        private const string URL_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAAwAAAFVSTAEBmxgD" +
           "AAAAADQAAABVUkwgaXMgYW4gVVJMIGZyb20gd2hpY2ggdGhlIGZpbGUgY2FuIGJlIGRvd25sb2FkZWQu" +
           "AC4ARJsYAAAADP////8BAf////8AAAAA";

        private const string File_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEABAAAAEZpbGUBAdAT" +
           "AwAAAABNAAAARmlsZSBpcyB0aGUgT1BDIFVBIG5vZGUgb2YgdGhlIGZpbGUgd2l0aCB0aGUgbWV0aG9k" +
           "IGZvciBkb3dubG9hZGluZyB0aGUgZmlsZS4ALwEANy3QEwAA/////woAAAAVYIkIAgAAAAAABAAAAFNp" +
           "emUBAQAAAC4ARAAJ/////wEB/////wAAAAAVYIkIAgAAAAAACAAAAFdyaXRhYmxlAQEAAAAuAEQAAf//" +
           "//8BAf////8AAAAAFWCJCAIAAAAAAAwAAABVc2VyV3JpdGFibGUBAQAAAC4ARAAB/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAACQAAAE9wZW5Db3VudAEBAAAALgBEAAX/////AQH/////AAAAAARhgggEAAAAAAAE" +
           "AAAAT3BlbgEBAAAALwEAPC0BAf////8CAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAA" +
           "LgBElgEAAAABACoBARMAAAAEAAAATW9kZQAD/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAAXYKkIAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBAAAALgBElgEAAAABACoBARkAAAAKAAAARmls" +
           "ZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIIBAAAAAAABQAAAENs" +
           "b3NlAQEAAAAvAQA/LQEB/////wEAAAAXYKkIAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEAAAAuAESW" +
           "AQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////" +
           "AAAAAARhgggEAAAAAAAEAAAAUmVhZAEBAAAALwEAQS0BAf////8CAAAAF2CpCAIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBAAAALgBElgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAq" +
           "AQEVAAAABgAAAExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAXYKkIAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBAAAALgBElgEAAAABACoBARMAAAAEAAAARGF0YQAP/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIIBAAAAAAABQAAAFdyaXRlAQEAAAAvAQBELQEB" +
           "/////wEAAAAXYKkIAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEAAAAuAESWAgAAAAEAKgEBGQAAAAoA" +
           "AABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAgAAAAEB/////wAAAAAEYYIIBAAAAAAACwAAAEdldFBvc2l0aW9uAQEAAAAvAQBGLQEB/////wIA" +
           "AAAXYKkIAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEAAAAuAESWAQAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "SGFuZGxlAAf/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQgCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQEAAAAuAESWAQAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIIBAAAAAAACwAAAFNldFBvc2l0aW9uAQEAAAAvAQBJLQEB" +
           "/////wEAAAAXYKkIAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEAAAAuAESWAgAAAAEAKgEBGQAAAAoA" +
           "AABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARcAAAAIAAAAUG9zaXRpb24ACf////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAIAAAABAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAFgAAAFJlc3VsdEZp" +
           "bGVUeXBlSW5zdGFuY2UBAekDAQHpA+kDAAD/////BAAAADVgiQoCAAAAAQAIAAAATWltZVR5cGUBAZkY" +
           "AwAAAAAmAAAATWltZVR5cGUgaXMgdGhlIE1JTUUgdHlwZSBvZiB0aGUgZmlsZS4ALgBEmRgAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAEABAAAAE5hbWUBAZoYAwAAAABoAAAATmFtZSBpcyB0aGUgbmFtZSB0" +
           "aGF0IGRlc2NyaWJlcyB0aGUgZmlsZS4gVGhlIG5hbWUgbWF5IGJlIGRpZmZlcmVudCBmcm9tIHRoZSBm" +
           "aWxlbmFtZSBvbiB0aGUgZmlsZXN5c3RlbS4ALgBEmhgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "AwAAAFVSTAEBmxgDAAAAADQAAABVUkwgaXMgYW4gVVJMIGZyb20gd2hpY2ggdGhlIGZpbGUgY2FuIGJl" +
           "IGRvd25sb2FkZWQuAC4ARJsYAAAADP////8BAf////8AAAAAJGCACgEAAAABAAQAAABGaWxlAQHQEwMA" +
           "AAAATQAAAEZpbGUgaXMgdGhlIE9QQyBVQSBub2RlIG9mIHRoZSBmaWxlIHdpdGggdGhlIG1ldGhvZCBm" +
           "b3IgZG93bmxvYWRpbmcgdGhlIGZpbGUuAC8BADct0BMAAP////8KAAAAFWCJCAIAAAAAAAQAAABTaXpl" +
           "AQEAAAAuAEQACf////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABXcml0YWJsZQEBAAAALgBEAAH/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAMAAAAVXNlcldyaXRhYmxlAQEAAAAuAEQAAf////8BAf////8AAAAA" +
           "FWCJCAIAAAAAAAkAAABPcGVuQ291bnQBAQAAAC4ARAAF/////wEB/////wAAAAAEYYIIBAAAAAAABAAA" +
           "AE9wZW4BAQAAAC8BADwtAQH/////AgAAABdgqQgCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4A" +
           "RJYBAAAAAQAqAQETAAAABAAAAE1vZGUAA/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA" +
           "F2CpCAIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQAAAC4ARJYBAAAAAQAqAQEZAAAACgAAAEZpbGVI" +
           "YW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCAQAAAAAAAUAAABDbG9z" +
           "ZQEBAAAALwEAPy0BAf////8BAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgEA" +
           "AAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAAEYYIIBAAAAAAABAAAAFJlYWQBAQAAAC8BAEEtAQH/////AgAAABdgqQgCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEB" +
           "FQAAAAYAAABMZW5ndGgABv////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAF2CpCAIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAQAAAC4ARJYBAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCAQAAAAAAAUAAABXcml0ZQEBAAAALwEARC0BAf//" +
           "//8BAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgIAAAABACoBARkAAAAKAAAA" +
           "RmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAIAAAABAf////8AAAAABGGCCAQAAAAAAAsAAABHZXRQb3NpdGlvbgEBAAAALwEARi0BAf////8CAAAA" +
           "F2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgEAAAABACoBARkAAAAKAAAARmlsZUhh" +
           "bmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkIAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBAAAALgBElgEAAAABACoBARcAAAAIAAAAUG9zaXRpb24ACf////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAEAAAABAf////8AAAAABGGCCAQAAAAAAAsAAABTZXRQb3NpdGlvbgEBAAAALwEASS0BAf//" +
           "//8BAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgIAAAABACoBARkAAAAKAAAA" +
           "RmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQEXAAAACAAAAFBvc2l0aW9uAAn/////AAAAAAABACgBAQAA" +
           "AAEAAAACAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> MimeType
        {
            get
            {
                return m_mimeType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mimeType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mimeType = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public PropertyState<string> URL
        {
            get
            {
                return m_uRL;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uRL, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uRL = value;
            }
        }

        /// <remarks />
        public FileState File
        {
            get
            {
                return m_file;
            }

            set
            {
                if (!Object.ReferenceEquals(m_file, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_file = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mimeType != null)
            {
                children.Add(m_mimeType);
            }

            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_uRL != null)
            {
                children.Add(m_uRL);
            }

            if (m_file != null)
            {
                children.Add(m_file);
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
                case Opc.Ua.LADS.BrowseNames.MimeType:
                {
                    if (createOrReplace)
                    {
                        if (MimeType == null)
                        {
                            if (replacement == null)
                            {
                                MimeType = new PropertyState<string>(this);
                            }
                            else
                            {
                                MimeType = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = MimeType;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.URL:
                {
                    if (createOrReplace)
                    {
                        if (URL == null)
                        {
                            if (replacement == null)
                            {
                                URL = new PropertyState<string>(this);
                            }
                            else
                            {
                                URL = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = URL;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.File:
                {
                    if (createOrReplace)
                    {
                        if (File == null)
                        {
                            if (replacement == null)
                            {
                                File = new FileState(this);
                            }
                            else
                            {
                                File = (FileState)replacement;
                            }
                        }
                    }

                    instance = File;
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
        private PropertyState<string> m_mimeType;
        private PropertyState<string> m_name;
        private PropertyState<string> m_uRL;
        private FileState m_file;
        #endregion
    }
    #endif
    #endregion

    #region ResultSetTypeState Class
    #if (!OPCUA_EXCLUDE_ResultSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResultSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public ResultSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ResultSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (NodeVersion != null)
            {
                NodeVersion.Initialize(context, NodeVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string NodeVersion_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YKkKAgAAAAAACwAAAE5vZGVWZXJz" +
           "aW9uAQHYFwMAAAAApQAAAE5vZGVWZXJzaW9uIGFuZCB0aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZlbnRU" +
           "eXBlIGFyZSBtZWNoYW5pc21zIHRvIG5vdGlmeSBjbGllbnRzIHRoYXQgdGhlIGNvbnRlbnQgb2YgdGhl" +
           "IHNldCBoYXMgY2hhbmdlZCBhbmQgc2hhbGwgYmUgdXNlZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAwMC0z" +
           "LgAuAETYFwAADAMAAABOYU4ADP////8DA/////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAFQAAAFJlc3VsdFNl" +
           "dFR5cGVJbnN0YW5jZQEB/AMBAfwD/AMAAP////8BAAAANWCpCgIAAAAAAAsAAABOb2RlVmVyc2lvbgEB" +
           "2BcDAAAAAKUAAABOb2RlVmVyc2lvbiBhbmQgdGhlIEdlbmVyYWxNb2RlbENoYW5nZUV2ZW50VHlwZSBh" +
           "cmUgbWVjaGFuaXNtcyB0byBub3RpZnkgY2xpZW50cyB0aGF0IHRoZSBjb250ZW50IG9mIHRoZSBzZXQg" +
           "aGFzIGNoYW5nZWQgYW5kIHNoYWxsIGJlIHVzZWQgYXMgZGVmaW5lZCBpbiBPUEMgMTAwMDAtMy4ALgBE" +
           "2BcAAAwDAAAATmFOAAz/////AwP/////AAAAAA==";
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

    #region ResultTypeState Class
    #if (!OPCUA_EXCLUDE_ResultTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResultTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ResultTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ResultType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (DeviceProgramRunId != null)
            {
                DeviceProgramRunId.Initialize(context, DeviceProgramRunId_InitializationString);
            }

            if (TotalRuntime != null)
            {
                TotalRuntime.Initialize(context, TotalRuntime_InitializationString);
            }

            if (TotalPauseTime != null)
            {
                TotalPauseTime.Initialize(context, TotalPauseTime_InitializationString);
            }

            if (EstimatedRuntime != null)
            {
                EstimatedRuntime.Initialize(context, EstimatedRuntime_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceProgramRunId_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEgAAAERldmljZVBy" +
           "b2dyYW1SdW5JZAEBXxkDAAAAAOQAAABEZXZpY2VQcm9ncmFtUnVuSWQgaXMgdGhlIGludGVybmFsIHBy" +
           "b2dyYW0gaWRlbnRpZmllciBhc3NpZ25lZCBieSB0aGUgRGV2aWNlIHRvIHRoZSBwcm9ncmFtIHJ1biBn" +
           "ZW5lcmF0aW5nIHRoaXMgcmVzdWx0LiBJdCBpcyB1c2VkIHRvIGlkZW50aWZ5IGEgUmVzdWx0IG9iamVj" +
           "dCBhbmQgaXMgcmV0dXJuZWQgdG8gdGhlIENsaWVudCB3aGVuIHRoZSBTdGFydFByb2dyYW0gTWV0aG9k" +
           "IGlzIGNhbGxlZC4ALgBEXxkAAAAM/////wMD/////wAAAAA=";

        private const string TotalRuntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEADAAAAFRvdGFsUnVu" +
           "dGltZQEBZBkDAAAAAMAAAABUb3RhbFJ1bnRpbWUgaXMgdGhlIHRvdGFsIHRpbWUgb2YgcHJvZ3JhbSBl" +
           "eGVjdXRpb24gaW5jbHVkaW5nIHBhdXNlZCBzdGF0ZXMuIFBhdXNlZCBzdGF0ZXMgYXJlIHRoZSBoZWxk" +
           "IFN0YXRlIGFuZCB0aGUgc3VzcGVuZGVkIFN0YXRlLiBUaGlzIGluZm9ybWF0aW9uIGlzIHJldHJpZXZl" +
           "ZCBmcm9tIHRoZSBBY3RpdmVQcm9ncmFtVHlwZS4ALgBEZBkAAAEAIgH/////AwP/////AAAAAA==";

        private const string TotalPauseTime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEADgAAAFRvdGFsUGF1" +
           "c2VUaW1lAQFlGQMAAAAAygAAAFRvdGFsUGF1c2VUaW1lIGlzIHRoZSB0aW1lIHRoZSBwcm9ncmFtIGV4" +
           "ZWN1dGlvbiBmb3IgdGhlIHJlc3VsdCB3YXMgaW4gYSBwYXVzZWQgc3RhdGUuIFBhdXNlZCBzdGF0ZXMg" +
           "YXJlIHRoZSBIZWxkIFN0YXRlIGFuZCB0aGUgU3VzcGVuZGVkIFN0YXRlLiBUaGlzIGluZm9ybWF0aW9u" +
           "IGlzIHJldHJpZXZlZCBmcm9tIHRoZSBBY3RpdmVQcm9ncmFtVHlwZS4ALgBEZRkAAAEAIgH/////AwP/" +
           "////AAAAAA==";

        private const string EstimatedRuntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEAAAAEVzdGltYXRl" +
           "ZFJ1bnRpbWUBAWgZAwAAAACEAAAARXN0aW1hdGVkUnVudGltZSBpcyB0aGUgdGltZSB0aGF0IHdhcyBl" +
           "c3RpbWF0ZWQgZm9yIHRoZSBwcm9ncmFtIGV4ZWN1dGlvbi4gVGhpcyBpbmZvcm1hdGlvbiBpcyByZXRy" +
           "aWV2ZWQgZnJvbSB0aGUgQWN0aXZlUHJvZ3JhbVR5cGUuAC4ARGgZAAABACIB/////wMD/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAEgAAAFJlc3VsdFR5" +
           "cGVJbnN0YW5jZQEB/QMBAf0D/QMAAP////8QAAAANWCJCgIAAAABAA4AAABBcHBsaWNhdGlvblVyaQEB" +
           "iRgDAAAAAKMBAABBcHBsaWNhdGlvblVyaSBwcm92aWRlcyBpbmZvcm1hdGlvbiBhYm91dCB0aGUgcmVt" +
           "b3RlIGNsaWVudCB0aGF0IGluaXRpYXRlZCB0aGUgcHJvZ3JhbSBydW4gZ2VuZXJhdGluZyB0aGUgcmVz" +
           "dWx0LiBJdCBtdXN0IGFsaWduIHdpdGggdGhlIEFwcGxpY2F0aW9uVXJpIGluIHRoZSBBcHBsaWNhdGlv" +
           "bkRlc2NyaXB0aW9uIChyZWZlciB0byBPUEMgMTAwMDAtNCBzZWN0aW9uIDcuMSkgb2YgYSBTZXNzaW9u" +
           "IChyZWZlciB0byBPUEMgMTAwMDAtNCBzZWN0aW9uIDUuNi4yKS4gSW4gaW5zdGFuY2VzIHdoZXJlIHRo" +
           "ZSBwcm9ncmFtIHdhcyBpbml0aWF0ZWQgbG9jYWxseSBhbmQgY2Fubm90IGJlIGF0dHJpYnV0ZWQgdG8g" +
           "YW4gT1BDIFVBIENsaWVudCwgdGhlIEFwcGxpY2F0aW9uVXJpIG9mIHRoZSBTZXJ2ZXIgc2hvdWxkIGJl" +
           "IHV0aWxpemVkLgAuAESJGAAAAAz/////AwP/////AAAAADVgiQoCAAAAAQALAAAARGVzY3JpcHRpb24B" +
           "AfwYAwAAAAB5AAAARGVzY3JpcHRpb24gaXMgdGhlIGh1bWFuLXJlYWRhYmxlIGRlc2NyaXB0aW9uIG9m" +
           "IHRoZSBzcGVjaWZpYyBwcm9ncmFtIHJ1biB0aGF0IGNyZWF0ZWQgdGhpcyByZXN1bHQgYW5kIHRoZSBy" +
           "ZXN1bHQgaXRzZWxmLgAuAET8GAAAABX/////AwP/////AAAAACRggAoBAAAAAQAHAAAARmlsZVNldAEB" +
           "2RMDAAAAAGMAAABUaGUgUmVzdWx0RmlsZVNldFR5cGUgaXMgdXNlZCBmb3Igb3JnYW5pc2luZyBSZXN1" +
           "bHRGaWxlVHlwZSBvYmplY3RzIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4ALwEB/gPZEwAA" +
           "/////wAAAAA1YIkKAgAAAAEAEAAAAFN1cGVydmlzb3J5Sm9iSWQBAfkYAwAAAADMAAAAU3VwZXJ2aXNv" +
           "cnlKb2JJZCBpcyB0aGUgaWRlbnRpZmllciBmb3IgdGhlIGV4ZWN1dGlvbiBvZiBhIHNwZWNpZmljIHdv" +
           "cmtmbG93IGNvbnNpc3Rpbmcgb2Ygb25lIG9yIG11bHRpcGxlIHRhc2tzLiBJdCBpcyBwcm92aWRlZCBh" +
           "cyBhbiBBcmd1bWVudCBvZiB0aGUgU3RhcnRQcm9ncmFtKCkgTWV0aG9kIHdoaWNoIGluaXRpYXRlcyB0" +
           "aGUgcHJvZ3JhbSBydW4uAC4ARPkYAAAADP////8DA/////8AAAAAN2CJCgIAAAABAAcAAABTYW1wbGVz" +
           "AQGkGAMAAAAA/gAAAFNhbXBsZXMgaXMgYSBsaXN0IG9mIHNhbXBsZS1zcGVjaWZpYyBpbmZvcm1hdGlv" +
           "biB3aXRoIFNhbXBsZUluZm9UeXBlIHByb3ZpZGVkIHdoZW4gY2FsbGluZyB0aGUgU3RhcnRQcm9ncmFt" +
           "KCkgTWV0aG9kLCB3aGljaCBjYW4gYmUgdXRpbGl6ZWQgd2hlbiBwZXJmb3JtaW5nIHRoZSBwcm9ncmFt" +
           "IHJ1biBhbmQgcHJvdmlkZWQgaW4gdGhlIFJlc3VsdFR5cGUgb2JqZWN0IGZvciBkb2N1bWVudGF0aW9u" +
           "IGFuZCB0cmFjZWFiaWxpdHkgcHVycG9zZXMuAC4ARKQYAAABAboLAQAAAAEAAAABAAAAAwP/////AAAA" +
           "ADVgiQoCAAAAAQAHAAAAU3RhcnRlZAEBoxgDAAAAADkAAABTdGFydGVkIGlzIHRoZSB0aW1lc3RhbXAg" +
           "b2Ygd2hlbiB0aGUgcHJvZ3JhbSB3YXMgc3RhcnRlZC4ALgBEoxgAAAAN/////wMD/////wAAAAA1YIkK" +
           "AgAAAAEABwAAAFN0b3BwZWQBAfoYAwAAAAA5AAAAU3RvcHBlZCBpcyB0aGUgdGltZXN0YW1wIG9mIHdo" +
           "ZW4gdGhlIHByb2dyYW0gd2FzIHN0b3BwZWQuAC4ARPoYAAAADf////8DA/////8AAAAAJGCACgEAAAAB" +
           "AA8AAABQcm9ncmFtVGVtcGxhdGUBAfgTAwAAAADjAAAAUHJvZ3JhbVRlbXBsYXRlIGlzIGFuIGltbXV0" +
           "YWJsZSBjb3B5IG9mIHRoZSBQcm9ncmFtIFRlbXBsYXRlIGF0dHJpYnV0ZXMgd2l0aCB3aGljaCB0aGUg" +
           "cmVzdWx0IHdhcyBnZW5lcmF0ZWQgYW5kIGlzIHByb3ZpZGVkIGZvciBkb2N1bWVudGF0aW9uIGFuZCB0" +
           "cmFjZWFiaWxpdHkgcHVycG9zZXMuIFRoaXMgY29weSB3aWxsIG5vdCBjaGFuZ2UgZXZlbiBpZiB0aGUg" +
           "b3JpZ2luYWwgaXMgY2hhbmdlZC4ALwEB+gP4EwAA/////wYAAAA1YIkKAgAAAAEABgAAAEF1dGhvcgEB" +
           "zBgDAAAAACwAAABBdXRob3IgaXMgdGhlIHVzZXIgd2hvIGNyZWF0ZWQgdGhlIHRlbXBsYXRlLgAuAETM" +
           "GAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAHAAAAQ3JlYXRlZAEBxRgDAAAAADEAAABDcmVhdGVk" +
           "IGlzIHRoZSB0aW1lIG9mIHRoZSB0ZW1wbGF0ZeKAmXMgY3JlYXRpb24uAC4ARMUYAAAADf////8BAf//" +
           "//8AAAAANWCJCgIAAAABAAsAAABEZXNjcmlwdGlvbgEBxBgDAAAAADwAAABEZXNjcmlwdGlvbiBpcyBh" +
           "IGh1bWFuLXJlYWRhYmxlIGRlc2NyaXB0aW9uIG9mIHRoZSB0ZW1wbGF0ZS4ALgBExBgAAAAV/////wEB" +
           "/////wAAAAA1YIkKAgAAAAEACAAAAE1vZGlmaWVkAQHIGAMAAAAAKgAAAE1vZGlmaWVkIGlzIHRoZSB0" +
           "aW1lIG9mIGxhc3QgbW9kaWZpY2F0aW9uLgAuAETIGAAAAA3/////AQH/////AAAAADVgiQoCAAAAAQAQ" +
           "AAAARGV2aWNlVGVtcGxhdGVJZAEBcxgDAAAAAFwAAABEZXZpY2VUZW1wbGF0ZUlkIGlzIHRoZSBwcm9n" +
           "cmFtIHRlbXBsYXRlJ3MgaWRlbnRpZmllciB1bmlxdWUgd2l0aGluIHRoZSBzY29wZSBvZiB0aGUgZGV2" +
           "aWNlLgAuAERzGAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAHAAAAVmVyc2lvbgEByhgDAAAAAFIA" +
           "AABWZXJzaW9uIGlzIHRoZSB2ZXJzaW9uIG9mIHRoZSB0ZW1wbGF0ZSAodGhlIGZvcm1hdCBpcyBhdCB0" +
           "aGUgdXNlcuKAmXMgZGlzY3JldGlvbikuAC4ARMoYAAAADP////8BAf////8AAAAANWCJCgIAAAABAAQA" +
           "AABVc2VyAQGKGAMAAAAAaQEAAFVzZXIgcHJvdmlkZXMgaW5mb3JtYXRpb24gYWJvdXQgdGhlIHJlbW90" +
           "ZSBjbGllbnQgdXNlciB0aGF0IGluaXRpYXRlZCB0aGUgcHJvZ3JhbSBydW4gZ2VuZXJhdGluZyB0aGUg" +
           "cmVzdWx0LiBVc2VyIG11c3QgYmUgYSBodW1hbi1yZWFkYWJsZSB2YWx1ZSwgYmFzZWQgb24gdGhlIFVz" +
           "ZXJJZGVudGl0eVRva2VuIChyZWZlciB0byBPUEMgMTAwMDAtNCBzZWN0aW9uIDcuMzYpLiBJbiBpbnN0" +
           "YW5jZXMgd2hlcmUgdGhlIHByb2dyYW0gd2FzIGluaXRpYXRlZCBsb2NhbGx5IGFuZCBjYW5ub3QgYmUg" +
           "YXR0cmlidXRlZCB0byBhbiBPUEMgVUEgQ2xpZW50LCB0aGUgbG9jYWwgdXNlciBvZiB0aGUgU2VydmVy" +
           "IHNob3VsZCBiZSB1dGlsaXplZC4ALgBEihgAAAAM/////wMD/////wAAAAAkYIAKAQAAAAEACwAAAFZh" +
           "cmlhYmxlU2V0AQHLEwMAAAAAXQAAAFRoZSBWYXJpYWJsZVNldFR5cGUgaXMgdXNlZCBmb3Igc3Rvcmlu" +
           "ZyBhZGRpdGlvbmFsIHNhbXBsZSBkYXRhIHRoYXQgd2FzIGNyZWF0ZWQgZHVyaW5nIGEgcnVuLgAvAQER" +
           "BMsTAAABAAAAACkAAQBVCAAAAAA3YIkKAgAAAAEACgAAAFByb3BlcnRpZXMBAVUZAwAAAAD0AAAAUHJv" +
           "cGVydGllcyBpcyBhIGxpc3Qgb2Yga2V5LXZhbHVlIHBhaXJzIHdpdGggS2V5VmFsdWVUeXBlLCBwcm92" +
           "aWRlZCB3aGVuIGNhbGxpbmcgdGhlIFN0YXJ0UHJvZ3JhbSgpIE1ldGhvZCwgd2hpY2ggY2FuIGJlIHV0" +
           "aWxpemVkIHdoZW4gcGVyZm9ybWluZyB0aGUgcHJvZ3JhbSBydW4gYW5kIHByb3ZpZGVkIGluIHRoZSBS" +
           "ZXN1bHRUeXBlIG9iamVjdCBmb3IgZG9jdW1lbnRhdGlvbiBhbmQgdHJhY2VhYmlsaXR5IHB1cnBvc2Vz" +
           "LgAuAERVGQAAAQG7CwEAAAABAAAAAQAAAAMD/////wAAAAA1YIkKAgAAAAEAEQAAAFN1cGVydmlzb3J5" +
           "VGFza0lkAQFXGQMAAAAA0gAAAFN1cGVydmlzb3J5VGFza0lkIGlzIHRoZSB1bmlxdWUgaWRlbnRpZmll" +
           "ciBvZiB0aGUgc3BlY2lmaWMgVGFzayBpbiB0aGUgc3VwZXJ2aXNvcnkgc3lzdGVtIHRvIHdoaWNoIHRo" +
           "ZSByZXN1bHQgYmVsb25ncy4gSXQgaXMgcHJvdmlkZWQgYXMgYW4gQXJndW1lbnQgb2YgdGhlIFN0YXJ0" +
           "UHJvZ3JhbSgpIE1ldGhvZCB3aGljaCBpbml0aWF0ZXMgdGhlIHByb2dyYW0gcnVuLgAuAERXGQAAAAz/" +
           "////AwP/////AAAAADVgiQoCAAAAAQASAAAARGV2aWNlUHJvZ3JhbVJ1bklkAQFfGQMAAAAA5AAAAERl" +
           "dmljZVByb2dyYW1SdW5JZCBpcyB0aGUgaW50ZXJuYWwgcHJvZ3JhbSBpZGVudGlmaWVyIGFzc2lnbmVk" +
           "IGJ5IHRoZSBEZXZpY2UgdG8gdGhlIHByb2dyYW0gcnVuIGdlbmVyYXRpbmcgdGhpcyByZXN1bHQuIEl0" +
           "IGlzIHVzZWQgdG8gaWRlbnRpZnkgYSBSZXN1bHQgb2JqZWN0IGFuZCBpcyByZXR1cm5lZCB0byB0aGUg" +
           "Q2xpZW50IHdoZW4gdGhlIFN0YXJ0UHJvZ3JhbSBNZXRob2QgaXMgY2FsbGVkLgAuAERfGQAAAAz/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAMAAAAVG90YWxSdW50aW1lAQFkGQMAAAAAwAAAAFRvdGFsUnVudGlt" +
           "ZSBpcyB0aGUgdG90YWwgdGltZSBvZiBwcm9ncmFtIGV4ZWN1dGlvbiBpbmNsdWRpbmcgcGF1c2VkIHN0" +
           "YXRlcy4gUGF1c2VkIHN0YXRlcyBhcmUgdGhlIGhlbGQgU3RhdGUgYW5kIHRoZSBzdXNwZW5kZWQgU3Rh" +
           "dGUuIFRoaXMgaW5mb3JtYXRpb24gaXMgcmV0cmlldmVkIGZyb20gdGhlIEFjdGl2ZVByb2dyYW1UeXBl" +
           "LgAuAERkGQAAAQAiAf////8DA/////8AAAAANWCJCgIAAAABAA4AAABUb3RhbFBhdXNlVGltZQEBZRkD" +
           "AAAAAMoAAABUb3RhbFBhdXNlVGltZSBpcyB0aGUgdGltZSB0aGUgcHJvZ3JhbSBleGVjdXRpb24gZm9y" +
           "IHRoZSByZXN1bHQgd2FzIGluIGEgcGF1c2VkIHN0YXRlLiBQYXVzZWQgc3RhdGVzIGFyZSB0aGUgSGVs" +
           "ZCBTdGF0ZSBhbmQgdGhlIFN1c3BlbmRlZCBTdGF0ZS4gVGhpcyBpbmZvcm1hdGlvbiBpcyByZXRyaWV2" +
           "ZWQgZnJvbSB0aGUgQWN0aXZlUHJvZ3JhbVR5cGUuAC4ARGUZAAABACIB/////wMD/////wAAAAA1YIkK" +
           "AgAAAAEAEAAAAEVzdGltYXRlZFJ1bnRpbWUBAWgZAwAAAACEAAAARXN0aW1hdGVkUnVudGltZSBpcyB0" +
           "aGUgdGltZSB0aGF0IHdhcyBlc3RpbWF0ZWQgZm9yIHRoZSBwcm9ncmFtIGV4ZWN1dGlvbi4gVGhpcyBp" +
           "bmZvcm1hdGlvbiBpcyByZXRyaWV2ZWQgZnJvbSB0aGUgQWN0aXZlUHJvZ3JhbVR5cGUuAC4ARGgZAAAB" +
           "ACIB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> ApplicationUri
        {
            get
            {
                return m_applicationUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_applicationUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_applicationUri = value;
            }
        }

        /// <remarks />
        public new PropertyState<LocalizedText> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <remarks />
        public ResultFileSetTypeState FileSet
        {
            get
            {
                return m_fileSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fileSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fileSet = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SupervisoryJobId
        {
            get
            {
                return m_supervisoryJobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supervisoryJobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supervisoryJobId = value;
            }
        }

        /// <remarks />
        public PropertyState<SampleInfoType[]> Samples
        {
            get
            {
                return m_samples;
            }

            set
            {
                if (!Object.ReferenceEquals(m_samples, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_samples = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Started
        {
            get
            {
                return m_started;
            }

            set
            {
                if (!Object.ReferenceEquals(m_started, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_started = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Stopped
        {
            get
            {
                return m_stopped;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopped, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopped = value;
            }
        }

        /// <remarks />
        public ProgramTemplateTypeState ProgramTemplate
        {
            get
            {
                return m_programTemplate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programTemplate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programTemplate = value;
            }
        }

        /// <remarks />
        public PropertyState<string> User
        {
            get
            {
                return m_user;
            }

            set
            {
                if (!Object.ReferenceEquals(m_user, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_user = value;
            }
        }

        /// <remarks />
        public VariableSetTypeState VariableSet
        {
            get
            {
                return m_variableSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_variableSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_variableSet = value;
            }
        }

        /// <remarks />
        public PropertyState<KeyValueType[]> Properties
        {
            get
            {
                return m_properties;
            }

            set
            {
                if (!Object.ReferenceEquals(m_properties, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_properties = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SupervisoryTaskId
        {
            get
            {
                return m_supervisoryTaskId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supervisoryTaskId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supervisoryTaskId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceProgramRunId
        {
            get
            {
                return m_deviceProgramRunId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceProgramRunId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceProgramRunId = value;
            }
        }

        /// <remarks />
        public PropertyState<double> TotalRuntime
        {
            get
            {
                return m_totalRuntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_totalRuntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_totalRuntime = value;
            }
        }

        /// <remarks />
        public PropertyState<double> TotalPauseTime
        {
            get
            {
                return m_totalPauseTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_totalPauseTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_totalPauseTime = value;
            }
        }

        /// <remarks />
        public PropertyState<double> EstimatedRuntime
        {
            get
            {
                return m_estimatedRuntime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_estimatedRuntime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_estimatedRuntime = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_applicationUri != null)
            {
                children.Add(m_applicationUri);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_fileSet != null)
            {
                children.Add(m_fileSet);
            }

            if (m_supervisoryJobId != null)
            {
                children.Add(m_supervisoryJobId);
            }

            if (m_samples != null)
            {
                children.Add(m_samples);
            }

            if (m_started != null)
            {
                children.Add(m_started);
            }

            if (m_stopped != null)
            {
                children.Add(m_stopped);
            }

            if (m_programTemplate != null)
            {
                children.Add(m_programTemplate);
            }

            if (m_user != null)
            {
                children.Add(m_user);
            }

            if (m_variableSet != null)
            {
                children.Add(m_variableSet);
            }

            if (m_properties != null)
            {
                children.Add(m_properties);
            }

            if (m_supervisoryTaskId != null)
            {
                children.Add(m_supervisoryTaskId);
            }

            if (m_deviceProgramRunId != null)
            {
                children.Add(m_deviceProgramRunId);
            }

            if (m_totalRuntime != null)
            {
                children.Add(m_totalRuntime);
            }

            if (m_totalPauseTime != null)
            {
                children.Add(m_totalPauseTime);
            }

            if (m_estimatedRuntime != null)
            {
                children.Add(m_estimatedRuntime);
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
                case Opc.Ua.LADS.BrowseNames.ApplicationUri:
                {
                    if (createOrReplace)
                    {
                        if (ApplicationUri == null)
                        {
                            if (replacement == null)
                            {
                                ApplicationUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ApplicationUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ApplicationUri;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Description = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.FileSet:
                {
                    if (createOrReplace)
                    {
                        if (FileSet == null)
                        {
                            if (replacement == null)
                            {
                                FileSet = new ResultFileSetTypeState(this);
                            }
                            else
                            {
                                FileSet = (ResultFileSetTypeState)replacement;
                            }
                        }
                    }

                    instance = FileSet;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.SupervisoryJobId:
                {
                    if (createOrReplace)
                    {
                        if (SupervisoryJobId == null)
                        {
                            if (replacement == null)
                            {
                                SupervisoryJobId = new PropertyState<string>(this);
                            }
                            else
                            {
                                SupervisoryJobId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SupervisoryJobId;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Samples:
                {
                    if (createOrReplace)
                    {
                        if (Samples == null)
                        {
                            if (replacement == null)
                            {
                                Samples = new PropertyState<SampleInfoType[]>(this);
                            }
                            else
                            {
                                Samples = (PropertyState<SampleInfoType[]>)replacement;
                            }
                        }
                    }

                    instance = Samples;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Started:
                {
                    if (createOrReplace)
                    {
                        if (Started == null)
                        {
                            if (replacement == null)
                            {
                                Started = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                Started = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Started;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Stopped:
                {
                    if (createOrReplace)
                    {
                        if (Stopped == null)
                        {
                            if (replacement == null)
                            {
                                Stopped = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                Stopped = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Stopped;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ProgramTemplate:
                {
                    if (createOrReplace)
                    {
                        if (ProgramTemplate == null)
                        {
                            if (replacement == null)
                            {
                                ProgramTemplate = new ProgramTemplateTypeState(this);
                            }
                            else
                            {
                                ProgramTemplate = (ProgramTemplateTypeState)replacement;
                            }
                        }
                    }

                    instance = ProgramTemplate;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.User:
                {
                    if (createOrReplace)
                    {
                        if (User == null)
                        {
                            if (replacement == null)
                            {
                                User = new PropertyState<string>(this);
                            }
                            else
                            {
                                User = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = User;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.VariableSet:
                {
                    if (createOrReplace)
                    {
                        if (VariableSet == null)
                        {
                            if (replacement == null)
                            {
                                VariableSet = new VariableSetTypeState(this);
                            }
                            else
                            {
                                VariableSet = (VariableSetTypeState)replacement;
                            }
                        }
                    }

                    instance = VariableSet;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Properties:
                {
                    if (createOrReplace)
                    {
                        if (Properties == null)
                        {
                            if (replacement == null)
                            {
                                Properties = new PropertyState<KeyValueType[]>(this);
                            }
                            else
                            {
                                Properties = (PropertyState<KeyValueType[]>)replacement;
                            }
                        }
                    }

                    instance = Properties;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.SupervisoryTaskId:
                {
                    if (createOrReplace)
                    {
                        if (SupervisoryTaskId == null)
                        {
                            if (replacement == null)
                            {
                                SupervisoryTaskId = new PropertyState<string>(this);
                            }
                            else
                            {
                                SupervisoryTaskId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SupervisoryTaskId;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.DeviceProgramRunId:
                {
                    if (createOrReplace)
                    {
                        if (DeviceProgramRunId == null)
                        {
                            if (replacement == null)
                            {
                                DeviceProgramRunId = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceProgramRunId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceProgramRunId;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TotalRuntime:
                {
                    if (createOrReplace)
                    {
                        if (TotalRuntime == null)
                        {
                            if (replacement == null)
                            {
                                TotalRuntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                TotalRuntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = TotalRuntime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TotalPauseTime:
                {
                    if (createOrReplace)
                    {
                        if (TotalPauseTime == null)
                        {
                            if (replacement == null)
                            {
                                TotalPauseTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                TotalPauseTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = TotalPauseTime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.EstimatedRuntime:
                {
                    if (createOrReplace)
                    {
                        if (EstimatedRuntime == null)
                        {
                            if (replacement == null)
                            {
                                EstimatedRuntime = new PropertyState<double>(this);
                            }
                            else
                            {
                                EstimatedRuntime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = EstimatedRuntime;
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
        private PropertyState<string> m_applicationUri;
        private PropertyState<LocalizedText> m_description;
        private ResultFileSetTypeState m_fileSet;
        private PropertyState<string> m_supervisoryJobId;
        private PropertyState<SampleInfoType[]> m_samples;
        private PropertyState<DateTime> m_started;
        private PropertyState<DateTime> m_stopped;
        private ProgramTemplateTypeState m_programTemplate;
        private PropertyState<string> m_user;
        private VariableSetTypeState m_variableSet;
        private PropertyState<KeyValueType[]> m_properties;
        private PropertyState<string> m_supervisoryTaskId;
        private PropertyState<string> m_deviceProgramRunId;
        private PropertyState<double> m_totalRuntime;
        private PropertyState<double> m_totalPauseTime;
        private PropertyState<double> m_estimatedRuntime;
        #endregion
    }
    #endif
    #endregion

    #region CoverStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_CoverStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CoverStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public CoverStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.CoverStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Close != null)
            {
                Close.Initialize(context, Close_InitializationString);
            }

            if (Lock != null)
            {
                Lock.Initialize(context, Lock_InitializationString);
            }

            if (Open != null)
            {
                Open.Initialize(context, Open_InitializationString);
            }

            if (Unlock != null)
            {
                Unlock.Initialize(context, Unlock_InitializationString);
            }

            if (Reset != null)
            {
                Reset.Initialize(context, Reset_InitializationString);
            }
        }

        #region Initialization String
        private const string Close_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAENsb3NlAQFk" +
           "GwAvAQFkG2QbAAABAQIAAAAANQEBAYgTADUBAQERFAAAAAA=";

        private const string Lock_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABAAAAExvY2sBAWUb" +
           "AC8BAWUbZRsAAAEBAgAAAAA1AQEB0xMANQEBARMUAAAAAA==";

        private const string Open_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABAAAAE9wZW4BAWMb" +
           "AC8BAWMbYxsAAAEBAgAAAAA1AQEB0hMANQEBAfsTAAAAAA==";

        private const string Unlock_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABgAAAFVubG9jawEB" +
           "ZhsALwEBZhtmGwAAAQECAAAAADUBAQHVEwA1AQEB6hMAAAAA";

        private const string Reset_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAFJlc2V0AQFY" +
           "GwAvAQFYG1gbAAABAQEAAAAANQEBAdoTAAAAAA==";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHQAAAENvdmVyU3Rh" +
           "dGVNYWNoaW5lVHlwZUluc3RhbmNlAQHyAwEB8gPyAwAA/////wYAAAAVYIkIAgAAAAAADAAAAEN1cnJl" +
           "bnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEABH/" +
           "////AQH/////AAAAAARhggoEAAAAAQAFAAAAQ2xvc2UBAWQbAC8BAWQbZBsAAAEBAgAAAAA1AQEBiBMA" +
           "NQEBAREUAAAAAARhggoEAAAAAQAEAAAATG9jawEBZRsALwEBZRtlGwAAAQECAAAAADUBAQHTEwA1AQEB" +
           "ExQAAAAABGGCCgQAAAABAAQAAABPcGVuAQFjGwAvAQFjG2MbAAABAQIAAAAANQEBAdITADUBAQH7EwAA" +
           "AAAEYYIKBAAAAAEABgAAAFVubG9jawEBZhsALwEBZhtmGwAAAQECAAAAADUBAQHVEwA1AQEB6hMAAAAA" +
           "BGGCCgQAAAABAAUAAABSZXNldAEBWBsALwEBWBtYGwAAAQEBAAAAADUBAQHaEwAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Close
        {
            get
            {
                return m_closeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_closeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_closeMethod = value;
            }
        }

        /// <remarks />
        public MethodState Lock
        {
            get
            {
                return m_lockMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockMethod = value;
            }
        }

        /// <remarks />
        public MethodState Open
        {
            get
            {
                return m_openMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_openMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_openMethod = value;
            }
        }

        /// <remarks />
        public MethodState Unlock
        {
            get
            {
                return m_unlockMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_unlockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unlockMethod = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_closeMethod != null)
            {
                children.Add(m_closeMethod);
            }

            if (m_lockMethod != null)
            {
                children.Add(m_lockMethod);
            }

            if (m_openMethod != null)
            {
                children.Add(m_openMethod);
            }

            if (m_unlockMethod != null)
            {
                children.Add(m_unlockMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
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
                case Opc.Ua.LADS.BrowseNames.Close:
                {
                    if (createOrReplace)
                    {
                        if (Close == null)
                        {
                            if (replacement == null)
                            {
                                Close = new MethodState(this);
                            }
                            else
                            {
                                Close = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Close;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new MethodState(this);
                            }
                            else
                            {
                                Lock = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Lock;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Open:
                {
                    if (createOrReplace)
                    {
                        if (Open == null)
                        {
                            if (replacement == null)
                            {
                                Open = new MethodState(this);
                            }
                            else
                            {
                                Open = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Open;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Unlock:
                {
                    if (createOrReplace)
                    {
                        if (Unlock == null)
                        {
                            if (replacement == null)
                            {
                                Unlock = new MethodState(this);
                            }
                            else
                            {
                                Unlock = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Unlock;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
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
        private MethodState m_closeMethod;
        private MethodState m_lockMethod;
        private MethodState m_openMethod;
        private MethodState m_unlockMethod;
        private MethodState m_resetMethod;
        #endregion
    }
    #endif
    #endregion

    #region LADSDeviceStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_LADSDeviceStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSDeviceStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public LADSDeviceStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.LADSDeviceStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (GotoOperate != null)
            {
                GotoOperate.Initialize(context, GotoOperate_InitializationString);
            }

            if (GotoShutdown != null)
            {
                GotoShutdown.Initialize(context, GotoShutdown_InitializationString);
            }

            if (GotoSleep != null)
            {
                GotoSleep.Initialize(context, GotoSleep_InitializationString);
            }
        }

        #region Initialization String
        private const string GotoOperate_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACwAAAEdvdG9PcGVy" +
           "YXRlAQFtGwAvAQFtG20bAAABAQEAAAAANQEBAdsTAAAAAA==";

        private const string GotoShutdown_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEADAAAAEdvdG9TaHV0" +
           "ZG93bgEBdxsALwEBdxt3GwAAAQEBAAAAADUBAQFAFAAAAAA=";

        private const string GotoSleep_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACQAAAEdvdG9TbGVl" +
           "cAEBeBsALwEBeBt4GwAAAQEBAAAAADUBAQGMFAAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIgAAAExBRFNEZXZp" +
           "Y2VTdGF0ZU1hY2hpbmVUeXBlSW5zdGFuY2UBAQ8EAQEPBA8EAAD/////BAAAABVgiQgCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQEAAAAvAQDICgAV/////wEB/////wEAAAAVYIkIAgAAAAAAAgAAAElkAQEAAAAu" +
           "AEQAEf////8BAf////8AAAAABGGCCgQAAAABAAsAAABHb3RvT3BlcmF0ZQEBbRsALwEBbRttGwAAAQEB" +
           "AAAAADUBAQHbEwAAAAAEYYIKBAAAAAEADAAAAEdvdG9TaHV0ZG93bgEBdxsALwEBdxt3GwAAAQEBAAAA" +
           "ADUBAQFAFAAAAAAEYYIKBAAAAAEACQAAAEdvdG9TbGVlcAEBeBsALwEBeBt4GwAAAQEBAAAAADUBAQGM" +
           "FAAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState GotoOperate
        {
            get
            {
                return m_gotoOperateMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoOperateMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoOperateMethod = value;
            }
        }

        /// <remarks />
        public MethodState GotoShutdown
        {
            get
            {
                return m_gotoShutdownMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoShutdownMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoShutdownMethod = value;
            }
        }

        /// <remarks />
        public MethodState GotoSleep
        {
            get
            {
                return m_gotoSleepMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoSleepMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoSleepMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_gotoOperateMethod != null)
            {
                children.Add(m_gotoOperateMethod);
            }

            if (m_gotoShutdownMethod != null)
            {
                children.Add(m_gotoShutdownMethod);
            }

            if (m_gotoSleepMethod != null)
            {
                children.Add(m_gotoSleepMethod);
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
                case Opc.Ua.LADS.BrowseNames.GotoOperate:
                {
                    if (createOrReplace)
                    {
                        if (GotoOperate == null)
                        {
                            if (replacement == null)
                            {
                                GotoOperate = new MethodState(this);
                            }
                            else
                            {
                                GotoOperate = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GotoOperate;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.GotoShutdown:
                {
                    if (createOrReplace)
                    {
                        if (GotoShutdown == null)
                        {
                            if (replacement == null)
                            {
                                GotoShutdown = new MethodState(this);
                            }
                            else
                            {
                                GotoShutdown = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GotoShutdown;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.GotoSleep:
                {
                    if (createOrReplace)
                    {
                        if (GotoSleep == null)
                        {
                            if (replacement == null)
                            {
                                GotoSleep = new MethodState(this);
                            }
                            else
                            {
                                GotoSleep = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GotoSleep;
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
        private MethodState m_gotoOperateMethod;
        private MethodState m_gotoShutdownMethod;
        private MethodState m_gotoSleepMethod;
        #endregion
    }
    #endif
    #endregion

    #region FunctionalStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public FunctionalStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.FunctionalStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Abort != null)
            {
                Abort.Initialize(context, Abort_InitializationString);
            }

            if (Clear != null)
            {
                Clear.Initialize(context, Clear_InitializationString);
            }

            if (Stop != null)
            {
                Stop.Initialize(context, Stop_InitializationString);
            }

            if (RunningStateMachine != null)
            {
                RunningStateMachine.Initialize(context, RunningStateMachine_InitializationString);
            }
        }

        #region Initialization String
        private const string Abort_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAEFib3J0AQGm" +
           "GwAvAQGmG6YbAAABAQEAAAAANQEBAe8TAAAAAA==";

        private const string Clear_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAENsZWFyAQGn" +
           "GwAvAQGnG6cbAAABAQEAAAAANQEBAS0UAAAAAA==";

        private const string Stop_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABAAAAFN0b3ABAcgb" +
           "AC8BAcgbyBsAAAEBAQAAAAA1AQEB8RMAAAAA";

        private const string RunningStateMachine_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEAEwAAAFJ1bm5pbmdT" +
           "dGF0ZU1hY2hpbmUBAQoUAwAAAABxAAAAVGhlIFJ1bm5pbmdTdGF0ZU1hY2hpbmVUeXBlIGlzIGEgc3Vi" +
           "LXN0YXRlIG1hY2hpbmUgb2YgdGhlIEZ1bmN0aW9uYWxTdGF0ZU1hY2hpbmUgYW5kIGluY2x1ZGVzIGRl" +
           "dGFpbGVkIHN1YnN0YXRlcy4ALwEBDAQKFAAAAQAAAAB1AQEB6xMBAAAAFWCJCgIAAAAAAAwAAABDdXJy" +
           "ZW50U3RhdGUBAQIYAC8BAMgKAhgAAAAV/////wEB/////wEAAAAVYIkIAgAAAAAAAgAAAElkAQEAAAAu" +
           "AEQAEf////8BAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIgAAAEZ1bmN0aW9u" +
           "YWxTdGF0ZU1hY2hpbmVUeXBlSW5zdGFuY2UBAQ4EAQEOBA4EAAD/////BwAAABVgiQoCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQHUFwAvAQDICtQXAAAAFf////8BAf////8CAAAAFWCJCAIAAAAAAAIAAABJZAEB" +
           "AAAALgBEABH/////AQH/////AAAAABVgiQoCAAAAAAAUAAAARWZmZWN0aXZlRGlzcGxheU5hbWUBAdUX" +
           "AC4ARNUXAAAAFf////8BAf////8AAAAAN2CJCgIAAAAAAA8AAABBdmFpbGFibGVTdGF0ZXMBAUkZAwAA" +
           "AAAuAAAAU2V0IG9mIHN0YXRlcyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9JGQAA" +
           "ABEBAAAAAQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAABQAAABBdmFpbGFibGVUcmFuc2l0aW9ucwEB" +
           "SBkDAAAAADMAAABTZXQgb2YgdHJhbnNpdGlvbnMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlv" +
           "bi4ALwA/SBkAAAARAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAFAAAAQWJvcnQBAaYbAC8B" +
           "AaYbphsAAAEBAQAAAAA1AQEB7xMAAAAABGGCCgQAAAABAAUAAABDbGVhcgEBpxsALwEBpxunGwAAAQEB" +
           "AAAAADUBAQEtFAAAAAAEYYIKBAAAAAEABAAAAFN0b3ABAcgbAC8BAcgbyBsAAAEBAQAAAAA1AQEB8RMA" +
           "AAAAJGCACgEAAAABABMAAABSdW5uaW5nU3RhdGVNYWNoaW5lAQEKFAMAAAAAcQAAAFRoZSBSdW5uaW5n" +
           "U3RhdGVNYWNoaW5lVHlwZSBpcyBhIHN1Yi1zdGF0ZSBtYWNoaW5lIG9mIHRoZSBGdW5jdGlvbmFsU3Rh" +
           "dGVNYWNoaW5lIGFuZCBpbmNsdWRlcyBkZXRhaWxlZCBzdWJzdGF0ZXMuAC8BAQwEChQAAAEAAAAAdQEB" +
           "AesTAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQECGAAvAQDICgIYAAAAFf////8BAf////8B" +
           "AAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Abort
        {
            get
            {
                return m_abortMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_abortMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_abortMethod = value;
            }
        }

        /// <remarks />
        public MethodState Clear
        {
            get
            {
                return m_clearMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_clearMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_clearMethod = value;
            }
        }

        /// <remarks />
        public MethodState Stop
        {
            get
            {
                return m_stopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopMethod = value;
            }
        }

        /// <remarks />
        public RunningStateMachineTypeState RunningStateMachine
        {
            get
            {
                return m_runningStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningStateMachine = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_abortMethod != null)
            {
                children.Add(m_abortMethod);
            }

            if (m_clearMethod != null)
            {
                children.Add(m_clearMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
            }

            if (m_runningStateMachine != null)
            {
                children.Add(m_runningStateMachine);
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
                case Opc.Ua.LADS.BrowseNames.Abort:
                {
                    if (createOrReplace)
                    {
                        if (Abort == null)
                        {
                            if (replacement == null)
                            {
                                Abort = new MethodState(this);
                            }
                            else
                            {
                                Abort = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Abort;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Clear:
                {
                    if (createOrReplace)
                    {
                        if (Clear == null)
                        {
                            if (replacement == null)
                            {
                                Clear = new MethodState(this);
                            }
                            else
                            {
                                Clear = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Clear;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new MethodState(this);
                            }
                            else
                            {
                                Stop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Stop;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.RunningStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (RunningStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                RunningStateMachine = new RunningStateMachineTypeState(this);
                            }
                            else
                            {
                                RunningStateMachine = (RunningStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = RunningStateMachine;
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
        private MethodState m_abortMethod;
        private MethodState m_clearMethod;
        private MethodState m_stopMethod;
        private RunningStateMachineTypeState m_runningStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region RunningStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_RunningStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RunningStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        /// <remarks />
        public RunningStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.RunningStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Hold != null)
            {
                Hold.Initialize(context, Hold_InitializationString);
            }

            if (Reset != null)
            {
                Reset.Initialize(context, Reset_InitializationString);
            }

            if (Suspend != null)
            {
                Suspend.Initialize(context, Suspend_InitializationString);
            }

            if (ToComplete != null)
            {
                ToComplete.Initialize(context, ToComplete_InitializationString);
            }

            if (Unhold != null)
            {
                Unhold.Initialize(context, Unhold_InitializationString);
            }

            if (Unsuspend != null)
            {
                Unsuspend.Initialize(context, Unsuspend_InitializationString);
            }
        }

        #region Initialization String
        private const string Hold_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABAAAAEhvbGQBAaIb" +
           "AC8BAaIbohsAAAEBBgAAAAA1AQEBuxMANQEBAQkUADUBAQELFAA1AQEBDBQANQEBAQ0UADUBAQEOFAAA" +
           "AAA=";

        private const string Reset_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAFJlc2V0AQGd" +
           "GwAvAQGdG50bAAABAQEAAAAANQEBAasTAAAAAA==";

        private const string Suspend_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABwAAAFN1c3BlbmQB" +
           "AaEbAC8BAaEboRsAAAEBAQAAAAA1AQEBrRMAAAAA";

        private const string ToComplete_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACgAAAFRvQ29tcGxl" +
           "dGUBAZ4bAC8BAZ4bnhsAAAEBAQAAAAA1AQEBqRMAAAAA";

        private const string Unhold_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABgAAAFVuaG9sZAEB" +
           "oBsALwEBoBugGwAAAQEBAAAAADUBAQG9EwAAAAA=";

        private const string Unsuspend_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACQAAAFVuc3VzcGVu" +
           "ZAEBoxsALwEBoxujGwAAAQEBAAAAADUBAQGwEwAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHwAAAFJ1bm5pbmdT" +
           "dGF0ZU1hY2hpbmVUeXBlSW5zdGFuY2UBAQwEAQEMBAwEAAD/////BwAAABVgiQoCAAAAAAAMAAAAQ3Vy" +
           "cmVudFN0YXRlAQECGAAvAQDICgIYAAAAFf////8BAf////8BAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAA" +
           "LgBEABH/////AQH/////AAAAAARhggoEAAAAAQAEAAAASG9sZAEBohsALwEBohuiGwAAAQEGAAAAADUB" +
           "AQG7EwA1AQEBCRQANQEBAQsUADUBAQEMFAA1AQEBDRQANQEBAQ4UAAAAAARhggoEAAAAAQAFAAAAUmVz" +
           "ZXQBAZ0bAC8BAZ0bnRsAAAEBAQAAAAA1AQEBqxMAAAAABGGCCgQAAAABAAcAAABTdXNwZW5kAQGhGwAv" +
           "AQGhG6EbAAABAQEAAAAANQEBAa0TAAAAAARhggoEAAAAAQAKAAAAVG9Db21wbGV0ZQEBnhsALwEBnhue" +
           "GwAAAQEBAAAAADUBAQGpEwAAAAAEYYIKBAAAAAEABgAAAFVuaG9sZAEBoBsALwEBoBugGwAAAQEBAAAA" +
           "ADUBAQG9EwAAAAAEYYIKBAAAAAEACQAAAFVuc3VzcGVuZAEBoxsALwEBoxujGwAAAQEBAAAAADUBAQGw" +
           "EwAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Hold
        {
            get
            {
                return m_holdMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_holdMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_holdMethod = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <remarks />
        public MethodState Suspend
        {
            get
            {
                return m_suspendMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendMethod = value;
            }
        }

        /// <remarks />
        public MethodState ToComplete
        {
            get
            {
                return m_toCompleteMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toCompleteMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toCompleteMethod = value;
            }
        }

        /// <remarks />
        public MethodState Unhold
        {
            get
            {
                return m_unholdMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_unholdMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unholdMethod = value;
            }
        }

        /// <remarks />
        public MethodState Unsuspend
        {
            get
            {
                return m_unsuspendMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_unsuspendMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unsuspendMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_holdMethod != null)
            {
                children.Add(m_holdMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_suspendMethod != null)
            {
                children.Add(m_suspendMethod);
            }

            if (m_toCompleteMethod != null)
            {
                children.Add(m_toCompleteMethod);
            }

            if (m_unholdMethod != null)
            {
                children.Add(m_unholdMethod);
            }

            if (m_unsuspendMethod != null)
            {
                children.Add(m_unsuspendMethod);
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
                case Opc.Ua.LADS.BrowseNames.Hold:
                {
                    if (createOrReplace)
                    {
                        if (Hold == null)
                        {
                            if (replacement == null)
                            {
                                Hold = new MethodState(this);
                            }
                            else
                            {
                                Hold = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Hold;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Suspend:
                {
                    if (createOrReplace)
                    {
                        if (Suspend == null)
                        {
                            if (replacement == null)
                            {
                                Suspend = new MethodState(this);
                            }
                            else
                            {
                                Suspend = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Suspend;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ToComplete:
                {
                    if (createOrReplace)
                    {
                        if (ToComplete == null)
                        {
                            if (replacement == null)
                            {
                                ToComplete = new MethodState(this);
                            }
                            else
                            {
                                ToComplete = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ToComplete;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Unhold:
                {
                    if (createOrReplace)
                    {
                        if (Unhold == null)
                        {
                            if (replacement == null)
                            {
                                Unhold = new MethodState(this);
                            }
                            else
                            {
                                Unhold = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Unhold;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Unsuspend:
                {
                    if (createOrReplace)
                    {
                        if (Unsuspend == null)
                        {
                            if (replacement == null)
                            {
                                Unsuspend = new MethodState(this);
                            }
                            else
                            {
                                Unsuspend = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Unsuspend;
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
        private MethodState m_holdMethod;
        private MethodState m_resetMethod;
        private MethodState m_suspendMethod;
        private MethodState m_toCompleteMethod;
        private MethodState m_unholdMethod;
        private MethodState m_unsuspendMethod;
        #endregion
    }
    #endif
    #endregion

    #region MaintenanceSetTypeState Class
    #if (!OPCUA_EXCLUDE_MaintenanceSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MaintenanceSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public MaintenanceSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.MaintenanceSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGgAAAE1haW50ZW5h" +
           "bmNlU2V0VHlwZUluc3RhbmNlAQEDBAEBAwQDBAAAAQAAAAApAAEAVQgAAAAA";
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

    #region MaintenanceTaskTypeState Class
    #if (!OPCUA_EXCLUDE_MaintenanceTaskTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MaintenanceTaskTypeState : MaintenanceRequiredAlarmTypeState
    {
        #region Constructors
        /// <remarks />
        public MaintenanceTaskTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.MaintenanceTaskType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (StartTask != null)
            {
                StartTask.Initialize(context, StartTask_InitializationString);
            }

            if (LastExecutionDate != null)
            {
                LastExecutionDate.Initialize(context, LastExecutionDate_InitializationString);
            }

            if (RecurrencePeriod != null)
            {
                RecurrencePeriod.Initialize(context, RecurrencePeriod_InitializationString);
            }

            if (LastOperatingTime != null)
            {
                LastOperatingTime.Initialize(context, LastOperatingTime_InitializationString);
            }

            if (NextOperatingTime != null)
            {
                NextOperatingTime.Initialize(context, NextOperatingTime_InitializationString);
            }

            if (LastOperatingCycles != null)
            {
                LastOperatingCycles.Initialize(context, LastOperatingCycles_InitializationString);
            }

            if (NextOperatingCycles != null)
            {
                NextOperatingCycles.Initialize(context, NextOperatingCycles_InitializationString);
            }

            if (StopTask != null)
            {
                StopTask.Initialize(context, StopTask_InitializationString);
            }

            if (ResetTask != null)
            {
                ResetTask.Initialize(context, ResetTask_InitializationString);
            }

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
        private const string StartTask_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACQAAAFN0YXJ0VGFz" +
           "awEBlRsALwEBlRuVGwAAAQH/////AAAAAA==";

        private const string LastExecutionDate_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEQAAAExhc3RFeGVj" +
           "dXRpb25EYXRlAQHYGAMAAAAAcAAAAExhc3RFeGVjdXRpb25EYXRlIGlzIHRoZSBkYXRlIHdoZW4gdGhl" +
           "IFRhc2sgd2FzIGxhc3QgcGVyZm9ybWVkLiBPcHRpb25hbCwgYXMgdGhlIFRhc2sgbWF5IGhhdmUgbmV2" +
           "ZXIgcnVuIGJlZm9yZS4ALgBE2BgAAAEAJgH/////AwP/////AAAAAA==";

        private const string RecurrencePeriod_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEAAAAFJlY3VycmVu" +
           "Y2VQZXJpb2QBAdoYAwAAAACJAAAAUmVjdXJyZW5jZVBlcmlvZCBpcyB0aGUgcGVyaW9kIG9mIHJlcGV0" +
           "aXRpb24gb2YgdGhlIFRhc2ssIHNwZWNpZmllZCBpbiBtaWxsaXNlY29uZHMuIE9wdGlvbmFsLCBhcyBu" +
           "b3QgYWxsIFRhc2tzIGhhdmUgYSByZWN1cnJlbmNlIHBlcmlvZC4ALgBE2hgAAAEAIgH/////AwP/////" +
           "AAAAAA==";

        private const string LastOperatingTime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEQAAAExhc3RPcGVy" +
           "YXRpbmdUaW1lAQHBFwMAAAAAtgAAAExhc3RPcGVyYXRpbmdUaW1lIGlzIHRoZSB0b3RhbCBhbW91bnQg" +
           "b2Ygb3BlcmF0aW5nIHRpbWUgKGFzIGRlZmluZWQgaW4gU2VjdGlvbiA5LjMgb2YgRU4gMTMzMDYtMjAx" +
           "NykgaW4gbWlsbGlzZWNvbmRzIChtcykgYnkgdGhlIERldmljZSBhdCB0aGUgdGltZSBvZiB0aGUgbGFz" +
           "dCBleGVjdXRpb24gb2YgdGhlIFRhc2suAC4ARMEXAAABACIB/////wMD/////wAAAAA=";

        private const string NextOperatingTime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEQAAAE5leHRPcGVy" +
           "YXRpbmdUaW1lAQHHFwMAAAAArgAAAE5leHRPcGVyYXRpbmdUaW1lIGlzIHRoZSB0b3RhbCBhbW91bnQg" +
           "b2Ygb3BlcmF0aW5nIHRpbWUgKGFzIGRlZmluZWQgaW4gU2VjdGlvbiA5LjMgb2YgRU4gMTMzMDYtMjAx" +
           "NykgaW4gbWlsbGlzZWNvbmRzIChtcykgYnkgdGhlIERldmljZSBiZWZvcmUgdGhlIG5leHQgZXhlY3V0" +
           "aW9uIG9mIHRoZSBUYXNrLgAuAETHFwAAAQAiAf////8DA/////8AAAAA";

        private const string LastOperatingCycles_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEwAAAExhc3RPcGVy" +
           "YXRpbmdDeWNsZXMBAcgXAwAAAACqAAAATGFzdE9wZXJhdGluZ0N5Y2xlcyBpcyB0aGUgbnVtYmVyIG9m" +
           "IGN5Y2xlcyBkdXJpbmcgdGhlIG9wZXJhdGluZyB0aW1lIChhcyBkZWZpbmVkIGluIFNlY3Rpb24gOS4z" +
           "IG9mIEVOIDEzMzA2LTIwMTcpIHJlY29yZGVkIGF0IHRoZSB0aW1lIG9mIHRoZSBsYXN0IGV4ZWN1dGlv" +
           "biBvZiB0aGUgVGFzay4ALgBEyBcAAAAH/////wMD/////wAAAAA=";

        private const string NextOperatingCycles_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEAEwAAAE5leHRPcGVy" +
           "YXRpbmdDeWNsZXMBAcsXAwAAAAClAAAATmV4dE9wZXJhdGluZ0N5Y2xlcyBpcyB0aGUgbnVtYmVyIG9m" +
           "IGN5Y2xlcyBkdXJpbmcgb3BlcmF0aW5nIHRpbWUgKGFzIGRlZmluZWQgaW4gU2VjdGlvbiA5LjMgb2Yg" +
           "RU4gMTMzMDYtMjAxNykgdG8gYmUgY29tcGxldGVkIGJlZm9yZSB0aGUgbmV4dCBleGVjdXRpb24gb2Yg" +
           "dGhlIFRhc2suAC4ARMsXAAAAB/////8DA/////8AAAAA";

        private const string StopTask_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACAAAAFN0b3BUYXNr" +
           "AQFZGwAvAQFZG1kbAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBzBcALgBE" +
           "zBcAAJYCAAAAAQAqAQFXAAAAGQAAAE1haW50ZW5hbmNlVGFza1N0b3BSZXN1bHQBAbgL/////wAAAAAC" +
           "KQAAAFByb3ZpZGUgdGhlIHJlc3VsdCBvZiB0aGUuVGFzayBleGVjdXRpb24uAQAqAQEtAAAABwAAAENv" +
           "bW1lbnQAFf////8AAAAAAhMAAABBZGRpdGlvbmFsIGNvbW1lbnQuAQAoAQEAAAABAAAAAgAAAAEB////" +
           "/wAAAAA=";

        private const string ResetTask_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACQAAAFJlc2V0VGFz" +
           "awEBWxsALwEBWxtbGwAAAQH/////AAAAAA==";

        private const string ConfigurationChanged_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAFAAAAENvbmZpZ3Vy" +
           "YXRpb25DaGFuZ2VkAQHRFwMAAAAAmAAAAFRoZSBDb25maWd1cmF0aW9uQ2hhbmdlZCBwcm92aWRlcyBp" +
           "bmZvcm1hdGlvbiBpZiB0aGUgY29uZmlndXJhdGlvbiBvZiB0aGUgYXNzZXQgaXMgcGxhbm5lZCB0byBi" +
           "ZSBjaGFuZ2VkIG9yIGhhcyBjaGFuZ2VkIGR1cmluZyB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHkuAC4A" +
           "RNEXAAAAAf////8DA/////8AAAAA";

        private const string EstimatedDowntime_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAEQAAAEVzdGltYXRl" +
           "ZERvd250aW1lAQHWFwMAAAAA7wEAAFRoZSBFc3RpbWF0ZWREb3dudGltZSBwcm92aWRlcyB0aGUgZXN0" +
           "aW1hdGVkIHRpbWUgdGhlIGV4ZWN1dGlvbiBvZiB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHkgd2lsbCB0" +
           "YWtlLiBJbiBjYXNlIG9mIHJlcGxhbm5pbmcsIGl0IGlzIGFsbG93ZWQgdG8gY2hhbmdlIHRoZSBFc3Rp" +
           "bWF0ZWREb3dudGltZS4gSWYgZHVyaW5nIHRoZSBleGVjdXRpb24gb2YgdGhlIG1haW50ZW5hbmNlIGFj" +
           "dGl2aXR5IHRoZSBFc3RpbWF0ZWREb3dudGltZSBjYW4gYmUgYWRqdXN0ZWQgKGUuZy4sIHRoZSBhc3Nl" +
           "dCBuZWVkcyB0byBiZSByZXBhaXJlZCBiZWNhdXNlIGFuIGluc3BlY3Rpb24gZm91bmQgc29tZSBpc3N1" +
           "ZXMpIHRoaXMgc2hvdWxkIGJlIGRvbmUuIENsaWVudHMgY2FuIGFjY2VzcyB0aGUgaGlzdG9yeSBvZiBF" +
           "dmVudHMgdG8gcmVjZWl2ZSB0aGUgaW5mb3JtYXRpb24gb24gdGhlIG9yaWdpbmFsIGVzdGltYXRlcyB3" +
           "aGVuIHRoZSBtYWludGVuYW5jZSBhY3Rpdml0eSBzdGFydGVkLgAuAETWFwAAAQAiAf////8DA/////8A" +
           "AAAA";

        private const string MaintenanceMethod_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAEQAAAE1haW50ZW5h" +
           "bmNlTWV0aG9kAQHaFwMAAAAAKwEAAFRoZSBNYWludGVuYW5jZU1ldGhvZCBwcm92aWRlcyBpbmZvcm1h" +
           "dGlvbiBhYm91dCB0aGUgcGxhbm5lZCBvciB1c2VkIG1haW50ZW5hbmNlIG1ldGhvZC4gVGhlIGNvbnRl" +
           "bnQgbWF5IGNoYW5nZSBkdXJpbmcgdGhlIGRpZmZlcmVudCBNYWludGVuYW5jZVN0YXRlcy4gQnkgYWNj" +
           "ZXNzaW5nIHRoZSBoaXN0b3J5IG9mIEV2ZW50cyBhIENsaWVudCBjYW4gZGlzdGluZ3Vpc2ggYmV0d2Vl" +
           "biB0aGUgcGxhbm5lZCBhbmQgYWN0dWFsIHVzZWQgbWFpbnRlbmFuY2UgbWV0aG9kIGR1cmluZyB0aGUg" +
           "bWFpbnRlbmFuY2UgYWN0aXZpdHkuAC4ARNoXAAABBLwL/////wMD/////wAAAAA=";

        private const string MaintenanceSupplier_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAEwAAAE1haW50ZW5h" +
           "bmNlU3VwcGxpZXIBAdsXAwAAAADxAQAAVGhlIE1haW50ZW5hbmNlU3VwcGxpZXIgcHJvdmlkZXMgaW5m" +
           "b3JtYXRpb24gb24gdGhlIHN1cHBsaWVyIHRoYXQgaXMgcGxhbm5lZCB0byBleGVjdXRlLCBjdXJyZW50" +
           "bHkgZXhlY3V0aW5nIG9yIGhhcyBleGVjdXRlZCB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHkuIFRoZSBj" +
           "b250ZW50IG1heSBjaGFuZ2UgZHVyaW5nIHRoZSBkaWZmZXJlbnQgTWFpbnRlbmFuY2VTdGF0ZXMuIEJ5" +
           "IGFjY2Vzc2luZyB0aGUgaGlzdG9yeSBvZiBFdmVudHMgYSBDbGllbnQgY2FuIGRpc3Rpbmd1aXNoIGJl" +
           "dHdlZW4gdGhlIHBsYW5uZWQgYW5kIGFjdHVhbCBzdXBwbGllciB0aGF0IGV4ZWN1dGVkIHRoZSBtYWlu" +
           "dGVuYW5jZSBhY3Rpdml0eS4gVGhlIHZhbHVlIGNvbnRhaW5zIGFsd2F5cyBhIGh1bWFuLXJlYWRhYmxl" +
           "IG5hbWUgb2YgdGhlIHN1cHBsaWVyIGFuZCBvcHRpb25hbGx5IHJlZmVyZW5jZXMgYSBOb2RlIHJlcHJl" +
           "c2VudGluZyB0aGUgc3VwcGxpZXIgaW4gdGhlIEFkZHJlc3NTcGFjZS4ALgBE2xcAAAEEuwv/////AwP/" +
           "////AAAAAA==";

        private const string PartsOfAssetReplaced_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////83YIkKAgAAAAQAFAAAAFBhcnRzT2ZB" +
           "c3NldFJlcGxhY2VkAQHcFwMAAAAAkwIAAFRoZSBQYXJ0c09mQXNzZXRSZXBsYWNlZCBwcm92aWRlcyBp" +
           "bmZvcm1hdGlvbiBvbiB0aGUgcGFydHMgb2YgdGhlIGFzc2V0cyB0aGF0IGFyZSBwbGFubmVkIHRvIGJl" +
           "IHJlcGxhY2VkIGR1cmluZyB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHksIGN1cnJlbnRseSBpbiByZXBs" +
           "YWNlbWVudCBvciBoYXZlIGJlZW4gcmVwbGFjZWQsIGRlcGVuZGluZyBvbiB0aGUgZGlmZmVyZW50IE1h" +
           "aW50ZW5hbmNlU3RhdGVzLiBUaGUgY29udGVudCBtYXkgY2hhbmdlIGR1cmluZyB0aGUgZGlmZmVyZW50" +
           "IE1haW50ZW5hbmNlU3RhdGVzLiBCeSBhY2Nlc3NpbmcgdGhlIGhpc3Rvcnkgb2YgRXZlbnRzIGEgQ2xp" +
           "ZW50IGNhbiBkaXN0aW5ndWlzaCBiZXR3ZWVuIHRoZSBwbGFubmVkIGFuZCBhY3R1YWwgcGFydHMgb2Yg" +
           "dGhlIGFzc2V0cyByZXBsYWNlZCBkdXJpbmcgdGhlIG1haW50ZW5hbmNlIGFjdGl2aXR5LiBUaGUgdmFs" +
           "dWUgY29udGFpbnMgYWx3YXlzIGFuIGFycmF5IG9mIGEgaHVtYW4tcmVhZGFibGUgbmFtZSBvZiB0aGUg" +
           "cXVhbGlmaWNhdGlvbiBvZiB0aGUgcGFydHMgb2YgdGhlIGFzc2V0IHRvIGJlIHJlcGxhY2VkIGFuZCBv" +
           "cHRpb25hbGx5IHJlZmVyZW5jZXMgYSBOb2RlIHJlcHJlc2VudGluZyBlYWNoIHBhcnQgb2YgdGhlIGFz" +
           "c2V0IGluIHRoZSBBZGRyZXNzU3BhY2UuAC4ARNwXAAABBLsLAQAAAAEAAAAAAAAAAwP/////AAAAAA==";

        private const string PartsOfAssetServiced_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////83YIkKAgAAAAQAFAAAAFBhcnRzT2ZB" +
           "c3NldFNlcnZpY2VkAQHfFwMAAAAAjAIAAFRoZSBQYXJ0c09mQXNzZXRTZXJ2aWNlZCBwcm92aWRlcyBp" +
           "bmZvcm1hdGlvbiBvbiB0aGUgcGFydHMgb2YgdGhlIGFzc2V0cyB0aGF0IGFyZSBwbGFubmVkIHRvIGJl" +
           "IHNlcnZpY2VkIGR1cmluZyB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHksIGN1cnJlbnRseSBzZXJ2aWNl" +
           "ZCBvciBoYXZlIGJlZW4gc2VydmljZWQsIGRlcGVuZGluZyBvbiB0aGUgZGlmZmVyZW50IE1haW50ZW5h" +
           "bmNlU3RhdGVzLiBUaGUgY29udGVudCBtYXkgY2hhbmdlIGR1cmluZyB0aGUgZGlmZmVyZW50IE1haW50" +
           "ZW5hbmNlU3RhdGVzLiBCeSBhY2Nlc3NpbmcgdGhlIGhpc3Rvcnkgb2YgRXZlbnRzIGEgQ2xpZW50IGNh" +
           "biBkaXN0aW5ndWlzaCBiZXR3ZWVuIHRoZSBwbGFubmVkIGFuZCBhY3R1YWwgcGFydHMgb2YgdGhlIGFz" +
           "c2V0cyBzZXJ2aWNlZCBkdXJpbmcgdGhlIG1haW50ZW5hbmNlIGFjdGl2aXR5LiBUaGUgdmFsdWUgY29u" +
           "dGFpbnMgYWx3YXlzIGFuIGFycmF5IG9mIGEgaHVtYW4tcmVhZGFibGUgbmFtZSBvZiB0aGUgcXVhbGlm" +
           "aWNhdGlvbiBvZiB0aGUgcGFydHMgb2YgdGhlIGFzc2V0IHRvIGJlIHNlcnZpY2VkIGFuZCBvcHRpb25h" +
           "bGx5IHJlZmVyZW5jZXMgYSBOb2RlIHJlcHJlc2VudGluZyB0aGUgcGFydCBvZiB0aGUgYXNzZXQgaW4g" +
           "dGhlIEFkZHJlc3NTcGFjZS4ALgBE3xcAAAEEuwsBAAAAAQAAAAAAAAADA/////8AAAAA";

        private const string PlannedDate_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQACwAAAFBsYW5uZWRE" +
           "YXRlAQHnFwMAAAAAngEAAFRoZSBQbGFubmVkRGF0ZSBwcm92aWRlcyB0aGUgZGF0ZSBmb3Igd2hpY2gg" +
           "dGhlIG1haW50ZW5hbmNlIGFjdGl2aXR5IGhhcyBiZWVuIHNjaGVkdWxlZC4uIEluIGNhc2Ugb2YgcmVw" +
           "bGFubmluZywgaXQgaXMgYWxsb3dlZCB0byBjaGFuZ2UgdGhlIFBsYW5uZWREYXRlLiBIb3dldmVyLCBp" +
           "dCBpcyBub3QgdGhlIGludGVudGlvbiB0aGF0IHRoZSBQbGFubmVkRGF0ZSBpcyBtb2RpZmllZCBiZWNh" +
           "dXNlIHRoZSBtYWludGVuYW5jZSBhY3Rpdml0eSBzdGFydHMgdG8gZ2V0IGV4ZWN1dGVkLiBJZiB0aGUg" +
           "UGxhbm5lZERhdGUgZGVwZW5kcyBmb3IgZXhhbXBsZSBvbiB0aGUgb3BlcmF0aW9uIGhvdXJzIG9mIHRo" +
           "ZSBhc3NldCwgaXQgbWlnaHQgZ2V0IGFkYXB0ZWQgZGVwZW5kaW5nIG9uIHRoZSBwYXNzZWQgb3BlcmF0" +
           "aW9uIGhvdXJzLgAuAETnFwAAAQAmAf////8DA/////8AAAAA";

        private const string QualificationOfPersonnel_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAGAAAAFF1YWxpZmlj" +
           "YXRpb25PZlBlcnNvbm5lbAEB6BcDAAAAAE4CAABUaGUgUXVhbGlmaWNhdGlvbk9mUGVyc29ubmVsIHBy" +
           "b3ZpZGVzIGluZm9ybWF0aW9uIG9uIHRoZSBxdWFsaWZpY2F0aW9uIG9mIHRoZSBwZXJzb25uZWwgdGhh" +
           "dCBpcyBwbGFubmVkIHRvIGV4ZWN1dGUsIGN1cnJlbnRseSBleGVjdXRpbmcgb3IgaGFzIGV4ZWN1dGVk" +
           "IHRoZSBtYWludGVuYW5jZSBhY3Rpdml0eS4gVGhlIGNvbnRlbnQgbWF5IGNoYW5nZSBkdXJpbmcgdGhl" +
           "IGRpZmZlcmVudCBNYWludGVuYW5jZVN0YXRlcy4gQnkgYWNjZXNzaW5nIHRoZSBoaXN0b3J5IG9mIEV2" +
           "ZW50cyBhIENsaWVudCBjYW4gZGlzdGluZ3Vpc2ggYmV0d2VlbiB0aGUgcGxhbm5lZCBhbmQgYWN0dWFs" +
           "IHF1YWxpZmljYXRpb24gb2YgdGhlIHBlcnNvbm5lbCB0aGF0IGV4ZWN1dGVkIHRoZSBtYWludGVuYW5j" +
           "ZSBhY3Rpdml0eS4gVGhlIHZhbHVlIGNvbnRhaW5zIGFsd2F5cyBhIGh1bWFuLXJlYWRhYmxlIG5hbWUg" +
           "b2YgdGhlIHF1YWxpZmljYXRpb24gb2YgdGhlIHBlcnNvbm5lbCBhbmQgb3B0aW9uYWxseSByZWZlcmVu" +
           "Y2VzIGEgTm9kZSByZXByZXNlbnRpbmcgdGhlIHF1YWxpZmljYXRpb24gb2YgdGhlIHBlcnNvbm5lbCBp" +
           "biB0aGUgQWRkcmVzc1NwYWNlLgAuAEToFwAAAQS7C/////8DA/////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGwAAAE1haW50ZW5h" +
           "bmNlVGFza1R5cGVJbnN0YW5jZQEBBAQBAQQEBAQAAAEAAAABAMNEAAEE9AMvAAAAFWCJCAIAAAAAAAcA" +
           "AABFdmVudElkAQEAAAAuAEQAD/////8BAf////8AAAAAFWCJCAIAAAAAAAkAAABFdmVudFR5cGUBAQAA" +
           "AC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAAAC4ARAAR/////wEB" +
           "/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkI" +
           "AgAAAAAABAAAAFRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAALAAAAUmVjZWl2" +
           "ZVRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVzc2FnZQEBAAAALgBE" +
           "ABX/////AQH/////AAAAABVgiQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkI" +
           "AgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBAAAALgBEABX/////AQH/////AAAAABdgiQgCAAAA" +
           "AAATAAAAQ29uZGl0aW9uU3ViQ2xhc3NJZAEBAAAALgBEABEBAAAAAQAAAAAAAAABAf////8AAAAAF2CJ" +
           "CAIAAAAAABUAAABDb25kaXRpb25TdWJDbGFzc05hbWUBAQAAAC4ARAAVAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABVgiQgCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAIAAAAQnJhbmNoSWQBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAABgAAAFJldGFp" +
           "bgEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEAAAAvAQAj" +
           "IwAV/////wEBBQAAAAEALCMAAwEAHgAAAE1haW50ZW5hbmNlVGFza1R5cGVfQWNrZWRTdGF0ZQEALCMA" +
           "AwEAIgAAAE1haW50ZW5hbmNlVGFza1R5cGVfQ29uZmlybWVkU3RhdGUBACwjAAMBAB8AAABNYWludGVu" +
           "YW5jZVRhc2tUeXBlX0FjdGl2ZVN0YXRlAQAsIwADAQAjAAAATWFpbnRlbmFuY2VUYXNrVHlwZV9TdXBw" +
           "cmVzc2VkU3RhdGUBACwjAAMBACEAAABNYWludGVuYW5jZVRhc2tUeXBlX1NoZWx2aW5nU3RhdGUBAAAA" +
           "FWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAHAAAAUXVhbGl0" +
           "eQEBAAAALwEAKiMAE/////8BAf////8BAAAAFWCJCAIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAQAA" +
           "AC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAATGFzdFNldmVyaXR5AQEAAAAvAQAqIwAF" +
           "/////wEB/////wEAAAAVYIkIAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAAAALgBEAQAmAf////8B" +
           "Af////8AAAAAFWCJCAIAAAAAAAcAAABDb21tZW50AQEAAAAvAQAqIwAV/////wEB/////wEAAAAVYIkI" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAA" +
           "AAwAAABDbGllbnRVc2VySWQBAQAAAC4ARAAM/////wEB/////wAAAAAEYYIIBAAAAAAABwAAAERpc2Fi" +
           "bGUBAQAAAC8BAEQjAQEBAAAAAQD5CwABAPMKAAAAAARhgggEAAAAAAAGAAAARW5hYmxlAQEAAAAvAQBD" +
           "IwEBAQAAAAEA+QsAAQDzCgAAAAAEYYIIBAAAAAAACgAAAEFkZENvbW1lbnQBAQAAAC8BAEUjAQEBAAAA" +
           "AQD5CwABAA0LAQAAABdgqQgCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIA" +
           "AAAAAAoAAABBY2tlZFN0YXRlAwEAHgAAAE1haW50ZW5hbmNlVGFza1R5cGVfQWNrZWRTdGF0ZQAvAQAj" +
           "IwAV/////wEBAQAAAAEALCMBAwEAIAAAAE1haW50ZW5hbmNlVGFza1R5cGVfRW5hYmxlZFN0YXRlAQAA" +
           "ABVgiQgCAAAAAAACAAAASWQBAQAAAC4ARAAB/////wEB/////wAAAAAEYYIIBAAAAAAACwAAAEFja25v" +
           "d2xlZGdlAQEAAAAvAQCXIwEBAQAAAAEA+QsAAQDwIgEAAAAXYKkIAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQEAAAAuAESWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBp" +
           "ZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV////" +
           "/wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEA" +
           "AAACAAAAAQH/////AAAAABVgiQgCAAAAAAALAAAAQWN0aXZlU3RhdGUDAQAfAAAATWFpbnRlbmFuY2VU" +
           "YXNrVHlwZV9BY3RpdmVTdGF0ZQAvAQAjIwAV/////wEBAQAAAAEALCMBAwEAIAAAAE1haW50ZW5hbmNl" +
           "VGFza1R5cGVfRW5hYmxlZFN0YXRlAQAAABVgiQgCAAAAAAACAAAASWQBAQAAAC4ARAAB/////wEB////" +
           "/wAAAAAVYIkIAgAAAAAACQAAAElucHV0Tm9kZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAA" +
           "AAATAAAAU3VwcHJlc3NlZE9yU2hlbHZlZAEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAL" +
           "AAAATm9ybWFsU3RhdGUBAQAAAC4ARAAR/////wEB/////wAAAAAEYYIKBAAAAAEACQAAAFN0YXJ0VGFz" +
           "awEBlRsALwEBlRuVGwAAAQH/////AAAAADVgiQoCAAAAAQARAAAATGFzdEV4ZWN1dGlvbkRhdGUBAdgY" +
           "AwAAAABwAAAATGFzdEV4ZWN1dGlvbkRhdGUgaXMgdGhlIGRhdGUgd2hlbiB0aGUgVGFzayB3YXMgbGFz" +
           "dCBwZXJmb3JtZWQuIE9wdGlvbmFsLCBhcyB0aGUgVGFzayBtYXkgaGF2ZSBuZXZlciBydW4gYmVmb3Jl" +
           "LgAuAETYGAAAAQAmAf////8DA/////8AAAAANWCJCgIAAAABABAAAABSZWN1cnJlbmNlUGVyaW9kAQHa" +
           "GAMAAAAAiQAAAFJlY3VycmVuY2VQZXJpb2QgaXMgdGhlIHBlcmlvZCBvZiByZXBldGl0aW9uIG9mIHRo" +
           "ZSBUYXNrLCBzcGVjaWZpZWQgaW4gbWlsbGlzZWNvbmRzLiBPcHRpb25hbCwgYXMgbm90IGFsbCBUYXNr" +
           "cyBoYXZlIGEgcmVjdXJyZW5jZSBwZXJpb2QuAC4ARNoYAAABACIB/////wMD/////wAAAAA1YIkKAgAA" +
           "AAEAEQAAAExhc3RPcGVyYXRpbmdUaW1lAQHBFwMAAAAAtgAAAExhc3RPcGVyYXRpbmdUaW1lIGlzIHRo" +
           "ZSB0b3RhbCBhbW91bnQgb2Ygb3BlcmF0aW5nIHRpbWUgKGFzIGRlZmluZWQgaW4gU2VjdGlvbiA5LjMg" +
           "b2YgRU4gMTMzMDYtMjAxNykgaW4gbWlsbGlzZWNvbmRzIChtcykgYnkgdGhlIERldmljZSBhdCB0aGUg" +
           "dGltZSBvZiB0aGUgbGFzdCBleGVjdXRpb24gb2YgdGhlIFRhc2suAC4ARMEXAAABACIB/////wMD////" +
           "/wAAAAA1YIkKAgAAAAEAEQAAAE5leHRPcGVyYXRpbmdUaW1lAQHHFwMAAAAArgAAAE5leHRPcGVyYXRp" +
           "bmdUaW1lIGlzIHRoZSB0b3RhbCBhbW91bnQgb2Ygb3BlcmF0aW5nIHRpbWUgKGFzIGRlZmluZWQgaW4g" +
           "U2VjdGlvbiA5LjMgb2YgRU4gMTMzMDYtMjAxNykgaW4gbWlsbGlzZWNvbmRzIChtcykgYnkgdGhlIERl" +
           "dmljZSBiZWZvcmUgdGhlIG5leHQgZXhlY3V0aW9uIG9mIHRoZSBUYXNrLgAuAETHFwAAAQAiAf////8D" +
           "A/////8AAAAANWCJCgIAAAABABMAAABMYXN0T3BlcmF0aW5nQ3ljbGVzAQHIFwMAAAAAqgAAAExhc3RP" +
           "cGVyYXRpbmdDeWNsZXMgaXMgdGhlIG51bWJlciBvZiBjeWNsZXMgZHVyaW5nIHRoZSBvcGVyYXRpbmcg" +
           "dGltZSAoYXMgZGVmaW5lZCBpbiBTZWN0aW9uIDkuMyBvZiBFTiAxMzMwNi0yMDE3KSByZWNvcmRlZCBh" +
           "dCB0aGUgdGltZSBvZiB0aGUgbGFzdCBleGVjdXRpb24gb2YgdGhlIFRhc2suAC4ARMgXAAAAB/////8D" +
           "A/////8AAAAANWCJCgIAAAABABMAAABOZXh0T3BlcmF0aW5nQ3ljbGVzAQHLFwMAAAAApQAAAE5leHRP" +
           "cGVyYXRpbmdDeWNsZXMgaXMgdGhlIG51bWJlciBvZiBjeWNsZXMgZHVyaW5nIG9wZXJhdGluZyB0aW1l" +
           "IChhcyBkZWZpbmVkIGluIFNlY3Rpb24gOS4zIG9mIEVOIDEzMzA2LTIwMTcpIHRvIGJlIGNvbXBsZXRl" +
           "ZCBiZWZvcmUgdGhlIG5leHQgZXhlY3V0aW9uIG9mIHRoZSBUYXNrLgAuAETLFwAAAAf/////AwP/////" +
           "AAAAAARhggoEAAAAAQAIAAAAU3RvcFRhc2sBAVkbAC8BAVkbWRsAAAEB/////wEAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQHMFwAuAETMFwAAlgIAAAABACoBAVcAAAAZAAAATWFpbnRlbmFuY2VU" +
           "YXNrU3RvcFJlc3VsdAEBuAv/////AAAAAAIpAAAAUHJvdmlkZSB0aGUgcmVzdWx0IG9mIHRoZS5UYXNr" +
           "IGV4ZWN1dGlvbi4BACoBAS0AAAAHAAAAQ29tbWVudAAV/////wAAAAACEwAAAEFkZGl0aW9uYWwgY29t" +
           "bWVudC4BACgBAQAAAAEAAAACAAAAAQH/////AAAAAARhggoEAAAAAQAJAAAAUmVzZXRUYXNrAQFbGwAv" +
           "AQFbG1sbAAABAf////8AAAAANWCJCgIAAAAEABQAAABDb25maWd1cmF0aW9uQ2hhbmdlZAEB0RcDAAAA" +
           "AJgAAABUaGUgQ29uZmlndXJhdGlvbkNoYW5nZWQgcHJvdmlkZXMgaW5mb3JtYXRpb24gaWYgdGhlIGNv" +
           "bmZpZ3VyYXRpb24gb2YgdGhlIGFzc2V0IGlzIHBsYW5uZWQgdG8gYmUgY2hhbmdlZCBvciBoYXMgY2hh" +
           "bmdlZCBkdXJpbmcgdGhlIG1haW50ZW5hbmNlIGFjdGl2aXR5LgAuAETRFwAAAAH/////AwP/////AAAA" +
           "ADVgiQoCAAAABAARAAAARXN0aW1hdGVkRG93bnRpbWUBAdYXAwAAAADvAQAAVGhlIEVzdGltYXRlZERv" +
           "d250aW1lIHByb3ZpZGVzIHRoZSBlc3RpbWF0ZWQgdGltZSB0aGUgZXhlY3V0aW9uIG9mIHRoZSBtYWlu" +
           "dGVuYW5jZSBhY3Rpdml0eSB3aWxsIHRha2UuIEluIGNhc2Ugb2YgcmVwbGFubmluZywgaXQgaXMgYWxs" +
           "b3dlZCB0byBjaGFuZ2UgdGhlIEVzdGltYXRlZERvd250aW1lLiBJZiBkdXJpbmcgdGhlIGV4ZWN1dGlv" +
           "biBvZiB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHkgdGhlIEVzdGltYXRlZERvd250aW1lIGNhbiBiZSBh" +
           "ZGp1c3RlZCAoZS5nLiwgdGhlIGFzc2V0IG5lZWRzIHRvIGJlIHJlcGFpcmVkIGJlY2F1c2UgYW4gaW5z" +
           "cGVjdGlvbiBmb3VuZCBzb21lIGlzc3VlcykgdGhpcyBzaG91bGQgYmUgZG9uZS4gQ2xpZW50cyBjYW4g" +
           "YWNjZXNzIHRoZSBoaXN0b3J5IG9mIEV2ZW50cyB0byByZWNlaXZlIHRoZSBpbmZvcm1hdGlvbiBvbiB0" +
           "aGUgb3JpZ2luYWwgZXN0aW1hdGVzIHdoZW4gdGhlIG1haW50ZW5hbmNlIGFjdGl2aXR5IHN0YXJ0ZWQu" +
           "AC4ARNYXAAABACIB/////wMD/////wAAAAA1YIkKAgAAAAQAEQAAAE1haW50ZW5hbmNlTWV0aG9kAQHa" +
           "FwMAAAAAKwEAAFRoZSBNYWludGVuYW5jZU1ldGhvZCBwcm92aWRlcyBpbmZvcm1hdGlvbiBhYm91dCB0" +
           "aGUgcGxhbm5lZCBvciB1c2VkIG1haW50ZW5hbmNlIG1ldGhvZC4gVGhlIGNvbnRlbnQgbWF5IGNoYW5n" +
           "ZSBkdXJpbmcgdGhlIGRpZmZlcmVudCBNYWludGVuYW5jZVN0YXRlcy4gQnkgYWNjZXNzaW5nIHRoZSBo" +
           "aXN0b3J5IG9mIEV2ZW50cyBhIENsaWVudCBjYW4gZGlzdGluZ3Vpc2ggYmV0d2VlbiB0aGUgcGxhbm5l" +
           "ZCBhbmQgYWN0dWFsIHVzZWQgbWFpbnRlbmFuY2UgbWV0aG9kIGR1cmluZyB0aGUgbWFpbnRlbmFuY2Ug" +
           "YWN0aXZpdHkuAC4ARNoXAAABBLwL/////wMD/////wAAAAAkYIAKAQAAAAQAEAAAAE1haW50ZW5hbmNl" +
           "U3RhdGUBAcoTAwAAAACRAAAAVGhlIE1haW50ZW5hbmNlU3RhdGUgc3RhdGUtbWFjaGluZSBwcm92aWRl" +
           "cyBpbmZvcm1hdGlvbiwgd2hldGhlciBhIG1haW50ZW5hbmNlIGFjdGl2aXR5IGlzIHBsYW5uZWQsIGN1" +
           "cnJlbnRseSBpbiBleGVjdXRpb24sIG9mIGhhcyBiZWVuIGV4ZWN1dGVkLgAvAQT1A8oTAAD/////AQAA" +
           "ABVgiQgCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEAAAAvAQDICgAV/////wEB/////wEAAAAVYIkIAgAA" +
           "AAAAAgAAAElkAQEAAAAuAEQAEf////8BAf////8AAAAANWCJCgIAAAAEABMAAABNYWludGVuYW5jZVN1" +
           "cHBsaWVyAQHbFwMAAAAA8QEAAFRoZSBNYWludGVuYW5jZVN1cHBsaWVyIHByb3ZpZGVzIGluZm9ybWF0" +
           "aW9uIG9uIHRoZSBzdXBwbGllciB0aGF0IGlzIHBsYW5uZWQgdG8gZXhlY3V0ZSwgY3VycmVudGx5IGV4" +
           "ZWN1dGluZyBvciBoYXMgZXhlY3V0ZWQgdGhlIG1haW50ZW5hbmNlIGFjdGl2aXR5LiBUaGUgY29udGVu" +
           "dCBtYXkgY2hhbmdlIGR1cmluZyB0aGUgZGlmZmVyZW50IE1haW50ZW5hbmNlU3RhdGVzLiBCeSBhY2Nl" +
           "c3NpbmcgdGhlIGhpc3Rvcnkgb2YgRXZlbnRzIGEgQ2xpZW50IGNhbiBkaXN0aW5ndWlzaCBiZXR3ZWVu" +
           "IHRoZSBwbGFubmVkIGFuZCBhY3R1YWwgc3VwcGxpZXIgdGhhdCBleGVjdXRlZCB0aGUgbWFpbnRlbmFu" +
           "Y2UgYWN0aXZpdHkuIFRoZSB2YWx1ZSBjb250YWlucyBhbHdheXMgYSBodW1hbi1yZWFkYWJsZSBuYW1l" +
           "IG9mIHRoZSBzdXBwbGllciBhbmQgb3B0aW9uYWxseSByZWZlcmVuY2VzIGEgTm9kZSByZXByZXNlbnRp" +
           "bmcgdGhlIHN1cHBsaWVyIGluIHRoZSBBZGRyZXNzU3BhY2UuAC4ARNsXAAABBLsL/////wMD/////wAA" +
           "AAA3YIkKAgAAAAQAFAAAAFBhcnRzT2ZBc3NldFJlcGxhY2VkAQHcFwMAAAAAkwIAAFRoZSBQYXJ0c09m" +
           "QXNzZXRSZXBsYWNlZCBwcm92aWRlcyBpbmZvcm1hdGlvbiBvbiB0aGUgcGFydHMgb2YgdGhlIGFzc2V0" +
           "cyB0aGF0IGFyZSBwbGFubmVkIHRvIGJlIHJlcGxhY2VkIGR1cmluZyB0aGUgbWFpbnRlbmFuY2UgYWN0" +
           "aXZpdHksIGN1cnJlbnRseSBpbiByZXBsYWNlbWVudCBvciBoYXZlIGJlZW4gcmVwbGFjZWQsIGRlcGVu" +
           "ZGluZyBvbiB0aGUgZGlmZmVyZW50IE1haW50ZW5hbmNlU3RhdGVzLiBUaGUgY29udGVudCBtYXkgY2hh" +
           "bmdlIGR1cmluZyB0aGUgZGlmZmVyZW50IE1haW50ZW5hbmNlU3RhdGVzLiBCeSBhY2Nlc3NpbmcgdGhl" +
           "IGhpc3Rvcnkgb2YgRXZlbnRzIGEgQ2xpZW50IGNhbiBkaXN0aW5ndWlzaCBiZXR3ZWVuIHRoZSBwbGFu" +
           "bmVkIGFuZCBhY3R1YWwgcGFydHMgb2YgdGhlIGFzc2V0cyByZXBsYWNlZCBkdXJpbmcgdGhlIG1haW50" +
           "ZW5hbmNlIGFjdGl2aXR5LiBUaGUgdmFsdWUgY29udGFpbnMgYWx3YXlzIGFuIGFycmF5IG9mIGEgaHVt" +
           "YW4tcmVhZGFibGUgbmFtZSBvZiB0aGUgcXVhbGlmaWNhdGlvbiBvZiB0aGUgcGFydHMgb2YgdGhlIGFz" +
           "c2V0IHRvIGJlIHJlcGxhY2VkIGFuZCBvcHRpb25hbGx5IHJlZmVyZW5jZXMgYSBOb2RlIHJlcHJlc2Vu" +
           "dGluZyBlYWNoIHBhcnQgb2YgdGhlIGFzc2V0IGluIHRoZSBBZGRyZXNzU3BhY2UuAC4ARNwXAAABBLsL" +
           "AQAAAAEAAAAAAAAAAwP/////AAAAADdgiQoCAAAABAAUAAAAUGFydHNPZkFzc2V0U2VydmljZWQBAd8X" +
           "AwAAAACMAgAAVGhlIFBhcnRzT2ZBc3NldFNlcnZpY2VkIHByb3ZpZGVzIGluZm9ybWF0aW9uIG9uIHRo" +
           "ZSBwYXJ0cyBvZiB0aGUgYXNzZXRzIHRoYXQgYXJlIHBsYW5uZWQgdG8gYmUgc2VydmljZWQgZHVyaW5n" +
           "IHRoZSBtYWludGVuYW5jZSBhY3Rpdml0eSwgY3VycmVudGx5IHNlcnZpY2VkIG9yIGhhdmUgYmVlbiBz" +
           "ZXJ2aWNlZCwgZGVwZW5kaW5nIG9uIHRoZSBkaWZmZXJlbnQgTWFpbnRlbmFuY2VTdGF0ZXMuIFRoZSBj" +
           "b250ZW50IG1heSBjaGFuZ2UgZHVyaW5nIHRoZSBkaWZmZXJlbnQgTWFpbnRlbmFuY2VTdGF0ZXMuIEJ5" +
           "IGFjY2Vzc2luZyB0aGUgaGlzdG9yeSBvZiBFdmVudHMgYSBDbGllbnQgY2FuIGRpc3Rpbmd1aXNoIGJl" +
           "dHdlZW4gdGhlIHBsYW5uZWQgYW5kIGFjdHVhbCBwYXJ0cyBvZiB0aGUgYXNzZXRzIHNlcnZpY2VkIGR1" +
           "cmluZyB0aGUgbWFpbnRlbmFuY2UgYWN0aXZpdHkuIFRoZSB2YWx1ZSBjb250YWlucyBhbHdheXMgYW4g" +
           "YXJyYXkgb2YgYSBodW1hbi1yZWFkYWJsZSBuYW1lIG9mIHRoZSBxdWFsaWZpY2F0aW9uIG9mIHRoZSBw" +
           "YXJ0cyBvZiB0aGUgYXNzZXQgdG8gYmUgc2VydmljZWQgYW5kIG9wdGlvbmFsbHkgcmVmZXJlbmNlcyBh" +
           "IE5vZGUgcmVwcmVzZW50aW5nIHRoZSBwYXJ0IG9mIHRoZSBhc3NldCBpbiB0aGUgQWRkcmVzc1NwYWNl" +
           "LgAuAETfFwAAAQS7CwEAAAABAAAAAAAAAAMD/////wAAAAA1YIkKAgAAAAQACwAAAFBsYW5uZWREYXRl" +
           "AQHnFwMAAAAAngEAAFRoZSBQbGFubmVkRGF0ZSBwcm92aWRlcyB0aGUgZGF0ZSBmb3Igd2hpY2ggdGhl" +
           "IG1haW50ZW5hbmNlIGFjdGl2aXR5IGhhcyBiZWVuIHNjaGVkdWxlZC4uIEluIGNhc2Ugb2YgcmVwbGFu" +
           "bmluZywgaXQgaXMgYWxsb3dlZCB0byBjaGFuZ2UgdGhlIFBsYW5uZWREYXRlLiBIb3dldmVyLCBpdCBp" +
           "cyBub3QgdGhlIGludGVudGlvbiB0aGF0IHRoZSBQbGFubmVkRGF0ZSBpcyBtb2RpZmllZCBiZWNhdXNl" +
           "IHRoZSBtYWludGVuYW5jZSBhY3Rpdml0eSBzdGFydHMgdG8gZ2V0IGV4ZWN1dGVkLiBJZiB0aGUgUGxh" +
           "bm5lZERhdGUgZGVwZW5kcyBmb3IgZXhhbXBsZSBvbiB0aGUgb3BlcmF0aW9uIGhvdXJzIG9mIHRoZSBh" +
           "c3NldCwgaXQgbWlnaHQgZ2V0IGFkYXB0ZWQgZGVwZW5kaW5nIG9uIHRoZSBwYXNzZWQgb3BlcmF0aW9u" +
           "IGhvdXJzLgAuAETnFwAAAQAmAf////8DA/////8AAAAANWCJCgIAAAAEABgAAABRdWFsaWZpY2F0aW9u" +
           "T2ZQZXJzb25uZWwBAegXAwAAAABOAgAAVGhlIFF1YWxpZmljYXRpb25PZlBlcnNvbm5lbCBwcm92aWRl" +
           "cyBpbmZvcm1hdGlvbiBvbiB0aGUgcXVhbGlmaWNhdGlvbiBvZiB0aGUgcGVyc29ubmVsIHRoYXQgaXMg" +
           "cGxhbm5lZCB0byBleGVjdXRlLCBjdXJyZW50bHkgZXhlY3V0aW5nIG9yIGhhcyBleGVjdXRlZCB0aGUg" +
           "bWFpbnRlbmFuY2UgYWN0aXZpdHkuIFRoZSBjb250ZW50IG1heSBjaGFuZ2UgZHVyaW5nIHRoZSBkaWZm" +
           "ZXJlbnQgTWFpbnRlbmFuY2VTdGF0ZXMuIEJ5IGFjY2Vzc2luZyB0aGUgaGlzdG9yeSBvZiBFdmVudHMg" +
           "YSBDbGllbnQgY2FuIGRpc3Rpbmd1aXNoIGJldHdlZW4gdGhlIHBsYW5uZWQgYW5kIGFjdHVhbCBxdWFs" +
           "aWZpY2F0aW9uIG9mIHRoZSBwZXJzb25uZWwgdGhhdCBleGVjdXRlZCB0aGUgbWFpbnRlbmFuY2UgYWN0" +
           "aXZpdHkuIFRoZSB2YWx1ZSBjb250YWlucyBhbHdheXMgYSBodW1hbi1yZWFkYWJsZSBuYW1lIG9mIHRo" +
           "ZSBxdWFsaWZpY2F0aW9uIG9mIHRoZSBwZXJzb25uZWwgYW5kIG9wdGlvbmFsbHkgcmVmZXJlbmNlcyBh" +
           "IE5vZGUgcmVwcmVzZW50aW5nIHRoZSBxdWFsaWZpY2F0aW9uIG9mIHRoZSBwZXJzb25uZWwgaW4gdGhl" +
           "IEFkZHJlc3NTcGFjZS4ALgBE6BcAAAEEuwv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState StartTask
        {
            get
            {
                return m_startTaskMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startTaskMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startTaskMethod = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> LastExecutionDate
        {
            get
            {
                return m_lastExecutionDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastExecutionDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastExecutionDate = value;
            }
        }

        /// <remarks />
        public PropertyState<double> RecurrencePeriod
        {
            get
            {
                return m_recurrencePeriod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_recurrencePeriod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_recurrencePeriod = value;
            }
        }

        /// <remarks />
        public PropertyState<double> LastOperatingTime
        {
            get
            {
                return m_lastOperatingTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastOperatingTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastOperatingTime = value;
            }
        }

        /// <remarks />
        public PropertyState<double> NextOperatingTime
        {
            get
            {
                return m_nextOperatingTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nextOperatingTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nextOperatingTime = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> LastOperatingCycles
        {
            get
            {
                return m_lastOperatingCycles;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastOperatingCycles, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastOperatingCycles = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> NextOperatingCycles
        {
            get
            {
                return m_nextOperatingCycles;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nextOperatingCycles, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nextOperatingCycles = value;
            }
        }

        /// <remarks />
        public StopTaskMethodState StopTask
        {
            get
            {
                return m_stopTaskMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopTaskMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopTaskMethod = value;
            }
        }

        /// <remarks />
        public MethodState ResetTask
        {
            get
            {
                return m_resetTaskMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetTaskMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetTaskMethod = value;
            }
        }

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
            if (m_startTaskMethod != null)
            {
                children.Add(m_startTaskMethod);
            }

            if (m_lastExecutionDate != null)
            {
                children.Add(m_lastExecutionDate);
            }

            if (m_recurrencePeriod != null)
            {
                children.Add(m_recurrencePeriod);
            }

            if (m_lastOperatingTime != null)
            {
                children.Add(m_lastOperatingTime);
            }

            if (m_nextOperatingTime != null)
            {
                children.Add(m_nextOperatingTime);
            }

            if (m_lastOperatingCycles != null)
            {
                children.Add(m_lastOperatingCycles);
            }

            if (m_nextOperatingCycles != null)
            {
                children.Add(m_nextOperatingCycles);
            }

            if (m_stopTaskMethod != null)
            {
                children.Add(m_stopTaskMethod);
            }

            if (m_resetTaskMethod != null)
            {
                children.Add(m_resetTaskMethod);
            }

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
                case Opc.Ua.LADS.BrowseNames.StartTask:
                {
                    if (createOrReplace)
                    {
                        if (StartTask == null)
                        {
                            if (replacement == null)
                            {
                                StartTask = new MethodState(this);
                            }
                            else
                            {
                                StartTask = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartTask;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.LastExecutionDate:
                {
                    if (createOrReplace)
                    {
                        if (LastExecutionDate == null)
                        {
                            if (replacement == null)
                            {
                                LastExecutionDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                LastExecutionDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastExecutionDate;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.RecurrencePeriod:
                {
                    if (createOrReplace)
                    {
                        if (RecurrencePeriod == null)
                        {
                            if (replacement == null)
                            {
                                RecurrencePeriod = new PropertyState<double>(this);
                            }
                            else
                            {
                                RecurrencePeriod = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = RecurrencePeriod;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.LastOperatingTime:
                {
                    if (createOrReplace)
                    {
                        if (LastOperatingTime == null)
                        {
                            if (replacement == null)
                            {
                                LastOperatingTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                LastOperatingTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = LastOperatingTime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.NextOperatingTime:
                {
                    if (createOrReplace)
                    {
                        if (NextOperatingTime == null)
                        {
                            if (replacement == null)
                            {
                                NextOperatingTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                NextOperatingTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = NextOperatingTime;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.LastOperatingCycles:
                {
                    if (createOrReplace)
                    {
                        if (LastOperatingCycles == null)
                        {
                            if (replacement == null)
                            {
                                LastOperatingCycles = new PropertyState<uint>(this);
                            }
                            else
                            {
                                LastOperatingCycles = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = LastOperatingCycles;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.NextOperatingCycles:
                {
                    if (createOrReplace)
                    {
                        if (NextOperatingCycles == null)
                        {
                            if (replacement == null)
                            {
                                NextOperatingCycles = new PropertyState<uint>(this);
                            }
                            else
                            {
                                NextOperatingCycles = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = NextOperatingCycles;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.StopTask:
                {
                    if (createOrReplace)
                    {
                        if (StopTask == null)
                        {
                            if (replacement == null)
                            {
                                StopTask = new StopTaskMethodState(this);
                            }
                            else
                            {
                                StopTask = (StopTaskMethodState)replacement;
                            }
                        }
                    }

                    instance = StopTask;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ResetTask:
                {
                    if (createOrReplace)
                    {
                        if (ResetTask == null)
                        {
                            if (replacement == null)
                            {
                                ResetTask = new MethodState(this);
                            }
                            else
                            {
                                ResetTask = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ResetTask;
                    break;
                }

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
        private MethodState m_startTaskMethod;
        private PropertyState<DateTime> m_lastExecutionDate;
        private PropertyState<double> m_recurrencePeriod;
        private PropertyState<double> m_lastOperatingTime;
        private PropertyState<double> m_nextOperatingTime;
        private PropertyState<uint> m_lastOperatingCycles;
        private PropertyState<uint> m_nextOperatingCycles;
        private StopTaskMethodState m_stopTaskMethod;
        private MethodState m_resetTaskMethod;
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

    #region LADSDeviceTypeState Class
    #if (!OPCUA_EXCLUDE_LADSDeviceTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSDeviceTypeState : DeviceTypeState
    {
        #region Constructors
        /// <remarks />
        public LADSDeviceTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.LADSDeviceType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Components != null)
            {
                Components.Initialize(context, Components_InitializationString);
            }

            if (Maintenance != null)
            {
                Maintenance.Initialize(context, Maintenance_InitializationString);
            }

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (OperationalLocation != null)
            {
                OperationalLocation.Initialize(context, OperationalLocation_InitializationString);
            }

            if (HierarchicalLocation != null)
            {
                HierarchicalLocation.Initialize(context, HierarchicalLocation_InitializationString);
            }

            if (MachineryBuildingBlocks != null)
            {
                MachineryBuildingBlocks.Initialize(context, MachineryBuildingBlocks_InitializationString);
            }
        }

        #region Initialization String
        private const string Components_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAMACgAAAENvbXBvbmVu" +
           "dHMBAfcTAwAAAABlAAAAQ29tcG9uZW50cyBpcyB1c2VkIGZvciBzdHJ1Y3R1cmluZyBvYmplY3RzIG9m" +
           "IHR5cGUgTEFEU0NvbXBvbmVudHNUeXBlIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4BAMRE" +
           "AQEBBPcTAAABAAAAACkAAQBVCAAAAAA=";

        private const string Maintenance_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEACwAAAE1haW50ZW5h" +
           "bmNlAQHkEwMAAAAAkAAAAFRoZSBNYWludGVuYW5jZVNldFR5cGUgaXMgYSBzZXQgY29udGFpbmluZyBh" +
           "bGwgbWFpbnRlbmFuY2UgdGFza3MgZm9yIGEgRGV2aWNlIG9yIENvbXBvbmVudCBhY2NvcmRpbmcgdG8g" +
           "dGhlIHJlY29tbWVuZGF0aW9ucyBpbiBPUEMgVUEgMTAwMDAtMTEwLgAvAQEDBOQTAAABAAAAACkAAQBV" +
           "CAEAAAA1YKkKAgAAAAAACwAAAE5vZGVWZXJzaW9uAQHhFwMAAAAApQAAAE5vZGVWZXJzaW9uIGFuZCB0" +
           "aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZlbnRUeXBlIGFyZSBtZWNoYW5pc21zIHRvIG5vdGlmeSBjbGll" +
           "bnRzIHRoYXQgdGhlIGNvbnRlbnQgb2YgdGhlIHNldCBoYXMgY2hhbmdlZCBhbmQgc2hhbGwgYmUgdXNl" +
           "ZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAwMC0zLgAuAEThFwAADAMAAABOYU4ADP////8DA/////8AAAAA";

        private const string DeviceClass_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIACwAAAERldmljZUNs" +
           "YXNzAQHDFwMAAAAAzAAAAERldmljZUNsYXNzIGluZGljYXRlcyBpbiB3aGljaCBkb21haW4gb3IgZm9y" +
           "IHdoYXQgcHVycG9zZSBhIGNlcnRhaW4gaXRlbSBmb3Igd2hpY2ggdGhlIEludGVyZmFjZSBpcyBhcHBs" +
           "aWVkIGlzIHVzZWQuIEV4YW1wbGVzIGFyZSDigJxQcm9ncmFtbWFibGVDb250cm9sbGVy4oCdLCDigJxS" +
           "ZW1vdGVJT+KAnSwgYW5kIOKAnFRlbXBlcmF0dXJlU2Vuc29y4oCdLgAuAETDFwAAAAz/////AQH/////" +
           "AAAAAA==";

        private const string DeviceHealth_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADAAAAERldmljZUhl" +
           "YWx0aAEBxhcDAAAAAJgAAABEZXZpY2VIZWFsdGggaW5kaWNhdGVzIHRoZSBzdGF0dXMgYXMgZGVmaW5l" +
           "ZCBieSBOQU1VUiBSZWNvbW1lbmRhdGlvbiBORTEwNy4gQ2xpZW50cyBjYW4gcmVhZCBvciBtb25pdG9y" +
           "IHRoaXMgVmFyaWFibGUgdG8gZGV0ZXJtaW5lIHRoZSBkZXZpY2UgY29uZGl0aW9uLgAvAD/GFwAAAQJk" +
           "GP////8BAf////8AAAAA";

        private const string ManufacturerUri_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADwAAAE1hbnVmYWN0" +
           "dXJlclVyaQEBzhcDAAAAAMYAAABNYW51ZmFjdHVyZXJVcmkgcHJvdmlkZXMgYSB1bmlxdWUgaWRlbnRp" +
           "ZmllciBmb3IgdGhpcyBjb21wYW55LiBUaGlzIGlkZW50aWZpZXIgc2hvdWxkIGJlIGEgZnVsbHkgcXVh" +
           "bGlmaWVkIGRvbWFpbiBuYW1lOyBob3dldmVyLCBpdCBtYXkgYmUgYSBHVUlEIG9yIHNpbWlsYXIgY29u" +
           "c3RydWN0IHRoYXQgZW5zdXJlcyBnbG9iYWwgdW5pcXVlbmVzcy4ALgBEzhcAAAAM/////wEB/////wAA" +
           "AAA=";

        private const string ProductCode_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIACwAAAFByb2R1Y3RD" +
           "b2RlAQHPFwMAAAAAqwAAAFByb2R1Y3RDb2RlIHByb3ZpZGVzIGEgdW5pcXVlIGNvbWJpbmF0aW9uIG9m" +
           "IG51bWJlcnMgYW5kIGxldHRlcnMgdXNlZCB0byBpZGVudGlmeSB0aGUgcHJvZHVjdC4gSXQgbWF5IGJl" +
           "IHRoZSBvcmRlciBpbmZvcm1hdGlvbiBkaXNwbGF5ZWQgb24gdHlwZSBzaGllbGRzIG9yIGluIEVSUCBz" +
           "eXN0ZW1zLgAuAETPFwAAAAz/////AQH/////AAAAAA==";

        private const string OperationalLocation_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAEwAAAE9wZXJhdGlv" +
           "bmFsTG9jYXRpb24BAYwXAwAAAABUAQAAT3BlcmF0aW9uYWxMb2NhdGlvbiBwcm92aWRlcyB0aGUgb3Bl" +
           "cmF0aW9uYWwgbG9jYXRpb24gb2YgdGhlIERldmljZSBvciBDb21wb25lbnQuIFRoZSBzdHJ1Y3R1cmUg" +
           "d2l0aGluIHRoZSBzdHJpbmcgbWF5IGV4cG9zZSBzZXZlcmFsIGxldmVscy4gSG93IHRoaXMgaXMgZXhw" +
           "b3NlZCwgd2hpY2ggZGVsaW1pdGVycyBhcmUgdXNlZCwgZXRjLiBpcyB2ZW5kb3Itc3BlY2lmaWMuIEV4" +
           "YW1wbGVzIG9mIHN1Y2ggc3RyaW5ncyBhcmUg4oCcV2FyZWhvdXNlMS9TaGVldDPigJ0gb3Ig4oCcU3Rh" +
           "aW5sZXNzU3RlZWxUb3RlM+KAnSAoc2VlIE9QQyBVQSBPUEMgMTAwMDAtMTEwIGZvciBtb3JlIGRldGFp" +
           "bHMpLgAuAESMFwAAAAz/////AwP/////AAAAAA==";

        private const string HierarchicalLocation_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAFAAAAEhpZXJhcmNo" +
           "aWNhbExvY2F0aW9uAQGNFwMAAAAAWgEAAEhpZXJhcmNoaWNhbExvY2F0aW9uIHByb3ZpZGVzIHRoZSBo" +
           "aWVyYXJjaGljYWwgbG9jYXRpb24gb2YgdGhlIExBRFNEZXZpY2UuVGhlIHN0cnVjdHVyZSB3aXRoaW4g" +
           "dGhlIHN0cmluZyBtYXkgZXhwb3NlIHNldmVyYWwgbGV2ZWxzLiBIb3cgdGhpcyBpcyBleHBvc2VkLCB3" +
           "aGljaCBkZWxpbWl0ZXJzIGFyZSB1c2VkLCBldGMuIGlzIHZlbmRvci1zcGVjaWZpYy4gRXhhbXBsZXMg" +
           "b2Ygc3VjaCBzdHJpbmdzIGFyZSDigJxGYWN0b3J5QS9CdWlsZGluZ0MvRmxvb3Ix4oCdIG9yIOKAnEFy" +
           "ZWExLVByb2Nlc3NDZWxsMTctVW5pdDTigJ0gKHNlZSBPUEMgVUEgT1BDIDEwMDAwLTExMCBmb3IgbW9y" +
           "ZSBkZXRhaWxzKS4ALgBEjRcAAAAM/////wMD/////wAAAAA=";

        private const string MachineryBuildingBlocks_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAMAFwAAAE1hY2hpbmVy" +
           "eUJ1aWxkaW5nQmxvY2tzAQHHEwMAAAAArQAAAFRoZSBNYWNoaW5lcnlCdWlsZGluZ0Jsb2NrcyBmb2xk" +
           "ZXIgY29udGFpbnMgYWxsIG1hY2hpbmVyeSBidWlsZGluZyBibG9ja3MsIGVzcGVjaWFsbHkgdGhlIE1h" +
           "Y2hpbmVyeUl0ZW1TdGF0ZSwgTWFjaGluZXJ5T3BlcmF0aW9uTW9kZSwgT3BlcmF0aW9uQ291bnRlciBh" +
           "bmQgTGlmZXRpbWUgQ291bnRlcnMuACMAPccTAAD/////BAAAACRggAoBAAAAAwASAAAATWFjaGluZXJ5" +
           "SXRlbVN0YXRlAQHhEwMAAAAAdAAAAE1hY2hpbmVyeUl0ZW1TdGF0ZSBpbmRpY2F0ZXMgdGhlIGN1cnJl" +
           "bnQgc3RhdGUgb2YgdGhlIGRldmljZSBpbiBjb25mb3JtYW5jZSB3aXRoIHRoZSBNYWNoaW5lcnkgQmFz" +
           "aWNzIHNwZWNpZmljYXRpb24uAQDERAED6gPhEwAA/////wEAAAAVYIkIAgAAAAAADAAAAEN1cnJlbnRT" +
           "dGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEABH/////" +
           "AQH/////AAAAACRggAoBAAAAAwAWAAAATWFjaGluZXJ5T3BlcmF0aW9uTW9kZQEB4hMDAAAAAJYAAABT" +
           "dGF0ZSBtYWNoaW5lIHJlcHJlc2VudGluZyB0aGUgb3BlcmF0aW9uIG1vZGUgb2YgYSBsYWJvcmF0b3J5" +
           "IGRldmljZS4gT3B0aW9uYWwgbWV0aG9kcyBhbGxvdyBmb3IgaW5pdGlhdGluZyBjaGFuZ2VzIG9mIHRo" +
           "ZSBvcGVyYXRpb24gbW9kZSBmcm9tIHJlbW90ZS4BAMREAQEaBOITAAD/////AQAAABVgiQgCAAAAAAAM" +
           "AAAAQ3VycmVudFN0YXRlAQEAAAAvAQDICgAV/////wEB/////wEAAAAVYIkIAgAAAAAAAgAAAElkAQEA" +
           "AAAuAEQAEf////8BAf////8AAAAAJGCACgEAAAADABAAAABMaWZldGltZUNvdW50ZXJzAQHjEwMAAAAA" +
           "VgAAAExpZmV0aW1lIENvdW50ZXIgcHJvdmlkZXMgaW5mb3JtYXRpb24gYWJvdXQgdGhlIHBhc3QgYW5k" +
           "IGVzdGltYXRlZCByZW1haW5pbmcgbGlmZXRpbWUuAQDERAED9wPjEwAA/////wAAAAAkYIAKAQAAAAIA" +
           "EQAAAE9wZXJhdGlvbkNvdW50ZXJzAQHlEwMAAAAAeAAAAE9wZXJhdGlvbkNvdW50ZXJzIGZvciBtb25p" +
           "dG9yaW5nIHRoZSBjb25kaXRpb24gb2YgdGhlIGRldmljZSBvciBjb21wb25lbnQgaW4gY29uZm9ybWFu" +
           "Y2Ugd2l0aCB0aGUgRGV2aWNlcyBzcGVjaWZpY2F0aW9uLgEAxEQBA/ED5RMAAAEAAAABAMNEAAEC4AEA" +
           "AAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAFgAAAExBRFNEZXZp" +
           "Y2VUeXBlSW5zdGFuY2UBAeoDAQHqA+oDAAD/////FwAAACRggAoBAAAAAgAOAAAASWRlbnRpZmljYXRp" +
           "b24BAegTAwAAAABFAAAASWRlbnRpZmljYXRpb24gcHJvdmlkZXMgcHJvcGVydGllcyB0byBpZGVudGlm" +
           "eSBhIGRldmljZSBvciBjb21wb25lbnQuAQDERAED9APoEwAAAgAAAAEAw0QAAQPzAwEAw0QAAQPyAwMA" +
           "AAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBchcDAAAAAEoAAABBIGh1bWFuLXJlYWRhYmxlLCBs" +
           "b2NhbGl6ZWQgbmFtZSBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBNYWNoaW5lcnlJdGVtLgAuAERy" +
           "FwAAABX/////AQH/////AAAAADVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQF/FwMAAAAA" +
           "UQAAAEEgZ2xvYmFsbHkgdW5pcXVlIHJlc291cmNlIGlkZW50aWZpZXIgcHJvdmlkZWQgYnkgdGhlIG1h" +
           "bnVmYWN0dXJlciBvZiB0aGUgbWFjaGluZQAuAER/FwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQFzFwMAAAAAFwEAAEEgc3RyaW5nIGNvbnRhaW5pbmcgYSB1bmlxdWUgcHJv" +
           "ZHVjdGlvbiBudW1iZXIgb2YgdGhlIG1hbnVmYWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4gVGhl" +
           "IGdsb2JhbCB1bmlxdWVuZXNzIG9mIHRoZSBzZXJpYWwgbnVtYmVyIGlzIG9ubHkgZ2l2ZW4gaW4gdGhl" +
           "IGNvbnRleHQgb2YgdGhlIG1hbnVmYWN0dXJlciwgYW5kIHBvdGVudGlhbGx5IHRoZSBtb2RlbC4gVGhl" +
           "IHZhbHVlIHNoYWxsIG5vdCBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZlLWN5Y2xlIG9mIHRoZSBNYWNoaW5l" +
           "cnlJdGVtLgAuAERzFwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQF5" +
           "FwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAu" +
           "AER5FwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAPAAAATWFudWZhY3R1cmVyVXJpAQHOFwMAAAAA" +
           "xgAAAE1hbnVmYWN0dXJlclVyaSBwcm92aWRlcyBhIHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGlzIGNv" +
           "bXBhbnkuIFRoaXMgaWRlbnRpZmllciBzaG91bGQgYmUgYSBmdWxseSBxdWFsaWZpZWQgZG9tYWluIG5h" +
           "bWU7IGhvd2V2ZXIsIGl0IG1heSBiZSBhIEdVSUQgb3Igc2ltaWxhciBjb25zdHJ1Y3QgdGhhdCBlbnN1" +
           "cmVzIGdsb2JhbCB1bmlxdWVuZXNzLgAuAETOFwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAFAAAA" +
           "TW9kZWwBAXoXAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARHoXAAAAFf////8BAf//" +
           "//8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQHNFwMAAAAALAAAAFJldmlzaW9uIGxl" +
           "dmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARM0XAAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQGvFwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARK8XAAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBrhcDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVs" +
           "IG9mIHRoZSBkZXZpY2UALgBErhcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIACwAAAFByb2R1Y3RD" +
           "b2RlAQHPFwMAAAAAqwAAAFByb2R1Y3RDb2RlIHByb3ZpZGVzIGEgdW5pcXVlIGNvbWJpbmF0aW9uIG9m" +
           "IG51bWJlcnMgYW5kIGxldHRlcnMgdXNlZCB0byBpZGVudGlmeSB0aGUgcHJvZHVjdC4gSXQgbWF5IGJl" +
           "IHRoZSBvcmRlciBpbmZvcm1hdGlvbiBkaXNwbGF5ZWQgb24gdHlwZSBzaGllbGRzIG9yIGluIEVSUCBz" +
           "eXN0ZW1zLgAuAETPFwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQGj" +
           "FwMAAAAAfQAAAERldmljZU1hbnVhbCBhbGxvd3Mgc3BlY2lmeWluZyBhbiBhZGRyZXNzIG9mIHRoZSB1" +
           "c2VyIG1hbnVhbC4gSXQgbWF5IGJlIGEgcGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJM" +
           "IChXZWIgYWRkcmVzcykuAC4ARKMXAAAADP////8BAf////8AAAAANWCJCgIAAAACAAsAAABEZXZpY2VD" +
           "bGFzcwEBwxcDAAAAAMwAAABEZXZpY2VDbGFzcyBpbmRpY2F0ZXMgaW4gd2hpY2ggZG9tYWluIG9yIGZv" +
           "ciB3aGF0IHB1cnBvc2UgYSBjZXJ0YWluIGl0ZW0gZm9yIHdoaWNoIHRoZSBJbnRlcmZhY2UgaXMgYXBw" +
           "bGllZCBpcyB1c2VkLiBFeGFtcGxlcyBhcmUg4oCcUHJvZ3JhbW1hYmxlQ29udHJvbGxlcuKAnSwg4oCc" +
           "UmVtb3RlSU/igJ0sIGFuZCDigJxUZW1wZXJhdHVyZVNlbnNvcuKAnS4ALgBEwxcAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBsBcDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQg" +
           "dW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5j" +
           "ZQAuAESwFwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQHQ" +
           "FwMAAAAAzgAAAFByb2R1Y3RJbnN0YW5jZVVyaSBpcyBhIGdsb2JhbGx5IHVuaXF1ZSByZXNvdXJjZSBp" +
           "ZGVudGlmaWVyIHByb3ZpZGVkIGJ5IHRoZSBtYW51ZmFjdHVyZXIuIFRoaXMgaXMgb2Z0ZW4gc3RhbXBl" +
           "ZCBvbiB0aGUgb3V0c2lkZSBvZiBhIHBoeXNpY2FsIGNvbXBvbmVudCBhbmQgbWF5IGJlIHVzZWQgZm9y" +
           "IHRyYWNlYWJpbGl0eSBhbmQgd2FycmFudHkgcHVycG9zZXMuAC4ARNAXAAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAXgXAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291" +
           "bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0" +
           "aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARHgXAAAABv////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAcAAABBc3NldElkAQG0FwMAAAAAmAAAAEFzc2V0SWQgaXMgYSB1c2VyIHdyaXRhYmxlIGFscGhhbnVt" +
           "ZXJpYyBjaGFyYWN0ZXIgc2VxdWVuY2UgdW5pcXVlbHkgaWRlbnRpZnlpbmcgYSBjb21wb25lbnQuIFRo" +
           "ZSBJRCBpcyBwcm92aWRlZCBieSB0aGUgaW50ZWdyYXRvciBvciB1c2VyIG9mIHRoZSBkZXZpY2UuAC4A" +
           "RLQXAAAADP////8DA/////8AAAAANWCJCgIAAAACAA0AAABDb21wb25lbnROYW1lAQG1FwMAAAAAWgAA" +
           "AENvbXBvbmVudE5hbWUgaXMgYSB1c2VyIHdyaXRhYmxlIG5hbWUgcHJvdmlkZWQgYnkgdGhlIGludGVn" +
           "cmF0b3Igb3IgdXNlciBvZiB0aGUgY29tcG9uZW50LgAuAES1FwAAABX/////AwP/////AAAAADVgiQoC" +
           "AAAAAgAMAAAARGV2aWNlSGVhbHRoAQHGFwMAAAAAmAAAAERldmljZUhlYWx0aCBpbmRpY2F0ZXMgdGhl" +
           "IHN0YXR1cyBhcyBkZWZpbmVkIGJ5IE5BTVVSIFJlY29tbWVuZGF0aW9uIE5FMTA3LiBDbGllbnRzIGNh" +
           "biByZWFkIG9yIG1vbml0b3IgdGhpcyBWYXJpYWJsZSB0byBkZXRlcm1pbmUgdGhlIGRldmljZSBjb25k" +
           "aXRpb24uAC8AP8YXAAABAmQY/////wEB/////wAAAAAkYIAKAQAAAAMACgAAAENvbXBvbmVudHMBAfcT" +
           "AwAAAABlAAAAQ29tcG9uZW50cyBpcyB1c2VkIGZvciBzdHJ1Y3R1cmluZyBvYmplY3RzIG9mIHR5cGUg" +
           "TEFEU0NvbXBvbmVudHNUeXBlIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4BAMREAQEBBPcT" +
           "AAABAAAAACkAAQBVCAAAAAAkYIAKAQAAAAEAEQAAAEZ1bmN0aW9uYWxVbml0U2V0AQGKEwMAAAAARQAA" +
           "AFRoZSBGdW5jdGlvbmFsVW5pdFNldFR5cGUgcHJvdmlkZXMgYSBzZXQgb2YgYSBGdW5jdGlvbmFsVW5p" +
           "dCBvYmplY3RzLgAvAQH/A4oTAAD/////AQAAADVgqQoCAAAAAAALAAAATm9kZVZlcnNpb24BAdcXAwAA" +
           "AAClAAAATm9kZVZlcnNpb24gYW5kIHRoZSBHZW5lcmFsTW9kZWxDaGFuZ2VFdmVudFR5cGUgYXJlIG1l" +
           "Y2hhbmlzbXMgdG8gbm90aWZ5IGNsaWVudHMgdGhhdCB0aGUgY29udGVudCBvZiB0aGUgc2V0IGhhcyBj" +
           "aGFuZ2VkIGFuZCBzaGFsbCBiZSB1c2VkIGFzIGRlZmluZWQgaW4gT1BDIDEwMDAwLTMuAC4ARNcXAAAM" +
           "AwAAAE5hTgAM/////wMD/////wAAAAAkYIAKAQAAAAEACwAAAERldmljZVN0YXRlAQFHFAMAAAAAlwAA" +
           "AERldmljZVN0YXRlIHJlcHJlc2VudHMgdGhlIERldmljZeKAmXMgc3RhdGUgb2Ygb3BlcmF0aW9uLiBJ" +
           "dCBpcyBpbnNwaXJlZCBieSB0aGUgQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmVUeXBlIGZyb20gdGhl" +
           "IEFuYWx5emVyIERldmljZXMgU3BlY2lmaWNhdGlvbi4ALwEBDwRHFAAA/////wQAAAAVYIkKAgAAAAAA" +
           "DAAAAEN1cnJlbnRTdGF0ZQEByBkALwEAyArIGQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAA" +
           "SWQBAckZAC4ARMkZAAAAEf////8BAf////8AAAAABGGCCgQAAAABAAsAAABHb3RvT3BlcmF0ZQEB1BsA" +
           "LwEBbRvUGwAAAQH/////AAAAAARhggoEAAAAAQAMAAAAR290b1NodXRkb3duAQHVGwAvAQF3G9UbAAAB" +
           "Af////8AAAAABGGCCgQAAAABAAkAAABHb3RvU2xlZXABAdYbAC8BAXgb1hsAAAEB/////wAAAAAkYIAK" +
           "AQAAAAEACwAAAE1haW50ZW5hbmNlAQHkEwMAAAAAkAAAAFRoZSBNYWludGVuYW5jZVNldFR5cGUgaXMg" +
           "YSBzZXQgY29udGFpbmluZyBhbGwgbWFpbnRlbmFuY2UgdGFza3MgZm9yIGEgRGV2aWNlIG9yIENvbXBv" +
           "bmVudCBhY2NvcmRpbmcgdG8gdGhlIHJlY29tbWVuZGF0aW9ucyBpbiBPUEMgVUEgMTAwMDAtMTEwLgAv" +
           "AQEDBOQTAAABAAAAACkAAQBVCAEAAAA1YKkKAgAAAAAACwAAAE5vZGVWZXJzaW9uAQHhFwMAAAAApQAA" +
           "AE5vZGVWZXJzaW9uIGFuZCB0aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZlbnRUeXBlIGFyZSBtZWNoYW5p" +
           "c21zIHRvIG5vdGlmeSBjbGllbnRzIHRoYXQgdGhlIGNvbnRlbnQgb2YgdGhlIHNldCBoYXMgY2hhbmdl" +
           "ZCBhbmQgc2hhbGwgYmUgdXNlZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAwMC0zLgAuAEThFwAADAMAAABO" +
           "YU4ADP////8DA/////8AAAAANWCJCgIAAAAEABMAAABPcGVyYXRpb25hbExvY2F0aW9uAQGMFwMAAAAA" +
           "VAEAAE9wZXJhdGlvbmFsTG9jYXRpb24gcHJvdmlkZXMgdGhlIG9wZXJhdGlvbmFsIGxvY2F0aW9uIG9m" +
           "IHRoZSBEZXZpY2Ugb3IgQ29tcG9uZW50LiBUaGUgc3RydWN0dXJlIHdpdGhpbiB0aGUgc3RyaW5nIG1h" +
           "eSBleHBvc2Ugc2V2ZXJhbCBsZXZlbHMuIEhvdyB0aGlzIGlzIGV4cG9zZWQsIHdoaWNoIGRlbGltaXRl" +
           "cnMgYXJlIHVzZWQsIGV0Yy4gaXMgdmVuZG9yLXNwZWNpZmljLiBFeGFtcGxlcyBvZiBzdWNoIHN0cmlu" +
           "Z3MgYXJlIOKAnFdhcmVob3VzZTEvU2hlZXQz4oCdIG9yIOKAnFN0YWlubGVzc1N0ZWVsVG90ZTPigJ0g" +
           "KHNlZSBPUEMgVUEgT1BDIDEwMDAwLTExMCBmb3IgbW9yZSBkZXRhaWxzKS4ALgBEjBcAAAAM/////wMD" +
           "/////wAAAAA1YIkKAgAAAAQAFAAAAEhpZXJhcmNoaWNhbExvY2F0aW9uAQGNFwMAAAAAWgEAAEhpZXJh" +
           "cmNoaWNhbExvY2F0aW9uIHByb3ZpZGVzIHRoZSBoaWVyYXJjaGljYWwgbG9jYXRpb24gb2YgdGhlIExB" +
           "RFNEZXZpY2UuVGhlIHN0cnVjdHVyZSB3aXRoaW4gdGhlIHN0cmluZyBtYXkgZXhwb3NlIHNldmVyYWwg" +
           "bGV2ZWxzLiBIb3cgdGhpcyBpcyBleHBvc2VkLCB3aGljaCBkZWxpbWl0ZXJzIGFyZSB1c2VkLCBldGMu" +
           "IGlzIHZlbmRvci1zcGVjaWZpYy4gRXhhbXBsZXMgb2Ygc3VjaCBzdHJpbmdzIGFyZSDigJxGYWN0b3J5" +
           "QS9CdWlsZGluZ0MvRmxvb3Ix4oCdIG9yIOKAnEFyZWExLVByb2Nlc3NDZWxsMTctVW5pdDTigJ0gKHNl" +
           "ZSBPUEMgVUEgT1BDIDEwMDAwLTExMCBmb3IgbW9yZSBkZXRhaWxzKS4ALgBEjRcAAAAM/////wMD////" +
           "/wAAAAAkYIAKAQAAAAMAFwAAAE1hY2hpbmVyeUJ1aWxkaW5nQmxvY2tzAQHHEwMAAAAArQAAAFRoZSBN" +
           "YWNoaW5lcnlCdWlsZGluZ0Jsb2NrcyBmb2xkZXIgY29udGFpbnMgYWxsIG1hY2hpbmVyeSBidWlsZGlu" +
           "ZyBibG9ja3MsIGVzcGVjaWFsbHkgdGhlIE1hY2hpbmVyeUl0ZW1TdGF0ZSwgTWFjaGluZXJ5T3BlcmF0" +
           "aW9uTW9kZSwgT3BlcmF0aW9uQ291bnRlciBhbmQgTGlmZXRpbWUgQ291bnRlcnMuACMAPccTAAD/////" +
           "BAAAACRggAoBAAAAAwASAAAATWFjaGluZXJ5SXRlbVN0YXRlAQHhEwMAAAAAdAAAAE1hY2hpbmVyeUl0" +
           "ZW1TdGF0ZSBpbmRpY2F0ZXMgdGhlIGN1cnJlbnQgc3RhdGUgb2YgdGhlIGRldmljZSBpbiBjb25mb3Jt" +
           "YW5jZSB3aXRoIHRoZSBNYWNoaW5lcnkgQmFzaWNzIHNwZWNpZmljYXRpb24uAQDERAED6gPhEwAA////" +
           "/wEAAAAVYIkIAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJ" +
           "CAIAAAAAAAIAAABJZAEBAAAALgBEABH/////AQH/////AAAAACRggAoBAAAAAwAWAAAATWFjaGluZXJ5" +
           "T3BlcmF0aW9uTW9kZQEB4hMDAAAAAJYAAABTdGF0ZSBtYWNoaW5lIHJlcHJlc2VudGluZyB0aGUgb3Bl" +
           "cmF0aW9uIG1vZGUgb2YgYSBsYWJvcmF0b3J5IGRldmljZS4gT3B0aW9uYWwgbWV0aG9kcyBhbGxvdyBm" +
           "b3IgaW5pdGlhdGluZyBjaGFuZ2VzIG9mIHRoZSBvcGVyYXRpb24gbW9kZSBmcm9tIHJlbW90ZS4BAMRE" +
           "AQEaBOITAAD/////AQAAABVgiQgCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEAAAAvAQDICgAV/////wEB" +
           "/////wEAAAAVYIkIAgAAAAAAAgAAAElkAQEAAAAuAEQAEf////8BAf////8AAAAAJGCACgEAAAADABAA" +
           "AABMaWZldGltZUNvdW50ZXJzAQHjEwMAAAAAVgAAAExpZmV0aW1lIENvdW50ZXIgcHJvdmlkZXMgaW5m" +
           "b3JtYXRpb24gYWJvdXQgdGhlIHBhc3QgYW5kIGVzdGltYXRlZCByZW1haW5pbmcgbGlmZXRpbWUuAQDE" +
           "RAED9wPjEwAA/////wAAAAAkYIAKAQAAAAIAEQAAAE9wZXJhdGlvbkNvdW50ZXJzAQHlEwMAAAAAeAAA" +
           "AE9wZXJhdGlvbkNvdW50ZXJzIGZvciBtb25pdG9yaW5nIHRoZSBjb25kaXRpb24gb2YgdGhlIGRldmlj" +
           "ZSBvciBjb21wb25lbnQgaW4gY29uZm9ybWFuY2Ugd2l0aCB0aGUgRGV2aWNlcyBzcGVjaWZpY2F0aW9u" +
           "LgEAxEQBA/ED5RMAAAEAAAABAMNEAAEC4AEAAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LADSComponentsTypeState Components
        {
            get
            {
                return m_components;
            }

            set
            {
                if (!Object.ReferenceEquals(m_components, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_components = value;
            }
        }

        /// <remarks />
        public FunctionalUnitSetTypeState FunctionalUnitSet
        {
            get
            {
                return m_functionalUnitSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionalUnitSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionalUnitSet = value;
            }
        }

        /// <remarks />
        public new MachineIdentificationTypeState Identification
        {
            get { return (MachineIdentificationTypeState)base.Identification; }
            set { base.Identification = value; }
        }

        /// <remarks />
        public LADSDeviceStateMachineTypeState DeviceState
        {
            get
            {
                return m_deviceState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceState = value;
            }
        }

        /// <remarks />
        public MaintenanceSetTypeState Maintenance
        {
            get
            {
                return m_maintenance;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenance, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenance = value;
            }
        }

        /// <remarks />
        public PropertyState<string> OperationalLocation
        {
            get
            {
                return m_operationalLocation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationalLocation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationalLocation = value;
            }
        }

        /// <remarks />
        public PropertyState<string> HierarchicalLocation
        {
            get
            {
                return m_hierarchicalLocation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hierarchicalLocation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hierarchicalLocation = value;
            }
        }

        /// <remarks />
        public FolderState MachineryBuildingBlocks
        {
            get
            {
                return m_machineryBuildingBlocks;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machineryBuildingBlocks, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machineryBuildingBlocks = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_components != null)
            {
                children.Add(m_components);
            }

            if (m_functionalUnitSet != null)
            {
                children.Add(m_functionalUnitSet);
            }

            if (m_deviceState != null)
            {
                children.Add(m_deviceState);
            }

            if (m_maintenance != null)
            {
                children.Add(m_maintenance);
            }

            if (m_operationalLocation != null)
            {
                children.Add(m_operationalLocation);
            }

            if (m_hierarchicalLocation != null)
            {
                children.Add(m_hierarchicalLocation);
            }

            if (m_machineryBuildingBlocks != null)
            {
                children.Add(m_machineryBuildingBlocks);
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
                case Opc.Ua.Machinery.BrowseNames.Components:
                {
                    if (createOrReplace)
                    {
                        if (Components == null)
                        {
                            if (replacement == null)
                            {
                                Components = new LADSComponentsTypeState(this);
                            }
                            else
                            {
                                Components = (LADSComponentsTypeState)replacement;
                            }
                        }
                    }

                    instance = Components;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.FunctionalUnitSet:
                {
                    if (createOrReplace)
                    {
                        if (FunctionalUnitSet == null)
                        {
                            if (replacement == null)
                            {
                                FunctionalUnitSet = new FunctionalUnitSetTypeState(this);
                            }
                            else
                            {
                                FunctionalUnitSet = (FunctionalUnitSetTypeState)replacement;
                            }
                        }
                    }

                    instance = FunctionalUnitSet;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Identification:
                {
                    if (createOrReplace)
                    {
                        if (Identification == null)
                        {
                            if (replacement == null)
                            {
                                Identification = new MachineIdentificationTypeState(this);
                            }
                            else
                            {
                                Identification = (MachineIdentificationTypeState)replacement;
                            }
                        }
                    }

                    instance = Identification;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.DeviceState:
                {
                    if (createOrReplace)
                    {
                        if (DeviceState == null)
                        {
                            if (replacement == null)
                            {
                                DeviceState = new LADSDeviceStateMachineTypeState(this);
                            }
                            else
                            {
                                DeviceState = (LADSDeviceStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = DeviceState;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Maintenance:
                {
                    if (createOrReplace)
                    {
                        if (Maintenance == null)
                        {
                            if (replacement == null)
                            {
                                Maintenance = new MaintenanceSetTypeState(this);
                            }
                            else
                            {
                                Maintenance = (MaintenanceSetTypeState)replacement;
                            }
                        }
                    }

                    instance = Maintenance;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.OperationalLocation:
                {
                    if (createOrReplace)
                    {
                        if (OperationalLocation == null)
                        {
                            if (replacement == null)
                            {
                                OperationalLocation = new PropertyState<string>(this);
                            }
                            else
                            {
                                OperationalLocation = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = OperationalLocation;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.HierarchicalLocation:
                {
                    if (createOrReplace)
                    {
                        if (HierarchicalLocation == null)
                        {
                            if (replacement == null)
                            {
                                HierarchicalLocation = new PropertyState<string>(this);
                            }
                            else
                            {
                                HierarchicalLocation = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HierarchicalLocation;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.MachineryBuildingBlocks:
                {
                    if (createOrReplace)
                    {
                        if (MachineryBuildingBlocks == null)
                        {
                            if (replacement == null)
                            {
                                MachineryBuildingBlocks = new FolderState(this);
                            }
                            else
                            {
                                MachineryBuildingBlocks = (FolderState)replacement;
                            }
                        }
                    }

                    instance = MachineryBuildingBlocks;
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
        private LADSComponentsTypeState m_components;
        private FunctionalUnitSetTypeState m_functionalUnitSet;
        private LADSDeviceStateMachineTypeState m_deviceState;
        private MaintenanceSetTypeState m_maintenance;
        private PropertyState<string> m_operationalLocation;
        private PropertyState<string> m_hierarchicalLocation;
        private FolderState m_machineryBuildingBlocks;
        #endregion
    }
    #endif
    #endregion

    #region LADSComponentTypeState Class
    #if (!OPCUA_EXCLUDE_LADSComponentTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSComponentTypeState : ComponentTypeState
    {
        #region Constructors
        /// <remarks />
        public LADSComponentTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.LADSComponentType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }

            if (DeviceHealthAlarms != null)
            {
                DeviceHealthAlarms.Initialize(context, DeviceHealthAlarms_InitializationString);
            }

            if (Maintenance != null)
            {
                Maintenance.Initialize(context, Maintenance_InitializationString);
            }

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

            if (DeviceManual != null)
            {
                DeviceManual.Initialize(context, DeviceManual_InitializationString);
            }

            if (DeviceRevision != null)
            {
                DeviceRevision.Initialize(context, DeviceRevision_InitializationString);
            }

            if (HardwareRevision != null)
            {
                HardwareRevision.Initialize(context, HardwareRevision_InitializationString);
            }

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (ProductInstanceUri != null)
            {
                ProductInstanceUri.Initialize(context, ProductInstanceUri_InitializationString);
            }

            if (RevisionCounter != null)
            {
                RevisionCounter.Initialize(context, RevisionCounter_InitializationString);
            }

            if (SoftwareRevision != null)
            {
                SoftwareRevision.Initialize(context, SoftwareRevision_InitializationString);
            }

            if (Components != null)
            {
                Components.Initialize(context, Components_InitializationString);
            }

            if (OperationalLocation != null)
            {
                OperationalLocation.Initialize(context, OperationalLocation_InitializationString);
            }

            if (HierarchicalLocation != null)
            {
                HierarchicalLocation.Initialize(context, HierarchicalLocation_InitializationString);
            }

            if (MachineryBuildingBlocks != null)
            {
                MachineryBuildingBlocks.Initialize(context, MachineryBuildingBlocks_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceHealth_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADAAAAERldmljZUhl" +
           "YWx0aAEBUBkDAAAAAF8AAABEZXZpY2VIZWFsdGggaW5kaWNhdGVzIHRoZSBoZWFsdGggc3RhdHVzIG9m" +
           "IGEgZGV2aWNlIGFzIGRlZmluZWQgYnkgTkFNVVIgUmVjb21tZW5kYXRpb24gTkUgMTA3LgAvAD9QGQAA" +
           "AQJkGP////8DA/////8AAAAA";

        private const string DeviceHealthAlarms_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAIAEgAAAERldmljZUhl" +
           "YWx0aEFsYXJtcwEBihQDAAAAAEgAAABEZXZpY2VIZWFsdGhBbGFybXMgZ3JvdXBzIGFsbCBpbnN0YW5j" +
           "ZXMgb2YgZGV2aWNlIGhlYWx0aCByZWxhdGVkIGFsYXJtcy4ALwA9ihQAAP////8AAAAA";

        private const string Maintenance_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEACwAAAE1haW50ZW5h" +
           "bmNlAQHyEwMAAAAAkAAAAFRoZSBNYWludGVuYW5jZVNldFR5cGUgaXMgYSBzZXQgY29udGFpbmluZyBh" +
           "bGwgbWFpbnRlbmFuY2UgdGFza3MgZm9yIGEgRGV2aWNlIG9yIENvbXBvbmVudCBhY2NvcmRpbmcgdG8g" +
           "dGhlIHJlY29tbWVuZGF0aW9ucyBpbiBPUEMgVUEgMTAwMDAtMTEwLgAvAQEDBPITAAABAAAAACkAAQBV" +
           "CAEAAAA1YKkKAgAAAAAACwAAAE5vZGVWZXJzaW9uAQEtGAMAAAAApQAAAE5vZGVWZXJzaW9uIGFuZCB0" +
           "aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZlbnRUeXBlIGFyZSBtZWNoYW5pc21zIHRvIG5vdGlmeSBjbGll" +
           "bnRzIHRoYXQgdGhlIGNvbnRlbnQgb2YgdGhlIHNldCBoYXMgY2hhbmdlZCBhbmQgc2hhbGwgYmUgdXNl" +
           "ZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAwMC0zLgAuAEQtGAAADAMAAABOYU4ADP////8DA/////8AAAAA";

        private const string AssetId_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIABwAAAEFzc2V0SWQB" +
           "AQUYAwAAAACYAAAAQXNzZXRJZCBpcyBhIHVzZXIgd3JpdGFibGUgYWxwaGFudW1lcmljIGNoYXJhY3Rl" +
           "ciBzZXF1ZW5jZSB1bmlxdWVseSBpZGVudGlmeWluZyBhIGNvbXBvbmVudC4gVGhlIElEIGlzIHByb3Zp" +
           "ZGVkIGJ5IHRoZSBpbnRlZ3JhdG9yIG9yIHVzZXIgb2YgdGhlIGRldmljZS4ALgBEBRgAAAAM/////wMD" +
           "/////wAAAAA=";

        private const string ComponentName_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADQAAAENvbXBvbmVu" +
           "dE5hbWUBAQYYAwAAAABaAAAAQ29tcG9uZW50TmFtZSBpcyBhIHVzZXIgd3JpdGFibGUgbmFtZSBwcm92" +
           "aWRlZCBieSB0aGUgaW50ZWdyYXRvciBvciB1c2VyIG9mIHRoZSBjb21wb25lbnQuAC4ARAYYAAAAFf//" +
           "//8DA/////8AAAAA";

        private const string DeviceClass_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIACwAAAERldmljZUNs" +
           "YXNzAQEHGAMAAAAAzAAAAERldmljZUNsYXNzIGluZGljYXRlcyBpbiB3aGljaCBkb21haW4gb3IgZm9y" +
           "IHdoYXQgcHVycG9zZSBhIGNlcnRhaW4gaXRlbSBmb3Igd2hpY2ggdGhlIEludGVyZmFjZSBpcyBhcHBs" +
           "aWVkIGlzIHVzZWQuIEV4YW1wbGVzIGFyZSDigJxQcm9ncmFtbWFibGVDb250cm9sbGVy4oCdLCDigJxS" +
           "ZW1vdGVJT+KAnSwgYW5kIOKAnFRlbXBlcmF0dXJlU2Vuc29y4oCdLgAuAEQHGAAAAAz/////AQH/////" +
           "AAAAAA==";

        private const string DeviceManual_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADAAAAERldmljZU1h" +
           "bnVhbAEBCBgDAAAAAH0AAABEZXZpY2VNYW51YWwgYWxsb3dzIHNwZWNpZnlpbmcgYW4gYWRkcmVzcyBv" +
           "ZiB0aGUgdXNlciBtYW51YWwuIEl0IG1heSBiZSBhIHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBv" +
           "ciBhIFVSTCAoV2ViIGFkZHJlc3MpLgAuAEQIGAAAAAz/////AQH/////AAAAAA==";

        private const string DeviceRevision_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADgAAAERldmljZVJl" +
           "dmlzaW9uAQEJGAMAAAAAuQAAAERldmljZVJldmlzaW9uIHByb3ZpZGVzIHRoZSBvdmVyYWxsIHJldmlz" +
           "aW9uIGxldmVsIG9mIGEgaGFyZHdhcmUgY29tcG9uZW50IG9yIHRoZSBEZXZpY2UuIEFzIGFuIGV4YW1w" +
           "bGUsIHRoaXMgUHJvcGVydHkgY2FuIGJlIHVzZWQgaW4gRVJQIHN5c3RlbXMgdG9nZXRoZXIgd2l0aCB0" +
           "aGUgUHJvZHVjdENvZGUgUHJvcGVydHkuAC4ARAkYAAAADP////8BAf////8AAAAA";

        private const string HardwareRevision_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIAEAAAAEhhcmR3YXJl" +
           "UmV2aXNpb24BAQoYAwAAAAA9AAAASGFyZHdhcmVSZXZpc2lvbiBwcm92aWRlcyB0aGUgcmV2aXNpb24g" +
           "bGV2ZWwgb2YgdGhlIGhhcmR3YXJlLgAuAEQKGAAAAAz/////AQH/////AAAAAA==";

        private const string ManufacturerUri_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAIADwAAAE1hbnVmYWN0" +
           "dXJlclVyaQEBGhgALgBEGhgAAAAM/////wEB/////wAAAAA=";

        private const string Model_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAIABQAAAE1vZGVsAQEb" +
           "GAAuAEQbGAAAABX/////AQH/////AAAAAA==";

        private const string ProductCode_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAIACwAAAFByb2R1Y3RD" +
           "b2RlAQEcGAAuAEQcGAAAAAz/////AQH/////AAAAAA==";

        private const string ProductInstanceUri_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAIAEgAAAFByb2R1Y3RJ" +
           "bnN0YW5jZVVyaQEBHRgALgBEHRgAAAAM/////wEB/////wAAAAA=";

        private const string RevisionCounter_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAIADwAAAFJldmlzaW9u" +
           "Q291bnRlcgEBHhgALgBEHhgAAAAG/////wEB/////wAAAAA=";

        private const string SoftwareRevision_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8VYIkKAgAAAAIAEAAAAFNvZnR3YXJl" +
           "UmV2aXNpb24BASAYAC4ARCAYAAAADP////8BAf////8AAAAA";

        private const string Components_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAMACgAAAENvbXBvbmVu" +
           "dHMBAdETAwAAAABlAAAAQ29tcG9uZW50cyBpcyB1c2VkIGZvciBzdHJ1Y3R1cmluZyBvYmplY3RzIG9m" +
           "IHR5cGUgTEFEU0NvbXBvbmVudHNUeXBlIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4BAMRE" +
           "AQEBBNETAAABAAAAACkAAQBVCAAAAAA=";

        private const string OperationalLocation_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAEwAAAE9wZXJhdGlv" +
           "bmFsTG9jYXRpb24BAboXAwAAAABUAQAAT3BlcmF0aW9uYWxMb2NhdGlvbiBwcm92aWRlcyB0aGUgb3Bl" +
           "cmF0aW9uYWwgbG9jYXRpb24gb2YgdGhlIERldmljZSBvciBDb21wb25lbnQuIFRoZSBzdHJ1Y3R1cmUg" +
           "d2l0aGluIHRoZSBzdHJpbmcgbWF5IGV4cG9zZSBzZXZlcmFsIGxldmVscy4gSG93IHRoaXMgaXMgZXhw" +
           "b3NlZCwgd2hpY2ggZGVsaW1pdGVycyBhcmUgdXNlZCwgZXRjLiBpcyB2ZW5kb3Itc3BlY2lmaWMuIEV4" +
           "YW1wbGVzIG9mIHN1Y2ggc3RyaW5ncyBhcmUg4oCcV2FyZWhvdXNlMS9TaGVldDPigJ0gb3Ig4oCcU3Rh" +
           "aW5sZXNzU3RlZWxUb3RlM+KAnSAoc2VlIE9QQyBVQSBPUEMgMTAwMDAtMTEwIGZvciBtb3JlIGRldGFp" +
           "bHMpLgAuAES6FwAAAAz/////AwP/////AAAAAA==";

        private const string HierarchicalLocation_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAQAFAAAAEhpZXJhcmNo" +
           "aWNhbExvY2F0aW9uAQHAFwMAAAAAWwEAAEhpZXJhcmNoaWNhbExvY2F0aW9uIHByb3ZpZGVzIHRoZSBo" +
           "aWVyYXJjaGljYWwgbG9jYXRpb24gb2YgdGhlIExBRFMgRGV2aWNlLlRoZSBzdHJ1Y3R1cmUgaW5zaWRl" +
           "IHRoZSBzdHJpbmcgbWF5IGV4cG9zZSBzZXZlcmFsIGxldmVscy4gSG93IHRoaXMgaXMgZXhwb3NlZCwg" +
           "d2hpY2ggZGVsaW1pdGVycyBhcmUgdXNlZCwgZXRjLiBpcyB2ZW5kb3Itc3BlY2lmaWMuIEV4YW1wbGVz" +
           "IG9mIHN1Y2ggc3RyaW5ncyBhcmUg4oCcRmFjdG9yeUEvQnVpbGRpbmdDL0Zsb29yMeKAnSBvciDigJxB" +
           "cmVhMS1Qcm9jZXNzQ2VsbDE3LVVuaXQ04oCdIChzZWUgT1BDIFVBIE9QQyAxMDAwMC0xMTAgZm9yIG1v" +
           "cmUgRGV0YWlscykuAC4ARMAXAAAADP////8DA/////8AAAAA";

        private const string MachineryBuildingBlocks_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAMAFwAAAE1hY2hpbmVy" +
           "eUJ1aWxkaW5nQmxvY2tzAQHgEwMAAAAArQAAAFRoZSBNYWNoaW5lcnlCdWlsZGluZ0Jsb2NrcyBmb2xk" +
           "ZXIgY29udGFpbnMgYWxsIG1hY2hpbmVyeSBidWlsZGluZyBibG9ja3MsIGVzcGVjaWFsbHkgdGhlIE1h" +
           "Y2hpbmVyeUl0ZW1TdGF0ZSwgTWFjaGluZXJ5T3BlcmF0aW9uTW9kZSwgT3BlcmF0aW9uQ291bnRlciBh" +
           "bmQgTGlmZXRpbWUgQ291bnRlcnMuACMAPeATAAD/////AgAAACRggAoBAAAAAwAQAAAATGlmZXRpbWVD" +
           "b3VudGVycwEB5hMDAAAAAFYAAABMaWZldGltZSBDb3VudGVyIHByb3ZpZGVzIGluZm9ybWF0aW9uIGFi" +
           "b3V0IHRoZSBwYXN0IGFuZCBlc3RpbWF0ZWQgcmVtYWluaW5nIGxpZmV0aW1lLgEAxEQBA/cD5hMAAP//" +
           "//8AAAAABGCACgEAAAACABEAAABPcGVyYXRpb25Db3VudGVycwEB6RMBAMREAQPxA+kTAAABAAAAAQDD" +
           "RAABAuABAAAAAA==";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGQAAAExBRFNDb21w" +
           "b25lbnRUeXBlSW5zdGFuY2UBAQAEAQEABAAEAAABAAAAAQDDRAABAss6FgAAACRggAoBAAAAAgAOAAAA" +
           "SWRlbnRpZmljYXRpb24BAecTAwAAAABFAAAASWRlbnRpZmljYXRpb24gcHJvdmlkZXMgcHJvcGVydGll" +
           "cyB0byBpZGVudGlmeSBhIGRldmljZSBvciBjb21wb25lbnQuAQDERAED7QPnEwAA/////wIAAAA1YIkK" +
           "AgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBchcDAAAAAEoAAABBIGh1bWFuLXJlYWRhYmxlLCBsb2NhbGl6" +
           "ZWQgbmFtZSBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBNYWNoaW5lcnlJdGVtLgAuAERyFwAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQFzFwMAAAAAFwEAAEEgc3RyaW5n" +
           "IGNvbnRhaW5pbmcgYSB1bmlxdWUgcHJvZHVjdGlvbiBudW1iZXIgb2YgdGhlIG1hbnVmYWN0dXJlciBv" +
           "ZiB0aGUgTWFjaGluZXJ5SXRlbS4gVGhlIGdsb2JhbCB1bmlxdWVuZXNzIG9mIHRoZSBzZXJpYWwgbnVt" +
           "YmVyIGlzIG9ubHkgZ2l2ZW4gaW4gdGhlIGNvbnRleHQgb2YgdGhlIG1hbnVmYWN0dXJlciwgYW5kIHBv" +
           "dGVudGlhbGx5IHRoZSBtb2RlbC4gVGhlIHZhbHVlIHNoYWxsIG5vdCBjaGFuZ2UgZHVyaW5nIHRoZSBs" +
           "aWZlLWN5Y2xlIG9mIHRoZSBNYWNoaW5lcnlJdGVtLgAuAERzFwAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAgAMAAAATWFudWZhY3R1cmVyAQEZGAAuAEQZGAAAABX/////AQH/////AAAAABVgiQoCAAAAAgAP" +
           "AAAATWFudWZhY3R1cmVyVXJpAQEaGAAuAEQaGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAgAFAAAA" +
           "TW9kZWwBARsYAC4ARBsYAAAAFf////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlz" +
           "aW9uAQEKGAMAAAAAPQAAAEhhcmR3YXJlUmV2aXNpb24gcHJvdmlkZXMgdGhlIHJldmlzaW9uIGxldmVs" +
           "IG9mIHRoZSBoYXJkd2FyZS4ALgBEChgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAIAEAAAAFNvZnR3" +
           "YXJlUmV2aXNpb24BASAYAC4ARCAYAAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VS" +
           "ZXZpc2lvbgEBCRgDAAAAALkAAABEZXZpY2VSZXZpc2lvbiBwcm92aWRlcyB0aGUgb3ZlcmFsbCByZXZp" +
           "c2lvbiBsZXZlbCBvZiBhIGhhcmR3YXJlIGNvbXBvbmVudCBvciB0aGUgRGV2aWNlLiBBcyBhbiBleGFt" +
           "cGxlLCB0aGlzIFByb3BlcnR5IGNhbiBiZSB1c2VkIGluIEVSUCBzeXN0ZW1zIHRvZ2V0aGVyIHdpdGgg" +
           "dGhlIFByb2R1Y3RDb2RlIFByb3BlcnR5LgAuAEQJGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAgAL" +
           "AAAAUHJvZHVjdENvZGUBARwYAC4ARBwYAAAADP////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZp" +
           "Y2VNYW51YWwBAQgYAwAAAAB9AAAARGV2aWNlTWFudWFsIGFsbG93cyBzcGVjaWZ5aW5nIGFuIGFkZHJl" +
           "c3Mgb2YgdGhlIHVzZXIgbWFudWFsLiBJdCBtYXkgYmUgYSBwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0" +
           "ZW0gb3IgYSBVUkwgKFdlYiBhZGRyZXNzKS4ALgBECBgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "CwAAAERldmljZUNsYXNzAQEHGAMAAAAAzAAAAERldmljZUNsYXNzIGluZGljYXRlcyBpbiB3aGljaCBk" +
           "b21haW4gb3IgZm9yIHdoYXQgcHVycG9zZSBhIGNlcnRhaW4gaXRlbSBmb3Igd2hpY2ggdGhlIEludGVy" +
           "ZmFjZSBpcyBhcHBsaWVkIGlzIHVzZWQuIEV4YW1wbGVzIGFyZSDigJxQcm9ncmFtbWFibGVDb250cm9s" +
           "bGVy4oCdLCDigJxSZW1vdGVJT+KAnSwgYW5kIOKAnFRlbXBlcmF0dXJlU2Vuc29y4oCdLgAuAEQHGAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEfGAAuAEQfGAAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQEdGAAuAEQdGAAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQEeGAAuAEQeGAAAAAb/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAHAAAAQXNzZXRJZAEBBRgDAAAAAJgAAABBc3NldElkIGlzIGEgdXNlciB3" +
           "cml0YWJsZSBhbHBoYW51bWVyaWMgY2hhcmFjdGVyIHNlcXVlbmNlIHVuaXF1ZWx5IGlkZW50aWZ5aW5n" +
           "IGEgY29tcG9uZW50LiBUaGUgSUQgaXMgcHJvdmlkZWQgYnkgdGhlIGludGVncmF0b3Igb3IgdXNlciBv" +
           "ZiB0aGUgZGV2aWNlLgAuAEQFGAAAAAz/////AwP/////AAAAADVgiQoCAAAAAgANAAAAQ29tcG9uZW50" +
           "TmFtZQEBBhgDAAAAAFoAAABDb21wb25lbnROYW1lIGlzIGEgdXNlciB3cml0YWJsZSBuYW1lIHByb3Zp" +
           "ZGVkIGJ5IHRoZSBpbnRlZ3JhdG9yIG9yIHVzZXIgb2YgdGhlIGNvbXBvbmVudC4ALgBEBhgAAAAV////" +
           "/wMD/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZUhlYWx0aAEBUBkDAAAAAF8AAABEZXZpY2VIZWFs" +
           "dGggaW5kaWNhdGVzIHRoZSBoZWFsdGggc3RhdHVzIG9mIGEgZGV2aWNlIGFzIGRlZmluZWQgYnkgTkFN" +
           "VVIgUmVjb21tZW5kYXRpb24gTkUgMTA3LgAvAD9QGQAAAQJkGP////8DA/////8AAAAAJGCACgEAAAAC" +
           "ABIAAABEZXZpY2VIZWFsdGhBbGFybXMBAYoUAwAAAABIAAAARGV2aWNlSGVhbHRoQWxhcm1zIGdyb3Vw" +
           "cyBhbGwgaW5zdGFuY2VzIG9mIGRldmljZSBoZWFsdGggcmVsYXRlZCBhbGFybXMuAC8APYoUAAD/////" +
           "AAAAACRggAoBAAAAAQALAAAATWFpbnRlbmFuY2UBAfITAwAAAACQAAAAVGhlIE1haW50ZW5hbmNlU2V0" +
           "VHlwZSBpcyBhIHNldCBjb250YWluaW5nIGFsbCBtYWludGVuYW5jZSB0YXNrcyBmb3IgYSBEZXZpY2Ug" +
           "b3IgQ29tcG9uZW50IGFjY29yZGluZyB0byB0aGUgcmVjb21tZW5kYXRpb25zIGluIE9QQyBVQSAxMDAw" +
           "MC0xMTAuAC8BAQME8hMAAAEAAAAAKQABAFUIAQAAADVgqQoCAAAAAAALAAAATm9kZVZlcnNpb24BAS0Y" +
           "AwAAAAClAAAATm9kZVZlcnNpb24gYW5kIHRoZSBHZW5lcmFsTW9kZWxDaGFuZ2VFdmVudFR5cGUgYXJl" +
           "IG1lY2hhbmlzbXMgdG8gbm90aWZ5IGNsaWVudHMgdGhhdCB0aGUgY29udGVudCBvZiB0aGUgc2V0IGhh" +
           "cyBjaGFuZ2VkIGFuZCBzaGFsbCBiZSB1c2VkIGFzIGRlZmluZWQgaW4gT1BDIDEwMDAwLTMuAC4ARC0Y" +
           "AAAMAwAAAE5hTgAM/////wMD/////wAAAAAkYIAKAQAAAAMACgAAAENvbXBvbmVudHMBAdETAwAAAABl" +
           "AAAAQ29tcG9uZW50cyBpcyB1c2VkIGZvciBzdHJ1Y3R1cmluZyBvYmplY3RzIG9mIHR5cGUgTEFEU0Nv" +
           "bXBvbmVudHNUeXBlIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4BAMREAQEBBNETAAABAAAA" +
           "ACkAAQBVCAAAAAA1YIkKAgAAAAQAEwAAAE9wZXJhdGlvbmFsTG9jYXRpb24BAboXAwAAAABUAQAAT3Bl" +
           "cmF0aW9uYWxMb2NhdGlvbiBwcm92aWRlcyB0aGUgb3BlcmF0aW9uYWwgbG9jYXRpb24gb2YgdGhlIERl" +
           "dmljZSBvciBDb21wb25lbnQuIFRoZSBzdHJ1Y3R1cmUgd2l0aGluIHRoZSBzdHJpbmcgbWF5IGV4cG9z" +
           "ZSBzZXZlcmFsIGxldmVscy4gSG93IHRoaXMgaXMgZXhwb3NlZCwgd2hpY2ggZGVsaW1pdGVycyBhcmUg" +
           "dXNlZCwgZXRjLiBpcyB2ZW5kb3Itc3BlY2lmaWMuIEV4YW1wbGVzIG9mIHN1Y2ggc3RyaW5ncyBhcmUg" +
           "4oCcV2FyZWhvdXNlMS9TaGVldDPigJ0gb3Ig4oCcU3RhaW5sZXNzU3RlZWxUb3RlM+KAnSAoc2VlIE9Q" +
           "QyBVQSBPUEMgMTAwMDAtMTEwIGZvciBtb3JlIGRldGFpbHMpLgAuAES6FwAAAAz/////AwP/////AAAA" +
           "ADVgiQoCAAAABAAUAAAASGllcmFyY2hpY2FsTG9jYXRpb24BAcAXAwAAAABbAQAASGllcmFyY2hpY2Fs" +
           "TG9jYXRpb24gcHJvdmlkZXMgdGhlIGhpZXJhcmNoaWNhbCBsb2NhdGlvbiBvZiB0aGUgTEFEUyBEZXZp" +
           "Y2UuVGhlIHN0cnVjdHVyZSBpbnNpZGUgdGhlIHN0cmluZyBtYXkgZXhwb3NlIHNldmVyYWwgbGV2ZWxz" +
           "LiBIb3cgdGhpcyBpcyBleHBvc2VkLCB3aGljaCBkZWxpbWl0ZXJzIGFyZSB1c2VkLCBldGMuIGlzIHZl" +
           "bmRvci1zcGVjaWZpYy4gRXhhbXBsZXMgb2Ygc3VjaCBzdHJpbmdzIGFyZSDigJxGYWN0b3J5QS9CdWls" +
           "ZGluZ0MvRmxvb3Ix4oCdIG9yIOKAnEFyZWExLVByb2Nlc3NDZWxsMTctVW5pdDTigJ0gKHNlZSBPUEMg" +
           "VUEgT1BDIDEwMDAwLTExMCBmb3IgbW9yZSBEZXRhaWxzKS4ALgBEwBcAAAAM/////wMD/////wAAAAAk" +
           "YIAKAQAAAAMAFwAAAE1hY2hpbmVyeUJ1aWxkaW5nQmxvY2tzAQHgEwMAAAAArQAAAFRoZSBNYWNoaW5l" +
           "cnlCdWlsZGluZ0Jsb2NrcyBmb2xkZXIgY29udGFpbnMgYWxsIG1hY2hpbmVyeSBidWlsZGluZyBibG9j" +
           "a3MsIGVzcGVjaWFsbHkgdGhlIE1hY2hpbmVyeUl0ZW1TdGF0ZSwgTWFjaGluZXJ5T3BlcmF0aW9uTW9k" +
           "ZSwgT3BlcmF0aW9uQ291bnRlciBhbmQgTGlmZXRpbWUgQ291bnRlcnMuACMAPeATAAD/////AgAAACRg" +
           "gAoBAAAAAwAQAAAATGlmZXRpbWVDb3VudGVycwEB5hMDAAAAAFYAAABMaWZldGltZSBDb3VudGVyIHBy" +
           "b3ZpZGVzIGluZm9ybWF0aW9uIGFib3V0IHRoZSBwYXN0IGFuZCBlc3RpbWF0ZWQgcmVtYWluaW5nIGxp" +
           "ZmV0aW1lLgEAxEQBA/cD5hMAAP////8AAAAABGCACgEAAAACABEAAABPcGVyYXRpb25Db3VudGVycwEB" +
           "6RMBAMREAQPxA+kTAAABAAAAAQDDRAABAuABAAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<DeviceHealthEnumeration> DeviceHealth
        {
            get
            {
                return m_deviceHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealth = value;
            }
        }

        /// <remarks />
        public FolderState DeviceHealthAlarms
        {
            get
            {
                return m_deviceHealthAlarms;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealthAlarms, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealthAlarms = value;
            }
        }

        /// <remarks />
        public new MachineryComponentIdentificationTypeState Identification
        {
            get { return (MachineryComponentIdentificationTypeState)base.Identification; }
            set { base.Identification = value; }
        }

        /// <remarks />
        public MaintenanceSetTypeState Maintenance
        {
            get
            {
                return m_maintenance;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenance, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenance = value;
            }
        }

        /// <remarks />
        public LADSComponentsTypeState Components
        {
            get
            {
                return m_components;
            }

            set
            {
                if (!Object.ReferenceEquals(m_components, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_components = value;
            }
        }

        /// <remarks />
        public PropertyState<string> OperationalLocation
        {
            get
            {
                return m_operationalLocation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationalLocation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationalLocation = value;
            }
        }

        /// <remarks />
        public PropertyState<string> HierarchicalLocation
        {
            get
            {
                return m_hierarchicalLocation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hierarchicalLocation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hierarchicalLocation = value;
            }
        }

        /// <remarks />
        public FolderState MachineryBuildingBlocks
        {
            get
            {
                return m_machineryBuildingBlocks;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machineryBuildingBlocks, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machineryBuildingBlocks = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceHealth != null)
            {
                children.Add(m_deviceHealth);
            }

            if (m_deviceHealthAlarms != null)
            {
                children.Add(m_deviceHealthAlarms);
            }

            if (m_maintenance != null)
            {
                children.Add(m_maintenance);
            }

            if (m_components != null)
            {
                children.Add(m_components);
            }

            if (m_operationalLocation != null)
            {
                children.Add(m_operationalLocation);
            }

            if (m_hierarchicalLocation != null)
            {
                children.Add(m_hierarchicalLocation);
            }

            if (m_machineryBuildingBlocks != null)
            {
                children.Add(m_machineryBuildingBlocks);
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
                case Opc.Ua.Di.BrowseNames.DeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealth = new BaseDataVariableState<DeviceHealthEnumeration>(this);
                            }
                            else
                            {
                                DeviceHealth = (BaseDataVariableState<DeviceHealthEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceHealth;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceHealthAlarms:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealthAlarms == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealthAlarms = new FolderState(this);
                            }
                            else
                            {
                                DeviceHealthAlarms = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceHealthAlarms;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Identification:
                {
                    if (createOrReplace)
                    {
                        if (Identification == null)
                        {
                            if (replacement == null)
                            {
                                Identification = new MachineryComponentIdentificationTypeState(this);
                            }
                            else
                            {
                                Identification = (MachineryComponentIdentificationTypeState)replacement;
                            }
                        }
                    }

                    instance = Identification;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Maintenance:
                {
                    if (createOrReplace)
                    {
                        if (Maintenance == null)
                        {
                            if (replacement == null)
                            {
                                Maintenance = new MaintenanceSetTypeState(this);
                            }
                            else
                            {
                                Maintenance = (MaintenanceSetTypeState)replacement;
                            }
                        }
                    }

                    instance = Maintenance;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.Components:
                {
                    if (createOrReplace)
                    {
                        if (Components == null)
                        {
                            if (replacement == null)
                            {
                                Components = new LADSComponentsTypeState(this);
                            }
                            else
                            {
                                Components = (LADSComponentsTypeState)replacement;
                            }
                        }
                    }

                    instance = Components;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.OperationalLocation:
                {
                    if (createOrReplace)
                    {
                        if (OperationalLocation == null)
                        {
                            if (replacement == null)
                            {
                                OperationalLocation = new PropertyState<string>(this);
                            }
                            else
                            {
                                OperationalLocation = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = OperationalLocation;
                    break;
                }

                case Opc.Ua.AMB.BrowseNames.HierarchicalLocation:
                {
                    if (createOrReplace)
                    {
                        if (HierarchicalLocation == null)
                        {
                            if (replacement == null)
                            {
                                HierarchicalLocation = new PropertyState<string>(this);
                            }
                            else
                            {
                                HierarchicalLocation = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HierarchicalLocation;
                    break;
                }

                case Opc.Ua.Machinery.BrowseNames.MachineryBuildingBlocks:
                {
                    if (createOrReplace)
                    {
                        if (MachineryBuildingBlocks == null)
                        {
                            if (replacement == null)
                            {
                                MachineryBuildingBlocks = new FolderState(this);
                            }
                            else
                            {
                                MachineryBuildingBlocks = (FolderState)replacement;
                            }
                        }
                    }

                    instance = MachineryBuildingBlocks;
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
        private BaseDataVariableState<DeviceHealthEnumeration> m_deviceHealth;
        private FolderState m_deviceHealthAlarms;
        private MaintenanceSetTypeState m_maintenance;
        private LADSComponentsTypeState m_components;
        private PropertyState<string> m_operationalLocation;
        private PropertyState<string> m_hierarchicalLocation;
        private FolderState m_machineryBuildingBlocks;
        #endregion
    }
    #endif
    #endregion

    #region FunctionalUnitTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalUnitTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalUnitTypeState : TopologyElementTypeState
    {
        #region Constructors
        /// <remarks />
        public FunctionalUnitTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.FunctionalUnitType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (FunctionSet != null)
            {
                FunctionSet.Initialize(context, FunctionSet_InitializationString);
            }

            if (Identification != null)
            {
                Identification.Initialize(context, Identification_InitializationString);
            }

            if (ProgramManager != null)
            {
                ProgramManager.Initialize(context, ProgramManager_InitializationString);
            }

            if (SupportedPropertiesSet != null)
            {
                SupportedPropertiesSet.Initialize(context, SupportedPropertiesSet_InitializationString);
            }

            if (AssetId != null)
            {
                AssetId.Initialize(context, AssetId_InitializationString);
            }

            if (ComponentName != null)
            {
                ComponentName.Initialize(context, ComponentName_InitializationString);
            }

            if (Operational != null)
            {
                Operational.Initialize(context, Operational_InitializationString);
            }
        }

        #region Initialization String
        private const string FunctionSet_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEACwAAAEZ1bmN0aW9u" +
           "U2V0AQGQEwMAAAAAXwAAAFRoZSBGdW5jdGlvblNldFR5cGUgaXMgdXNlZCBmb3Igb3JnYW5pc2luZyBG" +
           "dW5jdGlvblR5cGUgb2JqZWN0cyBpbiBhbiB1bm9yZGVyZWQgbGlzdCBzdHJ1Y3R1cmUuAC8BAQIEkBMA" +
           "AP////8AAAAA";

        private const string Identification_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAIADgAAAElkZW50aWZp" +
           "Y2F0aW9uAQGLEwMAAAAARwAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3IgaWRlbnRpZmlj" +
           "YXRpb24gb2YgdGhpcyBmdW5jdGlvbmFsIHVuaXQuAC8BAu0DixMAAP////8AAAAA";

        private const string ProgramManager_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////9kYIAKAQAAAAEADgAAAFByb2dyYW1N" +
           "YW5hZ2VyAQGXEwMAAAAADwAAAFByb2dyYW0gTWFuYWdlcgMAAAAAQgAAAFRoZSBQcm9ncmFtTWFuYWdl" +
           "ciBwcm92aWRlcyB0aGUgZnVuY3Rpb25hbCB1bml0J3MgcHJvZ3JhbSBtYW5hZ2VyLgAvAQHuA5cTAAD/" +
           "////AwAAACRggAoBAAAAAQANAAAAQWN0aXZlUHJvZ3JhbQEBYhQDAAAAACsBAABUaGUgQWN0aXZlUHJv" +
           "Z3JhbSBzcGVjaWZpZXMgdGhlIGN1cnJlbnQgc3RhdGUgb2Ygb3BlcmF0aW9uIG9mIGEgRnVuY3Rpb25h" +
           "bFVuaXQuIEl0IHByb3ZpZGVzIGNvbnRleHQgYW5kIGluZm9ybWF0aW9uIGFib3V0IHRoZSBjdXJyZW50" +
           "bHkgYWN0aXZlIHByb2dyYW0gb24gdGhlIGRldmljZS4gVGhpcyBhbGxvd3MgdXNlcnMgdG8gZm9sbG93" +
           "IHRoZSBwcm9ncmVzcyBvZiBhIHByb2dyYW0gcnVuIGluIGEgc3RhbmRhcmRpemVkIGZhc2hpb24gYnkg" +
           "b3JnYW5pc2luZyBzdGVwcyBpbnRvIGEgZmxhdCwgbGluZWFyIHNlcXVlbmNlLgAvAQEQBGIUAAD/////" +
           "AAAAACRggAoBAAAAAQASAAAAUHJvZ3JhbVRlbXBsYXRlU2V0AQGdEwMAAAAAbQAAAFRoZSBQcm9ncmFt" +
           "VGVtcGxhdGVTZXRUeXBlIGlzIHVzZWQgZm9yIG9yZ2FuaXNpbmcgUHJvZ3JhbVRlbXBsYXRlVHlwZSBv" +
           "YmplY3RzIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4ALwEB+wOdEwAA/////wEAAAA1YKkK" +
           "AgAAAAAACwAAAE5vZGVWZXJzaW9uAQFyGAMAAAAApQAAAE5vZGVWZXJzaW9uIGFuZCB0aGUgR2VuZXJh" +
           "bE1vZGVsQ2hhbmdlRXZlbnRUeXBlIGFyZSBtZWNoYW5pc21zIHRvIG5vdGlmeSBjbGllbnRzIHRoYXQg" +
           "dGhlIGNvbnRlbnQgb2YgdGhlIHNldCBoYXMgY2hhbmdlZCBhbmQgc2hhbGwgYmUgdXNlZCBhcyBkZWZp" +
           "bmVkIGluIE9QQyAxMDAwMC0zLgAuAERyGAAADAMAAABOYU4ADP////8BAf////8AAAAAJGCACgEAAAAB" +
           "AAkAAABSZXN1bHRTZXQBAZ4TAwAAAABbAAAAVGhlIFJlc3VsdFNldFR5cGUgaXMgdXNlZCBmb3Igb3Jn" +
           "YW5pc2luZyBSZXN1bHRUeXBlIG9iamVjdHMgaW4gYW4gdW5vcmRlcmVkIGxpc3Qgc3RydWN0dXJlLgAv" +
           "AQH8A54TAAD/////AQAAADVgqQoCAAAAAAALAAAATm9kZVZlcnNpb24BAaQXAwAAAAClAAAATm9kZVZl" +
           "cnNpb24gYW5kIHRoZSBHZW5lcmFsTW9kZWxDaGFuZ2VFdmVudFR5cGUgYXJlIG1lY2hhbmlzbXMgdG8g" +
           "bm90aWZ5IGNsaWVudHMgdGhhdCB0aGUgY29udGVudCBvZiB0aGUgc2V0IGhhcyBjaGFuZ2VkIGFuZCBz" +
           "aGFsbCBiZSB1c2VkIGFzIGRlZmluZWQgaW4gT1BDIDEwMDAwLTMuAC4ARKQXAAAMAwAAAE5hTgAM////" +
           "/wMD/////wAAAAA=";

        private const string SupportedPropertiesSet_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEAFgAAAFN1cHBvcnRl" +
           "ZFByb3BlcnRpZXNTZXQBAfwTAwAAAADEAAAAU3VwcG9ydGVkUHJvcGVydGllc1NldCBwcm92aWRlcyBh" +
           "IHNldCBvZiBwcm9wZXJ0aWVzIHdoaWNoIGFyZSBzdXBwb3J0ZWQgYXMgbWVtYmVycyBvZiBhIHByb3Bl" +
           "cnRpZXMgbGlzdCBBcmd1bWVudCBmb3IgTWV0aG9kIGNhbGxzIHN1Y2ggYXMsIEZ1bmN0aW9uYWxVbml0" +
           "LlN0YXJ0RnVuY3Rpb25zKCkgb3IgQWN0aXZlUHJvZ3JhbS5TdGFydCgpLgAvAQEJBPwTAAD/////AAAA" +
           "AA==";

        private const string AssetId_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIABwAAAEFzc2V0SWQB" +
           "AYwYAwAAAAB7AAAAQXNzZXRJZCBpcyBhIHVzZXItd3JpdGFibGUgYWxwaGFudW1lcmljIGNoYXJhY3Rl" +
           "ciBzZXF1ZW5jZSB0aGUgdW5pcXVlbHkgaWRlbnRpZmllcyBhIEZ1bmN0aW9uYWxVbml0IChzZWUgT1BD" +
           "IFVBIDEwMDAwLTEwMCkuAC4ARIwYAAAADP////8BAf////8AAAAA";

        private const string ComponentName_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAIADQAAAENvbXBvbmVu" +
           "dE5hbWUBAY0YAwAAAABfAAAAQ29tcG9uZW50TmFtZSBpcyBhIHVzZXItd3JpdGFibGUgbmFtZSBwcm92" +
           "aWRlZCBieSB0aGUgaW50ZWdyYXRvciBvciB1c2VyIG9mIHRoZSBGdW5jdGlvbmFsVW5pdC4ALgBEjRgA" +
           "AAAV/////wEB/////wAAAAA=";

        private const string Operational_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEACwAAAE9wZXJhdGlv" +
           "bmFsAQGPEwMAAAAATQAAAFBhcmFtZXRlcnMgYW5kIE1ldGhvZHMgdXNlZnVsIGZvciBkdXJpbmcgbm9y" +
           "bWFsIG9wZXJhdGlvbiwgbGlrZSBwcm9jZXNzIGRhdGEuAC8BAu0DjxMAAP////8FAAAABGGCCgQAAAAB" +
           "AAUAAABDbGVhcgEBaxsAIwEBaxtrGwAAAQH/////AAAAAARhggoEAAAAAQAEAAAAU3RvcAEBcBsAIwEB" +
           "cBtwGwAAAQH/////AAAAAARhggoEAAAAAQAFAAAAQWJvcnQBAXEbACMBAXEbcRsAAAEB/////wAAAAAV" +
           "YIkKAgAAAAAAFAAAAEVmZmVjdGl2ZURpc3BsYXlOYW1lAQHZFwAjAETZFwAAABX/////AQH/////AAAA" +
           "AARhggoEAAAAAQAMAAAAU3RhcnRQcm9ncmFtAQGGGwAjAQGGG4YbAAABAf////8CAAAAN2CpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEB/hcDAAAAAF4AAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQg" +
           "YXJndW1lbnQgb2YgbWV0aG9kIDQ6RnVuY3Rpb25hbFVuaXRTdGF0ZU1hY2hpbmVUeXBlLjQ6U3RhcnRQ" +
           "cm9ncmFtAC4ARP4XAACWBQAAAAEAKgEBUwAAAAoAAABQcm9wZXJ0aWVzAQG7CwEAAAAAAAAAAjQAAABB" +
           "IEtleS9WYWx1ZSBzZXQgZm9yIHBhcmFtZXRlcml6YXRpb24gb2YgdGhlIHByb2dyYW0uAQAqAQEfAAAA" +
           "EAAAAFN1cGVydmlzb3J5Sm9iSWQADP////8AAAAAAAEAKgEBQgAAABEAAABTdXBlcnZpc29yeVRhc2tJ" +
           "ZAAM/////wAAAAACHgAAAFRoZSBJRCBvZiB0aGUgU3VwZXJ2aXNvcnlUYXNrLgEAKgEBfgAAAAcAAABT" +
           "YW1wbGVzAQG6CwEAAAABAAAAAQAAAAJeAAAAQW4gYXJyYXkgb2YgdGhlIFNhbXBsZUluZm9UeXBlIHRo" +
           "YXQgZGVzY3JpYmVzIHRoZSBzYW1wbGVzIHByb2Nlc3NlZCBpbiB0aGlzIHByb2dyYW0gZXhlY3V0aW9u" +
           "LgEAKgEBagAAABEAAABQcm9ncmFtVGVtcGxhdGVJZAAM/////wAAAAACRgAAAFRoZSBJRCBvZiB0aGUg" +
           "cHJvZ3JhbSB0ZW1wbGF0ZSB0aGF0IGlzIHVzZWQgZm9yIHRoZSBjdXJyZW50IGV4ZWN1dGlvbi4BACgB" +
           "AQAAAAEAAAAFAAAAAQH/////AAAAADdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQH/FwMAAAAA" +
           "YAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCA0OkZ1bmN0" +
           "aW9uYWxVbml0U3RhdGVNYWNoaW5lVHlwZS40OlN0YXJ0UHJvZ3JhbQAuAET/FwAAlgEAAAABACoBAUcA" +
           "AAASAAAARGV2aWNlUHJvZ3JhbVJ1bklkAAz/////AAAAAAIiAAAAVGhlIElEIG9mIHRoZSBjcmVhdGVk" +
           "IHByb2dyYW0gcnVuLgEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGgAAAEZ1bmN0aW9u" +
           "YWxVbml0VHlwZUluc3RhbmNlAQHrAwEB6wPrAwAAAQAAAAEAw0QAAQLIOgkAAAAkYIAKAQAAAAIADgAA" +
           "AElkZW50aWZpY2F0aW9uAQGLEwMAAAAARwAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3Ig" +
           "aWRlbnRpZmljYXRpb24gb2YgdGhpcyBmdW5jdGlvbmFsIHVuaXQuAC8BAu0DixMAAP////8AAAAAJGCA" +
           "CgEAAAACAAQAAABMb2NrAQGMEwMAAAAAIAAAAFVzZWQgdG8gbG9jayB0aGUgRnVuY3Rpb25hbFVuaXQu" +
           "AC8BAvQYjBMAAP////8IAAAAFWCJCgIAAAACAAYAAABMb2NrZWQBAYEXAC4ARIEXAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAACAA0AAABMb2NraW5nQ2xpZW50AQGCFwAuAESCFwAAAAz/////AQH/////AAAA" +
           "ABVgiQoCAAAAAgALAAAATG9ja2luZ1VzZXIBAYMXAC4ARIMXAAAADP////8BAf////8AAAAAFWCJCgIA" +
           "AAACABEAAABSZW1haW5pbmdMb2NrVGltZQEBhBcALgBEhBcAAAEAIgH/////AQH/////AAAAAARhggoE" +
           "AAAAAgAIAAAASW5pdExvY2sBAV8bAC8BAvkYXxsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQF/FwAuAER/FwAAlgEAAAABACoBARYAAAAHAAAAQ29udGV4dAAM/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBgBcALgBE" +
           "gBcAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAAB" +
           "AAAAAQH/////AAAAAARhggoEAAAAAgAJAAAAUmVuZXdMb2NrAQFgGwAvAQL8GGAbAAABAf////8BAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYUXAC4ARIUXAACWAQAAAAEAKgEBHgAAAA8AAABS" +
           "ZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAC" +
           "AAgAAABFeGl0TG9jawEBXhsALwEC/hheGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQF+FwAuAER+FwAAlgEAAAABACoBAR0AAAAOAAAARXhpdExvY2tTdGF0dXMABv////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAACAAkAAABCcmVha0xvY2sBAV0bAC8BAgAZ" +
           "XRsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBfRcALgBEfRcAAJYBAAAA" +
           "AQAqAQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAAkYIAKAQAAAAEACwAAAEZ1bmN0aW9uU2V0AQGQEwMAAAAAXwAAAFRoZSBGdW5jdGlvblNldFR5" +
           "cGUgaXMgdXNlZCBmb3Igb3JnYW5pc2luZyBGdW5jdGlvblR5cGUgb2JqZWN0cyBpbiBhbiB1bm9yZGVy" +
           "ZWQgbGlzdCBzdHJ1Y3R1cmUuAC8BAQIEkBMAAP////8AAAAAZGCACgEAAAABAA4AAABQcm9ncmFtTWFu" +
           "YWdlcgEBlxMDAAAAAA8AAABQcm9ncmFtIE1hbmFnZXIDAAAAAEIAAABUaGUgUHJvZ3JhbU1hbmFnZXIg" +
           "cHJvdmlkZXMgdGhlIGZ1bmN0aW9uYWwgdW5pdCdzIHByb2dyYW0gbWFuYWdlci4ALwEB7gOXEwAA////" +
           "/wMAAAAkYIAKAQAAAAEADQAAAEFjdGl2ZVByb2dyYW0BAWIUAwAAAAArAQAAVGhlIEFjdGl2ZVByb2dy" +
           "YW0gc3BlY2lmaWVzIHRoZSBjdXJyZW50IHN0YXRlIG9mIG9wZXJhdGlvbiBvZiBhIEZ1bmN0aW9uYWxV" +
           "bml0LiBJdCBwcm92aWRlcyBjb250ZXh0IGFuZCBpbmZvcm1hdGlvbiBhYm91dCB0aGUgY3VycmVudGx5" +
           "IGFjdGl2ZSBwcm9ncmFtIG9uIHRoZSBkZXZpY2UuIFRoaXMgYWxsb3dzIHVzZXJzIHRvIGZvbGxvdyB0" +
           "aGUgcHJvZ3Jlc3Mgb2YgYSBwcm9ncmFtIHJ1biBpbiBhIHN0YW5kYXJkaXplZCBmYXNoaW9uIGJ5IG9y" +
           "Z2FuaXNpbmcgc3RlcHMgaW50byBhIGZsYXQsIGxpbmVhciBzZXF1ZW5jZS4ALwEBEARiFAAA/////wAA" +
           "AAAkYIAKAQAAAAEAEgAAAFByb2dyYW1UZW1wbGF0ZVNldAEBnRMDAAAAAG0AAABUaGUgUHJvZ3JhbVRl" +
           "bXBsYXRlU2V0VHlwZSBpcyB1c2VkIGZvciBvcmdhbmlzaW5nIFByb2dyYW1UZW1wbGF0ZVR5cGUgb2Jq" +
           "ZWN0cyBpbiBhbiB1bm9yZGVyZWQgbGlzdCBzdHJ1Y3R1cmUuAC8BAfsDnRMAAP////8BAAAANWCpCgIA" +
           "AAAAAAsAAABOb2RlVmVyc2lvbgEBchgDAAAAAKUAAABOb2RlVmVyc2lvbiBhbmQgdGhlIEdlbmVyYWxN" +
           "b2RlbENoYW5nZUV2ZW50VHlwZSBhcmUgbWVjaGFuaXNtcyB0byBub3RpZnkgY2xpZW50cyB0aGF0IHRo" +
           "ZSBjb250ZW50IG9mIHRoZSBzZXQgaGFzIGNoYW5nZWQgYW5kIHNoYWxsIGJlIHVzZWQgYXMgZGVmaW5l" +
           "ZCBpbiBPUEMgMTAwMDAtMy4ALgBEchgAAAwDAAAATmFOAAz/////AQH/////AAAAACRggAoBAAAAAQAJ" +
           "AAAAUmVzdWx0U2V0AQGeEwMAAAAAWwAAAFRoZSBSZXN1bHRTZXRUeXBlIGlzIHVzZWQgZm9yIG9yZ2Fu" +
           "aXNpbmcgUmVzdWx0VHlwZSBvYmplY3RzIGluIGFuIHVub3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4ALwEB" +
           "/AOeEwAA/////wEAAAA1YKkKAgAAAAAACwAAAE5vZGVWZXJzaW9uAQGkFwMAAAAApQAAAE5vZGVWZXJz" +
           "aW9uIGFuZCB0aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZlbnRUeXBlIGFyZSBtZWNoYW5pc21zIHRvIG5v" +
           "dGlmeSBjbGllbnRzIHRoYXQgdGhlIGNvbnRlbnQgb2YgdGhlIHNldCBoYXMgY2hhbmdlZCBhbmQgc2hh" +
           "bGwgYmUgdXNlZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAwMC0zLgAuAESkFwAADAMAAABOYU4ADP////8D" +
           "A/////8AAAAAJGCACgEAAAABABYAAABTdXBwb3J0ZWRQcm9wZXJ0aWVzU2V0AQH8EwMAAAAAxAAAAFN1" +
           "cHBvcnRlZFByb3BlcnRpZXNTZXQgcHJvdmlkZXMgYSBzZXQgb2YgcHJvcGVydGllcyB3aGljaCBhcmUg" +
           "c3VwcG9ydGVkIGFzIG1lbWJlcnMgb2YgYSBwcm9wZXJ0aWVzIGxpc3QgQXJndW1lbnQgZm9yIE1ldGhv" +
           "ZCBjYWxscyBzdWNoIGFzLCBGdW5jdGlvbmFsVW5pdC5TdGFydEZ1bmN0aW9ucygpIG9yIEFjdGl2ZVBy" +
           "b2dyYW0uU3RhcnQoKS4ALwEBCQT8EwAA/////wAAAAAkYIAKAQAAAAEAEwAAAEZ1bmN0aW9uYWxVbml0" +
           "U3RhdGUBAY0TAwAAAABFAAAARnVuY3Rpb25hbFVuaXRTdGF0ZSBwcm92aWRlcyB0aGUgc3RhdGUtbWFj" +
           "aGluZSBvZiB0aGUgRnVuY3Rpb25hbFVuaXQuAC8BARMEjRMAAP////8DAAAAFWCJCgIAAAAAAAwAAABD" +
           "dXJyZW50U3RhdGUBAYcYAC8BAMgKhxgAAAAV/////wEB/////wIAAAAVYIkIAgAAAAAAAgAAAElkAQEA" +
           "AAAuAEQAEf////8BAf////8AAAAAFWCJCgIAAAAAABQAAABFZmZlY3RpdmVEaXNwbGF5TmFtZQEBiBgA" +
           "LgBEiBgAAAAV/////wEB/////wAAAAA3YIkKAgAAAAAADwAAAEF2YWlsYWJsZVN0YXRlcwEBSRkDAAAA" +
           "AC4AAABTZXQgb2Ygc3RhdGVzIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8AP0kZAAAA" +
           "EQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAAFAAAAEF2YWlsYWJsZVRyYW5zaXRpb25zAQFI" +
           "GQMAAAAAMwAAAFNldCBvZiB0cmFuc2l0aW9ucyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9u" +
           "LgAvAD9IGQAAABEBAAAAAQAAAAEAAAABAf////8AAAAANWCJCgIAAAACAAcAAABBc3NldElkAQGMGAMA" +
           "AAAAewAAAEFzc2V0SWQgaXMgYSB1c2VyLXdyaXRhYmxlIGFscGhhbnVtZXJpYyBjaGFyYWN0ZXIgc2Vx" +
           "dWVuY2UgdGhlIHVuaXF1ZWx5IGlkZW50aWZpZXMgYSBGdW5jdGlvbmFsVW5pdCAoc2VlIE9QQyBVQSAx" +
           "MDAwMC0xMDApLgAuAESMGAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgANAAAAQ29tcG9uZW50TmFt" +
           "ZQEBjRgDAAAAAF8AAABDb21wb25lbnROYW1lIGlzIGEgdXNlci13cml0YWJsZSBuYW1lIHByb3ZpZGVk" +
           "IGJ5IHRoZSBpbnRlZ3JhdG9yIG9yIHVzZXIgb2YgdGhlIEZ1bmN0aW9uYWxVbml0LgAuAESNGAAAABX/" +
           "////AQH/////AAAAACRggAoBAAAAAQALAAAAT3BlcmF0aW9uYWwBAY8TAwAAAABNAAAAUGFyYW1ldGVy" +
           "cyBhbmQgTWV0aG9kcyB1c2VmdWwgZm9yIGR1cmluZyBub3JtYWwgb3BlcmF0aW9uLCBsaWtlIHByb2Nl" +
           "c3MgZGF0YS4ALwEC7QOPEwAA/////wUAAAAEYYIKBAAAAAEABQAAAENsZWFyAQFrGwAjAQFrG2sbAAAB" +
           "Af////8AAAAABGGCCgQAAAABAAQAAABTdG9wAQFwGwAjAQFwG3AbAAABAf////8AAAAABGGCCgQAAAAB" +
           "AAUAAABBYm9ydAEBcRsAIwEBcRtxGwAAAQH/////AAAAABVgiQoCAAAAAAAUAAAARWZmZWN0aXZlRGlz" +
           "cGxheU5hbWUBAdkXACMARNkXAAAAFf////8BAf////8AAAAABGGCCgQAAAABAAwAAABTdGFydFByb2dy" +
           "YW0BAYYbACMBAYYbhhsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH+FwMA" +
           "AAAAXgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgNDpGdW5j" +
           "dGlvbmFsVW5pdFN0YXRlTWFjaGluZVR5cGUuNDpTdGFydFByb2dyYW0ALgBE/hcAAJYFAAAAAQAqAQFT" +
           "AAAACgAAAFByb3BlcnRpZXMBAbsLAQAAAAAAAAACNAAAAEEgS2V5L1ZhbHVlIHNldCBmb3IgcGFyYW1l" +
           "dGVyaXphdGlvbiBvZiB0aGUgcHJvZ3JhbS4BACoBAR8AAAAQAAAAU3VwZXJ2aXNvcnlKb2JJZAAM////" +
           "/wAAAAAAAQAqAQFCAAAAEQAAAFN1cGVydmlzb3J5VGFza0lkAAz/////AAAAAAIeAAAAVGhlIElEIG9m" +
           "IHRoZSBTdXBlcnZpc29yeVRhc2suAQAqAQF+AAAABwAAAFNhbXBsZXMBAboLAQAAAAEAAAABAAAAAl4A" +
           "AABBbiBhcnJheSBvZiB0aGUgU2FtcGxlSW5mb1R5cGUgdGhhdCBkZXNjcmliZXMgdGhlIHNhbXBsZXMg" +
           "cHJvY2Vzc2VkIGluIHRoaXMgcHJvZ3JhbSBleGVjdXRpb24uAQAqAQFqAAAAEQAAAFByb2dyYW1UZW1w" +
           "bGF0ZUlkAAz/////AAAAAAJGAAAAVGhlIElEIG9mIHRoZSBwcm9ncmFtIHRlbXBsYXRlIHRoYXQgaXMg" +
           "dXNlZCBmb3IgdGhlIGN1cnJlbnQgZXhlY3V0aW9uLgEAKAEBAAAAAQAAAAUAAAABAf////8AAAAAN2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf8XAwAAAABgAAAAdGhlIGRlZmluaXRpb24gb2YgdGhl" +
           "IG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDQ6RnVuY3Rpb25hbFVuaXRTdGF0ZU1hY2hpbmVUeXBl" +
           "LjQ6U3RhcnRQcm9ncmFtAC4ARP8XAACWAQAAAAEAKgEBRwAAABIAAABEZXZpY2VQcm9ncmFtUnVuSWQA" +
           "DP////8AAAAAAiIAAABUaGUgSUQgb2YgdGhlIGNyZWF0ZWQgcHJvZ3JhbSBydW4uAQAoAQEAAAABAAAA" +
           "AQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FunctionSetTypeState FunctionSet
        {
            get
            {
                return m_functionSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionSet = value;
            }
        }

        /// <remarks />
        public ProgramManagerTypeState ProgramManager
        {
            get
            {
                return m_programManager;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programManager, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programManager = value;
            }
        }

        /// <remarks />
        public SupportedPropertiesSetTypeState SupportedPropertiesSet
        {
            get
            {
                return m_supportedPropertiesSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedPropertiesSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedPropertiesSet = value;
            }
        }

        /// <remarks />
        public FunctionalUnitStateMachineTypeState FunctionalUnitState
        {
            get
            {
                return m_functionalUnitState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionalUnitState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionalUnitState = value;
            }
        }

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
        public FunctionalGroupTypeState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_functionSet != null)
            {
                children.Add(m_functionSet);
            }

            if (m_programManager != null)
            {
                children.Add(m_programManager);
            }

            if (m_supportedPropertiesSet != null)
            {
                children.Add(m_supportedPropertiesSet);
            }

            if (m_functionalUnitState != null)
            {
                children.Add(m_functionalUnitState);
            }

            if (m_assetId != null)
            {
                children.Add(m_assetId);
            }

            if (m_componentName != null)
            {
                children.Add(m_componentName);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
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
                case Opc.Ua.LADS.BrowseNames.FunctionSet:
                {
                    if (createOrReplace)
                    {
                        if (FunctionSet == null)
                        {
                            if (replacement == null)
                            {
                                FunctionSet = new FunctionSetTypeState(this);
                            }
                            else
                            {
                                FunctionSet = (FunctionSetTypeState)replacement;
                            }
                        }
                    }

                    instance = FunctionSet;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ProgramManager:
                {
                    if (createOrReplace)
                    {
                        if (ProgramManager == null)
                        {
                            if (replacement == null)
                            {
                                ProgramManager = new ProgramManagerTypeState(this);
                            }
                            else
                            {
                                ProgramManager = (ProgramManagerTypeState)replacement;
                            }
                        }
                    }

                    instance = ProgramManager;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.SupportedPropertiesSet:
                {
                    if (createOrReplace)
                    {
                        if (SupportedPropertiesSet == null)
                        {
                            if (replacement == null)
                            {
                                SupportedPropertiesSet = new SupportedPropertiesSetTypeState(this);
                            }
                            else
                            {
                                SupportedPropertiesSet = (SupportedPropertiesSetTypeState)replacement;
                            }
                        }
                    }

                    instance = SupportedPropertiesSet;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.FunctionalUnitState:
                {
                    if (createOrReplace)
                    {
                        if (FunctionalUnitState == null)
                        {
                            if (replacement == null)
                            {
                                FunctionalUnitState = new FunctionalUnitStateMachineTypeState(this);
                            }
                            else
                            {
                                FunctionalUnitState = (FunctionalUnitStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = FunctionalUnitState;
                    break;
                }

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

                case Opc.Ua.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Operational;
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
        private FunctionSetTypeState m_functionSet;
        private ProgramManagerTypeState m_programManager;
        private SupportedPropertiesSetTypeState m_supportedPropertiesSet;
        private FunctionalUnitStateMachineTypeState m_functionalUnitState;
        private PropertyState<string> m_assetId;
        private PropertyState<LocalizedText> m_componentName;
        private FunctionalGroupTypeState m_operational;
        #endregion
    }
    #endif
    #endregion

    #region FunctionTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionTypeState : TopologyElementTypeState
    {
        #region Constructors
        /// <remarks />
        public FunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.FunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }

            if (FunctionSet != null)
            {
                FunctionSet.Initialize(context, FunctionSet_InitializationString);
            }
        }

        #region Initialization String
        private const string Configuration_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEADQAAAENvbmZpZ3Vy" +
           "YXRpb24BAZQTAwAAAABPAAAAQ29uZmlndXJhdGlvbiBpcyB1c2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRl" +
           "cnMgZm9yIGNvbmZpZ3VyYXRpb24gb2YgdGhlIEZ1bmN0aW9uLgAvAQLtA5QTAAD/////AAAAAA==";

        private const string FunctionSet_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////9kYIAKAQAAAAEACwAAAEZ1bmN0aW9u" +
           "U2V0AQGVEwMAAAAADAAAAEZ1bmN0aW9uIFNldAMAAAAAXwAAAFRoZSBGdW5jdGlvblNldFR5cGUgaXMg" +
           "dXNlZCBmb3Igb3JnYW5pc2luZyBGdW5jdGlvblR5cGUgb2JqZWN0cyBpbiBhbiB1bm9yZGVyZWQgbGlz" +
           "dCBzdHJ1Y3R1cmUuAC8BAQIElRMAAP////8BAAAANWCpCgIAAAAAAAsAAABOb2RlVmVyc2lvbgEBxBcD" +
           "AAAAAKUAAABOb2RlVmVyc2lvbiBhbmQgdGhlIEdlbmVyYWxNb2RlbENoYW5nZUV2ZW50VHlwZSBhcmUg" +
           "bWVjaGFuaXNtcyB0byBub3RpZnkgY2xpZW50cyB0aGF0IHRoZSBjb250ZW50IG9mIHRoZSBzZXQgaGFz" +
           "IGNoYW5nZWQgYW5kIHNoYWxsIGJlIHVzZWQgYXMgZGVmaW5lZCBpbiBPUEMgMTAwMDAtMy4ALgBExBcA" +
           "AAwDAAAATmFOAAz/////AwP/////AAAAAA==";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAFAAAAEZ1bmN0aW9u" +
           "VHlwZUluc3RhbmNlAQHsAwEB7APsAwAA/////wMAAAAkYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24B" +
           "AZQTAwAAAABPAAAAQ29uZmlndXJhdGlvbiBpcyB1c2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9y" +
           "IGNvbmZpZ3VyYXRpb24gb2YgdGhlIEZ1bmN0aW9uLgAvAQLtA5QTAAD/////AAAAAGRggAoBAAAAAQAL" +
           "AAAARnVuY3Rpb25TZXQBAZUTAwAAAAAMAAAARnVuY3Rpb24gU2V0AwAAAABfAAAAVGhlIEZ1bmN0aW9u" +
           "U2V0VHlwZSBpcyB1c2VkIGZvciBvcmdhbmlzaW5nIEZ1bmN0aW9uVHlwZSBvYmplY3RzIGluIGFuIHVu" +
           "b3JkZXJlZCBsaXN0IHN0cnVjdHVyZS4ALwEBAgSVEwAA/////wEAAAA1YKkKAgAAAAAACwAAAE5vZGVW" +
           "ZXJzaW9uAQHEFwMAAAAApQAAAE5vZGVWZXJzaW9uIGFuZCB0aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZl" +
           "bnRUeXBlIGFyZSBtZWNoYW5pc21zIHRvIG5vdGlmeSBjbGllbnRzIHRoYXQgdGhlIGNvbnRlbnQgb2Yg" +
           "dGhlIHNldCBoYXMgY2hhbmdlZCBhbmQgc2hhbGwgYmUgdXNlZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAw" +
           "MC0zLgAuAETEFwAADAMAAABOYU4ADP////8DA/////8AAAAANWCJCgIAAAABAAkAAABJc0VuYWJsZWQB" +
           "AXIXAwAAAADGAAAASXNFbmFibGVkIGluZGljYXRlcyB3aGV0aGVyIHRoZSBGdW5jdGlvbiBjYW4gY3Vy" +
           "cmVudGx5IGJlIGV4ZWN1dGVkIG9uIHRoZSBEZXZpY2UuIEEgRnVuY3Rpb24gbWF5IGJlIGRpc2FibGVk" +
           "IGZvciBzZXZlcmFsIHJlYXNvbnMgaW5jbHVkaW5nIG5vdCBsaWNlbnNlZCwgbWlzc2luZyBoYXJkd2Fy" +
           "ZSBtb2R1bGVzLCBvciBtaXNzaW5nIHN1cHBsaWVzAC4ARHIXAAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FunctionalGroupTypeState Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <remarks />
        public FunctionSetTypeState FunctionSet
        {
            get
            {
                return m_functionSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionSet = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsEnabled
        {
            get
            {
                return m_isEnabled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isEnabled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isEnabled = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_functionSet != null)
            {
                children.Add(m_functionSet);
            }

            if (m_isEnabled != null)
            {
                children.Add(m_isEnabled);
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
                case Opc.Ua.LADS.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Configuration = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.FunctionSet:
                {
                    if (createOrReplace)
                    {
                        if (FunctionSet == null)
                        {
                            if (replacement == null)
                            {
                                FunctionSet = new FunctionSetTypeState(this);
                            }
                            else
                            {
                                FunctionSet = (FunctionSetTypeState)replacement;
                            }
                        }
                    }

                    instance = FunctionSet;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.IsEnabled:
                {
                    if (createOrReplace)
                    {
                        if (IsEnabled == null)
                        {
                            if (replacement == null)
                            {
                                IsEnabled = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsEnabled = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsEnabled;
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
        private FunctionalGroupTypeState m_configuration;
        private FunctionSetTypeState m_functionSet;
        private PropertyState<bool> m_isEnabled;
        #endregion
    }
    #endif
    #endregion

    #region BaseControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_BaseControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BaseControlFunctionTypeState : FunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public BaseControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.BaseControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (AlarmMonitor != null)
            {
                AlarmMonitor.Initialize(context, AlarmMonitor_InitializationString);
            }

            if (ControllerTuningParameter != null)
            {
                ControllerTuningParameter.Initialize(context, ControllerTuningParameter_InitializationString);
            }
        }

        #region Initialization String
        private const string AlarmMonitor_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEADAAAAEFsYXJtTW9u" +
           "aXRvcgEBzBMDAAAAAJEAAABBbGFybU1vbml0b3IgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIGRldmlhdGlv" +
           "biBmcm9tIGEgc2V0IHBvaW50IGV4Y2VlZHMgdGhlIGxpbWl0LiBTZWU6IDEwMDAwLTk6IEFsYXJtcyAm" +
           "IENvbmRpdGlvbnMgfCBFeGNsdXNpdmVEZXZpYXRpb25BbGFybVR5cGUuAC8BACQmzBMAAP////8iAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQFoGAAuAERoGAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQFpGAAuAERpGAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBbhgALgBEbhgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAW0Y" +
           "AC4ARG0YAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFvGAAuAERvGAAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBaxgALgBEaxgAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBahgALgBEahgAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQFsGAAuAERsGAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBYBgALgBEYBgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBYRgALgBEYRgAAAAV/////wEB/////wAAAAAXYIkIAgAAAAAAEwAAAENv" +
           "bmRpdGlvblN1YkNsYXNzSWQBAQAAAC4ARAARAQAAAAEAAAAAAAAAAQH/////AAAAABdgiQgCAAAAAAAV" +
           "AAAAQ29uZGl0aW9uU3ViQ2xhc3NOYW1lAQEAAAAuAEQAFQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAWIYAC4ARGIYAAAADP////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABCcmFuY2hJZAEBXBgALgBEXBgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFp" +
           "bgEBZxgALgBEZxgAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBVBgA" +
           "LwEAIyNUGAAAABX/////AQEFAAAAAQAsIwABAVgYAQAsIwADAQAzAAAAQmFzZUNvbnRyb2xGdW5jdGlv" +
           "blR5cGVfQWxhcm1Nb25pdG9yX0NvbmZpcm1lZFN0YXRlAQAsIwABAVAYAQAsIwADAQA0AAAAQmFzZUNv" +
           "bnRyb2xGdW5jdGlvblR5cGVfQWxhcm1Nb25pdG9yX1N1cHByZXNzZWRTdGF0ZQEALCMAAwEAMgAAAEJh" +
           "c2VDb250cm9sRnVuY3Rpb25UeXBlX0FsYXJtTW9uaXRvcl9TaGVsdmluZ1N0YXRlAQAAABVgiQoCAAAA" +
           "AAACAAAASWQBAVUYAC4ARFUYAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQFl" +
           "GAAvAQAqI2UYAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAWYY" +
           "AC4ARGYYAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBYxgALwEA" +
           "KiNjGAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFkGAAuAERk" +
           "GAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQFeGAAvAQAqI14YAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAV8YAC4ARF8YAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBXRgALgBEXRgAAAAM/////wEB////" +
           "/wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYQbAC8BAEQjhBsAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAABgAAAEVuYWJsZQEBhRsALwEAQyOFGwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAA" +
           "AAAKAAAAQWRkQ29tbWVudAEBgxsALwEARSODGwAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAVsYAC4ARFsYAACWAgAAAAEAKgEBQgAAAAcAAABFdmVudElkAA//////" +
           "AAAAAAIoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBPgAAAAcA" +
           "AABDb21tZW50ABX/////AAAAAAIkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24u" +
           "AQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAVYIkKAgAAAAAACgAAAEFja2VkU3RhdGUBAVgYAC8BACMj" +
           "WBgAAAAV/////wEBAQAAAAEALCMBAQFUGAEAAAAVYIkKAgAAAAAAAgAAAElkAQFZGAAuAERZGAAAAAH/" +
           "////AQH/////AAAAAARhggoEAAAAAAALAAAAQWNrbm93bGVkZ2UBAYIbAC8BAJcjghsAAAEBAQAAAAEA" +
           "+QsAAQDwIgEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFaGAAuAERaGAAAlgIAAAABACoB" +
           "AUIAAAAHAAAARXZlbnRJZAAP/////wAAAAACKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAT4AAAAHAAAAQ29tbWVudAAV/////wAAAAACJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCgIAAAAAAAsA" +
           "AABBY3RpdmVTdGF0ZQEBUBgALwEAIyNQGAAAABX/////AQECAAAAAQAsIwEBAVQYAQAsIwABAc8TAQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAVEYAC4ARFEYAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABJ" +
           "bnB1dE5vZGUBAVYYAC4ARFYYAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABMAAABTdXBwcmVzc2Vk" +
           "T3JTaGVsdmVkAQFXGAAuAERXGAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAANAAAASGlnaEhpZ2hM" +
           "aW1pdAEBhxcALgBEhxcAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEhpZ2hMaW1pdAEBiBcA" +
           "LgBEiBcAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAExvd0xpbWl0AQGJFwAuAESJFwAAAAv/" +
           "////AQH/////AAAAABVgiQoCAAAAAAALAAAATG93TG93TGltaXQBAYoXAC4ARIoXAAAAC/////8BAf//" +
           "//8AAAAABGCACgEAAAAAAAoAAABMaW1pdFN0YXRlAQHPEwAvAQBmJM8TAAABAAAAAQAsIwEBAVAYAQAA" +
           "ABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQFSGAAvAQDIClIYAAAAFf////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBUxgALgBEUxgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFNldHBv" +
           "aW50Tm9kZQEBTxgALgBETxgAAAAR/////wEB/////wAAAAA=";

        private const string ControllerTuningParameter_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEAGQAAAENvbnRyb2xs" +
           "ZXJUdW5pbmdQYXJhbWV0ZXIBAYkTAwAAAADUAAAAVGhlIENvbnRyb2xsZXJUdW5pbmdQYXJhbWV0ZXJU" +
           "eXBlIGlzIGFuIGFic3RyYWN0IGNsYXNzLiBJdCBpcyBmb3JtYWxseSBkZWZpbmVkIGluIFRhYmxlIDg1" +
           "LiBTdWJ0eXBlcyBvZiB0aGUgQ29udHJvbGxlclR1bmluZ1BhcmFtZXRlclR5cGUgY29udGFpbiB0aGUg" +
           "cGFyYW1ldGVycyBhbmQgaW5mb3JtYXRpb24gYWJvdXQgYSBDb250cm9sbGVyIChjb25maWd1cmF0aW9u" +
           "KS4ALwEB8AOJEwAA/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHwAAAEJhc2VDb250" +
           "cm9sRnVuY3Rpb25UeXBlSW5zdGFuY2UBAe8DAQHvA+8DAAD/////BQAAADVgiQoCAAAAAQAJAAAASXNF" +
           "bmFibGVkAQFyFwMAAAAAxgAAAElzRW5hYmxlZCBpbmRpY2F0ZXMgd2hldGhlciB0aGUgRnVuY3Rpb24g" +
           "Y2FuIGN1cnJlbnRseSBiZSBleGVjdXRlZCBvbiB0aGUgRGV2aWNlLiBBIEZ1bmN0aW9uIG1heSBiZSBk" +
           "aXNhYmxlZCBmb3Igc2V2ZXJhbCByZWFzb25zIGluY2x1ZGluZyBub3QgbGljZW5zZWQsIG1pc3Npbmcg" +
           "aGFyZHdhcmUgbW9kdWxlcywgb3IgbWlzc2luZyBzdXBwbGllcwAuAERyFwAAAAH/////AwP/////AAAA" +
           "ACRggAoBAAAAAQAMAAAAQWxhcm1Nb25pdG9yAQHMEwMAAAAAkQAAAEFsYXJtTW9uaXRvciBpbmRpY2F0" +
           "ZXMgd2hldGhlciB0aGUgZGV2aWF0aW9uIGZyb20gYSBzZXQgcG9pbnQgZXhjZWVkcyB0aGUgbGltaXQu" +
           "IFNlZTogMTAwMDAtOTogQWxhcm1zICYgQ29uZGl0aW9ucyB8IEV4Y2x1c2l2ZURldmlhdGlvbkFsYXJt" +
           "VHlwZS4ALwEAJCbMEwAA/////yIAAAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAWgYAC4ARGgYAAAAD///" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAWkYAC4ARGkYAAAAEf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFuGAAuAERuGAAAABH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAKAAAAU291cmNlTmFtZQEBbRgALgBEbRgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAA" +
           "AFRpbWUBAW8YAC4ARG8YAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQFrGAAuAERrGAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQFqGAAuAERq" +
           "GAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAWwYAC4ARGwYAAAABf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lkAQFgGAAuAERgGAAAABH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQFhGAAuAERhGAAAABX/////AQH/" +
           "////AAAAABdgiQgCAAAAAAATAAAAQ29uZGl0aW9uU3ViQ2xhc3NJZAEBAAAALgBEABEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAAF2CJCAIAAAAAABUAAABDb25kaXRpb25TdWJDbGFzc05hbWUBAQAAAC4ARAAVAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBYhgALgBEYhgAAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFcGAAuAERcGAAAABH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFnGAAuAERnGAAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAARW5hYmxlZFN0YXRlAQFUGAAvAQAjI1QYAAAAFf////8BAQUAAAABACwjAAEBWBgBACwjAAMB" +
           "ADMAAABCYXNlQ29udHJvbEZ1bmN0aW9uVHlwZV9BbGFybU1vbml0b3JfQ29uZmlybWVkU3RhdGUBACwj" +
           "AAEBUBgBACwjAAMBADQAAABCYXNlQ29udHJvbEZ1bmN0aW9uVHlwZV9BbGFybU1vbml0b3JfU3VwcHJl" +
           "c3NlZFN0YXRlAQAsIwADAQAyAAAAQmFzZUNvbnRyb2xGdW5jdGlvblR5cGVfQWxhcm1Nb25pdG9yX1No" +
           "ZWx2aW5nU3RhdGUBAAAAFWCJCgIAAAAAAAIAAABJZAEBVRgALgBEVRgAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBAWUYAC8BACojZRgAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBZhgALgBEZhgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQFjGAAvAQAqI2MYAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAWQYAC4ARGQYAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBAV4YAC8BACojXhgAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBXxgALgBEXxgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQFdGAAuAERdGAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBhBsALwEARCOE" +
           "GwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGFGwAvAQBDI4UbAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGDGwAvAQBFI4MbAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWxgALgBEWxgAAJYCAAAAAQAq" +
           "AQFCAAAABwAAAEV2ZW50SWQAD/////8AAAAAAigAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQE+AAAABwAAAENvbW1lbnQAFf////8AAAAAAiQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAACAAAAAQH/////AAAAABVgiQoCAAAAAAAK" +
           "AAAAQWNrZWRTdGF0ZQEBWBgALwEAIyNYGAAAABX/////AQEBAAAAAQAsIwEBAVQYAQAAABVgiQoCAAAA" +
           "AAACAAAASWQBAVkYAC4ARFkYAAAAAf////8BAf////8AAAAABGGCCgQAAAAAAAsAAABBY2tub3dsZWRn" +
           "ZQEBghsALwEAlyOCGwAAAQEBAAAAAQD5CwABAPAiAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAVoYAC4ARFoYAACWAgAAAAEAKgEBQgAAAAcAAABFdmVudElkAA//////AAAAAAIoAAAAVGhlIGlk" +
           "ZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBPgAAAAcAAABDb21tZW50ABX/////" +
           "AAAAAAIkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAgAA" +
           "AAEB/////wAAAAAVYIkKAgAAAAAACwAAAEFjdGl2ZVN0YXRlAQFQGAAvAQAjI1AYAAAAFf////8BAQIA" +
           "AAABACwjAQEBVBgBACwjAAEBzxMBAAAAFWCJCgIAAAAAAAIAAABJZAEBURgALgBEURgAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACQAAAElucHV0Tm9kZQEBVhgALgBEVhgAAAAR/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEwAAAFN1cHByZXNzZWRPclNoZWx2ZWQBAVcYAC4ARFcYAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAA0AAABIaWdoSGlnaExpbWl0AQGHFwAuAESHFwAAAAv/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAJAAAASGlnaExpbWl0AQGIFwAuAESIFwAAAAv/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "TG93TGltaXQBAYkXAC4ARIkXAAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABMb3dMb3dMaW1p" +
           "dAEBihcALgBEihcAAAAL/////wEB/////wAAAAAEYIAKAQAAAAAACgAAAExpbWl0U3RhdGUBAc8TAC8B" +
           "AGYkzxMAAAEAAAABACwjAQEBUBgBAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAVIYAC8BAMgK" +
           "UhgAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFTGAAuAERTGAAAABH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAAU2V0cG9pbnROb2RlAQFPGAAuAERPGAAAABH/////AQH/////AAAAACRg" +
           "gAoBAAAAAQALAAAAT3BlcmF0aW9uYWwBAbYTAwAAAADcAAAAT3BlcmF0aW9uYWwgaXMgYSBGdW5jdGlv" +
           "bmFsR3JvdXAgdGhhdCBzaGFsbCBvcmdhbml6ZSB0aGUgQ3VycmVudFN0YXRlIHByb3BlcnR5IG9mIHRo" +
           "ZSBTdGF0ZU1hY2hpbmUgYW5kIGFsbCBpdHMgcmVtb3RlIGludm9jYWJsZSBNZXRob2RzLiBGdXJ0aGVy" +
           "bW9yZSwgaXQgc2hhbGwgb3JnYW5pemUgYXQgbGVhc3QgdGhlIEN1cnJlbnRWYWx1ZSBhbmQgVGFyZ2V0" +
           "VmFsdWUgdmFyaWFibGVzLgAvAQLtA7YTAAD/////AgAAAARhggoEAAAAAQAFAAAAUmVzZXQBAXUbACMB" +
           "AXUbdRsAAAEB/////wAAAAAEYYIKBAAAAAEABAAAAFN0b3ABAXQbACMBAXQbdBsAAAEB/////wAAAAAk" +
           "YIAKAQAAAAEAFAAAAENvbnRyb2xGdW5jdGlvblN0YXRlAQGuEwMAAAAAeAAAAENvbnRyb2xGdW5jdGlv" +
           "blN0YXRlIGlzIGEgc3RhdGUgbWFjaGluZSB3aGljaCByZXByZXNlbnRzIHRoZSBleGVjdXRpb24gc3Rh" +
           "dGUgYW5kIGNvbnRyb2xzIHRoZSBleGVjdXRpb24gb2YgdGhlIEZ1bmN0aW9uLgAvAQEUBK4TAAD/////" +
           "AwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQG/FwAvAQDICr8XAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBmhcALgBEmhcAAAAR/////wEB/////wAAAAA3YIkKAgAAAAAADwAAAEF2" +
           "YWlsYWJsZVN0YXRlcwEBSRkDAAAAAC4AAABTZXQgb2Ygc3RhdGVzIHN1cHBvcnRlZCBieSB0aGUgaW1w" +
           "bGVtZW50YXRpb24uAC8AP0kZAAAAEQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAAFAAAAEF2" +
           "YWlsYWJsZVRyYW5zaXRpb25zAQFIGQMAAAAAMwAAAFNldCBvZiB0cmFuc2l0aW9ucyBzdXBwb3J0ZWQg" +
           "YnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9IGQAAABEBAAAAAQAAAAEAAAABAf////8AAAAAJGCACgEA" +
           "AAABABkAAABDb250cm9sbGVyVHVuaW5nUGFyYW1ldGVyAQGJEwMAAAAA1AAAAFRoZSBDb250cm9sbGVy" +
           "VHVuaW5nUGFyYW1ldGVyVHlwZSBpcyBhbiBhYnN0cmFjdCBjbGFzcy4gSXQgaXMgZm9ybWFsbHkgZGVm" +
           "aW5lZCBpbiBUYWJsZSA4NS4gU3VidHlwZXMgb2YgdGhlIENvbnRyb2xsZXJUdW5pbmdQYXJhbWV0ZXJU" +
           "eXBlIGNvbnRhaW4gdGhlIHBhcmFtZXRlcnMgYW5kIGluZm9ybWF0aW9uIGFib3V0IGEgQ29udHJvbGxl" +
           "ciAoY29uZmlndXJhdGlvbikuAC8BAfADiRMAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ExclusiveDeviationAlarmState AlarmMonitor
        {
            get
            {
                return m_alarmMonitor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmMonitor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmMonitor = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }

        /// <remarks />
        public ControlFunctionStateMachineTypeState ControlFunctionState
        {
            get
            {
                return m_controlFunctionState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controlFunctionState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controlFunctionState = value;
            }
        }

        /// <remarks />
        public ControllerTuningParameterTypeState ControllerTuningParameter
        {
            get
            {
                return m_controllerTuningParameter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controllerTuningParameter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controllerTuningParameter = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_alarmMonitor != null)
            {
                children.Add(m_alarmMonitor);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
            }

            if (m_controlFunctionState != null)
            {
                children.Add(m_controlFunctionState);
            }

            if (m_controllerTuningParameter != null)
            {
                children.Add(m_controllerTuningParameter);
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
                case Opc.Ua.LADS.BrowseNames.AlarmMonitor:
                {
                    if (createOrReplace)
                    {
                        if (AlarmMonitor == null)
                        {
                            if (replacement == null)
                            {
                                AlarmMonitor = new ExclusiveDeviationAlarmState(this);
                            }
                            else
                            {
                                AlarmMonitor = (ExclusiveDeviationAlarmState)replacement;
                            }
                        }
                    }

                    instance = AlarmMonitor;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Operational;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ControlFunctionState:
                {
                    if (createOrReplace)
                    {
                        if (ControlFunctionState == null)
                        {
                            if (replacement == null)
                            {
                                ControlFunctionState = new ControlFunctionStateMachineTypeState(this);
                            }
                            else
                            {
                                ControlFunctionState = (ControlFunctionStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = ControlFunctionState;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ControllerTuningParameter:
                {
                    if (createOrReplace)
                    {
                        if (ControllerTuningParameter == null)
                        {
                            if (replacement == null)
                            {
                                ControllerTuningParameter = new ControllerTuningParameterTypeState(this);
                            }
                            else
                            {
                                ControllerTuningParameter = (ControllerTuningParameterTypeState)replacement;
                            }
                        }
                    }

                    instance = ControllerTuningParameter;
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
        private ExclusiveDeviationAlarmState m_alarmMonitor;
        private FunctionalGroupTypeState m_operational;
        private ControlFunctionStateMachineTypeState m_controlFunctionState;
        private ControllerTuningParameterTypeState m_controllerTuningParameter;
        #endregion
    }
    #endif
    #endregion

    #region AnalogControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogControlFunctionTypeState : BaseControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIQAAAEFuYWxvZ0Nv" +
           "bnRyb2xGdW5jdGlvblR5cGVJbnN0YW5jZQEB8QMBAfED8QMAAP////8FAAAANWCJCgIAAAABAAkAAABJ" +
           "c0VuYWJsZWQBAXIXAwAAAADGAAAASXNFbmFibGVkIGluZGljYXRlcyB3aGV0aGVyIHRoZSBGdW5jdGlv" +
           "biBjYW4gY3VycmVudGx5IGJlIGV4ZWN1dGVkIG9uIHRoZSBEZXZpY2UuIEEgRnVuY3Rpb24gbWF5IGJl" +
           "IGRpc2FibGVkIGZvciBzZXZlcmFsIHJlYXNvbnMgaW5jbHVkaW5nIG5vdCBsaWNlbnNlZCwgbWlzc2lu" +
           "ZyBoYXJkd2FyZSBtb2R1bGVzLCBvciBtaXNzaW5nIHN1cHBsaWVzAC4ARHIXAAAAAf////8DA/////8A" +
           "AAAAJGCACgEAAAABAAsAAABPcGVyYXRpb25hbAEBkRMDAAAAANwAAABPcGVyYXRpb25hbCBpcyBhIEZ1" +
           "bmN0aW9uYWxHcm91cCB0aGF0IHNoYWxsIG9yZ2FuaXplIHRoZSBDdXJyZW50U3RhdGUgcHJvcGVydHkg" +
           "b2YgdGhlIFN0YXRlTWFjaGluZSBhbmQgYWxsIGl0cyByZW1vdGUgaW52b2NhYmxlIE1ldGhvZHMuIEZ1" +
           "cnRoZXJtb3JlLCBpdCBzaGFsbCBvcmdhbml6ZSBhdCBsZWFzdCB0aGUgQ3VycmVudFZhbHVlIGFuZCBU" +
           "YXJnZXRWYWx1ZSB2YXJpYWJsZXMuAC8BAu0DkRMAAP////8BAAAABGGCCgQAAAABAAQAAABTdG9wAQF0" +
           "GwAjAQF0G3QbAAABAf////8AAAAAJGCACgEAAAABABQAAABDb250cm9sRnVuY3Rpb25TdGF0ZQEBFRQD" +
           "AAAAAHgAAABDb250cm9sRnVuY3Rpb25TdGF0ZSBpcyBhIHN0YXRlIG1hY2hpbmUgd2hpY2ggcmVwcmVz" +
           "ZW50cyB0aGUgZXhlY3V0aW9uIHN0YXRlIGFuZCBjb250cm9scyB0aGUgZXhlY3V0aW9uIG9mIHRoZSBG" +
           "dW5jdGlvbi4ALwEBFAQVFAAA/////wQAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEB1BcALwEA" +
           "yArUFwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZoXAC4ARJoXAAAAEf////8BAf//" +
           "//8AAAAAN2CJCgIAAAAAAA8AAABBdmFpbGFibGVTdGF0ZXMBAUkZAwAAAAAuAAAAU2V0IG9mIHN0YXRl" +
           "cyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9JGQAAABEBAAAAAQAAAAEAAAABAf//" +
           "//8AAAAAN2CJCgIAAAAAABQAAABBdmFpbGFibGVUcmFuc2l0aW9ucwEBSBkDAAAAADMAAABTZXQgb2Yg" +
           "dHJhbnNpdGlvbnMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlvbi4ALwA/SBkAAAARAQAAAAEA" +
           "AAABAAAAAQH/////AAAAAARhggoEAAAAAQAUAAAAU3RhcnRXaXRoVGFyZ2V0VmFsdWUBAXMbAC8BAWEb" +
           "cxsAAAEB/////wEAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGhGAMAAAAAVQAAAHRoZSBk" +
           "ZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgNDpGdW5jdGlvblN0YXRlTWFj" +
           "aGluZVR5cGVUeXBlLjQ6U3RhcnQALgBEoRgAAJYBAAAAAQAqAQFyAAAACwAAAFRhcmdldFZhbHVlAAv/" +
           "////AAAAAAJUAAAAKE9wdGlvbmFsKSBUaGUgdmFsdWUgY2FuIHVzZSB0byBzZXQgdGhlIHRhcmdldCB2" +
           "YWx1ZSBwYXJhbGxlbCB3aXRoIHRoZSBzdGFydCBtZXRob2QuAQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAA1YIkKAgAAAAEADAAAAEN1cnJlbnRWYWx1ZQEBcRcDAAAAACoAAABDdXJyZW50VmFsdWUgaXMgdGhl" +
           "IGN1cnJlbnQgcHJvY2VzcyB2YWx1ZS4ALwEAokRxFwAAAAv/////AQH/////AgAAABVgiQgCAAAAAAAH" +
           "AAAARVVSYW5nZQEBAAAALgBEAQB0A/////8BAf////8AAAAAFWCJCAIAAAAAABAAAABFbmdpbmVlcmlu" +
           "Z1VuaXRzAQEAAAAuAEQBAHcD/////wEB/////wAAAAA1YIkKAgAAAAEACwAAAFRhcmdldFZhbHVlAQF2" +
           "FwMAAAAALAAAAFRhcmdldFZhbHVlIGlzIHRoZSB0YXJnZXRlZCBzZXQtcG9pbnQgdmFsdWUuAC8BAKJE" +
           "dhcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> CurrentValue
        {
            get
            {
                return m_currentValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentValue = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> TargetValue
        {
            get
            {
                return m_targetValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetValue = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentValue != null)
            {
                children.Add(m_currentValue);
            }

            if (m_targetValue != null)
            {
                children.Add(m_targetValue);
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
                case Opc.Ua.LADS.BrowseNames.CurrentValue:
                {
                    if (createOrReplace)
                    {
                        if (CurrentValue == null)
                        {
                            if (replacement == null)
                            {
                                CurrentValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CurrentValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CurrentValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TargetValue:
                {
                    if (createOrReplace)
                    {
                        if (TargetValue == null)
                        {
                            if (replacement == null)
                            {
                                TargetValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                TargetValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = TargetValue;
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
        private AnalogUnitRangeState<double> m_currentValue;
        private AnalogUnitRangeState<double> m_targetValue;
        #endregion
    }
    #endif
    #endregion

    #region AnalogControlFunctionWithTotalizerTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogControlFunctionWithTotalizerTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogControlFunctionWithTotalizerTypeState : AnalogControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogControlFunctionWithTotalizerTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionWithTotalizerType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (ResetTotalizer != null)
            {
                ResetTotalizer.Initialize(context, ResetTotalizer_InitializationString);
            }
        }

        #region Initialization String
        private const string ResetTotalizer_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEADgAAAFJlc2V0VG90" +
           "YWxpemVyAQFaGwAvAQFaG1obAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "9BcALgBE9BcAAJYBAAAAAQAqAQEUAAAABQAAAFZhbHVlAAv/////AAAAAAABACgBAQAAAAEAAAABAAAA" +
           "AwP/////AAAAAA==";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEALgAAAEFuYWxvZ0Nv" +
           "bnRyb2xGdW5jdGlvbldpdGhUb3RhbGl6ZXJUeXBlSW5zdGFuY2UBAfYDAQH2A/YDAAD/////BwAAADVg" +
           "iQoCAAAAAQAJAAAASXNFbmFibGVkAQFyFwMAAAAAxgAAAElzRW5hYmxlZCBpbmRpY2F0ZXMgd2hldGhl" +
           "ciB0aGUgRnVuY3Rpb24gY2FuIGN1cnJlbnRseSBiZSBleGVjdXRlZCBvbiB0aGUgRGV2aWNlLiBBIEZ1" +
           "bmN0aW9uIG1heSBiZSBkaXNhYmxlZCBmb3Igc2V2ZXJhbCByZWFzb25zIGluY2x1ZGluZyBub3QgbGlj" +
           "ZW5zZWQsIG1pc3NpbmcgaGFyZHdhcmUgbW9kdWxlcywgb3IgbWlzc2luZyBzdXBwbGllcwAuAERyFwAA" +
           "AAH/////AwP/////AAAAACRggAoBAAAAAQALAAAAT3BlcmF0aW9uYWwBAcMTAwAAAADcAAAAT3BlcmF0" +
           "aW9uYWwgaXMgYSBGdW5jdGlvbmFsR3JvdXAgdGhhdCBzaGFsbCBvcmdhbml6ZSB0aGUgQ3VycmVudFN0" +
           "YXRlIHByb3BlcnR5IG9mIHRoZSBTdGF0ZU1hY2hpbmUgYW5kIGFsbCBpdHMgcmVtb3RlIGludm9jYWJs" +
           "ZSBNZXRob2RzLiBGdXJ0aGVybW9yZSwgaXQgc2hhbGwgb3JnYW5pemUgYXQgbGVhc3QgdGhlIEN1cnJl" +
           "bnRWYWx1ZSBhbmQgVGFyZ2V0VmFsdWUgdmFyaWFibGVzLgAvAQLtA8MTAAD/////AQAAAARhggoEAAAA" +
           "AQAEAAAAU3RvcAEBdBsAIwEBdBt0GwAAAQH/////AAAAACRggAoBAAAAAQAUAAAAQ29udHJvbEZ1bmN0" +
           "aW9uU3RhdGUBARUUAwAAAAB4AAAAQ29udHJvbEZ1bmN0aW9uU3RhdGUgaXMgYSBzdGF0ZSBtYWNoaW5l" +
           "IHdoaWNoIHJlcHJlc2VudHMgdGhlIGV4ZWN1dGlvbiBzdGF0ZSBhbmQgY29udHJvbHMgdGhlIGV4ZWN1" +
           "dGlvbiBvZiB0aGUgRnVuY3Rpb24uAC8BARQEFRQAAP////8DAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50" +
           "U3RhdGUBAdQXAC8BAMgK1BcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGaFwAuAESa" +
           "FwAAABH/////AQH/////AAAAADdgiQoCAAAAAAAPAAAAQXZhaWxhYmxlU3RhdGVzAQFJGQMAAAAALgAA" +
           "AFNldCBvZiBzdGF0ZXMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlvbi4ALwA/SRkAAAARAQAA" +
           "AAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAUAAAAQXZhaWxhYmxlVHJhbnNpdGlvbnMBAUgZAwAA" +
           "AAAzAAAAU2V0IG9mIHRyYW5zaXRpb25zIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8A" +
           "P0gZAAAAEQEAAAABAAAAAQAAAAEB/////wAAAAA1YIkKAgAAAAEADAAAAEN1cnJlbnRWYWx1ZQEBcRcD" +
           "AAAAACoAAABDdXJyZW50VmFsdWUgaXMgdGhlIGN1cnJlbnQgcHJvY2VzcyB2YWx1ZS4ALwEAokRxFwAA" +
           "AAv/////AQH/////AgAAABVgiQgCAAAAAAAHAAAARVVSYW5nZQEBAAAALgBEAQB0A/////8BAf////8A" +
           "AAAAFWCJCAIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQEAAAAuAEQBAHcD/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEACwAAAFRhcmdldFZhbHVlAQF2FwMAAAAALAAAAFRhcmdldFZhbHVlIGlzIHRoZSB0YXJn" +
           "ZXRlZCBzZXQtcG9pbnQgdmFsdWUuAC8BAKJEdhcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAQAAAC4ARAEAdAP/////AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdV" +
           "bml0cwEBAAAALgBEAQB3A/////8BAf////8AAAAANWCJCgIAAAABAA4AAABUb3RhbGl6ZWRWYWx1ZQEB" +
           "excDAAAAAG4AAABUb3RhbGl6ZWRWYWx1ZSBpcyB0aGUgdG90YWxpemVkIHByb2Nlc3MgdmFsdWUuIEl0" +
           "IGNhbiBiZSByZXNldCBhdCBhbnkgdGltZSB1c2luZyB0aGUgUmVzZXRUb3RhbGl6ZXIoKSBjb21tYW5k" +
           "LgAvAQCiRHsXAAAAC/////8BAf////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQBAHQD" +
           "/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/////" +
           "AQH/////AAAAAARhggoEAAAAAQAOAAAAUmVzZXRUb3RhbGl6ZXIBAVobAC8BAVobWhsAAAEB/////wEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH0FwAuAET0FwAAlgEAAAABACoBARQAAAAFAAAA" +
           "VmFsdWUAC/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAADA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> TotalizedValue
        {
            get
            {
                return m_totalizedValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_totalizedValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_totalizedValue = value;
            }
        }

        /// <remarks />
        public ResetTotalizerMethodState ResetTotalizer
        {
            get
            {
                return m_resetTotalizerMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetTotalizerMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetTotalizerMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_totalizedValue != null)
            {
                children.Add(m_totalizedValue);
            }

            if (m_resetTotalizerMethod != null)
            {
                children.Add(m_resetTotalizerMethod);
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
                case Opc.Ua.LADS.BrowseNames.TotalizedValue:
                {
                    if (createOrReplace)
                    {
                        if (TotalizedValue == null)
                        {
                            if (replacement == null)
                            {
                                TotalizedValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                TotalizedValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = TotalizedValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ResetTotalizer:
                {
                    if (createOrReplace)
                    {
                        if (ResetTotalizer == null)
                        {
                            if (replacement == null)
                            {
                                ResetTotalizer = new ResetTotalizerMethodState(this);
                            }
                            else
                            {
                                ResetTotalizer = (ResetTotalizerMethodState)replacement;
                            }
                        }
                    }

                    instance = ResetTotalizer;
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
        private AnalogUnitRangeState<double> m_totalizedValue;
        private ResetTotalizerMethodState m_resetTotalizerMethod;
        #endregion
    }
    #endif
    #endregion

    #region DiscreteControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_DiscreteControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DiscreteControlFunctionTypeState : BaseControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public DiscreteControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.DiscreteControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIwAAAERpc2NyZXRl" +
           "Q29udHJvbEZ1bmN0aW9uVHlwZUluc3RhbmNlAQH5AwEB+QP5AwAA/////wUAAAA1YIkKAgAAAAEACQAA" +
           "AElzRW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIEZ1bmN0" +
           "aW9uIGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERldmljZS4gQSBGdW5jdGlvbiBtYXkg" +
           "YmUgZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRpbmcgbm90IGxpY2Vuc2VkLCBtaXNz" +
           "aW5nIGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxpZXMALgBEchcAAAAB/////wMD////" +
           "/wAAAAAkYIAKAQAAAAEACwAAAE9wZXJhdGlvbmFsAQG2EwMAAAAA3AAAAE9wZXJhdGlvbmFsIGlzIGEg" +
           "RnVuY3Rpb25hbEdyb3VwIHRoYXQgc2hhbGwgb3JnYW5pemUgdGhlIEN1cnJlbnRTdGF0ZSBwcm9wZXJ0" +
           "eSBvZiB0aGUgU3RhdGVNYWNoaW5lIGFuZCBhbGwgaXRzIHJlbW90ZSBpbnZvY2FibGUgTWV0aG9kcy4g" +
           "RnVydGhlcm1vcmUsIGl0IHNoYWxsIG9yZ2FuaXplIGF0IGxlYXN0IHRoZSBDdXJyZW50VmFsdWUgYW5k" +
           "IFRhcmdldFZhbHVlIHZhcmlhYmxlcy4ALwEC7QO2EwAA/////wEAAAAEYYIKBAAAAAEABAAAAFN0b3AB" +
           "AXQbACMBAXQbdBsAAAEB/////wAAAAAkYIAKAQAAAAEAFAAAAENvbnRyb2xGdW5jdGlvblN0YXRlAQGu" +
           "EwMAAAAAeAAAAENvbnRyb2xGdW5jdGlvblN0YXRlIGlzIGEgc3RhdGUgbWFjaGluZSB3aGljaCByZXBy" +
           "ZXNlbnRzIHRoZSBleGVjdXRpb24gc3RhdGUgYW5kIGNvbnRyb2xzIHRoZSBleGVjdXRpb24gb2YgdGhl" +
           "IEZ1bmN0aW9uLgAvAQEUBK4TAAD/////AwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQG/FwAv" +
           "AQDICr8XAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBmhcALgBEmhcAAAAR/////wEB" +
           "/////wAAAAA3YIkKAgAAAAAADwAAAEF2YWlsYWJsZVN0YXRlcwEBSRkDAAAAAC4AAABTZXQgb2Ygc3Rh" +
           "dGVzIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8AP0kZAAAAEQEAAAABAAAAAQAAAAEB" +
           "/////wAAAAA3YIkKAgAAAAAAFAAAAEF2YWlsYWJsZVRyYW5zaXRpb25zAQFIGQMAAAAAMwAAAFNldCBv" +
           "ZiB0cmFuc2l0aW9ucyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9IGQAAABEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAANWCJCgIAAAABAAwAAABDdXJyZW50VmFsdWUBAbEXAwAAAAAxAAAAQ3Vy" +
           "cmVudFZhbHVlIGlzIGEgY3VycmVudCBkaXNjcmV0ZSBwcm9jZXNzIHZhbHVlLgAvAQBECbEXAAAAGP//" +
           "//8BAf////8AAAAANWCJCgIAAAABAAsAAABUYXJnZXRWYWx1ZQEB6xcDAAAAADUAAABUYXJnZXRWYWx1" +
           "ZSBpcyB0aGUgdGFyZ2V0ZWQgZGlzY3JldGUgc2V0LXBvaW50IHZhbHVlLgAvAQBECesXAAAAGP////8D" +
           "A/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState CurrentValue
        {
            get
            {
                return m_currentValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentValue = value;
            }
        }

        /// <remarks />
        public DiscreteItemState TargetValue
        {
            get
            {
                return m_targetValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetValue = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentValue != null)
            {
                children.Add(m_currentValue);
            }

            if (m_targetValue != null)
            {
                children.Add(m_targetValue);
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
                case Opc.Ua.LADS.BrowseNames.CurrentValue:
                {
                    if (createOrReplace)
                    {
                        if (CurrentValue == null)
                        {
                            if (replacement == null)
                            {
                                CurrentValue = new DiscreteItemState(this);
                            }
                            else
                            {
                                CurrentValue = (DiscreteItemState)replacement;
                            }
                        }
                    }

                    instance = CurrentValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TargetValue:
                {
                    if (createOrReplace)
                    {
                        if (TargetValue == null)
                        {
                            if (replacement == null)
                            {
                                TargetValue = new DiscreteItemState(this);
                            }
                            else
                            {
                                TargetValue = (DiscreteItemState)replacement;
                            }
                        }
                    }

                    instance = TargetValue;
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
        private DiscreteItemState m_currentValue;
        private DiscreteItemState m_targetValue;
        #endregion
    }
    #endif
    #endregion

    #region MultiStateDiscreteControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_MultiStateDiscreteControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MultiStateDiscreteControlFunctionTypeState : DiscreteControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public MultiStateDiscreteControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.MultiStateDiscreteControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEALQAAAE11bHRpU3Rh" +
           "dGVEaXNjcmV0ZUNvbnRyb2xGdW5jdGlvblR5cGVJbnN0YW5jZQEBFQQBARUEFQQAAP////8FAAAANWCJ" +
           "CgIAAAABAAkAAABJc0VuYWJsZWQBAXIXAwAAAADGAAAASXNFbmFibGVkIGluZGljYXRlcyB3aGV0aGVy" +
           "IHRoZSBGdW5jdGlvbiBjYW4gY3VycmVudGx5IGJlIGV4ZWN1dGVkIG9uIHRoZSBEZXZpY2UuIEEgRnVu" +
           "Y3Rpb24gbWF5IGJlIGRpc2FibGVkIGZvciBzZXZlcmFsIHJlYXNvbnMgaW5jbHVkaW5nIG5vdCBsaWNl" +
           "bnNlZCwgbWlzc2luZyBoYXJkd2FyZSBtb2R1bGVzLCBvciBtaXNzaW5nIHN1cHBsaWVzAC4ARHIXAAAA" +
           "Af////8DA/////8AAAAAJGCACgEAAAABAAsAAABPcGVyYXRpb25hbAEBthMDAAAAANwAAABPcGVyYXRp" +
           "b25hbCBpcyBhIEZ1bmN0aW9uYWxHcm91cCB0aGF0IHNoYWxsIG9yZ2FuaXplIHRoZSBDdXJyZW50U3Rh" +
           "dGUgcHJvcGVydHkgb2YgdGhlIFN0YXRlTWFjaGluZSBhbmQgYWxsIGl0cyByZW1vdGUgaW52b2NhYmxl" +
           "IE1ldGhvZHMuIEZ1cnRoZXJtb3JlLCBpdCBzaGFsbCBvcmdhbml6ZSBhdCBsZWFzdCB0aGUgQ3VycmVu" +
           "dFZhbHVlIGFuZCBUYXJnZXRWYWx1ZSB2YXJpYWJsZXMuAC8BAu0DthMAAP////8BAAAABGGCCgQAAAAB" +
           "AAQAAABTdG9wAQF0GwAjAQF0G3QbAAABAf////8AAAAAJGCACgEAAAABABQAAABDb250cm9sRnVuY3Rp" +
           "b25TdGF0ZQEBFhQDAAAAAHgAAABDb250cm9sRnVuY3Rpb25TdGF0ZSBpcyBhIHN0YXRlIG1hY2hpbmUg" +
           "d2hpY2ggcmVwcmVzZW50cyB0aGUgZXhlY3V0aW9uIHN0YXRlIGFuZCBjb250cm9scyB0aGUgZXhlY3V0" +
           "aW9uIG9mIHRoZSBGdW5jdGlvbi4ALwEBFAQWFAAA/////wQAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRT" +
           "dGF0ZQEB1BcALwEAyArUFwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZoXAC4ARJoX" +
           "AAAAEf////8BAf////8AAAAAN2CJCgIAAAAAAA8AAABBdmFpbGFibGVTdGF0ZXMBAUkZAwAAAAAuAAAA" +
           "U2V0IG9mIHN0YXRlcyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9JGQAAABEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAABQAAABBdmFpbGFibGVUcmFuc2l0aW9ucwEBSBkDAAAA" +
           "ADMAAABTZXQgb2YgdHJhbnNpdGlvbnMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlvbi4ALwA/" +
           "SBkAAAARAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAUAAAAU3RhcnRXaXRoVGFyZ2V0VmFs" +
           "dWUBAYobAC8BAWEbihsAAAEB/////wEAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGiGAMA" +
           "AAAAVQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgNDpGdW5j" +
           "dGlvblN0YXRlTWFjaGluZVR5cGVUeXBlLjQ6U3RhcnQALgBEohgAAJYBAAAAAQAqAQFyAAAACwAAAFRh" +
           "cmdldFZhbHVlAAf/////AAAAAAJUAAAAKE9wdGlvbmFsKSBUaGUgdmFsdWUgY2FuIHVzZSB0byBzZXQg" +
           "dGhlIHRhcmdldCB2YWx1ZSBwYXJhbGxlbCB3aXRoIHRoZSBzdGFydCBtZXRob2QuAQAoAQEAAAABAAAA" +
           "AQAAAAEB/////wAAAAA1YIkKAgAAAAEADAAAAEN1cnJlbnRWYWx1ZQEBsxcDAAAAADEAAABDdXJyZW50" +
           "VmFsdWUgaXMgYSBjdXJyZW50IGRpc2NyZXRlIHByb2Nlc3MgdmFsdWUuAC8BAEgJsxcAAAAH/////wEB" +
           "/////wEAAAA3YIkKAgAAAAAACwAAAEVudW1TdHJpbmdzAQENGAMAAAAAOwAAAExpc3Qgb2YgaHVtYW4g" +
           "cmVhZGFibGUgaWRlbnRpZmllcnMgZm9yIHRoZSBkaXNjcmV0ZSB2YWx1ZXMuAC4ARA0YAAAAFQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAA1YIkKAgAAAAEACwAAAFRhcmdldFZhbHVlAQHsFwMAAAAANQAAAFRhcmdl" +
           "dFZhbHVlIGlzIHRoZSB0YXJnZXRlZCBkaXNjcmV0ZSBzZXQtcG9pbnQgdmFsdWUuAC8BAEgJ7BcAAAAH" +
           "/////wMD/////wEAAAA3YIkKAgAAAAAACwAAAEVudW1TdHJpbmdzAQEOGAMAAAAAOwAAAExpc3Qgb2Yg" +
           "aHVtYW4gcmVhZGFibGUgaWRlbnRpZmllcnMgZm9yIHRoZSBkaXNjcmV0ZSB2YWx1ZXMuAC4ARA4YAAAA" +
           "FQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new MultiStateDiscreteState<uint> CurrentValue
        {
            get { return (MultiStateDiscreteState<uint>)base.CurrentValue; }
            set { base.CurrentValue = value; }
        }

        /// <remarks />
        public new MultiStateDiscreteState<uint> TargetValue
        {
            get { return (MultiStateDiscreteState<uint>)base.TargetValue; }
            set { base.TargetValue = value; }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

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
                case Opc.Ua.LADS.BrowseNames.CurrentValue:
                {
                    if (createOrReplace)
                    {
                        if (CurrentValue == null)
                        {
                            if (replacement == null)
                            {
                                CurrentValue = new MultiStateDiscreteState<uint>(this);
                            }
                            else
                            {
                                CurrentValue = (MultiStateDiscreteState<uint>)replacement;
                            }
                        }
                    }

                    instance = CurrentValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TargetValue:
                {
                    if (createOrReplace)
                    {
                        if (TargetValue == null)
                        {
                            if (replacement == null)
                            {
                                TargetValue = new MultiStateDiscreteState<uint>(this);
                            }
                            else
                            {
                                TargetValue = (MultiStateDiscreteState<uint>)replacement;
                            }
                        }
                    }

                    instance = TargetValue;
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
        #endregion
    }
    #endif
    #endregion

    #region TwoStateDiscreteControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_TwoStateDiscreteControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TwoStateDiscreteControlFunctionTypeState : DiscreteControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public TwoStateDiscreteControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.TwoStateDiscreteControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKwAAAFR3b1N0YXRl" +
           "RGlzY3JldGVDb250cm9sRnVuY3Rpb25UeXBlSW5zdGFuY2UBARIEAQESBBIEAAD/////BQAAADVgiQoC" +
           "AAAAAQAJAAAASXNFbmFibGVkAQFyFwMAAAAAxgAAAElzRW5hYmxlZCBpbmRpY2F0ZXMgd2hldGhlciB0" +
           "aGUgRnVuY3Rpb24gY2FuIGN1cnJlbnRseSBiZSBleGVjdXRlZCBvbiB0aGUgRGV2aWNlLiBBIEZ1bmN0" +
           "aW9uIG1heSBiZSBkaXNhYmxlZCBmb3Igc2V2ZXJhbCByZWFzb25zIGluY2x1ZGluZyBub3QgbGljZW5z" +
           "ZWQsIG1pc3NpbmcgaGFyZHdhcmUgbW9kdWxlcywgb3IgbWlzc2luZyBzdXBwbGllcwAuAERyFwAAAAH/" +
           "////AwP/////AAAAACRggAoBAAAAAQALAAAAT3BlcmF0aW9uYWwBAbYTAwAAAADcAAAAT3BlcmF0aW9u" +
           "YWwgaXMgYSBGdW5jdGlvbmFsR3JvdXAgdGhhdCBzaGFsbCBvcmdhbml6ZSB0aGUgQ3VycmVudFN0YXRl" +
           "IHByb3BlcnR5IG9mIHRoZSBTdGF0ZU1hY2hpbmUgYW5kIGFsbCBpdHMgcmVtb3RlIGludm9jYWJsZSBN" +
           "ZXRob2RzLiBGdXJ0aGVybW9yZSwgaXQgc2hhbGwgb3JnYW5pemUgYXQgbGVhc3QgdGhlIEN1cnJlbnRW" +
           "YWx1ZSBhbmQgVGFyZ2V0VmFsdWUgdmFyaWFibGVzLgAvAQLtA7YTAAD/////AQAAAARhggoEAAAAAQAE" +
           "AAAAU3RvcAEBdBsAIwEBdBt0GwAAAQH/////AAAAACRggAoBAAAAAQAUAAAAQ29udHJvbEZ1bmN0aW9u" +
           "U3RhdGUBARgUAwAAAAB4AAAAQ29udHJvbEZ1bmN0aW9uU3RhdGUgaXMgYSBzdGF0ZSBtYWNoaW5lIHdo" +
           "aWNoIHJlcHJlc2VudHMgdGhlIGV4ZWN1dGlvbiBzdGF0ZSBhbmQgY29udHJvbHMgdGhlIGV4ZWN1dGlv" +
           "biBvZiB0aGUgRnVuY3Rpb24uAC8BARQEGBQAAP////8EAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3Rh" +
           "dGUBAdQXAC8BAMgK1BcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGaFwAuAESaFwAA" +
           "ABH/////AQH/////AAAAADdgiQoCAAAAAAAPAAAAQXZhaWxhYmxlU3RhdGVzAQFJGQMAAAAALgAAAFNl" +
           "dCBvZiBzdGF0ZXMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlvbi4ALwA/SRkAAAARAQAAAAEA" +
           "AAABAAAAAQH/////AAAAADdgiQoCAAAAAAAUAAAAQXZhaWxhYmxlVHJhbnNpdGlvbnMBAUgZAwAAAAAz" +
           "AAAAU2V0IG9mIHRyYW5zaXRpb25zIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8AP0gZ" +
           "AAAAEQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEAFAAAAFN0YXJ0V2l0aFRhcmdldFZhbHVl" +
           "AQGOGwAvAQFhG44bAAABAf////8BAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpRgDAAAA" +
           "AFUAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDQ6RnVuY3Rp" +
           "b25TdGF0ZU1hY2hpbmVUeXBlVHlwZS40OlN0YXJ0AC4ARKUYAACWAQAAAAEAKgEBcgAAAAsAAABUYXJn" +
           "ZXRWYWx1ZQAB/////wAAAAACVAAAAChPcHRpb25hbCkgVGhlIHZhbHVlIGNhbiB1c2UgdG8gc2V0IHRo" +
           "ZSB0YXJnZXQgdmFsdWUgcGFyYWxsZWwgd2l0aCB0aGUgc3RhcnQgbWV0aG9kLgEAKAEBAAAAAQAAAAEA" +
           "AAABAf////8AAAAANWCJCgIAAAABAAwAAABDdXJyZW50VmFsdWUBAbIXAwAAAAAxAAAAQ3VycmVudFZh" +
           "bHVlIGlzIGEgY3VycmVudCBkaXNjcmV0ZSBwcm9jZXNzIHZhbHVlLgAvAQBFCbIXAAAAAf////8BAf//" +
           "//8CAAAANWCpCgIAAAAAAAoAAABGYWxzZVN0YXRlAQH6FwMAAAAALQAAAEh1bWFuIHJlYWRhYmxlIGlk" +
           "ZW50aWZpZXIgb2YgdGhlIHZhbHVlIGZhbHNlLgAuAET6FwAAFQIDAAAAb2ZmABX/////AQH/////AAAA" +
           "ADVgqQoCAAAAAAAJAAAAVHJ1ZVN0YXRlAQH8FwMAAAAALAAAAEh1bWFuIHJlYWRhYmxlIGlkZW50aWZp" +
           "ZXIgb2YgdGhlIHZhbHVlIHRydWUuAC4ARPwXAAAVAgIAAABvbgAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEACwAAAFRhcmdldFZhbHVlAQH3FwMAAAAANQAAAFRhcmdldFZhbHVlIGlzIHRoZSB0YXJnZXRlZCBk" +
           "aXNjcmV0ZSBzZXQtcG9pbnQgdmFsdWUuAC8BAEUJ9xcAAAAB/////wMD/////wIAAAA1YKkKAgAAAAAA" +
           "CgAAAEZhbHNlU3RhdGUBAQsYAwAAAAAtAAAASHVtYW4gcmVhZGFibGUgaWRlbnRpZmllciBvZiB0aGUg" +
           "dmFsdWUgZmFsc2UuAC4ARAsYAAAVAgMAAABvZmYAFf////8BAf////8AAAAANWCpCgIAAAAAAAkAAABU" +
           "cnVlU3RhdGUBAQwYAwAAAAAsAAAASHVtYW4gcmVhZGFibGUgaWRlbnRpZmllciBvZiB0aGUgdmFsdWUg" +
           "dHJ1ZS4ALgBEDBgAABUCAgAAAG9uABX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new TwoStateDiscreteState CurrentValue
        {
            get { return (TwoStateDiscreteState)base.CurrentValue; }
            set { base.CurrentValue = value; }
        }

        /// <remarks />
        public new TwoStateDiscreteState TargetValue
        {
            get { return (TwoStateDiscreteState)base.TargetValue; }
            set { base.TargetValue = value; }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

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
                case Opc.Ua.LADS.BrowseNames.CurrentValue:
                {
                    if (createOrReplace)
                    {
                        if (CurrentValue == null)
                        {
                            if (replacement == null)
                            {
                                CurrentValue = new TwoStateDiscreteState(this);
                            }
                            else
                            {
                                CurrentValue = (TwoStateDiscreteState)replacement;
                            }
                        }
                    }

                    instance = CurrentValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TargetValue:
                {
                    if (createOrReplace)
                    {
                        if (TargetValue == null)
                        {
                            if (replacement == null)
                            {
                                TargetValue = new TwoStateDiscreteState(this);
                            }
                            else
                            {
                                TargetValue = (TwoStateDiscreteState)replacement;
                            }
                        }
                    }

                    instance = TargetValue;
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
        #endregion
    }
    #endif
    #endregion

    #region BaseSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_BaseSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BaseSensorFunctionTypeState : FunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public BaseSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.BaseSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }
        }

        #region Initialization String
        private const string Configuration_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEADQAAAENvbmZpZ3Vy" +
           "YXRpb24BAaYTAwAAAABPAAAAQ29uZmlndXJhdGlvbiBpcyB1c2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRl" +
           "cnMgZm9yIGNvbmZpZ3VyYXRpb24gb2YgdGhlIEZ1bmN0aW9uLgAvAQLtA6YTAAD/////AQAAADVgiQoC" +
           "AAAAAQAJAAAASXNFbmFibGVkAQGGFwMAAAAATAAAAERldGVybW5lcyB3aHRlaGVyIHRoaXMgZnVuY3Rp" +
           "b24gaXMgY3VycmVudGx5IGVuYWJsZWQgKHJlYWR5IHRvIGJlIHV0aWxpemVkKS4AIwBEhhcAAAAB////" +
           "/wMD/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHgAAAEJhc2VTZW5z" +
           "b3JGdW5jdGlvblR5cGVJbnN0YW5jZQEB7QMBAe0D7QMAAP////8CAAAAJGCACgEAAAABAA0AAABDb25m" +
           "aWd1cmF0aW9uAQGmEwMAAAAATwAAAENvbmZpZ3VyYXRpb24gaXMgdXNlZCB0byBvcmdhbml6ZSBwYXJh" +
           "bWV0ZXJzIGZvciBjb25maWd1cmF0aW9uIG9mIHRoZSBGdW5jdGlvbi4ALwEC7QOmEwAA/////wEAAAA1" +
           "YIkKAgAAAAEACQAAAElzRW5hYmxlZAEBhhcDAAAAAEwAAABEZXRlcm1uZXMgd2h0ZWhlciB0aGlzIGZ1" +
           "bmN0aW9uIGlzIGN1cnJlbnRseSBlbmFibGVkIChyZWFkeSB0byBiZSB1dGlsaXplZCkuACMARIYXAAAA" +
           "Af////8DA/////8AAAAANWCJCgIAAAABAAkAAABJc0VuYWJsZWQBAXIXAwAAAADGAAAASXNFbmFibGVk" +
           "IGluZGljYXRlcyB3aGV0aGVyIHRoZSBGdW5jdGlvbiBjYW4gY3VycmVudGx5IGJlIGV4ZWN1dGVkIG9u" +
           "IHRoZSBEZXZpY2UuIEEgRnVuY3Rpb24gbWF5IGJlIGRpc2FibGVkIGZvciBzZXZlcmFsIHJlYXNvbnMg" +
           "aW5jbHVkaW5nIG5vdCBsaWNlbnNlZCwgbWlzc2luZyBoYXJkd2FyZSBtb2R1bGVzLCBvciBtaXNzaW5n" +
           "IHN1cHBsaWVzAC4ARHIXAAAAAf////8DA/////8AAAAA";
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

    #region AnalogScalarSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogScalarSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogScalarSensorFunctionTypeState : AnalogSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogScalarSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogScalarSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJgAAAEFuYWxvZ1Nj" +
           "YWxhclNlbnNvckZ1bmN0aW9uVHlwZUluc3RhbmNlAQH4AwEB+AP4AwAA/////wQAAAA1YIkKAgAAAAEA" +
           "CQAAAElzRW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIEZ1" +
           "bmN0aW9uIGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERldmljZS4gQSBGdW5jdGlvbiBt" +
           "YXkgYmUgZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRpbmcgbm90IGxpY2Vuc2VkLCBt" +
           "aXNzaW5nIGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxpZXMALgBEchcAAAAB/////wMD" +
           "/////wAAAAAkYIAKAQAAAAEACwAAAE9wZXJhdGlvbmFsAQGgEwMAAAAAOwAAAFVzZWQgdG8gb3JnYW5p" +
           "emUgcGFyYW1ldGVycyBmb3Igb3BlcmF0aW9uIG9mIHRoaXMgZnVuY3Rpb24uAC8BAu0DoBMAAP////8A" +
           "AAAANWCJCgIAAAABAAgAAABSYXdWYWx1ZQEBlxcDAAAAAGwAAABSYXdWYWx1ZSBpcyB0aGUgcmF3IHZh" +
           "bHVlIG1lYXN1cmVkIGF0IHRoZSBTZW5zb3IgZWxlbWVudCwgc3VjaCBhcyB0aGUgTmVybnN0IHZvbHRh" +
           "Z2Ugb2YgYSBwSCBTZW5zb3IgZWxlbWVudC4ALwEAokSXFwAAAAv/////AQH/////AgAAABVgiQgCAAAA" +
           "AAAHAAAARVVSYW5nZQEBAAAALgBEAQB0A/////8BAf////8AAAAAFWCJCAIAAAAAABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAQEAAAAuAEQBAHcD/////wEB/////wAAAAA1YIkKAgAAAAEACwAAAFNlbnNvclZhbHVl" +
           "AQGRFwMAAAAAUAAAAFNlbnNvclZhbHVlIGlzIHRoZSBjYWxpYnJhdGVkIGFuZCBvcHRpb25hbGx5IGNv" +
           "bXBlbnNhdGVkL2ZpbHRlcmVkIHByb2Nlc3MgdmFsdWUuAC8BAKJEkRcAAAAL/////wEB/////wIAAAAV" +
           "YIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////AQH/////AAAAABVgiQgCAAAAAAAQAAAA" +
           "RW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new AnalogUnitRangeState<double> SensorValue
        {
            get { return (AnalogUnitRangeState<double>)base.SensorValue; }
            set { base.SensorValue = value; }
        }

        /// <remarks />
        public new AnalogUnitRangeState<double> RawValue
        {
            get { return (AnalogUnitRangeState<double>)base.RawValue; }
            set { base.RawValue = value; }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

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
                case Opc.Ua.LADS.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                SensorValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = SensorValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.RawValue:
                {
                    if (createOrReplace)
                    {
                        if (RawValue == null)
                        {
                            if (replacement == null)
                            {
                                RawValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                RawValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = RawValue;
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
        #endregion
    }
    #endif
    #endregion

    #region DiscreteSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_DiscreteSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DiscreteSensorFunctionTypeState : BaseSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public DiscreteSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.DiscreteSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIgAAAERpc2NyZXRl" +
           "U2Vuc29yRnVuY3Rpb25UeXBlSW5zdGFuY2UBAfQDAQH0A/QDAAD/////AwAAADVgiQoCAAAAAQAJAAAA" +
           "SXNFbmFibGVkAQFyFwMAAAAAxgAAAElzRW5hYmxlZCBpbmRpY2F0ZXMgd2hldGhlciB0aGUgRnVuY3Rp" +
           "b24gY2FuIGN1cnJlbnRseSBiZSBleGVjdXRlZCBvbiB0aGUgRGV2aWNlLiBBIEZ1bmN0aW9uIG1heSBi" +
           "ZSBkaXNhYmxlZCBmb3Igc2V2ZXJhbCByZWFzb25zIGluY2x1ZGluZyBub3QgbGljZW5zZWQsIG1pc3Np" +
           "bmcgaGFyZHdhcmUgbW9kdWxlcywgb3IgbWlzc2luZyBzdXBwbGllcwAuAERyFwAAAAH/////AwP/////" +
           "AAAAADVgiQoCAAAAAQALAAAAU2Vuc29yVmFsdWUBAY8XAwAAAAAsAAAAU2Vuc29yVmFsdWUgaXMgYSBk" +
           "aXNjcmV0ZSBtZWFzdXJlbWVudCB2YWx1ZS4ALwEARAmPFwAAABj/////AQH/////AAAAACRggAoBAAAA" +
           "AQALAAAAT3BlcmF0aW9uYWwBAcUTAwAAAAA7AAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZv" +
           "ciBvcGVyYXRpb24gb2YgdGhpcyBmdW5jdGlvbi4ALwEC7QPFEwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState SensorValue
        {
            get
            {
                return m_sensorValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sensorValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sensorValue = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_sensorValue != null)
            {
                children.Add(m_sensorValue);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
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
                case Opc.Ua.LADS.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new DiscreteItemState(this);
                            }
                            else
                            {
                                SensorValue = (DiscreteItemState)replacement;
                            }
                        }
                    }

                    instance = SensorValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Operational;
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
        private DiscreteItemState m_sensorValue;
        private FunctionalGroupTypeState m_operational;
        #endregion
    }
    #endif
    #endregion

    #region CoverFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_CoverFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CoverFunctionTypeState : FunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public CoverFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.CoverFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGQAAAENvdmVyRnVu" +
           "Y3Rpb25UeXBlSW5zdGFuY2UBAfMDAQHzA/MDAAD/////AwAAADVgiQoCAAAAAQAJAAAASXNFbmFibGVk" +
           "AQFyFwMAAAAAxgAAAElzRW5hYmxlZCBpbmRpY2F0ZXMgd2hldGhlciB0aGUgRnVuY3Rpb24gY2FuIGN1" +
           "cnJlbnRseSBiZSBleGVjdXRlZCBvbiB0aGUgRGV2aWNlLiBBIEZ1bmN0aW9uIG1heSBiZSBkaXNhYmxl" +
           "ZCBmb3Igc2V2ZXJhbCByZWFzb25zIGluY2x1ZGluZyBub3QgbGljZW5zZWQsIG1pc3NpbmcgaGFyZHdh" +
           "cmUgbW9kdWxlcywgb3IgbWlzc2luZyBzdXBwbGllcwAuAERyFwAAAAH/////AwP/////AAAAACRggAoB" +
           "AAAAAQALAAAAT3BlcmF0aW9uYWwBAcgTAwAAAABKAAAAT3BlcmF0aW9uYWwgb3JnYW5pemVzIHRoZSBt" +
           "ZXRob2RzIGFuZCBjdXJyZW50IHN0YXRlIG9mIHRoZSBjb3ZlciBmdW5jdGlvbi4ALwEC7QPIEwAA////" +
           "/wAAAAAkYIAKAQAAAAEACgAAAENvdmVyU3RhdGUBAb8TAwAAAADCAAAAaGUgQ292ZXJTdGF0ZU1hY2hp" +
           "bmVUeXBlIGlzIHVzZWQgdG8gY29udHJvbCB0aGUgbGlkLCBkb29yLCBvciBjb3ZlciBvZiBhIGxhYm9y" +
           "YXRvcnkgZGV2aWNlLiBPbmUgRGV2aWNlIG1heSBoYXZlIGFueSBhcmJpdHJhcnkgbnVtYmVyIG9mIGxp" +
           "ZHMsIGRvb3JzLCBjb3ZlcnMgYW5kIHRoZWlyIGNvcnJlc3BvbmRpbmcgQ292ZXJGdW5jdGlvbi4ALwEB" +
           "8gO/EwAA/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBqhgALwEAyAqqGAAAABX/////" +
           "AQH/////AQAAABVgiQgCAAAAAAACAAAASWQBAQAAAC4ARAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FunctionalGroupTypeState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }

        /// <remarks />
        public CoverStateMachineTypeState CoverState
        {
            get
            {
                return m_coverState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coverState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coverState = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_operational != null)
            {
                children.Add(m_operational);
            }

            if (m_coverState != null)
            {
                children.Add(m_coverState);
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
                case Opc.Ua.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Operational;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CoverState:
                {
                    if (createOrReplace)
                    {
                        if (CoverState == null)
                        {
                            if (replacement == null)
                            {
                                CoverState = new CoverStateMachineTypeState(this);
                            }
                            else
                            {
                                CoverState = (CoverStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = CoverState;
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
        private FunctionalGroupTypeState m_operational;
        private CoverStateMachineTypeState m_coverState;
        #endregion
    }
    #endif
    #endregion

    #region ProgramManagerTypeState Class
    #if (!OPCUA_EXCLUDE_ProgramManagerTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramManagerTypeState : TopologyElementTypeState
    {
        #region Constructors
        /// <remarks />
        public ProgramManagerTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ProgramManagerType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Download != null)
            {
                Download.Initialize(context, Download_InitializationString);
            }

            if (Remove != null)
            {
                Remove.Initialize(context, Remove_InitializationString);
            }

            if (Upload != null)
            {
                Upload.Initialize(context, Upload_InitializationString);
            }
        }

        #region Initialization String
        private const string Download_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACAAAAERvd25sb2Fk" +
           "AQGLGwAvAQGLG4sbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBkRgALgBE" +
           "kRgAAJYBAAAAAQAqAQFQAAAACgAAAFRlbXBsYXRlSWQADP////8AAAAAAjMAAABVbmlxdWUgaWRlbnRp" +
           "ZmllciBvZiB0aGUgdGVtcGxhdGUgdG8gYmUgZG93bmxvYWRlZC4BACgBAQAAAAEAAAABAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGSGAAuAESSGAAAlgIAAAABACoBAVsAAAAU" +
           "AAAAQWRkaXRpb25hbFBhcmFtZXRlcnMBAbsLAQAAAAEAAAAAAAAAAi4AAABBZGRpdGlvbmFsIHByb3Bl" +
           "cnRpZXMgb2YgdGhlIHByb2dyYW0gdGVtcGxhdGUuAQAqAQE0AAAABAAAAERhdGEAD/////8AAAAAAh0A" +
           "AABPcGFxdWUgcHJvZ3JhbSB0ZW1wbGF0ZSBkYXRhLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAA";

        private const string Remove_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABgAAAFJlbW92ZQEB" +
           "jBsALwEBjBuMGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZMYAC4ARJMY" +
           "AACWAQAAAAEAKgEBTQAAAAoAAABUZW1wbGF0ZUlkAAz/////AAAAAAIwAAAAVW5pcXVlIGlkZW50aWZp" +
           "ZXIgb2YgdGhlIHRlbXBsYXRlIHRvIGJlIHJlbW92ZWQuAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";

        private const string Upload_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABgAAAFVwbG9hZAEB" +
           "jRsALwEBjRuNGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZQYAC4ARJQY" +
           "AACWAgAAAAEAKgEBWwAAABQAAABBZGRpdGlvbmFsUGFyYW1ldGVycwEBuwsBAAAAAQAAAAAAAAACLgAA" +
           "AEFkZGl0aW9uYWwgcHJvcGVydGllcyBvZiB0aGUgcHJvZ3JhbSB0ZW1wbGF0ZS4BACoBATQAAAAEAAAA" +
           "RGF0YQAP/////wAAAAACHQAAAE9wYXF1ZSBwcm9ncmFtIHRlbXBsYXRlIGRhdGEuAQAoAQEAAAABAAAA" +
           "AgAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBkBcALgBEkBcAAJYBAAAA" +
           "AQAqAQG6AAAACgAAAFRlbXBsYXRlSWQADP////8AAAAAAp0AAABUaGUgdW5pcXVlIGlkZW50aWZpZXIg" +
           "b2YgdGhlIHRlbXBsYXRlIHdoaWNoIG1pZ2h0IGJlIGdlbmVyYXRlZCBieSB0aGUgZGV2aWNlL2Z1bmN0" +
           "aW9uYWwtdW5pdCBpdHNlbGYgb3IgbWlnaHQgYmUgcHJvdmlkZWQgYXMgZWxlbWVudCBvZiB0aGUgb3Bh" +
           "cXVlIGlucHV0IGRhdGEuAQAoAQEAAAABAAAAAQAAAAMD/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAGgAAAFByb2dyYW1N" +
           "YW5hZ2VyVHlwZUluc3RhbmNlAQHuAwEB7gPuAwAA/////wYAAAAkYIAKAQAAAAEADQAAAEFjdGl2ZVBy" +
           "b2dyYW0BAUYUAwAAAAArAQAAVGhlIEFjdGl2ZVByb2dyYW0gc3BlY2lmaWVzIHRoZSBjdXJyZW50IHN0" +
           "YXRlIG9mIG9wZXJhdGlvbiBvZiBhIEZ1bmN0aW9uYWxVbml0LiBJdCBwcm92aWRlcyBjb250ZXh0IGFu" +
           "ZCBpbmZvcm1hdGlvbiBhYm91dCB0aGUgY3VycmVudGx5IGFjdGl2ZSBwcm9ncmFtIG9uIHRoZSBkZXZp" +
           "Y2UuIFRoaXMgYWxsb3dzIHVzZXJzIHRvIGZvbGxvdyB0aGUgcHJvZ3Jlc3Mgb2YgYSBwcm9ncmFtIHJ1" +
           "biBpbiBhIHN0YW5kYXJkaXplZCBmYXNoaW9uIGJ5IG9yZ2FuaXNpbmcgc3RlcHMgaW50byBhIGZsYXQs" +
           "IGxpbmVhciBzZXF1ZW5jZS4ALwEBEARGFAAA/////wAAAAAkYIAKAQAAAAEAEgAAAFByb2dyYW1UZW1w" +
           "bGF0ZVNldAEBnBMDAAAAAG0AAABUaGUgUHJvZ3JhbVRlbXBsYXRlU2V0VHlwZSBpcyB1c2VkIGZvciBv" +
           "cmdhbmlzaW5nIFByb2dyYW1UZW1wbGF0ZVR5cGUgb2JqZWN0cyBpbiBhbiB1bm9yZGVyZWQgbGlzdCBz" +
           "dHJ1Y3R1cmUuAC8BAfsDnBMAAP////8BAAAANWCpCgIAAAAAAAsAAABOb2RlVmVyc2lvbgEBcRgDAAAA" +
           "AKUAAABOb2RlVmVyc2lvbiBhbmQgdGhlIEdlbmVyYWxNb2RlbENoYW5nZUV2ZW50VHlwZSBhcmUgbWVj" +
           "aGFuaXNtcyB0byBub3RpZnkgY2xpZW50cyB0aGF0IHRoZSBjb250ZW50IG9mIHRoZSBzZXQgaGFzIGNo" +
           "YW5nZWQgYW5kIHNoYWxsIGJlIHVzZWQgYXMgZGVmaW5lZCBpbiBPUEMgMTAwMDAtMy4ALgBEcRgAAAwD" +
           "AAAATmFOAAz/////AQH/////AAAAAARhggoEAAAAAQAIAAAARG93bmxvYWQBAYsbAC8BAYsbixsAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGRGAAuAESRGAAAlgEAAAABACoBAVAA" +
           "AAAKAAAAVGVtcGxhdGVJZAAM/////wAAAAACMwAAAFVuaXF1ZSBpZGVudGlmaWVyIG9mIHRoZSB0ZW1w" +
           "bGF0ZSB0byBiZSBkb3dubG9hZGVkLgEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAZIYAC4ARJIYAACWAgAAAAEAKgEBWwAAABQAAABBZGRpdGlvbmFsUGFy" +
           "YW1ldGVycwEBuwsBAAAAAQAAAAAAAAACLgAAAEFkZGl0aW9uYWwgcHJvcGVydGllcyBvZiB0aGUgcHJv" +
           "Z3JhbSB0ZW1wbGF0ZS4BACoBATQAAAAEAAAARGF0YQAP/////wAAAAACHQAAAE9wYXF1ZSBwcm9ncmFt" +
           "IHRlbXBsYXRlIGRhdGEuAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAEABgAAAFJlbW92" +
           "ZQEBjBsALwEBjBuMGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZMYAC4A" +
           "RJMYAACWAQAAAAEAKgEBTQAAAAoAAABUZW1wbGF0ZUlkAAz/////AAAAAAIwAAAAVW5pcXVlIGlkZW50" +
           "aWZpZXIgb2YgdGhlIHRlbXBsYXRlIHRvIGJlIHJlbW92ZWQuAQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEABgAAAFVwbG9hZAEBjRsALwEBjRuNGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAZQYAC4ARJQYAACWAgAAAAEAKgEBWwAAABQAAABBZGRpdGlvbmFsUGFyYW1l" +
           "dGVycwEBuwsBAAAAAQAAAAAAAAACLgAAAEFkZGl0aW9uYWwgcHJvcGVydGllcyBvZiB0aGUgcHJvZ3Jh" +
           "bSB0ZW1wbGF0ZS4BACoBATQAAAAEAAAARGF0YQAP/////wAAAAACHQAAAE9wYXF1ZSBwcm9ncmFtIHRl" +
           "bXBsYXRlIGRhdGEuAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBkBcALgBEkBcAAJYBAAAAAQAqAQG6AAAACgAAAFRlbXBsYXRlSWQADP////8AAAAAAp0A" +
           "AABUaGUgdW5pcXVlIGlkZW50aWZpZXIgb2YgdGhlIHRlbXBsYXRlIHdoaWNoIG1pZ2h0IGJlIGdlbmVy" +
           "YXRlZCBieSB0aGUgZGV2aWNlL2Z1bmN0aW9uYWwtdW5pdCBpdHNlbGYgb3IgbWlnaHQgYmUgcHJvdmlk" +
           "ZWQgYXMgZWxlbWVudCBvZiB0aGUgb3BhcXVlIGlucHV0IGRhdGEuAQAoAQEAAAABAAAAAQAAAAMD////" +
           "/wAAAAAkYIAKAQAAAAEACQAAAFJlc3VsdFNldAEBmxMDAAAAAFsAAABUaGUgUmVzdWx0U2V0VHlwZSBp" +
           "cyB1c2VkIGZvciBvcmdhbmlzaW5nIFJlc3VsdFR5cGUgb2JqZWN0cyBpbiBhbiB1bm9yZGVyZWQgbGlz" +
           "dCBzdHJ1Y3R1cmUuAC8BAfwDmxMAAP////8BAAAANWCpCgIAAAAAAAsAAABOb2RlVmVyc2lvbgEBmRcD" +
           "AAAAAKUAAABOb2RlVmVyc2lvbiBhbmQgdGhlIEdlbmVyYWxNb2RlbENoYW5nZUV2ZW50VHlwZSBhcmUg" +
           "bWVjaGFuaXNtcyB0byBub3RpZnkgY2xpZW50cyB0aGF0IHRoZSBjb250ZW50IG9mIHRoZSBzZXQgaGFz" +
           "IGNoYW5nZWQgYW5kIHNoYWxsIGJlIHVzZWQgYXMgZGVmaW5lZCBpbiBPUEMgMTAwMDAtMy4ALgBEmRcA" +
           "AAwDAAAATmFOAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ActiveProgramTypeState ActiveProgram
        {
            get
            {
                return m_activeProgram;
            }

            set
            {
                if (!Object.ReferenceEquals(m_activeProgram, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeProgram = value;
            }
        }

        /// <remarks />
        public ProgramTemplateSetTypeState ProgramTemplateSet
        {
            get
            {
                return m_programTemplateSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programTemplateSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programTemplateSet = value;
            }
        }

        /// <remarks />
        public DownloadMethodState Download
        {
            get
            {
                return m_downloadMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_downloadMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_downloadMethod = value;
            }
        }

        /// <remarks />
        public RemoveMethodState Remove
        {
            get
            {
                return m_removeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_removeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_removeMethod = value;
            }
        }

        /// <remarks />
        public UploadMethodState Upload
        {
            get
            {
                return m_uploadMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uploadMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uploadMethod = value;
            }
        }

        /// <remarks />
        public ResultSetTypeState ResultSet
        {
            get
            {
                return m_resultSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resultSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resultSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_activeProgram != null)
            {
                children.Add(m_activeProgram);
            }

            if (m_programTemplateSet != null)
            {
                children.Add(m_programTemplateSet);
            }

            if (m_downloadMethod != null)
            {
                children.Add(m_downloadMethod);
            }

            if (m_removeMethod != null)
            {
                children.Add(m_removeMethod);
            }

            if (m_uploadMethod != null)
            {
                children.Add(m_uploadMethod);
            }

            if (m_resultSet != null)
            {
                children.Add(m_resultSet);
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
                case Opc.Ua.LADS.BrowseNames.ActiveProgram:
                {
                    if (createOrReplace)
                    {
                        if (ActiveProgram == null)
                        {
                            if (replacement == null)
                            {
                                ActiveProgram = new ActiveProgramTypeState(this);
                            }
                            else
                            {
                                ActiveProgram = (ActiveProgramTypeState)replacement;
                            }
                        }
                    }

                    instance = ActiveProgram;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ProgramTemplateSet:
                {
                    if (createOrReplace)
                    {
                        if (ProgramTemplateSet == null)
                        {
                            if (replacement == null)
                            {
                                ProgramTemplateSet = new ProgramTemplateSetTypeState(this);
                            }
                            else
                            {
                                ProgramTemplateSet = (ProgramTemplateSetTypeState)replacement;
                            }
                        }
                    }

                    instance = ProgramTemplateSet;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Download:
                {
                    if (createOrReplace)
                    {
                        if (Download == null)
                        {
                            if (replacement == null)
                            {
                                Download = new DownloadMethodState(this);
                            }
                            else
                            {
                                Download = (DownloadMethodState)replacement;
                            }
                        }
                    }

                    instance = Download;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Remove:
                {
                    if (createOrReplace)
                    {
                        if (Remove == null)
                        {
                            if (replacement == null)
                            {
                                Remove = new RemoveMethodState(this);
                            }
                            else
                            {
                                Remove = (RemoveMethodState)replacement;
                            }
                        }
                    }

                    instance = Remove;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Upload:
                {
                    if (createOrReplace)
                    {
                        if (Upload == null)
                        {
                            if (replacement == null)
                            {
                                Upload = new UploadMethodState(this);
                            }
                            else
                            {
                                Upload = (UploadMethodState)replacement;
                            }
                        }
                    }

                    instance = Upload;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ResultSet:
                {
                    if (createOrReplace)
                    {
                        if (ResultSet == null)
                        {
                            if (replacement == null)
                            {
                                ResultSet = new ResultSetTypeState(this);
                            }
                            else
                            {
                                ResultSet = (ResultSetTypeState)replacement;
                            }
                        }
                    }

                    instance = ResultSet;
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
        private ActiveProgramTypeState m_activeProgram;
        private ProgramTemplateSetTypeState m_programTemplateSet;
        private DownloadMethodState m_downloadMethod;
        private RemoveMethodState m_removeMethod;
        private UploadMethodState m_uploadMethod;
        private ResultSetTypeState m_resultSet;
        #endregion
    }
    #endif
    #endregion

    #region TimerControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_TimerControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TimerControlFunctionTypeState : BaseControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public TimerControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.TimerControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (DifferenceValue != null)
            {
                DifferenceValue.Initialize(context, DifferenceValue_InitializationString);
            }

            if (TargetValue != null)
            {
                TargetValue.Initialize(context, TargetValue_InitializationString);
            }

            if (CurrentValue != null)
            {
                CurrentValue.Initialize(context, CurrentValue_InitializationString);
            }
        }

        #region Initialization String
        private const string DifferenceValue_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////91YIkKAgAAAAEADwAAAERpZmZlcmVu" +
           "Y2VWYWx1ZQEBfBcDAAAAAA4AAABSZW1haW5pbmcgdGltZQMAAAAApAAAAFRoZSBEaWZmZXJlbmNlVmFs" +
           "dWUgKGFrYSByZW1haW5pbmcgdGltZSkgaXMgY2FsY3VsYXRlZCBieSBzdWJ0cmFjdGluZyB0aGUgQ3Vy" +
           "cmVudFZhbHVlIGZyb20gdGhlIFRhcmdldFZhbHVlLiBUaHVzLCBpdCBjb3VudHMgZG93bndhcmRzIGZy" +
           "b20gdGhlIFRhcmdldFZhbHVlIHRvIHplcm8uAC8BAKJEfBcAAAEAIgH/////AQH/////AgAAABVgiQgC" +
           "AAAAAAAHAAAARVVSYW5nZQEBAAAALgBEAQB0A/////8BAf////8AAAAAFWCpCgIAAAAAABAAAABFbmdp" +
           "bmVlcmluZ1VuaXRzAQEEGAAuAEQEGAAAFgEAeQMBTgAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRp" +
           "b24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdDYyQwACAgAAAG1zAgsAAABtaWxsaXNlY29uZAEAdwP/////" +
           "AQH/////AAAAAA==";

        private const string TargetValue_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////91YIkKAgAAAAEACwAAAFRhcmdldFZh" +
           "bHVlAQGSFwMAAAAACwAAAFRhcmdldCB0aW1lAwAAAAAOAQAAVGhlIHRpbWVyJ3MgdGFyZ2V0IHRpbWUu" +
           "IEFzIHNvb24gYXMgdGhlIEN1cnJlbnRWYWx1ZSByZWFjaGVzIHRoZSBUYXJnZXRWYWx1ZSwgdGhlIEN1" +
           "cnJlbnRTdGF0ZSBvZiB0aGUgVGltZXJGdW5jdGlvbiBhdXRvbWF0aWNhbGx5IHRyYW5zaXRpb25zIHRv" +
           "IE9mZi4gVGhpcyBpcyB0eXBpY2FsbHkgYWNjb21wYW5pZWQgYnkgc29tZSAoaW50ZXJuYWwpIGFjdGlv" +
           "bi9lZmZlY3QsIHN1Y2ggYXMgc3RvcHBpbmcgdGhlIGV4ZWN1dGlvbiBvZiBhIEZ1bmN0aW9uIG9yIHNp" +
           "bWlsYXIuAC8BAKJEkhcAAAEAIgH/////AwP/////AgAAABVgiQgCAAAAAAAHAAAARVVSYW5nZQEBAAAA" +
           "LgBEAQB0A/////8BAf////8AAAAAFWCpCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQERGAAuAEQR" +
           "GAAAFgEAeQMBTgAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2Nl" +
           "ZmFjdDYyQwACAgAAAG1zAgsAAABtaWxsaXNlY29uZAEAdwP/////AQH/////AAAAAA==";

        private const string CurrentValue_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////91YIkKAgAAAAEADAAAAEN1cnJlbnRW" +
           "YWx1ZQEBkxcDAAAAAAwAAABFbGFwc2VkIHRpbWUDAAAAAH4AAABPbmNlIHN0YXJ0ZWQsIHRoZSBDdXJy" +
           "ZW50VmFsdWUgKGFrYSBlbGFwc2VkIHRpbWUpIGNvdW50cyB1cHdhcmRzIGZyb20gemVybyB1bnRpbCBp" +
           "dCByZWFjaGVzIHRoZSBUYXJnZXRWYWx1ZSAoYWthIHRhcmdldCB0aW1lKS4ALwEAokSTFwAAAQAiAf//" +
           "//8BAf////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQBAHQD/////wEB/////wAAAAAV" +
           "YKkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQMYAC4ARAMYAAAWAQB5AwFOAAAALwAAAGh0dHA6" +
           "Ly93d3cub3BjZm91bmRhdGlvbi5vcmcvVUEvdW5pdHMvdW4vY2VmYWN0NjJDAAICAAAAbXMCCwAAAG1p" +
           "bGxpc2Vjb25kAQB3A/////8BAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIAAAAFRpbWVyQ29u" +
           "dHJvbEZ1bmN0aW9uVHlwZUluc3RhbmNlAQH1AwEB9QP1AwAA/////wYAAAA1YIkKAgAAAAEACQAAAElz" +
           "RW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIEZ1bmN0aW9u" +
           "IGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERldmljZS4gQSBGdW5jdGlvbiBtYXkgYmUg" +
           "ZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRpbmcgbm90IGxpY2Vuc2VkLCBtaXNzaW5n" +
           "IGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxpZXMALgBEchcAAAAB/////wMD/////wAA" +
           "AAAkYIAKAQAAAAEACwAAAE9wZXJhdGlvbmFsAQH5EwMAAAAA3AAAAE9wZXJhdGlvbmFsIGlzIGEgRnVu" +
           "Y3Rpb25hbEdyb3VwIHRoYXQgc2hhbGwgb3JnYW5pemUgdGhlIEN1cnJlbnRTdGF0ZSBwcm9wZXJ0eSBv" +
           "ZiB0aGUgU3RhdGVNYWNoaW5lIGFuZCBhbGwgaXRzIHJlbW90ZSBpbnZvY2FibGUgTWV0aG9kcy4gRnVy" +
           "dGhlcm1vcmUsIGl0IHNoYWxsIG9yZ2FuaXplIGF0IGxlYXN0IHRoZSBDdXJyZW50VmFsdWUgYW5kIFRh" +
           "cmdldFZhbHVlIHZhcmlhYmxlcy4ALwEC7QP5EwAA/////wEAAAAEYYIKBAAAAAEABAAAAFN0b3ABAXQb" +
           "ACMBAXQbdBsAAAEB/////wAAAAAkYIAKAQAAAAEAFAAAAENvbnRyb2xGdW5jdGlvblN0YXRlAQGuEwMA" +
           "AAAAeAAAAENvbnRyb2xGdW5jdGlvblN0YXRlIGlzIGEgc3RhdGUgbWFjaGluZSB3aGljaCByZXByZXNl" +
           "bnRzIHRoZSBleGVjdXRpb24gc3RhdGUgYW5kIGNvbnRyb2xzIHRoZSBleGVjdXRpb24gb2YgdGhlIEZ1" +
           "bmN0aW9uLgAvAQEUBK4TAAD/////AwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQG/FwAvAQDI" +
           "Cr8XAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBmhcALgBEmhcAAAAR/////wEB////" +
           "/wAAAAA3YIkKAgAAAAAADwAAAEF2YWlsYWJsZVN0YXRlcwEBSRkDAAAAAC4AAABTZXQgb2Ygc3RhdGVz" +
           "IHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8AP0kZAAAAEQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAA3YIkKAgAAAAAAFAAAAEF2YWlsYWJsZVRyYW5zaXRpb25zAQFIGQMAAAAAMwAAAFNldCBvZiB0" +
           "cmFuc2l0aW9ucyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9IGQAAABEBAAAAAQAA" +
           "AAEAAAABAf////8AAAAAdWCJCgIAAAABAA8AAABEaWZmZXJlbmNlVmFsdWUBAXwXAwAAAAAOAAAAUmVt" +
           "YWluaW5nIHRpbWUDAAAAAKQAAABUaGUgRGlmZmVyZW5jZVZhbHVlIChha2EgcmVtYWluaW5nIHRpbWUp" +
           "IGlzIGNhbGN1bGF0ZWQgYnkgc3VidHJhY3RpbmcgdGhlIEN1cnJlbnRWYWx1ZSBmcm9tIHRoZSBUYXJn" +
           "ZXRWYWx1ZS4gVGh1cywgaXQgY291bnRzIGRvd253YXJkcyBmcm9tIHRoZSBUYXJnZXRWYWx1ZSB0byB6" +
           "ZXJvLgAvAQCiRHwXAAABACIB/////wEB/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4A" +
           "RAEAdAP/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBBBgALgBEBBgA" +
           "ABYBAHkDAU4AAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZh" +
           "Y3Q2MkMAAgIAAABtcwILAAAAbWlsbGlzZWNvbmQBAHcD/////wEB/////wAAAAB1YIkKAgAAAAEACwAA" +
           "AFRhcmdldFZhbHVlAQGSFwMAAAAACwAAAFRhcmdldCB0aW1lAwAAAAAOAQAAVGhlIHRpbWVyJ3MgdGFy" +
           "Z2V0IHRpbWUuIEFzIHNvb24gYXMgdGhlIEN1cnJlbnRWYWx1ZSByZWFjaGVzIHRoZSBUYXJnZXRWYWx1" +
           "ZSwgdGhlIEN1cnJlbnRTdGF0ZSBvZiB0aGUgVGltZXJGdW5jdGlvbiBhdXRvbWF0aWNhbGx5IHRyYW5z" +
           "aXRpb25zIHRvIE9mZi4gVGhpcyBpcyB0eXBpY2FsbHkgYWNjb21wYW5pZWQgYnkgc29tZSAoaW50ZXJu" +
           "YWwpIGFjdGlvbi9lZmZlY3QsIHN1Y2ggYXMgc3RvcHBpbmcgdGhlIGV4ZWN1dGlvbiBvZiBhIEZ1bmN0" +
           "aW9uIG9yIHNpbWlsYXIuAC8BAKJEkhcAAAEAIgH/////AwP/////AgAAABVgiQgCAAAAAAAHAAAARVVS" +
           "YW5nZQEBAAAALgBEAQB0A/////8BAf////8AAAAAFWCpCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AQERGAAuAEQRGAAAFgEAeQMBTgAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3Vu" +
           "aXRzL3VuL2NlZmFjdDYyQwACAgAAAG1zAgsAAABtaWxsaXNlY29uZAEAdwP/////AQH/////AAAAAHVg" +
           "iQoCAAAAAQAMAAAAQ3VycmVudFZhbHVlAQGTFwMAAAAADAAAAEVsYXBzZWQgdGltZQMAAAAAfgAAAE9u" +
           "Y2Ugc3RhcnRlZCwgdGhlIEN1cnJlbnRWYWx1ZSAoYWthIGVsYXBzZWQgdGltZSkgY291bnRzIHVwd2Fy" +
           "ZHMgZnJvbSB6ZXJvIHVudGlsIGl0IHJlYWNoZXMgdGhlIFRhcmdldFZhbHVlIChha2EgdGFyZ2V0IHRp" +
           "bWUpLgAvAQCiRJMXAAABACIB/////wEB/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4A" +
           "RAEAdAP/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAxgALgBEAxgA" +
           "ABYBAHkDAU4AAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZh" +
           "Y3Q2MkMAAgIAAABtcwILAAAAbWlsbGlzZWNvbmQBAHcD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> DifferenceValue
        {
            get
            {
                return m_differenceValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_differenceValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_differenceValue = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> TargetValue
        {
            get
            {
                return m_targetValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetValue = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> CurrentValue
        {
            get
            {
                return m_currentValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentValue = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_differenceValue != null)
            {
                children.Add(m_differenceValue);
            }

            if (m_targetValue != null)
            {
                children.Add(m_targetValue);
            }

            if (m_currentValue != null)
            {
                children.Add(m_currentValue);
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
                case Opc.Ua.LADS.BrowseNames.DifferenceValue:
                {
                    if (createOrReplace)
                    {
                        if (DifferenceValue == null)
                        {
                            if (replacement == null)
                            {
                                DifferenceValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                DifferenceValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = DifferenceValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TargetValue:
                {
                    if (createOrReplace)
                    {
                        if (TargetValue == null)
                        {
                            if (replacement == null)
                            {
                                TargetValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                TargetValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = TargetValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CurrentValue:
                {
                    if (createOrReplace)
                    {
                        if (CurrentValue == null)
                        {
                            if (replacement == null)
                            {
                                CurrentValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CurrentValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CurrentValue;
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
        private AnalogUnitRangeState<double> m_differenceValue;
        private AnalogUnitRangeState<double> m_targetValue;
        private AnalogUnitRangeState<double> m_currentValue;
        #endregion
    }
    #endif
    #endregion

    #region AnalogScalarSensorFunctionWithCompensationTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogScalarSensorFunctionWithCompensationTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogScalarSensorFunctionWithCompensationTypeState : AnalogScalarSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogScalarSensorFunctionWithCompensationTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogScalarSensorFunctionWithCompensationType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEANgAAAEFuYWxvZ1Nj" +
           "YWxhclNlbnNvckZ1bmN0aW9uV2l0aENvbXBlbnNhdGlvblR5cGVJbnN0YW5jZQEB6AMBAegD6AMAAP//" +
           "//8FAAAANWCJCgIAAAABAAkAAABJc0VuYWJsZWQBAXIXAwAAAADGAAAASXNFbmFibGVkIGluZGljYXRl" +
           "cyB3aGV0aGVyIHRoZSBGdW5jdGlvbiBjYW4gY3VycmVudGx5IGJlIGV4ZWN1dGVkIG9uIHRoZSBEZXZp" +
           "Y2UuIEEgRnVuY3Rpb24gbWF5IGJlIGRpc2FibGVkIGZvciBzZXZlcmFsIHJlYXNvbnMgaW5jbHVkaW5n" +
           "IG5vdCBsaWNlbnNlZCwgbWlzc2luZyBoYXJkd2FyZSBtb2R1bGVzLCBvciBtaXNzaW5nIHN1cHBsaWVz" +
           "AC4ARHIXAAAAAf////8DA/////8AAAAAJGCACgEAAAABAAsAAABPcGVyYXRpb25hbAEBoBMDAAAAADsA" +
           "AABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIG9wZXJhdGlvbiBvZiB0aGlzIGZ1bmN0aW9u" +
           "LgAvAQLtA6ATAAD/////AAAAADVgiQoCAAAAAQAIAAAAUmF3VmFsdWUBAZcXAwAAAABsAAAAUmF3VmFs" +
           "dWUgaXMgdGhlIHJhdyB2YWx1ZSBtZWFzdXJlZCBhdCB0aGUgU2Vuc29yIGVsZW1lbnQsIHN1Y2ggYXMg" +
           "dGhlIE5lcm5zdCB2b2x0YWdlIG9mIGEgcEggU2Vuc29yIGVsZW1lbnQuAC8BAKJElxcAAAAL/////wEB" +
           "/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf////8AAAAANWCJCgIAAAAB" +
           "AAsAAABTZW5zb3JWYWx1ZQEBkRcDAAAAAFAAAABTZW5zb3JWYWx1ZSBpcyB0aGUgY2FsaWJyYXRlZCBh" +
           "bmQgb3B0aW9uYWxseSBjb21wZW5zYXRlZC9maWx0ZXJlZCBwcm9jZXNzIHZhbHVlLgAvAQCiRJEXAAAA" +
           "C/////8BAf////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQBAHQD/////wEB/////wAA" +
           "AAAVYIkIAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/////AQH/////AAAAADVg" +
           "iQoCAAAAAQARAAAAQ29tcGVuc2F0aW9uVmFsdWUBAZUXAwAAAACZAAAAQ29tcGVuc2F0aW9uVmFsdWUg" +
           "aXMgdGhlIGNvbXBlbnNhdGlvbiB2YWx1ZSB1c2VkIHdoaWxlIGNhbGN1bGF0aW5nIHRoZSBwcm9jZXNz" +
           "IHZhbHVlLCBzdWNoIGFzIHRoZSB0ZW1wZXJhdHVyZSBhdCB0aGUgU2Vuc29yIGVsZW1lbnQgZm9yIHBI" +
           "IG9yIERPIFNlbnNvcnMuAC8BAKJElRcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAQAAAC4ARAEAdAP/////AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "AAAALgBEAQB3A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> CompensationValue
        {
            get
            {
                return m_compensationValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_compensationValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_compensationValue = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_compensationValue != null)
            {
                children.Add(m_compensationValue);
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
                case Opc.Ua.LADS.BrowseNames.CompensationValue:
                {
                    if (createOrReplace)
                    {
                        if (CompensationValue == null)
                        {
                            if (replacement == null)
                            {
                                CompensationValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CompensationValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CompensationValue;
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
        private AnalogUnitRangeState<double> m_compensationValue;
        #endregion
    }
    #endif
    #endregion

    #region ControllerTuningParameterTypeState Class
    #if (!OPCUA_EXCLUDE_ControllerTuningParameterTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerTuningParameterTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ControllerTuningParameterTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ControllerTuningParameterType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJQAAAENvbnRyb2xs" +
           "ZXJUdW5pbmdQYXJhbWV0ZXJUeXBlSW5zdGFuY2UBAfADAQHwA/ADAAD/////AAAAAA==";
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

    #region PidControllerParameterTypeState Class
    #if (!OPCUA_EXCLUDE_PidControllerParameterTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PidControllerParameterTypeState : ControllerTuningParameterTypeState
    {
        #region Constructors
        /// <remarks />
        public PidControllerParameterTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.PidControllerParameterType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (CtrlP != null)
            {
                CtrlP.Initialize(context, CtrlP_InitializationString);
            }

            if (CtrlTd != null)
            {
                CtrlTd.Initialize(context, CtrlTd_InitializationString);
            }

            if (CtrlTi != null)
            {
                CtrlTi.Initialize(context, CtrlTi_InitializationString);
            }
        }

        #region Initialization String
        private const string CtrlP_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEABQAAAEN0cmxQAQFz" +
           "FwMAAAAALgAAAEN0cmxQIGlzIHRoZSBwcm9wb3J0aW9uYWwgY29udHJvbGxlciBwYXJhbWV0ZXIALwEA" +
           "okRzFwAAAAv/////AwP/////AgAAABVgiQgCAAAAAAAHAAAARVVSYW5nZQEBAAAALgBEAQB0A/////8B" +
           "Af////8AAAAAFWCJCAIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQEAAAAuAEQBAHcD/////wEB////" +
           "/wAAAAA=";

        private const string CtrlTd_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEABgAAAEN0cmxUZAEB" +
           "dBcDAAAAACsAAABDdHJsVGQgaXMgdGhlIGRlcml2YXRlIGNvbnRyb2xsZXIgcGFyYW1ldGVyAC8BAKJE" +
           "dBcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf////8A" +
           "AAAA";

        private const string CtrlTi_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEABgAAAEN0cmxUaQEB" +
           "dRcDAAAAAC4AAABDdHJsVGkgaXMgdGhlIGludGVncmF0b3IgY29udHJvbGxlciBwYXJhbWV0ZXIuAC8B" +
           "AKJEdRcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf//" +
           "//8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIgAAAFBpZENvbnRy" +
           "b2xsZXJQYXJhbWV0ZXJUeXBlSW5zdGFuY2UBAQYEAQEGBAYEAAD/////AwAAADVgiQoCAAAAAQAFAAAA" +
           "Q3RybFABAXMXAwAAAAAuAAAAQ3RybFAgaXMgdGhlIHByb3BvcnRpb25hbCBjb250cm9sbGVyIHBhcmFt" +
           "ZXRlcgAvAQCiRHMXAAAAC/////8DA/////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQB" +
           "AHQD/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAGAAAAQ3RybFRkAQF0FwMAAAAAKwAAAEN0cmxUZCBpcyB0aGUg" +
           "ZGVyaXZhdGUgY29udHJvbGxlciBwYXJhbWV0ZXIALwEAokR0FwAAAAv/////AwP/////AgAAABVgiQgC" +
           "AAAAAAAHAAAARVVSYW5nZQEBAAAALgBEAQB0A/////8BAf////8AAAAAFWCJCAIAAAAAABAAAABFbmdp" +
           "bmVlcmluZ1VuaXRzAQEAAAAuAEQBAHcD/////wEB/////wAAAAA1YIkKAgAAAAEABgAAAEN0cmxUaQEB" +
           "dRcDAAAAAC4AAABDdHJsVGkgaXMgdGhlIGludGVncmF0b3IgY29udHJvbGxlciBwYXJhbWV0ZXIuAC8B" +
           "AKJEdRcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> CtrlP
        {
            get
            {
                return m_ctrlP;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ctrlP, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ctrlP = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> CtrlTd
        {
            get
            {
                return m_ctrlTd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ctrlTd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ctrlTd = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> CtrlTi
        {
            get
            {
                return m_ctrlTi;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ctrlTi, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ctrlTi = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_ctrlP != null)
            {
                children.Add(m_ctrlP);
            }

            if (m_ctrlTd != null)
            {
                children.Add(m_ctrlTd);
            }

            if (m_ctrlTi != null)
            {
                children.Add(m_ctrlTi);
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
                case Opc.Ua.LADS.BrowseNames.CtrlP:
                {
                    if (createOrReplace)
                    {
                        if (CtrlP == null)
                        {
                            if (replacement == null)
                            {
                                CtrlP = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CtrlP = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CtrlP;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CtrlTd:
                {
                    if (createOrReplace)
                    {
                        if (CtrlTd == null)
                        {
                            if (replacement == null)
                            {
                                CtrlTd = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CtrlTd = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CtrlTd;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CtrlTi:
                {
                    if (createOrReplace)
                    {
                        if (CtrlTi == null)
                        {
                            if (replacement == null)
                            {
                                CtrlTi = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CtrlTi = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CtrlTi;
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
        private AnalogUnitRangeState<double> m_ctrlP;
        private AnalogUnitRangeState<double> m_ctrlTd;
        private AnalogUnitRangeState<double> m_ctrlTi;
        #endregion
    }
    #endif
    #endregion

    #region TwoStateDiscreteSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_TwoStateDiscreteSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TwoStateDiscreteSensorFunctionTypeState : DiscreteSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public TwoStateDiscreteSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.TwoStateDiscreteSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKgAAAFR3b1N0YXRl" +
           "RGlzY3JldGVTZW5zb3JGdW5jdGlvblR5cGVJbnN0YW5jZQEBBwQBAQcEBwQAAP////8DAAAANWCJCgIA" +
           "AAABAAkAAABJc0VuYWJsZWQBAXIXAwAAAADGAAAASXNFbmFibGVkIGluZGljYXRlcyB3aGV0aGVyIHRo" +
           "ZSBGdW5jdGlvbiBjYW4gY3VycmVudGx5IGJlIGV4ZWN1dGVkIG9uIHRoZSBEZXZpY2UuIEEgRnVuY3Rp" +
           "b24gbWF5IGJlIGRpc2FibGVkIGZvciBzZXZlcmFsIHJlYXNvbnMgaW5jbHVkaW5nIG5vdCBsaWNlbnNl" +
           "ZCwgbWlzc2luZyBoYXJkd2FyZSBtb2R1bGVzLCBvciBtaXNzaW5nIHN1cHBsaWVzAC4ARHIXAAAAAf//" +
           "//8DA/////8AAAAANWCJCgIAAAABAAsAAABTZW5zb3JWYWx1ZQEBdxcDAAAAABUAAABCb29sZWFuIHNl" +
           "bnNvciB2YWx1ZS4ALwEARQl3FwAAAAH/////AQH/////AgAAADVgqQoCAAAAAAAKAAAARmFsc2VTdGF0" +
           "ZQEB+BcDAAAAADYAAABIdW1hbiByZWFkYWJsZSBpZGVudGlmaWVyIG9mIHRoZSBzaWduYWxzJyBmYWxz" +
           "ZSBzdGF0ZS4ALgBE+BcAABUCAwAAAG9mZgAV/////wEB/////wAAAAA1YKkKAgAAAAAACQAAAFRydWVT" +
           "dGF0ZQEB+RcDAAAAADUAAABIdW1hbiByZWFkYWJsZSBpZGVudGlmaWVyIG9mIHRoZSBzaWduYWxzJyB0" +
           "cnVlIHN0YXRlLgAuAET5FwAAFQICAAAAb24AFf////8BAf////8AAAAAJGCACgEAAAABAAsAAABPcGVy" +
           "YXRpb25hbAEBxRMDAAAAADsAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIG9wZXJhdGlv" +
           "biBvZiB0aGlzIGZ1bmN0aW9uLgAvAQLtA8UTAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new TwoStateDiscreteState SensorValue
        {
            get { return (TwoStateDiscreteState)base.SensorValue; }
            set { base.SensorValue = value; }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

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
                case Opc.Ua.LADS.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new TwoStateDiscreteState(this);
                            }
                            else
                            {
                                SensorValue = (TwoStateDiscreteState)replacement;
                            }
                        }
                    }

                    instance = SensorValue;
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
        #endregion
    }
    #endif
    #endregion

    #region MultiStateDiscreteSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_MultiStateDiscreteSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MultiStateDiscreteSensorFunctionTypeState : DiscreteSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public MultiStateDiscreteSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.MultiStateDiscreteSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEALAAAAE11bHRpU3Rh" +
           "dGVEaXNjcmV0ZVNlbnNvckZ1bmN0aW9uVHlwZUluc3RhbmNlAQENBAEBDQQNBAAA/////wMAAAA1YIkK" +
           "AgAAAAEACQAAAElzRW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNhdGVzIHdoZXRoZXIg" +
           "dGhlIEZ1bmN0aW9uIGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERldmljZS4gQSBGdW5j" +
           "dGlvbiBtYXkgYmUgZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRpbmcgbm90IGxpY2Vu" +
           "c2VkLCBtaXNzaW5nIGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxpZXMALgBEchcAAAAB" +
           "/////wMD/////wAAAAA1YIkKAgAAAAEACwAAAFNlbnNvclZhbHVlAQGOFwMAAAAAFgAAAERpc2NyZXRl" +
           "IHNlbnNvciB2YWx1ZS4ALwEASAmOFwAAAAf/////AQH/////AQAAADdgiQoCAAAAAAALAAAARW51bVN0" +
           "cmluZ3MBARAYAwAAAABCAAAATGlzdCBvZiBodW1hbiByZWFkYWJsZSBpZGVudGlmaWVycyBmb3IgdGhl" +
           "IGRpc2NyZXRlIHNlbnNvciB2YWx1ZXMuAC4ARBAYAAAAFQEAAAABAAAAAAAAAAEB/////wAAAAAkYIAK" +
           "AQAAAAEACwAAAE9wZXJhdGlvbmFsAQHFEwMAAAAAOwAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVy" +
           "cyBmb3Igb3BlcmF0aW9uIG9mIHRoaXMgZnVuY3Rpb24uAC8BAu0DxRMAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new MultiStateDiscreteState<uint> SensorValue
        {
            get { return (MultiStateDiscreteState<uint>)base.SensorValue; }
            set { base.SensorValue = value; }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {

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
                case Opc.Ua.LADS.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new MultiStateDiscreteState<uint>(this);
                            }
                            else
                            {
                                SensorValue = (MultiStateDiscreteState<uint>)replacement;
                            }
                        }
                    }

                    instance = SensorValue;
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
        #endregion
    }
    #endif
    #endregion

    #region FunctionalUnitStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalUnitStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalUnitStateMachineTypeState : FunctionalStateMachineTypeState
    {
        #region Constructors
        /// <remarks />
        public FunctionalUnitStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.FunctionalUnitStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (Start != null)
            {
                Start.Initialize(context, Start_InitializationString);
            }

            if (StartProgram != null)
            {
                StartProgram.Initialize(context, StartProgram_InitializationString);
            }
        }

        #region Initialization String
        private const string Start_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAFN0YXJ0AQFc" +
           "GwAvAQFcG1wbAAABAf////8BAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB7xcDAAAAAFcA" +
           "AAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDQ6RnVuY3Rpb25h" +
           "bFVuaXRTdGF0ZW1hY2hpbmVUeXBlLjQ6U3RhcnQALgBE7xcAAJYBAAAAAQAqAQFpAAAACgAAAFByb3Bl" +
           "cnRpZXMBAMU4AQAAAAAAAAACSgAAAEEgc2V0IG9mIFByb3BlcnRpZXMgdGhhdCBwYXJhbWV0ZXJpemUg" +
           "dGhlIGV4ZWN1dGlvbiBvZiB0aGUgRnVuY3Rpb25hbCBVbml0AQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAA=";

        private const string StartProgram_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEADAAAAFN0YXJ0UHJv" +
           "Z3JhbQEBYhsALwEBYhtiGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAdIX" +
           "AwAAAABeAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCA0OkZ1" +
           "bmN0aW9uYWxVbml0U3RhdGVNYWNoaW5lVHlwZS40OlN0YXJ0UHJvZ3JhbQAuAETSFwAAlgUAAAABACoB" +
           "AZwAAAARAAAAUHJvZ3JhbVRlbXBsYXRlSWQADP////8AAAAAAngAAABUaGUgdW5pcXVlIGlkIG9mIHRo" +
           "ZSBwcm9ncmFtIHRlbXBsYXRlIHVzZWQgZm9yIHRoZSBwcm9ncmFtLXJ1bi4gVGhlIHRlbXBsYXRlIG11" +
           "c3QgYmUgYSBtZW1iZXIgb2YgdGhlIFByb2dyYW1UZW1wbGF0ZVNldC4BACoBAVwAAAAKAAAAUHJvcGVy" +
           "dGllcwEBuwsBAAAAAQAAAAAAAAACOQAAAEEgS2V5L1ZhbHVlIGxpc3QgZm9yIHBhcmFtZXRlcml6YXRp" +
           "b24gb2YgdGhlIHByb2dyYW0tcnVuLgEAKgEBQQAAABAAAABTdXBlcnZpc29yeUpvYklkAAz/////AAAA" +
           "AAIeAAAAVGhlIElEIG9mIHRoZSBzdXBlcnZpc29yeSBqb2IuAQAqAQFDAAAAEQAAAFN1cGVydmlzb3J5" +
           "VGFza0lkAAz/////AAAAAAIfAAAAVGhlIElEIG9mIHRoZSBzdXBlcnZpc29yeSB0YXNrLgEAKgEBeAAA" +
           "AAcAAABTYW1wbGVzAQG6CwEAAAABAAAAAAAAAAJYAAAAQW4gYXJyYXkgb2YgdGhlIFNhbXBsZUluZm9U" +
           "eXBlIHRoYXQgZGVzY3JpYmVzIHRoZSBzYW1wbGVzIHByb2Nlc3NlZCBpbiB0aGlzIHByb2dyYW0tcnVu" +
           "LgEAKAEBAAAAAQAAAAUAAAABAf////8AAAAAN2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAekX" +
           "AwAAAABgAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDQ6" +
           "RnVuY3Rpb25hbFVuaXRTdGF0ZU1hY2hpbmVUeXBlLjQ6U3RhcnRQcm9ncmFtAC4AROkXAACWAQAAAAEA" +
           "KgEBVwAAABIAAABEZXZpY2VQcm9ncmFtUnVuSWQADP////8AAAAAAjIAAABUaGUgZGV2aWNlIHNwZWNp" +
           "ZmljIElEIG9mIHRoZSBjdXJyZW50IHByb2dyYW0tcnVuLgEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJgAAAEZ1bmN0aW9u" +
           "YWxVbml0U3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQETBAEBEwQTBAAA/////wUAAAAVYIkKAgAAAAAA" +
           "DAAAAEN1cnJlbnRTdGF0ZQEBhxgALwEAyAqHGAAAABX/////AQH/////AgAAABVgiQgCAAAAAAACAAAA" +
           "SWQBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkKAgAAAAAAFAAAAEVmZmVjdGl2ZURpc3BsYXlOYW1l" +
           "AQGIGAAuAESIGAAAABX/////AQH/////AAAAADdgiQoCAAAAAAAPAAAAQXZhaWxhYmxlU3RhdGVzAQFJ" +
           "GQMAAAAALgAAAFNldCBvZiBzdGF0ZXMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlvbi4ALwA/" +
           "SRkAAAARAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAUAAAAQXZhaWxhYmxlVHJhbnNpdGlv" +
           "bnMBAUgZAwAAAAAzAAAAU2V0IG9mIHRyYW5zaXRpb25zIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50" +
           "YXRpb24uAC8AP0gZAAAAEQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQFc" +
           "GwAvAQFcG1wbAAABAf////8BAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB7xcDAAAAAFcA" +
           "AAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDQ6RnVuY3Rpb25h" +
           "bFVuaXRTdGF0ZW1hY2hpbmVUeXBlLjQ6U3RhcnQALgBE7xcAAJYBAAAAAQAqAQFpAAAACgAAAFByb3Bl" +
           "cnRpZXMBAMU4AQAAAAAAAAACSgAAAEEgc2V0IG9mIFByb3BlcnRpZXMgdGhhdCBwYXJhbWV0ZXJpemUg" +
           "dGhlIGV4ZWN1dGlvbiBvZiB0aGUgRnVuY3Rpb25hbCBVbml0AQAoAQEAAAABAAAAAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEADAAAAFN0YXJ0UHJvZ3JhbQEBYhsALwEBYhtiGwAAAQH/////AgAAADdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAdIXAwAAAABeAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0" +
           "IGFyZ3VtZW50IG9mIG1ldGhvZCA0OkZ1bmN0aW9uYWxVbml0U3RhdGVNYWNoaW5lVHlwZS40OlN0YXJ0" +
           "UHJvZ3JhbQAuAETSFwAAlgUAAAABACoBAZwAAAARAAAAUHJvZ3JhbVRlbXBsYXRlSWQADP////8AAAAA" +
           "AngAAABUaGUgdW5pcXVlIGlkIG9mIHRoZSBwcm9ncmFtIHRlbXBsYXRlIHVzZWQgZm9yIHRoZSBwcm9n" +
           "cmFtLXJ1bi4gVGhlIHRlbXBsYXRlIG11c3QgYmUgYSBtZW1iZXIgb2YgdGhlIFByb2dyYW1UZW1wbGF0" +
           "ZVNldC4BACoBAVwAAAAKAAAAUHJvcGVydGllcwEBuwsBAAAAAQAAAAAAAAACOQAAAEEgS2V5L1ZhbHVl" +
           "IGxpc3QgZm9yIHBhcmFtZXRlcml6YXRpb24gb2YgdGhlIHByb2dyYW0tcnVuLgEAKgEBQQAAABAAAABT" +
           "dXBlcnZpc29yeUpvYklkAAz/////AAAAAAIeAAAAVGhlIElEIG9mIHRoZSBzdXBlcnZpc29yeSBqb2Iu" +
           "AQAqAQFDAAAAEQAAAFN1cGVydmlzb3J5VGFza0lkAAz/////AAAAAAIfAAAAVGhlIElEIG9mIHRoZSBz" +
           "dXBlcnZpc29yeSB0YXNrLgEAKgEBeAAAAAcAAABTYW1wbGVzAQG6CwEAAAABAAAAAAAAAAJYAAAAQW4g" +
           "YXJyYXkgb2YgdGhlIFNhbXBsZUluZm9UeXBlIHRoYXQgZGVzY3JpYmVzIHRoZSBzYW1wbGVzIHByb2Nl" +
           "c3NlZCBpbiB0aGlzIHByb2dyYW0tcnVuLgEAKAEBAAAAAQAAAAUAAAABAf////8AAAAAN2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAekXAwAAAABgAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1" +
           "dCBhcmd1bWVudHMgb2YgbWV0aG9kIDQ6RnVuY3Rpb25hbFVuaXRTdGF0ZU1hY2hpbmVUeXBlLjQ6U3Rh" +
           "cnRQcm9ncmFtAC4AROkXAACWAQAAAAEAKgEBVwAAABIAAABEZXZpY2VQcm9ncmFtUnVuSWQADP////8A" +
           "AAAAAjIAAABUaGUgZGV2aWNlIHNwZWNpZmljIElEIG9mIHRoZSBjdXJyZW50IHByb2dyYW0tcnVuLgEA" +
           "KAEBAAAAAQAAAAEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public StartMethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public StartProgramMethodState StartProgram
        {
            get
            {
                return m_startProgramMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProgramMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProgramMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_startProgramMethod != null)
            {
                children.Add(m_startProgramMethod);
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
                case Opc.Ua.LADS.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new StartMethodState(this);
                            }
                            else
                            {
                                Start = (StartMethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.StartProgram:
                {
                    if (createOrReplace)
                    {
                        if (StartProgram == null)
                        {
                            if (replacement == null)
                            {
                                StartProgram = new StartProgramMethodState(this);
                            }
                            else
                            {
                                StartProgram = (StartProgramMethodState)replacement;
                            }
                        }
                    }

                    instance = StartProgram;
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
        private StartMethodState m_startMethod;
        private StartProgramMethodState m_startProgramMethod;
        #endregion
    }
    #endif
    #endregion

    #region ControlFunctionStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_ControlFunctionStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControlFunctionStateMachineTypeState : FunctionalStateMachineTypeState
    {
        #region Constructors
        /// <remarks />
        public ControlFunctionStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ControlFunctionStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (StartWithTargetValue != null)
            {
                StartWithTargetValue.Initialize(context, StartWithTargetValue_InitializationString);
            }

            if (Start != null)
            {
                Start.Initialize(context, Start_InitializationString);
            }
        }

        #region Initialization String
        private const string StartWithTargetValue_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEAFAAAAFN0YXJ0V2l0" +
           "aFRhcmdldFZhbHVlAQFhGwAvAQFhG2EbAAABAf////8BAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEB8RcDAAAAAFUAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0" +
           "aG9kIDQ6RnVuY3Rpb25TdGF0ZU1hY2hpbmVUeXBlVHlwZS40OlN0YXJ0AC4ARPEXAACWAQAAAAEAKgEB" +
           "cgAAAAsAAABUYXJnZXRWYWx1ZQAa/////wAAAAACVAAAAChPcHRpb25hbCkgVGhlIHZhbHVlIGNhbiB1" +
           "c2UgdG8gc2V0IHRoZSB0YXJnZXQgdmFsdWUgcGFyYWxsZWwgd2l0aCB0aGUgc3RhcnQgbWV0aG9kLgEA" +
           "KAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string Start_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEABQAAAFN0YXJ0AQF7" +
           "GwAvAQF7G3sbAAABAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJwAAAENvbnRyb2xG" +
           "dW5jdGlvblN0YXRlTWFjaGluZVR5cGVJbnN0YW5jZQEBFAQBARQEFAQAAP////8FAAAAFWCJCgIAAAAA" +
           "AAwAAABDdXJyZW50U3RhdGUBAdQXAC8BAMgK1BcAAAAV/////wEB/////wEAAAAVYIkIAgAAAAAAAgAA" +
           "AElkAQEAAAAuAEQAEf////8BAf////8AAAAAN2CJCgIAAAAAAA8AAABBdmFpbGFibGVTdGF0ZXMBAUkZ" +
           "AwAAAAAuAAAAU2V0IG9mIHN0YXRlcyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9J" +
           "GQAAABEBAAAAAQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAABQAAABBdmFpbGFibGVUcmFuc2l0aW9u" +
           "cwEBSBkDAAAAADMAAABTZXQgb2YgdHJhbnNpdGlvbnMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRh" +
           "dGlvbi4ALwA/SBkAAAARAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAUAAAAU3RhcnRXaXRo" +
           "VGFyZ2V0VmFsdWUBAWEbAC8BAWEbYRsAAAEB/////wEAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQHxFwMAAAAAVQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRo" +
           "b2QgNDpGdW5jdGlvblN0YXRlTWFjaGluZVR5cGVUeXBlLjQ6U3RhcnQALgBE8RcAAJYBAAAAAQAqAQFy" +
           "AAAACwAAAFRhcmdldFZhbHVlABr/////AAAAAAJUAAAAKE9wdGlvbmFsKSBUaGUgdmFsdWUgY2FuIHVz" +
           "ZSB0byBzZXQgdGhlIHRhcmdldCB2YWx1ZSBwYXJhbGxlbCB3aXRoIHRoZSBzdGFydCBtZXRob2QuAQAo" +
           "AQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQF7GwAvAQF7G3sbAAABAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public StartWithTargetValueMethodState StartWithTargetValue
        {
            get
            {
                return m_startWithTargetValueMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startWithTargetValueMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startWithTargetValueMethod = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startWithTargetValueMethod != null)
            {
                children.Add(m_startWithTargetValueMethod);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
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
                case Opc.Ua.LADS.BrowseNames.StartWithTargetValue:
                {
                    if (createOrReplace)
                    {
                        if (StartWithTargetValue == null)
                        {
                            if (replacement == null)
                            {
                                StartWithTargetValue = new StartWithTargetValueMethodState(this);
                            }
                            else
                            {
                                StartWithTargetValue = (StartWithTargetValueMethodState)replacement;
                            }
                        }
                    }

                    instance = StartWithTargetValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
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
        private StartWithTargetValueMethodState m_startWithTargetValueMethod;
        private MethodState m_startMethod;
        #endregion
    }
    #endif
    #endregion

    #region MultiModeAnalogControlFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_MultiModeAnalogControlFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MultiModeAnalogControlFunctionTypeState : BaseControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public MultiModeAnalogControlFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.MultiModeAnalogControlFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKgAAAE11bHRpTW9k" +
           "ZUFuYWxvZ0NvbnRyb2xGdW5jdGlvblR5cGVJbnN0YW5jZQEBFwQBARcEFwQAAP////8FAAAANWCJCgIA" +
           "AAABAAkAAABJc0VuYWJsZWQBAXIXAwAAAADGAAAASXNFbmFibGVkIGluZGljYXRlcyB3aGV0aGVyIHRo" +
           "ZSBGdW5jdGlvbiBjYW4gY3VycmVudGx5IGJlIGV4ZWN1dGVkIG9uIHRoZSBEZXZpY2UuIEEgRnVuY3Rp" +
           "b24gbWF5IGJlIGRpc2FibGVkIGZvciBzZXZlcmFsIHJlYXNvbnMgaW5jbHVkaW5nIG5vdCBsaWNlbnNl" +
           "ZCwgbWlzc2luZyBoYXJkd2FyZSBtb2R1bGVzLCBvciBtaXNzaW5nIHN1cHBsaWVzAC4ARHIXAAAAAf//" +
           "//8DA/////8AAAAAJGCACgEAAAABAAsAAABPcGVyYXRpb25hbAEBwhMDAAAAANwAAABPcGVyYXRpb25h" +
           "bCBpcyBhIEZ1bmN0aW9uYWxHcm91cCB0aGF0IHNoYWxsIG9yZ2FuaXplIHRoZSBDdXJyZW50U3RhdGUg" +
           "cHJvcGVydHkgb2YgdGhlIFN0YXRlTWFjaGluZSBhbmQgYWxsIGl0cyByZW1vdGUgaW52b2NhYmxlIE1l" +
           "dGhvZHMuIEZ1cnRoZXJtb3JlLCBpdCBzaGFsbCBvcmdhbml6ZSBhdCBsZWFzdCB0aGUgQ3VycmVudFZh" +
           "bHVlIGFuZCBUYXJnZXRWYWx1ZSB2YXJpYWJsZXMuAC8BAu0DwhMAAP////8BAAAABGGCCgQAAAABAAQA" +
           "AABTdG9wAQF0GwAjAQF0G3QbAAABAf////8AAAAAJGCACgEAAAABABQAAABDb250cm9sRnVuY3Rpb25T" +
           "dGF0ZQEBrhMDAAAAAHgAAABDb250cm9sRnVuY3Rpb25TdGF0ZSBpcyBhIHN0YXRlIG1hY2hpbmUgd2hp" +
           "Y2ggcmVwcmVzZW50cyB0aGUgZXhlY3V0aW9uIHN0YXRlIGFuZCBjb250cm9scyB0aGUgZXhlY3V0aW9u" +
           "IG9mIHRoZSBGdW5jdGlvbi4ALwEBFASuEwAA/////wMAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0" +
           "ZQEBvxcALwEAyAq/FwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZoXAC4ARJoXAAAA" +
           "Ef////8BAf////8AAAAAN2CJCgIAAAAAAA8AAABBdmFpbGFibGVTdGF0ZXMBAUkZAwAAAAAuAAAAU2V0" +
           "IG9mIHN0YXRlcyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVudGF0aW9uLgAvAD9JGQAAABEBAAAAAQAA" +
           "AAEAAAABAf////8AAAAAN2CJCgIAAAAAABQAAABBdmFpbGFibGVUcmFuc2l0aW9ucwEBSBkDAAAAADMA" +
           "AABTZXQgb2YgdHJhbnNpdGlvbnMgc3VwcG9ydGVkIGJ5IHRoZSBpbXBsZW1lbnRhdGlvbi4ALwA/SBkA" +
           "AAARAQAAAAEAAAABAAAAAQH/////AAAAADVgiQoCAAAAAQALAAAAQ3VycmVudE1vZGUBAeoXAwAAAACC" +
           "AQAAQ3VycmVudE1vZGUgZGVmaW5lcyB0aGUgY3VycmVudGx5IHNlbGVjdGVkIG1vZGUuIEl0cyBFbnVt" +
           "U3RyaW5ncyBhcnJheSBsaXN0cyB0aGUgZGlmZmVyZW50IGRlZmluZWQgbW9kZXMsIHdoaWNoIHNoYWxs" +
           "IG1hdGNoIHRoZSBuYW1lcyBvZiB0aGUgY29ycmVzcG9uZGluZyBlbGVtZW50cyBpbiB0aGUgQ29udHJv" +
           "bGxlck1vZGVTZXQuIE5vdGU6IFRoZSBFbnVtU3RyaW5ncyBhcnJheSBjb250YWlucyBMb2NhbGl6ZWRU" +
           "ZXh0IGVudHJpZXMuIFRoZSBEaXNwbGF5TmFtZSBvZiB0aGUgQ29udHJvbGxlck1vZGUgaXMgdXNlZCB0" +
           "byBtYXAgdGhlIGNoaWxkIG5vZGUgb2YgdGhlIENvbnRyb2xsZXJNb2RlU2V0LiBUaGUgbG9jYWxlIHNo" +
           "b3VsZCBiZSDigJxlbi1VU+KAnSBvciBlbXB0eS4ALwEASAnqFwAAAAf/////AwP/////AQAAABdgiQoC" +
           "AAAAAAALAAAARW51bVN0cmluZ3MBARUYAC4ARBUYAAAAFQEAAAABAAAAAAAAAAEB/////wAAAAAkYIAK" +
           "AQAAAAEAEQAAAENvbnRyb2xsZXJNb2RlU2V0AQHUEwMAAAAAOwAAAENvbnRyb2xsZXJNb2RlU2V0IGlz" +
           "IHRoZSBzZXQgb2YgdGFyZ2V0L2N1cnJlbnQgdmFsdWUgcGFpcnMuAC8BARkE1BMAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MultiStateDiscreteState<uint> CurrentMode
        {
            get
            {
                return m_currentMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentMode = value;
            }
        }

        /// <remarks />
        public ControllerParameterSetTypeState ControllerModeSet
        {
            get
            {
                return m_controllerModeSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controllerModeSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controllerModeSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentMode != null)
            {
                children.Add(m_currentMode);
            }

            if (m_controllerModeSet != null)
            {
                children.Add(m_controllerModeSet);
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
                case Opc.Ua.LADS.BrowseNames.CurrentMode:
                {
                    if (createOrReplace)
                    {
                        if (CurrentMode == null)
                        {
                            if (replacement == null)
                            {
                                CurrentMode = new MultiStateDiscreteState<uint>(this);
                            }
                            else
                            {
                                CurrentMode = (MultiStateDiscreteState<uint>)replacement;
                            }
                        }
                    }

                    instance = CurrentMode;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ControllerModeSet:
                {
                    if (createOrReplace)
                    {
                        if (ControllerModeSet == null)
                        {
                            if (replacement == null)
                            {
                                ControllerModeSet = new ControllerParameterSetTypeState(this);
                            }
                            else
                            {
                                ControllerModeSet = (ControllerParameterSetTypeState)replacement;
                            }
                        }
                    }

                    instance = ControllerModeSet;
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
        private MultiStateDiscreteState<uint> m_currentMode;
        private ControllerParameterSetTypeState m_controllerModeSet;
        #endregion
    }
    #endif
    #endregion

    #region ControllerParameterTypeState Class
    #if (!OPCUA_EXCLUDE_ControllerParameterTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerParameterTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ControllerParameterTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ControllerParameterType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (AlarmMonitor != null)
            {
                AlarmMonitor.Initialize(context, AlarmMonitor_InitializationString);
            }
        }

        #region Initialization String
        private const string AlarmMonitor_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEADAAAAEFsYXJtTW9u" +
           "aXRvcgEBGhQDAAAAAJEAAABBbGFybU1vbml0b3IgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIGRldmlhdGlv" +
           "biBmcm9tIGEgc2V0IHBvaW50IGV4Y2VlZHMgdGhlIGxpbWl0LiBTZWU6IDEwMDAwLTk6IEFsYXJtcyAm" +
           "IENvbmRpdGlvbnMgfCBFeGNsdXNpdmVEZXZpYXRpb25BbGFybVR5cGUuAC8BACQmGhQAAP////8eAAAA" +
           "FWCJCAIAAAAAAAcAAABFdmVudElkAQEAAAAuAEQAD/////8BAf////8AAAAAFWCJCAIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5vZGUBAQAA" +
           "AC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM/////wEB" +
           "/////wAAAAAVYIkIAgAAAAAABAAAAFRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAA" +
           "AAALAAAAUmVjZWl2ZVRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAHAAAATWVz" +
           "c2FnZQEBAAAALgBEABX/////AQH/////AAAAABVgiQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAAAC4ARAAF" +
           "/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAQAAAC4ARAAR/////wEB" +
           "/////wAAAAAVYIkIAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBAAAALgBEABX/////AQH/////" +
           "AAAAABdgiQgCAAAAAAATAAAAQ29uZGl0aW9uU3ViQ2xhc3NJZAEBAAAALgBEABEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAAF2CJCAIAAAAAABUAAABDb25kaXRpb25TdWJDbGFzc05hbWUBAQAAAC4ARAAVAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAABVgiQgCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBAAAALgBEAAz/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAIAAAAQnJhbmNoSWQBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAA" +
           "AAAABgAAAFJldGFpbgEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAARW5hYmxlZFN0" +
           "YXRlAQEAAAAvAQAjIwAV/////wEBBQAAAAEALCMAAwEALwAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBl" +
           "X0FsYXJtTW9uaXRvcl9BY2tlZFN0YXRlAQAsIwADAQAzAAAAQ29udHJvbGxlclBhcmFtZXRlclR5cGVf" +
           "QWxhcm1Nb25pdG9yX0NvbmZpcm1lZFN0YXRlAQAsIwADAQAwAAAAQ29udHJvbGxlclBhcmFtZXRlclR5" +
           "cGVfQWxhcm1Nb25pdG9yX0FjdGl2ZVN0YXRlAQAsIwADAQA0AAAAQ29udHJvbGxlclBhcmFtZXRlclR5" +
           "cGVfQWxhcm1Nb25pdG9yX1N1cHByZXNzZWRTdGF0ZQEALCMAAwEAMgAAAENvbnRyb2xsZXJQYXJhbWV0" +
           "ZXJUeXBlX0FsYXJtTW9uaXRvcl9TaGVsdmluZ1N0YXRlAQAAABVgiQgCAAAAAAACAAAASWQBAQAAAC4A" +
           "RAAB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAFF1YWxpdHkBAQAAAC8BACojABP/////AQH/////" +
           "AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAV" +
           "YIkIAgAAAAAADAAAAExhc3RTZXZlcml0eQEBAAAALwEAKiMABf////8BAf////8BAAAAFWCJCAIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAHAAAA" +
           "Q29tbWVudAEBAAAALwEAKiMAFf////8BAf////8BAAAAFWCJCAIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEAAAAu" +
           "AEQADP////8BAf////8AAAAABGGCCAQAAAAAAAcAAABEaXNhYmxlAQEAAAAvAQBEIwEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIIBAAAAAAABgAAAEVuYWJsZQEBAAAALwEAQyMBAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CAQAAAAAAAoAAABBZGRDb21tZW50AQEAAAAvAQBFIwEBAQAAAAEA+QsAAQANCwEAAAAXYKkIAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQEAAAAuAESWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAA" +
           "AAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAH" +
           "AAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRp" +
           "dGlvbi4BACgBAQAAAAEAAAACAAAAAQH/////AAAAABVgiQgCAAAAAAAKAAAAQWNrZWRTdGF0ZQMBAC8A" +
           "AABDb250cm9sbGVyUGFyYW1ldGVyVHlwZV9BbGFybU1vbml0b3JfQWNrZWRTdGF0ZQAvAQAjIwAV////" +
           "/wEBAQAAAAEALCMBAwEAMQAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRvcl9FbmFi" +
           "bGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAAARhgggEAAAA" +
           "AAALAAAAQWNrbm93bGVkZ2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAA" +
           "AAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABD" +
           "b21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9u" +
           "LgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0ZQMBADAAAABD" +
           "b250cm9sbGVyUGFyYW1ldGVyVHlwZV9BbGFybU1vbml0b3JfQWN0aXZlU3RhdGUALwEAIyMAFf////8B" +
           "AQIAAAABACwjAQMBADEAAABDb250cm9sbGVyUGFyYW1ldGVyVHlwZV9BbGFybU1vbml0b3JfRW5hYmxl" +
           "ZFN0YXRlAQAsIwADAQAvAAAAQ29udHJvbGxlclBhcmFtZXRlclR5cGVfQWxhcm1Nb25pdG9yX0xpbWl0" +
           "U3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAJ" +
           "AAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAAABMAAABTdXBwcmVzc2Vk" +
           "T3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8AAAAABGCACAEAAAAAAAoAAABMaW1pdFN0YXRlAwEA" +
           "LwAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRvcl9MaW1pdFN0YXRlAC8BAGYkAQAA" +
           "AAEALCMBAwEAMAAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRvcl9BY3RpdmVTdGF0" +
           "ZQEAAAAVYIkIAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJ" +
           "CAIAAAAAAAIAAABJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAAU2V0cG9pbnRO" +
           "b2RlAQEAAAAuAEQAEf////8BAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHwAAAENvbnRyb2xs" +
           "ZXJQYXJhbWV0ZXJUeXBlSW5zdGFuY2UBARgEAQEYBBgEAAD/////AwAAADVgiQoCAAAAAQAMAAAAQ3Vy" +
           "cmVudFZhbHVlAQHdFwMAAAAAKgAAAEN1cnJlbnRWYWx1ZSBpcyB0aGUgY3VycmVudCBwcm9jZXNzIHZh" +
           "bHVlLgAvAQCiRN0XAAAAC/////8BAf////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQB" +
           "AHQD/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/" +
           "////AQH/////AAAAADVgiQoCAAAAAQALAAAAVGFyZ2V0VmFsdWUBAd4XAwAAAAAsAAAAVGFyZ2V0VmFs" +
           "dWUgaXMgdGhlIHRhcmdldGVkIHNldC1wb2ludCB2YWx1ZS4ALwEAokTeFwAAAAv/////AwP/////AgAA" +
           "ABVgiQgCAAAAAAAHAAAARVVSYW5nZQEBAAAALgBEAQB0A/////8BAf////8AAAAAFWCJCAIAAAAAABAA" +
           "AABFbmdpbmVlcmluZ1VuaXRzAQEAAAAuAEQBAHcD/////wEB/////wAAAAAkYIAKAQAAAAEADAAAAEFs" +
           "YXJtTW9uaXRvcgEBGhQDAAAAAJEAAABBbGFybU1vbml0b3IgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIGRl" +
           "dmlhdGlvbiBmcm9tIGEgc2V0IHBvaW50IGV4Y2VlZHMgdGhlIGxpbWl0LiBTZWU6IDEwMDAwLTk6IEFs" +
           "YXJtcyAmIENvbmRpdGlvbnMgfCBFeGNsdXNpdmVEZXZpYXRpb25BbGFybVR5cGUuAC8BACQmGhQAAP//" +
           "//8eAAAAFWCJCAIAAAAAAAcAAABFdmVudElkAQEAAAAuAEQAD/////8BAf////8AAAAAFWCJCAIAAAAA" +
           "AAkAAABFdmVudFR5cGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkIAgAAAAAACgAAAFNvdXJjZU5hbWUBAQAAAC4ARAAM" +
           "/////wEB/////wAAAAAVYIkIAgAAAAAABAAAAFRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVg" +
           "iQgCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAH" +
           "AAAATWVzc2FnZQEBAAAALgBEABX/////AQH/////AAAAABVgiQgCAAAAAAAIAAAAU2V2ZXJpdHkBAQAA" +
           "AC4ARAAF/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAQAAAC4ARAAR" +
           "/////wEB/////wAAAAAVYIkIAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBAAAALgBEABX/////" +
           "AQH/////AAAAABdgiQgCAAAAAAATAAAAQ29uZGl0aW9uU3ViQ2xhc3NJZAEBAAAALgBEABEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAF2CJCAIAAAAAABUAAABDb25kaXRpb25TdWJDbGFzc05hbWUBAQAAAC4ARAAV" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAABVgiQgCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBAAAALgBEAAz/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAIAAAAQnJhbmNoSWQBAQAAAC4ARAAR/////wEB/////wAAAAAV" +
           "YIkIAgAAAAAABgAAAFJldGFpbgEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAARW5h" +
           "YmxlZFN0YXRlAQEAAAAvAQAjIwAV/////wEBBQAAAAEALCMAAwEALwAAAENvbnRyb2xsZXJQYXJhbWV0" +
           "ZXJUeXBlX0FsYXJtTW9uaXRvcl9BY2tlZFN0YXRlAQAsIwADAQAzAAAAQ29udHJvbGxlclBhcmFtZXRl" +
           "clR5cGVfQWxhcm1Nb25pdG9yX0NvbmZpcm1lZFN0YXRlAQAsIwADAQAwAAAAQ29udHJvbGxlclBhcmFt" +
           "ZXRlclR5cGVfQWxhcm1Nb25pdG9yX0FjdGl2ZVN0YXRlAQAsIwADAQA0AAAAQ29udHJvbGxlclBhcmFt" +
           "ZXRlclR5cGVfQWxhcm1Nb25pdG9yX1N1cHByZXNzZWRTdGF0ZQEALCMAAwEAMgAAAENvbnRyb2xsZXJQ" +
           "YXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRvcl9TaGVsdmluZ1N0YXRlAQAAABVgiQgCAAAAAAACAAAASWQB" +
           "AQAAAC4ARAAB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAFF1YWxpdHkBAQAAAC8BACojABP/////" +
           "AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB////" +
           "/wAAAAAVYIkIAgAAAAAADAAAAExhc3RTZXZlcml0eQEBAAAALwEAKiMABf////8BAf////8BAAAAFWCJ" +
           "CAIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAA" +
           "AAAHAAAAQ29tbWVudAEBAAAALwEAKiMAFf////8BAf////8BAAAAFWCJCAIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAQAAAC4ARAEAJgH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQEAAAAuAEQADP////8BAf////8AAAAABGGCCAQAAAAAAAcAAABEaXNhYmxlAQEAAAAvAQBEIwEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIIBAAAAAAABgAAAEVuYWJsZQEBAAAALwEAQyMBAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCAQAAAAAAAoAAABBZGRDb21tZW50AQEAAAAvAQBFIwEBAQAAAAEA+QsAAQANCwEAAAAXYKkI" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEAAAAuAESWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//" +
           "////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoB" +
           "AUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhl" +
           "IGNvbmRpdGlvbi4BACgBAQAAAAEAAAACAAAAAQH/////AAAAABVgiQgCAAAAAAAKAAAAQWNrZWRTdGF0" +
           "ZQMBAC8AAABDb250cm9sbGVyUGFyYW1ldGVyVHlwZV9BbGFybU1vbml0b3JfQWNrZWRTdGF0ZQAvAQAj" +
           "IwAV/////wEBAQAAAAEALCMBAwEAMQAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRv" +
           "cl9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAAARh" +
           "gggEAAAAAAALAAAAQWNrbm93bGVkZ2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8A" +
           "AAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAA" +
           "AAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29u" +
           "ZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0ZQMB" +
           "ADAAAABDb250cm9sbGVyUGFyYW1ldGVyVHlwZV9BbGFybU1vbml0b3JfQWN0aXZlU3RhdGUALwEAIyMA" +
           "Ff////8BAQIAAAABACwjAQMBADEAAABDb250cm9sbGVyUGFyYW1ldGVyVHlwZV9BbGFybU1vbml0b3Jf" +
           "RW5hYmxlZFN0YXRlAQAsIwADAQAvAAAAQ29udHJvbGxlclBhcmFtZXRlclR5cGVfQWxhcm1Nb25pdG9y" +
           "X0xpbWl0U3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAJAAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAAABMAAABTdXBw" +
           "cmVzc2VkT3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8AAAAABGCACAEAAAAAAAoAAABMaW1pdFN0" +
           "YXRlAwEALwAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRvcl9MaW1pdFN0YXRlAC8B" +
           "AGYkAQAAAAEALCMBAwEAMAAAAENvbnRyb2xsZXJQYXJhbWV0ZXJUeXBlX0FsYXJtTW9uaXRvcl9BY3Rp" +
           "dmVTdGF0ZQEAAAAVYIkIAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8B" +
           "AAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAMAAAAU2V0" +
           "cG9pbnROb2RlAQEAAAAuAEQAEf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> CurrentValue
        {
            get
            {
                return m_currentValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentValue = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> TargetValue
        {
            get
            {
                return m_targetValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetValue = value;
            }
        }

        /// <remarks />
        public ExclusiveDeviationAlarmState AlarmMonitor
        {
            get
            {
                return m_alarmMonitor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmMonitor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmMonitor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentValue != null)
            {
                children.Add(m_currentValue);
            }

            if (m_targetValue != null)
            {
                children.Add(m_targetValue);
            }

            if (m_alarmMonitor != null)
            {
                children.Add(m_alarmMonitor);
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
                case Opc.Ua.LADS.BrowseNames.CurrentValue:
                {
                    if (createOrReplace)
                    {
                        if (CurrentValue == null)
                        {
                            if (replacement == null)
                            {
                                CurrentValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                CurrentValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = CurrentValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.TargetValue:
                {
                    if (createOrReplace)
                    {
                        if (TargetValue == null)
                        {
                            if (replacement == null)
                            {
                                TargetValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                TargetValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = TargetValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.AlarmMonitor:
                {
                    if (createOrReplace)
                    {
                        if (AlarmMonitor == null)
                        {
                            if (replacement == null)
                            {
                                AlarmMonitor = new ExclusiveDeviationAlarmState(this);
                            }
                            else
                            {
                                AlarmMonitor = (ExclusiveDeviationAlarmState)replacement;
                            }
                        }
                    }

                    instance = AlarmMonitor;
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
        private AnalogUnitRangeState<double> m_currentValue;
        private AnalogUnitRangeState<double> m_targetValue;
        private ExclusiveDeviationAlarmState m_alarmMonitor;
        #endregion
    }
    #endif
    #endregion

    #region ControllerParameterSetTypeState Class
    #if (!OPCUA_EXCLUDE_ControllerParameterSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerParameterSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public ControllerParameterSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.ControllerParameterSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIgAAAENvbnRyb2xs" +
           "ZXJQYXJhbWV0ZXJTZXRUeXBlSW5zdGFuY2UBARkEAQEZBBkEAAD/////AAAAAA==";
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

    #region AnalogControlFunctionWithComposedTargetValueTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogControlFunctionWithComposedTargetValueTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogControlFunctionWithComposedTargetValueTypeState : AnalogControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogControlFunctionWithComposedTargetValueTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionWithComposedTargetValueType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAOAAAAEFuYWxvZ0Nv" +
           "bnRyb2xGdW5jdGlvbldpdGhDb21wb3NlZFRhcmdldFZhbHVlVHlwZUluc3RhbmNlAQEcBAEBHAQcBAAA" +
           "/////wYAAAA1YIkKAgAAAAEACQAAAElzRW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNh" +
           "dGVzIHdoZXRoZXIgdGhlIEZ1bmN0aW9uIGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERl" +
           "dmljZS4gQSBGdW5jdGlvbiBtYXkgYmUgZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRp" +
           "bmcgbm90IGxpY2Vuc2VkLCBtaXNzaW5nIGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxp" +
           "ZXMALgBEchcAAAAB/////wMD/////wAAAAAkYIAKAQAAAAEACwAAAE9wZXJhdGlvbmFsAQGREwMAAAAA" +
           "3AAAAE9wZXJhdGlvbmFsIGlzIGEgRnVuY3Rpb25hbEdyb3VwIHRoYXQgc2hhbGwgb3JnYW5pemUgdGhl" +
           "IEN1cnJlbnRTdGF0ZSBwcm9wZXJ0eSBvZiB0aGUgU3RhdGVNYWNoaW5lIGFuZCBhbGwgaXRzIHJlbW90" +
           "ZSBpbnZvY2FibGUgTWV0aG9kcy4gRnVydGhlcm1vcmUsIGl0IHNoYWxsIG9yZ2FuaXplIGF0IGxlYXN0" +
           "IHRoZSBDdXJyZW50VmFsdWUgYW5kIFRhcmdldFZhbHVlIHZhcmlhYmxlcy4ALwEC7QOREwAA/////wEA" +
           "AAAEYYIKBAAAAAEABAAAAFN0b3ABAXQbACMBAXQbdBsAAAEB/////wAAAAAkYIAKAQAAAAEAFAAAAENv" +
           "bnRyb2xGdW5jdGlvblN0YXRlAQEVFAMAAAAAeAAAAENvbnRyb2xGdW5jdGlvblN0YXRlIGlzIGEgc3Rh" +
           "dGUgbWFjaGluZSB3aGljaCByZXByZXNlbnRzIHRoZSBleGVjdXRpb24gc3RhdGUgYW5kIGNvbnRyb2xz" +
           "IHRoZSBleGVjdXRpb24gb2YgdGhlIEZ1bmN0aW9uLgAvAQEUBBUUAAD/////AwAAABVgiQoCAAAAAAAM" +
           "AAAAQ3VycmVudFN0YXRlAQHUFwAvAQDICtQXAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBmhcALgBEmhcAAAAR/////wEB/////wAAAAA3YIkKAgAAAAAADwAAAEF2YWlsYWJsZVN0YXRlcwEB" +
           "SRkDAAAAAC4AAABTZXQgb2Ygc3RhdGVzIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8A" +
           "P0kZAAAAEQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAAFAAAAEF2YWlsYWJsZVRyYW5zaXRp" +
           "b25zAQFIGQMAAAAAMwAAAFNldCBvZiB0cmFuc2l0aW9ucyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVu" +
           "dGF0aW9uLgAvAD9IGQAAABEBAAAAAQAAAAEAAAABAf////8AAAAANWCJCgIAAAABAAwAAABDdXJyZW50" +
           "VmFsdWUBAXEXAwAAAAAqAAAAQ3VycmVudFZhbHVlIGlzIHRoZSBjdXJyZW50IHByb2Nlc3MgdmFsdWUu" +
           "AC8BAKJEcRcAAAAL/////wEB/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8B" +
           "Af////8AAAAANWCJCgIAAAABAAsAAABUYXJnZXRWYWx1ZQEBdhcDAAAAACwAAABUYXJnZXRWYWx1ZSBp" +
           "cyB0aGUgdGFyZ2V0ZWQgc2V0LXBvaW50IHZhbHVlLgAvAQCiRHYXAAAAC/////8DA/////8CAAAAFWCJ" +
           "CAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQBAHQD/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVu" +
           "Z2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/////AQH/////AAAAACRggAoBAAAAAQAOAAAAVGFyZ2V0" +
           "VmFsdWVTZXQBAd8TAwAAAABAAAAAVGFyZ2V0VmFsdWVTZXQgY29udGFpbnMgdGhlIHBhcnRpYWwgdmFs" +
           "dWVzIGZvciB0aGUgdGFyZ2V0IHZhbHVlLgAvAQERBN8TAAABAAAAACkAAQBVCAAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public VariableSetTypeState TargetValueSet
        {
            get
            {
                return m_targetValueSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetValueSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetValueSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_targetValueSet != null)
            {
                children.Add(m_targetValueSet);
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
                case Opc.Ua.LADS.BrowseNames.TargetValueSet:
                {
                    if (createOrReplace)
                    {
                        if (TargetValueSet == null)
                        {
                            if (replacement == null)
                            {
                                TargetValueSet = new VariableSetTypeState(this);
                            }
                            else
                            {
                                TargetValueSet = (VariableSetTypeState)replacement;
                            }
                        }
                    }

                    instance = TargetValueSet;
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
        private VariableSetTypeState m_targetValueSet;
        #endregion
    }
    #endif
    #endregion

    #region MultiSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_MultiSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MultiSensorFunctionTypeState : BaseSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public MultiSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.MultiSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAHwAAAE11bHRpU2Vu" +
           "c29yRnVuY3Rpb25UeXBlSW5zdGFuY2UBARsEAQEbBBsEAAD/////AgAAAGRggAoBAAAAAQALAAAARnVu" +
           "Y3Rpb25TZXQBAY4TAwAAAAAMAAAARnVuY3Rpb24gU2V0AwAAAABfAAAAVGhlIEZ1bmN0aW9uU2V0VHlw" +
           "ZSBpcyB1c2VkIGZvciBvcmdhbmlzaW5nIEZ1bmN0aW9uVHlwZSBvYmplY3RzIGluIGFuIHVub3JkZXJl" +
           "ZCBsaXN0IHN0cnVjdHVyZS4ALwEBAgSOEwAA/////wAAAAA1YIkKAgAAAAEACQAAAElzRW5hYmxlZAEB" +
           "chcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIEZ1bmN0aW9uIGNhbiBjdXJy" +
           "ZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERldmljZS4gQSBGdW5jdGlvbiBtYXkgYmUgZGlzYWJsZWQg" +
           "Zm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRpbmcgbm90IGxpY2Vuc2VkLCBtaXNzaW5nIGhhcmR3YXJl" +
           "IG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxpZXMALgBEchcAAAAB/////wMD/////wAAAAA=";
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

    #region AnalogControlFunctionWithRelativeTargetValueTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogControlFunctionWithRelativeTargetValueTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogControlFunctionWithRelativeTargetValueTypeState : AnalogControlFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogControlFunctionWithRelativeTargetValueTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionWithRelativeTargetValueType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (IncreaseRate != null)
            {
                IncreaseRate.Initialize(context, IncreaseRate_InitializationString);
            }

            if (DecreaseRate != null)
            {
                DecreaseRate.Initialize(context, DecreaseRate_InitializationString);
            }

            if (ModifyTargetValueBy != null)
            {
                ModifyTargetValueBy.Initialize(context, ModifyTargetValueBy_InitializationString);
            }
        }

        #region Initialization String
        private const string IncreaseRate_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEADAAAAEluY3JlYXNl" +
           "UmF0ZQEByRcDAAAAAHAAAABSYXRlIGJ5IHdoaWNoIHRoZSBpbnRlcm5hbCB0YXJnZXQtdmFsdWUgaXMg" +
           "aW5jcmVhc2VkIG9uIGNoYW5nZSAoZS5nLiwgYWNjZWxlcmF0aW9uIHJhbXAsIGFzcGlyYXRpbmcgYWN0" +
           "aW9uLCAuLikuAC8BAKJEyRcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAA" +
           "AC4ARAEAdAP/////AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBE" +
           "AQB3A/////8BAf////8AAAAA";

        private const string DecreaseRate_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEADAAAAERlY3JlYXNl" +
           "UmF0ZQEB7RcDAAAAAHYAAABSYXRlIGJ5IHdoaWNoIHRoZSBpbnRlcm5hbCB0YXJnZXQtdmFsdWUgaXMg" +
           "ZGVjcmVhc2VkIG9uIGNoYW5nZSAoZS5nLiwgZGVjZWxlcmF0aW9uL2JyYWtlIHJhbXAsIGRpc3BlbnNp" +
           "bmcgYWN0aW9uLCAuLikuAC8BAKJE7RcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAQAAAC4ARAEAdAP/////AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "AAAALgBEAQB3A/////8BAf////8AAAAA";

        private const string ModifyTargetValueBy_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEAEwAAAE1vZGlmeVRh" +
           "cmdldFZhbHVlQnkBAW4bAC8BAW4bbhsAAAEB/////wEAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQHwFwMAAAAAfgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRo" +
           "b2QgNDpBbmFsb2dDb250cm9sRnVuY3Rpb25XaXRoSW5jcmVhc2VEZWNyZWFzZVJhdGVzVHlwZS40Ok1v" +
           "ZGlmeVRhcmdldFZhbHVlQnlEZWx0YQAuAETwFwAAlgEAAAABACoBAdEAAAAFAAAAVmFsdWUAC/////8A" +
           "AAAAArkAAABSZWxhdGl2ZSB2YWx1ZSBieSB3aGljaCB0aGUgdGFyZ2V0IHZhbHVlIHdpbGwgYmUgY2hh" +
           "bmdlZC4gVGhlIHJlc3VsdGluZyB2YWx1ZSB3aWxsIHR5cGljYWxseSBiZSBsaW1pdGVkIHRvIHRoZSB0" +
           "YXJnZXQtdmFsdWUncyBhbGxvd2VkIHJhbmdlLiBQcm92aWRlZCB2YWx1ZXMgY2FuIGJlIHBvc2l0aXZl" +
           "IG9yIG5lZ2F0aXZlLgEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAOAAAAEFuYWxvZ0Nv" +
           "bnRyb2xGdW5jdGlvbldpdGhSZWxhdGl2ZVRhcmdldFZhbHVlVHlwZUluc3RhbmNlAQEFBAEBBQQFBAAA" +
           "/////wgAAAA1YIkKAgAAAAEACQAAAElzRW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNh" +
           "dGVzIHdoZXRoZXIgdGhlIEZ1bmN0aW9uIGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERl" +
           "dmljZS4gQSBGdW5jdGlvbiBtYXkgYmUgZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRp" +
           "bmcgbm90IGxpY2Vuc2VkLCBtaXNzaW5nIGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxp" +
           "ZXMALgBEchcAAAAB/////wMD/////wAAAAAkYIAKAQAAAAEACwAAAE9wZXJhdGlvbmFsAQHcEwMAAAAA" +
           "3AAAAE9wZXJhdGlvbmFsIGlzIGEgRnVuY3Rpb25hbEdyb3VwIHRoYXQgc2hhbGwgb3JnYW5pemUgdGhl" +
           "IEN1cnJlbnRTdGF0ZSBwcm9wZXJ0eSBvZiB0aGUgU3RhdGVNYWNoaW5lIGFuZCBhbGwgaXRzIHJlbW90" +
           "ZSBpbnZvY2FibGUgTWV0aG9kcy4gRnVydGhlcm1vcmUsIGl0IHNoYWxsIG9yZ2FuaXplIGF0IGxlYXN0" +
           "IHRoZSBDdXJyZW50VmFsdWUgYW5kIFRhcmdldFZhbHVlIHZhcmlhYmxlcy4ALwEC7QPcEwAA/////wEA" +
           "AAAEYYIKBAAAAAEABAAAAFN0b3ABAXQbACMBAXQbdBsAAAEB/////wAAAAAkYIAKAQAAAAEAFAAAAENv" +
           "bnRyb2xGdW5jdGlvblN0YXRlAQEVFAMAAAAAeAAAAENvbnRyb2xGdW5jdGlvblN0YXRlIGlzIGEgc3Rh" +
           "dGUgbWFjaGluZSB3aGljaCByZXByZXNlbnRzIHRoZSBleGVjdXRpb24gc3RhdGUgYW5kIGNvbnRyb2xz" +
           "IHRoZSBleGVjdXRpb24gb2YgdGhlIEZ1bmN0aW9uLgAvAQEUBBUUAAD/////AwAAABVgiQoCAAAAAAAM" +
           "AAAAQ3VycmVudFN0YXRlAQHUFwAvAQDICtQXAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBmhcALgBEmhcAAAAR/////wEB/////wAAAAA3YIkKAgAAAAAADwAAAEF2YWlsYWJsZVN0YXRlcwEB" +
           "SRkDAAAAAC4AAABTZXQgb2Ygc3RhdGVzIHN1cHBvcnRlZCBieSB0aGUgaW1wbGVtZW50YXRpb24uAC8A" +
           "P0kZAAAAEQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAAFAAAAEF2YWlsYWJsZVRyYW5zaXRp" +
           "b25zAQFIGQMAAAAAMwAAAFNldCBvZiB0cmFuc2l0aW9ucyBzdXBwb3J0ZWQgYnkgdGhlIGltcGxlbWVu" +
           "dGF0aW9uLgAvAD9IGQAAABEBAAAAAQAAAAEAAAABAf////8AAAAANWCJCgIAAAABAAwAAABDdXJyZW50" +
           "VmFsdWUBAXEXAwAAAAAqAAAAQ3VycmVudFZhbHVlIGlzIHRoZSBjdXJyZW50IHByb2Nlc3MgdmFsdWUu" +
           "AC8BAKJEcRcAAAAL/////wEB/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8B" +
           "Af////8AAAAANWCJCgIAAAABAAsAAABUYXJnZXRWYWx1ZQEBdhcDAAAAACwAAABUYXJnZXRWYWx1ZSBp" +
           "cyB0aGUgdGFyZ2V0ZWQgc2V0LXBvaW50IHZhbHVlLgAvAQCiRHYXAAAAC/////8DA/////8CAAAAFWCJ" +
           "CAIAAAAAAAcAAABFVVJhbmdlAQEAAAAuAEQBAHQD/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVu" +
           "Z2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/////AQH/////AAAAADVgiQoCAAAAAQAMAAAASW5jcmVh" +
           "c2VSYXRlAQHJFwMAAAAAcAAAAFJhdGUgYnkgd2hpY2ggdGhlIGludGVybmFsIHRhcmdldC12YWx1ZSBp" +
           "cyBpbmNyZWFzZWQgb24gY2hhbmdlIChlLmcuLCBhY2NlbGVyYXRpb24gcmFtcCwgYXNwaXJhdGluZyBh" +
           "Y3Rpb24sIC4uKS4ALwEAokTJFwAAAAv/////AwP/////AgAAABVgiQgCAAAAAAAHAAAARVVSYW5nZQEB" +
           "AAAALgBEAQB0A/////8BAf////8AAAAAFWCJCAIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQEAAAAu" +
           "AEQBAHcD/////wEB/////wAAAAA1YIkKAgAAAAEADAAAAERlY3JlYXNlUmF0ZQEB7RcDAAAAAHYAAABS" +
           "YXRlIGJ5IHdoaWNoIHRoZSBpbnRlcm5hbCB0YXJnZXQtdmFsdWUgaXMgZGVjcmVhc2VkIG9uIGNoYW5n" +
           "ZSAoZS5nLiwgZGVjZWxlcmF0aW9uL2JyYWtlIHJhbXAsIGRpc3BlbnNpbmcgYWN0aW9uLCAuLikuAC8B" +
           "AKJE7RcAAAAL/////wMD/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf//" +
           "//8AAAAABGGCCgQAAAABABMAAABNb2RpZnlUYXJnZXRWYWx1ZUJ5AQFuGwAvAQFuG24bAAABAf////8B" +
           "AAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB8BcDAAAAAH4AAAB0aGUgZGVmaW5pdGlvbiBv" +
           "ZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDQ6QW5hbG9nQ29udHJvbEZ1bmN0aW9uV2l0aElu" +
           "Y3JlYXNlRGVjcmVhc2VSYXRlc1R5cGUuNDpNb2RpZnlUYXJnZXRWYWx1ZUJ5RGVsdGEALgBE8BcAAJYB" +
           "AAAAAQAqAQHRAAAABQAAAFZhbHVlAAv/////AAAAAAK5AAAAUmVsYXRpdmUgdmFsdWUgYnkgd2hpY2gg" +
           "dGhlIHRhcmdldCB2YWx1ZSB3aWxsIGJlIGNoYW5nZWQuIFRoZSByZXN1bHRpbmcgdmFsdWUgd2lsbCB0" +
           "eXBpY2FsbHkgYmUgbGltaXRlZCB0byB0aGUgdGFyZ2V0LXZhbHVlJ3MgYWxsb3dlZCByYW5nZS4gUHJv" +
           "dmlkZWQgdmFsdWVzIGNhbiBiZSBwb3NpdGl2ZSBvciBuZWdhdGl2ZS4BACgBAQAAAAEAAAABAAAAAQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState<double> IncreaseRate
        {
            get
            {
                return m_increaseRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_increaseRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_increaseRate = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState<double> DecreaseRate
        {
            get
            {
                return m_decreaseRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_decreaseRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_decreaseRate = value;
            }
        }

        /// <remarks />
        public ModifyTargetValueByMethodState ModifyTargetValueBy
        {
            get
            {
                return m_modifyTargetValueByMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modifyTargetValueByMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modifyTargetValueByMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_increaseRate != null)
            {
                children.Add(m_increaseRate);
            }

            if (m_decreaseRate != null)
            {
                children.Add(m_decreaseRate);
            }

            if (m_modifyTargetValueByMethod != null)
            {
                children.Add(m_modifyTargetValueByMethod);
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
                case Opc.Ua.LADS.BrowseNames.IncreaseRate:
                {
                    if (createOrReplace)
                    {
                        if (IncreaseRate == null)
                        {
                            if (replacement == null)
                            {
                                IncreaseRate = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                IncreaseRate = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = IncreaseRate;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.DecreaseRate:
                {
                    if (createOrReplace)
                    {
                        if (DecreaseRate == null)
                        {
                            if (replacement == null)
                            {
                                DecreaseRate = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                DecreaseRate = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = DecreaseRate;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.ModifyTargetValueBy:
                {
                    if (createOrReplace)
                    {
                        if (ModifyTargetValueBy == null)
                        {
                            if (replacement == null)
                            {
                                ModifyTargetValueBy = new ModifyTargetValueByMethodState(this);
                            }
                            else
                            {
                                ModifyTargetValueBy = (ModifyTargetValueByMethodState)replacement;
                            }
                        }
                    }

                    instance = ModifyTargetValueBy;
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
        private AnalogUnitRangeState<double> m_increaseRate;
        private AnalogUnitRangeState<double> m_decreaseRate;
        private ModifyTargetValueByMethodState m_modifyTargetValueByMethod;
        #endregion
    }
    #endif
    #endregion

    #region AnalogArraySensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogArraySensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogArraySensorFunctionTypeState : AnalogSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogArraySensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogArraySensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAJQAAAEFuYWxvZ0Fy" +
           "cmF5U2Vuc29yRnVuY3Rpb25UeXBlSW5zdGFuY2UBAfcDAQH3A/cDAAD/////BAAAADVgiQoCAAAAAQAJ" +
           "AAAASXNFbmFibGVkAQFyFwMAAAAAxgAAAElzRW5hYmxlZCBpbmRpY2F0ZXMgd2hldGhlciB0aGUgRnVu" +
           "Y3Rpb24gY2FuIGN1cnJlbnRseSBiZSBleGVjdXRlZCBvbiB0aGUgRGV2aWNlLiBBIEZ1bmN0aW9uIG1h" +
           "eSBiZSBkaXNhYmxlZCBmb3Igc2V2ZXJhbCByZWFzb25zIGluY2x1ZGluZyBub3QgbGljZW5zZWQsIG1p" +
           "c3NpbmcgaGFyZHdhcmUgbW9kdWxlcywgb3IgbWlzc2luZyBzdXBwbGllcwAuAERyFwAAAAH/////AwP/" +
           "////AAAAACRggAoBAAAAAQALAAAAT3BlcmF0aW9uYWwBAZMTAwAAAAA7AAAAVXNlZCB0byBvcmdhbml6" +
           "ZSBwYXJhbWV0ZXJzIGZvciBvcGVyYXRpb24gb2YgdGhpcyBmdW5jdGlvbi4ALwEC7QOTEwAA/////wAA" +
           "AAA1YIkKAgAAAAEACAAAAFJhd1ZhbHVlAQH2FwMAAAAAdwAAAFJhd1ZhbHVlIGlzIHRoZSByYXcgdmFs" +
           "dWUgbWVhc3VyZWQgYXQgdGhlIHNlbnNvciBhcnJheSwgc3VjaCBhcyB0aGUgZWxlY3RyaWNhbCBjdXJy" +
           "ZW50IG9mIHBsYXRlLXJlYWRlciBwaG90by1kZXRlY3RvcnMuAC8BAKJE9hcAAAALAAAAAAEB/////wIA" +
           "AAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////AQH/////AAAAABVgiQgCAAAAAAAQ" +
           "AAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf////8AAAAANWCJCgIAAAABAAsAAABT" +
           "ZW5zb3JWYWx1ZQEB8hcDAAAAAF4AAABTZW5zb3JWYWx1ZSBpcyB0aGUgY2FsaWJyYXRlZCBhbmQgb3B0" +
           "aW9uYWxseSBjb21wZW5zYXRlZC9maWx0ZXJlZCBhcnJheSBvZiBtZWFzdXJlbWVudCB2YWx1ZXMuAC8B" +
           "AKJE8hcAAAALAAAAAAEB/////wIAAAAVYIkIAgAAAAAABwAAAEVVUmFuZ2UBAQAAAC4ARAEAdAP/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBAAAALgBEAQB3A/////8BAf//" +
           "//8AAAAA";
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

    #region SetTypeState Class
    #if (!OPCUA_EXCLUDE_SetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public SetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.SetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (NodeVersion != null)
            {
                NodeVersion.Initialize(context, NodeVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string NodeVersion_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YKkKAgAAAAAACwAAAE5vZGVWZXJz" +
           "aW9uAQG7FwMAAAAApQAAAE5vZGVWZXJzaW9uIGFuZCB0aGUgR2VuZXJhbE1vZGVsQ2hhbmdlRXZlbnRU" +
           "eXBlIGFyZSBtZWNoYW5pc21zIHRvIG5vdGlmeSBjbGllbnRzIHRoYXQgdGhlIGNvbnRlbnQgb2YgdGhl" +
           "IHNldCBoYXMgY2hhbmdlZCBhbmQgc2hhbGwgYmUgdXNlZCBhcyBkZWZpbmVkIGluIE9QQyAxMDAwMC0z" +
           "LgAuAES7FwAADAMAAABOYU4ADP////8DA/////8AAAAA";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEADwAAAFNldFR5cGVJ" +
           "bnN0YW5jZQEBPQABAT0APQAAAAEAAAAAKQABAFUIAQAAADVgqQoCAAAAAAALAAAATm9kZVZlcnNpb24B" +
           "AbsXAwAAAAClAAAATm9kZVZlcnNpb24gYW5kIHRoZSBHZW5lcmFsTW9kZWxDaGFuZ2VFdmVudFR5cGUg" +
           "YXJlIG1lY2hhbmlzbXMgdG8gbm90aWZ5IGNsaWVudHMgdGhhdCB0aGUgY29udGVudCBvZiB0aGUgc2V0" +
           "IGhhcyBjaGFuZ2VkIGFuZCBzaGFsbCBiZSB1c2VkIGFzIGRlZmluZWQgaW4gT1BDIDEwMDAwLTMuAC4A" +
           "RLsXAAAMAwAAAE5hTgAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> NodeVersion
        {
            get
            {
                return m_nodeVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nodeVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nodeVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_nodeVersion != null)
            {
                children.Add(m_nodeVersion);
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
                case Opc.Ua.BrowseNames.NodeVersion:
                {
                    if (createOrReplace)
                    {
                        if (NodeVersion == null)
                        {
                            if (replacement == null)
                            {
                                NodeVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                NodeVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NodeVersion;
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
        private PropertyState<string> m_nodeVersion;
        #endregion
    }
    #endif
    #endregion

    #region VariableSetTypeState Class
    #if (!OPCUA_EXCLUDE_VariableSetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VariableSetTypeState : SetTypeState
    {
        #region Constructors
        /// <remarks />
        public VariableSetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.VariableSetType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAFwAAAFZhcmlhYmxl" +
           "U2V0VHlwZUluc3RhbmNlAQERBAEBEQQRBAAAAQAAAAApAAEAVQgAAAAA";
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

    #region AnalogSensorFunctionTypeState Class
    #if (!OPCUA_EXCLUDE_AnalogSensorFunctionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorFunctionTypeState : BaseSensorFunctionTypeState
    {
        #region Constructors
        /// <remarks />
        public AnalogSensorFunctionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.AnalogSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (AlarmMonitor != null)
            {
                AlarmMonitor.Initialize(context, AlarmMonitor_InitializationString);
            }

            if (CalibrationValues != null)
            {
                CalibrationValues.Initialize(context, CalibrationValues_InitializationString);
            }

            if (Damping != null)
            {
                Damping.Initialize(context, Damping_InitializationString);
            }

            if (Calibration != null)
            {
                Calibration.Initialize(context, Calibration_InitializationString);
            }

            if (Tuning != null)
            {
                Tuning.Initialize(context, Tuning_InitializationString);
            }
        }

        #region Initialization String
        private const string AlarmMonitor_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEADAAAAEFsYXJtTW9u" +
           "aXRvcgEBzRMDAAAAAIgAAABBbGFybU1vbml0b3IgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIGxpbWl0IG9m" +
           "IGFuIGFuYWxvZ3VlIFNlbnNvciBpcyBleGNlZWRlZC4gU2VlOiAxMDAwMC05OiBBbGFybXMgJiBDb25k" +
           "aXRpb25zIHwgRXhjbHVzaXZlTGV2ZWxBbGFybVR5cGUuAC8BAAolzRMAAP////8dAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQFHGAAuAERHGAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQFIGAAuAERIGAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBTRgA" +
           "LgBETRgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAUwYAC4AREwYAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFOGAAuAEROGAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBShgALgBEShgAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBSRgALgBESRgAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQFLGAAuAERLGAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBPxgALgBEPxgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBQBgALgBEQBgAAAAV/////wEB/////wAAAAAXYIkIAgAAAAAAEwAAAENvbmRpdGlvblN1" +
           "YkNsYXNzSWQBAQAAAC4ARAARAQAAAAEAAAAAAAAAAQH/////AAAAABdgiQgCAAAAAAAVAAAAQ29uZGl0" +
           "aW9uU3ViQ2xhc3NOYW1lAQEAAAAuAEQAFQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAUEYAC4AREEYAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBOxgALgBEOxgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBRhgALgBE" +
           "RhgAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBMxgALwEAIyMzGAAA" +
           "ABX/////AQEFAAAAAQAsIwABATcYAQAsIwADAQA0AAAAQW5hbG9nU2Vuc29yRnVuY3Rpb25UeXBlX0Fs" +
           "YXJtTW9uaXRvcl9Db25maXJtZWRTdGF0ZQEALCMAAQEvGAEALCMAAwEANQAAAEFuYWxvZ1NlbnNvckZ1" +
           "bmN0aW9uVHlwZV9BbGFybU1vbml0b3JfU3VwcHJlc3NlZFN0YXRlAQAsIwADAQAzAAAAQW5hbG9nU2Vu" +
           "c29yRnVuY3Rpb25UeXBlX0FsYXJtTW9uaXRvcl9TaGVsdmluZ1N0YXRlAQAAABVgiQoCAAAAAAACAAAA" +
           "SWQBATQYAC4ARDQYAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQFEGAAvAQAq" +
           "I0QYAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAUUYAC4AREUY" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBQhgALwEAKiNCGAAA" +
           "AAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFDGAAuAERDGAAAAQAm" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQE9GAAvAQAqIz0YAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAT4YAC4ARD4YAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBPBgALgBEPBgAAAAM/////wEB/////wAAAAAE" +
           "YYIKBAAAAAAABwAAAERpc2FibGUBAYAbAC8BAEQjgBsAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAA" +
           "AAAABgAAAEVuYWJsZQEBgRsALwEAQyOBGwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAA" +
           "QWRkQ29tbWVudAEBfxsALwEARSN/GwAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAToYAC4ARDoYAACWAgAAAAEAKgEBQgAAAAcAAABFdmVudElkAA//////AAAAAAIo" +
           "AAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBPgAAAAcAAABDb21t" +
           "ZW50ABX/////AAAAAAIkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEA" +
           "AAABAAAAAgAAAAEB/////wAAAAAVYIkKAgAAAAAACgAAAEFja2VkU3RhdGUBATcYAC8BACMjNxgAAAAV" +
           "/////wEBAQAAAAEALCMBAQEzGAEAAAAVYIkKAgAAAAAAAgAAAElkAQE4GAAuAEQ4GAAAAAH/////AQH/" +
           "////AAAAAARhggoEAAAAAAALAAAAQWNrbm93bGVkZ2UBAX4bAC8BAJcjfhsAAAEBAQAAAAEA+QsAAQDw" +
           "IgEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE5GAAuAEQ5GAAAlgIAAAABACoBAUIAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAACKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAT4AAAAHAAAAQ29tbWVudAAV/////wAAAAACJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCgIAAAAAAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBLxgALwEAIyMvGAAAABX/////AQECAAAAAQAsIwEBATMYAQAsIwABAc4TAQAAABVgiQoC" +
           "AAAAAAACAAAASWQBATAYAC4ARDAYAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABJbnB1dE5v" +
           "ZGUBATUYAC4ARDUYAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABMAAABTdXBwcmVzc2VkT3JTaGVs" +
           "dmVkAQE2GAAuAEQ2GAAAAAH/////AQH/////AAAAAARggAoBAAAAAAAKAAAATGltaXRTdGF0ZQEBzhMA" +
           "LwEAZiTOEwAAAQAAAAEALCMBAQEvGAEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBMRgALwEA" +
           "yAoxGAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBATIYAC4ARDIYAAAAEf////8BAf//" +
           "//8AAAAA";

        private const string CalibrationValues_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////83YIkKAgAAAAEAEQAAAENhbGlicmF0" +
           "aW9uVmFsdWVzAQGUFwMAAAAAcQAAAENhbGlicmF0aW9uVmFsdWVzIGlzIGFuIGFycmF5IG9mIGNhbGli" +
           "cmF0aW9uIHZhbHVlcyBmb3IgY29udmVydGluZyB0aGUgU2Vuc29y4oCZcyByYXcgdmFsdWUgdG8gdGhl" +
           "IHByb2Nlc3MgdmFsdWUuAC8AP5QXAAAACwEAAAABAAAAAQAAAAMD/////wAAAAA=";

        private const string Damping_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////81YIkKAgAAAAEABwAAAERhbXBpbmcB" +
           "AZYXAwAAAAA/AAAARGFtcGluZyBpcyBhIGxvdy1wYXNzIGZpbHRlciBwYXJhbWV0ZXIgdXNlZCBmb3Ig" +
           "c2lnbmFsIGRhbXBpbmcuAC4ARJYXAAAAC/////8DA/////8AAAAA";

        private const string Calibration_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEACwAAAENhbGlicmF0" +
           "aW9uAQEPFAMAAAAATQAAAENhbGlicmF0aW9uIGlzIHVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBm" +
           "b3IgY29uZmlndXJhdGlvbiBvZiB0aGlzIEZ1bmN0aW9uAC8BAu0DDxQAAP////8AAAAA";

        private const string Tuning_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8kYIAKAQAAAAEABgAAAFR1bmluZwEB" +
           "khMDAAAAAEUAAABUdW5pbmcgaXMgdXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBvcGVyYXRp" +
           "b24gb2YgdGhpcyBGdW5jdGlvbi4ALwEC7QOSEwAA/////wAAAAA=";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAIAAAAEFuYWxvZ1Nl" +
           "bnNvckZ1bmN0aW9uVHlwZUluc3RhbmNlAQEWBAEBFgQWBAAA/////wkAAAA1YIkKAgAAAAEACQAAAElz" +
           "RW5hYmxlZAEBchcDAAAAAMYAAABJc0VuYWJsZWQgaW5kaWNhdGVzIHdoZXRoZXIgdGhlIEZ1bmN0aW9u" +
           "IGNhbiBjdXJyZW50bHkgYmUgZXhlY3V0ZWQgb24gdGhlIERldmljZS4gQSBGdW5jdGlvbiBtYXkgYmUg" +
           "ZGlzYWJsZWQgZm9yIHNldmVyYWwgcmVhc29ucyBpbmNsdWRpbmcgbm90IGxpY2Vuc2VkLCBtaXNzaW5n" +
           "IGhhcmR3YXJlIG1vZHVsZXMsIG9yIG1pc3Npbmcgc3VwcGxpZXMALgBEchcAAAAB/////wMD/////wAA" +
           "AAAkYIAKAQAAAAEADAAAAEFsYXJtTW9uaXRvcgEBzRMDAAAAAIgAAABBbGFybU1vbml0b3IgaW5kaWNh" +
           "dGVzIHdoZXRoZXIgdGhlIGxpbWl0IG9mIGFuIGFuYWxvZ3VlIFNlbnNvciBpcyBleGNlZWRlZC4gU2Vl" +
           "OiAxMDAwMC05OiBBbGFybXMgJiBDb25kaXRpb25zIHwgRXhjbHVzaXZlTGV2ZWxBbGFybVR5cGUuAC8B" +
           "AAolzRMAAP////8dAAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQFHGAAuAERHGAAAAA//////AQH/////" +
           "AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQFIGAAuAERIGAAAABH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAKAAAAU291cmNlTm9kZQEBTRgALgBETRgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAA" +
           "AFNvdXJjZU5hbWUBAUwYAC4AREwYAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFO" +
           "GAAuAEROGAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBShgALgBE" +
           "ShgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBSRgALgBESRgAAAAV////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AQFLGAAuAERLGAAAAAX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBPxgALgBEPxgAAAAR/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBQBgALgBEQBgAAAAV/////wEB/////wAAAAAX" +
           "YIkIAgAAAAAAEwAAAENvbmRpdGlvblN1YkNsYXNzSWQBAQAAAC4ARAARAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgiQgCAAAAAAAVAAAAQ29uZGl0aW9uU3ViQ2xhc3NOYW1lAQEAAAAuAEQAFQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAUEYAC4AREEYAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBOxgALgBEOxgAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABgAAAFJldGFpbgEBRhgALgBERhgAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVu" +
           "YWJsZWRTdGF0ZQEBMxgALwEAIyMzGAAAABX/////AQEFAAAAAQAsIwABATcYAQAsIwADAQA0AAAAQW5h" +
           "bG9nU2Vuc29yRnVuY3Rpb25UeXBlX0FsYXJtTW9uaXRvcl9Db25maXJtZWRTdGF0ZQEALCMAAQEvGAEA" +
           "LCMAAwEANQAAAEFuYWxvZ1NlbnNvckZ1bmN0aW9uVHlwZV9BbGFybU1vbml0b3JfU3VwcHJlc3NlZFN0" +
           "YXRlAQAsIwADAQAzAAAAQW5hbG9nU2Vuc29yRnVuY3Rpb25UeXBlX0FsYXJtTW9uaXRvcl9TaGVsdmlu" +
           "Z1N0YXRlAQAAABVgiQoCAAAAAAACAAAASWQBATQYAC4ARDQYAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQFEGAAvAQAqI0QYAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAUUYAC4AREUYAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBQhgALwEAKiNCGAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFDGAAuAERDGAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQE9GAAvAQAqIz0YAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AT4YAC4ARD4YAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBPBgA" +
           "LgBEPBgAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYAbAC8BAEQjgBsAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBgRsALwEAQyOBGwAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBfxsALwEARSN/GwAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAToYAC4ARDoYAACWAgAAAAEAKgEBQgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAIoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBPgAAAAcAAABDb21tZW50ABX/////AAAAAAIkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAVYIkKAgAAAAAACgAAAEFj" +
           "a2VkU3RhdGUBATcYAC8BACMjNxgAAAAV/////wEBAQAAAAEALCMBAQEzGAEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQE4GAAuAEQ4GAAAAAH/////AQH/////AAAAAARhggoEAAAAAAALAAAAQWNrbm93bGVkZ2UBAX4b" +
           "AC8BAJcjfhsAAAEBAQAAAAEA+QsAAQDwIgEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE5" +
           "GAAuAEQ5GAAAlgIAAAABACoBAUIAAAAHAAAARXZlbnRJZAAP/////wAAAAACKAAAAFRoZSBpZGVudGlm" +
           "aWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAT4AAAAHAAAAQ29tbWVudAAV/////wAAAAAC" +
           "JAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABBY3RpdmVTdGF0ZQEBLxgALwEAIyMvGAAAABX/////AQECAAAAAQAs" +
           "IwEBATMYAQAsIwABAc4TAQAAABVgiQoCAAAAAAACAAAASWQBATAYAC4ARDAYAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAkAAABJbnB1dE5vZGUBATUYAC4ARDUYAAAAEf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABMAAABTdXBwcmVzc2VkT3JTaGVsdmVkAQE2GAAuAEQ2GAAAAAH/////AQH/////AAAAAARggAoB" +
           "AAAAAAAKAAAATGltaXRTdGF0ZQEBzhMALwEAZiTOEwAAAQAAAAEALCMBAQEvGAEAAAAVYIkKAgAAAAAA" +
           "DAAAAEN1cnJlbnRTdGF0ZQEBMRgALwEAyAoxGAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAA" +
           "SWQBATIYAC4ARDIYAAAAEf////8BAf////8AAAAAJGCACgEAAAABAAsAAABPcGVyYXRpb25hbAEBkxMD" +
           "AAAAADsAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIG9wZXJhdGlvbiBvZiB0aGlzIGZ1" +
           "bmN0aW9uLgAvAQLtA5MTAAD/////AAAAADdgiQoCAAAAAQARAAAAQ2FsaWJyYXRpb25WYWx1ZXMBAZQX" +
           "AwAAAABxAAAAQ2FsaWJyYXRpb25WYWx1ZXMgaXMgYW4gYXJyYXkgb2YgY2FsaWJyYXRpb24gdmFsdWVz" +
           "IGZvciBjb252ZXJ0aW5nIHRoZSBTZW5zb3LigJlzIHJhdyB2YWx1ZSB0byB0aGUgcHJvY2VzcyB2YWx1" +
           "ZS4ALwA/lBcAAAALAQAAAAEAAAABAAAAAwP/////AAAAADVgiQoCAAAAAQAHAAAARGFtcGluZwEBlhcD" +
           "AAAAAD8AAABEYW1waW5nIGlzIGEgbG93LXBhc3MgZmlsdGVyIHBhcmFtZXRlciB1c2VkIGZvciBzaWdu" +
           "YWwgZGFtcGluZy4ALgBElhcAAAAL/////wMD/////wAAAAAkYIAKAQAAAAEACwAAAENhbGlicmF0aW9u" +
           "AQEPFAMAAAAATQAAAENhbGlicmF0aW9uIGlzIHVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3Ig" +
           "Y29uZmlndXJhdGlvbiBvZiB0aGlzIEZ1bmN0aW9uAC8BAu0DDxQAAP////8AAAAAJGCACgEAAAABAAYA" +
           "AABUdW5pbmcBAZITAwAAAABFAAAAVHVuaW5nIGlzIHVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBm" +
           "b3Igb3BlcmF0aW9uIG9mIHRoaXMgRnVuY3Rpb24uAC8BAu0DkhMAAP////8AAAAANWCBCgIAAAABAAgA" +
           "AABSYXdWYWx1ZQEBmBcDAAAAAGwAAABSYXdWYWx1ZSBpcyB0aGUgcmF3IHZhbHVlIG1lYXN1cmVkIGF0" +
           "IHRoZSBTZW5zb3IgZWxlbWVudCwgc3VjaCBhcyB0aGUgTmVybnN0IHZvbHRhZ2Ugb2YgYSBwSCBTZW5z" +
           "b3IgZWxlbWVudC4ALwEAokSYFwAAAAsDA/////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEAAAAu" +
           "AEQBAHQD/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4ARAEA" +
           "dwP/////AQH/////AAAAADVggQoCAAAAAQALAAAAU2Vuc29yVmFsdWUBAeAXAwAAAABQAAAAU2Vuc29y" +
           "VmFsdWUgaXMgdGhlIGNhbGlicmF0ZWQgYW5kIG9wdGlvbmFsbHkgY29tcGVuc2F0ZWQvZmlsdGVyZWQg" +
           "cHJvY2VzcyB2YWx1ZS4ALwEAokTgFwAAAAsDA/////8CAAAAFWCJCAIAAAAAAAcAAABFVVJhbmdlAQEA" +
           "AAAuAEQBAHQD/////wEB/////wAAAAAVYIkIAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4A" +
           "RAEAdwP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ExclusiveLevelAlarmState AlarmMonitor
        {
            get
            {
                return m_alarmMonitor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmMonitor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmMonitor = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double[]> CalibrationValues
        {
            get
            {
                return m_calibrationValues;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationValues, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationValues = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Damping
        {
            get
            {
                return m_damping;
            }

            set
            {
                if (!Object.ReferenceEquals(m_damping, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_damping = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState Calibration
        {
            get
            {
                return m_calibration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibration = value;
            }
        }

        /// <remarks />
        public FunctionalGroupTypeState Tuning
        {
            get
            {
                return m_tuning;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tuning, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tuning = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState RawValue
        {
            get
            {
                return m_rawValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rawValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rawValue = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState SensorValue
        {
            get
            {
                return m_sensorValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sensorValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sensorValue = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_alarmMonitor != null)
            {
                children.Add(m_alarmMonitor);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
            }

            if (m_calibrationValues != null)
            {
                children.Add(m_calibrationValues);
            }

            if (m_damping != null)
            {
                children.Add(m_damping);
            }

            if (m_calibration != null)
            {
                children.Add(m_calibration);
            }

            if (m_tuning != null)
            {
                children.Add(m_tuning);
            }

            if (m_rawValue != null)
            {
                children.Add(m_rawValue);
            }

            if (m_sensorValue != null)
            {
                children.Add(m_sensorValue);
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
                case Opc.Ua.LADS.BrowseNames.AlarmMonitor:
                {
                    if (createOrReplace)
                    {
                        if (AlarmMonitor == null)
                        {
                            if (replacement == null)
                            {
                                AlarmMonitor = new ExclusiveLevelAlarmState(this);
                            }
                            else
                            {
                                AlarmMonitor = (ExclusiveLevelAlarmState)replacement;
                            }
                        }
                    }

                    instance = AlarmMonitor;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Operational;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.CalibrationValues:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationValues == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationValues = new BaseDataVariableState<double[]>(this);
                            }
                            else
                            {
                                CalibrationValues = (BaseDataVariableState<double[]>)replacement;
                            }
                        }
                    }

                    instance = CalibrationValues;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Damping:
                {
                    if (createOrReplace)
                    {
                        if (Damping == null)
                        {
                            if (replacement == null)
                            {
                                Damping = new PropertyState<double>(this);
                            }
                            else
                            {
                                Damping = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Damping;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Calibration:
                {
                    if (createOrReplace)
                    {
                        if (Calibration == null)
                        {
                            if (replacement == null)
                            {
                                Calibration = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Calibration = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Calibration;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.Tuning:
                {
                    if (createOrReplace)
                    {
                        if (Tuning == null)
                        {
                            if (replacement == null)
                            {
                                Tuning = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Tuning = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Tuning;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.RawValue:
                {
                    if (createOrReplace)
                    {
                        if (RawValue == null)
                        {
                            if (replacement == null)
                            {
                                RawValue = new AnalogUnitRangeState(this);
                            }
                            else
                            {
                                RawValue = (AnalogUnitRangeState)replacement;
                            }
                        }
                    }

                    instance = RawValue;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new AnalogUnitRangeState(this);
                            }
                            else
                            {
                                SensorValue = (AnalogUnitRangeState)replacement;
                            }
                        }
                    }

                    instance = SensorValue;
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
        private ExclusiveLevelAlarmState m_alarmMonitor;
        private FunctionalGroupTypeState m_operational;
        private BaseDataVariableState<double[]> m_calibrationValues;
        private PropertyState<double> m_damping;
        private FunctionalGroupTypeState m_calibration;
        private FunctionalGroupTypeState m_tuning;
        private AnalogUnitRangeState m_rawValue;
        private AnalogUnitRangeState m_sensorValue;
        #endregion
    }
    #endif
    #endregion

    #region LADSOperationModeStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_LADSOperationModeStateMachineTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSOperationModeStateMachineTypeState : MachineryOperationModeStateMachineTypeState
    {
        #region Constructors
        /// <remarks />
        public LADSOperationModeStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.LADS.ObjectTypes.LADSOperationModeStateMachineType, Opc.Ua.LADS.Namespaces.LADS, namespaceUris);
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

            if (GotoProcessing != null)
            {
                GotoProcessing.Initialize(context, GotoProcessing_InitializationString);
            }

            if (GotoMaintenance != null)
            {
                GotoMaintenance.Initialize(context, GotoMaintenance_InitializationString);
            }

            if (GotoSetup != null)
            {
                GotoSetup.Initialize(context, GotoSetup_InitializationString);
            }
        }

        #region Initialization String
        private const string GotoProcessing_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEADgAAAEdvdG9Qcm9j" +
           "ZXNzaW5nAQFsGwAvAQFsG2wbAAABAf////8AAAAA";

        private const string GotoMaintenance_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEADwAAAEdvdG9NYWlu" +
           "dGVuYW5jZQEBjxsALwEBjxuPGwAAAQH/////AAAAAA==";

        private const string GotoSetup_InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIKBAAAAAEACQAAAEdvdG9TZXR1" +
           "cAEBkBsALwEBkBuQGwAAAQH/////AAAAAA==";

        private const string InitializationString =
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYIACAQAAAAEAKQAAAExBRFNPcGVy" +
           "YXRpb25Nb2RlU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQEaBAEBGgQaBAAA/////wQAAAAVYIkIAgAA" +
           "AAAADAAAAEN1cnJlbnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJCAIAAAAAAAIAAABJ" +
           "ZAEBAAAALgBEABH/////AQH/////AAAAAARhggoEAAAAAQAOAAAAR290b1Byb2Nlc3NpbmcBAWwbAC8B" +
           "AWwbbBsAAAEB/////wAAAAAEYYIKBAAAAAEADwAAAEdvdG9NYWludGVuYW5jZQEBjxsALwEBjxuPGwAA" +
           "AQH/////AAAAAARhggoEAAAAAQAJAAAAR290b1NldHVwAQGQGwAvAQGQG5AbAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState GotoProcessing
        {
            get
            {
                return m_gotoProcessingMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoProcessingMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoProcessingMethod = value;
            }
        }

        /// <remarks />
        public MethodState GotoMaintenance
        {
            get
            {
                return m_gotoMaintenanceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoMaintenanceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoMaintenanceMethod = value;
            }
        }

        /// <remarks />
        public MethodState GotoSetup
        {
            get
            {
                return m_gotoSetupMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoSetupMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoSetupMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_gotoProcessingMethod != null)
            {
                children.Add(m_gotoProcessingMethod);
            }

            if (m_gotoMaintenanceMethod != null)
            {
                children.Add(m_gotoMaintenanceMethod);
            }

            if (m_gotoSetupMethod != null)
            {
                children.Add(m_gotoSetupMethod);
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
                case Opc.Ua.LADS.BrowseNames.GotoProcessing:
                {
                    if (createOrReplace)
                    {
                        if (GotoProcessing == null)
                        {
                            if (replacement == null)
                            {
                                GotoProcessing = new MethodState(this);
                            }
                            else
                            {
                                GotoProcessing = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GotoProcessing;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.GotoMaintenance:
                {
                    if (createOrReplace)
                    {
                        if (GotoMaintenance == null)
                        {
                            if (replacement == null)
                            {
                                GotoMaintenance = new MethodState(this);
                            }
                            else
                            {
                                GotoMaintenance = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GotoMaintenance;
                    break;
                }

                case Opc.Ua.LADS.BrowseNames.GotoSetup:
                {
                    if (createOrReplace)
                    {
                        if (GotoSetup == null)
                        {
                            if (replacement == null)
                            {
                                GotoSetup = new MethodState(this);
                            }
                            else
                            {
                                GotoSetup = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GotoSetup;
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
        private MethodState m_gotoProcessingMethod;
        private MethodState m_gotoMaintenanceMethod;
        private MethodState m_gotoSetupMethod;
        #endregion
    }
    #endif
    #endregion

    #region BreakLockMethodState Class
    #if (!OPCUA_EXCLUDE_BreakLockMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BreakLockMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public BreakLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new BreakLockMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEwAAAEJyZWFrTG9j" +
           "a01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public BreakLockMethodStateMethodCallHandler OnCall;
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

            int breakLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref breakLockStatus);
            }

            _outputArguments[0] = breakLockStatus;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult BreakLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int breakLockStatus);
    #endif
    #endregion

    #region ExitLockMethodState Class
    #if (!OPCUA_EXCLUDE_ExitLockMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExitLockMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ExitLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ExitLockMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEgAAAEV4aXRMb2Nr" +
           "TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ExitLockMethodStateMethodCallHandler OnCall;
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

            int exitLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref exitLockStatus);
            }

            _outputArguments[0] = exitLockStatus;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ExitLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int exitLockStatus);
    #endif
    #endregion

    #region InitLockMethodState Class
    #if (!OPCUA_EXCLUDE_InitLockMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InitLockMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public InitLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new InitLockMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEgAAAEluaXRMb2Nr" +
           "TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public InitLockMethodStateMethodCallHandler OnCall;
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

            string context = (string)_inputArguments[0];

            int initLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    context,
                    ref initLockStatus);
            }

            _outputArguments[0] = initLockStatus;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult InitLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string context,
        ref int initLockStatus);
    #endif
    #endregion

    #region RenewLockMethodState Class
    #if (!OPCUA_EXCLUDE_RenewLockMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RenewLockMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RenewLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RenewLockMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEwAAAFJlbmV3TG9j" +
           "a01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RenewLockMethodStateMethodCallHandler OnCall;
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

            int renewLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref renewLockStatus);
            }

            _outputArguments[0] = renewLockStatus;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RenewLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int renewLockStatus);
    #endif
    #endregion

    #region AcknowledgeMethodState Class
    #if (!OPCUA_EXCLUDE_AcknowledgeMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AcknowledgeMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public AcknowledgeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new AcknowledgeMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAFQAAAEFja25vd2xl" +
           "ZGdlTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public AcknowledgeMethodStateMethodCallHandler OnCall;
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

            byte[] eventId = (byte[])_inputArguments[0];
            LocalizedText comment = (LocalizedText)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    eventId,
                    comment);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult AcknowledgeMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        byte[] eventId,
        LocalizedText comment);
    #endif
    #endregion

    #region AddCommentMethodState Class
    #if (!OPCUA_EXCLUDE_AddCommentMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AddCommentMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public AddCommentMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new AddCommentMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAFAAAAEFkZENvbW1l" +
           "bnRNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public AddCommentMethodStateMethodCallHandler OnCall;
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

            byte[] eventId = (byte[])_inputArguments[0];
            LocalizedText comment = (LocalizedText)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    eventId,
                    comment);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult AddCommentMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        byte[] eventId,
        LocalizedText comment);
    #endif
    #endregion

    #region DownloadMethodState Class
    #if (!OPCUA_EXCLUDE_DownloadMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DownloadMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public DownloadMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new DownloadMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEgAAAERvd25sb2Fk" +
           "TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public DownloadMethodStateMethodCallHandler OnCall;
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

            string templateId = (string)_inputArguments[0];

            KeyValueType[] additionalParameters = (KeyValueType[])_outputArguments[0];
            byte[] data = (byte[])_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    templateId,
                    ref additionalParameters,
                    ref data);
            }

            _outputArguments[0] = additionalParameters;
            _outputArguments[1] = data;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult DownloadMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string templateId,
        ref KeyValueType[] additionalParameters,
        ref byte[] data);
    #endif
    #endregion

    #region RemoveMethodState Class
    #if (!OPCUA_EXCLUDE_RemoveMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RemoveMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RemoveMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RemoveMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEAAAAFJlbW92ZU1l" +
           "dGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RemoveMethodStateMethodCallHandler OnCall;
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

            string templateId = (string)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    templateId);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RemoveMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string templateId);
    #endif
    #endregion

    #region UploadMethodState Class
    #if (!OPCUA_EXCLUDE_UploadMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class UploadMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public UploadMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new UploadMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEAAAAFVwbG9hZE1l" +
           "dGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public UploadMethodStateMethodCallHandler OnCall;
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

            KeyValueType[] additionalParameters = (KeyValueType[])ExtensionObject.ToArray(_inputArguments[0], typeof(KeyValueType));
            byte[] data = (byte[])_inputArguments[1];

            string templateId = (string)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    additionalParameters,
                    data,
                    ref templateId);
            }

            _outputArguments[0] = templateId;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult UploadMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        KeyValueType[] additionalParameters,
        byte[] data,
        ref string templateId);
    #endif
    #endregion

    #region ResetTotalizerMethodState Class
    #if (!OPCUA_EXCLUDE_ResetTotalizerMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResetTotalizerMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ResetTotalizerMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ResetTotalizerMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAGAAAAFJlc2V0VG90" +
           "YWxpemVyTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ResetTotalizerMethodStateMethodCallHandler OnCall;
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

            double value = (double)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    value);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ResetTotalizerMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double value);
    #endif
    #endregion

    #region StopTaskMethodState Class
    #if (!OPCUA_EXCLUDE_StopTaskMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StopTaskMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public StopTaskMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new StopTaskMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAEgAAAFN0b3BUYXNr" +
           "TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public StopTaskMethodStateMethodCallHandler OnCall;
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

            MaintenanceTaskResultEnum maintenanceTaskStopResult = (MaintenanceTaskResultEnum)_inputArguments[0];
            LocalizedText comment = (LocalizedText)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    maintenanceTaskStopResult,
                    comment);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult StopTaskMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        MaintenanceTaskResultEnum maintenanceTaskStopResult,
        LocalizedText comment);
    #endif
    #endregion

    #region StartMethodState Class
    #if (!OPCUA_EXCLUDE_StartMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public StartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new StartMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEADwAAAFN0YXJ0TWV0" +
           "aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public StartMethodStateMethodCallHandler OnCall;
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

            Opc.Ua.KeyValuePair[] properties = (Opc.Ua.KeyValuePair[])ExtensionObject.ToArray(_inputArguments[0], typeof(Opc.Ua.KeyValuePair));

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    properties);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult StartMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        Opc.Ua.KeyValuePair[] properties);
    #endif
    #endregion

    #region StartWithTargetValueMethodState Class
    #if (!OPCUA_EXCLUDE_StartWithTargetValueMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartWithTargetValueMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public StartWithTargetValueMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new StartWithTargetValueMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAHgAAAFN0YXJ0V2l0" +
           "aFRhcmdldFZhbHVlTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public StartWithTargetValueMethodStateMethodCallHandler OnCall;
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

            object targetValue = (object)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    targetValue);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult StartWithTargetValueMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object targetValue);
    #endif
    #endregion

    #region StartProgramMethodState Class
    #if (!OPCUA_EXCLUDE_StartProgramMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartProgramMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public StartProgramMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new StartProgramMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAFgAAAFN0YXJ0UHJv" +
           "Z3JhbU1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public StartProgramMethodStateMethodCallHandler OnCall;
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

            string programTemplateId = (string)_inputArguments[0];
            KeyValueType[] properties = (KeyValueType[])ExtensionObject.ToArray(_inputArguments[1], typeof(KeyValueType));
            string supervisoryJobId = (string)_inputArguments[2];
            string supervisoryTaskId = (string)_inputArguments[3];
            SampleInfoType[] samples = (SampleInfoType[])ExtensionObject.ToArray(_inputArguments[4], typeof(SampleInfoType));

            string deviceProgramRunId = (string)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    programTemplateId,
                    properties,
                    supervisoryJobId,
                    supervisoryTaskId,
                    samples,
                    ref deviceProgramRunId);
            }

            _outputArguments[0] = deviceProgramRunId;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult StartProgramMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string programTemplateId,
        KeyValueType[] properties,
        string supervisoryJobId,
        string supervisoryTaskId,
        SampleInfoType[] samples,
        ref string deviceProgramRunId);
    #endif
    #endregion

    #region ModifyTargetValueByMethodState Class
    #if (!OPCUA_EXCLUDE_ModifyTargetValueByMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ModifyTargetValueByMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ModifyTargetValueByMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ModifyTargetValueByMethodState(parent);
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
           "BAAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTEFEUy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLyYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5LyAA" +
           "AABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQU1CL/////8EYYIABAAAAAEAHQAAAE1vZGlmeVRh" +
           "cmdldFZhbHVlQnlNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ModifyTargetValueByMethodStateMethodCallHandler OnCall;
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

            double value = (double)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    value);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ModifyTargetValueByMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double value);
    #endif
    #endregion
}