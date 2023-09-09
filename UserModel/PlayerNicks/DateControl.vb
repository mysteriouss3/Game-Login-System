Public Class DateControl
    Dim ThisMoment As Date
    Public Function NickDateControl()
        ThisMoment = Now
        Dim Tarih As String = Format(ThisMoment, "dd-MM-yyyy")
        Dim PlayerLastNickDate As Date = Player_Nick_LastUpdate_Date
        Dim DateNow As Date = Tarih
        Dim yil = DateDiff(DateInterval.Year, PlayerLastNickDate, DateNow)
        PlayerLastNickDate = PlayerLastNickDate.AddYears(yil)
        Dim ay = DateDiff(DateInterval.Month, PlayerLastNickDate, DateNow)
        PlayerLastNickDate = PlayerLastNickDate.AddMonths(ay)
        Dim gun = DateDiff(DateInterval.Day, PlayerLastNickDate, DateNow)
        If ay >= 1 And gun >= 0 And yil >= 0 Then
            Return True
        Else
            If ay <= -1 Or ay >= 0 And gun >= 0 And yil >= 1 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Class