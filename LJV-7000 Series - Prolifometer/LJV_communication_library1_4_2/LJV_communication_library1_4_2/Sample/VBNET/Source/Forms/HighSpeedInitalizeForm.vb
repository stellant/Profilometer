'----------------------------------------------------------------------------- 
' <copyright file="HighSpeedInitalizeForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class HighSpeedInitalizeForm
		Inherits OpenEthernetForm
		#Region "Field"
		''' <summary>
		''' Port number (high speed)
		''' </summary>
		Private _highSpeedPortNo As UShort

		''' <summary>
		''' Number of profiles
		''' </summary>
		Private _profileCnt As UInteger
		#End Region

		#Region "Property"
		''' <summary>
		''' Port number (high speed)
		''' </summary>
		Public ReadOnly Property HighSpeedPortNo() As UShort
			Get
				Return _highSpeedPortNo
			End Get
		End Property

		''' <summary>
		''' Number of profiles
		''' </summary>
		Public ReadOnly Property ProfileCnt() As UInteger
			Get
				Return _profileCnt
			End Get
		End Property
		#End Region

		#Region "Event"
		''' <summary>
		''' Close start event
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnClosing(e As CancelEventArgs)
			If DialogResult = DialogResult.OK Then
				Try
					_highSpeedPortNo = Convert.ToUInt16(_txtboxPortHighSpeed.Text)
					_profileCnt = Convert.ToUInt32(_txtboxProfileCnt.Text)
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
		''' <param name="isEtherVisible">Ethernet settings display setting</param>
		Public Sub New(isEtherVisible As Boolean)
			InitializeComponent()

			' Field initialization
			_highSpeedPortNo = 0
			_profileCnt = 0

			' Control display setting
			SetControlVisible(isEtherVisible)
		End Sub

		''' <summary>
		''' Control display setting
		''' </summary>
		''' <param name="isVisible"></param>
		Protected Overrides Sub SetControlVisible(isVisible As Boolean)
			_lblPortHighSpeed.Visible = isVisible
			_txtboxPortHighSpeed.Visible = isVisible

			MyBase.SetControlVisible(isVisible)
		End Sub
		#End Region
	End Class
End Namespace
