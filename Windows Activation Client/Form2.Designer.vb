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
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.productKeyHelpTitleLabel = New System.Windows.Forms.Label()
        Me.productKeyHelpLabel = New System.Windows.Forms.Label()
        Me.productKeyHelpLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.productKeyTextLabel = New System.Windows.Forms.Label()
        Me.productKeyTextBox = New System.Windows.Forms.TextBox()
        Me.privacyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.helpActivationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.bottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.SystemColors.Control
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cancelBtn.Location = New System.Drawing.Point(530, 8)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 2
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bottomPanel.Controls.Add(Me.nextBtn)
        Me.bottomPanel.Controls.Add(Me.cancelBtn)
        Me.bottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.bottomPanel.TabIndex = 1
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.SystemColors.Control
        Me.nextBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.nextBtn.Location = New System.Drawing.Point(449, 8)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(75, 23)
        Me.nextBtn.TabIndex = 1
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(32, 70)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(487, 34)
        Me.descLabel.TabIndex = 4
        Me.descLabel.Text = "The Windows 7 product key can be found on the installation disc holder inside the" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows package. Activation will register the product key to this computer."
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(32, 32)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(179, 23)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Type your product key"
        '
        'productKeyHelpTitleLabel
        '
        Me.productKeyHelpTitleLabel.AutoSize = True
        Me.productKeyHelpTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productKeyHelpTitleLabel.Location = New System.Drawing.Point(32, 150)
        Me.productKeyHelpTitleLabel.Name = "productKeyHelpTitleLabel"
        Me.productKeyHelpTitleLabel.Size = New System.Drawing.Size(187, 17)
        Me.productKeyHelpTitleLabel.TabIndex = 5
        Me.productKeyHelpTitleLabel.Text = "The product key looks like this:"
        '
        'productKeyHelpLabel
        '
        Me.productKeyHelpLabel.AutoSize = True
        Me.productKeyHelpLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productKeyHelpLabel.Location = New System.Drawing.Point(62, 190)
        Me.productKeyHelpLabel.Name = "productKeyHelpLabel"
        Me.productKeyHelpLabel.Size = New System.Drawing.Size(392, 20)
        Me.productKeyHelpLabel.TabIndex = 6
        Me.productKeyHelpLabel.Text = "PRODUCT KEY: XXXXX-XXXXX-XXXXX-XXXXX-XXXXX"
        '
        'productKeyHelpLinkLabel
        '
        Me.productKeyHelpLinkLabel.AutoSize = True
        Me.productKeyHelpLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productKeyHelpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.productKeyHelpLinkLabel.Location = New System.Drawing.Point(32, 230)
        Me.productKeyHelpLinkLabel.Name = "productKeyHelpLinkLabel"
        Me.productKeyHelpLinkLabel.Size = New System.Drawing.Size(256, 17)
        Me.productKeyHelpLinkLabel.TabIndex = 7
        Me.productKeyHelpLinkLabel.TabStop = True
        Me.productKeyHelpLinkLabel.Text = "Where do I find my Windows product key?"
        '
        'productKeyTextLabel
        '
        Me.productKeyTextLabel.AutoSize = True
        Me.productKeyTextLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productKeyTextLabel.Location = New System.Drawing.Point(32, 290)
        Me.productKeyTextLabel.Name = "productKeyTextLabel"
        Me.productKeyTextLabel.Size = New System.Drawing.Size(81, 17)
        Me.productKeyTextLabel.TabIndex = 8
        Me.productKeyTextLabel.Text = "Product Key:"
        '
        'productKeyTextBox
        '
        Me.productKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.productKeyTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productKeyTextBox.Location = New System.Drawing.Point(155, 287)
        Me.productKeyTextBox.MaxLength = 29
        Me.productKeyTextBox.Name = "productKeyTextBox"
        Me.productKeyTextBox.Size = New System.Drawing.Size(332, 25)
        Me.productKeyTextBox.TabIndex = 0
        Me.productKeyTextBox.WordWrap = False
        '
        'privacyLinkLabel
        '
        Me.privacyLinkLabel.AutoSize = True
        Me.privacyLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.privacyLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.privacyLinkLabel.Location = New System.Drawing.Point(32, 415)
        Me.privacyLinkLabel.Name = "privacyLinkLabel"
        Me.privacyLinkLabel.Size = New System.Drawing.Size(205, 17)
        Me.privacyLinkLabel.TabIndex = 10
        Me.privacyLinkLabel.TabStop = True
        Me.privacyLinkLabel.Text = "Read the privacy statement online"
        '
        'helpActivationLinkLabel
        '
        Me.helpActivationLinkLabel.AutoSize = True
        Me.helpActivationLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpActivationLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.helpActivationLinkLabel.Location = New System.Drawing.Point(32, 395)
        Me.helpActivationLinkLabel.Name = "helpActivationLinkLabel"
        Me.helpActivationLinkLabel.Size = New System.Drawing.Size(116, 17)
        Me.helpActivationLinkLabel.TabIndex = 11
        Me.helpActivationLinkLabel.TabStop = True
        Me.helpActivationLinkLabel.Text = "What is activation?"
        '
        'Form2
        '
        Me.AcceptButton = Me.nextBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.helpActivationLinkLabel)
        Me.Controls.Add(Me.privacyLinkLabel)
        Me.Controls.Add(Me.productKeyTextBox)
        Me.Controls.Add(Me.productKeyTextLabel)
        Me.Controls.Add(Me.productKeyHelpLinkLabel)
        Me.Controls.Add(Me.productKeyHelpLabel)
        Me.Controls.Add(Me.productKeyHelpTitleLabel)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.bottomPanel)
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
        Me.bottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelBtn As Button
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents descLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents productKeyHelpTitleLabel As Label
    Friend WithEvents productKeyHelpLabel As Label
    Friend WithEvents productKeyHelpLinkLabel As LinkLabel
    Friend WithEvents productKeyTextLabel As Label
    Friend WithEvents productKeyTextBox As TextBox
    Friend WithEvents nextBtn As Button
    Friend WithEvents privacyLinkLabel As LinkLabel
    Friend WithEvents helpActivationLinkLabel As LinkLabel
End Class
