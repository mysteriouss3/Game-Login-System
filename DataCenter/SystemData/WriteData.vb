Imports MySql.Data.MySqlClient
Imports DataAccess
Public Class WriteData
    Inherits LoginDataBase
    Dim ThisMoment As Date
    ReadOnly Şifrele As New Encryption()
    Public Sub Register(Username As String, Pass As String, Posta As String, Gamers_Nick As String, Mac_Adres As String, İp_Adres As String)
        ThisMoment = Now
        Dim Tarih As String = Format(ThisMoment, "dd-MM-yyyy HH:mm:ss")
        Dim Tarih1 As String = Format(ThisMoment, "dd-MM-yyyy")
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "INSERT INTO Hesaplar (Username, Password, Email, PlayerNick, MacAdress, ipAdress, Hesap_Giris_Date, HesapKayitDate, NickUpdateDate) values(@Username, @Password, @Email, @PlayerNick, @MacAdress, @ipAdress, @Hesap_Giris_Date, @HesapKayitDate, @NickUpdateDate)"
                Command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = Username
                Command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Şifrele.Şifre_Olustur(Pass)
                Command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Posta
                Command.Parameters.Add("@PlayerNick", MySqlDbType.VarChar).Value = Gamers_Nick
                Command.Parameters.Add("@MacAdress", MySqlDbType.VarChar).Value = Mac_Adres
                Command.Parameters.Add("@ipAdress", MySqlDbType.VarChar).Value = İp_Adres
                Command.Parameters.Add("@Hesap_Giris_Date", MySqlDbType.VarChar).Value = Tarih
                Command.Parameters.Add("@HesapKayitDate", MySqlDbType.VarChar).Value = Tarih
                Command.Parameters.Add("@NickUpdateDate", MySqlDbType.VarChar).Value = Tarih1
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
                Command.Dispose()
            End Using
            Using Cmd = New MySqlCommand()
                Cmd.Connection = Baglanti
                Cmd.CommandText = "INSERT INTO Admin_Panel (Username, Nick) values(@Username, @Nick)"
                Cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = Username
                Cmd.Parameters.Add("@Nick", MySqlDbType.VarChar).Value = Gamers_Nick
                Cmd.CommandType = CommandType.Text
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
            End Using
        End Using
    End Sub
End Class
