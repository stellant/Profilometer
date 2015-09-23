VERSION 5.00
Begin VB.Form SettingForm 
   BorderStyle     =   3  'å≈íË¿ﬁ≤±€∏ﬁ
   Caption         =   "Settings"
   ClientHeight    =   7125
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5550
   Icon            =   "SettingForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7125
   ScaleWidth      =   5550
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'µ∞≈∞ Ã´∞—ÇÃíÜâõ
   Tag             =   "0"
   Begin VB.CommandButton btnCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   255
      Left            =   3360
      TabIndex        =   26
      Tag             =   "0"
      Top             =   6720
      Width           =   975
   End
   Begin VB.CommandButton btnOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   255
      Left            =   1200
      TabIndex        =   25
      Tag             =   "0"
      Top             =   6720
      Width           =   975
   End
   Begin VB.TextBox txtboxParameter 
      Height          =   855
      Left            =   240
      MultiLine       =   -1  'True
      ScrollBars      =   2  'êÇíº
      TabIndex        =   24
      Tag             =   "0"
      Text            =   "SettingForm.frx":000C
      Top             =   5635
      Width           =   4920
   End
   Begin VB.TextBox txtDataLength 
      Height          =   270
      Left            =   1680
      TabIndex        =   21
      Tag             =   "0"
      Text            =   "1"
      Top             =   5160
      Width           =   735
   End
   Begin VB.TextBox txtboxTarget4 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   18
      Tag             =   "0"
      Text            =   "00"
      Top             =   4800
      Width           =   1215
   End
   Begin VB.TextBox txtboxTarget3 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   16
      Tag             =   "0"
      Text            =   "00"
      Top             =   4320
      Width           =   1215
   End
   Begin VB.TextBox txtboxTarget2 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   14
      Tag             =   "0"
      Text            =   "00"
      Top             =   3840
      Width           =   1215
   End
   Begin VB.TextBox txtboxTarget1 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   9
      Tag             =   "0"
      Text            =   "00"
      Top             =   3320
      Width           =   1215
   End
   Begin VB.TextBox txtboxItem 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   7
      Tag             =   "0"
      Text            =   "02"
      Top             =   2840
      Width           =   1215
   End
   Begin VB.TextBox txtboxCategory 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   5
      Tag             =   "0"
      Text            =   "00"
      Top             =   2360
      Width           =   1215
   End
   Begin VB.TextBox txtboxType 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   3
      Tag             =   "0"
      Text            =   "10"
      Top             =   1320
      Width           =   1215
   End
   Begin VB.TextBox txtboxDepth 
      Height          =   270
      Left            =   600
      MaxLength       =   2
      TabIndex        =   1
      Tag             =   "0"
      Text            =   "01"
      Top             =   600
      Width           =   1215
   End
   Begin VB.Label Label5 
      Caption         =   "see the tables in the communication command"
      Height          =   255
      Left            =   840
      TabIndex        =   35
      Top             =   360
      Width           =   4215
   End
   Begin VB.Label lblType 
      Caption         =   "Setting type"
      Height          =   255
      Left            =   1920
      TabIndex        =   34
      Top             =   1360
      Width           =   1095
   End
   Begin VB.Label Label2 
      Caption         =   "0x10: Program 0, 0x11: Program 1, ..., 0x1F: Program 15"
      Height          =   255
      Left            =   360
      TabIndex        =   33
      Tag             =   "0"
      Top             =   2040
      Width           =   4455
   End
   Begin VB.Label lblItem 
      Caption         =   "Setting item"
      Height          =   255
      Left            =   1920
      TabIndex        =   32
      Tag             =   "0"
      Top             =   2880
      Width           =   1095
   End
   Begin VB.Label lblTarget1 
      Caption         =   "Setting target 1"
      Height          =   255
      Left            =   1920
      TabIndex        =   31
      Tag             =   "0"
      Top             =   3360
      Width           =   1695
   End
   Begin VB.Label lblTarget2 
      Caption         =   "Setting target 2"
      Height          =   255
      Left            =   1920
      TabIndex        =   30
      Tag             =   "0"
      Top             =   3880
      Width           =   1455
   End
   Begin VB.Label lblTarget3 
      Caption         =   "Setting target 3"
      Height          =   255
      Left            =   1920
      TabIndex        =   29
      Tag             =   "0"
      Top             =   4360
      Width           =   1455
   End
   Begin VB.Label lblTarget4 
      Caption         =   "Setting target 4"
      Height          =   255
      Left            =   1920
      TabIndex        =   28
      Tag             =   "0"
      Top             =   4840
      Width           =   1455
   End
   Begin VB.Label lblCategory 
      Caption         =   "Category"
      Height          =   255
      Left            =   1920
      TabIndex        =   27
      Tag             =   "0"
      Top             =   2400
      Width           =   1095
   End
   Begin VB.Label lblParameter 
      Caption         =   "Writing parameters (comma-separated hexadecimal values)"
      Height          =   255
      Left            =   240
      TabIndex        =   23
      Tag             =   "0"
      Top             =   5445
      Width           =   4815
   End
   Begin VB.Label lblBYTE 
      Caption         =   "BYTE"
      Height          =   180
      Left            =   2640
      TabIndex        =   22
      Tag             =   "0"
      Top             =   5205
      Width           =   615
   End
   Begin VB.Label lblAmountOfData 
      Caption         =   "Amount of data"
      Height          =   255
      Left            =   240
      TabIndex        =   20
      Tag             =   "0"
      Top             =   5200
      Width           =   1335
   End
   Begin VB.Label lblHexTarget4 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   19
      Tag             =   "0"
      Top             =   4840
      Width           =   495
   End
   Begin VB.Label lblHexTarget3 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   17
      Tag             =   "0"
      Top             =   4360
      Width           =   495
   End
   Begin VB.Label lblHexTarget2 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   15
      Tag             =   "0"
      Top             =   3880
      Width           =   495
   End
   Begin VB.Label Label3 
      Caption         =   "0x01: Environment settings, 0x02: Common measurement settings, "
      Height          =   255
      Left            =   360
      TabIndex        =   13
      Tag             =   "0"
      Top             =   1680
      Width           =   5055
   End
   Begin VB.Label Label4 
      Caption         =   "0: Write settings area, 1: Running settings area, 2: Save area"
      Height          =   255
      Left            =   360
      TabIndex        =   12
      Tag             =   "0"
      Top             =   960
      Width           =   4815
   End
   Begin VB.Label lblDepth 
      Caption         =   "Get target area and setting depth"
      Height          =   255
      Left            =   1920
      TabIndex        =   11
      Tag             =   "0"
      Top             =   660
      Width           =   3135
   End
   Begin VB.Label lblHexTarget1 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   10
      Tag             =   "0"
      Top             =   3360
      Width           =   495
   End
   Begin VB.Label lblHexItem 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   8
      Tag             =   "0"
      Top             =   2880
      Width           =   495
   End
   Begin VB.Label lblHexCategory 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   6
      Top             =   2400
      Width           =   495
   End
   Begin VB.Label lblHexType 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Tag             =   "0"
      Top             =   1360
      Width           =   375
   End
   Begin VB.Label lblHexDepth 
      Caption         =   "0x"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Tag             =   "0"
      Top             =   660
      Width           =   375
   End
   Begin VB.Label Label1 
      Caption         =   "For details on the items that follow the category, "
      Height          =   255
      Left            =   840
      TabIndex        =   0
      Tag             =   "0"
      Top             =   120
      Width           =   3855
   End
End
Attribute VB_Name = "SettingForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="SettingForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Specify to what level the sent settings will be reflected (LJV7IF_SETTING_DEPTH).
Private depth As Byte

'Identify the item that is the target to send.
Private targetSetting As LJV7IF_TARGET_SETTING

'Specify the buffer that stores the setting data to send.
Private data() As Byte

'Dialog result
Private dialogResult As EnumDialogResult

'------ Property
'Specify to what level the sent settings will be reflected (LJV7IF_SETTING_DEPTH).
Public Property Get GetDepth() As Byte
 GetDepth = depth
End Property

'Identify the item that is the target to send.
Friend Property Get GetTargetSetting() As LJV7IF_TARGET_SETTING
 GetTargetSetting = targetSetting
End Property

Public Property Get GetDataLength() As Integer
 GetDataLength = CInt(txtDataLength.Text)
End Property

'Specify the buffer that stores the setting data to send.
Public Sub GetData(ByRef sendData() As Byte)
 ReDim sendData(CInt(txtDataLength.Text) - 1)
 Dim i As Integer
 For i = 0 To (CInt(txtDataLength.Text) - 1) Step 1
  sendData(i) = data(i)
 Next i
End Sub

'Get dialog result
Public Property Get GetDialogResult() As EnumDialogResult
 GetDialogResult = dialogResult
End Property

'------ Event handler
'"OK" button clicked.
Private Sub btnOK_Click()
 ReDim data(LJV7IFEX_SETTING_SIZE_PROGRAM)
 
 On Error Resume Next
 depth = CByte("&H" & txtboxDepth.Text)
 targetSetting.byType = CByte("&H" & txtboxType.Text)
 targetSetting.byCategory = CByte("&H" & txtboxCategory.Text)
 targetSetting.byItem = CByte("&H" & txtboxItem.Text)
 targetSetting.byTarget1 = CByte("&H" & txtboxTarget1.Text)
 targetSetting.byTarget2 = CByte("&H" & txtboxTarget2.Text)
 targetSetting.byTarget3 = CByte("&H" & txtboxTarget3.Text)
 targetSetting.byTarget4 = CByte("&H" & txtboxTarget4.Text)
 
 Dim trimStr As String
 trimStr = TrimChars(txtboxParameter.Text, " ")
 trimStr = TrimChars(txtboxParameter.Text, ",")
 
 If Len(trimStr) > 0 Then
  Dim aSrc() As String
  aSrc = Split(trimStr, ",")
  If (UBound(aSrc) + 1) > 0 Then
   Dim i As Integer
   For i = 0 To UBound(aSrc) Step 1
    data(i) = CByte("&H" & aSrc(i))
   Next i
  End If
 End If
 
 ReDim Preserve data(CInt(txtDataLength.Text) - 1)
 
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

'------- Method
Public Sub InitializeSettingForm(isSetSetting As Boolean)
 'Control display control
 txtboxParameter.Visible = isSetSetting
 lblParameter.Visible = isSetSetting
 
 'Settings that change the sampling period of the running area to "100 Hz"
 depth = &H1                       ' Setting depth: Running settings area
 targetSetting.byType = &H10       ' Setting type: Program number 0
 targetSetting.byCategory = &H0    ' Category: Trigger settings
 targetSetting.byItem = &H2        ' Setting item: Sampling period
 targetSetting.byTarget1 = &H0     ' Setting target 1: None
 targetSetting.byTarget2 = &H0     ' Setting target 2: None
 targetSetting.byTarget3 = &H0     ' Setting target 3: None
 targetSetting.byTarget4 = &H0     ' Setting target 4: None
 
 txtboxDepth.Text = Hex$(depth)
 txtboxType.Text = Hex$(targetSetting.byType)
 txtboxCategory.Text = Hex$(targetSetting.byCategory)
 txtboxItem.Text = Hex$(targetSetting.byItem)
 txtboxTarget1.Text = Hex$(targetSetting.byTarget1)
 txtboxTarget2.Text = Hex$(targetSetting.byTarget2)
 txtboxTarget3.Text = Hex$(targetSetting.byTarget3)
 txtboxTarget4.Text = Hex$(targetSetting.byTarget4)
 txtboxParameter.Text = CStr(CInt(&H3))
End Sub

Private Function TrimChars(strTarget As String, strTrimChars As String) As String
 Dim strTrimStart As String
 
 Dim i As Integer
 For i = 1 To Len(strTarget)
  If InStr(1, strTrimChars, Mid$(strTarget, i, 1)) <= 0 Then
   strTrimStart = Mid$(strTarget, i)
   Exit For
  End If
 Next i
 
 Dim strTrimEnd As String
 
 For i = Len(strTrimStart) To 1 Step -1
  If InStr(1, strTrimChars, Mid$(strTrimStart, i, 1)) <= 0 Then
   strTrimEnd = Mid$(strTrimStart, 1, i)
   Exit For
  End If
 Next i
 TrimChars = strTrimEnd
End Function

