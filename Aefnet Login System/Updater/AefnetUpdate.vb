Imports System.IO
Imports System.Net
Imports System.IO.Compression
Imports System.Runtime.InteropServices
Public Class AefnetUpdate
    Private ReadOnly AefnetUpdater As New AefnetUpdater()
    'ReadOnly AppYol As String = New FileInfo(Application.ExecutablePath).DirectoryName 'klasör yolu alma
    ReadOnly ExeName As String = Process.GetCurrentProcess().MainModule.FileName ' çalışan exe adı
    Private URL_Download As String
    Private Totalsize As String
    Private Amount As String
    Private Csize As String
#Region "Uygulama Hareket"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        CheckForIllegalCrossThreadCalls = False
        Timer2.Start()
    End Sub
    Public Function URL_Read()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim Web As New WebClient()
        URL_Download = Web.DownloadString(AefnetDownloadURL)
        Web.Dispose()
        Return URL_Download
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim Size1 As Integer
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim wr As WebRequest
        wr = WebRequest.Create(URL_Read)
        Dim webr As WebResponse = wr.GetResponse
        Size1 = webr.ContentLength
        webr.Close()
        Size1 /= 1024
        ProgressBar.Maximum = Size1
        Totalsize = Size1
        Try
            My.Computer.Network.DownloadFile(URL_Download, AppYol & AefnetDownloadFileName, 500000, True)
            MsgBox("Güncelleme İşlemi Başariyla Tamamlandi.", MsgBoxStyle.Information, "AEFNET GÜNCELLEYİCİ SİSTEMİ")
            File.WriteAllText(AefnetVersion_Yol, File.ReadAllText(AefnetVersion_Yol).Replace(AefnetUpdater.Version_Read(), AefnetUpdater.Control()))
            Using archive As ZipArchive = ZipFile.OpenRead(AppYol & AefnetDownloadFileName)
                For Each entry As ZipArchiveEntry In archive.Entries
                    Dim entryFullname = Path.Combine(".\", entry.FullName)
                    Dim entryPath = Path.GetDirectoryName(entryFullname)
                    If (Not (Directory.Exists(entryPath))) Then
                        Directory.CreateDirectory(entryPath)
                    End If
                    Dim entryFn = Path.GetFileName(entryFullname)
                    If (Not String.IsNullOrEmpty(entryFn)) Then
                        entry.ExtractToFile(entryFullname, True)
                    End If
                Next
            End Using
            My.Computer.FileSystem.DeleteFile(AppYol & AefnetDownloadFileName)
            Application.Restart()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AEFNET UPDATE SYSTEM")
            If File.Exists(AppYol & AefnetDownloadFileName) Then
                File.Delete(AppYol & AefnetDownloadFileName)
            End If
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End Try
    End Sub
    Public Function DosyaSizeZip()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim Server As HttpWebRequest = WebRequest.Create(URL_Read)
        Dim Cevap As HttpWebResponse = Server.GetResponse()
        Dim DosyaBoyut As Long = Cevap.ContentLength.ToString()
        DosyaBoyut = DosyaBoyut / 1024 / 1024
        Cevap.Close()
        Return DosyaBoyut
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If File.Exists(AppYol & AefnetDownloadFileName) Then
            Dim o As New FileInfo(AppYol & AefnetDownloadFileName)
            Amount = o.Length
            Amount /= 1024
            Csize = Amount
            ProgressBar.Value = Amount
            Label1.Text = Csize + " KBs / " + Totalsize + " KBs"
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        If File.Exists(AppYol & AefnetDownloadFileName) = True Then
            My.Computer.FileSystem.DeleteFile(AppYol & AefnetDownloadFileName)
        End If
        MsgBox("- Toplam Güncelleme Boyutu : " & DosyaSizeZip() & " MB", MsgBoxStyle.Information, "AEFNET GÜNCELLEYİCİ SİSTEMİ")
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class