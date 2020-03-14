'Global file, all procedures/functions
Public Class ShipImages
    'Initializes image arrays
    Public Shared acch() As Image = {My.Resources.aircraft0, My.Resources.aircraft1, My.Resources.aircraft2, My.Resources.aircraft3, My.Resources.aircraft4}
    Public Shared accv() As Image = {My.Resources.aircraftv0, My.Resources.aircraftv1, My.Resources.aircraftv2, My.Resources.aircraftv3, My.Resources.aircraftv4}
    Public Shared btlshph() As Image = {My.Resources.battleship0, My.Resources.battleship1, My.Resources.battleship2, My.Resources.battleship3}
    Public Shared btlshpv() As Image = {My.Resources.battleshipv0, My.Resources.battleshipv1, My.Resources.battleshipv2, My.Resources.battleshipv3}
    Public Shared subh() As Image = {My.Resources.sub0, My.Resources.sub1, My.Resources.sub2}
    Public Shared subv() As Image = {My.Resources.subv0, My.Resources.subv1, My.Resources.subv2}
    Public Shared desth() As Image = {My.Resources.dest0, My.Resources.dest1, My.Resources.dest2}
    Public Shared destv() As Image = {My.Resources.destv0, My.Resources.destv1, My.Resources.destv2}
    Public Shared pbh() As Image = {My.Resources.pb0, My.Resources.pb1}
    Public Shared pbv() As Image = {My.Resources.pbv0, My.Resources.pbv1}
    Public Shared Sub Place(ByRef form As Form, ByRef board(,) As PictureBox, ByRef intboard(,) As Integer, ByRef picbox As PictureBox)
        'Variables for placement position and controls on the form from which the procedure is called
        Static intpieceplace As Integer = 0
        Dim row As Integer = picbox.Name.ToString.Substring(1, 1)
        Dim col As Integer = picbox.Name.ToString.Substring(2)
        Dim radhoriz As RadioButton = form.Controls.Find("radhoriz", True)(0)
        Dim radvert As RadioButton = form.Controls.Find("radvert", True)(0)
        Dim lblplacing As Label = form.Controls.Find("lblplacing", True)(0)
        Dim gbplacement As GroupBox = form.Controls.Find("gbplacement", True)(0)
        Dim btnaction As Button = form.Controls.Find("btnaction", True)(0)
        'intpieceplace represents the ship being placed. Throughout the application, 0-4 refer to
        'certain ships, 5-9 refer to their respective ships when they are hit
        If intpieceplace < 5 Then
            Select Case intpieceplace
                Case 0
                    'Make intarray positions not interfere with fire/sink checks, -1 represents empty
                    For r = 0 To 9
                        For c = 0 To 9
                            intboard(r, c) = -1
                        Next
                    Next
                    'ACC place
                    If radhoriz.Checked Then
                        If col < 6 Then
                            'Image visualization
                            picbox.Image = ShipImages.acch(0)
                            board(row, col + 1).Image = ShipImages.acch(1)
                            board(row, col + 2).Image = ShipImages.acch(2)
                            board(row, col + 3).Image = ShipImages.acch(3)
                            board(row, col + 4).Image = ShipImages.acch(4)
                            'Tag declaration
                            intboard(row, col) = 0
                            intboard(row, col + 1) = 0
                            intboard(row, col + 2) = 0
                            intboard(row, col + 3) = 0
                            intboard(row, col + 4) = 0
                            'Time for next turn
                            intpieceplace += 1
                            lblplacing.Text = "Currently placing: Battleship"
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    ElseIf radvert.Checked Then
                        If row < 6 Then
                            'Image visualization
                            picbox.Image = ShipImages.accv(0)
                            board(row + 1, col).Image = ShipImages.accv(1)
                            board(row + 2, col).Image = ShipImages.accv(2)
                            board(row + 3, col).Image = ShipImages.accv(3)
                            board(row + 4, col).Image = ShipImages.accv(4)
                            'Tag Declaration
                            intboard(row, col) = 0
                            intboard(row + 1, col) = 0
                            intboard(row + 2, col) = 0
                            intboard(row + 3, col) = 0
                            intboard(row + 4, col) = 0
                            'time for next turn
                            intpieceplace += 1
                            lblplacing.Text = "Currently placing: Battleship"
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    End If
                    'BTL place
                Case 1
                    If radhoriz.Checked Then
                        If col < 7 Then
                            If board(row, col).Image Is Nothing And board(row, col + 1).Image Is Nothing And board(row, col + 2).Image Is Nothing And board(row, col + 3).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.btlshph(0)
                                board(row, col + 1).Image = ShipImages.btlshph(1)
                                board(row, col + 2).Image = ShipImages.btlshph(2)
                                board(row, col + 3).Image = ShipImages.btlshph(3)
                                'Tag declaration
                                intboard(row, col) = 1
                                intboard(row, col + 1) = 1
                                intboard(row, col + 2) = 1
                                intboard(row, col + 3) = 1
                                'Time for next turn
                                intpieceplace += 1
                                lblplacing.Text = "Currently placing: Submarine"
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    ElseIf radvert.Checked Then
                        If row < 7 Then
                            If board(row, col).Image Is Nothing And board(row + 1, col).Image Is Nothing And board(row + 2, col).Image Is Nothing And board(row + 3, col).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.btlshpv(0)
                                board(row + 1, col).Image = ShipImages.btlshpv(1)
                                board(row + 2, col).Image = ShipImages.btlshpv(2)
                                board(row + 3, col).Image = ShipImages.btlshpv(3)
                                'Tag declaration
                                intboard(row, col) = 1
                                intboard(row + 1, col) = 1
                                intboard(row + 2, col) = 1
                                intboard(row + 3, col) = 1
                                'Time for next turn
                                intpieceplace += 1
                                lblplacing.Text = "Currently placing: Submarine"
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    End If
                    'SUB place
                Case 2
                    If radhoriz.Checked Then
                        If col < 8 Then
                            If board(row, col).Image Is Nothing And board(row, col + 1).Image Is Nothing And board(row, col + 2).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.subh(0)
                                board(row, col + 1).Image = ShipImages.subh(1)
                                board(row, col + 2).Image = ShipImages.subh(2)
                                'Tag declaration
                                intboard(row, col) = 2
                                intboard(row, col + 1) = 2
                                intboard(row, col + 2) = 2
                                'Time for next turn
                                intpieceplace += 1
                                lblplacing.Text = "Currently placing: Destroyer"
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    Else
                        If row < 8 Then
                            If board(row, col).Image Is Nothing And board(row + 1, col).Image Is Nothing And board(row + 2, col).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.subv(0)
                                board(row + 1, col).Image = ShipImages.subv(1)
                                board(row + 2, col).Image = ShipImages.subv(2)
                                'Tag declaration
                                intboard(row, col) = 2
                                intboard(row + 1, col) = 2
                                intboard(row + 2, col) = 2
                                'Time for next turn
                                intpieceplace += 1
                                lblplacing.Text = "Currently placing: Destroyer"
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    End If
                    'DES place
                Case 3
                    If radhoriz.Checked Then
                        If col < 8 Then
                            If board(row, col).Image Is Nothing And board(row, col + 1).Image Is Nothing And board(row, col + 2).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.desth(0)
                                board(row, col + 1).Image = ShipImages.desth(1)
                                board(row, col + 2).Image = ShipImages.desth(2)
                                'Tag declaration
                                intboard(row, col) = 3
                                intboard(row, col + 1) = 3
                                intboard(row, col + 2) = 3
                                'Time for next turn
                                intpieceplace += 1
                                lblplacing.Text = "Currently placing: Patrol Boat"
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    Else
                        If row < 8 Then
                            If board(row, col).Image Is Nothing And board(row + 1, col).Image Is Nothing And board(row + 2, col).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.destv(0)
                                board(row + 1, col).Image = ShipImages.destv(1)
                                board(row + 2, col).Image = ShipImages.destv(2)
                                'Tag declaration
                                intboard(row, col) = 3
                                intboard(row + 1, col) = 3
                                intboard(row + 2, col) = 3
                                'Time for next turn
                                intpieceplace += 1
                                lblplacing.Text = "Currently placing: Patrol Boat"
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    End If
                    'PTB place
                Case 4
                    If radhoriz.Checked Then
                        If col < 9 Then
                            If board(row, col).Image Is Nothing And board(row, col + 1).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.pbh(0)
                                board(row, col + 1).Image = ShipImages.pbh(1)
                                'Tag declaration
                                intboard(row, col) = 4
                                intboard(row, col + 1) = 4
                                'Stop placement phase
                                intpieceplace = 0
                                lblplacing.Text = ""
                                gbplacement.Visible = False
                                btnaction.Enabled = True
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    Else
                        If row < 9 Then
                            If board(row, col).Image Is Nothing And board(row + 1, col).Image Is Nothing Then
                                'Image visualization
                                picbox.Image = ShipImages.pbv(0)
                                board(row + 1, col).Image = ShipImages.pbv(1)
                                'Tag declaration
                                intboard(row, col) = 4
                                intboard(row + 1, col) = 4
                                'Stop placement phase
                                intpieceplace = 0
                                lblplacing.Text = ""
                                gbplacement.Visible = False
                                btnaction.Enabled = True
                            Else
                                MessageBox.Show("Invalid placement (make sure there is enough room)")
                            End If
                        Else
                            MessageBox.Show("Invalid placement (make sure there is enough room)")
                        End If
                    End If
            End Select
        End If
    End Sub
    'if spot is 0-5, then a ship is hit, and changed to its "hit" value (5-9)
    Public Shared Function Fire(ByRef fireboard(,) As PictureBox, ByRef oboard(,) As PictureBox, ByRef spot As Integer, ByVal row As Integer, ByVal col As Integer)
        If spot > -1 And spot < 5 Then
            If spot = 0 Then
                spot = 5
            End If
            If spot = 1 Then
                spot = 6
            End If
            If spot = 2 Then
                spot = 7
            End If
            If spot = 3 Then
                spot = 8
            End If
            If spot = 4 Then
                spot = 9
            End If
            'Fireboard and opponent's board reflect the hit
            oboard(row, col).Image = My.Resources.fire
            fireboard(row, col).Image = My.Resources.fire
            Return True
        ElseIf spot > 4 And spot < 10 Then
            'My personal little feature to anger people :p
            MessageBox.Show("Hitting a ship a second time still counts as a turn!")
            Return True
        End If
        Return False
    End Function
    'If a ship is sunk, the opponent's board shows the sunk image, so does the fireboard
    ' the 10-14 numbers refer to a sunk ship, used to check for game ending later
    Public Shared Sub CheckSink(ByRef fireboard(,) As PictureBox, ByRef picoboard(,) As PictureBox, ByRef intoboard(,) As Integer, ByVal spot As Integer)
        'ACC
        For row = 0 To 9
            For col = 0 To 5
                If intoboard(row, col) = intoboard(row, col + 1) And intoboard(row, col) = intoboard(row, col + 2) And intoboard(row, col) = intoboard(row, col + 3) And intoboard(row, col) = intoboard(row, col + 4) And intoboard(row, col) = 5 Then
                    picoboard(row, col).Image = My.Resources.sunk
                    picoboard(row, col + 1).Image = My.Resources.sunk
                    picoboard(row, col + 2).Image = My.Resources.sunk
                    picoboard(row, col + 3).Image = My.Resources.sunk
                    picoboard(row, col + 4).Image = My.Resources.sunk
                    fireboard(row, col).Image = My.Resources.sunk
                    fireboard(row, col + 1).Image = My.Resources.sunk
                    fireboard(row, col + 2).Image = My.Resources.sunk
                    fireboard(row, col + 3).Image = My.Resources.sunk
                    fireboard(row, col + 4).Image = My.Resources.sunk
                    MsgBox("You sunk the enemy Aircraft Carrier!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 10
                End If
            Next
        Next
        For row = 0 To 5
            For col = 0 To 9
                If intoboard(row, col) = intoboard(row + 1, col) And intoboard(row, col) = intoboard(row + 2, col) And intoboard(row, col) = intoboard(row + 3, col) And intoboard(row, col) = intoboard(row + 4, col) And intoboard(row, col) = 5 Then
                    picoboard(row, col).Image = My.Resources.sunkv
                    picoboard(row + 1, col).Image = My.Resources.sunkv
                    picoboard(row + 2, col).Image = My.Resources.sunkv
                    picoboard(row + 3, col).Image = My.Resources.sunkv
                    picoboard(row + 4, col).Image = My.Resources.sunkv
                    fireboard(row, col).Image = My.Resources.sunkv
                    fireboard(row + 1, col).Image = My.Resources.sunkv
                    fireboard(row + 2, col).Image = My.Resources.sunkv
                    fireboard(row + 3, col).Image = My.Resources.sunkv
                    fireboard(row + 4, col).Image = My.Resources.sunkv
                    MsgBox("You sunk the enemy Aircraft Carrier!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 10
                End If
            Next
        Next
        'BTL
        For row = 0 To 9
            For col = 0 To 6
                If intoboard(row, col) = intoboard(row, col + 1) And intoboard(row, col) = intoboard(row, col + 2) And intoboard(row, col) = intoboard(row, col + 3) And intoboard(row, col) = 6 Then
                    picoboard(row, col).Image = My.Resources.sunk
                    picoboard(row, col + 1).Image = My.Resources.sunk
                    picoboard(row, col + 2).Image = My.Resources.sunk
                    picoboard(row, col + 3).Image = My.Resources.sunk
                    fireboard(row, col).Image = My.Resources.sunk
                    fireboard(row, col + 1).Image = My.Resources.sunk
                    fireboard(row, col + 2).Image = My.Resources.sunk
                    fireboard(row, col + 3).Image = My.Resources.sunk
                    MsgBox("You sunk the enemy Battleship!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 11
                End If
            Next
        Next
        For row = 0 To 6
            For col = 0 To 9
                If intoboard(row, col) = intoboard(row + 1, col) And intoboard(row, col) = intoboard(row + 2, col) And intoboard(row, col) = intoboard(row + 3, col) And intoboard(row, col) = 6 Then
                    picoboard(row, col).Image = My.Resources.sunkv
                    picoboard(row + 1, col).Image = My.Resources.sunkv
                    picoboard(row + 2, col).Image = My.Resources.sunkv
                    picoboard(row + 3, col).Image = My.Resources.sunkv
                    fireboard(row, col).Image = My.Resources.sunkv
                    fireboard(row + 1, col).Image = My.Resources.sunkv
                    fireboard(row + 2, col).Image = My.Resources.sunkv
                    fireboard(row + 3, col).Image = My.Resources.sunkv
                    MsgBox("You sunk the enemy Battleship!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 11
                End If
            Next
        Next
        'SUB
        For row = 0 To 9
            For col = 0 To 7
                If intoboard(row, col) = intoboard(row, col + 1) And intoboard(row, col) = intoboard(row, col + 2) And intoboard(row, col) = 7 Then
                    picoboard(row, col).Image = My.Resources.sunk
                    picoboard(row, col + 1).Image = My.Resources.sunk
                    picoboard(row, col + 2).Image = My.Resources.sunk
                    fireboard(row, col).Image = My.Resources.sunk
                    fireboard(row, col + 1).Image = My.Resources.sunk
                    fireboard(row, col + 2).Image = My.Resources.sunk
                    MsgBox("You sunk the enemy Submarine!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 12
                End If
            Next
        Next
        For row = 0 To 7
            For col = 0 To 9
                If intoboard(row, col) = intoboard(row + 1, col) And intoboard(row, col) = intoboard(row + 2, col) And intoboard(row, col) = 7 Then
                    picoboard(row, col).Image = My.Resources.sunkv
                    picoboard(row + 1, col).Image = My.Resources.sunkv
                    picoboard(row + 2, col).Image = My.Resources.sunkv
                    fireboard(row, col).Image = My.Resources.sunkv
                    fireboard(row + 1, col).Image = My.Resources.sunkv
                    fireboard(row + 2, col).Image = My.Resources.sunkv
                    MsgBox("You sunk the enemy Submarine!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 12
                End If
            Next
        Next
        'DES
        For row = 0 To 9
            For col = 0 To 7
                If intoboard(row, col) = intoboard(row, col + 1) And intoboard(row, col) = intoboard(row, col + 2) And intoboard(row, col) = 8 Then
                    picoboard(row, col).Image = My.Resources.sunk
                    picoboard(row, col + 1).Image = My.Resources.sunk
                    picoboard(row, col + 2).Image = My.Resources.sunk
                    fireboard(row, col).Image = My.Resources.sunk
                    fireboard(row, col + 1).Image = My.Resources.sunk
                    fireboard(row, col + 2).Image = My.Resources.sunk
                    MsgBox("You sunk the enemy Destroyer!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 13
                End If
            Next
        Next
        For row = 0 To 7
            For col = 0 To 9
                If intoboard(row, col) = intoboard(row + 1, col) And intoboard(row, col) = intoboard(row + 2, col) And intoboard(row, col) = 8 Then
                    picoboard(row, col).Image = My.Resources.sunkv
                    picoboard(row + 1, col).Image = My.Resources.sunkv
                    picoboard(row + 2, col).Image = My.Resources.sunkv
                    fireboard(row, col).Image = My.Resources.sunkv
                    fireboard(row + 1, col).Image = My.Resources.sunkv
                    fireboard(row + 2, col).Image = My.Resources.sunkv
                    MsgBox("You sunk the enemy Destroyer!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 13
                End If
            Next
        Next
        'PTB
        For row = 0 To 9
            For col = 0 To 8
                If intoboard(row, col) = intoboard(row, col + 1) And intoboard(row, col) = 9 Then
                    picoboard(row, col).Image = My.Resources.sunk
                    picoboard(row, col + 1).Image = My.Resources.sunk
                    fireboard(row, col).Image = My.Resources.sunk
                    fireboard(row, col + 1).Image = My.Resources.sunk
                    MsgBox("You sunk the enemy Patrol Boat!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 14
                End If
            Next
        Next
        For row = 0 To 8
            For col = 0 To 9
                If intoboard(row, col) = intoboard(row + 1, col) And intoboard(row, col) = 9 Then
                    picoboard(row, col).Image = My.Resources.sunkv
                    picoboard(row + 1, col).Image = My.Resources.sunkv
                    fireboard(row, col).Image = My.Resources.sunkv
                    fireboard(row + 1, col).Image = My.Resources.sunkv
                    MsgBox("You sunk the enemy Patrol Boat!", MsgBoxStyle.OkOnly, "Sunk!")
                    intoboard(row, col) = 14
                End If
            Next
        Next
        'Check if all ships are sunk
        For row = 0 To 9
            Dim blnacc As Boolean
            Dim blnbtl As Boolean
            Dim blnsub As Boolean
            Dim blndes As Boolean
            Dim blnptb As Boolean
            For col = 0 To 9
                If intoboard(row, col) = 10 Then
                    blnacc = True
                End If
                If intoboard(row, col) = 11 Then
                    blnbtl = True
                End If
                If intoboard(row, col) = 12 Then
                    blnsub = True
                End If
                If intoboard(row, col) = 13 Then
                    blndes = True
                End If
                If intoboard(row, col) = 14 Then
                    blnptb = True
                End If
            Next
            'Ends the game, restarts app to startscreen
            If blnacc = True And blnbtl = True And blndes = True And blnsub = True And blnptb = True Then
                Beep()
                MessageBox.Show("Player " & TurnChange.intplayturn & " Wins!")
                Application.Restart()
                Exit For
            End If
        Next
    End Sub


End Class
