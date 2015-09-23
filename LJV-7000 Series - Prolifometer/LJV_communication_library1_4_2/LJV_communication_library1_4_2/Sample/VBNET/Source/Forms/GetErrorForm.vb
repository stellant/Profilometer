'----------------------------------------------------------------------------- 
' <copyright file="GetErrorForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class GetErrorForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Maximum number of system errors to receive
		''' </summary>
		Private _rcvMax As Byte
		#End Region

		#Region "Property"

		''' <summary>
		''' Specify the maximum amount of system error information to receive.
		''' </summary>
		Public ReadOnly Property RcvMax() As Byte
			Get
				Return _rcvMax
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
					_rcvMax = Convert.ToByte(_txtboxErrCnt.Text)
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
			_rcvMax = 0
		End Sub
		#End Region
	End Class
End Namespace
