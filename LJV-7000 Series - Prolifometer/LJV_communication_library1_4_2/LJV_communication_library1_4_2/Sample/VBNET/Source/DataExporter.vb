'----------------------------------------------------------------------------- 
' <copyright file="DataExporter.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.IO
Imports System.Text
Imports LJV7_DllSampleAll.Datas

''' <summary>
''' Data export class
''' </summary>
Public NotInheritable Class DataExporter
	Private Sub New()
	End Sub
	#Region "Method"

	''' <summary>
	''' Profile output
	''' </summary>
	''' <param name="datas">Profile data</param>
	''' <param name="profileNo">Profile information</param>
	''' <param name="fileName">File name</param>
	''' <returns></returns>
	Public Shared Function ExportOneProfile(datas As ProfileData(), profileNo As Integer, fileName As String) As Boolean
		Try
			Dim unicode As Encoding = System.Text.Encoding.GetEncoding("utf-16")
			Using sw As New StreamWriter(fileName, False, unicode)
				Try
					If datas(0) Is Nothing Then
						Return False
					End If
					sw.WriteLine(datas(profileNo).ToString())
				Finally
					sw.Close()
				End Try
			End Using
		Catch ex As Exception
			' File save failure
			System.Diagnostics.Debug.WriteLine(ex.Message)
			System.Diagnostics.Debug.Assert(False)
			Return False
		End Try

		Return True
	End Function

	''' <summary>
	''' Measurement value output
	''' </summary>
	''' <param name="datas">Measurement data</param>
	''' <param name="fileName">File name</param>
	''' <returns></returns>
	Public Shared Function ExportMeasureData(datas As MeasureData(), fileName As String) As Boolean
		Try
			Dim unicode As Encoding = System.Text.Encoding.GetEncoding("utf-16")

			Using sw As New StreamWriter(fileName, False, unicode)
				' File output to all receivers
				For i As Integer = 0 To datas.Length - 1
					sw.WriteLine(datas(i).ToString())
				Next
			End Using
		Catch ex As Exception
			' File save failure
			System.Diagnostics.Debug.WriteLine(ex.Message)
			System.Diagnostics.Debug.Assert(False)
			Return False
		End Try

		Return True
	End Function

	#End Region
End Class
