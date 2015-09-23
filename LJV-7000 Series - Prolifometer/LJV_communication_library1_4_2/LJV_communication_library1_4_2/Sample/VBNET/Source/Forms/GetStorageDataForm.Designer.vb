Namespace Forms
	Partial Class GetStorageDataForm
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
			Me._lblSurface = New System.Windows.Forms.Label()
			Me._lblStartNo = New System.Windows.Forms.Label()
			Me._lblDataCnt = New System.Windows.Forms.Label()
			Me._txtboxSurface = New System.Windows.Forms.TextBox()
			Me._txtboxStartNo = New System.Windows.Forms.TextBox()
			Me._txtboxDataCnt = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(219, 130)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 4
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(128, 130)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 3
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblSurface
			' 
			Me._lblSurface.AutoSize = True
			Me._lblSurface.Location = New System.Drawing.Point(126, 16)
			Me._lblSurface.Name = "_lblSurface"
			Me._lblSurface.Size = New System.Drawing.Size(122, 13)
			Me._lblSurface.TabIndex = 21
			Me._lblSurface.Text = "Storage surface to read"
			' 
			' _lblStartNo
			' 
			Me._lblStartNo.AutoSize = True
			Me._lblStartNo.Location = New System.Drawing.Point(126, 57)
			Me._lblStartNo.Name = "_lblStartNo"
			Me._lblStartNo.Size = New System.Drawing.Size(172, 13)
			Me._lblStartNo.TabIndex = 22
			Me._lblStartNo.Text = "Data number to start reading from"
			' 
			' _lblDataCnt
			' 
			Me._lblDataCnt.AutoSize = True
			Me._lblDataCnt.Location = New System.Drawing.Point(126, 93)
			Me._lblDataCnt.Name = "_lblDataCnt"
			Me._lblDataCnt.Size = New System.Drawing.Size(123, 13)
			Me._lblDataCnt.TabIndex = 23
			Me._lblDataCnt.Text = "Number of items to read"
			' 
			' _txtboxSurface
			' 
			Me._txtboxSurface.Location = New System.Drawing.Point(12, 13)
			Me._txtboxSurface.Name = "_txtboxSurface"
			Me._txtboxSurface.Size = New System.Drawing.Size(100, 21)
			Me._txtboxSurface.TabIndex = 0
			Me._txtboxSurface.Text = "0"
			' 
			' _txtboxStartNo
			' 
			Me._txtboxStartNo.Location = New System.Drawing.Point(12, 50)
			Me._txtboxStartNo.Name = "_txtboxStartNo"
			Me._txtboxStartNo.Size = New System.Drawing.Size(100, 21)
			Me._txtboxStartNo.TabIndex = 1
			Me._txtboxStartNo.Text = "0"
			' 
			' _txtboxDataCnt
			' 
			Me._txtboxDataCnt.Location = New System.Drawing.Point(12, 90)
			Me._txtboxDataCnt.Name = "_txtboxDataCnt"
			Me._txtboxDataCnt.Size = New System.Drawing.Size(100, 21)
			Me._txtboxDataCnt.TabIndex = 2
			Me._txtboxDataCnt.Text = "1"
			' 
			' GetStorageDataForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(317, 170)
			Me.Controls.Add(Me._txtboxDataCnt)
			Me.Controls.Add(Me._txtboxStartNo)
			Me.Controls.Add(Me._txtboxSurface)
			Me.Controls.Add(Me._lblDataCnt)
			Me.Controls.Add(Me._lblStartNo)
			Me.Controls.Add(Me._lblSurface)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GetStorageDataForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "GetStorageData"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblSurface As System.Windows.Forms.Label
		Private _lblStartNo As System.Windows.Forms.Label
		Private _lblDataCnt As System.Windows.Forms.Label
		Private _txtboxSurface As System.Windows.Forms.TextBox
		Private _txtboxStartNo As System.Windows.Forms.TextBox
		Private _txtboxDataCnt As System.Windows.Forms.TextBox
	End Class
End Namespace
