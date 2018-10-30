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
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optMoive = New System.Windows.Forms.RadioButton()
        Me.optMusic = New System.Windows.Forms.RadioButton()
        Me.mnuMainForm = New System.Windows.Forms.MenuStrip()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.mnuMainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(46, 182)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelect.TabIndex = 0
        Me.cmdSelect.Text = "&Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(171, 182)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optMoive)
        Me.GroupBox1.Controls.Add(Me.optMusic)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 88)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Media Choices"
        '
        'optMoive
        '
        Me.optMoive.AutoSize = True
        Me.optMoive.Location = New System.Drawing.Point(125, 36)
        Me.optMoive.Name = "optMoive"
        Me.optMoive.Size = New System.Drawing.Size(54, 17)
        Me.optMoive.TabIndex = 1
        Me.optMoive.TabStop = True
        Me.optMoive.Text = "Moive"
        Me.optMoive.UseVisualStyleBackColor = True
        '
        'optMusic
        '
        Me.optMusic.AutoSize = True
        Me.optMusic.Location = New System.Drawing.Point(27, 36)
        Me.optMusic.Name = "optMusic"
        Me.optMusic.Size = New System.Drawing.Size(53, 17)
        Me.optMusic.TabIndex = 0
        Me.optMusic.TabStop = True
        Me.optMusic.Text = "Music"
        Me.optMusic.UseVisualStyleBackColor = True
        '
        'mnuMainForm
        '
        Me.mnuMainForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuExit})
        Me.mnuMainForm.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainForm.Name = "mnuMainForm"
        Me.mnuMainForm.Size = New System.Drawing.Size(284, 24)
        Me.mnuMainForm.TabIndex = 3
        Me.mnuMainForm.Text = "MenuStrip1"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "&About"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "&Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.mnuMainForm)
        Me.MainMenuStrip = Me.mnuMainForm
        Me.Name = "frmMain"
        Me.Text = "Media Library"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnuMainForm.ResumeLayout(False)
        Me.mnuMainForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSelect As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optMoive As RadioButton
    Friend WithEvents optMusic As RadioButton
    Friend WithEvents mnuMainForm As MenuStrip
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
