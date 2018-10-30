'Title:     Tic Tac Toe
'Author:    Xiaomeng Cao
'Date:      November 29, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program will  allows two users to play Tic Tac Toe against each other.
'
'Initial Algorithm:
'   1.  Create 9 game buttons and click events for each buttons
'   2.  Allows the user to Select player
'   3.  Displays X if user select X turn or O if user select O turn
'   4.  If button is clicked disabled button
'   5.  Store 1 for X or -1 for O in a 2D array depending on user's choice
'   6.  Create a procedure to check for wins
'   7.  Allows the user to restart game by reset button
'
'Data Requirements:
'   Input:
'       None
'   Output:
'       Display the game result: lblResult
'   Additional:
'       None
'
'Formulas:
'   rowTotal = rowTotal + game(row, col)
'   colTotal = colTotal + game(row, col)
'   diagonalTotal1 = diagonalTotal1 + game(row, col)
'   diagonalTotal2 = diagonalTotal2 + game(row, col)
'
'Refined Algorithm:
'   Declare a 2D array and counter
'   1.  Create 9 game buttons and click events for each buttons
'   2.  Allows the user to Select player
'       Create two radio button, one is optX, another one is optO
'   3.  Displays X if user select X turn or O if user select O turn
'       IF X radio button is selected
'           Set text to X
'           Store 1 into array
'           Increase counter
'           Call procedures CheckWinner to check game result 
'           Disable the button
'       ELSE
'           Set text to O
'           Store -1 into array
'           Increase counter
'           Call procedures CheckWinner to check game result 
'           Disable the button
'       END IF
'   4.  Repeat the step 3, if a button is clicked
'   5.  Create a procedure to check for wins
'       IF counter = 9
'           Display a message that shows the game is tied
'           Disable all buttons
'       ELSE
'           IF player X win
'               Display a message that shows Player X Wins
'           ELSE
'               Display a message that shows Player O Wins
'           END IF
'       END IF
'   6.  Allows the user to restart game by reset button

Public Class frmMain
    'Global variables
    Dim MAX_ROW As Integer = 2
    Dim MAX_COl As Integer = 2
    Dim game(MAX_ROW, MAX_COl) As Integer
    Dim counter As Integer = 0

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        If optX.Checked = True Then 'If optX is selected
            cmd1.Text = "X" 'Set text to X
            game(0, 0) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd1.Text = "O" 'Set text to O
            game(0, 0) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd1.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        If optX.Checked = True Then 'If optX is selected
            cmd2.Text = "X" 'Set text to X
            game(0, 1) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd2.Text = "O" 'Set text to O
            game(0, 1) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd2.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        If optX.Checked = True Then 'If optX is selected
            cmd3.Text = "X" 'Set text to X
            game(0, 2) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd3.Text = "O" 'Set text to O
            game(0, 2) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd3.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        If optX.Checked = True Then 'If optX is selected
            cmd4.Text = "X" 'Set text to X
            game(1, 0) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd4.Text = "O" 'Set text to O
            game(1, 0) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd4.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        If optX.Checked = True Then 'If optX is selected
            cmd5.Text = "X" 'Set text to X
            game(1, 1) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd5.Text = "O" 'Set text to O
            game(1, 1) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd5.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        If optX.Checked = True Then 'If optX is selected
            cmd6.Text = "X" 'Set text to X
            game(1, 2) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd6.Text = "O" 'Set text to O
            game(1, 2) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd6.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        If optX.Checked = True Then 'If optX is selected
            cmd7.Text = "X" 'Set text to X
            game(2, 0) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd7.Text = "O" 'Set text to O
            game(2, 0) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd7.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        If optX.Checked = True Then 'If optX is selected
            cmd8.Text = "X" 'Set text to X
            game(2, 1) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd8.Text = "O" 'Set text to O
            game(2, 1) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd8.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        If optX.Checked = True Then 'If optX is selected
            cmd9.Text = "X" 'Set text to X
            game(2, 2) = 1 'Store 1 into array
        Else 'Else optO is selected
            cmd9.Text = "O" 'Set text to O
            game(2, 2) = -1 'Store -1 into array
        End If

        counter += 1 'Increase counter
        CheckWinner(counter) 'Call procedures CheckWinner to check game result
        cmd9.Enabled = False 'Disable the button
    End Sub

    '*****************************************************************
    '   IF counter = 9 THEN
    '       Display a message that shows the game is tied
    '       Disable all buttons
    '   ELSE
    '       For row = 0 To MAX_ROW
    '           For col = 0 To MAX_COl
    '               Calculate the total of each row
    '               IF rowTotal = 3 THEN
    '                   Display a message that shows Player X Wins
    '                   Disable all buttons
    '               ELSEIF rowTotal = -3 THEN
    '                   Display a message that shows Player O Wins
    '                   Disable all buttons
    '               END IF
    '           Next
    '            rowTotal = 0
    '       Next
    '       For col = 0 To MAX_COl
    '           For row = 0 To MAX_ROW
    '               Calculate the total of each col
    '               IF colTotal = 3 THEN
    '                   Display a message that shows Player X Wins
    '                   Disable all buttons
    '               ELSE IF colTotal = -3 Then
    '                   Display a message that shows Player O Wins
    '                   Disable all buttons
    '               End If
    '           Next
    '           colTotal = 0
    '       Next
    '       For row = 0 To MAX_ROW
    '           For col = 0 To MAX_COl
    '               IF row = col THEN
    '                   Calculate the total of first diagonal
    '                   If diagonalTotal1 = 3 THEN
    '                       Display a message that shows Player X Wins
    '                       Disable all buttons
    '                   ELSEIF diagonalTotal1 = -3 THEN
    '                       Display a message that shows Player O Wins
    '                       Disable all buttons
    '                   End If
    '               End If
    '               IF row + col = 2 THEN
    '                   Calculate the total of second diagonal
    '                   IF diagonalTotal2 = 3 THEN
    '                       Display a message that shows Player X Wins
    '                       Disable all buttons
    '                   ELSEIF diagonalTotal2 = -3 THEN
    '                       Display a message that shows Player O Wins
    '                       Disable all buttons
    '                   End If
    '               End If
    '           Next
    '       Next
    '   End If
    '*****************************************************************
    Public Sub CheckWinner(ByVal counter As Integer)

        'Local variables
        Dim row As Integer = 0
        Dim col As Integer = 0
        Dim rowTotal As Integer = 0
        Dim colTotal As Integer = 0
        Dim diagonalTotal1 As Integer = 0
        Dim diagonalTotal2 As Integer = 0

        If counter = 9 Then 'If all buttons are clicked
            'Display a message that shows the game is tied
            lblResult.Text = "Draw"
            'Disable all buttons
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmd6.Enabled = False
            cmd7.Enabled = False
            cmd8.Enabled = False
            cmd9.Enabled = False
        Else 'If counter not equals to 9
            For row = 0 To MAX_ROW
                For col = 0 To MAX_COl
                    'Calculate the total of each row
                    rowTotal = rowTotal + game(row, col)

                    If rowTotal = 3 Then 'If a total of a row is 3
                        'Display a message that shows Player X Wins
                        lblResult.Text = "Player X Wins"
                        'Disable all buttons
                        cmd1.Enabled = False
                        cmd2.Enabled = False
                        cmd3.Enabled = False
                        cmd4.Enabled = False
                        cmd5.Enabled = False
                        cmd6.Enabled = False
                        cmd7.Enabled = False
                        cmd8.Enabled = False
                        cmd9.Enabled = False
                    ElseIf rowTotal = -3 Then 'Else if a total of a row is -3
                        'Display a message that shows Player O Wins
                        lblResult.Text = "Player O Wins"
                        'Disable all buttons
                        cmd1.Enabled = False
                        cmd2.Enabled = False
                        cmd3.Enabled = False
                        cmd4.Enabled = False
                        cmd5.Enabled = False
                        cmd6.Enabled = False
                        cmd7.Enabled = False
                        cmd8.Enabled = False
                        cmd9.Enabled = False
                    End If
                Next
                'Re-initialize rowTotal to 0
                rowTotal = 0
            Next

            For col = 0 To MAX_COl
                For row = 0 To MAX_ROW
                    'Calculate the total of each col
                    colTotal = colTotal + game(row, col)

                    If colTotal = 3 Then 'If a total of a col is 3
                        'Display a message that shows Player X Wins
                        lblResult.Text = "Player X Wins"
                        'Disable all buttons
                        cmd1.Enabled = False
                        cmd2.Enabled = False
                        cmd3.Enabled = False
                        cmd4.Enabled = False
                        cmd5.Enabled = False
                        cmd6.Enabled = False
                        cmd7.Enabled = False
                        cmd8.Enabled = False
                        cmd9.Enabled = False
                    ElseIf colTotal = -3 Then 'Else if a total of a col is -3
                        'Display a message that shows Player O Wins
                        lblResult.Text = "Player O Wins"
                        'Disable all buttons
                        cmd1.Enabled = False
                        cmd2.Enabled = False
                        cmd3.Enabled = False
                        cmd4.Enabled = False
                        cmd5.Enabled = False
                        cmd6.Enabled = False
                        cmd7.Enabled = False
                        cmd8.Enabled = False
                        cmd9.Enabled = False
                    End If
                Next
                'Re-initialize colTotal to 0
                colTotal = 0
            Next

            For row = 0 To MAX_ROW
                For col = 0 To MAX_COl
                    If row = col Then
                        'Calculate the total of first diagonal
                        diagonalTotal1 = diagonalTotal1 + game(row, col)

                        If diagonalTotal1 = 3 Then 'If a total of a diagonal is 3
                            'Display a message that shows Player X Wins
                            lblResult.Text = "Player X Wins"
                            'Disable all buttons
                            cmd1.Enabled = False
                            cmd2.Enabled = False
                            cmd3.Enabled = False
                            cmd4.Enabled = False
                            cmd5.Enabled = False
                            cmd6.Enabled = False
                            cmd7.Enabled = False
                            cmd8.Enabled = False
                            cmd9.Enabled = False
                        ElseIf diagonalTotal1 = -3 Then 'Else if a total of a diagonal is -3
                            'Display a message that shows Player O Wins
                            lblResult.Text = "Player O Wins"
                            'Disable all buttons
                            cmd1.Enabled = False
                            cmd2.Enabled = False
                            cmd3.Enabled = False
                            cmd4.Enabled = False
                            cmd5.Enabled = False
                            cmd6.Enabled = False
                            cmd7.Enabled = False
                            cmd8.Enabled = False
                            cmd9.Enabled = False
                        End If
                    End If

                    If row + col = 2 Then
                        'Calculate the total of second diagonal
                        diagonalTotal2 = diagonalTotal2 + game(row, col)

                        If diagonalTotal2 = 3 Then 'If a total of a diagonal is 3
                            'Display a message that shows Player X Wins
                            lblResult.Text = "Player X Wins"
                            'Disable all buttons
                            cmd1.Enabled = False
                            cmd2.Enabled = False
                            cmd3.Enabled = False
                            cmd4.Enabled = False
                            cmd5.Enabled = False
                            cmd6.Enabled = False
                            cmd7.Enabled = False
                            cmd8.Enabled = False
                            cmd9.Enabled = False
                        ElseIf diagonalTotal2 = -3 Then 'Else if a total of a diagonal is -3
                            'Display a message that shows Player O Wins
                            lblResult.Text = "Player O Wins"
                            'Disable all buttons
                            cmd1.Enabled = False
                            cmd2.Enabled = False
                            cmd3.Enabled = False
                            cmd4.Enabled = False
                            cmd5.Enabled = False
                            cmd6.Enabled = False
                            cmd7.Enabled = False
                            cmd8.Enabled = False
                            cmd9.Enabled = False
                        End If
                    End If
                Next
            Next
        End If

    End Sub

    '*****************************************************************
    '   This button enable the game, and all game buttons
    '*****************************************************************
    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        'Disable the play button
        cmdPlay.Enabled = False
        'Enable all buttons
        cmd1.Enabled = True
        cmd2.Enabled = True
        cmd3.Enabled = True
        cmd4.Enabled = True
        cmd5.Enabled = True
        cmd6.Enabled = True
        cmd7.Enabled = True
        cmd8.Enabled = True
        cmd9.Enabled = True
        cmdReset.Enabled = True
        optX.Enabled = True
        optO.Enabled = True
    End Sub

    '*****************************************************************
    '   This button reset the array and counter, and it disable all 
    ' game buttons and reset the text of all game buttons
    '*****************************************************************
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        'Clear the contents of the array
        Array.Clear(game, 0, game.Length)
        'Re-initialize counter
        counter = 0
        'Clear out label
        lblResult.Text = ""
        'Clear the text of all buttons
        cmd1.Text = ""
        cmd2.Text = ""
        cmd3.Text = ""
        cmd4.Text = ""
        cmd5.Text = ""
        cmd6.Text = ""
        cmd7.Text = ""
        cmd8.Text = ""
        cmd9.Text = ""
        'Disable all buttons
        cmd1.Enabled = False
        cmd2.Enabled = False
        cmd3.Enabled = False
        cmd4.Enabled = False
        cmd5.Enabled = False
        cmd6.Enabled = False
        cmd7.Enabled = False
        cmd8.Enabled = False
        cmd9.Enabled = False
        cmdReset.Enabled = False
        optX.Enabled = False
        optO.Enabled = False
        'Enable play button
        cmdPlay.Enabled = True
    End Sub

    '*****************************************************************
    '   This procedures ask user to confirm they want exit the program
    '*****************************************************************
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim temp As Boolean
        temp = (MessageBox.Show("Comfirm close?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No)
        e.Cancel = temp
    End Sub
End Class
