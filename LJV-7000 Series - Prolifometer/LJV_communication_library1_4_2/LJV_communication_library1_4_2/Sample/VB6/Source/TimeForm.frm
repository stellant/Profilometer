VERSION 5.00
Begin VB.Form TimeForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "Date and time settings"
   ClientHeight    =   3735
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3045
   Icon            =   "TimeForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3735
   ScaleWidth      =   3045
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.TextBox txtboxSecond 
      Height          =   270
      Left            =   1080
      TabIndex        =   12
      Text            =   "0"
      Top             =   2520
      Width           =   1455
   End
   Begin VB.TextBox txtboxMinute 
      Height          =   270
      Left            =   1080
      TabIndex        =   10
      Text            =   "0"
      Top             =   2160
      Width           =   1455
   End
   Begin VB.TextBox txtboxHour 
      Height          =   270
      Left            =   1080
      TabIndex        =   8
      Text            =   "0"
      Top             =   1800
      Width           =   1455
   End
   Begin VB.TextBox txtboxDay 
      Height          =   270
      Left            =   1080
      TabIndex        =   6
      Text            =   "1"
      Top             =   1320
      Width           =   1455
   End
   Begin VB.TextBox txtboxMonth 
      Height          =   270
      Left            =   1080
      TabIndex        =   4
      Text            =   "1"
      Top             =   960
      Width           =   1455
   End
   Begin VB.TextBox txtboxYear 
      Height          =   270
      Left            =   1080
      TabIndex        =   2
      Text            =   "99"
      Top             =   600
      Width           =   1455
   End
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   240
      TabIndex        =   13
      Top             =   3120
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   1680
      TabIndex        =   14
      Top             =   3120
      Width           =   1095
   End
   Begin VB.Label lblSecond 
      Caption         =   "Second"
      Height          =   255
      Left            =   360
      TabIndex        =   11
      Top             =   2565
      Width           =   735
   End
   Begin VB.Label lblMinute 
      Caption         =   "Minute"
      Height          =   255
      Left            =   360
      TabIndex        =   9
      Top             =   2205
      Width           =   735
   End
   Begin VB.Label lblHour 
      Caption         =   "Hour"
      Height          =   255
      Left            =   360
      TabIndex        =   7
      Top             =   1845
      Width           =   735
   End
   Begin VB.Label lblDay 
      Caption         =   "Day"
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   1365
      Width           =   735
   End
   Begin VB.Label lblMonth 
      Caption         =   "Month"
      Height          =   255
      Left            =   360
      TabIndex        =   3
      Top             =   1005
      Width           =   735
   End
   Begin VB.Label lblYear 
      Caption         =   "Year"
      Height          =   255
      Left            =   360
      TabIndex        =   1
      Top             =   645
      Width           =   735
   End
   Begin VB.Label lblTimeDescription 
      Caption         =   "Input range (0 to 255)"
      Height          =   255
      Left            =   600
      TabIndex        =   0
      Top             =   240
      Width           =   1935
   End
End
Attribute VB_Name = "TimeForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="TimeForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'The date and time to set
Private time As LJV7IF_TIME

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'The date and time to set
Friend Property Get GetTime() As LJV7IF_TIME
 GetTime = time
End Property
            
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
 
 time.byYear = CByte(txtboxYear.Text)
 time.byMonth = CByte(txtboxMonth.Text)
 time.byDay = CByte(txtboxDay.Text)
 time.byHour = CByte(txtboxHour.Text)
 time.byMinute = CByte(txtboxMinute.Text)
 time.bySecond = CByte(txtboxSecond.Text)
                    
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
