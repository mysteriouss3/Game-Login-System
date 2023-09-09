Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions
Imports System.Net
Public Class Playerİnfo
    Public Function GetIP() As String
        ServicePointManager.Expect100Continue = True
        ServicePointManager.DefaultConnectionLimit = 9999
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim wc As New WebClient()
        Dim strIP As String = wc.DownloadString("http://checkip.dyndns.org")
        strIP = New Regex("\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b").Match(strIP).Value
        wc.Dispose()
        Return strIP
    End Function
    Public Function Mac() As String
        Dim Mac_Adress As String = (From nic In NetworkInterface.GetAllNetworkInterfaces()
                                    Where nic.OperationalStatus = OperationalStatus.Up
                                    Select nic.GetPhysicalAddress()).FirstOrDefault().ToString()
        Return Mac_Adress
    End Function
End Class