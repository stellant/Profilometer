VERSION 5.00
Begin VB.Form GetStorageStatusForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "GetStorageStatusReq"
   ClientHeight    =   1125
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4515
   Icon            =   "GetStorageStatusForm.frx":0000
   LinkTopic       =   "Form4"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1125
   ScaleWidth      =   4515
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.TextBox txtboxInputValue 
      Height          =   270
      Left            =   2520
      TabIndex        =   1
      Text            =   "0"
      Top             =   120
      Width           =   1575
   End
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1680
      TabIndex        =   2
      Top             =   600
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3000
      TabIndex        =   3
      Top             =   600
      Width           =   1095
   End
   Begin VB.Label lblSendPos 
      Caption         =   "Target surface to read"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   165
      Width           =   1935
   End
End
Attribute VB_Name = "GetStorageStatusForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="GetStorageStatusForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Storage status request structure
Private req As LJV7IF_GET_STRAGE_STATUS_REQ

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Storage status request structure
Friend Property Get GetReq() As LJV7IF_GET_STRAGE_STATUS_REQ
 GetReq = req
End Property
        
'Dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
  
 req.dwRdArea = CLng(txtboxInputValue.Text)
 
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

