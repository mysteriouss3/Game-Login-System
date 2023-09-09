Public Class DataLayer
    Inherits Controller
    ReadOnly MailController As New MailController()
    Public Function Login(User As String, Pass As String) As String
        Return Login_Control(User, Pass)
    End Function
    Public Function Register_Verify(Mac_Adres As String, User_name As String, Email As String, Nick As String) As String
        Return Control_Register(Mac_Adres, User_name, Email, Nick)
    End Function
    Public Function RecoverPassword(requestingUser As String) As String
        Return MailController.PasswordForget(requestingUser)
    End Function
    Public Function Nick_Verify(Nick As String) As String
        Return PlayerNickControl(Nick)
    End Function
End Class