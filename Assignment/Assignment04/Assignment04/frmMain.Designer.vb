<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBaseAmount = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblCityTax = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblkWhUsed = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtkWhUsed = New System.Windows.Forms.TextBox()
        Me.lblOutputBaseAmount = New System.Windows.Forms.Label()
        Me.lblOutputDiscountAmount = New System.Windows.Forms.Label()
        Me.lblOutputStateTax = New System.Windows.Forms.Label()
        Me.lblOutputCityTax = New System.Windows.Forms.Label()
        Me.lblOutputTotalAmount = New System.Windows.Forms.Label()
        Me.cmdCompute = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBaseAmount
        '
        Me.lblBaseAmount.AutoSize = True
        Me.lblBaseAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaseAmount.Location = New System.Drawing.Point(26, 85)
        Me.lblBaseAmount.Name = "lblBaseAmount"
        Me.lblBaseAmount.Size = New System.Drawing.Size(93, 16)
        Me.lblBaseAmount.TabIndex = 6
        Me.lblBaseAmount.Text = "Base amount: "
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.AutoSize = True
        Me.lblDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountAmount.Location = New System.Drawing.Point(26, 109)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(113, 16)
        Me.lblDiscountAmount.TabIndex = 8
        Me.lblDiscountAmount.Text = "Discount amount: "
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(26, 132)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(68, 16)
        Me.lblStateTax.TabIndex = 10
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblCityTax
        '
        Me.lblCityTax.AutoSize = True
        Me.lblCityTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityTax.Location = New System.Drawing.Point(26, 155)
        Me.lblCityTax.Name = "lblCityTax"
        Me.lblCityTax.Size = New System.Drawing.Size(59, 16)
        Me.lblCityTax.TabIndex = 12
        Me.lblCityTax.Text = "City Tax:"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(26, 178)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(89, 16)
        Me.lblTotalAmount.TabIndex = 14
        Me.lblTotalAmount.Text = "Total amount:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(26, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 16)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblkWhUsed
        '
        Me.lblkWhUsed.AutoSize = True
        Me.lblkWhUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkWhUsed.Location = New System.Drawing.Point(26, 45)
        Me.lblkWhUsed.Name = "lblkWhUsed"
        Me.lblkWhUsed.Size = New System.Drawing.Size(74, 16)
        Me.lblkWhUsed.TabIndex = 5
        Me.lblkWhUsed.Text = "kWh Used:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(144, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(115, 22)
        Me.txtName.TabIndex = 0
        '
        'txtkWhUsed
        '
        Me.txtkWhUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkWhUsed.Location = New System.Drawing.Point(144, 45)
        Me.txtkWhUsed.Name = "txtkWhUsed"
        Me.txtkWhUsed.Size = New System.Drawing.Size(115, 22)
        Me.txtkWhUsed.TabIndex = 1
        '
        'lblOutputBaseAmount
        '
        Me.lblOutputBaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputBaseAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputBaseAmount.Location = New System.Drawing.Point(144, 85)
        Me.lblOutputBaseAmount.Name = "lblOutputBaseAmount"
        Me.lblOutputBaseAmount.Size = New System.Drawing.Size(115, 23)
        Me.lblOutputBaseAmount.TabIndex = 7
        Me.lblOutputBaseAmount.Text = " "
        '
        'lblOutputDiscountAmount
        '
        Me.lblOutputDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputDiscountAmount.Location = New System.Drawing.Point(144, 109)
        Me.lblOutputDiscountAmount.Name = "lblOutputDiscountAmount"
        Me.lblOutputDiscountAmount.Size = New System.Drawing.Size(115, 23)
        Me.lblOutputDiscountAmount.TabIndex = 9
        Me.lblOutputDiscountAmount.Text = " "
        '
        'lblOutputStateTax
        '
        Me.lblOutputStateTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputStateTax.Location = New System.Drawing.Point(144, 132)
        Me.lblOutputStateTax.Name = "lblOutputStateTax"
        Me.lblOutputStateTax.Size = New System.Drawing.Size(115, 23)
        Me.lblOutputStateTax.TabIndex = 11
        Me.lblOutputStateTax.Text = " "
        '
        'lblOutputCityTax
        '
        Me.lblOutputCityTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputCityTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputCityTax.Location = New System.Drawing.Point(144, 155)
        Me.lblOutputCityTax.Name = "lblOutputCityTax"
        Me.lblOutputCityTax.Size = New System.Drawing.Size(115, 23)
        Me.lblOutputCityTax.TabIndex = 13
        Me.lblOutputCityTax.Text = " "
        '
        'lblOutputTotalAmount
        '
        Me.lblOutputTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputTotalAmount.Location = New System.Drawing.Point(144, 178)
        Me.lblOutputTotalAmount.Name = "lblOutputTotalAmount"
        Me.lblOutputTotalAmount.Size = New System.Drawing.Size(115, 23)
        Me.lblOutputTotalAmount.TabIndex = 15
        Me.lblOutputTotalAmount.Text = " "
        '
        'cmdCompute
        '
        Me.cmdCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.Location = New System.Drawing.Point(29, 227)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(75, 23)
        Me.cmdCompute.TabIndex = 2
        Me.cmdCompute.Text = "&Compute"
        Me.cmdCompute.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.Location = New System.Drawing.Point(184, 227)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuit.TabIndex = 3
        Me.cmdQuit.Text = "&Quit"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.lblOutputTotalAmount)
        Me.Controls.Add(Me.lblOutputCityTax)
        Me.Controls.Add(Me.lblOutputStateTax)
        Me.Controls.Add(Me.lblOutputDiscountAmount)
        Me.Controls.Add(Me.lblOutputBaseAmount)
        Me.Controls.Add(Me.txtkWhUsed)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblkWhUsed)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblCityTax)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblDiscountAmount)
        Me.Controls.Add(Me.lblBaseAmount)
        Me.Name = "frmMain"
        Me.Text = " Municipal Power & Light"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBaseAmount As Label
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblCityTax As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblkWhUsed As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtkWhUsed As TextBox
    Friend WithEvents lblOutputBaseAmount As Label
    Friend WithEvents lblOutputDiscountAmount As Label
    Friend WithEvents lblOutputStateTax As Label
    Friend WithEvents lblOutputCityTax As Label
    Friend WithEvents lblOutputTotalAmount As Label
    Friend WithEvents cmdCompute As Button
    Friend WithEvents cmdQuit As Button
End Class
