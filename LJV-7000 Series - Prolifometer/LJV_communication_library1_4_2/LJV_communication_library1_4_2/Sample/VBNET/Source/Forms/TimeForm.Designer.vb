Namespace Forms
	Partial Class TimeForm
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
			Me._txtboxYear = New System.Windows.Forms.TextBox()
			Me._lblYear = New System.Windows.Forms.Label()
			Me._txtboxMonth = New System.Windows.Forms.TextBox()
			Me._lblMonth = New System.Windows.Forms.Label()
			Me._txtboxDay = New System.Windows.Forms.TextBox()
			Me._lblDay = New System.Windows.Forms.Label()
			Me._txtboxHour = New System.Windows.Forms.TextBox()
			Me._lblHour = New System.Windows.Forms.Label()
			Me._txtboxMinute = New System.Windows.Forms.TextBox()
			Me._lblMinute = New System.Windows.Forms.Label()
			Me._txtboxSecond = New System.Windows.Forms.TextBox()
			Me._lblSecond = New System.Windows.Forms.Label()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me._btnOk = New System.Windows.Forms.Button()
			Me._lblTimeDescription = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _txtboxYear
			' 
			Me._txtboxYear.Location = New System.Drawing.Point(69, 49)
			Me._txtboxYear.Name = "_txtboxYear"
			Me._txtboxYear.Size = New System.Drawing.Size(99, 21)
			Me._txtboxYear.TabIndex = 28
			Me._txtboxYear.Text = "99"
			' 
			' _lblYear
			' 
			Me._lblYear.AutoSize = True
			Me._lblYear.Location = New System.Drawing.Point(24, 52)
			Me._lblYear.Name = "_lblYear"
			Me._lblYear.Size = New System.Drawing.Size(29, 13)
			Me._lblYear.TabIndex = 27
			Me._lblYear.Text = "Year"
			' 
			' _txtboxMonth
			' 
			Me._txtboxMonth.Location = New System.Drawing.Point(69, 76)
			Me._txtboxMonth.Name = "_txtboxMonth"
			Me._txtboxMonth.Size = New System.Drawing.Size(99, 21)
			Me._txtboxMonth.TabIndex = 30
			Me._txtboxMonth.Text = "1"
			' 
			' _lblMonth
			' 
			Me._lblMonth.AutoSize = True
			Me._lblMonth.Location = New System.Drawing.Point(24, 79)
			Me._lblMonth.Name = "_lblMonth"
			Me._lblMonth.Size = New System.Drawing.Size(37, 13)
			Me._lblMonth.TabIndex = 29
			Me._lblMonth.Text = "Month"
			' 
			' _txtboxDay
			' 
			Me._txtboxDay.Location = New System.Drawing.Point(69, 103)
			Me._txtboxDay.Name = "_txtboxDay"
			Me._txtboxDay.Size = New System.Drawing.Size(99, 21)
			Me._txtboxDay.TabIndex = 32
			Me._txtboxDay.Text = "1"
			' 
			' _lblDay
			' 
			Me._lblDay.AutoSize = True
			Me._lblDay.Location = New System.Drawing.Point(24, 106)
			Me._lblDay.Name = "_lblDay"
			Me._lblDay.Size = New System.Drawing.Size(26, 13)
			Me._lblDay.TabIndex = 31
			Me._lblDay.Text = "Day"
			' 
			' _txtboxHour
			' 
			Me._txtboxHour.Location = New System.Drawing.Point(69, 140)
			Me._txtboxHour.Name = "_txtboxHour"
			Me._txtboxHour.Size = New System.Drawing.Size(99, 21)
			Me._txtboxHour.TabIndex = 34
			Me._txtboxHour.Text = "0"
			' 
			' _lblHour
			' 
			Me._lblHour.AutoSize = True
			Me._lblHour.Location = New System.Drawing.Point(24, 143)
			Me._lblHour.Name = "_lblHour"
			Me._lblHour.Size = New System.Drawing.Size(30, 13)
			Me._lblHour.TabIndex = 33
			Me._lblHour.Text = "Hour"
			' 
			' _txtboxMinute
			' 
			Me._txtboxMinute.Location = New System.Drawing.Point(69, 167)
			Me._txtboxMinute.Name = "_txtboxMinute"
			Me._txtboxMinute.Size = New System.Drawing.Size(99, 21)
			Me._txtboxMinute.TabIndex = 36
			Me._txtboxMinute.Text = "0"
			' 
			' _lblMinute
			' 
			Me._lblMinute.AutoSize = True
			Me._lblMinute.Location = New System.Drawing.Point(24, 170)
			Me._lblMinute.Name = "_lblMinute"
			Me._lblMinute.Size = New System.Drawing.Size(39, 13)
			Me._lblMinute.TabIndex = 35
			Me._lblMinute.Text = "Minute"
			' 
			' _txtboxSecond
			' 
			Me._txtboxSecond.Location = New System.Drawing.Point(69, 194)
			Me._txtboxSecond.Name = "_txtboxSecond"
			Me._txtboxSecond.Size = New System.Drawing.Size(99, 21)
			Me._txtboxSecond.TabIndex = 38
			Me._txtboxSecond.Text = "0"
			' 
			' _lblSecond
			' 
			Me._lblSecond.AutoSize = True
			Me._lblSecond.Location = New System.Drawing.Point(24, 197)
			Me._lblSecond.Name = "_lblSecond"
			Me._lblSecond.Size = New System.Drawing.Size(42, 13)
			Me._lblSecond.TabIndex = 37
			Me._lblSecond.Text = "Second"
			' 
			' _btnCancel
			' 
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(107, 237)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(75, 25)
			Me._btnCancel.TabIndex = 40
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' _btnOk
			' 
			Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOk.Location = New System.Drawing.Point(12, 237)
			Me._btnOk.Name = "_btnOk"
			Me._btnOk.Size = New System.Drawing.Size(75, 25)
			Me._btnOk.TabIndex = 39
			Me._btnOk.Text = "OK"
			Me._btnOk.UseVisualStyleBackColor = True
			' 
			' _lblTimeDescription
			' 
			Me._lblTimeDescription.AutoSize = True
			Me._lblTimeDescription.Location = New System.Drawing.Point(44, 20)
			Me._lblTimeDescription.Name = "_lblTimeDescription"
			Me._lblTimeDescription.Size = New System.Drawing.Size(115, 13)
			Me._lblTimeDescription.TabIndex = 41
			Me._lblTimeDescription.Text = "Input range (0 to 255)"
			' 
			' TimeForm
			' 
			Me.AcceptButton = Me._btnOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(203, 285)
			Me.Controls.Add(Me._lblTimeDescription)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOk)
			Me.Controls.Add(Me._txtboxSecond)
			Me.Controls.Add(Me._lblSecond)
			Me.Controls.Add(Me._txtboxMinute)
			Me.Controls.Add(Me._lblMinute)
			Me.Controls.Add(Me._txtboxHour)
			Me.Controls.Add(Me._lblHour)
			Me.Controls.Add(Me._txtboxDay)
			Me.Controls.Add(Me._lblDay)
			Me.Controls.Add(Me._txtboxMonth)
			Me.Controls.Add(Me._lblMonth)
			Me.Controls.Add(Me._txtboxYear)
			Me.Controls.Add(Me._lblYear)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "TimeForm"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Date and time settings"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _txtboxYear As System.Windows.Forms.TextBox
		Private _lblYear As System.Windows.Forms.Label
		Private _txtboxMonth As System.Windows.Forms.TextBox
		Private _lblMonth As System.Windows.Forms.Label
		Private _txtboxDay As System.Windows.Forms.TextBox
		Private _lblDay As System.Windows.Forms.Label
		Private _txtboxHour As System.Windows.Forms.TextBox
		Private _lblHour As System.Windows.Forms.Label
		Private _txtboxMinute As System.Windows.Forms.TextBox
		Private _lblMinute As System.Windows.Forms.Label
		Private _txtboxSecond As System.Windows.Forms.TextBox
		Private _lblSecond As System.Windows.Forms.Label
		Private _btnCancel As System.Windows.Forms.Button
		Private _btnOk As System.Windows.Forms.Button
		Private _lblTimeDescription As System.Windows.Forms.Label
	End Class
End Namespace
