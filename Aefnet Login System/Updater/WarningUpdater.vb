Imports System.Runtime.InteropServices
Public Class WarningUpdater
    Private ReadOnly Updater As New AppUpdate()
#Region "Uygulama Hareket"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PanelBarr.MouseDown, Label1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(FileUpdater) Then
            My.Computer.FileSystem.DeleteDirectory(FileUpdater, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        Label1.Text = "Aefnet Login Sistemine Yeni Güncelleme Geldi." + vbNewLine +
        "- Güncelleme Boyutu : " & Updater.DosyaSize() & " MB"
    End Sub
    Private Sub KodSend_Click(sender As Object, e As EventArgs) Handles KodSend.Click
        Updater.Show()
        Close()
    End Sub
End Class