VERSION 5.00
Begin VB.Form OutSelectForm 
   BorderStyle     =   3  'ŒÅ’èÀÞ²±Û¸Þ
   Caption         =   "Dialog box"
   ClientHeight    =   3660
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3600
   Icon            =   "OutSelectForm.frx":0000
   LinkTopic       =   "Form5"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3660
   ScaleWidth      =   3600
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ°Å° Ì«°Ñ‚Ì’†‰›
   Begin VB.CheckBox chkboxBit16 
      Caption         =   "16"
      Height          =   375
      Left            =   2400
      TabIndex        =   19
      Top             =   2160
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit12 
      Caption         =   "12"
      Height          =   375
      Left            =   2400
      TabIndex        =   15
      Top             =   1800
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit8 
      Caption         =   "8"
      Height          =   375
      Left            =   2400
      TabIndex        =   11
      Top             =   1440
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit4 
      Caption         =   "4"
      Height          =   375
      Left            =   2400
      TabIndex        =   7
      Top             =   1080
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit15 
      Caption         =   "15"
      Height          =   375
      Left            =   1800
      TabIndex        =   18
      Top             =   2160
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit11 
      Caption         =   "11"
      Height          =   375
      Left            =   1800
      TabIndex        =   14
      Top             =   1800
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit7 
      Caption         =   "7"
      Height          =   375
      Left            =   1800
      TabIndex        =   10
      Top             =   1440
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit3 
      Caption         =   "3"
      Height          =   375
      Left            =   1800
      TabIndex        =   6
      Top             =   1080
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit14 
      Caption         =   "14"
      Height          =   375
      Left            =   1200
      TabIndex        =   17
      Top             =   2160
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit10 
      Caption         =   "10"
      Height          =   375
      Left            =   1200
      TabIndex        =   13
      Top             =   1800
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit6 
      Caption         =   "6"
      Height          =   375
      Left            =   1200
      TabIndex        =   9
      Top             =   1440
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.CheckBox chkboxBit2 
      Caption         =   "2"
      Height          =   375
      Left            =   1200
      TabIndex        =   5
      Top             =   1080
      Value           =   1  'Áª¯¸
      Width           =   615
   End
   Begin VB.Frame Frame1 
      Caption         =   "Target OUT (the lower 16 bits)"
      Height          =   1935
      Left            =   360
      TabIndex        =   3
      Top             =   840
      Width           =   2895
      Begin VB.CheckBox chkboxBit13 
         Caption         =   "13"
         Height          =   375
         Left            =   240
         TabIndex        =   16
         Top             =   1320
         Value           =   1  'Áª¯¸
         Width           =   615
      End
      Begin VB.CheckBox chkboxBit9 
         Caption         =   "9"
         Height          =   375
         Left            =   240
         TabIndex        =   12
         Top             =   960
         Value           =   1  'Áª¯¸
         Width           =   615
      End
      Begin VB.CheckBox chkboxBit5 
         Caption         =   "5"
         Height          =   375
         Left            =   240
         TabIndex        =   8
         Top             =   600
         Value           =   1  'Áª¯¸
         Width           =   615
      End
      Begin VB.CheckBox chkboxBit1 
         Caption         =   "1"
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   240
         Value           =   1  'Áª¯¸
         Width           =   615
      End
   End
   Begin VB.TextBox txtboxOnOff 
      Height          =   270
      Left            =   1800
      MaxLength       =   1
      TabIndex        =   1
      Text            =   "0"
      Top             =   200
      Width           =   855
   End
   Begin VB.CommandButton btnOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   600
      TabIndex        =   20
      Top             =   3120
      Width           =   1095
   End
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   1920
      TabIndex        =   21
      Top             =   3120
      Width           =   1095
   End
   Begin VB.Label lblOnOffDescription 
      Caption         =   "Other than 0: on request, 0: off request"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   480
      Width           =   3135
   End
   Begin VB.Label lblOnOff 
      Caption         =   "On/off request"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   1455
   End
End
Attribute VB_Name = "OutSelectForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="OutSelectForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Auto zero on request and off request
Private onOff As Byte

'The bits of the parameter are used to specify the processing target OUTs.
Private out As Long

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Other than 0: auto zero on request, 0: auto zero off request
Public Property Get GetOnOff() As Byte
 GetOnOff = onOff
End Property

'The bits of the parameter are used to specify the processing target OUTs.
Public Property Get GetOut() As Long
 GetOut = out
End Property

'Dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 On Error Resume Next
  
 onOff = CByte(txtboxOnOff.Text)
 
 If chkboxBit1.value Then
  out = out Or 1
 End If
 If chkboxBit2.value Then
  out = out Or BitShiftLeft(1, 1)
 End If
 If chkboxBit3.value Then
  out = out Or BitShiftLeft(1, 2)
 End If
 If chkboxBit4.value Then
  out = out Or BitShiftLeft(1, 3)
 End If
 If chkboxBit5.value Then
  out = out Or BitShiftLeft(1, 4)
 End If
 If chkboxBit6.value Then
  out = out Or BitShiftLeft(1, 5)
 End If
 If chkboxBit7.value Then
  out = out Or BitShiftLeft(1, 6)
 End If
 If chkboxBit8.value Then
  out = out Or BitShiftLeft(1, 7)
 End If
 If chkboxBit9.value Then
  out = out Or BitShiftLeft(1, 8)
 End If
 If chkboxBit10.value Then
  out = out Or BitShiftLeft(1, 9)
 End If
 If chkboxBit11.value Then
  out = out Or BitShiftLeft(1, 10)
 End If
 If chkboxBit12.value Then
  out = out Or BitShiftLeft(1, 11)
 End If
 If chkboxBit13.value Then
  out = out Or BitShiftLeft(1, 12)
 End If
 If chkboxBit14.value Then
  out = out Or BitShiftLeft(1, 13)
 End If
 If chkboxBit15.value Then
  out = out Or BitShiftLeft(1, 14)
 End If
 If chkboxBit16.value Then
  out = out Or BitShiftLeft(1, 15)
 End If
 
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
Public Sub InitializeOutSelectForm(isOnOffVisible As Boolean)
 'Field initialization
 onOff = 0
 out = 0

 'Control display control
 lblOnOff.Visible = isOnOffVisible
 txtboxOnOff.Visible = isOnOffVisible
 lblOnOffDescription.Visible = isOnOffVisible
End Sub

Private Function BitShiftLeft(target As Long, shift As Integer) As Long
 Dim s As Long
 
 If shift <= 0 Then
  BitShiftLeft = target
  Exit Function
 End If
 
 If shift >= 32 Then
  BitShiftLeft = 0
  Exit Function
 End If
 
 If shift = 31 Then
  BitShiftLeft = &H80000000 * (target And &H1&)
  Exit Function
 End If
 
 s = target And (2 ^ (31 - shift))
 target = (target And (2 ^ (31 - shift) - 1)) * (2 ^ shift)
 If s Then
  target = target Or &H80000000
 End If
 
 BitShiftLeft = target
End Function
