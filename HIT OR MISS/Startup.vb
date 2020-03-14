Public Class Startup
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Exits the app
        End
    End Sub
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        'Starts a game
        Me.Hide()
        p1board.Show()
    End Sub
    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        'About the game
        MessageBox.Show("Hit or Miss is a nautical strategy game made by Deity Joy Dela Cruz, " & vbNewLine &
                        "Blessel Marie Fortunato, Elyzha Lois Rodriguez, and Ma. Rowa Jean Tomonong." & vbNewLine &
                        "This is based on the board game Battleship by Milton Bradley." & vbNewLine &
                        "Made for the final requirement in the subject BSCOE-ELEC3 | BSCOE ELECTIVE 3." & vbNewLine &
                        "The game represents the manifestation of the skills we have" & vbNewLine &
                        "learned in the language over the year.", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class