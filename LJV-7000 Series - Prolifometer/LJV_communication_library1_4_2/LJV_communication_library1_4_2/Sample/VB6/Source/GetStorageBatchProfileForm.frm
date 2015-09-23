VERSION 5.00
Begin VB.Form GetStorageBatchProfileForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "GetStorageBatchProfileForm"
   ClientHeight    =   2760
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5400
   Icon            =   "GetStorageBatchProfileForm.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2760
   ScaleWidth      =   5400
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.TextBox txtboxGetProfCnt 
      Height          =   270
      Left            =   240
      TabIndex        =   7
      Text            =   "1"
      Top             =   1560
      Width           =   1575
   End
   Begin VB.TextBox txtboxGetBatchTopProfNo 
      Height          =   270
      Left            =   240
      TabIndex        =   4
      Text            =   "1"
      Top             =   1080
      Width           =   1575
   End
   Begin VB.TextBox txtboxGetBatchNo 
      Height          =   270
      Left            =   240
      TabIndex        =   2
      Text            =   "0"
      Top             =   600
      Width           =   1575
   End
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   2520
      TabIndex        =   9
      Top             =   2160
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3960
      TabIndex        =   10
      Top             =   2160
      Width           =   1095
   End
   Begin VB.TextBox txtboxSurface 
      Height          =   270
      Left            =   240
      TabIndex        =   0
      Text            =   "0"
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label lblGetBatchTopProfNo2 
      Caption         =   "in the batch do you want to get the data?"
      Height          =   255
      Left            =   2040
      TabIndex        =   6
      Top             =   1245
      Width           =   3255
   End
   Begin VB.Label lblGetProfCnt 
      Caption         =   "Number of profiles to read"
      Height          =   255
      Left            =   2040
      TabIndex        =   8
      Top             =   1605
      Width           =   2895
   End
   Begin VB.Label lblGetBatchTopProfNo1 
      Caption         =   "From what profile number"
      Height          =   255
      Left            =   2040
      TabIndex        =   5
      Top             =   1000
      Width           =   2895
   End
   Begin VB.Label lblGetBatchNo 
      Caption         =   "Batch number of read"
      Height          =   255
      Left            =   2040
      TabIndex        =   3
      Top             =   645
      Width           =   2895
   End
   Begin VB.Label lblSurface 
      Caption         =   "Stroage surface to read"
      Height          =   255
      Left            =   2040
      TabIndex        =   1
      Top             =   165
      Width           =   2895
   End
End
Attribute VB_Name = "GetStorageBatchProfileForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="GetStorageBatchProfileForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Get batch profile storage request structure
Private req As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Get batch profile storage request structure Property
Friend Property Get GetReq() As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ
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
 req.dwGetBatchNo = CLng(txtboxGetBatchNo.Text)
 req.dwGetBatchTopProfNo = CLng(txtboxGetBatchTopProfNo.Text)
 req.byGetProfCnt = CByte(txtboxGetProfCnt.Text)
 
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
