Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Public Class AppUpdate
    Private ReadOnly AppUpdater As New AppUpdater()
    Private Sharing_URL As String
    Private Totalsize As String
    Private Amount As String
    Private Csize As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()
        Timer1.Start()
    End Sub
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
    Public Function URL_Reading()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim URL As New WebClient()
        Sharing_URL = URL.DownloadString(AppDownloadURL)
        URL.Dispose()
        Return Sharing_URL
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim Size1 As Integer
        Dim wr As WebRequest
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        wr = WebRequest.Create(URL_Reading)
        Dim webr As WebResponse = wr.GetResponse
        Size1 = webr.ContentLength
        webr.Close()
        Size1 /= 1024
        ProgressBar1.Maximum = Size1
        Totalsize = Size1
        Try
            If File.Exists(UpdaterToolsMix_Yol) = False Then
                Dim MsgResult = MsgBox("Updater Tools Bilgisayarinizda Bulunamadi! Oyunu Sıfırlamanız Gerekmektedir," &
                                       "Aksi Halde Oyuna Giremiceksiniz." + vbNewLine + " Oyunu Şimdi Sıfırlamak İstiyor musunuz?", MsgBoxStyle.YesNo)
                If MsgResult = MsgBoxResult.Yes Then
                    Process.Start(FullUpdaterRun)
                    Application.Exit()
                Else
                    Application.Exit()
                End If
            Else
                My.Computer.FileSystem.CreateDirectory(FileUpdater)
                My.Computer.Network.DownloadFile(Sharing_URL, FileUpdater & DownloadFileName, 500000, True)
                MsgBox("Güncelleme İşlemi Başariyla Tamamlandi.", MsgBoxStyle.Information, "AEFNET GÜNCELLEYİCİ SİSTEMİ")
                RenameFiless()
                Process.Start(ToolsRun)
                Application.Exit()
            End If
        Catch ex As Exception
            If My.Computer.FileSystem.DirectoryExists(FileUpdater) Then
                My.Computer.FileSystem.DeleteDirectory(FileUpdater, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            Process.Start(FullUpdaterRun)
            Application.Exit()
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If File.Exists(FileUpdater & DownloadFileName) Then
            Dim o As New FileInfo(FileUpdater & DownloadFileName)
            Amount = o.Length
            Amount /= 1024
            Csize = Amount
            ProgressBar1.Value = Amount
            Label1.Text = Csize + " KBs / " + Totalsize + " KBs"
        End If
    End Sub
    Public Function DosyaSize()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim Server As HttpWebRequest = WebRequest.Create(URL_Reading)
        Dim Cevap As HttpWebResponse = Server.GetResponse()
        Dim DosyaBoyut As Long = Cevap.ContentLength.ToString()
        DosyaBoyut = DosyaBoyut / 1024 / 1024
        Cevap.Close()
        Return DosyaBoyut
    End Function
    Function Version_Read()
        Dim Reader As New StreamReader(AppVersion_Yol)
        Dim Str_Oku = Reader.ReadLine()
        Reader.Close()
        Return Str_Oku
    End Function
    Private Sub RenameFiless()
        My.Computer.FileSystem.RenameFile(UpdaterToolsMix, UpdaterToolsFile)
        File.WriteAllText(AppVersion_Yol, File.ReadAllText(AppVersion_Yol).Replace(Version_Read, AppUpdater.AppVersionNumber()))
    End Sub
End Class