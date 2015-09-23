'----------------------------------------------------------------------------- 
' <copyright file="Utility.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Diagnostics

''' <summary>
''' Utility class
''' </summary>
NotInheritable Class Utility
	Private Sub New()
	End Sub
	#Region "Enum"
	''' <summary>
	''' Structure classification
	''' </summary>
	Public Enum TypeOfStruct
		PROFILE_HEADER
		PROFILE_FOOTER
		MEASURE_DATA
	End Enum
	#End Region

	#Region "Constant"
	''' <summary>
	''' Storage structure (storage status)
	''' </summary>
	Private Const STORAGE_INFO_STATUS_EMPTY As Integer = 0
	Private Const STORAGE_INFO_STATUS_STORING As Integer = 1
	Private Const STORAGE_INFO_STATUS_FINISHED As Integer = 2

	''' <summary>
	''' Storage structure (storage target)
	''' </summary>
	Private Const STORAGE_INFO_TARGET_DATA As Integer = 0
	Private Const STORAGE_INFO_TARGET_PROFILE As Integer = 2
	Private Const STORAGE_INFO_TARGET_BATCH As Integer = 3
	#End Region

	#Region "Method"

	#Region "Get the byte size"

	''' <summary>
	''' Get the byte size of the structure.
	''' </summary>
	''' <param name="profileHeader">Structure whose byte size you want to get.</param>
	''' <returns>Byte size</returns>
	Public Shared Function GetByteSize(type As TypeOfStruct) As Integer
		Select Case type
			Case TypeOfStruct.PROFILE_HEADER
				Dim profileHeader As New LJV7IF_PROFILE_HEADER()
				Return Marshal.SizeOf(profileHeader)

			Case TypeOfStruct.PROFILE_FOOTER
				Dim profileFooter As New LJV7IF_PROFILE_FOOTER()
				Return Marshal.SizeOf(profileFooter)

			Case TypeOfStruct.MEASURE_DATA
				Dim measureData As New LJV7IF_MEASURE_DATA()
				Return Marshal.SizeOf(measureData)
		End Select

		Return 0
	End Function
	#End Region

	#Region "Acquisition of log"

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(storageInfo As LJV7IF_STORAGE_INFO) As StringBuilder
		Dim sb As New StringBuilder()

		Dim status As String = String.Empty
		Select Case storageInfo.byStatus
			Case STORAGE_INFO_STATUS_EMPTY
				status = "EMPTY"
				Exit Select
			Case STORAGE_INFO_STATUS_STORING
				status = "STORING"
				Exit Select
			Case STORAGE_INFO_STATUS_FINISHED
				status = "FINISHED"
				Exit Select
			Case Else
				status = "UNEXPECTED"
				Exit Select
		End Select
		sb.AppendLine(String.Format("  Status" & vbTab & vbTab & ": {0}", status))
		sb.AppendLine(String.Format("  ProgNo" & vbTab & vbTab & ": {0}", storageInfo.byProgramNo))
		Dim target As String = String.Empty
		

		Select Case storageInfo.byTarget
			Case STORAGE_INFO_TARGET_DATA
				target = "DATA"
				Exit Select
			Case STORAGE_INFO_TARGET_PROFILE
				target = "PROFILE"
				Exit Select
			Case STORAGE_INFO_TARGET_BATCH
				target = "BATCH PROFILE"
				Exit Select
			Case Else
				target = "UNEXPECTED"
				Exit Select
		End Select
		sb.AppendLine(String.Format("  Target" & vbTab & vbTab & ": {0}", target))
		sb.Append(String.Format("  StorageCnt" & vbTab & ": {0}", storageInfo.dwStorageCnt))

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(storageRsp As LJV7IF_GET_STORAGE_RSP) As StringBuilder
		Dim sb As New StringBuilder()

		sb.AppendLine(String.Format("  StartNo" & vbTab & ": {0}", storageRsp.dwStartNo))
		sb.AppendLine(String.Format("  DataCnt" & vbTab & ": {0}", storageRsp.dwDataCnt))
		sb.Append(ConvertToLogString(storageRsp.stBaseTime).ToString())

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(measureData As LJV7IF_MEASURE_DATA) As StringBuilder
		Dim sb As New StringBuilder()

		Dim dataInfo As String = String.Empty
		Select Case measureData.byDataInfo
			Case CInt(LJV7IF_MEASURE_DATA_INFO.LJV7IF_MEASURE_DATA_INFO_VALID)
				dataInfo = "Valid" & vbTab & vbTab
				Exit Select
			Case CInt(LJV7IF_MEASURE_DATA_INFO.LJV7IF_MEASURE_DATA_INFO_ALARM)
				dataInfo = "Alarm value  "
				Exit Select
			Case CInt(LJV7IF_MEASURE_DATA_INFO.LJV7IF_MEASURE_DATA_INFO_WAIT)
				dataInfo = "Judgment wait value  "
				Exit Select
			Case Else
				dataInfo = "Unexpected value" & vbTab
				Exit Select
		End Select
		sb.Append(dataInfo)
		Dim judge As String = String.Empty
		Select Case measureData.byJudge
			Case 0
				judge = "______  "
				Exit Select
			Case CInt(LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_HI)
				judge = "HI____  "
				Exit Select
			Case CInt(LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_GO)
				judge = "__GO__  "
				Exit Select
			Case CInt(LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_LO)
				judge = "____LO  "
				Exit Select
			Case CInt(LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_HI Or LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_LO)
				judge = "HI__LO  "
				Exit Select
			Case CInt(LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_HI Or LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_GO Or LJV7IF_JUDGE_RESULT.LJV7IF_JUDGE_RESULT_LO)
				judge = "ALL BIT  "
				Exit Select
			Case Else
				judge = "UNEXPECTED "
				Exit Select
		End Select
		sb.Append(judge)
		sb.Append(measureData.fValue.ToString())

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(profileInfo As LJV7IF_PROFILE_INFO) As StringBuilder
		Dim sb As New StringBuilder()

		' Profile information of the profile obtained
		sb.AppendLine(String.Format("  Profile Data Num" & vbTab & vbTab & vbTab & ": {0}", profileInfo.byProfileCnt))
		Dim envelope As String = If(profileInfo.byEnvelope = 0, "OFF", "ON")
		sb.AppendLine(String.Format("  Envelope" & vbTab & vbTab & vbTab & ": {0}", envelope))
		sb.AppendLine(String.Format("  Profile Data Points" & vbTab & vbTab & vbTab & ": {0}", profileInfo.wProfDataCnt))
		sb.AppendLine(String.Format("  X coordinate of the first point" & vbTab & ": {0}", profileInfo.lXStart))
		sb.Append(String.Format("  X-direction interval" & vbTab & vbTab & ": {0}", profileInfo.lXPitch))

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(rsp As LJV7IF_GET_BATCH_PROFILE_STORAGE_RSP) As StringBuilder
		Dim sb As New StringBuilder()

		' Profile information of the profile obtained
		sb.AppendLine(String.Format("  BatchNo" & vbTab & vbTab & " : {0}", rsp.dwGetBatchNo))
		sb.AppendLine(String.Format("  BatchProfCnt" & vbTab & " : {0}", rsp.dwGetBatchProfCnt))
		sb.AppendLine(String.Format("  BatchTopProfNo" & vbTab & " : {0}", rsp.dwGetBatchTopProfNo))
		sb.AppendLine(String.Format("  ProfCnt" & vbTab & vbTab & " : {0}", rsp.byGetProfCnt))
		sb.Append(ConvertToLogString(rsp.stBaseTime).ToString())

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(rsp As LJV7IF_GET_BATCH_PROFILE_RSP) As StringBuilder
		Dim sb As New StringBuilder()

		' Profile information of the profile obtained
		sb.AppendLine(String.Format("  CurrentBatchNo" & vbTab & vbTab & vbTab & ": {0}", rsp.dwCurrentBatchNo))
		sb.AppendLine(String.Format("  CurrentBatchProfCnt" & vbTab & vbTab & ": {0}", rsp.dwCurrentBatchProfCnt))
		sb.AppendLine(String.Format("  OldestBatchNo" & vbTab & vbTab & vbTab & ": {0}", rsp.dwOldestBatchNo))
		sb.AppendLine(String.Format("  OldestBatchProfCnt" & vbTab & vbTab & ": {0}", rsp.dwOldestBatchProfCnt))
		sb.AppendLine(String.Format("  GetBatchNo" & vbTab & vbTab & vbTab & ": {0}", rsp.dwGetBatchNo))
		sb.AppendLine(String.Format("  GetBatchProfCnt" & vbTab & vbTab & vbTab & ": {0}", rsp.dwGetBatchProfCnt))
		sb.AppendLine(String.Format("  GetBatchTopProfNo" & vbTab & vbTab & ": {0}", rsp.dwGetBatchTopProfNo))
		sb.AppendLine(String.Format("  GetProfCnt" & vbTab & vbTab & vbTab & ": {0}", rsp.byGetProfCnt))
		sb.Append(String.Format("  CurrentBatchCommited" & vbTab & vbTab & ": {0}", rsp.byCurrentBatchCommited))

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(rsp As LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP) As StringBuilder
		Dim sb As New StringBuilder()

		' Profile information of the profile obtained
		sb.AppendLine(String.Format("  GetBatchNo" & vbTab & vbTab & ": {0}", rsp.dwGetBatchNo))
		sb.AppendLine(String.Format("  GetBatchProfCnt" & vbTab & vbTab & ": {0}", rsp.dwGetBatchProfCnt))
		sb.AppendLine(String.Format("  GetBatchTopProfNo" & vbTab & ": {0}", rsp.dwGetBatchTopProfNo))
		sb.Append(String.Format("  GetProfCnt" & vbTab & vbTab & ": {0}", rsp.byGetProfCnt))

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(time As LJV7IF_TIME) As StringBuilder
		Dim sb As New StringBuilder()

		sb.Append(String.Format("yy/mm/dd hh:mm:ss " & vbLf & " {0,0:d2}/{1,0:d2}/{2,0:d2} {3,0:d2}:{4,0:d2}:{5,0:d2}", time.byYear, time.byMonth, time.byDay, time.byHour, time.byMinute, _
			time.bySecond))

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(rsp As LJV7IF_GET_PROFILE_RSP) As StringBuilder
		Dim sb As New StringBuilder()

		sb.AppendLine(String.Format("  CurrentProfNo" & vbTab & ": {0}", rsp.dwCurrentProfNo))
		sb.AppendLine(String.Format("  OldestProfNo" & vbTab & ": {0}", rsp.dwOldestProfNo))
		sb.AppendLine(String.Format("  GetTopProfNo" & vbTab & ": {0}", rsp.dwGetTopProfNo))
		sb.Append(String.Format("  GetProfCnt" & vbTab & ": {0}", rsp.byGetProfCnt))

		Return sb
	End Function

	''' <summary>
	''' Get the string for log output.
	''' </summary>
	''' <param name="obj">Structure that you want to convert to a string</param>
	''' <returns>String for log output</returns>
	Public Shared Function ConvertToLogString(rsp As LJV7IF_GET_STRAGE_STATUS_RSP) As StringBuilder
		Dim sb As New StringBuilder()

		sb.AppendLine(String.Format("  SurfaceCnt" & vbTab & ": {0}", rsp.dwSurfaceCnt))
		sb.AppendLine(String.Format("  ActiveSurface" & vbTab & ": {0}", rsp.dwActiveSurface))

		Return sb
	End Function
	#End Region

	#End Region
End Class
