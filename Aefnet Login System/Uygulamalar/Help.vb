Imports DataCenter
Imports System.Runtime.InteropServices
Imports System.IO
Public Class Help
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
#Region "Web Site Yönlendirme"
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://discord.com/invite/PfDtdCy")
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://aefnet.com")
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("https://discord.com/invite/PfDtdCy")
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Process.Start("https://aefnet.com")
    End Sub
#End Region
    Private Sub Btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Dim Result As DialogResult = MsgBox("Sizi Yöneticiye Aktaracağiz. Sitedeki Canli Destek Kismindan," & vbNewLine &
                                            "Yönetici Arkadaşlarimiza Mesaj Gönderiniz." & vbNewLine &
                                            "Onayliyor musunuz ?", MsgBoxStyle.YesNo)
        If Result = DialogResult.Yes Then
            Process.Start("https://aefnet.com")
            Close()
        Else
        End If
    End Sub

    Private Sub Btnistek_Click(sender As Object, e As EventArgs) Handles btnistek.Click
        Dim Result As DialogResult = MsgBox("Sizi Discord Sunucumuza Aktaracağiz. Eğer Discorda Kayıtlı Değilseniz," & vbNewLine &
                                            "Lütfen Kayıt Olun. Kayıt Olmayi Bilmiyorsanız Youtube'dan Bakabilirsiniz." & vbNewLine &
                                            "Discord Sunucumuza Katılmayi Onayliyor musunuz ?", MsgBoxStyle.YesNo)
        If Result = DialogResult.Yes Then
            Process.Start("https://discord.com/invite/PfDtdCy")
            Close()
        Else
        End If
    End Sub

    Private Sub BtnSıfırla_Click(sender As Object, e As EventArgs) Handles BtnSıfırla.Click
        Dim Result As DialogResult = MsgBox("Oyun En Güncel Version'una Çevrilecektir. Güncel Version'a Çevrilmesi Durumunda, Eğer Oyunda Bir Sorun Varsa Düzelir." & vbNewLine &
                                            "Oyunu Sıfırlamayi Onayliyor musunuz ?", MsgBoxStyle.YesNo)
        Try
            If Result = DialogResult.Yes Then
                If Qt_Updater_Full_Setting = "Aktif" Then
                    Process.Start(FullUpdaterRun)
                    Application.Exit()
                Else
                    MsgBox("Aefnet Güncelleme Sisteminde Sorun Vardir. Anlayişiniz İçin Teşekkürler !", MsgBoxStyle.Exclamation, "AEFNET SYSTEM")
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SYSTEM")
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class