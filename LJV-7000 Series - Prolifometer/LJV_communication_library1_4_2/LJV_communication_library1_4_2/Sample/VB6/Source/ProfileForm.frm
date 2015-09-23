VERSION 5.00
Begin VB.Form ProfileForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "Read the profile."
   ClientHeight    =   5520
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7095
   Icon            =   "ProfileForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5520
   ScaleWidth      =   7095
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   5880
      TabIndex        =   21
      Top             =   5040
      Width           =   1095
   End
   Begin VB.CommandButton btnOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   4560
      TabIndex        =   20
      Top             =   5040
      Width           =   1095
   End
   Begin VB.TextBox txtboxErase 
      Height          =   270
      Left            =   240
      TabIndex        =   17
      Text            =   "0"
      Top             =   4320
      Width           =   975
   End
   Begin VB.TextBox txtboxGetProfCount 
      Height          =   270
      Left            =   240
      TabIndex        =   15
      Text            =   "1"
      Top             =   3840
      Width           =   975
   End
   Begin VB.TextBox txtboxGetProfNo 
      Height          =   270
      Left            =   240
      TabIndex        =   11
      Text            =   "0"
      Top             =   2880
      Width           =   975
   End
   Begin VB.TextBox txtboxPosMode 
      Height          =   270
      Left            =   240
      TabIndex        =   6
      Text            =   "00"
      Top             =   1680
      Width           =   975
   End
   Begin VB.TextBox txtboxTargetBank 
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
      Top             =   340
      Width           =   3375
   End
   Begin VB.Label Label1 
      Caption         =   "specify the number of the profile to get."
      Height          =   255
      Left            =   240
      TabIndex        =   14
      Top             =   3460
      Width           =   3495
   End
   Begin VB.Label lblPosModeDescription3 
      Caption         =   "0x02: Specify position"
      Height          =   375
      Left            =   240
      TabIndex        =   10
      Top             =   2480
      Width           =   1935
   End
   Begin VB.Label lblPosModeDescription2 
      Caption         =   "0x01: From oldest"
      Height          =   255
      Left            =   240
      TabIndex        =   9
      Top             =   2260
      Width           =   1935
   End
   Begin VB.Label lblTargetBankDescription2 
      Caption         =   "0x01: Inactive surface"
      Height          =   255
      Left            =   240
      TabIndex        =   5
      Top             =   1300
      Width           =   1695
   End
   Begin VB.Label lblTargetBank 
      Caption         =   "Get profile bank specification"
      Height          =   255
      Left            =   1320
      TabIndex        =   3
      Top             =   765
      Width           =   2775
   End
   Begin VB.Label lblTargetBankDescription1 
      AutoSize        =   -1  'True
      Caption         =   "0x00: Active surface"
      Height          =   180
      Left            =   240
      TabIndex        =   4
      Top             =   1080
      Width           =   1575
   End
   Begin VB.Label lblPosMode 
      Caption         =   "Get profile position specification method"
      Height          =   255
      Left            =   1320
      TabIndex        =   7
      Top             =   1740
      Width           =   3735
   End
   Begin VB.Label lblPosModeDescription1 
      Caption         =   "0x00: From current"
      Height          =   255
      Left            =   240
      TabIndex        =   8
      Top             =   2040
      Width           =   1815
   End
   Begin VB.Label lblGetProfNo 
      Caption         =   "From what number profile do you want to start acquiring profiles?"
      Height          =   255
      Left            =   1320
      TabIndex        =   12
      Top             =   2940
      Width           =   5415
   End
   Begin VB.Label Label5 
      Caption         =   "When the profile position specification is [0x02: Specify position],"
      Height          =   255
      Left            =   240
      TabIndex        =   13
      Top             =   3240
      Width           =   5535
   End
   Begin VB.Label lblGetProfCount 
      Caption         =   "Number of profiles to request the acquisition of"
      Height          =   255
      Left            =   1320
      TabIndex        =   16
      Top             =   3900
      Width           =   4215
   End
   Begin VB.Label Label3 
      Caption         =   "Already read indication flag"
      Height          =   255
      Left            =   1320
      TabIndex        =   18
      Top             =   4380
      Width           =   2295
   End
   Begin VB.Label Label2 
      Caption         =   "0: Do not erase the profiles that were read. 1: Erase the profiles that were read."
      Height          =   255
      Left            =   240
      TabIndex        =   19
      Top             =   4680
      Width           =   6735
   End
   Begin VB.Label lblProfileDescription 
      Caption         =   "From what number profile do you want to start acquiring profiles (in ushort format)?"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   6735
   End
End
Attribute VB_Name = "ProfileForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="ProfileForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Specify the position, etc., of the profiles to get.
Private req As LJV7IF_GET_PROFILE_REQ

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Specify the position, etc., of the profiles to get.
Friend Property Get GetReq() As LJV7IF_GET_PROFILE_REQ
 GetReq = req
End Property

'Get dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'Close start event handler
Private Sub btnOK_Click()
 On Error Resume Next
 req.byTargetBank = CByte("&H" & txtboxTargetBank.Text)
 req.byPosMode = CByte("&H" & txtboxPosMode.Text)
 req.dwGetProfNo = CLng(txtboxGetProfNo.Text)
 req.byGetProfCnt = CByte(txtboxGetProfCount.Text)
 req.byErase = CByte(txtboxErase.Text)

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
