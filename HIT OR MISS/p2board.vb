Public Class p2board
    'Array Declaration/Initialization (2 arrays for e. ship, horiz and vert, plus player's board)
    Public p2spaces(9, 9) As PictureBox
    Public intp2(9, 9) As Integer
    Public fireboard(9, 9) As PictureBox
    Private Sub PlaceClick(sender As Object, e As EventArgs) Handles s00.Click, s01.Click, s02.Click, s03.Click, s04.Click, s05.Click, s06.Click, s07.Click, s08.Click, s09.Click, s10.Click, s11.Click, s12.Click, s13.Click, s14.Click, s15.Click, s16.Click, s17.Click, s18.Click, s19.Click, s20.Click, s21.Click, s22.Click, s23.Click, s24.Click, s25.Click, s26.Click, s27.Click, s28.Click, s29.Click, s30.Click, s31.Click, s32.Click, s33.Click, s34.Click, s35.Click, s36.Click, s37.Click, s38.Click, s39.Click, s40.Click, s41.Click, s42.Click, s43.Click, s44.Click, s45.Click, s46.Click, s47.Click, s48.Click, s49.Click, s50.Click, s51.Click, s52.Click, s53.Click, s54.Click, s55.Click, s56.Click, s57.Click, s58.Click, s59.Click, s60.Click, s61.Click, s62.Click, s63.Click, s64.Click, s65.Click, s66.Click, s67.Click, s68.Click, s69.Click, s70.Click, s71.Click, s72.Click, s73.Click, s74.Click, s75.Click, s76.Click, s77.Click, s78.Click, s79.Click, s80.Click, s81.Click, s82.Click, s83.Click, s84.Click, s85.Click, s86.Click, s87.Click, s88.Click, s89.Click, s90.Click, s91.Click, s92.Click, s93.Click, s94.Click, s95.Click, s96.Click, s97.Click, s98.Click, s99.Click
        Dim picbox As PictureBox = sender
        'If placement is still going on, call the Sub to place the given ship
        If gbplacement.Visible = True Then
            Call ShipImages.Place(Me, p2spaces, intp2, picbox)
        End If
    End Sub
    Private Sub Fire(sender As Object, e As EventArgs) Handles o00.Click, o01.Click, o02.Click, o03.Click, o04.Click, o05.Click, o06.Click, o07.Click, o08.Click, o09.Click, o10.Click, o11.Click, o12.Click, o13.Click, o14.Click, o15.Click, o16.Click, o17.Click, o18.Click, o19.Click, o20.Click, o21.Click, o22.Click, o23.Click, o24.Click, o25.Click, o26.Click, o27.Click, o28.Click, o29.Click, o30.Click, o31.Click, o32.Click, o33.Click, o34.Click, o35.Click, o36.Click, o37.Click, o38.Click, o39.Click, o40.Click, o41.Click, o42.Click, o43.Click, o44.Click, o45.Click, o46.Click, o47.Click, o48.Click, o49.Click, o50.Click, o51.Click, o52.Click, o53.Click, o54.Click, o55.Click, o56.Click, o57.Click, o58.Click, o59.Click, o60.Click, o61.Click, o62.Click, o63.Click, o64.Click, o65.Click, o66.Click, o67.Click, o68.Click, o69.Click, o70.Click, o71.Click, o72.Click, o73.Click, o74.Click, o75.Click, o76.Click, o77.Click, o78.Click, o79.Click, o80.Click, o81.Click, o82.Click, o83.Click, o84.Click, o85.Click, o86.Click, o87.Click, o88.Click, o89.Click, o90.Click, o91.Click, o92.Click, o93.Click, o94.Click, o95.Click, o96.Click, o97.Click, o98.Click, o99.Click
        Dim clicked As PictureBox = sender
        Dim row As Integer = clicked.Name.Substring(1, 1)
        Dim col As Integer = clicked.Name.Substring(2)
        Dim spot As Integer = p1board.intp1(row, col)
        'Checks if shot is a hit, if so checks for sinks
        If ShipImages.Fire(fireboard, p1board.p1spaces, spot, row, col) Then
            MsgBox("Hit!")
            p1board.intp1(row, col) = spot
            Call ShipImages.CheckSink(fireboard, p1board.p1spaces, p1board.intp1, spot)
        Else
            fireboard(row, col).Image = My.Resources.miss
            p1board.p1spaces(row, col).BackColor = Color.White
            MsgBox("Miss!")
        End If
        'Changes turn
        Me.Hide()
        TurnChange.Show()
    End Sub
    Private Sub p2board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initializes p2spaces array, the visual board of pictureboxes
        For row = 0 To 9
            For col = 0 To 9
                Dim find() As Object = Controls.Find("s" & row & col, False)
                p2spaces(row, col) = find(0)
            Next
        Next
    End Sub
    Sub p2turn()
        'Called after placement to update the label, and to show fireboard (pnloboard)
        If btnaction.Visible = False Then
            pnloboard.Visible = True
            lblinfo.Text = "Captain, the enemy has placed their ships! Now it's up" & vbNewLine &
                            "to you to decide where to attack! Click on a spot on " & vbNewLine &
                            "the smaller board to the right to make your move, " & vbNewLine &
                            "and see if you managed to sink any enemy vessels!"
        End If
    End Sub
    Private Sub btnaction_Click(sender As Object, e As EventArgs) Handles btnaction.Click
        'If the fireboard isn't seen yet, its array is initialized
        If pnloboard.Visible = False Then
            For row = 0 To 9
                For col = 0 To 9
                    fireboard(row, col) = Controls.Find("o" & row & col, True)(0)
                Next
            Next
            'Then changes the turn and hides the button
            Me.Hide()
            TurnChange.Show()
            btnaction.Visible = False
        End If
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Since "Startup.vb" is the main form, clicking the "X" won't end the app
        If MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            p1board.Close()
            'Closes player forms and opens main form to end app
            Startup.Show()
        End If
    End Sub
End Class
