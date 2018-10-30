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
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblNumeriGrade = New System.Windows.Forms.Label()
        Me.txtNumericGrade = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConvert
        '
        Me.cmdConvert.Location = New System.Drawing.Point(33, 226)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(75, 23)
        Me.cmdConvert.TabIndex = 2
        Me.cmdConvert.Text = "&Convert"
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(183, 226)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(33, 93)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(225, 117)
        Me.lblOutput.TabIndex = 6
        '
        'lblNumeriGrade
        '
        Me.lblNumeriGrade.AutoSize = True
        Me.lblNumeriGrade.Location = New System.Drawing.Point(30, 59)
        Me.lblNumeriGrade.Name = "lblNumeriGrade"
        Me.lblNumeriGrade.Size = New System.Drawing.Size(78, 13)
        Me.lblNumeriGrade.TabIndex = 5
        Me.lblNumeriGrade.Text = "Numeric Grade"
        '
        'txtNumericGrade
        '
        Me.txtNumericGrade.Location = New System.Drawing.Point(158, 56)
        Me.txtNumericGrade.Name = "txtNumericGrade"
        Me.txtNumericGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade.TabIndex = 1
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(158, 18)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse.TabIndex = 0
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(30, 21)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(71, 13)
        Me.lblCourse.TabIndex = 4
        Me.lblCourse.Text = "Course Name"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.txtNumericGrade)
        Me.Controls.Add(Me.lblNumeriGrade)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdConvert)
        Me.Name = "frmMain"
        Me.Text = "Grade & Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdConvert As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblNumeriGrade As Label
    Friend WithEvents txtNumericGrade As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblCourse As Label
End Class
