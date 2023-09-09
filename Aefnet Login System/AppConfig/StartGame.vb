Public Class StartGame
    Public Sub Run()
        RenameFile()
        Try
            Dim procStartInfo As New ProcessStartInfo
            Dim procExecuting As New Process
            With procStartInfo
                .UseShellExecute = True
                .FileName = "zdta.exe"
                .WindowStyle = ProcessWindowStyle.Normal
                .Verb = "runas" 'add this to prompt for elevation
            End With
            procExecuting = Process.Start(procStartInfo)
        Catch ex As Exception
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End Try
    End Sub
    Private Sub RenameFile()
        Try
            Files()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AgainRenameFile()
        Try
            AgainFiles()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Files()
        My.Computer.FileSystem.RenameFile("zdta.mix", "zdta.exe")
        My.Computer.FileSystem.RenameFile("Resources\Clientdx.mix", "Clientdx.exe")
        My.Computer.FileSystem.RenameFile("Resources\Clientogl.mix", "Clientogl.exe")
        My.Computer.FileSystem.RenameFile("Resources\Clientxna.mix", "Clientxna.exe")
    End Sub
    Public Sub AgainFiles()
        My.Computer.FileSystem.RenameFile("zdta.exe", "zdta.mix")
        My.Computer.FileSystem.RenameFile("Resources\Clientdx.exe", "Clientdx.mix")
        My.Computer.FileSystem.RenameFile("Resources\Clientogl.exe", "Clientogl.mix")
        My.Computer.FileSystem.RenameFile("Resources\Clientxna.exe", "Clientxna.mix")
    End Sub
End Class
