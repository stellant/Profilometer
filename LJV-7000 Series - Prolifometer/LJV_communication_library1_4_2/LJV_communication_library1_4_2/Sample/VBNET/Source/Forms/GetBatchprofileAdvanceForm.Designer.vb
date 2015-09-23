Namespace Forms
	Partial Class GetBatchprofileAdvanceForm
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
			Me._txtboxGetBatchNo = New System.Windows.Forms.TextBox()
			Me._lblGetBatchNo = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me._txtboxPosModeDescription = New System.Windows.Forms.Label()
			Me._txtboxGetProfCnt = New System.Windows.Forms.TextBox()
			Me._lblGetProfCnt = New System.Windows.Forms.Label()
			Me._txtboxGetProfNo = New System.Windows.Forms.TextBox()
			Me._lblGetProfNo = New System.Windows.Forms.Label()
			Me._txtboxPosMode = New System.Windows.Forms.TextBox()
			Me._lblProfileDescription = New System.Windows.Forms.Label()
			Me._lblPosMode = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _btnCancel
			' 
			Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(399, 301)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 5
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(295, 301)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 4
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _txtboxGetBatchNo
			' 
			Me._txtboxGetBatchNo.Location = New System.Drawing.Point(24, 147)
			Me._txtboxGetBatchNo.Name = "_txtboxGetBatchNo"
			Me._txtboxGetBatchNo.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetBatchNo.TabIndex = 1
			Me._txtboxGetBatchNo.Text = "0"
			' 
			' _lblGetBatchNo
			' 
			Me._lblGetBatchNo.AutoSize = True
			Me._lblGetBatchNo.Location = New System.Drawing.Point(99, 151)
			Me._lblGetBatchNo.Name = "_lblGetBatchNo"
			Me._lblGetBatchNo.Size = New System.Drawing.Size(318, 13)
			Me._lblGetBatchNo.TabIndex = 76
			Me._lblGetBatchNo.Text = "What is the number of the batch that contains the profile to get?"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(26, 212)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(323, 26)
			Me.label1.TabIndex = 75
			Me.label1.Text = "When the profile position specification is [0x02: Specify position], " & vbCr & vbLf & "specify th" & "e number of the profile to get."
			' 
			' _txtboxPosModeDescription
			' 
			Me._txtboxPosModeDescription.AutoSize = True
			Me._txtboxPosModeDescription.Location = New System.Drawing.Point(26, 81)
			Me._txtboxPosModeDescription.Name = "_txtboxPosModeDescription"
			Me._txtboxPosModeDescription.Size = New System.Drawing.Size(217, 52)
			Me._txtboxPosModeDescription.TabIndex = 74
			Me._txtboxPosModeDescription.Text = "0x00: From current" & vbCr & vbLf & "0x02: Specify position" & vbCr & vbLf & "0x03: From current after batch commit" & "ment" & vbCr & vbLf & "0x04: Current only"
			' 
			' _txtboxGetProfCnt
			' 
			Me._txtboxGetProfCnt.Location = New System.Drawing.Point(24, 251)
			Me._txtboxGetProfCnt.Name = "_txtboxGetProfCnt"
			Me._txtboxGetProfCnt.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetProfCnt.TabIndex = 3
			Me._txtboxGetProfCnt.Text = "1"
			' 
			' _lblGetProfCnt
			' 
			Me._lblGetProfCnt.AutoSize = True
			Me._lblGetProfCnt.Location = New System.Drawing.Point(99, 255)
			Me._lblGetProfCnt.Name = "_lblGetProfCnt"
			Me._lblGetProfCnt.Size = New System.Drawing.Size(233, 13)
			Me._lblGetProfCnt.TabIndex = 72
			Me._lblGetProfCnt.Text = "Number of profiles to request the acquisition of"
			' 
			' _txtboxGetProfNo
			' 
			Me._txtboxGetProfNo.Location = New System.Drawing.Point(24, 189)
			Me._txtboxGetProfNo.Name = "_txtboxGetProfNo"
			Me._txtboxGetProfNo.Size = New System.Drawing.Size(69, 21)
			Me._txtboxGetProfNo.TabIndex = 2
			Me._txtboxGetProfNo.Text = "0"
			' 
			' _lblGetProfNo
			' 
			Me._lblGetProfNo.AutoSize = True
			Me._lblGetProfNo.Location = New System.Drawing.Point(99, 192)
			Me._lblGetProfNo.Name = "_lblGetProfNo"
			Me._lblGetProfNo.Size = New System.Drawing.Size(321, 13)
			Me._lblGetProfNo.TabIndex = 70
			Me._lblGetProfNo.Text = "From what number profile do you want to start acquiring profiles?"
			' 
			' _txtboxPosMode
			' 
			Me._txtboxPosMode.Location = New System.Drawing.Point(24, 57)
			Me._txtboxPosMode.Name = "_txtboxPosMode"
			Me._txtboxPosMode.Size = New System.Drawing.Size(69, 21)
			Me._txtboxPosMode.TabIndex = 0
			Me._txtboxPosMode.Text = "00"
			' 
			' _lblProfileDescription
			' 
			Me._lblProfileDescription.AutoSize = True
			Me._lblProfileDescription.Location = New System.Drawing.Point(22, 10)
			Me._lblProfileDescription.Name = "_lblProfileDescription"
			Me._lblProfileDescription.Size = New System.Drawing.Size(412, 26)
			Me._lblProfileDescription.TabIndex = 78
			Me._lblProfileDescription.Text = "From what number profile do you want to start acquiring profiles (in ushort forma" & "t)? " & vbCr & vbLf & "This profile will be excluded (byte format)."
			' 
			' _lblPosMode
			' 
			Me._lblPosMode.AutoSize = True
			Me._lblPosMode.Location = New System.Drawing.Point(99, 61)
			Me._lblPosMode.Name = "_lblPosMode"
			Me._lblPosMode.Size = New System.Drawing.Size(171, 13)
			Me._lblPosMode.TabIndex = 68
			Me._lblPosMode.Text = "Bank position specification method"
			' 
			' GetBatchprofileAdvanceForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(503, 339)
			Me.Controls.Add(Me._lblProfileDescription)
			Me.Controls.Add(Me._txtboxGetBatchNo)
			Me.Controls.Add(Me._lblGetBatchNo)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._txtboxPosModeDescription)
			Me.Controls.Add(Me._txtboxGetProfCnt)
			Me.Controls.Add(Me._lblGetProfCnt)
			Me.Controls.Add(Me._txtboxGetProfNo)
			Me.Controls.Add(Me._lblGetProfNo)
			Me.Controls.Add(Me._txtboxPosMode)
			Me.Controls.Add(Me._lblPosMode)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GetBatchprofileAdvanceForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "GetBatchprofileAdvanceForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _txtboxGetBatchNo As System.Windows.Forms.TextBox
		Private _lblGetBatchNo As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private _txtboxPosModeDescription As System.Windows.Forms.Label
		Private _txtboxGetProfCnt As System.Windows.Forms.TextBox
		Private _lblGetProfCnt As System.Windows.Forms.Label
		Private _txtboxGetProfNo As System.Windows.Forms.TextBox
		Private _lblGetProfNo As System.Windows.Forms.Label
		Private _txtboxPosMode As System.Windows.Forms.TextBox
		Private _lblProfileDescription As System.Windows.Forms.Label
		Private _lblPosMode As System.Windows.Forms.Label
	End Class
End Namespace
