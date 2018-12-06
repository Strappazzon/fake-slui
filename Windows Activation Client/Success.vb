Public Class Success
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

    Private Sub Success_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub benefitsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles benefitsLinkLabel.LinkClicked
        Dim BenefitsAddress As String = "https://support.microsoft.com/en-us/help/15087/windows-genuine"
        Process.Start(BenefitsAddress)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub
End Class