Imports System.Runtime.InteropServices
Imports DataCenter

Public Class Forget_Password
    Private ReadOnly DataSend As New DataLayer()
#Region "BtnClose And Mininize"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
    Private Sub BtnMininize_Click(sender As Object, e As EventArgs) Handles BtnMininize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Form Hareket Settings"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub PanelBarr_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarr.MouseDown, MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub KodSend_Click(sender As Object, e As EventArgs) Handles KodSend.Click
        Reset()
        Try
            If Posta.Text = Nothing Then
                PictureBox1.Visible = True
                lblError.Visible = True
                lblError.Text = "E-Posta adresinizi yazmadınız."
            Else
                Dim Result = DataSend.RecoverPassword(Posta.Text)
                If Result = True Then
                    MsgBox("Merhaba" & vbNewLine & "Şifre Kurtarma Talebinde Bulundunuz." & vbNewLine &
                           "Şifrenizi Kayit Olurken Girdiğiniz Mail Adresinize Gönderilmiştir." & vbNewLine &
                           "İyi Oyunlar Dileriz.", MsgBoxStyle.Information, "AEFNET SİSTEM")
                    Close()
                Else
                    PictureBox1.Visible = True
                    lblError.Visible = True
                    lblError.Text = "Sistemde böyle bir mail adresi kayitli değildir !"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SYSTEM")
        End Try
    End Sub
    Private Sub Reset()
        lblError.Visible = False
        PictureBox1.Visible = False
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Result As DialogResult = MsgBox("Sizi Yöneticiye Aktaracağiz. Sitedeki Canli Destek Kismindan," & vbNewLine &
                                            "Yönetici Arkadaşlarimiza Mesaj Gönderin." & vbNewLine &
                                            "Onayliyor musunuz ?", MsgBoxStyle.YesNo)
        If Result = DialogResult.Yes Then
            Process.Start("https://aefnet.com")
            Close()
        Else
            Close()
        End If
    End Sub
End Class