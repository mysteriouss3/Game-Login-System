
Imports DataCenter
Public Class AllPlayers
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Profile.FormAdd(Of HomeProfile)()
        Close()
    End Sub
    Private Sub AllPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AllPlayerTable.DataSource = AllPlayersTable
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "AEFNET SİSTEM")
        End Try
    End Sub
End Class