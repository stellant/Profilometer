'----------------------------------------------------------------------------- 
' <copyright file="GetStorageBatchProfileForm.c" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class GetStorageBatchProfileForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Get batch profile storage request structure
		''' </summary>
		Private _req As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ
		#End Region

		#Region "Property"
		''' <summary>
		''' Get batch profile storage request structure Property
		''' </summary>
		Public ReadOnly Property Req() As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ
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
					_req.dwSurface = Convert.ToUInt32(_txtboxSurface.Text)
					_req.dwGetBatchNo = Convert.ToUInt32(_txtboxGetBatchNo.Text)
					_req.dwGetBatchTopProfNo = Convert.ToUInt32(_txtboxGetBatchTopProfNo.Text)
					_req.byGetProfCnt = Convert.ToByte(_txtboxGetProfCnt.Text)
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

			_req = New LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ()
		End Sub
		#End Region
	End Class
End Namespace
