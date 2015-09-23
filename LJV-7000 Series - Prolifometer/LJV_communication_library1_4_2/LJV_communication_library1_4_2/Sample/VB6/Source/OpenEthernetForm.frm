VERSION 5.00
Begin VB.Form OpenEthernetForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "OpenEthernet"
   ClientHeight    =   1830
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6345
   Icon            =   "OpenEthernetForm.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1830
   ScaleWidth      =   6345
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   5040
      TabIndex        =   9
      Top             =   1320
      Width           =   1095
   End
   Begin VB.CommandButton btnOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   3840
      TabIndex        =   8
      Top             =   1320
      Width           =   1095
   End
   Begin VB.TextBox txtboxIpFourthSegment 
      Height          =   270
      Left            =   3240
      TabIndex        =   5
      Text            =   "1"
      Top             =   480
      Width           =   615
   End
   Begin VB.TextBox txtboxIpThirdSegment 
      Height          =   270
      Left            =   2520
      TabIndex        =   4
      Text            =   "0"
      Top             =   480
      Width           =   615
   End
   Begin VB.TextBox txtboxPort 
      Height          =   270
      Left            =   1080
      TabIndex        =   7
      Text            =   "24691"
      Top             =   840
      Width           =   2775
   End
   Begin VB.TextBox txtboxIpSecondSegment 
      Height          =   270
      Left            =   1800
      TabIndex        =   3
      Text            =   "168"
      Top             =   480
      Width           =   615
   End
   Begin VB.TextBox txtboxIpFirstSegment 
      Height          =   270
      Left            =   1080
      TabIndex        =   2
      Text            =   "192"
      Top             =   480
      Width           =   615
   End
   Begin VB.Label Label3 
      Caption         =   "Port"
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   840
      Width           =   855
   End
   Begin VB.Label Label2 
      Caption         =   "IP address"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "[Valid range] Ther IP address is a byte value and the port is a ushort value."
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6015
   End
End
Attribute VB_Name = "OpenEthernetForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'----------------------------------------------------------------------------
' <copyright file="OpenEthernetForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Ethernet communication settings
Private config As LJV7IF_ETHERNET_CONFIG

Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'Ethernet communication settings
Friend Property Get GetEthernetConfig() As LJV7IF_ETHERNET_CONFIG
 GetEthernetConfig = config
End Property

'-------- Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
 config.address.IPAddress1 = CByte(txtboxIpFirstSegment)
 config.address.IPAddress2 = CByte(txtboxIpSecondSegment)
 config.address.IPAddress3 = CByte(txtboxIpThirdSegment)
 config.address.IPAddress4 = CByte(txtboxIpFourthSegment)
   
 config.wPortNo = IntegerFromWordValue(CLng(txtboxPort))
 
 If Err.Number <> 0 Then
  Call MsgBox(Err.Description, vbOKOnly + vbDefaultButton1, "")
  Call Err.Clear
 Else
  dialogResult = EnumDialogResult.OK
  Me.Hide
 End If
End Sub

'"Cancel" button clicked.
Private Sub btnCancel_Click()
 dialogResult = EnumDialogResult.Cancel
 Me.Hide
End Sub
