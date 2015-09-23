'----------------------------------------------------------------------------- 
' <copyright file="ThreadSafeBuffer.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Collections.Generic

''' <summary>
''' Thread-safe class for array storage
''' </summary>
Public NotInheritable Class ThreadSafeBuffer
	Private Sub New()
	End Sub
	#Region "Field"
	''' <summary>Data buffer</summary>
	Private Shared _buffer As List(Of Integer())() = New List(Of Integer())(NativeMethods.DeviceCount - 1) {}
	''' <summary>Buffer for the amount of data</summary>
	Private Shared _count As UInteger() = New UInteger(NativeMethods.DeviceCount - 1) {}
	''' <summary>Object for exclusive control</summary>
	Private Shared _syncObject As Object() = New Object(NativeMethods.DeviceCount - 1) {}
	''' <summary>Callback function notification parameter</summary>
	Private Shared _notify As UInteger() = New UInteger(NativeMethods.DeviceCount - 1) {}
	''' <summary>Batch number</summary>
	Private Shared _batchNo As Integer() = New Integer(NativeMethods.DeviceCount - 1) {}
	#End Region

	#Region "Constructor"

	''' <summary>
	''' Constructor
	''' </summary>
	Shared Sub New()
		For i As Integer = 0 To NativeMethods.DeviceCount - 1
			_buffer(i) = New List(Of Integer())()
			_syncObject(i) = New Object()
		Next
	End Sub
	#End Region

	#Region "Method"
	''' <summary>
	''' Element addition
	''' </summary>
	''' <param name="index">User information set when high-speed communication was initialized</param>
	''' <param name="value">Additional element</param>
	''' <param name="notify">Parameter for notification</param>
	Public Shared Sub Add(index As Integer, value As List(Of Integer()), notify As UInteger)
		SyncLock _syncObject(index)
			_buffer(index).AddRange(value)
			_count(index) += CUInt(value.Count)
			_notify(index) = _notify(index) Or notify
			' Add the batch number if the batch has been finalized.
            If (notify And (&H1 << 16)) <> 0 Then
                _batchNo(index) += 1
            End If
		End SyncLock
	End Sub

	''' <summary>
	''' Clear elements.
	''' </summary>
	''' <param name="index">Device ID</param>
	Public Shared Sub Clear(_currentDeviceId As Integer)
		SyncLock _syncObject(_currentDeviceId)
			_buffer(_currentDeviceId).Clear()
		End SyncLock
	End Sub

	''' <summary>
	''' Clear the number of elements.
	''' </summary>
	''' <param name="index">Device ID</param>
	Public Shared Sub ClearCount(index As Integer)
		SyncLock _syncObject(index)
			_count(index) = 0
		End SyncLock
	End Sub

	''' <summary>
	''' Clear notifications.
	''' </summary>
	''' <param name="index">Device ID</param>
	Public Shared Sub ClearNotify(index As Integer)
		SyncLock _syncObject(index)
			_notify(index) = 0
		End SyncLock
	End Sub

	''' <summary>
	''' Clear elements.
	''' </summary>
	Public Shared Sub ClearAll()
		For i As Integer = 0 To NativeMethods.DeviceCount - 1
			ClearBuffer(i)
		Next
	End Sub

	''' <summary>
	''' Clear the buffer.
	''' </summary>
	''' <param name="_currentDeviceId">Device ID</param>
	Public Shared Sub ClearBuffer(_currentDeviceId As Integer)
		Clear(_currentDeviceId)
		ClearCount(_currentDeviceId)
		_batchNo(_currentDeviceId) = 0
		ClearNotify(_currentDeviceId)
	End Sub

	''' <summary>
	''' Get element.
	''' </summary>
	''' <param name="index">Device ID</param>
	''' <param name="notify">Parameter for notification</param>
	''' <param name="batchNo">Batch number</param>
	''' <returns>Element</returns>
	Public Shared Function [Get](index As Integer, ByRef notify As UInteger, ByRef batchNo As Integer) As List(Of Integer())
		Dim value As New List(Of Integer())()
		SyncLock _syncObject(index)
			For Each data As Integer() In _buffer(index)
				value.Add(data)
			Next
			_buffer(index).Clear()
			notify = _notify(index)
			_notify(index) = 0
			batchNo = _batchNo(index)
		End SyncLock
		Return value
	End Function

	''' <summary>
	''' Add the count
	''' </summary>
	''' <param name="index">Device ID</param>
	''' <param name="count">Count</param>
	''' <param name="notify">Parameter for notification</param>
	Friend Shared Sub AddCount(index As Integer, count As UInteger, notify As UInteger)
		SyncLock _syncObject(index)
			_count(index) += count
			_notify(index) = _notify(index) Or notify
			' Add the batch number if the batch has been finalized.
            If (notify And (&H1 << 16)) <> 0 Then
                _batchNo(index) += 1
            End If
		End SyncLock
	End Sub

	''' <summary>
	''' Get the count
	''' </summary>
	''' <param name="index">Device ID</param>
	''' <param name="notify">Parameter for notification</param>
	''' <param name="batchNo">Batch number</param>
	''' <returns></returns>
	Friend Shared Function GetCount(index As Integer, ByRef notify As UInteger, ByRef batchNo As Integer) As UInteger
		SyncLock _syncObject(index)
			notify = _notify(index)
			_notify(index) = 0
			batchNo = _batchNo(index)
			Return _count(index)
		End SyncLock
	End Function

	#End Region
End Class
