Attribute VB_Name = "Resources"
'-----------------------------------------------------------------------------
' <copyright file="Resources.bas" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Resources
'-- String resources for operating the DLL
Public Const SID_INITIALIZE As String = "Initialize"

Public Const SID_FINALIZE As String = "Finalize"

Public Const SID_GET_VERSION As String = "GetVersion"

'-- String resources for establishing and disconnecting the communication path with the controller
Public Const SID_USB_OPEN As String = "UsbOpen"

Public Const SID_ETHERNET_OPEN As String = "EthernetOpen"

Public Const SID_COMM_CLOSE As String = "CommClose"

'-- String resources for controlling the system
Public Const SID_REBOOT_CONTROLLER As String = "RebootContoller"

Public Const SID_RETRUN_TO_FACTORY_SETTING As String = "ReturnToFactorySetting"

Public Const SID_GET_ERROR As String = "GetError"

Public Const SID_CLEAR_ERROR As String = "ClearError"

'-- String resources for controlling measurements
Public Const SID_TRIGGER As String = "Trigger"

Public Const SID_START_MEASURE As String = "StartMeasure"

Public Const SID_STOP_MEASURE As String = "StopMeasure"

Public Const SID_AUTO_ZERO As String = "AutoZero"

Public Const SID_TIMING As String = "Timing"

Public Const SID_RESET As String = "Reset"

Public Const SID_CLEAR_MEMORY As String = "ClearMemory"

'-- String resources for modifying or reading settings
Public Const SID_SET_SETTING As String = "SetSetting"

Public Const SID_GET_SETTING As String = "GetSetting"

Public Const SID_INITIALIZE_SETTING As String = "InitializeSetting"

Public Const SID_REFLECT_SETTING As String = "ReflectSetting"

Public Const SID_REWRITE_TEMPORARY_SETTING As String = "RewriteTemporarySetting"

Public Const SID_CHECK_MEMORY_ACCESS As String = "CheckMemoryAccess"

Public Const SID_SET_TIME As String = "SetTime"

Public Const SID_GET_TIME As String = "GetTime"

Public Const SID_CHANGE_ACTIVE_PROGRAM As String = "ChangeActiveProgram"

Public Const SID_GET_ACTIVE_PROGRAM As String = "GetActiveProgram"

'-- String resources for getting the measurement results
Public Const SID_GET_MEASUREMENT_VALUE As String = "GetMeasurementValue"

Public Const SID_GET_PROFILE As String = "GetProfile"

Public Const SID_GET_BATCH_PROFILE As String = "GetBatchProfile"

Public Const SID_GET_PROFILE_ADVANCE As String = "GetProfileAdvance"

Public Const SID_GET_BATCH_PROFILE_ADVANCE As String = "GetBatchProfileAdvance"

'-- String resources for storage-related functions
Public Const SID_START_STORAGE As String = "StartStorage"

Public Const SID_STOP_STORAGE As String = "StopStorage"

Public Const SID_GET_STORAGE_STATUS As String = "GetStorageStatus"

Public Const SID_GET_STORAGE_DATA As String = "GetStorageData"

Public Const SID_GET_STORAGE_PROFILE As String = "GetStorageProfile"

Public Const SID_GET_STORAGE_BATCH_PROFILE As String = "GetStorageBatchProfile"

'-- Return Code String
Public Const SID_RC_OK As String = "Normal termination"

Public Const SID_RC_ERR_OPEN_DEVICE As String = "Failed to open the device"

Public Const SID_RC_ERR_NO_DEVICE  As String = "Device not open"

Public Const SID_RC_ERR_SEND As String = "Command send error"

Public Const SID_RC_ERR_RECEIVE As String = "Response reception error"

Public Const SID_RC_ERR_TIMEOUT As String = "Time out"

Public Const SID_RC_ERR_NOMEMORY As String = "No free space"

Public Const SID_RC_ERR_PARAMETER As String = "Parameter error"


