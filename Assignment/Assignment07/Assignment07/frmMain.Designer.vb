﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(12, 9)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(260, 201)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "Welcome to grading system!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click start button to start enter student's grades"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(12, 227)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "&Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(197, 227)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "frmMain"
        Me.Text = "Grading System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdExit As Button
End Class
