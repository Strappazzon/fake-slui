Public Class Verification
    Private Const MF_BYPOSITION As Integer = &H400
    Private Const MF_REMOVE As Integer = &H1000
    Private Declare Auto Function GetSystemMenu Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bRevert As Integer) As IntPtr
    Private Declare Auto Function GetMenuItemCount Lib "user32.dll" (ByVal hMenu As IntPtr) As Integer
    Private Declare Function DrawMenuBar Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Private Declare Auto Function RemoveMenu Lib "user32.dll" (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    Private WithEvents VerificationTimer As New Timer()

    Private Sub DisableCloseButton(ByVal hWnd As IntPtr)
        '//stackoverflow.com/a/38311385
        Dim hMenu As IntPtr
        Dim n As Integer
        hMenu = GetSystemMenu(hWnd, 0)
        If Not hMenu.Equals(IntPtr.Zero) Then
            n = GetMenuItemCount(hMenu)
            If n > 0 Then
                RemoveMenu(hMenu, n - 1, MF_BYPOSITION Or MF_REMOVE)
                RemoveMenu(hMenu, n - 2, MF_BYPOSITION Or MF_REMOVE)
                DrawMenuBar(hWnd)
            End If
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
        'Disable the close button
        DisableCloseButton(Handle)

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
