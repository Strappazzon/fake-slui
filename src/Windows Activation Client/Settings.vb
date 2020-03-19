Imports IniParser
Imports IniParser.Model

Public Class Settings
    Private Shared ReadOnly IniParser = New FileIniDataParser()

    Public Shared Function GetProcsToKill() As String()
        Try
            Dim Data As IniData = IniParser.ReadFile("slui.ini")
            Dim ProcsToKill As String = Data("procstokill")("list")

            If ProcsToKill <> Nothing Then
                Return ProcsToKill.Split(","c)
            Else
                Return {"explorer", "taskmgr", "iexplore", "msinfo32", "mmc", "dxdiag", "msconfig", "cmd", "notepad", "syskey"}
            End If
        Catch
            Return {"explorer", "taskmgr", "iexplore", "msinfo32", "mmc", "dxdiag", "msconfig", "cmd", "notepad", "syskey"}
        End Try
    End Function

    Public Shared Function GetCustomProductKey() As String
        Try
            Dim Data As IniData = IniParser.ReadFile("slui.ini")
            Dim ProductKey As String = Data("slui")("productkey")

            If ProductKey <> Nothing AndAlso ProductKey.Length = 29 Then
                Return ProductKey
            Else
                Return "5T0PW-4ST1N-GURT1-M35C4-MM1NG"
            End If
        Catch
            Return "5T0PW-4ST1N-GURT1-M35C4-MM1NG"
        End Try
    End Function

    Public Shared Function GetCustomVerificationTime() As Integer
        '((60 * minutes) / 0.001) / ProgressBar.MaxValue = Timer.Interval

        Try
            Dim Data As IniData = IniParser.ReadFile("slui.ini")
            Dim VerificationTime As String = Data("slui")("verificationtime")

            If VerificationTime <> Nothing Then
                Return VerificationTime
            Else
                Return 1800 '3 minutes
            End If
        Catch
            Return 1800
        End Try
    End Function
End Class
