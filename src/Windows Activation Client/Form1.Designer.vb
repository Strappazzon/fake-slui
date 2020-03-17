<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.SkipBtn = New System.Windows.Forms.Button()
        Me.ActivateBtn = New System.Windows.Forms.Button()
        Me.HelpActivationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PrivacyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.RetypeBtn = New System.Windows.Forms.Button()
        Me.BottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPanel.Controls.Add(Me.CancelBtn)
        Me.BottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.BottomPanel.TabIndex = 7
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelBtn.Location = New System.Drawing.Point(530, 8)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 0
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(32, 32)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(182, 23)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Activate Windows now"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(32, 70)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(418, 34)
        Me.DescriptionLabel.TabIndex = 1
        Me.DescriptionLabel.Text = "Your activation period has expired and Windows is no longer working." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To use Wind" &
    "ows you must activate this copy of Windows."
        '
        'SkipBtn
        '
        Me.SkipBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SkipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SkipBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkipBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.SkipBtn.Image = CType(resources.GetObject("SkipBtn.Image"), System.Drawing.Image)
        Me.SkipBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SkipBtn.Location = New System.Drawing.Point(33, 180)
        Me.SkipBtn.Name = "SkipBtn"
        Me.SkipBtn.Size = New System.Drawing.Size(553, 41)
        Me.SkipBtn.TabIndex = 3
        Me.SkipBtn.Text = "     Access your computer with reduced functionality"
        Me.SkipBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SkipBtn.UseVisualStyleBackColor = False
        '
        'ActivateBtn
        '
        Me.ActivateBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ActivateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ActivateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ActivateBtn.Image = CType(resources.GetObject("ActivateBtn.Image"), System.Drawing.Image)
        Me.ActivateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActivateBtn.Location = New System.Drawing.Point(33, 125)
        Me.ActivateBtn.Name = "ActivateBtn"
        Me.ActivateBtn.Size = New System.Drawing.Size(553, 41)
        Me.ActivateBtn.TabIndex = 2
        Me.ActivateBtn.Text = "     Activate Windows online now"
        Me.ActivateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActivateBtn.UseVisualStyleBackColor = False
        '
        'HelpActivationLinkLabel
        '
        Me.HelpActivationLinkLabel.AutoSize = True
        Me.HelpActivationLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpActivationLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HelpActivationLinkLabel.Location = New System.Drawing.Point(32, 395)
        Me.HelpActivationLinkLabel.Name = "HelpActivationLinkLabel"
        Me.HelpActivationLinkLabel.Size = New System.Drawing.Size(116, 17)
        Me.HelpActivationLinkLabel.TabIndex = 5
        Me.HelpActivationLinkLabel.TabStop = True
        Me.HelpActivationLinkLabel.Text = "What is activation?"
        '
        'PrivacyLinkLabel
        '
        Me.PrivacyLinkLabel.AutoSize = True
        Me.PrivacyLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivacyLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.PrivacyLinkLabel.Location = New System.Drawing.Point(32, 415)
        Me.PrivacyLinkLabel.Name = "PrivacyLinkLabel"
        Me.PrivacyLinkLabel.Size = New System.Drawing.Size(205, 17)
        Me.PrivacyLinkLabel.TabIndex = 6
        Me.PrivacyLinkLabel.TabStop = True
        Me.PrivacyLinkLabel.Text = "Read the privacy statement online"
        '
        'RetypeBtn
        '
        Me.RetypeBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RetypeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RetypeBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetypeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.RetypeBtn.Image = CType(resources.GetObject("RetypeBtn.Image"), System.Drawing.Image)
        Me.RetypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RetypeBtn.Location = New System.Drawing.Point(33, 235)
        Me.RetypeBtn.Name = "RetypeBtn"
        Me.RetypeBtn.Size = New System.Drawing.Size(553, 41)
        Me.RetypeBtn.TabIndex = 4
        Me.RetypeBtn.Text = "     Retype your product key"
        Me.RetypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RetypeBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.RetypeBtn)
        Me.Controls.Add(Me.HelpActivationLinkLabel)
        Me.Controls.Add(Me.PrivacyLinkLabel)
        Me.Controls.Add(Me.SkipBtn)
        Me.Controls.Add(Me.ActivateBtn)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BottomPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(633, 551)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Activation"
        Me.TopMost = True
        Me.BottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BottomPanel As Panel
    Friend WithEvents CancelBtn As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ActivateBtn As Button
    Friend WithEvents SkipBtn As Button
    Friend WithEvents HelpActivationLinkLabel As LinkLabel
    Friend WithEvents PrivacyLinkLabel As LinkLabel
    Friend WithEvents RetypeBtn As Button
End Class
