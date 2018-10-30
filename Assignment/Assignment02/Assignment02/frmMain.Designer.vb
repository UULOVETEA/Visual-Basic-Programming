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
        Me.lblOriginalPrice = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.cmdCalc = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.lblOutputTax = New System.Windows.Forms.Label()
        Me.lblOutputFinalPrice = New System.Windows.Forms.Label()
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.lblDiscountPrice = New System.Windows.Forms.Label()
        Me.lblOutputDiscountPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOriginalPrice
        '
        Me.lblOriginalPrice.AutoSize = True
        Me.lblOriginalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalPrice.Location = New System.Drawing.Point(11, 24)
        Me.lblOriginalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOriginalPrice.Name = "lblOriginalPrice"
        Me.lblOriginalPrice.Size = New System.Drawing.Size(128, 24)
        Me.lblOriginalPrice.TabIndex = 4
        Me.lblOriginalPrice.Text = "Original Price:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(11, 120)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(47, 24)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "Tax:"
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalPrice.Location = New System.Drawing.Point(11, 168)
        Me.lblFinalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(104, 24)
        Me.lblFinalPrice.TabIndex = 9
        Me.lblFinalPrice.Text = "Final Price:"
        '
        'cmdCalc
        '
        Me.cmdCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalc.Location = New System.Drawing.Point(11, 221)
        Me.cmdCalc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(75, 30)
        Me.cmdCalc.TabIndex = 1
        Me.cmdCalc.Text = "&Calculate"
        Me.cmdCalc.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(104, 221)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 30)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "Clea&r"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.Location = New System.Drawing.Point(198, 221)
        Me.cmdQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(75, 30)
        Me.cmdQuit.TabIndex = 3
        Me.cmdQuit.Text = "&Quit"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'lblOutputTax
        '
        Me.lblOutputTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputTax.Location = New System.Drawing.Point(173, 120)
        Me.lblOutputTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutputTax.Name = "lblOutputTax"
        Me.lblOutputTax.Size = New System.Drawing.Size(100, 25)
        Me.lblOutputTax.TabIndex = 8
        '
        'lblOutputFinalPrice
        '
        Me.lblOutputFinalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputFinalPrice.Location = New System.Drawing.Point(173, 168)
        Me.lblOutputFinalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutputFinalPrice.Name = "lblOutputFinalPrice"
        Me.lblOutputFinalPrice.Size = New System.Drawing.Size(100, 25)
        Me.lblOutputFinalPrice.TabIndex = 10
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalPrice.Location = New System.Drawing.Point(173, 24)
        Me.txtOriginalPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtOriginalPrice.TabIndex = 0
        '
        'lblDiscountPrice
        '
        Me.lblDiscountPrice.AutoSize = True
        Me.lblDiscountPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountPrice.Location = New System.Drawing.Point(11, 72)
        Me.lblDiscountPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiscountPrice.Name = "lblDiscountPrice"
        Me.lblDiscountPrice.Size = New System.Drawing.Size(136, 24)
        Me.lblDiscountPrice.TabIndex = 5
        Me.lblDiscountPrice.Text = "Discount Price:"
        '
        'lblOutputDiscountPrice
        '
        Me.lblOutputDiscountPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputDiscountPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputDiscountPrice.Location = New System.Drawing.Point(173, 72)
        Me.lblOutputDiscountPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutputDiscountPrice.Name = "lblOutputDiscountPrice"
        Me.lblOutputDiscountPrice.Size = New System.Drawing.Size(100, 25)
        Me.lblOutputDiscountPrice.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblOutputDiscountPrice)
        Me.Controls.Add(Me.lblDiscountPrice)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Controls.Add(Me.lblOutputFinalPrice)
        Me.Controls.Add(Me.lblOutputTax)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdCalc)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblOriginalPrice)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "Sales Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOriginalPrice As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents cmdCalc As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdQuit As Button
    Friend WithEvents lblOutputTax As Label
    Friend WithEvents lblOutputFinalPrice As Label
    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents lblDiscountPrice As Label
    Friend WithEvents lblOutputDiscountPrice As Label
End Class
