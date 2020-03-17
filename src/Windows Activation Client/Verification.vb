Public Class Verification
    Private WithEvents VerificationTimer As New Timer()

    Private Sub Verification_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Don't close the form
            e.Cancel = True

            MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Cursor = Cursors.WaitCursor
        End If
    End Sub

    Private Sub VerificationTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles VerificationTimer.Tick
        If VerificationBar.Value = VerificationBar.Maximum Then
            If Form2.ProductKeyTextBox.Text = "5T0PW-4ST1N-GURT1-M35C4-MM1NG" Then
                VerificationTimer.Stop()
                Hide()
                Success.Show()
            Else
                VerificationTimer.Stop()
                'Show a connection error...
                MessageBox.Show("An error occured while connecting to the activation server. Please try again later.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                '...and close the application
                Application.Exit()
            End If
        Else
            'Increase the progress bar by 1 step
            VerificationBar.Value = VerificationBar.Value + 1
        End If
    End Sub

    Private Sub Verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.ProductKeyTextBox.Text = "5T0PW-4ST1N-GURT1-M35C4-MM1NG" Then
            VerificationTimer.Interval = 100
            VerificationTimer.Start()
        Else
            'This will take a long time...
            VerificationTimer.Interval = 3000
            VerificationTimer.Start()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        Cursor = Cursors.WaitCursor
    End Sub
End Class
