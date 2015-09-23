VERSION 5.00
Begin VB.Form GetErrorForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "Get the detailed error information."
   ClientHeight    =   1350
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3990
   Icon            =   "GetErrorForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1350
   ScaleWidth      =   3990
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1200
      TabIndex        =   3
      Top             =   840
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2640
      TabIndex        =   4
      Top             =   840
      Width           =   1095
   End
   Begin VB.TextBox txtboxErrCnt 
      Height          =   270
      Left            =   2640
      TabIndex        =   2
      Text            =   "10"
      Top             =   240
      Width           =   1095
   End
   Begin VB.Label lblErrCnt2 
      Caption         =   "error information to recieve"
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   360
      Width           =   2415
   End
   Begin VB.Label lblErrCnt1 
      Caption         =   "Amount of system"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   1815
   End
End
Attribute VB_Name = "GetErrorForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="GetErrorForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Maximun number of system errors of receive
Private rcvMax As Byte

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Specify the maximum amount of system error information to receive.
Public Property Get GetRcvMax() As Byte
 GetRcvMax = rcvMax
End Property

'Dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
 
 rcvMax = CByte(txtboxErrCnt.Text)

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

Private Sub Form_Initialize()
 'Field initialization
 rcvMax = 0
End Sub
