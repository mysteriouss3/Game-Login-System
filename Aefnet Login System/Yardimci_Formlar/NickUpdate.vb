Imports DataCenter
Imports UserModel
Public Class NickUpdate
    Private ReadOnly DateControl As New DateControl()
    Private ReadOnly UpdateData As New UpdateData()
    Private ReadOnly GamePlayerNickUpdater As New PlayerNickUpdater()
    Private ReadOnly DataLayer As New DataLayer()
    Private ReadOnly ReadApp As New ReadDataApp()
    Dim ThisMoment As Date
#Region "TxtNickChange Leave And Enter"
    Private Sub TxtNickChange_Leave(sender As Object, e As EventArgs) Handles txtNickChange.Leave
        If txtNickChange.Text = "" Then
            txtNickChange.Text = "Nick Giriniz..."
        End If
    End Sub
    Private Sub TxtNickChange_Enter(sender As Object, e As EventArgs) Handles txtNickChange.Enter
        If txtNickChange.Text = "Nick Giriniz..." Then
            txtNickChange.Text = ""
        End If
    End Sub
#End Region
#Region "Nick Change Key Filtre"
    Private Sub TxtNickChange_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNickChange.KeyPress
        If txtNickChange.TextLength = 0 Then
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
#Region "txtNickChange Filter"
    Private Function Filter()
        Dim lst As New List(Of String) _
    From {"gamemaster", "GAMEMASTER", "yonetici", "YONETICI", "Yonetici", "Anan", "anan", "Yetkili", "yetkili", "mod", "Admin",
    "admin*", "allahu", "akbar", "twat", "cock", "pussy", "hitler", "anal", "aefnet", "got", "sik", "pic", "serefsiz", "kaltak", "siker", "skerim", "sikerim", "amk", "siker",
    "gotos", "gamemaster", "antialperen", "anani", "avrat", "kerhaneci*", "sikik", "AEF", "kahpe", "orosbu", "orospu", "sikiyim", "administrator",
    "admin", "ADMIN", "AEFNET", "Aefnet", "aefnet", "MODERATOR", "MOD", "moderator", "Sex"}
        For Each i As String In lst
            If txtNickChange.Text = i Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region
#Region "Nick Change Settings"
    Private Sub Reset()
        LastPlayerNick.Items.Clear()
        LastPlayerNick.Items.Add(txtNickChange.Text)
        LastPlayerNick.Text = txtNickChange.Text
        txtNickChange.Clear()
    End Sub
#End Region
#Region "NickChange"
    Private Sub UpdateNick()
        GamePlayerNickUpdater.Player_Nick(txtNickChange.Text)
        UpdateData.Nick_Update(txtNickChange.Text, Player_Username)
        ReadApp.PasswordAndPNickRead(Player_Username)
        Profile.lblNick.Text = txtNickChange.Text
        DateTime()
        Reset()
        Button_Disable()
        MsgBox("Nick Değiştirildi.", MsgBoxStyle.Information, "AEFNET SİSTEM")
        ReadApp.AllPlayers()
    End Sub
#End Region
#Region "Date Control"
    Private Sub DateTime()
        ThisMoment = Now
        Dim Tarih As String = Format(ThisMoment, "dd-MM-yyyy")
        lblİnfo.Text = "Nickler Ayda Sadece Bir Kez Değişmektedir. Siz En Son : " + Tarih + " Tarihinde Nick Değiştirdiniz."
    End Sub
#End Region
    Private Sub NickUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblİnfo.Text = "Nickler Ayda Sadece Bir Kez Değişmektedir. Siz En Son : " + Player_Nick_LastUpdate_Date + " Tarihinde Nick Değiştirdiniz."
        LastPlayerNick.Items.Add(Player_Nick)
        LastPlayerNick.Text = Player_Nick
        SecuritySettings()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Profile.FormAdd(Of HomeProfile)()
        Close()
    End Sub
    Private Sub Button_Disable()
        txtNickChange.Enabled = False
        NickChange.Enabled = False
    End Sub
    Private Sub SecuritySettings()
        ''Herkes İçin İzin Verilen
        If NickChangeStatus = "Aktif" Then
            txtNickChange.Enabled = True
            NickChange.Enabled = True
        ElseIf PlayerNickStatus = "Aktif" Then  ''Yönetici Tarafindan İzin Verilen Kullanici
            txtNickChange.Enabled = True
            NickChange.Enabled = True
        ElseIf DateControl.NickDateControl() = True Then
            txtNickChange.Enabled = True
            NickChange.Enabled = True
        Else
            Button_Disable()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NickChange.Click
        ErrorProvider1.Clear()
        If txtNickChange.Text = Nothing Or txtNickChange.Text = "Nick Giriniz..." Then
            ErrorProvider1.SetError(txtNickChange, "Lütfen Yeni Bir Oyuncu Nick Giriniz.")
        ElseIf Filter() = True Then
            ErrorProvider1.SetError(txtNickChange, "Bu Nick'i Kullanmak Yasaktir.")
        ElseIf txtNickChange.Text = Player_Nick Then
            ErrorProvider1.SetError(txtNickChange, "Değiştirmek İstediğiniz Oyuncu Nick Eski Nick'iniz İle Ayni !")
        Else
            Try
                If DataLayer.Nick_Verify(txtNickChange.Text) = True Then
                    ErrorProvider1.SetError(txtNickChange, "Bu Nick Baskası Tarafından Kullanılıyor. Lütfen Başka Bir Nick Yazin.")
                Else
                    If PlayerNickStatus = "Aktif" Then  ''Yönetici Tarafindan İzin Verilen Kullanici
                        UpdateNick()
                        UpdateData.PNickChangeUpdate(Player_Username)
                        ReadApp.PlayerNickNameStatus(Player_Username)
                    Else
                        UpdateNick()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Nick Değiştirilemiyor, Çünkü Nickler Ayda Birkez Değişmektedir.", MsgBoxStyle.Exclamation, "AEFNET SİSTEM")
            End Try
        End If
    End Sub
End Class