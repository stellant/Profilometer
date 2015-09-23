'----------------------------------------------------------------------------- 
' <copyright file="TimeForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class TimeForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' The date and time to set
		''' </summary>
		Private _time As LJV7IF_TIME
		#End Region

		#Region "Property"
		''' <summary>
		''' The date and time to set
		''' </summary>
		Public ReadOnly Property Time() As LJV7IF_TIME
			Get
				Return _time
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
					_time.byYear = Convert.ToByte(_txtboxYear.Text)
					_time.byMonth = Convert.ToByte(_txtboxMonth.Text)
					_time.byDay = Convert.ToByte(_txtboxDay.Text)
					_time.byHour = Convert.ToByte(_txtboxHour.Text)
					_time.byMinute = Convert.ToByte(_txtboxMinute.Text)
					_time.bySecond = Convert.ToByte(_txtboxSecond.Text)
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
			_time = New LJV7IF_TIME()
		End Sub
		#End Region
	End Class
End Namespace
