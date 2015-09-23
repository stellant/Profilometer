'----------------------------------------------------------------------------- 
' <copyright file="OutSelectForm" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class OutSelectForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Auto zero on request and off request
		''' </summary>
		Private _onOff As Byte

		''' <summary>
		''' The bits of the parameter are used to specify the processing target OUTs.
		''' </summary>
		Private _out As UInteger
		#End Region

		#Region "Property"
		''' <summary>
		''' Other than 0: auto zero on request, 0: auto zero off request
		''' </summary>
		Public ReadOnly Property OnOff() As Byte
			Get
				Return _onOff
			End Get
		End Property

		''' <summary>
		''' The bits of the parameter are used to specify the processing target OUTs.
		''' </summary>
		Public ReadOnly Property Out() As UInteger
			Get
				Return _out
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
					_onOff = Convert.ToByte(_txtboxOnOff.Text)
					_out += If(_chkboxBit1.Checked, CUInt(1), CUInt(0))
					_out += If(_chkboxBit2.Checked, CUInt(1 << 1), CUInt(0))
					_out += If(_chkboxBit3.Checked, CUInt(1 << 2), CUInt(0))
					_out += If(_chkboxBit4.Checked, CUInt(1 << 3), CUInt(0))
					_out += If(_chkboxBit5.Checked, CUInt(1 << 4), CUInt(0))
					_out += If(_chkboxBit6.Checked, CUInt(1 << 5), CUInt(0))
					_out += If(_chkboxBit7.Checked, CUInt(1 << 6), CUInt(0))
					_out += If(_chkboxBit8.Checked, CUInt(1 << 7), CUInt(0))
					_out += If(_chkboxBit9.Checked, CUInt(1 << 8), CUInt(0))
					_out += If(_chkboxBit10.Checked, CUInt(1 << 9), CUInt(0))
					_out += If(_chkboxBit11.Checked, CUInt(1 << 10), CUInt(0))
					_out += If(_chkboxBit12.Checked, CUInt(1 << 11), CUInt(0))
					_out += If(_chkboxBit13.Checked, CUInt(1 << 12), CUInt(0))
					_out += If(_chkboxBit14.Checked, CUInt(1 << 13), CUInt(0))
					_out += If(_chkboxBit15.Checked, CUInt(1 << 14), CUInt(0))
					_out += If(_chkboxBit16.Checked, CUInt(1 << 15), CUInt(0))
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
		Public Sub New(isOnOffVisible As Boolean)
			InitializeComponent()

			' Field initialization
			_onOff = 0
			_out = 0

			' Control display control
			_lblOnOff.Visible = isOnOffVisible
			_txtboxOnOff.Visible = isOnOffVisible
			_lblOnOffDescription.Visible = isOnOffVisible
		End Sub
		#End Region
	End Class
End Namespace
