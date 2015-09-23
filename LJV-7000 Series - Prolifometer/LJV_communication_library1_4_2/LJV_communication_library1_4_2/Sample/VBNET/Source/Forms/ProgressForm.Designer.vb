

Partial Class ProgressForm
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
		Me._lblStatus = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		' _lblStatus
		' 
		Me._lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
		Me._lblStatus.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me._lblStatus.Location = New System.Drawing.Point(0, 0)
		Me._lblStatus.Name = "_lblStatus"
		Me._lblStatus.Size = New System.Drawing.Size(284, 66)
		Me._lblStatus.TabIndex = 0
		Me._lblStatus.Text = "Processing"
		Me._lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' ProgressForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 66)
		Me.ControlBox = False
		Me.Controls.Add(Me._lblStatus)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.Name = "ProgressForm"
		Me.Text = "ProgressForm"
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _lblStatus As System.Windows.Forms.Label
End Class
