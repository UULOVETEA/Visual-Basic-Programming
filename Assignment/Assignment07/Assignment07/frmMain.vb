'Title:     Calculate student grade
'Author:    Xiaomeng Cao
'Date:      October 30, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program  will be capable of accepting multiple students’
'               grades.For each student, it will be able to accept multiple grades.
'
'Initial Algorithm:
'   1.  User click the start button
'   2.  User enter a student's name
'   3.  User enter final average of quiz grades for that student
'   4.  User enter final average of homework assignment grades for that student
'   5.  User enter final exam grade for that student
'   6.  Calculate the end of marking period grade student
'   7.  Display the student's name and marking period grade in a message box
'   8.  Calculate a running total of all the marking period grades for all students
'   9.  Count the number of students are entered
'   10. Display how many students were entered and the average marking period grade for the class
'
'Data Requirements:
'   Input:
'       Student's name is entered by user: StudentName
'       All of three grades are entered by user:  UserInput
'   Output:
'       Student's name for each student: StudentName
'       Final marking period grade for each student: MarkingGrade
'       The total number of students were entered: Counter
'       The average of marking period grade fo the class: AvgMarkingGrade
'   Additional:
'       None
'
'Formulas:
'   OverallQuizGrade = AvgQuizGrade * 0.3
'   OverallAssignmentGrade = AvgAssignmentGrade * 0.2
'   OverallFinalExam = FinalExam * 0.5
'   MarkingGrade = OverallQuizGrade + OverallAssignmentGrade + OverallFinalExam
'   TotalMarkingGrade = TotalMarkingGrade + MarkingGrade
'   AvgMarkingGrade = TotalMarkingGrade / Counter
'
'Refined Algorithm:
'   Set IntialChoice As String = "Y"
'   Set UserChoice As String = "Y"
'   Set Counter As Integer = 0
'   1.  User click the start button
'   WHILE(UserChoice = IntialChoice)
'       Count how many students are entered
'       DO
'       2.  User enter a student's name
'       LOOP While StudentName = ""
'       Do
'           Do
'           3.  User enter final average of quiz grades for that student
'           Convert contents of input box to numeric value
'           LOOP WHILE AvgQuizGrade < 0 Or AvgQuizGrade > 100
'       LOOP UNTIL UserInput is a numeric
'       Do
'           Do
'           4.  User enter final average of homework assignment grades for that student
'           Convert contents of input box to numeric value
'           LOOP WHILE AvgAssignmentGrade < 0 Or AvgAssignmentGrade > 100
'       LOOP UNTIL UserInput is a numeric
'       Do
'           Do
'           5.  User enter final exam grade for that student
'           Convert contents of input box to numeric value
'           LOOP WHILE FinalExam < 0 Or FinalExam > 100
'       LOOP UNTIL UserInput is a numeric
'       6.  Calculate the end of marking period grade student
'               OverallQuizGrade = AvgQuizGrade * 0.3
'               OverallAssignmentGrade = AvgAssignmentGrade * 0.2
'               OverallFinalExam = FinalExam * 0.5
'               MarkingGrade = OverallQuizGrade + OverallAssignmentGrade + OverallFinalExam
'       7.  Display the student's name and marking period grade in a message box
'       8.  Calculate a running total of all the marking period grades for all students
'               TotalMarkingGrade = TotalMarkingGrade + MarkingGrade
'               AvgMarkingGrade = TotalMarkingGrade / Counter
'   END WHILE
'   9.  Calculate the average of marking period grade fo the class
'   10. Display how many students were entered and the average marking period grade for the class

Public Class frmMain
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Const IntialChoice As String = "Y" 'Program sentinel
        Dim UserChoice As String = "Y" 'User sentinel
        Dim Counter As Integer = 0 'Count how many students are entered

        Dim StudentName As String 'Hold each student's name
        Dim UserInput As String 'Value entered by user read as a string
        Dim AvgQuizGrade As Double 'Hold each student's average of quiz grade
        Dim AvgAssignmentGrade As Double 'Hold each student's average of assignment grade
        Dim FinalExam As Double 'Hold each student's final exam grade

        Dim OverallQuizGrade As Double 'Calucate by the program
        Dim OverallAssignmentGrade As Double 'Calucate by the program
        Dim OverallFinalExam As Double 'Calucate by the program

        Dim MarkingGrade As Double 'Hold each student's marking grade
        Dim TotalMarkingGrade As Double = 0 'Count and hold the running total of all students' marking grades
        Dim AvgMarkingGrade As Double 'Hold the average of all marking grades

        While (UserChoice.ToUpper() = IntialChoice) 'Repeat code as long as UserChoice is equal to the Flag ("Y")
            'Count how many students are entered
            Counter += 1

            Do
                'Ask the user to input student's name
                StudentName = InputBox("Please enter #" & Counter & " student's name")
            Loop While StudentName = "" 'Repeat when StudentName is blank

            Do
                Do
                    'Ask the user to input student's average of quiz grade
                    UserInput = InputBox("Please enter #" & Counter & " student's final average of quiz grade")
                    'Convert contents of input box to numeric value
                    AvgQuizGrade = Val(UserInput)
                Loop While AvgQuizGrade < 0 Or AvgQuizGrade > 100 'Repeat code while AvgQuizGrade < 0 Or AvgQuizGrade > 100
            Loop Until IsNumeric(UserInput) 'Repeat code untill UserInput is a numeric

            Do
                Do
                    'Ask the user to input student's average of homework assignment Grades
                    UserInput = InputBox("Please enter #" & Counter & " student's final average of homework assignment grade")
                    'Convert contents of input box to numeric value
                    AvgAssignmentGrade = Val(UserInput)
                Loop While AvgAssignmentGrade < 0 Or AvgAssignmentGrade > 100 'Repeat code while AvgAssignmentGrade < 0 Or AvgAssignmentGrade > 100
            Loop Until IsNumeric(UserInput) 'Repeat code untill UserInput is a numeric

            Do
                Do
                    'Ask the user to input student's final exam grade
                    UserInput = InputBox("Please enter #" & Counter & " student's final exam grade")
                    'Convert contents of input box to numeric value
                    FinalExam = Val(UserInput)
                Loop While FinalExam < 0 Or FinalExam > 100 'Repeat code while FinalExam < 0 Or FinalExam > 100 
            Loop Until IsNumeric(UserInput) 'Repeat code untill UserInput is a numeric

            'Calculate overall quiz grade
            OverallQuizGrade = AvgQuizGrade * 0.3
            'Calculate overall assignment grade
            OverallAssignmentGrade = AvgAssignmentGrade * 0.2
            'Calcualte overall final exam grade
            OverallFinalExam = FinalExam * 0.5
            'Calculate the marking grade
            MarkingGrade = OverallQuizGrade + OverallAssignmentGrade + OverallFinalExam
            'Calculate the total of marking grades
            TotalMarkingGrade = TotalMarkingGrade + MarkingGrade

            'Display each student's name and makring grade in the messsage box
            MessageBox.Show("Final Marking Period Grade is " & MarkingGrade, StudentName)

            'Ask the user do they want to enter anohter student
            UserChoice = InputBox("Do you want to enter another student's grade? Y/N")
        End While 'End Loop

        'Calculate the average of marking period grade fo the class
        AvgMarkingGrade = TotalMarkingGrade / Counter
        'Display how many students are entered and the average of marking period grade fo the class
        lblOutput.Text = "Total number of student: " & Counter & vbCr & "Average of marking period grade: " & AvgMarkingGrade

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
        End
    End Sub
End Class
