'Title:     Display Grades and Course Program
'Author:    Xiaomeng Cao
'Date:      October 5, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program that allows the user to enter a course name
'               and a numeric course grade, and it convert the course grade
'               to a letter grade
'
'Initial Algorithm:
'   1.  Get a course name and the numeric grade
'   2.  Convert the numeric grade to a letter grade
'   3.  Display the course name and letter grade
'
'Data Requirements:
'   Input:
'       Course name entered by user:  Course
'       Numeric grade entered by user:  NumericGrade
'   Output:
'       Output: Output (include course name and letter grade)
'   Additional:
'       None
'
'Formulas:
'   None
'
'Refined Algorithm:
'   1.  Get a course name and the numeric grade
'   2.  Validate the input of grade is numeric
'           If not, print out an error message and clear the text boxes
'   3.  Validate the input of grade is between 0 to 100
'           If not, print out an error message and clear the text boxes
'   4.  Convert the numeric grade to a letter grade
'           Detetmine a letter grade by select case method
'   5.  Display the course name and letter grade

Public Class frmMain
    Private Sub cmdConvert_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click
        'This command button convert a numeric grade to a letter grade 

        'Declare local variables
        Dim Course As String 'Course name entered by user
        Dim LetterGrade As String
        Static Dim Message As String
        Dim NumericGrade As Double 'Nnumeric grade entered by user

        'Get course name entered into text box and put into variable
        Course = txtCourse.Text

        'Validate the input of grade is numeric
        If IsNumeric(txtNumericGrade.Text) Then
            'Get grade entered into text box and put into variable
            NumericGrade = txtNumericGrade.Text

            'Validate the input of grade is between 0 to 100
            If NumericGrade >= 0 And NumericGrade <= 100 Then
                Select Case NumericGrade
                    Case >= 90
                        LetterGrade = "A"
                    Case >= 80
                        LetterGrade = "B"
                    Case >= 70
                        LetterGrade = "C"
                    Case >= 60
                        LetterGrade = "D"
                    Case < 60
                        LetterGrade = "F"
                End Select

                Message = Message + Course + " " + LetterGrade + vbCr
                lblOutput.Text = Message

            Else 'Show an error message box and clear the text boxes and set focus back to course name text box
                MessageBox.Show("Invaild input. Should be 0 to 100.", "Error")
                txtCourse.Text = ""
                txtNumericGrade.Text = ""
                txtCourse.Focus()
            End If

        Else 'Show an error message box and clear the text boxes and set focus back to course name text box
            MessageBox.Show("The input should be a numeric.", "Error")
            txtCourse.Text = ""
            txtNumericGrade.Text = ""
            txtCourse.Focus()
        End If

        'Return cursor to text box for next number
        txtCourse.Focus()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'This command button ends the program
        Me.Close() 'Remove active window
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim temp As Boolean
        temp = (MessageBox.Show("Comfirm close?", "Closing Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel)
        e.Cancel = temp
    End Sub
End Class