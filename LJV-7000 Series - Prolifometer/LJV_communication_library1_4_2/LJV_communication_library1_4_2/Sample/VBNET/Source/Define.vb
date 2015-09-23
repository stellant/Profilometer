'----------------------------------------------------------------------------- 
' <copyright file="Define.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
''' <summary>
''' Constant class
''' </summary>
Public NotInheritable Class Define
	Private Sub New()
	End Sub
	#Region "Constant"

	''' <summary>
	''' Get measurement results (the data of all 16 OUTs, including those that are not being measured, is stored).
	''' </summary>
	'public const int MEASUREMENT_VALUE_DATA_COUNT = 16;

	''' <summary>
	''' Maximum amount of data for 1 profile
	''' </summary>
	Public Const MAX_PROFILE_COUNT As Integer = 3200

	''' <summary>
	''' Device ID (fixed to 0)
	''' </summary>
	Public Const DEVICE_ID As Integer = 0

	''' <summary>
	''' Size of data for sending and getting settings
	''' </summary>
	Public Const WRITE_DATA_SIZE As Integer = 20 * 1024

	''' <summary>
	''' Upper limit for the size of data to get
	''' </summary>
	Public Const READ_DATA_SIZE As Integer = 1024 * 1024

	''' <summary>
	''' Maximum amount of profile data to retain
	''' </summary>
	Public Const PROFILE_DATA_MAX As Integer = 10

	''' <summary>
	''' Measurement range X direction
	''' </summary>
	Public Const MEASURE_RANGE_FULL As Integer = 800
	Public Const MEASURE_RANGE_MIDDLE As Integer = 600
	Public Const MEASURE_RANGE_SMALL As Integer = 400

	''' <summary>
	''' Light reception characteristic
	''' </summary>
	Public Const RECEIVED_BINNING_OFF As Integer = 1
	Public Const RECEIVED_BINNING_ON As Integer = 2

	Public Const COMPRESS_X_OFF As Integer = 1
	Public Const COMPRESS_X_2 As Integer = 2
	Public Const COMPRESS_X_4 As Integer = 4
	''' <summary>
	''' Default name to use when exporting profiles
	''' </summary>
    Public Const DEFAULT_PROFILE_FILE_NAME As String = "ReceiveData_VBNET.txt"


	''' <summary>
	''' Unit conversion factor (mm) for profile values
	''' </summary>
	Public Const PROFILE_UNIT_MM As Double = 1E-05

	#End Region
End Class
