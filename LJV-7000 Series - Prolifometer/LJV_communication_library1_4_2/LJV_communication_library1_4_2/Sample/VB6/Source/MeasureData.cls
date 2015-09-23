VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClassMeasureData"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="MeasureData.cls" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Elapsed time(ms)
Private offsetTime As Long

'Measurement results
Private measureData(LJV7IFEX_MAX_OUT_INDEX) As LJV7IF_MEASURE_DATA

'------ Property
'Elapsed time(ms)
Public Property Let LetOffsetTime(newOffsetTime As Long)
 offsetTime = newOffsetTime
End Property

'Measurement results
Public Property Get GetOffsetTime() As Long
 GetOffsetTime = offsetTime
End Property

'------ Method
Friend Sub CreateMeasureData(newMeasureData() As LJV7IF_MEASURE_DATA)
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  measureData(i) = newMeasureData(i)
 Next i
End Sub

Friend Sub CreateMeasureDataWithOffset(newOffsetTime As Long, newMeasureData() As LJV7IF_MEASURE_DATA)
 offsetTime = newOffsetTime
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  measureData(i) = newMeasureData(i)
 Next i
End Sub

'"data" is measurement results
Friend Sub GetMeasureData(ByRef data() As LJV7IF_MEASURE_DATA)
 ReDim data(LJV7IFEX_MAX_OUT_INDEX)
 Dim i As Long
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  data(i) = measureData(i)
 Next i
End Sub

Public Function GetMeasureDataString() As String
 Dim returnString As String
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  returnString = returnString & Format(measureData(i).fValue, "0.0000") & vbTab
 Next i
 GetMeasureDataString = returnString
End Function

'"newOffsetTime" is elapsed time
'"data" is measurement results
Public Sub SetDataArrayWithOffset(newOffsetTime As Long, data() As Byte)
 offsetTime = 0
 
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  Dim newMeasureData As LJV7IF_MEASURE_DATA
  newMeasureData.byDataInfo = data(i * SIGNED_LONG_SIZE * LJV7IFEX_MEASURE_DATA_SIZE + 0)
  newMeasureData.byJudge = data(i * SIGNED_LONG_SIZE * LJV7IFEX_MEASURE_DATA_SIZE + 1)
  Call MoveMemory(newMeasureData.fValue, data(i * SIGNED_LONG_SIZE * LJV7IFEX_MEASURE_DATA_SIZE + 4), SIGNED_LONG_SIZE)
  
  measureData(i) = newMeasureData
'  i = i + LJV7IFEX_MEASURE_DATA_SIZE * SIGNED_LONG_SIZE
 Next i
End Sub

'"data" is measurement results
'"startIndex" is start position
Public Sub SetDataArrayWithStartIndex(data() As Long, startIndex As Long)
 Dim offsetTime As Long
 offsetTime = data(0)
 
 Dim measureDataIndex As Long
 measureDataIndex = startIndex + 1
 
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  Dim newMeasureData As LJV7IF_MEASURE_DATA
  
  ' measure data must adjust binary size, so convert LONG's size to BYTE's one.
  Dim param(SIGNED_LONG_SIZE) As Byte
  Call MoveMemory(param(0), data(measureDataIndex), SIGNED_LONG_SIZE)
  newMeasureData.byDataInfo = param(0)
  newMeasureData.byJudge = param(1)
  Call MoveMemory(newMeasureData.fValue, data(measureDataIndex + 1), SIGNED_LONG_SIZE)
  
  measureData(i) = newMeasureData
  
  measureDataIndex = measureDataIndex + (MEASURE_DATA_SIZE / SIGNED_LONG_SIZE)
 Next i
End Sub

'"data" is measurement results
Public Sub SetDataArray(data() As Long)
 Dim offsetTime As Long
 offsetTime = 0
 
 Dim measureDataIndex As Long
 measureDataIndex = 0
 
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  Dim newMeasureData As LJV7IF_MEASURE_DATA
  
  ' measure data must adjust binary size, so convert LONG's size to BYTE's one.
  Dim param(SIGNED_LONG_SIZE) As Byte
  Call MoveMemory(param(0), data(measureDataIndex), SIGNED_LONG_SIZE)
  newMeasureData.byDataInfo = param(0)
  newMeasureData.byJudge = param(1)
  Call MoveMemory(newMeasureData.fValue, data(measureDataIndex + 1), SIGNED_LONG_SIZE)
  
  measureData(i) = newMeasureData
  
  measureDataIndex = measureDataIndex + (MEASURE_DATA_SIZE / SIGNED_LONG_SIZE)
 Next i
End Sub

'"data" is measurement results
Friend Sub SetMeasureDataArrayWithOffsetTime(newOffsetTime As Long, newMeasureData() As LJV7IF_MEASURE_DATA)
 offsetTime = newOffsetTime
 Dim i As Integer
 For i = 0 To LJV7IFEX_MAX_OUT_INDEX Step 1
  measureData(i) = newMeasureData(i)
 Next i
End Sub

