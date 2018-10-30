Public Class frmMain
    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        'Declare local variables
        Dim OriginalPrice As Double
        Dim Tax As Double
        Dim DiscountPrice As Double
        Dim FinalPrice As Double

        'Get original price entered into text box and put into variable
        OriginalPrice = txtOriginalPrice.Text

        'Calculate discount price
        DiscountPrice = 0.55 * OriginalPrice
        'Calculate tax
        Tax = 0.06 * DiscountPrice
        'Calculate final price
        FinalPrice = DiscountPrice + Tax

        'Print discount price
        lblOutputDiscountPrice.Text = DiscountPrice
        'print tax
        lblOutputTax.Text = Tax
        'print final price
        lblOutputFinalPrice.Text = FinalPrice

        txtOriginalPrice.Focus()

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        'This button clears out all text boxes and labels
        txtOriginalPrice.Text = ""
        lblOutputDiscountPrice.Text = ""
        lblOutputTax.Text = ""
        lblOutputFinalPrice.Text = ""

        'Set focus back to text box
        txtOriginalPrice.Focus()
    End Sub

    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click
        'This command button ends the program
        Me.Close() 'Remove active window
        End 'End program
    End Sub
End Class
