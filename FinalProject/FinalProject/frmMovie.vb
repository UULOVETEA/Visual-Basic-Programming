Imports System
Imports System.IO
Imports System.Text

Public Class frmMovie

    '*****************************************************************
    '   This button will close the frmMoive and show the frmMain
    '*****************************************************************
    Private Sub mnuCloseMoive_Click(sender As Object, e As EventArgs) Handles mnuCloseMoive.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Structure Moive
        Dim title As String             'the title of a movie
        Dim releaseYear As Integer      'the release year of a movie
        Dim length As Decimal           'the length of a movie
        Dim rating As String            'the rating of a movie
        Dim actor() As String           'the actor 
        Dim role() As String            'the role palyed
    End Structure

    Dim movieInfo(5) As Moive           'Array to hold the information of moives
    Dim counter As Integer              'Global counter


    '********************************************************************************************************************************************
    '************************************************************ Actor Menu Section ************************************************************
    '********************************************************************************************************************************************


    '*****************************************************************
    '   This button will try to create a file with specific file name.
    ' If successful, the program will write the data from the array 
    ' into the file
    '*****************************************************************
    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click
        Dim movieFile As StreamWriter       'Object variable
        Dim count As Integer                'Loop counter

        Try
            'Open file
            movieFile = File.CreateText("MovieLibrary.txt")

            'Get the data and write it to the file
            For count = 0 To UBound(movieInfo)
                With movieInfo(count)
                    movieFile.WriteLine(.title)
                    movieFile.WriteLine(.releaseYear)
                    movieFile.WriteLine(.length)
                    movieFile.WriteLine(.rating)
                End With
            Next

            'Close the file
            movieFile.Close()
        Catch
            'Error message
            MessageBox.Show("That file canot be created.")
        End Try
    End Sub

    '*****************************************************************
    '   This button will try to open a file with specific file name.
    ' If successful, the program will read the data from the file and 
    ' store into array, and the data wil be displayed on the form
    '*****************************************************************
    Private Sub mnuLoadFile_Click(sender As Object, e As EventArgs) Handles mnuLoadFile.Click
        Dim movieFile As StreamReader       'Object variable
        Dim count As Integer                'Loop counter

        Try
            'Open the file
            movieFile = File.OpenText("MovieLibrary.txt")

            'Read the data
            For count = 0 To UBound(movieInfo)
                With movieInfo(count)
                    .title = movieFile.ReadLine()
                    .releaseYear = movieFile.ReadLine()
                    .length = movieFile.ReadLine()
                    .rating = movieFile.ReadLine()
                End With

                lstMoive.Items.Add(movieInfo(count).title)
                txtTitle.Text = movieInfo(count).title
                txtReleaseYear.Text = movieInfo(count).releaseYear
                txtLength.Text = movieInfo(count).length
                cboRating.Text = movieInfo(count).rating
            Next

            'Close the file
            movieFile.Close()
        Catch
            MessageBox.Show("That file cannot be opened.")
        End Try
    End Sub

    '********************************************************************************************************************************************
    '************************************************************ Moive Menu Section ************************************************************
    '********************************************************************************************************************************************


    '*****************************************************************
    '   This button will enable and clear all of the fields
    '*****************************************************************
    Private Sub mnuNewMoive_Click(sender As Object, e As EventArgs) Handles mnuNewMoive.Click
        'Enable all of the fields 
        txtTitle.Enabled = True
        txtReleaseYear.Enabled = True
        txtLength.Enabled = True
        cboRating.Enabled = True

        'Set focus to the title field
        txtTitle.Focus()

        'Clear all of the fields
        txtTitle.Text = ""
        txtReleaseYear.Text = ""
        txtLength.Text = ""
        cboRating.Text = Nothing
        lstActor.Items.Clear()
    End Sub

    '*****************************************************************
    '   This button will enable all of the fields for user who is able
    ' to edit the information of the specific movie
    '*****************************************************************
    Private Sub mnuUpdateMoive_Click(sender As Object, e As EventArgs) Handles mnuUpdateMoive.Click
        'Enable all of the fields 
        txtTitle.Enabled = True
        txtReleaseYear.Enabled = True
        txtLength.Enabled = True
        cboRating.Enabled = True

        'Set focus to the title field
        txtTitle.Focus()
    End Sub

    '*****************************************************************
    '   This button will delete a specific movie by asking user
    '*****************************************************************
    Private Sub mnuDeleteMoive_Click(sender As Object, e As EventArgs) Handles mnuDeleteMoive.Click
        Dim count As Integer
        Dim temp As Integer

        If lstMoive.SelectedIndex <> -1 Then
            'Prompt user to make sure they want to delete a movie
            temp = MessageBox.Show("Comfirm delete the movie?", "Deleteing Movie", MessageBoxButtons.YesNo)

            If temp = DialogResult.Yes Then                                 'If user selected Yes
                count = lstMoive.Items.IndexOf(lstMoive.Text)               'Get the index value of the movie in the array
                lstMoive.Items.RemoveAt(lstMoive.SelectedIndex)             'Remove the movie user selcted from list box

                While count < counter
                    With movieInfo(count)
                        .title = movieInfo(count + 1).title                 'Move title data from higher index to lower index
                        .releaseYear = movieInfo(count + 1).releaseYear     'Move releaseYear data from higher index to lower index
                        .length = movieInfo(count + 1).length               'Move length data from higher index to lower index
                        .rating = movieInfo(count + 1).rating               'Move rating data from higher index to lower index
                    End With
                    count += 1                                              'Increase count by 1
                End While

                counter -= 1                                                'Descrease counter by 1

                'Clear all of the fields
                txtTitle.Text = ""
                txtReleaseYear.Text = ""
                txtLength.Text = ""
                cboRating.Text = Nothing
                lstActor.Items.Clear()
            End If
        Else
            MessageBox.Show("Must first select an item in the list")        'Display a message that the user must selected a movie to delete
        End If

    End Sub

    '*****************************************************************
    '   This button will save all information of a movie and store
    ' into array
    '*****************************************************************
    'Refined Algorithm:
    '   IF all fileds are blank
    '       Display a message that all fields must be filled in to add a movie
    '   ELSE
    '       IF txtReleaseYear.Text is not numeric
    '           Display a message year of the movie must be numeric
    '       ELSE
    '           IF txtLength.Text is not numeric
    '               Display a message that length of the movie must be numeric (total number of minutes)
    '           ELSE
    '               Prompt user to make sure they want to save the changes
    '               IF user selected Yes
    '                   ReDim Preserve movieInfo(UBound(movieInfo) + 1)
    '                   Get title from text box
    '                   Get year from text box
    '                   Get length from text box
    '                   Get rating from combo box
    '               END IF
    '           END IF
    '       END IF
    '   END IF
    Private Sub mnuSaveMoive_Click(sender As Object, e As EventArgs) Handles mnuSaveMoive.Click

        Dim temp As Integer

        If txtTitle.Text = "" Or txtReleaseYear.Text = "" Or txtLength.Text = "" Or cboRating.SelectedIndex = -1 Then
            'Display a message that all fields must be filled in to add a movie
            MessageBox.Show("All fields must be filled in. This inculdes the title, year, length, and rating.", "Incomplete Input")
        Else
            If Not Validation(txtReleaseYear.Text) Then
                'Display a message year of the movie must be numeric
                MessageBox.Show("The year for the movie is invalid, must be a numeric value.", "Invalid year for a movie")
            Else
                If Not Validation(txtLength.Text) Then
                    'Display a message that length of the movie must be numeric (total number of minutes)
                    MessageBox.Show("Moive length must be a numeric value. The length of the movie in minutes.", "Invalid movie length")
                Else
                    'Prompt user to make sure they want to save the changes
                    temp = MessageBox.Show("Comfirm save the movie?", "Saving Movie", MessageBoxButtons.YesNo)

                    If temp = DialogResult.Yes Then                             'If user selected Yes
                        If counter > UBound(movieInfo) Then                     'If array is full
                            ReDim Preserve movieInfo(UBound(movieInfo) + 1)     'Resize the array

                            With movieInfo(counter)
                                .title = txtTitle.Text                          'Get title from text box
                                .releaseYear = CInt(txtReleaseYear.Text)        'Get year from text box
                                .length = CDec(txtLength.Text)                  'Get length from text box
                                .rating = cboRating.SelectedItem.ToString       'Get rating from combo box
                            End With

                            If lstMoive.Items.Contains(txtTitle.Text) Then
                                'Display a message that movie cannot already exist in the list to be added to the list
                                MessageBox.Show("This movie already exist!", "Duplicate Moive")
                            Else
                                'DisplayMoive(movieInfo)
                                'Add movie into the listbox
                                lstMoive.Items.Add(movieInfo(counter).title)
                                'Current selected item in the list box of movies should be the movie just added
                                lstMoive.SelectedItem = txtTitle.Text

                                counter += 1

                                'Disable all of the controls again
                                txtTitle.Enabled = False
                                txtReleaseYear.Enabled = False
                                txtLength.Enabled = False
                                cboRating.Enabled = False
                            End If
                        Else
                            With movieInfo(counter)
                                .title = txtTitle.Text                          'Get title from text box
                                .releaseYear = CInt(txtReleaseYear.Text)        'Get year from text box
                                .length = CDec(txtLength.Text)                  'Get length from text box
                                .rating = cboRating.SelectedItem.ToString       'Get rating from combo box
                            End With

                            If lstMoive.Items.Contains(txtTitle.Text) Then
                                'Display a message that movie cannot already exist in the list to be added to the list
                                MessageBox.Show("This movie already exist!", "Duplicate Moive")
                            Else
                                'DisplayMoive(movieInfo)
                                'Add movie into the listbox
                                lstMoive.Items.Add(movieInfo(counter).title)
                                'Current selected item in the list box of movies should be the movie just added
                                lstMoive.SelectedItem = txtTitle.Text

                                counter += 1

                                'Disable all of the controls again
                                txtTitle.Enabled = False
                                txtReleaseYear.Enabled = False
                                txtLength.Enabled = False
                                cboRating.Enabled = False
                            End If

                        End If
                    End If
                End If

            End If
        End If

    End Sub

    '********************************************************************************************************************************************
    '************************************************************ Actor Menu Section ************************************************************
    '********************************************************************************************************************************************


    '*****************************************************************
    '   This button will get the name of actors and the role they
    ' played, and then it add the data into the selected movie
    '*****************************************************************
    'Refined Algorithm:
    '   If lstMoive.SelectedIndex > -1 Then
    '        index = lstMoive.Items.IndexOf(lstMoive.Text)
    '   DO
    '       Get the numeber of actors the user wish to input
    '       If Not IsNumeric(userInput) Then
    '           Display an error message
    '               Display a message that length of the movie must be numeric (total number of minutes)
    '           ELSE
    '               Prompt user to make sure they want to save the changes
    '               IF user selected Yes
    '                   ReDim Preserve movieInfo(UBound(movieInfo) + 1)
    '                   Get title from text box
    '                   Get year from text box
    '                   Get length from text box
    '                   Get rating from combo box
    '               END IF
    '           END IF
    '       END IF
    '   END IF
    Private Sub mnuNewActor_Click(sender As Object, e As EventArgs) Handles mnuNewActor.Click
        Dim MAX_NUM As Integer
        Dim userInput As String
        Dim count As Integer
        Dim index As Integer

        If lstMoive.SelectedIndex > -1 Then
            index = lstMoive.Items.IndexOf(lstMoive.Text)

            Do
                'Get the numeber of actors the user wish to input
                userInput = InputBox("How many actors/actresses do you wish to enter", "Number of actors/actresses")

                If Not IsNumeric(userInput) Then
                    MessageBox.Show("Number of actors should be a numeric", "Invalid Number of Actor")
                Else

                    MAX_NUM = CInt(userInput)

                    ReDim Preserve movieInfo(index).actor(MAX_NUM - 1)
                    ReDim Preserve movieInfo(index).role(MAX_NUM - 1)

                    For count = 0 To UBound(movieInfo(index).actor)
                        Do
                            movieInfo(index).actor(count) = InputBox("Enter an actor/actress name", "Actor/Actress Name")
                        Loop While movieInfo(index).actor(count) = ""

                        Do
                            movieInfo(index).role(count) = InputBox("Enter the character played by", "Character Name")
                        Loop While movieInfo(index).role(count) = ""

                        lstActor.Items.Add(movieInfo(index).actor(count) & " as " & movieInfo(index).role(count))
                    Next
                End If
            Loop While userInput = ""

        Else
            MessageBox.Show("Must select a movie first!", "Select a movie")     'Display a message that user must selected a movie first
        End If

    End Sub

    '*****************************************************************
    '   This button will delete a specific actor by asking user
    '*****************************************************************
    Private Sub mnuDeleteActor_Click(sender As Object, e As EventArgs) Handles mnuDeleteActor.Click

        Dim temp As Integer
        Dim count As Integer
        Dim index As Integer

        If lstActor.SelectedIndex <> -1 Then
            'Prompt user to make sure they want to delete an actor
            temp = MessageBox.Show("Comfirm delete the actor?", "Deleteing Actor", MessageBoxButtons.YesNo)

            If temp = DialogResult.Yes Then                                 'If user selected Yes
                count = lstActor.Items.IndexOf(lstActor.Text)               'Get the index value of the movie in the array
                lstActor.Items.RemoveAt(lstActor.SelectedIndex)             'Remove the actor from list box

                For index = 0 To UBound(movieInfo(count).actor)
                    With movieInfo(count)
                        .actor(index) = movieInfo(count).actor(index + 1)
                        .role(index) = movieInfo(count).role(index + 1)
                    End With
                Next
            End If
        Else
            MessageBox.Show("Must first select an item in the list")        'Display a message that user must selected actor to delete
        End If

    End Sub

    '*****************************************************************
    '   This button will enable the user to edit the information of 
    ' the specific actor
    '*****************************************************************
    Private Sub mnuUpdateActor_Click(sender As Object, e As EventArgs) Handles mnuUpdateActor.Click

    End Sub

    '*****************************************************************
    '   This function will validate input is numeric or not
    '*****************************************************************
    Private Function Validation(ByVal UserInput As String)
        'This function to validate the UserInput is a numeric

        Dim result As Boolean = True        'Set result to true

        If Not IsNumeric(UserInput) Then    'IF UserInput is not numeric
            result = False                  'Set result to false
        End If

        Return result                       'Return the result to GetInPut function
    End Function

    '*****************************************************************
    '   This procedure will change the information on all the fields
    ' when selected item is changed
    '*****************************************************************
    Private Sub lstMoive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMoive.SelectedIndexChanged

        Dim index As Integer
        Dim count As Integer

        If lstMoive.SelectedIndex > -1 Then

            If Not IsNothing(movieInfo(index).actor) And Not IsNothing(movieInfo(index).role) Then
                For count = 0 To UBound(movieInfo(index).actor)
                    'If Not movieInfo(index).actor(count) = "" And Not movieInfo(index).role(count) = "" Then
                    lstActor.Items.Add(movieInfo(index).actor(count) & " as " & movieInfo(index).role(count))
                    'End If
                Next
            Else
                index = lstMoive.Items.IndexOf(lstMoive.Text)
                txtTitle.Text = movieInfo(index).title
                txtReleaseYear.Text = movieInfo(index).releaseYear
                txtLength.Text = movieInfo(index).length
                cboRating.Text = movieInfo(index).rating
            End If
        End If
    End Sub

    '*****************************************************************
    '   This procedure will add rating information into the combo box
    '*****************************************************************
    Private Sub frmMoive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRating.Items.Add("G -General Audiences")
        cboRating.Items.Add("PG -Parental Guidance Suggested")
        cboRating.Items.Add("PG-13 - Parents Stongly Cautioned")
        cboRating.Items.Add("R -Restricted")
        cboRating.Items.Add("NC-17 - No One 17 And Under Admitted")
    End Sub

End Class