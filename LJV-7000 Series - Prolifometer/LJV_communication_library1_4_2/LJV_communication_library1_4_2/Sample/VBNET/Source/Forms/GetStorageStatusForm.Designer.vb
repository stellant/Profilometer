Namespace Forms
	Partial Class GetStorageStatusForm
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
			Me._txtboxInputValue = New System.Windows.Forms.TextBox()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._lblSendPos = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _txtboxInputValue
			' 
			Me._txtboxInputValue.Location = New System.Drawing.Point(155, 13)
			Me._txtboxInputValue.Name = "_txtboxInputValue"
			Me._txtboxInputValue.Size = New System.Drawing.Size(107, 21)
			Me._txtboxInputValue.TabIndex = 20
			Me._txtboxInputValue.Text = "0"
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(187, 52)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 19
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(106, 53)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 18
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblSendPos
			' 
			Me._lblSendPos.AutoSize = True
			Me._lblSendPos.Location = New System.Drawing.Point(20, 18)
			Me._lblSendPos.Name = "_lblSendPos"
			Me._lblSendPos.Size = New System.Drawing.Size(116, 13)
			Me._lblSendPos.TabIndex = 17
			Me._lblSendPos.Text = "Target surface to read"
			' 
			' GetStorageStatusForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(301, 91)
			Me.Controls.Add(Me._txtboxInputValue)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._lblSendPos)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GetStorageStatusForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "GetStorageStatusReq"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _txtboxInputValue As System.Windows.Forms.TextBox
		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblSendPos As System.Windows.Forms.Label
	End Class
End Namespace
