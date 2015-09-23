'----------------------------------------------------------------------------- 
' <copyright file="DeviceData.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Collections.Generic
Imports System.Text

Namespace Datas
	#Region "Enum"
	''' <summary>Device communication state</summary>
	Public Enum DeviceStatus
		NoConnection = 0
		Usb
		UsbFast
		Ethernet
		EthernetFast
	End Enum
	#End Region

	''' <summary>
	''' Device data class
	''' </summary>
	Public Class DeviceData
		#Region "Field"
		''' <summary>Connection state</summary>
		Private _status As DeviceStatus = DeviceStatus.NoConnection
		''' <summary>Ethernet settings</summary>
		Private _ethernetConfig As LJV7IF_ETHERNET_CONFIG
		''' <summary>Profile data</summary>
		Private _profileData As List(Of ProfileData)
		''' <summary>Measurement data</summary>
		Private _measureData As List(Of MeasureData)
		#End Region

		#Region "Property"
		''' <summary>
		''' Status property
		''' </summary>
		Public Property Status() As DeviceStatus
			Get
				Return _status
			End Get
			Set
				_profileData.Clear()
				_ethernetConfig = New LJV7IF_ETHERNET_CONFIG()
				_status = value
			End Set
		End Property

		Public Property EthernetConfig() As LJV7IF_ETHERNET_CONFIG
			Get
				Return _ethernetConfig
			End Get
			Set
				_ethernetConfig = value
			End Set
		End Property
		Public Property ProfileData() As List(Of ProfileData)
			Get
				Return _profileData
			End Get
			Set
				_profileData = value
			End Set
		End Property
		Public Property MeasureData() As List(Of MeasureData)
			Get
				Return _measureData
			End Get
			Set
				_measureData = value
			End Set
		End Property
		#End Region

		#Region "Constructor"
		''' <summary>
		''' Constructor
		''' </summary>
		Public Sub New()
			_ethernetConfig = New LJV7IF_ETHERNET_CONFIG()
			_profileData = New List(Of ProfileData)()
			_measureData = New List(Of MeasureData)()
		End Sub
		#End Region

		#Region "Method"
		''' <summary>
		''' Connection status acquisition
		''' </summary>
		''' <returns>Connection status for display</returns>
		Public Function GetStatusString() As String
			Dim status As String = _status.ToString()
			Select Case _status
				Case DeviceStatus.Ethernet, DeviceStatus.EthernetFast
					status += String.Format("---{0}.{1}.{2}.{3}", _ethernetConfig.abyIpAddress(0), _ethernetConfig.abyIpAddress(1), _ethernetConfig.abyIpAddress(2), _ethernetConfig.abyIpAddress(3))
					Exit Select
				Case Else
					Exit Select
			End Select
			Return status
		End Function
		#End Region
	End Class
End Namespace
