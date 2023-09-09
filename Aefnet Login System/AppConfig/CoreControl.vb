Imports System.IO

Public Class CoreControl
    'Core
    Private ReadOnly FullUpdaterFile As Boolean = File.Exists(FullUpdaterRun)
    'Core1
    Private ReadOnly ResultClientFile As Boolean = File.Exists(DTA_Yol)
    Private ReadOnly ResultClientCopy As Boolean = File.Exists(DTAMix_Yol)

    Private ReadOnly ResultCUpdater As Boolean = File.Exists(UpdaterToolsFile_Yol)
    Private ReadOnly ResultCUpdaterCopy As Boolean = File.Exists(UpdaterToolsMix_Yol)

    'Core2
    Private ReadOnly Dx As Boolean = File.Exists(Clientdx_Yol)
    Private ReadOnly DxMix As Boolean = File.Exists(ClientdxMix_Yol)

    Private ReadOnly Ogl As Boolean = File.Exists(Clientogl_Yol)
    Private ReadOnly OglMix As Boolean = File.Exists(ClientoglMix_Yol)

    Private ReadOnly Xna As Boolean = File.Exists(Clientxna_Yol)
    Private ReadOnly XnaMix As Boolean = File.Exists(ClientxnaMix_Yol)

    'Core3
    Private ReadOnly UpConfigini As Boolean = File.Exists(ClientUpdateConfig)

    Public Sub Core()
        If FullUpdaterFile = False Then
            LoginPage.btnLogin.Enabled = False
            LoginPage.BtnRegister.Enabled = False
            AefnetUpdate.Show()
        End If
    End Sub
    Public Sub Core1()
        If ResultClientFile = True And ResultClientCopy = True Then
            File.Delete(DTA_Yol)
        ElseIf ResultClientFile = True Then
            My.Computer.FileSystem.RenameFile(DTA_Yol, DTAMix)
        ElseIf ResultClientCopy = False Then
            LoginPage.btnLogin.Enabled = False
            LoginPage.BtnRegister.Enabled = False
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End If

        If ResultCUpdater = True And ResultCUpdaterCopy = True Then
            File.Delete(UpdaterToolsFile_Yol)
        ElseIf ResultCUpdater = True Then
            My.Computer.FileSystem.RenameFile(UpdaterToolsFile_Yol, UpdaterToolsMix)
        ElseIf ResultCUpdaterCopy = False Then
            LoginPage.btnLogin.Enabled = False
            LoginPage.BtnRegister.Enabled = False
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End If

    End Sub
    Public Sub Core2()

        If Dx = True And DxMix = True Then
            File.Delete(Clientdx_Yol)
        ElseIf Dx = True Then
            My.Computer.FileSystem.RenameFile(Clientdx_Yol, ClientdxMix)
        ElseIf DxMix = False Then
            LoginPage.btnLogin.Enabled = False
            LoginPage.BtnRegister.Enabled = False
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End If

        If Ogl = True And OglMix = True Then
            File.Delete(Clientogl_Yol)
        ElseIf Ogl = True Then
            My.Computer.FileSystem.RenameFile(Clientogl_Yol, ClientoglMix)
        ElseIf OglMix = False Then
            LoginPage.btnLogin.Enabled = False
            LoginPage.BtnRegister.Enabled = False
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End If

        If Xna = True And XnaMix = True Then
            File.Delete(Clientxna_Yol)
        ElseIf Xna = True Then
            My.Computer.FileSystem.RenameFile(Clientxna_Yol, ClientxnaMix)
        ElseIf XnaMix = False Then
            LoginPage.btnLogin.Enabled = False
            LoginPage.BtnRegister.Enabled = False
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End If
    End Sub
    Public Sub Core3()
        Try
            If UpConfigini = False Then
                LoginPage.btnLogin.Enabled = False
                LoginPage.BtnRegister.Enabled = False
                Process.Start(FullUpdaterRun)
                Application.Exit()
            End If
        Catch ex As Exception
            Dim Result = MsgBox("Oyun Dosyalarinizda Kritik Bir Sorun Vardir! Sizi Yöneticiye Aktariyoruz, " + vbNewLine +
                       "Web Sitemizdeki Sağ Alt Köşedeki Canli Destek Kismindan Yöneticiye Mesaj Atiniz. Sizi Siteye Aktariyoruz Onayliyor musunuz?", MsgBoxStyle.YesNo, "AEFNET LOGİN SYSTEM")
            If Result = MsgBoxResult.Yes Then
                Process.Start("https://aefnet.com")
                Application.Exit()
            Else
                Application.Exit()
            End If
        End Try
    End Sub
    Public Sub Core4()
        If UpConfigini = False And ResultClientFile = False And ResultClientCopy = False And ResultCUpdater = False And ResultCUpdaterCopy = False And DxMix = False And
            OglMix = False And XnaMix = False Then
            LoginPage.Timer1.Stop()
            MsgBox("Bu Uygulama Aefnet Oyun Dosyalari Olmadan Çaliştirilamaz.", MsgBoxStyle.Critical, "AEFNET SYSTEM")
            Application.Exit()
        End If
    End Sub
End Class
