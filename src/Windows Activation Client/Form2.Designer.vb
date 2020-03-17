<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ProductKeyHelpTitleLabel = New System.Windows.Forms.Label()
        Me.ProductKeyHelpLabel = New System.Windows.Forms.Label()
        Me.ProductKeyHelpLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ProductKeyTextLabel = New System.Windows.Forms.Label()
        Me.ProductKeyTextBox = New System.Windows.Forms.TextBox()
        Me.PrivacyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.HelpActivationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelBtn.Location = New System.Drawing.Point(530, 8)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPanel.Controls.Add(Me.NextBtn)
        Me.BottomPanel.Controls.Add(Me.CancelBtn)
        Me.BottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.BottomPanel.TabIndex = 9
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NextBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NextBtn.Location = New System.Drawing.Point(449, 8)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(75, 23)
        Me.NextBtn.TabIndex = 0
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(32, 70)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(487, 34)
        Me.DescriptionLabel.TabIndex = 1
        Me.DescriptionLabel.Text = "The Windows 7 product key can be found on the installation disc holder inside the" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows package. Activation will register the product key to this computer."
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(32, 32)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(179, 23)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Type your product key"
        '
        'ProductKeyHelpTitleLabel
        '
        Me.ProductKeyHelpTitleLabel.AutoSize = True
        Me.ProductKeyHelpTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductKeyHelpTitleLabel.Location = New System.Drawing.Point(32, 150)
        Me.ProductKeyHelpTitleLabel.Name = "ProductKeyHelpTitleLabel"
        Me.ProductKeyHelpTitleLabel.Size = New System.Drawing.Size(187, 17)
        Me.ProductKeyHelpTitleLabel.TabIndex = 2
        Me.ProductKeyHelpTitleLabel.Text = "The product key looks like this:"
        '
        'ProductKeyHelpLabel
        '
        Me.ProductKeyHelpLabel.AutoSize = True
        Me.ProductKeyHelpLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductKeyHelpLabel.Location = New System.Drawing.Point(62, 190)
        Me.ProductKeyHelpLabel.Name = "ProductKeyHelpLabel"
        Me.ProductKeyHelpLabel.Size = New System.Drawing.Size(392, 20)
        Me.ProductKeyHelpLabel.TabIndex = 3
        Me.ProductKeyHelpLabel.Text = "PRODUCT KEY: XXXXX-XXXXX-XXXXX-XXXXX-XXXXX"
        '
        'ProductKeyHelpLinkLabel
        '
        Me.ProductKeyHelpLinkLabel.AutoSize = True
        Me.ProductKeyHelpLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductKeyHelpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ProductKeyHelpLinkLabel.Location = New System.Drawing.Point(32, 230)
        Me.ProductKeyHelpLinkLabel.Name = "ProductKeyHelpLinkLabel"
        Me.ProductKeyHelpLinkLabel.Size = New System.Drawing.Size(256, 17)
        Me.ProductKeyHelpLinkLabel.TabIndex = 4
        Me.ProductKeyHelpLinkLabel.TabStop = True
        Me.ProductKeyHelpLinkLabel.Text = "Where do I find my Windows product key?"
        '
        'ProductKeyTextLabel
        '
        Me.ProductKeyTextLabel.AutoSize = True
        Me.ProductKeyTextLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductKeyTextLabel.Location = New System.Drawing.Point(32, 290)
        Me.ProductKeyTextLabel.Name = "ProductKeyTextLabel"
        Me.ProductKeyTextLabel.Size = New System.Drawing.Size(81, 17)
        Me.ProductKeyTextLabel.TabIndex = 5
        Me.ProductKeyTextLabel.Text = "Product Key:"
        '
        'ProductKeyTextBox
        '
        Me.ProductKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProductKeyTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductKeyTextBox.Location = New System.Drawing.Point(155, 287)
        Me.ProductKeyTextBox.MaxLength = 29
        Me.ProductKeyTextBox.Name = "ProductKeyTextBox"
        Me.ProductKeyTextBox.Size = New System.Drawing.Size(332, 25)
        Me.ProductKeyTextBox.TabIndex = 6
        Me.ProductKeyTextBox.WordWrap = False
        '
        'PrivacyLinkLabel
        '
        Me.PrivacyLinkLabel.AutoSize = True
        Me.PrivacyLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivacyLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.PrivacyLinkLabel.Location = New System.Drawing.Point(32, 415)
        Me.PrivacyLinkLabel.Name = "PrivacyLinkLabel"
        Me.PrivacyLinkLabel.Size = New System.Drawing.Size(205, 17)
        Me.PrivacyLinkLabel.TabIndex = 8
        Me.PrivacyLinkLabel.TabStop = True
        Me.PrivacyLinkLabel.Text = "Read the privacy statement online"
        '
        'HelpActivationLinkLabel
        '
        Me.HelpActivationLinkLabel.AutoSize = True
        Me.HelpActivationLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpActivationLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HelpActivationLinkLabel.Location = New System.Drawing.Point(32, 395)
        Me.HelpActivationLinkLabel.Name = "HelpActivationLinkLabel"
        Me.HelpActivationLinkLabel.Size = New System.Drawing.Size(116, 17)
        Me.HelpActivationLinkLabel.TabIndex = 7
        Me.HelpActivationLinkLabel.TabStop = True
        Me.HelpActivationLinkLabel.Text = "What is activation?"
        '
        'Form2
        '
        Me.AcceptButton = Me.NextBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.HelpActivationLinkLabel)
        Me.Controls.Add(Me.PrivacyLinkLabel)
        Me.Controls.Add(Me.ProductKeyTextBox)
        Me.Controls.Add(Me.ProductKeyTextLabel)
        Me.Controls.Add(Me.ProductKeyHelpLinkLabel)
        Me.Controls.Add(Me.ProductKeyHelpLabel)
        Me.Controls.Add(Me.ProductKeyHelpTitleLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BottomPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(633, 551)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Activation"
        Me.TopMost = True
        Me.BottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ProductKeyHelpTitleLabel As Label
    Friend WithEvents ProductKeyHelpLabel As Label
    Friend WithEvents ProductKeyHelpLinkLabel As LinkLabel
    Friend WithEvents ProductKeyTextLabel As Label
    Friend WithEvents ProductKeyTextBox As TextBox
    Friend WithEvents NextBtn As Button
    Friend WithEvents PrivacyLinkLabel As LinkLabel
    Friend WithEvents HelpActivationLinkLabel As LinkLabel
End Class
