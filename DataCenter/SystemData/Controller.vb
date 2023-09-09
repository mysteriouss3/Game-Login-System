Imports MySql.Data.MySqlClient
Imports DataAccess
Imports UserModel
Public Class Controller
    Inherits LoginDataBase
    ReadOnly Şifrele As New Encryption()
    Public Function Login_Control(Username As String, Pass As String) As String
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE Username=@Username AND Password=@Password"
                Command.Parameters.AddWithValue("@Username", Username)
                Command.Parameters.AddWithValue("@Password", Şifrele.Şifre_Olustur(Pass))
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                Do While Reader.Read
                    If Reader.GetString(10) = "Pasif" Then
                        Return "Hesabınız Yönetici Tarafından Bloke Edilmiştir."
                    ElseIf Reader.GetString(10) = "Aktif" Then
                        Player_Username = Reader.GetString(1)
                        Player_Password = Reader.GetString(2)
                        Player_E_Mail = Reader.GetString(3)
                        Player_Nick = Reader.GetString(4)
                        Player_Nick_LastUpdate_Date = Reader.GetString(9)
                        Return True
                    End If
                Loop
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
        Return "Kullanici Adi Yada Şifre Yanliş."
    End Function
    Public Function Control_Register(Mac_Adres As String, Username As String, E_Posta As String, Nick As String) As String
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE MacAdress=@MacAdress"
                Command.Parameters.AddWithValue("@MacAdress", Mac_Adres)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                If Reader.HasRows Then
                    Return "Daha Önce Bu Bilgisayardan Kayit Oldunuz."
                End If
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE Username=@Username"
                Command.Parameters.AddWithValue("@Username", Username)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                If Reader.HasRows Then
                    Return "Bu Kullanıcı Adı Başkası Tarafından Kullanılıyor."
                End If
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE Email=@Email"
                Command.Parameters.AddWithValue("@Email", E_Posta)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                If Reader.HasRows Then
                    Return "Bu E-Posta Adresi Başkası Tarafından Kullanılıyor."
                End If
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE PlayerNick=@PlayerNick"
                Command.Parameters.AddWithValue("@PlayerNick", Nick)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                If Reader.HasRows Then
                    Return "Bu Oyuncu Nick'i Başkası Tarafından Kullanılıyor."
                End If
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
            Return True
        End Using
    End Function
    Public Function PlayerNickControl(Nick As String) As String
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE PlayerNick=@PlayerNick"
                Command.Parameters.AddWithValue("@PlayerNick", Nick)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                If Reader.HasRows Then
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
End Class