Attribute VB_Name = "Module1"
Option Explicit

'------ ! CAUTION ! ------
'
'   LJ-V communication dll requires unsigned 16bit/32bit integer value type parameters in several structures and functions,
'   but Visual Basic 6 cannot handle these types.
'
'   So, in the declarations of the structures and functions, use signed integer value type as unsigned integer value type.
'       i.e. unsigned 16bit integer -> 'Integer'. unsigned 32bit integer -> 'Long'.
'
'   Therefore, when you access the parameters it may be necessary to translate between signed value and unsigned value.
'   Be careful about the ranges of the parameter's value can take.
'
'   The parameters which is originally unsigned type are named with prefix 'w' or 'dw', and commented with "unsigned value".
'
'-------------------------

'-- Note --
'1.
'   LJV7IF_SetSetting() and  LJV7IF_GetSetting() functions cannot call directly.
'       (Visual Basic 6 is not capable of passing structures by value.)
'
'   We provide substitute functions, LJV7IF_SetSettingEx() and LJV7IF_GetSettingEx(). Please use these.
'   These functions' usage are same as LJV7IF_SetSetting() or LJV7IF_GetSetting()
'
'2.
'   High-speed communication mode is not supported on Visual Basic 6.
'   The following functions are not available.
'       LJV7IF_HighSpeedDataUsbCommunicationInitalize()
'       LJV7IF_HighSpeedDataEthernetCommunicationInitalize()
'       LJV7IF_PreStartHighSpeedDataCommunication()
'       LJV7IF_StartHighSpeedDataCommunication()
'       LJV7IF_StopHighSpeedDataCommunication()
'       LJV7IF_HighSpeedDataCommunicationFinalize()
'
'----------


'----- Enumulations
' Return Code List
Public Enum LJV7IF_ReturnCode
    RC_OK = &H0                     ' Completed without errors
    
    ' Communication DLL error notification
    RC_ERR_OPEN_DEVICE = &H1000     ' Failed to open device
    RC_ERR_NO_DEVICE                ' Device is not open
    RC_ERR_SEND                     ' Command sending error
    RC_ERR_RECEIVE                  ' Response receiving error
    RC_ERR_TIMEOUT                  ' Time out
    RC_ERR_NOMEMORY                 ' No free memory
    RC_ERR_PARAMETER                ' Parameter error
    RC_ERR_RECVFMT                  ' Receive header format error
    
    RC_ERR_HS_NODEVICE              ' For high-speed communication mode (Not supported on VB6)
    RC_ERR_HS_OPENYET               ' For high-speed communication mode (Not supported on VB6)
    RC_ERR_HS_RECVYET               ' For high-speed communication mode (Not supported on VB6)
    
    RC_ERR_BUFFER_SHORT             ' Insufficient buffer size

End Enum

' Setting value storage level designation
Public Enum LJV7IF_SettingDepth
    DEPTH_WRITE     ' Write settings area
    DEPTH_RUNNING   ' Running settings area
    DEPTH_SAVE      ' Save area
End Enum

' Initialization target setting item designation
Public Enum LJV7IF_InitSettingTarget
    INIT_SETTING_TARGET_PRG0 = &H0   ' Program 0
    INIT_SETTING_TARGET_PRG1
    INIT_SETTING_TARGET_PRG2
    INIT_SETTING_TARGET_PRG3
    INIT_SETTING_TARGET_PRG4
    INIT_SETTING_TARGET_PRG5
    INIT_SETTING_TARGET_PRG6
    INIT_SETTING_TARGET_PRG7
    INIT_SETTING_TARGET_PRG8
    INIT_SETTING_TARGET_PRG9
    INIT_SETTING_TARGET_PRG10
    INIT_SETTING_TARGET_PRG11
    INIT_SETTING_TARGET_PRG12
    INIT_SETTING_TARGET_PRG13
    INIT_SETTING_TARGET_PRG14
    INIT_SETTING_TARGET_PRG15
End Enum

' Definition that indicates the validity of a measurement value
Public Enum LJV7IF_MeasureDataInfo
    MEASURE_DATA_INFO_VALID = &H0     ' Normal measurement data
    MEASURE_DATA_INFO_ALARM           ' Measurement alarm data
    MEASURE_DATA_INFO_WAIT            ' Judgment wait data
End Enum

' Definition that indicates the tolerance judgment result of the measurement value
Public Enum LJV7IF_JudgeResult
    JUDGE_RESULT_HI = &H1       ' HI
    JUDGE_RESULT_GO = &H2       ' GO
    JUDGE_RESULT_LO = &H4       ' LO
End Enum

' Get profile target buffer designation
Public Enum LJV7IF_ProfileBank
    PROFILE_BANK_ACTIVE = &H0   ' Active surface
    PROFILE_BANK_INACTIVE = &H1 ' Inactive surface
End Enum

' Get profile position specification method designation (batch measurement: off)
Public Enum LJV7IF_ProfilePos
    PROFILE_POS_CURRENT = &H0   ' From current
    PROFILE_POS_OLDEST = &H1    ' From oldest
    PROFILE_POS_SPEC = &H2      ' Specify position
End Enum

' Get profile batch data position specification method designation (batch measurement: on)
Public Enum LJV7IF_BatchPos
    BATCH_POS_CURRENT = &H0         ' From current
    BATCH_POS_SPEC = &H2            ' Specify position
    BATCH_POS_COMMITED = &H3        ' From current, after batch commitment
    BATCH_POS_CURRENT_ONLY = &H4    ' Current only
End Enum

' Get / Set settings target type
Public Enum LJV7IFEX_SettingType
    SETTING_TYPE_ENVIRONMENT = &H1  ' Environment
    SETTING_TYPE_COMMON = &H2       ' Common
    SETTING_TYPE_PROGRAM0 = &H10    ' Program
    SETTING_TYPE_PROGRAM1
    SETTING_TYPE_PROGRAM2
    SETTING_TYPE_PROGRAM3
    SETTING_TYPE_PROGRAM4
    SETTING_TYPE_PROGRAM5
    SETTING_TYPE_PROGRAM6
    SETTING_TYPE_PROGRAM7
    SETTING_TYPE_PROGRAM8
    SETTING_TYPE_PROGRAM9
    SETTING_TYPE_PROGRAM10
    SETTING_TYPE_PROGRAM11
    SETTING_TYPE_PROGRAM12
    SETTING_TYPE_PROGRAM13
    SETTING_TYPE_PROGRAM14
    SETTING_TYPE_PROGRAM15
End Enum


'------ Constant values
' Number of OUT settings
Public Const LJV7IF_OUT_COUNT As Long = 16
Public Const LJV7IFEX_MAX_OUT_INDEX As Long = LJV7IF_OUT_COUNT - 1

' Number of simultaneously connectable controllers
Public Const LJV7IF_DEVICE_COUNT As Long = 6

' MAX value for the amount of data in 1 profile
Public Const LJV7IFEX_MAX_PROFILE_COUNT As Long = 3200

' Setting data size in bytes
Public Const LJV7IFEX_SETTING_SIZE_ENVIRONMENT As Long = 60
Public Const LJV7IFEX_SETTING_SIZE_COMMON As Long = 12
Public Const LJV7IFEX_SETTING_SIZE_PROGRAM As Long = 10932

'------ Structures
' IP Address
Public Type LJV7IFEX_IP_ADDRESS
    IPAddress1 As Byte
    IPAddress2 As Byte
    IPAddress3 As Byte
    IPAddress4 As Byte
End Type

' Ethernet settings
Public Type LJV7IF_ETHERNET_CONFIG
    address As LJV7IFEX_IP_ADDRESS    ' IP Address
    wPortNo As Integer                ' (* unsigned 16bit value *)Port Number
    reserved As Integer               ' Padding
End Type

' Date and time
Public Type LJV7IF_TIME
    byYear As Byte      ' Year. Set from 0 to 99, which means 2000 to 2099.
    byMonth As Byte     ' Month. 1 to 12.
    byDay As Byte       ' Day. 1 to 31.
    byHour As Byte      ' Hour. 0 to 23.
    byMinute As Byte    ' Minute. 0 to 59.
    bySecond As Byte    ' Second. 0 to 59.
    reserved1 As Byte   ' Padding
    reserved2 As Byte   ' Padding
End Type

' Setting item designation structure
Public Type LJV7IF_TARGET_SETTING
    byType As Byte         ' Setting type
    byCategory As Byte     ' Category
    byItem As Byte         ' Setting item
    reserve As Byte        ' Padding
    byTarget1 As Byte      ' Setting Target 1
    byTarget2 As Byte      ' Setting Target 2
    byTarget3 As Byte      ' Setting Target 3
    byTarget4 As Byte      ' Setting Target 4
End Type

' Measurement results structure
Public Type LJV7IF_MEASURE_DATA
    byDataInfo As Byte     ' Measurement result information
    byJudge As Byte        ' Tolerance judgment result
    reserved1 As Byte      ' Padding
    reserved2 As Byte      ' Padding
    fValue As Single       ' Measurement value
End Type

' Required buffer size of LJV7IF_MEASURE_DATA in Long() array
Public Const LJV7IFEX_MEASURE_DATA_SIZE = 2

' Measurement result information
Public Type LJV7IF_PROFILE_INFO
    byProfileCnt As Byte    ' The amount of profile data stored
    byEnvelope As Byte      ' Whether profile compression (time axis) is on.
    reserved1 As Byte       ' Padding
    reserved2 As Byte       ' Padding
    wProfDataCnt As Integer ' (* unsigned 16bit value *)Profile data count
    reserved3 As Byte       ' Padding
    reserved4 As Byte       ' Padding
    lXStart As Long         ' 1st point X coordinate.
    lXPitch As Long         ' Profile data X direction interval.
End Type

' Profile header information structure
Public Type LJV7IF_PROFILE_HEADER
    reserved As Long         ' Padding
    dwTriggerCnt As Long     ' (* unsigned 32bit value *)The trigger count when the trigger was issued.
    dwEncoderCnt As Long     ' (* unsigned 32bit value *)The encoder count when the trigger was issued.
    reserved2 As Long        ' Padding
    reserved3 As Long        ' Padding
    reserved4 As Long        ' Padding
End Type

' Required buffer size of LJV7IF_PROFILE_HEADER in Long() array
Public Const LJV7IFEX_PROFILE_HEADER_SIZE = 6

' Profile footer information structure
Public Type LJV7IF_PROFILE_FOOTER
    reserved As Long         ' Padding
End Type

' Required buffer size of LJV7IF_PROFILE_FOOTER in Long() array
Public Const LJV7IFEX_PROFILE_FOOTER_SIZE = 1


' High-speed mode get profile request structure (batch measurement: off)
Public Type LJV7IF_GET_PROFILE_REQ
    byTargetBank As Byte    ' The target surface to read.
    byPosMode As Byte       ' The get profile position specification method.
    reserved1 As Byte       ' Padding
    reserved2 As Byte       ' Padding
    dwGetProfNo As Long     ' (* unsigned 32bit value *)The profile number for the profile to get.
    byGetProfCnt As Byte    ' The number of profiles to read.
    byErase As Byte         ' Erase the profiles that were read from the controller.
    reserved3 As Byte       ' Padding
    reserved4 As Byte       ' Padding
End Type

' High-speed mode get profile request structure (batch measurement: on)
Public Type LJV7IF_GET_BATCH_PROFILE_REQ
    byTargetBank As Byte    ' The target surface to read.
    byPosMode As Byte       ' The get profile position specification method
    reserved1 As Byte       ' Padding
    reserved2 As Byte       ' Padding
    dwGetBatchNo As Long    ' (* unsigned 32bit value *)The batch number for the profile to get.
    dwGetProfNo As Long     ' (* unsigned 32bit value *)The profile number to start getting profiles from in the specified batch number.
    byGetProfCnt As Byte    ' The number of profiles to read.
    byErase As Byte         ' Erase the profiles that were read from the controller.
    reserved3 As Byte       ' Padding
    reserved4 As Byte       ' Padding
End Type

' Advanced mode get profile request structure (batch measurement: on)
Public Type LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ
    byPosMode As Byte     ' The get profile position specification method
    reserved1 As Byte      ' Padding
    reserved2 As Byte      ' Padding
    reserved3 As Byte      ' Padding
    dwGetBatchNo As Long   ' (* unsigned 32bit value *)The batch number for the profiles to get.
    dwGetProfNo As Long    ' (* unsigned 32bit value *)The profile number to start getting profiles from in the specified batch number.
    byGetProfCnt As Byte   ' The number of profiles to read.
    reserved4 As Byte      ' Padding
    reserved5 As Byte      ' Padding
    reserved6 As Byte      ' Padding
End Type

' High-speed mode get profile response structure (batch measurement: off)
Public Type LJV7IF_GET_PROFILE_RSP
    dwCurrentProfNo As Long ' (* unsigned 32bit value *)The profile number at the current point in time.
    dwOldestProfNo As Long  ' (* unsigned 32bit value *)The profile number for the oldest profile held by the controller.
    dwGetTopProfNo As Long  ' (* unsigned 32bit value *)The profile number for the oldest profile out of those that were read this time.
    byGetProfCnt As Byte    ' The number of profiles that were read this time.
    reserved1 As Byte       ' Padding
    reserved2 As Byte       ' Padding
    reserved3 As Byte       ' Padding
End Type

' High-speed mode get profile response structure (batch measurement: on)
Public Type LJV7IF_GET_BATCH_PROFILE_RSP
    dwCurrentBatchNo As Long        ' (* unsigned 32bit value *)The batch number at the current point in time.
    dwCurrentBatchProfCnt As Long   ' (* unsigned 32bit value *)The number of profiles in the newest batch.
    dwOldestBatchNo As Long         ' (* unsigned 32bit value *)The batch number for the oldest batch held by the controller.
    dwOldestBatchProfCnt As Long    ' (* unsigned 32bit value *)The number of profiles in the oldest batch held by the controller.
    dwGetBatchNo As Long            ' (* unsigned 32bit value *)The batch number that was read this time.
    dwGetBatchProfCnt As Long       ' (* unsigned 32bit value *)The number of profiles in the batch that was read this time.
    dwGetBatchTopProfNo As Long     ' (* unsigned 32bit value *)The oldest profile number in the batch out of the profiles that were read this time.
    byGetProfCnt As Byte            ' The number of profiles to read.
    byCurrentBatchCommited As Byte  ' The batch mesurement of current batch number is completed.
    reserved3 As Byte       ' Padding
    reserved4 As Byte       ' Padding
End Type

' Advanced mode get profile response structure (batch measurement: on)
Public Type LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP
    dwGetBatchNo As Long        ' (* unsigned 32bit value *)The batch number that was read this time.
    dwGetBatchProfCnt As Long   ' (* unsigned 32bit value *)The number of profiles in the batch that was read this time.
    dwGetBatchTopProfNo As Long ' (* unsigned 32bit value *)The oldest profile number in the batch out of the profiles that were read this time.
    byGetProfCnt  As Byte       ' The number of profiles that were read this time.
    reserved1 As Byte           ' Padding
    reserved2 As Byte           ' Padding
    reserved3 As Byte           ' Padding
End Type

' Get storage status request structure
Public Type LJV7IF_GET_STRAGE_STATUS_REQ
    dwRdArea As Long            ' (* unsigned 32bit value *)The target surface to read.
End Type

' Get storage status response structure
Public Type LJV7IF_GET_STRAGE_STATUS_RSP
    dwSurfaceCnt As Long        ' (* unsigned 32bit value *)Storage surface count
    dwActiveSurface As Long     ' (* unsigned 32bit value *)The active storage surface.
End Type

' Storage information structure
Public Type LJV7IF_STORAGE_INFO
    byStatus As Byte            ' Storage status
    byProgramNo As Byte         ' The program number for the relevant storage surface.
    byTarget As Byte            ' Storage target
    reserved1 As Byte           ' Padding
    reserved2 As Byte           ' Padding
    reserved3 As Byte           ' Padding
    reserved4 As Byte           ' Padding
    reserved5 As Byte           ' Padding
    dwStorageCnt As Long        ' Storage count
End Type

' Get storage data request structure
Public Type LJV7IF_GET_STORAGE_REQ
    reserved1 As Byte           ' Padding
    reserved2 As Byte           ' Padding
    reserved3 As Byte           ' Padding
    reserved4 As Byte           ' Padding
    dwSurface As Long           ' Storage surface to read.
    dwStartNo As Long           ' The data number to start reading.
    dwDataCnt As Long           ' The number of items to read.
End Type

' Get storage data response structure
Public Type LJV7IF_GET_STORAGE_RSP
    dwStartNo As Long          ' (* unsigned 32bit value *)The storage number to start reading.
    dwDataCnt As Long          ' (* unsigned 32bit value *)The number of items to read.
    stBaseTime As LJV7IF_TIME  ' Base time
End Type

' Get batch profile storage request structure
Public Type LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ
    reserved1 As Byte           ' Padding
    reserved2 As Byte           ' Padding
    reserved3 As Byte           ' Padding
    reserved4 As Byte           ' Padding
    dwSurface As Long           ' (* unsigned 32bit value *)Storage surface to read.
    dwGetBatchNo As Long        ' (* unsigned 32bit value *)Batch number to read.
    dwGetBatchTopProfNo As Long ' (* unsigned 32bit value *)The oldest profile number in the batch to get the data.
    byGetProfCnt As Byte        ' The number of profiles to read.
    reserved5 As Byte           ' Padding
    reserved6 As Byte           ' Padding
    reserved7 As Byte           ' Padding
End Type

' Get batch profile storage response structure
Public Type LJV7IF_GET_BATCH_PROFILE_STORAGE_RSP
    dwGetBatchNo As Long        ' (* unsigned 32bit value *)The batch number that was read this time.
    dwGetBatchProfCnt As Long   ' (* unsigned 32bit value *)The number of profiles in the batch that was read this time.
    dwGetBatchTopProfNo As Long ' (* unsigned 32bit value *)The oldest profile number in the batch out of the profiles that were read this time.
    byGetProfCnt As Byte        ' The number of profiles that were read this time.
    reserved1 As Byte           ' Padding
    reserved2 As Byte           ' Padding
    reserved3 As Byte           ' Padding
    stBaseTime As LJV7IF_TIME   ' Base time
End Type




'------ Dll functions
'-- Operations for the DLL
'Initialize
Public Declare Function LJV7IF_Initialize Lib "LJV7_IF.dll" () As Long
'Finalize
Public Declare Function LJV7IF_Finalize Lib "LJV7_IF.dll" () As Long
'Version
Public Declare Function LJV7IF_GetVersion Lib "LJV7_IF.dll" () As Long

'-- Establish/disconnect the communication path with the controller
'Open Device by USB
Public Declare Function LJV7IF_UsbOpen Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Open Device by Ethernet
Public Declare Function LJV7IF_EthernetOpen Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pEthernetConfig As LJV7IF_ETHERNET_CONFIG) As Long
'Close Connection
Public Declare Function LJV7IF_CommClose Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long

'-- System control
'Reboot the controller
Public Declare Function LJV7IF_RebootController Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Return to factory state
Public Declare Function LJV7IF_RetrunToFactorySetting Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Get system error information
Public Declare Function LJV7IF_GetError Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byRcvMax As Byte, ByRef pbyErrCnt As Byte, ByRef pwErrCode As Integer) As Long
'Clear system error
Public Declare Function LJV7IF_ClearError Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal wErrCode As Integer) As Long

'-- Measurement control
'Trigger
Public Declare Function LJV7IF_Trigger Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Start batch measurements
Public Declare Function LJV7IF_StartMeasure Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Stop batch measurements
Public Declare Function LJV7IF_StopMeasure Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Auto zero
Public Declare Function LJV7IF_AutoZero Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byOnOff As Byte, ByVal dwOut As Long) As Long
'Timing
Public Declare Function LJV7IF_Timing Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byOnOff As Byte, ByVal dwOut As Long) As Long
'Reset
Public Declare Function LJV7IF_Reset Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal dwOut As Long) As Long
'Clear memory
Public Declare Function LJV7IF_ClearMemory Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long

'-- Functions related to modifying or reading settings
'Apply setting
'LJV7IF_SetSetting() cannnot call directry, call wrapped function LJV7IF_SetSettingEx()
'Obtain setting
'LJV7IF_GetSetting() cannnot call directry, call wrapped function LJV7IF_GetSettingEx()

'Initialize setting
Public Declare Function LJV7IF_InitializeSetting Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byDepth As Byte, ByVal byTarget As Byte) As Long
'Reflect setting
Public Declare Function LJV7IF_ReflectSetting Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byDepth As Byte, ByRef pdwError As Long) As Long
'Update write settings area
Public Declare Function LJV7IF_RewriteTemporarySetting Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byDepth As Byte) As Long
'Check the status of saving to the save area
Public Declare Function LJV7IF_CheckMemoryAccess Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pbyBusy As Byte) As Long
'Apply date/time
Public Declare Function LJV7IF_SetTime Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pTime As LJV7IF_TIME) As Long
'Obtain date/time
Public Declare Function LJV7IF_GetTime Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pTime As LJV7IF_TIME) As Long
'Change program
Public Declare Function LJV7IF_ChangeActiveProgram Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByVal byProgNo As Byte) As Long
'Obtain the active program number
Public Declare Function LJV7IF_GetActiveProgram Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pbyProgNo As Byte) As Long

'-- Acquiring measurement results
'Get measurement results
Public Declare Function LJV7IF_GetMeasurementValue Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pMeasureDatapbyProgNo As LJV7IF_MEASURE_DATA) As Long
'Get profiles (operation mode "high-speed (profile only)")
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetProfile Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_PROFILE_REQ, ByRef pRsp As LJV7IF_GET_PROFILE_RSP, ByRef pProfileInfo As LJV7IF_PROFILE_INFO, ByRef pdwProfileData As Long, ByVal dwDataSize As Long) As Long
'Get batch profiles (operation mode "high-speed (profile only)")
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetBatchProfile Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_BATCH_PROFILE_REQ, ByRef pRsp As LJV7IF_GET_BATCH_PROFILE_RSP, ByRef pProfileInfo As LJV7IF_PROFILE_INFO, ByRef pdwBatchData As Long, ByVal dwDataSize As Long) As Long
'Get profiles (operation mode "advanced (with OUT measurement)")
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetProfileAdvance Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pProfileInfo As LJV7IF_PROFILE_INFO, ByRef pdwProfileData As Long, ByVal dwDataSize As Long, ByRef pMeasureData As LJV7IF_MEASURE_DATA) As Long
'Get batch profiles (operation mode "advanced (with OUT measurement)")
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetBatchProfileAdvance Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ, ByRef pRsp As LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP, ByRef pProfileInfo As LJV7IF_PROFILE_INFO, ByRef pdwBatchData As Long, ByVal dwDataSize As Long, ByRef pBatchMeasureData As LJV7IF_MEASURE_DATA, ByRef pMeasureData As LJV7IF_MEASURE_DATA) As Long

'-- Storage function related
'Start storage
Public Declare Function LJV7IF_StartStorage Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Stop storage
Public Declare Function LJV7IF_StopStorage Lib "LJV7_IF.dll" (ByVal lDeviceId As Long) As Long
'Get storage status
Public Declare Function LJV7IF_GetStorageStatus Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_STRAGE_STATUS_REQ, ByRef pRsp As LJV7IF_GET_STRAGE_STATUS_RSP, ByRef pStorageInfo As LJV7IF_STORAGE_INFO) As Long
'Get data storage data
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetStorageData Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_STORAGE_REQ, ByRef pStorageInfo As LJV7IF_STORAGE_INFO, ByRef pRes As LJV7IF_GET_STORAGE_RSP, ByRef pdwData As Long, ByVal dwDataSize As Long) As Long
'Get profile storage data
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetStorageProfile Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_STORAGE_REQ, ByRef pStorageInfo As LJV7IF_STORAGE_INFO, ByRef pRes As LJV7IF_GET_STORAGE_RSP, ByRef pProfileInfo As LJV7IF_PROFILE_INFO, ByRef pdwData As Long, ByVal dwDataSize As Long) As Long
'Get batch profile storage data
'dwDataSize is an unsigned 32bit value
Public Declare Function LJV7IF_GetStorageBatchProfile Lib "LJV7_IF.dll" (ByVal lDeviceId As Long, ByRef pReq As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ, ByRef pStorageInfo As LJV7IF_STORAGE_INFO, ByRef pRes As LJV7IF_GET_BATCH_PROFILE_STORAGE_RSP, ByRef pProfileInfo As LJV7IF_PROFILE_INFO, ByRef pdwData As Long, ByVal dwDataSize As Long, ByRef pTimeOffset As Long, ByRef pMeasureData As LJV7IF_MEASURE_DATA) As Long

'-- High-sppeed communication mode is not supported on Visual Basic 6


'------Wrapper
' Visual Basic 6 is not capable of passing structures by value,
' but the value of the elements of the structure can be placed on the stack in the correct order.

' Wrap target function
Private Declare Function LJV7IF_Wrap_GetSetting Lib "LJV7_IF.dll" Alias "LJV7IF_GetSetting" (ByVal lDeviceId As Long, ByVal byDepth As Byte, ByVal lSettingUpper As Long, ByVal lSettingLower As Long, ByRef pData As Byte, ByVal dwDataSize As Long) As Long
Private Declare Function LJV7IF_Wrap_SetSetting Lib "LJV7_IF.dll" Alias "LJV7IF_SetSetting" (ByVal lDeviceId As Long, ByVal byDepth As Byte, ByVal lSettingUpper As Long, ByVal lSettingLower As Long, ByRef pData As Byte, ByVal dwDataSize As Long, ByRef pdwError As Long) As Long

' Wrapped function
Public Function LJV7IF_GetSettingEx(ByVal lDeviceId As Long, ByVal byDepth As Byte, ByRef targetSetting As LJV7IF_TARGET_SETTING, ByRef pData As Byte, ByVal dwDataSize As Long) As Long
 Dim lUpper As Long
 lUpper = CLng("&H" & Right("0" & Hex$(targetSetting.byItem), 2) & Right("0" & Hex$(targetSetting.byCategory), 2) & Right("0" & Hex$(targetSetting.byType), 2))
 Dim lLower As Long
 lLower = CLng("&H" & Right("0" & Hex$(targetSetting.byTarget4), 2) & Right("0" & Hex$(targetSetting.byTarget3), 2) & Right("0" & Hex$(targetSetting.byTarget2), 2) & Right("0" & Hex$(targetSetting.byTarget1), 2))
 
 LJV7IF_GetSettingEx = LJV7IF_Wrap_GetSetting(lDeviceId, byDepth, lUpper, lLower, pData, dwDataSize)
End Function

Public Function LJV7IF_SetSettingEx(ByVal lDeviceId As Long, ByVal byDepth As Byte, ByRef targetSetting As LJV7IF_TARGET_SETTING, ByRef pData As Byte, ByVal dwDataSize As Long, ByRef pdwError As Long) As Long
 Dim lUpper As Long
 lUpper = CLng("&H" & Right("0" & Hex$(targetSetting.byItem), 2) & Right("0" & Hex$(targetSetting.byCategory), 2) & Right("0" & Hex$(targetSetting.byType), 2))
 Dim lLower As Long
 lLower = CLng("&H" & Right("0" & Hex$(targetSetting.byTarget4), 2) & Right("0" & Hex$(targetSetting.byTarget3), 2) & Right("0" & Hex$(targetSetting.byTarget2), 2) & Right("0" & Hex$(targetSetting.byTarget1), 2))
 
 LJV7IF_SetSettingEx = LJV7IF_Wrap_SetSetting(lDeviceId, byDepth, lUpper, lLower, pData, dwDataSize, pdwError)
End Function


'------ Unsigned value conversion functions
'-----16bit unsigned <-> Integer
Public Function IntegerFromWordValue(value As Long) As Integer
 Dim trimed  As Long
 trimed = value And &HFFFF
 IntegerFromWordValue = CInt("&h" & Hex$(trimed))
End Function

Public Function WordValueFromInteger(value As Integer) As Long
 WordValueFromInteger = CLng("&h" & Hex$(value))
End Function


