Namespace Forms
	Partial Class SettingForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me._lblHexType = New System.Windows.Forms.Label()
			Me._txtboxType = New System.Windows.Forms.TextBox()
			Me._lblType = New System.Windows.Forms.Label()
			Me._lblCategor = New System.Windows.Forms.Label()
			Me._txtboxCategor = New System.Windows.Forms.TextBox()
			Me._lblHexCategor = New System.Windows.Forms.Label()
			Me._lblItem = New System.Windows.Forms.Label()
			Me._txtboxItem = New System.Windows.Forms.TextBox()
			Me._lblHexItem = New System.Windows.Forms.Label()
			Me._lblTarget1 = New System.Windows.Forms.Label()
			Me._txtboxTarget1 = New System.Windows.Forms.TextBox()
			Me._lblHexTarget1 = New System.Windows.Forms.Label()
			Me._lblTarget2 = New System.Windows.Forms.Label()
			Me._txtboxTarget2 = New System.Windows.Forms.TextBox()
			Me._lblHexTarget2 = New System.Windows.Forms.Label()
			Me._lblTarget3 = New System.Windows.Forms.Label()
			Me._txtboxTarget3 = New System.Windows.Forms.TextBox()
			Me._lblHexTarget3 = New System.Windows.Forms.Label()
			Me._lblTarget4 = New System.Windows.Forms.Label()
			Me._txtboxTarget4 = New System.Windows.Forms.TextBox()
			Me._lblHexTarget4 = New System.Windows.Forms.Label()
			Me._lblDepth = New System.Windows.Forms.Label()
			Me._txtboxDepth = New System.Windows.Forms.TextBox()
			Me._lblHexDepth = New System.Windows.Forms.Label()
			Me._lblParameter = New System.Windows.Forms.Label()
			Me._txtboxParameter = New System.Windows.Forms.TextBox()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me._txtDataLength = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _lblHexType
			' 
			Me._lblHexType.AutoSize = True
			Me._lblHexType.Location = New System.Drawing.Point(14, 106)
			Me._lblHexType.Name = "_lblHexType"
			Me._lblHexType.Size = New System.Drawing.Size(19, 13)
			Me._lblHexType.TabIndex = 0
			Me._lblHexType.Text = "0x"
			' 
			' _txtboxType
			' 
			Me._txtboxType.Location = New System.Drawing.Point(37, 103)
			Me._txtboxType.MaxLength = 2
			Me._txtboxType.Name = "_txtboxType"
			Me._txtboxType.Size = New System.Drawing.Size(76, 21)
			Me._txtboxType.TabIndex = 1
			Me._txtboxType.Text = "10"
			' 
			' _lblType
			' 
			Me._lblType.AutoSize = True
			Me._lblType.Location = New System.Drawing.Point(119, 106)
			Me._lblType.Name = "_lblType"
			Me._lblType.Size = New System.Drawing.Size(66, 13)
			Me._lblType.TabIndex = 2
			Me._lblType.Text = "Setting type"
			' 
			' _lblCategor
			' 
			Me._lblCategor.AutoSize = True
			Me._lblCategor.Location = New System.Drawing.Point(119, 178)
			Me._lblCategor.Name = "_lblCategor"
			Me._lblCategor.Size = New System.Drawing.Size(52, 13)
			Me._lblCategor.TabIndex = 5
			Me._lblCategor.Text = "Category"
			' 
			' _txtboxCategor
			' 
			Me._txtboxCategor.Location = New System.Drawing.Point(37, 174)
			Me._txtboxCategor.MaxLength = 2
			Me._txtboxCategor.Name = "_txtboxCategor"
			Me._txtboxCategor.Size = New System.Drawing.Size(76, 21)
			Me._txtboxCategor.TabIndex = 2
			Me._txtboxCategor.Text = "00"
			' 
			' _lblHexCategor
			' 
			Me._lblHexCategor.AutoSize = True
			Me._lblHexCategor.Location = New System.Drawing.Point(14, 178)
			Me._lblHexCategor.Name = "_lblHexCategor"
			Me._lblHexCategor.Size = New System.Drawing.Size(19, 13)
			Me._lblHexCategor.TabIndex = 3
			Me._lblHexCategor.Text = "0x"
			' 
			' _lblItem
			' 
			Me._lblItem.AutoSize = True
			Me._lblItem.Location = New System.Drawing.Point(119, 209)
			Me._lblItem.Name = "_lblItem"
			Me._lblItem.Size = New System.Drawing.Size(64, 13)
			Me._lblItem.TabIndex = 8
			Me._lblItem.Text = "Setting item"
			' 
			' _txtboxItem
			' 
			Me._txtboxItem.Location = New System.Drawing.Point(37, 206)
			Me._txtboxItem.MaxLength = 2
			Me._txtboxItem.Name = "_txtboxItem"
			Me._txtboxItem.Size = New System.Drawing.Size(76, 21)
			Me._txtboxItem.TabIndex = 3
			Me._txtboxItem.Text = "02"
			' 
			' _lblHexItem
			' 
			Me._lblHexItem.AutoSize = True
			Me._lblHexItem.Location = New System.Drawing.Point(14, 209)
			Me._lblHexItem.Name = "_lblHexItem"
			Me._lblHexItem.Size = New System.Drawing.Size(19, 13)
			Me._lblHexItem.TabIndex = 6
			Me._lblHexItem.Text = "0x"
			' 
			' _lblTarget1
			' 
			Me._lblTarget1.AutoSize = True
			Me._lblTarget1.Location = New System.Drawing.Point(119, 241)
			Me._lblTarget1.Name = "_lblTarget1"
			Me._lblTarget1.Size = New System.Drawing.Size(83, 13)
			Me._lblTarget1.TabIndex = 11
			Me._lblTarget1.Text = "Setting target 1"
			' 
			' _txtboxTarget1
			' 
			Me._txtboxTarget1.Location = New System.Drawing.Point(37, 237)
			Me._txtboxTarget1.MaxLength = 2
			Me._txtboxTarget1.Name = "_txtboxTarget1"
			Me._txtboxTarget1.Size = New System.Drawing.Size(76, 21)
			Me._txtboxTarget1.TabIndex = 4
			Me._txtboxTarget1.Text = "00"
			' 
			' _lblHexTarget1
			' 
			Me._lblHexTarget1.AutoSize = True
			Me._lblHexTarget1.Location = New System.Drawing.Point(14, 241)
			Me._lblHexTarget1.Name = "_lblHexTarget1"
			Me._lblHexTarget1.Size = New System.Drawing.Size(19, 13)
			Me._lblHexTarget1.TabIndex = 9
			Me._lblHexTarget1.Text = "0x"
			' 
			' _lblTarget2
			' 
			Me._lblTarget2.AutoSize = True
			Me._lblTarget2.Location = New System.Drawing.Point(119, 272)
			Me._lblTarget2.Name = "_lblTarget2"
			Me._lblTarget2.Size = New System.Drawing.Size(83, 13)
			Me._lblTarget2.TabIndex = 14
			Me._lblTarget2.Text = "Setting target 2"
			' 
			' _txtboxTarget2
			' 
			Me._txtboxTarget2.Location = New System.Drawing.Point(37, 269)
			Me._txtboxTarget2.MaxLength = 2
			Me._txtboxTarget2.Name = "_txtboxTarget2"
			Me._txtboxTarget2.Size = New System.Drawing.Size(76, 21)
			Me._txtboxTarget2.TabIndex = 5
			Me._txtboxTarget2.Text = "00"
			' 
			' _lblHexTarget2
			' 
			Me._lblHexTarget2.AutoSize = True
			Me._lblHexTarget2.Location = New System.Drawing.Point(14, 272)
			Me._lblHexTarget2.Name = "_lblHexTarget2"
			Me._lblHexTarget2.Size = New System.Drawing.Size(19, 13)
			Me._lblHexTarget2.TabIndex = 12
			Me._lblHexTarget2.Text = "0x"
			' 
			' _lblTarget3
			' 
			Me._lblTarget3.AutoSize = True
			Me._lblTarget3.Location = New System.Drawing.Point(119, 303)
			Me._lblTarget3.Name = "_lblTarget3"
			Me._lblTarget3.Size = New System.Drawing.Size(83, 13)
			Me._lblTarget3.TabIndex = 17
			Me._lblTarget3.Text = "Setting target 3"
			' 
			' _txtboxTarget3
			' 
			Me._txtboxTarget3.Location = New System.Drawing.Point(37, 300)
			Me._txtboxTarget3.MaxLength = 2
			Me._txtboxTarget3.Name = "_txtboxTarget3"
			Me._txtboxTarget3.Size = New System.Drawing.Size(76, 21)
			Me._txtboxTarget3.TabIndex = 6
			Me._txtboxTarget3.Text = "00"
			' 
			' _lblHexTarget3
			' 
			Me._lblHexTarget3.AutoSize = True
			Me._lblHexTarget3.Location = New System.Drawing.Point(14, 303)
			Me._lblHexTarget3.Name = "_lblHexTarget3"
			Me._lblHexTarget3.Size = New System.Drawing.Size(19, 13)
			Me._lblHexTarget3.TabIndex = 15
			Me._lblHexTarget3.Text = "0x"
			' 
			' _lblTarget4
			' 
			Me._lblTarget4.AutoSize = True
			Me._lblTarget4.Location = New System.Drawing.Point(119, 335)
			Me._lblTarget4.Name = "_lblTarget4"
			Me._lblTarget4.Size = New System.Drawing.Size(83, 13)
			Me._lblTarget4.TabIndex = 20
			Me._lblTarget4.Text = "Setting target 4"
			' 
			' _txtboxTarget4
			' 
			Me._txtboxTarget4.Location = New System.Drawing.Point(37, 332)
			Me._txtboxTarget4.MaxLength = 2
			Me._txtboxTarget4.Name = "_txtboxTarget4"
			Me._txtboxTarget4.Size = New System.Drawing.Size(76, 21)
			Me._txtboxTarget4.TabIndex = 7
			Me._txtboxTarget4.Text = "00"
			' 
			' _lblHexTarget4
			' 
			Me._lblHexTarget4.AutoSize = True
			Me._lblHexTarget4.Location = New System.Drawing.Point(14, 335)
			Me._lblHexTarget4.Name = "_lblHexTarget4"
			Me._lblHexTarget4.Size = New System.Drawing.Size(19, 13)
			Me._lblHexTarget4.TabIndex = 18
			Me._lblHexTarget4.Text = "0x"
			' 
			' _lblDepth
			' 
			Me._lblDepth.AutoSize = True
			Me._lblDepth.Location = New System.Drawing.Point(119, 56)
			Me._lblDepth.Name = "_lblDepth"
			Me._lblDepth.Size = New System.Drawing.Size(170, 13)
			Me._lblDepth.TabIndex = 23
			Me._lblDepth.Text = "Get target area and setting depth"
			' 
			' _txtboxDepth
			' 
			Me._txtboxDepth.Location = New System.Drawing.Point(37, 53)
			Me._txtboxDepth.MaxLength = 2
			Me._txtboxDepth.Name = "_txtboxDepth"
			Me._txtboxDepth.Size = New System.Drawing.Size(76, 21)
			Me._txtboxDepth.TabIndex = 0
			Me._txtboxDepth.Text = "01"
			' 
			' _lblHexDepth
			' 
			Me._lblHexDepth.AutoSize = True
			Me._lblHexDepth.Location = New System.Drawing.Point(14, 56)
			Me._lblHexDepth.Name = "_lblHexDepth"
			Me._lblHexDepth.Size = New System.Drawing.Size(19, 13)
			Me._lblHexDepth.TabIndex = 21
			Me._lblHexDepth.Text = "0x"
			' 
			' _lblParameter
			' 
			Me._lblParameter.AutoSize = True
			Me._lblParameter.Location = New System.Drawing.Point(14, 389)
			Me._lblParameter.Name = "_lblParameter"
			Me._lblParameter.Size = New System.Drawing.Size(292, 13)
			Me._lblParameter.TabIndex = 24
			Me._lblParameter.Text = "Writing parameters (comma-separated hexadecimal values)"
			' 
			' _txtboxParameter
			' 
			Me._txtboxParameter.Location = New System.Drawing.Point(16, 405)
			Me._txtboxParameter.Multiline = True
			Me._txtboxParameter.Name = "_txtboxParameter"
			Me._txtboxParameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me._txtboxParameter.Size = New System.Drawing.Size(324, 61)
			Me._txtboxParameter.TabIndex = 9
			Me._txtboxParameter.Text = "3"
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(211, 484)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 27
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(67, 484)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 26
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 75)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(322, 23)
			Me.label1.TabIndex = 28
			Me.label1.Text = "0: Write settings area, 1: Running settings area, 2: Save area"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(16, 127)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(344, 38)
			Me.label2.TabIndex = 29
			Me.label2.Text = "0x01: Environment settings, 0x02: Common measurement settings, 0x10: Program 0, 0" & "x11: Program 1, ..., 0x1F: Program 15"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 10)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(307, 30)
			Me.label3.TabIndex = 30
			Me.label3.Text = "For details on the items that follow the category, see the tables in the communic" & "ation command specifications." & vbCr & vbLf
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' _txtDataLength
			' 
			Me._txtDataLength.Location = New System.Drawing.Point(107, 363)
			Me._txtDataLength.Name = "_txtDataLength"
			Me._txtDataLength.Size = New System.Drawing.Size(45, 21)
			Me._txtDataLength.TabIndex = 8
			Me._txtDataLength.Text = "1"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(14, 366)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(82, 13)
			Me.label4.TabIndex = 20
			Me.label4.Text = "Amount of data"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(163, 366)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(31, 13)
			Me.label5.TabIndex = 20
			Me.label5.Text = "BYTE"
			' 
			' SettingForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(372, 521)
			Me.Controls.Add(Me._txtDataLength)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._txtboxParameter)
			Me.Controls.Add(Me._lblParameter)
			Me.Controls.Add(Me._lblDepth)
			Me.Controls.Add(Me._txtboxDepth)
			Me.Controls.Add(Me._lblHexDepth)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me._lblTarget4)
			Me.Controls.Add(Me._txtboxTarget4)
			Me.Controls.Add(Me._lblHexTarget4)
			Me.Controls.Add(Me._lblTarget3)
			Me.Controls.Add(Me._txtboxTarget3)
			Me.Controls.Add(Me._lblHexTarget3)
			Me.Controls.Add(Me._lblTarget2)
			Me.Controls.Add(Me._txtboxTarget2)
			Me.Controls.Add(Me._lblHexTarget2)
			Me.Controls.Add(Me._lblTarget1)
			Me.Controls.Add(Me._txtboxTarget1)
			Me.Controls.Add(Me._lblHexTarget1)
			Me.Controls.Add(Me._lblItem)
			Me.Controls.Add(Me._txtboxItem)
			Me.Controls.Add(Me._lblHexItem)
			Me.Controls.Add(Me._lblCategor)
			Me.Controls.Add(Me._txtboxCategor)
			Me.Controls.Add(Me._lblHexCategor)
			Me.Controls.Add(Me._lblType)
			Me.Controls.Add(Me._txtboxType)
			Me.Controls.Add(Me._lblHexType)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SettingForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Settings"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.SettingForm_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _lblHexType As System.Windows.Forms.Label
		Private _txtboxType As System.Windows.Forms.TextBox
		Private _lblType As System.Windows.Forms.Label
		Private _lblCategor As System.Windows.Forms.Label
		Private _txtboxCategor As System.Windows.Forms.TextBox
		Private _lblHexCategor As System.Windows.Forms.Label
		Private _lblItem As System.Windows.Forms.Label
		Private _txtboxItem As System.Windows.Forms.TextBox
		Private _lblHexItem As System.Windows.Forms.Label
		Private _lblTarget1 As System.Windows.Forms.Label
		Private _txtboxTarget1 As System.Windows.Forms.TextBox
		Private _lblHexTarget1 As System.Windows.Forms.Label
		Private _lblTarget2 As System.Windows.Forms.Label
		Private _txtboxTarget2 As System.Windows.Forms.TextBox
		Private _lblHexTarget2 As System.Windows.Forms.Label
		Private _lblTarget3 As System.Windows.Forms.Label
		Private _txtboxTarget3 As System.Windows.Forms.TextBox
		Private _lblHexTarget3 As System.Windows.Forms.Label
		Private _lblTarget4 As System.Windows.Forms.Label
		Private _txtboxTarget4 As System.Windows.Forms.TextBox
		Private _lblHexTarget4 As System.Windows.Forms.Label
		Private _lblDepth As System.Windows.Forms.Label
		Private _txtboxDepth As System.Windows.Forms.TextBox
		Private _lblHexDepth As System.Windows.Forms.Label
		Private _lblParameter As System.Windows.Forms.Label
		Private _txtboxParameter As System.Windows.Forms.TextBox
		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private _txtDataLength As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
	End Class
End Namespace
