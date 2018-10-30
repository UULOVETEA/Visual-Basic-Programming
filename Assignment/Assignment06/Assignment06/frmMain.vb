'Title:     Hotel Occupancy Program
'Author:    Xiaomeng Cao
'Date:      October 12, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program that calculates the occupancy rate for each floor
'               and the overall occupancy rate for a hotel.t.
'
'Initial Algorithm:
'   1.  User click the complete button
'   2.  User enter the number of rooms occpuied for each floor
'   3.  Calculate the occupancy rate for each floor
'   4.  Calculate the total number of rooms occupied
'   5.  Calcualte the overall occupancy rate
'   6.  Display the OccupiedRate, TotalOccupied, and OverallRate
'
'Data Requirements:
'   Input:
'       Rooms occupied for each floor entered by user:  RoomsOccupied
'   Output:
'       Occupancy rate for each floor: OccupiedRate
'       The total number Of rooms occupied: TotalOccupied
'       The overall occupancy rate for the hotel: OverallRate
'   Additional:
'       None
'
'Formulas:
'   OccupiedRate = RoomsOccupied / 30
'   TotalOccupied = TotalOccupied + RoomsOccupied
'   OverallRate = TotalOccupied / 450
'
'Refined Algorithm:
'   Set floor to zero
'   Set MaxFloor to 16
'   Set Rooms_Per_Floor to 30
'   Set TotalOccupied to 0
'   1.  User click the complete button
'   WHILE floor < MaxFloor
'   2.  User enter the number of rooms occpuied for each floor
'           IF floor = 12
'               Ask user to enter the rooms occupied on 14 floor, and skip the 13 floor
'                   IF UserInput is numeric AND UserInput >= 0 AND UserInput <= 30 THEN
'                       Calculate occupancy rate for 14 floor
'                       Get the information of each floor
'                       Calulate the total number of rooms occpuied
'                       Display the information for each floor in the list box
'                   END IF
'           ELSE
'               Ask user to enter the rooms occupied on each floor except the 13 floor
'                   IF UserInput is numeric AND UserInput >= 0 AND UserInput <= 30 THEN
'                       Calculate occupancy rate for each floor
'                       Get the information of each floor
'                       Calulate the total number of rooms occpuied
'                       Display the information for each floor in the list box
'                   END IF
'           End if
'   END WHILE
'   6.  Display the TotalOccupied and OverallRate


Public Class frmMain
    Private Sub cmdComplete_Click(sender As Object, e As EventArgs) Handles cmdComplete.Click
        'This command button calculate the total price of each package and display the total price

        'Declare local variables
        Dim floor As Integer = 0 'Count how many floors are entered
        Dim MaxFloor As Integer = 16 'The hotel has 16 floors
        Dim Rooms_Per_Floor As Integer = 30 'Each floor has 30 rooms
        Dim RoomsOccupied As Integer 'Numeric value entered by user
        Dim TotalOccupied As Integer = 0 'The total number Of rooms occupied 
        Dim Message As String
        Dim OverallRate As Double = 0 'Initialize to zero
        Dim OccupiedRate As Double 'Occupancy rate for each floor
        Dim UserInput As String 'Value entered by user read as a string

        While floor < MaxFloor 'Keep going until MaxFloor is reached

            If floor = 12 Then
                'Get the number of rooms occupied on 14 floor
                UserInput = InputBox("How many rooms do you want occupied on floor " & floor + 2)
                If IsNumeric(UserInput) And UserInput >= 0 And UserInput <= 30 Then
                    RoomsOccupied = Val(UserInput) 'Convert contents of input box to numeric value
                    OccupiedRate = RoomsOccupied / 30 'Calculate occupancy rate for each floor
                    floor += 2
                    'Get the information of each floor
                    Message = "Floor " & floor & " has " & RoomsOccupied & " rooms occupied." & "Occupied rate is " & Format(OccupiedRate, "Percent") & vbCr
                    'Calulate the total number of rooms occpuied
                    TotalOccupied = TotalOccupied + RoomsOccupied
                    'Display the information for each floor in the list box
                    lstOutput.Items.Add(Message)
                End If
            Else
                'Get the number of rooms occupied on each floor
                UserInput = InputBox("How many rooms do you want occupied on floor " & floor + 1)
                If IsNumeric(UserInput) And UserInput >= 0 And UserInput <= 30 Then
                    RoomsOccupied = Val(UserInput) 'convert contents of input box to numeric value
                    OccupiedRate = RoomsOccupied / 30 'Calculate occupancy rate for each floor
                    floor += 1
                    'Get the information of each floor, and put together
                    Message = "Floor " & floor & " has " & RoomsOccupied & " rooms occupied." & "Occupied rate is " & Format(OccupiedRate, "Percent") & vbCr
                    'Calulate the total number of rooms occpuied
                    TotalOccupied = TotalOccupied + RoomsOccupied
                    'Display the information for each floor in the list box
                    lstOutput.Items.Add(Message)
                End If

            End If

        End While 'End While floor < MaxFloor
        'Loop ends when floor = MaxFloor

        OverallRate = TotalOccupied / 450 'Calulate the overall occupancy rate for the hotel

        lblOutputTotalOccupied.Text = TotalOccupied 'Display TotalOccupied
        lblOutputOverallRate.Text = Format(OverallRate, "Percent") 'Display OverallRate

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        'This button clears out all labels
        lstOutput.Items.Clear()
        lblOutputTotalOccupied.Text = ""
        lblOutputOverallRate.Text = ""

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
