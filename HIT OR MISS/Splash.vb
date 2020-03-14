'NavalQuest, A Battleship-based game
'RYAN HECHT
Public Class Splash
    Private Sub tmrsplash_Tick(sender As Object, e As EventArgs) Handles tmrsplash.Tick
        'Simply displays the splash animation, since it's the splash screen the main form will then open ("Startup.vb")
        Static i As Integer
        Dim imgs() As Image = {My.Resources.splash1, My.Resources.splash2, My.Resources.splash3, My.Resources.splash4, My.Resources.splash5, My.Resources.hitormisslogo}
        If i < 6 Then
            picsplash.Image = imgs(i)
        End If
        If i = 4 Then
            tmrsplash.Interval = 500
        ElseIf i = 7 Then
            tmrsplash.Enabled = False
        End If
        i += 1
    End Sub
End Class