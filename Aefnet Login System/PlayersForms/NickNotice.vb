Imports System.Runtime.InteropServices
Imports DataCenter
Public Class NickNotice
#Region "Form Hareket Settings"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub PanelBar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub

#End Region
    Private Sub NickNotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NickChangeStatus = "Aktif" Then
            lblWarning.Text = NickChangeNotice
        Else
            lblWarning.Text = "Lütfen Yönetici İle İletişime Geçiniz."
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class