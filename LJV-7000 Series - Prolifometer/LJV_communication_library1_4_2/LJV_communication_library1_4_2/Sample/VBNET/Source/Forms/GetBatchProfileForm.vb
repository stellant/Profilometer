'----------------------------------------------------------------------------- 
' <copyright file="GetBatchProfileForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class GetBatchProfileForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' High-speed mode get profile request structure (batch measurement: on)
		''' </summary>
		Private _req As LJV7IF_GET_BATCH_PROFILE_REQ
		#End Region

		#Region "Property"
		''' <summary>
		''' High-speed mode get profile request structure (batch measurement: on)
		''' </summary>
		Public ReadOnly Property Req() As LJV7IF_GET_BATCH_PROFILE_REQ
			Get
				Return _req
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
					_req.byTargetBank = Convert.ToByte(_txtboxTargetBank.Text, 16)
					_req.byPosMode = Convert.ToByte(_txtboxPosMode.Text, 16)
					_req.dwGetBatchNo = Convert.ToUInt32(_txtboxGetBatchNo.Text)
					_req.dwGetProfNo = Convert.ToUInt32(_txtboxGetProfNo.Text)
					_req.byGetProfCnt = Convert.ToByte(_txtboxGetProfCnt.Text)
					_req.byErase = Convert.ToByte(_txtboxErase.Text)
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
		Public Sub New()
			InitializeComponent()

			' Field initialization
			_req = New LJV7IF_GET_BATCH_PROFILE_REQ()
		End Sub
		#End Region
	End Class
End Namespace
