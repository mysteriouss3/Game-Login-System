Imports DataCenter
Public Class LaddersForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Datas.DataSource = RankedAllPlayerTable
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SYSTEM")
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Profile.FormAdd(Of HomeProfile)()
    End Sub
End Class