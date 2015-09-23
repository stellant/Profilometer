'----------------------------------------------------------------------------- 
' <copyright file="ProgressForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

#Region "Enum"
''' <summary>
''' Processing status
''' </summary>
Public Enum Status
	Communicating = 0
	Saving
End Enum
#End Region

Public Partial Class ProgressForm
	Inherits Form
	#Region "Field"
	''' <summary>
	''' Processing status
	''' </summary>
	Private _status As Status
	#End Region

	#Region "Properety"
	''' <summary>
	''' Processing status
	''' </summary>
	Public Property Status() As Status
		Get
			Return _status
		End Get
		Set
			_status = value
			Select Case _status
				Case Status.Communicating
					_lblStatus.Text = "Communicating"
					Exit Select
				Case Status.Saving
					_lblStatus.Text = "Saving the file"
					Exit Select
				Case Else
					Return
			End Select
		End Set
	End Property
	#End Region

	#Region "Constructor"
	''' <summary>
	''' Constructor
	''' </summary>
	Public Sub New()
		InitializeComponent()
		_status = Status.Communicating
	End Sub
	#End Region
End Class
