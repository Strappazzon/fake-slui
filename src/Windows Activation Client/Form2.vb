Public Class Form2
    Private Sub Form2_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub ProductKeyHelpLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProductKeyHelpLinkLabel.LinkClicked
        Process.Start("https://support.microsoft.com/en-us/help/10749/windows-10-find-product-key")
    End Sub

    Private Sub HelpActivationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HelpActivationLinkLabel.LinkClicked
        Process.Start("https://support.microsoft.com/en-us/help/15083/windows-how-to-activate")
    End Sub

    Private Sub PrivacyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PrivacyLinkLabel.LinkClicked
        Process.Start("https://privacy.microsoft.com/en-us/privacystatement")
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        If ProductKeyTextBox.TextLength < 29 AndAlso ProductKeyTextBox.Text <> "" Then
            MessageBox.Show("The Windows 7 product key you typed was incorrect. Check your product key, and type it again.", "Invalid product key", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ProductKeyTextBox.Text = "" Then
            MessageBox.Show("You must enter a valid product key before activating online. Check your product key, and type it again.", "Windows Activation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Open the form that will pretend to check the Product Key online
            Hide()
            Verification.Show()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Application.Exit()
    End Sub
End Class
