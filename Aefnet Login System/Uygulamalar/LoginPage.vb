Imports System.IO
Imports System.Runtime.InteropServices
Imports DataCenter
Imports UserModel
Public Class LoginPage
    Private ReadOnly ReadDataApp As New ReadDataApp()
    Private ReadOnly GamersRanked As New GamersRanked()
    Private ReadOnly Player As New PlayerNickUpdater()
    Private ReadOnly Playerİnfo As New Playerİnfo()
    Private ReadOnly UpdateData As New UpdateData()
    Private ReadOnly AppUpdater As New AppUpdater()
    Private ReadOnly AefnetUpdater As New AefnetUpdater()
    Private ReadOnly StartGame As New StartGame()
    Private ReadOnly CoreControl As New CoreControl()
    Private ReadOnly W10 As New Defender()
#Region "Texbox Ayar"
    Private Sub CustomizeComponents()
        Dim ResultGame As Boolean = My.Computer.FileSystem.DirectoryExists("Updater")
        If ResultGame = True Then
            StartGame.Run()
            Timer2.Start()
        End If
        Try
            btnLogin.Enabled = False
            BtnRegister.Enabled = False
            'UpdaterStartGame
            If File.Exists(AppVersion_Yol) = True Then
                lblversion.Text = "v." & AppUpdater.LoginVersion_Read()
            End If
            'txtUser
            txtUser.AutoSize = False
            txtUser.Size = New Size(308, 25)
            'txtPass
            txtPass.AutoSize = False
            txtPass.Size = New Size(308, 25)
            txtPass.UseSystemPasswordChar = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET LOGİN SYSTEM")
        End Try
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        StartGame.AgainRenameFile()
        Timer2.Stop()
        Application.Exit()
    End Sub
    Private Sub TxtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Asc(e.KeyChar) >= 33 And Asc(e.KeyChar) <= 47 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 91 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 92 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 93 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 94 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 95 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 96 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) > 127 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Uygulama Hareket"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "Uygulama Bar Düğme Ayarlari"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Remember Me Settings"
    Private Sub LoadRememberMe()
        If My.Settings.beni_hatirla = True Then
            RememberMe.Checked = True
            txtPass.Select()
        Else
            RememberMe.Checked = False
            txtUser.Select()
        End If
        If My.Settings.id.Length And My.Settings.sifre.Length > 0 Then
            txtUser.Text = My.Settings.id
            txtPass.Text = My.Settings.sifre
            RememberMe.Checked = My.Settings.beni_hatirla
            txtUser.Select()
        End If
    End Sub
    Private Sub Remember_Me_Checked()
        If RememberMe.Checked = True Then
            If txtUser.Text.Length > 0 And txtPass.Text.Length > 0 Then
                My.Settings.id = txtUser.Text
                My.Settings.sifre = txtPass.Text
                My.Settings.beni_hatirla = True
                My.Settings.Save()
            End If
        End If
        If RememberMe.Checked = False Then
            My.Settings.Reset()
            My.Settings.beni_hatirla = False
            My.Settings.Save()
        End If
    End Sub
    Private Sub Button_Remember_Me()
        If RememberMe.Checked = True Then
            My.Settings.id = txtUser.Text
            My.Settings.sifre = txtPass.Text
            My.Settings.beni_hatirla = True
            My.Settings.Save()
        End If
        If RememberMe.Checked = False Then
            My.Settings.Reset()
        End If
    End Sub
#End Region
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker2.WorkerReportsProgress = True
        CheckForIllegalCrossThreadCalls = False
        W10.W10_Defn_Run()
        CustomizeComponents()
        LoadRememberMe()
        Timer1.Start()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim DataSend As New DataLayer()
        Dim Welcome As New Welcome()
        Try
            ReadDataApp.App_Datas()
            If RepairStatus = "Aktif" Then
                MsgBox(RepairNotice, MsgBoxStyle.Information, "AEFNET SİSTEM")
            Else
                ErrorProvider1.Clear()
                If txtUser.Text = Nothing Then
                    ErrorProvider1.SetError(txtUser, "Kullanıcı Adı Belirtilmedi !")
                    txtUser.Select()
                ElseIf txtPass.Text = Nothing Then
                    ErrorProvider1.SetError(txtPass, "Parola Belirtilmedi !")
                    txtPass.Select()
                Else
                    Button_Remember_Me()
                    Dim ValidLogin = DataSend.Login(txtUser.Text, txtPass.Text)
                    If ValidLogin <> "True" Then
                        MsgBox(ValidLogin, MsgBoxStyle.Critical, "AEFNET SİSTEM")
                    Else
                        BackgroundWorker1.RunWorkerAsync()
                        Welcome.Show()
                        Hide()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Mysql Sunucu Kapali Yada İnternet Bağlantiniz Yok.", MsgBoxStyle.Critical, "AEFNET SİSTEM")
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Help.Show()
    End Sub
    Private Sub RememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles RememberMe.CheckedChanged
        Remember_Me_Checked()
    End Sub
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Hide()
        Register.Show()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Forget_Password.Show()
    End Sub
#Region "Updater"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        App_Updaterr()
        Timer1.Stop()
    End Sub
    Private Sub App_Updaterr()
        Try
            If File.Exists(FullUpdaterRun) = True Then
                ReadDataApp.App_Updater_Control()
                AefnetUpdater.Aefnet_Updater_Kontrol()
                AppUpdater.AppLoginVersion()
                If AefnetVersion = AefnetUpdater.Version_Read() And AppLoginNumberVersion = AppUpdater.LoginVersion_Read() Then
                    btnLogin.Enabled = False
                    BtnRegister.Enabled = False
                    BackgroundWorker2.RunWorkerAsync()
                End If
            Else
                CoreControl.Core()
            End If
        Catch ex As Exception
            Timer1.Stop()
            MsgBox("Oyun Dosyalarinizda Kritik Bir Sorun Var! Yönetici İle İletişime Geçiniz.", MsgBoxStyle.Critical, "AEFNET SYSTEM")
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End Try
    End Sub
#End Region

#Region "BackGroundWorker"
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            GamersRanked.RankPlayer()
            GamersRanked.PlayerMatchİnfo()
            GamersRanked.Ranked1vs1AllMatch()
            GamersRanked.Top5Player()
            Player.Player_Nick(Player_Nick)
            UpdateData.İp_Join_Date_Update(Playerİnfo.GetIP, txtUser.Text)
            ReadDataApp.AdminPanelRead(txtUser.Text)
            ReadDataApp.PlayerNickNameStatus(txtUser.Text)
            ReadDataApp.AllPlayers()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SYSTEM")
        End Try
    End Sub
    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            lblversion.Text = "v." & AppLoginNumberVersion
            CoreControl.Core1()
            CoreControl.Core2()
            CoreControl.Core3()
            CoreControl.Core4()
            btnLogin.Enabled = True
            BtnRegister.Enabled = True
        Catch ex As Exception
            Timer1.Stop()
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End Try
    End Sub
#End Region
End Class
