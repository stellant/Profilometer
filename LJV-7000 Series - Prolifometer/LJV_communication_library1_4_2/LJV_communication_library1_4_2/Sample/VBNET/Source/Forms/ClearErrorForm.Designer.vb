Namespace Forms
	Partial Class ClearErrorForm
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
			Me._lblClearErrCode = New System.Windows.Forms.Label()
			Me._txtboxErrCode = New System.Windows.Forms.TextBox()
			Me._lblHexErrCode = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(198, 62)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 33
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(102, 62)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 32
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			AddHandler Me._btnOk.Click, New System.EventHandler(AddressOf Me._btnOk_Click)
			' 
			' _lblClearErrCode
			' 
			Me._lblClearErrCode.AutoSize = True
			Me._lblClearErrCode.Location = New System.Drawing.Point(110, 21)
			Me._lblClearErrCode.Name = "_lblClearErrCode"
			Me._lblClearErrCode.Size = New System.Drawing.Size(155, 13)
			Me._lblClearErrCode.TabIndex = 34
			Me._lblClearErrCode.Text = "Error code of the error to clear"
			' 
			' _txtboxErrCode
			' 
			Me._txtboxErrCode.Location = New System.Drawing.Point(33, 16)
			Me._txtboxErrCode.MaxLength = 4
			Me._txtboxErrCode.Name = "_txtboxErrCode"
			Me._txtboxErrCode.Size = New System.Drawing.Size(71, 21)
			Me._txtboxErrCode.TabIndex = 35
			Me._txtboxErrCode.Text = "0084"
			' 
			' _lblHexErrCode
			' 
			Me._lblHexErrCode.AutoSize = True
			Me._lblHexErrCode.Location = New System.Drawing.Point(12, 21)
			Me._lblHexErrCode.Name = "_lblHexErrCode"
			Me._lblHexErrCode.Size = New System.Drawing.Size(19, 13)
			Me._lblHexErrCode.TabIndex = 37
			Me._lblHexErrCode.Text = "0x"
			' 
			' ClearErrorForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(292, 106)
			Me.Controls.Add(Me._lblHexErrCode)
			Me.Controls.Add(Me._txtboxErrCode)
			Me.Controls.Add(Me._lblClearErrCode)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ClearErrorForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Clear the error"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblClearErrCode As System.Windows.Forms.Label
		Private _txtboxErrCode As System.Windows.Forms.TextBox
		Private _lblHexErrCode As System.Windows.Forms.Label
	End Class
End Namespace
