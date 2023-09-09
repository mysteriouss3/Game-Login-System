Imports System.Runtime.InteropServices
Public Class Verify
#Region "BtnClose And BtnMininize"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMininize_Click(sender As Object, e As EventArgs) Handles BtnMininize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Form Hareket Setting"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub PanelBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBar.MouseDown, MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        MsgBox("Spam Klosörünüzü Kontrol Etmeyi Unutmayiniz." & vbNewLine &
                "Doğrulama Kodu'nuzun Gelmesi Zaman Alabilir." & vbNewLine &
                " Lütfen Bekleyiniz.", MsgBoxStyle.Information, "AEFNET SYSTEM")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reset()
        If TextBox1.Text = Nothing Then
            ErrorProvider1.SetError(TextBox1, "Doğrulama Kodunuzu Yazmadiniz !")
        Else
            If TextBox1.Text = Register.Rasgele Then
                Try
                    Register.PlayerWantRegister()
                    LoginPage.Show()
                    Register.Close()
                    Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET SİSTEM")
                End Try
            Else
                İmagesError.Visible = True
                lblError.Visible = True
                lblError.Text = "Doğrulama Kodu Hatali !"
            End If
        End If
    End Sub
    Private Sub Reset()
        ErrorProvider1.Clear()
        İmagesError.Visible = False
        lblError.Visible = False
    End Sub
End Class