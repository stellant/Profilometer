'----------------------------------------------------------------------------- 
' <copyright file="PreStartHighSpeedForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class PreStartHighSpeedForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' High-speed communication start request structure
		''' </summary>
		Private _req As LJV7IF_HIGH_SPEED_PRE_START_REQ
		#End Region

		#Region "Property"
		''' <summary>
		''' High-speed communication start request structure
		''' </summary>
		Public ReadOnly Property Req() As LJV7IF_HIGH_SPEED_PRE_START_REQ
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
					_req.bySendPos = Convert.ToByte(_txtboxSendPos.Text)
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
			_req = New LJV7IF_HIGH_SPEED_PRE_START_REQ()
		End Sub
		#End Region
	End Class
End Namespace
