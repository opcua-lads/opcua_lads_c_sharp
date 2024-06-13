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
using Opc.Ua.Machinery;
using Opc.Ua.AMB;

namespace Opc.Ua.LADS
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint KeyValueType = 3003;

        /// <remarks />
        public const uint SampleInfoType = 3002;

        /// <remarks />
        public const uint MaintenanceTaskResultEnum = 3000;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_InitLock = 6166;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_RenewLock = 6169;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_ExitLock = 6171;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_BreakLock = 6173;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_InitLock = 7007;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_RenewLock = 7008;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_ExitLock = 7006;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_BreakLock = 7005;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock = 6166;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_InitLock = 6166;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_RenewLock = 6169;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_ExitLock = 6171;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_BreakLock = 6173;

        /// <remarks />
        public const uint CoverStateMachineType_Close = 7012;

        /// <remarks />
        public const uint CoverStateMachineType_Lock = 7013;

        /// <remarks />
        public const uint CoverStateMachineType_Open = 7011;

        /// <remarks />
        public const uint CoverStateMachineType_Unlock = 7014;

        /// <remarks />
        public const uint CoverStateMachineType_Reset = 7000;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_GotoOperate = 7021;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_GotoShutdown = 7031;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_GotoSleep = 7032;

        /// <remarks />
        public const uint FunctionalStateMachineType_Abort = 7078;

        /// <remarks />
        public const uint FunctionalStateMachineType_Clear = 7079;

        /// <remarks />
        public const uint FunctionalStateMachineType_Stop = 7112;

        /// <remarks />
        public const uint RunningStateMachineType_Hold = 7074;

        /// <remarks />
        public const uint RunningStateMachineType_Reset = 7069;

        /// <remarks />
        public const uint RunningStateMachineType_Suspend = 7073;

        /// <remarks />
        public const uint RunningStateMachineType_ToComplete = 7070;

        /// <remarks />
        public const uint RunningStateMachineType_Unhold = 7072;

        /// <remarks />
        public const uint RunningStateMachineType_Unsuspend = 7075;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Disable = 7048;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Enable = 7047;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__AddComment = 7049;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Acknowledge = 7030;

        /// <remarks />
        public const uint MaintenanceTaskType_StartTask = 7061;

        /// <remarks />
        public const uint MaintenanceTaskType_StopTask = 7001;

        /// <remarks />
        public const uint MaintenanceTaskType_ResetTask = 7003;

        /// <remarks />
        public const uint LADSDeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint LADSDeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint LADSDeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint LADSDeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint LADSDeviceType_DeviceState_GotoOperate = 7124;

        /// <remarks />
        public const uint LADSDeviceType_DeviceState_GotoShutdown = 7125;

        /// <remarks />
        public const uint LADSDeviceType_DeviceState_GotoSleep = 7126;

        /// <remarks />
        public const uint LADSComponentType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint LADSComponentType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint LADSComponentType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint LADSComponentType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_InitLock = 7007;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_RenewLock = 7008;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_ExitLock = 7006;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_BreakLock = 7005;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_InitLock = 6166;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_Clear = 7019;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_Stop = 7024;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_Abort = 7025;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_StartProgram = 7046;

        /// <remarks />
        public const uint FunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint FunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint FunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint FunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint BaseControlFunctionType_Operational_Reset = 7029;

        /// <remarks />
        public const uint BaseControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint AnalogControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_StartWithTargetValue = 7027;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Operational_Stop = 7028;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ResetTotalizer = 7002;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue = 7050;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue = 7054;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Disable = 7040;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Enable = 7041;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_AddComment = 7039;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Acknowledge = 7038;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint CoverFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint CoverFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint CoverFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint CoverFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint ProgramManagerType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint ProgramManagerType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint ProgramManagerType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint ProgramManagerType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint ProgramManagerType_Download = 7051;

        /// <remarks />
        public const uint ProgramManagerType_Remove = 7052;

        /// <remarks />
        public const uint ProgramManagerType_Upload = 7053;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint TimerControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Disable = 7040;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Enable = 7041;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AddComment = 7039;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge = 7038;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Start = 7004;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_StartProgram = 7010;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_StartWithTargetValue = 7009;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Start = 7035;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Operational_Stop = 7028;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Operational_Stop = 7028;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock = 6166;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RenewLock = 6169;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_ExitLock = 6171;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Disable = 7044;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Enable = 7045;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AddComment = 7043;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Acknowledge = 7042;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Operational_Stop = 7028;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueBy = 7022;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Disable = 7040;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Enable = 7041;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_AddComment = 7039;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Acknowledge = 7038;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Disable = 7040;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Enable = 7041;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_AddComment = 7039;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Acknowledge = 7038;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_GotoProcessing = 7020;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_GotoMaintenance = 7055;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_GotoSetup = 7056;

        /// <remarks />
        public const string FunctionalUnitType_Lock_BreakLockMethodType = "";

        /// <remarks />
        public const string FunctionalUnitType_Lock_ExitLockMethodType = "";

        /// <remarks />
        public const string FunctionalUnitType_Lock_InitLockMethodType = "";

        /// <remarks />
        public const string FunctionalUnitType_Lock_RenewLockMethodType = "";

        /// <remarks />
        public const string BaseControlFunctionType_AlarmMonitor_AcknowledgeMethodType = "";

        /// <remarks />
        public const string BaseControlFunctionType_AlarmMonitor_AddCommentMethodType = "";

        /// <remarks />
        public const string ProgramManagerType_DownloadMethodType = "";

        /// <remarks />
        public const string ProgramManagerType_RemoveMethodType = "";

        /// <remarks />
        public const string ProgramManagerType_UploadMethodType = "";

        /// <remarks />
        public const string AnalogControlFunctionWithTotalizerType_ResetTotalizerMethodType = "";

        /// <remarks />
        public const string MaintenanceTaskType_StopTaskMethodType = "";

        /// <remarks />
        public const string FunctionalUnitStateMachineType_StartMethodType = "";

        /// <remarks />
        public const string ControlFunctionStateMachineType_StartWithTargetValueMethodType = "";

        /// <remarks />
        public const string FunctionalUnitStateMachineType_StartProgramMethodType = "";

        /// <remarks />
        public const string AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueByMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint LADSComponentsType_Component_Identification = 5003;

        /// <remarks />
        public const uint LADSComponentsType_S_Component_ = 5065;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Identification = 5095;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement_ = 5016;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock = 5004;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_ActiveProgram = 5218;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_ProgramTemplateSet = 5021;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_ResultSet = 5022;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState = 5005;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement_ = 5027;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement_ = 5029;

        /// <remarks />
        public const uint SupportedPropertiesSetType_SetElement = 5048;

        /// <remarks />
        public const uint ResultFileSetType_S_SetElement_ = 5060;

        /// <remarks />
        public const uint ResultFileType_File = 5072;

        /// <remarks />
        public const uint ResultSetType_S_SetElement_ = 5062;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__FileSet = 5081;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate = 5112;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__VariableSet = 5067;

        /// <remarks />
        public const uint ResultType_FileSet = 5081;

        /// <remarks />
        public const uint ResultType_ProgramTemplate = 5112;

        /// <remarks />
        public const uint ResultType_VariableSet = 5067;

        /// <remarks />
        public const uint CoverStateMachineType_Closed = 5028;

        /// <remarks />
        public const uint CoverStateMachineType_Error = 5050;

        /// <remarks />
        public const uint CoverStateMachineType_Locked = 5049;

        /// <remarks />
        public const uint CoverStateMachineType_Opened = 5025;

        /// <remarks />
        public const uint CoverStateMachineType_OpenedToClosed = 5000;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToOpened = 5074;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToLocked = 5075;

        /// <remarks />
        public const uint CoverStateMachineType_LockedToClosed = 5077;

        /// <remarks />
        public const uint CoverStateMachineType_LockedToError = 5078;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToError = 5079;

        /// <remarks />
        public const uint CoverStateMachineType_ErrorToOpened = 5082;

        /// <remarks />
        public const uint CoverStateMachineType_LockedToUnlocking = 5098;

        /// <remarks />
        public const uint CoverStateMachineType_Unlocking = 5107;

        /// <remarks />
        public const uint CoverStateMachineType_Locking = 5108;

        /// <remarks />
        public const uint CoverStateMachineType_Opening = 5109;

        /// <remarks />
        public const uint CoverStateMachineType_Closing = 5110;

        /// <remarks />
        public const uint CoverStateMachineType_UnlockingToClosed = 5114;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToOpening = 5115;

        /// <remarks />
        public const uint CoverStateMachineType_OpeningToOpened = 5136;

        /// <remarks />
        public const uint CoverStateMachineType_OpenedToClosing = 5137;

        /// <remarks />
        public const uint CoverStateMachineType_ClosingToClosed = 5138;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToLocking = 5139;

        /// <remarks />
        public const uint CoverStateMachineType_LockingToLocked = 5140;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Operate = 5178;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_OperateToShutdown = 5184;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_OperateToSleep = 5260;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Initialization = 5177;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_InitializationToOperate = 5181;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Shutdown = 5180;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Sleep = 5259;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_SleepToOperate = 5083;

        /// <remarks />
        public const uint FunctionalStateMachineType_Aborted = 5160;

        /// <remarks />
        public const uint FunctionalStateMachineType_AbortedToClearing = 5165;

        /// <remarks />
        public const uint FunctionalStateMachineType_Aborting = 5159;

        /// <remarks />
        public const uint FunctionalStateMachineType_AbortingToAborted = 5126;

        /// <remarks />
        public const uint FunctionalStateMachineType_Clearing = 5143;

        /// <remarks />
        public const uint FunctionalStateMachineType_Stopped = 5085;

        /// <remarks />
        public const uint FunctionalStateMachineType_Running = 5099;

        /// <remarks />
        public const uint FunctionalStateMachineType_Stopping = 5100;

        /// <remarks />
        public const uint FunctionalStateMachineType_StoppingToStopped = 5101;

        /// <remarks />
        public const uint FunctionalStateMachineType_StoppedToRunning = 5102;

        /// <remarks />
        public const uint FunctionalStateMachineType_RunningToAborting = 5103;

        /// <remarks />
        public const uint FunctionalStateMachineType_ClearingToStopped = 5104;

        /// <remarks />
        public const uint FunctionalStateMachineType_RunningToStopping = 5105;

        /// <remarks />
        public const uint FunctionalStateMachineType_RunningStateMachine = 5130;

        /// <remarks />
        public const uint RunningStateMachineType_Complete = 5128;

        /// <remarks />
        public const uint RunningStateMachineType_Completing = 5127;

        /// <remarks />
        public const uint RunningStateMachineType_Execute = 5168;

        /// <remarks />
        public const uint RunningStateMachineType_Held = 5124;

        /// <remarks />
        public const uint RunningStateMachineType_Holding = 5123;

        /// <remarks />
        public const uint RunningStateMachineType_Idle = 5120;

        /// <remarks />
        public const uint RunningStateMachineType_Resetting = 5119;

        /// <remarks />
        public const uint RunningStateMachineType_Starting = 5117;

        /// <remarks />
        public const uint RunningStateMachineType_Suspended = 5121;

        /// <remarks />
        public const uint RunningStateMachineType_Suspending = 5118;

        /// <remarks />
        public const uint RunningStateMachineType_Unholding = 5125;

        /// <remarks />
        public const uint RunningStateMachineType_Unsuspending = 5122;

        /// <remarks />
        public const uint RunningStateMachineType_IdleToStarting = 5031;

        /// <remarks />
        public const uint RunningStateMachineType_StartingToExecute = 5032;

        /// <remarks />
        public const uint RunningStateMachineType_ExecuteToCompleting = 5033;

        /// <remarks />
        public const uint RunningStateMachineType_CompletingToComplete = 5034;

        /// <remarks />
        public const uint RunningStateMachineType_CompleteToResetting = 5035;

        /// <remarks />
        public const uint RunningStateMachineType_ResettingToIdle = 5036;

        /// <remarks />
        public const uint RunningStateMachineType_ExecuteToSuspending = 5037;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendingToSuspended = 5039;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendedToUnsuspending = 5040;

        /// <remarks />
        public const uint RunningStateMachineType_UnsuspendingToExecute = 5041;

        /// <remarks />
        public const uint RunningStateMachineType_ExecuteToHolding = 5051;

        /// <remarks />
        public const uint RunningStateMachineType_HoldingToHeld = 5052;

        /// <remarks />
        public const uint RunningStateMachineType_HeldToUnholding = 5053;

        /// <remarks />
        public const uint RunningStateMachineType_UnholdingToExecute = 5054;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendingToHolding = 5129;

        /// <remarks />
        public const uint RunningStateMachineType_StartingToHolding = 5131;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendedToHolding = 5132;

        /// <remarks />
        public const uint RunningStateMachineType_UnsuspendingToHolding = 5133;

        /// <remarks />
        public const uint RunningStateMachineType_UnholdingToHolding = 5134;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement_ = 5017;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__MaintenanceState = 5018;

        /// <remarks />
        public const uint MaintenanceTaskType_MaintenanceState = 5066;

        /// <remarks />
        public const uint LADSDeviceType_Identification = 5096;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint LADSDeviceType_Components = 5111;

        /// <remarks />
        public const uint LADSDeviceType_FunctionalUnitSet = 5002;

        /// <remarks />
        public const uint LADSDeviceType_DeviceState = 5191;

        /// <remarks />
        public const uint LADSDeviceType_Maintenance = 5092;

        /// <remarks />
        public const uint LADSDeviceType_MachineryBuildingBlocks = 5063;

        /// <remarks />
        public const uint LADSDeviceType_MachineryBuildingBlocks_MachineryItemState = 5089;

        /// <remarks />
        public const uint LADSDeviceType_MachineryBuildingBlocks_MachineryOperationMode = 5090;

        /// <remarks />
        public const uint LADSDeviceType_MachineryBuildingBlocks_LifetimeCounters = 5091;

        /// <remarks />
        public const uint LADSDeviceType_MachineryBuildingBlocks_OperationCounters = 5093;

        /// <remarks />
        public const uint LADSComponentType_Identification = 5095;

        /// <remarks />
        public const uint LADSComponentType_DeviceHealthAlarms = 5258;

        /// <remarks />
        public const uint LADSComponentType_Maintenance = 5106;

        /// <remarks />
        public const uint LADSComponentType_Components = 5073;

        /// <remarks />
        public const uint LADSComponentType_MachineryBuildingBlocks = 5088;

        /// <remarks />
        public const uint LADSComponentType_MachineryBuildingBlocks_LifetimeCounters = 5094;

        /// <remarks />
        public const uint LADSComponentType_MachineryBuildingBlocks_OperationCounters = 5097;

        /// <remarks />
        public const uint FunctionalUnitType_Identification = 5003;

        /// <remarks />
        public const uint FunctionalUnitType_Lock = 5004;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionSet = 5008;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager = 5015;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram = 5218;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_ProgramTemplateSet = 5021;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_ResultSet = 5022;

        /// <remarks />
        public const uint FunctionalUnitType_SupportedPropertiesSet = 5116;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState = 5005;

        /// <remarks />
        public const uint FunctionalUnitType_Operational = 5007;

        /// <remarks />
        public const uint FunctionType_Configuration = 5012;

        /// <remarks />
        public const uint FunctionType_FunctionSet = 5013;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor = 5068;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint BaseControlFunctionType_Operational = 5046;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState = 5038;

        /// <remarks />
        public const uint BaseControlFunctionType_ControllerTuningParameter = 5001;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint AnalogControlFunctionType_Operational = 5009;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState = 5141;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Operational = 5059;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState = 5142;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState = 5144;

        /// <remarks />
        public const uint BaseSensorFunctionType_Configuration = 5030;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_LimitState = 5070;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Operational = 5024;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Operational = 5061;

        /// <remarks />
        public const uint CoverFunctionType_Operational = 5064;

        /// <remarks />
        public const uint CoverFunctionType_CoverState = 5055;

        /// <remarks />
        public const uint ProgramManagerType_ActiveProgram = 5190;

        /// <remarks />
        public const uint ProgramManagerType_ProgramTemplateSet = 5020;

        /// <remarks />
        public const uint ProgramManagerType_ResultSet = 5019;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS_ = 5026;

        /// <remarks />
        public const uint SampleInfoType_Encoding_DefaultBinary = 5042;

        /// <remarks />
        public const uint SampleInfoType_Encoding_DefaultXml = 5043;

        /// <remarks />
        public const uint SampleInfoType_Encoding_DefaultJson = 5044;

        /// <remarks />
        public const uint KeyValueType_Encoding_DefaultBinary = 5045;

        /// <remarks />
        public const uint KeyValueType_Encoding_DefaultXml = 5056;

        /// <remarks />
        public const uint KeyValueType_Encoding_DefaultJson = 5057;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint TimerControlFunctionType_Operational = 5113;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState = 5070;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Operational = 5058;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControllerModeSet = 5076;

        /// <remarks />
        public const uint ControllerParameterType_AlarmMonitor = 5146;

        /// <remarks />
        public const uint ControllerParameterSetType_S_SetElement_ = 5023;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_TargetValueSet = 5087;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet = 5006;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement_ = 5080;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState = 5071;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Operational = 5084;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_LimitState = 5070;

        /// <remarks />
        public const uint SetType_S_SetElement_ = 5014;

        /// <remarks />
        public const uint VariableSetType_S_SetElement_ = 5086;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor = 5069;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState = 5070;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Operational = 5011;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Calibration = 5135;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Tuning = 5010;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint ActiveProgramType = 1040;

        /// <remarks />
        public const uint LADSComponentsType = 1025;

        /// <remarks />
        public const uint LADSOperationCountersType = 1034;

        /// <remarks />
        public const uint FunctionalUnitSetType = 1023;

        /// <remarks />
        public const uint FunctionSetType = 1026;

        /// <remarks />
        public const uint ProgramTemplateSetType = 1019;

        /// <remarks />
        public const uint ProgramTemplateType = 1018;

        /// <remarks />
        public const uint SupportedPropertiesSetType = 1033;

        /// <remarks />
        public const uint SupportedPropertyType = 1035;

        /// <remarks />
        public const uint ResultFileSetType = 1022;

        /// <remarks />
        public const uint ResultFileType = 1001;

        /// <remarks />
        public const uint ResultSetType = 1020;

        /// <remarks />
        public const uint ResultType = 1021;

        /// <remarks />
        public const uint CoverStateMachineType = 1010;

        /// <remarks />
        public const uint LADSDeviceStateMachineType = 1039;

        /// <remarks />
        public const uint FunctionalStateMachineType = 1038;

        /// <remarks />
        public const uint RunningStateMachineType = 1036;

        /// <remarks />
        public const uint MaintenanceSetType = 1027;

        /// <remarks />
        public const uint MaintenanceTaskType = 1028;

        /// <remarks />
        public const uint LADSDeviceType = 1002;

        /// <remarks />
        public const uint LADSComponentType = 1024;

        /// <remarks />
        public const uint FunctionalUnitType = 1003;

        /// <remarks />
        public const uint FunctionType = 1004;

        /// <remarks />
        public const uint BaseControlFunctionType = 1007;

        /// <remarks />
        public const uint AnalogControlFunctionType = 1009;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType = 1014;

        /// <remarks />
        public const uint DiscreteControlFunctionType = 1017;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType = 1045;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType = 1042;

        /// <remarks />
        public const uint BaseSensorFunctionType = 1005;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType = 1016;

        /// <remarks />
        public const uint DiscreteSensorFunctionType = 1012;

        /// <remarks />
        public const uint CoverFunctionType = 1011;

        /// <remarks />
        public const uint ProgramManagerType = 1006;

        /// <remarks />
        public const uint TimerControlFunctionType = 1013;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType = 1000;

        /// <remarks />
        public const uint ControllerTuningParameterType = 1008;

        /// <remarks />
        public const uint PidControllerParameterType = 1030;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType = 1031;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType = 1037;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType = 1043;

        /// <remarks />
        public const uint ControlFunctionStateMachineType = 1044;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType = 1047;

        /// <remarks />
        public const uint ControllerParameterType = 1048;

        /// <remarks />
        public const uint ControllerParameterSetType = 1049;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType = 1052;

        /// <remarks />
        public const uint MultiSensorFunctionType = 1051;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType = 1029;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType = 1015;

        /// <remarks />
        public const uint SetType = 61;

        /// <remarks />
        public const uint VariableSetType = 1041;

        /// <remarks />
        public const uint AnalogSensorFunctionType = 1046;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType = 1050;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint ActiveProgramType_CurrentPauseTime = 6180;

        /// <remarks />
        public const uint ActiveProgramType_CurrentRuntime = 6163;

        /// <remarks />
        public const uint ActiveProgramType_CurrentStepName = 6184;

        /// <remarks />
        public const uint ActiveProgramType_CurrentStepNumber = 6185;

        /// <remarks />
        public const uint ActiveProgramType_CurrentStepRuntime = 6186;

        /// <remarks />
        public const uint ActiveProgramType_EstimatedRuntime = 6159;

        /// <remarks />
        public const uint ActiveProgramType_EstimatedStepNumbers = 6162;

        /// <remarks />
        public const uint ActiveProgramType_EstimatedStepRuntime = 6183;

        /// <remarks />
        public const uint ActiveProgramType_DeviceProgramRunId = 6126;

        /// <remarks />
        public const uint ActiveProgramType_CurrentProgramTemplate = 6315;

        /// <remarks />
        public const uint LADSComponentsType_Component_Identification_Manufacturer = 6019;

        /// <remarks />
        public const uint LADSComponentsType_Component_Identification_SerialNumber = 6020;

        /// <remarks />
        public const uint LADSComponentsType_NodeVersion = 6085;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_Locked = 6468;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_LockingClient = 6163;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_LockingUser = 6164;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Manufacturer = 6169;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__SerialNumber = 6175;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Identification_Manufacturer = 6002;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Identification_SerialNumber = 6003;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Maintenance_NodeVersion = 6189;

        /// <remarks />
        public const uint LADSComponentsType_S_Component__Components_NodeVersion = 6085;

        /// <remarks />
        public const uint LADSOperationCountersType_LifeTime = 6027;

        /// <remarks />
        public const uint LADSOperationCountersType_LifeTime_StartValue = 469;

        /// <remarks />
        public const uint LADSOperationCountersType_LifeTime_LimitValue = 470;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_Locked = 6017;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_LockingClient = 6018;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_LockingUser = 6019;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_RemainingLockTime = 6020;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_InitLock_InputArguments = 6015;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_InitLock_OutputArguments = 6016;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_RenewLock_OutputArguments = 6021;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_ExitLock_OutputArguments = 6014;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Lock_BreakLock_OutputArguments = 6013;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_Locked = 6468;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_ProgramTemplateSet_NodeVersion = 6258;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Download_InputArguments = 6289;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Download_OutputArguments = 6290;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Remove_InputArguments = 6291;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Upload_InputArguments = 6292;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_Upload_OutputArguments = 6032;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__ProgramManager_ResultSet_NodeVersion = 6052;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_CurrentState = 6279;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_CurrentState_EffectiveDisplayName = 6280;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_AvailableStates = 6473;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_Start_InputArguments = 6127;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_StartProgram_InputArguments = 6098;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__FunctionalUnitState_StartProgram_OutputArguments = 6121;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Operational_StartProgram_InputArguments = 6142;

        /// <remarks />
        public const uint FunctionalUnitSetType_S_SetElement__Operational_StartProgram_OutputArguments = 6143;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_Locked = 6468;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_LockingClient = 6163;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_LockingUser = 6164;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint FunctionSetType_S_SetElement__IsEnabled = 6002;

        /// <remarks />
        public const uint ProgramTemplateSetType_NodeVersion = 6133;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement__Author = 6348;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement__Created = 6341;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement__Description = 6340;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement__Modified = 6344;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement__DeviceTemplateId = 6259;

        /// <remarks />
        public const uint ProgramTemplateSetType_S_SetElement__Version = 6346;

        /// <remarks />
        public const uint ProgramTemplateType_Author = 6348;

        /// <remarks />
        public const uint ProgramTemplateType_Created = 6341;

        /// <remarks />
        public const uint ProgramTemplateType_Description = 6340;

        /// <remarks />
        public const uint ProgramTemplateType_Modified = 6344;

        /// <remarks />
        public const uint ProgramTemplateType_DeviceTemplateId = 6259;

        /// <remarks />
        public const uint ProgramTemplateType_Version = 6346;

        /// <remarks />
        public const uint ProgramTemplateType_SupervisoryTemplateId = 6090;

        /// <remarks />
        public const uint ResultFileSetType_S_SetElement__MimeType = 6297;

        /// <remarks />
        public const uint ResultFileSetType_S_SetElement__Name = 6298;

        /// <remarks />
        public const uint ResultFileType_MimeType = 6297;

        /// <remarks />
        public const uint ResultFileType_Name = 6298;

        /// <remarks />
        public const uint ResultFileType_URL = 6299;

        /// <remarks />
        public const uint ResultSetType_NodeVersion = 6104;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ApplicationUri = 6281;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__Description = 6396;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__SupervisoryJobId = 6393;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__Samples = 6308;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__Started = 6307;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__Stopped = 6394;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate_Author = 6348;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate_Created = 6341;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate_Description = 6340;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate_Modified = 6344;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate_DeviceTemplateId = 6259;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__ProgramTemplate_Version = 6346;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__User = 6282;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__Properties = 6485;

        /// <remarks />
        public const uint ResultSetType_S_SetElement__SupervisoryTaskId = 6487;

        /// <remarks />
        public const uint ResultType_ApplicationUri = 6281;

        /// <remarks />
        public const uint ResultType_Description = 6396;

        /// <remarks />
        public const uint ResultType_SupervisoryJobId = 6393;

        /// <remarks />
        public const uint ResultType_Samples = 6308;

        /// <remarks />
        public const uint ResultType_Started = 6307;

        /// <remarks />
        public const uint ResultType_Stopped = 6394;

        /// <remarks />
        public const uint ResultType_ProgramTemplate_Author = 6348;

        /// <remarks />
        public const uint ResultType_ProgramTemplate_Created = 6341;

        /// <remarks />
        public const uint ResultType_ProgramTemplate_Description = 6340;

        /// <remarks />
        public const uint ResultType_ProgramTemplate_Modified = 6344;

        /// <remarks />
        public const uint ResultType_ProgramTemplate_DeviceTemplateId = 6259;

        /// <remarks />
        public const uint ResultType_ProgramTemplate_Version = 6346;

        /// <remarks />
        public const uint ResultType_User = 6282;

        /// <remarks />
        public const uint ResultType_Properties = 6485;

        /// <remarks />
        public const uint ResultType_SupervisoryTaskId = 6487;

        /// <remarks />
        public const uint ResultType_DeviceProgramRunId = 6495;

        /// <remarks />
        public const uint ResultType_TotalRuntime = 6500;

        /// <remarks />
        public const uint ResultType_TotalPauseTime = 6501;

        /// <remarks />
        public const uint ResultType_EstimatedRuntime = 6504;

        /// <remarks />
        public const uint CoverStateMachineType_Closed_StateNumber = 6044;

        /// <remarks />
        public const uint CoverStateMachineType_Error_StateNumber = 6046;

        /// <remarks />
        public const uint CoverStateMachineType_Locked_StateNumber = 6045;

        /// <remarks />
        public const uint CoverStateMachineType_Opened_StateNumber = 6043;

        /// <remarks />
        public const uint CoverStateMachineType_OpenedToClosed_TransitionNumber = 6000;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToOpened_TransitionNumber = 6463;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToLocked_TransitionNumber = 6464;

        /// <remarks />
        public const uint CoverStateMachineType_LockedToClosed_TransitionNumber = 6465;

        /// <remarks />
        public const uint CoverStateMachineType_LockedToError_TransitionNumber = 6466;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToError_TransitionNumber = 6467;

        /// <remarks />
        public const uint CoverStateMachineType_ErrorToOpened_TransitionNumber = 6476;

        /// <remarks />
        public const uint CoverStateMachineType_LockedToUnlocking_TransitionNumber = 6300;

        /// <remarks />
        public const uint CoverStateMachineType_Unlocking_StateNumber = 6293;

        /// <remarks />
        public const uint CoverStateMachineType_Locking_StateNumber = 6287;

        /// <remarks />
        public const uint CoverStateMachineType_Opening_StateNumber = 6288;

        /// <remarks />
        public const uint CoverStateMachineType_Closing_StateNumber = 6286;

        /// <remarks />
        public const uint CoverStateMachineType_UnlockingToClosed_TransitionNumber = 6304;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToOpening_TransitionNumber = 6295;

        /// <remarks />
        public const uint CoverStateMachineType_OpeningToOpened_TransitionNumber = 6303;

        /// <remarks />
        public const uint CoverStateMachineType_OpenedToClosing_TransitionNumber = 6302;

        /// <remarks />
        public const uint CoverStateMachineType_ClosingToClosed_TransitionNumber = 6296;

        /// <remarks />
        public const uint CoverStateMachineType_ClosedToLocking_TransitionNumber = 6294;

        /// <remarks />
        public const uint CoverStateMachineType_LockingToLocked_TransitionNumber = 6301;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Operate_StateNumber = 6330;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_OperateToShutdown_TransitionNumber = 6355;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_OperateToSleep_TransitionNumber = 6556;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Initialization_StateNumber = 6329;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_InitializationToOperate_TransitionNumber = 6352;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Shutdown_StateNumber = 6351;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_Sleep_StateNumber = 6525;

        /// <remarks />
        public const uint LADSDeviceStateMachineType_SleepToOperate_TransitionNumber = 6482;

        /// <remarks />
        public const uint FunctionalStateMachineType_CurrentState = 6100;

        /// <remarks />
        public const uint FunctionalStateMachineType_CurrentState_EffectiveDisplayName = 6101;

        /// <remarks />
        public const uint FunctionalStateMachineType_AvailableStates = 6473;

        /// <remarks />
        public const uint FunctionalStateMachineType_AvailableTransitions = 6472;

        /// <remarks />
        public const uint FunctionalStateMachineType_Aborted_StateNumber = 6475;

        /// <remarks />
        public const uint FunctionalStateMachineType_AbortedToClearing_TransitionNumber = 6486;

        /// <remarks />
        public const uint FunctionalStateMachineType_Aborting_StateNumber = 6474;

        /// <remarks />
        public const uint FunctionalStateMachineType_AbortingToAborted_TransitionNumber = 6432;

        /// <remarks />
        public const uint FunctionalStateMachineType_Clearing_StateNumber = 6449;

        /// <remarks />
        public const uint FunctionalStateMachineType_Stopped_StateNumber = 6508;

        /// <remarks />
        public const uint FunctionalStateMachineType_Running_StateNumber = 6509;

        /// <remarks />
        public const uint FunctionalStateMachineType_Stopping_StateNumber = 6511;

        /// <remarks />
        public const uint FunctionalStateMachineType_StoppingToStopped_TransitionNumber = 6512;

        /// <remarks />
        public const uint FunctionalStateMachineType_StoppedToRunning_TransitionNumber = 6513;

        /// <remarks />
        public const uint FunctionalStateMachineType_RunningToAborting_TransitionNumber = 6528;

        /// <remarks />
        public const uint FunctionalStateMachineType_ClearingToStopped_TransitionNumber = 6529;

        /// <remarks />
        public const uint FunctionalStateMachineType_RunningToStopping_TransitionNumber = 6534;

        /// <remarks />
        public const uint FunctionalStateMachineType_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint RunningStateMachineType_CurrentState = 6146;

        /// <remarks />
        public const uint RunningStateMachineType_Complete_StateNumber = 6434;

        /// <remarks />
        public const uint RunningStateMachineType_Completing_StateNumber = 6433;

        /// <remarks />
        public const uint RunningStateMachineType_Execute_StateNumber = 6489;

        /// <remarks />
        public const uint RunningStateMachineType_Held_StateNumber = 6430;

        /// <remarks />
        public const uint RunningStateMachineType_Holding_StateNumber = 6429;

        /// <remarks />
        public const uint RunningStateMachineType_Idle_StateNumber = 6426;

        /// <remarks />
        public const uint RunningStateMachineType_Resetting_StateNumber = 6425;

        /// <remarks />
        public const uint RunningStateMachineType_Starting_StateNumber = 6423;

        /// <remarks />
        public const uint RunningStateMachineType_Suspended_StateNumber = 6427;

        /// <remarks />
        public const uint RunningStateMachineType_Suspending_StateNumber = 6424;

        /// <remarks />
        public const uint RunningStateMachineType_Unholding_StateNumber = 6431;

        /// <remarks />
        public const uint RunningStateMachineType_Unsuspending_StateNumber = 6428;

        /// <remarks />
        public const uint RunningStateMachineType_IdleToStarting_TransitionNumber = 6047;

        /// <remarks />
        public const uint RunningStateMachineType_StartingToExecute_TransitionNumber = 6048;

        /// <remarks />
        public const uint RunningStateMachineType_ExecuteToCompleting_TransitionNumber = 6049;

        /// <remarks />
        public const uint RunningStateMachineType_CompletingToComplete_TransitionNumber = 6050;

        /// <remarks />
        public const uint RunningStateMachineType_CompleteToResetting_TransitionNumber = 6060;

        /// <remarks />
        public const uint RunningStateMachineType_ResettingToIdle_TransitionNumber = 6061;

        /// <remarks />
        public const uint RunningStateMachineType_ExecuteToSuspending_TransitionNumber = 6070;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendingToSuspended_TransitionNumber = 6071;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendedToUnsuspending_TransitionNumber = 6072;

        /// <remarks />
        public const uint RunningStateMachineType_UnsuspendingToExecute_TransitionNumber = 6073;

        /// <remarks />
        public const uint RunningStateMachineType_ExecuteToHolding_TransitionNumber = 6076;

        /// <remarks />
        public const uint RunningStateMachineType_HoldingToHeld_TransitionNumber = 6077;

        /// <remarks />
        public const uint RunningStateMachineType_HeldToUnholding_TransitionNumber = 6078;

        /// <remarks />
        public const uint RunningStateMachineType_UnholdingToExecute_TransitionNumber = 6114;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendingToHolding_TransitionNumber = 6115;

        /// <remarks />
        public const uint RunningStateMachineType_StartingToHolding_TransitionNumber = 6116;

        /// <remarks />
        public const uint RunningStateMachineType_SuspendedToHolding_TransitionNumber = 6117;

        /// <remarks />
        public const uint RunningStateMachineType_UnsuspendingToHolding_TransitionNumber = 6118;

        /// <remarks />
        public const uint RunningStateMachineType_UnholdingToHolding_TransitionNumber = 6275;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__EventId = 6270;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__EventType = 6271;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__SourceNode = 6272;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__SourceName = 6273;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Time = 6274;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ReceiveTime = 6276;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Message = 6277;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Severity = 6278;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ConditionClassId = 6268;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ConditionClassName = 6269;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ConditionName = 6190;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__BranchId = 6256;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Retain = 6188;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__EnabledState = 6166;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__EnabledState_Id = 6167;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Quality = 6260;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Quality_SourceTimestamp = 6261;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__LastSeverity = 6262;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__LastSeverity_SourceTimestamp = 6263;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Comment = 6264;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Comment_SourceTimestamp = 6265;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ClientUserId = 6266;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__AddComment_InputArguments = 6267;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__AckedState = 6181;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__AckedState_Id = 6182;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__Acknowledge_InputArguments = 6187;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ActiveState = 6168;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__ActiveState_Id = 6177;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__InputNode = 6179;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__SuppressedOrShelved = 6178;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__NormalState = 6164;

        /// <remarks />
        public const uint MaintenanceSetType_S_SetElement__StopTask_InputArguments = 6092;

        /// <remarks />
        public const uint MaintenanceTaskType_LastExecutionDate = 6360;

        /// <remarks />
        public const uint MaintenanceTaskType_RecurrencePeriod = 6362;

        /// <remarks />
        public const uint MaintenanceTaskType_LastOperatingTime = 6081;

        /// <remarks />
        public const uint MaintenanceTaskType_NextOperatingTime = 6087;

        /// <remarks />
        public const uint MaintenanceTaskType_LastOperatingCycles = 6088;

        /// <remarks />
        public const uint MaintenanceTaskType_NextOperatingCycles = 6091;

        /// <remarks />
        public const uint MaintenanceTaskType_StopTask_InputArguments = 6092;

        /// <remarks />
        public const uint MaintenanceTaskType_ConfigurationChanged = 6097;

        /// <remarks />
        public const uint MaintenanceTaskType_EstimatedDowntime = 6102;

        /// <remarks />
        public const uint MaintenanceTaskType_MaintenanceMethod = 6106;

        /// <remarks />
        public const uint MaintenanceTaskType_MaintenanceSupplier = 6107;

        /// <remarks />
        public const uint MaintenanceTaskType_PartsOfAssetReplaced = 6108;

        /// <remarks />
        public const uint MaintenanceTaskType_PartsOfAssetServiced = 6111;

        /// <remarks />
        public const uint MaintenanceTaskType_PlannedDate = 6119;

        /// <remarks />
        public const uint MaintenanceTaskType_QualificationOfPersonnel = 6120;

        /// <remarks />
        public const uint LADSDeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint LADSDeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint LADSDeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint LADSDeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint LADSDeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint LADSDeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint LADSDeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint LADSDeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint LADSDeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint LADSDeviceType_Manufacturer = 6009;

        /// <remarks />
        public const uint LADSDeviceType_ManufacturerUri = 6094;

        /// <remarks />
        public const uint LADSDeviceType_Model = 6010;

        /// <remarks />
        public const uint LADSDeviceType_HardwareRevision = 6093;

        /// <remarks />
        public const uint LADSDeviceType_SoftwareRevision = 6063;

        /// <remarks />
        public const uint LADSDeviceType_DeviceRevision = 6062;

        /// <remarks />
        public const uint LADSDeviceType_ProductCode = 6095;

        /// <remarks />
        public const uint LADSDeviceType_DeviceManual = 6051;

        /// <remarks />
        public const uint LADSDeviceType_DeviceClass = 6083;

        /// <remarks />
        public const uint LADSDeviceType_SerialNumber = 6064;

        /// <remarks />
        public const uint LADSDeviceType_ProductInstanceUri = 6096;

        /// <remarks />
        public const uint LADSDeviceType_RevisionCounter = 6008;

        /// <remarks />
        public const uint LADSDeviceType_AssetId = 6068;

        /// <remarks />
        public const uint LADSDeviceType_ComponentName = 6069;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint LADSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint LADSDeviceType_DeviceHealth = 6086;

        /// <remarks />
        public const uint LADSDeviceType_FunctionalUnitSet_NodeVersion = 6103;

        /// <remarks />
        public const uint LADSDeviceType_Identification_Manufacturer = 6002;

        /// <remarks />
        public const uint LADSDeviceType_Identification_ProductInstanceUri = 6015;

        /// <remarks />
        public const uint LADSDeviceType_Identification_SerialNumber = 6003;

        /// <remarks />
        public const uint LADSDeviceType_DeviceState_CurrentState = 6600;

        /// <remarks />
        public const uint LADSDeviceType_DeviceState_CurrentState_Id = 6601;

        /// <remarks />
        public const uint LADSDeviceType_Maintenance_NodeVersion = 6113;

        /// <remarks />
        public const uint LADSDeviceType_OperationalLocation = 6028;

        /// <remarks />
        public const uint LADSDeviceType_HierarchicalLocation = 6029;

        /// <remarks />
        public const uint LADSComponentType_Lock_Locked = 6468;

        /// <remarks />
        public const uint LADSComponentType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint LADSComponentType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint LADSComponentType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint LADSComponentType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint LADSComponentType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint LADSComponentType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint LADSComponentType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint LADSComponentType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint LADSComponentType_Manufacturer = 6169;

        /// <remarks />
        public const uint LADSComponentType_ManufacturerUri = 6170;

        /// <remarks />
        public const uint LADSComponentType_Model = 6171;

        /// <remarks />
        public const uint LADSComponentType_HardwareRevision = 6154;

        /// <remarks />
        public const uint LADSComponentType_SoftwareRevision = 6176;

        /// <remarks />
        public const uint LADSComponentType_DeviceRevision = 6153;

        /// <remarks />
        public const uint LADSComponentType_ProductCode = 6172;

        /// <remarks />
        public const uint LADSComponentType_DeviceManual = 6152;

        /// <remarks />
        public const uint LADSComponentType_DeviceClass = 6151;

        /// <remarks />
        public const uint LADSComponentType_SerialNumber = 6175;

        /// <remarks />
        public const uint LADSComponentType_ProductInstanceUri = 6173;

        /// <remarks />
        public const uint LADSComponentType_RevisionCounter = 6174;

        /// <remarks />
        public const uint LADSComponentType_AssetId = 6149;

        /// <remarks />
        public const uint LADSComponentType_ComponentName = 6150;

        /// <remarks />
        public const uint LADSComponentType_DeviceHealth = 6480;

        /// <remarks />
        public const uint LADSComponentType_Identification_Manufacturer = 6002;

        /// <remarks />
        public const uint LADSComponentType_Identification_SerialNumber = 6003;

        /// <remarks />
        public const uint LADSComponentType_Maintenance_NodeVersion = 6189;

        /// <remarks />
        public const uint LADSComponentType_OperationalLocation = 6074;

        /// <remarks />
        public const uint LADSComponentType_HierarchicalLocation = 6080;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_Locked = 6017;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_LockingClient = 6018;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_LockingUser = 6019;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_RemainingLockTime = 6020;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_InitLock_InputArguments = 6015;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_InitLock_OutputArguments = 6016;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_RenewLock_OutputArguments = 6021;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_ExitLock_OutputArguments = 6014;

        /// <remarks />
        public const uint FunctionalUnitType_Lock_BreakLock_OutputArguments = 6013;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_Locked = 6468;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion = 6258;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Download_InputArguments = 6289;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Download_OutputArguments = 6290;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Remove_InputArguments = 6291;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Upload_InputArguments = 6292;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_Upload_OutputArguments = 6032;

        /// <remarks />
        public const uint FunctionalUnitType_ProgramManager_ResultSet_NodeVersion = 6052;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_CurrentState = 6279;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_CurrentState_EffectiveDisplayName = 6280;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_AvailableStates = 6473;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_Start_InputArguments = 6127;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_StartProgram_InputArguments = 6098;

        /// <remarks />
        public const uint FunctionalUnitType_FunctionalUnitState_StartProgram_OutputArguments = 6121;

        /// <remarks />
        public const uint FunctionalUnitType_AssetId = 6284;

        /// <remarks />
        public const uint FunctionalUnitType_ComponentName = 6285;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_EffectiveDisplayName = 6105;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_StartProgram_InputArguments = 6142;

        /// <remarks />
        public const uint FunctionalUnitType_Operational_StartProgram_OutputArguments = 6143;

        /// <remarks />
        public const uint FunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint FunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint FunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint FunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint FunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint FunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint FunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint FunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint FunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint FunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint FunctionType_IsEnabled = 6002;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint BaseControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint BaseControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint BaseControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState_CurrentState = 6079;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint BaseControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6129;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint AnalogControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_CurrentState = 6100;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint AnalogControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6305;

        /// <remarks />
        public const uint AnalogControlFunctionType_CurrentValue = 6001;

        /// <remarks />
        public const uint AnalogControlFunctionType_TargetValue = 6006;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ControlFunctionState_CurrentState = 6100;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ControlFunctionState_StartWithTargetValue_InputArguments = 6305;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_TotalizedValue = 6011;

        /// <remarks />
        public const uint AnalogControlFunctionWithTotalizerType_ResetTotalizer_InputArguments = 6132;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint DiscreteControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint DiscreteControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint DiscreteControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint DiscreteControlFunctionType_ControlFunctionState_CurrentState = 6079;

        /// <remarks />
        public const uint DiscreteControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint DiscreteControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint DiscreteControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint DiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint DiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6129;

        /// <remarks />
        public const uint DiscreteControlFunctionType_CurrentValue = 6065;

        /// <remarks />
        public const uint DiscreteControlFunctionType_TargetValue = 6123;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_CurrentState = 6100;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6306;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_CurrentValue = 6067;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_TargetValue = 6124;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_CurrentValue_EnumStrings = 6157;

        /// <remarks />
        public const uint MultiStateDiscreteControlFunctionType_TargetValue_EnumStrings = 6158;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_CurrentState = 6100;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6309;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_CurrentValue = 6066;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_TargetValue = 6135;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_CurrentValue_FalseState = 6138;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_CurrentValue_TrueState = 6140;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_TargetValue_FalseState = 6155;

        /// <remarks />
        public const uint TwoStateDiscreteControlFunctionType_TargetValue_TrueState = 6156;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint BaseSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint BaseSensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint BaseSensorFunctionType_Configuration_IsEnabled = 6022;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_EventId = 6215;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_EventType = 6216;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_SourceNode = 6221;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_SourceName = 6220;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Time = 6222;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ReceiveTime = 6218;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Message = 6217;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Severity = 6219;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ConditionClassId = 6207;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ConditionClassName = 6208;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ConditionName = 6209;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_BranchId = 6203;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Retain = 6214;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_EnabledState = 6195;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_EnabledState_Id = 6196;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Quality = 6212;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6213;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_LastSeverity = 6210;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6211;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Comment = 6205;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6206;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ClientUserId = 6204;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_AddComment_InputArguments = 6202;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_AckedState = 6199;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_AckedState_Id = 6200;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6201;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ActiveState = 6191;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_ActiveState_Id = 6192;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_InputNode = 6197;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_SuppressedOrShelved = 6198;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_LimitState_CurrentState = 6193;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6194;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_RawValue = 6039;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionType_SensorValue = 6033;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint DiscreteSensorFunctionType_SensorValue = 6031;

        /// <remarks />
        public const uint CoverFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint CoverFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint CoverFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint CoverFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint CoverFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint CoverFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint CoverFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint CoverFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint CoverFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint CoverFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint CoverFunctionType_CoverState_CurrentState = 6314;

        /// <remarks />
        public const uint ProgramManagerType_Lock_Locked = 6468;

        /// <remarks />
        public const uint ProgramManagerType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint ProgramManagerType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint ProgramManagerType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint ProgramManagerType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint ProgramManagerType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint ProgramManagerType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint ProgramManagerType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint ProgramManagerType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint ProgramManagerType_ProgramTemplateSet_NodeVersion = 6257;

        /// <remarks />
        public const uint ProgramManagerType_Download_InputArguments = 6289;

        /// <remarks />
        public const uint ProgramManagerType_Download_OutputArguments = 6290;

        /// <remarks />
        public const uint ProgramManagerType_Remove_InputArguments = 6291;

        /// <remarks />
        public const uint ProgramManagerType_Upload_InputArguments = 6292;

        /// <remarks />
        public const uint ProgramManagerType_Upload_OutputArguments = 6032;

        /// <remarks />
        public const uint ProgramManagerType_ResultSet_NodeVersion = 6041;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__NamespaceUri = 6055;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__NamespaceVersion = 6056;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__NamespacePublicationDate = 6054;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__IsNamespaceSubset = 6053;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__StaticNodeIdTypes = 6057;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__StaticNumericNodeIdRange = 6058;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_LADS__StaticStringNodeIdPattern = 6059;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint TimerControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint TimerControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint TimerControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint TimerControlFunctionType_ControlFunctionState_CurrentState = 6079;

        /// <remarks />
        public const uint TimerControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint TimerControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint TimerControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint TimerControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint TimerControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6129;

        /// <remarks />
        public const uint TimerControlFunctionType_DifferenceValue = 6012;

        /// <remarks />
        public const uint TimerControlFunctionType_DifferenceValue_EngineeringUnits = 6148;

        /// <remarks />
        public const uint TimerControlFunctionType_TargetValue = 6034;

        /// <remarks />
        public const uint TimerControlFunctionType_TargetValue_EngineeringUnits = 6161;

        /// <remarks />
        public const uint TimerControlFunctionType_CurrentValue = 6035;

        /// <remarks />
        public const uint TimerControlFunctionType_CurrentValue_EngineeringUnits = 6147;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EventId = 6215;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EventType = 6216;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SourceNode = 6221;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SourceName = 6220;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Time = 6222;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime = 6218;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Message = 6217;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Severity = 6219;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId = 6207;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName = 6208;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionName = 6209;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_BranchId = 6203;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Retain = 6214;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EnabledState = 6195;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id = 6196;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Quality = 6212;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp = 6213;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity = 6210;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp = 6211;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Comment = 6205;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp = 6206;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId = 6204;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments = 6202;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AckedState = 6199;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id = 6200;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments = 6201;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ActiveState = 6191;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id = 6192;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_InputNode = 6197;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved = 6198;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState = 6193;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id = 6194;

        /// <remarks />
        public const uint AnalogScalarSensorFunctionWithCompensationType_CompensationValue = 6037;

        /// <remarks />
        public const uint PidControllerParameterType_CtrlP = 6003;

        /// <remarks />
        public const uint PidControllerParameterType_CtrlTd = 6004;

        /// <remarks />
        public const uint PidControllerParameterType_CtrlTi = 6005;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_SensorValue = 6007;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_SensorValue_FalseState = 6136;

        /// <remarks />
        public const uint TwoStateDiscreteSensorFunctionType_SensorValue_TrueState = 6137;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_SensorValue = 6030;

        /// <remarks />
        public const uint MultiStateDiscreteSensorFunctionType_SensorValue_EnumStrings = 6160;

        /// <remarks />
        public const uint MaintenanceTaskResultEnum_EnumValues = 6099;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_CurrentState = 6279;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_CurrentState_EffectiveDisplayName = 6280;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Aborted_StateNumber = 6475;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_AbortedToClearing_TransitionNumber = 6486;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Aborting_StateNumber = 6474;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_AbortingToAborted_TransitionNumber = 6432;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Clearing_StateNumber = 6449;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Stopped_StateNumber = 6508;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Running_StateNumber = 6509;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Stopping_StateNumber = 6511;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_StoppingToStopped_TransitionNumber = 6512;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_StoppedToRunning_TransitionNumber = 6513;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_RunningToAborting_TransitionNumber = 6528;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_ClearingToStopped_TransitionNumber = 6529;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_RunningToStopping_TransitionNumber = 6534;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_Start_InputArguments = 6127;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_StartProgram_InputArguments = 6098;

        /// <remarks />
        public const uint FunctionalUnitStateMachineType_StartProgram_OutputArguments = 6121;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Aborted_StateNumber = 6475;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_AbortedToClearing_TransitionNumber = 6486;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Aborting_StateNumber = 6474;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_AbortingToAborted_TransitionNumber = 6432;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Clearing_StateNumber = 6449;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Stopped_StateNumber = 6508;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Running_StateNumber = 6509;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_Stopping_StateNumber = 6511;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_StoppingToStopped_TransitionNumber = 6512;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_StoppedToRunning_TransitionNumber = 6513;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_RunningToAborting_TransitionNumber = 6528;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_ClearingToStopped_TransitionNumber = 6529;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_RunningToStopping_TransitionNumber = 6534;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint ControlFunctionStateMachineType_StartWithTargetValue_InputArguments = 6129;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControlFunctionState_CurrentState = 6079;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = 6129;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_CurrentMode = 6122;

        /// <remarks />
        public const uint MultiModeAnalogControlFunctionType_CurrentMode_EnumStrings = 6165;

        /// <remarks />
        public const uint ControllerParameterType_CurrentValue = 6109;

        /// <remarks />
        public const uint ControllerParameterType_TargetValue = 6110;

        /// <remarks />
        public const uint ControllerParameterSetType_S_SetElement__CurrentValue = 6109;

        /// <remarks />
        public const uint ControllerParameterSetType_S_SetElement__TargetValue = 6110;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_CurrentState = 6100;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_StartWithTargetValue_InputArguments = 6305;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint MultiSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_Locked = 6468;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_LockingClient = 6163;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_LockingUser = 6164;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint MultiSensorFunctionType_FunctionSet_S_SetElement__IsEnabled = 6002;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EventId = 6248;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EventType = 6249;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SourceNode = 6254;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SourceName = 6253;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Time = 6255;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ReceiveTime = 6251;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Message = 6250;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Severity = 6252;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionClassId = 6240;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionClassName = 6241;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionName = 6242;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_BranchId = 6236;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Retain = 6247;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EnabledState = 6228;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EnabledState_Id = 6229;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Quality = 6245;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Quality_SourceTimestamp = 6246;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LastSeverity = 6243;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LastSeverity_SourceTimestamp = 6244;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Comment = 6238;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Comment_SourceTimestamp = 6239;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ClientUserId = 6237;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AddComment_InputArguments = 6235;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AckedState = 6232;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AckedState_Id = 6233;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Acknowledge_InputArguments = 6234;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ActiveState = 6224;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ActiveState_Id = 6225;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_InputNode = 6230;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SuppressedOrShelved = 6231;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_HighHighLimit = 6023;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_HighLimit = 6024;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LowLimit = 6025;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LowLowLimit = 6026;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState_CurrentState = 6226;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState_CurrentState_Id = 6227;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SetpointNode = 6223;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_CurrentState = 6100;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_CurrentState_Id = 6042;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_AvailableStates = 6473;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_AvailableTransitions = 6472;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_RunningStateMachine_CurrentState = 6146;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_StartWithTargetValue_InputArguments = 6305;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_IncreaseRate = 6089;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_DecreaseRate = 6125;

        /// <remarks />
        public const uint AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueBy_InputArguments = 6128;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_EventId = 6215;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_EventType = 6216;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_SourceNode = 6221;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_SourceName = 6220;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Time = 6222;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ReceiveTime = 6218;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Message = 6217;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Severity = 6219;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ConditionClassId = 6207;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ConditionClassName = 6208;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ConditionName = 6209;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_BranchId = 6203;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Retain = 6214;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_EnabledState = 6195;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_EnabledState_Id = 6196;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Quality = 6212;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6213;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_LastSeverity = 6210;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6211;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Comment = 6205;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6206;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ClientUserId = 6204;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_AddComment_InputArguments = 6202;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_AckedState = 6199;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_AckedState_Id = 6200;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6201;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ActiveState = 6191;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_ActiveState_Id = 6192;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_InputNode = 6197;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_SuppressedOrShelved = 6198;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_LimitState_CurrentState = 6193;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6194;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_RawValue = 6134;

        /// <remarks />
        public const uint AnalogArraySensorFunctionType_SensorValue = 6130;

        /// <remarks />
        public const uint SetType_NodeVersion = 6075;

        /// <remarks />
        public const uint VariableSetType_S_VariableSetElement_ = 6082;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_Locked = 6468;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint AnalogSensorFunctionType_FunctionSet_NodeVersion = 6084;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_EventId = 6215;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_EventType = 6216;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_SourceNode = 6221;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_SourceName = 6220;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Time = 6222;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ReceiveTime = 6218;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Message = 6217;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Severity = 6219;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConditionClassId = 6207;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConditionClassName = 6208;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConditionName = 6209;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_BranchId = 6203;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Retain = 6214;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_EnabledState = 6195;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id = 6196;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Quality = 6212;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = 6213;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_LastSeverity = 6210;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 6211;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Comment = 6205;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = 6206;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ClientUserId = 6204;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments = 6202;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_AckedState = 6199;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_AckedState_Id = 6200;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = 6201;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ActiveState = 6191;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id = 6192;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_InputNode = 6197;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved = 6198;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState = 6193;

        /// <remarks />
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 6194;

        /// <remarks />
        public const uint AnalogSensorFunctionType_CalibrationValues = 6036;

        /// <remarks />
        public const uint AnalogSensorFunctionType_Damping = 6038;

        /// <remarks />
        public const uint AnalogSensorFunctionType_RawValue = 6040;

        /// <remarks />
        public const uint AnalogSensorFunctionType_SensorValue = 6112;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber = 6070;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber = 6067;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber = 6069;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber = 6068;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber = 6063;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromNoneToNone_TransitionNumber = 6066;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber = 6065;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromNoneToSetup_TransitionNumber = 6064;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber = 6076;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromProcessingToNone_TransitionNumber = 6075;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber = 6078;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber = 6077;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber = 6072;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromSetupToNone_TransitionNumber = 6071;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber = 6073;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_FromSetupToSetup_TransitionNumber = 6074;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_Maintenance_StateNumber = 6060;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_None_StateNumber = 6059;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_Processing_StateNumber = 6061;

        /// <remarks />
        public const uint LADSOperationModeStateMachineType_Setup_StateNumber = 6062;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KeyValueType = new ExpandedNodeId(Opc.Ua.LADS.DataTypes.KeyValueType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SampleInfoType = new ExpandedNodeId(Opc.Ua.LADS.DataTypes.SampleInfoType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskResultEnum = new ExpandedNodeId(Opc.Ua.LADS.DataTypes.MaintenanceTaskResultEnum, Opc.Ua.LADS.Namespaces.LADS);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentsType_S_Component__Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentsType_S_Component__Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentsType_S_Component__Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentsType_S_Component__Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionSetType_S_SetElement__Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionSetType_S_SetElement__Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionSetType_S_SetElement__Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionSetType_S_SetElement__Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Close = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverStateMachineType_Close, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Lock = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverStateMachineType_Lock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Open = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverStateMachineType_Open, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Unlock = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverStateMachineType_Unlock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Reset = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverStateMachineType_Reset, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_GotoOperate = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceStateMachineType_GotoOperate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_GotoShutdown = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceStateMachineType_GotoShutdown, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_GotoSleep = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceStateMachineType_GotoSleep, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Abort = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalStateMachineType_Abort, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Clear = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalStateMachineType_Clear, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalStateMachineType_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Hold = new ExpandedNodeId(Opc.Ua.LADS.Methods.RunningStateMachineType_Hold, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Reset = new ExpandedNodeId(Opc.Ua.LADS.Methods.RunningStateMachineType_Reset, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Suspend = new ExpandedNodeId(Opc.Ua.LADS.Methods.RunningStateMachineType_Suspend, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ToComplete = new ExpandedNodeId(Opc.Ua.LADS.Methods.RunningStateMachineType_ToComplete, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Unhold = new ExpandedNodeId(Opc.Ua.LADS.Methods.RunningStateMachineType_Unhold, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Unsuspend = new ExpandedNodeId(Opc.Ua.LADS.Methods.RunningStateMachineType_Unsuspend, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceSetType_S_SetElement__Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceSetType_S_SetElement__Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceSetType_S_SetElement__AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceSetType_S_SetElement__Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_StartTask = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceTaskType_StartTask, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_StopTask = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceTaskType_StopTask, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_ResetTask = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceTaskType_ResetTask, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceState_GotoOperate = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_DeviceState_GotoOperate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceState_GotoShutdown = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_DeviceState_GotoShutdown, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceState_GotoSleep = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSDeviceType_DeviceState_GotoSleep, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSComponentType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_Clear = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Operational_Clear, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_Abort = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Operational_Abort, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_StartProgram = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Operational_StartProgram, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Operational_Reset = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_Operational_Reset, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_StartWithTargetValue = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionType_ControlFunctionState_StartWithTargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ResetTotalizer = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_ResetTotalizer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.DiscreteSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.CoverFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Download = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Download, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Remove = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Remove, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Upload = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_Upload, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.TimerControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.TwoStateDiscreteSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiStateDiscreteSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Start = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitStateMachineType_Start, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StartProgram = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitStateMachineType_StartProgram, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_StartWithTargetValue = new ExpandedNodeId(Opc.Ua.LADS.Methods.ControlFunctionStateMachineType_StartWithTargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Start = new ExpandedNodeId(Opc.Ua.LADS.Methods.ControlFunctionStateMachineType_Start, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiModeAnalogControlFunctionType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithComposedTargetValueType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Operational_Stop = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_Operational_Stop, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueBy = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueBy, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogArraySensorFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_Lock_InitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_Lock_RenewLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_Lock_ExitLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_Lock_BreakLock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_Disable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_Enable, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_AddComment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_Acknowledge, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_GotoProcessing = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSOperationModeStateMachineType_GotoProcessing, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_GotoMaintenance = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSOperationModeStateMachineType_GotoMaintenance, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_GotoSetup = new ExpandedNodeId(Opc.Ua.LADS.Methods.LADSOperationModeStateMachineType_GotoSetup, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_BreakLockMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_BreakLockMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_ExitLockMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_ExitLockMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLockMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_InitLockMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RenewLockMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitType_Lock_RenewLockMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_AcknowledgeMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_AlarmMonitor_AcknowledgeMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_AddCommentMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.BaseControlFunctionType_AlarmMonitor_AddCommentMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_DownloadMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_DownloadMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_RemoveMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_RemoveMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_UploadMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.ProgramManagerType_UploadMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ResetTotalizerMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithTotalizerType_ResetTotalizerMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_StopTaskMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.MaintenanceTaskType_StopTaskMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StartMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitStateMachineType_StartMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_StartWithTargetValueMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.ControlFunctionStateMachineType_StartWithTargetValueMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StartProgramMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.FunctionalUnitStateMachineType_StartProgramMethodType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueByMethodType = new ExpandedNodeId(Opc.Ua.LADS.Methods.AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueByMethodType, Opc.Ua.LADS.Namespaces.LADS);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_Component_Identification = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentsType_Component_Identification, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentsType_S_Component_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Identification = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentsType_S_Component__Identification, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitSetType_S_SetElement__Lock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_ActiveProgram = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitSetType_S_SetElement__ProgramManager_ActiveProgram, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_ProgramTemplateSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitSetType_S_SetElement__ProgramManager_ProgramTemplateSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_ResultSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitSetType_S_SetElement__ProgramManager_ResultSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitSetType_S_SetElement__FunctionalUnitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.ProgramTemplateSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SupportedPropertiesSetType_SetElement = new ExpandedNodeId(Opc.Ua.LADS.Objects.SupportedPropertiesSetType_SetElement, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultFileSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileType_File = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultFileType_File, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__FileSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultSetType_S_SetElement__FileSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultSetType_S_SetElement__ProgramTemplate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__VariableSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultSetType_S_SetElement__VariableSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_FileSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultType_FileSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultType_ProgramTemplate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_VariableSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.ResultType_VariableSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Closed = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Closed, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Error = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Error, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Locked = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Opened = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Opened, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_OpenedToClosed = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_OpenedToClosed, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToOpened = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ClosedToOpened, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToLocked = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ClosedToLocked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockedToClosed = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_LockedToClosed, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockedToError = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_LockedToError, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToError = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ClosedToError, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ErrorToOpened = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ErrorToOpened, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockedToUnlocking = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_LockedToUnlocking, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Unlocking = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Unlocking, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Locking = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Locking, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Opening = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Opening, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Closing = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_Closing, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_UnlockingToClosed = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_UnlockingToClosed, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToOpening = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ClosedToOpening, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_OpeningToOpened = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_OpeningToOpened, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_OpenedToClosing = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_OpenedToClosing, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosingToClosed = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ClosingToClosed, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToLocking = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_ClosedToLocking, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockingToLocked = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverStateMachineType_LockingToLocked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Operate = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_Operate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_OperateToShutdown = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_OperateToShutdown, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_OperateToSleep = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_OperateToSleep, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Initialization = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_Initialization, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_InitializationToOperate = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_InitializationToOperate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Shutdown = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_Shutdown, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Sleep = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_Sleep, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_SleepToOperate = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceStateMachineType_SleepToOperate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Aborted = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_Aborted, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_AbortedToClearing = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_AbortedToClearing, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Aborting = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_Aborting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_AbortingToAborted = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_AbortingToAborted, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Clearing = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_Clearing, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Stopped = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_Stopped, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Running = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_Running, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Stopping = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_Stopping, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_StoppingToStopped = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_StoppingToStopped, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_StoppedToRunning = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_StoppedToRunning, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_RunningToAborting = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_RunningToAborting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_ClearingToStopped = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_ClearingToStopped, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_RunningToStopping = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_RunningToStopping, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_RunningStateMachine = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalStateMachineType_RunningStateMachine, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Complete = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Complete, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Completing = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Completing, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Execute = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Execute, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Held = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Held, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Holding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Holding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Idle = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Idle, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Resetting = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Resetting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Starting = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Starting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Suspended = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Suspended, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Suspending = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Suspending, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Unholding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Unholding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Unsuspending = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_Unsuspending, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_IdleToStarting = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_IdleToStarting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_StartingToExecute = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_StartingToExecute, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ExecuteToCompleting = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_ExecuteToCompleting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_CompletingToComplete = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_CompletingToComplete, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_CompleteToResetting = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_CompleteToResetting, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ResettingToIdle = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_ResettingToIdle, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ExecuteToSuspending = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_ExecuteToSuspending, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendingToSuspended = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_SuspendingToSuspended, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendedToUnsuspending = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_SuspendedToUnsuspending, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnsuspendingToExecute = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_UnsuspendingToExecute, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ExecuteToHolding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_ExecuteToHolding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_HoldingToHeld = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_HoldingToHeld, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_HeldToUnholding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_HeldToUnholding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnholdingToExecute = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_UnholdingToExecute, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendingToHolding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_SuspendingToHolding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_StartingToHolding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_StartingToHolding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendedToHolding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_SuspendedToHolding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnsuspendingToHolding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_UnsuspendingToHolding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnholdingToHolding = new ExpandedNodeId(Opc.Ua.LADS.Objects.RunningStateMachineType_UnholdingToHolding, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.MaintenanceSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__MaintenanceState = new ExpandedNodeId(Opc.Ua.LADS.Objects.MaintenanceSetType_S_SetElement__MaintenanceState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_MaintenanceState = new ExpandedNodeId(Opc.Ua.LADS.Objects.MaintenanceTaskType_MaintenanceState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Identification = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_Identification, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Components = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_Components, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_FunctionalUnitSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_FunctionalUnitSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceState = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_DeviceState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Maintenance = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_Maintenance, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_MachineryBuildingBlocks = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_MachineryBuildingBlocks, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_MachineryBuildingBlocks_MachineryItemState = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_MachineryBuildingBlocks_MachineryItemState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_MachineryBuildingBlocks_MachineryOperationMode = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_MachineryBuildingBlocks_MachineryOperationMode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_MachineryBuildingBlocks_LifetimeCounters = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_MachineryBuildingBlocks_LifetimeCounters, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_MachineryBuildingBlocks_OperationCounters = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSDeviceType_MachineryBuildingBlocks_OperationCounters, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Identification = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_Identification, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_DeviceHealthAlarms = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_DeviceHealthAlarms, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Maintenance = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_Maintenance, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Components = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_Components, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_MachineryBuildingBlocks = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_MachineryBuildingBlocks, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_MachineryBuildingBlocks_LifetimeCounters = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_MachineryBuildingBlocks_LifetimeCounters, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_MachineryBuildingBlocks_OperationCounters = new ExpandedNodeId(Opc.Ua.LADS.Objects.LADSComponentType_MachineryBuildingBlocks_OperationCounters, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Identification = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_Identification, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_Lock, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_FunctionSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_ProgramManager, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_ProgramManager_ActiveProgram, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ProgramTemplateSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_ProgramManager_ProgramTemplateSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ResultSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_ProgramManager_ResultSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_SupportedPropertiesSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_SupportedPropertiesSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_FunctionalUnitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionalUnitType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Configuration = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionType_Configuration, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_FunctionSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.FunctionType_FunctionSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor = new ExpandedNodeId(Opc.Ua.LADS.Objects.BaseControlFunctionType_AlarmMonitor, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.BaseControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.BaseControlFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState = new ExpandedNodeId(Opc.Ua.LADS.Objects.BaseControlFunctionType_ControlFunctionState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControllerTuningParameter = new ExpandedNodeId(Opc.Ua.LADS.Objects.BaseControlFunctionType_ControllerTuningParameter, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionType_ControlFunctionState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionWithTotalizerType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.DiscreteControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiStateDiscreteControlFunctionType_ControlFunctionState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState = new ExpandedNodeId(Opc.Ua.LADS.Objects.TwoStateDiscreteControlFunctionType_ControlFunctionState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Configuration = new ExpandedNodeId(Opc.Ua.LADS.Objects.BaseSensorFunctionType_Configuration, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogScalarSensorFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogScalarSensorFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.DiscreteSensorFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_CoverState = new ExpandedNodeId(Opc.Ua.LADS.Objects.CoverFunctionType_CoverState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram = new ExpandedNodeId(Opc.Ua.LADS.Objects.ProgramManagerType_ActiveProgram, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_ProgramTemplateSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.ProgramManagerType_ProgramTemplateSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_ResultSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.ProgramManagerType_ResultSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.http___opcfoundation_org_UA_LADS_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SampleInfoType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.LADS.Objects.SampleInfoType_Encoding_DefaultBinary, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SampleInfoType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.LADS.Objects.SampleInfoType_Encoding_DefaultXml, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SampleInfoType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.LADS.Objects.SampleInfoType_Encoding_DefaultJson, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId KeyValueType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.LADS.Objects.KeyValueType_Encoding_DefaultBinary, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId KeyValueType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.LADS.Objects.KeyValueType_Encoding_DefaultXml, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId KeyValueType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.LADS.Objects.KeyValueType_Encoding_DefaultJson, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.TimerControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.TimerControlFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiModeAnalogControlFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControllerModeSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiModeAnalogControlFunctionType_ControllerModeSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterType_AlarmMonitor = new ExpandedNodeId(Opc.Ua.LADS.Objects.ControllerParameterType_AlarmMonitor, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.ControllerParameterSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_TargetValueSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionWithComposedTargetValueType_TargetValueSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiSensorFunctionType_FunctionSet, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.MultiSensorFunctionType_FunctionSet_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogControlFunctionWithRelativeTargetValueType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogArraySensorFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.SetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId VariableSetType_S_SetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Objects.VariableSetType_S_SetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogSensorFunctionType_AlarmMonitor, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogSensorFunctionType_AlarmMonitor_LimitState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Operational = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogSensorFunctionType_Operational, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Calibration = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogSensorFunctionType_Calibration, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Tuning = new ExpandedNodeId(Opc.Ua.LADS.Objects.AnalogSensorFunctionType_Tuning, Opc.Ua.LADS.Namespaces.LADS);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ActiveProgramType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.LADSComponentsType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationCountersType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.LADSOperationCountersType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.FunctionalUnitSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.FunctionSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ProgramTemplateSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ProgramTemplateType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SupportedPropertiesSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.SupportedPropertiesSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SupportedPropertyType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.SupportedPropertyType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ResultFileSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ResultFileType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ResultSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ResultType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.CoverStateMachineType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.LADSDeviceStateMachineType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.FunctionalStateMachineType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.RunningStateMachineType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.MaintenanceSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.MaintenanceTaskType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.LADSDeviceType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.LADSComponentType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.FunctionalUnitType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.FunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.BaseControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionWithTotalizerType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.DiscreteControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.MultiStateDiscreteControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.TwoStateDiscreteControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.BaseSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogScalarSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.DiscreteSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.CoverFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ProgramManagerType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.TimerControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogScalarSensorFunctionWithCompensationType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerTuningParameterType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ControllerTuningParameterType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId PidControllerParameterType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.PidControllerParameterType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.TwoStateDiscreteSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.MultiStateDiscreteSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.FunctionalUnitStateMachineType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ControlFunctionStateMachineType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.MultiModeAnalogControlFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ControllerParameterType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.ControllerParameterSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionWithComposedTargetValueType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.MultiSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogControlFunctionWithRelativeTargetValueType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogArraySensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.SetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId VariableSetType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.VariableSetType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.AnalogSensorFunctionType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType = new ExpandedNodeId(Opc.Ua.LADS.ObjectTypes.LADSOperationModeStateMachineType, Opc.Ua.LADS.Namespaces.LADS);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_CurrentPauseTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_CurrentPauseTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_CurrentRuntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_CurrentRuntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_CurrentStepName = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_CurrentStepName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_CurrentStepNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_CurrentStepNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_CurrentStepRuntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_CurrentStepRuntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_EstimatedRuntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_EstimatedRuntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_EstimatedStepNumbers = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_EstimatedStepNumbers, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_EstimatedStepRuntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_EstimatedStepRuntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_DeviceProgramRunId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_DeviceProgramRunId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveProgramType_CurrentProgramTemplate = new ExpandedNodeId(Opc.Ua.LADS.Variables.ActiveProgramType_CurrentProgramTemplate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_Component_Identification_Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_Component_Identification_Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_Component_Identification_SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_Component_Identification_SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Identification_Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Identification_Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Identification_SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Identification_SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Maintenance_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Maintenance_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentsType_S_Component__Components_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentsType_S_Component__Components_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationCountersType_LifeTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationCountersType_LifeTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationCountersType_LifeTime_StartValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationCountersType_LifeTime_StartValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationCountersType_LifeTime_LimitValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationCountersType_LifeTime_LimitValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_ProgramTemplateSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_ProgramTemplateSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Download_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Download_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Download_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Download_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Remove_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Remove_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Upload_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Upload_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_Upload_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_Upload_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__ProgramManager_ResultSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__ProgramManager_ResultSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_CurrentState_EffectiveDisplayName = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_CurrentState_EffectiveDisplayName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_Start_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_Start_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_StartProgram_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_StartProgram_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__FunctionalUnitState_StartProgram_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__FunctionalUnitState_StartProgram_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Operational_StartProgram_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Operational_StartProgram_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitSetType_S_SetElement__Operational_StartProgram_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitSetType_S_SetElement__Operational_StartProgram_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionSetType_S_SetElement__IsEnabled = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionSetType_S_SetElement__IsEnabled, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement__Author = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_S_SetElement__Author, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement__Created = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_S_SetElement__Created, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement__Description = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_S_SetElement__Description, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement__Modified = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_S_SetElement__Modified, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement__DeviceTemplateId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_S_SetElement__DeviceTemplateId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateSetType_S_SetElement__Version = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateSetType_S_SetElement__Version, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_Author = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_Author, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_Created = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_Created, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_Description = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_Description, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_Modified = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_Modified, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_DeviceTemplateId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_DeviceTemplateId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_Version = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_Version, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramTemplateType_SupervisoryTemplateId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramTemplateType_SupervisoryTemplateId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileSetType_S_SetElement__MimeType = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultFileSetType_S_SetElement__MimeType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileSetType_S_SetElement__Name = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultFileSetType_S_SetElement__Name, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileType_MimeType = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultFileType_MimeType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileType_Name = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultFileType_Name, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultFileType_URL = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultFileType_URL, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ApplicationUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ApplicationUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__Description = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__Description, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__SupervisoryJobId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__SupervisoryJobId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__Samples = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__Samples, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__Started = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__Started, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__Stopped = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__Stopped, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate_Author = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ProgramTemplate_Author, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate_Created = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ProgramTemplate_Created, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate_Description = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ProgramTemplate_Description, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate_Modified = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ProgramTemplate_Modified, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate_DeviceTemplateId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ProgramTemplate_DeviceTemplateId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__ProgramTemplate_Version = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__ProgramTemplate_Version, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__User = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__User, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__Properties = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__Properties, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultSetType_S_SetElement__SupervisoryTaskId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultSetType_S_SetElement__SupervisoryTaskId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ApplicationUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ApplicationUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_Description = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_Description, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_SupervisoryJobId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_SupervisoryJobId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_Samples = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_Samples, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_Started = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_Started, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_Stopped = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_Stopped, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate_Author = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ProgramTemplate_Author, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate_Created = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ProgramTemplate_Created, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate_Description = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ProgramTemplate_Description, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate_Modified = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ProgramTemplate_Modified, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate_DeviceTemplateId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ProgramTemplate_DeviceTemplateId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_ProgramTemplate_Version = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_ProgramTemplate_Version, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_User = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_User, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_Properties = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_Properties, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_SupervisoryTaskId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_SupervisoryTaskId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_DeviceProgramRunId = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_DeviceProgramRunId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_TotalRuntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_TotalRuntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_TotalPauseTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_TotalPauseTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ResultType_EstimatedRuntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ResultType_EstimatedRuntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Closed_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Closed_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Error_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Error_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Locked_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Locked_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Opened_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Opened_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_OpenedToClosed_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_OpenedToClosed_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToOpened_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ClosedToOpened_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToLocked_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ClosedToLocked_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockedToClosed_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_LockedToClosed_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockedToError_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_LockedToError_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToError_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ClosedToError_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ErrorToOpened_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ErrorToOpened_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockedToUnlocking_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_LockedToUnlocking_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Unlocking_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Unlocking_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Locking_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Locking_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Opening_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Opening_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_Closing_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_Closing_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_UnlockingToClosed_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_UnlockingToClosed_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToOpening_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ClosedToOpening_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_OpeningToOpened_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_OpeningToOpened_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_OpenedToClosing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_OpenedToClosing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosingToClosed_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ClosingToClosed_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_ClosedToLocking_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_ClosedToLocking_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverStateMachineType_LockingToLocked_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverStateMachineType_LockingToLocked_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Operate_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_Operate_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_OperateToShutdown_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_OperateToShutdown_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_OperateToSleep_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_OperateToSleep_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Initialization_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_Initialization_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_InitializationToOperate_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_InitializationToOperate_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Shutdown_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_Shutdown_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_Sleep_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_Sleep_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceStateMachineType_SleepToOperate_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceStateMachineType_SleepToOperate_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_CurrentState_EffectiveDisplayName = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_CurrentState_EffectiveDisplayName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Aborted_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_Aborted_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_AbortedToClearing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_AbortedToClearing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Aborting_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_Aborting_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_AbortingToAborted_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_AbortingToAborted_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Clearing_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_Clearing_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Stopped_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_Stopped_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Running_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_Running_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_Stopping_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_Stopping_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_StoppingToStopped_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_StoppingToStopped_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_StoppedToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_StoppedToRunning_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_RunningToAborting_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_RunningToAborting_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_ClearingToStopped_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_ClearingToStopped_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_RunningToStopping_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_RunningToStopping_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalStateMachineType_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalStateMachineType_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Complete_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Complete_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Completing_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Completing_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Execute_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Execute_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Held_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Held_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Holding_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Holding_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Idle_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Idle_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Resetting_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Resetting_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Starting_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Starting_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Suspended_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Suspended_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Suspending_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Suspending_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Unholding_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Unholding_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_Unsuspending_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_Unsuspending_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_IdleToStarting_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_IdleToStarting_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_StartingToExecute_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_StartingToExecute_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ExecuteToCompleting_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_ExecuteToCompleting_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_CompletingToComplete_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_CompletingToComplete_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_CompleteToResetting_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_CompleteToResetting_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ResettingToIdle_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_ResettingToIdle_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ExecuteToSuspending_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_ExecuteToSuspending_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendingToSuspended_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_SuspendingToSuspended_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendedToUnsuspending_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_SuspendedToUnsuspending_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnsuspendingToExecute_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_UnsuspendingToExecute_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_ExecuteToHolding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_ExecuteToHolding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_HoldingToHeld_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_HoldingToHeld_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_HeldToUnholding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_HeldToUnholding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnholdingToExecute_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_UnholdingToExecute_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendingToHolding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_SuspendingToHolding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_StartingToHolding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_StartingToHolding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_SuspendedToHolding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_SuspendedToHolding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnsuspendingToHolding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_UnsuspendingToHolding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId RunningStateMachineType_UnholdingToHolding_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.RunningStateMachineType_UnholdingToHolding_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__NormalState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__NormalState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceSetType_S_SetElement__StopTask_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceSetType_S_SetElement__StopTask_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_LastExecutionDate = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_LastExecutionDate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_RecurrencePeriod = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_RecurrencePeriod, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_LastOperatingTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_LastOperatingTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_NextOperatingTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_NextOperatingTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_LastOperatingCycles = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_LastOperatingCycles, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_NextOperatingCycles = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_NextOperatingCycles, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_StopTask_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_StopTask_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_ConfigurationChanged = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_ConfigurationChanged, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_EstimatedDowntime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_EstimatedDowntime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_MaintenanceMethod = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_MaintenanceMethod, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_MaintenanceSupplier = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_MaintenanceSupplier, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_PartsOfAssetReplaced = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_PartsOfAssetReplaced, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_PartsOfAssetServiced = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_PartsOfAssetServiced, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_PlannedDate = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_PlannedDate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskType_QualificationOfPersonnel = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskType_QualificationOfPersonnel, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_ManufacturerUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Model = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Model, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_HardwareRevision = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_HardwareRevision, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_SoftwareRevision, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceRevision = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_DeviceRevision, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_ProductCode = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_ProductCode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceManual = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_DeviceManual, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceClass = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_DeviceClass, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_ProductInstanceUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_RevisionCounter = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_RevisionCounter, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_AssetId = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_AssetId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_ComponentName = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_ComponentName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceHealth = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_DeviceHealth, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_FunctionalUnitSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_FunctionalUnitSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Identification_Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Identification_Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Identification_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Identification_ProductInstanceUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Identification_SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Identification_SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_DeviceState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_DeviceState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_DeviceState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_Maintenance_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_Maintenance_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_OperationalLocation = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_OperationalLocation, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSDeviceType_HierarchicalLocation = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSDeviceType_HierarchicalLocation, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_ManufacturerUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Model = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Model, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_HardwareRevision = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_HardwareRevision, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_SoftwareRevision, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_DeviceRevision = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_DeviceRevision, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_ProductCode = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_ProductCode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_DeviceManual = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_DeviceManual, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_DeviceClass = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_DeviceClass, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_ProductInstanceUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_RevisionCounter = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_RevisionCounter, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_AssetId = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_AssetId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_ComponentName = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_ComponentName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_DeviceHealth = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_DeviceHealth, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Identification_Manufacturer = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Identification_Manufacturer, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Identification_SerialNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Identification_SerialNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_Maintenance_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_Maintenance_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_OperationalLocation = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_OperationalLocation, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSComponentType_HierarchicalLocation = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSComponentType_HierarchicalLocation, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Download_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Download_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Download_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Download_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Remove_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Remove_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Upload_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Upload_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Upload_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_Upload_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ResultSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ProgramManager_ResultSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_CurrentState_EffectiveDisplayName = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_CurrentState_EffectiveDisplayName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_Start_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_Start_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_StartProgram_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_StartProgram_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionalUnitState_StartProgram_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_FunctionalUnitState_StartProgram_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_AssetId = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_AssetId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_ComponentName = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_ComponentName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_EffectiveDisplayName = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Operational_EffectiveDisplayName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_StartProgram_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Operational_StartProgram_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitType_Operational_StartProgram_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitType_Operational_StartProgram_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionType_IsEnabled = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionType_IsEnabled, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionType_TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionType_TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_TotalizedValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_TotalizedValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithTotalizerType_ResetTotalizer_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithTotalizerType_ResetTotalizer_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteControlFunctionType_TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteControlFunctionType_TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_CurrentValue_EnumStrings = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_CurrentValue_EnumStrings, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteControlFunctionType_TargetValue_EnumStrings = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteControlFunctionType_TargetValue_EnumStrings, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_CurrentValue_FalseState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_CurrentValue_FalseState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_CurrentValue_TrueState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_CurrentValue_TrueState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_TargetValue_FalseState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_TargetValue_FalseState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteControlFunctionType_TargetValue_TrueState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteControlFunctionType_TargetValue_TrueState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId BaseSensorFunctionType_Configuration_IsEnabled = new ExpandedNodeId(Opc.Ua.LADS.Variables.BaseSensorFunctionType_Configuration_IsEnabled, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_RawValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_RawValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionType_SensorValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionType_SensorValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId DiscreteSensorFunctionType_SensorValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.DiscreteSensorFunctionType_SensorValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId CoverFunctionType_CoverState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.CoverFunctionType_CoverState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_ProgramTemplateSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_ProgramTemplateSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Download_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Download_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Download_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Download_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Remove_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Remove_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Upload_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Upload_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_Upload_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_Upload_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramManagerType_ResultSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.ProgramManagerType_ResultSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__NamespaceUri = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__NamespaceUri, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__NamespaceVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__NamespaceVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__NamespacePublicationDate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__IsNamespaceSubset, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__StaticNodeIdTypes, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__StaticNumericNodeIdRange, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_LADS__StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.LADS.Variables.http___opcfoundation_org_UA_LADS__StaticStringNodeIdPattern, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_DifferenceValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_DifferenceValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_DifferenceValue_EngineeringUnits = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_DifferenceValue_EngineeringUnits, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_TargetValue_EngineeringUnits = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_TargetValue_EngineeringUnits, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TimerControlFunctionType_CurrentValue_EngineeringUnits = new ExpandedNodeId(Opc.Ua.LADS.Variables.TimerControlFunctionType_CurrentValue_EngineeringUnits, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogScalarSensorFunctionWithCompensationType_CompensationValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogScalarSensorFunctionWithCompensationType_CompensationValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId PidControllerParameterType_CtrlP = new ExpandedNodeId(Opc.Ua.LADS.Variables.PidControllerParameterType_CtrlP, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId PidControllerParameterType_CtrlTd = new ExpandedNodeId(Opc.Ua.LADS.Variables.PidControllerParameterType_CtrlTd, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId PidControllerParameterType_CtrlTi = new ExpandedNodeId(Opc.Ua.LADS.Variables.PidControllerParameterType_CtrlTi, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_SensorValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_SensorValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_SensorValue_FalseState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_SensorValue_FalseState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId TwoStateDiscreteSensorFunctionType_SensorValue_TrueState = new ExpandedNodeId(Opc.Ua.LADS.Variables.TwoStateDiscreteSensorFunctionType_SensorValue_TrueState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_SensorValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_SensorValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiStateDiscreteSensorFunctionType_SensorValue_EnumStrings = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiStateDiscreteSensorFunctionType_SensorValue_EnumStrings, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceTaskResultEnum_EnumValues = new ExpandedNodeId(Opc.Ua.LADS.Variables.MaintenanceTaskResultEnum_EnumValues, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_CurrentState_EffectiveDisplayName = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_CurrentState_EffectiveDisplayName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Aborted_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Aborted_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_AbortedToClearing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_AbortedToClearing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Aborting_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Aborting_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_AbortingToAborted_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_AbortingToAborted_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Clearing_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Clearing_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Stopped_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Stopped_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Running_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Running_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Stopping_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Stopping_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StoppingToStopped_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_StoppingToStopped_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StoppedToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_StoppedToRunning_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_RunningToAborting_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_RunningToAborting_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_ClearingToStopped_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_ClearingToStopped_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_RunningToStopping_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_RunningToStopping_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_Start_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_Start_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StartProgram_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_StartProgram_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalUnitStateMachineType_StartProgram_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.FunctionalUnitStateMachineType_StartProgram_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Aborted_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_Aborted_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_AbortedToClearing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_AbortedToClearing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Aborting_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_Aborting_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_AbortingToAborted_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_AbortingToAborted_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Clearing_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_Clearing_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Stopped_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_Stopped_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Running_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_Running_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_Stopping_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_Stopping_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_StoppingToStopped_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_StoppingToStopped_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_StoppedToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_StoppedToRunning_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_RunningToAborting_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_RunningToAborting_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_ClearingToStopped_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_ClearingToStopped_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_RunningToStopping_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_RunningToStopping_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControlFunctionStateMachineType_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControlFunctionStateMachineType_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_CurrentMode = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_CurrentMode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiModeAnalogControlFunctionType_CurrentMode_EnumStrings = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiModeAnalogControlFunctionType_CurrentMode_EnumStrings, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterType_CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControllerParameterType_CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterType_TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControllerParameterType_TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterSetType_S_SetElement__CurrentValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControllerParameterSetType_S_SetElement__CurrentValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerParameterSetType_S_SetElement__TargetValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.ControllerParameterSetType_S_SetElement__TargetValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithComposedTargetValueType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId MultiSensorFunctionType_FunctionSet_S_SetElement__IsEnabled = new ExpandedNodeId(Opc.Ua.LADS.Variables.MultiSensorFunctionType_FunctionSet_S_SetElement__IsEnabled, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_HighHighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_HighHighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_HighLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_HighLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LowLowLimit = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LowLowLimit, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SetpointNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_AlarmMonitor_SetpointNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_AvailableStates = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_AvailableStates, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_AvailableTransitions = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_AvailableTransitions, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_RunningStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_RunningStateMachine_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_StartWithTargetValue_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ControlFunctionState_StartWithTargetValue_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_IncreaseRate = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_IncreaseRate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_DecreaseRate = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_DecreaseRate, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueBy_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogControlFunctionWithRelativeTargetValueType_ModifyTargetValueBy_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_RawValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_RawValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogArraySensorFunctionType_SensorValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogArraySensorFunctionType_SensorValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId SetType_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.SetType_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId VariableSetType_S_VariableSetElement_ = new ExpandedNodeId(Opc.Ua.LADS.Variables.VariableSetType_S_VariableSetElement_, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_Locked = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_Locked, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_LockingClient, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_LockingUser, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_RemainingLockTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_InitLock_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_InitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_RenewLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_ExitLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Lock_BreakLock_OutputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_FunctionSet_NodeVersion = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_FunctionSet_NodeVersion, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EventId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EventType, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SourceNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SourceName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Time, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ReceiveTime, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Message, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Severity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConditionClassId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConditionClassName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConditionName, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_BranchId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Retain, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EnabledState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Quality, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LastSeverity, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Comment, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ClientUserId, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_AckedState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_AckedState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ActiveState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_InputNode, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_CalibrationValues = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_CalibrationValues, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Damping = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_Damping, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_RawValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_RawValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId AnalogSensorFunctionType_SensorValue = new ExpandedNodeId(Opc.Ua.LADS.Variables.AnalogSensorFunctionType_SensorValue, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromNoneToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromNoneToNone_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromNoneToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromNoneToSetup_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromProcessingToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromProcessingToNone_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromSetupToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromSetupToNone_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_FromSetupToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_FromSetupToSetup_TransitionNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_Maintenance_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_Maintenance_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_None_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_None_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_Processing_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_Processing_StateNumber, Opc.Ua.LADS.Namespaces.LADS);

        /// <remarks />
        public static readonly ExpandedNodeId LADSOperationModeStateMachineType_Setup_StateNumber = new ExpandedNodeId(Opc.Ua.LADS.Variables.LADSOperationModeStateMachineType_Setup_StateNumber, Opc.Ua.LADS.Namespaces.LADS);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Abort = "Abort";

        /// <remarks />
        public const string Aborted = "Aborted";

        /// <remarks />
        public const string AbortedToClearing = "AbortedToClearing";

        /// <remarks />
        public const string Aborting = "Aborting";

        /// <remarks />
        public const string AbortingToAborted = "AbortingToAborted";

        /// <remarks />
        public const string AcknowledgeMethodType = "AcknowledgeMethodType";

        /// <remarks />
        public const string ActiveProgram = "ActiveProgram";

        /// <remarks />
        public const string ActiveProgramType = "ActiveProgramType";

        /// <remarks />
        public const string AddCommentMethodType = "AddCommentMethodType";

        /// <remarks />
        public const string AlarmMonitor = "AlarmMonitor";

        /// <remarks />
        public const string AnalogArraySensorFunctionType = "AnalogArraySensorFunctionType";

        /// <remarks />
        public const string AnalogControlFunctionType = "AnalogControlFunctionType";

        /// <remarks />
        public const string AnalogControlFunctionWithComposedTargetValueType = "AnalogControlFunctionWithComposedTargetValueType";

        /// <remarks />
        public const string AnalogControlFunctionWithRelativeTargetValueType = "AnalogControlFunctionWithRelativeTargetValueType";

        /// <remarks />
        public const string AnalogControlFunctionWithTotalizerType = "AnalogControlFunctionWithTotalizerType";

        /// <remarks />
        public const string AnalogScalarSensorFunctionType = "AnalogScalarSensorFunctionType";

        /// <remarks />
        public const string AnalogScalarSensorFunctionWithCompensationType = "AnalogScalarSensorFunctionWithCompensationType";

        /// <remarks />
        public const string AnalogSensorFunctionType = "AnalogSensorFunctionType";

        /// <remarks />
        public const string ApplicationUri = "ApplicationUri";

        /// <remarks />
        public const string Author = "Author";

        /// <remarks />
        public const string BaseControlFunctionType = "BaseControlFunctionType";

        /// <remarks />
        public const string BaseSensorFunctionType = "BaseSensorFunctionType";

        /// <remarks />
        public const string BreakLockMethodType = "BreakLockMethodType";

        /// <remarks />
        public const string Calibration = "Calibration";

        /// <remarks />
        public const string CalibrationValues = "CalibrationValues";

        /// <remarks />
        public const string Clear = "Clear";

        /// <remarks />
        public const string Clearing = "Clearing";

        /// <remarks />
        public const string ClearingToStopped = "ClearingToStopped";

        /// <remarks />
        public const string Close = "Close";

        /// <remarks />
        public const string Closed = "Closed";

        /// <remarks />
        public const string ClosedToError = "ClosedToError";

        /// <remarks />
        public const string ClosedToLocked = "ClosedToLocked";

        /// <remarks />
        public const string ClosedToLocking = "ClosedToLocking";

        /// <remarks />
        public const string ClosedToOpened = "ClosedToOpened";

        /// <remarks />
        public const string ClosedToOpening = "ClosedToOpening";

        /// <remarks />
        public const string Closing = "Closing";

        /// <remarks />
        public const string ClosingToClosed = "ClosingToClosed";

        /// <remarks />
        public const string CompensationValue = "CompensationValue";

        /// <remarks />
        public const string Complete = "Complete";

        /// <remarks />
        public const string CompleteToResetting = "CompleteToResetting";

        /// <remarks />
        public const string Completing = "Completing";

        /// <remarks />
        public const string CompletingToComplete = "CompletingToComplete";

        /// <remarks />
        public const string Configuration = "Configuration";

        /// <remarks />
        public const string ControlFunctionState = "ControlFunctionState";

        /// <remarks />
        public const string ControlFunctionStateMachineType = "ControlFunctionStateMachineType";

        /// <remarks />
        public const string ControllerModeSet = "ControllerModeSet";

        /// <remarks />
        public const string ControllerParameterSetType = "ControllerParameterSetType";

        /// <remarks />
        public const string ControllerParameterType = "ControllerParameterType";

        /// <remarks />
        public const string ControllerTuningParameter = "ControllerTuningParameter";

        /// <remarks />
        public const string ControllerTuningParameterType = "ControllerTuningParameterType";

        /// <remarks />
        public const string CoverFunctionType = "CoverFunctionType";

        /// <remarks />
        public const string CoverState = "CoverState";

        /// <remarks />
        public const string CoverStateMachineType = "CoverStateMachineType";

        /// <remarks />
        public const string Created = "Created";

        /// <remarks />
        public const string CtrlP = "CtrlP";

        /// <remarks />
        public const string CtrlTd = "CtrlTd";

        /// <remarks />
        public const string CtrlTi = "CtrlTi";

        /// <remarks />
        public const string CurrentMode = "CurrentMode";

        /// <remarks />
        public const string CurrentPauseTime = "CurrentPauseTime";

        /// <remarks />
        public const string CurrentProgramTemplate = "CurrentProgramTemplate";

        /// <remarks />
        public const string CurrentRuntime = "CurrentRuntime";

        /// <remarks />
        public const string CurrentStepName = "CurrentStepName";

        /// <remarks />
        public const string CurrentStepNumber = "CurrentStepNumber";

        /// <remarks />
        public const string CurrentStepRuntime = "CurrentStepRuntime";

        /// <remarks />
        public const string CurrentValue = "CurrentValue";

        /// <remarks />
        public const string Damping = "Damping";

        /// <remarks />
        public const string DecreaseRate = "DecreaseRate";

        /// <remarks />
        public const string Description = "Description";

        /// <remarks />
        public const string DeviceProgramRunId = "DeviceProgramRunId";

        /// <remarks />
        public const string DeviceState = "DeviceState";

        /// <remarks />
        public const string DeviceTemplateId = "DeviceTemplateId";

        /// <remarks />
        public const string DifferenceValue = "DifferenceValue";

        /// <remarks />
        public const string DiscreteControlFunctionType = "DiscreteControlFunctionType";

        /// <remarks />
        public const string DiscreteSensorFunctionType = "DiscreteSensorFunctionType";

        /// <remarks />
        public const string Download = "Download";

        /// <remarks />
        public const string DownloadMethodType = "DownloadMethodType";

        /// <remarks />
        public const string Error = "Error";

        /// <remarks />
        public const string ErrorToOpened = "ErrorToOpened";

        /// <remarks />
        public const string EstimatedRuntime = "EstimatedRuntime";

        /// <remarks />
        public const string EstimatedStepNumbers = "EstimatedStepNumbers";

        /// <remarks />
        public const string EstimatedStepRuntime = "EstimatedStepRuntime";

        /// <remarks />
        public const string Execute = "Execute";

        /// <remarks />
        public const string ExecuteToCompleting = "ExecuteToCompleting";

        /// <remarks />
        public const string ExecuteToHolding = "ExecuteToHolding";

        /// <remarks />
        public const string ExecuteToSuspending = "ExecuteToSuspending";

        /// <remarks />
        public const string ExitLockMethodType = "ExitLockMethodType";

        /// <remarks />
        public const string File = "File";

        /// <remarks />
        public const string FileSet = "FileSet";

        /// <remarks />
        public const string FunctionalStateMachineType = "FunctionalStateMachineType";

        /// <remarks />
        public const string FunctionalUnitSet = "FunctionalUnitSet";

        /// <remarks />
        public const string FunctionalUnitSetType = "FunctionalUnitSetType";

        /// <remarks />
        public const string FunctionalUnitState = "FunctionalUnitState";

        /// <remarks />
        public const string FunctionalUnitStateMachineType = "FunctionalUnitStateMachineType";

        /// <remarks />
        public const string FunctionalUnitType = "FunctionalUnitType";

        /// <remarks />
        public const string FunctionSet = "FunctionSet";

        /// <remarks />
        public const string FunctionSetType = "FunctionSetType";

        /// <remarks />
        public const string FunctionType = "FunctionType";

        /// <remarks />
        public const string GotoMaintenance = "GotoMaintenance";

        /// <remarks />
        public const string GotoOperate = "GotoOperate";

        /// <remarks />
        public const string GotoProcessing = "GotoProcessing";

        /// <remarks />
        public const string GotoSetup = "GotoSetup";

        /// <remarks />
        public const string GotoShutdown = "GotoShutdown";

        /// <remarks />
        public const string GotoSleep = "GotoSleep";

        /// <remarks />
        public const string Held = "Held";

        /// <remarks />
        public const string HeldToUnholding = "HeldToUnholding";

        /// <remarks />
        public const string Hold = "Hold";

        /// <remarks />
        public const string Holding = "Holding";

        /// <remarks />
        public const string HoldingToHeld = "HoldingToHeld";

        /// <remarks />
        public const string http___opcfoundation_org_UA_LADS_ = "http://opcfoundation.org/UA/LADS/";

        /// <remarks />
        public const string Idle = "Idle";

        /// <remarks />
        public const string IdleToStarting = "IdleToStarting";

        /// <remarks />
        public const string IncreaseRate = "IncreaseRate";

        /// <remarks />
        public const string Initialization = "Initialization";

        /// <remarks />
        public const string InitializationToOperate = "InitializationToOperate";

        /// <remarks />
        public const string InitLockMethodType = "InitLockMethodType";

        /// <remarks />
        public const string IsEnabled = "IsEnabled";

        /// <remarks />
        public const string KeyValueType = "KeyValueType";

        /// <remarks />
        public const string LADSComponentsType = "LADSComponentsType";

        /// <remarks />
        public const string LADSComponentType = "LADSComponentType";

        /// <remarks />
        public const string LADSDeviceStateMachineType = "LADSDeviceStateMachineType";

        /// <remarks />
        public const string LADSDeviceType = "LADSDeviceType";

        /// <remarks />
        public const string LADSOperationCountersType = "LADSOperationCountersType";

        /// <remarks />
        public const string LADSOperationModeStateMachineType = "LADSOperationModeStateMachineType";

        /// <remarks />
        public const string LastExecutionDate = "LastExecutionDate";

        /// <remarks />
        public const string LastOperatingCycles = "LastOperatingCycles";

        /// <remarks />
        public const string LastOperatingTime = "LastOperatingTime";

        /// <remarks />
        public const string LifeTime = "LifeTime";

        /// <remarks />
        public const string Lock = "Lock";

        /// <remarks />
        public const string Locked = "Locked";

        /// <remarks />
        public const string LockedToClosed = "LockedToClosed";

        /// <remarks />
        public const string LockedToError = "LockedToError";

        /// <remarks />
        public const string LockedToUnlocking = "LockedToUnlocking";

        /// <remarks />
        public const string Locking = "Locking";

        /// <remarks />
        public const string LockingToLocked = "LockingToLocked";

        /// <remarks />
        public const string Maintenance = "Maintenance";

        /// <remarks />
        public const string MaintenanceSetType = "MaintenanceSetType";

        /// <remarks />
        public const string MaintenanceTaskResultEnum = "MaintenanceTaskResultEnum";

        /// <remarks />
        public const string MaintenanceTaskType = "MaintenanceTaskType";

        /// <remarks />
        public const string MimeType = "MimeType";

        /// <remarks />
        public const string Modified = "Modified";

        /// <remarks />
        public const string ModifyTargetValueBy = "ModifyTargetValueBy";

        /// <remarks />
        public const string ModifyTargetValueByMethodType = "ModifyTargetValueByMethodType";

        /// <remarks />
        public const string MultiModeAnalogControlFunctionType = "MultiModeAnalogControlFunctionType";

        /// <remarks />
        public const string MultiSensorFunctionType = "MultiSensorFunctionType";

        /// <remarks />
        public const string MultiStateDiscreteControlFunctionType = "MultiStateDiscreteControlFunctionType";

        /// <remarks />
        public const string MultiStateDiscreteSensorFunctionType = "MultiStateDiscreteSensorFunctionType";

        /// <remarks />
        public const string Name = "Name";

        /// <remarks />
        public const string NextOperatingCycles = "NextOperatingCycles";

        /// <remarks />
        public const string NextOperatingTime = "NextOperatingTime";

        /// <remarks />
        public const string Open = "Open";

        /// <remarks />
        public const string Opened = "Opened";

        /// <remarks />
        public const string OpenedToClosed = "OpenedToClosed";

        /// <remarks />
        public const string OpenedToClosing = "OpenedToClosing";

        /// <remarks />
        public const string Opening = "Opening";

        /// <remarks />
        public const string OpeningToOpened = "OpeningToOpened";

        /// <remarks />
        public const string Operate = "Operate";

        /// <remarks />
        public const string OperateToShutdown = "OperateToShutdown";

        /// <remarks />
        public const string OperateToSleep = "OperateToSleep";

        /// <remarks />
        public const string Operational = "Operational";

        /// <remarks />
        public const string PidControllerParameterType = "PidControllerParameterType";

        /// <remarks />
        public const string ProgramManager = "ProgramManager";

        /// <remarks />
        public const string ProgramManagerType = "ProgramManagerType";

        /// <remarks />
        public const string ProgramTemplate = "ProgramTemplate";

        /// <remarks />
        public const string ProgramTemplateSet = "ProgramTemplateSet";

        /// <remarks />
        public const string ProgramTemplateSetType = "ProgramTemplateSetType";

        /// <remarks />
        public const string ProgramTemplateType = "ProgramTemplateType";

        /// <remarks />
        public const string Properties = "Properties";

        /// <remarks />
        public const string RawValue = "RawValue";

        /// <remarks />
        public const string RecurrencePeriod = "RecurrencePeriod";

        /// <remarks />
        public const string Remove = "Remove";

        /// <remarks />
        public const string RemoveMethodType = "RemoveMethodType";

        /// <remarks />
        public const string RenewLockMethodType = "RenewLockMethodType";

        /// <remarks />
        public const string Reset = "Reset";

        /// <remarks />
        public const string ResetTask = "ResetTask";

        /// <remarks />
        public const string Resetting = "Resetting";

        /// <remarks />
        public const string ResettingToIdle = "ResettingToIdle";

        /// <remarks />
        public const string ResetTotalizer = "ResetTotalizer";

        /// <remarks />
        public const string ResetTotalizerMethodType = "ResetTotalizerMethodType";

        /// <remarks />
        public const string ResultFileSetType = "ResultFileSetType";

        /// <remarks />
        public const string ResultFileType = "ResultFileType";

        /// <remarks />
        public const string ResultSet = "ResultSet";

        /// <remarks />
        public const string ResultSetType = "ResultSetType";

        /// <remarks />
        public const string ResultType = "ResultType";

        /// <remarks />
        public const string Running = "Running";

        /// <remarks />
        public const string RunningStateMachine = "RunningStateMachine";

        /// <remarks />
        public const string RunningStateMachineType = "RunningStateMachineType";

        /// <remarks />
        public const string RunningToAborting = "RunningToAborting";

        /// <remarks />
        public const string RunningToStopping = "RunningToStopping";

        /// <remarks />
        public const string S_SetElement_ = "<SetElement>";

        /// <remarks />
        public const string S_VariableSetElement_ = "<VariableSetElement>";

        /// <remarks />
        public const string SampleInfoType = "SampleInfoType";

        /// <remarks />
        public const string Samples = "Samples";

        /// <remarks />
        public const string SensorValue = "SensorValue";

        /// <remarks />
        public const string SetElement = "<SetElement>";

        /// <remarks />
        public const string SetType = "SetType";

        /// <remarks />
        public const string Shutdown = "Shutdown";

        /// <remarks />
        public const string Sleep = "Sleep";

        /// <remarks />
        public const string SleepToOperate = "SleepToOperate";

        /// <remarks />
        public const string Start = "Start";

        /// <remarks />
        public const string Started = "Started";

        /// <remarks />
        public const string Starting = "Starting";

        /// <remarks />
        public const string StartingToExecute = "StartingToExecute";

        /// <remarks />
        public const string StartingToHolding = "StartingToHolding";

        /// <remarks />
        public const string StartMethodType = "StartMethodType";

        /// <remarks />
        public const string StartProgram = "StartProgram";

        /// <remarks />
        public const string StartProgramMethodType = "StartProgramMethodType";

        /// <remarks />
        public const string StartTask = "StartTask";

        /// <remarks />
        public const string StartWithTargetValue = "StartWithTargetValue";

        /// <remarks />
        public const string StartWithTargetValueMethodType = "StartWithTargetValueMethodType";

        /// <remarks />
        public const string Stop = "Stop";

        /// <remarks />
        public const string Stopped = "Stopped";

        /// <remarks />
        public const string StoppedToRunning = "StoppedToRunning";

        /// <remarks />
        public const string Stopping = "Stopping";

        /// <remarks />
        public const string StoppingToStopped = "StoppingToStopped";

        /// <remarks />
        public const string StopTask = "StopTask";

        /// <remarks />
        public const string StopTaskMethodType = "StopTaskMethodType";

        /// <remarks />
        public const string SupervisoryJobId = "SupervisoryJobId";

        /// <remarks />
        public const string SupervisoryTaskId = "SupervisoryTaskId";

        /// <remarks />
        public const string SupervisoryTemplateId = "SupervisoryTemplateId";

        /// <remarks />
        public const string SupportedPropertiesSet = "SupportedPropertiesSet";

        /// <remarks />
        public const string SupportedPropertiesSetType = "SupportedPropertiesSetType";

        /// <remarks />
        public const string SupportedPropertyType = "SupportedPropertyType";

        /// <remarks />
        public const string Suspend = "Suspend";

        /// <remarks />
        public const string Suspended = "Suspended";

        /// <remarks />
        public const string SuspendedToHolding = "SuspendedToHolding";

        /// <remarks />
        public const string SuspendedToUnsuspending = "SuspendedToUnsuspending";

        /// <remarks />
        public const string Suspending = "Suspending";

        /// <remarks />
        public const string SuspendingToHolding = "SuspendingToHolding";

        /// <remarks />
        public const string SuspendingToSuspended = "SuspendingToSuspended";

        /// <remarks />
        public const string TargetValue = "TargetValue";

        /// <remarks />
        public const string TargetValueSet = "TargetValueSet";

        /// <remarks />
        public const string TimerControlFunctionType = "TimerControlFunctionType";

        /// <remarks />
        public const string ToComplete = "ToComplete";

        /// <remarks />
        public const string TotalizedValue = "TotalizedValue";

        /// <remarks />
        public const string TotalPauseTime = "TotalPauseTime";

        /// <remarks />
        public const string TotalRuntime = "TotalRuntime";

        /// <remarks />
        public const string Tuning = "Tuning";

        /// <remarks />
        public const string TwoStateDiscreteControlFunctionType = "TwoStateDiscreteControlFunctionType";

        /// <remarks />
        public const string TwoStateDiscreteSensorFunctionType = "TwoStateDiscreteSensorFunctionType";

        /// <remarks />
        public const string Unhold = "Unhold";

        /// <remarks />
        public const string Unholding = "Unholding";

        /// <remarks />
        public const string UnholdingToExecute = "UnholdingToExecute";

        /// <remarks />
        public const string UnholdingToHolding = "UnholdingToHolding";

        /// <remarks />
        public const string Unlock = "Unlock";

        /// <remarks />
        public const string Unlocking = "Unlocking";

        /// <remarks />
        public const string UnlockingToClosed = "UnlockingToClosed";

        /// <remarks />
        public const string Unsuspend = "Unsuspend";

        /// <remarks />
        public const string Unsuspending = "Unsuspending";

        /// <remarks />
        public const string UnsuspendingToExecute = "UnsuspendingToExecute";

        /// <remarks />
        public const string UnsuspendingToHolding = "UnsuspendingToHolding";

        /// <remarks />
        public const string Upload = "Upload";

        /// <remarks />
        public const string UploadMethodType = "UploadMethodType";

        /// <remarks />
        public const string URL = "URL";

        /// <remarks />
        public const string User = "User";

        /// <remarks />
        public const string VariableSet = "VariableSet";

        /// <remarks />
        public const string VariableSetType = "VariableSetType";

        /// <remarks />
        public const string Version = "Version";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the LADS namespace (.NET code namespace is 'Opc.Ua.LADS').
        /// </summary>
        public const string LADS = "http://opcfoundation.org/UA/LADS/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the MBBB namespace (.NET code namespace is 'Opc.Ua.Machinery').
        /// </summary>
        public const string MBBB = "http://opcfoundation.org/UA/Machinery/";

        /// <summary>
        /// The URI for the AMB namespace (.NET code namespace is 'Opc.Ua.AMB').
        /// </summary>
        public const string AMB = "http://opcfoundation.org/UA/AMB/";
    }
    #endregion
}