VERSION 5.00
Begin VB.Form GetBatchProfileAdvanceForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "GetBatchProfileAdvanceForm"
   ClientHeight    =   4440
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7065
   Icon            =   "GetBatchProfileAdvanceForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4440
   ScaleWidth      =   7065
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.TextBox txtboxGetBatchNo 
      Height          =   270
      Left            =   240
      TabIndex        =   8
      Text            =   "0"
      Top             =   2160
      Width           =   975
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   5880
      TabIndex        =   17
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton btnOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   4560
      TabIndex        =   16
      Top             =   3960
      Width           =   1095
   End
   Begin VB.TextBox txtboxGetProfCnt 
      Height          =   270
      Left            =   240
      TabIndex        =   14
      Text            =   "1"
      Top             =   3600
      Width           =   975
   End
   Begin VB.TextBox txtboxGetProfNo 
      Height          =   270
      Left            =   240
      TabIndex        =   10
      Text            =   "0"
      Top             =   2640
      Width           =   975
   End
   Begin VB.TextBox txtboxPosMode 
      Height          =   270
      Left            =   240
      TabIndex        =   2
      Text            =   "00"
      Top             =   720
      Width           =   975
   End
   Begin VB.Label Label4 
      Caption         =   "This profile will be excluded (byte format)."
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   360
      Width           =   3375
   End
   Begin VB.Label Label6 
      Caption         =   "From what number profile do you want to start acquiring profiles (in ushort format)?"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   6735
   End
   Begin VB.Label Label3 
      Caption         =   "0x04: Current Only"
      Height          =   255
      Left            =   240
      TabIndex        =   7
      Top             =   1800
      Width           =   2055
   End
   Begin VB.Label Label2 
      Caption         =   "0x03: From current after batch commitment"
      Height          =   255
      Left            =   240
      TabIndex        =   6
      Top             =   1560
      Width           =   3375
   End
   Begin VB.Label Label1 
      Caption         =   "specify the number of the profile to get."
      Height          =   255
      Left            =   240
      TabIndex        =   13
      Top             =   3240
      Width           =   3495
   End
   Begin VB.Label lblTargetBankDescription2 
      Caption         =   "0x02: Specify position"
      Height          =   255
      Left            =   240
      TabIndex        =   5
      Top             =   1300
      Width           =   1695
   End
   Begin VB.Label lblTargetBank 
      Caption         =   "Bank position specification method"
      Height          =   255
      Left            =   1320
      TabIndex        =   3
      Top             =   765
      Width           =   2775
   End
   Begin VB.Label lblTargetBankDescription1 
      AutoSize        =   -1  'True
      Caption         =   "0x00: From current"
      Height          =   180
      Left            =   240
      TabIndex        =   4
      Top             =   1080
      Width           =   1440
   End
   Begin VB.Label lblPosMode 
      Caption         =   "what is the number of the batch that contains the profile to get?"
      Height          =   255
      Left            =   1320
      TabIndex        =   9
      Top             =   2200
      Width           =   5415
   End
   Begin VB.Label lblGetProfNo 
      Caption         =   "From what number profile do you want to start acquiring profiles?"
      Height          =   255
      Left            =   1320
      TabIndex        =   11
      Top             =   2680
      Width           =   5415
   End
   Begin VB.Label Label5 
      Caption         =   "When the profile position specification is [0x02: Specify position],"
      Height          =   255
      Left            =   240
      TabIndex        =   12
      Top             =   3000
      Width           =   5535
   End
   Begin VB.Label lblGetProfCount 
      Caption         =   "Number of profiles to request the acquisition"
      Height          =   255
      Left            =   1320
      TabIndex        =   15
      Top             =   3640
      Width           =   3975
   End
End
Attribute VB_Name = "GetBatchProfileAdvanceForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="GetBatchprofileAdvanceForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Specify the position, etc., of the profiles to get.
Private req As LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Specify the position, etc., of the profiles to get.
Friend Property Get GetReq() As LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ
 GetReq = req
End Property

'Get dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'-------- Event handler
'Close start event handler

Private Sub btnOK_Click()
 On Error Resume Next
 req.byPosMode = CByte("&H" & txtboxPosMode.Text)
 req.dwGetBatchNo = CInt(txtboxGetBatchNo.Text)
 req.dwGetProfNo = CInt(txtboxGetProfNo.Text)
 req.byGetProfCnt = CByte(txtboxGetProfCnt.Text)

 If Err.Number <> 0 Then
  Call MsgBox(Err.Description, vbOKOnly + vbDefaultButton1, "")
  Call Err.Clear
 Else
  dialogResult = EnumDialogResult.OK
  Me.Hide
 End If
End Sub

Private Sub btnCancel_Click()
 dialogResult = EnumDialogResult.Cancel
 Me.Hide
End Sub
