Namespace Forms
	Partial Class GetBatchProfileForm
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
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._lblEraseDescription = New System.Windows.Forms.Label()
			Me._lblErase = New System.Windows.Forms.Label()
			Me._txtboxErase = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me._txtboxPosModeDescription = New System.Windows.Forms.Label()
			Me._lblTargetBankDescription = New System.Windows.Forms.Label()
			Me._txtboxGetProfCnt = New System.Windows.Forms.TextBox()
			Me._lblGetProfCnt = New System.Windows.Forms.Label()
			Me._txtboxGetProfNo = New System.Windows.Forms.TextBox()
			Me._lblGetProfNo = New System.Windows.Forms.Label()
			Me._txtboxPosMode = New System.Windows.Forms.TextBox()
			Me._lblPosMode = New System.Windows.Forms.Label()
			Me._txtboxTargetBank = New System.Windows.Forms.TextBox()
			Me._lblTargetBank = New System.Windows.Forms.Label()
			Me._txtboxGetBatchNo = New System.Windows.Forms.TextBox()
			Me._lblGetBatchNo = New System.Windows.Forms.Label()
			Me._lblProfileDescription = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _btnCancel
			' 
			Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(364, 423)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 7
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(274, 423)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 6
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblEraseDescription
			' 
			Me._lblEraseDescription.AutoSize = True
			Me._lblEraseDescription.Location = New System.Drawing.Point(23, 381)
			Me._lblEraseDescription.Name = "_lblEraseDescription"
			Me._lblEraseDescription.Size = New System.Drawing.Size(221, 26)
			Me._lblEraseDescription.TabIndex = 64
			Me._lblEraseDescription.Text = "0: Do not erase the batches that were read." & vbCr & vbLf & "1: Erase the batches that were read." & ""
			' 
			' _lblErase
			' 
			Me._lblErase.AutoSize = True
			Me._lblErase.Location = New System.Drawing.Point(96, 361)
			Me._lblErase.Name = "_lblErase"
			Me._lblErase.Size = New System.Drawing.Size(138, 13)
			Me._lblErase.TabIndex = 63
			Me._lblErase.Text = "Already read indication flag"
			' 
			' _txtboxErase
			' 
			Me._txtboxErase.Location = New System.Drawing.Point(21, 358)
			Me._txtboxErase.Name = "_txtboxErase"
			Me._txtboxErase.Size = New System.Drawing.Size(69, 21)
			Me._txtboxErase.TabIndex = 5
			Me._txtboxErase.Text = "0"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(23, 281)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(323, 26)
			Me.label1.TabIndex = 61
			Me.label1.Text = "When the profile position specification is [0x02: Specify position], " & vbCr & vbLf & "specify th" & "e number of the profile to get."
			' 
			' _txtboxPosModeDescription
			' 
			Me._txtboxPosModeDescription.AutoSize = True
			Me._txtboxPosModeDescription.Location = New System.Drawing.Point(23, 151)
			Me._txtboxPosModeDescription.Name = "_txtboxPosModeDescription"
			Me._txtboxPosModeDescription.Size = New System.Drawing.Size(217, 52)
			Me._txtboxPosModeDescription.TabIndex = 60
			Me._txtboxPosModeDescription.Text = "0x00: From current" & vbCr & vbLf & "0x02: Specify position" & vbCr & vbLf & "0x03: From current after batch commit" & "ment" & vbCr & vbLf & "0x04: Current only"
			' 
			' _lblTargetBankDescription
			' 
			Me._lblTargetBankDescription.AutoSize = True
			Me._lblTargetBankDescription.Location = New System.Drawing.Point(23, 87)
			Me._lblTargetBankDescription.Name = "_lblTargetBankDescription"
			Me._lblTargetBankDescription.Size = New System.Drawing.Size(116, 26)
			Me._lblTargetBankDescription.TabIndex = 59
			Me._lblTargetBankDescription.Text = "0x00: Active surface" & vbCr & vbLf & "0x01: Inactive surface"
			' 
			' _txtboxGetProfCnt
			' 
			Me._txtboxGetProfCnt.Location = New System.Drawing.Point(21, 320)
			Me._txtboxGetProfCnt.Name = "_txtboxGetProfCnt"
			Me._txtboxGetProfCnt.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetProfCnt.TabIndex = 4
			Me._txtboxGetProfCnt.Text = "1"
			' 
			' _lblGetProfCnt
			' 
			Me._lblGetProfCnt.AutoSize = True
			Me._lblGetProfCnt.Location = New System.Drawing.Point(96, 323)
			Me._lblGetProfCnt.Name = "_lblGetProfCnt"
			Me._lblGetProfCnt.Size = New System.Drawing.Size(220, 13)
			Me._lblGetProfCnt.TabIndex = 57
			Me._lblGetProfCnt.Text = "Number of profiles to request the acquisition"
			' 
			' _txtboxGetProfNo
			' 
			Me._txtboxGetProfNo.Location = New System.Drawing.Point(21, 257)
			Me._txtboxGetProfNo.Name = "_txtboxGetProfNo"
			Me._txtboxGetProfNo.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetProfNo.TabIndex = 3
			Me._txtboxGetProfNo.Text = "0"
			' 
			' _lblGetProfNo
			' 
			Me._lblGetProfNo.AutoSize = True
			Me._lblGetProfNo.Location = New System.Drawing.Point(96, 260)
			Me._lblGetProfNo.Name = "_lblGetProfNo"
			Me._lblGetProfNo.Size = New System.Drawing.Size(321, 13)
			Me._lblGetProfNo.TabIndex = 55
			Me._lblGetProfNo.Text = "From what number profile do you want to start acquiring profiles?"
			' 
			' _txtboxPosMode
			' 
			Me._txtboxPosMode.Location = New System.Drawing.Point(21, 127)
			Me._txtboxPosMode.Name = "_txtboxPosMode"
			Me._txtboxPosMode.Size = New System.Drawing.Size(69, 21)
			Me._txtboxPosMode.TabIndex = 1
			Me._txtboxPosMode.Text = "00"
			' 
			' _lblPosMode
			' 
			Me._lblPosMode.AutoSize = True
			Me._lblPosMode.Location = New System.Drawing.Point(96, 130)
			Me._lblPosMode.Name = "_lblPosMode"
			Me._lblPosMode.Size = New System.Drawing.Size(191, 13)
			Me._lblPosMode.TabIndex = 53
			Me._lblPosMode.Text = "Get bank position specification method"
			' 
			' _txtboxTargetBank
			' 
			Me._txtboxTargetBank.Location = New System.Drawing.Point(21, 63)
			Me._txtboxTargetBank.Name = "_txtboxTargetBank"
			Me._txtboxTargetBank.Size = New System.Drawing.Size(69, 21)
			Me._txtboxTargetBank.TabIndex = 0
			Me._txtboxTargetBank.Text = "00"
			' 
			' _lblTargetBank
			' 
			Me._lblTargetBank.AutoSize = True
			Me._lblTargetBank.Location = New System.Drawing.Point(96, 69)
			Me._lblTargetBank.Name = "_lblTargetBank"
			Me._lblTargetBank.Size = New System.Drawing.Size(145, 13)
			Me._lblTargetBank.TabIndex = 51
			Me._lblTargetBank.Text = "Get profile bank specification"
			' 
			' _txtboxGetBatchNo
			' 
			Me._txtboxGetBatchNo.Location = New System.Drawing.Point(21, 216)
			Me._txtboxGetBatchNo.Name = "_txtboxGetBatchNo"
			Me._txtboxGetBatchNo.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetBatchNo.TabIndex = 2
			Me._txtboxGetBatchNo.Text = "0"
			' 
			' _lblGetBatchNo
			' 
			Me._lblGetBatchNo.AutoSize = True
			Me._lblGetBatchNo.Location = New System.Drawing.Point(96, 219)
			Me._lblGetBatchNo.Name = "_lblGetBatchNo"
			Me._lblGetBatchNo.Size = New System.Drawing.Size(318, 13)
			Me._lblGetBatchNo.TabIndex = 66
			Me._lblGetBatchNo.Text = "What is the number of the batch that contains the profile to get?"
			' 
			' _lblProfileDescription
			' 
			Me._lblProfileDescription.AutoSize = True
			Me._lblProfileDescription.Location = New System.Drawing.Point(23, 10)
			Me._lblProfileDescription.Name = "_lblProfileDescription"
			Me._lblProfileDescription.Size = New System.Drawing.Size(395, 26)
			Me._lblProfileDescription.TabIndex = 67
			Me._lblProfileDescription.Text = "From what number profile do you want to start acquiring profiles : ushort format " & vbCr & vbLf & "other than that above : byte format"
			' 
			' GetBatchProfileForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(465, 460)
			Me.Controls.Add(Me._lblProfileDescription)
			Me.Controls.Add(Me._txtboxGetBatchNo)
			Me.Controls.Add(Me._lblGetBatchNo)
			Me.Controls.Add(Me._lblEraseDescription)
			Me.Controls.Add(Me._lblErase)
			Me.Controls.Add(Me._txtboxErase)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._txtboxPosModeDescription)
			Me.Controls.Add(Me._lblTargetBankDescription)
			Me.Controls.Add(Me._txtboxGetProfCnt)
			Me.Controls.Add(Me._lblGetProfCnt)
			Me.Controls.Add(Me._txtboxGetProfNo)
			Me.Controls.Add(Me._lblGetProfNo)
			Me.Controls.Add(Me._txtboxPosMode)
			Me.Controls.Add(Me._lblPosMode)
			Me.Controls.Add(Me._txtboxTargetBank)
			Me.Controls.Add(Me._lblTargetBank)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GetBatchProfileForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "GetBatchProfileForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblEraseDescription As System.Windows.Forms.Label
		Private _lblErase As System.Windows.Forms.Label
		Private _txtboxErase As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private _txtboxPosModeDescription As System.Windows.Forms.Label
		Private _lblTargetBankDescription As System.Windows.Forms.Label
		Private _txtboxGetProfCnt As System.Windows.Forms.TextBox
		Private _lblGetProfCnt As System.Windows.Forms.Label
		Private _txtboxGetProfNo As System.Windows.Forms.TextBox
		Private _lblGetProfNo As System.Windows.Forms.Label
		Private _txtboxPosMode As System.Windows.Forms.TextBox
		Private _lblPosMode As System.Windows.Forms.Label
		Private _txtboxTargetBank As System.Windows.Forms.TextBox
		Private _lblTargetBank As System.Windows.Forms.Label
		Private _txtboxGetBatchNo As System.Windows.Forms.TextBox
		Private _lblGetBatchNo As System.Windows.Forms.Label
		Private _lblProfileDescription As System.Windows.Forms.Label
	End Class
End Namespace
