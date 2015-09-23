Attribute VB_Name = "Enumeration"
'-----------------------------------------------------------------------------
' <copyright file="Enumeration.bas" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'----- Enumulations
' Dialog result
Public Enum EnumDialogResult
    None = 0
    OK = 1
    Cancel = 2
End Enum

' Device communication state
Public Enum DeviceStatus
    NoConnection = 0
    Usb = 1
    UsbFast = 2
    Ethernet = 3
    EthernetFast = 4
End Enum
