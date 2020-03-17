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
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.GenuineSoftwareLogo = New System.Windows.Forms.PictureBox()
        Me.BenefitsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BottomPanel.SuspendLayout()
        CType(Me.GenuineSoftwareLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(32, 70)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(391, 51)
        Me.DescriptionLabel.TabIndex = 1
        Me.DescriptionLabel.Text = "Activation helps verify that your copy of Windows is genuine. With" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a genuine cop" &
    "y of Windows 7, you are eligible to receive all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "available updates and product s" &
    "upport from Microsoft."
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CloseBtn.Location = New System.Drawing.Point(530, 8)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 0
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(32, 32)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(199, 23)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Activation was successful"
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPanel.Controls.Add(Me.CloseBtn)
        Me.BottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.BottomPanel.TabIndex = 3
        '
        'GenuineSoftwareLogo
        '
        Me.GenuineSoftwareLogo.Image = CType(resources.GetObject("GenuineSoftwareLogo.Image"), System.Drawing.Image)
        Me.GenuineSoftwareLogo.Location = New System.Drawing.Point(465, 80)
        Me.GenuineSoftwareLogo.Name = "GenuineSoftwareLogo"
        Me.GenuineSoftwareLogo.Size = New System.Drawing.Size(112, 61)
        Me.GenuineSoftwareLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GenuineSoftwareLogo.TabIndex = 8
        Me.GenuineSoftwareLogo.TabStop = False
        '
        'BenefitsLinkLabel
        '
        Me.BenefitsLinkLabel.AutoSize = True
        Me.BenefitsLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BenefitsLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BenefitsLinkLabel.Location = New System.Drawing.Point(32, 135)
        Me.BenefitsLinkLabel.Name = "BenefitsLinkLabel"
        Me.BenefitsLinkLabel.Size = New System.Drawing.Size(347, 17)
        Me.BenefitsLinkLabel.TabIndex = 2
        Me.BenefitsLinkLabel.TabStop = True
        Me.BenefitsLinkLabel.Text = "Learn more online about the benefits of genuine Windows"
        '
        'Success
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.CloseBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.BenefitsLinkLabel)
        Me.Controls.Add(Me.GenuineSoftwareLogo)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BottomPanel)
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
        Me.BottomPanel.ResumeLayout(False)
        CType(Me.GenuineSoftwareLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents GenuineSoftwareLogo As PictureBox
    Friend WithEvents BenefitsLinkLabel As LinkLabel
End Class
