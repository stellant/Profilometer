Namespace Forms
	Partial Class GetErrorForm
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
			Me._txtboxErrCnt = New System.Windows.Forms.TextBox()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._lblErrCnt = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _txtboxErrCnt
			' 
			Me._txtboxErrCnt.Location = New System.Drawing.Point(180, 13)
			Me._txtboxErrCnt.Name = "_txtboxErrCnt"
			Me._txtboxErrCnt.Size = New System.Drawing.Size(75, 21)
			Me._txtboxErrCnt.TabIndex = 12
			Me._txtboxErrCnt.Text = "10"
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(180, 62)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 11
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(75, 62)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 10
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblErrCnt
			' 
			Me._lblErrCnt.Location = New System.Drawing.Point(17, 10)
			Me._lblErrCnt.Name = "_lblErrCnt"
			Me._lblErrCnt.Size = New System.Drawing.Size(157, 38)
			Me._lblErrCnt.TabIndex = 9
			Me._lblErrCnt.Text = "Amount of system " & vbCr & vbLf & "error information to receive"
			' 
			' GetErrorForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(266, 102)
			Me.Controls.Add(Me._txtboxErrCnt)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._lblErrCnt)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GetErrorForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Get the detailed error information."
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _txtboxErrCnt As System.Windows.Forms.TextBox
		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblErrCnt As System.Windows.Forms.Label
	End Class
End Namespace
