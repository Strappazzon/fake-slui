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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verification))
        Me.verificationBar = New System.Windows.Forms.ProgressBar()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.productKeyHelpTitleLabel = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'verificationBar
        '
        Me.verificationBar.Location = New System.Drawing.Point(135, 175)
        Me.verificationBar.Name = "verificationBar"
        Me.verificationBar.Size = New System.Drawing.Size(357, 17)
        Me.verificationBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.verificationBar.TabIndex = 0
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bottomPanel.Controls.Add(Me.cancelBtn)
        Me.bottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.bottomPanel.TabIndex = 6
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
        'productKeyHelpTitleLabel
        '
        Me.productKeyHelpTitleLabel.AutoSize = True
        Me.productKeyHelpTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productKeyHelpTitleLabel.Location = New System.Drawing.Point(32, 120)
        Me.productKeyHelpTitleLabel.Name = "productKeyHelpTitleLabel"
        Me.productKeyHelpTitleLabel.Size = New System.Drawing.Size(183, 17)
        Me.productKeyHelpTitleLabel.TabIndex = 9
        Me.productKeyHelpTitleLabel.Text = "This might take a few minutes."
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(32, 70)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(202, 17)
        Me.descLabel.TabIndex = 8
        Me.descLabel.Text = "The product key is being verified."
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(32, 32)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(172, 23)
        Me.titleLabel.TabIndex = 7
        Me.titleLabel.Text = "Activating Windows..."
        '
        'Timer1
        '
        '
        'Verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.bottomPanel)
        Me.Controls.Add(Me.productKeyHelpTitleLabel)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.verificationBar)
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
        Me.bottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents verificationBar As ProgressBar
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents cancelBtn As Button
    Friend WithEvents productKeyHelpTitleLabel As Label
    Friend WithEvents descLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
