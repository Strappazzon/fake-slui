<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.skipBtn = New System.Windows.Forms.Button()
        Me.activateBtn = New System.Windows.Forms.Button()
        Me.helpActivationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.privacyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.retypeBtn = New System.Windows.Forms.Button()
        Me.taskmgrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bottomPanel.Controls.Add(Me.cancelBtn)
        Me.bottomPanel.Location = New System.Drawing.Point(-1, 472)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(619, 42)
        Me.bottomPanel.TabIndex = 0
        '
        'cancelBtn
        '
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cancelBtn.Location = New System.Drawing.Point(530, 8)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 2
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(32, 32)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(182, 23)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Activate Windows now"
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(32, 70)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(418, 34)
        Me.descLabel.TabIndex = 2
        Me.descLabel.Text = "Your activation period has expired and Windows is no longer working." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To use Wind" &
    "ows you must activate this copy of Windows."
        '
        'skipBtn
        '
        Me.skipBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.skipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.skipBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skipBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.skipBtn.Image = CType(resources.GetObject("skipBtn.Image"), System.Drawing.Image)
        Me.skipBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.skipBtn.Location = New System.Drawing.Point(33, 180)
        Me.skipBtn.Name = "skipBtn"
        Me.skipBtn.Size = New System.Drawing.Size(553, 41)
        Me.skipBtn.TabIndex = 1
        Me.skipBtn.Text = "     Access your computer with reduced functionality"
        Me.skipBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.skipBtn.UseVisualStyleBackColor = False
        '
        'activateBtn
        '
        Me.activateBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.activateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.activateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.activateBtn.Image = CType(resources.GetObject("activateBtn.Image"), System.Drawing.Image)
        Me.activateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.activateBtn.Location = New System.Drawing.Point(33, 125)
        Me.activateBtn.Name = "activateBtn"
        Me.activateBtn.Size = New System.Drawing.Size(553, 41)
        Me.activateBtn.TabIndex = 0
        Me.activateBtn.Text = "     Activate Windows online now"
        Me.activateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.activateBtn.UseVisualStyleBackColor = False
        '
        'helpActivationLinkLabel
        '
        Me.helpActivationLinkLabel.AutoSize = True
        Me.helpActivationLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpActivationLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.helpActivationLinkLabel.Location = New System.Drawing.Point(32, 395)
        Me.helpActivationLinkLabel.Name = "helpActivationLinkLabel"
        Me.helpActivationLinkLabel.Size = New System.Drawing.Size(116, 17)
        Me.helpActivationLinkLabel.TabIndex = 13
        Me.helpActivationLinkLabel.TabStop = True
        Me.helpActivationLinkLabel.Text = "What is activation?"
        '
        'privacyLinkLabel
        '
        Me.privacyLinkLabel.AutoSize = True
        Me.privacyLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.privacyLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.privacyLinkLabel.Location = New System.Drawing.Point(32, 415)
        Me.privacyLinkLabel.Name = "privacyLinkLabel"
        Me.privacyLinkLabel.Size = New System.Drawing.Size(205, 17)
        Me.privacyLinkLabel.TabIndex = 12
        Me.privacyLinkLabel.TabStop = True
        Me.privacyLinkLabel.Text = "Read the privacy statement online"
        '
        'retypeBtn
        '
        Me.retypeBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.retypeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.retypeBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retypeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.retypeBtn.Image = CType(resources.GetObject("retypeBtn.Image"), System.Drawing.Image)
        Me.retypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.retypeBtn.Location = New System.Drawing.Point(33, 235)
        Me.retypeBtn.Name = "retypeBtn"
        Me.retypeBtn.Size = New System.Drawing.Size(553, 41)
        Me.retypeBtn.TabIndex = 14
        Me.retypeBtn.Text = "     Retype your product key"
        Me.retypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.retypeBtn.UseVisualStyleBackColor = False
        '
        'taskmgrTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.retypeBtn)
        Me.Controls.Add(Me.helpActivationLinkLabel)
        Me.Controls.Add(Me.privacyLinkLabel)
        Me.Controls.Add(Me.skipBtn)
        Me.Controls.Add(Me.activateBtn)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.bottomPanel)
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
        Me.bottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bottomPanel As Panel
    Friend WithEvents cancelBtn As Button
    Friend WithEvents titleLabel As Label
    Friend WithEvents descLabel As Label
    Friend WithEvents activateBtn As Button
    Friend WithEvents skipBtn As Button
    Friend WithEvents helpActivationLinkLabel As LinkLabel
    Friend WithEvents privacyLinkLabel As LinkLabel
    Friend WithEvents retypeBtn As Button
    Friend WithEvents taskmgrTimer As Timer
End Class
