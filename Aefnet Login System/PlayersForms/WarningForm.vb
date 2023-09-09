Imports System.Runtime.InteropServices
Imports DataCenter
Imports UserModel
Public Class WarningForm
    Private ReadOnly UpdateData As New UpdateData()
#Region "Uygulama Hareket"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub UyariForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub BtnMininize_Click(sender As Object, e As EventArgs) Handles BtnMininize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
    Private Sub UyariForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateData.Warning_Update(Player_Username)
        lblWarning.Text = PlayerWarningNotice
    End Sub
End Class