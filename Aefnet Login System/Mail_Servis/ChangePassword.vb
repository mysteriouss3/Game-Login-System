Imports System.Runtime.InteropServices
Imports DataCenter
Imports UserModel
Imports DataAccess
Public Class ChangePassword
    Private ReadOnly Sifreleme As New Encryption()
    Private ReadOnly UpdateData As New UpdateData()
    Private ReadOnly ReadDataApp As New ReadDataApp()
    Private ReadOnly MailController As New MailController()
#Region "Form Hareket Settings"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub ChangePassword_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        İnitalizeLoad()
    End Sub
    Private Sub İnitalizeLoad()
        txtpassword.UseSystemPasswordChar = True
        txtpassword2.UseSystemPasswordChar = True
    End Sub
    Private Sub BtnPasswordChange_Click(sender As Object, e As EventArgs) Handles BtnPasswordChange.Click
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        If txtpassword.Text = Nothing Then
            ErrorProvider1.SetError(txtpassword, "Şifre Belirtilmedi.")
        Else
            If txtpassword.Text = txtpassword2.Text Then
                If txtpassword.Text = Sifreleme.Şifre_Çoz(Player_Password) Then
                    MsgBox("Güncel Şifreniz İle Girdiğiniz Yeni Şifre Ayni Olduğu İçin," & vbNewLine &
                        "Şifreniz Değiştirilemedi !", MsgBoxStyle.Critical, "AEFNET SİSTEM")
                Else
                    Try
                        UpdateData.PlayerPasswordUpdate(txtpassword.Text, Player_Username)
                        ReadDataApp.PasswordAndPNickRead(Player_Username)
                        MailController.PasswordRenewal()
                        MsgBox("Şifreniz Başariyla Değiştirildi.", MsgBoxStyle.Information, "AEFNET SİSTEM")
                        Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SİSTEM")
                    End Try
                End If
            Else
                ErrorProvider1.SetError(txtpassword, "Şifreler Uyuşmuyor!")
                ErrorProvider2.SetError(txtpassword2, "Şifreler Uyuşmuyor!")
            End If
        End If
    End Sub
#Region "BtnClose And BtnMininize"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMininize_Click(sender As Object, e As EventArgs) Handles BtnMininize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
End Class