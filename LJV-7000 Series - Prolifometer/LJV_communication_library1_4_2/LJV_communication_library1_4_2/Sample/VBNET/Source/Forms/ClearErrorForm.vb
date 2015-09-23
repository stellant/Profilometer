'----------------------------------------------------------------------------- 
' <copyright file="ClearErrorForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class ClearErrorForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Error code of the error to clear
		''' </summary>
		Private _errCode As Short
		#End Region

		#Region "Property"
		''' <summary>
		''' The error code for the error you wish to clear
		''' </summary>
		Public ReadOnly Property ErrCode() As Short
			Get
				Return _errCode
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
					_errCode = Convert.ToInt16(_txtboxErrCode.Text, 16)
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
			_errCode = 0
		End Sub
		#End Region

		Private Sub _btnOk_Click(sender As Object, e As EventArgs)

		End Sub
	End Class
End Namespace
