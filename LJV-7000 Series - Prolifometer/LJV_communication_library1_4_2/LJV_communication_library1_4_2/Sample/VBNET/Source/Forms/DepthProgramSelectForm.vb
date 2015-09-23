'----------------------------------------------------------------------------- 
' <copyright file="DepthProgramSelectForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class DepthProgramSelectForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Level
		''' </summary>
		Private _depth As Byte

		''' <summary>
		''' Specified program
		''' </summary>
		Private _target As Byte
		#End Region

		#Region "Property"

		''' <summary>
		''' Specify to what level the settings written for modification will be reflected (LJ7IF_SETTING_DEPTH).
		''' </summary>
		Public ReadOnly Property Depth() As Byte
			Get
				Return _depth
			End Get
		End Property

		''' <summary>
		''' Specify the setting that is the target for initialization (LJ7IF_INIT_SETTING_TARGET).
		''' </summary>
		Public ReadOnly Property Target() As Byte
			Get
				Return _target
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
					_depth = Convert.ToByte(_txtboxDepth.Text, 16)
					_target = Convert.ToByte(_txtboxTargetProgram.Text, 16)
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
		''' <param name="isDepthVisible">Level control display setting</param>
		''' <param name="isTargetVisible">Specified program control display setting</param>
		Public Sub New(isDepthVisible As Boolean, isTargetVisible As Boolean)
			InitializeComponent()

			' Field initialization
			_depth = 0
			_target = 0

			' Control display control
			_lblHexDepth.Visible = isDepthVisible
			_txtboxDepth.Visible = isDepthVisible
			_lblDepth.Visible = isDepthVisible
			_lblDepthDescription.Visible = isDepthVisible
			_lblHexTarget.Visible = isTargetVisible
			_txtboxTargetProgram.Visible = isTargetVisible
			_lblTargetProgram.Visible = isTargetVisible
			_lblTargetDescription.Visible = isTargetVisible
		End Sub
		#End Region
	End Class
End Namespace
