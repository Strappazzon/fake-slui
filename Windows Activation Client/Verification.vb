Public Class Verification
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

    Private Sub Verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verificationBar.Maximum = 100
        verificationBar.Value = 0

        If productKey = "5T0PW-4ST1N-GURT1-M35C4-MM1NG" Then
            Timer1.Interval = 100
        Else
            'This will take a long time...
            'Timer1.Interval = 100 'Debug
            Timer1.Interval = 5000
        End If

        Timer1.Enabled = True
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'Do nothing if it's the user that wants to close the application
        Dim result As Integer = MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Or result = DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If verificationBar.Value = verificationBar.Maximum Then
            If productKey = "5T0PW-4ST1N-GURT1-M35C4-MM1NG" Then
                Success.Show()
            Else
                'When the progress bar reaches the maximum value disable the timer and show a connection error...
                Timer1.Enabled = False
                MessageBox.Show("An error occured while connecting to the activation server. Please try again later.",
                "Connection error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1)

                '...then close the application
                Application.Exit()
            End If
        Else
            'Increase the progress bar by 1 step
            verificationBar.Value = verificationBar.Value + 1
        End If
    End Sub

    Private Sub Verification_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        'The user can't close the application
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Or result = DialogResult.No Then
                e.Cancel = True
            End If
        Else
            Application.Exit()
        End If
    End Sub
End Class