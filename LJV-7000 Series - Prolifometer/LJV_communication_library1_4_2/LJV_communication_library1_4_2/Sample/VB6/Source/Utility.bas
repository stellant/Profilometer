Attribute VB_Name = "Utility"
'-----------------------------------------------------------------------------
' <copyright file="Resources.bas" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Utility Class ------

'------ Constant
'Storage structure (storage status)
Public Const STORAGE_INFO_STATUS_EMPTY As Integer = 0
Public Const STORAGE_INFO_STATUS_STORING As Integer = 1
Public Const STORAGE_INFO_STATUS_FINISHED As Integer = 2

'Storage structure (storage target)
Public Const STORAGE_INFO_TARGET_DATA As Integer = 0
Public Const STORAGE_INFO_TARGET_PROFILE As Integer = 2
Public Const STORAGE_INFO_TARGET_BATCH As Integer = 3

Public Declare Sub MoveMemory Lib "kernel32" Alias "RtlMoveMemory" (dst As Any, src As Any, ByVal num As Long)

'---- Acquisition of log
'Get the string for log output.
'"storageInfo" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertStorageInfoToLogString(storageInfo As LJV7IF_STORAGE_INFO) As String
 Dim returnString As String
  
 Dim status As String
 Select Case storageInfo.byStatus
  Case STORAGE_INFO_STATUS_EMPTY
   status = "EMPTY"
  Case STORAGE_INFO_STATUS_STORING
   status = "STORING"
  Case STORAGE_INFO_STATUS_FINISHED
   status = "FINISHED"
  Case Else
   status = "UNEXPECTED"
 End Select
 returnString = returnString & "  Status      :" & status & vbCrLf
 returnString = returnString & "  ProgNo      :" & CStr(storageInfo.byProgramNo) & vbCrLf
  
 Dim target As String
 Select Case storageInfo.byTarget
  Case STORAGE_INFO_TARGET_DATA
   target = "DATA"
  Case STORAGE_INFO_TARGET_PROFILE
   target = "PROFILE"
  Case STORAGE_INFO_TARGET_BATCH
   target = "BATCH PROFILE"
  Case Else
   target = "UNEXPECTED"
 End Select
 returnString = returnString & "  Target      :" & target & vbCrLf
 returnString = returnString & "  StorageCnt  :" & CStr(storageInfo.dwStorageCnt)

 ConvertStorageInfoToLogString = returnString
End Function

'Get the string for log output.
'"storageRsp" is structure that you want to convert to a string
'Retunr string for log output
Public Function ConvertStorageRspToLogString(storageRsp As LJV7IF_GET_STORAGE_RSP) As String
 Dim returnString As String
 
 returnString = returnString & "  StartNo :" & CStr(storageRsp.dwStartNo) & vbCrLf
 returnString = returnString & "  DataCnt :" & storageRsp.dwDataCnt & vbCrLf
 returnString = returnString & ConvertTimeToLogString(storageRsp.stBaseTime)

 ConvertStorageRspToLogString = returnString
End Function
            
'Get the string for log output.
'"measureData" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertMeasureDataToLogString(measureData As LJV7IF_MEASURE_DATA) As String
 Dim returnString As String
 
 Dim dataInfo As String
 dataInfo = ""
 Select Case measureData.byDataInfo
 Case MEASURE_DATA_INFO_VALID
  dataInfo = "Valid        "
 Case MEASURE_DATA_INFO_ALARM
  dataInfo = "Alarm value  "
 Case MEASURE_DATA_INFO_WAIT
  dataInfo = "Judgment wait value  "
 Case Else
  dataInfo = "Unexpected value   "
 End Select
 returnString = returnString & dataInfo

 Dim judge As String
 judge = ""
 Select Case measureData.byJudge
  Case 0
   judge = "______  "
  Case JUDGE_RESULT_HI
   judge = "HI____  "
  Case JUDGE_RESULT_GO
   judge = "__GO__  "
  Case JUDGE_RESULT_LO
   judge = "____LO  "
  Case JUDGE_RESULT_HI Or JUDGE_RESULT_LO
   judge = "HI__LO  "
  Case JUDGE_RESULT_HI Or JUDGE_RESULT_GO Or JUDGE_RESULT_LO
   judge = "ALL BIT  "
  Case Else
   judge = "UNEXPECTED "
 End Select
 returnString = returnString & judge
 returnString = returnString & CStr(measureData.fValue)

 ConvertMeasureDataToLogString = returnString
End Function

'Get the string for log output.
'"profileInfo" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertProfileInfoToLogString(profileInfo As LJV7IF_PROFILE_INFO) As String
 Dim returnString As String
 ' Profile information of the profile obtained
 returnString = returnString & "  Profile Data Num                :" & profileInfo.byProfileCnt & vbCrLf
 Dim envelope As String
 If profileInfo.byEnvelope = 0 Then
  envelope = "OFF"
 Else
  envelope = "ON"
 End If
 returnString = returnString & "  Envelope                        :" & envelope & vbCrLf
 returnString = returnString & "  Profile Data Points             :" & profileInfo.wProfDataCnt & vbCrLf
 returnString = returnString & "  X coordinate of the first point :" & profileInfo.lXStart & vbCrLf
 returnString = returnString & "  X-direction interval            :" & profileInfo.lXPitch

 ConvertProfileInfoToLogString = returnString
End Function

'Get the string for log output.
'"rsp" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertBatchProfileStorageRspToLogString(rsp As LJV7IF_GET_BATCH_PROFILE_STORAGE_RSP) As String
 Dim returnString As String
 
 'Profile information of the profile obtained
 returnString = returnString & "  BatchNo         :" & rsp.dwGetBatchNo & vbCrLf
 returnString = returnString & "  BatchProfCnt    :" & rsp.dwGetBatchProfCnt & vbCrLf
 returnString = returnString & "  BatchTopProfNo  :" & rsp.dwGetBatchTopProfNo & vbCrLf
 returnString = returnString & "  ProfCnt         :" & rsp.byGetProfCnt & vbCrLf
 returnString = returnString & ConvertTimeToLogString(rsp.stBaseTime)
 
 ConvertBatchProfileStorageRspToLogString = returnString
End Function

'Get the string for log output.
'"rsp" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertBatchProfileRspToLogString(rsp As LJV7IF_GET_BATCH_PROFILE_RSP) As String
 Dim returnString As String

 'Profile information of the profile obtained
            returnString = returnString & "  CurrentBatchNo:" & rsp.dwCurrentBatchNo & vbCrLf
            returnString = returnString & "  CurrentBatchProfCnt   :" & rsp.dwCurrentBatchProfCnt & vbCrLf
            returnString = returnString & "  OldestBatchNo:" & rsp.dwOldestBatchNo & vbCrLf
            returnString = returnString & "  OldestBatchProfCnt:" & rsp.dwOldestBatchProfCnt & vbCrLf
            returnString = returnString & "  GetBatchNo:" & rsp.dwGetBatchNo & vbCrLf
            returnString = returnString & "  GetBatchProfCnt:" & rsp.dwGetBatchProfCnt & vbCrLf
            returnString = returnString & "  GetBatchTopProfNo:" & rsp.dwGetBatchTopProfNo & vbCrLf
            returnString = returnString & "  GetProfCnt:" & rsp.byGetProfCnt & vbCrLf
            returnString = returnString & "  CurrentBatchCommited:" & rsp.byCurrentBatchCommited

 ConvertBatchProfileRspToLogString = returnString
End Function

'Get the string for log output.
'"rsp" is structure that you want to convert to a string
'Retunr string for log output
Public Function ConvertBatchProfileAdvanceRspToLogString(rsp As LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP) As String
 Dim returnString As String
 'Profile information of the profile obtained
 returnString = returnString & "  GetBatchNo         :" & rsp.dwGetBatchNo & vbCrLf
 returnString = returnString & "  GetBatchProfCnt    :" & rsp.dwGetBatchProfCnt & vbCrLf
 returnString = returnString & "  GetBatchTopProfNo  :" & rsp.dwGetBatchTopProfNo & vbCrLf
 returnString = returnString & "  GetProfCnt         :" & rsp.byGetProfCnt

 ConvertBatchProfileAdvanceRspToLogString = returnString
End Function

'Get the string for log output.
'"Time" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertTimeToLogString(time As LJV7IF_TIME) As String
 Dim returnString As String
 returnString = "yy/mm/dd hh:mm:ss   " & Format(time.byYear, "00") & "/" & Format(time.byMonth, "00") & "/" & Format(time.byDay, "00") & "  " & Format(time.byHour, "00") & ":" & Format(time.byMinute, "00") & ":" & Format(time.bySecond, "00")

 ConvertTimeToLogString = returnString
End Function

'Get the string for log output.
'"rsp" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertProfileRspToLogString(rsp As LJV7IF_GET_PROFILE_RSP) As String
 Dim returnString As String

 returnString = returnString & "  CurrentProfNo     :" & rsp.dwCurrentProfNo & vbCrLf
 returnString = returnString & "  OldestProfNo      :" & rsp.dwOldestProfNo & vbCrLf
 returnString = returnString & "  GetTopProfNo      :" & rsp.dwGetTopProfNo & vbCrLf
 returnString = returnString & "  GetProfCnt        :" & rsp.byGetProfCnt

 ConvertProfileRspToLogString = returnString
End Function

'Get the string for log output.
'"rsp" is structure that you want to convert to a string
'Return string for log output
Public Function ConvertStorageStatusToLogString(rsp As LJV7IF_GET_STRAGE_STATUS_RSP) As String
 Dim returnString As String
 
 returnString = returnString & "  SurfaceCnt       :" & CStr(rsp.dwSurfaceCnt) & vbCrLf
 returnString = returnString & "  ActiveSurface    :" & CStr(rsp.dwActiveSurface) & vbCrLf
 
 ConvertStorageStatusToLogString = returnString
End Function



