Public Class PlayerRegister
    ReadOnly WriteData As New WriteData()
#Region "DataName"
    Private PlayerUsername
    Private PlayerPassword
    Private PlayerEmail
    Private PlayerNick
    Private PlayerMacAdres
    Private PlayerİpAdres

    Public Property PlayerUsername1 As Object
        Get
            Return PlayerUsername
        End Get
        Set(value As Object)
            PlayerUsername = value
        End Set
    End Property

    Public Property PlayerPassword1 As Object
        Get
            Return PlayerPassword
        End Get
        Set(value As Object)
            PlayerPassword = value
        End Set
    End Property

    Public Property PlayerEmail1 As Object
        Get
            Return PlayerEmail
        End Get
        Set(value As Object)
            PlayerEmail = value
        End Set
    End Property

    Public Property PlayerNick1 As Object
        Get
            Return PlayerNick
        End Get
        Set(value As Object)
            PlayerNick = value
        End Set
    End Property

    Public Property PlayerMacAdres1 As Object
        Get
            Return PlayerMacAdres
        End Get
        Set(value As Object)
            PlayerMacAdres = value
        End Set
    End Property

    Public Property PlayerİpAdres1 As Object
        Get
            Return PlayerİpAdres
        End Get
        Set(value As Object)
            PlayerİpAdres = value
        End Set
    End Property

    Public Sub New(playerUsername As Object, playerPassword As Object, playerEmail As Object, playerNick As Object, playerMacAdres As Object, playerİpAdres As Object)
        Me.PlayerUsername1 = playerUsername
        Me.PlayerPassword1 = playerPassword
        Me.PlayerEmail1 = playerEmail
        Me.PlayerNick1 = playerNick
        Me.PlayerMacAdres1 = playerMacAdres
        Me.PlayerİpAdres1 = playerİpAdres
    End Sub
    Public Sub New()

    End Sub
#End Region
    Public Function PlayerRegister()
        Try
            WriteData.Register(PlayerUsername, PlayerPassword, PlayerEmail, PlayerNick, PlayerMacAdres, PlayerİpAdres)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
