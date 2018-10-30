'Title:     Entering Data, Searching for Data, Printing out Data
'Author:    Xiaomeng Cao
'Date:      November 16, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program will accept 10 names from the user and store them
'               in an array. Once they've been entered, allow the user to enter
'               one name To search For To see If it Is In the array. Display a
'               message saying If it was found.
'
'Initial Algorithm:
'   1.  Declares an array of size 10
'   2.  Display a label with instructions for entering names with no duplicates
'   3.  Create a Command Button to start the process for Entering Names
'   4.  Return to the Form with a message saying all names have been entered and stored successfully
'   5.  Activate a textbox and a second Command Button to provide a way to search for one name
'   6.  Include buttons that allow the user to end, or start over
'
'Data Requirements:
'   Input:
'       Names is entered by user: Names(9)
'       SearchName is entered by user: SearchName
'   Output:
'       If the name is found, print out a message indicating where the name was found
'       If the name is not found, print out a message indicating this
'   Additional:
'       None
'
'Formulas:
'   None
'
'Refined Algorithm:
'   1.  Declares an array of size 10
'       Dim Names(9) As String
'   2.  Display a label with instructions for entering names with no duplicates
'   3.  Create a Command Button to start the process for Entering Names
'   WHILE counter <= UBound(Names)
'       User input names into input box
'       If UserInput = "" Then
'           Display a error message
'       ELSE
'           store the input into the array
'           counter += 1
'       END IF
'   END WHILE
'   4.  Return to the Form with a message saying all names have been entered and stored successfully
'   5.  Activate a textbox and a second Command Button to provide a way to search for one name
'   IF NOT txtSearchName.Text = "" Then
'       Get the search name form text box
'       IF LinearSearch(Names, SearchName) Then
'           Print out a message indicating where the name was found
'       ELSE
'           Print out a message indicating the name is not found
'       END IF
'   END IF
'   6.  Include buttons that allow the user to end, or start over

Public Class frmMain
    'Declares an array of size 10.  Use a constant for the size
    Const arraySize As Integer = 9
    Dim Names(arraySize) As String
    Private Sub cmdEnter_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click
        'This button get names from input box and store them into array
        Dim counter As Integer = 0
        Dim UserInput As String

        While counter <= UBound(Names)
            'Get the user input from input box
            UserInput = InputBox("Please enter the #" & (counter + 1) & " name")
            If UserInput = "" Then 'If UserInput is blank
                'Print a error
                MessageBox.Show("Input cannot be blank")
            Else 'UserInput is not blank
                'Store UserInput into the array
                Names(counter) = UserInput
                'Increase counter
                counter += 1
            End If
        End While

        'Display a message that all names have been entered and stored successfully
        lblInstruction.Text = "All names have been entered and stored successfully."

        'Make Enter button no longer visible
        cmdEnter.Visible = False
        'Make labels, text box, and Search button visible
        lblSearchName.Visible = True
        txtSearchName.Visible = True
        cmdSearch.Visible = True
        lblResult.Visible = True

        'Set focus on text box
        txtSearchName.Focus()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        'This button to search a name in the array
        'Make the label instrcution no longer visible
        lblInstruction.Visible = False
        Dim SearchName As String
        Dim counter As Integer = 0
        Dim found As Boolean = False

        If Not txtSearchName.Text = "" Then 'If text box is not blank
            SearchName = txtSearchName.Text 'Get search name from text box
            While found = False And counter <= UBound(Names)
                If Not (Names(counter) = SearchName) Then 'If did not found searchName in the array
                    'Increase counter
                    counter += 1
                Else 'Found name in the array
                    'Set found = true
                    found = True
                End If
            End While

            If found = True Then
                'Print out a message indicating where the name was found
                lblResult.Text = SearchName & " was found in cell " & counter
            ElseIf found = False Then
                'Print out a message indicating the name is not found
                lblResult.Text = SearchName & " is not found in the array "
            End If
        Else 'text box is blank
            'Display an error message
            MessageBox.Show("Input cannot be blank")
        End If

        'Set focus on text box
        txtSearchName.Focus()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        'This button clear the label and text box and reset the visiblity for buttons
        lblResult.Text = "Enter a name into the text box and click the search button to search in the array."
        'Make label, text box, search button no longer visible
        lblSearchName.Visible = False
        txtSearchName.Visible = False
        cmdSearch.Visible = False
        lblResult.Visible = False
        'Make instruction label and enter button visible
        lblInstruction.Visible = True
        cmdEnter.Visible = True
        'Set focus on enter button
        cmdEnter.Focus()
    End Sub

    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click
        'This command button ends the program
        Me.Close() 'Remove active window
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim temp As Boolean
        temp = (MessageBox.Show("Comfirm close?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No)
        e.Cancel = temp
    End Sub
End Class
