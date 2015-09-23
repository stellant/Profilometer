'----------------------------------------------------------------------------- 
' <copyright file="MainFors.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports LJV7_DllSampleAll.Datas
Imports LJV7_DllSampleAll.Forms
Imports LJV7_DllSampleAll.Properties

Public Partial Class MainForm
	Inherits Form
	#Region "Enum"

	''' <summary>
	''' Send command definition
	''' </summary>
	''' <remark>Defined for separate return code distinction</remark>
	Public Enum SendCommand
		''' <summary>None</summary>
		None
		''' <summary>Restart</summary>
		RebootController
		''' <summary>Trigger</summary>
		Trigger
		''' <summary>Start measurement</summary>
		StartMeasure
		''' <summary>Stop measurement</summary>
		StopMeasure
		''' <summary>Auto zero</summary>
		AutoZero
		''' <summary>Timing</summary>
		Timing
		''' <summary>Reset</summary>
		Reset
		''' <summary>Program switch</summary>
		ChangeActiveProgram
		''' <summary>Get measurement results</summary>
		GetMeasurementValue

		''' <summary>Get profiles</summary>
		GetProfile
		''' <summary>Get batch profiles (operation mode "high-speed (profile only)")</summary>
		GetBatchProfile
		''' <summary>Get profiles (operation mode "advanced (with OUT measurement)")</summary>
		GetProfileAdvance
		''' <summary>Get batch profiles (operation mode "advanced (with OUT measurement)").</summary>
		GetBatchProfileAdvance

		''' <summary>Start storage</summary>
		StartStorage
		''' <summary>Stop storage</summary>
		StopStorage
		''' <summary>Get storage status</summary>
		GetStorageStatus
		''' <summary>Manual storage request</summary>
		RequestStorage
		''' <summary>Get storage data</summary>
		GetStorageData
		''' <summary>Get profile storage data</summary>
		GetStorageProfile
		''' <summary>Get batch profile storage data.</summary>
		GetStorageBatchProfile

		''' <summary>Initialize USB high-speed data communication</summary>
		HighSpeedDataUsbCommunicationInitalize
		''' <summary>Initialize Ethernet high-speed data communication</summary>
		HighSpeedDataEthernetCommunicationInitalize
		''' <summary>Request preparation before starting high-speed data communication</summary>
		PreStartHighSpeedDataCommunication
		''' <summary>Start high-speed data communication</summary>
		StartHighSpeedDataCommunication
	End Enum

	#End Region

	#Region "Field"

	''' <summary>Ethernet settings structure </summary>
	Private _ethernetConfig As LJV7IF_ETHERNET_CONFIG
	''' <summary>Measurement data list</summary>
	Private _measureDatas As List(Of MeasureData)
	''' <summary>Current device ID</summary>
	Private _currentDeviceId As Integer
	''' <summary>Send command</summary>
	Private _sendCommand As SendCommand
	''' <summary>Callback function used during high-speed communication</summary>
	Private _callback As HighSpeedDataCallBack
	''' <summary>Callback function used during high-speed communication (count only)</summary>
	Private _callbackOnlyCount As HighSpeedDataCallBack

	''' The following are maintained in arrays to support multiple controllers.
	''' <summary>Array of profile information structures</summary>
	Private _profileInfo As LJV7IF_PROFILE_INFO()
	''' <summary>Array of controller information</summary>
	Private _deviceData As DeviceData()
	''' <summary>Array of labels that indicate the controller status</summary>
	Private _deviceStatusLabels As Label()
	''' <summary>Array of labels that indicate the number of received profiles </summary>
	Private _receivedProfileCountLabels As Label()

	#End Region

	#Region "Event handler(for single-function)"

	#Region "Button for operating the DLL"
	''' <summary>
	''' "Initialize" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnInitialize_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_Initialize()
		AddLogResult(rc, Resources.SID_INITIALIZE)

		For i As Integer = 0 To _deviceData.Length - 1
			_deviceData(i).Status = DeviceStatus.NoConnection
			_deviceStatusLabels(i).Text = _deviceData(i).GetStatusString()
		Next
	End Sub

	''' <summary>
	''' "GetVersion" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetVersion_Click(sender As Object, e As EventArgs)
		AddLogResult(CInt(Rc.Ok), Resources.SID_GET_VERSION)
		AddLog(NativeMethods.LJV7IF_GetVersion().ToString("x"))
	End Sub

	''' <summary>
	''' "Finalize" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnFinalize_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_Finalize()
		AddLogResult(rc, Resources.SID_FINALIZE)
		For i As Integer = 0 To _deviceData.Length - 1
			_deviceData(i).Status = DeviceStatus.NoConnection
			_deviceStatusLabels(i).Text = _deviceData(i).GetStatusString()
		Next
	End Sub
	#End Region

	#Region "Button for establishing and disconnecting the communication path with the controller"
	''' <summary>
	''' "UsbOpen" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnUsbOpen_Click(sender As Object, e As EventArgs)
		Dim rc__1 As Integer = NativeMethods.LJV7IF_UsbOpen(_currentDeviceId)
		' @Point
        ' # Enter the "_currentDeviceId" set here for the communication settings into the arguments of each DLL function.
        ' # If you want to get data from multiple controllers, prepare and set multiple "_currentDeviceId" values,
		'   enter these values into the arguments of the DLL functions, and then use the functions.

		AddLogResult(rc__1, Resources.SID_USB_OPEN)

		_deviceData(_currentDeviceId).Status = If((rc__1 = CInt(Rc.Ok)), DeviceStatus.Usb, DeviceStatus.NoConnection)
		_deviceStatusLabels(_currentDeviceId).Text = _deviceData(_currentDeviceId).GetStatusString()
	End Sub

	''' <summary>
	''' "EthernetOpen" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnEthernetOpen_Click(sender As Object, e As EventArgs)
		Using openEthernetForm As New OpenEthernetForm()
			If DialogResult.OK = openEthernetForm.ShowDialog() Then
				Dim ethernetConfig As LJV7IF_ETHERNET_CONFIG = openEthernetForm.EthernetConfig
				' @Point
                ' # Enter the "_currentDeviceId" set here for the communication settings into the arguments of each DLL function.
                ' # If you want to get data from multiple controllers, prepare and set multiple "_currentDeviceId" values,
				'   enter these values into the arguments of the DLL functions, and then use the functions.

				Dim rc__1 As Integer = NativeMethods.LJV7IF_EthernetOpen(_currentDeviceId, ethernetConfig)
				AddLogResult(rc__1, Resources.SID_ETHERNET_OPEN)

				If rc__1 = CInt(Rc.Ok) Then
					_deviceData(_currentDeviceId).Status = DeviceStatus.Ethernet
					_deviceData(_currentDeviceId).EthernetConfig = ethernetConfig
				Else
					_deviceData(_currentDeviceId).Status = DeviceStatus.NoConnection
				End If
				_deviceStatusLabels(_currentDeviceId).Text = _deviceData(_currentDeviceId).GetStatusString()
			End If
		End Using
	End Sub

	''' <summary>
	''' "CommClose" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnCommClose_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_CommClose(_currentDeviceId)
		AddLogResult(rc, Resources.SID_COMM_CLOSE)

		_deviceData(_currentDeviceId).Status = DeviceStatus.NoConnection
		_deviceStatusLabels(_currentDeviceId).Text = _deviceData(_currentDeviceId).GetStatusString()
	End Sub
	#End Region

	#Region "Buttons for controlling the system"
	''' <summary>
	''' "RebootController" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnRebootController_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.RebootController

		Dim rc As Integer = NativeMethods.LJV7IF_RebootController(_currentDeviceId)
		AddLogResult(rc, Resources.SID_REBOOT_CONTROLLER)
	End Sub

	''' <summary>
	''' "RetrunToFactorySetting" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnRetrunToFactorySetting_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_RetrunToFactorySetting(_currentDeviceId)
		AddLogResult(rc, Resources.SID_RETRUN_TO_FACTORY_SETTING)
	End Sub

	''' <summary>
	''' "GetError" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetError_Click(sender As Object, e As EventArgs)
		Using getErrorForm As New GetErrorForm()
			If DialogResult.OK = getErrorForm.ShowDialog() Then
				Dim errCnt As Byte = 0
				Dim errCode As UShort() = New UShort(Math.Max(CInt(getErrorForm.RcvMax), 1) - 1) {}
				Using pin As New PinnedObject(errCode)
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetError(_currentDeviceId, getErrorForm.RcvMax, errCnt, pin.Pointer)
					AddLogResult(rc__1, Resources.SID_GET_ERROR)
					If rc__1 = CInt(Rc.Ok) Then
						AddLog(String.Format("ErrCnt:{0}", errCnt.ToString("x")))
						For i As Integer = 0 To errCnt - 1
							AddLog(String.Format("ErrCode[{0}]:0x{1:0000}", i, errCode(i).ToString("x4")))
						Next
					End If
				End Using
			End If
		End Using
	End Sub

	''' <summary>
	''' "ClearError" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnClearError_Click(sender As Object, e As EventArgs)
		Using clearErrorForm As New ClearErrorForm()
			If DialogResult.OK = clearErrorForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_ClearError(_currentDeviceId, clearErrorForm.ErrCode)
				AddLogResult(rc, Resources.SID_CLEAR_ERROR)
			End If
		End Using
	End Sub
	#End Region

	#Region "Buttons for controlling measurements"
	''' <summary>
	''' "Trigger" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnTrigger_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.Trigger

		Dim rc As Integer = NativeMethods.LJV7IF_Trigger(_currentDeviceId)
		AddLogResult(rc, Resources.SID_TRIGGER)
	End Sub

	''' <summary>
	''' "StartMeasure" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnStartMeasure_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.StartMeasure

		Dim rc As Integer = NativeMethods.LJV7IF_StartMeasure(_currentDeviceId)
		AddLogResult(rc, Resources.SID_START_MEASURE)
	End Sub

	''' <summary>
	''' "StopMeasure" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnStopMeasure_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.StopMeasure

		Dim rc As Integer = NativeMethods.LJV7IF_StopMeasure(_currentDeviceId)
		AddLogResult(rc, Resources.SID_STOP_MEASURE)
	End Sub

	''' <summary>
	''' "AutoZero" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnAutoZero_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.AutoZero

		Using autoZeroForm As New OutSelectForm(True)
			If DialogResult.OK = autoZeroForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_AutoZero(_currentDeviceId, autoZeroForm.OnOff, autoZeroForm.Out)
				AddLogResult(rc, Resources.SID_AUTO_ZERO)
			End If
		End Using
	End Sub

	''' <summary>
	''' "Timing" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnTiming_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.Timing

		Using autoZeroForm As New OutSelectForm(True)
			If DialogResult.OK = autoZeroForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_Timing(_currentDeviceId, autoZeroForm.OnOff, autoZeroForm.Out)
				AddLogResult(rc, Resources.SID_TIMING)
			End If
		End Using
	End Sub

	''' <summary>
	''' "Reset" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnReset_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.Reset

		Using resetForm As New OutSelectForm(False)
			If DialogResult.OK = resetForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_Reset(_currentDeviceId, resetForm.Out)
				AddLogResult(rc, Resources.SID_RESET)
			End If
		End Using
	End Sub

	''' <summary>
	''' "ClearMemory" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnClearMemory_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_ClearMemory(_currentDeviceId)
		AddLogResult(rc, Resources.SID_CLEAR_MEMORY)
	End Sub
	#End Region

	#Region "Buttons for modifying or reading settings"
	''' <summary>
	''' "SetSetting" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnSetSetting_Click(sender As Object, e As EventArgs)
		Using settingForm As New SettingForm(True)
			If DialogResult.OK = settingForm.ShowDialog() Then
				Dim targetSetting As LJV7IF_TARGET_SETTING = settingForm.TargetSetting
				Using pin As New PinnedObject(settingForm.Data)
					Dim dwError As UInteger = 0
					Dim rc__1 As Integer = NativeMethods.LJV7IF_SetSetting(_currentDeviceId, settingForm.Depth, targetSetting, pin.Pointer, CUInt(settingForm.Data.Length), dwError)
					' @Point
                    ' # There are three setting areas: a) the write settings area, b) the running area, and c) the save area.
					'   * Specify a) for the setting level when you want to change multiple settings. However, to reflect settings in the LJ-V operations, you have to call LJV7IF_ReflectSetting.
					'	 * Specify b) for the setting level when you want to change one setting but you don't mind if this setting is returned to its value prior to the change when the power is turned off.
					'	 * Specify c) for the setting level when you want to change one setting and you want this new value to be retained even when the power is turned off.

					' @Point
					'  As a usage example, we will show how to use SettingForm to configure settings such that sending a setting, with SettingForm using its initial values,
					'  will change the sampling period in the running area to "100 Hz."
					'  Also see the GetSetting function.

					AddLogResult(rc__1, Resources.SID_SET_SETTING)
					If rc__1 <> CInt(Rc.Ok) Then
						AddError(dwError)
					End If
				End Using
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetSetting" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	Private Sub btnGetSetting_Click(sender As Object, e As EventArgs)
		Using settingForm As New SettingForm(False)
			If DialogResult.OK = settingForm.ShowDialog() Then
				Dim targetSetting As LJV7IF_TARGET_SETTING = settingForm.TargetSetting
				Dim data As Byte() = New Byte(settingForm.DataLength - 1) {}
				Using pin As New PinnedObject(data)
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetSetting(_currentDeviceId, settingForm.Depth, targetSetting, pin.Pointer, CUInt(settingForm.DataLength))
					' @Point
					'  We have prepared an object for reading the sampling period into the setting's initial value.
					'  Also see the SetSetting function.

					AddLogResult(rc__1, Resources.SID_GET_SETTING)
					If rc__1 = CInt(Rc.Ok) Then
						AddLog(vbTab & "    0  1  2  3  4  5  6  7")
						Dim sb As New StringBuilder()
						' Get data display
						For i As Integer = 0 To settingForm.DataLength - 1
							If (i Mod 8) = 0 Then
								sb.Append(String.Format("  [0x{0:x4}] ", i))
							End If

							sb.Append(String.Format("{0:x2} ", data(i)))
							If ((i Mod 8) = 7) OrElse (i = settingForm.DataLength - 1) Then
								AddLog(sb.ToString())
								sb.Remove(0, sb.Length)
							End If
						Next
					End If
				End Using
			End If
		End Using
	End Sub

	''' <summary>
	''' "InitializeSetting" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnInitializeSetting_Click(sender As Object, e As EventArgs)
		Using depthProgramSelectForm As New DepthProgramSelectForm(True, True)
			If DialogResult.OK = depthProgramSelectForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_InitializeSetting(_currentDeviceId, depthProgramSelectForm.Depth, depthProgramSelectForm.Target)
				AddLogResult(rc, Resources.SID_INITIALIZE_SETTING)
			End If
		End Using
	End Sub

	''' <summary>
	''' "ReflectSetting" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnUpdataSetting_Click(sender As Object, e As EventArgs)
		Using depthProgramSelectForm As New DepthProgramSelectForm(True, False)
			If DialogResult.OK = depthProgramSelectForm.ShowDialog() Then
				Dim dwError As UInteger = 0
				Dim rc__1 As Integer = NativeMethods.LJV7IF_ReflectSetting(_currentDeviceId, depthProgramSelectForm.Depth, dwError)

				AddLogResult(rc__1, Resources.SID_UPDATA_SETTING)
				If rc__1 <> CInt(Rc.Ok) Then
					AddError(dwError)
				End If
			End If
		End Using
	End Sub

	''' <summary>
	''' "RewriteTemporarySetting" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnRewriteTemporarySetting_Click(sender As Object, e As EventArgs)
		Using depthProgramSelectForm As New DepthProgramSelectForm(True, False)
			If DialogResult.OK = depthProgramSelectForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_RewriteTemporarySetting(_currentDeviceId, depthProgramSelectForm.Depth)
				AddLogResult(rc, Resources.SID_REWRITE_TEMPORARY_SETTING)
			End If
		End Using
	End Sub

	''' <summary>
	''' "CheckMemoryAccess" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnCheckMemoryAccess_Click(sender As Object, e As EventArgs)
		Dim busy As Byte = 0
		Dim rc__1 As Integer = NativeMethods.LJV7IF_CheckMemoryAccess(_currentDeviceId, busy)
		AddLogResult(rc__1, Resources.SID_CHECK_MEMORY_ACCESS)
		If rc__1 = CInt(Rc.Ok) Then
			If busy <> 0 Then
				AddLog("Accessing the save area")
			Else
				AddLog("No access")
			End If
		End If
	End Sub

	''' <summary>
	''' "SetTime" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnSetTime_Click(sender As Object, e As EventArgs)
		Using timeForm As New TimeForm()
			If DialogResult.OK = timeForm.ShowDialog() Then
				Dim time As LJV7IF_TIME = timeForm.Time
				Dim rc As Integer = NativeMethods.LJV7IF_SetTime(_currentDeviceId, time)
				AddLogResult(rc, Resources.SID_SET_TIME)
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetTime" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetTime_Click(sender As Object, e As EventArgs)
		Dim time As New LJV7IF_TIME()
		Dim rc__1 As Integer = NativeMethods.LJV7IF_GetTime(_currentDeviceId, time)
		AddLogResult(rc__1, Resources.SID_GET_TIME)
		If rc__1 = CInt(Rc.Ok) Then
			AddLog(Utility.ConvertToLogString(time).ToString())
		End If
	End Sub

	''' <summary>
	''' "ChangeActiveProgram" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnChangeActiveProgram_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.ChangeActiveProgram

		Using depthProgramSelectForm As New DepthProgramSelectForm(False, True)
			If DialogResult.OK = depthProgramSelectForm.ShowDialog() Then
				Dim rc As Integer = NativeMethods.LJV7IF_ChangeActiveProgram(_currentDeviceId, depthProgramSelectForm.Target)
				AddLogResult(rc, Resources.SID_CHANGE_ACTIVE_PROGRAM)
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetActiveProgram" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetActiveProgram_Click(sender As Object, e As EventArgs)
		Dim progNo As Byte = 0
		Dim rc__1 As Integer = NativeMethods.LJV7IF_GetActiveProgram(_currentDeviceId, progNo)
		AddLogResult(rc__1, Resources.SID_GET_ACTIVE_PROGRAM)
		If rc__1 = CInt(Rc.Ok) Then
			AddLog(String.Format("ProgNo:{0}", progNo))
		End If
	End Sub
	#End Region

	#Region "Button for getting the measurement results"
	''' <summary>
	''' "GetMeasurementValue" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetMeasurementValue_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetMeasurementValue

		Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
		Dim rc__1 As Integer = NativeMethods.LJV7IF_GetMeasurementValue(_currentDeviceId, measureData)
		AddLogResult(rc__1, Resources.SID_GET_MEASUREMENT_VALUE)
		If rc__1 = CInt(Rc.Ok) Then
			_measureDatas.Clear()
			_measureDatas.Add(New MeasureData(0, measureData))

			For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
				AddLog(String.Format("  OUT{0:00}: {1}", (i + 1), Utility.ConvertToLogString(measureData(i)).ToString()))
			Next
		End If
	End Sub

	''' <summary>
	''' "GetProfile" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetProfile_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetProfile

		Using profileForm As New ProfileForm()
			If DialogResult.OK = profileForm.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				_deviceData(_currentDeviceId).MeasureData.Clear()
				Dim req As LJV7IF_GET_PROFILE_REQ = profileForm.Req
				Dim rsp As New LJV7IF_GET_PROFILE_RSP()
				Dim profileInfo As New LJV7IF_PROFILE_INFO()
				Dim oneProfDataBuffSize As UInteger = GetOneProfileDataSize()
				Dim allProfDataBuffSize As UInteger = oneProfDataBuffSize * req.byGetProfCnt
                Dim profileData As Integer() = New Integer(CType(allProfDataBuffSize \ Marshal.SizeOf(GetType(Integer)) - 1, Integer)) {}

				Using pin As New PinnedObject(profileData)
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetProfile(_currentDeviceId, req, rsp, profileInfo, pin.Pointer, allProfDataBuffSize)
					AddLogResult(rc__1, Resources.SID_GET_PROFILE)
					If rc__1 = CInt(Rc.Ok) Then
						' Response data display
						AddLog(Utility.ConvertToLogString(rsp).ToString())
						AddLog(Utility.ConvertToLogString(profileInfo).ToString())

						AnalyzeProfileData(CInt(rsp.byGetProfCnt), profileInfo, profileData)

						' Profile export
						If DataExporter.ExportOneProfile(_deviceData(_currentDeviceId).ProfileData.ToArray(), 0, _txtboxProfileFilePath.Text) Then
							AddLog("###Saved!!")
						End If
					End If
				End Using
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetBatchProfile" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetBatchProfile_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetBatchProfile

		Using getBatchProfileForm As New GetBatchProfileForm()
			If DialogResult.OK = getBatchProfileForm.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				_deviceData(_currentDeviceId).MeasureData.Clear()
				' Set the command function
				Dim req As LJV7IF_GET_BATCH_PROFILE_REQ = getBatchProfileForm.Req
				Dim rsp As New LJV7IF_GET_BATCH_PROFILE_RSP()
				Dim profileInfo As New LJV7IF_PROFILE_INFO()
				Dim oneDataSize As UInteger = GetOneProfileDataSize()
				Dim allDataSize As UInteger = oneDataSize * getBatchProfileForm.Req.byGetProfCnt
                Dim profileData As Integer() = New Integer(CType(allDataSize \ Marshal.SizeOf(GetType(Integer)) - 1, Integer)) {}

				Using pin As New PinnedObject(profileData)
					' Send the command
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetBatchProfile(_currentDeviceId, req, rsp, profileInfo, pin.Pointer, allDataSize)
					' @Point
                    ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
                    ' # To read the remaining profiles after the first set of profiles have been read,
					'    set the specification method (byPosMode)to 0x02, specify the batch number (dwGetBatchNo),
					'    and then set the number to start reading profiles from (dwGetProfNo) and the number of profiles to read (byGetProfCnt) to values 
					'    that specify a range of profiles that have not been read to read the profiles in order.
                    ' # For the basic code, see "btnGetBatchProfileEx_Click."

					' Result output
					AddLogResult(rc__1, Resources.SID_GET_BATCH_PROFILE)
					If rc__1 = CInt(Rc.Ok) Then
						' Response data display
						AddLog(Utility.ConvertToLogString(rsp).ToString())
						AddLog(Utility.ConvertToLogString(profileInfo).ToString())

						AnalyzeProfileData(CInt(rsp.byGetProfCnt), profileInfo, profileData)

						' Profile export
						If DataExporter.ExportOneProfile(_deviceData(_currentDeviceId).ProfileData.ToArray(), 0, _txtboxProfileFilePath.Text) Then
							AddLog("###Saved!!")

						End If
					End If
				End Using
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetProfileAdvance" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetProfileAdvance_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetProfileAdvance
		_deviceData(_currentDeviceId).ProfileData.Clear()
		_deviceData(_currentDeviceId).MeasureData.Clear()
		_measureDatas.Clear()

		' Set the command function
		Dim profileInfo As New LJV7IF_PROFILE_INFO()
		Dim dataSize As UInteger = GetOneProfileDataSize()
        Dim profileData As Integer() = New Integer(CType(dataSize \ Marshal.SizeOf(GetType(Integer)) - 1, Integer)) {}
		Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}

		Using pin As New PinnedObject(profileData)
			' Send the command
			Dim rc__1 As Integer = NativeMethods.LJV7IF_GetProfileAdvance(_currentDeviceId, profileInfo, pin.Pointer, dataSize, measureData)

			' Result output
			AddLogResult(rc__1, Resources.SID_GET_PROFILE_ADVANCE)
			If rc__1 = CInt(Rc.Ok) Then
				' Response data display
				AddLog(Utility.ConvertToLogString(profileInfo).ToString())

				_measureDatas.Add(New MeasureData(0, measureData))
				AnalyzeProfileData(1, profileInfo, profileData)
				For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
					AddLog(String.Format("  OUT{0:00}: {1}", (i + 1), Utility.ConvertToLogString(measureData(i)).ToString()))
				Next
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetBatchProfileAdvance" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetBatchProfileAdvance_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetBatchProfileAdvance

		Using getBatchprofileAdvanceForm As New GetBatchprofileAdvanceForm()
			If DialogResult.OK = getBatchprofileAdvanceForm.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				_deviceData(_currentDeviceId).MeasureData.Clear()
				_measureDatas.Clear()

				' Set the command function
				Dim req As LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ = getBatchprofileAdvanceForm.Req
				Dim rsp As New LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP()
				Dim profileInfo As New LJV7IF_PROFILE_INFO()
				Dim oneDataSize As UInteger = GetOneProfileDataSize() + CUInt(Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA)) * CUInt(NativeMethods.MeasurementDataCount)
                Dim allDataSize As UInteger = oneDataSize * getBatchprofileAdvanceForm.Req.byGetProfCnt
                Dim profileData As Integer() = New Integer(CType(allDataSize \ Marshal.SizeOf(GetType(Integer)) - 1, Integer)) {}
				Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
				Dim batchMeasureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}

				Using pin As New PinnedObject(profileData)
					' Send the command
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetBatchProfileAdvance(_currentDeviceId, req, rsp, profileInfo, pin.Pointer, allDataSize, _
						batchMeasureData, measureData)
					' @Point
                    ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
                    ' # To read the remaining profiles after the first set of profiles have been read,
					'    set the specification method (byPosMode)to 0x02, specify the batch number (dwGetBatchNo),
					'    and then set the number to start reading profiles from (dwGetProfNo) and the number of profiles to read (byGetProfCnt) to values 
					'    that specify a range of profiles that have not been read to read the profiles in order.
                    ' # For the basic code, see "btnGetBatchProfileEx_Click."

					' Result output
					AddLogResult(rc__1, Resources.SID_GET_BATCH_PROFILE_ADVANCE)
					If rc__1 = CInt(Rc.Ok) Then
						_measureDatas.Add(New MeasureData(0, measureData))
						AddLog(Utility.ConvertToLogString(rsp).ToString())
						AddLog(Utility.ConvertToLogString(profileInfo).ToString())
						For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
							AddLog(String.Format("  OUT{0:00}: {1}", (i + 1), Utility.ConvertToLogString(measureData(i)).ToString()))
						Next

						AnalyzeBatchData(CInt(rsp.byGetProfCnt), profileInfo, False, profileData, 0)

						' Profile export
						If DataExporter.ExportOneProfile(_deviceData(_currentDeviceId).ProfileData.ToArray(), 0, _txtboxProfileFilePath.Text) Then
							AddLog("###Saved!!")
						End If
					End If
				End Using
			End If
		End Using
	End Sub
	#End Region

	#Region "Button for storage-related functions"
	''' <summary>
	''' "StartStorage" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnStartStorage_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.StartStorage

		Dim rc As Integer = NativeMethods.LJV7IF_StartStorage(_currentDeviceId)
		AddLogResult(rc, Resources.SID_START_STORAGE)
	End Sub

	''' <summary>
	''' "StopStorage" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnStopStorage_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.StopStorage

		Dim rc As Integer = NativeMethods.LJV7IF_StopStorage(_currentDeviceId)
		AddLogResult(rc, Resources.SID_STOP_STORAGE)
	End Sub

	''' <summary>
	''' "GetStorageStatus" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetStorageStatus_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetStorageStatus

		Using getStorageStatusForm As New GetStorageStatusForm()
			If DialogResult.OK = getStorageStatusForm.ShowDialog() Then
				Dim req As LJV7IF_GET_STRAGE_STATUS_REQ = getStorageStatusForm.Req
				' @Point
                ' # dwReadArea is the target surface to read.
				'   The target surface to read indicates where in the internal memory usage area to read.
                ' # The method to use in specifying dwReadArea varies depending on how internal memory is allocated.
				'   * Double buffer
				'      0 indicates the active surface, 1 indicates surface A, and 2 indicates surface B.
				'   * Entire area (overwrite)
				'      Fixed to 1
				'   * Entire area (do not overwrite)
				'      After a setting modification, data is saved in surfaces 1, 2, 3, and so on in order, and 0 is set as the active surface.
                ' # For details, see "9.2.9.2 Internal memory."

				Dim rsp As New LJV7IF_GET_STRAGE_STATUS_RSP()
				Dim storageInfo As New LJV7IF_STORAGE_INFO()

				Dim rc__1 As Integer = NativeMethods.LJV7IF_GetStorageStatus(_currentDeviceId, req, rsp, storageInfo)
				' @Point
                ' # Terminology	
				'  * Base time … time expressed with 32 bits (<- the time when the setting was changed)
				'  * Accumulated date and time	 … counter value that indicates the elapsed time, in units of 10 ms, from the base time
                ' # The accumulated date and time are stored in the accumulated data.
                ' # The accumulated time of read data is calculated as shown below.
				'   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time × 10 ms"

				AddLogResult(rc__1, Resources.SID_GET_STORAGE_STATUS)
				If rc__1 = CInt(Rc.Ok) Then
					' Response data display
					AddLog(Utility.ConvertToLogString(rsp).ToString())
					AddLog(Utility.ConvertToLogString(storageInfo).ToString())
				End If
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetStorageData" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetStorageData_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetStorageData

		Using getStorageData As New GetStorageDataForm()
			If DialogResult.OK = getStorageData.ShowDialog() Then
				_measureDatas.Clear()
				Dim req As LJV7IF_GET_STORAGE_REQ = getStorageData.Req
				' @Point
                ' # dwReadArea is the target surface to read.
				'    The target surface to read indicates where in the internal memory usage area to read.
                ' # The method to use in specifying dwReadArea varies depending on how internal memory is allocated.
				'   * Double buffer
				'      0 indicates the active surface, 1 indicates surface A, and 2 indicates surface B.
				'   * Entire area (overwrite)
				'      Fixed to 1
				'   * Entire area (do not overwrite)
				'      After a setting modification, data is saved in surfaces 1, 2, 3, and so on in order, and 0 is set as the active surface.
                ' # For details, see "9.2.9.2 Internal memory."

				Dim storageInfo As New LJV7IF_STORAGE_INFO()
				Dim rsp As New LJV7IF_GET_STORAGE_RSP()
				Dim oneDataSize As UInteger = CUInt(Marshal.SizeOf(GetType(UInteger)) + CUInt(Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA)) * CUInt(NativeMethods.MeasurementDataCount))
                Dim allDataSize As UInteger
                If getStorageData.Req.dwDataCnt > System.Int16.MaxValue Then
                    allDataSize = Define.READ_DATA_SIZE
                Else
                    allDataSize = CType(Math.Min(Define.READ_DATA_SIZE, oneDataSize * getStorageData.Req.dwDataCnt), UInteger)
                End If

                Dim receiveData As Byte() = New Byte(CType(allDataSize - 1, Integer)) {}
				Using pin As New PinnedObject(receiveData)
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetStorageData(_currentDeviceId, req, storageInfo, rsp, pin.Pointer, allDataSize)
					AddLogResult(rc__1, Resources.SID_GET_STORAGE_DATA)
					' @Point
                    ' # Terminology	
					'  * Base time … time expressed with 32 bits (<- the time when the setting was changed)
					'  * Accumulated date and time	 … counter value that indicates the elapsed time, in units of 10 ms, from the base time
                    ' # The accumulated date and time are stored in the accumulated data.
                    ' # The accumulated time of read data is calculated as shown below.
					'   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time × 10 ms"

					If rc__1 = CInt(Rc.Ok) Then
						' Temporarily retain the get data.
						Dim byteSize As Integer = MeasureData.GetByteSize()
						For i As Integer = 0 To CInt(rsp.dwDataCnt) - 1
							_measureDatas.Add(New MeasureData(receiveData, byteSize * i))
						Next

						' Response data display
						AddLog(Utility.ConvertToLogString(storageInfo).ToString())
						AddLog(Utility.ConvertToLogString(rsp).ToString())
					End If
				End Using
			End If
		End Using
	End Sub

	''' <summary>
	''' "GetStorageProfile" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetStorageProfile_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetStorageProfile

		Using getStorageData As New GetStorageDataForm()
			If DialogResult.OK = getStorageData.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				_deviceData(_currentDeviceId).MeasureData.Clear()
				_measureDatas.Clear()
				Dim req As LJV7IF_GET_STORAGE_REQ = getStorageData.Req
				' @Point
                ' # dwReadArea is the target surface to read.
				'   The target surface to read indicates where in the internal memory usage area to read.
                ' # The method to use in specifying dwReadArea varies depending on how internal memory is allocated.
				'   * Double buffer
				'      0 indicates the active surface, 1 indicates surface A, and 2 indicates surface B.
				'   * Entire area (overwrite)
				'      Fixed to 1
				'   * Entire area (do not overwrite)
				'      After a setting modification, data is saved in surfaces 1, 2, 3, and so on in order, and 0 is set as the active surface.
                ' # For details, see "9.2.9.2 Internal memory."

				Dim storageInfo As New LJV7IF_STORAGE_INFO()
				Dim rsp As New LJV7IF_GET_STORAGE_RSP()
				Dim profileInfo As New LJV7IF_PROFILE_INFO()

				Dim oneDataSize As UInteger = CUInt(Marshal.SizeOf(GetType(UInteger)) + CUInt(Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA)) * CUInt(NativeMethods.MeasurementDataCount) * 2 + GetOneProfileDataSize())
                Dim allDataSize As UInteger
                If getStorageData.Req.dwDataCnt > System.Int16.MaxValue Then
                    allDataSize = Define.READ_DATA_SIZE
                Else
                    allDataSize = CType(Math.Min(Define.READ_DATA_SIZE, oneDataSize * getStorageData.Req.dwDataCnt), UInteger)
                End If

                Dim receiveData As Byte() = New Byte(CType(allDataSize - 1, Integer)) {}
                Using pin As New PinnedObject(receiveData)
                    Dim rc__1 As Integer = NativeMethods.LJV7IF_GetStorageProfile(_currentDeviceId, req, storageInfo, rsp, profileInfo, pin.Pointer, _
                     allDataSize)
                    ' @Point
                    ' # Terminology	
                    '  * Base time … time expressed with 32 bits (<- the time when the setting was changed)
                    '  * Accumulated date and time	 … counter value that indicates the elapsed time, in units of 10 ms, from the base time
                    ' # The accumulated date and time are stored in the accumulated data.
                    ' # The accumulated time of read data is calculated as shown below.
                    '   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time × 10 ms"

                    ' @Point
                    ' # When reading multiple profiles, the specified number of profiles may not be read.
                    ' # To read the remaining profiles after the first set of profiles have been read,
                    '   set the number to start reading profiles from (dwStartNo) and the number of profiles to read (byDataCnt) 
                    '   to values that specify a range of profiles that have not been read to read the profiles in order.
                    ' # For the basic code, see "btnGetBatchProfileEx_Click."

                    AddLogResult(rc__1, Resources.SID_GET_STORAGE_PROFILE)
                    If rc__1 = CInt(Rc.Ok) Then
                        ' Temporarily retain the get data.
                        Dim measureDataSize As Integer = MeasureData.GetByteSize()
                        Dim profileDataSize As Integer = ProfileData.CalculateDataSize(profileInfo) * Marshal.SizeOf(GetType(Integer))
                        Dim profileMeasureDataSize As Integer = Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA) * NativeMethods.MeasurementDataCount
                        Dim byteSize As Integer = measureDataSize + profileDataSize + profileMeasureDataSize
                        Dim tempRecvieMeasureData As Byte() = New Byte(profileMeasureDataSize - 1) {}

                        For i As Integer = 0 To CInt(rsp.dwDataCnt) - 1
                            _measureDatas.Add(New MeasureData(receiveData, byteSize * i))
                            _deviceData(_currentDeviceId).ProfileData.Add(New ProfileData(receiveData, (measureDataSize + byteSize * i), profileInfo))
                            Buffer.BlockCopy(receiveData, (measureDataSize + profileDataSize + byteSize * i), tempRecvieMeasureData, 0, profileMeasureDataSize)
                            _deviceData(_currentDeviceId).MeasureData.Add(New MeasureData(tempRecvieMeasureData))
                        Next

                        ' Response data display
                        AddLog(Utility.ConvertToLogString(storageInfo).ToString())
                        AddLog(Utility.ConvertToLogString(rsp).ToString())
                        AddLog(Utility.ConvertToLogString(profileInfo).ToString())
                    End If
                End Using
            End If
		End Using
	End Sub

	''' <summary>
	''' "GetStorageBatchProfile" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnGetStorageBatchProfile_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.GetStorageBatchProfile

		Using getStorageBatchProfileForm As New GetStorageBatchProfileForm()
			If DialogResult.OK = getStorageBatchProfileForm.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				_deviceData(_currentDeviceId).MeasureData.Clear()
				_measureDatas.Clear()
				' Set the function data
				Dim req As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ = getStorageBatchProfileForm.Req
				Dim storageInfo As New LJV7IF_STORAGE_INFO()
				Dim rsp As New LJV7IF_GET_BATCH_PROFILE_STORAGE_RSP()
				Dim profileInfo As New LJV7IF_PROFILE_INFO()
				Dim oneDataSize As UInteger = GetOneProfileDataSize() + CUInt(Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA) * CUInt(NativeMethods.MeasurementDataCount))
				Dim allDataSize As UInteger = oneDataSize * getStorageBatchProfileForm.Req.byGetProfCnt
				Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
                Dim profileData As Integer() = New Integer(CType(allDataSize \ Marshal.SizeOf(GetType(Integer)) - 1, Integer)) {}
				Dim offsetTime As UInteger = 0

				Using pin As New PinnedObject(profileData)
					' Send the command
					Dim rc__1 As Integer = NativeMethods.LJV7IF_GetStorageBatchProfile(_currentDeviceId, req, storageInfo, rsp, profileInfo, pin.Pointer, _
						allDataSize, offsetTime, measureData)
					' @Point
                    ' # Terminology	
					'  * Base time … time expressed with 32 bits (<- the time when the setting was changed)
					'  * Accumulated date and time	 … counter value that indicates the elapsed time, in units of 10 ms, from the base time
                    ' # The accumulated date and time are stored in the accumulated data.
                    ' # The accumulated time of read data is calculated as shown below.
					'   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time × 10 ms"

					' @Point
                    ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.	
                    ' # To read the remaining profiles after the first set of profiles have been read, 
					'   specify the batch number (dwGetBatchNo), and then set the number to start reading profiles 
					'   from (dwGetTopProfNo) and the number of profiles to read (byGetProfCnt) to values 
					'   that specify a range of profiles that have not been read to read the profiles in order.
                    ' # For the basic code, see "btnGetBatchProfileEx_Click."

					' Result output
					AddLogResult(rc__1, Resources.SID_GET_STORAGE_BATCH_PROFILE)
					If rc__1 = CInt(Rc.Ok) Then
						AnalyzeBatchData(CInt(rsp.byGetProfCnt), profileInfo, False, profileData, 0)

						_measureDatas.Add(New MeasureData(offsetTime, measureData))
						' Response data display
						AddLog(Utility.ConvertToLogString(storageInfo).ToString())
						AddLog(Utility.ConvertToLogString(rsp).ToString())
						AddLog(Utility.ConvertToLogString(profileInfo).ToString())
						AddLog(String.Format("offsetTime" & vbTab & ":{0}", offsetTime))
					End If
				End Using
			End If
		End Using
	End Sub
	#End Region

	#Region "Buttons related to high-speed data communication"
	''' <summary>
	''' "HighSpeedDataUsbCommunicationInitalize" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnHighSpeedDataUsbCommunicationInitalize_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.HighSpeedDataUsbCommunicationInitalize

		Using highSpeedInitalizeForm As New HighSpeedInitalizeForm(False)
			If DialogResult.OK = highSpeedInitalizeForm.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				' Clear the retained profile data.
				_deviceData(_currentDeviceId).MeasureData.Clear()

				Dim rc__1 As Integer = NativeMethods.LJV7IF_HighSpeedDataUsbCommunicationInitalize(_currentDeviceId, (If(_chkOnlyProfileCount.Checked, _callbackOnlyCount, _callback)), highSpeedInitalizeForm.ProfileCnt, CUInt(_currentDeviceId))
				' @Point
                ' # When the frequency of calls is low, the callback function may not be called once per specified number of profiles.
                ' # The callback function is called when both of the following conditions are met.
				'   * There is one packet of received data.
				'   * The specified number of profiles have been received by the time the call frequency has been met.

				AddLogResult(rc__1, Resources.SID_HIGH_SPEED_DATA_USB_COMMUNICATION_INITALIZE)

				If rc__1 = CInt(Rc.Ok) Then
					_deviceData(_currentDeviceId).Status = DeviceStatus.UsbFast
				End If
				_deviceStatusLabels(_currentDeviceId).Text = _deviceData(_currentDeviceId).GetStatusString()
			End If
		End Using
	End Sub

	''' <summary>
	''' "HighSpeedDataEthernetCommunicationInitalize" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnHighSpeedDataEthernetCommunicationInitalize_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.HighSpeedDataEthernetCommunicationInitalize

		Using highSpeedInitalizeForm As New HighSpeedInitalizeForm(True)
			highSpeedInitalizeForm.EthernetConfig = _deviceData(_currentDeviceId).EthernetConfig

			If DialogResult.OK = highSpeedInitalizeForm.ShowDialog() Then
				_deviceData(_currentDeviceId).ProfileData.Clear()
				'Clear the retained profile data.
				_deviceData(_currentDeviceId).MeasureData.Clear()

				Dim ethernetConfig As LJV7IF_ETHERNET_CONFIG = highSpeedInitalizeForm.EthernetConfig
				Dim rc__1 As Integer = NativeMethods.LJV7IF_HighSpeedDataEthernetCommunicationInitalize(_currentDeviceId, ethernetConfig, highSpeedInitalizeForm.HighSpeedPortNo, (If(_chkOnlyProfileCount.Checked, _callbackOnlyCount, _callback)), highSpeedInitalizeForm.ProfileCnt, CUInt(_currentDeviceId))
				' @Point
                ' # When the frequency of calls is low, the callback function may not be called once per specified number of profiles.
                ' # The callback function is called when both of the following conditions are met.
				'   * There is one packet of received data.
				'   * The specified number of profiles have been received by the time the call frequency has been met.

				AddLogResult(rc__1, Resources.SID_HIGH_SPEED_DATA_ETHERNET_COMMUNICATION_INITALIZE)

				If rc__1 = CInt(Rc.Ok) Then
					_deviceData(_currentDeviceId).Status = DeviceStatus.EthernetFast
					_deviceData(_currentDeviceId).EthernetConfig = ethernetConfig
				End If

				_deviceStatusLabels(_currentDeviceId).Text = _deviceData(_currentDeviceId).GetStatusString()
			End If
		End Using
	End Sub

	''' <summary>
	''' "PreStartHighSpeedDataCommunication" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnPreStartHighSpeedDataCommunication_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.PreStartHighSpeedDataCommunication

		Using preStartHighSpeedForm As New PreStartHighSpeedForm()
			If DialogResult.OK = preStartHighSpeedForm.ShowDialog() Then
				Dim req As LJV7IF_HIGH_SPEED_PRE_START_REQ = preStartHighSpeedForm.Req
				' @Point
                ' # SendPos is used to specify which profile to start sending data from during high-speed communication.
                ' # When "Overwrite" is specified for the operation when memory full and 
				'   "0: From previous send complete position" is specified for the send start position,
				'    if the LJ-V continues to accumulate profiles, the LJ-V memory will become full,
				'    and the profile at the previous send complete position will be overwritten with a new profile.
				'    In this situation, because the profile at the previous send complete position is not saved, an error will occur.

				Dim profileInfo As New LJV7IF_PROFILE_INFO()

				Dim rc__1 As Integer = NativeMethods.LJV7IF_PreStartHighSpeedDataCommunication(_currentDeviceId, req, profileInfo)
				AddLogResult(rc__1, Resources.SID_PRE_START_HIGH_SPEED_DATA_COMMUNICATION)
				If rc__1 = CInt(Rc.Ok) Then
					' Response data display
					AddLog(Utility.ConvertToLogString(profileInfo).ToString())
					_profileInfo(_currentDeviceId) = profileInfo
				End If
			End If
		End Using
	End Sub

	''' <summary>
	''' "StartHighSpeedDataCommunication" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnStartHighSpeedDataCommunication_Click(sender As Object, e As EventArgs)
		_sendCommand = SendCommand.StartHighSpeedDataCommunication

		ThreadSafeBuffer.ClearBuffer(_currentDeviceId)
		_receivedProfileCountLabels(_currentDeviceId).Text = "0"
		Dim rc As Integer = NativeMethods.LJV7IF_StartHighSpeedDataCommunication(_currentDeviceId)
		' @Point
		'  If the LJ-V does not measure the profile for 30 seconds from the start of transmission,
		'  "0x00000008" is stored in dwNotify of the callback function.

		AddLogResult(rc, Resources.SID_START_HIGH_SPEED_DATA_COMMUNICATION)
	End Sub

	''' <summary>
	''' "StopHighSpeedDataCommunication" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnStopHighSpeedDataCommunication_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_StopHighSpeedDataCommunication(_currentDeviceId)
		AddLogResult(rc, Resources.SID_STOP_HIGH_SPEED_DATA_COMMUNICATION)
	End Sub

	''' <summary>
	''' "HighSpeedDataCommunicationFinalize" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnHighSpeedDataCommunicationFinalize_Click(sender As Object, e As EventArgs)
		Dim rc As Integer = NativeMethods.LJV7IF_HighSpeedDataCommunicationFinalize(_currentDeviceId)
		AddLogResult(rc, Resources.SID_HIGH_SPEED_DATA_COMMUNICATION_FINALIZE)

		Select Case _deviceData(_currentDeviceId).Status
			Case DeviceStatus.UsbFast
				_deviceData(_currentDeviceId).Status = DeviceStatus.Usb
				Exit Select
			Case DeviceStatus.EthernetFast
				Dim config As LJV7IF_ETHERNET_CONFIG = _deviceData(_currentDeviceId).EthernetConfig
				_deviceData(_currentDeviceId).Status = DeviceStatus.Ethernet
				_deviceData(_currentDeviceId).EthernetConfig = config
				Exit Select
			Case Else
				Exit Select
		End Select
		_deviceStatusLabels(_currentDeviceId).Text = _deviceData(_currentDeviceId).GetStatusString()

	End Sub
	#End Region

	#Region "Button for settings / results"

	''' <summary>
	''' "Clear the log" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnLogClear_Click(sender As Object, e As EventArgs)
		_txtboxLog.Clear()
	End Sub

	''' <summary>
	''' "..." button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnProfileFileSave_Click(sender As Object, e As EventArgs)
		If _profileFileSave.ShowDialog(Me) = DialogResult.Cancel Then
			Return
		End If
		_txtboxProfileFilePath.Text = _profileFileSave.FileName
		_txtboxProfileFilePath.SelectionStart = _txtboxProfileFilePath.Text.Length
	End Sub

	''' <summary>
	''' "Save the profile" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnSave_Click(sender As Object, e As EventArgs)
		Dim profileNo As Integer = CInt(Math.Truncate(_nudProfileNo.Value))
		If profileNo >= _deviceData(_currentDeviceId).ProfileData.Count Then
			AddLog("There is no profile specified.")
			Return
		End If

		If DataExporter.ExportOneProfile(_deviceData(_currentDeviceId).ProfileData.ToArray(), profileNo, _txtboxProfileFilePath.Text) Then
			AddLog("Saved")
		End If
	End Sub

	''' <summary>
	''' "Save the measurement value" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnSaveMeasureData_Click(sender As Object, e As EventArgs)
		DataExporter.ExportMeasureData(_measureDatas.ToArray(), _txtboxProfileFilePath.Text)
		DataExporter.ExportMeasureData(_deviceData(_currentDeviceId).MeasureData.ToArray(), _txtboxProfileFilePath.Text & "2.txt")
	End Sub
	#End Region

	#Region "Other event handlers"
	''' <summary>
	''' "ID" option button (also known as a radio button) event handler
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub _rdDevice_CheckedChanged(sender As Object, e As EventArgs)
		_currentDeviceId = GetSelectedDeviceId()
	End Sub

	''' <summary>
	''' Event handler for the timer used during high-speed communication
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub _timerHighSpeedReceive_Tick(sender As Object, e As EventArgs)
		Dim count As Integer = 0
		Dim notify As UInteger = 0
		Dim batchNo As Integer = 0
		For i As Integer = 0 To NativeMethods.DeviceCount - 1
			If _chkOnlyProfileCount.Checked Then
				_receivedProfileCountLabels(i).Text = ThreadSafeBuffer.GetCount(i, notify, batchNo).ToString()
			Else
				Dim data As List(Of Integer()) = ThreadSafeBuffer.[Get](i, notify, batchNo)
				If data.Count = 0 Then
					Continue For
				End If

				For Each profile As Integer() In data
					If _deviceData(i).ProfileData.Count < Define.WRITE_DATA_SIZE Then
						_deviceData(i).ProfileData.Add(New ProfileData(profile, _profileInfo(i)))
					End If
					count += 1
				Next
				_receivedProfileCountLabels(i).Text = (Convert.ToInt32(_receivedProfileCountLabels(i).Text) + count).ToString()
			End If

			If notify <> 0 Then
				AddLog(String.Format("  notify[{0}] = {1,0:x8}" & vbTab & "batch[{0}] = {2}", i, notify, batchNo))
			End If
		Next

	End Sub

	''' <summary>
	''' "Timer start check box" event handler
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub _chkStartTimer_CheckedChanged(sender As Object, e As EventArgs)
		Dim isStart As Boolean = _chkStartTimer.Checked
		If isStart Then
			_timerHighSpeedReceive.Interval = CInt(Math.Truncate(_numInterval.Value))
			_timerHighSpeedReceive.Start()
		Else
			_timerHighSpeedReceive.[Stop]()
		End If
		_numInterval.Enabled = Not isStart
		_chkOnlyProfileCount.Enabled = Not isStart
	End Sub

	#End Region

	#End Region

	#Region "Event handler(for combination-function)"

	#Region "Initialization and Exit event handler"
	''' <summary>
	''' "Communication establishment" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Initialize the DLL, and then establish a USB or Ethernet communication path.</remarks>
	Private Sub btnEstablishCommunicationEx_Click(sender As Object, e As EventArgs)
		Dim rc__1 As Rc = Rc.Ok
		' Initialize the DLL
		rc__1 = CType(NativeMethods.LJV7IF_Initialize(), Rc)
		If Not CheckReturnCode(rc__1) Then
			Return
		End If

		' Open the communication path
		If _rdUsb.Checked Then
			rc__1 = CType(NativeMethods.LJV7IF_UsbOpen(Define.DEVICE_ID), Rc)
		Else
			' Generate the settings for Ethernet communication.
			Try
				_ethernetConfig.abyIpAddress = New Byte() {Convert.ToByte(_txtIpFirstSegment.Text), Convert.ToByte(_txtIpSecondSegment.Text), Convert.ToByte(_txtIpThirdSegment.Text), Convert.ToByte(_txtIpFourthSegment.Text)}
				_ethernetConfig.wPortNo = Convert.ToUInt16(_txtCommandPort.Text)
			Catch ex As Exception
				MessageBox.Show(Me, ex.Message)
				Return
			End Try

			rc__1 = CType(NativeMethods.LJV7IF_EthernetOpen(Define.DEVICE_ID, _ethernetConfig), Rc)
		End If
		If Not CheckReturnCode(rc__1) Then
			Return
		End If
	End Sub

	''' <summary>
	''' "Communication finalization" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Processing of the finalization of communication with the controller</remarks>
	Private Sub btnTerminateCommunicationEx_Click(sender As Object, e As EventArgs)
		Dim rc__1 As Rc = Rc.Ok
		' Close the communication
		rc__1 = CType(NativeMethods.LJV7IF_CommClose(Define.DEVICE_ID), Rc)
		If Not CheckReturnCode(rc__1) Then
			Return
		End If

		' Finalize the DLL
		rc__1 = CType(NativeMethods.LJV7IF_Finalize(), Rc)
		If Not CheckReturnCode(rc__1) Then
			Return
		End If
	End Sub

	''' <summary>
	''' When the "Ethernet" option button (also known as a radio button) is selected
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub _rdEthernet_CheckedChanged(sender As Object, e As EventArgs)
		_grpEthernetSetting.Enabled = _rdEthernet.Checked
	End Sub

	#End Region

	#Region "Get measurement results event handler"
	''' <summary>
	''' "Get current values" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Get the latest measurement values of OUT1 to OUT16.</remarks>
	Private Sub btnGetMeasureValueEx_Click(sender As Object, e As EventArgs)
		Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
		Dim rc As Rc = CType(NativeMethods.LJV7IF_GetMeasurementValue(Define.DEVICE_ID, measureData), Rc)
		If Not CheckReturnCode(rc) Then
			Return
		End If
		Dim data As New MeasureData(measureData)

		Dim sb As New StringBuilder()
		For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
			sb.Append(String.Format("OUT {0:d2}:" & vbTab & "{1,0:f4}" & vbCr & vbLf, (i + 1), measureData(i).fValue))
		Next

		_txtMeasureData.Text = sb.ToString()
	End Sub

	''' <summary>
	''' Browse ("...") button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnReferenceSavePathEx_Click(sender As Object, e As EventArgs)
		If _profileFileSave.ShowDialog() <> DialogResult.OK Then
			Return
		End If
		_txtSavePath.Text = _profileFileSave.FileName
	End Sub

	''' <summary>
	''' "Get high-speed mode profiles" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>
	''' Get profiles in high-speed mode, and then output profile data to file.
	''' </remarks>
	Private Sub btnGetProfileEx_Click(sender As Object, e As EventArgs)
		Dim req As New LJV7IF_GET_PROFILE_REQ()
		req.byTargetBank = CByte(ProfileBank.Active)
		req.byPosMode = CByte(ProfilePos.Current)
		req.dwGetProfNo = 0
		req.byGetProfCnt = 10
		req.byErase = 0

		Dim rsp As New LJV7IF_GET_PROFILE_RSP()
		Dim profileInfo As New LJV7IF_PROFILE_INFO()

		Dim profileDataSize As Integer = Define.MAX_PROFILE_COUNT + (Marshal.SizeOf(GetType(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(GetType(LJV7IF_PROFILE_FOOTER))) \ Marshal.SizeOf(GetType(Integer))
		Dim receiveBuffer As Integer() = New Integer(profileDataSize * req.byGetProfCnt - 1) {}

		Using progressForm As New ProgressForm()
			Cursor.Current = Cursors.WaitCursor

			progressForm.Status = Status.Communicating
			progressForm.Show(Me)
			progressForm.Refresh()

			' Get profiles.
			Using pin As New PinnedObject(receiveBuffer)
				Dim rc As Rc = CType(NativeMethods.LJV7IF_GetProfile(Define.DEVICE_ID, req, rsp, profileInfo, pin.Pointer, CUInt(receiveBuffer.Length * Marshal.SizeOf(GetType(Integer)))), Rc)
				If Not CheckReturnCode(rc) Then
					Return
				End If
			End Using

			' Output the data of each profile
			Dim profileDatas As New List(Of ProfileData)()
			Dim unitSize As Integer = ProfileData.CalculateDataSize(profileInfo)
			For i As Integer = 0 To rsp.byGetProfCnt - 1
				profileDatas.Add(New ProfileData(receiveBuffer, unitSize * i, profileInfo))
			Next

			progressForm.Status = Status.Saving
			progressForm.Refresh()

			' Save the file
			SaveProfile(profileDatas, _txtSavePath.Text)
		End Using
	End Sub

	''' <summary>
	''' "Get high-speed mode batch profiles" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>
	''' Read one batch worth of committed profiles that have been acquired with batch measurement in high-speed mode.
	''' </remarks>
	Private Sub btnGetBatchProfileEx_Click(sender As Object, e As EventArgs)
		' Specify the target batch to get.
		Dim req As New LJV7IF_GET_BATCH_PROFILE_REQ()
		req.byTargetBank = CByte(ProfileBank.Active)
		req.byPosMode = CByte(BatchPos.Commited)
		req.dwGetBatchNo = 0
		req.dwGetProfNo = 0
		req.byGetProfCnt = Byte.MaxValue
		req.byErase = 0

		Dim rsp As New LJV7IF_GET_BATCH_PROFILE_RSP()
		Dim profileInfo As New LJV7IF_PROFILE_INFO()

		Dim profileDataSize As Integer = Define.MAX_PROFILE_COUNT + (Marshal.SizeOf(GetType(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(GetType(LJV7IF_PROFILE_FOOTER))) \ Marshal.SizeOf(GetType(Integer))
		Dim receiveBuffer As Integer() = New Integer(profileDataSize * req.byGetProfCnt - 1) {}

		Using progressForm As New ProgressForm()
			Cursor.Current = Cursors.WaitCursor

			progressForm.Status = Status.Communicating
			progressForm.Show(Me)
			progressForm.Refresh()

			Dim profileDatas As New List(Of ProfileData)()
			' Get profiles
			Using pin As New PinnedObject(receiveBuffer)
				Dim rc As Rc = CType(NativeMethods.LJV7IF_GetBatchProfile(Define.DEVICE_ID, req, rsp, profileInfo, pin.Pointer, CUInt(receiveBuffer.Length * Marshal.SizeOf(GetType(Integer)))), Rc)
				' @Point
                ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
                ' # To read the remaining profiles after the first set of profiles have been read, set the specification method (byPosMode)to 0x02, 
				'   specify the batch number (dwGetBatchNo), and then set the number to start reading profiles from (dwGetProfNo) and 
				'   the number of profiles to read (byGetProfCnt) to values that specify a range of profiles that have not been read to read the profiles in order.
                ' # In more detail, this process entails:
				'   * First configure req as listed below and call this function again.
				'      byPosMode = LJV7IF_BATCH_POS_SPEC
				'      dwGetBatchNo = batch number that was read
				'      byGetProfCnt = Profile number of unread in the batch
				'   * Furthermore, if all profiles in the batch are not read,update the starting position for reading profiles (req.dwGetProfNo) and
				'     the number of profiles to read (req.byGetProfCnt), and then call LJV7IF_GetBatchProfile again. (Repeat this process until all the profiles have been read.)

				If Not CheckReturnCode(rc) Then
					Return
				End If

				' Output the data of each profile
				Dim unitSize As Integer = ProfileData.CalculateDataSize(profileInfo)
				For i As Integer = 0 To rsp.byGetProfCnt - 1
					profileDatas.Add(New ProfileData(receiveBuffer, unitSize * i, profileInfo))
				Next

				' Get all profiles within the batch.
				req.byPosMode = CByte(BatchPos.Spec)
				req.dwGetBatchNo = rsp.dwGetBatchNo
				Do
					' Update the get profile position
					req.dwGetProfNo = rsp.dwGetBatchTopProfNo + rsp.byGetProfCnt
					req.byGetProfCnt = CByte(Math.Min(CUInt(Byte.MaxValue), (rsp.dwCurrentBatchProfCnt - req.dwGetProfNo)))

					rc = CType(NativeMethods.LJV7IF_GetBatchProfile(Define.DEVICE_ID, req, rsp, profileInfo, pin.Pointer, CUInt(receiveBuffer.Length * Marshal.SizeOf(GetType(Integer)))), Rc)
					If Not CheckReturnCode(rc) Then
						Return
					End If
					For i As Integer = 0 To rsp.byGetProfCnt - 1
						profileDatas.Add(New ProfileData(receiveBuffer, unitSize * i, profileInfo))
					Next
				Loop While rsp.dwGetBatchProfCnt <> (rsp.dwGetBatchTopProfNo + rsp.byGetProfCnt)
			End Using

			progressForm.Status = Status.Saving
			progressForm.Refresh()
			' Save the file
			SaveProfile(profileDatas, _txtSavePath.Text)
		End Using
	End Sub

	''' <summary>
	''' "Get advanced mode profiles" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>
	''' Get profiles in advanced mode, and then output profile data to file.
	''' </remarks>
	Private Sub btnGetProfileAdvanceEx_Click(sender As Object, e As EventArgs)
		Dim profileInfo As New LJV7IF_PROFILE_INFO()
		Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
		' OUT1 to OUT16 measurement value
		Dim profileDataSize As Integer = Define.MAX_PROFILE_COUNT + (Marshal.SizeOf(GetType(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(GetType(LJV7IF_PROFILE_FOOTER))) \ Marshal.SizeOf(GetType(Integer))
		Dim receiveBuffer As Integer() = New Integer(profileDataSize - 1) {}
		' 3,207 (total of the header, the footer, and the 3,200 data entries)
		Using pin As New PinnedObject(receiveBuffer)
			Dim rc As Rc = CType(NativeMethods.LJV7IF_GetProfileAdvance(Define.DEVICE_ID, profileInfo, pin.Pointer, CUInt(receiveBuffer.Length * Marshal.SizeOf(GetType(Integer))), measureData), Rc)

			If Not CheckReturnCode(rc) Then
				Return
			End If
		End Using

		Dim profileDatas As New List(Of ProfileData)()
		' Output the data of each profile
		profileDatas.Add(New ProfileData(receiveBuffer, 0, profileInfo))

		' Save the file
		SaveProfile(profileDatas, _txtSavePath.Text)
	End Sub

	''' <summary>
	''' "Get advanced mode batch profiles" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>
	''' Read one batch worth of committed profiles that have been acquired with batch measurement in advanced mode.
	''' </remarks>
	Private Sub btnGetBatchProfileAdvanceEx_Click(sender As Object, e As EventArgs)
		MessageBox.Show("We will start Advanced mode get batch profiles.")
		Dim req As New LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ()
		' Get request structure
		req.byPosMode = CByte(BatchPos.Commited)
		req.dwGetBatchNo = 0
		req.dwGetProfNo = 0
		req.byGetProfCnt = Byte.MaxValue

		Dim rsp As New LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP()
		Dim profileInfo As New LJV7IF_PROFILE_INFO()
		Dim batchMeasureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
		Dim measureData As LJV7IF_MEASURE_DATA() = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}

		Dim profileDataSize As Integer = Define.MAX_PROFILE_COUNT + (Marshal.SizeOf(GetType(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(GetType(LJV7IF_PROFILE_FOOTER))) \ Marshal.SizeOf(GetType(Integer))
		Dim measureDataSize As Integer = Marshal.SizeOf(GetType(LJV7IF_MEASURE_DATA)) * NativeMethods.MeasurementDataCount \ Marshal.SizeOf(GetType(Integer))
		Dim receiveBuffer As Integer() = New Integer((profileDataSize + measureDataSize) * req.byGetProfCnt - 1) {}

		Using progressForm As New ProgressForm()
			Cursor.Current = Cursors.WaitCursor
			progressForm.Status = Status.Communicating
			progressForm.Show(Me)
			progressForm.Refresh()

			Dim profileDatas As New List(Of ProfileData)()
			' Get profiles.
			Using pin As New PinnedObject(receiveBuffer)
				Dim rc As Rc = CType(NativeMethods.LJV7IF_GetBatchProfileAdvance(Define.DEVICE_ID, req, rsp, profileInfo, pin.Pointer, CUInt(receiveBuffer.Length * Marshal.SizeOf(GetType(Integer))), _
					batchMeasureData, measureData), Rc)
				' @Point
                ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
                ' # To read the remaining profiles after the first set of profiles have been read, set the specification method (byPosMode)to 0x02, 
				'  specify the batch number (dwGetBatchNo), and then set the number to start reading profiles from (dwGetProfNo) and 
				'  the number of profiles to read (byGetProfCnt) to values that specify a range of profiles that have not been read to read the profiles in order.
                ' # In more detail, this process entails:
				'  * First configure req as listed below and call this function again.
				'     byPosMode = LJV7IF_BATCH_POS_SPEC
				'     dwGetBatchNo = batch number that was read
				'     byGetProfCnt = Profile number of unread in the batch
				'  * Furthermore, if all profiles in the batch are not read,update the starting position for reading profiles (req.dwGetProfNo) and
				'	  the number of profiles to read (req.byGetProfCnt), and then call LJV7IF_GetBatchProfile again. (Repeat this process until all the profiles have been read.)

				If Not CheckReturnCode(rc) Then
					Return
				End If

				' Output the data of each profile
				Dim unitSize As Integer = ProfileData.CalculateDataSize(profileInfo) + measureDataSize
				For i As Integer = 0 To rsp.byGetProfCnt - 1
					profileDatas.Add(New ProfileData(receiveBuffer, unitSize * i, profileInfo))
				Next

				' Get all profiles within the batch.
				req.byPosMode = CByte(BatchPos.Spec)
				req.dwGetBatchNo = rsp.dwGetBatchNo
				Do
					' Update the get profile position
					req.dwGetProfNo = rsp.dwGetBatchTopProfNo + rsp.byGetProfCnt
					req.byGetProfCnt = CByte(Math.Min(CUInt(Byte.MaxValue), (rsp.dwGetBatchProfCnt - req.dwGetProfNo)))

					rc = CType(NativeMethods.LJV7IF_GetBatchProfileAdvance(Define.DEVICE_ID, req, rsp, profileInfo, pin.Pointer, CUInt(receiveBuffer.Length * Marshal.SizeOf(GetType(Integer))), _
						batchMeasureData, measureData), Rc)
					If Not CheckReturnCode(rc) Then
						Return
					End If
					For i As Integer = 0 To rsp.byGetProfCnt - 1
						profileDatas.Add(New ProfileData(receiveBuffer, unitSize * i, profileInfo))
					Next
				Loop While rsp.dwGetBatchProfCnt <> (rsp.dwGetBatchTopProfNo + rsp.byGetProfCnt)
			End Using

			progressForm.Status = Status.Saving
			progressForm.Refresh()

			' Save the file
			SaveProfile(profileDatas, _txtSavePath.Text)
		End Using
	End Sub

	#End Region

	#Region "High-speed data communication event handler"
	''' <summary>
	''' High-speed data communication "Start" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Perform the preparations for starting high-speed data communication, and then start high-speed data communication.</remarks>
	Private Sub btnBeginHighSpeedCommunicationEx_Click(sender As Object, e As EventArgs)
		' Stop and finalize high-speed data communication.
		NativeMethods.LJV7IF_StopHighSpeedDataCommunication(Define.DEVICE_ID)
		NativeMethods.LJV7IF_HighSpeedDataCommunicationFinalize(Define.DEVICE_ID)

		' Initialize the data.
		ThreadSafeBuffer.Clear(Define.DEVICE_ID)
		Dim rc__1 As Rc = Rc.Ok

		' Initialize the high-speed communication path
		' High-speed communication start preparations
		Dim req As New LJV7IF_HIGH_SPEED_PRE_START_REQ()
		Try
			Dim frequency As UInteger = Convert.ToUInt32(_txtCallbackFrequency.Text)
			Dim threadId As UInteger = CUInt(Define.DEVICE_ID)

			If _rdUsb.Checked Then
				' Initialize USB high-speed data communication
				rc__1 = CType(NativeMethods.LJV7IF_HighSpeedDataUsbCommunicationInitalize(Define.DEVICE_ID, _callback, frequency, threadId), Rc)
			Else
				' Generate the settings for Ethernet communication.
				Dim highSpeedPort As UShort = 0
				_ethernetConfig.abyIpAddress = New Byte() {Convert.ToByte(_txtIpFirstSegment.Text), Convert.ToByte(_txtIpSecondSegment.Text), Convert.ToByte(_txtIpThirdSegment.Text), Convert.ToByte(_txtIpFourthSegment.Text)}
				_ethernetConfig.wPortNo = Convert.ToUInt16(_txtCommandPort.Text)
				highSpeedPort = Convert.ToUInt16(_txtHighSpeedPort.Text)

				' Initialize Ethernet high-speed data communication
				rc__1 = CType(NativeMethods.LJV7IF_HighSpeedDataEthernetCommunicationInitalize(Define.DEVICE_ID, _ethernetConfig, highSpeedPort, _callback, frequency, threadId), Rc)
			End If
			If Not CheckReturnCode(rc__1) Then
				Return
			End If
			req.bySendPos = Convert.ToByte(_txtStartProfileNo.Text)
		Catch ex As FormatException
			MessageBox.Show(Me, ex.Message)
			Return
		Catch ex As OverflowException
			MessageBox.Show(Me, ex.Message)
			Return
		End Try

		' High-speed data communication start preparations
		Dim profileInfo As New LJV7IF_PROFILE_INFO()
		rc__1 = CType(NativeMethods.LJV7IF_PreStartHighSpeedDataCommunication(Define.DEVICE_ID, req, profileInfo), Rc)
		If Not CheckReturnCode(rc__1) Then
			Return
		End If

		' Start high-speed data communication.
		rc__1 = CType(NativeMethods.LJV7IF_StartHighSpeedDataCommunication(Define.DEVICE_ID), Rc)
		If Not CheckReturnCode(rc__1) Then
			Return
		End If

		_lblReceiveProfileCount.Text = "0"
		_timerHighSpeed.Start()
	End Sub

	''' <summary>
	''' High-speed data communication "Exit" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Stop high-speed data communication and perform high-speed data communication finalization processing.</remarks>
	Private Sub btnEndHighSpeedDataCommunicationEx_Click(sender As Object, e As EventArgs)
		' Stop high-speed data communication.
		Dim rc As Rc = CType(NativeMethods.LJV7IF_StopHighSpeedDataCommunication(Define.DEVICE_ID), Rc)
		If CheckReturnCode(rc) Then
			' Finalize high-speed data communication.
			rc = CType(NativeMethods.LJV7IF_HighSpeedDataCommunicationFinalize(Define.DEVICE_ID), Rc)
			CheckReturnCode(rc)
		End If
	End Sub

	''' <summary>
	''' Timer event handler
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub _timerHighSpeed_Tick(sender As Object, e As EventArgs)
		Dim notify As UInteger = 0
		Dim batcnNo As Integer = 0
		Dim data As List(Of Integer()) = ThreadSafeBuffer.[Get](Define.DEVICE_ID, notify, batcnNo)

        Dim count As Long = 0
		For Each profile As Integer() In data
			' Process received data here
			count += 1
		Next
		_lblReceiveProfileCount.Text = (Convert.ToUInt32(_lblReceiveProfileCount.Text) + count).ToString()

        If (notify And &HFFFF) <> 0 Then
            ' If the lower 16 bits of the notification are not 0, high-speed communication was interrupted, so stop the timer.
            _timerHighSpeed.[Stop]()
            MessageBox.Show(String.Format("Finalize communication.0x{0:x8}", notify))
        End If

				' A descriptor is included here if processing when batch measurement is finished is required.
        If (notify And &H10000) <> 0 Then
        End If
	End Sub

	#End Region

	#Region "Reading or writing settings for each program number event handler"

	''' <summary>
	''' Browse ("...") button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub _btnReferenceProgramFilePathEx_Click(sender As Object, e As EventArgs)
		If _openProgramFileDialog.ShowDialog() <> DialogResult.OK Then
			Return
		End If
		_txtProgramFilePath.Text = _openProgramFileDialog.FileName
	End Sub

	''' <summary>
	''' "Sending settings (PC -> LJ)" button clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Send settings in the file to the controller</remarks>
	Private Sub btnSetSettingEx_Click(sender As Object, e As EventArgs)
		If _txtProgramFilePath.Text.Length = 0 Then
			Return
		End If
		If File.Exists(_txtProgramFilePath.Text) = False Then
			Return
		End If

		' Parameter
		Dim setting As LJV7IF_TARGET_SETTING = GetSelectedProgramTargetSetting()
		Dim size As UInt32 = GetSelectedProgramDataSize()

		' Allocate buffer
        Dim receiveBuffer As Byte() = New Byte(CType(size - 1, Integer)) {}
		' Load program data
		Using fs As New FileStream(_txtProgramFilePath.Text, FileMode.Open)
			'It is a very simple validation method.
			If fs.Length <> size Then
				MessageBox.Show("File size is not match.")
				Return
			End If
			Using reader As New BinaryReader(fs)
				reader.Read(receiveBuffer, 0, CInt(size))
			End Using
		End Using

		Using pin As New PinnedObject(receiveBuffer)
			' Upload
			Dim [error] As UInteger = 0
			Dim rc As Rc = CType(NativeMethods.LJV7IF_SetSetting(Define.DEVICE_ID, CByte(SettingDepth.Running), setting, pin.Pointer, size, [error]), Rc)
			If Not CheckReturnCode(rc) Then
				Return
			End If
		End Using
	End Sub

	''' <summary>
	''' "Receiving settings (LJ -> PC)" button clicked.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Receive settings from the controller, and then write these settings to the file</remarks>
	Private Sub btnGetSettingEx_Click(sender As Object, e As EventArgs)
		If _txtProgramFilePath.Text.Length = 0 Then
			Return
		End If

		' Parameter
		Dim setting As LJV7IF_TARGET_SETTING = GetSelectedProgramTargetSetting()
		Dim size As UInt32 = GetSelectedProgramDataSize()
		' Environment:60, Common:12, Program number:10932
		' Allocate buffer
        Dim receiveBuffer As Byte() = New Byte(CType(size - 1, Integer)) {}
		Using pin As New PinnedObject(receiveBuffer)
			' Download
			Dim rc As Rc = CType(NativeMethods.LJV7IF_GetSetting(Define.DEVICE_ID, CByte(SettingDepth.Running), setting, pin.Pointer, size), Rc)
			If Not CheckReturnCode(rc) Then
				Return
			End If
		End Using
		' Save program data
		Using fs As New FileStream(_txtProgramFilePath.Text, FileMode.Create)
			Using writer As New BinaryWriter(fs)
				writer.Write(receiveBuffer)
			End Using
		End Using
	End Sub

	#End Region

	#End Region

	#Region "Method(for single-function)"

	''' <summary>
	''' Constructor
	''' </summary>
	Public Sub New()
		InitializeComponent()

		' Field initialization
		_sendCommand = SendCommand.None
		_deviceData = New DeviceData(NativeMethods.DeviceCount - 1) {}
		_measureDatas = New List(Of MeasureData)()
		_callback = New HighSpeedDataCallBack(AddressOf ReceiveHighSpeedData)
		_callbackOnlyCount = New HighSpeedDataCallBack(AddressOf CountProfileReceive)
		_deviceStatusLabels = New Label() {_lblDeviceStatus0, _lblDeviceStatus1, _lblDeviceStatus2, _lblDeviceStatus3, _lblDeviceStatus4, _lblDeviceStatus5}

		_receivedProfileCountLabels = New Label() {_lblReceiveProfileCount0, _lblReceiveProfileCount1, _lblReceiveProfileCount2, _lblReceiveProfileCount3, _lblReceiveProfileCount4, _lblReceiveProfileCount5}

		For i As Integer = 0 To NativeMethods.DeviceCount - 1
			_deviceData(i) = New DeviceData()
			_deviceStatusLabels(i).Text = _deviceData(i).GetStatusString()
		Next
		_profileInfo = New LJV7IF_PROFILE_INFO(NativeMethods.DeviceCount - 1) {}

		' Communication button comment setting
		SetCommandBtnString()

		' Control initialization
		_cmbMeasureX.DataSource = GetMeasureRangeList()
		_cmbReceivedBinning.DataSource = GetReceivedBiginning()
        _cmbCompressX.DataSource = GetCompressX()

        _cbxSelectProgram.SelectedIndex = 2

		_cmbMeasureX.SelectedValue = Define.MEASURE_RANGE_FULL
		_cmbReceivedBinning.SelectedValue = Define.RECEIVED_BINNING_OFF
		_cmbCompressX.SelectedValue = Define.COMPRESS_X_OFF

		' For use in profile export control
        '_txtboxProfileFilePath.Text = Directory.GetCurrentDirectory() & "\" & Define.DEFAULT_PROFILE_FILE_NAME
        '_txtboxProfileFilePath.SelectionStart = _txtboxProfileFilePath.Text.Length
	End Sub

	''' <summary>
	''' AnalyzeProfileData
	''' </summary>
	''' <param name="profileCount">Number of profiles that were read</param>
	''' <param name="profileInfo">Profile information structure</param>
	''' <param name="profileData">Acquired profile data</param>
	Private Sub AnalyzeProfileData(profileCount As Integer, ByRef profileInfo As LJV7IF_PROFILE_INFO, profileData__1 As Integer())
		Dim dataUnit As Integer = ProfileData.CalculateDataSize(profileInfo)
		AnalyzeProfileData(profileCount, profileInfo, profileData__1, 0, dataUnit)
	End Sub

	''' <summary>
	''' AnalyzeProfileData
	''' </summary>
	''' <param name="profileCount">Number of profiles that were read</param>
	''' <param name="profileInfo">Profile information structure</param>
	''' <param name="profileData">Acquired profile data</param>
	''' <param name="startProfileIndex">Start position of the profiles to copy</param>
	''' <param name="dataUnit">Profile data size</param>
	Private Sub AnalyzeProfileData(profileCount As Integer, ByRef profileInfo As LJV7IF_PROFILE_INFO, profileData__1 As Integer(), startProfileIndex As Integer, dataUnit As Integer)
		Dim readPropfileDataSize As Integer = ProfileData.CalculateDataSize(profileInfo)
		Dim tempRecvieProfileData As Integer() = New Integer(readPropfileDataSize - 1) {}

		' Profile data retention
		For i As Integer = 0 To profileCount - 1
			Array.Copy(profileData__1, (startProfileIndex + i * dataUnit), tempRecvieProfileData, 0, readPropfileDataSize)

			_deviceData(_currentDeviceId).ProfileData.Add(New ProfileData(tempRecvieProfileData, profileInfo))
		Next
	End Sub

	''' <summary>
	''' AnalyzeBatchData
	''' </summary>
	''' <param name="profileCount">Number of profiles that were read</param>
	''' <param name="profileInfo">Profile information structure</param>
	''' <param name="includeTimeData">Whether to include the time offset</param>
	''' <param name="batchData">Acquired batch profile data</param>
	''' <param name="startProfileIndex">Start position of the profiles to copy</param>
	Private Sub AnalyzeBatchData(profileCount As Integer, ByRef profileInfo As LJV7IF_PROFILE_INFO, includeTimeData As Boolean, batchData As Integer(), startProfileIndex As Integer)
		Dim offsetTimeSize As Integer = If((includeTimeData), 1, 0)
		Dim readPropfileDataSize As Integer = ProfileData.CalculateDataSize(profileInfo)
		Dim readMeasureDataSize As Integer = Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA) * CInt(NativeMethods.MeasurementDataCount)
		Dim dataUnit As Integer = offsetTimeSize + readPropfileDataSize + readMeasureDataSize \ Marshal.SizeOf(GetType(Integer))
		Dim tempRecvieProfileData As Integer() = New Integer(readPropfileDataSize - 1) {}
		Dim tempRecvieMeasureData As Byte() = New Byte(readMeasureDataSize - 1) {}
		Dim offestTime As UInteger = 0

		' Profile data retention
		For i As Integer = 0 To profileCount - 1
			If includeTimeData Then
				offestTime = CUInt(batchData(startProfileIndex + i * dataUnit))
			End If
			Array.Copy(batchData, (startProfileIndex + i * dataUnit + offsetTimeSize), tempRecvieProfileData, 0, readPropfileDataSize)
			_deviceData(_currentDeviceId).ProfileData.Add(New ProfileData(tempRecvieProfileData, profileInfo))

			'int test = (startProfileIndex + i * dataUnit + offsetTimeSize + readPropfileDataSize) * Marshal.SizeOf(typeof(int));
			Buffer.BlockCopy(batchData, (startProfileIndex + i * dataUnit + offsetTimeSize + readPropfileDataSize) * Marshal.SizeOf(GetType(Integer)), tempRecvieMeasureData, 0, readMeasureDataSize)
			_deviceData(_currentDeviceId).MeasureData.Add(New MeasureData(tempRecvieMeasureData))
			If includeTimeData Then
				_deviceData(_currentDeviceId).MeasureData(i).OffsetTime = offestTime
			End If
		Next
	End Sub

	''' <summary>
	''' Get the profile data size
	''' </summary>
	''' <returns>Data size of one profile (in units of bytes)</returns>
	Private Function GetOneProfileDataSize() As UInteger
		' Buffer size (in units of bytes)
		Dim retBuffSize As UInteger = 0

		' Basic size
		Dim basicSize As Integer = CInt(_cmbMeasureX.SelectedValue) \ CInt(_cmbReceivedBinning.SelectedValue)
        basicSize = CType(basicSize / CInt(_cmbCompressX.SelectedValue), Integer)

		' Number of headers
		retBuffSize += CUInt(basicSize) * (If(_rdbtnOneHead.Checked, 1UI, 2UI))

		' Envelope setting
		retBuffSize *= (If(_chkboxEnvelope.Checked, 2UI, 1UI))

		'in units of bytes
		retBuffSize *= CUInt(Marshal.SizeOf(GetType(UInteger)))

		' Sizes of the header and footer structures
		Dim profileHeader As New LJV7IF_PROFILE_HEADER()
		retBuffSize += CUInt(Marshal.SizeOf(profileHeader))
		Dim profileFooter As New LJV7IF_PROFILE_FOOTER()
		retBuffSize += CUInt(Marshal.SizeOf(profileFooter))

		Return retBuffSize
	End Function

	''' <summary>
	''' Method that is called from the DLL as a callback function
	''' </summary>
	''' <param name="buffer">Leading pointer of the received data</param>
	''' <param name="size">Size in units of bytes of one profile</param>
	''' <param name="count">Number of profiles</param>
	''' <param name="notify">Completion flag</param>
	''' <param name="user">Thread ID (value passed during initialization)</param>
	Public Shared Sub ReceiveHighSpeedData(buffer As IntPtr, size As UInteger, count As UInteger, notify As UInteger, user As UInteger)
        '' @Point
        '' Take care to only implement storing profile data in a thread save buffer in the callback function.
        '' As the thread used to call the callback function is the same as the thread used to receive data,
        '' the processing time of the callback function affects the speed at which data is received,
        '' and may stop communication from being performed properly in some environments.

        Dim profileSize As UInteger = CUInt(size \ Marshal.SizeOf(GetType(Integer)))
		Dim receiveBuffer As New List(Of Integer())()
        Dim bufferArray As Integer() = New Integer(CType(profileSize * count - 1, Integer)) {}
		Marshal.Copy(buffer, bufferArray, 0, CInt(profileSize * count))

		' Profile data retention
        For i As Integer = 0 To CType(count - 1, Integer)
            Dim oneProfile As Integer() = New Integer(CType(profileSize - 1, Integer)) {}
            Array.Copy(bufferArray, i * profileSize, oneProfile, 0, profileSize)
            receiveBuffer.Add(oneProfile)
        Next

		ThreadSafeBuffer.Add(CInt(user), receiveBuffer, notify)
	End Sub

	''' <summary>
	''' Method that is called from the DLL as a callback function
	''' </summary>
	''' <param name="buffer">Leading pointer of the received data</param>
	''' <param name="size">Size in units of bytes of one profile</param>
	''' <param name="count">Number of profiles</param>
	''' <param name="notify">Completion flag</param>
	''' <param name="user">Thread ID (value passed during initialization)</param>
	Public Shared Sub CountProfileReceive(buffer As IntPtr, size As UInteger, count As UInteger, notify As UInteger, user As UInteger)
        '' @Point
        '' Take care to only implement storing profile data in a thread save buffer in the callback function.
        '' As the thread used to call the callback function is the same as the thread used to receive data,
        '' the processing time of the callback function affects the speed at which data is received,
        '' and may stop communication from being performed properly in some environments.

        ThreadSafeBuffer.AddCount(CInt(user), count, notify)
	End Sub

	''' <summary>
	''' Get the ID of the selected device.
	''' </summary>
	''' <returns>Device ID</returns>
	Private Function GetSelectedDeviceId() As Integer
		For Each control As Control In _pnlDeviceId.Controls
			Dim rd As RadioButton = TryCast(control, RadioButton)
			If (rd Is Nothing) OrElse (Not rd.Checked) Then
				Continue For
			End If

			Return Convert.ToInt32(rd.Tag)
		Next

		Return -1
	End Function

	''' <summary>
	''' Get the measurement range.
	''' </summary>
	''' <returns>List used as the combo box data source</returns>
	Private Function GetMeasureRangeList() As List(Of DictionaryEntry)
		Dim list As New List(Of DictionaryEntry)()
		list.Add(New DictionaryEntry(Resources.SID_MEASURE_RANGE_FULL, Define.MEASURE_RANGE_FULL))
		list.Add(New DictionaryEntry(Resources.SID_MEASURE_RANGE_MIDDLE, Define.MEASURE_RANGE_MIDDLE))
		list.Add(New DictionaryEntry(Resources.SID_MEASURE_RANGE_SMALL, Define.MEASURE_RANGE_SMALL))
		Return list
	End Function

	''' <summary>
	''' Get the light reception characteristic binning list.
	''' </summary>
	''' <returns>List used as the combo box data source</returns>
	Private Function GetReceivedBiginning() As List(Of DictionaryEntry)
		Dim list As New List(Of DictionaryEntry)()
		list.Add(New DictionaryEntry(Resources.SID_RECEIVED_BINNING_OFF, Define.RECEIVED_BINNING_OFF))
		list.Add(New DictionaryEntry(Resources.SID_RECEIVED_BINNING_ON, Define.RECEIVED_BINNING_ON))
		Return list
	End Function

	''' <summary>
	''' Get the light reception characteristic binning list.
	''' </summary>
	''' <returns>List used as the combo box data source</returns>
	Private Function GetCompressX() As List(Of DictionaryEntry)
		Dim list As New List(Of DictionaryEntry)()
		list.Add(New DictionaryEntry(Resources.SID_COMPRESS_X_OFF, Define.COMPRESS_X_OFF))
		list.Add(New DictionaryEntry(Resources.SID_COMPRESS_X_2, Define.COMPRESS_X_2))
		list.Add(New DictionaryEntry(Resources.SID_COMPRESS_X_4, Define.COMPRESS_X_4))
		Return list
	End Function

	''' <summary>
	''' Communication button string setting
	''' </summary>
	Private Sub SetCommandBtnString()
		' Set the communication button comment here to match it with the log output string.
		_btnUsbOpen.Text = Resources.SID_USB_OPEN
		_btnGetTime.Text = Resources.SID_GET_TIME
		_btnGetVersion.Text = Resources.SID_GET_VERSION
		_btnFinalize.Text = Resources.SID_FINALIZE
		_btnInitialize.Text = Resources.SID_INITIALIZE
		_btnCommClose.Text = Resources.SID_COMM_CLOSE
		_btnEthernetOpen.Text = Resources.SID_ETHERNET_OPEN
		_btnGetActiveProgram.Text = Resources.SID_GET_ACTIVE_PROGRAM
		_btnHighSpeedDataCommunicationFinalize.Text = Resources.SID_HIGH_SPEED_DATA_COMMUNICATION_FINALIZE
		_btnStopHighSpeedDataCommunication.Text = Resources.SID_STOP_HIGH_SPEED_DATA_COMMUNICATION
		_btnStartHighSpeedDataCommunication.Text = Resources.SID_START_HIGH_SPEED_DATA_COMMUNICATION
		_btnPreStartHighSpeedDataCommunication.Text = Resources.SID_PRE_START_HIGH_SPEED_DATA_COMMUNICATION
		_btnHighSpeedDataUsbCommunicationInitalize.Text = Resources.SID_HIGH_SPEED_DATA_USB_COMMUNICATION_INITALIZE
		_btnHighSpeedDataEthernetCommunicationInitalize.Text = Resources.SID_HIGH_SPEED_DATA_ETHERNET_COMMUNICATION_INITALIZE
		_btnRewriteTemporarySetting.Text = Resources.SID_REWRITE_TEMPORARY_SETTING
		_btnGetStorageBatchProfile.Text = Resources.SID_GET_STORAGE_BATCH_PROFILE
		_btnGetStorageProfile.Text = Resources.SID_GET_STORAGE_PROFILE
		_btnGetStorageData.Text = Resources.SID_GET_STORAGE_DATA
		_btnGetStorageStatus.Text = Resources.SID_GET_STORAGE_STATUS
		_btnStopStorage.Text = Resources.SID_STOP_STORAGE
		_btnStartStorage.Text = Resources.SID_START_STORAGE
		_btnGetBatchProfileAdvance.Text = Resources.SID_GET_BATCH_PROFILE_ADVANCE
		_btnGetProfileAdvance.Text = Resources.SID_GET_PROFILE_ADVANCE
		_btnGetBatchProfile.Text = Resources.SID_GET_BATCH_PROFILE
		_btnGetProfile.Text = Resources.SID_GET_PROFILE
		_btnGetMeasurementValue.Text = Resources.SID_GET_MEASUREMENT_VALUE
		_btnChangeActiveProgram.Text = Resources.SID_CHANGE_ACTIVE_PROGRAM
		_btnSetTime.Text = Resources.SID_SET_TIME
		_btnUpdataSetting.Text = Resources.SID_UPDATA_SETTING
		_btnCheckMemoryAccess.Text = Resources.SID_CHECK_MEMORY_ACCESS
		_btnSetSetting.Text = Resources.SID_SET_SETTING
		_btnGetSetting.Text = Resources.SID_GET_SETTING
		_btnClearMemory.Text = Resources.SID_CLEAR_MEMORY
		_btnReset.Text = Resources.SID_RESET
		_btnTiming.Text = Resources.SID_TIMING
		_btnAutoZero.Text = Resources.SID_AUTO_ZERO
		_btnStopMeasure.Text = Resources.SID_STOP_MEASURE
		_btnStartMeasure.Text = Resources.SID_START_MEASURE
		_btnTrigger.Text = Resources.SID_TRIGGER
		_btnClearError.Text = Resources.SID_CLEAR_ERROR
		_btnGetError.Text = Resources.SID_GET_ERROR
		_btnRetrunToFactorySetting.Text = Resources.SID_RETRUN_TO_FACTORY_SETTING
		_btnRebootController.Text = Resources.SID_REBOOT_CONTROLLER
	End Sub

	#Region "Log output"

	''' <summary>
	''' Log output
	''' </summary>
	''' <param name="strLog">Output log</param>
	Private Sub AddLog(strLog As String)
		_txtboxLog.AppendText(strLog & Environment.NewLine)
		_txtboxLog.SelectionStart = _txtboxLog.Text.Length
		_txtboxLog.Focus()
		_txtboxLog.ScrollToCaret()
	End Sub

	''' <summary>
	''' Communication command result log output
	''' </summary>
	''' <param name="rc">Return code from the DLL</param>
	''' <param name="commandName">Command name to be output in the log</param>
	Private Sub AddLogResult(rc__1 As Integer, commandName As String)
		If rc__1 = CInt(Rc.Ok) Then
			AddLog(String.Format(Resources.SID_LOG_FORMAT, commandName, Resources.SID_RESULT_OK, rc__1))
		Else
			AddLog(String.Format(Resources.SID_LOG_FORMAT, commandName, Resources.SID_RESULT_NG, rc__1))
			AddErrorLog(rc__1)
		End If
	End Sub

	''' <summary>
	''' Error log output
	''' </summary>
	''' <param name="rc">Return code</param>
	Private Sub AddErrorLog(rc As Integer)
		If rc < &H8000 Then
			' Common return code
			CommonErrorLog(rc)
		Else
			' Individual return code
			IndividualErrorLog(rc)
		End If
	End Sub

	''' <summary>
	''' Add Error
	''' </summary>
	''' <param name="dwError"></param>
	Private Sub AddError(dwError As UInteger)
		_txtboxLog.AppendText("  ErrorCode : 0x" & dwError.ToString("x8") & Environment.NewLine)
		_txtboxLog.SelectionStart = _txtboxLog.Text.Length
		_txtboxLog.Focus()
		_txtboxLog.ScrollToCaret()
	End Sub

	''' <summary>
	''' Common return code log output
	''' </summary>
	''' <param name="rc">Return code</param>
	Private Sub CommonErrorLog(rc__1 As Integer)
		Select Case rc__1
			Case CInt(Rc.Ok)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_OK))
				Exit Select
			Case CInt(Rc.ErrOpenDevice)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_OPEN_DEVICE))
				Exit Select
			Case CInt(Rc.ErrNoDevice)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_NO_DEVICE))
				Exit Select
			Case CInt(Rc.ErrSend)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_SEND))
				Exit Select
			Case CInt(Rc.ErrReceive)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_RECEIVE))
				Exit Select
			Case CInt(Rc.ErrTimeout)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_TIMEOUT))
				Exit Select
			Case CInt(Rc.ErrParameter)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_PARAMETER))
				Exit Select
			Case CInt(Rc.ErrNomemory)
				AddLog(String.Format(Resources.SID_RC_FORMAT, Resources.SID_RC_ERR_NOMEMORY))
				Exit Select
			Case Else
				AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc__1))
				Exit Select
		End Select
	End Sub

	''' <summary>
	''' Individual return code log output
	''' </summary>
	''' <param name="rc">Return code</param>
	Private Sub IndividualErrorLog(rc As Integer)
		Select Case _sendCommand
			Case SendCommand.RebootController
				If True Then
					Select Case rc
						Case &H80a0
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Accessing the save area"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.Trigger
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The trigger mode is not [external trigger]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.StartMeasure, SendCommand.StopMeasure
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Batch measurements are off"))
							Exit Select
						Case &H80a0
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Batch measurement start processing could not be performed because the REMOTE terminal is off or the LASER_OFF terminal is on"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.AutoZero, SendCommand.Timing, SendCommand.Reset, SendCommand.GetMeasurementValue
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [high-speed (profile only)]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.ChangeActiveProgram
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The change program setting is [terminal]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.GetProfile, SendCommand.GetProfileAdvance
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [advanced (with OUT measurement)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Batch measurements on and profile compression (time axis) off"))
							Exit Select
						Case &H80a0
							AddLog(String.Format(Resources.SID_RC_FORMAT, "No profile data"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.GetBatchProfile, SendCommand.GetBatchProfileAdvance
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [advanced (with OUT measurement)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Not [batch measurements on and profile compression (time axis) off]"))
							Exit Select
						Case &H80a0
							AddLog(String.Format(Resources.SID_RC_FORMAT, "No batch data (batch measurements not run even once)"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select

			Case SendCommand.StartStorage, SendCommand.StopStorage
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [high-speed (profile only)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Storage target setting is [OFF] (no storage)"))
							Exit Select
						Case &H8082
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The storage condition setting is not [terminal/command]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.GetStorageStatus
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [high-speed (profile only)]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.GetStorageData
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [high-speed (profile only)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The storage target setting is not [OUT value]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.GetStorageProfile
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [high-speed (profile only)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The storage target setting is not profile, or batch measurements on and profile compression (time axis) off"))
							Exit Select
						Case &H8082
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Batch measurements on and profile compression (time axis) off"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.GetStorageBatchProfile
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [high-speed (profile only)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The storage target setting is not profile, or batch measurements on and profile compression (time axis) off"))
							Exit Select
						Case &H8082
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Not [batch measurements on and profile compression (time axis) off]"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.HighSpeedDataUsbCommunicationInitalize, SendCommand.HighSpeedDataEthernetCommunicationInitalize
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [advanced (with OUT measurement)]"))
							Exit Select
						Case &H80a1
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Already performing high-speed communication error (for high-speed communication)"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case SendCommand.PreStartHighSpeedDataCommunication, SendCommand.StartHighSpeedDataCommunication
				If True Then
					Select Case rc
						Case &H8080
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The operation mode is [advanced (with OUT measurement)]"))
							Exit Select
						Case &H8081
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The data specified as the send start position does not exist"))
							Exit Select
						Case &H80a0
							AddLog(String.Format(Resources.SID_RC_FORMAT, "A high-speed data communication connection was not established"))
							Exit Select
						Case &H80a1
							AddLog(String.Format(Resources.SID_RC_FORMAT, "Already performing high-speed communication error (for high-speed communication)"))
							Exit Select
						Case &H80a4
							AddLog(String.Format(Resources.SID_RC_FORMAT, "The send target data was cleared"))
							Exit Select
						Case Else
							AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
							Exit Select
					End Select
				End If
				Exit Select
			Case Else
				AddLog(String.Format(Resources.SID_NOT_DEFINE_FROMAT, rc))
				Exit Select
		End Select
	End Sub

	#End Region


	#End Region

	#Region "Method(for combination-function)"
	''' <summary>
	''' Create program download/upload parameters depends on combobox selection.
	''' </summary>
	''' <returns>Setting item structure</returns>
	Private Function GetSelectedProgramTargetSetting() As LJV7IF_TARGET_SETTING
		Dim setting As LJV7IF_TARGET_SETTING
		setting.byCategory = &Hff
		' means all parameter
		setting.byItem = &H0
		setting.reserve = 0
		setting.byTarget1 = 0
		' This is used when you want to set a setting item in greater detail
		setting.byTarget2 = 0
		setting.byTarget3 = 0
		setting.byTarget4 = 0

		If _cbxSelectProgram.SelectedIndex = 0 Then
			setting.byType = CByte(SettingType.Environment)
		ElseIf _cbxSelectProgram.SelectedIndex = 1 Then
			setting.byType = CByte(SettingType.Common)
		Else
			setting.byType = CByte(CType(CInt(SettingType.Program00) + (_cbxSelectProgram.SelectedIndex - 2), SettingType))
		End If

		Return setting
	End Function


	''' <summary>
	''' GetSelectedProgramDataSize
	''' </summary>
	''' <returns>Program settingsサイズ</returns>
	Private Function GetSelectedProgramDataSize() As UInt32
		If _cbxSelectProgram.SelectedIndex = 0 Then
			Return NativeMethods.EnvironmentSettingSize
		End If
		If _cbxSelectProgram.SelectedIndex = 1 Then
			Return NativeMethods.CommonSettingSize
		End If
		Return NativeMethods.ProgramSettingSize
	End Function

	''' <summary>
	''' Return code check
	''' </summary>
	''' <param name="rc">Return code</param>
	''' <returns>Is the return code OK?</returns>
	''' <remarks>If the return code is not OK, display a message and return false.</remarks>
	Private Function CheckReturnCode(rc__1 As Rc) As Boolean
		If rc__1 = Rc.Ok Then
			Return True
		End If
		MessageBox.Show(Me, String.Format("Error: 0x{0,8:x}", rc__1), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.[Error])
		Return False
	End Function

	''' <summary>
	''' Output profile data to a file.
	''' </summary>
	''' <param name="profileDatas">Profile data to output</param>
	''' <param name="savePath">Full path to the file to save</param>
	''' <remarks>Output data in TSV format.</remarks>
	Private Shared Sub SaveProfile(profileDatas As List(Of ProfileData), savePath As String)
		Try
			' Save the profile
			Using sw As New StreamWriter(savePath, False, Encoding.GetEncoding("utf-16"))
				' X-axis output
				sw.WriteLine(ProfileData.GetXPosString(profileDatas(0).ProfInfo))

				' Output the data of each profile
				For Each profile As ProfileData In profileDatas
					Dim sb As New StringBuilder()
					Dim dataCount As Integer = profile.ProfDatas.Length

					For i As Integer = 0 To dataCount - 1
						sb.AppendFormat("{0}" & vbTab, profile.ProfDatas(i))
					Next
					sw.WriteLine(sb)
				Next
			End Using
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub

	#End Region

End Class
