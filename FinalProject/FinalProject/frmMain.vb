'Title:     Movie Library
'Author:    Xiaomeng Cao
'Date:      December 10, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program will keep track of a media library to store movies.
'               It will store all of the data using array.
'
'Initial Algorithm:
'   1.  Select a radio button
'   2.  Show the form depending on which radio button is selected
'   3.  Click Movie - New
'       Input the information for a movie
'   5.  Click Movie - Update
'       Update the information of selected movie
'   6.  Click Movie - Delete
'       Delete a selected movie
'   7.  Click Movie - Save
'       Save all movies into an array
'   8.  Click File - Save
'       Create a file and write the information of movies in to the file
'   9.  Click File - Load
'       Read the data from a file and store the data into an array
'   10. Click Actor - New
'       Input the information of actors
'   11. Click Actor - Delete
'       Delete a speific actor
'   12. Click Actor - Update
'       Update the information of a speific actor
'   13. Close
'       Close the movie form and return to main form
'   14. Click About
'       Show the about information
'   15. Click Exit
'       Exit the program

Public Class frmMain

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        AboutMediaLibrary.Show()
    End Sub

    '*****************************************************************
    '   This button to check which radio button is selected, and the
    ' program will show the form for selected radio button
    '*****************************************************************
    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        If optMusic.Checked Then        'If music button is selected
            Me.Hide()                   'Hide the frmMain
            frmMusic.Show()             'Show the frmMusic
        ElseIf optMoive.Checked Then    'Else if moive button is selected
            Me.Hide()                   'Hide the frmMain
            frmMovie.Show()             'Shwo the frmMoive
        End If
    End Sub

    '*****************************************************************
    '   This button to display X if X turn radio button is selected,
    ' or display O if O turn radio button is selected
    '*****************************************************************
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
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
