Imports System.IO
Imports System.Net
Imports DataCenter
Public Class AppUpdater
    Private ReadOnly AefnetUpdater As New AefnetUpdater()
    Public Function AppVersionNumber()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim Web As New WebClient()
        AppLoginNumberVersion = Web.DownloadString(AppVersionURL)
        Web.Dispose()
        Return AppLoginNumberVersion
    End Function
    Public Sub AppLoginVersion()
        Try
            If File.Exists(AppVersion_Yol) = True Then
            Else
                My.Computer.FileSystem.WriteAllText(AppVersion_Yol, String.Empty, False)
                Version_Write()
            End If
            If LoginVersion_Read() = Nothing Then
                My.Computer.FileSystem.DeleteFile(AppVersion_Yol)
                My.Computer.FileSystem.WriteAllText(AppVersion_Yol, String.Empty, False)
                Version_Write()
            Else
                If AppUpdaterSetting = "Aktif" Then
                    If AefnetVersion = AefnetUpdater.Version_Read() Then
                        If AppVersionNumber() <> LoginVersion_Read() Then
                            LoginPage.btnLogin.Enabled = False
                            LoginPage.BtnRegister.Enabled = False
                            WarningUpdater.Show()
                        Else
                            LoginPage.btnLogin.Enabled = True
                            LoginPage.BtnRegister.Enabled = True
                        End If
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
        Dim fs As FileStream = New FileStream(AppVersion_Yol, FileMode.Append)
        Dim sw As StreamWriter = New StreamWriter(fs)
        sw.WriteLine(LastVersion)
        sw.Flush()
        sw.Close()
    End Sub
    Public Function LoginVersion_Read()
        Dim Reader As New StreamReader(AppVersion_Yol)
        Dim Str_Oku = Reader.ReadLine()
        Reader.Close()
        Return Str_Oku
    End Function
End Class
