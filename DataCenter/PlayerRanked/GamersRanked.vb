Imports DataAccess
Imports UserModel
Imports MySql.Data.MySqlClient
Public Class GamersRanked
    Inherits RankedDataBase
    Public Sub RankPlayer()
        Using Baglanti = Ranked_Connection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT *FROM gamers_rank_archives WHERE name=@Nick"
                Command.Parameters.AddWithValue("@Nick", Player_Nick)
                Dim Reader = Command.ExecuteReader()
                While Reader.Read
                    RankedPlayer_Rank = Reader.GetString(2)
                End While
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub PlayerMatchİnfo()
        Using Baglanti = Ranked_Connection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT * FROM gamers Where name=@Nick"
                Command.Parameters.AddWithValue("@Nick", Player_Nick)
                Dim Reader = Command.ExecuteReader()
                While Reader.Read
                    PlayerPoint = Reader.GetString(3)
                    PlayerTotalWon = Reader.GetString(23)
                    PlayerTotalMatch = Reader.GetString(26)
                End While
                Reader.Close()
                Reader.Dispose()
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub Ranked1vs1AllMatch()
        RankedAllPlayerTable = New DataTable()
        Using Baglanti = Ranked_Connection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT name,point,total_won,total_match FROM gamers ORDER BY point DESC"
                Dim adapter As New MySqlDataAdapter(Command)
                adapter.Fill(RankedAllPlayerTable)
                Command.Dispose()
            End Using
        End Using
    End Sub
    Public Sub Top5Player()
        Top5PlayerTable = New DataTable()
        Using Baglanti = Ranked_Connection()
            Baglanti.Open()
            Using Command = New MySqlCommand()
                Command.Connection = Baglanti
                Command.CommandText = "SELECT name,point,total_won,total_match FROM gamers ORDER BY point DESC LIMIT 5"
                Dim adapter As New MySqlDataAdapter(Command)
                adapter.Fill(Top5PlayerTable)
                Command.Dispose()
            End Using
        End Using
    End Sub
End Class
