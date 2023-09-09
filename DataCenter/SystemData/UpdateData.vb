Imports DataAccess
Imports MySql.Data.MySqlClient
Public Class UpdateData
    Inherits LoginDataBase
    Private ReadOnly Şifrele As New Encryption()
    Dim ThisMoment As Date
    Public Sub Nick_Update(Gamers_Nick As String, UserName As String)
        ThisMoment = Now
        Dim Tarih As String = Format(ThisMoment, "dd-MM-yyyy HH:mm:ss")
        Dim Tarih1 As String = Format(ThisMoment, "dd-MM-yyyy")
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "UPDATE Hesaplar SET PlayerNick=@PlayerNick, NickUpdateDate=@NickUpdateDate WHERE Username=@Username"
                Command.Parameters.AddWithValue("@PlayerNick", Gamers_Nick)
                Command.Parameters.AddWithValue("@NickUpdateDate", Tarih1)
                Command.Parameters.AddWithValue("@Username", UserName)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "UPDATE Admin_Panel SET Nick=@Nick WHERE Username=@Username"
                Command.Parameters.AddWithValue("@Nick", Gamers_Nick)
                Command.Parameters.AddWithValue("@Username", UserName)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub PlayerPasswordUpdate(PlayerPassword As String, PlayerUsername As String)
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "UPDATE Hesaplar SET Password=@Password WHERE Username=@Username"
                Command.Parameters.AddWithValue("@Password", Şifrele.Şifre_Olustur(PlayerPassword))
                Command.Parameters.AddWithValue("@Username", PlayerUsername)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub İp_Join_Date_Update(My_ip As String, User_id As String)
        ThisMoment = Now
        Dim Tarih As String = Format(ThisMoment, "dd.MM.yyyy HH:mm:ss")
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "UPDATE Hesaplar SET ipAdress=@ipAdress, Hesap_Giris_Date=@Hesap_Giris_Date WHERE Username=@Username"
                Command.Parameters.AddWithValue("@ipAdress", My_ip)
                Command.Parameters.AddWithValue("@Hesap_Giris_Date", Tarih)
                Command.Parameters.AddWithValue("@Username", User_id)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub Warning_Update(Username As String)
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "UPDATE Admin_Panel SET Warning_Status=@Warning_Status WHERE Username=@Username"
                Command.Parameters.AddWithValue("@Warning_Status", "Okundu")
                Command.Parameters.AddWithValue("@Username", Username)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub PNickChangeUpdate(PUsername As String)
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "UPDATE Admin_Panel SET PlayerNick_Status=@PlayerNick_Status WHERE Username=@Username"
                Command.Parameters.AddWithValue("@PlayerNick_Status", "Pasif")
                Command.Parameters.AddWithValue("@Username", PUsername)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
        End Using
    End Sub
End Class
