'----------------------------------------------------------------------------- 
' <copyright file="PinnedObject.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices

''' <summary>
''' Object pinning class
''' </summary>
Public NotInheritable Class PinnedObject
	Implements IDisposable
	#Region "Field"

	Private _Handle As GCHandle
	' Garbage collector handle
	#End Region

	#Region "Property"

	''' <summary>
	''' Get the address.
	''' </summary>
	Public ReadOnly Property Pointer() As IntPtr
		' Get the leading address of the current object that is pinned.
		Get
			Return _Handle.AddrOfPinnedObject()
		End Get
	End Property

	#End Region

	#Region "Constructor"

	''' <summary>
	''' Constructor
	''' </summary>
	''' <param name="target">Target to protect from the garbage collector</param>
	Public Sub New(target As Object)
		' Pin the target to protect it from the garbage collector.
		_Handle = GCHandle.Alloc(target, GCHandleType.Pinned)
	End Sub

	#End Region

	#Region "Interface"
	''' <summary>
	''' Interface
	''' </summary>
	Public Sub Dispose() Implements IDisposable.Dispose
		_Handle.Free()
		_Handle = New GCHandle()
	End Sub

	#End Region
End Class
