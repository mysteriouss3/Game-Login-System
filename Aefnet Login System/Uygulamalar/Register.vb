Imports System.Runtime.InteropServices
Imports DataCenter
Imports DataAccess
Imports UserModel
Imports System.IO
Public Class Register
    Private ReadOnly LoginVersionControl As New AppUpdater()
    ReadOnly Playerİnfo As New Playerİnfo()
    ReadOnly DataLayer As New DataLayer()
    Public Rasgele As String
    Public rndm As Random = New Random
    Public Random1 As String = rndm.Next(1000, 9999)
#Region "App Close And Mininize"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        LoginPage.Show()
        Close()
    End Sub
    Private Sub BtnMininize_Click(sender As Object, e As EventArgs) Handles BtnMininize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "txtNick Key Filtre"
    Private Sub Kayit_nick_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kayit_nick.KeyPress, kayit_uname.KeyPress
        If Kayit_nick.TextLength = 0 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
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
        Else
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
        End If
    End Sub
#End Region
#Region "Form Hareket Setting"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Pnelbar_MouseDown(sender As Object, e As MouseEventArgs) Handles Pnelbar.MouseDown, MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "txtNickChange Filter"
    Private Function Filter()
        Dim lst As New List(Of String) _
    From {"gamemaster", "GAMEMASTER", "yonetici", "YONETICI", "Yonetici", "Anan", "anan", "Yetkili", "yetkili", "mod",
    "admin*", "allahu", "akbar", "twat", "cock", "pussy", "hitler", "anal", "aefnet", "got", "sik", "pic", "serefsiz", "kaltak", "siker", "skerim", "sikerim", "amk", "siker",
    "gotos", "gamemaster", "antialperen", "anani", "avrat", "c8e3f0eeea", "gari", "kerhaneci*", "sikik", "AEF", "kahpe", "orosbu", "orospu", "sikiyim", "administrator",
    "admin", "ADMIN", "AEFNET", "Aefnet", "aefnet", "MODERATOR", "MOD", "moderator"}
        For Each i As String In lst
            If Kayit_nick.Text = i Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region
#Region "Texbox Settings"
    Private Sub Kayit_uname_Enter(sender As Object, e As EventArgs) Handles kayit_uname.Enter
        If kayit_uname.Text = "Kullanıcı Adı" Then
            kayit_uname.Text = ""
        End If
    End Sub

    Private Sub Kayit_uname_Leave(sender As Object, e As EventArgs) Handles kayit_uname.Leave
        If kayit_uname.Text = "" Then
            kayit_uname.Text = "Kullanıcı Adı"
        End If
    End Sub

    Private Sub Kayit_upass_Enter(sender As Object, e As EventArgs) Handles Kayit_upass.Enter
        If Kayit_upass.Text = "Parola" Then
            Kayit_upass.Text = ""
            Kayit_upass.UseSystemPasswordChar = True

        End If
    End Sub
    Private Sub Kayit_upass_Leave(sender As Object, e As EventArgs) Handles Kayit_upass.Leave
        If Kayit_upass.Text = "" Then
            Kayit_upass.Text = "Parola"
            Kayit_upass.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub Kayit_e_posta_Enter(sender As Object, e As EventArgs) Handles Kayit_e_posta.Enter
        If Kayit_e_posta.Text = "E-Posta" Then
            Kayit_e_posta.Text = ""

        End If
    End Sub
    Private Sub Kayit_e_posta_Leave(sender As Object, e As EventArgs) Handles Kayit_e_posta.Leave
        If Kayit_e_posta.Text = "" Then
            Kayit_e_posta.Text = "E-Posta"
        End If
    End Sub
    Private Sub Kayit_nick_Enter(sender As Object, e As EventArgs) Handles Kayit_nick.Enter
        If Kayit_nick.Text = "Oyuncu Nick" Then
            Kayit_nick.Text = ""
        End If
    End Sub

    Private Sub Kayit_nick_Leave(sender As Object, e As EventArgs) Handles Kayit_nick.Leave
        If Kayit_nick.Text = "" Then
            Kayit_nick.Text = "Oyuncu Nick"
        End If
    End Sub
#End Region
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("LoginVersion") = True Then
            lblversion.Text = "v." & LoginVersionControl.LoginVersion_Read()
        Else
            lblversion.Text = "v." & AppLoginNumberVersion
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorProvider1.Clear()
        If Filter() = True Then
            ErrorProvider1.SetError(Kayit_nick, "Bu Nick'i Kullanmak Yasaktir.")
        Else
            If kayit_uname.Text = "Kullanıcı Adı" Then
                ErrorProvider1.SetError(kayit_uname, "Kullanıcı Adı Belirtilmemiş !")
                kayit_uname.Select()
            ElseIf Kayit_upass.Text = "Parola" Then
                ErrorProvider1.SetError(Kayit_upass, "Parola Belirtilmemiş !")
                Kayit_upass.Select()
            ElseIf Kayit_e_posta.Text = "E-Posta" Then
                ErrorProvider1.SetError(Kayit_e_posta, "E-Posta Adresi Belirtilmemiş !")
                Kayit_e_posta.Select()
            ElseIf Kayit_nick.Text = "Oyuncu Nick" Then
                ErrorProvider1.SetError(Kayit_nick, "Oyuncu Nick Belirtilmemiş !")
                Kayit_nick.Select()
            Else
                Try
                    Dim Result = DataLayer.Register_Verify(Playerİnfo.Mac, kayit_uname.Text, Kayit_e_posta.Text, Kayit_nick.Text)
                    If Result <> "True" Then
                        MsgBox(Result, MsgBoxStyle.Information, "AEFNET SİSTEM")
                    Else
                        Button1.Enabled = False
                        MailCodeVerify()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SYSTEM")
                End Try
            End If
        End If
    End Sub
    Public Sub PlayerWantRegister()
        Dim Players As New PlayerRegister(playerUsername:=kayit_uname.Text,
                                                 playerPassword:=Kayit_upass.Text,
                                                 playerEmail:=Kayit_e_posta.Text,
                                                 playerNick:=Kayit_nick.Text,
                                                 playerMacAdres:=Playerİnfo.Mac,
                                                 playerİpAdres:=Playerİnfo.GetIP)
        Dim Result = Players.PlayerRegister()
        If Result = True Then
            MsgBox("Kayit Başariyla Gerçekleşti." & vbNewLine &
                   "Üyelik Bilgileriniz Mail Adresinize Gönderilmiştir.", MsgBoxStyle.Information, "AEFNET SİSTEM")
            Registerİnfo()
        Else
            MsgBox("Sunucuya Bağlanılamıyor!, İnternet Baglantınızı kontrol ediniz.", MsgBoxStyle.Critical, "BAĞLANTI HATASI")
        End If

    End Sub
    Public Sub MailCodeVerify()
        Dim MailSystem As New SystemSupportMail()
        Rasgele = Random1
        Dim Result = MailSystem.Send_Mail(subject:="AEFNET SİSTEM : MAİL DOĞRULAMA",
                             body:="Command & Conquer’e Tekrar Hoşgeldiniz " & kayit_uname.Text & vbNewLine &
                             "Dogrulama Kodunuz : " & Rasgele & vbNewLine &
                             "AeFNeT, Türkiye’nin en büyük Command & Conquer çok oyunculu platformlarından biridir." & vbNewLine &
                             "AeFNet Ailesi Olarak İyi Oyunlar Dileriz Komutan",
                             receiverMail:=Kayit_e_posta.Text)
        If Result = True Then
            Verify.Show()
        Else
            MsgBox(Result, MsgBoxStyle.Critical, "AEFNET SYSTEM")
        End If
    End Sub
    Private Sub Registerİnfo()
        Dim MailSystem As New SystemSupportMail()
        Dim Result = MailSystem.Send_Mail(subject:="AEFNET ÜYELİK BİLGİLERİNİZ",
                             body:="Command & Conquer’e Tekrar Hoşgeldiniz." & vbNewLine & vbNewLine &
                             "- BİLGİLERİNİZ -" & vbNewLine & vbNewLine &
                             "Kullanici Adiniz : " & kayit_uname.Text & vbNewLine &
                             "Mevcut Şifreniz  : " & Kayit_upass.Text & vbNewLine &
                             "E-Posta'nız : " & Kayit_e_posta.Text & vbNewLine &
                             "Mevcut Oyuncu Nickiniz : " & Kayit_nick.Text & vbNewLine & vbNewLine &
                             "AeFNeT, Türkiye’nin en büyük Command & Conquer çok oyunculu platformlarından biridir." & vbNewLine &
                             "AeFNet Ailesi Olarak İyi Oyunlar Dileriz Komutan. " & vbNewLine & vbNewLine &
                             "- AEFNET YAZİLİM GRUBU - ",
                             receiverMail:=Kayit_e_posta.Text)
        If Result = False Then
            MsgBox("Aefnet Mail Server'da Sorun Vardir ! Lütfen Yöneticiye Bildir.", MsgBoxStyle.Exclamation, "AEFNET SYSTEM")
        End If
    End Sub
End Class