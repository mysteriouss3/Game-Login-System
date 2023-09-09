Imports System.IO
Imports System.Net
Imports DataCenter
Public Class AefnetUpdater
#Region "VersionWeb"
    Public Function Control()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim Web As New WebClient()
        AefnetVersion = Web.DownloadString(AefnetVersionURL)
        Web.Dispose()
        Return AefnetVersion
    End Function
#End Region
    Public Sub Aefnet_Updater_Kontrol()
        Try
            If File.Exists(AefnetVersion_Yol) = True Then
            Else
                My.Computer.FileSystem.WriteAllText(AefnetVersion_Yol, String.Empty, False)
                Version_Write()
            End If
            If Version_Read() = Nothing Then
                My.Computer.FileSystem.DeleteFile(AefnetVersion_Yol)
                My.Computer.FileSystem.WriteAllText(AefnetVersion_Yol, String.Empty, False)
                Version_Write()
            Else
                If AefnetUpdaterSetting = "Aktif" Then
                    If Control() <> Version_Read() Then
                        LoginPage.btnLogin.Enabled = False
                        LoginPage.BtnRegister.Enabled = False
                        AefnetUpdate.Show()
                    Else
                        LoginPage.btnLogin.Enabled = True
                        LoginPage.BtnRegister.Enabled = True
                    End If
                Else
                    LoginPage.btnLogin.Enabled = True
                    LoginPage.BtnRegister.Enabled = True
                End If
            End If
        Catch ex As Exception
            LoginPage.Timer1.Stop()
            MsgBox("Aefnet Güncelleyici Açılamiyor. Lütfen Yönetici İle İletişime Geçiniz.", MsgBoxStyle.Critical, "AEFNET SİSTEM")
            Application.Exit()
        End Try
    End Sub
    Sub Version_Write()
        Dim fs As FileStream = New FileStream(AefnetVersion_Yol, FileMode.Append)
        Dim sw As StreamWriter = New StreamWriter(fs)
        sw.WriteLine(LastVersion)
        sw.Flush()
        sw.Close()
    End Sub
    Public Function Version_Read()
        Dim Reader As New StreamReader(AefnetVersion_Yol)
        Dim Str_Oku = Reader.ReadLine()
        Reader.Close()
        Return Str_Oku
    End Function
End Class
