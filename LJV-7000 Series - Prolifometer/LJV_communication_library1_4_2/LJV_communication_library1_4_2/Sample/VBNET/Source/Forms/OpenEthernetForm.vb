'----------------------------------------------------------------------------- 
' <copyright file="OpenEthernetForm.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Forms
	Public Partial Class OpenEthernetForm
		Inherits Form
		#Region "Field"
		''' <summary>
		''' Ethernet communication settings
		''' </summary>
		Private _ethernetConfig As LJV7IF_ETHERNET_CONFIG
		#End Region

		#Region "Property"
		''' <summary>
		''' Ethernet communication settings
		''' </summary>
		Public Property EthernetConfig() As LJV7IF_ETHERNET_CONFIG
			Get
				Return _ethernetConfig
			End Get
			Set
				_ethernetConfig = value
				If _ethernetConfig.abyIpAddress IsNot Nothing Then
					_txtboxIpFirstSegment.Text = _ethernetConfig.abyIpAddress(0).ToString()
					_txtboxIpSecondSegment.Text = _ethernetConfig.abyIpAddress(1).ToString()
					_txtboxIpThirdSegment.Text = _ethernetConfig.abyIpAddress(2).ToString()
					_txtboxIpFourthSegment.Text = _ethernetConfig.abyIpAddress(3).ToString()
				End If
				_txtboxPort.Text = _ethernetConfig.wPortNo.ToString()
			End Set
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
					_ethernetConfig.abyIpAddress = New Byte() {Convert.ToByte(_txtboxIpFirstSegment.Text), Convert.ToByte(_txtboxIpSecondSegment.Text), Convert.ToByte(_txtboxIpThirdSegment.Text), Convert.ToByte(_txtboxIpFourthSegment.Text)}
					_ethernetConfig.wPortNo = Convert.ToUInt16(_txtboxPort.Text)
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
			_ethernetConfig = New LJV7IF_ETHERNET_CONFIG()
		End Sub

		''' <summary>
		''' Control display setting
		''' </summary>
		Protected Overridable Sub SetControlVisible(isVisible As Boolean)
			_lblDescription.Visible = isVisible
			_lblIpAddress.Visible = isVisible
			_txtboxIpFirstSegment.Visible = isVisible
			_txtboxIpSecondSegment.Visible = isVisible
			_txtboxIpThirdSegment.Visible = isVisible
			_txtboxIpFourthSegment.Visible = isVisible
			_lblPort.Visible = isVisible
			_txtboxPort.Visible = isVisible
		End Sub
		#End Region

	End Class
End Namespace
