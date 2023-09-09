Imports UserModel
Imports DataCenter
Public Class Edit_Profile
#Region "Form Settings"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Profile.FormAdd(Of HomeProfile)()
        Close()
    End Sub
    Private Sub Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        İnitalizeUserLoad()
        RankPictureControl()
    End Sub
    Private Sub LinkLabelEditProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditProfile.LinkClicked
        ChangePassword.Show()
    End Sub
#End Region
    Private Sub İnitalizeUserLoad()
        lblusername.Text = Player_Username
        lblnick.Text = Player_Nick
        lblemail.Text = Player_E_Mail
        If PlayerTotalWon = Nothing Then
            lbltotalwon.Text = "0"
        Else
            lbltotalwon.Text = PlayerTotalWon
        End If
        If PlayerTotalMatch = Nothing Then
            lbltotalmatch.Text = "0"
        Else
            lbltotalmatch.Text = PlayerTotalMatch
        End If
        If PlayerPoint = Nothing Then
            lblpoint.Text = "0"
        Else
            lblpoint.Text = PlayerPoint
        End If
    End Sub
    Private Sub RankPictureControl()
        Try
            If RankedPlayer_Rank = "Acemi" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-default.png")
            ElseIf RankedPlayer_Rank = "Tegmen" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t1.png")
            ElseIf RankedPlayer_Rank = "Yuzbasi" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t2.png")
            ElseIf RankedPlayer_Rank = "Binbasi" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t3.png")
            ElseIf RankedPlayer_Rank = "Yarbay" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t4.png")
            ElseIf RankedPlayer_Rank = "Albay" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t5.png")
            ElseIf RankedPlayer_Rank = "TugGeneral" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t6.png")
            ElseIf RankedPlayer_Rank = "Tumgeneral" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t7.png")
            ElseIf RankedPlayer_Rank = "Korgeneral" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t8.png")
            ElseIf RankedPlayer_Rank = "Orgeneral" Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-t9.png")
            ElseIf RankedPlayer_Rank = Nothing Then
                PictureRutbe.Image = Image.FromFile("Ranked\badge-default.png")
            End If
        Catch ex As Exception
            MsgBox("Rank Resim Dosyalari Bulunamadi.", MsgBoxStyle.Exclamation, "AEFNET SİSTEM")
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class