VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClassProfileData"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------
' <copyright file="DeviceData.cls" company="KEYENCE">
'   Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
' </copyright>
'-----------------------------------------------------------------------------

Option Explicit

'------ Field
'Trigger count
Private triggerCnt As Long

'Encoder count
Private encoderCnt As Long

'Profile data
Private profData() As Long

'Profile information
Private profileInfo As LJV7IF_PROFILE_INFO

'------ Property
'Trigger count
Public Property Get GetTriggerCnt() As Integer
 GetTriggerCnt = triggerCnt
End Property

'Encoder Count
Public Property Get GetEncodeCnt() As Integer
 GetEncodeCnt = encoderCnt
End Property
       
'String for display
Public Function GetProfileDataString() As String
 Dim returnString As String
 
 'Data position calculation
 Dim posX As Double
 Dim deltaX As Double
 posX = profileInfo.lXStart
 deltaX = profileInfo.lXPitch
 
 Dim singleProfileCount As Long
 Dim dataCount As Long
 singleProfileCount = profileInfo.wProfDataCnt
 dataCount = profileInfo.byProfileCnt * (profileInfo.byEnvelope + 1)

 Dim i As Long
 Dim j As Long
 For i = 0 To (singleProfileCount - 1) Step 1
  returnString = returnString & CStr(posX + deltaX * i) & vbTab
  For j = 0 To (dataCount - 1) Step 1
   returnString = returnString & profData(i + profileInfo.wProfDataCnt * j) & vbTab
  Next j
   returnString = returnString & vbCrLf
 Next i
 GetProfileDataString = returnString
End Function
        
'Create the X-position string from the profile information.
'"profileInfo" is Profile information
'Return X-position string
Public Function GetXPosString() As String
 Dim returnString As String
 
 'Data position calculation
 Dim posX As Double
 Dim deltaX As Double
 posX = profileInfo.lXStart
 deltaX = profileInfo.lXPitch
 
 Dim singleProfileCount As Integer
 Dim dataCount As Integer
 singleProfileCount = profileInfo.wProfDataCnt
 dataCount = profileInfo.byProfileCnt * (profileInfo.byEnvelope + 1)
 Dim i As Integer
 Dim j As Integer
 For i = 0 To (dataCount - 1) Step 1
  For j = 0 To (singleProfileCount - 1) Step 1
   returnString = returnString & (posX + deltaX * j) & vbTab
  Next j
 Next i
 GetXPosString = returnString
End Function

'Set the members to the arguments.
'"receiveBuffer" is Receive buffer
'"newProfileInfo" is Profile information
Friend Sub SetData(recieveBuffer() As Long, newProfileInfo As LJV7IF_PROFILE_INFO)
 profileInfo = newProfileInfo
 
 'Extract the header.
 Dim headaerSize As Integer
 headaerSize = PROFILE_HEADER_SIZE / SIGNED_LONG_SIZE
 Dim headerData() As Long
 ReDim headerData(headaerSize - 1)
 Dim headerDataIndex As Long
 For headerDataIndex = 0 To (headaerSize - 1) Step 1
 headerData(headerDataIndex) = recieveBuffer(headerDataIndex)
 Next headerDataIndex
 triggerCnt = recieveBuffer(1)
 encoderCnt = recieveBuffer(2)
 
 'Extract the footer.
 Dim footerSize As Integer
 footerSize = PROFILE_FOOTER_SIZE / SIGNED_LONG_SIZE
 Dim footerData() As Long
 ReDim footerData(footerSize - 1)
 Dim footerDataIndex As Integer
 For footerDataIndex = 0 To (footerSize - 1) Step 1
  footerData(footerDataIndex) = recieveBuffer(UBound(recieveBuffer) - PROFILE_FOOTER_SIZE + 1)
 Next footerDataIndex
    
 'Extract the profile data.
 Dim profSize As Integer
 profSize = (UBound(recieveBuffer) + 1) - headaerSize - footerSize
 ReDim profData(profSize - 1)
 Dim profDataIndex As Integer
 For profDataIndex = 0 To (profSize - 1) Step 1
  profData(profDataIndex) = recieveBuffer(headaerSize + profDataIndex)
 Next profDataIndex
End Sub

'"receiveBuffer" is receive buffer
'"startIndex" is start position
'"profileInfo" is profile information
Friend Sub SetDataWithStartIndex(receiveBuffer() As Long, startIndex As Long, newProfileInfo As LJV7IF_PROFILE_INFO)
 Dim bufIntSize As Integer
 Dim bufIntArray() As Long
 
 bufIntSize = CalculateDataSize(newProfileInfo)
 ReDim bufIntArray(bufIntSize)
 profileInfo = newProfileInfo
 
 Dim i As Integer
 For i = 0 To (bufIntSize - 1) Step 1
  bufIntArray(i) = receiveBuffer(startIndex + i)
  Call SetData(bufIntArray, newProfileInfo)
 Next i
End Sub

'Data size alculation
'"profileInfo" is profile information
'Return profile data size
Private Function CalculateDataSize(profileInfo As LJV7IF_PROFILE_INFO) As Long
 CalculateDataSize = profileInfo.wProfDataCnt * profileInfo.byProfileCnt * (profileInfo.byEnvelope + 1) + ((PROFILE_HEADER_SIZE + PROFILE_FOOTER_SIZE) / SIGNED_LONG_SIZE)
End Function
