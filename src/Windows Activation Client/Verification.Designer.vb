<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Verification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verification))
        Me.VerificationBar = New System.Windows.Forms.ProgressBar()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ProductKeyHelpTitleLabel = New System.Windows.Forms.Label()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'VerificationBar
        '
        Me.VerificationBar.Location = New System.Drawing.Point(135, 175)
        Me.VerificationBar.Name = "VerificationBar"
        Me.VerificationBar.Size = New System.Drawing.Size(357, 17)
        Me.VerificationBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.VerificationBar.TabIndex = 3
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPanel.Controls.Add(Me.CancelBtn)
        Me.BottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.BottomPanel.TabIndex = 4
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelBtn.Location = New System.Drawing.Point(530, 8)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 0
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ProductKeyHelpTitleLabel
        '
        Me.ProductKeyHelpTitleLabel.AutoSize = True
        Me.ProductKeyHelpTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductKeyHelpTitleLabel.Location = New System.Drawing.Point(32, 120)
        Me.ProductKeyHelpTitleLabel.Name = "ProductKeyHelpTitleLabel"
        Me.ProductKeyHelpTitleLabel.Size = New System.Drawing.Size(183, 17)
        Me.ProductKeyHelpTitleLabel.TabIndex = 2
        Me.ProductKeyHelpTitleLabel.Text = "This might take a few minutes."
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.Location = New System.Drawing.Point(32, 70)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(202, 17)
        Me.DescLabel.TabIndex = 1
        Me.DescLabel.Text = "The product key is being verified."
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(32, 32)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(172, 23)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Activating Windows..."
        '
        'Verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.ProductKeyHelpTitleLabel)
        Me.Controls.Add(Me.DescLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.VerificationBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(633, 551)
        Me.Name = "Verification"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Activation"
        Me.TopMost = True
        Me.BottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VerificationBar As ProgressBar
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ProductKeyHelpTitleLabel As Label
    Friend WithEvents DescLabel As Label
    Friend WithEvents TitleLabel As Label
End Class
