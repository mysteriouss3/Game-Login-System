Imports MySql.Data.MySqlClient
Imports DataAccess
Imports UserModel
Public Class ReadDataApp
    Inherits LoginDataBase
    Public Sub AllPlayers()
        AllPlayersTable = New DataTable()
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT PlayerNick,Hesap_Giris_Date,Status FROM Hesaplar ORDER BY Hesap_Giris_Date DESC"
                Dim adapter As New MySqlDataAdapter(Command)
                adapter.Fill(AllPlayersTable)
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub App_Datas()
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand
                Command.Connection = Baglanti
                Command.CommandText = "Select * From Uygulama_Ayar WHERE ID=1"
                Dim Reader = Command.ExecuteReader()
                While Reader.Read
                    AppVersion = Reader.GetString(1)
                    RepairStatus = Reader.GetString(2)
                    RepairNotice = Reader.GetString(3)
                    AnnouncementStatus = Reader.GetString(4)
                    AnnouncementNotice = Reader.GetString(5)
                    NewsControl = Reader.GetString(6)
                    News = Reader.GetString(7)
                    NickChangeStatus = Reader.GetString(8)
                    NickChangeNotice = Reader.GetString(9)
                End While
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub App_Updater_Control()
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand
                Command.Connection = Baglanti
                Command.CommandText = "Select * From UpdaterControl WHERE ID=1"
                Dim Reader = Command.ExecuteReader()
                While Reader.Read
                    AppUpdaterSetting = Reader.GetString(1)
                    AefnetUpdaterSetting = Reader.GetString(2)
                    Qt_Updater_Full_Setting = Reader.GetString(2)
                End While
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub PlayerNickNameStatus(Username As String)
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "Select * From Admin_Panel WHERE Username=@Username"
                Command.Parameters.AddWithValue("@Username", Username)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                While Reader.Read()
                    PlayerNickStatus = Reader.GetString(2)
                End While
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub PasswordAndPNickRead(Username As String)
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM Hesaplar WHERE Username=@Username"
                Command.Parameters.AddWithValue("@Username", Username)
                Command.CommandType = CommandType.Text
                Dim Reader = Command.ExecuteReader()
                While Reader.Read()
                    Player_Password = Reader.GetString(2)
                    Player_Nick = Reader.GetString(4)
                    Player_Nick_LastUpdate_Date = Reader.GetString(9)
                End While
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub AdminPanelRead(Username As String)
        Using Baglanti = GetConnection()
            Baglanti.Open()
            Using command = New MySqlCommand()
                command.Connection = Baglanti
                command.CommandText = "Select * From Admin_Panel WHERE Username=@Username"
                command.Parameters.AddWithValue("@Username", Username)
                command.CommandType = CommandType.Text
                Dim Reader = command.ExecuteReader()
                While Reader.Read
                    PlayerWarning = Reader.GetString(4)
                    PlayerWarningNotice = Reader.GetString(5)
                End While
                Reader.Close()
                Reader.Dispose()
                command.Dispose()
            End Using
        End Using
    End Sub
End Class