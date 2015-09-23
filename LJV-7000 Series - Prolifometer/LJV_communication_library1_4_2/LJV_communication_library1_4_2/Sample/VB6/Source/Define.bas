Attribute VB_Name = "Define"
'-----------------------------------------------------------------------------
' <copyright file="Define.bas" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'--Upper limit for the size of data to get(1024 * 1024)
Public Const READ_DATA_SIZE As Long = 1024& * 1024&

'-- Measurement range X direction
Public Const MEASURE_RANGE_FULL = 800
Public Const MEASURE_RANGE_MIDDLE = 600
Public Const MEASURE_RANGE_SMALL = 400

'-- Light reception charateristic
Public Const RECEIVED_BINNING_OFF = 1
Public Const RECEIVED_BINNING_ON = 2

Public Const COMPRESS_X_OFF = 1
Public Const COMPRESS_X_2 = 2
Public Const COMPRESS_X_4 = 4

'-- Others
Public Const BYTE_SIZE = 1
Public Const SIGNED_LONG_SIZE = 4
Public Const UNSIGNED_INT_SIZE = 4
Public Const PROFILE_HEADER_SIZE = 24
Public Const PROFILE_FOOTER_SIZE = 4
Public Const MEASURE_DATA_SIZE = 8


