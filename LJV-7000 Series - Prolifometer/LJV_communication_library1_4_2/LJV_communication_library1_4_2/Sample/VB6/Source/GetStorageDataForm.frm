VERSION 5.00
Begin VB.Form GetStorageDataForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "GetStorageData"
   ClientHeight    =   2295
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4755
   Icon            =   "GetStorageDataForm.frx":0000
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2295
   ScaleWidth      =   4755
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.TextBox txtboxDataCnt 
      Height          =   270
      Left            =   240
      TabIndex        =   4
      Text            =   "1"
      Top             =   1200
      Width           =   1575
   End
   Begin VB.TextBox txtboxStartNo 
      Height          =   270
      Left            =   240
      TabIndex        =   2
      Text            =   "0"
      Top             =   720
      Width           =   1575
   End
   Begin VB.TextBox txtboxSurface 
      Height          =   270
      Left            =   240
      TabIndex        =   0
      Text            =   "0"
      Top             =   240
      Width           =   1575
   End
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1920
      TabIndex        =   6
      Top             =   1680
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3360
      TabIndex        =   7
      Top             =   1680
      Width           =   1095
   End
   Begin VB.Label lblDataCnt 
      Caption         =   "Number of items to read"
      Height          =   255
      Left            =   2040
      TabIndex        =   5
      Top             =   1245
      Width           =   2895
   End
   Begin VB.Label lblStartNo 
      Caption         =   "Data number to start reading from"
      Height          =   255
      Left            =   2040
      TabIndex        =   3
      Top             =   765
      Width           =   2895
   End
   Begin VB.Label lblSurface 
      Caption         =   "Stroage surface to read"
      Height          =   255
      Left            =   2040
      TabIndex        =   1
      Top             =   285
      Width           =   2895
   End
End
Attribute VB_Name = "GetStorageDataForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="GetStorageDataForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit
'------ Field
'Storage status request structure
Private req As LJV7IF_GET_STORAGE_REQ

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
Friend Property Get GetReq() As LJV7IF_GET_STORAGE_REQ
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
  
 req.dwSurface = CLng(txtboxSurface.Text)
 req.dwStartNo = CLng(txtboxStartNo.Text)
 req.dwDataCnt = CInt(txtboxDataCnt.Text)
 
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
