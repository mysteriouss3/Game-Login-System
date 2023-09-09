Imports DataCenter
Public Class PlayersTop5
    Private Sub PlayersTop5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Datas.DataSource = Top5PlayerTable
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SİSTEM")
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Profile.FormAdd(Of HomeProfile)()
        Close()
    End Sub
End Class