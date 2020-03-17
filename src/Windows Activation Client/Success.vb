Public Class Success
    Private Sub Success_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub BenefitsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BenefitsLinkLabel.LinkClicked
        Try
            Process.Start("https://support.microsoft.com/en-us/help/15087/windows-genuine")
        Catch
            Return
        End Try
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub
End Class
