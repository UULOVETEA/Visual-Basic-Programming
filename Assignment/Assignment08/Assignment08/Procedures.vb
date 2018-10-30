Module Procedures
    Public Function GetRandomNumber()
        'This function to generate a random number
        Randomize()
        Dim RandomNumber As Integer = Int((100 - 1 + 1) * Rnd()) + 1
        Return RandomNumber
    End Function

    Public Sub WinOrLose(ByVal counter As Integer)
        Select Case counter
            Case <= 4
                MessageBox.Show("Either you know the secret or you got lucky!")
            Case 5, 6, 7
                MessageBox.Show("You're pretty good at this!")
            Case 8, 9, 10
                MessageBox.Show("You'll do better next time.")
            Case Else
                MessageBox.Show("Sorry - You have taken too many guesses.")
        End Select
    End Sub

    Public Function Validation(ByVal UserInput As String)
        'This function to validate the UserInput is a numeric

        Dim result As Boolean = True 'Set result to true

        If Not IsNumeric(UserInput) Then 'IF UserInput is not numeric
            result = False 'Set result to false
            MessageBox.Show("Should be a numeric") 'Print a error message
        End If

        Return result 'Return the result to GetInPut function
    End Function

    Public Function InRange(ByVal GuessNumber As Integer)
        'This function to validate the GuessNumber is in the range 1 to 100

        Dim result As Boolean = True 'Set result to true

        If GuessNumber < 1 Or GuessNumber > 100 Then 'IF GuessNumber is not in the range
            result = False 'Set result to false
            MessageBox.Show("Should be within 1 to 100") 'Print a error message
        End If

        Return result 'Return the result to GetInPut function
    End Function
End Module
