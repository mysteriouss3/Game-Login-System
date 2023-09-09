Imports DataCenter
Imports UserModel
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Profile
    Private ReadOnly Player As New PlayerNickUpdater()
    Private ReadOnly StartGame As New StartGame()
    Private ReadOnly LoginVersionControl As New AppUpdater()
#Region "BtnClose And BtnMininize"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        LoginPage.Close()
    End Sub
    Private Sub BtnMininize_Click(sender As Object, e As EventArgs) Handles BtnMininize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Ana Menu Ayar"
    Private Sub Menum_Tick(sender As Object, e As EventArgs) Handles Menum.Tick
        If panelMenu.Width <= 55 And ProfilePanel.Width <= 55 Then
            Menum.Enabled = False
        Else
            panelMenu.Width = panelMenu.Width - 10
            ProfilePanel.Width = ProfilePanel.Width - 10
        End If
    End Sub

    Private Sub Menu2_Tick(sender As Object, e As EventArgs) Handles Menu2.Tick
        If panelMenu.Width >= 265 And ProfilePanel.Width <= 265 Then
            Menu2.Enabled = False
        Else
            panelMenu.Width = panelMenu.Width + 10
            ProfilePanel.Width = ProfilePanel.Width + 10
        End If
    End Sub
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If panelMenu.Width = 265 And ProfilePanel.Width = 265 Then
            Menum.Enabled = True
        ElseIf panelMenu.Width = 55 And ProfilePanel.Width = 55 Then
            Menu2.Enabled = True
        End If
    End Sub
#End Region
#Region "Form Pozisyon"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBar.MouseDown, Ana_Panel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "Profile Load"
    Private Sub Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormAdd(Of HomeProfile)()
        İnitializePlayerİnfo()

    End Sub
#End Region
#Region "AnaPanel Settings"
    Public Sub FormAdd(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = Ana_Panel.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform With {
                .TopLevel = False,
                .FormBorderStyle = FormBorderStyle.None,
                .Dock = DockStyle.Fill
            }
            If Me.Ana_Panel.Controls.Count > 0 Then
                Me.Ana_Panel.Controls.RemoveAt(0)
                Ana_Panel.Controls.Add(Formulario)
                Ana_Panel.Tag = Formulario
                Formulario.Show()
                Formulario.BringToFront()
            Else
                Ana_Panel.Controls.Add(Formulario)
                Ana_Panel.Tag = Formulario
                Formulario.Show()
                Formulario.BringToFront()
            End If
        Else
            Formulario.BringToFront()
        End If
    End Sub
#End Region
#Region "Menu Button Click"
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles BtnMyİnfo.Click
        FormAdd(Of Edit_Profile)()
    End Sub
    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditProfile.LinkClicked
        FormAdd(Of NickUpdate)()
    End Sub
    Private Sub BtnStatus_Click(sender As Object, e As EventArgs) Handles BtnStatus.Click
        FormAdd(Of LaddersForm)()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FormAdd(Of AllPlayers)()
    End Sub
    Private Sub LblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        FormAdd(Of HomeProfile)()
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        FormAdd(Of HomeProfile)()
    End Sub
    Private Sub BtnOff_Click(sender As Object, e As EventArgs) Handles BtnOff.Click
        LoginPage.Show()
        Close()
    End Sub
    Private Sub BtnTop5_Click(sender As Object, e As EventArgs) Handles BtnTop5.Click
        FormAdd(Of PlayersTop5)()
    End Sub
#End Region
#Region "Picture Click"
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        FormAdd(Of Edit_Profile)()
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        FormAdd(Of AllPlayers)()
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        FormAdd(Of LaddersForm)()
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        FormAdd(Of PlayersTop5)()
    End Sub
#End Region
    Private Sub İnitializePlayerİnfo()
        If RankedPlayer_Rank = Nothing Then
            lblRank.Text = "Acemi"
        Else
            lblRank.Text = RankedPlayer_Rank
        End If
        lblUser.Text = Player_Username
        lblNick.Text = Player_Nick
        If File.Exists("LoginVersion") = True Then
            Label5.Text = "v." & LoginVersionControl.LoginVersion_Read()
        Else
            Label5.Text = "v." & AppLoginNumberVersion
        End If
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Try
            Player.Player_Nick(Player_Nick)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET LOGİN SYSTEM")
        End Try
        StartGame.Run()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StartGame.AgainRenameFile()
        Timer1.Stop()
        Application.Exit()
    End Sub
End Class