VERSION 5.00
Begin VB.Form ClearErrorForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "Clear the error"
   ClientHeight    =   1410
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4380
   Icon            =   "ClearErrorForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1410
   ScaleWidth      =   4380
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.TextBox txtboxErrCode 
      Height          =   270
      Left            =   480
      MaxLength       =   4
      TabIndex        =   1
      Text            =   "0084"
      Top             =   240
      Width           =   855
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2880
      TabIndex        =   4
      Top             =   840
      Width           =   1215
   End
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1320
      TabIndex        =   3
      Top             =   840
      Width           =   1215
   End
   Begin VB.Label lblClearErrCode 
      Caption         =   "Error code of the error to clear"
      Height          =   255
      Left            =   1440
      TabIndex        =   2
      Top             =   280
      Width           =   2655
   End
   Begin VB.Label lblHexErrCode 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   280
      Width           =   255
   End
End
Attribute VB_Name = "ClearErrorForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="ClearErrorForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Error code of the error to clear
Private errCode As Integer

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'The error code for the error you wish to clear
Public Property Get GetErrCode() As Integer
 GetErrCode = errCode
End Property
        
'Dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
 errCode = CInt("&H" & txtboxErrCode.Text)

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
 errCode = 0
End Sub
