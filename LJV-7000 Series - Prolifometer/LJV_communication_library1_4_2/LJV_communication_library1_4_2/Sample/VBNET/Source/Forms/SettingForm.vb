'----------------------------------------------------------------------------- 
' <copyright file="SettingForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class SettingForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Specify to what level the sent settings will be reflected (LJV7IF_SETTING_DEPTH).
		''' </summary>
		Private _depth As Byte

		''' <summary>
		''' Identify the item that is the target to send.
		''' </summary>
		Private _targetSetting As LJV7IF_TARGET_SETTING

		''' <summary>
		''' Specify the buffer that stores the setting data to send.
		''' </summary>
		Private _data As Byte()
		#End Region

		#Region "Property"
		''' <summary>
		''' Specify to what level the sent settings will be reflected (LJV7IF_SETTING_DEPTH).
		''' </summary>
		Public ReadOnly Property Depth() As Byte
			Get
				Return _depth
			End Get
		End Property

		''' <summary>
		''' Identify the item that is the target to send.
		''' </summary>
		Public ReadOnly Property TargetSetting() As LJV7IF_TARGET_SETTING
			Get
				Return _targetSetting
			End Get
		End Property
		Public ReadOnly Property DataLength() As Integer
			Get
				Return Convert.ToInt32(_txtDataLength.Text)
			End Get
		End Property
		''' <summary>
		''' Specify the buffer that stores the setting data to send.
		''' </summary>
		Public ReadOnly Property Data() As Byte()
			Get
				Return _data
			End Get
		End Property
		#End Region

		#Region "Event"
		Private Sub SettingForm_Load(sender As Object, e As EventArgs)
			_txtboxDepth.Text = Convert.ToString(_depth, 16)
			_txtboxType.Text = Convert.ToString(_targetSetting.byType, 16)
			_txtboxCategor.Text = Convert.ToString(_targetSetting.byCategory, 16)
			_txtboxItem.Text = Convert.ToString(_targetSetting.byItem, 16)
			_txtboxTarget1.Text = Convert.ToString(_targetSetting.byTarget1, 16)
			_txtboxTarget2.Text = Convert.ToString(_targetSetting.byTarget2, 16)
			_txtboxTarget3.Text = Convert.ToString(_targetSetting.byTarget3, 16)
			_txtboxTarget4.Text = Convert.ToString(_targetSetting.byTarget4, 16)
			_txtboxParameter.Text = Convert.ToString(_data(0), 16)
		End Sub

		''' <summary>
		''' Close start event
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnClosing(e As CancelEventArgs)
			If DialogResult = DialogResult.OK Then
				Try
					_depth = Convert.ToByte(_txtboxDepth.Text, 16)
					_targetSetting.byType = Convert.ToByte(_txtboxType.Text, 16)
					_targetSetting.byCategory = Convert.ToByte(_txtboxCategor.Text, 16)
					_targetSetting.byItem = Convert.ToByte(_txtboxItem.Text, 16)
					_targetSetting.byTarget1 = Convert.ToByte(_txtboxTarget1.Text, 16)
					_targetSetting.byTarget2 = Convert.ToByte(_txtboxTarget2.Text, 16)
					_targetSetting.byTarget3 = Convert.ToByte(_txtboxTarget3.Text, 16)
					_targetSetting.byTarget4 = Convert.ToByte(_txtboxTarget4.Text, 16)

					Dim trimChars As Char() = New Char() {" "C, ","C}
					Dim trimStr As String = _txtboxParameter.Text.Trim(trimChars)
					If trimStr.Length > 0 Then
						Dim aSrc As String() = trimStr.Split(","C)
						If aSrc.Length > 0 Then
							_data = Array.ConvertAll(Of String, Byte)(aSrc, Function(s As String) Convert.ToByte(s, 16))
						End If
					End If
					Array.Resize(_data, Convert.ToInt32(_txtDataLength.Text))
				Catch ex As Exception
					MessageBox.Show(Me, ex.Message)
					e.Cancel = True
					Return
				End Try
			End If

			MyBase.OnClosing(e)
		End Sub
		#End Region

		#Region "Method"
		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="isSetSetting">True when sending settings, false when getting settings</param>
		Public Sub New(isSetSetting As Boolean)
			InitializeComponent()

			' Control display control
			_txtboxParameter.Visible = isSetSetting
			_lblParameter.Visible = isSetSetting

			' Settings that change the sampling period of the running area to "100 Hz"
			_depth = &H1
			' Setting depth: Running settings area
			_targetSetting.byType = &H10
			' Setting type: Program number 0
			_targetSetting.byCategory = &H0
			' Category: Trigger settings
			_targetSetting.byItem = &H2
			' Setting item: Sampling period
			_targetSetting.byTarget1 = &H0
			' Setting target 1: None
			_targetSetting.byTarget2 = &H0
			' Setting target 2: None
			_targetSetting.byTarget3 = &H0
			' Setting target 3: None
			_targetSetting.byTarget4 = &H0
			' Setting target 4: None

            _data = New Byte(CType(NativeMethods.ProgramSettingSize - 1, Integer)) {}
			_data(0) = CByte(&H3)
		End Sub
		#End Region

	End Class
End Namespace
