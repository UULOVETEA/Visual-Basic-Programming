'Title:     The State Utilities Commission Project
'Author:    Xiaomeng Cao
'Date:      September 28, 2016
'Course:    CSC 162
'Section:   801
'Description:   This program that allows the user to the customer name and number
'               of kWh used during the current month, and it will calculate the
'               state and city tax and depends on how much kWch used, it calclulate
'               the discount amount, and finally compute the total amount.
'
'Initial Algorithm:
'   1.  Get the name and the number of kWh used
'   2.  Calculate the base amount
'   3.  Calculate state tax and city tax
'   4.  Calculate the discount amount
'   5.  Calcualte the total amount
'   6.  Display the base, taxes, dicount, and total amount
'
'Data Requirements:
'   Input:
'       Name entered by user:  name
'       The number of kWh entered by user:  kWh
'   Output:
'       Base Amount: BaseAmount
'       Discount amount: DiscountAmount
'       State Tax: StateTax
'       City Tax: CityTax
'       Total amount: TotalAmount
'   Additional:
'       None
'
'Formulas:
'   StateTax = BaseAmount * 0.035
'   CityTax = BaseAmount * 0.015
'   DiscountAmount = BaseAmount * 0.88
'   TotalAmount = DiscountAmount + StateTax + CityTax
'
'Refined Algorithm:
'   1.  Get the name and the number of kWh used
'   2.  Calculate the base amount
'           BaseAmount = AmountLevel1 + AmountLevel2 + AmountLevel3 + AmountLevel4
'   3.  Calculate state tax and city tax
'           StateTax = BaseAmount * 0.035
'           CityTax = BaseAmount * 0.015
'   4.  Calculate the discount amount
'           DiscountAmount = BaseAmount * 0.88
'   5.  Calcualte the total amount
'           TotalAmount = DiscountAmount + StateTax + CityTax
'   6.  Display the base, taxes, dicount, and total amount

Public Class frmMain
    Private Sub cmdCompute_Click(sender As Object, e As EventArgs) Handles cmdCompute.Click
        'This command button calculate the total price of each package and display the total price

        'Declare local variables
        Dim name As String 'Name entered by user
        Dim kWh As Double 'Number entered by user
        Dim BaseAmount As Double
        Dim StateTax As Double
        Dim CityTax As Double
        Dim DiscountAmount As Double
        Dim TotalAmount As Double
        Dim AmountLevel1 As Double = 0 'Initialize AmountLevel1 to 0
        Dim AmountLevel2 As Double = 0 'Initialize AmountLevel2 to 0
        Dim AmountLevel3 As Double = 0 'Initialize AmountLevel3 to 0
        Dim AmountLevel4 As Double = 0 'Initialize AmountLevel4 to 0

        'Get number entered into text box and put into variable
        kWh = txtkWhUsed.Text

        If kWh < 1000 Then 'IF kWh < 1000
            '$0.052 per kWh used
            AmountLevel1 = kWh * 0.052

        ElseIf kWh >= 1000 And kWh < 1300 Then 'IF 1000 <= kWh < 1300
            '$0.052 per kWh for first 1000 kWh used
            AmountLevel1 = 1000 * 0.052
            '$0.041 per kWh over 1000kWh
            AmountLevel2 = (kWh - 1000) * 0.041

        ElseIf kWh >= 1300 And kWh < 2000 Then 'IF 1300 <= kWh < 2000
            '$0.052 per kWh for first 1000 kWh used
            AmountLevel1 = 1000 * 0.052
            '$0.041 per kWh for the next 300 kWh used
            AmountLevel2 = 300 * 0.041
            '$0.035 per kWh over 1300 kWh
            AmountLevel3 = (kWh - 1300) * 0.035

        ElseIf kWh >= 2000 Then 'IF kWh >= 2000
            '$0.052 per kWh for first 1000 kWh used
            AmountLevel1 = 1000 * 0.052
            '$0.041 per kWh for the next 300 kWh used
            AmountLevel2 = 300 * 0.041
            '$0.035 per kWh for the next 700 kWh used
            AmountLevel3 = 700 * 0.035
            '$0.03 per kWh over 2000kWh
            AmountLevel4 = (kWh - 2000) * 0.03
        End If

        'Calculate the base amount
        BaseAmount = AmountLevel1 + AmountLevel2 + AmountLevel3 + AmountLevel4

        'Calculate the state tax
        StateTax = BaseAmount * 0.035

        'Calculate the city tax
        CityTax = BaseAmount * 0.015

        'Calculate the discount amount
        DiscountAmount = BaseAmount * 0.88

        'Calculate the total amount
        TotalAmount = DiscountAmount + StateTax + CityTax

        'Display the base amount
        lblOutputBaseAmount.Text = FormatCurrency(BaseAmount)
        'Display the state tax
        lblOutputStateTax.Text = FormatCurrency(StateTax)
        'Display the city tax
        lblOutputCityTax.Text = FormatCurrency(CityTax)
        'Display the discount amount
        lblOutputDiscountAmount.Text = FormatCurrency(DiscountAmount)
        'Display the total amount
        lblOutputTotalAmount.Text = FormatCurrency(TotalAmount)

        'Return cursor to text box for next number
        txtName.Focus()
    End Sub

    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click
        'This command button ends the program

        Me.Close() 'Remove active window
        End 'End program
    End Sub
End Class
