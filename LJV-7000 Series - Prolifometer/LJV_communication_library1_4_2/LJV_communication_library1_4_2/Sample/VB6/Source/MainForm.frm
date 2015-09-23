VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form MainForm 
   BorderStyle     =   3  'å≈íË¿ﬁ≤±€∏ﬁ
   Caption         =   "DLL Function Sample"
   ClientHeight    =   9870
   ClientLeft      =   315
   ClientTop       =   2385
   ClientWidth     =   15150
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   9
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "MainForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   9870
   ScaleWidth      =   15150
   Begin TabDlg.SSTab SSTab1 
      Height          =   9855
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   15135
      _ExtentX        =   26696
      _ExtentY        =   17383
      _Version        =   393216
      Tabs            =   2
      TabHeight       =   520
      TabCaption(0)   =   "[DLL functions] Simple function sample"
      TabPicture(0)   =   "MainForm.frx":000C
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "grpCommand"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "Frame14"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).ControlCount=   2
      TabCaption(1)   =   "[DLL functions] Combination sample"
      TabPicture(1)   =   "MainForm.frx":0028
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame6"
      Tab(1).Control(1)=   "Frame4"
      Tab(1).Control(2)=   "Frame22"
      Tab(1).ControlCount=   3
      Begin VB.Frame Frame22 
         Caption         =   "Establish/disconnect the communication path with the controller"
         Height          =   3255
         Left            =   -74760
         TabIndex        =   91
         Top             =   600
         Width           =   6855
         Begin VB.OptionButton OptionEthernet 
            Caption         =   "Ethernet"
            Height          =   255
            Left            =   240
            TabIndex        =   96
            Top             =   1200
            Width           =   1095
         End
         Begin VB.Frame Frame3 
            Height          =   1815
            Left            =   360
            TabIndex        =   95
            Top             =   1200
            Width           =   6135
            Begin VB.TextBox TextIpPortHighSpeed 
               Height          =   315
               Left            =   5040
               TabIndex        =   108
               Text            =   "24692"
               Top             =   1200
               Width           =   855
            End
            Begin VB.TextBox TextIpaddr3 
               BeginProperty DataFormat 
                  Type            =   1
                  Format          =   "0"
                  HaveTrueFalseNull=   0
                  FirstDayOfWeek  =   0
                  FirstWeekOfYear =   0
                  LCID            =   1041
                  SubFormatType   =   1
               EndProperty
               Height          =   315
               Left            =   4800
               MaxLength       =   3
               TabIndex        =   103
               Text            =   "0"
               Top             =   240
               Width           =   495
            End
            Begin VB.TextBox TextIpaddr4 
               BeginProperty DataFormat 
                  Type            =   1
                  Format          =   "0"
                  HaveTrueFalseNull=   0
                  FirstDayOfWeek  =   0
                  FirstWeekOfYear =   0
                  LCID            =   1041
                  SubFormatType   =   1
               EndProperty
               Height          =   315
               Left            =   5400
               MaxLength       =   3
               TabIndex        =   104
               Text            =   "1"
               Top             =   240
               Width           =   495
            End
            Begin VB.TextBox TextIpaddr1 
               BeginProperty DataFormat 
                  Type            =   1
                  Format          =   "0"
                  HaveTrueFalseNull=   0
                  FirstDayOfWeek  =   0
                  FirstWeekOfYear =   0
                  LCID            =   1041
                  SubFormatType   =   1
               EndProperty
               Height          =   315
               Left            =   3600
               MaxLength       =   3
               TabIndex        =   98
               Text            =   "192"
               Top             =   240
               Width           =   495
            End
            Begin VB.TextBox TextIpaddr2 
               BeginProperty DataFormat 
                  Type            =   1
                  Format          =   "0"
                  HaveTrueFalseNull=   0
                  FirstDayOfWeek  =   0
                  FirstWeekOfYear =   0
                  LCID            =   1041
                  SubFormatType   =   1
               EndProperty
               Height          =   315
               Left            =   4200
               MaxLength       =   3
               TabIndex        =   100
               Text            =   "168"
               Top             =   240
               Width           =   495
            End
            Begin VB.TextBox TextIpPort 
               Height          =   315
               Left            =   5040
               MaxLength       =   5
               TabIndex        =   106
               Text            =   "24691"
               Top             =   720
               Width           =   855
            End
            Begin VB.Label Label27 
               Caption         =   "TCP port number (high-speed communication)"
               Height          =   255
               Left            =   480
               TabIndex        =   107
               Top             =   1240
               Width           =   3975
            End
            Begin VB.Label LabelIP 
               Caption         =   "IP address"
               Height          =   255
               Left            =   480
               TabIndex        =   97
               Top             =   280
               Width           =   975
            End
            Begin VB.Label Label2 
               Caption         =   "."
               Height          =   255
               Left            =   4080
               TabIndex        =   99
               Top             =   360
               Width           =   135
            End
            Begin VB.Label Label4 
               Caption         =   "."
               Height          =   255
               Left            =   4680
               TabIndex        =   101
               Top             =   360
               Width           =   135
            End
            Begin VB.Label Label5 
               Caption         =   "."
               Height          =   255
               Left            =   5280
               TabIndex        =   102
               Top             =   360
               Width           =   135
            End
            Begin VB.Label LabelPort 
               Caption         =   "TCP port number"
               Height          =   255
               Left            =   480
               TabIndex        =   105
               Top             =   760
               Width           =   2055
            End
         End
         Begin VB.OptionButton OptionUSB 
            Caption         =   "USB"
            Height          =   255
            Left            =   240
            TabIndex        =   94
            Top             =   840
            Value           =   -1  'True
            Width           =   735
         End
         Begin VB.CommandButton Finalization 
            Caption         =   "Communication finalization"
            Height          =   375
            Left            =   3360
            TabIndex        =   93
            Top             =   360
            Width           =   3015
         End
         Begin VB.CommandButton Initialization 
            Caption         =   "Communication establishment"
            Height          =   375
            Left            =   240
            TabIndex        =   92
            Top             =   360
            Width           =   3015
         End
      End
      Begin VB.Frame Frame14 
         Caption         =   "Setting / Result"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   9375
         Left            =   9720
         TabIndex        =   47
         Top             =   360
         Width           =   5295
         Begin VB.PictureBox Picture1 
            BackColor       =   &H00C0C0C0&
            Height          =   2175
            Left            =   120
            ScaleHeight     =   2115
            ScaleWidth      =   4995
            TabIndex        =   49
            TabStop         =   0   'False
            Top             =   480
            Width           =   5055
            Begin VB.Frame Frame1 
               BackColor       =   &H00C0C0C0&
               BorderStyle     =   0  'Ç»Çµ
               Caption         =   "Frame1"
               Height          =   1455
               Left            =   120
               TabIndex        =   52
               Top             =   470
               Width           =   495
               Begin VB.OptionButton OptionDevice5 
                  BackColor       =   &H00C0C0C0&
                  Caption         =   "5"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   0
                  TabIndex        =   63
                  Top             =   1200
                  Width           =   495
               End
               Begin VB.OptionButton OptionDevice1 
                  BackColor       =   &H00C0C0C0&
                  Caption         =   "1"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   0
                  TabIndex        =   55
                  Top             =   240
                  Width           =   375
               End
               Begin VB.OptionButton OptionDevice0 
                  BackColor       =   &H00C0C0C0&
                  Caption         =   "0"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   0
                  TabIndex        =   53
                  Top             =   0
                  Value           =   -1  'True
                  Width           =   375
               End
               Begin VB.OptionButton OptionDevice2 
                  BackColor       =   &H00C0C0C0&
                  Caption         =   "2"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   0
                  TabIndex        =   57
                  Top             =   480
                  Width           =   495
               End
               Begin VB.OptionButton OptionDevice4 
                  BackColor       =   &H00C0C0C0&
                  Caption         =   "4"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   0
                  TabIndex        =   61
                  Top             =   960
                  Width           =   495
               End
               Begin VB.OptionButton OptionDevice3 
                  BackColor       =   &H00C0C0C0&
                  Caption         =   "3"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   210
                  Left            =   0
                  TabIndex        =   59
                  Top             =   720
                  Width           =   495
               End
            End
            Begin VB.Label lblDeviceStatus5 
               BackStyle       =   0  'ìßñæ
               Caption         =   "Unconnected"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   840
               TabIndex        =   64
               Top             =   1680
               Width           =   2055
            End
            Begin VB.Label lblDeviceStatus4 
               BackStyle       =   0  'ìßñæ
               Caption         =   "Unconnected"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   840
               TabIndex        =   62
               Top             =   1440
               Width           =   1935
            End
            Begin VB.Label lblDeviceStatus3 
               BackStyle       =   0  'ìßñæ
               Caption         =   "Unconnected"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   840
               TabIndex        =   60
               Top             =   1200
               Width           =   2055
            End
            Begin VB.Label lblDeviceStatus2 
               BackStyle       =   0  'ìßñæ
               Caption         =   "Unconnected"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   840
               TabIndex        =   58
               Top             =   960
               Width           =   1935
            End
            Begin VB.Label lblDeviceStatus1 
               BackStyle       =   0  'ìßñæ
               Caption         =   "Unconnected"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   840
               TabIndex        =   56
               Top             =   720
               Width           =   2055
            End
            Begin VB.Label lblDeviceStatus0 
               BackStyle       =   0  'ìßñæ
               Caption         =   "Unconnected"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   840
               TabIndex        =   54
               Top             =   480
               Width           =   2055
            End
            Begin VB.Label Label8 
               BackStyle       =   0  'ìßñæ
               Caption         =   "State (USB / IP address)"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   700
                  Underline       =   -1  'True
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   600
               TabIndex        =   51
               Top             =   120
               Width           =   2775
            End
            Begin VB.Label Label7 
               BackStyle       =   0  'ìßñæ
               Caption         =   "ID"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   700
                  Underline       =   -1  'True
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   120
               TabIndex        =   50
               Top             =   120
               Width           =   255
            End
         End
         Begin VB.Frame Frame18 
            Caption         =   "Save the results file"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   1575
            Left            =   120
            TabIndex        =   83
            Top             =   7680
            Width           =   5055
            Begin MSComDlg.CommonDialog ProfileFileSavePathDlg 
               Left            =   4440
               Top             =   600
               _ExtentX        =   847
               _ExtentY        =   847
               _Version        =   393216
            End
            Begin VB.TextBox txtboxProfileNo 
               Height          =   315
               Left            =   2400
               TabIndex        =   88
               Text            =   "0"
               Top             =   640
               Width           =   495
            End
            Begin VB.TextBox txtboxProfileFilePath 
               BeginProperty Font 
                  Name            =   "ÇlÇr ÇoÉSÉVÉbÉN"
                  Size            =   9
                  Charset         =   128
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   315
               Left            =   1440
               TabIndex        =   85
               Top             =   240
               Width           =   3015
            End
            Begin VB.CommandButton btnProfileFileSave 
               Caption         =   "..."
               Height          =   255
               Left            =   4560
               TabIndex        =   86
               Top             =   240
               Width           =   375
            End
            Begin VB.CommandButton btnSaveMeasureData 
               Caption         =   "Save the measurement"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2640
               TabIndex        =   90
               Top             =   1080
               Width           =   1815
            End
            Begin VB.CommandButton btnSave 
               Caption         =   "Save the profile"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   600
               TabIndex        =   89
               Top             =   1080
               Width           =   1815
            End
            Begin VB.Label Label26 
               Caption         =   "Index of the profile to save"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   120
               TabIndex        =   87
               Top             =   680
               Width           =   2535
            End
            Begin VB.Label Label25 
               Caption         =   "Save destination"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   120
               TabIndex        =   84
               Top             =   280
               Width           =   1455
            End
         End
         Begin VB.Frame Frame16 
            Caption         =   "Buffer size setting (set and used when reading profiles)"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   2895
            Left            =   120
            TabIndex        =   68
            Top             =   4680
            Width           =   5055
            Begin VB.Frame Frame21 
               Caption         =   "Profiles settings"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   615
               Left            =   120
               TabIndex        =   79
               Top             =   2160
               Width           =   4815
               Begin VB.CheckBox chkboxEnvelope 
                  Caption         =   "Envelope setting"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   3000
                  TabIndex        =   82
                  Top             =   240
                  Value           =   1  '¡™Ø∏
                  Width           =   1695
               End
               Begin VB.ComboBox cmbCompressX 
                  Height          =   330
                  ItemData        =   "MainForm.frx":0044
                  Left            =   1920
                  List            =   "MainForm.frx":0051
                  Style           =   2  'ƒﬁ€ØÃﬂ¿ﬁ≥› ÿΩƒ
                  TabIndex        =   81
                  Top             =   200
                  Width           =   855
               End
               Begin VB.Label Label24 
                  Caption         =   "Compression (X axis)"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   120
                  TabIndex        =   80
                  Top             =   240
                  Width           =   1815
               End
            End
            Begin VB.Frame Frame20 
               Caption         =   "Imaging settings"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   1095
               Left            =   120
               TabIndex        =   74
               Top             =   1080
               Width           =   4815
               Begin VB.ComboBox cmbReceiveBinning 
                  Height          =   330
                  ItemData        =   "MainForm.frx":0060
                  Left            =   2520
                  List            =   "MainForm.frx":006A
                  Style           =   2  'ƒﬁ€ØÃﬂ¿ﬁ≥› ÿΩƒ
                  TabIndex        =   78
                  Top             =   600
                  Width           =   1935
               End
               Begin VB.ComboBox cmbMeasureX 
                  Height          =   330
                  ItemData        =   "MainForm.frx":0077
                  Left            =   2520
                  List            =   "MainForm.frx":0084
                  Style           =   2  'ƒﬁ€ØÃﬂ¿ﬁ≥› ÿΩƒ
                  TabIndex        =   76
                  Top             =   240
                  Width           =   1935
               End
               Begin VB.Label Label23 
                  Caption         =   "Binning"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   120
                  TabIndex        =   77
                  Top             =   640
                  Width           =   2535
               End
               Begin VB.Label Label22 
                  Caption         =   "Measurement range X direction"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   120
                  TabIndex        =   75
                  Top             =   280
                  Width           =   2775
               End
            End
            Begin VB.Frame Frame19 
               Caption         =   "Head"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   615
               Left            =   120
               TabIndex        =   70
               Top             =   480
               Width           =   4815
               Begin VB.OptionButton rdbtnWide 
                  Caption         =   "Two heads (wide)"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   2880
                  TabIndex        =   73
                  Top             =   240
                  Width           =   1815
               End
               Begin VB.OptionButton v 
                  Caption         =   "Two Head"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   1560
                  TabIndex        =   72
                  Top             =   240
                  Value           =   -1  'True
                  Width           =   1335
               End
               Begin VB.OptionButton rdbtnOneHead 
                  Caption         =   "One Head"
                  BeginProperty Font 
                     Name            =   "Tahoma"
                     Size            =   8.25
                     Charset         =   0
                     Weight          =   400
                     Underline       =   0   'False
                     Italic          =   0   'False
                     Strikethrough   =   0   'False
                  EndProperty
                  Height          =   255
                  Left            =   240
                  TabIndex        =   71
                  Top             =   240
                  Width           =   1215
               End
            End
            Begin VB.Label Label29 
               Caption         =   "*Match the setting of the controller with this application"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   255
               Left            =   120
               TabIndex        =   69
               Top             =   240
               Width           =   4695
            End
         End
         Begin VB.Frame Frame15 
            Caption         =   "Operation result log"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   2055
            Left            =   120
            TabIndex        =   65
            Top             =   2640
            Width           =   5055
            Begin VB.CommandButton ClearLog 
               Caption         =   "Clear the log"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   66
               Top             =   260
               Width           =   1455
            End
            Begin VB.TextBox txtboxLog 
               BeginProperty Font 
                  Name            =   "@ÇlÇr ÉSÉVÉbÉN"
                  Size            =   9
                  Charset         =   128
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   1215
               Left            =   120
               MultiLine       =   -1  'True
               ScrollBars      =   2  'êÇíº
               TabIndex        =   67
               Top             =   720
               Width           =   4815
            End
         End
         Begin VB.Label Label3 
            Caption         =   "Controller connection status (Up to 6 units can be connected)"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   120
            TabIndex        =   48
            Top             =   240
            Width           =   4575
         End
      End
      Begin VB.Frame grpCommand 
         Caption         =   "Communication command"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   9375
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   9495
         Begin VB.Frame Frame13 
            Caption         =   "Storage-related functions"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   1215
            Left            =   120
            TabIndex        =   40
            Top             =   7200
            Width           =   9255
            Begin VB.CommandButton btnGetStorageBatchProfile 
               Caption         =   "GetStorageBatchProfile"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   46
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnGetStorageProfile 
               Caption         =   "GetStorageProfile"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   45
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnGetStorageStatus 
               Caption         =   "GetStorageStatus"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   43
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnStopStorage 
               Caption         =   "StopStorage"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   42
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnStartStorage 
               Caption         =   "StartStorage"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   41
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnGetStorageData 
               Caption         =   "GetStorageData"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   6960
               TabIndex        =   44
               Top             =   240
               Width           =   2175
            End
         End
         Begin VB.Frame Frame12 
            Caption         =   "Get measurement results"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   1215
            Left            =   120
            TabIndex        =   34
            Top             =   5880
            Width           =   9255
            Begin VB.CommandButton btnGetProfileAdvance 
               Caption         =   "GetProfileAdvance"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   38
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnGetBatchProfile 
               Caption         =   "GetBatchProfile"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   37
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnGetProfile 
               Caption         =   "GetProfile"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   36
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnGetMeasurementValue 
               Caption         =   "GetMeasurementValue"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   35
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnGetBatchProfileAdvance 
               Caption         =   "GetBatchProfileAdvance"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   6960
               TabIndex        =   39
               Top             =   720
               Width           =   2175
            End
         End
         Begin VB.Frame Frame11 
            Caption         =   "Functions related to modifying or reading settings"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   1695
            Left            =   120
            TabIndex        =   23
            Top             =   4080
            Width           =   9255
            Begin VB.CommandButton btnGetActiveProgram 
               Caption         =   "GetActiveProgram"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   33
               Top             =   1200
               Width           =   2175
            End
            Begin VB.CommandButton btnChangeActiveProgram 
               Caption         =   "ChangeActiveProgram"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   32
               Top             =   1200
               Width           =   2175
            End
            Begin VB.CommandButton btnGetTime 
               Caption         =   "GetTime"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   6960
               TabIndex        =   31
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnSetTime 
               Caption         =   "SetTime"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   30
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnCheckMemoryAccess 
               Caption         =   "CheckMemoryAccess"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   29
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnRewriteTemporarySetting 
               Caption         =   "RewriteTemporarySetting"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   28
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnReflectSetting 
               Caption         =   "ReflectSetting"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   6960
               TabIndex        =   27
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnInitializeSetting 
               Caption         =   "InitializeSetting"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   26
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnGetSetting 
               Caption         =   "GetSetting"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   25
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnSetSetting 
               Caption         =   "SetSetting"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   24
               Top             =   240
               Width           =   2175
            End
         End
         Begin VB.Frame Frame10 
            Caption         =   "Measurement control"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   1215
            Left            =   120
            TabIndex        =   15
            Top             =   2760
            Width           =   9255
            Begin VB.CommandButton btnAutoZero 
               Caption         =   "AutoZero"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   6960
               TabIndex        =   19
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnClearMemmory 
               Caption         =   "ClearMemmory"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   22
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnReset 
               Caption         =   "Reset"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   21
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnTiming 
               Caption         =   "Timing"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   20
               Top             =   720
               Width           =   2175
            End
            Begin VB.CommandButton btnStopMeasure 
               Caption         =   "StopMeasure"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   18
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnStartMeasure 
               Caption         =   "StartMeasure"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   17
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnTrigger 
               Caption         =   "Trigger"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   16
               Top             =   240
               Width           =   2175
            End
         End
         Begin VB.Frame Frame9 
            Caption         =   "System control"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   735
            Left            =   120
            TabIndex        =   10
            Top             =   1920
            Width           =   9255
            Begin VB.CommandButton btnClearError 
               Caption         =   "ClearError"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   6960
               TabIndex        =   14
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnGetError 
               Caption         =   "GetError"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   13
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnReturnToFactorySetting 
               Caption         =   "ReturnToFactorySetting"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   12
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnRebootController 
               Caption         =   "RebootController"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   11
               Top             =   240
               Width           =   2175
            End
         End
         Begin VB.Frame Frame8 
            Caption         =   "Establish/disconnect the communication path with the controller"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   735
            Left            =   120
            TabIndex        =   6
            Top             =   1080
            Width           =   9255
            Begin VB.CommandButton btnCommClose 
               Caption         =   "CommClose"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   9
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnEthernetOpen 
               Caption         =   "EthernetOpen"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   8
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnUsbOpen 
               Caption         =   "UsbOpen"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   7
               Top             =   240
               Width           =   2175
            End
         End
         Begin VB.Frame Frame7 
            Caption         =   "Operations for the DLL"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   735
            Left            =   120
            TabIndex        =   2
            Top             =   240
            Width           =   9255
            Begin VB.CommandButton btnFinalize 
               Caption         =   "Finalize"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   4680
               TabIndex        =   5
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnGetVersion 
               Caption         =   "GetVersion"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2400
               TabIndex        =   4
               Top             =   240
               Width           =   2175
            End
            Begin VB.CommandButton btnInitialize 
               Caption         =   "Initialize"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   120
               TabIndex        =   3
               Top             =   240
               Width           =   2175
            End
         End
      End
      Begin VB.Frame Frame4 
         Caption         =   "Get measurement results"
         Height          =   4095
         Left            =   -67800
         TabIndex        =   116
         Top             =   600
         Width           =   7695
         Begin MSComDlg.CommonDialog SelectProfilePathDlg 
            Left            =   1560
            Top             =   1320
            _ExtentX        =   847
            _ExtentY        =   847
            _Version        =   393216
            DefaultExt      =   ".txt"
            DialogTitle     =   "Select save path"
            FileName        =   "0"
            Filter          =   "Text Files (*.txt)|*.txt|All Files(*.*)|*.*"
            FilterIndex     =   1
         End
         Begin VB.CommandButton GetCurrentValues 
            Caption         =   "GetCurrentValues"
            Height          =   375
            Left            =   120
            TabIndex        =   117
            Top             =   360
            Width           =   1935
         End
         Begin VB.TextBox TextMeasureResult 
            Height          =   1455
            Left            =   2160
            MultiLine       =   -1  'True
            ScrollBars      =   2  'êÇíº
            TabIndex        =   118
            Top             =   360
            Width           =   5295
         End
         Begin VB.Frame Frame5 
            Caption         =   "Get profiles"
            Height          =   1815
            Left            =   120
            TabIndex        =   119
            Top             =   2040
            Width           =   7335
            Begin VB.TextBox TextProfilePath 
               Height          =   315
               Left            =   1200
               TabIndex        =   121
               Top             =   360
               Width           =   5415
            End
            Begin VB.CommandButton SelectProfilePath 
               Caption         =   "..."
               Height          =   255
               Left            =   6720
               TabIndex        =   122
               Top             =   360
               Width           =   375
            End
            Begin VB.CommandButton GetHighSpeedModeProfiles 
               Caption         =   "Get high-speed mode profiles"
               Height          =   375
               Left            =   240
               TabIndex        =   123
               Top             =   840
               Width           =   3015
            End
            Begin VB.CommandButton GetAdvancedModeProfiles 
               Caption         =   "Get advanced mode profiles"
               Height          =   375
               Left            =   240
               TabIndex        =   125
               Top             =   1320
               Width           =   3015
            End
            Begin VB.CommandButton GetHighSpeedModeBatchProfiles 
               Caption         =   "Get high-speed mode batch profiles"
               Height          =   375
               Left            =   3360
               TabIndex        =   124
               Top             =   840
               Width           =   3735
            End
            Begin VB.CommandButton GetAdvancedModeBatchProfiles 
               Caption         =   "Get advanced mode batch profiles"
               Height          =   375
               Left            =   3360
               TabIndex        =   126
               Top             =   1320
               Width           =   3735
            End
            Begin VB.Label Label1 
               Caption         =   "Save path"
               Height          =   255
               Left            =   240
               TabIndex        =   120
               Top             =   400
               Width           =   975
            End
         End
      End
      Begin VB.Frame Frame6 
         Caption         =   "Reading or writing settings for each program number"
         Height          =   1935
         Left            =   -74760
         TabIndex        =   109
         Top             =   3960
         Width           =   6855
         Begin MSComDlg.CommonDialog SelectProgramPathDlg 
            Left            =   5280
            Top             =   240
            _ExtentX        =   847
            _ExtentY        =   847
            _Version        =   393216
            DefaultExt      =   ".bin"
            DialogTitle     =   "Select program path"
            Filter          =   "Binary Files (*.bin)|*.bin|All Files(*.*)|*.*"
            FilterIndex     =   1
         End
         Begin VB.CommandButton UploadProgram 
            Caption         =   "Sending settings (PC -> LJ)"
            Height          =   375
            Left            =   360
            TabIndex        =   114
            Top             =   1320
            Width           =   3015
         End
         Begin VB.CommandButton SelectProgramPath 
            Caption         =   "..."
            Height          =   255
            Left            =   6120
            TabIndex        =   113
            Top             =   840
            Width           =   375
         End
         Begin VB.TextBox TextProgramPath 
            Height          =   315
            Left            =   360
            TabIndex        =   112
            Top             =   840
            Width           =   5655
         End
         Begin VB.CommandButton DownloadProgram 
            Caption         =   "Recieving settings (LJ -> PC)"
            Height          =   375
            Left            =   3480
            TabIndex        =   115
            Top             =   1320
            Width           =   3015
         End
         Begin VB.ComboBox SelectProgramArea 
            Height          =   330
            ItemData        =   "MainForm.frx":009D
            Left            =   2280
            List            =   "MainForm.frx":00D7
            Style           =   2  'ƒﬁ€ØÃﬂ¿ﬁ≥› ÿΩƒ
            TabIndex        =   111
            Top             =   360
            Width           =   1935
         End
         Begin VB.Label Label6 
            Caption         =   "Select the program"
            Height          =   255
            Left            =   360
            TabIndex        =   110
            Top             =   390
            Width           =   1935
         End
      End
   End
End
Attribute VB_Name = "MainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="MainForm.frm" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Constant values
Private Const DeviceID As Long = 0

'------ Enumulations
'Send command definition(Defined for separate return code distinction)
Public Enum EnumSendCommand
    'None
    None = 0
    'Restart
    RebootController = 1
    'Trigger
    Trigger = 2
    'Start measurement
    StartMeasure = 3
    'Stop measurement
    StopMeasure = 4
    'Auto zero
    AutoZero = 5
    'Timing
    Timing = 6
    'Reset
    Reset = 7
    'Program switch
    ChangeActiveProgram = 8
    'Get measurement results
    GetMeasurementValue = 9
    'Get profiles
    GetProfile = 10
    'Get batch profiles (operation mode "high-speed (profile only)")
    GetBatchProfile = 11
    'Get profiles (operation mode "advanced (with OUT measurement)")
    GetProfileAdvance = 12
    'Get batch profiles (operation mode "advanced (with OUT measurement)").
    GetBatchProfileAdvance = 13
    'Start storage
    StartStorage = 14
    'Stop storage
    StopStorage = 15
    'Get storage status
    GetStorageStatus = 16
    'Manual storage request
    RequestStorage = 17
    'Get storage data
    getStorageData = 18
    'Get profile storage data
    GetStorageProfile = 19
    'Get batch profile storage data.
    GetStorageBatchProfile = 20
    'Initialize USB high-speed data communication
    HighSpeedDataUsbCommunicationInitalize = 21
    'Initialize Ethernet high-speed data communication
    HighSpeedDataEthernetCommunicationInitalize = 22
    'Request preparation before starting high-speed data communication
    PreStartHighSpeedDataCommunication = 23
    'Start high-speed data communication
    StartHighSpeedDataCommunication = 24
End Enum

'------ Field
Private measureDataCollection As Collection

'Current device ID
Private currentDeviceId As Long

'Send command
Private sendCommand As EnumSendCommand

'Array of controller infomation
Private deviceData(LJV7IF_DEVICE_COUNT - 1) As ClassDeviceData

'------ Event handler(for single-function)
'-- Button for operating the DLL
'"Initialize" button clicked.
Private Sub btnInitialize_Click()
 Dim rc As Long
 rc = LJV7IF_Initialize()
 Call AddLogResult(rc, SID_INITIALIZE)
 
 Dim i As Integer
 For i = 0 To UBound(deviceData) Step 1
  deviceData(i).DeviceStatus = DeviceStatus.NoConnection
 Next i
 Call UpdateDeviceStatus
End Sub

'"GetVersion" button clicked.
Private Sub btnGetVersion_Click()
 Dim rc As Long
 rc = LJV7IF_GetVersion
 Call AddLogResult(Rc_Ok, SID_GET_VERSION)
 Call AddLog(Hex(rc))
End Sub

'"Finalize" button clicked.
Private Sub btnFinalize_Click()
 Dim rc As Long
 rc = LJV7IF_Finalize
 Call AddLogResult(rc, SID_FINALIZE)
 
 Dim i As Integer
 For i = 0 To UBound(deviceData) Step 1
  deviceData(i).DeviceStatus = DeviceStatus.NoConnection
 Next i
 Call UpdateDeviceStatus
End Sub

'-- Button for establishing and disconnecting the communication path with the controller
'"UsbOpen" button clicked.
Private Sub btnUsbOpen_Click()
 Dim rc As Long
 rc = LJV7IF_UsbOpen(currentDeviceId)
 ' @Point
 ' # Enter the "_currentDeviceId" set here for the communication settings into the arguments of each DLL function.
 ' # If you want to get data from multiple controllers, prepare and set multiple "_currentDeviceId" values,
 '    enter these values into the arguments of the DLL functions, and then use the functions.
            
 Call AddLogResult(rc, SID_USB_OPEN)
 
 If rc = Rc_Ok Then
  deviceData(currentDeviceId).DeviceStatus = DeviceStatus.Usb
 Else
  deviceData(currentDeviceId).DeviceStatus = DeviceStatus.NoConnection
 End If
 Call UpdateDeviceStatus
End Sub

'"EthernetOpen" button clicked.
Private Sub btnEthernetOpen_Click()
 Dim subForm As OpenEthernetForm
 Set subForm = New OpenEthernetForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim EthernetConfig As LJV7IF_ETHERNET_CONFIG
  EthernetConfig = subForm.GetEthernetConfig
  ' @Point
  ' # Enter the "_currentDeviceId" set here for the communication settings into the arguments of each DLL function.
  ' # If you want to get data from multiple controllers, prepare and set multiple "_currentDeviceId" values,
  '    enter these values into the arguments of the DLL functions, and then use the functions.
  
  Dim rc As Long
  rc = LJV7IF_EthernetOpen(currentDeviceId, EthernetConfig)
  Call AddLogResult(rc, SID_ETHERNET_OPEN)
  
  If rc = Rc_Ok Then
   deviceData(currentDeviceId).DeviceStatus = DeviceStatus.Ethernet
   deviceData(currentDeviceId).LetEthernetConfig = EthernetConfig
  Else
   deviceData(currentDeviceId).DeviceStatus = DeviceStatus.NoConnection
  End If
  Call UpdateDeviceStatus

 End If
 Set subForm = Nothing
End Sub

'"CommClose" button clicked.
Private Sub btnCommClose_Click()
 Dim rc As Long
 rc = LJV7IF_CommClose(currentDeviceId)
 Call AddLogResult(rc, SID_COMM_CLOSE)
 
 deviceData(currentDeviceId).DeviceStatus = DeviceStatus.NoConnection
 Call UpdateDeviceStatus
End Sub

'-- Buttons for controlling the system
'"RebootController" button clicked.
Private Sub btnRebootController_Click()
 sendCommand = EnumSendCommand.RebootController
 
 Dim rc As Long
 rc = LJV7IF_RebootController(currentDeviceId)
 Call AddLogResult(rc, SID_REBOOT_CONTROLLER)
End Sub

'"RetrunToFactorySetting" button clicked.
Private Sub btnReturnToFactorySetting_Click()
 Dim rc As Long
 rc = LJV7IF_RetrunToFactorySetting(currentDeviceId)
 Call AddLogResult(rc, SID_RETRUN_TO_FACTORY_SETTING)
End Sub

'"GetError" button clicked.
Private Sub btnGetError_Click()
 Dim subForm As GetErrorForm
 Set subForm = New GetErrorForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim errCnt As Byte
  Dim errCode() As Integer
  
  Dim errCodeCnt As Integer
  If CInt(subForm.GetRcvMax) >= 1 Then
   errCodeCnt = CInt(subForm.GetRcvMax)
  Else
   errCodeCnt = 1
  End If
  ReDim errCode(CInt(errCodeCnt))
  
  Dim rc As Long
  rc = LJV7IF_GetError(currentDeviceId, subForm.GetRcvMax, errCnt, errCode(0))
  Call AddLogResult(rc, SID_GET_ERROR)
  If rc = Rc_Ok Then
   AddLog ("ErrCnt:" & Hex$(errCnt))
   Dim i As Integer
   For i = 0 To (errCnt - 1) Step 1
    AddLog ("ErrorCode[" & CStr(i) & "]" & ":0x" & Right("0000" & Hex(errCode(i)), 4))
   Next i
  End If
 End If
 Set subForm = Nothing
End Sub


'"ClearError" button clicked.
Private Sub btnClearError_Click()
 Dim subForm As ClearErrorForm
 Set subForm = New ClearErrorForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_ClearError(currentDeviceId, subForm.GetErrCode)
  Call AddLogResult(rc, SID_CLEAR_ERROR)
 End If
 Set subForm = Nothing
End Sub

'-- Buttons for controlling measurements
'"Trigger" button clicked.
Private Sub btnTrigger_Click()
 sendCommand = EnumSendCommand.Trigger
 
 Dim rc As Long
 rc = LJV7IF_Trigger(currentDeviceId)
 Call AddLogResult(rc, SID_TRIGGER)
End Sub

'"StartMeasure" button clicked.
Private Sub btnStartMeasure_Click()
 sendCommand = EnumSendCommand.StartMeasure
 
 Dim rc As Long
 rc = LJV7IF_StartMeasure(currentDeviceId)
 Call AddLogResult(rc, SID_START_MEASURE)
End Sub

'"StopMeasure" button clicked.
Private Sub btnStopMeasure_Click()
 sendCommand = EnumSendCommand.StopMeasure
 
 Dim rc As Long
 rc = LJV7IF_StopMeasure(currentDeviceId)
 Call AddLogResult(rc, SID_STOP_MEASURE)
End Sub

'"AutoZero" button clicked.
Private Sub btnAutoZero_Click()
 sendCommand = EnumSendCommand.AutoZero
 
 Dim subForm As OutSelectForm
 Set subForm = New OutSelectForm
 Call subForm.InitializeOutSelectForm(True)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_AutoZero(currentDeviceId, subForm.GetOnOff, subForm.GetOut)
  Call AddLogResult(rc, SID_AUTO_ZERO)
 End If
 Set subForm = Nothing
End Sub

'"Timing" button clicked.
Private Sub btnTiming_Click()
 sendCommand = EnumSendCommand.Timing
 
 Dim subForm As OutSelectForm
 Set subForm = New OutSelectForm
 Call subForm.InitializeOutSelectForm(True)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_Timing(currentDeviceId, subForm.GetOnOff, subForm.GetOut)
  Call AddLogResult(rc, SID_TIMING)
 End If
 Set subForm = Nothing
End Sub

'"Reset" button clicked.
Private Sub btnReset_Click()
 sendCommand = EnumSendCommand.Reset
 
 Dim subForm As OutSelectForm
 Set subForm = New OutSelectForm
 Call subForm.InitializeOutSelectForm(False)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_Reset(currentDeviceId, subForm.GetOut)
  Call AddLogResult(rc, SID_RESET)
 End If
 Set subForm = Nothing
End Sub

'"ClearMemory" button clicked.
Private Sub btnClearMemmory_Click()
 Dim rc As Long
 rc = LJV7IF_ClearMemory(currentDeviceId)
 Call AddLogResult(rc, SID_CLEAR_MEMORY)
End Sub

'-- Buttons for modifying or reading settings
'"SetSetting" button clicked.
Private Sub btnSetSetting_Click()
 Dim subForm As SettingForm

 Set subForm = New SettingForm
 Call subForm.InitializeSettingForm(True)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim targetSetting As LJV7IF_TARGET_SETTING
  targetSetting = subForm.GetTargetSetting
 
  'Reserve buffer
  Dim buffer() As Byte
  Call subForm.GetData(buffer)
  
  Dim rc As Long
  Dim dwError As Long
  rc = LJV7IF_SetSettingEx(currentDeviceId, subForm.GetDepth, targetSetting, buffer(0), subForm.GetDataLength, dwError)
  ' @Point
  ' # There are three setting areas: a) the write settings area, b) the running area, and c) the save area.
  '   * Specify a) for the setting level when you want to change multiple settings. However, to reflect settings in the LJ-V operations, you have to call LJV7IF_ReflectSetting.
  '   * Specify b) for the setting level when you want to change one setting but you don't mind if this setting is returned to its value prior to the change when the power is turned off.
  '   * Specify c) for the setting level when you want to change one setting and you want this new value to be retained even when the power is turned off.

  ' @Point
  '  As a usage example, we will show how to use SettingForm to configure settings such that sending a setting, with SettingForm using its initial values,
  '  will change the sampling period in the running area to "100 Hz."
  '  Also see the GetSetting function.
 
  Call AddLogResult(rc, SID_SET_SETTING)
  If rc <> Rc_Ok Then
   Call AddLog("    Error Code :" & CLng(dwError))
  End If
 End If
 Set subForm = Nothing
End Sub

'"GetSetting" button clicked.
Private Sub btnGetSetting_Click()
 Dim subForm As SettingForm

 Set subForm = New SettingForm
 Call subForm.InitializeSettingForm(False)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim targetSetting As LJV7IF_TARGET_SETTING
  targetSetting = subForm.GetTargetSetting
  
  'Reserve buffer
  Dim buffer() As Byte
  ReDim buffer(subForm.GetDataLength - 1)
  
  Dim rc As Long
  Dim error As Long
  rc = LJV7IF_GetSettingEx(currentDeviceId, subForm.GetDepth, targetSetting, buffer(0), subForm.GetDataLength)
  ' @Point
  '  We have prepared an object for reading the sampling period into the setting's initial value.
  '  Also see the SetSetting function.

  Call AddLogResult(rc, SID_GET_SETTING)
   
  If rc = Rc_Ok Then
   Call AddLog(vbTab & "         0   1   2   3   4   5   6   7")
      
   Dim str As String
   ' Get data display
   Dim i As Integer
   For i = 0 To (subForm.GetDataLength - 1) Step 1
    If (i Mod 8) = 0 Then
     str = str & vbTab & "[0x" & Right("0000" & Hex(i), 4) & "] "
    End If
    str = str & Format(buffer(i), "00") & "  "
    If ((i Mod 8) = 7) Or (i = (subForm.GetDataLength - 1)) Then
     AddLog (str)
     str = ""
    End If
   Next i
  End If
 End If
 Set subForm = Nothing
End Sub

'"InitializeSetting" button clicked.
Private Sub btnInitializeSetting_Click()
 Dim subForm As DepthProgramSelectForm
 Set subForm = New DepthProgramSelectForm
 Call subForm.InitializeDepthProgramSelectForm(True, True)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_InitializeSetting(currentDeviceId, subForm.GetDepth, subForm.GetTarget)
  Call AddLogResult(rc, SID_INITIALIZE_SETTING)
 End If
 Set subForm = Nothing
End Sub

'"ReflectSetting" button clicked.
Private Sub btnReflectSetting_Click()
 Dim subForm As DepthProgramSelectForm
 Set subForm = New DepthProgramSelectForm
 Call subForm.InitializeDepthProgramSelectForm(True, False)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  Dim dwError As Long
  dwError = 0
  rc = LJV7IF_ReflectSetting(currentDeviceId, subForm.GetDepth, dwError)
  
  Call AddLogResult(rc, SID_REFLECT_SETTING)
  If rc <> Rc_Ok Then
   Call AddLog("    Error Code :" & CLng(dwError))
  End If
 End If
 Set subForm = Nothing
End Sub

'"RewriteTemporarySetting" button clicked.
Private Sub btnRewriteTemporarySetting_Click()
 Dim subForm As DepthProgramSelectForm
 Set subForm = New DepthProgramSelectForm
 Call subForm.InitializeDepthProgramSelectForm(True, False)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_RewriteTemporarySetting(currentDeviceId, subForm.GetDepth)
  Call AddLogResult(rc, SID_REWRITE_TEMPORARY_SETTING)
 End If
 Set subForm = Nothing
End Sub

'"CheckMemoryAccess" button clicked.
Private Sub btnCheckMemoryAccess_Click()
 Dim busy As Byte
 busy = 0
 Dim rc As Long
 rc = LJV7IF_CheckMemoryAccess(currentDeviceId, busy)
 Call AddLogResult(rc, SID_CHECK_MEMORY_ACCESS)
 If rc = Rc_Ok Then
  If busy <> 0 Then
   AddLog ("Accessing the save area")
  Else
   AddLog ("No access")
  End If
 End If
End Sub

'"SetTime" button clicked.
Private Sub btnSetTime_Click()
 Dim subForm As TimeForm
 Set subForm = New TimeForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim time As LJV7IF_TIME
  time = subForm.GetTime
  Dim rc As Long
  rc = LJV7IF_SetTime(currentDeviceId, time)
  Call AddLogResult(rc, SID_SET_TIME)
 End If
 Set subForm = Nothing
End Sub

'"GetTime" button clicked.
Private Sub btnGetTime_Click()
 Dim time As LJV7IF_TIME
 Dim rc As Long
 rc = LJV7IF_GetTime(currentDeviceId, time)
 Call AddLogResult(rc, SID_GET_TIME)
 If rc = Rc_Ok Then
  AddLog (ConvertTimeToLogString(time))
 End If
End Sub

'"ChangeActiveProgram" button clicked.
Private Sub btnChangeActiveProgram_Click()
 sendCommand = EnumSendCommand.ChangeActiveProgram
 
 Dim subForm As DepthProgramSelectForm
 Set subForm = New DepthProgramSelectForm
 Call subForm.InitializeDepthProgramSelectForm(False, True)
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim rc As Long
  rc = LJV7IF_ChangeActiveProgram(currentDeviceId, subForm.GetTarget)
  Call AddLogResult(rc, SID_CHANGE_ACTIVE_PROGRAM)
 End If
 Set subForm = Nothing
End Sub

'"GetActiveProgram" button clicked.
Private Sub btnGetActiveProgram_Click()
 Dim progNo As Byte
 Dim rc As Long
 rc = LJV7IF_GetActiveProgram(currentDeviceId, progNo)
 Call AddLogResult(rc, SID_GET_ACTIVE_PROGRAM)
 If rc = Rc_Ok Then
  AddLog ("ProgNo:" & CStr(progNo))
 End If
End Sub

'-- Button for getting the measurement results
'"GetMeasurementValue" button clicked.
Private Sub btnGetMeasurementValue_Click()
 sendCommand = EnumSendCommand.GetMeasurementValue
 
 Dim measureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
 Dim rc As Long
 rc = LJV7IF_GetMeasurementValue(currentDeviceId, measureData(0))
 Call AddLogResult(rc, SID_GET_MEASUREMENT_VALUE)
 
 If rc = Rc_Ok Then
  Call ClearMeasureDataCollection
  Dim newMesureData As ClassMeasureData
  Set newMesureData = New ClassMeasureData
  Call newMesureData.CreateMeasureData(measureData)
  Call measureDataCollection.Add(newMesureData)
  
  Dim i As Integer
   For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
    AddLog ("  OUT" & Format(i + 1, "00") & ": " & ConvertMeasureDataToLogString(measureData(i)))
   Next i
 End If
End Sub

'"GetProfile" button clicked.
Private Sub btnGetProfile_Click()
 sendCommand = EnumSendCommand.GetProfile
 
 Dim subForm As ProfileForm
 Set subForm = New ProfileForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  deviceData(currentDeviceId).ClearProfileData
  deviceData(currentDeviceId).ClearMeasureData
  
  Dim req As LJV7IF_GET_PROFILE_REQ
  Dim rsp As LJV7IF_GET_PROFILE_RSP
  Dim profileInfo As LJV7IF_PROFILE_INFO
  Dim oneProfDataBuffSize As Long
  Dim allProfDatabuffSize As Long
  Dim profileData() As Long
  
  req = subForm.GetReq
  oneProfDataBuffSize = GetOneProfileDataSize()
  allProfDatabuffSize = oneProfDataBuffSize * req.byGetProfCnt
  ReDim profileData(allProfDatabuffSize / SIGNED_LONG_SIZE - 1)
 
  Dim rc As Long
  rc = LJV7IF_GetProfile(currentDeviceId, req, rsp, profileInfo, profileData(0), allProfDatabuffSize)
  Call AddLogResult(rc, SID_GET_PROFILE)
  If rc = Rc_Ok Then
   'Response data display
   AddLog (ConvertProfileRspToLogString(rsp))
   AddLog (ConvertProfileInfoToLogString(profileInfo))
   
   Call AnalyzeProfileData(CInt(rsp.byGetProfCnt), profileInfo, profileData)
      
   'Profile export
   Dim deviceProfileData As Collection
   Call deviceData(currentDeviceId).GetProfile(deviceProfileData)
   If ExportOneProfile(deviceProfileData, 0, txtboxProfileFilePath.Text) Then
    AddLog ("###Saved!")
   End If
  End If
 End If
 Set subForm = Nothing
End Sub

'"GetBatchProfile" button clicked.
Private Sub btnGetBatchProfile_Click()
 sendCommand = EnumSendCommand.GetBatchProfile
 
 Dim subForm As GetBatchProfileForm
 Set subForm = New GetBatchProfileForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  deviceData(currentDeviceId).ClearProfileData
  deviceData(currentDeviceId).ClearMeasureData
  
  'Set the command function
  Dim req As LJV7IF_GET_BATCH_PROFILE_REQ
  Dim rsp As LJV7IF_GET_BATCH_PROFILE_RSP
  Dim profileInfo As LJV7IF_PROFILE_INFO
  Dim oneDataSize As Long
  Dim allDataSize As Long
  Dim profileData() As Long
    
  req = subForm.GetReq
  oneDataSize = GetOneProfileDataSize
  allDataSize = oneDataSize * req.byGetProfCnt
  ReDim profileData(allDataSize / SIGNED_LONG_SIZE - 1)
 
  'Send the command
  Dim rc As Long
  rc = LJV7IF_GetBatchProfile(currentDeviceId, req, rsp, profileInfo, profileData(0), allDataSize)
  ' @Point
  ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
  ' # To read the remaining profiles after the first set of profiles have been read,
  '    set the specification method (byPosMode)to 0x02, specify the batch number (dwGetBatchNo),
  '    and then set the number to start reading profiles from (dwGetProfNo) and the number of profiles to read (byGetProfCnt) to values
  '    that specify a range of profiles that have not been read to read the profiles in order.
  ' # For the basic code, see "GetHighSpeedModeBatchProfiles_Click"
                        
  'Result output
  Call AddLogResult(rc, SID_GET_BATCH_PROFILE)
  If rc = Rc_Ok Then
   'Response data display
   AddLog (ConvertBatchProfileRspToLogString(rsp))
   AddLog (ConvertProfileInfoToLogString(profileInfo))
   
   Call AnalyzeProfileData(CInt(rsp.byGetProfCnt), profileInfo, profileData)
   
   'Profile Export
   Dim deviceProfileData As Collection
   Call deviceData(currentDeviceId).GetProfile(deviceProfileData)
   If ExportOneProfile(deviceProfileData, 0, txtboxProfileFilePath.Text) Then
    AddLog ("###Saved!")
   End If
  End If
 End If
 Set subForm = Nothing
End Sub

'"GetProfileAdvance" button clicked.
Private Sub btnGetProfileAdvance_Click()
 sendCommand = EnumSendCommand.GetProfileAdvance
 deviceData(currentDeviceId).ClearProfileData
 deviceData(currentDeviceId).ClearMeasureData
 Call ClearMeasureDataCollection
           
 'Set the command function
 Dim profileInfo As LJV7IF_PROFILE_INFO
 Dim dataSize As Long
 Dim profileData() As Long
 Dim measureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
 
 dataSize = GetOneProfileDataSize
 ReDim profileData(dataSize / SIGNED_LONG_SIZE - 1)
 
 'Send the command
 Dim rc As Long
 rc = LJV7IF_GetProfileAdvance(currentDeviceId, profileInfo, profileData(0), dataSize, measureData(0))
 
 'Result output
 Call AddLogResult(rc, SID_GET_PROFILE_ADVANCE)
 If rc = Rc_Ok Then
  'Response data display
  AddLog (ConvertProfileInfoToLogString(profileInfo))
  
  Dim newMesureData As ClassMeasureData
  Set newMesureData = New ClassMeasureData
  Call newMesureData.CreateMeasureData(measureData)
  Call measureDataCollection.Add(newMesureData)
  
  Call AnalyzeProfileData(1, profileInfo, profileData)
  
  Dim i As Integer
  For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
   AddLog ("  OUT" & Format(i + 1, "00") & ": " & ConvertMeasureDataToLogString(measureData(i)))
  Next i
 End If
End Sub

'"GetBatchProfileAdvance" button clicked.
Private Sub btnGetBatchProfileAdvance_Click()
 sendCommand = EnumSendCommand.GetBatchProfileAdvance
 
 Dim subForm As GetBatchProfileAdvanceForm
 Set subForm = New GetBatchProfileAdvanceForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  deviceData(currentDeviceId).ClearProfileData
  deviceData(currentDeviceId).ClearMeasureData
  Call ClearMeasureDataCollection

  'Set the command function
  Dim req As LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ
  Dim rsp As LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP
  Dim profileInfo As LJV7IF_PROFILE_INFO
  Dim oneDataSize As Long
  Dim allDataSize As Long
  Dim profileData() As Long
  Dim measureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
  Dim batchMeasureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
  
  req = subForm.GetReq
  oneDataSize = GetOneProfileDataSize() + MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
  allDataSize = oneDataSize * CInt(req.byGetProfCnt)
  ReDim profileData(allDataSize / SIGNED_LONG_SIZE - 1)
 
  'Send the command
  Dim rc As Long
  rc = LJV7IF_GetBatchProfileAdvance(currentDeviceId, req, rsp, profileInfo, profileData(0), allDataSize, batchMeasureData(0), measureData(0))
  ' @Point
  ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
  ' # To read the remaining profiles after the first set of profiles have been read,
  '    set the specification method (byPosMode)to 0x02, specify the batch number (dwGetBatchNo),
  '    and then set the number to start reading profiles from (dwGetProfNo) and the number of profiles to read (byGetProfCnt) to values
  '    that specify a range of profiles that have not been read to read the profiles in order.
  ' # For the basic code, see "GetHighSpeedModeBatchProfiles_Click"
                                              
  'Result output
  Call AddLogResult(rc, SID_GET_BATCH_PROFILE_ADVANCE)
 
  If rc = Rc_Ok Then
   Dim newMesureData As ClassMeasureData
   Set newMesureData = New ClassMeasureData
   Call newMesureData.CreateMeasureData(measureData)
   Call newMesureData.SetMeasureDataArrayWithOffsetTime(0, measureData)
   Call measureDataCollection.Add(newMesureData)
  
   AddLog (ConvertBatchProfileAdvanceRspToLogString(rsp))
   AddLog (ConvertProfileInfoToLogString(profileInfo))
     
   Dim i As Integer
   For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
    AddLog ("  OUT" & Format(i + 1, "00") & ": " & ConvertMeasureDataToLogString(measureData(i)))
   Next i
   
   Call AnalyzeBatchData(CInt(rsp.byGetProfCnt), profileInfo, False, profileData, 0)
   
   'Profile export
   Dim deviceProfileData As Collection
   Call deviceData(currentDeviceId).GetProfile(deviceProfileData)
   If ExportOneProfile(deviceProfileData, 0, txtboxProfileFilePath.Text) Then
     AddLog ("###Saved!")
   End If
  End If
 End If
 Set subForm = Nothing
End Sub

'-- Button for storage-related functions
'"StartStorage" button clicked.
Private Sub btnStartStorage_Click()
 sendCommand = EnumSendCommand.StartStorage
 
 Dim rc As Long
 rc = LJV7IF_StartStorage(currentDeviceId)
 Call AddLogResult(rc, SID_START_STORAGE)
End Sub

'"StopStorage" button clicked.
Private Sub btnStopStorage_Click()
 sendCommand = EnumSendCommand.StopStorage
 
 Dim rc As Long
 rc = LJV7IF_StopStorage(currentDeviceId)
 Call AddLogResult(rc, SID_STOP_STORAGE)
End Sub

'"GetStorageStatus" button clicked.
Private Sub btnGetStorageStatus_Click()
 sendCommand = EnumSendCommand.GetStorageStatus
 
 Dim subForm As GetStorageStatusForm
 Set subForm = New GetStorageStatusForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Dim req As LJV7IF_GET_STRAGE_STATUS_REQ
  ' @Point
  ' # dwReadArea is the target surface to read.
  '   The target surface to read indicates where in the internal memory usage area to read.
  ' # The method to use in specifying dwReadArea varies depending on how internal memory is allocated.
  '   * Double buffer
  '      0 indicates the active surface, 1 indicates surface A, and 2 indicates surface B.
  '   * Entire area (overwrite)
  '      Fixed to 1
  '   * Entire area (do not overwrite)
  '      After a setting modification, data is saved in surfaces 1, 2, 3, and so on in order, and 0 is set as the active surface.
  ' # For details, see "9.2.9.2 Internal memory."
  
  Dim rsp As LJV7IF_GET_STRAGE_STATUS_RSP
  Dim storageInfo As LJV7IF_STORAGE_INFO
  
  Dim rc As Long
  rc = LJV7IF_GetStorageStatus(currentDeviceId, req, rsp, storageInfo)
  ' @Point
  ' # Terminology
  '  * Base time Åc time expressed with 32 bits (<- the time when the setting was changed)
  '  * Accumulated date and time     Åc counter value that indicates the elapsed time, in units of 10 ms, from the base time
  ' # The accumulated date and time are stored in the accumulated data.
  ' # The accumulated time of read data is calculated as shown below.
  '   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time Å~ 10 ms"

  Call AddLogResult(rc, SID_GET_STORAGE_STATUS)
  If rc = Rc_Ok Then
   'Response data display
   Call AddLog(ConvertStorageStatusToLogString(rsp))
   Call AddLog(ConvertStorageInfoToLogString(storageInfo))
  End If
 End If
End Sub

'"GetStorageData" button clicked.
Private Sub btnGetStorageData_Click()
 sendCommand = EnumSendCommand.getStorageData
 Dim subForm As GetStorageDataForm
 Set subForm = New GetStorageDataForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  Call ClearMeasureDataCollection
  Dim req As LJV7IF_GET_STORAGE_REQ
  req = subForm.GetReq
  ' @Point
  ' # dwReadArea is the target surface to read.
  '    The target surface to read indicates where in the internal memory usage area to read.
  ' # The method to use in specifying dwReadArea varies depending on how internal memory is allocated.
  '   * Double buffer
  '      0 indicates the active surface, 1 indicates surface A, and 2 indicates surface B.
  '   * Entire area (overwrite)
  '      Fixed to 1
  '   * Entire area (do not overwrite)
  '      After a setting modification, data is saved in surfaces 1, 2, 3, and so on in order, and 0 is set as the active surface.
  ' # For details, see "9.2.9.2 Internal memory."
  
  Dim storageInfo As LJV7IF_STORAGE_INFO
  Dim rsp As LJV7IF_GET_STORAGE_RSP
  Dim oneDataSize As Long
  Dim allDataSize As Long
  Dim recieveData() As Long
  
  oneDataSize = SIGNED_LONG_SIZE + MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
  allDataSize = Min(READ_DATA_SIZE, oneDataSize * subForm.GetReq.dwDataCnt)
  ReDim recieveData(allDataSize / SIGNED_LONG_SIZE - 1)
  
  Dim rc As Long
  rc = LJV7IF_GetStorageData(currentDeviceId, req, storageInfo, rsp, recieveData(0), allDataSize)
  Call AddLogResult(rc, SID_GET_STORAGE_DATA)
  ' @Point
  ' # Terminology
  '  * Base time Åc time expressed with 32 bits (<- the time when the setting was changed)
  '  * Accumulated date and time     Åc counter value that indicates the elapsed time, in units of 10 ms, from the base time
  ' # The accumulated date and time are stored in the accumulated data.
  ' # The accumulated time of read data is calculated as shown below.
  '   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time Å~ 10 ms"
  
  If rc = Rc_Ok Then
   'Temporarily retain the get data.
   Dim byteSize As Long
   byteSize = GetByteSize
   Dim i As Integer
   For i = 0 To (rsp.dwDataCnt - 1) Step 1
    Dim newMeasureData As ClassMeasureData
    Set newMeasureData = New ClassMeasureData
    Call newMeasureData.SetDataArrayWithStartIndex(recieveData, byteSize * i / SIGNED_LONG_SIZE)
    Call measureDataCollection.Add(newMeasureData)
   Next i
   Call AddLog(ConvertStorageInfoToLogString(storageInfo))
   Call AddLog(ConvertStorageRspToLogString(rsp))
  End If
 End If
End Sub

'"GetStorageProfile" button clicked.
Private Sub btnGetStorageProfile_Click()
 sendCommand = EnumSendCommand.GetStorageProfile
 
 Dim subForm As GetStorageDataForm
 Set subForm = New GetStorageDataForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  deviceData(currentDeviceId).ClearProfileData
  deviceData(currentDeviceId).ClearMeasureData
  Call ClearMeasureDataCollection
  
  Dim req As LJV7IF_GET_STORAGE_REQ
  req = subForm.GetReq
  ' @Point
  ' # dwReadArea is the target surface to read.
  '   The target surface to read indicates where in the internal memory usage area to read.
  ' # The method to use in specifying dwReadArea varies depending on how internal memory is allocated.
  '   * Double buffer
  '      0 indicates the active surface, 1 indicates surface A, and 2 indicates surface B.
  '   * Entire area (overwrite)
  '      Fixed to 1
  '   * Entire area (do not overwrite)
  '      After a setting modification, data is saved in surfaces 1, 2, 3, and so on in order, and 0 is set as the active surface.
  ' # For details, see "9.2.9.2 Internal memory."
  
  Dim storageInfo As LJV7IF_STORAGE_INFO
  Dim rsp As LJV7IF_GET_STORAGE_RSP
  Dim profileInfo As LJV7IF_PROFILE_INFO
  Dim oneDataSize As Long
  Dim allDataSize As Long
  Dim recieveData() As Long
  
  oneDataSize = SIGNED_LONG_SIZE + MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT * 2 + GetOneProfileDataSize
  allDataSize = Min(READ_DATA_SIZE, oneDataSize * subForm.GetReq.dwDataCnt)
  ReDim recieveData(allDataSize / SIGNED_LONG_SIZE - 1)
  Dim rc As Long
  rc = recieveData(0)
  rc = LJV7IF_GetStorageProfile(currentDeviceId, req, storageInfo, rsp, profileInfo, recieveData(0), allDataSize)
  ' @Point
  ' # Terminology
  '  * Base time Åc time expressed with 32 bits (<- the time when the setting was changed)
  '  * Accumulated date and time     Åc counter value that indicates the elapsed time, in units of 10 ms, from the base time
  ' # The accumulated date and time are stored in the accumulated data.
  ' # The accumulated time of read data is calculated as shown below.
  '   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time Å~ 10 ms"

  ' @Point
  ' # When reading multiple profiles, the specified number of profiles may not be read.
  ' # To read the remaining profiles after the first set of profiles have been read,
  '   set the number to start reading profiles from (dwStartNo) and the number of profiles to read (byDataCnt)
  '   to values that specify a range of profiles that have not been read to read the profiles in order.
  ' # For the basic code, see "GetHighSpeedModeBatchProfiles_Click"

  Call AddLogResult(rc, SID_GET_STORAGE_PROFILE)
  If rc = Rc_Ok Then
   ' Temporarily retain the get data.
   Dim measureDataSize As Long
   Dim profileDataSize As Long
   Dim profileMeasureDataSize As Long
   Dim byteSize As Long
   Dim tempRecvieMeasureData() As Long
       
   measureDataSize = GetByteSize
   profileDataSize = CalculateDataSize(profileInfo) * SIGNED_LONG_SIZE
   profileMeasureDataSize = MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
   byteSize = measureDataSize + profileDataSize + profileMeasureDataSize
   ReDim tempRecvieMeasureData((profileMeasureDataSize / SIGNED_LONG_SIZE) - 1)
      
   Dim i As Integer
   For i = 0 To (rsp.dwDataCnt - 1) Step 1
    Dim newMeasureData As ClassMeasureData
    Set newMeasureData = New ClassMeasureData
    Call newMeasureData.SetDataArrayWithStartIndex(recieveData, byteSize * i / SIGNED_LONG_SIZE)
    Call measureDataCollection.Add(newMeasureData)
   
    Dim newProfileData As ClassProfileData
    Set newProfileData = New ClassProfileData
    Call newProfileData.SetDataWithStartIndex(recieveData, (measureDataSize + byteSize * i) / SIGNED_LONG_SIZE, profileInfo)
    Call deviceData(currentDeviceId).AddProfileData(newProfileData)
   
    Dim deviceMeasureData As ClassMeasureData
    Set deviceMeasureData = New ClassMeasureData
    Dim j As Integer
    For j = 0 To ((profileMeasureDataSize / SIGNED_LONG_SIZE) - 1) Step 1
     tempRecvieMeasureData(j) = recieveData((measureDataSize + profileDataSize + byteSize * i) / SIGNED_LONG_SIZE + j)
    Next j
    Call deviceMeasureData.SetDataArray(tempRecvieMeasureData)
    Call deviceData(currentDeviceId).AddMeasureData(deviceMeasureData)
   Next i

   'Response data display
   Call AddLog(ConvertStorageInfoToLogString(storageInfo))
   Call AddLog(ConvertStorageRspToLogString(rsp))
   Call AddLog(ConvertProfileInfoToLogString(profileInfo))
  End If
 End If
End Sub

'"GetStorageBatchProfile" button clicked.
Private Sub btnGetStorageBatchProfile_Click()
 sendCommand = EnumSendCommand.GetStorageBatchProfile

 Dim subForm As GetStorageBatchProfileForm
 Set subForm = New GetStorageBatchProfileForm
 Call subForm.Show(vbModal)
 
 If subForm.GetDialogResult = EnumDialogResult.OK Then
  deviceData(currentDeviceId).ClearProfileData
  deviceData(currentDeviceId).ClearMeasureData
  Call ClearMeasureDataCollection
  
  'Set the function data
  Dim req As LJV7IF_GET_BATCH_PROFILE_STORAGE_REQ
  Dim storageInfo As LJV7IF_STORAGE_INFO
  Dim rsp As LJV7IF_GET_BATCH_PROFILE_STORAGE_RSP
  Dim profileInfo As LJV7IF_PROFILE_INFO
  Dim oneDataSize As Long
  Dim allDataSize As Long
  Dim measureData() As LJV7IF_MEASURE_DATA
  Dim profileData() As Long
  Dim offsetTime As Long
  
  req = subForm.GetReq
  oneDataSize = GetOneProfileDataSize() + MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
  allDataSize = oneDataSize * subForm.GetReq.byGetProfCnt
  ReDim measureData(LJV7IFEX_MAX_OUT_INDEX)
  ReDim profileData(allDataSize - 1)
  offsetTime = 0
  
  'Send the command
  Dim rc As Long
  rc = LJV7IF_GetStorageBatchProfile(currentDeviceId, req, storageInfo, rsp, profileInfo, profileData(0), allDataSize, offsetTime, measureData(0))
  ' @Point
  ' # Terminology
  '  * Base time Åc time expressed with 32 bits (<- the time when the setting was changed)
  '  * Accumulated date and time     Åc counter value that indicates the elapsed time, in units of 10 ms, from the base time
  ' # The accumulated date and time are stored in the accumulated data.
  ' # The accumulated time of read data is calculated as shown below.
  '   Accumulated time = "base time (stBaseTime of LJV7IF_GET_STORAGE_RSP)" + "accumulated date and time Å~ 10 ms"

  ' @Point
  ' # When reading all the profiles from a single batch, the specified number of profiles may not be read.
  ' # To read the remaining profiles after the first set of profiles have been read,
  '   specify the batch number (dwGetBatchNo), and then set the number to start reading profiles
  '   from (dwGetTopProfNo) and the number of profiles to read (byGetProfCnt) to values
  '   that specify a range of profiles that have not been read to read the profiles in order.
  ' # For the basic code, see "GetHighSpeedModeBatchProfiles_Click"

  'Result output
  Call AddLogResult(rc, Resources.SID_GET_STORAGE_BATCH_PROFILE)
  If rc = Rc_Ok Then
   Call AnalyzeBatchData(CLng(rsp.byGetProfCnt), profileInfo, False, profileData, 0)
   
   Dim newMeasureData As ClassMeasureData
   Set newMeasureData = New ClassMeasureData
   Call newMeasureData.CreateMeasureData(measureData)
   Call newMeasureData.SetMeasureDataArrayWithOffsetTime(offsetTime, measureData)
   Call measureDataCollection.Add(newMeasureData)
   
   'Response data display
   Call AddLog(ConvertStorageInfoToLogString(storageInfo))
   Call AddLog(ConvertBatchProfileStorageRspToLogString(rsp))
   Call AddLog(ConvertProfileInfoToLogString(profileInfo))
   Call AddLog("offsetTime   :" & offsetTime)
  End If
 End If
End Sub

'-- Button for settings / results
'"Clear the log" button clicked
Private Sub btnClearLog_Click()
 txtboxLog.Text = ""
End Sub

'"..." button clicked.
Private Sub btnProfileFileSave_Click()
  With ProfileFileSavePathDlg
  .Flags = .Flags Or FileOpenConstants.cdlOFNHideReadOnly
  .fileName = txtboxProfileFilePath.Text
  .Filter = "Profile (*.txt)|*.txt |all files (*.*)|*.*"
  .CancelError = True
 End With
On Error GoTo CANCEL_DLG
  ProfileFileSavePathDlg.ShowOpen
  txtboxProfileFilePath.Text = ProfileFileSavePathDlg.fileName
CANCEL_DLG:
End Sub

'"Save the profile" button clicked.
Private Sub btnSave_Click()
 Dim profileNo As Long
 profileNo = CLng(txtboxProfileNo.Text)
 
 Dim profileData As Collection
 Call deviceData(currentDeviceId).GetProfile(profileData)
   
 If profileNo >= profileData.Count Then
  AddLog ("There is no profile specified.")
  Exit Sub
 End If

 If (ExportOneProfile(profileData, profileNo, txtboxProfileFilePath.Text)) Then
  AddLog ("Saved")
 End If
End Sub

'"Save the measurement value" button clicked.
Private Sub btnSaveMeasureData_Click()
 Call ExportMeasureData(measureDataCollection, txtboxProfileFilePath.Text)
 
 Dim measureData As Collection
 Set measureData = New Collection
 Call deviceData(currentDeviceId).GetMeasure(measureData)
 Call ExportMeasureData(measureData, txtboxProfileFilePath.Text & "2.txt")
 Set measureData = Nothing
End Sub

'"Clear the log" button clicked
Private Sub ClearLog_Click()
 txtboxLog.Text = ""
End Sub

'-- Other event handlers
' Load this form
Private Sub Form_Load()
 EnableEtherSetting (False)
 'txtboxProfileFilePath.Text = CurDir$() & "\" & "TestAppDefaultProfile.txt"
 cmbMeasureX.ListIndex = 0
 cmbReceiveBinning.ListIndex = 0
 cmbCompressX.ListIndex = 0
 currentDeviceId = 0
 
 ReDim measureData(LJV7IFEX_MAX_OUT_INDEX)
 
 Set measureDataCollection = New Collection
 
 SelectProgramArea.ListIndex = 2
 
 Dim i As Integer
 For i = 0 To UBound(deviceData) Step 1
  Set deviceData(i) = New ClassDeviceData
  deviceData(i).DeviceStatus = DeviceStatus.NoConnection
 Next i
  
 Call UpdateDeviceStatus
End Sub

Private Sub Form_Unload(Cancel As Integer)
 'For single-function
 Set measureDataCollection = Nothing
 
 Dim i As Integer
 For i = 0 To UBound(deviceData) Step 1
  Set deviceData(i) = Nothing
 Next i
 
 'For combination-function
 'Guard for forgot finalization.
 LJV7IF_CommClose (DeviceID)
 LJV7IF_Finalize
End Sub

'"ID" option button (also known as a radio button) event handler
Private Sub OptionDevice0_Click()
 Call UpdateCurrentDeviceId
End Sub

'"ID" option button (also known as a radio button) event handler
Private Sub OptionDevice1_Click()
 Call UpdateCurrentDeviceId
End Sub

'"ID" option button (also known as a radio button) event handler
Private Sub OptionDevice2_Click()
 Call UpdateCurrentDeviceId
End Sub

'"ID" option button (also known as a radio button) event handler
Private Sub OptionDevice3_Click()
 Call UpdateCurrentDeviceId
End Sub

'"ID" option button (also known as a radio button) event handler
Private Sub OptionDevice4_Click()
 Call UpdateCurrentDeviceId
End Sub

'"ID" option button (also known as a radio button) event handler
Private Sub OptionDevice5_Click()
 Call UpdateCurrentDeviceId
End Sub

'-- Method for single-function
'AnalyzeProfileData
'"profileCount" is number of profiles that were read
'"profileInfo" is profile information structure
'"profileData" is acquired profile data
Private Sub AnalyzeProfileData(profileCount As Integer, profileInfo As LJV7IF_PROFILE_INFO, profileData() As Long)
 Dim dataUnit As Long
 dataUnit = CalculateDataSize(profileInfo)
 Call AnalyzeProfileDataInner(profileCount, profileInfo, profileData, 0, dataUnit)
End Sub

'AnalyzeProfileData
'"profileCount" is number of profiles that were read
'"profileInfo" is profile information structure
'"profileData" is acquired profile data
'"startProfileIndex" is start position of the profiles to copy
'"dataUnit" is profile data size
Private Sub AnalyzeProfileDataInner(profileCount As Integer, profileInfo As LJV7IF_PROFILE_INFO, profileData() As Long, startProfileIndex As Integer, dataUnit As Long)
 Dim readProfileDataSize As Integer
 Dim tempRecieveProfileData() As Long
 'sizing profile data
 readProfileDataSize = CalculateDataSize(profileInfo)
 ReDim tempRecieveProfileData(readProfileDataSize - 1)
 
 'Profile data retention
 Dim i As Long
 For i = 0 To (profileCount - 1) Step 1
  Dim profileDataIndex As Long
  For profileDataIndex = 0 To (readProfileDataSize - 1) Step 1
   tempRecieveProfileData(profileDataIndex) = profileData(startProfileIndex + (i * dataUnit) + profileDataIndex)
  Next profileDataIndex
  
  Dim newProfileData As ClassProfileData
  Set newProfileData = New ClassProfileData
  Call newProfileData.SetData(tempRecieveProfileData, profileInfo)
  Call deviceData(currentDeviceId).AddProfileData(newProfileData)
 Next i
End Sub

'"profileCount" is number of profiles that were read
'"profileInfo" is profile information structure
'"includeTimeData" is whether to include the time offset
'"batchData" is acquired batch profile data
'"startProfileIndex" is start position of the profiles to copy
Private Sub AnalyzeBatchData(profileCount As Integer, profileInfo As LJV7IF_PROFILE_INFO, includeTimeData As Boolean, batchData() As Long, startProfileIndex As Integer)
 Dim offsetTimeSize As Long
 Dim readProfileDataSize As Long
 Dim readMeasureDataSize As Long
 Dim dataUnit As Long
 Dim tempRecvieProfileData() As Long
 Dim tempRecvieMeasureData() As Byte
 Dim offsetTime As Long
 
 'sizing offset-time
 If includeTimeData Then
  offsetTimeSize = 1
 Else
  offsetTimeSize = 0
 End If
 'sizing profile data
 readProfileDataSize = CalculateDataSize(profileInfo)
 'sizing measure data
 readMeasureDataSize = MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
 'sizing all data (by unit)
 dataUnit = offsetTimeSize + readProfileDataSize + readMeasureDataSize / SIGNED_LONG_SIZE
 ReDim tempRecvieProfileData(readProfileDataSize - 1)
 ReDim tempRecvieMeasureData(readMeasureDataSize - 1)
 offsetTime = 0
 
 'Profile data retention
 '  search binary index with batchData's array index.
 '  increase batchData's array index, and pick out fixed data.
 Dim i As Integer
 For i = 0 To (profileCount - 1) Step 1
  If includeTimeData Then
   offsetTime = batchData(startProfileIndex + i * dataUnit)
  End If
  
  Dim j As Integer
  For j = 0 To (readProfileDataSize - 1) Step 1
   tempRecvieProfileData(j) = batchData(startProfileIndex + i * dataUnit + offsetTimeSize + j)
  Next j
  Dim newProfileData As ClassProfileData
  Set newProfileData = New ClassProfileData
  Call newProfileData.SetData(tempRecvieProfileData, profileInfo)
  Call deviceData(currentDeviceId).AddProfileData(newProfileData)
  
  ' measure data must adjust binary size, so convert LONG's size to BYTE's one.
  Dim k As Integer
  For k = 0 To ((readMeasureDataSize / SIGNED_LONG_SIZE) - 1) Step 1
   Call MoveMemory(tempRecvieMeasureData(k * SIGNED_LONG_SIZE), batchData((startProfileIndex + i * dataUnit + offsetTimeSize + readProfileDataSize + k)), SIGNED_LONG_SIZE)
  Next k
  Dim newMeasureData As ClassMeasureData
  Set newMeasureData = New ClassMeasureData
  Call newMeasureData.SetDataArrayWithOffset(0, tempRecvieMeasureData)
  Call deviceData(currentDeviceId).AddMeasureData(newMeasureData)
  If includeTimeData Then
   Call deviceData(currentDeviceId).SetOffsetTime(i, offsetTime)
  End If
 Next i
End Sub

'Get the profile data size
'return value is Data size of one profile (in units of bytes)
Private Function GetOneProfileDataSize() As Long
 'Buffer size (in units of bytes)
 Dim retBuffSize As Long
 retBuffSize = 0
 
 'Basic size
 Dim measureXSelectedValue As Long
 If cmbMeasureX.ListIndex = 0 Then
  measureXSelectedValue = MEASURE_RANGE_FULL
 ElseIf cmbMeasureX.ListIndex = 1 Then
  measureXSelectedValue = MEASURE_RANGE_MIDDLE
 ElseIf cmbMeasureX.ListIndex = 2 Then
  measureXSelectedValue = MEASURE_RANGE_SMALL
 End If
 
 Dim receiveBinningSelectedValue As Long
 If cmbReceiveBinning.ListIndex = 0 Then
  receiveBinningSelectedValue = RECEIVED_BINNING_OFF
 ElseIf cmbReceiveBinning.ListIndex = 1 Then
  receiveBinningSelectedValue = RECEIVED_BINNING_ON
 End If
 
 Dim compressXSelectedValue As Long
 If cmbCompressX.ListIndex = 0 Then
  compressXSelectedValue = COMPRESS_X_OFF
 ElseIf cmbCompressX.ListIndex = 1 Then
  compressXSelectedValue = COMPRESS_X_2
 ElseIf cmbCompressX.ListIndex = 2 Then
  compressXSelectedValue = COMPRESS_X_4
 End If
 
 Dim basicSize As Long
 basicSize = measureXSelectedValue / receiveBinningSelectedValue
 basicSize = basicSize / compressXSelectedValue
 
 'Number of headers
 If rdbtnOneHead.value = True Then
  retBuffSize = basicSize * 1
 Else
  retBuffSize = basicSize * 2
 End If
 
 'Envelope setting
 If chkboxEnvelope.value = 1 Then
  retBuffSize = retBuffSize * 2
 End If
 
 'in units of bytes
 retBuffSize = retBuffSize * UNSIGNED_INT_SIZE
 
 'Sizes of the header and footer structures
 retBuffSize = retBuffSize + PROFILE_HEADER_SIZE
 retBuffSize = retBuffSize + PROFILE_FOOTER_SIZE
 
 GetOneProfileDataSize = retBuffSize
End Function

'Data size calculation
'"profileInfo" is profile information
'Return profile data size
Friend Function CalculateDataSize(profileInfo As LJV7IF_PROFILE_INFO) As Long
 CalculateDataSize = profileInfo.wProfDataCnt * profileInfo.byProfileCnt * (profileInfo.byEnvelope + 1) + ((PROFILE_HEADER_SIZE + PROFILE_FOOTER_SIZE) / SIGNED_LONG_SIZE)
End Function

'Size acquisition
'Return data size
Public Function GetByteSize() As Long
 GetByteSize = SIGNED_LONG_SIZE + MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
End Function

'Clear measure data collection at filed
Private Sub ClearMeasureDataCollection()
 Dim i As Long
 If (measureDataCollection.Count) > 0 Then
  For i = (measureDataCollection.Count) To 1 Step -1
   Call measureDataCollection.Remove(i)
  Next i
 End If
End Sub

'------ Event handler(for combination-function)
'Download Program
Private Sub DownloadProgram_Click()
 If Len(TextProgramPath.Text) = 0 Then
  MsgBox ("Please input file path.")
  Exit Sub
 End If
 
 'Set parameter
 Dim setting As LJV7IF_TARGET_SETTING
 setting = SelectedProgramSetting()
 Dim size As Long
 size = SelectedProgramDataSize()

 'Reserve buffer
 Dim buffer() As Byte
 ReDim buffer(size - 1)
 
 'Download
 Dim rc As Long
 rc = LJV7IF_GetSettingEx(DeviceID, DEPTH_RUNNING, setting, buffer(0), size)
 If CheckStatus(rc, "LJV7IF_GetSettingEx") = False Then
  Exit Sub
 End If
 
 'Remove existing file
 If Dir(TextProgramPath.Text) <> vbNullString Then
  Kill (TextProgramPath.Text)
 End If
 
 'Write to file
 Dim fileNo As Integer
 fileNo = FreeFile
 Open TextProgramPath.Text For Binary Access Write As #fileNo
 Put #fileNo, , buffer
 Close #fileNo
End Sub

'Upload Program
Private Sub UploadProgram_Click()
 If Len(TextProgramPath.Text) = 0 Then
  MsgBox ("Please input file path.")
  Exit Sub
 End If
 
 If Dir(TextProgramPath.Text) = vbNullString Then
  MsgBox ("File is not found.")
  Exit Sub
 End If
 
 'Set parameter
 Dim setting As LJV7IF_TARGET_SETTING
 setting = SelectedProgramSetting()
 Dim size As Long
 size = SelectedProgramDataSize()
 
 'Validate file (This is very simple method. You should use more certain method.)
 If FileLen(TextProgramPath.Text) <> size Then
  MsgBox ("File size is mismatch.")
  Exit Sub
 End If
 
 'Reserve buffer
 Dim buffer() As Byte
 ReDim buffer(size - 1)
 
 'Read from file
 Dim fileNo As Integer
 fileNo = FreeFile
 Open TextProgramPath.Text For Binary Access Read As #fileNo
 Get #fileNo, , buffer
 Close #fileNo

 'Upload
 Dim error As Long
 Dim rc As Long
 rc = LJV7IF_SetSettingEx(DeviceID, DEPTH_RUNNING, setting, buffer(0), size, error)
 If CheckStatus(rc, "LJV7IF_SetSettingEx") = False Then
  Exit Sub
 End If

End Sub

' Get profiles and measurement data (Advanced mode)
Private Sub GetAdvancedModeProfiles_Click()
 ' Reserve response data area
 Dim profileInfo As LJV7IF_PROFILE_INFO
 Dim measureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
 
 Dim sizeResponseBuffer As Long
 sizeResponseBuffer = MaxProfileSizePerBlock
 
 Dim receiveBuffer() As Long
 ReDim receiveBuffer(sizeResponseBuffer - 1)
 
 ' Execute
 Dim rc As Long
 rc = LJV7IF_GetProfileAdvance(DeviceID, profileInfo, receiveBuffer(0), sizeResponseBuffer * 4, measureData(0))
 If CheckStatus(rc, "LJV7IF_GetProfileAdvance") = False Then
  Exit Sub
 End If
 
 ' Output
 Call ShowMeasurementValue(measureData)
 Call SaveProfile(profileInfo, receiveBuffer, 1, False)
End Sub

' Get profiles data (Profile only mode)
Private Sub GetHighSpeedModeProfiles_Click()
 ' Set parameter
 Dim request As LJV7IF_GET_PROFILE_REQ
 request.byTargetBank = PROFILE_BANK_ACTIVE
 request.byPosMode = PROFILE_POS_CURRENT
 request.dwGetProfNo = 0
 request.byGetProfCnt = 10
 request.byErase = 0
 
 ' Reserve response data area
 Dim response As LJV7IF_GET_PROFILE_RSP
 Dim profileInfo As LJV7IF_PROFILE_INFO
 
 Dim sizeResponseBuffer As Long
 sizeResponseBuffer = MaxProfileSizePerBlock * request.byGetProfCnt
 
 Dim receiveBuffer() As Long
 ReDim receiveBuffer(sizeResponseBuffer - 1)
 
 ' Execute
 Dim rc As Long
 rc = LJV7IF_GetProfile(DeviceID, request, response, profileInfo, receiveBuffer(0), sizeResponseBuffer * 4)
 If CheckStatus(rc, "LJV7IF_GetProfile") = False Then
  Exit Sub
 End If
 
 ' Output
 Call SaveProfile(profileInfo, receiveBuffer, request.byGetProfCnt, False)
End Sub

' Get profiles and measurement data (Advanced and batch mode)
Private Sub GetAdvancedModeBatchProfiles_Click()
 Screen.MousePointer = vbHourglass
 
 ' Set parameter
 Dim request As LJV7IF_GET_BATCH_PROFILE_ADVANCE_REQ
 request.byPosMode = BATCH_POS_CURRENT
 request.dwGetBatchNo = 0
 request.dwGetProfNo = 0
 request.byGetProfCnt = &HFF
 
 ' Reserve response data area
 Dim response As LJV7IF_GET_BATCH_PROFILE_ADVANCE_RSP
 Dim profileInfo As LJV7IF_PROFILE_INFO
  
 Dim measureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
 Dim resultBatchMeasure(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
 
 Dim sizeResponseBuffer As Long
 sizeResponseBuffer = (MaxProfileSizePerBlock + MeasureDataBlockSize) * request.byGetProfCnt
 
 Dim receiveBuffer() As Long
 ReDim receiveBuffer(sizeResponseBuffer - 1)
 
 ' Execute
 Dim rc As Long
 rc = LJV7IF_GetBatchProfileAdvance(DeviceID, request, response, profileInfo, receiveBuffer(0), sizeResponseBuffer * 4, resultBatchMeasure(0), measureData(0))
 If CheckStatus(rc, "LJV7IF_GetBatchProfileAdvance (" & CStr(response.dwGetBatchTopProfNo + response.byGetProfCnt) & "/" & response.dwGetBatchProfCnt & ")") = False Then
  Screen.MousePointer = vbNormal
  Exit Sub
 End If
 
 ' Output
 Call ShowMeasurementValue(measureData)
 Call SaveProfileAdvance(profileInfo, receiveBuffer, response.byGetProfCnt, False)
 
 ' Repeat until read all data
 request.byPosMode = BATCH_POS_SPEC
 request.dwGetBatchNo = response.dwGetBatchNo
 Do Until (response.dwGetBatchProfCnt = response.dwGetBatchTopProfNo + response.byGetProfCnt)
  request.dwGetProfNo = response.dwGetBatchTopProfNo + response.byGetProfCnt
  request.byGetProfCnt = CByte(Min(&HFF, response.dwGetBatchProfCnt - request.dwGetProfNo))
  rc = LJV7IF_GetBatchProfileAdvance(DeviceID, request, response, profileInfo, receiveBuffer(0), sizeResponseBuffer * 4, resultBatchMeasure(0), measureData(0))
  If CheckStatus(rc, "LJV7IF_GetBatchProfileAdvance (" & CStr(response.dwGetBatchTopProfNo + response.byGetProfCnt) & "/" & response.dwGetBatchProfCnt & ")") = False Then
   Screen.MousePointer = vbNormal
   Exit Sub
  End If
 
  Call SaveProfileAdvance(profileInfo, receiveBuffer, response.byGetProfCnt, True)
 Loop
 
 Screen.MousePointer = vbNormal
End Sub

' Get profiles data (Profile only & batch mode)
Private Sub GetHighSpeedModeBatchProfiles_Click()
 Screen.MousePointer = vbHourglass
 
 ' Set parameter
 Dim request As LJV7IF_GET_BATCH_PROFILE_REQ
 request.byTargetBank = PROFILE_BANK_ACTIVE
 request.byPosMode = PROFILE_POS_CURRENT
 request.dwGetBatchNo = 0
 request.dwGetProfNo = 0
 request.byGetProfCnt = &HFF
 request.byErase = 0
 
 ' Reserve response data area
 Dim response As LJV7IF_GET_BATCH_PROFILE_RSP
 Dim profileInfo As LJV7IF_PROFILE_INFO
 
 Dim sizeResponseBuffer As Long
 sizeResponseBuffer = MaxProfileSizePerBlock * request.byGetProfCnt
 
 Dim receiveBuffer() As Long
 ReDim receiveBuffer(sizeResponseBuffer - 1)
  
 ' Execute
 Dim rc As Long
 rc = LJV7IF_GetBatchProfile(DeviceID, request, response, profileInfo, receiveBuffer(0), sizeResponseBuffer * 4)
 If CheckStatus(rc, "LJV7IF_GetBatchProfile (" & CStr(response.dwGetBatchTopProfNo + response.byGetProfCnt) & "/" & response.dwCurrentBatchProfCnt & ")") = False Then
  Screen.MousePointer = vbNormal
  Exit Sub
 End If
 
 ' Output
 Call SaveProfile(profileInfo, receiveBuffer, response.byGetProfCnt, False)
 
 ' Repeat until read all data
 request.byPosMode = PROFILE_POS_SPEC
 request.dwGetBatchNo = response.dwGetBatchNo
 Do Until (response.dwGetBatchProfCnt = response.dwGetBatchTopProfNo + response.byGetProfCnt)
  request.dwGetProfNo = response.dwGetBatchTopProfNo + response.byGetProfCnt
  request.byGetProfCnt = CByte(Min(&HFF, response.dwCurrentBatchProfCnt - request.dwGetProfNo))
  rc = LJV7IF_GetBatchProfile(DeviceID, request, response, profileInfo, receiveBuffer(0), sizeResponseBuffer * 4)
  If CheckStatus(rc, "LJV7IF_GetBatchProfile (" & CStr(response.dwGetBatchTopProfNo + response.byGetProfCnt) & "/" & response.dwCurrentBatchProfCnt & ")") = False Then
   Screen.MousePointer = vbNormal
   Exit Sub
  End If
  
  Call SaveProfile(profileInfo, receiveBuffer, response.byGetProfCnt, True)
 Loop

 Screen.MousePointer = vbNormal
End Sub

Private Sub GetCurrentValues_Click()
 ' Reserve response data area
 Dim resultMeasure(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA
 
 ' Execute
 Dim rc As Long
 rc = LJV7IF_GetMeasurementValue(DeviceID, resultMeasure(0))
 If CheckStatus(rc, "LJV7IF_GetMeasurementValue") = False Then
  Exit Sub
 End If

 ' Output
 Call ShowMeasurementValue(resultMeasure)
End Sub

' Initialization
Private Sub Initialization_Click()
 Dim rc As Long
 ' Initialize
 rc = LJV7IF_Initialize()
 If CheckStatus(rc, "LJV7IF_Initialize") = False Then
  Exit Sub
 End If
 
 If OptionUSB.value Then
  ' Connect by USB
  rc = LJV7IF_UsbOpen(DeviceID)
  If CheckStatus(rc, "LJV7IF_UsbOpen") = False Then
   Exit Sub
  End If
  
  
 Else
  Screen.MousePointer = vbHourglass
  DoEvents
  ' Connect by Ethernet
  Dim config As LJV7IF_ETHERNET_CONFIG
  config.address.IPAddress1 = CByte(TextIpaddr1)
  config.address.IPAddress2 = CByte(TextIpaddr2)
  config.address.IPAddress3 = CByte(TextIpaddr3)
  config.address.IPAddress4 = CByte(TextIpaddr4)
  
  config.wPortNo = IntegerFromWordValue(CLng(TextIpPort))
  
  rc = LJV7IF_EthernetOpen(DeviceID, config)
  Screen.MousePointer = vbNormal
  If CheckStatus(rc, "LJV7IF_EthernetOpen") = False Then
   Exit Sub
  End If
 End If
 
End Sub

'Finalization
Private Sub Finalization_Click()
 '
 Dim rc As Long
 Dim check As Boolean
 
 rc = LJV7IF_CommClose(DeviceID)
 check = CheckStatus(rc, "LJV7IF_CommClose")
 rc = LJV7IF_Finalize
 check = CheckStatus(rc, "LJV7IF_Finalize")
End Sub

Private Sub OptionEthernet_Click()
 EnableEtherSetting (True)
End Sub

Private Sub OptionUSB_Click()
 EnableEtherSetting (False)
End Sub

Private Sub EnableEtherSetting(en As Boolean)
 LabelIP.Enabled = en
 LabelPort.Enabled = en
 TextIpaddr1.Enabled = en
 TextIpaddr2.Enabled = en
 TextIpaddr3.Enabled = en
 TextIpaddr4.Enabled = en
 TextIpPort.Enabled = en
 TextIpPortHighSpeed.Enabled = en
 Label2.Enabled = en
 Label4.Enabled = en
 Label5.Enabled = en
 Label27.Enabled = en
End Sub

' Check and show communication result
Private Function CheckStatus(rc As Long, func As String) As Boolean
 If rc <> Rc_Ok Then
  MsgBox ("Function error: H" & Hex(rc))
  CheckStatus = False
 Else
  CheckStatus = True
 End If
 DoEvents
End Function

Private Function FindSpecialFolder() As String
 Dim objWsh As Object
 Set objWsh = CreateObject("Wscript.Shell")
 FindSpecialFolder = objWsh.SpecialFolders("DeskTop")
 Set objWsh = Nothing
End Function

Private Sub SelectProfilePath_Click()
 With SelectProfilePathDlg
 .Flags = .Flags Or FileOpenConstants.cdlOFNHideReadOnly
 .fileName = TextProfilePath.Text
 .CancelError = True
 End With
On Error GoTo CANCEL_DLG
 SelectProfilePathDlg.ShowOpen
 TextProfilePath.Text = SelectProfilePathDlg.fileName
CANCEL_DLG:
End Sub

Private Sub SelectProgramPath_Click()
 With SelectProgramPathDlg
 .Flags = .Flags Or FileOpenConstants.cdlOFNHideReadOnly
 .fileName = TextProgramPath.Text
 .CancelError = True
 End With
On Error GoTo CANCEL_DLG
 SelectProgramPathDlg.ShowOpen
 TextProgramPath.Text = SelectProgramPathDlg.fileName
CANCEL_DLG:
End Sub

Private Function SelectedProgramSetting() As LJV7IF_TARGET_SETTING
 Dim selection As Integer
 selection = SelectProgramArea.ListIndex
 
 Dim setting As LJV7IF_TARGET_SETTING
 With setting
  .byCategory = &HFF
  .byItem = &H0
  .byTarget1 = 0
  .byTarget2 = 0
  .byTarget3 = 0
  .byTarget4 = 0
  .reserve = 0
  If selection = 0 Then
   .byType = SETTING_TYPE_ENVIRONMENT
  ElseIf selection = 1 Then
   .byType = SETTING_TYPE_COMMON
  Else
   .byType = SETTING_TYPE_PROGRAM0 + CByte(selection - 2)
  End If
 End With
 SelectedProgramSetting = setting
End Function

Private Function SelectedProgramDataSize() As Long
 Dim selection As Integer
 selection = SelectProgramArea.ListIndex
 
 If selection = 0 Then
   SelectedProgramDataSize = LJV7IFEX_SETTING_SIZE_ENVIRONMENT
 ElseIf selection = 1 Then
   SelectedProgramDataSize = LJV7IFEX_SETTING_SIZE_COMMON
 Else
   SelectedProgramDataSize = LJV7IFEX_SETTING_SIZE_PROGRAM
 End If
End Function

'------ Method(for single-function)
'Update current device ID
Private Sub UpdateCurrentDeviceId()
 If OptionDevice0.value = True Then
  currentDeviceId = 0
 ElseIf OptionDevice1.value = True Then
  currentDeviceId = 1
 ElseIf OptionDevice2.value = True Then
  currentDeviceId = 2
 ElseIf OptionDevice3.value = True Then
  currentDeviceId = 3
 ElseIf OptionDevice4.value = True Then
  currentDeviceId = 4
 ElseIf OptionDevice5.value = True Then
  currentDeviceId = 5
 End If
End Sub

'Update device status
Private Sub UpdateDeviceStatus()
 lblDeviceStatus0.Caption = deviceData(0).GetStatusString()
 lblDeviceStatus1.Caption = deviceData(1).GetStatusString()
 lblDeviceStatus2.Caption = deviceData(2).GetStatusString()
 lblDeviceStatus3.Caption = deviceData(3).GetStatusString()
 lblDeviceStatus4.Caption = deviceData(4).GetStatusString()
 lblDeviceStatus5.Caption = deviceData(5).GetStatusString()
End Sub

'-- Log output
'Log output
Private Sub AddLog(strLog As String)
 txtboxLog.Text = txtboxLog.Text & strLog & vbNewLine
 txtboxLog.SetFocus
 txtboxLog.SelStart = Len(txtboxLog)
End Sub

'Communication command result log output
Private Sub AddLogResult(rc As Long, func As String)
 Dim log As String
 If rc = Rc_Ok Then
  log = "[" & func & "]  :" & "OK" & "(0x" & Format(Hex(rc), "0000") & ")"
  Call AddLog(log)
 Else
  log = "[" & func & "]  :" & "NG" & "(0x" & Format(Hex(rc), "0000") & ")"
  Call AddLog(log)
  Call AddErrorLog(rc)
 End If
 DoEvents
End Sub

'Error log output
Private Sub AddErrorLog(rc As Long)
 If rc < CLng("&H8000") Then
  'Common return code
  CommonErrorLog (rc)
 Else
  'Individual return code
  IndividualErrorLog (rc)
 End If
End Sub

'Common return code log output("rc" is return code)
Private Sub CommonErrorLog(rc As Long)
 Dim log As String
 Select Case rc
  Case Rc_Ok
   AddLog ("  --> " & SID_RC_OK)
  Case RC_ERR_OPEN_DEVICE
   AddLog ("  --> " & SID_RC_ERR_OPEN_DEVICE)
  Case RC_ERR_NO_DEVICE
   AddLog ("  --> " & SID_RC_ERR_NO_DEVICE)
  Case RC_ERR_SEND
   AddLog ("  --> " & SID_RC_ERR_SEND)
  Case RC_ERR_RECEIVE
   AddLog ("  --> " & SID_RC_ERR_RECEIVE)
  Case RC_ERR_TIMEOUT
   AddLog ("  --> " & SID_RC_ERR_TIMEOUT)
  Case RC_ERR_PARAMETER
   AddLog ("  --> " & SID_RC_ERR_PARAMETER)
  Case RC_ERR_NOMEMORY
   AddLog ("  --> " & SID_RC_ERR_NOMEMORY)
  Case Else
   AddLog ("  --> " & CStr(rc))
 End Select
End Sub

'Individual return code log output("rc" is return code)
Private Sub IndividualErrorLog(rc As Long)
 Select Case sendCommand
  Case RebootController
   Select Case rc
    Case CLng("&H80A0")
     AddLog ("  --> " & "Accessing the save area")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case Trigger
   Select Case rc
     Case CLng("&H8080")
      AddLog ("  --> " & "The trigger mode is not [external trigger]")
     Case Else
      AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
     End Select
     
  Case StartMeasure, StopMeasure
   Select Case rc
   Case CLng("&H8080")
    AddLog ("  --> " & "Batch measurements are off")
   Case CLng("&H80A0")
    AddLog (" -->" & "Batch measurement start processing could not be performed because the REMOTE terminal is off or the LASER_OFF terminal is on")
   Case Else
    AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case AutoZero, Timing, Reset, GetMeasurementValue
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [high-speed (profile only)]")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
    End Select
    
  Case ChangeActiveProgram
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The change program setting is [terminal]")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case GetProfile, GetProfileAdvance
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [advanced (with OUT measurement)]")
    Case CLng("&H8081")
     AddLog ("  --> " & "Batch measurements on and profile compression (time axis) off")
    Case CLng("&H80A0")
     AddLog ("  --> " & "No profile data")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case GetBatchProfile, GetBatchProfileAdvance
    Select Case rc
     Case CLng("&H8080")
      AddLog ("  --> " & "The operation mode is [advanced (with OUT measurement)]")
     Case CLng("&H8081")
      AddLog ("  --> " & "Not [batch measurements on and profile compression (time axis) off]")
     Case CLng("&H80A0")
      AddLog ("  --> " & "No batch data (batch measurements not run even once)")
     Case Else
      AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
     End Select

  Case StartStorage, StopStorage
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [high-speed (profile only)]")
    Case CLng("&H8081")
     AddLog ("  --> " & "Storage target setting is [OFF] (no storage)")
    Case CLng("&H8082")
     AddLog ("  --> " & "The storage condition setting is not [terminal/command]")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select

  Case GetStorageStatus
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [high-speed (profile only)]")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
    End Select
    
  Case getStorageData
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [high-speed (profile only)]")
    Case CLng("&H8081")
     AddLog ("  --> " & "The storage target setting is not [OUT value]")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case GetStorageProfile
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [high-speed (profile only)]")
    Case CLng("&H8081")
     AddLog ("  --> " & "The storage target setting is not profile, or batch measurements on and profile compression (time axis) off")
    Case CLng("&H8082")
     AddLog ("  --> " & "Batch measurements on and profile compression (time axis) off")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case GetStorageBatchProfile
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [high-speed (profile only)]")
    Case CLng("&H8081")
     AddLog ("  --> " & "The storage target setting is not profile, or batch measurements on and profile compression (time axis) off")
    Case CLng("&H8082")
     AddLog ("  --> " & "Not [batch measurements on and profile compression (time axis) off]")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case HighSpeedDataUsbCommunicationInitalize, HighSpeedDataEthernetCommunicationInitalize
   Select Case rc
    Case CLng("&H8080")
     AddLog ("  --> " & "The operation mode is [advanced (with OUT measurement)]")
    Case CLng("&H80A1")
     AddLog ("  --> " & "Already performing high-speed communication error (for high-speed communication)")
    Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case PreStartHighSpeedDataCommunication, StartHighSpeedDataCommunication
   Select Case rc
   Case CLng("&H8080")
    AddLog ("  --> " & "The operation mode is [advanced (with OUT measurement)]")
   Case CLng("&H8081")
    AddLog ("  --> " & "The data specified as the send start position does not exist")
   Case CLng("&H80A0")
    AddLog ("  --> " & "A high-speed data communication connection was not established")
   Case CLng("&H80A1")
    AddLog ("  --> " & "Already performing high-speed communication error (for high-speed communication)")
   Case CLng("&H80A4")
    AddLog ("  --> " & "The send target data was cleared")
   Case Else
     AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
   End Select
   
  Case Else
   AddLog ("#Undefined RC (0x" & Format(Hex(rc), "0000") & ")")
 End Select
End Sub

'Profile output
'"data" is profile data
'"profileNo" is profile information
'"fileName" is file name
Private Function ExportOneProfile(data As Collection, profileNo As Long, fileName As String) As Boolean
 On Error Resume Next
 If Len(fileName) = 0 Then
  Exit Function
 End If
 
 Dim fileNo As Integer
 fileNo = FreeFile
 
 Open fileName For Output As #fileNo

  Dim profileData As ClassProfileData
  Set profileData = data.Item(profileNo + 1)
  Print #fileNo, profileData.GetProfileDataString
 
 Close #fileNo
 
 If Err.Number <> 0 Then
 ExportOneProfile = False
  Call MsgBox(Err.Description, vbOKOnly + vbDefaultButton1, "")
  Call Err.Clear
 Else
  'File save failure
  ExportOneProfile = True
 End If
End Function

'Measurement value output
'"data" is Measurement data
'"fileName" is File name
Private Function ExportMeasureData(data As Collection, fileName As String)
 On Error Resume Next
 If Len(fileName) = 0 Then
  Exit Function
 End If

 Dim fileNo As Integer
 fileNo = FreeFile

 Open fileName For Output As #fileNo
 
 'File output to all receivers
 Dim i As Integer
 For i = 1 To data.Count Step 1
  Dim str As String
  str = data(i).GetMeasureDataString
  Print #fileNo, data(i).GetMeasureDataString
 Next i
 
 Close #fileNo
 
 If Err.Number <> 0 Then
  ExportMeasureData = False
 Else
  'File save failure
  ExportMeasureData = True
 End If
End Function

'------ Method(for combination-function)
'-- For profile
Private Sub SaveProfile(profileInfo As LJV7IF_PROFILE_INFO, ByRef buffer() As Long, ByVal cntBlock As Integer, ByVal isAppend As Boolean)
 If Len(TextProfilePath.Text) = 0 Then
  Exit Sub
 End If

 Dim fileNo As Integer
 fileNo = FreeFile
 If isAppend Then
  Open TextProfilePath.Text For Append As #fileNo
 Else
  Open TextProfilePath.Text For Output As #fileNo
  'HeadLine
  Print #fileNo, ProfileHeadLineString(profileInfo)
 End If
  
 'Body
 Dim sizePerBlock As Long
 sizePerBlock = ProfileSizePerBlock(profileInfo)
 Dim idxBlock As Integer
 For idxBlock = 0 To cntBlock - 1
  Print #fileNo, ProfileBodyString(profileInfo, buffer, idxBlock * sizePerBlock)
 Next idxBlock
 
 Close #fileNo
End Sub

Private Sub SaveProfileAdvance(profileInfo As LJV7IF_PROFILE_INFO, ByRef buffer() As Long, ByVal cntBlock As Integer, ByVal isAppend As Boolean)
 If Len(TextProfilePath.Text) = 0 Then
  Exit Sub
 End If

 Dim fileNo As Integer
 fileNo = FreeFile
 If isAppend Then
  Open TextProfilePath.Text For Append As #fileNo
 Else
  Open TextProfilePath.Text For Output As #fileNo
  'HeadLine
  Print #fileNo, ProfileHeadLineString(profileInfo)
 End If
 
 'Body
 Dim sizePerBlock As Long
 sizePerBlock = ProfileSizePerBlock(profileInfo) + MeasureDataBlockSize
 Dim idxBlock As Integer
 For idxBlock = 0 To cntBlock - 1
  Print #fileNo, ProfileBodyString(profileInfo, buffer, idxBlock * sizePerBlock)
 Next idxBlock
 
 Close #fileNo
End Sub

Private Function MaxProfileSizePerBlock() As Long
 MaxProfileSizePerBlock = LJV7IFEX_MAX_PROFILE_COUNT + LJV7IFEX_PROFILE_HEADER_SIZE + LJV7IFEX_PROFILE_FOOTER_SIZE
End Function

Private Function ProfileCountPerBlock(profileInfo As LJV7IF_PROFILE_INFO) As Long
 ProfileCountPerBlock = profileInfo.byProfileCnt * (profileInfo.byEnvelope + 1)
End Function

Private Function ElementCountPerProfile(profileInfo As LJV7IF_PROFILE_INFO) As Long
 ElementCountPerProfile = profileInfo.wProfDataCnt
End Function

Private Function TotalElementCountPerBlock(profileInfo As LJV7IF_PROFILE_INFO) As Long
 TotalElementCountPerBlock = ElementCountPerProfile(profileInfo) * ProfileCountPerBlock(profileInfo)
End Function

Private Function ProfileSizePerBlock(profileInfo As LJV7IF_PROFILE_INFO) As Long
 ProfileSizePerBlock = ElementCountPerProfile(profileInfo) * ProfileCountPerBlock(profileInfo) + LJV7IFEX_PROFILE_HEADER_SIZE + LJV7IFEX_PROFILE_FOOTER_SIZE
End Function

Private Function ProfileHeadLineString(profileInfo As LJV7IF_PROFILE_INFO) As String
 Dim cntProfile As Integer
 cntProfile = ProfileCountPerBlock(profileInfo)
 Dim cntElement As Integer
 cntElement = ElementCountPerProfile(profileInfo)
  
 'X position
 Dim posX As Double
 Dim deltaX As Double
 posX = profileInfo.lXStart
 deltaX = profileInfo.lXPitch
  
 'Headline
 Dim strHeadline As String
 Dim idxProfile As Integer
 Dim idxElement As Integer
 For idxProfile = 0 To cntProfile - 1
  For idxElement = 0 To cntElement - 1
   strHeadline = strHeadline & CStr(posX + deltaX * idxElement) & vbTab
  Next idxElement
 Next idxProfile
 
 ProfileHeadLineString = strHeadline
End Function

Private Function ProfileBodyString(profileInfo As LJV7IF_PROFILE_INFO, ByRef buffer() As Long, idxHeadPosition As Long) As String
 Dim cntElement As Long
 cntElement = TotalElementCountPerBlock(profileInfo)

 'Read header data
 Dim dwTriggerCount As Long
 dwTriggerCount = buffer(idxHeadPosition + 1)
 Dim dwEncoderCount As Long
 dwEncoderCount = buffer(idxHeadPosition + 2)

 'Body
 Dim strBody As String
 Dim idxBodyDataPos As Long
 idxBodyDataPos = idxHeadPosition + LJV7IFEX_PROFILE_HEADER_SIZE
 Dim idxProfile As Long
 Dim idxElement As Long
 For idxElement = 0 To cntElement - 1
  strBody = strBody & CStr(buffer(idxBodyDataPos + idxElement)) & vbTab
 Next idxElement
 
 ProfileBodyString = strBody
End Function

'-- For measurement value
Private Function MeasureDataBlockSize() As Long
 MeasureDataBlockSize = LJV7IFEX_MEASURE_DATA_SIZE * LJV7IF_OUT_COUNT
End Function

Private Sub ShowMeasurementValue(resultMeasure() As LJV7IF_MEASURE_DATA)
 Dim strData As String
 Dim idxData As Integer
 For idxData = 0 To LJV7IFEX_MAX_OUT_INDEX
  strData = strData & CStr(idxData) & vbTab & MeasureDataString(resultMeasure(idxData)) & vbCrLf
 Next idxData
 TextMeasureResult.Text = strData
End Sub

Private Function MeasureDataString(data As LJV7IF_MEASURE_DATA) As String
 MeasureDataString = CStr(data.fValue) & vbTab & MeasureInfoString(data.byDataInfo) & vbTab & MeasureJudgeString(data.byJudge)
End Function

Private Function MeasureJudgeString(judge As Byte) As String
 Select Case judge
  Case JUDGE_RESULT_HI
   MeasureJudgeString = "HI"
  Case JUDGE_RESULT_LO
   MeasureJudgeString = "LO"
  Case (JUDGE_RESULT_HI Or JUDGE_RESULT_LO)
   MeasureJudgeString = "Alarm"
  Case JUDGE_RESULT_GO
   MeasureJudgeString = "GO"
  Case Else
   MeasureJudgeString = "Unknown &H" & Hex(judge)
 End Select
End Function

Private Function MeasureInfoString(info As Byte) As String
 Select Case info
  Case MEASURE_DATA_INFO_ALARM
   MeasureInfoString = "Alarm"
  Case MEASURE_DATA_INFO_WAIT
   MeasureInfoString = "Wait"
  Case MEASURE_DATA_INFO_VALID
   MeasureInfoString = "Valid"
  Case Else
   MeasureInfoString = "Unknown &H" & Hex(info)
 End Select
End Function

Private Function Min(ByVal value1 As Long, ByVal value2 As Long) As Long
 If value1 <= value2 Then
  Min = value1
 Else
  Min = value2
 End If
End Function





