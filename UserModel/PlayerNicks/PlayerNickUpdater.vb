Imports System.IO
Public Class PlayerNickUpdater
    Private Const Dosya_Yol = "RA2MD.ini"
    Public Sub Player_Nick(Player_Nick As String)
        If File.Exists(Dosya_Yol) = True Then
            Player_Nick_Update(Player_Nick)
        Else
            Player_File_Create(Player_Nick)
        End If
    End Sub
#Region "Player Nick Update And Create"
    Private Sub Player_Nick_Update(ByVal PlayerNick As String)
        Dim addText As String = "[MultiPlayer]" + Environment.NewLine + "Handle=" + Environment.NewLine + "Theme="
        Dim startText As String = "[MultiPlayer]"
        Dim endText As String = "Theme="
        Dim content As String = ReadTxtFile(Dosya_Yol)
        Dim startPosition As Integer = Math.Max(0, content.IndexOf(startText))
        Dim endPosition As Integer = Math.Min(content.IndexOf(endText) + endText.Length, content.Length)
        Dim previousText As String = content.Substring(0, startPosition)
        Dim nextText As String = content.Substring(endPosition)
        content = previousText + addText + nextText
        WriteTxtFile(Dosya_Yol, content)
        File.WriteAllText(Dosya_Yol, File.ReadAllText(Dosya_Yol).Replace("Handle=", "Handle=" + PlayerNick))
    End Sub
    Private Sub Player_File_Create(ByVal PlayerNick As String)
        My.Computer.FileSystem.WriteAllText(Dosya_Yol, String.Empty, False)
        Dim addText As String = "[MultiPlayer]" + Environment.NewLine + "Handle=" + Environment.NewLine + "Theme=Allied Tema"
        Dim startText As String = "[MultiPlayer]"
        Dim endText As String = "Theme="
        Dim content As String = ReadTxtFile(Dosya_Yol)
        Dim startPosition As Integer = Math.Max(0, content.IndexOf(startText))
        Dim endPosition As Integer = Math.Min(content.IndexOf(endText) + endText.Length, content.Length)
        Dim previousText As String = content.Substring(0, startPosition)
        Dim nextText As String = content.Substring(endPosition)
        content = previousText + addText + nextText
        WriteTxtFile(Dosya_Yol, content)
        File.WriteAllText(Dosya_Yol, File.ReadAllText(Dosya_Yol).Replace("Handle=", "Handle=" + PlayerNick))
    End Sub
    Private Function ReadTxtFile(FileName As String) As String
        Dim textReader As TextReader = New StreamReader(FileName)
        Dim content As String = textReader.ReadToEnd()
        textReader.Dispose()
        textReader.Close()
        Return content
    End Function
    Private Sub WriteTxtFile(FileName As String, content As String)
        Dim textWriter As TextWriter = New StreamWriter(FileName)
        textWriter.Write(content)
        textWriter.Flush()
        textWriter.Close()
    End Sub
#End Region
End Class
