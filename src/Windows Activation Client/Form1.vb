﻿Public Class Form1
    Private ReadOnly ProcsList() As String = {"explorer", "taskmgr", "iexplore", "msinfo32", "mmc", "dxdiag", "msconfig", "cmd", "notepad", "syskey"}
    Private WithEvents ProcsTimer As New Timer()

    Private Sub ProcsTimer_Tick(sender As Object, e As EventArgs) Handles ProcsTimer.Tick
        'Force kill processes tipically used by scammers, Windows Explorer and Task Manager
        For Each Process As Process In Process.GetProcesses
            If ProcsList.Contains(Process.ProcessName) Then
                Process.Kill()
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Kill Windows Explorer
        Shell("taskkill /F /IM explorer.exe")

        'Start timer that will check running processes
        ProcsTimer.Interval = 500
        ProcsTimer.Start()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        'Restart Explorer when closing fake-slui
        Using StartProc As New Process()
            StartProc.StartInfo.CreateNoWindow = True
            StartProc.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\explorer.exe"
            StartProc.Start()
        End Using
    End Sub

    Private Sub ActivateBtn_Click(sender As Object, e As EventArgs) Handles ActivateBtn.Click
        'Hide the current form and proceed to the next step
        Hide()
        Form2.Show()
    End Sub

    Private Sub RetypeBtn_Click(sender As Object, e As EventArgs) Handles RetypeBtn.Click
        'Hide the current form and proceed to the next step
        Hide()
        Form2.Show()
    End Sub

    Private Sub SkipBtn_Click(sender As Object, e As EventArgs) Handles SkipBtn.Click
        Application.Exit()
    End Sub

    Private Sub HelpActivationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HelpActivationLinkLabel.LinkClicked
        Process.Start("https://support.microsoft.com/en-us/help/15083/windows-how-to-activate")
    End Sub

    Private Sub PrivacyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PrivacyLinkLabel.LinkClicked
        Process.Start("https://privacy.microsoft.com/en-us/privacystatement")
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Application.Exit()
    End Sub
End Class
