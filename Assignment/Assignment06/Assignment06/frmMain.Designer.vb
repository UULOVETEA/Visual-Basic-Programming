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
        Me.cmdComplete = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblTotalOccupied = New System.Windows.Forms.Label()
        Me.lblOverallRate = New System.Windows.Forms.Label()
        Me.lblOutputTotalOccupied = New System.Windows.Forms.Label()
        Me.lblOutputOverallRate = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdComplete
        '
        Me.cmdComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComplete.Location = New System.Drawing.Point(11, 428)
        Me.cmdComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdComplete.Name = "cmdComplete"
        Me.cmdComplete.Size = New System.Drawing.Size(75, 23)
        Me.cmdComplete.TabIndex = 0
        Me.cmdComplete.Text = "&Complete"
        Me.cmdComplete.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(152, 428)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 1
        Me.cmdClear.Text = "Clea&r"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(298, 428)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblTotalOccupied
        '
        Me.lblTotalOccupied.AutoSize = True
        Me.lblTotalOccupied.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOccupied.Location = New System.Drawing.Point(51, 355)
        Me.lblTotalOccupied.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalOccupied.Name = "lblTotalOccupied"
        Me.lblTotalOccupied.Size = New System.Drawing.Size(147, 16)
        Me.lblTotalOccupied.TabIndex = 4
        Me.lblTotalOccupied.Text = "Total Rooms Occuoied"
        '
        'lblOverallRate
        '
        Me.lblOverallRate.AutoSize = True
        Me.lblOverallRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallRate.Location = New System.Drawing.Point(52, 388)
        Me.lblOverallRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOverallRate.Name = "lblOverallRate"
        Me.lblOverallRate.Size = New System.Drawing.Size(146, 16)
        Me.lblOverallRate.TabIndex = 6
        Me.lblOverallRate.Text = "Overall occupancy rate"
        '
        'lblOutputTotalOccupied
        '
        Me.lblOutputTotalOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTotalOccupied.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputTotalOccupied.Location = New System.Drawing.Point(222, 354)
        Me.lblOutputTotalOccupied.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutputTotalOccupied.Name = "lblOutputTotalOccupied"
        Me.lblOutputTotalOccupied.Size = New System.Drawing.Size(75, 23)
        Me.lblOutputTotalOccupied.TabIndex = 5
        '
        'lblOutputOverallRate
        '
        Me.lblOutputOverallRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputOverallRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputOverallRate.Location = New System.Drawing.Point(222, 387)
        Me.lblOutputOverallRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutputOverallRate.Name = "lblOutputOverallRate"
        Me.lblOutputOverallRate.Size = New System.Drawing.Size(75, 23)
        Me.lblOutputOverallRate.TabIndex = 7
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 16
        Me.lstOutput.Location = New System.Drawing.Point(12, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(361, 308)
        Me.lstOutput.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 462)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblOutputOverallRate)
        Me.Controls.Add(Me.lblOutputTotalOccupied)
        Me.Controls.Add(Me.lblOverallRate)
        Me.Controls.Add(Me.lblTotalOccupied)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdComplete)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Hotel Occupancy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdComplete As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblTotalOccupied As Label
    Friend WithEvents lblOverallRate As Label
    Friend WithEvents lblOutputTotalOccupied As Label
    Friend WithEvents lblOutputOverallRate As Label
    Friend WithEvents lstOutput As ListBox
End Class
