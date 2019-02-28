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

        If imDebugging = True Or productKey = "5T0PW-4ST1N-GURT1-M35C4-MM1NG" Then
            Timer1.Interval = 100
        Else
            'This will take a long time...
            Timer1.Interval = 3000
        End If

        Timer1.Enabled = True
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'Do nothing
        MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        Me.Cursor = Cursors.WaitCursor
        cancelBtn.Enabled = False
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

    'https://stackoverflow.com/a/38311385
    Private Const MF_BYPOSITION As Integer = &H400
    Private Const MF_REMOVE As Integer = &H1000
    Private Declare Auto Function GetSystemMenu Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bRevert As Integer) As IntPtr
    Private Declare Auto Function GetMenuItemCount Lib "user32.dll" (ByVal hMenu As IntPtr) As Integer
    Private Declare Function DrawMenuBar Lib "user32.dll" (ByVal hwnd As IntPtr) As Boolean
    Private Declare Auto Function RemoveMenu Lib "user32.dll" (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer

    Public Sub DisableCloseButton(ByVal hwnd As IntPtr)
        Dim hMenu As IntPtr, n As Integer
        hMenu = GetSystemMenu(hwnd, 0)
        If Not hMenu.Equals(IntPtr.Zero) Then
            n = GetMenuItemCount(hMenu)
            If n > 0 Then
                RemoveMenu(hMenu, n - 1, MF_BYPOSITION Or MF_REMOVE)
                RemoveMenu(hMenu, n - 2, MF_BYPOSITION Or MF_REMOVE)
                DrawMenuBar(hwnd)
            End If
        End If
    End Sub

    Private Sub Verification_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        'The Product Key must be verified
        If e.CloseReason = CloseReason.UserClosing Then
            MessageBox.Show("Are you sure you want to cancel the verification process?", "Windows Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            e.Cancel = True
            Me.Cursor = Cursors.WaitCursor

            'Disable the close button
            DisableCloseButton(Handle)
        Else
            Application.Exit()
        End If
    End Sub
End Class