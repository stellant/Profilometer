VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClassDeviceData"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="DeviceData.cls" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Device data class ------
'------ Field
'Connection state
Private status As DeviceStatus

'Ethernet settings
Private config As LJV7IF_ETHERNET_CONFIG

'
Private profileDatas As Collection

Private measureDatas As Collection

'------ Property
'Status get property
Public Property Get DeviceStatus() As DeviceStatus
 DeviceStatus = status
End Property

'Status let property
Public Property Let DeviceStatus(currentStatus As DeviceStatus)
 status = currentStatus
End Property

'Ethernet settings get property
Friend Property Get GetEthernetConfig() As LJV7IF_ETHERNET_CONFIG
 GetEthernetConfig = config
End Property

'Ethernet settings let property
Friend Property Let LetEthernetConfig(currentConfig As LJV7IF_ETHERNET_CONFIG)
 config = currentConfig
End Property

'------ Method
Public Sub GetProfile(ByRef data As Collection)
 Set data = New Collection
 Dim i As Long
 For i = 1 To profileDatas.Count Step 1
  data.Add (profileDatas.Item(i))
 Next i
End Sub

Public Sub GetMeasure(ByRef data As Collection)
 Dim i As Long
 For i = 1 To measureDatas.Count Step 1
  Call data.Add(measureDatas.Item(i))
 Next i
End Sub

'Connection status acquisition
'Return connection status for display
Public Function GetStatusString() As String
 Dim statusString As String
 statusString = ""
 Select Case status
  Case NoConnection
   statusString = "NoConnection"
  Case Usb
   statusString = "Usb"
  Case UsbFast
   statusString = "UsbFast"
  Case Ethernet, EthernetFast
   statusString = "Ethernet" & "---" & config.address.IPAddress1 & "." & config.address.IPAddress2 & "." & config.address.IPAddress3 & "." & config.address.IPAddress4
 End Select
 GetStatusString = statusString
End Function

Public Sub ClearProfileData()
 Set profileDatas = New Collection
End Sub

Public Sub ClearMeasureData()
 Set measureDatas = New Collection
End Sub

Private Sub Class_Initialize()
 Set profileDatas = New Collection
 Set measureDatas = New Collection
End Sub

Public Sub AddProfileData(newProfileData As ClassProfileData)
 Call profileDatas.Add(newProfileData)
End Sub

Public Sub AddMeasureData(newMeasureData As ClassMeasureData)
 Call measureDatas.Add(newMeasureData)
End Sub

Public Sub SetOffsetTime(targetMeasureDataIndex As Integer, newOffsetTime As Long)
 Dim targetMeasureData As ClassMeasureData
 Set targetMeasureData = measureDatas.Item(targetMeasureDataIndex)
 targetMeasureData.LetOffsetTime = newOffsetTime
End Sub
