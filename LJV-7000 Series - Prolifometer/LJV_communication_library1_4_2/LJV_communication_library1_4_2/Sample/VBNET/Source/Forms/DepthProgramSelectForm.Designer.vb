Namespace Forms
	Partial Class DepthProgramSelectForm
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
			Me._txtboxDepth = New System.Windows.Forms.TextBox()
			Me._lblDepth = New System.Windows.Forms.Label()
			Me._lblTargetProgram = New System.Windows.Forms.Label()
			Me._txtboxTargetProgram = New System.Windows.Forms.TextBox()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._lblDepthDescription = New System.Windows.Forms.Label()
			Me._lblHexDepth = New System.Windows.Forms.Label()
			Me._lblTargetDescription = New System.Windows.Forms.Label()
			Me._lblHexTarget = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _txtboxDepth
			' 
			Me._txtboxDepth.Location = New System.Drawing.Point(51, 17)
			Me._txtboxDepth.Name = "_txtboxDepth"
			Me._txtboxDepth.Size = New System.Drawing.Size(81, 21)
			Me._txtboxDepth.TabIndex = 26
			Me._txtboxDepth.Text = "00"
			' 
			' _lblDepth
			' 
			Me._lblDepth.AutoSize = True
			Me._lblDepth.Location = New System.Drawing.Point(138, 21)
			Me._lblDepth.Name = "_lblDepth"
			Me._lblDepth.Size = New System.Drawing.Size(32, 13)
			Me._lblDepth.TabIndex = 25
			Me._lblDepth.Text = "Level"
			' 
			' _lblTargetProgram
			' 
			Me._lblTargetProgram.AutoSize = True
			Me._lblTargetProgram.Location = New System.Drawing.Point(138, 121)
			Me._lblTargetProgram.Name = "_lblTargetProgram"
			Me._lblTargetProgram.Size = New System.Drawing.Size(93, 13)
			Me._lblTargetProgram.TabIndex = 27
			Me._lblTargetProgram.Text = "Specified program"
			' 
			' _txtboxTargetProgram
			' 
			Me._txtboxTargetProgram.Location = New System.Drawing.Point(51, 118)
			Me._txtboxTargetProgram.Name = "_txtboxTargetProgram"
			Me._txtboxTargetProgram.Size = New System.Drawing.Size(78, 21)
			Me._txtboxTargetProgram.TabIndex = 28
			Me._txtboxTargetProgram.Text = "00"
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(279, 233)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 31
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(183, 233)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 30
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblDepthDescription
			' 
			Me._lblDepthDescription.AutoSize = True
			Me._lblDepthDescription.Location = New System.Drawing.Point(21, 46)
			Me._lblDepthDescription.Name = "_lblDepthDescription"
			Me._lblDepthDescription.Size = New System.Drawing.Size(232, 52)
			Me._lblDepthDescription.TabIndex = 32
			Me._lblDepthDescription.Text = "Level (specified with LJV7IF_SETTING_DEPTH) " & vbCr & vbLf & " 0x00  Write settings memory  " & vbCr & vbLf & " 0x" & "01  Running memory   " & vbCr & vbLf & " 0x02  Save memory " & vbCr & vbLf
			' 
			' _lblHexDepth
			' 
			Me._lblHexDepth.AutoSize = True
			Me._lblHexDepth.Location = New System.Drawing.Point(28, 21)
			Me._lblHexDepth.Name = "_lblHexDepth"
			Me._lblHexDepth.Size = New System.Drawing.Size(19, 13)
			Me._lblHexDepth.TabIndex = 33
			Me._lblHexDepth.Text = "0x"
			' 
			' _lblTargetDescription
			' 
			Me._lblTargetDescription.AutoSize = True
			Me._lblTargetDescription.Location = New System.Drawing.Point(18, 150)
			Me._lblTargetDescription.Name = "_lblTargetDescription"
			Me._lblTargetDescription.Size = New System.Drawing.Size(324, 65)
			Me._lblTargetDescription.TabIndex = 34
			Me._lblTargetDescription.Text = "Specified program (specified with LJV7IF_INIT_SETTING_TARGET)" & vbCr & vbLf & " 0x00 program 0" & vbCr & vbLf & " " & "0x01 program 1" & vbCr & vbLf & " ..." & vbCr & vbLf & " 0x0F program 15"
			' 
			' _lblHexTarget
			' 
			Me._lblHexTarget.AutoSize = True
			Me._lblHexTarget.Location = New System.Drawing.Point(28, 122)
			Me._lblHexTarget.Name = "_lblHexTarget"
			Me._lblHexTarget.Size = New System.Drawing.Size(19, 13)
			Me._lblHexTarget.TabIndex = 35
			Me._lblHexTarget.Text = "0x"
			' 
			' DepthProgramSelectForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(378, 272)
			Me.Controls.Add(Me._lblHexTarget)
			Me.Controls.Add(Me._lblTargetDescription)
			Me.Controls.Add(Me._lblHexDepth)
			Me.Controls.Add(Me._lblDepthDescription)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._txtboxTargetProgram)
			Me.Controls.Add(Me._lblTargetProgram)
			Me.Controls.Add(Me._txtboxDepth)
			Me.Controls.Add(Me._lblDepth)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "DepthProgramSelectForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Program settings"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _txtboxDepth As System.Windows.Forms.TextBox
		Private _lblDepth As System.Windows.Forms.Label
		Private _lblTargetProgram As System.Windows.Forms.Label
		Private _txtboxTargetProgram As System.Windows.Forms.TextBox
		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblDepthDescription As System.Windows.Forms.Label
		Private _lblHexDepth As System.Windows.Forms.Label
		Private _lblTargetDescription As System.Windows.Forms.Label
		Private _lblHexTarget As System.Windows.Forms.Label
	End Class
End Namespace
