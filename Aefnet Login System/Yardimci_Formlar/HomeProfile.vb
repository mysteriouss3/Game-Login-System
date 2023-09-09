Imports DataCenter
Imports UserModel
Public Class HomeProfile
    Private ReadOnly Playerİnfo As New Playerİnfo()
    Private Sub HomeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        İnitalizeSystemLoad()
    End Sub
    Private Sub İnitalizeSystemLoad()
        Try
            If AnnouncementStatus = "Aktif" Then
                lblduyuru.Text = "DUYURU : " & AnnouncementNotice
            Else
                lblduyuru.Text = "DUYURU : " & "Herhangi Bir Duyuru Bildirilmedi."
            End If
            lblipadres.Text = Playerİnfo.GetIP
            lblmacadres.Text = Playerİnfo.Mac
            If NewsControl = "Pasif" Then
                lblhaberler.Text = "HABERLER : " & "Aefnet'ten Yeni Bir Haber Bildirilmedi."
            Else
                lblhaberler.Text = "HABERLER : " & News
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SİSTEM")
        End Try
    End Sub
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
End Class