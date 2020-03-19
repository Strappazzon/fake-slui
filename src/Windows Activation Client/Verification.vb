Public Class Verification
    Private WithEvents VerificationTimer As New Timer()

    Private Sub VerificationTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles VerificationTimer.Tick
        If VerificationBar.Value = VerificationBar.Maximum Then
            If Form2.ProductKeyTextBox.Text = Settings.GetCustomProductKey() Then
                'Show Success form
                VerificationTimer.Stop()
                Hide()
                Success.Show()
            Else
                VerificationTimer.Stop()
                'Show a connection error
                MessageBox.Show("An error occured while connecting to the activation server. Please try again later.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        Else
            'Increase the progress bar by 1 step
            VerificationBar.Value = VerificationBar.Value + 1
        End If
    End Sub

    Private Sub Verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set timer interval
        If Form2.ProductKeyTextBox.Text = Settings.GetCustomProductKey() Then
            VerificationTimer.Interval = 100
            VerificationTimer.Start()
        Else
            VerificationTimer.Interval = ((60 * Settings.GetCustomVerificationTime()) / 0.001) / 100
            VerificationTimer.Start()
        End If
    End Sub

    Private Sub Verification_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Don't close the form
            e.Cancel = True

            MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Cursor = Cursors.WaitCursor
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        Cursor = Cursors.WaitCursor
    End Sub
End Class
