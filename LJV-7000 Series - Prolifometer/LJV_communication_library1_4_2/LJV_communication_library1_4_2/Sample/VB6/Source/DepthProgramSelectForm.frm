VERSION 5.00
Begin VB.Form DepthProgramSelectForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "Program settings"
   ClientHeight    =   3705
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5670
   Icon            =   "DepthProgramSelectForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3705
   ScaleWidth      =   5670
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   3000
      TabIndex        =   15
      Top             =   3240
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   4440
      TabIndex        =   16
      Top             =   3240
      Width           =   1095
   End
   Begin VB.TextBox txtboxTargetProgram 
      Height          =   270
      Left            =   720
      TabIndex        =   8
      Text            =   "00"
      Top             =   1680
      Width           =   1215
   End
   Begin VB.TextBox txtboxDepth 
      Height          =   270
      Left            =   720
      TabIndex        =   1
      Text            =   "00"
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label lblTargetDescription5 
      Caption         =   "0x0F program 15"
      Height          =   255
      Left            =   360
      TabIndex        =   14
      Top             =   3000
      Width           =   3975
   End
   Begin VB.Label lblTargetDescription4 
      Caption         =   " ..."
      Height          =   255
      Left            =   360
      TabIndex        =   13
      Top             =   2760
      Width           =   3975
   End
   Begin VB.Label lblTargetDescription3 
      Caption         =   "0x01 program 1"
      Height          =   255
      Left            =   360
      TabIndex        =   12
      Top             =   2520
      Width           =   3975
   End
   Begin VB.Label lblTargetDescription2 
      Caption         =   "0x00 program 0"
      Height          =   255
      Left            =   360
      TabIndex        =   11
      Top             =   2280
      Width           =   3975
   End
   Begin VB.Label lblTargetDescription1 
      Caption         =   "Specified program (specified with LJV7IF_INIT_SETTING_TARGET)"
      Height          =   255
      Left            =   240
      TabIndex        =   10
      Top             =   2040
      Width           =   5295
   End
   Begin VB.Label lblTargetProgram 
      Caption         =   "Specified program"
      Height          =   255
      Left            =   2040
      TabIndex        =   9
      Top             =   1725
      Width           =   1695
   End
   Begin VB.Label lblHexTarget 
      Caption         =   "0x"
      Height          =   255
      Left            =   360
      TabIndex        =   7
      Top             =   1725
      Width           =   255
   End
   Begin VB.Label lblDepthDescription4 
      Caption         =   "0x02 Save memory"
      Height          =   255
      Left            =   360
      TabIndex        =   6
      Top             =   1320
      Width           =   3975
   End
   Begin VB.Label lblDepthDescription3 
      Caption         =   "0x01 Running memory"
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   1080
      Width           =   3975
   End
   Begin VB.Label lblDepthDescription2 
      Caption         =   "0x00 Write settings memory"
      Height          =   255
      Left            =   360
      TabIndex        =   4
      Top             =   840
      Width           =   3975
   End
   Begin VB.Label lblDepthDescription1 
      Caption         =   "Level (specified with LJV7IF_SETTING_DEPTH)"
      Height          =   255
      Left            =   240
      TabIndex        =   3
      Top             =   600
      Width           =   3975
   End
   Begin VB.Label lblDepth 
      Caption         =   "Level"
      Height          =   255
      Left            =   2040
      TabIndex        =   2
      Top             =   285
      Width           =   615
   End
   Begin VB.Label lblHexDepth 
      Caption         =   "0x"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   285
      Width           =   255
   End
End
Attribute VB_Name = "DepthProgramSelectForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="DepthProgramSelectForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Level
Private depth As Byte

'Specified program
Private target As Byte
        
'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Specify to what level the settings written for modification will be reflected (LJ7IF_SETTING_DEPTH).
Public Property Get GetDepth() As Byte
 GetDepth = depth
End Property

'Specify the setting that is the target for initialization (LJ7IF_INIT_SETTING_TARGET).
Public Property Get GetTarget() As Byte
 GetTarget = target
End Property
      
'Dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
 
 depth = CByte("&H" & txtboxDepth.Text)
 target = CByte("&H" & txtboxTargetProgram.Text)
 
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

'------ Method
'"isDepthVisible" is level control display setting
'"isTargetVisible" is specified program control display setting
Public Function InitializeDepthProgramSelectForm(isDepthVisible As Boolean, isTargetVisible As Boolean)
 ' Field initialization
 depth = 0
 target = 0

 'Control display control
 lblHexDepth.Visible = isDepthVisible
 txtboxDepth.Visible = isDepthVisible
 lblDepth.Visible = isDepthVisible
 lblDepthDescription1.Visible = isDepthVisible
 lblDepthDescription2.Visible = isDepthVisible
 lblDepthDescription3.Visible = isDepthVisible
 lblDepthDescription4.Visible = isDepthVisible
 lblHexTarget.Visible = isTargetVisible
 txtboxTargetProgram.Visible = isTargetVisible
 lblTargetProgram.Visible = isTargetVisible
 lblTargetDescription1.Visible = isTargetVisible
 lblTargetDescription2.Visible = isTargetVisible
 lblTargetDescription3.Visible = isTargetVisible
 lblTargetDescription4.Visible = isTargetVisible
 lblTargetDescription5.Visible = isTargetVisible
End Function
