<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Success
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Success))
        Me.descLabel = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.genuineSoftwarePicture = New System.Windows.Forms.PictureBox()
        Me.benefitsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.bottomPanel.SuspendLayout()
        CType(Me.genuineSoftwarePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(32, 70)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(391, 51)
        Me.descLabel.TabIndex = 7
        Me.descLabel.Text = "Activation helps verify that your copy of Windows is genuine. With" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a genuine cop" &
    "y of Windows 7, you are eligible to receive all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "available updates and product s" &
    "upport from Microsoft."
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.Control
        Me.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.closeBtn.Location = New System.Drawing.Point(530, 8)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(75, 23)
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(32, 32)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.TabIndex = 6
        Me.TitleLabel.Size = New System.Drawing.Size(199, 23)
        Me.TitleLabel.Text = "Activation was successful"
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bottomPanel.Controls.Add(Me.closeBtn)
        Me.bottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.bottomPanel.TabIndex = 5
        '
        'genuineSoftwarePicture
        '
        Me.genuineSoftwarePicture.Image = CType(resources.GetObject("genuineSoftwarePicture.Image"), System.Drawing.Image)
        Me.genuineSoftwarePicture.Location = New System.Drawing.Point(465, 80)
        Me.genuineSoftwarePicture.Name = "genuineSoftwarePicture"
        Me.genuineSoftwarePicture.Size = New System.Drawing.Size(112, 61)
        Me.genuineSoftwarePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.genuineSoftwarePicture.TabIndex = 8
        Me.genuineSoftwarePicture.TabStop = False
        '
        'benefitsLinkLabel
        '
        Me.benefitsLinkLabel.AutoSize = True
        Me.benefitsLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.benefitsLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.benefitsLinkLabel.Location = New System.Drawing.Point(32, 135)
        Me.benefitsLinkLabel.Name = "benefitsLinkLabel"
        Me.benefitsLinkLabel.Size = New System.Drawing.Size(347, 17)
        Me.benefitsLinkLabel.TabIndex = 9
        Me.benefitsLinkLabel.TabStop = True
        Me.benefitsLinkLabel.Text = "Learn more online about the benefits of genuine Windows"
        '
        'Success
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.closeBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.benefitsLinkLabel)
        Me.Controls.Add(Me.genuineSoftwarePicture)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.bottomPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(633, 551)
        Me.Name = "Success"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Activation"
        Me.TopMost = True
        Me.bottomPanel.ResumeLayout(False)
        CType(Me.genuineSoftwarePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descLabel As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents titleLabel As Label
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents genuineSoftwarePicture As PictureBox
    Friend WithEvents benefitsLinkLabel As LinkLabel
End Class
