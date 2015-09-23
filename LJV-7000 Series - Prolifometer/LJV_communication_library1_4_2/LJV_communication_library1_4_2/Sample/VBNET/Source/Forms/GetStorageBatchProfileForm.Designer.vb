Namespace Forms
	Partial Class GetStorageBatchProfileForm
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
			Me._txtboxGetBatchTopProfNo = New System.Windows.Forms.TextBox()
			Me._txtboxGetBatchNo = New System.Windows.Forms.TextBox()
			Me._txtboxSurface = New System.Windows.Forms.TextBox()
			Me._lblGetBatchTopProfNo = New System.Windows.Forms.Label()
			Me._lblGetBatchNo = New System.Windows.Forms.Label()
			Me._lblSurface = New System.Windows.Forms.Label()
			Me._txtboxGetProfCnt = New System.Windows.Forms.TextBox()
			Me._lblGetProfCnt = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(268, 168)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 5
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(177, 168)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 4
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _txtboxGetBatchTopProfNo
			' 
			Me._txtboxGetBatchTopProfNo.Location = New System.Drawing.Point(12, 87)
			Me._txtboxGetBatchTopProfNo.Name = "_txtboxGetBatchTopProfNo"
			Me._txtboxGetBatchTopProfNo.Size = New System.Drawing.Size(100, 21)
			Me._txtboxGetBatchTopProfNo.TabIndex = 2
			Me._txtboxGetBatchTopProfNo.Text = "1"
			' 
			' _txtboxGetBatchNo
			' 
			Me._txtboxGetBatchNo.Location = New System.Drawing.Point(12, 50)
			Me._txtboxGetBatchNo.Name = "_txtboxGetBatchNo"
			Me._txtboxGetBatchNo.Size = New System.Drawing.Size(100, 21)
			Me._txtboxGetBatchNo.TabIndex = 1
			Me._txtboxGetBatchNo.Text = "0"
			' 
			' _txtboxSurface
			' 
			Me._txtboxSurface.Location = New System.Drawing.Point(12, 13)
			Me._txtboxSurface.Name = "_txtboxSurface"
			Me._txtboxSurface.Size = New System.Drawing.Size(100, 21)
			Me._txtboxSurface.TabIndex = 0
			Me._txtboxSurface.Text = "0"
			' 
			' _lblGetBatchTopProfNo
			' 
			Me._lblGetBatchTopProfNo.AutoSize = True
			Me._lblGetBatchTopProfNo.Location = New System.Drawing.Point(126, 81)
			Me._lblGetBatchTopProfNo.Name = "_lblGetBatchTopProfNo"
			Me._lblGetBatchTopProfNo.Size = New System.Drawing.Size(208, 26)
			Me._lblGetBatchTopProfNo.TabIndex = 29
			Me._lblGetBatchTopProfNo.Text = "From what profile number " & vbCr & vbLf & "in the batch do you want to get the data?"
			' 
			' _lblGetBatchNo
			' 
			Me._lblGetBatchNo.AutoSize = True
			Me._lblGetBatchNo.Location = New System.Drawing.Point(126, 53)
			Me._lblGetBatchNo.Name = "_lblGetBatchNo"
			Me._lblGetBatchNo.Size = New System.Drawing.Size(111, 13)
			Me._lblGetBatchNo.TabIndex = 28
			Me._lblGetBatchNo.Text = "Batch number to read"
			' 
			' _lblSurface
			' 
			Me._lblSurface.AutoSize = True
			Me._lblSurface.Location = New System.Drawing.Point(126, 16)
			Me._lblSurface.Name = "_lblSurface"
			Me._lblSurface.Size = New System.Drawing.Size(122, 13)
			Me._lblSurface.TabIndex = 27
			Me._lblSurface.Text = "Storage surface to read"
			' 
			' _txtboxGetProfCnt
			' 
			Me._txtboxGetProfCnt.Location = New System.Drawing.Point(12, 129)
			Me._txtboxGetProfCnt.Name = "_txtboxGetProfCnt"
			Me._txtboxGetProfCnt.Size = New System.Drawing.Size(100, 21)
			Me._txtboxGetProfCnt.TabIndex = 3
			Me._txtboxGetProfCnt.Text = "1"
			' 
			' _lblGetProfCnt
			' 
			Me._lblGetProfCnt.AutoSize = True
			Me._lblGetProfCnt.Location = New System.Drawing.Point(126, 137)
			Me._lblGetProfCnt.Name = "_lblGetProfCnt"
			Me._lblGetProfCnt.Size = New System.Drawing.Size(133, 13)
			Me._lblGetProfCnt.TabIndex = 33
			Me._lblGetProfCnt.Text = "Number of profiles to read"
			' 
			' GetStorageBatchProfileForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(360, 204)
			Me.Controls.Add(Me._txtboxGetProfCnt)
			Me.Controls.Add(Me._lblGetProfCnt)
			Me.Controls.Add(Me._txtboxGetBatchTopProfNo)
			Me.Controls.Add(Me._txtboxGetBatchNo)
			Me.Controls.Add(Me._txtboxSurface)
			Me.Controls.Add(Me._lblGetBatchTopProfNo)
			Me.Controls.Add(Me._lblGetBatchNo)
			Me.Controls.Add(Me._lblSurface)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GetStorageBatchProfileForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "GetStorageBatchProfileForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _txtboxGetBatchTopProfNo As System.Windows.Forms.TextBox
		Private _txtboxGetBatchNo As System.Windows.Forms.TextBox
		Private _txtboxSurface As System.Windows.Forms.TextBox
		Private _lblGetBatchTopProfNo As System.Windows.Forms.Label
		Private _lblGetBatchNo As System.Windows.Forms.Label
		Private _lblSurface As System.Windows.Forms.Label
		Private _txtboxGetProfCnt As System.Windows.Forms.TextBox
		Private _lblGetProfCnt As System.Windows.Forms.Label
	End Class
End Namespace
