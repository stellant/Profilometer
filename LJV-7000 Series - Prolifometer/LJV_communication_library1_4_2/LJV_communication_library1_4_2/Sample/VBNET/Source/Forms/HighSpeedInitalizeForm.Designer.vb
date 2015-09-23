Namespace Forms
	Partial Class HighSpeedInitalizeForm
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
			Me._txtboxPortHighSpeed = New System.Windows.Forms.TextBox()
			Me._lblPortHighSpeed = New System.Windows.Forms.Label()
			Me._lblProfileCnt = New System.Windows.Forms.Label()
			Me._txtboxProfileCnt = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' _btnOk
			' 
			Me._btnOk.Location = New System.Drawing.Point(217, 166)
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			' 
			' _btnCancel
			' 
			Me._btnCancel.Location = New System.Drawing.Point(314, 166)
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			' 
			' _txtboxPortHighSpeed
			' 
			Me._txtboxPortHighSpeed.Location = New System.Drawing.Point(118, 103)
			Me._txtboxPortHighSpeed.Name = "_txtboxPortHighSpeed"
			Me._txtboxPortHighSpeed.Size = New System.Drawing.Size(157, 21)
			Me._txtboxPortHighSpeed.TabIndex = 10
			Me._txtboxPortHighSpeed.Text = "24692"
			' 
			' _lblPortHighSpeed
			' 
			Me._lblPortHighSpeed.AutoSize = True
			Me._lblPortHighSpeed.Location = New System.Drawing.Point(12, 106)
			Me._lblPortHighSpeed.Name = "_lblPortHighSpeed"
			Me._lblPortHighSpeed.Size = New System.Drawing.Size(90, 13)
			Me._lblPortHighSpeed.TabIndex = 11
			Me._lblPortHighSpeed.Text = "Port (high speed)"
			' 
			' _lblProfileCnt
			' 
			Me._lblProfileCnt.AutoSize = True
			Me._lblProfileCnt.Location = New System.Drawing.Point(12, 138)
			Me._lblProfileCnt.Name = "_lblProfileCnt"
			Me._lblProfileCnt.Size = New System.Drawing.Size(95, 13)
			Me._lblProfileCnt.TabIndex = 12
			Me._lblProfileCnt.Text = "Number of profiles"
			' 
			' _txtboxProfileCnt
			' 
			Me._txtboxProfileCnt.Location = New System.Drawing.Point(118, 134)
			Me._txtboxProfileCnt.Name = "_txtboxProfileCnt"
			Me._txtboxProfileCnt.Size = New System.Drawing.Size(64, 21)
			Me._txtboxProfileCnt.TabIndex = 13
			Me._txtboxProfileCnt.Text = "1"
			' 
			' HighSpeedInitalizeForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(417, 204)
			Me.Controls.Add(Me._txtboxProfileCnt)
			Me.Controls.Add(Me._lblProfileCnt)
			Me.Controls.Add(Me._txtboxPortHighSpeed)
			Me.Controls.Add(Me._lblPortHighSpeed)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.Name = "HighSpeedInitalizeForm"
			Me.Text = "HighSpeedInitalize"
			Me.Controls.SetChildIndex(Me._btnCancel, 0)
			Me.Controls.SetChildIndex(Me._btnOk, 0)
			Me.Controls.SetChildIndex(Me._lblPortHighSpeed, 0)
			Me.Controls.SetChildIndex(Me._txtboxPortHighSpeed, 0)
			Me.Controls.SetChildIndex(Me._lblProfileCnt, 0)
			Me.Controls.SetChildIndex(Me._txtboxProfileCnt, 0)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _txtboxPortHighSpeed As System.Windows.Forms.TextBox
		Private _lblPortHighSpeed As System.Windows.Forms.Label
		Private _lblProfileCnt As System.Windows.Forms.Label
		Private _txtboxProfileCnt As System.Windows.Forms.TextBox
	End Class
End Namespace
