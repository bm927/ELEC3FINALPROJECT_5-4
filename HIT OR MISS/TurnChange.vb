Public Class TurnChange
    'Form exists so players do not see each other's boards
    Public Shared intplayturn As Integer = 1
    Private Sub TurnChange_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inverts who's turn it is, then prints to labels
        If intplayturn = 1 Then
            intplayturn = 2
        Else
            intplayturn = 1
        End If
        lblannounce.Text = "Player " & intplayturn & ", your turn!"
        Me.Text = "It's Player " & intplayturn & "'s turn!"
    End Sub
    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        'Begins the correct player's turn
        If intplayturn = 2 Then
            p2board.Show()
            Call p2board.p2turn()
        ElseIf intplayturn = 1 Then
            p1board.Show()
            Call p1board.p1turn()
        End If
        Me.Close()
    End Sub
End Class