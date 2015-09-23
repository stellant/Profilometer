namespace LJV7_DllSampleAll
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._btnUsbOpen = new System.Windows.Forms.Button();
			this._btnGetTime = new System.Windows.Forms.Button();
			this._btnGetVersion = new System.Windows.Forms.Button();
			this._btnFinalize = new System.Windows.Forms.Button();
			this._btnInitialize = new System.Windows.Forms.Button();
			this._btnCommClose = new System.Windows.Forms.Button();
			this._btnEthernetOpen = new System.Windows.Forms.Button();
			this._grpCommand = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this._btnHighSpeedDataUsbCommunicationInitalize = new System.Windows.Forms.Button();
			this._btnHighSpeedDataEthernetCommunicationInitalize = new System.Windows.Forms.Button();
			this._btnPreStartHighSpeedDataCommunication = new System.Windows.Forms.Button();
			this._btnStartHighSpeedDataCommunication = new System.Windows.Forms.Button();
			this._btnStopHighSpeedDataCommunication = new System.Windows.Forms.Button();
			this._btnHighSpeedDataCommunicationFinalize = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this._btnStartStorage = new System.Windows.Forms.Button();
			this._btnStopStorage = new System.Windows.Forms.Button();
			this._btnGetStorageStatus = new System.Windows.Forms.Button();
			this._btnGetStorageData = new System.Windows.Forms.Button();
			this._btnGetStorageProfile = new System.Windows.Forms.Button();
			this._btnGetStorageBatchProfile = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this._btnGetMeasurementValue = new System.Windows.Forms.Button();
			this._btnGetProfile = new System.Windows.Forms.Button();
			this._btnGetBatchProfile = new System.Windows.Forms.Button();
			this._btnGetBatchProfileAdvance = new System.Windows.Forms.Button();
			this._btnGetProfileAdvance = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this._btnSetSetting = new System.Windows.Forms.Button();
			this._btnGetSetting = new System.Windows.Forms.Button();
			this._btnInitializeSetting = new System.Windows.Forms.Button();
			this._btnUpdataSetting = new System.Windows.Forms.Button();
			this._btnRewriteTemporarySetting = new System.Windows.Forms.Button();
			this._btnCheckMemoryAccess = new System.Windows.Forms.Button();
			this._btnSetTime = new System.Windows.Forms.Button();
			this._btnGetActiveProgram = new System.Windows.Forms.Button();
			this._btnChangeActiveProgram = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this._btnTrigger = new System.Windows.Forms.Button();
			this._btnStartMeasure = new System.Windows.Forms.Button();
			this._btnStopMeasure = new System.Windows.Forms.Button();
			this._btnAutoZero = new System.Windows.Forms.Button();
			this._btnClearMemory = new System.Windows.Forms.Button();
			this._btnReset = new System.Windows.Forms.Button();
			this._btnTiming = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._btnRebootController = new System.Windows.Forms.Button();
			this._btnRetrunToFactorySetting = new System.Windows.Forms.Button();
			this._btnGetError = new System.Windows.Forms.Button();
			this._btnClearError = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._groupBox1 = new System.Windows.Forms.GroupBox();
			this._grpLog = new System.Windows.Forms.GroupBox();
			this._txtboxLog = new System.Windows.Forms.TextBox();
			this._btnLogClear = new System.Windows.Forms.Button();
			this._grpBufferSize = new System.Windows.Forms.GroupBox();
			this._lblSettingAttention = new System.Windows.Forms.Label();
			this._grpReceived = new System.Windows.Forms.GroupBox();
			this._chkboxEnvelope = new System.Windows.Forms.CheckBox();
			this._cmbCompressX = new System.Windows.Forms.ComboBox();
			this._lblCompressX = new System.Windows.Forms.Label();
			this._grpMeasureRange = new System.Windows.Forms.GroupBox();
			this._cmbReceivedBinning = new System.Windows.Forms.ComboBox();
			this._cmbMeasureX = new System.Windows.Forms.ComboBox();
			this._lblReceivedBinning = new System.Windows.Forms.Label();
			this._lblMeasureX = new System.Windows.Forms.Label();
			this._grpHead = new System.Windows.Forms.GroupBox();
			this._rdbtnOneHead = new System.Windows.Forms.RadioButton();
			this._rdbtnTwoHead = new System.Windows.Forms.RadioButton();
			this._rdbtnWide = new System.Windows.Forms.RadioButton();
			this._grpExport = new System.Windows.Forms.GroupBox();
			this._nudProfileNo = new System.Windows.Forms.NumericUpDown();
			this._txtboxProfileFilePath = new System.Windows.Forms.TextBox();
			this._btnSaveMeasureData = new System.Windows.Forms.Button();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnProfileFileSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this._lblSavePath = new System.Windows.Forms.Label();
			this._profileFileSave = new System.Windows.Forms.SaveFileDialog();
			this._timerHighSpeedReceive = new System.Windows.Forms.Timer(this.components);
			this._lblReceiveProfileCount0 = new System.Windows.Forms.Label();
			this._rdDevice0 = new System.Windows.Forms.RadioButton();
			this._rdDevice2 = new System.Windows.Forms.RadioButton();
			this._rdDevice1 = new System.Windows.Forms.RadioButton();
			this._pnlDeviceId = new System.Windows.Forms.Panel();
			this._lblDeviceStatus5 = new System.Windows.Forms.Label();
			this._lblDeviceStatus4 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this._lblReceiveProfileCount5 = new System.Windows.Forms.Label();
			this._lblReceiveProfileCount4 = new System.Windows.Forms.Label();
			this._lblReceiveProfileCount3 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._lblReceiveProfileCount1 = new System.Windows.Forms.Label();
			this._lblReceiveProfileCount2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._lblDeviceStatus3 = new System.Windows.Forms.Label();
			this._lblDeviceStatus2 = new System.Windows.Forms.Label();
			this._lblDeviceStatus1 = new System.Windows.Forms.Label();
			this._lblDeviceStatus0 = new System.Windows.Forms.Label();
			this._rdDevice3 = new System.Windows.Forms.RadioButton();
			this._chkOnlyProfileCount = new System.Windows.Forms.CheckBox();
			this._chkStartTimer = new System.Windows.Forms.CheckBox();
			this._numInterval = new System.Windows.Forms.NumericUpDown();
			this._tabControl = new System.Windows.Forms.TabControl();
			this._tabPage1 = new System.Windows.Forms.TabPage();
			this._groupBox = new System.Windows.Forms.GroupBox();
			this._lblConectedDevice = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this._tabPage2 = new System.Windows.Forms.TabPage();
			this._grpProgram = new System.Windows.Forms.GroupBox();
			this._btnUploadProgram = new System.Windows.Forms.Button();
			this._btnDownloadProgram = new System.Windows.Forms.Button();
			this._btnReferenceProgramFilePath = new System.Windows.Forms.Button();
			this._txtProgramFilePath = new System.Windows.Forms.TextBox();
			this._lblSelectProgram = new System.Windows.Forms.Label();
			this._cbxSelectProgram = new System.Windows.Forms.ComboBox();
			this._grpHighSpeed = new System.Windows.Forms.GroupBox();
			this._txtCallbackFrequency = new System.Windows.Forms.TextBox();
			this._txtStartProfileNo = new System.Windows.Forms.TextBox();
			this._lblReceiveProfileCount = new System.Windows.Forms.Label();
			this._lblCallbackFrequency = new System.Windows.Forms.Label();
			this._btnTerminateHighSpeedCommunication = new System.Windows.Forms.Button();
			this._lblHighSpeedStartNo = new System.Windows.Forms.Label();
			this._lblReceiveCount = new System.Windows.Forms.Label();
			this._btnBeginHighSpeedDataCommunication = new System.Windows.Forms.Button();
			this._grpGetData = new System.Windows.Forms.GroupBox();
			this._txtMeasureData = new System.Windows.Forms.TextBox();
			this._grpGetProfile = new System.Windows.Forms.GroupBox();
			this._btnGetProfileAdvanceData = new System.Windows.Forms.Button();
			this._btnReferenceSavePath = new System.Windows.Forms.Button();
			this._btnGetBatchProfileDataAdvance = new System.Windows.Forms.Button();
			this._btnGetBatchProfileData = new System.Windows.Forms.Button();
			this._btnGetProfileData = new System.Windows.Forms.Button();
			this._txtSavePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnGetLatestMeasureValue = new System.Windows.Forms.Button();
			this._grpBaseOperation = new System.Windows.Forms.GroupBox();
			this._pnlCommunicationDevice = new System.Windows.Forms.Panel();
			this._rdUsb = new System.Windows.Forms.RadioButton();
			this._rdEthernet = new System.Windows.Forms.RadioButton();
			this._grpEthernetSetting = new System.Windows.Forms.GroupBox();
			this._txtIpFirstSegment = new System.Windows.Forms.TextBox();
			this._txtIpFourthSegment = new System.Windows.Forms.TextBox();
			this._txtIpSecondSegment = new System.Windows.Forms.TextBox();
			this._lblHighSpeedPort = new System.Windows.Forms.Label();
			this._txtIpThirdSegment = new System.Windows.Forms.TextBox();
			this._lblIpSeparator3 = new System.Windows.Forms.Label();
			this._lblIpSeparator2 = new System.Windows.Forms.Label();
			this._txtHighSpeedPort = new System.Windows.Forms.TextBox();
			this._lblIpSeparator1 = new System.Windows.Forms.Label();
			this._txtCommandPort = new System.Windows.Forms.TextBox();
			this._lblIpAddress = new System.Windows.Forms.Label();
			this._lblCommandPort = new System.Windows.Forms.Label();
			this._btnTerminateCommunication = new System.Windows.Forms.Button();
			this._btnEstablishCommunication = new System.Windows.Forms.Button();
			this._timerHighSpeed = new System.Windows.Forms.Timer(this.components);
			this._openProgramFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._grpCommand.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this._groupBox1.SuspendLayout();
			this._grpLog.SuspendLayout();
			this._grpBufferSize.SuspendLayout();
			this._grpReceived.SuspendLayout();
			this._grpMeasureRange.SuspendLayout();
			this._grpHead.SuspendLayout();
			this._grpExport.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._nudProfileNo)).BeginInit();
			this._pnlDeviceId.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numInterval)).BeginInit();
			this._tabControl.SuspendLayout();
			this._tabPage1.SuspendLayout();
			this._groupBox.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this._tabPage2.SuspendLayout();
			this._grpProgram.SuspendLayout();
			this._grpHighSpeed.SuspendLayout();
			this._grpGetData.SuspendLayout();
			this._grpGetProfile.SuspendLayout();
			this._grpBaseOperation.SuspendLayout();
			this._pnlCommunicationDevice.SuspendLayout();
			this._grpEthernetSetting.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnUsbOpen
			// 
			this._btnUsbOpen.BackColor = System.Drawing.Color.LightGray;
			this._btnUsbOpen.Location = new System.Drawing.Point(6, 18);
			this._btnUsbOpen.Name = "_btnUsbOpen";
			this._btnUsbOpen.Size = new System.Drawing.Size(145, 23);
			this._btnUsbOpen.TabIndex = 0;
			this._btnUsbOpen.Text = "UsbOpen";
			this._btnUsbOpen.UseVisualStyleBackColor = false;
			this._btnUsbOpen.Click += new System.EventHandler(this.btnUsbOpen_Click);
			// 
			// _btnGetTime
			// 
			this._btnGetTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetTime.Location = new System.Drawing.Point(452, 48);
			this._btnGetTime.Name = "_btnGetTime";
			this._btnGetTime.Size = new System.Drawing.Size(143, 23);
			this._btnGetTime.TabIndex = 7;
			this._btnGetTime.Text = "GetTime";
			this._btnGetTime.UseVisualStyleBackColor = false;
			this._btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
			// 
			// _btnGetVersion
			// 
			this._btnGetVersion.Location = new System.Drawing.Point(156, 18);
			this._btnGetVersion.Name = "_btnGetVersion";
			this._btnGetVersion.Size = new System.Drawing.Size(136, 23);
			this._btnGetVersion.TabIndex = 1;
			this._btnGetVersion.Text = "GetVersion";
			this._btnGetVersion.UseVisualStyleBackColor = true;
			this._btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
			// 
			// _btnFinalize
			// 
			this._btnFinalize.Location = new System.Drawing.Point(303, 18);
			this._btnFinalize.Name = "_btnFinalize";
			this._btnFinalize.Size = new System.Drawing.Size(143, 23);
			this._btnFinalize.TabIndex = 2;
			this._btnFinalize.Text = "Finalize";
			this._btnFinalize.UseVisualStyleBackColor = true;
			this._btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
			// 
			// _btnInitialize
			// 
			this._btnInitialize.Location = new System.Drawing.Point(6, 18);
			this._btnInitialize.Name = "_btnInitialize";
			this._btnInitialize.Size = new System.Drawing.Size(144, 23);
			this._btnInitialize.TabIndex = 0;
			this._btnInitialize.Text = "Initialize";
			this._btnInitialize.UseVisualStyleBackColor = true;
			this._btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
			// 
			// _btnCommClose
			// 
			this._btnCommClose.BackColor = System.Drawing.Color.LightGray;
			this._btnCommClose.Location = new System.Drawing.Point(304, 18);
			this._btnCommClose.Name = "_btnCommClose";
			this._btnCommClose.Size = new System.Drawing.Size(143, 23);
			this._btnCommClose.TabIndex = 2;
			this._btnCommClose.Text = "CommClose";
			this._btnCommClose.UseVisualStyleBackColor = false;
			this._btnCommClose.Click += new System.EventHandler(this.btnCommClose_Click);
			// 
			// _btnEthernetOpen
			// 
			this._btnEthernetOpen.BackColor = System.Drawing.Color.LightGray;
			this._btnEthernetOpen.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnEthernetOpen.Location = new System.Drawing.Point(157, 18);
			this._btnEthernetOpen.Name = "_btnEthernetOpen";
			this._btnEthernetOpen.Size = new System.Drawing.Size(136, 23);
			this._btnEthernetOpen.TabIndex = 1;
			this._btnEthernetOpen.Text = "EthernetOpen";
			this._btnEthernetOpen.UseVisualStyleBackColor = false;
			this._btnEthernetOpen.Click += new System.EventHandler(this.btnEthernetOpen_Click);
			// 
			// _grpCommand
			// 
			this._grpCommand.BackColor = System.Drawing.Color.Linen;
			this._grpCommand.Controls.Add(this.groupBox7);
			this._grpCommand.Controls.Add(this.groupBox6);
			this._grpCommand.Controls.Add(this.groupBox5);
			this._grpCommand.Controls.Add(this.groupBox4);
			this._grpCommand.Controls.Add(this.groupBox3);
			this._grpCommand.Controls.Add(this.groupBox2);
			this._grpCommand.Controls.Add(this.groupBox1);
			this._grpCommand.Controls.Add(this._groupBox1);
			this._grpCommand.Location = new System.Drawing.Point(3, 3);
			this._grpCommand.Name = "_grpCommand";
			this._grpCommand.Size = new System.Drawing.Size(618, 675);
			this._grpCommand.TabIndex = 0;
			this._grpCommand.TabStop = false;
			this._grpCommand.Text = "Communication command";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this._btnHighSpeedDataUsbCommunicationInitalize);
			this.groupBox7.Controls.Add(this._btnHighSpeedDataEthernetCommunicationInitalize);
			this.groupBox7.Controls.Add(this._btnPreStartHighSpeedDataCommunication);
			this.groupBox7.Controls.Add(this._btnStartHighSpeedDataCommunication);
			this.groupBox7.Controls.Add(this._btnStopHighSpeedDataCommunication);
			this.groupBox7.Controls.Add(this._btnHighSpeedDataCommunicationFinalize);
			this.groupBox7.Location = new System.Drawing.Point(9, 557);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(603, 110);
			this.groupBox7.TabIndex = 7;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "High-speed data communication related functions";
			// 
			// _btnHighSpeedDataUsbCommunicationInitalize
			// 
			this._btnHighSpeedDataUsbCommunicationInitalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
			this._btnHighSpeedDataUsbCommunicationInitalize.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnHighSpeedDataUsbCommunicationInitalize.Location = new System.Drawing.Point(6, 18);
			this._btnHighSpeedDataUsbCommunicationInitalize.Name = "_btnHighSpeedDataUsbCommunicationInitalize";
			this._btnHighSpeedDataUsbCommunicationInitalize.Size = new System.Drawing.Size(141, 41);
			this._btnHighSpeedDataUsbCommunicationInitalize.TabIndex = 0;
			this._btnHighSpeedDataUsbCommunicationInitalize.Text = "HighSpeedDataUSB CommunicationInitalize";
			this._btnHighSpeedDataUsbCommunicationInitalize.UseVisualStyleBackColor = false;
			this._btnHighSpeedDataUsbCommunicationInitalize.Click += new System.EventHandler(this.btnHighSpeedDataUsbCommunicationInitalize_Click);
			// 
			// _btnHighSpeedDataEthernetCommunicationInitalize
			// 
			this._btnHighSpeedDataEthernetCommunicationInitalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
			this._btnHighSpeedDataEthernetCommunicationInitalize.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnHighSpeedDataEthernetCommunicationInitalize.Location = new System.Drawing.Point(153, 18);
			this._btnHighSpeedDataEthernetCommunicationInitalize.Name = "_btnHighSpeedDataEthernetCommunicationInitalize";
			this._btnHighSpeedDataEthernetCommunicationInitalize.Size = new System.Drawing.Size(141, 41);
			this._btnHighSpeedDataEthernetCommunicationInitalize.TabIndex = 1;
			this._btnHighSpeedDataEthernetCommunicationInitalize.Text = "HighSpeedDataEthernet CommunicationInitalize";
			this._btnHighSpeedDataEthernetCommunicationInitalize.UseVisualStyleBackColor = false;
			this._btnHighSpeedDataEthernetCommunicationInitalize.Click += new System.EventHandler(this.btnHighSpeedDataEthernetCommunicationInitalize_Click);
			// 
			// _btnPreStartHighSpeedDataCommunication
			// 
			this._btnPreStartHighSpeedDataCommunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
			this._btnPreStartHighSpeedDataCommunication.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnPreStartHighSpeedDataCommunication.Location = new System.Drawing.Point(300, 18);
			this._btnPreStartHighSpeedDataCommunication.Name = "_btnPreStartHighSpeedDataCommunication";
			this._btnPreStartHighSpeedDataCommunication.Size = new System.Drawing.Size(145, 41);
			this._btnPreStartHighSpeedDataCommunication.TabIndex = 2;
			this._btnPreStartHighSpeedDataCommunication.Text = "PreStartHighSpeedData Communication";
			this._btnPreStartHighSpeedDataCommunication.UseVisualStyleBackColor = false;
			this._btnPreStartHighSpeedDataCommunication.Click += new System.EventHandler(this.btnPreStartHighSpeedDataCommunication_Click);
			// 
			// _btnStartHighSpeedDataCommunication
			// 
			this._btnStartHighSpeedDataCommunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
			this._btnStartHighSpeedDataCommunication.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnStartHighSpeedDataCommunication.Location = new System.Drawing.Point(449, 18);
			this._btnStartHighSpeedDataCommunication.Name = "_btnStartHighSpeedDataCommunication";
			this._btnStartHighSpeedDataCommunication.Size = new System.Drawing.Size(143, 41);
			this._btnStartHighSpeedDataCommunication.TabIndex = 3;
			this._btnStartHighSpeedDataCommunication.Text = "StartHighSpeed DataCommunication";
			this._btnStartHighSpeedDataCommunication.UseVisualStyleBackColor = false;
			this._btnStartHighSpeedDataCommunication.Click += new System.EventHandler(this.btnStartHighSpeedDataCommunication_Click);
			// 
			// _btnStopHighSpeedDataCommunication
			// 
			this._btnStopHighSpeedDataCommunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
			this._btnStopHighSpeedDataCommunication.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnStopHighSpeedDataCommunication.Location = new System.Drawing.Point(7, 65);
			this._btnStopHighSpeedDataCommunication.Name = "_btnStopHighSpeedDataCommunication";
			this._btnStopHighSpeedDataCommunication.Size = new System.Drawing.Size(140, 41);
			this._btnStopHighSpeedDataCommunication.TabIndex = 4;
			this._btnStopHighSpeedDataCommunication.Text = "StopHighSpeedData Communication";
			this._btnStopHighSpeedDataCommunication.UseVisualStyleBackColor = false;
			this._btnStopHighSpeedDataCommunication.Click += new System.EventHandler(this.btnStopHighSpeedDataCommunication_Click);
			// 
			// _btnHighSpeedDataCommunicationFinalize
			// 
			this._btnHighSpeedDataCommunicationFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
			this._btnHighSpeedDataCommunicationFinalize.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnHighSpeedDataCommunicationFinalize.Location = new System.Drawing.Point(153, 65);
			this._btnHighSpeedDataCommunicationFinalize.Name = "_btnHighSpeedDataCommunicationFinalize";
			this._btnHighSpeedDataCommunicationFinalize.Size = new System.Drawing.Size(141, 41);
			this._btnHighSpeedDataCommunicationFinalize.TabIndex = 5;
			this._btnHighSpeedDataCommunicationFinalize.Text = "HighSpeedData CommunicationFinalize";
			this._btnHighSpeedDataCommunicationFinalize.UseVisualStyleBackColor = false;
			this._btnHighSpeedDataCommunicationFinalize.Click += new System.EventHandler(this.btnHighSpeedDataCommunicationFinalize_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this._btnStartStorage);
			this.groupBox6.Controls.Add(this._btnStopStorage);
			this.groupBox6.Controls.Add(this._btnGetStorageStatus);
			this.groupBox6.Controls.Add(this._btnGetStorageData);
			this.groupBox6.Controls.Add(this._btnGetStorageProfile);
			this.groupBox6.Controls.Add(this._btnGetStorageBatchProfile);
			this.groupBox6.Location = new System.Drawing.Point(6, 470);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(606, 79);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Storage-related functions";
			// 
			// _btnStartStorage
			// 
			this._btnStartStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._btnStartStorage.Location = new System.Drawing.Point(7, 18);
			this._btnStartStorage.Name = "_btnStartStorage";
			this._btnStartStorage.Size = new System.Drawing.Size(143, 23);
			this._btnStartStorage.TabIndex = 0;
			this._btnStartStorage.Text = "StartStorage";
			this._btnStartStorage.UseVisualStyleBackColor = false;
			this._btnStartStorage.Click += new System.EventHandler(this.btnStartStorage_Click);
			// 
			// _btnStopStorage
			// 
			this._btnStopStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._btnStopStorage.Location = new System.Drawing.Point(156, 18);
			this._btnStopStorage.Name = "_btnStopStorage";
			this._btnStopStorage.Size = new System.Drawing.Size(141, 23);
			this._btnStopStorage.TabIndex = 1;
			this._btnStopStorage.Text = "StopStorage";
			this._btnStopStorage.UseVisualStyleBackColor = false;
			this._btnStopStorage.Click += new System.EventHandler(this.btnStopStorage_Click);
			// 
			// _btnGetStorageStatus
			// 
			this._btnGetStorageStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._btnGetStorageStatus.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetStorageStatus.Location = new System.Drawing.Point(303, 18);
			this._btnGetStorageStatus.Name = "_btnGetStorageStatus";
			this._btnGetStorageStatus.Size = new System.Drawing.Size(143, 23);
			this._btnGetStorageStatus.TabIndex = 2;
			this._btnGetStorageStatus.Text = "GetStorageStatus";
			this._btnGetStorageStatus.UseVisualStyleBackColor = false;
			this._btnGetStorageStatus.Click += new System.EventHandler(this.btnGetStorageStatus_Click);
			// 
			// _btnGetStorageData
			// 
			this._btnGetStorageData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._btnGetStorageData.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetStorageData.Location = new System.Drawing.Point(452, 18);
			this._btnGetStorageData.Name = "_btnGetStorageData";
			this._btnGetStorageData.Size = new System.Drawing.Size(143, 23);
			this._btnGetStorageData.TabIndex = 3;
			this._btnGetStorageData.Text = "GetStorageData";
			this._btnGetStorageData.UseVisualStyleBackColor = false;
			this._btnGetStorageData.Click += new System.EventHandler(this.btnGetStorageData_Click);
			// 
			// _btnGetStorageProfile
			// 
			this._btnGetStorageProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._btnGetStorageProfile.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetStorageProfile.Location = new System.Drawing.Point(8, 47);
			this._btnGetStorageProfile.Name = "_btnGetStorageProfile";
			this._btnGetStorageProfile.Size = new System.Drawing.Size(142, 23);
			this._btnGetStorageProfile.TabIndex = 4;
			this._btnGetStorageProfile.Text = "GetStorageProfile";
			this._btnGetStorageProfile.UseVisualStyleBackColor = false;
			this._btnGetStorageProfile.Click += new System.EventHandler(this.btnGetStorageProfile_Click);
			// 
			// _btnGetStorageBatchProfile
			// 
			this._btnGetStorageBatchProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._btnGetStorageBatchProfile.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetStorageBatchProfile.Location = new System.Drawing.Point(156, 47);
			this._btnGetStorageBatchProfile.Name = "_btnGetStorageBatchProfile";
			this._btnGetStorageBatchProfile.Size = new System.Drawing.Size(141, 23);
			this._btnGetStorageBatchProfile.TabIndex = 5;
			this._btnGetStorageBatchProfile.Text = "GetStorageBatchProfile";
			this._btnGetStorageBatchProfile.UseVisualStyleBackColor = false;
			this._btnGetStorageBatchProfile.Click += new System.EventHandler(this.btnGetStorageBatchProfile_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this._btnGetMeasurementValue);
			this.groupBox5.Controls.Add(this._btnGetProfile);
			this.groupBox5.Controls.Add(this._btnGetBatchProfile);
			this.groupBox5.Controls.Add(this._btnGetBatchProfileAdvance);
			this.groupBox5.Controls.Add(this._btnGetProfileAdvance);
			this.groupBox5.Location = new System.Drawing.Point(6, 387);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(606, 78);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Get measurement results";
			// 
			// _btnGetMeasurementValue
			// 
			this._btnGetMeasurementValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetMeasurementValue.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetMeasurementValue.Location = new System.Drawing.Point(8, 18);
			this._btnGetMeasurementValue.Name = "_btnGetMeasurementValue";
			this._btnGetMeasurementValue.Size = new System.Drawing.Size(142, 23);
			this._btnGetMeasurementValue.TabIndex = 0;
			this._btnGetMeasurementValue.Text = "GetMeasurementValue";
			this._btnGetMeasurementValue.UseVisualStyleBackColor = false;
			this._btnGetMeasurementValue.Click += new System.EventHandler(this.btnGetMeasurementValue_Click);
			// 
			// _btnGetProfile
			// 
			this._btnGetProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetProfile.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetProfile.Location = new System.Drawing.Point(8, 44);
			this._btnGetProfile.Name = "_btnGetProfile";
			this._btnGetProfile.Size = new System.Drawing.Size(142, 23);
			this._btnGetProfile.TabIndex = 1;
			this._btnGetProfile.Text = "GetProfile";
			this._btnGetProfile.UseVisualStyleBackColor = false;
			this._btnGetProfile.Click += new System.EventHandler(this.btnGetProfile_Click);
			// 
			// _btnGetBatchProfile
			// 
			this._btnGetBatchProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetBatchProfile.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetBatchProfile.Location = new System.Drawing.Point(156, 44);
			this._btnGetBatchProfile.Name = "_btnGetBatchProfile";
			this._btnGetBatchProfile.Size = new System.Drawing.Size(141, 23);
			this._btnGetBatchProfile.TabIndex = 2;
			this._btnGetBatchProfile.Text = "GetBatchProfile";
			this._btnGetBatchProfile.UseVisualStyleBackColor = false;
			this._btnGetBatchProfile.Click += new System.EventHandler(this.btnGetBatchProfile_Click);
			// 
			// _btnGetBatchProfileAdvance
			// 
			this._btnGetBatchProfileAdvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetBatchProfileAdvance.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetBatchProfileAdvance.Location = new System.Drawing.Point(452, 44);
			this._btnGetBatchProfileAdvance.Name = "_btnGetBatchProfileAdvance";
			this._btnGetBatchProfileAdvance.Size = new System.Drawing.Size(143, 23);
			this._btnGetBatchProfileAdvance.TabIndex = 4;
			this._btnGetBatchProfileAdvance.Text = "GetBatchProfileAdvance";
			this._btnGetBatchProfileAdvance.UseVisualStyleBackColor = false;
			this._btnGetBatchProfileAdvance.Click += new System.EventHandler(this.btnGetBatchProfileAdvance_Click);
			// 
			// _btnGetProfileAdvance
			// 
			this._btnGetProfileAdvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetProfileAdvance.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetProfileAdvance.Location = new System.Drawing.Point(303, 44);
			this._btnGetProfileAdvance.Name = "_btnGetProfileAdvance";
			this._btnGetProfileAdvance.Size = new System.Drawing.Size(143, 23);
			this._btnGetProfileAdvance.TabIndex = 3;
			this._btnGetProfileAdvance.Text = "GetProfileAdvance";
			this._btnGetProfileAdvance.UseVisualStyleBackColor = false;
			this._btnGetProfileAdvance.Click += new System.EventHandler(this.btnGetProfileAdvance_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this._btnSetSetting);
			this.groupBox4.Controls.Add(this._btnGetSetting);
			this.groupBox4.Controls.Add(this._btnInitializeSetting);
			this.groupBox4.Controls.Add(this._btnUpdataSetting);
			this.groupBox4.Controls.Add(this._btnRewriteTemporarySetting);
			this.groupBox4.Controls.Add(this._btnCheckMemoryAccess);
			this.groupBox4.Controls.Add(this._btnSetTime);
			this.groupBox4.Controls.Add(this._btnGetActiveProgram);
			this.groupBox4.Controls.Add(this._btnGetTime);
			this.groupBox4.Controls.Add(this._btnChangeActiveProgram);
			this.groupBox4.Location = new System.Drawing.Point(6, 271);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(606, 109);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Functions related to modifying or reading settings";
			// 
			// _btnSetSetting
			// 
			this._btnSetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnSetSetting.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnSetSetting.Location = new System.Drawing.Point(7, 18);
			this._btnSetSetting.Name = "_btnSetSetting";
			this._btnSetSetting.Size = new System.Drawing.Size(143, 23);
			this._btnSetSetting.TabIndex = 0;
			this._btnSetSetting.Text = "SetSetting";
			this._btnSetSetting.UseVisualStyleBackColor = false;
			this._btnSetSetting.Click += new System.EventHandler(this.btnSetSetting_Click);
			// 
			// _btnGetSetting
			// 
			this._btnGetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetSetting.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetSetting.Location = new System.Drawing.Point(156, 18);
			this._btnGetSetting.Name = "_btnGetSetting";
			this._btnGetSetting.Size = new System.Drawing.Size(141, 23);
			this._btnGetSetting.TabIndex = 1;
			this._btnGetSetting.Text = "GetSetting";
			this._btnGetSetting.UseVisualStyleBackColor = false;
			this._btnGetSetting.Click += new System.EventHandler(this.btnGetSetting_Click);
			// 
			// _btnInitializeSetting
			// 
			this._btnInitializeSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnInitializeSetting.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnInitializeSetting.Location = new System.Drawing.Point(303, 18);
			this._btnInitializeSetting.Name = "_btnInitializeSetting";
			this._btnInitializeSetting.Size = new System.Drawing.Size(145, 23);
			this._btnInitializeSetting.TabIndex = 2;
			this._btnInitializeSetting.Text = "InitializeSetting";
			this._btnInitializeSetting.UseVisualStyleBackColor = false;
			this._btnInitializeSetting.Click += new System.EventHandler(this.btnInitializeSetting_Click);
			// 
			// _btnUpdataSetting
			// 
			this._btnUpdataSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnUpdataSetting.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnUpdataSetting.Location = new System.Drawing.Point(454, 18);
			this._btnUpdataSetting.Name = "_btnUpdataSetting";
			this._btnUpdataSetting.Size = new System.Drawing.Size(143, 23);
			this._btnUpdataSetting.TabIndex = 3;
			this._btnUpdataSetting.Text = "ReflectSetting";
			this._btnUpdataSetting.UseVisualStyleBackColor = false;
			this._btnUpdataSetting.Click += new System.EventHandler(this.btnUpdataSetting_Click);
			// 
			// _btnRewriteTemporarySetting
			// 
			this._btnRewriteTemporarySetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnRewriteTemporarySetting.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnRewriteTemporarySetting.Location = new System.Drawing.Point(7, 48);
			this._btnRewriteTemporarySetting.Name = "_btnRewriteTemporarySetting";
			this._btnRewriteTemporarySetting.Size = new System.Drawing.Size(143, 23);
			this._btnRewriteTemporarySetting.TabIndex = 4;
			this._btnRewriteTemporarySetting.Text = "RewriteTemporarySetting";
			this._btnRewriteTemporarySetting.UseVisualStyleBackColor = false;
			this._btnRewriteTemporarySetting.Click += new System.EventHandler(this.btnRewriteTemporarySetting_Click);
			// 
			// _btnCheckMemoryAccess
			// 
			this._btnCheckMemoryAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnCheckMemoryAccess.Location = new System.Drawing.Point(156, 47);
			this._btnCheckMemoryAccess.Name = "_btnCheckMemoryAccess";
			this._btnCheckMemoryAccess.Size = new System.Drawing.Size(141, 23);
			this._btnCheckMemoryAccess.TabIndex = 5;
			this._btnCheckMemoryAccess.Text = "CheckMemoryAccess";
			this._btnCheckMemoryAccess.UseVisualStyleBackColor = false;
			this._btnCheckMemoryAccess.Click += new System.EventHandler(this.btnCheckMemoryAccess_Click);
			// 
			// _btnSetTime
			// 
			this._btnSetTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnSetTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnSetTime.Location = new System.Drawing.Point(303, 48);
			this._btnSetTime.Name = "_btnSetTime";
			this._btnSetTime.Size = new System.Drawing.Size(145, 23);
			this._btnSetTime.TabIndex = 6;
			this._btnSetTime.Text = "SetTime";
			this._btnSetTime.UseVisualStyleBackColor = false;
			this._btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
			// 
			// _btnGetActiveProgram
			// 
			this._btnGetActiveProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnGetActiveProgram.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetActiveProgram.Location = new System.Drawing.Point(157, 77);
			this._btnGetActiveProgram.Name = "_btnGetActiveProgram";
			this._btnGetActiveProgram.Size = new System.Drawing.Size(140, 23);
			this._btnGetActiveProgram.TabIndex = 9;
			this._btnGetActiveProgram.Text = "GetActiveProgram";
			this._btnGetActiveProgram.UseVisualStyleBackColor = false;
			this._btnGetActiveProgram.Click += new System.EventHandler(this.btnGetActiveProgram_Click);
			// 
			// _btnChangeActiveProgram
			// 
			this._btnChangeActiveProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this._btnChangeActiveProgram.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnChangeActiveProgram.Location = new System.Drawing.Point(10, 78);
			this._btnChangeActiveProgram.Name = "_btnChangeActiveProgram";
			this._btnChangeActiveProgram.Size = new System.Drawing.Size(141, 23);
			this._btnChangeActiveProgram.TabIndex = 8;
			this._btnChangeActiveProgram.Text = "ChangeActiveProgram";
			this._btnChangeActiveProgram.UseVisualStyleBackColor = false;
			this._btnChangeActiveProgram.Click += new System.EventHandler(this.btnChangeActiveProgram_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this._btnTrigger);
			this.groupBox3.Controls.Add(this._btnStartMeasure);
			this.groupBox3.Controls.Add(this._btnStopMeasure);
			this.groupBox3.Controls.Add(this._btnAutoZero);
			this.groupBox3.Controls.Add(this._btnClearMemory);
			this.groupBox3.Controls.Add(this._btnReset);
			this.groupBox3.Controls.Add(this._btnTiming);
			this.groupBox3.Location = new System.Drawing.Point(4, 186);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(608, 79);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Measurement control";
			// 
			// _btnTrigger
			// 
			this._btnTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnTrigger.Location = new System.Drawing.Point(9, 18);
			this._btnTrigger.Name = "_btnTrigger";
			this._btnTrigger.Size = new System.Drawing.Size(143, 23);
			this._btnTrigger.TabIndex = 0;
			this._btnTrigger.Text = "Trigger";
			this._btnTrigger.UseVisualStyleBackColor = false;
			this._btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
			// 
			// _btnStartMeasure
			// 
			this._btnStartMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnStartMeasure.Location = new System.Drawing.Point(158, 18);
			this._btnStartMeasure.Name = "_btnStartMeasure";
			this._btnStartMeasure.Size = new System.Drawing.Size(141, 23);
			this._btnStartMeasure.TabIndex = 1;
			this._btnStartMeasure.Text = "StartMeasure";
			this._btnStartMeasure.UseVisualStyleBackColor = false;
			this._btnStartMeasure.Click += new System.EventHandler(this.btnStartMeasure_Click);
			// 
			// _btnStopMeasure
			// 
			this._btnStopMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnStopMeasure.Location = new System.Drawing.Point(305, 18);
			this._btnStopMeasure.Name = "_btnStopMeasure";
			this._btnStopMeasure.Size = new System.Drawing.Size(145, 23);
			this._btnStopMeasure.TabIndex = 2;
			this._btnStopMeasure.Text = "StopMeasure";
			this._btnStopMeasure.UseVisualStyleBackColor = false;
			this._btnStopMeasure.Click += new System.EventHandler(this.btnStopMeasure_Click);
			// 
			// _btnAutoZero
			// 
			this._btnAutoZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnAutoZero.Location = new System.Drawing.Point(454, 18);
			this._btnAutoZero.Name = "_btnAutoZero";
			this._btnAutoZero.Size = new System.Drawing.Size(143, 23);
			this._btnAutoZero.TabIndex = 3;
			this._btnAutoZero.Text = "AutoZero";
			this._btnAutoZero.UseVisualStyleBackColor = false;
			this._btnAutoZero.Click += new System.EventHandler(this.btnAutoZero_Click);
			// 
			// _btnClearMemory
			// 
			this._btnClearMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnClearMemory.Location = new System.Drawing.Point(305, 51);
			this._btnClearMemory.Name = "_btnClearMemory";
			this._btnClearMemory.Size = new System.Drawing.Size(145, 23);
			this._btnClearMemory.TabIndex = 6;
			this._btnClearMemory.Text = "ClearMemory";
			this._btnClearMemory.UseVisualStyleBackColor = false;
			this._btnClearMemory.Click += new System.EventHandler(this.btnClearMemory_Click);
			// 
			// _btnReset
			// 
			this._btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnReset.Location = new System.Drawing.Point(158, 51);
			this._btnReset.Name = "_btnReset";
			this._btnReset.Size = new System.Drawing.Size(141, 23);
			this._btnReset.TabIndex = 5;
			this._btnReset.Text = "Reset";
			this._btnReset.UseVisualStyleBackColor = false;
			this._btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// _btnTiming
			// 
			this._btnTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this._btnTiming.Location = new System.Drawing.Point(9, 51);
			this._btnTiming.Name = "_btnTiming";
			this._btnTiming.Size = new System.Drawing.Size(143, 23);
			this._btnTiming.TabIndex = 4;
			this._btnTiming.Text = "Timing";
			this._btnTiming.UseVisualStyleBackColor = false;
			this._btnTiming.Click += new System.EventHandler(this.btnTiming_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this._btnRebootController);
			this.groupBox2.Controls.Add(this._btnRetrunToFactorySetting);
			this.groupBox2.Controls.Add(this._btnGetError);
			this.groupBox2.Controls.Add(this._btnClearError);
			this.groupBox2.Location = new System.Drawing.Point(6, 130);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(606, 50);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "System control";
			// 
			// _btnRebootController
			// 
			this._btnRebootController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this._btnRebootController.Location = new System.Drawing.Point(6, 18);
			this._btnRebootController.Name = "_btnRebootController";
			this._btnRebootController.Size = new System.Drawing.Size(144, 23);
			this._btnRebootController.TabIndex = 0;
			this._btnRebootController.Text = "RebootController";
			this._btnRebootController.UseVisualStyleBackColor = false;
			this._btnRebootController.Click += new System.EventHandler(this.btnRebootController_Click);
			// 
			// _btnRetrunToFactorySetting
			// 
			this._btnRetrunToFactorySetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this._btnRetrunToFactorySetting.Location = new System.Drawing.Point(156, 18);
			this._btnRetrunToFactorySetting.Name = "_btnRetrunToFactorySetting";
			this._btnRetrunToFactorySetting.Size = new System.Drawing.Size(136, 23);
			this._btnRetrunToFactorySetting.TabIndex = 1;
			this._btnRetrunToFactorySetting.Text = "RetrunToFactorySetting";
			this._btnRetrunToFactorySetting.UseVisualStyleBackColor = false;
			this._btnRetrunToFactorySetting.Click += new System.EventHandler(this.btnRetrunToFactorySetting_Click);
			// 
			// _btnGetError
			// 
			this._btnGetError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this._btnGetError.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnGetError.Location = new System.Drawing.Point(303, 18);
			this._btnGetError.Name = "_btnGetError";
			this._btnGetError.Size = new System.Drawing.Size(143, 23);
			this._btnGetError.TabIndex = 2;
			this._btnGetError.Text = "GetError";
			this._btnGetError.UseVisualStyleBackColor = false;
			this._btnGetError.Click += new System.EventHandler(this.btnGetError_Click);
			// 
			// _btnClearError
			// 
			this._btnClearError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this._btnClearError.Location = new System.Drawing.Point(452, 18);
			this._btnClearError.Name = "_btnClearError";
			this._btnClearError.Size = new System.Drawing.Size(143, 23);
			this._btnClearError.TabIndex = 3;
			this._btnClearError.Text = "ClearError";
			this._btnClearError.UseVisualStyleBackColor = false;
			this._btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._btnCommClose);
			this.groupBox1.Controls.Add(this._btnEthernetOpen);
			this.groupBox1.Controls.Add(this._btnUsbOpen);
			this.groupBox1.Location = new System.Drawing.Point(5, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(607, 50);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Establish/disconnect the communication path with the controller";
			// 
			// _groupBox1
			// 
			this._groupBox1.Controls.Add(this._btnInitialize);
			this._groupBox1.Controls.Add(this._btnGetVersion);
			this._groupBox1.Controls.Add(this._btnFinalize);
			this._groupBox1.Location = new System.Drawing.Point(6, 18);
			this._groupBox1.Name = "_groupBox1";
			this._groupBox1.Size = new System.Drawing.Size(606, 50);
			this._groupBox1.TabIndex = 0;
			this._groupBox1.TabStop = false;
			this._groupBox1.Text = "Operations for the DLL";
			// 
			// _grpLog
			// 
			this._grpLog.Controls.Add(this._txtboxLog);
			this._grpLog.Controls.Add(this._btnLogClear);
			this._grpLog.Location = new System.Drawing.Point(12, 174);
			this._grpLog.Name = "_grpLog";
			this._grpLog.Size = new System.Drawing.Size(339, 126);
			this._grpLog.TabIndex = 0;
			this._grpLog.TabStop = false;
			this._grpLog.Text = "Operation result log";
			// 
			// _txtboxLog
			// 
			this._txtboxLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtboxLog.Location = new System.Drawing.Point(6, 42);
			this._txtboxLog.Multiline = true;
			this._txtboxLog.Name = "_txtboxLog";
			this._txtboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._txtboxLog.Size = new System.Drawing.Size(315, 70);
			this._txtboxLog.TabIndex = 1;
			// 
			// _btnLogClear
			// 
			this._btnLogClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnLogClear.Location = new System.Drawing.Point(7, 14);
			this._btnLogClear.Name = "_btnLogClear";
			this._btnLogClear.Size = new System.Drawing.Size(96, 23);
			this._btnLogClear.TabIndex = 0;
			this._btnLogClear.Text = "Clear the log";
			this._btnLogClear.UseVisualStyleBackColor = true;
			this._btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
			// 
			// _grpBufferSize
			// 
			this._grpBufferSize.Controls.Add(this._lblSettingAttention);
			this._grpBufferSize.Controls.Add(this._grpReceived);
			this._grpBufferSize.Controls.Add(this._grpMeasureRange);
			this._grpBufferSize.Controls.Add(this._grpHead);
			this._grpBufferSize.Location = new System.Drawing.Point(12, 306);
			this._grpBufferSize.Name = "_grpBufferSize";
			this._grpBufferSize.Size = new System.Drawing.Size(339, 198);
			this._grpBufferSize.TabIndex = 3;
			this._grpBufferSize.TabStop = false;
			this._grpBufferSize.Text = "Buffer size setting (set and used when reading profiles)";
			// 
			// _lblSettingAttention
			// 
			this._lblSettingAttention.AutoSize = true;
			this._lblSettingAttention.Location = new System.Drawing.Point(6, 15);
			this._lblSettingAttention.Name = "_lblSettingAttention";
			this._lblSettingAttention.Size = new System.Drawing.Size(253, 12);
			this._lblSettingAttention.TabIndex = 4;
			this._lblSettingAttention.Text = "*Match the setting of the controller with this application";
			// 
			// _grpReceived
			// 
			this._grpReceived.Controls.Add(this._chkboxEnvelope);
			this._grpReceived.Controls.Add(this._cmbCompressX);
			this._grpReceived.Controls.Add(this._lblCompressX);
			this._grpReceived.Location = new System.Drawing.Point(6, 142);
			this._grpReceived.Name = "_grpReceived";
			this._grpReceived.Size = new System.Drawing.Size(317, 50);
			this._grpReceived.TabIndex = 3;
			this._grpReceived.TabStop = false;
			this._grpReceived.Text = "Profile settings";
			// 
			// _chkboxEnvelope
			// 
			this._chkboxEnvelope.AutoSize = true;
			this._chkboxEnvelope.Checked = true;
			this._chkboxEnvelope.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkboxEnvelope.Location = new System.Drawing.Point(196, 20);
			this._chkboxEnvelope.Name = "_chkboxEnvelope";
			this._chkboxEnvelope.Size = new System.Drawing.Size(98, 16);
			this._chkboxEnvelope.TabIndex = 2;
			this._chkboxEnvelope.Text = "Envelope setting";
			this._chkboxEnvelope.UseVisualStyleBackColor = true;
			// 
			// _cmbCompressX
			// 
			this._cmbCompressX.DisplayMember = "Key";
			this._cmbCompressX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbCompressX.FormattingEnabled = true;
			this._cmbCompressX.Location = new System.Drawing.Point(127, 18);
			this._cmbCompressX.Name = "_cmbCompressX";
			this._cmbCompressX.Size = new System.Drawing.Size(59, 20);
			this._cmbCompressX.TabIndex = 1;
			this._cmbCompressX.ValueMember = "Value";
			// 
			// _lblCompressX
			// 
			this._lblCompressX.AutoSize = true;
			this._lblCompressX.Location = new System.Drawing.Point(6, 22);
			this._lblCompressX.Name = "_lblCompressX";
			this._lblCompressX.Size = new System.Drawing.Size(99, 12);
			this._lblCompressX.TabIndex = 0;
			this._lblCompressX.Text = "Compression (X axis)";
			// 
			// _grpMeasureRange
			// 
			this._grpMeasureRange.Controls.Add(this._cmbReceivedBinning);
			this._grpMeasureRange.Controls.Add(this._cmbMeasureX);
			this._grpMeasureRange.Controls.Add(this._lblReceivedBinning);
			this._grpMeasureRange.Controls.Add(this._lblMeasureX);
			this._grpMeasureRange.Location = new System.Drawing.Point(6, 70);
			this._grpMeasureRange.Name = "_grpMeasureRange";
			this._grpMeasureRange.Size = new System.Drawing.Size(317, 67);
			this._grpMeasureRange.TabIndex = 2;
			this._grpMeasureRange.TabStop = false;
			this._grpMeasureRange.Text = "Imaging settings";
			// 
			// _cmbReceivedBinning
			// 
			this._cmbReceivedBinning.DisplayMember = "Key";
			this._cmbReceivedBinning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbReceivedBinning.FormattingEnabled = true;
			this._cmbReceivedBinning.Location = new System.Drawing.Point(182, 42);
			this._cmbReceivedBinning.Name = "_cmbReceivedBinning";
			this._cmbReceivedBinning.Size = new System.Drawing.Size(91, 20);
			this._cmbReceivedBinning.TabIndex = 3;
			this._cmbReceivedBinning.ValueMember = "Value";
			// 
			// _cmbMeasureX
			// 
			this._cmbMeasureX.DisplayMember = "Key";
			this._cmbMeasureX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbMeasureX.FormattingEnabled = true;
			this._cmbMeasureX.Location = new System.Drawing.Point(182, 17);
			this._cmbMeasureX.Name = "_cmbMeasureX";
			this._cmbMeasureX.Size = new System.Drawing.Size(91, 20);
			this._cmbMeasureX.TabIndex = 1;
			this._cmbMeasureX.ValueMember = "Value";
			// 
			// _lblReceivedBinning
			// 
			this._lblReceivedBinning.AutoSize = true;
			this._lblReceivedBinning.Location = new System.Drawing.Point(13, 46);
			this._lblReceivedBinning.Name = "_lblReceivedBinning";
			this._lblReceivedBinning.Size = new System.Drawing.Size(39, 12);
			this._lblReceivedBinning.TabIndex = 2;
			this._lblReceivedBinning.Text = "Binning";
			// 
			// _lblMeasureX
			// 
			this._lblMeasureX.AutoSize = true;
			this._lblMeasureX.Location = new System.Drawing.Point(12, 19);
			this._lblMeasureX.Name = "_lblMeasureX";
			this._lblMeasureX.Size = new System.Drawing.Size(144, 12);
			this._lblMeasureX.TabIndex = 0;
			this._lblMeasureX.Text = "Measurement range X direction";
			// 
			// _grpHead
			// 
			this._grpHead.Controls.Add(this._rdbtnOneHead);
			this._grpHead.Controls.Add(this._rdbtnTwoHead);
			this._grpHead.Controls.Add(this._rdbtnWide);
			this._grpHead.Location = new System.Drawing.Point(6, 30);
			this._grpHead.Name = "_grpHead";
			this._grpHead.Size = new System.Drawing.Size(317, 38);
			this._grpHead.TabIndex = 1;
			this._grpHead.TabStop = false;
			this._grpHead.Text = "Head";
			// 
			// _rdbtnOneHead
			// 
			this._rdbtnOneHead.AutoSize = true;
			this._rdbtnOneHead.Location = new System.Drawing.Point(21, 17);
			this._rdbtnOneHead.Name = "_rdbtnOneHead";
			this._rdbtnOneHead.Size = new System.Drawing.Size(68, 16);
			this._rdbtnOneHead.TabIndex = 0;
			this._rdbtnOneHead.Text = "One Head";
			this._rdbtnOneHead.UseVisualStyleBackColor = true;
			// 
			// _rdbtnTwoHead
			// 
			this._rdbtnTwoHead.AutoSize = true;
			this._rdbtnTwoHead.Checked = true;
			this._rdbtnTwoHead.Location = new System.Drawing.Point(104, 17);
			this._rdbtnTwoHead.Name = "_rdbtnTwoHead";
			this._rdbtnTwoHead.Size = new System.Drawing.Size(69, 16);
			this._rdbtnTwoHead.TabIndex = 1;
			this._rdbtnTwoHead.TabStop = true;
			this._rdbtnTwoHead.Text = "Two Head";
			this._rdbtnTwoHead.UseVisualStyleBackColor = true;
			// 
			// _rdbtnWide
			// 
			this._rdbtnWide.AutoSize = true;
			this._rdbtnWide.Location = new System.Drawing.Point(187, 17);
			this._rdbtnWide.Name = "_rdbtnWide";
			this._rdbtnWide.Size = new System.Drawing.Size(104, 16);
			this._rdbtnWide.TabIndex = 2;
			this._rdbtnWide.Text = "Two heads (wide)";
			this._rdbtnWide.UseVisualStyleBackColor = true;
			// 
			// _grpExport
			// 
			this._grpExport.Controls.Add(this._nudProfileNo);
			this._grpExport.Controls.Add(this._txtboxProfileFilePath);
			this._grpExport.Controls.Add(this._btnSaveMeasureData);
			this._grpExport.Controls.Add(this._btnSave);
			this._grpExport.Controls.Add(this._btnProfileFileSave);
			this._grpExport.Controls.Add(this.label2);
			this._grpExport.Controls.Add(this._lblSavePath);
			this._grpExport.Location = new System.Drawing.Point(12, 571);
			this._grpExport.Name = "_grpExport";
			this._grpExport.Size = new System.Drawing.Size(339, 92);
			this._grpExport.TabIndex = 4;
			this._grpExport.TabStop = false;
			this._grpExport.Text = "Save the results file";
			// 
			// _nudProfileNo
			// 
			this._nudProfileNo.Location = new System.Drawing.Point(170, 42);
			this._nudProfileNo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this._nudProfileNo.Name = "_nudProfileNo";
			this._nudProfileNo.Size = new System.Drawing.Size(43, 20);
			this._nudProfileNo.TabIndex = 4;
			// 
			// _txtboxProfileFilePath
			// 
			this._txtboxProfileFilePath.Location = new System.Drawing.Point(105, 18);
			this._txtboxProfileFilePath.Name = "_txtboxProfileFilePath";
			this._txtboxProfileFilePath.Size = new System.Drawing.Size(189, 20);
			this._txtboxProfileFilePath.TabIndex = 1;
			// 
			// _btnSaveMeasureData
			// 
			this._btnSaveMeasureData.Location = new System.Drawing.Point(193, 65);
			this._btnSaveMeasureData.Name = "_btnSaveMeasureData";
			this._btnSaveMeasureData.Size = new System.Drawing.Size(130, 23);
			this._btnSaveMeasureData.TabIndex = 6;
			this._btnSaveMeasureData.Text = "Save the measurement value";
			this._btnSaveMeasureData.UseVisualStyleBackColor = true;
			this._btnSaveMeasureData.Click += new System.EventHandler(this.btnSaveMeasureData_Click);
			// 
			// _btnSave
			// 
			this._btnSave.Location = new System.Drawing.Point(44, 65);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(132, 23);
			this._btnSave.TabIndex = 5;
			this._btnSave.Text = "Save the profile";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// _btnProfileFileSave
			// 
			this._btnProfileFileSave.Location = new System.Drawing.Point(300, 18);
			this._btnProfileFileSave.Name = "_btnProfileFileSave";
			this._btnProfileFileSave.Size = new System.Drawing.Size(25, 18);
			this._btnProfileFileSave.TabIndex = 2;
			this._btnProfileFileSave.Text = "...";
			this._btnProfileFileSave.UseVisualStyleBackColor = true;
			this._btnProfileFileSave.Click += new System.EventHandler(this.btnProfileFileSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Index of the profile to save";
			// 
			// _lblSavePath
			// 
			this._lblSavePath.AutoSize = true;
			this._lblSavePath.Location = new System.Drawing.Point(9, 22);
			this._lblSavePath.Name = "_lblSavePath";
			this._lblSavePath.Size = new System.Drawing.Size(78, 12);
			this._lblSavePath.TabIndex = 0;
			this._lblSavePath.Text = "Save destination";
			// 
			// _profileFileSave
			// 
			this._profileFileSave.Filter = "Profile (*.txt)|*.txt | all files (*.*)|*.*";
			// 
			// _timerHighSpeedReceive
			// 
			this._timerHighSpeedReceive.Interval = 500;
			this._timerHighSpeedReceive.Tick += new System.EventHandler(this._timerHighSpeedReceive_Tick);
			// 
			// _lblReceiveProfileCount0
			// 
			this._lblReceiveProfileCount0.AutoSize = true;
			this._lblReceiveProfileCount0.BackColor = System.Drawing.Color.Transparent;
			this._lblReceiveProfileCount0.Location = new System.Drawing.Point(3, 31);
			this._lblReceiveProfileCount0.Name = "_lblReceiveProfileCount0";
			this._lblReceiveProfileCount0.Size = new System.Drawing.Size(10, 12);
			this._lblReceiveProfileCount0.TabIndex = 1;
			this._lblReceiveProfileCount0.Text = "0";
			// 
			// _rdDevice0
			// 
			this._rdDevice0.AutoSize = true;
			this._rdDevice0.Checked = true;
			this._rdDevice0.Location = new System.Drawing.Point(8, 32);
			this._rdDevice0.Name = "_rdDevice0";
			this._rdDevice0.Size = new System.Drawing.Size(28, 16);
			this._rdDevice0.TabIndex = 2;
			this._rdDevice0.TabStop = true;
			this._rdDevice0.Tag = "0";
			this._rdDevice0.Text = "&0";
			this._rdDevice0.UseVisualStyleBackColor = true;
			this._rdDevice0.CheckedChanged += new System.EventHandler(this._rdDevice_CheckedChanged);
			// 
			// _rdDevice2
			// 
			this._rdDevice2.AutoSize = true;
			this._rdDevice2.Location = new System.Drawing.Point(8, 66);
			this._rdDevice2.Name = "_rdDevice2";
			this._rdDevice2.Size = new System.Drawing.Size(28, 16);
			this._rdDevice2.TabIndex = 6;
			this._rdDevice2.Tag = "2";
			this._rdDevice2.Text = "&2";
			this._rdDevice2.UseVisualStyleBackColor = true;
			this._rdDevice2.CheckedChanged += new System.EventHandler(this._rdDevice_CheckedChanged);
			// 
			// _rdDevice1
			// 
			this._rdDevice1.AutoSize = true;
			this._rdDevice1.Location = new System.Drawing.Point(8, 49);
			this._rdDevice1.Name = "_rdDevice1";
			this._rdDevice1.Size = new System.Drawing.Size(28, 16);
			this._rdDevice1.TabIndex = 4;
			this._rdDevice1.Tag = "1";
			this._rdDevice1.Text = "&1";
			this._rdDevice1.UseVisualStyleBackColor = true;
			this._rdDevice1.CheckedChanged += new System.EventHandler(this._rdDevice_CheckedChanged);
			// 
			// _pnlDeviceId
			// 
			this._pnlDeviceId.BackColor = System.Drawing.Color.DarkGray;
			this._pnlDeviceId.Controls.Add(this._lblDeviceStatus5);
			this._pnlDeviceId.Controls.Add(this._lblDeviceStatus4);
			this._pnlDeviceId.Controls.Add(this.radioButton2);
			this._pnlDeviceId.Controls.Add(this.radioButton1);
			this._pnlDeviceId.Controls.Add(this.panel1);
			this._pnlDeviceId.Controls.Add(this.label5);
			this._pnlDeviceId.Controls.Add(this.label4);
			this._pnlDeviceId.Controls.Add(this._lblDeviceStatus3);
			this._pnlDeviceId.Controls.Add(this._lblDeviceStatus2);
			this._pnlDeviceId.Controls.Add(this._lblDeviceStatus1);
			this._pnlDeviceId.Controls.Add(this._lblDeviceStatus0);
			this._pnlDeviceId.Controls.Add(this._rdDevice3);
			this._pnlDeviceId.Controls.Add(this._rdDevice2);
			this._pnlDeviceId.Controls.Add(this._rdDevice1);
			this._pnlDeviceId.Controls.Add(this._rdDevice0);
			this._pnlDeviceId.Location = new System.Drawing.Point(12, 30);
			this._pnlDeviceId.Name = "_pnlDeviceId";
			this._pnlDeviceId.Size = new System.Drawing.Size(334, 140);
			this._pnlDeviceId.TabIndex = 1;
			this._pnlDeviceId.Tag = "";
			// 
			// _lblDeviceStatus5
			// 
			this._lblDeviceStatus5.AutoSize = true;
			this._lblDeviceStatus5.Location = new System.Drawing.Point(55, 118);
			this._lblDeviceStatus5.Name = "_lblDeviceStatus5";
			this._lblDeviceStatus5.Size = new System.Drawing.Size(65, 12);
			this._lblDeviceStatus5.TabIndex = 65;
			this._lblDeviceStatus5.Text = "Unconnected";
			// 
			// _lblDeviceStatus4
			// 
			this._lblDeviceStatus4.AutoSize = true;
			this._lblDeviceStatus4.Location = new System.Drawing.Point(55, 102);
			this._lblDeviceStatus4.Name = "_lblDeviceStatus4";
			this._lblDeviceStatus4.Size = new System.Drawing.Size(65, 12);
			this._lblDeviceStatus4.TabIndex = 64;
			this._lblDeviceStatus4.Text = "Unconnected";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(8, 114);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(28, 16);
			this.radioButton2.TabIndex = 63;
			this.radioButton2.Tag = "5";
			this.radioButton2.Text = "&5";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this._rdDevice_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 97);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(28, 16);
			this.radioButton1.TabIndex = 62;
			this.radioButton1.Tag = "4";
			this.radioButton1.Text = "&4";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this._rdDevice_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this._lblReceiveProfileCount5);
			this.panel1.Controls.Add(this._lblReceiveProfileCount4);
			this.panel1.Controls.Add(this._lblReceiveProfileCount3);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this._lblReceiveProfileCount0);
			this.panel1.Controls.Add(this._lblReceiveProfileCount1);
			this.panel1.Controls.Add(this._lblReceiveProfileCount2);
			this.panel1.Location = new System.Drawing.Point(205, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(121, 135);
			this.panel1.TabIndex = 59;
			// 
			// _lblReceiveProfileCount5
			// 
			this._lblReceiveProfileCount5.AutoSize = true;
			this._lblReceiveProfileCount5.BackColor = System.Drawing.Color.Transparent;
			this._lblReceiveProfileCount5.Location = new System.Drawing.Point(3, 114);
			this._lblReceiveProfileCount5.Name = "_lblReceiveProfileCount5";
			this._lblReceiveProfileCount5.Size = new System.Drawing.Size(10, 12);
			this._lblReceiveProfileCount5.TabIndex = 6;
			this._lblReceiveProfileCount5.Text = "0";
			// 
			// _lblReceiveProfileCount4
			// 
			this._lblReceiveProfileCount4.AutoSize = true;
			this._lblReceiveProfileCount4.BackColor = System.Drawing.Color.Transparent;
			this._lblReceiveProfileCount4.Location = new System.Drawing.Point(3, 97);
			this._lblReceiveProfileCount4.Name = "_lblReceiveProfileCount4";
			this._lblReceiveProfileCount4.Size = new System.Drawing.Size(10, 12);
			this._lblReceiveProfileCount4.TabIndex = 5;
			this._lblReceiveProfileCount4.Text = "0";
			// 
			// _lblReceiveProfileCount3
			// 
			this._lblReceiveProfileCount3.AutoSize = true;
			this._lblReceiveProfileCount3.BackColor = System.Drawing.Color.Transparent;
			this._lblReceiveProfileCount3.Location = new System.Drawing.Point(3, 79);
			this._lblReceiveProfileCount3.Name = "_lblReceiveProfileCount3";
			this._lblReceiveProfileCount3.Size = new System.Drawing.Size(10, 12);
			this._lblReceiveProfileCount3.TabIndex = 4;
			this._lblReceiveProfileCount3.Text = "0";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 30);
			this.label3.TabIndex = 0;
			this.label3.Text = "Number of \r\nreceived profiles";
			// 
			// _lblReceiveProfileCount1
			// 
			this._lblReceiveProfileCount1.AutoSize = true;
			this._lblReceiveProfileCount1.BackColor = System.Drawing.Color.Transparent;
			this._lblReceiveProfileCount1.Location = new System.Drawing.Point(3, 48);
			this._lblReceiveProfileCount1.Name = "_lblReceiveProfileCount1";
			this._lblReceiveProfileCount1.Size = new System.Drawing.Size(10, 12);
			this._lblReceiveProfileCount1.TabIndex = 2;
			this._lblReceiveProfileCount1.Text = "0";
			// 
			// _lblReceiveProfileCount2
			// 
			this._lblReceiveProfileCount2.AutoSize = true;
			this._lblReceiveProfileCount2.BackColor = System.Drawing.Color.Transparent;
			this._lblReceiveProfileCount2.Location = new System.Drawing.Point(3, 65);
			this._lblReceiveProfileCount2.Name = "_lblReceiveProfileCount2";
			this._lblReceiveProfileCount2.Size = new System.Drawing.Size(10, 12);
			this._lblReceiveProfileCount2.TabIndex = 3;
			this._lblReceiveProfileCount2.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(42, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "State (USB / IP address)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "ID";
			// 
			// _lblDeviceStatus3
			// 
			this._lblDeviceStatus3.AutoSize = true;
			this._lblDeviceStatus3.Location = new System.Drawing.Point(55, 84);
			this._lblDeviceStatus3.Name = "_lblDeviceStatus3";
			this._lblDeviceStatus3.Size = new System.Drawing.Size(65, 12);
			this._lblDeviceStatus3.TabIndex = 61;
			this._lblDeviceStatus3.Text = "Unconnected";
			// 
			// _lblDeviceStatus2
			// 
			this._lblDeviceStatus2.AutoSize = true;
			this._lblDeviceStatus2.Location = new System.Drawing.Point(55, 66);
			this._lblDeviceStatus2.Name = "_lblDeviceStatus2";
			this._lblDeviceStatus2.Size = new System.Drawing.Size(65, 12);
			this._lblDeviceStatus2.TabIndex = 7;
			this._lblDeviceStatus2.Text = "Unconnected";
			// 
			// _lblDeviceStatus1
			// 
			this._lblDeviceStatus1.AutoSize = true;
			this._lblDeviceStatus1.Location = new System.Drawing.Point(55, 51);
			this._lblDeviceStatus1.Name = "_lblDeviceStatus1";
			this._lblDeviceStatus1.Size = new System.Drawing.Size(65, 12);
			this._lblDeviceStatus1.TabIndex = 5;
			this._lblDeviceStatus1.Text = "Unconnected";
			// 
			// _lblDeviceStatus0
			// 
			this._lblDeviceStatus0.AutoSize = true;
			this._lblDeviceStatus0.Location = new System.Drawing.Point(55, 35);
			this._lblDeviceStatus0.Name = "_lblDeviceStatus0";
			this._lblDeviceStatus0.Size = new System.Drawing.Size(65, 12);
			this._lblDeviceStatus0.TabIndex = 3;
			this._lblDeviceStatus0.Text = "Unconnected";
			// 
			// _rdDevice3
			// 
			this._rdDevice3.AutoSize = true;
			this._rdDevice3.Location = new System.Drawing.Point(8, 80);
			this._rdDevice3.Name = "_rdDevice3";
			this._rdDevice3.Size = new System.Drawing.Size(28, 16);
			this._rdDevice3.TabIndex = 60;
			this._rdDevice3.Tag = "3";
			this._rdDevice3.Text = "&3";
			this._rdDevice3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this._rdDevice3.UseVisualStyleBackColor = true;
			this._rdDevice3.CheckedChanged += new System.EventHandler(this._rdDevice_CheckedChanged);
			// 
			// _chkOnlyProfileCount
			// 
			this._chkOnlyProfileCount.AutoSize = true;
			this._chkOnlyProfileCount.Checked = true;
			this._chkOnlyProfileCount.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkOnlyProfileCount.Location = new System.Drawing.Point(122, 37);
			this._chkOnlyProfileCount.Name = "_chkOnlyProfileCount";
			this._chkOnlyProfileCount.Size = new System.Drawing.Size(180, 16);
			this._chkOnlyProfileCount.TabIndex = 0;
			this._chkOnlyProfileCount.Text = "Count only the number of profiles.";
			this._chkOnlyProfileCount.UseVisualStyleBackColor = true;
			// 
			// _chkStartTimer
			// 
			this._chkStartTimer.AutoSize = true;
			this._chkStartTimer.Location = new System.Drawing.Point(122, 18);
			this._chkStartTimer.Name = "_chkStartTimer";
			this._chkStartTimer.Size = new System.Drawing.Size(87, 16);
			this._chkStartTimer.TabIndex = 1;
			this._chkStartTimer.Text = "Start the timer";
			this._chkStartTimer.UseVisualStyleBackColor = true;
			this._chkStartTimer.CheckedChanged += new System.EventHandler(this._chkStartTimer_CheckedChanged);
			// 
			// _numInterval
			// 
			this._numInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this._numInterval.Location = new System.Drawing.Point(242, 18);
			this._numInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this._numInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this._numInterval.Name = "_numInterval";
			this._numInterval.Size = new System.Drawing.Size(64, 20);
			this._numInterval.TabIndex = 2;
			this._numInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// _tabControl
			// 
			this._tabControl.Controls.Add(this._tabPage1);
			this._tabControl.Controls.Add(this._tabPage2);
			this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tabControl.Location = new System.Drawing.Point(0, 0);
			this._tabControl.Name = "_tabControl";
			this._tabControl.SelectedIndex = 0;
			this._tabControl.Size = new System.Drawing.Size(994, 713);
			this._tabControl.TabIndex = 0;
			// 
			// _tabPage1
			// 
			this._tabPage1.BackColor = System.Drawing.Color.Linen;
			this._tabPage1.Controls.Add(this._groupBox);
			this._tabPage1.Controls.Add(this._grpCommand);
			this._tabPage1.Location = new System.Drawing.Point(4, 21);
			this._tabPage1.Name = "_tabPage1";
			this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this._tabPage1.Size = new System.Drawing.Size(986, 688);
			this._tabPage1.TabIndex = 0;
			this._tabPage1.Text = "[DLL functions] Simple function sample";
			// 
			// _groupBox
			// 
			this._groupBox.Controls.Add(this._lblConectedDevice);
			this._groupBox.Controls.Add(this.groupBox8);
			this._groupBox.Controls.Add(this._grpLog);
			this._groupBox.Controls.Add(this._grpExport);
			this._groupBox.Controls.Add(this._grpBufferSize);
			this._groupBox.Controls.Add(this._pnlDeviceId);
			this._groupBox.Location = new System.Drawing.Point(627, 5);
			this._groupBox.Name = "_groupBox";
			this._groupBox.Size = new System.Drawing.Size(351, 674);
			this._groupBox.TabIndex = 1;
			this._groupBox.TabStop = false;
			this._groupBox.Text = "Setting / Result";
			// 
			// _lblConectedDevice
			// 
			this._lblConectedDevice.AutoSize = true;
			this._lblConectedDevice.Location = new System.Drawing.Point(10, 14);
			this._lblConectedDevice.Name = "_lblConectedDevice";
			this._lblConectedDevice.Size = new System.Drawing.Size(282, 12);
			this._lblConectedDevice.TabIndex = 5;
			this._lblConectedDevice.Text = "Controller connection status (Up to 6 units can be connected)";
			// 
			// groupBox8
			// 
			this.groupBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox8.Controls.Add(this._chkOnlyProfileCount);
			this.groupBox8.Controls.Add(this._numInterval);
			this.groupBox8.Controls.Add(this._chkStartTimer);
			this.groupBox8.Location = new System.Drawing.Point(12, 507);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(339, 59);
			this.groupBox8.TabIndex = 2;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Profile-related settings ( set and used during high-speed communication)";
			// 
			// _tabPage2
			// 
			this._tabPage2.BackColor = System.Drawing.Color.AliceBlue;
			this._tabPage2.Controls.Add(this._grpProgram);
			this._tabPage2.Controls.Add(this._grpHighSpeed);
			this._tabPage2.Controls.Add(this._grpGetData);
			this._tabPage2.Controls.Add(this._grpBaseOperation);
			this._tabPage2.Location = new System.Drawing.Point(4, 21);
			this._tabPage2.Name = "_tabPage2";
			this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this._tabPage2.Size = new System.Drawing.Size(986, 688);
			this._tabPage2.TabIndex = 1;
			this._tabPage2.Text = "[DLL functions] Combination sample";
			// 
			// _grpProgram
			// 
			this._grpProgram.Controls.Add(this._btnUploadProgram);
			this._grpProgram.Controls.Add(this._btnDownloadProgram);
			this._grpProgram.Controls.Add(this._btnReferenceProgramFilePath);
			this._grpProgram.Controls.Add(this._txtProgramFilePath);
			this._grpProgram.Controls.Add(this._lblSelectProgram);
			this._grpProgram.Controls.Add(this._cbxSelectProgram);
			this._grpProgram.Location = new System.Drawing.Point(28, 194);
			this._grpProgram.Name = "_grpProgram";
			this._grpProgram.Size = new System.Drawing.Size(441, 114);
			this._grpProgram.TabIndex = 1;
			this._grpProgram.TabStop = false;
			this._grpProgram.Text = "Reading or writing settings for each program number";
			// 
			// _btnUploadProgram
			// 
			this._btnUploadProgram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnUploadProgram.Location = new System.Drawing.Point(19, 78);
			this._btnUploadProgram.Name = "_btnUploadProgram";
			this._btnUploadProgram.Size = new System.Drawing.Size(189, 23);
			this._btnUploadProgram.TabIndex = 4;
			this._btnUploadProgram.Text = "Sending settings (PC -> LJ)";
			this._btnUploadProgram.UseVisualStyleBackColor = true;
			this._btnUploadProgram.Click += new System.EventHandler(this.btnSetSettingEx_Click);
			// 
			// _btnDownloadProgram
			// 
			this._btnDownloadProgram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnDownloadProgram.Location = new System.Drawing.Point(235, 78);
			this._btnDownloadProgram.Name = "_btnDownloadProgram";
			this._btnDownloadProgram.Size = new System.Drawing.Size(189, 23);
			this._btnDownloadProgram.TabIndex = 5;
			this._btnDownloadProgram.Text = "Receiving settings (LJ -> PC)";
			this._btnDownloadProgram.UseVisualStyleBackColor = true;
			this._btnDownloadProgram.Click += new System.EventHandler(this.btnGetSettingEx_Click);
			// 
			// _btnReferenceProgramFilePath
			// 
			this._btnReferenceProgramFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnReferenceProgramFilePath.Location = new System.Drawing.Point(373, 50);
			this._btnReferenceProgramFilePath.Name = "_btnReferenceProgramFilePath";
			this._btnReferenceProgramFilePath.Size = new System.Drawing.Size(51, 23);
			this._btnReferenceProgramFilePath.TabIndex = 3;
			this._btnReferenceProgramFilePath.Text = "...";
			this._btnReferenceProgramFilePath.UseVisualStyleBackColor = true;
			this._btnReferenceProgramFilePath.Click += new System.EventHandler(this._btnReferenceProgramFilePathEx_Click);
			// 
			// _txtProgramFilePath
			// 
			this._txtProgramFilePath.Location = new System.Drawing.Point(19, 53);
			this._txtProgramFilePath.Name = "_txtProgramFilePath";
			this._txtProgramFilePath.Size = new System.Drawing.Size(347, 20);
			this._txtProgramFilePath.TabIndex = 2;
			// 
			// _lblSelectProgram
			// 
			this._lblSelectProgram.AutoSize = true;
			this._lblSelectProgram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblSelectProgram.Location = new System.Drawing.Point(17, 30);
			this._lblSelectProgram.Name = "_lblSelectProgram";
			this._lblSelectProgram.Size = new System.Drawing.Size(90, 12);
			this._lblSelectProgram.TabIndex = 0;
			this._lblSelectProgram.Text = "Select the program";
			// 
			// _cbxSelectProgram
			// 
			this._cbxSelectProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbxSelectProgram.FormattingEnabled = true;
			this._cbxSelectProgram.Items.AddRange(new object[] {
            "Environment",
            "Common",
            "Program0",
            "Program1",
            "Program2",
            "Program3",
            "Program4",
            "Program5",
            "Program6",
            "Program7",
            "Program8",
            "Program9",
            "Program10",
            "Program11",
            "Program12",
            "Program13",
            "Program14",
            "Program15"});
			this._cbxSelectProgram.Location = new System.Drawing.Point(130, 29);
			this._cbxSelectProgram.Name = "_cbxSelectProgram";
			this._cbxSelectProgram.Size = new System.Drawing.Size(101, 20);
			this._cbxSelectProgram.TabIndex = 1;
			// 
			// _grpHighSpeed
			// 
			this._grpHighSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._grpHighSpeed.Controls.Add(this._txtCallbackFrequency);
			this._grpHighSpeed.Controls.Add(this._txtStartProfileNo);
			this._grpHighSpeed.Controls.Add(this._lblReceiveProfileCount);
			this._grpHighSpeed.Controls.Add(this._lblCallbackFrequency);
			this._grpHighSpeed.Controls.Add(this._btnTerminateHighSpeedCommunication);
			this._grpHighSpeed.Controls.Add(this._lblHighSpeedStartNo);
			this._grpHighSpeed.Controls.Add(this._lblReceiveCount);
			this._grpHighSpeed.Controls.Add(this._btnBeginHighSpeedDataCommunication);
			this._grpHighSpeed.Location = new System.Drawing.Point(485, 241);
			this._grpHighSpeed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpHighSpeed.Name = "_grpHighSpeed";
			this._grpHighSpeed.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpHighSpeed.Size = new System.Drawing.Size(440, 120);
			this._grpHighSpeed.TabIndex = 3;
			this._grpHighSpeed.TabStop = false;
			this._grpHighSpeed.Text = "High-speed data communication";
			// 
			// _txtCallbackFrequency
			// 
			this._txtCallbackFrequency.Location = new System.Drawing.Point(338, 50);
			this._txtCallbackFrequency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtCallbackFrequency.Name = "_txtCallbackFrequency";
			this._txtCallbackFrequency.Size = new System.Drawing.Size(45, 20);
			this._txtCallbackFrequency.TabIndex = 4;
			this._txtCallbackFrequency.Text = "10";
			// 
			// _txtStartProfileNo
			// 
			this._txtStartProfileNo.Location = new System.Drawing.Point(338, 23);
			this._txtStartProfileNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtStartProfileNo.Name = "_txtStartProfileNo";
			this._txtStartProfileNo.Size = new System.Drawing.Size(45, 20);
			this._txtStartProfileNo.TabIndex = 2;
			this._txtStartProfileNo.Text = "2";
			// 
			// _lblReceiveProfileCount
			// 
			this._lblReceiveProfileCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._lblReceiveProfileCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblReceiveProfileCount.Location = new System.Drawing.Point(305, 79);
			this._lblReceiveProfileCount.Name = "_lblReceiveProfileCount";
			this._lblReceiveProfileCount.Size = new System.Drawing.Size(78, 17);
			this._lblReceiveProfileCount.TabIndex = 6;
			this._lblReceiveProfileCount.Text = "123456789";
			this._lblReceiveProfileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblCallbackFrequency
			// 
			this._lblCallbackFrequency.AutoSize = true;
			this._lblCallbackFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblCallbackFrequency.Location = new System.Drawing.Point(107, 47);
			this._lblCallbackFrequency.Name = "_lblCallbackFrequency";
			this._lblCallbackFrequency.Size = new System.Drawing.Size(149, 12);
			this._lblCallbackFrequency.TabIndex = 3;
			this._lblCallbackFrequency.Text = "Callback function call frequency";
			// 
			// _btnTerminateHighSpeedCommunication
			// 
			this._btnTerminateHighSpeedCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnTerminateHighSpeedCommunication.Location = new System.Drawing.Point(6, 50);
			this._btnTerminateHighSpeedCommunication.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnTerminateHighSpeedCommunication.Name = "_btnTerminateHighSpeedCommunication";
			this._btnTerminateHighSpeedCommunication.Size = new System.Drawing.Size(75, 23);
			this._btnTerminateHighSpeedCommunication.TabIndex = 7;
			this._btnTerminateHighSpeedCommunication.Text = "Finalize ";
			this._btnTerminateHighSpeedCommunication.UseVisualStyleBackColor = true;
			this._btnTerminateHighSpeedCommunication.Click += new System.EventHandler(this.btnEndHighSpeedDataCommunicationEx_Click);
			// 
			// _lblHighSpeedStartNo
			// 
			this._lblHighSpeedStartNo.AutoSize = true;
			this._lblHighSpeedStartNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblHighSpeedStartNo.Location = new System.Drawing.Point(107, 23);
			this._lblHighSpeedStartNo.Name = "_lblHighSpeedStartNo";
			this._lblHighSpeedStartNo.Size = new System.Drawing.Size(88, 12);
			this._lblHighSpeedStartNo.TabIndex = 1;
			this._lblHighSpeedStartNo.Text = "Send start position";
			// 
			// _lblReceiveCount
			// 
			this._lblReceiveCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblReceiveCount.Location = new System.Drawing.Point(107, 71);
			this._lblReceiveCount.Name = "_lblReceiveCount";
			this._lblReceiveCount.Size = new System.Drawing.Size(288, 25);
			this._lblReceiveCount.TabIndex = 5;
			this._lblReceiveCount.Text = "Number of received \r\nhigh-speed communication profiles";
			// 
			// _btnBeginHighSpeedDataCommunication
			// 
			this._btnBeginHighSpeedDataCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnBeginHighSpeedDataCommunication.Location = new System.Drawing.Point(6, 18);
			this._btnBeginHighSpeedDataCommunication.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnBeginHighSpeedDataCommunication.Name = "_btnBeginHighSpeedDataCommunication";
			this._btnBeginHighSpeedDataCommunication.Size = new System.Drawing.Size(75, 23);
			this._btnBeginHighSpeedDataCommunication.TabIndex = 0;
			this._btnBeginHighSpeedDataCommunication.Text = "Start";
			this._btnBeginHighSpeedDataCommunication.UseVisualStyleBackColor = true;
			this._btnBeginHighSpeedDataCommunication.Click += new System.EventHandler(this.btnBeginHighSpeedCommunicationEx_Click);
			// 
			// _grpGetData
			// 
			this._grpGetData.Controls.Add(this._txtMeasureData);
			this._grpGetData.Controls.Add(this._grpGetProfile);
			this._grpGetData.Controls.Add(this._btnGetLatestMeasureValue);
			this._grpGetData.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this._grpGetData.Location = new System.Drawing.Point(485, 6);
			this._grpGetData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpGetData.Name = "_grpGetData";
			this._grpGetData.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpGetData.Size = new System.Drawing.Size(441, 223);
			this._grpGetData.TabIndex = 2;
			this._grpGetData.TabStop = false;
			this._grpGetData.Text = "Get measurement results";
			// 
			// _txtMeasureData
			// 
			this._txtMeasureData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtMeasureData.Location = new System.Drawing.Point(127, 19);
			this._txtMeasureData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtMeasureData.Multiline = true;
			this._txtMeasureData.Name = "_txtMeasureData";
			this._txtMeasureData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._txtMeasureData.Size = new System.Drawing.Size(307, 82);
			this._txtMeasureData.TabIndex = 1;
			// 
			// _grpGetProfile
			// 
			this._grpGetProfile.Controls.Add(this._btnGetProfileAdvanceData);
			this._grpGetProfile.Controls.Add(this._btnReferenceSavePath);
			this._grpGetProfile.Controls.Add(this._btnGetBatchProfileDataAdvance);
			this._grpGetProfile.Controls.Add(this._btnGetBatchProfileData);
			this._grpGetProfile.Controls.Add(this._btnGetProfileData);
			this._grpGetProfile.Controls.Add(this._txtSavePath);
			this._grpGetProfile.Controls.Add(this.label1);
			this._grpGetProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._grpGetProfile.Location = new System.Drawing.Point(6, 108);
			this._grpGetProfile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpGetProfile.Name = "_grpGetProfile";
			this._grpGetProfile.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpGetProfile.Size = new System.Drawing.Size(427, 111);
			this._grpGetProfile.TabIndex = 2;
			this._grpGetProfile.TabStop = false;
			this._grpGetProfile.Text = "Get profiles";
			// 
			// _btnGetProfileAdvanceData
			// 
			this._btnGetProfileAdvanceData.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this._btnGetProfileAdvanceData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnGetProfileAdvanceData.Location = new System.Drawing.Point(6, 78);
			this._btnGetProfileAdvanceData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnGetProfileAdvanceData.Name = "_btnGetProfileAdvanceData";
			this._btnGetProfileAdvanceData.Size = new System.Drawing.Size(201, 23);
			this._btnGetProfileAdvanceData.TabIndex = 5;
			this._btnGetProfileAdvanceData.Text = "Get advanced mode profiles";
			this._btnGetProfileAdvanceData.UseVisualStyleBackColor = true;
			this._btnGetProfileAdvanceData.Click += new System.EventHandler(this.btnGetProfileAdvanceEx_Click);
			// 
			// _btnReferenceSavePath
			// 
			this._btnReferenceSavePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnReferenceSavePath.Location = new System.Drawing.Point(391, 19);
			this._btnReferenceSavePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnReferenceSavePath.Name = "_btnReferenceSavePath";
			this._btnReferenceSavePath.Size = new System.Drawing.Size(30, 23);
			this._btnReferenceSavePath.TabIndex = 2;
			this._btnReferenceSavePath.Text = "...";
			this._btnReferenceSavePath.UseVisualStyleBackColor = true;
			this._btnReferenceSavePath.Click += new System.EventHandler(this.btnReferenceSavePathEx_Click);
			// 
			// _btnGetBatchProfileDataAdvance
			// 
			this._btnGetBatchProfileDataAdvance.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this._btnGetBatchProfileDataAdvance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnGetBatchProfileDataAdvance.Location = new System.Drawing.Point(219, 78);
			this._btnGetBatchProfileDataAdvance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnGetBatchProfileDataAdvance.Name = "_btnGetBatchProfileDataAdvance";
			this._btnGetBatchProfileDataAdvance.Size = new System.Drawing.Size(201, 23);
			this._btnGetBatchProfileDataAdvance.TabIndex = 6;
			this._btnGetBatchProfileDataAdvance.Text = "Get advanced mode batch profiles";
			this._btnGetBatchProfileDataAdvance.UseVisualStyleBackColor = true;
			this._btnGetBatchProfileDataAdvance.Click += new System.EventHandler(this.btnGetBatchProfileAdvanceEx_Click);
			// 
			// _btnGetBatchProfileData
			// 
			this._btnGetBatchProfileData.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this._btnGetBatchProfileData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnGetBatchProfileData.Location = new System.Drawing.Point(219, 48);
			this._btnGetBatchProfileData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnGetBatchProfileData.Name = "_btnGetBatchProfileData";
			this._btnGetBatchProfileData.Size = new System.Drawing.Size(201, 23);
			this._btnGetBatchProfileData.TabIndex = 4;
			this._btnGetBatchProfileData.Text = "Get high-speed mode batch profiles";
			this._btnGetBatchProfileData.UseVisualStyleBackColor = true;
			this._btnGetBatchProfileData.Click += new System.EventHandler(this.btnGetBatchProfileEx_Click);
			// 
			// _btnGetProfileData
			// 
			this._btnGetProfileData.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this._btnGetProfileData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnGetProfileData.Location = new System.Drawing.Point(6, 48);
			this._btnGetProfileData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnGetProfileData.Name = "_btnGetProfileData";
			this._btnGetProfileData.Size = new System.Drawing.Size(201, 23);
			this._btnGetProfileData.TabIndex = 3;
			this._btnGetProfileData.Text = "Get high-speed mode profiles";
			this._btnGetProfileData.UseVisualStyleBackColor = true;
			this._btnGetProfileData.Click += new System.EventHandler(this.btnGetProfileEx_Click);
			// 
			// _txtSavePath
			// 
			this._txtSavePath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtSavePath.Location = new System.Drawing.Point(103, 23);
			this._txtSavePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtSavePath.Name = "_txtSavePath";
			this._txtSavePath.Size = new System.Drawing.Size(283, 21);
			this._txtSavePath.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Save path";
			// 
			// _btnGetLatestMeasureValue
			// 
			this._btnGetLatestMeasureValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btnGetLatestMeasureValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnGetLatestMeasureValue.Location = new System.Drawing.Point(6, 18);
			this._btnGetLatestMeasureValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnGetLatestMeasureValue.Name = "_btnGetLatestMeasureValue";
			this._btnGetLatestMeasureValue.Size = new System.Drawing.Size(115, 23);
			this._btnGetLatestMeasureValue.TabIndex = 0;
			this._btnGetLatestMeasureValue.Text = "Get Current values";
			this._btnGetLatestMeasureValue.UseVisualStyleBackColor = true;
			this._btnGetLatestMeasureValue.Click += new System.EventHandler(this.btnGetMeasureValueEx_Click);
			// 
			// _grpBaseOperation
			// 
			this._grpBaseOperation.Controls.Add(this._pnlCommunicationDevice);
			this._grpBaseOperation.Controls.Add(this._btnTerminateCommunication);
			this._grpBaseOperation.Controls.Add(this._btnEstablishCommunication);
			this._grpBaseOperation.Location = new System.Drawing.Point(28, 6);
			this._grpBaseOperation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpBaseOperation.Name = "_grpBaseOperation";
			this._grpBaseOperation.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpBaseOperation.Size = new System.Drawing.Size(441, 179);
			this._grpBaseOperation.TabIndex = 0;
			this._grpBaseOperation.TabStop = false;
			this._grpBaseOperation.Text = "Establish/disconnect the communication path with the controller";
			// 
			// _pnlCommunicationDevice
			// 
			this._pnlCommunicationDevice.Controls.Add(this._rdUsb);
			this._pnlCommunicationDevice.Controls.Add(this._rdEthernet);
			this._pnlCommunicationDevice.Controls.Add(this._grpEthernetSetting);
			this._pnlCommunicationDevice.Location = new System.Drawing.Point(6, 49);
			this._pnlCommunicationDevice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._pnlCommunicationDevice.Name = "_pnlCommunicationDevice";
			this._pnlCommunicationDevice.Size = new System.Drawing.Size(418, 120);
			this._pnlCommunicationDevice.TabIndex = 1;
			// 
			// _rdUsb
			// 
			this._rdUsb.AutoSize = true;
			this._rdUsb.Checked = true;
			this._rdUsb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._rdUsb.Location = new System.Drawing.Point(3, 5);
			this._rdUsb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._rdUsb.Name = "_rdUsb";
			this._rdUsb.Size = new System.Drawing.Size(42, 16);
			this._rdUsb.TabIndex = 0;
			this._rdUsb.TabStop = true;
			this._rdUsb.Text = "USB";
			this._rdUsb.UseVisualStyleBackColor = true;
			// 
			// _rdEthernet
			// 
			this._rdEthernet.AutoSize = true;
			this._rdEthernet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._rdEthernet.Location = new System.Drawing.Point(3, 24);
			this._rdEthernet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._rdEthernet.Name = "_rdEthernet";
			this._rdEthernet.Size = new System.Drawing.Size(61, 16);
			this._rdEthernet.TabIndex = 1;
			this._rdEthernet.Text = "Ethernet";
			this._rdEthernet.UseVisualStyleBackColor = true;
			this._rdEthernet.CheckedChanged += new System.EventHandler(this._rdEthernet_CheckedChanged);
			// 
			// _grpEthernetSetting
			// 
			this._grpEthernetSetting.Controls.Add(this._txtIpFirstSegment);
			this._grpEthernetSetting.Controls.Add(this._txtIpFourthSegment);
			this._grpEthernetSetting.Controls.Add(this._txtIpSecondSegment);
			this._grpEthernetSetting.Controls.Add(this._lblHighSpeedPort);
			this._grpEthernetSetting.Controls.Add(this._txtIpThirdSegment);
			this._grpEthernetSetting.Controls.Add(this._lblIpSeparator3);
			this._grpEthernetSetting.Controls.Add(this._lblIpSeparator2);
			this._grpEthernetSetting.Controls.Add(this._txtHighSpeedPort);
			this._grpEthernetSetting.Controls.Add(this._lblIpSeparator1);
			this._grpEthernetSetting.Controls.Add(this._txtCommandPort);
			this._grpEthernetSetting.Controls.Add(this._lblIpAddress);
			this._grpEthernetSetting.Controls.Add(this._lblCommandPort);
			this._grpEthernetSetting.Enabled = false;
			this._grpEthernetSetting.Location = new System.Drawing.Point(23, 30);
			this._grpEthernetSetting.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpEthernetSetting.Name = "_grpEthernetSetting";
			this._grpEthernetSetting.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._grpEthernetSetting.Size = new System.Drawing.Size(374, 84);
			this._grpEthernetSetting.TabIndex = 1;
			this._grpEthernetSetting.TabStop = false;
			// 
			// _txtIpFirstSegment
			// 
			this._txtIpFirstSegment.Location = new System.Drawing.Point(229, 11);
			this._txtIpFirstSegment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtIpFirstSegment.Name = "_txtIpFirstSegment";
			this._txtIpFirstSegment.Size = new System.Drawing.Size(25, 20);
			this._txtIpFirstSegment.TabIndex = 1;
			this._txtIpFirstSegment.Text = "192";
			// 
			// _txtIpFourthSegment
			// 
			this._txtIpFourthSegment.Location = new System.Drawing.Point(328, 11);
			this._txtIpFourthSegment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtIpFourthSegment.Name = "_txtIpFourthSegment";
			this._txtIpFourthSegment.Size = new System.Drawing.Size(25, 20);
			this._txtIpFourthSegment.TabIndex = 3;
			this._txtIpFourthSegment.Text = "1";
			// 
			// _txtIpSecondSegment
			// 
			this._txtIpSecondSegment.Location = new System.Drawing.Point(262, 11);
			this._txtIpSecondSegment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtIpSecondSegment.Name = "_txtIpSecondSegment";
			this._txtIpSecondSegment.Size = new System.Drawing.Size(25, 20);
			this._txtIpSecondSegment.TabIndex = 2;
			this._txtIpSecondSegment.Text = "168";
			// 
			// _lblHighSpeedPort
			// 
			this._lblHighSpeedPort.AutoSize = true;
			this._lblHighSpeedPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblHighSpeedPort.Location = new System.Drawing.Point(15, 60);
			this._lblHighSpeedPort.Name = "_lblHighSpeedPort";
			this._lblHighSpeedPort.Size = new System.Drawing.Size(216, 12);
			this._lblHighSpeedPort.TabIndex = 9;
			this._lblHighSpeedPort.Text = "TCP port number (high-speed communication)";
			// 
			// _txtIpThirdSegment
			// 
			this._txtIpThirdSegment.Location = new System.Drawing.Point(295, 11);
			this._txtIpThirdSegment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtIpThirdSegment.Name = "_txtIpThirdSegment";
			this._txtIpThirdSegment.Size = new System.Drawing.Size(25, 20);
			this._txtIpThirdSegment.TabIndex = 2;
			this._txtIpThirdSegment.Text = "0";
			// 
			// _lblIpSeparator3
			// 
			this._lblIpSeparator3.AutoSize = true;
			this._lblIpSeparator3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblIpSeparator3.Location = new System.Drawing.Point(320, 18);
			this._lblIpSeparator3.Name = "_lblIpSeparator3";
			this._lblIpSeparator3.Size = new System.Drawing.Size(8, 12);
			this._lblIpSeparator3.TabIndex = 6;
			this._lblIpSeparator3.Text = ".";
			// 
			// _lblIpSeparator2
			// 
			this._lblIpSeparator2.AutoSize = true;
			this._lblIpSeparator2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblIpSeparator2.Location = new System.Drawing.Point(288, 18);
			this._lblIpSeparator2.Name = "_lblIpSeparator2";
			this._lblIpSeparator2.Size = new System.Drawing.Size(8, 12);
			this._lblIpSeparator2.TabIndex = 5;
			this._lblIpSeparator2.Text = ".";
			// 
			// _txtHighSpeedPort
			// 
			this._txtHighSpeedPort.Location = new System.Drawing.Point(293, 56);
			this._txtHighSpeedPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtHighSpeedPort.Name = "_txtHighSpeedPort";
			this._txtHighSpeedPort.Size = new System.Drawing.Size(59, 20);
			this._txtHighSpeedPort.TabIndex = 10;
			this._txtHighSpeedPort.Text = "24692";
			// 
			// _lblIpSeparator1
			// 
			this._lblIpSeparator1.AutoSize = true;
			this._lblIpSeparator1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblIpSeparator1.Location = new System.Drawing.Point(254, 18);
			this._lblIpSeparator1.Name = "_lblIpSeparator1";
			this._lblIpSeparator1.Size = new System.Drawing.Size(8, 12);
			this._lblIpSeparator1.TabIndex = 4;
			this._lblIpSeparator1.Text = ".";
			// 
			// _txtCommandPort
			// 
			this._txtCommandPort.Location = new System.Drawing.Point(294, 36);
			this._txtCommandPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._txtCommandPort.Name = "_txtCommandPort";
			this._txtCommandPort.Size = new System.Drawing.Size(59, 20);
			this._txtCommandPort.TabIndex = 8;
			this._txtCommandPort.Text = "24691";
			// 
			// _lblIpAddress
			// 
			this._lblIpAddress.AutoSize = true;
			this._lblIpAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblIpAddress.Location = new System.Drawing.Point(15, 17);
			this._lblIpAddress.Name = "_lblIpAddress";
			this._lblIpAddress.Size = new System.Drawing.Size(52, 12);
			this._lblIpAddress.TabIndex = 0;
			this._lblIpAddress.Text = "IP address";
			// 
			// _lblCommandPort
			// 
			this._lblCommandPort.AutoSize = true;
			this._lblCommandPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._lblCommandPort.Location = new System.Drawing.Point(15, 39);
			this._lblCommandPort.Name = "_lblCommandPort";
			this._lblCommandPort.Size = new System.Drawing.Size(84, 12);
			this._lblCommandPort.TabIndex = 7;
			this._lblCommandPort.Text = "TCP port number";
			// 
			// _btnTerminateCommunication
			// 
			this._btnTerminateCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnTerminateCommunication.Location = new System.Drawing.Point(207, 18);
			this._btnTerminateCommunication.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnTerminateCommunication.Name = "_btnTerminateCommunication";
			this._btnTerminateCommunication.Size = new System.Drawing.Size(196, 23);
			this._btnTerminateCommunication.TabIndex = 1;
			this._btnTerminateCommunication.Text = "Communication finalization";
			this._btnTerminateCommunication.UseVisualStyleBackColor = true;
			this._btnTerminateCommunication.Click += new System.EventHandler(this.btnTerminateCommunicationEx_Click);
			// 
			// _btnEstablishCommunication
			// 
			this._btnEstablishCommunication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._btnEstablishCommunication.Location = new System.Drawing.Point(6, 18);
			this._btnEstablishCommunication.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._btnEstablishCommunication.Name = "_btnEstablishCommunication";
			this._btnEstablishCommunication.Size = new System.Drawing.Size(196, 23);
			this._btnEstablishCommunication.TabIndex = 0;
			this._btnEstablishCommunication.Text = "Communication establishment";
			this._btnEstablishCommunication.UseVisualStyleBackColor = true;
			this._btnEstablishCommunication.Click += new System.EventHandler(this.btnEstablishCommunicationEx_Click);
			// 
			// _timerHighSpeed
			// 
			this._timerHighSpeed.Interval = 200;
			this._timerHighSpeed.Tick += new System.EventHandler(this._timerHighSpeed_Tick);
			// 
			// _openProgramFileDialog
			// 
			this._openProgramFileDialog.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 713);
			this.Controls.Add(this._tabControl);
			this.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "DLL Function Sample";
			this._grpCommand.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this._groupBox1.ResumeLayout(false);
			this._grpLog.ResumeLayout(false);
			this._grpLog.PerformLayout();
			this._grpBufferSize.ResumeLayout(false);
			this._grpBufferSize.PerformLayout();
			this._grpReceived.ResumeLayout(false);
			this._grpReceived.PerformLayout();
			this._grpMeasureRange.ResumeLayout(false);
			this._grpMeasureRange.PerformLayout();
			this._grpHead.ResumeLayout(false);
			this._grpHead.PerformLayout();
			this._grpExport.ResumeLayout(false);
			this._grpExport.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._nudProfileNo)).EndInit();
			this._pnlDeviceId.ResumeLayout(false);
			this._pnlDeviceId.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numInterval)).EndInit();
			this._tabControl.ResumeLayout(false);
			this._tabPage1.ResumeLayout(false);
			this._groupBox.ResumeLayout(false);
			this._groupBox.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this._tabPage2.ResumeLayout(false);
			this._grpProgram.ResumeLayout(false);
			this._grpProgram.PerformLayout();
			this._grpHighSpeed.ResumeLayout(false);
			this._grpHighSpeed.PerformLayout();
			this._grpGetData.ResumeLayout(false);
			this._grpGetData.PerformLayout();
			this._grpGetProfile.ResumeLayout(false);
			this._grpGetProfile.PerformLayout();
			this._grpBaseOperation.ResumeLayout(false);
			this._pnlCommunicationDevice.ResumeLayout(false);
			this._pnlCommunicationDevice.PerformLayout();
			this._grpEthernetSetting.ResumeLayout(false);
			this._grpEthernetSetting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnUsbOpen;
		private System.Windows.Forms.Button _btnGetTime;
		private System.Windows.Forms.Button _btnGetVersion;
		private System.Windows.Forms.Button _btnFinalize;
		private System.Windows.Forms.Button _btnInitialize;
		private System.Windows.Forms.Button _btnCommClose;
		private System.Windows.Forms.Button _btnEthernetOpen;
		private System.Windows.Forms.GroupBox _grpCommand;
		private System.Windows.Forms.Button _btnAutoZero;
		private System.Windows.Forms.Button _btnStopMeasure;
		private System.Windows.Forms.Button _btnStartMeasure;
		private System.Windows.Forms.Button _btnTrigger;
		private System.Windows.Forms.Button _btnClearError;
		private System.Windows.Forms.Button _btnGetError;
		private System.Windows.Forms.Button _btnRetrunToFactorySetting;
		private System.Windows.Forms.Button _btnRebootController;
		private System.Windows.Forms.Button _btnStopStorage;
		private System.Windows.Forms.Button _btnStartStorage;
		private System.Windows.Forms.Button _btnGetBatchProfileAdvance;
		private System.Windows.Forms.Button _btnGetProfileAdvance;
		private System.Windows.Forms.Button _btnGetBatchProfile;
		private System.Windows.Forms.Button _btnGetProfile;
		private System.Windows.Forms.Button _btnGetMeasurementValue;
		private System.Windows.Forms.Button _btnChangeActiveProgram;
		private System.Windows.Forms.Button _btnSetTime;
		private System.Windows.Forms.Button _btnUpdataSetting;
		private System.Windows.Forms.Button _btnCheckMemoryAccess;
		private System.Windows.Forms.Button _btnSetSetting;
		private System.Windows.Forms.Button _btnGetSetting;
		private System.Windows.Forms.Button _btnClearMemory;
		private System.Windows.Forms.Button _btnReset;
		private System.Windows.Forms.Button _btnTiming;
		private System.Windows.Forms.Button _btnGetStorageStatus;
		private System.Windows.Forms.Button _btnGetStorageData;
		private System.Windows.Forms.Button _btnGetStorageProfile;
		private System.Windows.Forms.Button _btnGetStorageBatchProfile;
		private System.Windows.Forms.Button _btnRewriteTemporarySetting;
		private System.Windows.Forms.Button _btnHighSpeedDataEthernetCommunicationInitalize;
		private System.Windows.Forms.Button _btnPreStartHighSpeedDataCommunication;
		private System.Windows.Forms.Button _btnStartHighSpeedDataCommunication;
		private System.Windows.Forms.Button _btnHighSpeedDataCommunicationFinalize;
		private System.Windows.Forms.Button _btnStopHighSpeedDataCommunication;
		private System.Windows.Forms.Button _btnGetActiveProgram;
		private System.Windows.Forms.GroupBox _grpLog;
		private System.Windows.Forms.Button _btnLogClear;
		private System.Windows.Forms.TextBox _txtboxLog;
		private System.Windows.Forms.Button _btnInitializeSetting;
		private System.Windows.Forms.GroupBox _grpBufferSize;
		private System.Windows.Forms.CheckBox _chkboxEnvelope;
		private System.Windows.Forms.GroupBox _grpHead;
		private System.Windows.Forms.RadioButton _rdbtnTwoHead;
		private System.Windows.Forms.RadioButton _rdbtnOneHead;
		private System.Windows.Forms.GroupBox _grpMeasureRange;
		private System.Windows.Forms.Label _lblReceivedBinning;
		private System.Windows.Forms.Label _lblMeasureX;
		private System.Windows.Forms.GroupBox _grpReceived;
		private System.Windows.Forms.ComboBox _cmbMeasureX;
		private System.Windows.Forms.ComboBox _cmbReceivedBinning;
		private System.Windows.Forms.Button _btnHighSpeedDataUsbCommunicationInitalize;
		private System.Windows.Forms.GroupBox _grpExport;
		private System.Windows.Forms.TextBox _txtboxProfileFilePath;
		private System.Windows.Forms.Button _btnProfileFileSave;
		private System.Windows.Forms.SaveFileDialog _profileFileSave;
		private System.Windows.Forms.RadioButton _rdbtnWide;
		private System.Windows.Forms.ComboBox _cmbCompressX;
		private System.Windows.Forms.Label _lblCompressX;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Label _lblSavePath;
		private System.Windows.Forms.NumericUpDown _nudProfileNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer _timerHighSpeedReceive;
		private System.Windows.Forms.Label _lblReceiveProfileCount0;
		private System.Windows.Forms.Button _btnSaveMeasureData;
		private System.Windows.Forms.RadioButton _rdDevice0;
		private System.Windows.Forms.RadioButton _rdDevice2;
		private System.Windows.Forms.RadioButton _rdDevice1;
		private System.Windows.Forms.Panel _pnlDeviceId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label _lblDeviceStatus2;
		private System.Windows.Forms.Label _lblDeviceStatus1;
		private System.Windows.Forms.Label _lblDeviceStatus0;
		private System.Windows.Forms.Label _lblReceiveProfileCount2;
		private System.Windows.Forms.Label _lblReceiveProfileCount1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox _chkOnlyProfileCount;
		private System.Windows.Forms.CheckBox _chkStartTimer;
		private System.Windows.Forms.NumericUpDown _numInterval;
		private System.Windows.Forms.TabControl _tabControl;
		private System.Windows.Forms.TabPage _tabPage1;
		private System.Windows.Forms.TabPage _tabPage2;
		private System.Windows.Forms.GroupBox _groupBox;
		private System.Windows.Forms.GroupBox _groupBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox _grpHighSpeed;
		private System.Windows.Forms.TextBox _txtCallbackFrequency;
		private System.Windows.Forms.TextBox _txtStartProfileNo;
		private System.Windows.Forms.Label _lblReceiveProfileCount;
		private System.Windows.Forms.Label _lblCallbackFrequency;
		private System.Windows.Forms.Label _lblHighSpeedStartNo;
		private System.Windows.Forms.Label _lblReceiveCount;
		private System.Windows.Forms.Button _btnTerminateHighSpeedCommunication;
		private System.Windows.Forms.Button _btnBeginHighSpeedDataCommunication;
		private System.Windows.Forms.GroupBox _grpGetData;
		private System.Windows.Forms.TextBox _txtMeasureData;
		private System.Windows.Forms.GroupBox _grpGetProfile;
		private System.Windows.Forms.Button _btnGetProfileAdvanceData;
		private System.Windows.Forms.Button _btnReferenceSavePath;
		private System.Windows.Forms.Button _btnGetBatchProfileDataAdvance;
		private System.Windows.Forms.Button _btnGetBatchProfileData;
		private System.Windows.Forms.Button _btnGetProfileData;
		private System.Windows.Forms.TextBox _txtSavePath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btnGetLatestMeasureValue;
		private System.Windows.Forms.GroupBox _grpBaseOperation;
		private System.Windows.Forms.Panel _pnlCommunicationDevice;
		private System.Windows.Forms.RadioButton _rdUsb;
		private System.Windows.Forms.RadioButton _rdEthernet;
		private System.Windows.Forms.GroupBox _grpEthernetSetting;
		private System.Windows.Forms.TextBox _txtIpFirstSegment;
		private System.Windows.Forms.TextBox _txtIpFourthSegment;
		private System.Windows.Forms.TextBox _txtIpSecondSegment;
		private System.Windows.Forms.TextBox _txtIpThirdSegment;
		private System.Windows.Forms.Label _lblIpSeparator3;
		private System.Windows.Forms.Label _lblIpSeparator2;
		private System.Windows.Forms.Label _lblHighSpeedPort;
		private System.Windows.Forms.TextBox _txtHighSpeedPort;
		private System.Windows.Forms.Label _lblIpSeparator1;
		private System.Windows.Forms.TextBox _txtCommandPort;
		private System.Windows.Forms.Label _lblIpAddress;
		private System.Windows.Forms.Label _lblCommandPort;
		private System.Windows.Forms.Button _btnTerminateCommunication;
		private System.Windows.Forms.Button _btnEstablishCommunication;
		private System.Windows.Forms.GroupBox _grpProgram;
		private System.Windows.Forms.Button _btnUploadProgram;
		private System.Windows.Forms.Button _btnDownloadProgram;
		private System.Windows.Forms.Button _btnReferenceProgramFilePath;
		private System.Windows.Forms.TextBox _txtProgramFilePath;
		private System.Windows.Forms.Label _lblSelectProgram;
		private System.Windows.Forms.ComboBox _cbxSelectProgram;
		private System.Windows.Forms.Label _lblConectedDevice;
		private System.Windows.Forms.Label _lblDeviceStatus3;
		private System.Windows.Forms.RadioButton _rdDevice3;
		private System.Windows.Forms.Label _lblReceiveProfileCount3;
		private System.Windows.Forms.Label _lblDeviceStatus4;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label _lblDeviceStatus5;
		private System.Windows.Forms.Label _lblReceiveProfileCount5;
		private System.Windows.Forms.Label _lblReceiveProfileCount4;
		private System.Windows.Forms.Timer _timerHighSpeed;
		private System.Windows.Forms.OpenFileDialog _openProgramFileDialog;
		private System.Windows.Forms.Label _lblSettingAttention;
	}
}

