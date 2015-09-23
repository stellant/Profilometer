'----------------------------------------------------------------------------- 
' <copyright file="MeasureData.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices

Namespace Datas
	''' <summary>
	''' Measurement data class
	''' </summary>
	Public Class MeasureData
		#Region "Field"
		''' <summary>
		''' Elapsed time(ms)
		''' </summary>
		Private _offsetTime As UInteger

		''' <summary>
		''' Measurement results
		''' </summary>
		Private _data As LJV7IF_MEASURE_DATA()
		#End Region

		#Region "Property"
		''' <summary>
		''' Elapsed time(ms)
		''' </summary>
		Public Property OffsetTime() As UInteger
			Get
				Return _offsetTime
			End Get
			Set
				_offsetTime = value
			End Set
		End Property

		''' <summary>
		''' Measurement results
		''' </summary>
		Public ReadOnly Property Data() As LJV7IF_MEASURE_DATA()
			Get
				Return _data
			End Get
		End Property
		#End Region

		#Region "Constructor"
		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="data">Measurement results</param>
		Public Sub New(data As LJV7IF_MEASURE_DATA())
			_data = data
		End Sub

		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="data">Measurement results</param>
		Public Sub New(data As Byte())
			_offsetTime = 0
			Dim measureDataIndex As Integer = 0
			_data = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
			Dim measureDataSize As Integer = Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA)

			For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
				_data(i).byDataInfo = data(measureDataIndex + 0)
				_data(i).byJudge = data(measureDataIndex + 1)
				_data(i).fValue = BitConverter.ToSingle(data, (measureDataIndex + 4))
				measureDataIndex += measureDataSize
			Next
		End Sub

		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="offsetTime">Elapsed time</param>
		''' <param name="data">Measurement results</param>
		Public Sub New(offsetTime As UInteger, data As LJV7IF_MEASURE_DATA())
			_offsetTime = offsetTime
			_data = data
		End Sub

		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="offsetTime">Elapsed time</param>
		''' <param name="data">Start position</param>
		Public Sub New(data As Byte(), startIndex As Integer)
			_offsetTime = BitConverter.ToUInt32(data, startIndex)
			Dim measureDataIndex As Integer = startIndex + Marshal.SizeOf(GetType(UInteger))
			_data = New LJV7IF_MEASURE_DATA(NativeMethods.MeasurementDataCount - 1) {}
			Dim measureDataSize As Integer = Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA)

			For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
				_data(i).byDataInfo = data(measureDataIndex + 0)
				_data(i).byJudge = data(measureDataIndex + 1)
				_data(i).fValue = BitConverter.ToSingle(data, (measureDataIndex + 4))
				measureDataIndex += measureDataSize
			Next
		End Sub

		#End Region

		#Region "Method"
		''' <summary>
		''' Size acquisition
		''' </summary>
		''' <returns>Data size</returns>
		Public Shared Function GetByteSize() As Integer
			Return (Marshal.SizeOf(GetType(UInteger)) + Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA) * NativeMethods.MeasurementDataCount)
		End Function

		''' <summary>
		''' ToString override
		''' </summary>
		''' <returns>String for display</returns>
		Public Overrides Function ToString() As String
			Dim sb As New StringBuilder()

			For i As Integer = 0 To NativeMethods.MeasurementDataCount - 1
				sb.Append(String.Format("{0,0:f4}" & vbTab, _data(i).fValue))
			Next

			Return sb.ToString()
		End Function
		#End Region
	End Class
End Namespace
