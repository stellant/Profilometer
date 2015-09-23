Namespace Forms
	Partial Class ProfileForm
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
			Me._txtboxTargetBank = New System.Windows.Forms.TextBox()
			Me._lblTargetBank = New System.Windows.Forms.Label()
			Me._txtboxPosMode = New System.Windows.Forms.TextBox()
			Me._lblPosMode = New System.Windows.Forms.Label()
			Me._txtboxGetProfNo = New System.Windows.Forms.TextBox()
			Me._lblGetProfNo = New System.Windows.Forms.Label()
			Me._txtboxGetProfCount = New System.Windows.Forms.TextBox()
			Me._lblGetProfCount = New System.Windows.Forms.Label()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._lblTargetBankDescription = New System.Windows.Forms.Label()
			Me._txtboxPosModeDescription = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me._txtboxErase = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me._lblProfileDescription = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _txtboxTargetBank
			' 
			Me._txtboxTargetBank.Location = New System.Drawing.Point(18, 51)
			Me._txtboxTargetBank.Name = "_txtboxTargetBank"
			Me._txtboxTargetBank.Size = New System.Drawing.Size(69, 21)
			Me._txtboxTargetBank.TabIndex = 0
			Me._txtboxTargetBank.Text = "00"
			' 
			' _lblTargetBank
			' 
			Me._lblTargetBank.AutoSize = True
			Me._lblTargetBank.Location = New System.Drawing.Point(93, 54)
			Me._lblTargetBank.Name = "_lblTargetBank"
			Me._lblTargetBank.Size = New System.Drawing.Size(145, 13)
			Me._lblTargetBank.TabIndex = 29
			Me._lblTargetBank.Text = "Get profile bank specification"
			' 
			' _txtboxPosMode
			' 
			Me._txtboxPosMode.Location = New System.Drawing.Point(18, 115)
			Me._txtboxPosMode.Name = "_txtboxPosMode"
			Me._txtboxPosMode.Size = New System.Drawing.Size(69, 21)
			Me._txtboxPosMode.TabIndex = 1
			Me._txtboxPosMode.Text = "00"
			' 
			' _lblPosMode
			' 
			Me._lblPosMode.AutoSize = True
			Me._lblPosMode.Location = New System.Drawing.Point(93, 118)
			Me._lblPosMode.Name = "_lblPosMode"
			Me._lblPosMode.Size = New System.Drawing.Size(198, 13)
			Me._lblPosMode.TabIndex = 31
			Me._lblPosMode.Text = "Get profile position specification method"
			' 
			' _txtboxGetProfNo
			' 
			Me._txtboxGetProfNo.Location = New System.Drawing.Point(18, 189)
			Me._txtboxGetProfNo.Name = "_txtboxGetProfNo"
			Me._txtboxGetProfNo.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetProfNo.TabIndex = 2
			Me._txtboxGetProfNo.Text = "0"
			' 
			' _lblGetProfNo
			' 
			Me._lblGetProfNo.AutoSize = True
			Me._lblGetProfNo.Location = New System.Drawing.Point(93, 192)
			Me._lblGetProfNo.Name = "_lblGetProfNo"
			Me._lblGetProfNo.Size = New System.Drawing.Size(321, 13)
			Me._lblGetProfNo.TabIndex = 33
			Me._lblGetProfNo.Text = "From what number profile do you want to start acquiring profiles?"
			' 
			' _txtboxGetProfCount
			' 
			Me._txtboxGetProfCount.Location = New System.Drawing.Point(18, 251)
			Me._txtboxGetProfCount.Name = "_txtboxGetProfCount"
			Me._txtboxGetProfCount.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetProfCount.TabIndex = 3
			Me._txtboxGetProfCount.Text = "1"
			' 
			' _lblGetProfCount
			' 
			Me._lblGetProfCount.AutoSize = True
			Me._lblGetProfCount.Location = New System.Drawing.Point(93, 255)
			Me._lblGetProfCount.Name = "_lblGetProfCount"
			Me._lblGetProfCount.Size = New System.Drawing.Size(233, 13)
			Me._lblGetProfCount.TabIndex = 35
			Me._lblGetProfCount.Text = "Number of profiles to request the acquisition of"
			' 
			' _btnCancel
			' 
			Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(363, 349)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 6
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(267, 349)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 5
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblTargetBankDescription
			' 
			Me._lblTargetBankDescription.AutoSize = True
			Me._lblTargetBankDescription.Location = New System.Drawing.Point(20, 75)
			Me._lblTargetBankDescription.Name = "_lblTargetBankDescription"
			Me._lblTargetBankDescription.Size = New System.Drawing.Size(116, 26)
			Me._lblTargetBankDescription.TabIndex = 44
			Me._lblTargetBankDescription.Text = "0x00: Active surface" & vbCr & vbLf & "0x01: Inactive surface"
			' 
			' _txtboxPosModeDescription
			' 
			Me._txtboxPosModeDescription.AutoSize = True
			Me._txtboxPosModeDescription.Location = New System.Drawing.Point(20, 139)
			Me._txtboxPosModeDescription.Name = "_txtboxPosModeDescription"
			Me._txtboxPosModeDescription.Size = New System.Drawing.Size(113, 39)
			Me._txtboxPosModeDescription.TabIndex = 45
			Me._txtboxPosModeDescription.Text = "0x00: From current" & vbCr & vbLf & "0x01: From oldest" & vbCr & vbLf & "0x02: Specify position"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(20, 212)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(323, 26)
			Me.label1.TabIndex = 46
			Me.label1.Text = "When the profile position specification is [0x02: Specify position], " & vbCr & vbLf & "specify th" & "e number of the profile to get."
			' 
			' _txtboxErase
			' 
			Me._txtboxErase.Location = New System.Drawing.Point(18, 289)
			Me._txtboxErase.Name = "_txtboxErase"
			Me._txtboxErase.Size = New System.Drawing.Size(69, 21)
			Me._txtboxErase.TabIndex = 4
			Me._txtboxErase.Text = "0"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(93, 293)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(138, 13)
			Me.label2.TabIndex = 48
			Me.label2.Text = "Already read indication flag"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(20, 313)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(397, 13)
			Me.label3.TabIndex = 49
			Me.label3.Text = "0: Do not erase the profiles that were read. 1: Erase the profiles that were read" & "."
			' 
			' _lblProfileDescription
			' 
			Me._lblProfileDescription.AutoSize = True
			Me._lblProfileDescription.Location = New System.Drawing.Point(16, 10)
			Me._lblProfileDescription.Name = "_lblProfileDescription"
			Me._lblProfileDescription.Size = New System.Drawing.Size(395, 26)
			Me._lblProfileDescription.TabIndex = 50
			Me._lblProfileDescription.Text = "From what number profile do you want to start acquiring profiles : ushort format " & vbCr & vbLf & "other than that above : byte format"
			' 
			' ProfileForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(471, 387)
			Me.Controls.Add(Me._lblProfileDescription)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me._txtboxErase)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._txtboxPosModeDescription)
			Me.Controls.Add(Me._lblTargetBankDescription)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._txtboxGetProfCount)
			Me.Controls.Add(Me._lblGetProfCount)
			Me.Controls.Add(Me._txtboxGetProfNo)
			Me.Controls.Add(Me._lblGetProfNo)
			Me.Controls.Add(Me._txtboxPosMode)
			Me.Controls.Add(Me._lblPosMode)
			Me.Controls.Add(Me._txtboxTargetBank)
			Me.Controls.Add(Me._lblTargetBank)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ProfileForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Read the profile."
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _txtboxTargetBank As System.Windows.Forms.TextBox
		Private _lblTargetBank As System.Windows.Forms.Label
		Private _txtboxPosMode As System.Windows.Forms.TextBox
		Private _lblPosMode As System.Windows.Forms.Label
		Private _txtboxGetProfNo As System.Windows.Forms.TextBox
		Private _lblGetProfNo As System.Windows.Forms.Label
		Private _txtboxGetProfCount As System.Windows.Forms.TextBox
		Private _lblGetProfCount As System.Windows.Forms.Label
		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblTargetBankDescription As System.Windows.Forms.Label
		Private _txtboxPosModeDescription As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private _txtboxErase As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private _lblProfileDescription As System.Windows.Forms.Label
	End Class
End Namespace
