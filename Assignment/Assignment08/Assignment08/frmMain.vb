'Title:     Guess the number
'Author:    Xiaomeng Cao
'Date:      November 7, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program will generate a random number between 1 & 100.
'               The user will try yo guess the random number. The program will
'               accept the guess and display a message instructing the user
'               to guess higher or lower until the correct number is guessed.
'
'Initial Algorithm:
'   1.  Generate a random number
'   2.  User enter a number
'   3.  Validate the UserInput is a numeric
'   4.  Validate the GuessNumber is in the range 1 to 100
'   5.  User will get prompt of the number is higher or lower
'   6.  Display a message when user guess a correct number
'
'Data Requirements:
'   Input:
'       Guess number is entered by user: GuessName
'   Output:
'       None
'   Additional:
'       Random number generate by the program: RandomNumber
'
'Formulas:
'   None
'
'Refined Algorithm:
'   1.  Generate a random number
'   2.  Ask uesr to enter a number
'   3.  Validate the UserInput is a numeric
'   If Validation(UserInput) Then
'       Convert contents of input box to numeric value
'       4.  Validate the GuessNumber is in the range 1 to 100
'       If InRange(GuessNumber) Then
'           counter += 1
'           5.  User will get prompt of the number is higher or lower
'           IF GuessNumber < RandomNumber
'               IF counter = 10
'                   Print a message tell user lost the game                  
'                   Change lblOuput background color to blue
'                   Print a message to insturcting user in the lblOuput
'                   Add the guess number and insturcting to the list box
'                   Disable start button
'                   Make the again button visiable
'                   Initial counter to 0
'               ELSE
'                   Change lblOuput background color to blue
'                   Print a message to insturcting user in the lblOuput
'                   Add the guess number and insturcting to the list box
'               END IF
'           ELSE IF GuessNumber > RandomNumber
'               IF counter = 10
'                   Print a message tell user lost the game                  
'                   Change lblOuput background color to red
'                   Print a message to insturcting user in the lblOuput
'                   Add the guess number and insturcting to the list box
'                   Disable start button
'                   Make the again button visiable
'                   Initial counter to 0
'               ELSE
'                   Change lblOuput background color to red
'                   Print a message to insturcting user in the lblOuput
'                   Add the guess number and insturcting to the list box
'               END IF
'           6.  Display a message when user guess a correct number
'           ELSE IF GuessNumber = RandomNumber
'               Change lblOuput background color to yellow
'               Print a message to insturcting user in the lblOuput
'               Print a message by using procedures WinOrLose
'               Disable start button
'               Make the again button visiable
'               Initial counter to 0
'           END IF
'       END IF
'   END IF


Public Class frmMain
    Dim RandomNumber As Integer = GetRandomNumber() 'Generate a randon number

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Static counter As Integer = 0
        Dim UserInput As String 'Value entered by user read as a string
        Dim GuessNumber As Integer

        'Ask the user to input a number
        UserInput = InputBox("Plesae enter a number between 1 to 100")

        If Validation(UserInput) Then 'If Validation is true
            GuessNumber = CInt(UserInput) 'Convert contents of input box to numeric value
            If InRange(GuessNumber) Then 'If InRange is true
                'Increase the counter
                counter += 1

                If GuessNumber < RandomNumber Then
                    If counter = 10 Then 'If counter = 10 and guess still incorrect
                        'Print a message that tell user lost the game
                        MessageBox.Show("Sorry, you lost the game")
                        'Set the background color of label to blue
                        lblOutput.BackColor = Color.Blue
                        'Display the hint and remaining guess times in the label
                        lblOutput.Text = "Your guess is too low" & vbCr & "You have " & 10 - counter & " times left"
                        'Add the guess number and the status to the list box
                        lstOutput.Items.Add(GuessNumber & "         Too low")
                        'Disable the start button
                        cmdStart.Enabled = False
                        'Set again button visible to true
                        cmdAgain.Visible = True
                        'Initial counter to 0
                        counter = 0
                    Else
                        'Set the background color of label to blue
                        lblOutput.BackColor = Color.Blue
                        'Display the hint and remaining guess times in the label
                        lblOutput.Text = "Your guess is too low" & vbCr & "You have " & 10 - counter & " times left"
                        'Add the guess number and the status to the list box
                        lstOutput.Items.Add(GuessNumber & "         Too low")
                    End If

                ElseIf GuessNumber > RandomNumber Then
                    If counter = 10 Then 'If counter = 10 and guess still incorrect
                        'Print a message that tell user lost the game
                        MessageBox.Show("Sorry, you lost the game")
                        'Set the background color of label to red
                        lblOutput.BackColor = Color.Red
                        'Display the hint and remaining guess times in the label
                        lblOutput.Text = "Your guess is too high" & vbCr & "You have " & 10 - counter & " times left"
                        'Add the guess number and the status to the list box
                        lstOutput.Items.Add(GuessNumber & "         Too high")
                        'Disable the start button
                        cmdStart.Enabled = False
                        'Set again button visible to true
                        cmdAgain.Visible = True
                        'Initial counter to 0
                        counter = 0
                    Else
                        'Set the background color of label to red
                        lblOutput.BackColor = Color.Red
                        'Display the hint and remaining guess times in the label
                        lblOutput.Text = "Your guess is too high" & vbCr & "You have " & 10 - counter & " times left"
                        'Add the guess number and the status to the list box
                        lstOutput.Items.Add(GuessNumber & "         Too high")
                    End If

                ElseIf GuessNumber = RandomNumber Then
                    'Set the background color of label to yellow
                    lblOutput.BackColor = Color.Yellow
                    'Display the hint and remaining guess times in the label
                    lblOutput.Text = "Your entry is correct" & vbCr & "You have " & 10 - counter & " times left"
                    'Add the guess number and the status to the list box
                    lstOutput.Items.Add(GuessNumber & "         Correct")
                    'Display a message by using procedures
                    WinOrLose(counter)
                    'Disable the start button
                    cmdStart.Enabled = False
                    'Set again button visible to true
                    cmdAgain.Visible = True
                    'Initital counter to 0
                    counter = 0
                End If
            End If
        End If

    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim temp As Boolean
        temp = (MessageBox.Show("Comfirm close?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No)
        e.Cancel = temp
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAgain_Click(sender As Object, e As EventArgs) Handles cmdAgain.Click
        'This button clear the label and list box and initial the counter to 0
        RandomNumber = GetRandomNumber() 'Get the random number
        lblOutput.Text = Nothing 'Clear label
        lblOutput.BackColor = Nothing 'Clear the label color
        lstOutput.Items.Clear() 'Clear list box
        cmdStart.Enabled = True
        cmdAgain.Visible = False
        cmdStart.Focus()
    End Sub
End Class
