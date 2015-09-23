'----------------------------------------------------------------------------- 
' <copyright file="ProfileData.cs" company="KEYENCE">
'	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'----------------------------------------------------------------------------- 
Imports System.Text
Imports System.Runtime.InteropServices

Namespace Datas
	''' <summary>
	''' Profile data class
	''' </summary>
	Public Class ProfileData
		#Region "Field"

		''' <summary>
		''' Trigger count
		''' </summary>
		Private _triggerCnt As Integer

		''' <summary>
		''' Encoder count
		''' </summary>
		Private _encoderCnt As Integer

		''' <summary>
		''' Profile data
		''' </summary>
		Private _profData As Integer()

		''' <summary>
		''' Profile information
		''' </summary>
		Private _profileInfo As LJV7IF_PROFILE_INFO

		#End Region

		#Region "Property"
		''' <summary>
		''' Trigger count
		''' </summary>
		Public ReadOnly Property TriggerCnt() As Integer
			Get
				Return _triggerCnt
			End Get
		End Property

		''' <summary>
		''' Encoder count
		''' </summary>
		Public ReadOnly Property EncodeCnt() As Integer
			Get
				Return _encoderCnt
			End Get
		End Property

		''' <summary>
		''' Profile Data
		''' </summary>
		Public ReadOnly Property ProfDatas() As Integer()
			Get
				Return _profData
			End Get
		End Property

		''' <summary>
		''' Profile Imformation
		''' </summary>
		Public ReadOnly Property ProfInfo() As LJV7IF_PROFILE_INFO
			Get
				Return _profileInfo
			End Get
		End Property
		#End Region

		#Region "Method"
		''' <summary>
		''' Constructor
		''' </summary>
		Public Sub New(receiveBuffer As Integer(), profileInfo As LJV7IF_PROFILE_INFO)
			SetData(receiveBuffer, profileInfo)
		End Sub

		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="receiveBuffer">Receive buffer</param>
		''' <param name="startIndex">Start position</param>
		''' <param name="profileInfo">Profile information</param>
		Public Sub New(receiveBuffer As Byte(), startIndex As Integer, profileInfo As LJV7IF_PROFILE_INFO)
			Dim bufIntSize As Integer = CalculateDataSize(profileInfo)
			Dim bufIntArray As Integer() = New Integer(bufIntSize - 1) {}
			_profileInfo = profileInfo

			' Conversion from byte[] to int[]
			For i As Integer = 0 To bufIntSize - 1
				bufIntArray(i) = BitConverter.ToInt32(receiveBuffer, (startIndex + i * Marshal.SizeOf(GetType(Integer))))
			Next
			SetData(bufIntArray, profileInfo)
		End Sub

		''' <summary>
		''' Constructor Overload
		''' </summary>
		''' <param name="receiveBuffer">Receive buffer</param>
		''' <param name="startIndex">Start position</param>
		''' <param name="profileInfo">Profile information</param>
		Public Sub New(receiveBuffer As Integer(), startIndex As Integer, profileInfo As LJV7IF_PROFILE_INFO)
			Dim bufIntSize As Integer = CalculateDataSize(profileInfo)
			Dim bufIntArray As Integer() = New Integer(bufIntSize - 1) {}
			_profileInfo = profileInfo

			Array.Copy(receiveBuffer, startIndex, bufIntArray, 0, bufIntSize)
			SetData(bufIntArray, profileInfo)
		End Sub

		''' <summary>
		''' Set the members to the arguments.
		''' </summary>
		''' <param name="receiveBuffer">Receive buffer</param>
		''' <param name="profileInfo">Profile information</param>
		Private Sub SetData(receiveBuffer As Integer(), profileInfo As LJV7IF_PROFILE_INFO)
			_profileInfo = profileInfo

			' Extract the header.
			Dim headerSize As Integer = Utility.GetByteSize(Utility.TypeOfStruct.PROFILE_HEADER) \ Marshal.SizeOf(GetType(Integer))
			Dim headerData As Integer() = New Integer(headerSize - 1) {}
			Array.Copy(receiveBuffer, 0, headerData, 0, headerSize)
			_triggerCnt = headerData(1)
			_encoderCnt = headerData(2)

			' Extract the footer.
			Dim footerSize As Integer = Utility.GetByteSize(Utility.TypeOfStruct.PROFILE_FOOTER) \ Marshal.SizeOf(GetType(Integer))
			Dim footerData As Integer() = New Integer(footerSize - 1) {}
			Array.Copy(receiveBuffer, receiveBuffer.Length - footerSize, footerData, 0, footerSize)

			' Extract the profile data.
			Dim profSize As Integer = receiveBuffer.Length - headerSize - footerSize
			_profData = New Integer(profSize - 1) {}
			Array.Copy(receiveBuffer, headerSize, _profData, 0, profSize)
		End Sub

		''' <summary>
		''' Get the data string.
		''' </summary>
		''' <returns>Retained data</returns>
		Public Function GetStringData() As StringBuilder
			Dim retString As New StringBuilder()

			retString.AppendLine(String.Format("Trigger count" & vbTab & ":{0}", _triggerCnt))
			retString.AppendLine(String.Format("Encoder count:{0}", _encoderCnt))

			Return retString
		End Function

		''' <summary>
		''' Data size calculation
		''' </summary>
		''' <param name="profileInfo">Profile information</param>
		''' <returns>Profile data size</returns>
		Public Shared Function CalculateDataSize(profileInfo As LJV7IF_PROFILE_INFO) As Integer
			Dim header As New LJV7IF_PROFILE_HEADER()
			Dim footer As New LJV7IF_PROFILE_FOOTER()

			Return profileInfo.wProfDataCnt * profileInfo.byProfileCnt * (profileInfo.byEnvelope + 1) + (Marshal.SizeOf(header) + Marshal.SizeOf(footer)) \ Marshal.SizeOf(GetType(Integer))
		End Function

		''' <summary>
		''' ToString override
		''' </summary>
		''' <returns>String for display</returns>
		Public Overrides Function ToString() As String
			Dim sb As New StringBuilder()

			' Data position calculation
			Dim posX As Double = ProfInfo.lXStart
			Dim deltaX As Double = ProfInfo.lXPitch

			Dim singleProfileCount As Integer = ProfInfo.wProfDataCnt
			Dim dataCount As Integer = CInt(ProfInfo.byProfileCnt) * (ProfInfo.byEnvelope + 1)

			For i As Integer = 0 To singleProfileCount - 1
				sb.AppendFormat("{0}" & vbTab, posX + deltaX * i)
				For j As Integer = 0 To dataCount - 1
					sb.AppendFormat("{0}" & vbTab, _profData(i + ProfInfo.wProfDataCnt * j))
				Next
				sb.AppendLine()
			Next

			Return sb.ToString()
		End Function

		''' <summary>
		''' Create the X-position string from the profile information.
		''' </summary>
		''' <param name="profileInfo">Profile information</param>
		''' <returns>X-position string</returns>
		Public Shared Function GetXPosString(profileInfo As LJV7IF_PROFILE_INFO) As String
			Dim sb As New StringBuilder()
			' Data position calculation
			Dim posX As Double = profileInfo.lXStart
			Dim deltaX As Double = profileInfo.lXPitch

			Dim singleProfileCount As Integer = profileInfo.wProfDataCnt
			Dim dataCount As Integer = CInt(profileInfo.byProfileCnt) * (profileInfo.byEnvelope + 1)

			For i As Integer = 0 To dataCount - 1
				For j As Integer = 0 To singleProfileCount - 1
					sb.AppendFormat("{0}" & vbTab, (posX + deltaX * j))
				Next
			Next
			Return sb.ToString()
		End Function

		#End Region
	End Class
End Namespace
