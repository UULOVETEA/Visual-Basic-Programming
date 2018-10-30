'Title:     Temperature Program
'Author:    Xiaomeng Cao
'Date:      September 21, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program converts a Fahrenheit temperature entered by the user
'               to a Celsius temperature displayed on the screen.
'
'Initial Algorithm:
'   1.  Get Fahrenheit temperature Entered by User
'   2.  Convert it to Celsius temperature
'   3.  Display the Celsius temperature
'
'Data Requirements:
'   Input:
'       Temperature entered by user:  F
'   Output:
'       RCelsius temperature: C
'   Additional:
'       None
'
'Formulas:
'   C = (5 / 9) * (F - 32)
'
'Refined Algorithm:
'   1.  Get Fahrenheit temperature Entered by User
'   2.  Error heck for the temperature 
'   3.  Convert it to Celsius temperature
'           C = (5 / 9) * (F - 32)
'   4.  Display the Celsius temperature

Public Class frmMain
    Private Sub cmdConvert_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click
        'This command button coverts Fahrenheit temperature to Celsius temperature

        'Declare local variables
        Dim F As Double 'Number entered by user
        Dim C As Double

        'Error checking
        If IsNumeric(txtFahrenheit.Text) Then
            'Get number from user
            F = Val(txtFahrenheit.Text)

            'Formula to convert from Fahrenheit to Celsius
            C = (5 / 9) * (F - 32)

            'Output Celsius in standard format
            lblOutput.Text = Format(C, "n")
        Else
            'Display error message
            MessageBox.Show("Invalid Input", "Error")

            'Clear the output label
            lblOutput.Text = ""
        End If

        'Return cursor to text box for next number
        txtFahrenheit.Focus()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        'This command button ends the program

        Me.Close() 'Remove active window
        End 'End program
    End Sub
End Class
