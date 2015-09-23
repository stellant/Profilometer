Partial Class MainForm
	''' <summary>
	''' 必要なデザイナ変数です。
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' 使用中のリソースをすべてクリーンアップします。
	''' </summary>
	''' <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows フォーム デザイナで生成されたコード"

	''' <summary>
	''' デザイナ サポートに必要なメソッドです。このメソッドの内容を
	''' コード エディタで変更しないでください。
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me._btnUsbOpen = New System.Windows.Forms.Button()
		Me._btnGetTime = New System.Windows.Forms.Button()
		Me._btnGetVersion = New System.Windows.Forms.Button()
		Me._btnFinalize = New System.Windows.Forms.Button()
		Me._btnInitialize = New System.Windows.Forms.Button()
		Me._btnCommClose = New System.Windows.Forms.Button()
		Me._btnEthernetOpen = New System.Windows.Forms.Button()
		Me._grpCommand = New System.Windows.Forms.GroupBox()
		Me.groupBox7 = New System.Windows.Forms.GroupBox()
		Me._btnHighSpeedDataUsbCommunicationInitalize = New System.Windows.Forms.Button()
		Me._btnHighSpeedDataEthernetCommunicationInitalize = New System.Windows.Forms.Button()
		Me._btnPreStartHighSpeedDataCommunication = New System.Windows.Forms.Button()
		Me._btnStartHighSpeedDataCommunication = New System.Windows.Forms.Button()
		Me._btnStopHighSpeedDataCommunication = New System.Windows.Forms.Button()
		Me._btnHighSpeedDataCommunicationFinalize = New System.Windows.Forms.Button()
		Me.groupBox6 = New System.Windows.Forms.GroupBox()
		Me._btnStartStorage = New System.Windows.Forms.Button()
		Me._btnStopStorage = New System.Windows.Forms.Button()
		Me._btnGetStorageStatus = New System.Windows.Forms.Button()
		Me._btnGetStorageData = New System.Windows.Forms.Button()
		Me._btnGetStorageProfile = New System.Windows.Forms.Button()
		Me._btnGetStorageBatchProfile = New System.Windows.Forms.Button()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me._btnGetMeasurementValue = New System.Windows.Forms.Button()
		Me._btnGetProfile = New System.Windows.Forms.Button()
		Me._btnGetBatchProfile = New System.Windows.Forms.Button()
		Me._btnGetBatchProfileAdvance = New System.Windows.Forms.Button()
		Me._btnGetProfileAdvance = New System.Windows.Forms.Button()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me._btnSetSetting = New System.Windows.Forms.Button()
		Me._btnGetSetting = New System.Windows.Forms.Button()
		Me._btnInitializeSetting = New System.Windows.Forms.Button()
		Me._btnUpdataSetting = New System.Windows.Forms.Button()
		Me._btnRewriteTemporarySetting = New System.Windows.Forms.Button()
		Me._btnCheckMemoryAccess = New System.Windows.Forms.Button()
		Me._btnSetTime = New System.Windows.Forms.Button()
		Me._btnGetActiveProgram = New System.Windows.Forms.Button()
		Me._btnChangeActiveProgram = New System.Windows.Forms.Button()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me._btnTrigger = New System.Windows.Forms.Button()
		Me._btnStartMeasure = New System.Windows.Forms.Button()
		Me._btnStopMeasure = New System.Windows.Forms.Button()
		Me._btnAutoZero = New System.Windows.Forms.Button()
		Me._btnClearMemory = New System.Windows.Forms.Button()
		Me._btnReset = New System.Windows.Forms.Button()
		Me._btnTiming = New System.Windows.Forms.Button()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me._btnRebootController = New System.Windows.Forms.Button()
		Me._btnRetrunToFactorySetting = New System.Windows.Forms.Button()
		Me._btnGetError = New System.Windows.Forms.Button()
		Me._btnClearError = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me._groupBox1 = New System.Windows.Forms.GroupBox()
		Me._grpLog = New System.Windows.Forms.GroupBox()
		Me._txtboxLog = New System.Windows.Forms.TextBox()
		Me._btnLogClear = New System.Windows.Forms.Button()
		Me._grpBufferSize = New System.Windows.Forms.GroupBox()
		Me._lblSettingAttention = New System.Windows.Forms.Label()
		Me._grpReceived = New System.Windows.Forms.GroupBox()
		Me._chkboxEnvelope = New System.Windows.Forms.CheckBox()
		Me._cmbCompressX = New System.Windows.Forms.ComboBox()
		Me._lblCompressX = New System.Windows.Forms.Label()
		Me._grpMeasureRange = New System.Windows.Forms.GroupBox()
		Me._cmbReceivedBinning = New System.Windows.Forms.ComboBox()
		Me._cmbMeasureX = New System.Windows.Forms.ComboBox()
		Me._lblReceivedBinning = New System.Windows.Forms.Label()
		Me._lblMeasureX = New System.Windows.Forms.Label()
		Me._grpHead = New System.Windows.Forms.GroupBox()
		Me._rdbtnOneHead = New System.Windows.Forms.RadioButton()
		Me._rdbtnTwoHead = New System.Windows.Forms.RadioButton()
		Me._rdbtnWide = New System.Windows.Forms.RadioButton()
		Me._grpExport = New System.Windows.Forms.GroupBox()
		Me._nudProfileNo = New System.Windows.Forms.NumericUpDown()
		Me._txtboxProfileFilePath = New System.Windows.Forms.TextBox()
		Me._btnSaveMeasureData = New System.Windows.Forms.Button()
		Me._btnSave = New System.Windows.Forms.Button()
		Me._btnProfileFileSave = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me._lblSavePath = New System.Windows.Forms.Label()
		Me._profileFileSave = New System.Windows.Forms.SaveFileDialog()
		Me._timerHighSpeedReceive = New System.Windows.Forms.Timer(Me.components)
		Me._lblReceiveProfileCount0 = New System.Windows.Forms.Label()
		Me._rdDevice0 = New System.Windows.Forms.RadioButton()
		Me._rdDevice2 = New System.Windows.Forms.RadioButton()
		Me._rdDevice1 = New System.Windows.Forms.RadioButton()
		Me._pnlDeviceId = New System.Windows.Forms.Panel()
		Me._lblDeviceStatus5 = New System.Windows.Forms.Label()
		Me._lblDeviceStatus4 = New System.Windows.Forms.Label()
		Me.radioButton2 = New System.Windows.Forms.RadioButton()
		Me.radioButton1 = New System.Windows.Forms.RadioButton()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me._lblReceiveProfileCount5 = New System.Windows.Forms.Label()
		Me._lblReceiveProfileCount4 = New System.Windows.Forms.Label()
		Me._lblReceiveProfileCount3 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me._lblReceiveProfileCount1 = New System.Windows.Forms.Label()
		Me._lblReceiveProfileCount2 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me._lblDeviceStatus3 = New System.Windows.Forms.Label()
		Me._lblDeviceStatus2 = New System.Windows.Forms.Label()
		Me._lblDeviceStatus1 = New System.Windows.Forms.Label()
		Me._lblDeviceStatus0 = New System.Windows.Forms.Label()
		Me._rdDevice3 = New System.Windows.Forms.RadioButton()
		Me._chkOnlyProfileCount = New System.Windows.Forms.CheckBox()
		Me._chkStartTimer = New System.Windows.Forms.CheckBox()
		Me._numInterval = New System.Windows.Forms.NumericUpDown()
		Me._tabControl = New System.Windows.Forms.TabControl()
		Me._tabPage1 = New System.Windows.Forms.TabPage()
		Me._groupBox = New System.Windows.Forms.GroupBox()
		Me._lblConectedDevice = New System.Windows.Forms.Label()
		Me.groupBox8 = New System.Windows.Forms.GroupBox()
		Me._tabPage2 = New System.Windows.Forms.TabPage()
		Me._grpProgram = New System.Windows.Forms.GroupBox()
		Me._btnUploadProgram = New System.Windows.Forms.Button()
		Me._btnDownloadProgram = New System.Windows.Forms.Button()
		Me._btnReferenceProgramFilePath = New System.Windows.Forms.Button()
		Me._txtProgramFilePath = New System.Windows.Forms.TextBox()
		Me._lblSelectProgram = New System.Windows.Forms.Label()
		Me._cbxSelectProgram = New System.Windows.Forms.ComboBox()
		Me._grpHighSpeed = New System.Windows.Forms.GroupBox()
		Me._txtCallbackFrequency = New System.Windows.Forms.TextBox()
		Me._txtStartProfileNo = New System.Windows.Forms.TextBox()
		Me._lblReceiveProfileCount = New System.Windows.Forms.Label()
		Me._lblCallbackFrequency = New System.Windows.Forms.Label()
		Me._btnTerminateHighSpeedCommunication = New System.Windows.Forms.Button()
		Me._lblHighSpeedStartNo = New System.Windows.Forms.Label()
		Me._lblReceiveCount = New System.Windows.Forms.Label()
		Me._btnBeginHighSpeedDataCommunication = New System.Windows.Forms.Button()
		Me._grpGetData = New System.Windows.Forms.GroupBox()
		Me._txtMeasureData = New System.Windows.Forms.TextBox()
		Me._grpGetProfile = New System.Windows.Forms.GroupBox()
		Me._btnGetProfileAdvanceData = New System.Windows.Forms.Button()
		Me._btnReferenceSavePath = New System.Windows.Forms.Button()
		Me._btnGetBatchProfileDataAdvance = New System.Windows.Forms.Button()
		Me._btnGetBatchProfileData = New System.Windows.Forms.Button()
		Me._btnGetProfileData = New System.Windows.Forms.Button()
		Me._txtSavePath = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me._btnGetLatestMeasureValue = New System.Windows.Forms.Button()
		Me._grpBaseOperation = New System.Windows.Forms.GroupBox()
		Me._pnlCommunicationDevice = New System.Windows.Forms.Panel()
		Me._rdUsb = New System.Windows.Forms.RadioButton()
		Me._rdEthernet = New System.Windows.Forms.RadioButton()
		Me._grpEthernetSetting = New System.Windows.Forms.GroupBox()
		Me._txtIpFirstSegment = New System.Windows.Forms.TextBox()
		Me._txtIpFourthSegment = New System.Windows.Forms.TextBox()
		Me._txtIpSecondSegment = New System.Windows.Forms.TextBox()
		Me._lblHighSpeedPort = New System.Windows.Forms.Label()
		Me._txtIpThirdSegment = New System.Windows.Forms.TextBox()
		Me._lblIpSeparator3 = New System.Windows.Forms.Label()
		Me._lblIpSeparator2 = New System.Windows.Forms.Label()
		Me._txtHighSpeedPort = New System.Windows.Forms.TextBox()
		Me._lblIpSeparator1 = New System.Windows.Forms.Label()
		Me._txtCommandPort = New System.Windows.Forms.TextBox()
		Me._lblIpAddress = New System.Windows.Forms.Label()
		Me._lblCommandPort = New System.Windows.Forms.Label()
		Me._btnTerminateCommunication = New System.Windows.Forms.Button()
		Me._btnEstablishCommunication = New System.Windows.Forms.Button()
		Me._timerHighSpeed = New System.Windows.Forms.Timer(Me.components)
		Me._openProgramFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me._grpCommand.SuspendLayout()
		Me.groupBox7.SuspendLayout()
		Me.groupBox6.SuspendLayout()
		Me.groupBox5.SuspendLayout()
		Me.groupBox4.SuspendLayout()
		Me.groupBox3.SuspendLayout()
		Me.groupBox2.SuspendLayout()
		Me.groupBox1.SuspendLayout()
		Me._groupBox1.SuspendLayout()
		Me._grpLog.SuspendLayout()
		Me._grpBufferSize.SuspendLayout()
		Me._grpReceived.SuspendLayout()
		Me._grpMeasureRange.SuspendLayout()
		Me._grpHead.SuspendLayout()
		Me._grpExport.SuspendLayout()
		DirectCast(Me._nudProfileNo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me._pnlDeviceId.SuspendLayout()
		Me.panel1.SuspendLayout()
		DirectCast(Me._numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
		Me._tabControl.SuspendLayout()
		Me._tabPage1.SuspendLayout()
		Me._groupBox.SuspendLayout()
		Me.groupBox8.SuspendLayout()
		Me._tabPage2.SuspendLayout()
		Me._grpProgram.SuspendLayout()
		Me._grpHighSpeed.SuspendLayout()
		Me._grpGetData.SuspendLayout()
		Me._grpGetProfile.SuspendLayout()
		Me._grpBaseOperation.SuspendLayout()
		Me._pnlCommunicationDevice.SuspendLayout()
		Me._grpEthernetSetting.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _btnUsbOpen
		' 
		Me._btnUsbOpen.BackColor = System.Drawing.Color.LightGray
		Me._btnUsbOpen.Location = New System.Drawing.Point(6, 19)
		Me._btnUsbOpen.Name = "_btnUsbOpen"
		Me._btnUsbOpen.Size = New System.Drawing.Size(145, 25)
		Me._btnUsbOpen.TabIndex = 0
		Me._btnUsbOpen.Text = "UsbOpen"
		Me._btnUsbOpen.UseVisualStyleBackColor = False
		AddHandler Me._btnUsbOpen.Click, New System.EventHandler(AddressOf Me.btnUsbOpen_Click)
		' 
		' _btnGetTime
		' 
		Me._btnGetTime.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetTime.Location = New System.Drawing.Point(452, 52)
		Me._btnGetTime.Name = "_btnGetTime"
		Me._btnGetTime.Size = New System.Drawing.Size(143, 25)
		Me._btnGetTime.TabIndex = 7
		Me._btnGetTime.Text = "GetTime"
		Me._btnGetTime.UseVisualStyleBackColor = False
		AddHandler Me._btnGetTime.Click, New System.EventHandler(AddressOf Me.btnGetTime_Click)
		' 
		' _btnGetVersion
		' 
		Me._btnGetVersion.Location = New System.Drawing.Point(156, 19)
		Me._btnGetVersion.Name = "_btnGetVersion"
		Me._btnGetVersion.Size = New System.Drawing.Size(136, 25)
		Me._btnGetVersion.TabIndex = 1
		Me._btnGetVersion.Text = "GetVersion"
		Me._btnGetVersion.UseVisualStyleBackColor = True
		AddHandler Me._btnGetVersion.Click, New System.EventHandler(AddressOf Me.btnGetVersion_Click)
		' 
		' _btnFinalize
		' 
		Me._btnFinalize.Location = New System.Drawing.Point(303, 19)
		Me._btnFinalize.Name = "_btnFinalize"
		Me._btnFinalize.Size = New System.Drawing.Size(143, 25)
		Me._btnFinalize.TabIndex = 2
		Me._btnFinalize.Text = "Finalize"
		Me._btnFinalize.UseVisualStyleBackColor = True
		AddHandler Me._btnFinalize.Click, New System.EventHandler(AddressOf Me.btnFinalize_Click)
		' 
		' _btnInitialize
		' 
		Me._btnInitialize.Location = New System.Drawing.Point(6, 19)
		Me._btnInitialize.Name = "_btnInitialize"
		Me._btnInitialize.Size = New System.Drawing.Size(144, 25)
		Me._btnInitialize.TabIndex = 0
		Me._btnInitialize.Text = "Initialize"
		Me._btnInitialize.UseVisualStyleBackColor = True
		AddHandler Me._btnInitialize.Click, New System.EventHandler(AddressOf Me.btnInitialize_Click)
		' 
		' _btnCommClose
		' 
		Me._btnCommClose.BackColor = System.Drawing.Color.LightGray
		Me._btnCommClose.Location = New System.Drawing.Point(304, 19)
		Me._btnCommClose.Name = "_btnCommClose"
		Me._btnCommClose.Size = New System.Drawing.Size(143, 25)
		Me._btnCommClose.TabIndex = 2
		Me._btnCommClose.Text = "CommClose"
		Me._btnCommClose.UseVisualStyleBackColor = False
		AddHandler Me._btnCommClose.Click, New System.EventHandler(AddressOf Me.btnCommClose_Click)
		' 
		' _btnEthernetOpen
		' 
		Me._btnEthernetOpen.BackColor = System.Drawing.Color.LightGray
		Me._btnEthernetOpen.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnEthernetOpen.Location = New System.Drawing.Point(157, 19)
		Me._btnEthernetOpen.Name = "_btnEthernetOpen"
		Me._btnEthernetOpen.Size = New System.Drawing.Size(136, 25)
		Me._btnEthernetOpen.TabIndex = 1
		Me._btnEthernetOpen.Text = "EthernetOpen"
		Me._btnEthernetOpen.UseVisualStyleBackColor = False
		AddHandler Me._btnEthernetOpen.Click, New System.EventHandler(AddressOf Me.btnEthernetOpen_Click)
		' 
		' _grpCommand
		' 
		Me._grpCommand.BackColor = System.Drawing.Color.Linen
		Me._grpCommand.Controls.Add(Me.groupBox7)
		Me._grpCommand.Controls.Add(Me.groupBox6)
		Me._grpCommand.Controls.Add(Me.groupBox5)
		Me._grpCommand.Controls.Add(Me.groupBox4)
		Me._grpCommand.Controls.Add(Me.groupBox3)
		Me._grpCommand.Controls.Add(Me.groupBox2)
		Me._grpCommand.Controls.Add(Me.groupBox1)
		Me._grpCommand.Controls.Add(Me._groupBox1)
		Me._grpCommand.Location = New System.Drawing.Point(3, 3)
		Me._grpCommand.Name = "_grpCommand"
		Me._grpCommand.Size = New System.Drawing.Size(618, 731)
		Me._grpCommand.TabIndex = 0
		Me._grpCommand.TabStop = False
		Me._grpCommand.Text = "Communication command"
		' 
		' groupBox7
		' 
		Me.groupBox7.Controls.Add(Me._btnHighSpeedDataUsbCommunicationInitalize)
		Me.groupBox7.Controls.Add(Me._btnHighSpeedDataEthernetCommunicationInitalize)
		Me.groupBox7.Controls.Add(Me._btnPreStartHighSpeedDataCommunication)
		Me.groupBox7.Controls.Add(Me._btnStartHighSpeedDataCommunication)
		Me.groupBox7.Controls.Add(Me._btnStopHighSpeedDataCommunication)
		Me.groupBox7.Controls.Add(Me._btnHighSpeedDataCommunicationFinalize)
		Me.groupBox7.Location = New System.Drawing.Point(9, 603)
		Me.groupBox7.Name = "groupBox7"
		Me.groupBox7.Size = New System.Drawing.Size(603, 119)
		Me.groupBox7.TabIndex = 7
		Me.groupBox7.TabStop = False
		Me.groupBox7.Text = "High-speed data communication related functions"
		' 
		' _btnHighSpeedDataUsbCommunicationInitalize
		' 
		Me._btnHighSpeedDataUsbCommunicationInitalize.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(218)), CInt(CByte(255)))
		Me._btnHighSpeedDataUsbCommunicationInitalize.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnHighSpeedDataUsbCommunicationInitalize.Location = New System.Drawing.Point(6, 19)
		Me._btnHighSpeedDataUsbCommunicationInitalize.Name = "_btnHighSpeedDataUsbCommunicationInitalize"
		Me._btnHighSpeedDataUsbCommunicationInitalize.Size = New System.Drawing.Size(141, 44)
		Me._btnHighSpeedDataUsbCommunicationInitalize.TabIndex = 0
		Me._btnHighSpeedDataUsbCommunicationInitalize.Text = "HighSpeedDataUSB CommunicationInitalize"
		Me._btnHighSpeedDataUsbCommunicationInitalize.UseVisualStyleBackColor = False
		AddHandler Me._btnHighSpeedDataUsbCommunicationInitalize.Click, New System.EventHandler(AddressOf Me.btnHighSpeedDataUsbCommunicationInitalize_Click)
		' 
		' _btnHighSpeedDataEthernetCommunicationInitalize
		' 
		Me._btnHighSpeedDataEthernetCommunicationInitalize.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(218)), CInt(CByte(255)))
		Me._btnHighSpeedDataEthernetCommunicationInitalize.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnHighSpeedDataEthernetCommunicationInitalize.Location = New System.Drawing.Point(153, 19)
		Me._btnHighSpeedDataEthernetCommunicationInitalize.Name = "_btnHighSpeedDataEthernetCommunicationInitalize"
		Me._btnHighSpeedDataEthernetCommunicationInitalize.Size = New System.Drawing.Size(141, 44)
		Me._btnHighSpeedDataEthernetCommunicationInitalize.TabIndex = 1
		Me._btnHighSpeedDataEthernetCommunicationInitalize.Text = "HighSpeedDataEthernet CommunicationInitalize"
		Me._btnHighSpeedDataEthernetCommunicationInitalize.UseVisualStyleBackColor = False
		AddHandler Me._btnHighSpeedDataEthernetCommunicationInitalize.Click, New System.EventHandler(AddressOf Me.btnHighSpeedDataEthernetCommunicationInitalize_Click)
		' 
		' _btnPreStartHighSpeedDataCommunication
		' 
		Me._btnPreStartHighSpeedDataCommunication.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(218)), CInt(CByte(255)))
		Me._btnPreStartHighSpeedDataCommunication.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnPreStartHighSpeedDataCommunication.Location = New System.Drawing.Point(300, 19)
		Me._btnPreStartHighSpeedDataCommunication.Name = "_btnPreStartHighSpeedDataCommunication"
		Me._btnPreStartHighSpeedDataCommunication.Size = New System.Drawing.Size(145, 44)
		Me._btnPreStartHighSpeedDataCommunication.TabIndex = 2
		Me._btnPreStartHighSpeedDataCommunication.Text = "PreStartHighSpeedData Communication"
		Me._btnPreStartHighSpeedDataCommunication.UseVisualStyleBackColor = False
		AddHandler Me._btnPreStartHighSpeedDataCommunication.Click, New System.EventHandler(AddressOf Me.btnPreStartHighSpeedDataCommunication_Click)
		' 
		' _btnStartHighSpeedDataCommunication
		' 
		Me._btnStartHighSpeedDataCommunication.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(218)), CInt(CByte(255)))
		Me._btnStartHighSpeedDataCommunication.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnStartHighSpeedDataCommunication.Location = New System.Drawing.Point(449, 19)
		Me._btnStartHighSpeedDataCommunication.Name = "_btnStartHighSpeedDataCommunication"
		Me._btnStartHighSpeedDataCommunication.Size = New System.Drawing.Size(143, 44)
		Me._btnStartHighSpeedDataCommunication.TabIndex = 3
		Me._btnStartHighSpeedDataCommunication.Text = "StartHighSpeed DataCommunication"
		Me._btnStartHighSpeedDataCommunication.UseVisualStyleBackColor = False
		AddHandler Me._btnStartHighSpeedDataCommunication.Click, New System.EventHandler(AddressOf Me.btnStartHighSpeedDataCommunication_Click)
		' 
		' _btnStopHighSpeedDataCommunication
		' 
		Me._btnStopHighSpeedDataCommunication.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(218)), CInt(CByte(255)))
		Me._btnStopHighSpeedDataCommunication.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnStopHighSpeedDataCommunication.Location = New System.Drawing.Point(7, 70)
		Me._btnStopHighSpeedDataCommunication.Name = "_btnStopHighSpeedDataCommunication"
		Me._btnStopHighSpeedDataCommunication.Size = New System.Drawing.Size(140, 44)
		Me._btnStopHighSpeedDataCommunication.TabIndex = 4
		Me._btnStopHighSpeedDataCommunication.Text = "StopHighSpeedData Communication"
		Me._btnStopHighSpeedDataCommunication.UseVisualStyleBackColor = False
		AddHandler Me._btnStopHighSpeedDataCommunication.Click, New System.EventHandler(AddressOf Me.btnStopHighSpeedDataCommunication_Click)
		' 
		' _btnHighSpeedDataCommunicationFinalize
		' 
		Me._btnHighSpeedDataCommunicationFinalize.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(218)), CInt(CByte(255)))
		Me._btnHighSpeedDataCommunicationFinalize.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnHighSpeedDataCommunicationFinalize.Location = New System.Drawing.Point(153, 70)
		Me._btnHighSpeedDataCommunicationFinalize.Name = "_btnHighSpeedDataCommunicationFinalize"
		Me._btnHighSpeedDataCommunicationFinalize.Size = New System.Drawing.Size(141, 44)
		Me._btnHighSpeedDataCommunicationFinalize.TabIndex = 5
		Me._btnHighSpeedDataCommunicationFinalize.Text = "HighSpeedData CommunicationFinalize"
		Me._btnHighSpeedDataCommunicationFinalize.UseVisualStyleBackColor = False
		AddHandler Me._btnHighSpeedDataCommunicationFinalize.Click, New System.EventHandler(AddressOf Me.btnHighSpeedDataCommunicationFinalize_Click)
		' 
		' groupBox6
		' 
		Me.groupBox6.Controls.Add(Me._btnStartStorage)
		Me.groupBox6.Controls.Add(Me._btnStopStorage)
		Me.groupBox6.Controls.Add(Me._btnGetStorageStatus)
		Me.groupBox6.Controls.Add(Me._btnGetStorageData)
		Me.groupBox6.Controls.Add(Me._btnGetStorageProfile)
		Me.groupBox6.Controls.Add(Me._btnGetStorageBatchProfile)
		Me.groupBox6.Location = New System.Drawing.Point(6, 509)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(606, 86)
		Me.groupBox6.TabIndex = 6
		Me.groupBox6.TabStop = False
		Me.groupBox6.Text = "Storage-related functions"
		' 
		' _btnStartStorage
		' 
		Me._btnStartStorage.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me._btnStartStorage.Location = New System.Drawing.Point(7, 19)
		Me._btnStartStorage.Name = "_btnStartStorage"
		Me._btnStartStorage.Size = New System.Drawing.Size(143, 25)
		Me._btnStartStorage.TabIndex = 0
		Me._btnStartStorage.Text = "StartStorage"
		Me._btnStartStorage.UseVisualStyleBackColor = False
		AddHandler Me._btnStartStorage.Click, New System.EventHandler(AddressOf Me.btnStartStorage_Click)
		' 
		' _btnStopStorage
		' 
		Me._btnStopStorage.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me._btnStopStorage.Location = New System.Drawing.Point(156, 19)
		Me._btnStopStorage.Name = "_btnStopStorage"
		Me._btnStopStorage.Size = New System.Drawing.Size(141, 25)
		Me._btnStopStorage.TabIndex = 1
		Me._btnStopStorage.Text = "StopStorage"
		Me._btnStopStorage.UseVisualStyleBackColor = False
		AddHandler Me._btnStopStorage.Click, New System.EventHandler(AddressOf Me.btnStopStorage_Click)
		' 
		' _btnGetStorageStatus
		' 
		Me._btnGetStorageStatus.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me._btnGetStorageStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetStorageStatus.Location = New System.Drawing.Point(303, 19)
		Me._btnGetStorageStatus.Name = "_btnGetStorageStatus"
		Me._btnGetStorageStatus.Size = New System.Drawing.Size(143, 25)
		Me._btnGetStorageStatus.TabIndex = 2
		Me._btnGetStorageStatus.Text = "GetStorageStatus"
		Me._btnGetStorageStatus.UseVisualStyleBackColor = False
		AddHandler Me._btnGetStorageStatus.Click, New System.EventHandler(AddressOf Me.btnGetStorageStatus_Click)
		' 
		' _btnGetStorageData
		' 
		Me._btnGetStorageData.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me._btnGetStorageData.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetStorageData.Location = New System.Drawing.Point(452, 19)
		Me._btnGetStorageData.Name = "_btnGetStorageData"
		Me._btnGetStorageData.Size = New System.Drawing.Size(143, 25)
		Me._btnGetStorageData.TabIndex = 3
		Me._btnGetStorageData.Text = "GetStorageData"
		Me._btnGetStorageData.UseVisualStyleBackColor = False
		AddHandler Me._btnGetStorageData.Click, New System.EventHandler(AddressOf Me.btnGetStorageData_Click)
		' 
		' _btnGetStorageProfile
		' 
		Me._btnGetStorageProfile.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me._btnGetStorageProfile.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetStorageProfile.Location = New System.Drawing.Point(8, 51)
		Me._btnGetStorageProfile.Name = "_btnGetStorageProfile"
		Me._btnGetStorageProfile.Size = New System.Drawing.Size(142, 25)
		Me._btnGetStorageProfile.TabIndex = 4
		Me._btnGetStorageProfile.Text = "GetStorageProfile"
		Me._btnGetStorageProfile.UseVisualStyleBackColor = False
		AddHandler Me._btnGetStorageProfile.Click, New System.EventHandler(AddressOf Me.btnGetStorageProfile_Click)
		' 
		' _btnGetStorageBatchProfile
		' 
		Me._btnGetStorageBatchProfile.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me._btnGetStorageBatchProfile.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetStorageBatchProfile.Location = New System.Drawing.Point(156, 51)
		Me._btnGetStorageBatchProfile.Name = "_btnGetStorageBatchProfile"
		Me._btnGetStorageBatchProfile.Size = New System.Drawing.Size(141, 25)
		Me._btnGetStorageBatchProfile.TabIndex = 5
		Me._btnGetStorageBatchProfile.Text = "GetStorageBatchProfile"
		Me._btnGetStorageBatchProfile.UseVisualStyleBackColor = False
		AddHandler Me._btnGetStorageBatchProfile.Click, New System.EventHandler(AddressOf Me.btnGetStorageBatchProfile_Click)
		' 
		' groupBox5
		' 
		Me.groupBox5.Controls.Add(Me._btnGetMeasurementValue)
		Me.groupBox5.Controls.Add(Me._btnGetProfile)
		Me.groupBox5.Controls.Add(Me._btnGetBatchProfile)
		Me.groupBox5.Controls.Add(Me._btnGetBatchProfileAdvance)
		Me.groupBox5.Controls.Add(Me._btnGetProfileAdvance)
		Me.groupBox5.Location = New System.Drawing.Point(6, 419)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(606, 84)
		Me.groupBox5.TabIndex = 5
		Me.groupBox5.TabStop = False
		Me.groupBox5.Text = "Get measurement results"
		' 
		' _btnGetMeasurementValue
		' 
		Me._btnGetMeasurementValue.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetMeasurementValue.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetMeasurementValue.Location = New System.Drawing.Point(8, 20)
		Me._btnGetMeasurementValue.Name = "_btnGetMeasurementValue"
		Me._btnGetMeasurementValue.Size = New System.Drawing.Size(142, 25)
		Me._btnGetMeasurementValue.TabIndex = 0
		Me._btnGetMeasurementValue.Text = "GetMeasurementValue"
		Me._btnGetMeasurementValue.UseVisualStyleBackColor = False
		AddHandler Me._btnGetMeasurementValue.Click, New System.EventHandler(AddressOf Me.btnGetMeasurementValue_Click)
		' 
		' _btnGetProfile
		' 
		Me._btnGetProfile.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetProfile.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetProfile.Location = New System.Drawing.Point(8, 48)
		Me._btnGetProfile.Name = "_btnGetProfile"
		Me._btnGetProfile.Size = New System.Drawing.Size(142, 25)
		Me._btnGetProfile.TabIndex = 1
		Me._btnGetProfile.Text = "GetProfile"
		Me._btnGetProfile.UseVisualStyleBackColor = False
		AddHandler Me._btnGetProfile.Click, New System.EventHandler(AddressOf Me.btnGetProfile_Click)
		' 
		' _btnGetBatchProfile
		' 
		Me._btnGetBatchProfile.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetBatchProfile.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetBatchProfile.Location = New System.Drawing.Point(156, 48)
		Me._btnGetBatchProfile.Name = "_btnGetBatchProfile"
		Me._btnGetBatchProfile.Size = New System.Drawing.Size(141, 25)
		Me._btnGetBatchProfile.TabIndex = 2
		Me._btnGetBatchProfile.Text = "GetBatchProfile"
		Me._btnGetBatchProfile.UseVisualStyleBackColor = False
		AddHandler Me._btnGetBatchProfile.Click, New System.EventHandler(AddressOf Me.btnGetBatchProfile_Click)
		' 
		' _btnGetBatchProfileAdvance
		' 
		Me._btnGetBatchProfileAdvance.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetBatchProfileAdvance.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetBatchProfileAdvance.Location = New System.Drawing.Point(452, 48)
		Me._btnGetBatchProfileAdvance.Name = "_btnGetBatchProfileAdvance"
		Me._btnGetBatchProfileAdvance.Size = New System.Drawing.Size(143, 25)
		Me._btnGetBatchProfileAdvance.TabIndex = 4
		Me._btnGetBatchProfileAdvance.Text = "GetBatchProfileAdvance"
		Me._btnGetBatchProfileAdvance.UseVisualStyleBackColor = False
		AddHandler Me._btnGetBatchProfileAdvance.Click, New System.EventHandler(AddressOf Me.btnGetBatchProfileAdvance_Click)
		' 
		' _btnGetProfileAdvance
		' 
		Me._btnGetProfileAdvance.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetProfileAdvance.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetProfileAdvance.Location = New System.Drawing.Point(303, 48)
		Me._btnGetProfileAdvance.Name = "_btnGetProfileAdvance"
		Me._btnGetProfileAdvance.Size = New System.Drawing.Size(143, 25)
		Me._btnGetProfileAdvance.TabIndex = 3
		Me._btnGetProfileAdvance.Text = "GetProfileAdvance"
		Me._btnGetProfileAdvance.UseVisualStyleBackColor = False
		AddHandler Me._btnGetProfileAdvance.Click, New System.EventHandler(AddressOf Me.btnGetProfileAdvance_Click)
		' 
		' groupBox4
		' 
		Me.groupBox4.Controls.Add(Me._btnSetSetting)
		Me.groupBox4.Controls.Add(Me._btnGetSetting)
		Me.groupBox4.Controls.Add(Me._btnInitializeSetting)
		Me.groupBox4.Controls.Add(Me._btnUpdataSetting)
		Me.groupBox4.Controls.Add(Me._btnRewriteTemporarySetting)
		Me.groupBox4.Controls.Add(Me._btnCheckMemoryAccess)
		Me.groupBox4.Controls.Add(Me._btnSetTime)
		Me.groupBox4.Controls.Add(Me._btnGetActiveProgram)
		Me.groupBox4.Controls.Add(Me._btnGetTime)
		Me.groupBox4.Controls.Add(Me._btnChangeActiveProgram)
		Me.groupBox4.Location = New System.Drawing.Point(6, 294)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(606, 118)
		Me.groupBox4.TabIndex = 4
		Me.groupBox4.TabStop = False
		Me.groupBox4.Text = "Functions related to modifying or reading settings"
		' 
		' _btnSetSetting
		' 
		Me._btnSetSetting.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnSetSetting.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnSetSetting.Location = New System.Drawing.Point(7, 19)
		Me._btnSetSetting.Name = "_btnSetSetting"
		Me._btnSetSetting.Size = New System.Drawing.Size(143, 25)
		Me._btnSetSetting.TabIndex = 0
		Me._btnSetSetting.Text = "SetSetting"
		Me._btnSetSetting.UseVisualStyleBackColor = False
		AddHandler Me._btnSetSetting.Click, New System.EventHandler(AddressOf Me.btnSetSetting_Click)
		' 
		' _btnGetSetting
		' 
		Me._btnGetSetting.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetSetting.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetSetting.Location = New System.Drawing.Point(156, 19)
		Me._btnGetSetting.Name = "_btnGetSetting"
		Me._btnGetSetting.Size = New System.Drawing.Size(141, 25)
		Me._btnGetSetting.TabIndex = 1
		Me._btnGetSetting.Text = "GetSetting"
		Me._btnGetSetting.UseVisualStyleBackColor = False
		AddHandler Me._btnGetSetting.Click, New System.EventHandler(AddressOf Me.btnGetSetting_Click)
		' 
		' _btnInitializeSetting
		' 
		Me._btnInitializeSetting.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnInitializeSetting.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnInitializeSetting.Location = New System.Drawing.Point(303, 19)
		Me._btnInitializeSetting.Name = "_btnInitializeSetting"
		Me._btnInitializeSetting.Size = New System.Drawing.Size(145, 25)
		Me._btnInitializeSetting.TabIndex = 2
		Me._btnInitializeSetting.Text = "InitializeSetting"
		Me._btnInitializeSetting.UseVisualStyleBackColor = False
		AddHandler Me._btnInitializeSetting.Click, New System.EventHandler(AddressOf Me.btnInitializeSetting_Click)
		' 
		' _btnUpdataSetting
		' 
		Me._btnUpdataSetting.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnUpdataSetting.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnUpdataSetting.Location = New System.Drawing.Point(454, 19)
		Me._btnUpdataSetting.Name = "_btnUpdataSetting"
		Me._btnUpdataSetting.Size = New System.Drawing.Size(143, 25)
		Me._btnUpdataSetting.TabIndex = 3
		Me._btnUpdataSetting.Text = "ReflectSetting"
		Me._btnUpdataSetting.UseVisualStyleBackColor = False
		AddHandler Me._btnUpdataSetting.Click, New System.EventHandler(AddressOf Me.btnUpdataSetting_Click)
		' 
		' _btnRewriteTemporarySetting
		' 
		Me._btnRewriteTemporarySetting.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnRewriteTemporarySetting.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnRewriteTemporarySetting.Location = New System.Drawing.Point(7, 52)
		Me._btnRewriteTemporarySetting.Name = "_btnRewriteTemporarySetting"
		Me._btnRewriteTemporarySetting.Size = New System.Drawing.Size(143, 25)
		Me._btnRewriteTemporarySetting.TabIndex = 4
		Me._btnRewriteTemporarySetting.Text = "RewriteTemporarySetting"
		Me._btnRewriteTemporarySetting.UseVisualStyleBackColor = False
		AddHandler Me._btnRewriteTemporarySetting.Click, New System.EventHandler(AddressOf Me.btnRewriteTemporarySetting_Click)
		' 
		' _btnCheckMemoryAccess
		' 
		Me._btnCheckMemoryAccess.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnCheckMemoryAccess.Location = New System.Drawing.Point(156, 51)
		Me._btnCheckMemoryAccess.Name = "_btnCheckMemoryAccess"
		Me._btnCheckMemoryAccess.Size = New System.Drawing.Size(141, 25)
		Me._btnCheckMemoryAccess.TabIndex = 5
		Me._btnCheckMemoryAccess.Text = "CheckMemoryAccess"
		Me._btnCheckMemoryAccess.UseVisualStyleBackColor = False
		AddHandler Me._btnCheckMemoryAccess.Click, New System.EventHandler(AddressOf Me.btnCheckMemoryAccess_Click)
		' 
		' _btnSetTime
		' 
		Me._btnSetTime.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnSetTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnSetTime.Location = New System.Drawing.Point(303, 52)
		Me._btnSetTime.Name = "_btnSetTime"
		Me._btnSetTime.Size = New System.Drawing.Size(145, 25)
		Me._btnSetTime.TabIndex = 6
		Me._btnSetTime.Text = "SetTime"
		Me._btnSetTime.UseVisualStyleBackColor = False
		AddHandler Me._btnSetTime.Click, New System.EventHandler(AddressOf Me.btnSetTime_Click)
		' 
		' _btnGetActiveProgram
		' 
		Me._btnGetActiveProgram.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnGetActiveProgram.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetActiveProgram.Location = New System.Drawing.Point(157, 83)
		Me._btnGetActiveProgram.Name = "_btnGetActiveProgram"
		Me._btnGetActiveProgram.Size = New System.Drawing.Size(140, 25)
		Me._btnGetActiveProgram.TabIndex = 9
		Me._btnGetActiveProgram.Text = "GetActiveProgram"
		Me._btnGetActiveProgram.UseVisualStyleBackColor = False
		AddHandler Me._btnGetActiveProgram.Click, New System.EventHandler(AddressOf Me.btnGetActiveProgram_Click)
		' 
		' _btnChangeActiveProgram
		' 
		Me._btnChangeActiveProgram.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me._btnChangeActiveProgram.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnChangeActiveProgram.Location = New System.Drawing.Point(10, 84)
		Me._btnChangeActiveProgram.Name = "_btnChangeActiveProgram"
		Me._btnChangeActiveProgram.Size = New System.Drawing.Size(141, 25)
		Me._btnChangeActiveProgram.TabIndex = 8
		Me._btnChangeActiveProgram.Text = "ChangeActiveProgram"
		Me._btnChangeActiveProgram.UseVisualStyleBackColor = False
		AddHandler Me._btnChangeActiveProgram.Click, New System.EventHandler(AddressOf Me.btnChangeActiveProgram_Click)
		' 
		' groupBox3
		' 
		Me.groupBox3.Controls.Add(Me._btnTrigger)
		Me.groupBox3.Controls.Add(Me._btnStartMeasure)
		Me.groupBox3.Controls.Add(Me._btnStopMeasure)
		Me.groupBox3.Controls.Add(Me._btnAutoZero)
		Me.groupBox3.Controls.Add(Me._btnClearMemory)
		Me.groupBox3.Controls.Add(Me._btnReset)
		Me.groupBox3.Controls.Add(Me._btnTiming)
		Me.groupBox3.Location = New System.Drawing.Point(4, 201)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(608, 86)
		Me.groupBox3.TabIndex = 3
		Me.groupBox3.TabStop = False
		Me.groupBox3.Text = "Measurement control"
		' 
		' _btnTrigger
		' 
		Me._btnTrigger.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnTrigger.Location = New System.Drawing.Point(9, 20)
		Me._btnTrigger.Name = "_btnTrigger"
		Me._btnTrigger.Size = New System.Drawing.Size(143, 25)
		Me._btnTrigger.TabIndex = 0
		Me._btnTrigger.Text = "Trigger"
		Me._btnTrigger.UseVisualStyleBackColor = False
		AddHandler Me._btnTrigger.Click, New System.EventHandler(AddressOf Me.btnTrigger_Click)
		' 
		' _btnStartMeasure
		' 
		Me._btnStartMeasure.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnStartMeasure.Location = New System.Drawing.Point(158, 19)
		Me._btnStartMeasure.Name = "_btnStartMeasure"
		Me._btnStartMeasure.Size = New System.Drawing.Size(141, 25)
		Me._btnStartMeasure.TabIndex = 1
		Me._btnStartMeasure.Text = "StartMeasure"
		Me._btnStartMeasure.UseVisualStyleBackColor = False
		AddHandler Me._btnStartMeasure.Click, New System.EventHandler(AddressOf Me.btnStartMeasure_Click)
		' 
		' _btnStopMeasure
		' 
		Me._btnStopMeasure.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnStopMeasure.Location = New System.Drawing.Point(305, 19)
		Me._btnStopMeasure.Name = "_btnStopMeasure"
		Me._btnStopMeasure.Size = New System.Drawing.Size(145, 25)
		Me._btnStopMeasure.TabIndex = 2
		Me._btnStopMeasure.Text = "StopMeasure"
		Me._btnStopMeasure.UseVisualStyleBackColor = False
		AddHandler Me._btnStopMeasure.Click, New System.EventHandler(AddressOf Me.btnStopMeasure_Click)
		' 
		' _btnAutoZero
		' 
		Me._btnAutoZero.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnAutoZero.Location = New System.Drawing.Point(454, 20)
		Me._btnAutoZero.Name = "_btnAutoZero"
		Me._btnAutoZero.Size = New System.Drawing.Size(143, 25)
		Me._btnAutoZero.TabIndex = 3
		Me._btnAutoZero.Text = "AutoZero"
		Me._btnAutoZero.UseVisualStyleBackColor = False
		AddHandler Me._btnAutoZero.Click, New System.EventHandler(AddressOf Me.btnAutoZero_Click)
		' 
		' _btnClearMemory
		' 
		Me._btnClearMemory.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnClearMemory.Location = New System.Drawing.Point(305, 55)
		Me._btnClearMemory.Name = "_btnClearMemory"
		Me._btnClearMemory.Size = New System.Drawing.Size(145, 25)
		Me._btnClearMemory.TabIndex = 6
		Me._btnClearMemory.Text = "ClearMemory"
		Me._btnClearMemory.UseVisualStyleBackColor = False
		AddHandler Me._btnClearMemory.Click, New System.EventHandler(AddressOf Me.btnClearMemory_Click)
		' 
		' _btnReset
		' 
		Me._btnReset.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnReset.Location = New System.Drawing.Point(158, 55)
		Me._btnReset.Name = "_btnReset"
		Me._btnReset.Size = New System.Drawing.Size(141, 25)
		Me._btnReset.TabIndex = 5
		Me._btnReset.Text = "Reset"
		Me._btnReset.UseVisualStyleBackColor = False
		AddHandler Me._btnReset.Click, New System.EventHandler(AddressOf Me.btnReset_Click)
		' 
		' _btnTiming
		' 
		Me._btnTiming.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(224)), CInt(CByte(192)))
		Me._btnTiming.Location = New System.Drawing.Point(9, 55)
		Me._btnTiming.Name = "_btnTiming"
		Me._btnTiming.Size = New System.Drawing.Size(143, 25)
		Me._btnTiming.TabIndex = 4
		Me._btnTiming.Text = "Timing"
		Me._btnTiming.UseVisualStyleBackColor = False
		AddHandler Me._btnTiming.Click, New System.EventHandler(AddressOf Me.btnTiming_Click)
		' 
		' groupBox2
		' 
		Me.groupBox2.Controls.Add(Me._btnRebootController)
		Me.groupBox2.Controls.Add(Me._btnRetrunToFactorySetting)
		Me.groupBox2.Controls.Add(Me._btnGetError)
		Me.groupBox2.Controls.Add(Me._btnClearError)
		Me.groupBox2.Location = New System.Drawing.Point(6, 141)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(606, 54)
		Me.groupBox2.TabIndex = 2
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = "System control"
		' 
		' _btnRebootController
		' 
		Me._btnRebootController.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(192)), CInt(CByte(192)))
		Me._btnRebootController.Location = New System.Drawing.Point(6, 19)
		Me._btnRebootController.Name = "_btnRebootController"
		Me._btnRebootController.Size = New System.Drawing.Size(144, 25)
		Me._btnRebootController.TabIndex = 0
		Me._btnRebootController.Text = "RebootController"
		Me._btnRebootController.UseVisualStyleBackColor = False
		AddHandler Me._btnRebootController.Click, New System.EventHandler(AddressOf Me.btnRebootController_Click)
		' 
		' _btnRetrunToFactorySetting
		' 
		Me._btnRetrunToFactorySetting.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(192)), CInt(CByte(192)))
		Me._btnRetrunToFactorySetting.Location = New System.Drawing.Point(156, 19)
		Me._btnRetrunToFactorySetting.Name = "_btnRetrunToFactorySetting"
		Me._btnRetrunToFactorySetting.Size = New System.Drawing.Size(136, 25)
		Me._btnRetrunToFactorySetting.TabIndex = 1
		Me._btnRetrunToFactorySetting.Text = "RetrunToFactorySetting"
		Me._btnRetrunToFactorySetting.UseVisualStyleBackColor = False
		AddHandler Me._btnRetrunToFactorySetting.Click, New System.EventHandler(AddressOf Me.btnRetrunToFactorySetting_Click)
		' 
		' _btnGetError
		' 
		Me._btnGetError.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(192)), CInt(CByte(192)))
		Me._btnGetError.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnGetError.Location = New System.Drawing.Point(303, 19)
		Me._btnGetError.Name = "_btnGetError"
		Me._btnGetError.Size = New System.Drawing.Size(143, 25)
		Me._btnGetError.TabIndex = 2
		Me._btnGetError.Text = "GetError"
		Me._btnGetError.UseVisualStyleBackColor = False
		AddHandler Me._btnGetError.Click, New System.EventHandler(AddressOf Me.btnGetError_Click)
		' 
		' _btnClearError
		' 
		Me._btnClearError.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(192)), CInt(CByte(192)))
		Me._btnClearError.Location = New System.Drawing.Point(452, 19)
		Me._btnClearError.Name = "_btnClearError"
		Me._btnClearError.Size = New System.Drawing.Size(143, 25)
		Me._btnClearError.TabIndex = 3
		Me._btnClearError.Text = "ClearError"
		Me._btnClearError.UseVisualStyleBackColor = False
		AddHandler Me._btnClearError.Click, New System.EventHandler(AddressOf Me.btnClearError_Click)
		' 
		' groupBox1
		' 
		Me.groupBox1.Controls.Add(Me._btnCommClose)
		Me.groupBox1.Controls.Add(Me._btnEthernetOpen)
		Me.groupBox1.Controls.Add(Me._btnUsbOpen)
		Me.groupBox1.Location = New System.Drawing.Point(5, 76)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(607, 54)
		Me.groupBox1.TabIndex = 1
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Establish/disconnect the communication path with the controller"
		' 
		' _groupBox1
		' 
		Me._groupBox1.Controls.Add(Me._btnInitialize)
		Me._groupBox1.Controls.Add(Me._btnGetVersion)
		Me._groupBox1.Controls.Add(Me._btnFinalize)
		Me._groupBox1.Location = New System.Drawing.Point(6, 19)
		Me._groupBox1.Name = "_groupBox1"
		Me._groupBox1.Size = New System.Drawing.Size(606, 54)
		Me._groupBox1.TabIndex = 0
		Me._groupBox1.TabStop = False
		Me._groupBox1.Text = "Operations for the DLL"
		' 
		' _grpLog
		' 
		Me._grpLog.Controls.Add(Me._txtboxLog)
		Me._grpLog.Controls.Add(Me._btnLogClear)
		Me._grpLog.Location = New System.Drawing.Point(12, 188)
		Me._grpLog.Name = "_grpLog"
		Me._grpLog.Size = New System.Drawing.Size(339, 136)
		Me._grpLog.TabIndex = 0
		Me._grpLog.TabStop = False
		Me._grpLog.Text = "Operation result log"
		' 
		' _txtboxLog
		' 
		Me._txtboxLog.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._txtboxLog.Location = New System.Drawing.Point(6, 46)
		Me._txtboxLog.Multiline = True
		Me._txtboxLog.Name = "_txtboxLog"
		Me._txtboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me._txtboxLog.Size = New System.Drawing.Size(315, 75)
		Me._txtboxLog.TabIndex = 1
		' 
		' _btnLogClear
		' 
		Me._btnLogClear.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me._btnLogClear.Location = New System.Drawing.Point(7, 15)
		Me._btnLogClear.Name = "_btnLogClear"
		Me._btnLogClear.Size = New System.Drawing.Size(96, 25)
		Me._btnLogClear.TabIndex = 0
		Me._btnLogClear.Text = "Clear the log"
		Me._btnLogClear.UseVisualStyleBackColor = True
		AddHandler Me._btnLogClear.Click, New System.EventHandler(AddressOf Me.btnLogClear_Click)
		' 
		' _grpBufferSize
		' 
		Me._grpBufferSize.Controls.Add(Me._lblSettingAttention)
		Me._grpBufferSize.Controls.Add(Me._grpReceived)
		Me._grpBufferSize.Controls.Add(Me._grpMeasureRange)
		Me._grpBufferSize.Controls.Add(Me._grpHead)
		Me._grpBufferSize.Location = New System.Drawing.Point(12, 331)
		Me._grpBufferSize.Name = "_grpBufferSize"
		Me._grpBufferSize.Size = New System.Drawing.Size(339, 215)
		Me._grpBufferSize.TabIndex = 3
		Me._grpBufferSize.TabStop = False
		Me._grpBufferSize.Text = "Buffer size setting (set and used when reading profiles)"
		' 
		' _lblSettingAttention
		' 
		Me._lblSettingAttention.AutoSize = True
		Me._lblSettingAttention.Location = New System.Drawing.Point(6, 16)
		Me._lblSettingAttention.Name = "_lblSettingAttention"
		Me._lblSettingAttention.Size = New System.Drawing.Size(274, 13)
		Me._lblSettingAttention.TabIndex = 4
		Me._lblSettingAttention.Text = "*Match the setting of the controller with this application"
		' 
		' _grpReceived
		' 
		Me._grpReceived.Controls.Add(Me._chkboxEnvelope)
		Me._grpReceived.Controls.Add(Me._cmbCompressX)
		Me._grpReceived.Controls.Add(Me._lblCompressX)
		Me._grpReceived.Location = New System.Drawing.Point(6, 154)
		Me._grpReceived.Name = "_grpReceived"
		Me._grpReceived.Size = New System.Drawing.Size(317, 54)
		Me._grpReceived.TabIndex = 3
		Me._grpReceived.TabStop = False
		Me._grpReceived.Text = "Profile settings"
		' 
		' _chkboxEnvelope
		' 
		Me._chkboxEnvelope.AutoSize = True
		Me._chkboxEnvelope.Checked = True
		Me._chkboxEnvelope.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkboxEnvelope.Location = New System.Drawing.Point(196, 22)
		Me._chkboxEnvelope.Name = "_chkboxEnvelope"
		Me._chkboxEnvelope.Size = New System.Drawing.Size(106, 17)
		Me._chkboxEnvelope.TabIndex = 2
		Me._chkboxEnvelope.Text = "Envelope setting"
		Me._chkboxEnvelope.UseVisualStyleBackColor = True
		' 
		' _cmbCompressX
		' 
		Me._cmbCompressX.DisplayMember = "Key"
		Me._cmbCompressX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbCompressX.FormattingEnabled = True
		Me._cmbCompressX.Location = New System.Drawing.Point(127, 20)
		Me._cmbCompressX.Name = "_cmbCompressX"
		Me._cmbCompressX.Size = New System.Drawing.Size(59, 21)
		Me._cmbCompressX.TabIndex = 1
		Me._cmbCompressX.ValueMember = "Value"
		' 
		' _lblCompressX
		' 
		Me._lblCompressX.AutoSize = True
		Me._lblCompressX.Location = New System.Drawing.Point(6, 24)
		Me._lblCompressX.Name = "_lblCompressX"
		Me._lblCompressX.Size = New System.Drawing.Size(107, 13)
		Me._lblCompressX.TabIndex = 0
		Me._lblCompressX.Text = "Compression (X axis)"
		' 
		' _grpMeasureRange
		' 
		Me._grpMeasureRange.Controls.Add(Me._cmbReceivedBinning)
		Me._grpMeasureRange.Controls.Add(Me._cmbMeasureX)
		Me._grpMeasureRange.Controls.Add(Me._lblReceivedBinning)
		Me._grpMeasureRange.Controls.Add(Me._lblMeasureX)
		Me._grpMeasureRange.Location = New System.Drawing.Point(6, 76)
		Me._grpMeasureRange.Name = "_grpMeasureRange"
		Me._grpMeasureRange.Size = New System.Drawing.Size(317, 73)
		Me._grpMeasureRange.TabIndex = 2
		Me._grpMeasureRange.TabStop = False
		Me._grpMeasureRange.Text = "Imaging settings"
		' 
		' _cmbReceivedBinning
		' 
		Me._cmbReceivedBinning.DisplayMember = "Key"
		Me._cmbReceivedBinning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbReceivedBinning.FormattingEnabled = True
		Me._cmbReceivedBinning.Location = New System.Drawing.Point(182, 46)
		Me._cmbReceivedBinning.Name = "_cmbReceivedBinning"
		Me._cmbReceivedBinning.Size = New System.Drawing.Size(91, 21)
		Me._cmbReceivedBinning.TabIndex = 3
		Me._cmbReceivedBinning.ValueMember = "Value"
		' 
		' _cmbMeasureX
		' 
		Me._cmbMeasureX.DisplayMember = "Key"
		Me._cmbMeasureX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbMeasureX.FormattingEnabled = True
		Me._cmbMeasureX.Location = New System.Drawing.Point(182, 18)
		Me._cmbMeasureX.Name = "_cmbMeasureX"
		Me._cmbMeasureX.Size = New System.Drawing.Size(91, 21)
		Me._cmbMeasureX.TabIndex = 1
		Me._cmbMeasureX.ValueMember = "Value"
		' 
		' _lblReceivedBinning
		' 
		Me._lblReceivedBinning.AutoSize = True
		Me._lblReceivedBinning.Location = New System.Drawing.Point(13, 50)
		Me._lblReceivedBinning.Name = "_lblReceivedBinning"
		Me._lblReceivedBinning.Size = New System.Drawing.Size(41, 13)
		Me._lblReceivedBinning.TabIndex = 2
		Me._lblReceivedBinning.Text = "Binning"
		' 
		' _lblMeasureX
		' 
		Me._lblMeasureX.AutoSize = True
		Me._lblMeasureX.Location = New System.Drawing.Point(12, 21)
		Me._lblMeasureX.Name = "_lblMeasureX"
		Me._lblMeasureX.Size = New System.Drawing.Size(156, 13)
		Me._lblMeasureX.TabIndex = 0
		Me._lblMeasureX.Text = "Measurement range X direction"
		' 
		' _grpHead
		' 
		Me._grpHead.Controls.Add(Me._rdbtnOneHead)
		Me._grpHead.Controls.Add(Me._rdbtnTwoHead)
		Me._grpHead.Controls.Add(Me._rdbtnWide)
		Me._grpHead.Location = New System.Drawing.Point(6, 32)
		Me._grpHead.Name = "_grpHead"
		Me._grpHead.Size = New System.Drawing.Size(317, 41)
		Me._grpHead.TabIndex = 1
		Me._grpHead.TabStop = False
		Me._grpHead.Text = "Head"
		' 
		' _rdbtnOneHead
		' 
		Me._rdbtnOneHead.AutoSize = True
		Me._rdbtnOneHead.Location = New System.Drawing.Point(21, 18)
		Me._rdbtnOneHead.Name = "_rdbtnOneHead"
		Me._rdbtnOneHead.Size = New System.Drawing.Size(73, 17)
		Me._rdbtnOneHead.TabIndex = 0
		Me._rdbtnOneHead.Text = "One Head"
		Me._rdbtnOneHead.UseVisualStyleBackColor = True
		' 
		' _rdbtnTwoHead
		' 
		Me._rdbtnTwoHead.AutoSize = True
		Me._rdbtnTwoHead.Checked = True
		Me._rdbtnTwoHead.Location = New System.Drawing.Point(104, 18)
		Me._rdbtnTwoHead.Name = "_rdbtnTwoHead"
		Me._rdbtnTwoHead.Size = New System.Drawing.Size(73, 17)
		Me._rdbtnTwoHead.TabIndex = 1
		Me._rdbtnTwoHead.TabStop = True
		Me._rdbtnTwoHead.Text = "Two Head"
		Me._rdbtnTwoHead.UseVisualStyleBackColor = True
		' 
		' _rdbtnWide
		' 
		Me._rdbtnWide.AutoSize = True
		Me._rdbtnWide.Location = New System.Drawing.Point(187, 18)
		Me._rdbtnWide.Name = "_rdbtnWide"
		Me._rdbtnWide.Size = New System.Drawing.Size(110, 17)
		Me._rdbtnWide.TabIndex = 2
		Me._rdbtnWide.Text = "Two heads (wide)"
		Me._rdbtnWide.UseVisualStyleBackColor = True
		' 
		' _grpExport
		' 
		Me._grpExport.Controls.Add(Me._nudProfileNo)
		Me._grpExport.Controls.Add(Me._txtboxProfileFilePath)
		Me._grpExport.Controls.Add(Me._btnSaveMeasureData)
		Me._grpExport.Controls.Add(Me._btnSave)
		Me._grpExport.Controls.Add(Me._btnProfileFileSave)
		Me._grpExport.Controls.Add(Me.label2)
		Me._grpExport.Controls.Add(Me._lblSavePath)
		Me._grpExport.Location = New System.Drawing.Point(12, 619)
		Me._grpExport.Name = "_grpExport"
		Me._grpExport.Size = New System.Drawing.Size(339, 100)
		Me._grpExport.TabIndex = 4
		Me._grpExport.TabStop = False
		Me._grpExport.Text = "Save the results file"
		' 
		' _nudProfileNo
		' 
		Me._nudProfileNo.Location = New System.Drawing.Point(170, 45)
		Me._nudProfileNo.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me._nudProfileNo.Name = "_nudProfileNo"
		Me._nudProfileNo.Size = New System.Drawing.Size(43, 21)
		Me._nudProfileNo.TabIndex = 4
		' 
		' _txtboxProfileFilePath
		' 
		Me._txtboxProfileFilePath.Location = New System.Drawing.Point(105, 20)
		Me._txtboxProfileFilePath.Name = "_txtboxProfileFilePath"
		Me._txtboxProfileFilePath.Size = New System.Drawing.Size(189, 21)
		Me._txtboxProfileFilePath.TabIndex = 1
		' 
		' _btnSaveMeasureData
		' 
		Me._btnSaveMeasureData.Location = New System.Drawing.Point(193, 70)
		Me._btnSaveMeasureData.Name = "_btnSaveMeasureData"
		Me._btnSaveMeasureData.Size = New System.Drawing.Size(130, 25)
		Me._btnSaveMeasureData.TabIndex = 6
		Me._btnSaveMeasureData.Text = "Save the measurement value"
		Me._btnSaveMeasureData.UseVisualStyleBackColor = True
		AddHandler Me._btnSaveMeasureData.Click, New System.EventHandler(AddressOf Me.btnSaveMeasureData_Click)
		' 
		' _btnSave
		' 
		Me._btnSave.Location = New System.Drawing.Point(44, 70)
		Me._btnSave.Name = "_btnSave"
		Me._btnSave.Size = New System.Drawing.Size(132, 25)
		Me._btnSave.TabIndex = 5
		Me._btnSave.Text = "Save the profile"
		Me._btnSave.UseVisualStyleBackColor = True
		AddHandler Me._btnSave.Click, New System.EventHandler(AddressOf Me.btnSave_Click)
		' 
		' _btnProfileFileSave
		' 
		Me._btnProfileFileSave.Location = New System.Drawing.Point(300, 19)
		Me._btnProfileFileSave.Name = "_btnProfileFileSave"
		Me._btnProfileFileSave.Size = New System.Drawing.Size(25, 20)
		Me._btnProfileFileSave.TabIndex = 2
		Me._btnProfileFileSave.Text = "..."
		Me._btnProfileFileSave.UseVisualStyleBackColor = True
		AddHandler Me._btnProfileFileSave.Click, New System.EventHandler(AddressOf Me.btnProfileFileSave_Click)
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(8, 47)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(139, 13)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Index of the profile to save"
		' 
		' _lblSavePath
		' 
		Me._lblSavePath.AutoSize = True
		Me._lblSavePath.Location = New System.Drawing.Point(9, 24)
		Me._lblSavePath.Name = "_lblSavePath"
		Me._lblSavePath.Size = New System.Drawing.Size(87, 13)
		Me._lblSavePath.TabIndex = 0
		Me._lblSavePath.Text = "Save destination"
		' 
		' _profileFileSave
		' 
		Me._profileFileSave.Filter = "Profile (*.txt)|*.txt | all files (*.*)|*.*"
		' 
		' _timerHighSpeedReceive
		' 
		Me._timerHighSpeedReceive.Interval = 500
		AddHandler Me._timerHighSpeedReceive.Tick, New System.EventHandler(AddressOf Me._timerHighSpeedReceive_Tick)
		' 
		' _lblReceiveProfileCount0
		' 
		Me._lblReceiveProfileCount0.AutoSize = True
		Me._lblReceiveProfileCount0.BackColor = System.Drawing.Color.Transparent
		Me._lblReceiveProfileCount0.Location = New System.Drawing.Point(3, 34)
		Me._lblReceiveProfileCount0.Name = "_lblReceiveProfileCount0"
		Me._lblReceiveProfileCount0.Size = New System.Drawing.Size(13, 13)
		Me._lblReceiveProfileCount0.TabIndex = 1
		Me._lblReceiveProfileCount0.Text = "0"
		' 
		' _rdDevice0
		' 
		Me._rdDevice0.AutoSize = True
		Me._rdDevice0.Checked = True
		Me._rdDevice0.Location = New System.Drawing.Point(8, 35)
		Me._rdDevice0.Name = "_rdDevice0"
		Me._rdDevice0.Size = New System.Drawing.Size(31, 17)
		Me._rdDevice0.TabIndex = 2
		Me._rdDevice0.TabStop = True
		Me._rdDevice0.Tag = "0"
		Me._rdDevice0.Text = "&0"
		Me._rdDevice0.UseVisualStyleBackColor = True
		AddHandler Me._rdDevice0.CheckedChanged, New System.EventHandler(AddressOf Me._rdDevice_CheckedChanged)
		' 
		' _rdDevice2
		' 
		Me._rdDevice2.AutoSize = True
		Me._rdDevice2.Location = New System.Drawing.Point(8, 71)
		Me._rdDevice2.Name = "_rdDevice2"
		Me._rdDevice2.Size = New System.Drawing.Size(31, 17)
		Me._rdDevice2.TabIndex = 6
		Me._rdDevice2.Tag = "2"
		Me._rdDevice2.Text = "&2"
		Me._rdDevice2.UseVisualStyleBackColor = True
		AddHandler Me._rdDevice2.CheckedChanged, New System.EventHandler(AddressOf Me._rdDevice_CheckedChanged)
		' 
		' _rdDevice1
		' 
		Me._rdDevice1.AutoSize = True
		Me._rdDevice1.Location = New System.Drawing.Point(8, 53)
		Me._rdDevice1.Name = "_rdDevice1"
		Me._rdDevice1.Size = New System.Drawing.Size(31, 17)
		Me._rdDevice1.TabIndex = 4
		Me._rdDevice1.Tag = "1"
		Me._rdDevice1.Text = "&1"
		Me._rdDevice1.UseVisualStyleBackColor = True
		AddHandler Me._rdDevice1.CheckedChanged, New System.EventHandler(AddressOf Me._rdDevice_CheckedChanged)
		' 
		' _pnlDeviceId
		' 
		Me._pnlDeviceId.BackColor = System.Drawing.Color.DarkGray
		Me._pnlDeviceId.Controls.Add(Me._lblDeviceStatus5)
		Me._pnlDeviceId.Controls.Add(Me._lblDeviceStatus4)
		Me._pnlDeviceId.Controls.Add(Me.radioButton2)
		Me._pnlDeviceId.Controls.Add(Me.radioButton1)
		Me._pnlDeviceId.Controls.Add(Me.panel1)
		Me._pnlDeviceId.Controls.Add(Me.label5)
		Me._pnlDeviceId.Controls.Add(Me.label4)
		Me._pnlDeviceId.Controls.Add(Me._lblDeviceStatus3)
		Me._pnlDeviceId.Controls.Add(Me._lblDeviceStatus2)
		Me._pnlDeviceId.Controls.Add(Me._lblDeviceStatus1)
		Me._pnlDeviceId.Controls.Add(Me._lblDeviceStatus0)
		Me._pnlDeviceId.Controls.Add(Me._rdDevice3)
		Me._pnlDeviceId.Controls.Add(Me._rdDevice2)
		Me._pnlDeviceId.Controls.Add(Me._rdDevice1)
		Me._pnlDeviceId.Controls.Add(Me._rdDevice0)
		Me._pnlDeviceId.Location = New System.Drawing.Point(12, 32)
		Me._pnlDeviceId.Name = "_pnlDeviceId"
		Me._pnlDeviceId.Size = New System.Drawing.Size(334, 152)
		Me._pnlDeviceId.TabIndex = 1
		Me._pnlDeviceId.Tag = ""
		' 
		' _lblDeviceStatus5
		' 
		Me._lblDeviceStatus5.AutoSize = True
		Me._lblDeviceStatus5.Location = New System.Drawing.Point(55, 128)
		Me._lblDeviceStatus5.Name = "_lblDeviceStatus5"
		Me._lblDeviceStatus5.Size = New System.Drawing.Size(70, 13)
		Me._lblDeviceStatus5.TabIndex = 65
		Me._lblDeviceStatus5.Text = "Unconnected"
		' 
		' _lblDeviceStatus4
		' 
		Me._lblDeviceStatus4.AutoSize = True
		Me._lblDeviceStatus4.Location = New System.Drawing.Point(55, 110)
		Me._lblDeviceStatus4.Name = "_lblDeviceStatus4"
		Me._lblDeviceStatus4.Size = New System.Drawing.Size(70, 13)
		Me._lblDeviceStatus4.TabIndex = 64
		Me._lblDeviceStatus4.Text = "Unconnected"
		' 
		' radioButton2
		' 
		Me.radioButton2.AutoSize = True
		Me.radioButton2.Location = New System.Drawing.Point(8, 123)
		Me.radioButton2.Name = "radioButton2"
		Me.radioButton2.Size = New System.Drawing.Size(31, 17)
		Me.radioButton2.TabIndex = 63
		Me.radioButton2.Tag = "5"
		Me.radioButton2.Text = "&5"
		Me.radioButton2.UseVisualStyleBackColor = True
		' 
		' radioButton1
		' 
		Me.radioButton1.AutoSize = True
		Me.radioButton1.Location = New System.Drawing.Point(8, 105)
		Me.radioButton1.Name = "radioButton1"
		Me.radioButton1.Size = New System.Drawing.Size(31, 17)
		Me.radioButton1.TabIndex = 62
		Me.radioButton1.Tag = "4"
		Me.radioButton1.Text = "&4"
		Me.radioButton1.UseVisualStyleBackColor = True
		' 
		' panel1
		' 
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(255)), CInt(CByte(255)))
		Me.panel1.Controls.Add(Me._lblReceiveProfileCount5)
		Me.panel1.Controls.Add(Me._lblReceiveProfileCount4)
		Me.panel1.Controls.Add(Me._lblReceiveProfileCount3)
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me._lblReceiveProfileCount0)
		Me.panel1.Controls.Add(Me._lblReceiveProfileCount1)
		Me.panel1.Controls.Add(Me._lblReceiveProfileCount2)
		Me.panel1.Location = New System.Drawing.Point(205, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(121, 146)
		Me.panel1.TabIndex = 59
		' 
		' _lblReceiveProfileCount5
		' 
		Me._lblReceiveProfileCount5.AutoSize = True
		Me._lblReceiveProfileCount5.BackColor = System.Drawing.Color.Transparent
		Me._lblReceiveProfileCount5.Location = New System.Drawing.Point(3, 124)
		Me._lblReceiveProfileCount5.Name = "_lblReceiveProfileCount5"
		Me._lblReceiveProfileCount5.Size = New System.Drawing.Size(13, 13)
		Me._lblReceiveProfileCount5.TabIndex = 6
		Me._lblReceiveProfileCount5.Text = "0"
		' 
		' _lblReceiveProfileCount4
		' 
		Me._lblReceiveProfileCount4.AutoSize = True
		Me._lblReceiveProfileCount4.BackColor = System.Drawing.Color.Transparent
		Me._lblReceiveProfileCount4.Location = New System.Drawing.Point(3, 105)
		Me._lblReceiveProfileCount4.Name = "_lblReceiveProfileCount4"
		Me._lblReceiveProfileCount4.Size = New System.Drawing.Size(13, 13)
		Me._lblReceiveProfileCount4.TabIndex = 5
		Me._lblReceiveProfileCount4.Text = "0"
		' 
		' _lblReceiveProfileCount3
		' 
		Me._lblReceiveProfileCount3.AutoSize = True
		Me._lblReceiveProfileCount3.BackColor = System.Drawing.Color.Transparent
		Me._lblReceiveProfileCount3.Location = New System.Drawing.Point(3, 86)
		Me._lblReceiveProfileCount3.Name = "_lblReceiveProfileCount3"
		Me._lblReceiveProfileCount3.Size = New System.Drawing.Size(13, 13)
		Me._lblReceiveProfileCount3.TabIndex = 4
		Me._lblReceiveProfileCount3.Text = "0"
		' 
		' label3
		' 
		Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label3.Location = New System.Drawing.Point(3, 3)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(174, 32)
		Me.label3.TabIndex = 0
		Me.label3.Text = "Number of " & vbCr & vbLf & "received profiles"
		' 
		' _lblReceiveProfileCount1
		' 
		Me._lblReceiveProfileCount1.AutoSize = True
		Me._lblReceiveProfileCount1.BackColor = System.Drawing.Color.Transparent
		Me._lblReceiveProfileCount1.Location = New System.Drawing.Point(3, 52)
		Me._lblReceiveProfileCount1.Name = "_lblReceiveProfileCount1"
		Me._lblReceiveProfileCount1.Size = New System.Drawing.Size(13, 13)
		Me._lblReceiveProfileCount1.TabIndex = 2
		Me._lblReceiveProfileCount1.Text = "0"
		' 
		' _lblReceiveProfileCount2
		' 
		Me._lblReceiveProfileCount2.AutoSize = True
		Me._lblReceiveProfileCount2.BackColor = System.Drawing.Color.Transparent
		Me._lblReceiveProfileCount2.Location = New System.Drawing.Point(3, 70)
		Me._lblReceiveProfileCount2.Name = "_lblReceiveProfileCount2"
		Me._lblReceiveProfileCount2.Size = New System.Drawing.Size(13, 13)
		Me._lblReceiveProfileCount2.TabIndex = 3
		Me._lblReceiveProfileCount2.Text = "0"
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label5.Location = New System.Drawing.Point(42, 13)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(145, 13)
		Me.label5.TabIndex = 1
		Me.label5.Text = "State (USB / IP address)"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label4.Location = New System.Drawing.Point(19, 13)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(20, 13)
		Me.label4.TabIndex = 0
		Me.label4.Text = "ID"
		' 
		' _lblDeviceStatus3
		' 
		Me._lblDeviceStatus3.AutoSize = True
		Me._lblDeviceStatus3.Location = New System.Drawing.Point(55, 91)
		Me._lblDeviceStatus3.Name = "_lblDeviceStatus3"
		Me._lblDeviceStatus3.Size = New System.Drawing.Size(70, 13)
		Me._lblDeviceStatus3.TabIndex = 61
		Me._lblDeviceStatus3.Text = "Unconnected"
		' 
		' _lblDeviceStatus2
		' 
		Me._lblDeviceStatus2.AutoSize = True
		Me._lblDeviceStatus2.Location = New System.Drawing.Point(55, 72)
		Me._lblDeviceStatus2.Name = "_lblDeviceStatus2"
		Me._lblDeviceStatus2.Size = New System.Drawing.Size(70, 13)
		Me._lblDeviceStatus2.TabIndex = 7
		Me._lblDeviceStatus2.Text = "Unconnected"
		' 
		' _lblDeviceStatus1
		' 
		Me._lblDeviceStatus1.AutoSize = True
		Me._lblDeviceStatus1.Location = New System.Drawing.Point(55, 55)
		Me._lblDeviceStatus1.Name = "_lblDeviceStatus1"
		Me._lblDeviceStatus1.Size = New System.Drawing.Size(70, 13)
		Me._lblDeviceStatus1.TabIndex = 5
		Me._lblDeviceStatus1.Text = "Unconnected"
		' 
		' _lblDeviceStatus0
		' 
		Me._lblDeviceStatus0.AutoSize = True
		Me._lblDeviceStatus0.Location = New System.Drawing.Point(55, 38)
		Me._lblDeviceStatus0.Name = "_lblDeviceStatus0"
		Me._lblDeviceStatus0.Size = New System.Drawing.Size(70, 13)
		Me._lblDeviceStatus0.TabIndex = 3
		Me._lblDeviceStatus0.Text = "Unconnected"
		' 
		' _rdDevice3
		' 
		Me._rdDevice3.AutoSize = True
		Me._rdDevice3.Location = New System.Drawing.Point(8, 87)
		Me._rdDevice3.Name = "_rdDevice3"
		Me._rdDevice3.Size = New System.Drawing.Size(31, 17)
		Me._rdDevice3.TabIndex = 60
		Me._rdDevice3.Tag = "3"
		Me._rdDevice3.Text = "&3"
		Me._rdDevice3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me._rdDevice3.UseVisualStyleBackColor = True
		AddHandler Me._rdDevice3.CheckedChanged, New System.EventHandler(AddressOf Me._rdDevice_CheckedChanged)
		' 
		' _chkOnlyProfileCount
		' 
		Me._chkOnlyProfileCount.AutoSize = True
		Me._chkOnlyProfileCount.Checked = True
		Me._chkOnlyProfileCount.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkOnlyProfileCount.Location = New System.Drawing.Point(122, 40)
		Me._chkOnlyProfileCount.Name = "_chkOnlyProfileCount"
		Me._chkOnlyProfileCount.Size = New System.Drawing.Size(191, 17)
		Me._chkOnlyProfileCount.TabIndex = 0
		Me._chkOnlyProfileCount.Text = "Count only the number of profiles."
		Me._chkOnlyProfileCount.UseVisualStyleBackColor = True
		' 
		' _chkStartTimer
		' 
		Me._chkStartTimer.AutoSize = True
		Me._chkStartTimer.Location = New System.Drawing.Point(122, 19)
		Me._chkStartTimer.Name = "_chkStartTimer"
		Me._chkStartTimer.Size = New System.Drawing.Size(96, 17)
		Me._chkStartTimer.TabIndex = 1
		Me._chkStartTimer.Text = "Start the timer"
		Me._chkStartTimer.UseVisualStyleBackColor = True
		AddHandler Me._chkStartTimer.CheckedChanged, New System.EventHandler(AddressOf Me._chkStartTimer_CheckedChanged)
		' 
		' _numInterval
		' 
		Me._numInterval.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me._numInterval.Location = New System.Drawing.Point(242, 19)
		Me._numInterval.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me._numInterval.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me._numInterval.Name = "_numInterval"
		Me._numInterval.Size = New System.Drawing.Size(64, 21)
		Me._numInterval.TabIndex = 2
		Me._numInterval.Value = New Decimal(New Integer() {500, 0, 0, 0})
		' 
		' _tabControl
		' 
		Me._tabControl.Controls.Add(Me._tabPage1)
		Me._tabControl.Controls.Add(Me._tabPage2)
		Me._tabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me._tabControl.Location = New System.Drawing.Point(0, 0)
		Me._tabControl.Name = "_tabControl"
		Me._tabControl.SelectedIndex = 0
		Me._tabControl.Size = New System.Drawing.Size(994, 772)
		Me._tabControl.TabIndex = 0
		' 
		' _tabPage1
		' 
		Me._tabPage1.BackColor = System.Drawing.Color.Linen
		Me._tabPage1.Controls.Add(Me._groupBox)
		Me._tabPage1.Controls.Add(Me._grpCommand)
		Me._tabPage1.Location = New System.Drawing.Point(4, 22)
		Me._tabPage1.Name = "_tabPage1"
		Me._tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me._tabPage1.Size = New System.Drawing.Size(986, 746)
		Me._tabPage1.TabIndex = 0
		Me._tabPage1.Text = "[DLL functions] Simple function sample"
		' 
		' _groupBox
		' 
		Me._groupBox.Controls.Add(Me._lblConectedDevice)
		Me._groupBox.Controls.Add(Me.groupBox8)
		Me._groupBox.Controls.Add(Me._grpLog)
		Me._groupBox.Controls.Add(Me._grpExport)
		Me._groupBox.Controls.Add(Me._grpBufferSize)
		Me._groupBox.Controls.Add(Me._pnlDeviceId)
		Me._groupBox.Location = New System.Drawing.Point(627, 5)
		Me._groupBox.Name = "_groupBox"
		Me._groupBox.Size = New System.Drawing.Size(351, 730)
		Me._groupBox.TabIndex = 1
		Me._groupBox.TabStop = False
		Me._groupBox.Text = "Setting / Result"
		' 
		' _lblConectedDevice
		' 
		Me._lblConectedDevice.AutoSize = True
		Me._lblConectedDevice.Location = New System.Drawing.Point(10, 15)
		Me._lblConectedDevice.Name = "_lblConectedDevice"
		Me._lblConectedDevice.Size = New System.Drawing.Size(302, 13)
		Me._lblConectedDevice.TabIndex = 5
		Me._lblConectedDevice.Text = "Controller connection status (Up to 6 units can be connected)"
		' 
		' groupBox8
		' 
		Me.groupBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.groupBox8.Controls.Add(Me._chkOnlyProfileCount)
		Me.groupBox8.Controls.Add(Me._numInterval)
		Me.groupBox8.Controls.Add(Me._chkStartTimer)
		Me.groupBox8.Location = New System.Drawing.Point(12, 549)
		Me.groupBox8.Name = "groupBox8"
		Me.groupBox8.Size = New System.Drawing.Size(339, 64)
		Me.groupBox8.TabIndex = 2
		Me.groupBox8.TabStop = False
		Me.groupBox8.Text = "Profile-related settings ( set and used during high-speed communication)"
		' 
		' _tabPage2
		' 
		Me._tabPage2.BackColor = System.Drawing.Color.AliceBlue
		Me._tabPage2.Controls.Add(Me._grpProgram)
		Me._tabPage2.Controls.Add(Me._grpHighSpeed)
		Me._tabPage2.Controls.Add(Me._grpGetData)
		Me._tabPage2.Controls.Add(Me._grpBaseOperation)
		Me._tabPage2.Location = New System.Drawing.Point(4, 22)
		Me._tabPage2.Name = "_tabPage2"
		Me._tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me._tabPage2.Size = New System.Drawing.Size(986, 746)
		Me._tabPage2.TabIndex = 1
		Me._tabPage2.Text = "[DLL functions] Combination sample"
		' 
		' _grpProgram
		' 
		Me._grpProgram.Controls.Add(Me._btnUploadProgram)
		Me._grpProgram.Controls.Add(Me._btnDownloadProgram)
		Me._grpProgram.Controls.Add(Me._btnReferenceProgramFilePath)
		Me._grpProgram.Controls.Add(Me._txtProgramFilePath)
		Me._grpProgram.Controls.Add(Me._lblSelectProgram)
		Me._grpProgram.Controls.Add(Me._cbxSelectProgram)
		Me._grpProgram.Location = New System.Drawing.Point(28, 210)
		Me._grpProgram.Name = "_grpProgram"
		Me._grpProgram.Size = New System.Drawing.Size(441, 123)
		Me._grpProgram.TabIndex = 1
		Me._grpProgram.TabStop = False
		Me._grpProgram.Text = "Reading or writing settings for each program number"
		' 
		' _btnUploadProgram
		' 
		Me._btnUploadProgram.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnUploadProgram.Location = New System.Drawing.Point(19, 84)
		Me._btnUploadProgram.Name = "_btnUploadProgram"
		Me._btnUploadProgram.Size = New System.Drawing.Size(189, 25)
		Me._btnUploadProgram.TabIndex = 4
		Me._btnUploadProgram.Text = "Sending settings (PC -> LJ)"
		Me._btnUploadProgram.UseVisualStyleBackColor = True
		AddHandler Me._btnUploadProgram.Click, New System.EventHandler(AddressOf Me.btnSetSettingEx_Click)
		' 
		' _btnDownloadProgram
		' 
		Me._btnDownloadProgram.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnDownloadProgram.Location = New System.Drawing.Point(235, 84)
		Me._btnDownloadProgram.Name = "_btnDownloadProgram"
		Me._btnDownloadProgram.Size = New System.Drawing.Size(189, 25)
		Me._btnDownloadProgram.TabIndex = 5
		Me._btnDownloadProgram.Text = "Receiving settings (LJ -> PC)"
		Me._btnDownloadProgram.UseVisualStyleBackColor = True
		AddHandler Me._btnDownloadProgram.Click, New System.EventHandler(AddressOf Me.btnGetSettingEx_Click)
		' 
		' _btnReferenceProgramFilePath
		' 
		Me._btnReferenceProgramFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnReferenceProgramFilePath.Location = New System.Drawing.Point(373, 54)
		Me._btnReferenceProgramFilePath.Name = "_btnReferenceProgramFilePath"
		Me._btnReferenceProgramFilePath.Size = New System.Drawing.Size(51, 25)
		Me._btnReferenceProgramFilePath.TabIndex = 3
		Me._btnReferenceProgramFilePath.Text = "..."
		Me._btnReferenceProgramFilePath.UseVisualStyleBackColor = True
		AddHandler Me._btnReferenceProgramFilePath.Click, New System.EventHandler(AddressOf Me._btnReferenceProgramFilePathEx_Click)
		' 
		' _txtProgramFilePath
		' 
		Me._txtProgramFilePath.Location = New System.Drawing.Point(19, 57)
		Me._txtProgramFilePath.Name = "_txtProgramFilePath"
		Me._txtProgramFilePath.Size = New System.Drawing.Size(347, 21)
		Me._txtProgramFilePath.TabIndex = 2
		' 
		' _lblSelectProgram
		' 
		Me._lblSelectProgram.AutoSize = True
		Me._lblSelectProgram.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblSelectProgram.Location = New System.Drawing.Point(17, 33)
		Me._lblSelectProgram.Name = "_lblSelectProgram"
		Me._lblSelectProgram.Size = New System.Drawing.Size(98, 13)
		Me._lblSelectProgram.TabIndex = 0
		Me._lblSelectProgram.Text = "Select the program"
		' 
		' _cbxSelectProgram
		' 
		Me._cbxSelectProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxSelectProgram.FormattingEnabled = True
		Me._cbxSelectProgram.Items.AddRange(New Object() {"Environment", "Common", "Program0", "Program1", "Program2", "Program3", _
			"Program4", "Program5", "Program6", "Program7", "Program8", "Program9", _
			"Program10", "Program11", "Program12", "Program13", "Program14", "Program15"})
		Me._cbxSelectProgram.Location = New System.Drawing.Point(130, 31)
		Me._cbxSelectProgram.Name = "_cbxSelectProgram"
		Me._cbxSelectProgram.Size = New System.Drawing.Size(101, 21)
		Me._cbxSelectProgram.TabIndex = 1
		' 
		' _grpHighSpeed
		' 
		Me._grpHighSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me._grpHighSpeed.Controls.Add(Me._txtCallbackFrequency)
		Me._grpHighSpeed.Controls.Add(Me._txtStartProfileNo)
		Me._grpHighSpeed.Controls.Add(Me._lblReceiveProfileCount)
		Me._grpHighSpeed.Controls.Add(Me._lblCallbackFrequency)
		Me._grpHighSpeed.Controls.Add(Me._btnTerminateHighSpeedCommunication)
		Me._grpHighSpeed.Controls.Add(Me._lblHighSpeedStartNo)
		Me._grpHighSpeed.Controls.Add(Me._lblReceiveCount)
		Me._grpHighSpeed.Controls.Add(Me._btnBeginHighSpeedDataCommunication)
		Me._grpHighSpeed.Location = New System.Drawing.Point(485, 260)
		Me._grpHighSpeed.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpHighSpeed.Name = "_grpHighSpeed"
		Me._grpHighSpeed.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpHighSpeed.Size = New System.Drawing.Size(440, 130)
		Me._grpHighSpeed.TabIndex = 3
		Me._grpHighSpeed.TabStop = False
		Me._grpHighSpeed.Text = "High-speed data communication"
		' 
		' _txtCallbackFrequency
		' 
		Me._txtCallbackFrequency.Location = New System.Drawing.Point(338, 54)
		Me._txtCallbackFrequency.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtCallbackFrequency.Name = "_txtCallbackFrequency"
		Me._txtCallbackFrequency.Size = New System.Drawing.Size(45, 21)
		Me._txtCallbackFrequency.TabIndex = 4
		Me._txtCallbackFrequency.Text = "10"
		' 
		' _txtStartProfileNo
		' 
		Me._txtStartProfileNo.Location = New System.Drawing.Point(338, 25)
		Me._txtStartProfileNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtStartProfileNo.Name = "_txtStartProfileNo"
		Me._txtStartProfileNo.Size = New System.Drawing.Size(45, 21)
		Me._txtStartProfileNo.TabIndex = 2
		Me._txtStartProfileNo.Text = "2"
		' 
		' _lblReceiveProfileCount
		' 
		Me._lblReceiveProfileCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._lblReceiveProfileCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblReceiveProfileCount.Location = New System.Drawing.Point(305, 86)
		Me._lblReceiveProfileCount.Name = "_lblReceiveProfileCount"
		Me._lblReceiveProfileCount.Size = New System.Drawing.Size(78, 18)
		Me._lblReceiveProfileCount.TabIndex = 6
		Me._lblReceiveProfileCount.Text = "123456789"
		Me._lblReceiveProfileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' _lblCallbackFrequency
		' 
		Me._lblCallbackFrequency.AutoSize = True
		Me._lblCallbackFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblCallbackFrequency.Location = New System.Drawing.Point(107, 51)
		Me._lblCallbackFrequency.Name = "_lblCallbackFrequency"
		Me._lblCallbackFrequency.Size = New System.Drawing.Size(158, 13)
		Me._lblCallbackFrequency.TabIndex = 3
		Me._lblCallbackFrequency.Text = "Callback function call frequency"
		' 
		' _btnTerminateHighSpeedCommunication
		' 
		Me._btnTerminateHighSpeedCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnTerminateHighSpeedCommunication.Location = New System.Drawing.Point(6, 54)
		Me._btnTerminateHighSpeedCommunication.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnTerminateHighSpeedCommunication.Name = "_btnTerminateHighSpeedCommunication"
		Me._btnTerminateHighSpeedCommunication.Size = New System.Drawing.Size(75, 25)
		Me._btnTerminateHighSpeedCommunication.TabIndex = 7
		Me._btnTerminateHighSpeedCommunication.Text = "Finalize "
		Me._btnTerminateHighSpeedCommunication.UseVisualStyleBackColor = True
		AddHandler Me._btnTerminateHighSpeedCommunication.Click, New System.EventHandler(AddressOf Me.btnEndHighSpeedDataCommunicationEx_Click)
		' 
		' _lblHighSpeedStartNo
		' 
		Me._lblHighSpeedStartNo.AutoSize = True
		Me._lblHighSpeedStartNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblHighSpeedStartNo.Location = New System.Drawing.Point(107, 25)
		Me._lblHighSpeedStartNo.Name = "_lblHighSpeedStartNo"
		Me._lblHighSpeedStartNo.Size = New System.Drawing.Size(97, 13)
		Me._lblHighSpeedStartNo.TabIndex = 1
		Me._lblHighSpeedStartNo.Text = "Send start position"
		' 
		' _lblReceiveCount
		' 
		Me._lblReceiveCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblReceiveCount.Location = New System.Drawing.Point(107, 77)
		Me._lblReceiveCount.Name = "_lblReceiveCount"
		Me._lblReceiveCount.Size = New System.Drawing.Size(288, 27)
		Me._lblReceiveCount.TabIndex = 5
		Me._lblReceiveCount.Text = "Number of received " & vbCr & vbLf & "high-speed communication profiles"
		' 
		' _btnBeginHighSpeedDataCommunication
		' 
		Me._btnBeginHighSpeedDataCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnBeginHighSpeedDataCommunication.Location = New System.Drawing.Point(6, 19)
		Me._btnBeginHighSpeedDataCommunication.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnBeginHighSpeedDataCommunication.Name = "_btnBeginHighSpeedDataCommunication"
		Me._btnBeginHighSpeedDataCommunication.Size = New System.Drawing.Size(75, 25)
		Me._btnBeginHighSpeedDataCommunication.TabIndex = 0
		Me._btnBeginHighSpeedDataCommunication.Text = "Start"
		Me._btnBeginHighSpeedDataCommunication.UseVisualStyleBackColor = True
		AddHandler Me._btnBeginHighSpeedDataCommunication.Click, New System.EventHandler(AddressOf Me.btnBeginHighSpeedCommunicationEx_Click)
		' 
		' _grpGetData
		' 
		Me._grpGetData.Controls.Add(Me._txtMeasureData)
		Me._grpGetData.Controls.Add(Me._grpGetProfile)
		Me._grpGetData.Controls.Add(Me._btnGetLatestMeasureValue)
		Me._grpGetData.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._grpGetData.Location = New System.Drawing.Point(485, 7)
		Me._grpGetData.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpGetData.Name = "_grpGetData"
		Me._grpGetData.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpGetData.Size = New System.Drawing.Size(441, 242)
		Me._grpGetData.TabIndex = 2
		Me._grpGetData.TabStop = False
		Me._grpGetData.Text = "Get measurement results"
		' 
		' _txtMeasureData
		' 
		Me._txtMeasureData.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._txtMeasureData.Location = New System.Drawing.Point(127, 21)
		Me._txtMeasureData.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtMeasureData.Multiline = True
		Me._txtMeasureData.Name = "_txtMeasureData"
		Me._txtMeasureData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me._txtMeasureData.Size = New System.Drawing.Size(307, 88)
		Me._txtMeasureData.TabIndex = 1
		' 
		' _grpGetProfile
		' 
		Me._grpGetProfile.Controls.Add(Me._btnGetProfileAdvanceData)
		Me._grpGetProfile.Controls.Add(Me._btnReferenceSavePath)
		Me._grpGetProfile.Controls.Add(Me._btnGetBatchProfileDataAdvance)
		Me._grpGetProfile.Controls.Add(Me._btnGetBatchProfileData)
		Me._grpGetProfile.Controls.Add(Me._btnGetProfileData)
		Me._grpGetProfile.Controls.Add(Me._txtSavePath)
		Me._grpGetProfile.Controls.Add(Me.label1)
		Me._grpGetProfile.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._grpGetProfile.Location = New System.Drawing.Point(6, 117)
		Me._grpGetProfile.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpGetProfile.Name = "_grpGetProfile"
		Me._grpGetProfile.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpGetProfile.Size = New System.Drawing.Size(427, 120)
		Me._grpGetProfile.TabIndex = 2
		Me._grpGetProfile.TabStop = False
		Me._grpGetProfile.Text = "Get profiles"
		' 
		' _btnGetProfileAdvanceData
		' 
		Me._btnGetProfileAdvanceData.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._btnGetProfileAdvanceData.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnGetProfileAdvanceData.Location = New System.Drawing.Point(6, 84)
		Me._btnGetProfileAdvanceData.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnGetProfileAdvanceData.Name = "_btnGetProfileAdvanceData"
		Me._btnGetProfileAdvanceData.Size = New System.Drawing.Size(201, 25)
		Me._btnGetProfileAdvanceData.TabIndex = 5
		Me._btnGetProfileAdvanceData.Text = "Get advanced mode profiles"
		Me._btnGetProfileAdvanceData.UseVisualStyleBackColor = True
		AddHandler Me._btnGetProfileAdvanceData.Click, New System.EventHandler(AddressOf Me.btnGetProfileAdvanceEx_Click)
		' 
		' _btnReferenceSavePath
		' 
		Me._btnReferenceSavePath.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnReferenceSavePath.Location = New System.Drawing.Point(391, 21)
		Me._btnReferenceSavePath.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnReferenceSavePath.Name = "_btnReferenceSavePath"
		Me._btnReferenceSavePath.Size = New System.Drawing.Size(30, 25)
		Me._btnReferenceSavePath.TabIndex = 2
		Me._btnReferenceSavePath.Text = "..."
		Me._btnReferenceSavePath.UseVisualStyleBackColor = True
		AddHandler Me._btnReferenceSavePath.Click, New System.EventHandler(AddressOf Me.btnReferenceSavePathEx_Click)
		' 
		' _btnGetBatchProfileDataAdvance
		' 
		Me._btnGetBatchProfileDataAdvance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._btnGetBatchProfileDataAdvance.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnGetBatchProfileDataAdvance.Location = New System.Drawing.Point(219, 84)
		Me._btnGetBatchProfileDataAdvance.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnGetBatchProfileDataAdvance.Name = "_btnGetBatchProfileDataAdvance"
		Me._btnGetBatchProfileDataAdvance.Size = New System.Drawing.Size(201, 25)
		Me._btnGetBatchProfileDataAdvance.TabIndex = 6
		Me._btnGetBatchProfileDataAdvance.Text = "Get advanced mode batch profiles"
		Me._btnGetBatchProfileDataAdvance.UseVisualStyleBackColor = True
		AddHandler Me._btnGetBatchProfileDataAdvance.Click, New System.EventHandler(AddressOf Me.btnGetBatchProfileAdvanceEx_Click)
		' 
		' _btnGetBatchProfileData
		' 
		Me._btnGetBatchProfileData.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._btnGetBatchProfileData.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnGetBatchProfileData.Location = New System.Drawing.Point(219, 52)
		Me._btnGetBatchProfileData.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnGetBatchProfileData.Name = "_btnGetBatchProfileData"
		Me._btnGetBatchProfileData.Size = New System.Drawing.Size(201, 25)
		Me._btnGetBatchProfileData.TabIndex = 4
		Me._btnGetBatchProfileData.Text = "Get high-speed mode batch profiles"
		Me._btnGetBatchProfileData.UseVisualStyleBackColor = True
		AddHandler Me._btnGetBatchProfileData.Click, New System.EventHandler(AddressOf Me.btnGetBatchProfileEx_Click)
		' 
		' _btnGetProfileData
		' 
		Me._btnGetProfileData.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._btnGetProfileData.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnGetProfileData.Location = New System.Drawing.Point(6, 52)
		Me._btnGetProfileData.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnGetProfileData.Name = "_btnGetProfileData"
		Me._btnGetProfileData.Size = New System.Drawing.Size(201, 25)
		Me._btnGetProfileData.TabIndex = 3
		Me._btnGetProfileData.Text = "Get high-speed mode profiles"
		Me._btnGetProfileData.UseVisualStyleBackColor = True
		AddHandler Me._btnGetProfileData.Click, New System.EventHandler(AddressOf Me.btnGetProfileEx_Click)
		' 
		' _txtSavePath
		' 
		Me._txtSavePath.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._txtSavePath.Location = New System.Drawing.Point(103, 25)
		Me._txtSavePath.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtSavePath.Name = "_txtSavePath"
		Me._txtSavePath.Size = New System.Drawing.Size(283, 21)
		Me._txtSavePath.TabIndex = 1
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.label1.Location = New System.Drawing.Point(6, 29)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(56, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Save path"
		' 
		' _btnGetLatestMeasureValue
		' 
		Me._btnGetLatestMeasureValue.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._btnGetLatestMeasureValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnGetLatestMeasureValue.Location = New System.Drawing.Point(6, 19)
		Me._btnGetLatestMeasureValue.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnGetLatestMeasureValue.Name = "_btnGetLatestMeasureValue"
		Me._btnGetLatestMeasureValue.Size = New System.Drawing.Size(115, 25)
		Me._btnGetLatestMeasureValue.TabIndex = 0
		Me._btnGetLatestMeasureValue.Text = "Get Current values"
		Me._btnGetLatestMeasureValue.UseVisualStyleBackColor = True
		AddHandler Me._btnGetLatestMeasureValue.Click, New System.EventHandler(AddressOf Me.btnGetMeasureValueEx_Click)
		' 
		' _grpBaseOperation
		' 
		Me._grpBaseOperation.Controls.Add(Me._pnlCommunicationDevice)
		Me._grpBaseOperation.Controls.Add(Me._btnTerminateCommunication)
		Me._grpBaseOperation.Controls.Add(Me._btnEstablishCommunication)
		Me._grpBaseOperation.Location = New System.Drawing.Point(28, 7)
		Me._grpBaseOperation.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpBaseOperation.Name = "_grpBaseOperation"
		Me._grpBaseOperation.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpBaseOperation.Size = New System.Drawing.Size(441, 194)
		Me._grpBaseOperation.TabIndex = 0
		Me._grpBaseOperation.TabStop = False
		Me._grpBaseOperation.Text = "Establish/disconnect the communication path with the controller"
		' 
		' _pnlCommunicationDevice
		' 
		Me._pnlCommunicationDevice.Controls.Add(Me._rdUsb)
		Me._pnlCommunicationDevice.Controls.Add(Me._rdEthernet)
		Me._pnlCommunicationDevice.Controls.Add(Me._grpEthernetSetting)
		Me._pnlCommunicationDevice.Location = New System.Drawing.Point(6, 53)
		Me._pnlCommunicationDevice.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._pnlCommunicationDevice.Name = "_pnlCommunicationDevice"
		Me._pnlCommunicationDevice.Size = New System.Drawing.Size(418, 130)
		Me._pnlCommunicationDevice.TabIndex = 1
		' 
		' _rdUsb
		' 
		Me._rdUsb.AutoSize = True
		Me._rdUsb.Checked = True
		Me._rdUsb.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._rdUsb.Location = New System.Drawing.Point(3, 5)
		Me._rdUsb.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._rdUsb.Name = "_rdUsb"
		Me._rdUsb.Size = New System.Drawing.Size(44, 17)
		Me._rdUsb.TabIndex = 0
		Me._rdUsb.TabStop = True
		Me._rdUsb.Text = "USB"
		Me._rdUsb.UseVisualStyleBackColor = True
		' 
		' _rdEthernet
		' 
		Me._rdEthernet.AutoSize = True
		Me._rdEthernet.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._rdEthernet.Location = New System.Drawing.Point(3, 26)
		Me._rdEthernet.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._rdEthernet.Name = "_rdEthernet"
		Me._rdEthernet.Size = New System.Drawing.Size(67, 17)
		Me._rdEthernet.TabIndex = 1
		Me._rdEthernet.Text = "Ethernet"
		Me._rdEthernet.UseVisualStyleBackColor = True
		AddHandler Me._rdEthernet.CheckedChanged, New System.EventHandler(AddressOf Me._rdEthernet_CheckedChanged)
		' 
		' _grpEthernetSetting
		' 
		Me._grpEthernetSetting.Controls.Add(Me._txtIpFirstSegment)
		Me._grpEthernetSetting.Controls.Add(Me._txtIpFourthSegment)
		Me._grpEthernetSetting.Controls.Add(Me._txtIpSecondSegment)
		Me._grpEthernetSetting.Controls.Add(Me._lblHighSpeedPort)
		Me._grpEthernetSetting.Controls.Add(Me._txtIpThirdSegment)
		Me._grpEthernetSetting.Controls.Add(Me._lblIpSeparator3)
		Me._grpEthernetSetting.Controls.Add(Me._lblIpSeparator2)
		Me._grpEthernetSetting.Controls.Add(Me._txtHighSpeedPort)
		Me._grpEthernetSetting.Controls.Add(Me._lblIpSeparator1)
		Me._grpEthernetSetting.Controls.Add(Me._txtCommandPort)
		Me._grpEthernetSetting.Controls.Add(Me._lblIpAddress)
		Me._grpEthernetSetting.Controls.Add(Me._lblCommandPort)
		Me._grpEthernetSetting.Enabled = False
		Me._grpEthernetSetting.Location = New System.Drawing.Point(23, 32)
		Me._grpEthernetSetting.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpEthernetSetting.Name = "_grpEthernetSetting"
		Me._grpEthernetSetting.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._grpEthernetSetting.Size = New System.Drawing.Size(374, 91)
		Me._grpEthernetSetting.TabIndex = 1
		Me._grpEthernetSetting.TabStop = False
		' 
		' _txtIpFirstSegment
		' 
		Me._txtIpFirstSegment.Location = New System.Drawing.Point(229, 12)
		Me._txtIpFirstSegment.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtIpFirstSegment.Name = "_txtIpFirstSegment"
		Me._txtIpFirstSegment.Size = New System.Drawing.Size(25, 21)
		Me._txtIpFirstSegment.TabIndex = 1
		Me._txtIpFirstSegment.Text = "192"
		' 
		' _txtIpFourthSegment
		' 
		Me._txtIpFourthSegment.Location = New System.Drawing.Point(328, 12)
		Me._txtIpFourthSegment.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtIpFourthSegment.Name = "_txtIpFourthSegment"
		Me._txtIpFourthSegment.Size = New System.Drawing.Size(25, 21)
		Me._txtIpFourthSegment.TabIndex = 3
		Me._txtIpFourthSegment.Text = "1"
		' 
		' _txtIpSecondSegment
		' 
		Me._txtIpSecondSegment.Location = New System.Drawing.Point(262, 12)
		Me._txtIpSecondSegment.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtIpSecondSegment.Name = "_txtIpSecondSegment"
		Me._txtIpSecondSegment.Size = New System.Drawing.Size(25, 21)
		Me._txtIpSecondSegment.TabIndex = 2
		Me._txtIpSecondSegment.Text = "168"
		' 
		' _lblHighSpeedPort
		' 
		Me._lblHighSpeedPort.AutoSize = True
		Me._lblHighSpeedPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblHighSpeedPort.Location = New System.Drawing.Point(15, 65)
		Me._lblHighSpeedPort.Name = "_lblHighSpeedPort"
		Me._lblHighSpeedPort.Size = New System.Drawing.Size(225, 13)
		Me._lblHighSpeedPort.TabIndex = 9
		Me._lblHighSpeedPort.Text = "TCP port number (high-speed communication)"
		' 
		' _txtIpThirdSegment
		' 
		Me._txtIpThirdSegment.Location = New System.Drawing.Point(295, 12)
		Me._txtIpThirdSegment.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtIpThirdSegment.Name = "_txtIpThirdSegment"
		Me._txtIpThirdSegment.Size = New System.Drawing.Size(25, 21)
		Me._txtIpThirdSegment.TabIndex = 2
		Me._txtIpThirdSegment.Text = "0"
		' 
		' _lblIpSeparator3
		' 
		Me._lblIpSeparator3.AutoSize = True
		Me._lblIpSeparator3.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblIpSeparator3.Location = New System.Drawing.Point(320, 19)
		Me._lblIpSeparator3.Name = "_lblIpSeparator3"
		Me._lblIpSeparator3.Size = New System.Drawing.Size(11, 13)
		Me._lblIpSeparator3.TabIndex = 6
		Me._lblIpSeparator3.Text = "."
		' 
		' _lblIpSeparator2
		' 
		Me._lblIpSeparator2.AutoSize = True
		Me._lblIpSeparator2.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblIpSeparator2.Location = New System.Drawing.Point(288, 19)
		Me._lblIpSeparator2.Name = "_lblIpSeparator2"
		Me._lblIpSeparator2.Size = New System.Drawing.Size(11, 13)
		Me._lblIpSeparator2.TabIndex = 5
		Me._lblIpSeparator2.Text = "."
		' 
		' _txtHighSpeedPort
		' 
		Me._txtHighSpeedPort.Location = New System.Drawing.Point(293, 61)
		Me._txtHighSpeedPort.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtHighSpeedPort.Name = "_txtHighSpeedPort"
		Me._txtHighSpeedPort.Size = New System.Drawing.Size(59, 21)
		Me._txtHighSpeedPort.TabIndex = 10
		Me._txtHighSpeedPort.Text = "24692"
		' 
		' _lblIpSeparator1
		' 
		Me._lblIpSeparator1.AutoSize = True
		Me._lblIpSeparator1.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblIpSeparator1.Location = New System.Drawing.Point(254, 19)
		Me._lblIpSeparator1.Name = "_lblIpSeparator1"
		Me._lblIpSeparator1.Size = New System.Drawing.Size(11, 13)
		Me._lblIpSeparator1.TabIndex = 4
		Me._lblIpSeparator1.Text = "."
		' 
		' _txtCommandPort
		' 
		Me._txtCommandPort.Location = New System.Drawing.Point(294, 39)
		Me._txtCommandPort.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._txtCommandPort.Name = "_txtCommandPort"
		Me._txtCommandPort.Size = New System.Drawing.Size(59, 21)
		Me._txtCommandPort.TabIndex = 8
		Me._txtCommandPort.Text = "24691"
		' 
		' _lblIpAddress
		' 
		Me._lblIpAddress.AutoSize = True
		Me._lblIpAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblIpAddress.Location = New System.Drawing.Point(15, 18)
		Me._lblIpAddress.Name = "_lblIpAddress"
		Me._lblIpAddress.Size = New System.Drawing.Size(58, 13)
		Me._lblIpAddress.TabIndex = 0
		Me._lblIpAddress.Text = "IP address"
		' 
		' _lblCommandPort
		' 
		Me._lblCommandPort.AutoSize = True
		Me._lblCommandPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._lblCommandPort.Location = New System.Drawing.Point(15, 42)
		Me._lblCommandPort.Name = "_lblCommandPort"
		Me._lblCommandPort.Size = New System.Drawing.Size(88, 13)
		Me._lblCommandPort.TabIndex = 7
		Me._lblCommandPort.Text = "TCP port number"
		' 
		' _btnTerminateCommunication
		' 
		Me._btnTerminateCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnTerminateCommunication.Location = New System.Drawing.Point(207, 19)
		Me._btnTerminateCommunication.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnTerminateCommunication.Name = "_btnTerminateCommunication"
		Me._btnTerminateCommunication.Size = New System.Drawing.Size(196, 25)
		Me._btnTerminateCommunication.TabIndex = 1
		Me._btnTerminateCommunication.Text = "Communication finalization"
		Me._btnTerminateCommunication.UseVisualStyleBackColor = True
		AddHandler Me._btnTerminateCommunication.Click, New System.EventHandler(AddressOf Me.btnTerminateCommunicationEx_Click)
		' 
		' _btnEstablishCommunication
		' 
		Me._btnEstablishCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me._btnEstablishCommunication.Location = New System.Drawing.Point(6, 19)
		Me._btnEstablishCommunication.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me._btnEstablishCommunication.Name = "_btnEstablishCommunication"
		Me._btnEstablishCommunication.Size = New System.Drawing.Size(196, 25)
		Me._btnEstablishCommunication.TabIndex = 0
		Me._btnEstablishCommunication.Text = "Communication establishment"
		Me._btnEstablishCommunication.UseVisualStyleBackColor = True
		AddHandler Me._btnEstablishCommunication.Click, New System.EventHandler(AddressOf Me.btnEstablishCommunicationEx_Click)
		' 
		' _timerHighSpeed
		' 
		Me._timerHighSpeed.Interval = 200
		AddHandler Me._timerHighSpeed.Tick, New System.EventHandler(AddressOf Me._timerHighSpeed_Tick)
		' 
		' _openProgramFileDialog
		' 
		Me._openProgramFileDialog.FileName = "openFileDialog1"
		' 
		' MainForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(994, 772)
		Me.Controls.Add(Me._tabControl)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "MainForm"
		Me.Text = "DLL Function Sample"
		Me._grpCommand.ResumeLayout(False)
		Me.groupBox7.ResumeLayout(False)
		Me.groupBox6.ResumeLayout(False)
		Me.groupBox5.ResumeLayout(False)
		Me.groupBox4.ResumeLayout(False)
		Me.groupBox3.ResumeLayout(False)
		Me.groupBox2.ResumeLayout(False)
		Me.groupBox1.ResumeLayout(False)
		Me._groupBox1.ResumeLayout(False)
		Me._grpLog.ResumeLayout(False)
		Me._grpLog.PerformLayout()
		Me._grpBufferSize.ResumeLayout(False)
		Me._grpBufferSize.PerformLayout()
		Me._grpReceived.ResumeLayout(False)
		Me._grpReceived.PerformLayout()
		Me._grpMeasureRange.ResumeLayout(False)
		Me._grpMeasureRange.PerformLayout()
		Me._grpHead.ResumeLayout(False)
		Me._grpHead.PerformLayout()
		Me._grpExport.ResumeLayout(False)
		Me._grpExport.PerformLayout()
		DirectCast(Me._nudProfileNo, System.ComponentModel.ISupportInitialize).EndInit()
		Me._pnlDeviceId.ResumeLayout(False)
		Me._pnlDeviceId.PerformLayout()
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		DirectCast(Me._numInterval, System.ComponentModel.ISupportInitialize).EndInit()
		Me._tabControl.ResumeLayout(False)
		Me._tabPage1.ResumeLayout(False)
		Me._groupBox.ResumeLayout(False)
		Me._groupBox.PerformLayout()
		Me.groupBox8.ResumeLayout(False)
		Me.groupBox8.PerformLayout()
		Me._tabPage2.ResumeLayout(False)
		Me._grpProgram.ResumeLayout(False)
		Me._grpProgram.PerformLayout()
		Me._grpHighSpeed.ResumeLayout(False)
		Me._grpHighSpeed.PerformLayout()
		Me._grpGetData.ResumeLayout(False)
		Me._grpGetData.PerformLayout()
		Me._grpGetProfile.ResumeLayout(False)
		Me._grpGetProfile.PerformLayout()
		Me._grpBaseOperation.ResumeLayout(False)
		Me._pnlCommunicationDevice.ResumeLayout(False)
		Me._pnlCommunicationDevice.PerformLayout()
		Me._grpEthernetSetting.ResumeLayout(False)
		Me._grpEthernetSetting.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _btnUsbOpen As System.Windows.Forms.Button
	Private _btnGetTime As System.Windows.Forms.Button
	Private _btnGetVersion As System.Windows.Forms.Button
	Private _btnFinalize As System.Windows.Forms.Button
	Private _btnInitialize As System.Windows.Forms.Button
	Private _btnCommClose As System.Windows.Forms.Button
	Private _btnEthernetOpen As System.Windows.Forms.Button
	Private _grpCommand As System.Windows.Forms.GroupBox
	Private _btnAutoZero As System.Windows.Forms.Button
	Private _btnStopMeasure As System.Windows.Forms.Button
	Private _btnStartMeasure As System.Windows.Forms.Button
	Private _btnTrigger As System.Windows.Forms.Button
	Private _btnClearError As System.Windows.Forms.Button
	Private _btnGetError As System.Windows.Forms.Button
	Private _btnRetrunToFactorySetting As System.Windows.Forms.Button
	Private _btnRebootController As System.Windows.Forms.Button
	Private _btnStopStorage As System.Windows.Forms.Button
	Private _btnStartStorage As System.Windows.Forms.Button
	Private _btnGetBatchProfileAdvance As System.Windows.Forms.Button
	Private _btnGetProfileAdvance As System.Windows.Forms.Button
	Private _btnGetBatchProfile As System.Windows.Forms.Button
	Private _btnGetProfile As System.Windows.Forms.Button
	Private _btnGetMeasurementValue As System.Windows.Forms.Button
	Private _btnChangeActiveProgram As System.Windows.Forms.Button
	Private _btnSetTime As System.Windows.Forms.Button
	Private _btnUpdataSetting As System.Windows.Forms.Button
	Private _btnCheckMemoryAccess As System.Windows.Forms.Button
	Private _btnSetSetting As System.Windows.Forms.Button
	Private _btnGetSetting As System.Windows.Forms.Button
	Private _btnClearMemory As System.Windows.Forms.Button
	Private _btnReset As System.Windows.Forms.Button
	Private _btnTiming As System.Windows.Forms.Button
	Private _btnGetStorageStatus As System.Windows.Forms.Button
	Private _btnGetStorageData As System.Windows.Forms.Button
	Private _btnGetStorageProfile As System.Windows.Forms.Button
	Private _btnGetStorageBatchProfile As System.Windows.Forms.Button
	Private _btnRewriteTemporarySetting As System.Windows.Forms.Button
	Private _btnHighSpeedDataEthernetCommunicationInitalize As System.Windows.Forms.Button
	Private _btnPreStartHighSpeedDataCommunication As System.Windows.Forms.Button
	Private _btnStartHighSpeedDataCommunication As System.Windows.Forms.Button
	Private _btnHighSpeedDataCommunicationFinalize As System.Windows.Forms.Button
	Private _btnStopHighSpeedDataCommunication As System.Windows.Forms.Button
	Private _btnGetActiveProgram As System.Windows.Forms.Button
	Private _grpLog As System.Windows.Forms.GroupBox
	Private _btnLogClear As System.Windows.Forms.Button
	Private _txtboxLog As System.Windows.Forms.TextBox
	Private _btnInitializeSetting As System.Windows.Forms.Button
	Private _grpBufferSize As System.Windows.Forms.GroupBox
	Private _chkboxEnvelope As System.Windows.Forms.CheckBox
	Private _grpHead As System.Windows.Forms.GroupBox
	Private _rdbtnTwoHead As System.Windows.Forms.RadioButton
	Private _rdbtnOneHead As System.Windows.Forms.RadioButton
	Private _grpMeasureRange As System.Windows.Forms.GroupBox
	Private _lblReceivedBinning As System.Windows.Forms.Label
	Private _lblMeasureX As System.Windows.Forms.Label
	Private _grpReceived As System.Windows.Forms.GroupBox
	Private _cmbMeasureX As System.Windows.Forms.ComboBox
	Private _cmbReceivedBinning As System.Windows.Forms.ComboBox
	Private _btnHighSpeedDataUsbCommunicationInitalize As System.Windows.Forms.Button
	Private _grpExport As System.Windows.Forms.GroupBox
	Private _txtboxProfileFilePath As System.Windows.Forms.TextBox
	Private _btnProfileFileSave As System.Windows.Forms.Button
	Private _profileFileSave As System.Windows.Forms.SaveFileDialog
	Private _rdbtnWide As System.Windows.Forms.RadioButton
	Private _cmbCompressX As System.Windows.Forms.ComboBox
	Private _lblCompressX As System.Windows.Forms.Label
	Private _btnSave As System.Windows.Forms.Button
	Private _lblSavePath As System.Windows.Forms.Label
	Private _nudProfileNo As System.Windows.Forms.NumericUpDown
	Private label2 As System.Windows.Forms.Label
	Private _timerHighSpeedReceive As System.Windows.Forms.Timer
	Private _lblReceiveProfileCount0 As System.Windows.Forms.Label
	Private _btnSaveMeasureData As System.Windows.Forms.Button
	Private _rdDevice0 As System.Windows.Forms.RadioButton
	Private _rdDevice2 As System.Windows.Forms.RadioButton
	Private _rdDevice1 As System.Windows.Forms.RadioButton
	Private _pnlDeviceId As System.Windows.Forms.Panel
	Private label4 As System.Windows.Forms.Label
	Private _lblDeviceStatus2 As System.Windows.Forms.Label
	Private _lblDeviceStatus1 As System.Windows.Forms.Label
	Private _lblDeviceStatus0 As System.Windows.Forms.Label
	Private _lblReceiveProfileCount2 As System.Windows.Forms.Label
	Private _lblReceiveProfileCount1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private label3 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private _chkOnlyProfileCount As System.Windows.Forms.CheckBox
	Private _chkStartTimer As System.Windows.Forms.CheckBox
	Private _numInterval As System.Windows.Forms.NumericUpDown
	Private _tabControl As System.Windows.Forms.TabControl
	Private _tabPage1 As System.Windows.Forms.TabPage
	Private _tabPage2 As System.Windows.Forms.TabPage
	Private _groupBox As System.Windows.Forms.GroupBox
	Private _groupBox1 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private groupBox7 As System.Windows.Forms.GroupBox
	Private groupBox8 As System.Windows.Forms.GroupBox
	Private _grpHighSpeed As System.Windows.Forms.GroupBox
	Private _txtCallbackFrequency As System.Windows.Forms.TextBox
	Private _txtStartProfileNo As System.Windows.Forms.TextBox
	Private _lblReceiveProfileCount As System.Windows.Forms.Label
	Private _lblCallbackFrequency As System.Windows.Forms.Label
	Private _lblHighSpeedStartNo As System.Windows.Forms.Label
	Private _lblReceiveCount As System.Windows.Forms.Label
	Private _btnTerminateHighSpeedCommunication As System.Windows.Forms.Button
	Private _btnBeginHighSpeedDataCommunication As System.Windows.Forms.Button
	Private _grpGetData As System.Windows.Forms.GroupBox
	Private _txtMeasureData As System.Windows.Forms.TextBox
	Private _grpGetProfile As System.Windows.Forms.GroupBox
	Private _btnGetProfileAdvanceData As System.Windows.Forms.Button
	Private _btnReferenceSavePath As System.Windows.Forms.Button
	Private _btnGetBatchProfileDataAdvance As System.Windows.Forms.Button
	Private _btnGetBatchProfileData As System.Windows.Forms.Button
	Private _btnGetProfileData As System.Windows.Forms.Button
	Private _txtSavePath As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private _btnGetLatestMeasureValue As System.Windows.Forms.Button
	Private _grpBaseOperation As System.Windows.Forms.GroupBox
	Private _pnlCommunicationDevice As System.Windows.Forms.Panel
	Private _rdUsb As System.Windows.Forms.RadioButton
	Private _rdEthernet As System.Windows.Forms.RadioButton
	Private _grpEthernetSetting As System.Windows.Forms.GroupBox
	Private _txtIpFirstSegment As System.Windows.Forms.TextBox
	Private _txtIpFourthSegment As System.Windows.Forms.TextBox
	Private _txtIpSecondSegment As System.Windows.Forms.TextBox
	Private _txtIpThirdSegment As System.Windows.Forms.TextBox
	Private _lblIpSeparator3 As System.Windows.Forms.Label
	Private _lblIpSeparator2 As System.Windows.Forms.Label
	Private _lblHighSpeedPort As System.Windows.Forms.Label
	Private _txtHighSpeedPort As System.Windows.Forms.TextBox
	Private _lblIpSeparator1 As System.Windows.Forms.Label
	Private _txtCommandPort As System.Windows.Forms.TextBox
	Private _lblIpAddress As System.Windows.Forms.Label
	Private _lblCommandPort As System.Windows.Forms.Label
	Private _btnTerminateCommunication As System.Windows.Forms.Button
	Private _btnEstablishCommunication As System.Windows.Forms.Button
	Private _grpProgram As System.Windows.Forms.GroupBox
	Private _btnUploadProgram As System.Windows.Forms.Button
	Private _btnDownloadProgram As System.Windows.Forms.Button
	Private _btnReferenceProgramFilePath As System.Windows.Forms.Button
	Private _txtProgramFilePath As System.Windows.Forms.TextBox
	Private _lblSelectProgram As System.Windows.Forms.Label
	Private _cbxSelectProgram As System.Windows.Forms.ComboBox
	Private _lblConectedDevice As System.Windows.Forms.Label
	Private _lblDeviceStatus3 As System.Windows.Forms.Label
	Private _rdDevice3 As System.Windows.Forms.RadioButton
	Private _lblReceiveProfileCount3 As System.Windows.Forms.Label
	Private _lblDeviceStatus4 As System.Windows.Forms.Label
	Private radioButton2 As System.Windows.Forms.RadioButton
	Private radioButton1 As System.Windows.Forms.RadioButton
	Private _lblDeviceStatus5 As System.Windows.Forms.Label
	Private _lblReceiveProfileCount5 As System.Windows.Forms.Label
	Private _lblReceiveProfileCount4 As System.Windows.Forms.Label
	Private _timerHighSpeed As System.Windows.Forms.Timer
	Private _openProgramFileDialog As System.Windows.Forms.OpenFileDialog
	Private _lblSettingAttention As System.Windows.Forms.Label
End Class

