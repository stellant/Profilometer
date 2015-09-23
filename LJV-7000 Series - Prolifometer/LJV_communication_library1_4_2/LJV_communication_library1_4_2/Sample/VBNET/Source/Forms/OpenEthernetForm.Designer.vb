Namespace Forms
	Partial Class OpenEthernetForm
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
			Me._lblIpAddress = New System.Windows.Forms.Label()
			Me._txtboxIpFirstSegment = New System.Windows.Forms.TextBox()
			Me._txtboxIpSecondSegment = New System.Windows.Forms.TextBox()
			Me._txtboxIpThirdSegment = New System.Windows.Forms.TextBox()
			Me._txtboxIpFourthSegment = New System.Windows.Forms.TextBox()
			Me._lblPort = New System.Windows.Forms.Label()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._txtboxPort = New System.Windows.Forms.TextBox()
			Me._lblDescription = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _lblIpAddress
			' 
			Me._lblIpAddress.AutoSize = True
			Me._lblIpAddress.Location = New System.Drawing.Point(12, 40)
			Me._lblIpAddress.Name = "_lblIpAddress"
			Me._lblIpAddress.Size = New System.Drawing.Size(58, 13)
			Me._lblIpAddress.TabIndex = 0
			Me._lblIpAddress.Text = "IP address"
			' 
			' _txtboxIpFirstSegment
			' 
			Me._txtboxIpFirstSegment.Location = New System.Drawing.Point(81, 37)
			Me._txtboxIpFirstSegment.Name = "_txtboxIpFirstSegment"
			Me._txtboxIpFirstSegment.Size = New System.Drawing.Size(44, 21)
			Me._txtboxIpFirstSegment.TabIndex = 1
			Me._txtboxIpFirstSegment.Text = "192"
			' 
			' _txtboxIpSecondSegment
			' 
			Me._txtboxIpSecondSegment.Location = New System.Drawing.Point(131, 37)
			Me._txtboxIpSecondSegment.Name = "_txtboxIpSecondSegment"
			Me._txtboxIpSecondSegment.Size = New System.Drawing.Size(44, 21)
			Me._txtboxIpSecondSegment.TabIndex = 2
			Me._txtboxIpSecondSegment.Text = "168"
			' 
			' _txtboxIpThirdSegment
			' 
			Me._txtboxIpThirdSegment.Location = New System.Drawing.Point(181, 37)
			Me._txtboxIpThirdSegment.Name = "_txtboxIpThirdSegment"
			Me._txtboxIpThirdSegment.Size = New System.Drawing.Size(44, 21)
			Me._txtboxIpThirdSegment.TabIndex = 3
			Me._txtboxIpThirdSegment.Text = "0"
			' 
			' _txtboxIpFourthSegment
			' 
			Me._txtboxIpFourthSegment.Location = New System.Drawing.Point(231, 37)
			Me._txtboxIpFourthSegment.Name = "_txtboxIpFourthSegment"
			Me._txtboxIpFourthSegment.Size = New System.Drawing.Size(44, 21)
			Me._txtboxIpFourthSegment.TabIndex = 4
			Me._txtboxIpFourthSegment.Text = "1"
			' 
			' _lblPort
			' 
			Me._lblPort.AutoSize = True
			Me._lblPort.Location = New System.Drawing.Point(12, 74)
			Me._lblPort.Name = "_lblPort"
			Me._lblPort.Size = New System.Drawing.Size(27, 13)
			Me._lblPort.TabIndex = 5
			Me._lblPort.Text = "Port"
			' 
			' _btnOk
			' 
			Me._btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(231, 104)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 6
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _btnCancel
			' 
			Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(327, 104)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 7
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _txtboxPort
			' 
			Me._txtboxPort.Location = New System.Drawing.Point(81, 70)
			Me._txtboxPort.Name = "_txtboxPort"
			Me._txtboxPort.Size = New System.Drawing.Size(194, 21)
			Me._txtboxPort.TabIndex = 8
			Me._txtboxPort.Text = "24691"
			' 
			' _lblDescription
			' 
			Me._lblDescription.AutoSize = True
			Me._lblDescription.Location = New System.Drawing.Point(12, 10)
			Me._lblDescription.Name = "_lblDescription"
			Me._lblDescription.Size = New System.Drawing.Size(365, 13)
			Me._lblDescription.TabIndex = 9
			Me._lblDescription.Text = "[Valid range] The IP address is a byte value and the port is a ushort value."
			' 
			' OpenEthernetForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(414, 142)
			Me.Controls.Add(Me._lblDescription)
			Me.Controls.Add(Me._txtboxPort)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._lblPort)
			Me.Controls.Add(Me._txtboxIpFourthSegment)
			Me.Controls.Add(Me._txtboxIpThirdSegment)
			Me.Controls.Add(Me._txtboxIpSecondSegment)
			Me.Controls.Add(Me._txtboxIpFirstSegment)
			Me.Controls.Add(Me._lblIpAddress)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "OpenEthernetForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Open Ethernet"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _lblIpAddress As System.Windows.Forms.Label
		Private _txtboxIpFirstSegment As System.Windows.Forms.TextBox
		Private _txtboxIpSecondSegment As System.Windows.Forms.TextBox
		Private _txtboxIpThirdSegment As System.Windows.Forms.TextBox
		Private _txtboxIpFourthSegment As System.Windows.Forms.TextBox
		Private _lblPort As System.Windows.Forms.Label
		Private _txtboxPort As System.Windows.Forms.TextBox
		Private _lblDescription As System.Windows.Forms.Label
		Public _btnOk As System.Windows.Forms.Button
		Public _btnCancel As System.Windows.Forms.Button
	End Class
End Namespace
