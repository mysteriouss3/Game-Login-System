Imports MySql.Data.MySqlClient
Imports DataAccess
Imports UserModel
Public Class MailController
    Inherits LoginDataBase
    Private ReadOnly Şifrele As New Encryption()
    Public Function PasswordForget(RequestingUser As String) As String
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE Email=@Email"
                Command.Parameters.AddWithValue("@Email", RequestingUser)
                Command.CommandType = CommandType.Text
                Dim Reader As MySqlDataReader = Command.ExecuteReader()
                If Reader.Read() = True Then
                    Dim Username = Reader.GetString(1)
                    Dim UserPassword = Reader.GetString(2)
                    Dim UserMail = Reader.GetString(3)
                    Dim MailSystem As New SystemSupportMail()
                    MailSystem.Send_Mail(subject:="AEFNET SİSTEM : ŞİFRE KURTARMA İSTEĞİ",
                                         body:="Merhaba " & Username & vbNewLine & "Şifre Kurtarma Talebinde Bulundunuz." & vbNewLine &
                                         "Mevcut Şifreniz : " & Şifrele.Şifre_Çoz(UserPassword) & vbNewLine &
                                         "Ancak, Sisteme Şifrenizi Girdiğinizde Hemen Değiştirmenizi Rica Ediyoruz.",
                                         receiverMail:=UserMail)
                    Return True
                Else
                    Return False
                End If
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Function
    Public Sub PasswordRenewal()
        Dim MailSystem As New SystemSupportMail()
        Try
            MailSystem.Send_Mail(subject:="AEFNET SİSTEM : ŞİFRENİZ YENİLENDİ ",
                                         body:="Merhaba " & Player_Username & " Şifre'niz Yenilendi. " & vbNewLine &
                                         "" & vbNewLine &
                                         "Yeni Şifre'niz : " & Şifrele.Şifre_Çoz(Player_Password) & " Olarak Güncellenmiştir." & vbNewLine &
                                         "" & vbNewLine &
                                         "BU MAİL, SİZİ BİLGİLENDİRMEK İÇİN GÖNDERİLMİŞTİR." & vbNewLine &
                                         "AeFNeT, Türkiye’nin en büyük Command & Conquer çok oyunculu platformlarından biridir." & vbNewLine &
                                         "AeFNet Ailesi Olarak İyi Oyunlar Dileriz Komutan." & vbNewLine &
                                         "" & vbNewLine &
                                         "- AEFNET YAZILIM GRUBU - ",
                                         receiverMail:=Player_E_Mail)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "AEFNET SYSTEM")
        End Try
    End Sub
End Class
