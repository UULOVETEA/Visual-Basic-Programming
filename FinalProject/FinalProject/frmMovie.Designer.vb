<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnuMoiveForm = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewMoive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateMoive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteMoive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveMoive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewActor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteActor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateActor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloseMoive = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstMoive = New System.Windows.Forms.ListBox()
        Me.lstActor = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblReleaseYear = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.txtReleaseYear = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.cboRating = New System.Windows.Forms.ComboBox()
        Me.mnuMoiveForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMoiveForm
        '
        Me.mnuMoiveForm.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.mnuMoiveForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMoive, Me.mnuActor, Me.mnuCloseMoive})
        Me.mnuMoiveForm.Location = New System.Drawing.Point(0, 0)
        Me.mnuMoiveForm.Name = "mnuMoiveForm"
        Me.mnuMoiveForm.Size = New System.Drawing.Size(524, 24)
        Me.mnuMoiveForm.TabIndex = 10
        Me.mnuMoiveForm.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSaveFile, Me.mnuLoadFile})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.Size = New System.Drawing.Size(152, 22)
        Me.mnuSaveFile.Text = "Save"
        '
        'mnuLoadFile
        '
        Me.mnuLoadFile.Name = "mnuLoadFile"
        Me.mnuLoadFile.Size = New System.Drawing.Size(152, 22)
        Me.mnuLoadFile.Text = "Load"
        '
        'mnuMoive
        '
        Me.mnuMoive.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewMoive, Me.mnuUpdateMoive, Me.mnuDeleteMoive, Me.mnuSaveMoive})
        Me.mnuMoive.Name = "mnuMoive"
        Me.mnuMoive.Size = New System.Drawing.Size(52, 20)
        Me.mnuMoive.Text = "&Movie"
        '
        'mnuNewMoive
        '
        Me.mnuNewMoive.Name = "mnuNewMoive"
        Me.mnuNewMoive.Size = New System.Drawing.Size(112, 22)
        Me.mnuNewMoive.Text = "New"
        '
        'mnuUpdateMoive
        '
        Me.mnuUpdateMoive.Name = "mnuUpdateMoive"
        Me.mnuUpdateMoive.Size = New System.Drawing.Size(112, 22)
        Me.mnuUpdateMoive.Text = "Update"
        '
        'mnuDeleteMoive
        '
        Me.mnuDeleteMoive.Name = "mnuDeleteMoive"
        Me.mnuDeleteMoive.Size = New System.Drawing.Size(112, 22)
        Me.mnuDeleteMoive.Text = "Delete"
        '
        'mnuSaveMoive
        '
        Me.mnuSaveMoive.Name = "mnuSaveMoive"
        Me.mnuSaveMoive.Size = New System.Drawing.Size(112, 22)
        Me.mnuSaveMoive.Text = "Save"
        '
        'mnuActor
        '
        Me.mnuActor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewActor, Me.mnuDeleteActor, Me.mnuUpdateActor})
        Me.mnuActor.Name = "mnuActor"
        Me.mnuActor.Size = New System.Drawing.Size(91, 20)
        Me.mnuActor.Text = "&Actor/Actress"
        '
        'mnuNewActor
        '
        Me.mnuNewActor.Name = "mnuNewActor"
        Me.mnuNewActor.Size = New System.Drawing.Size(112, 22)
        Me.mnuNewActor.Text = "New"
        '
        'mnuDeleteActor
        '
        Me.mnuDeleteActor.Name = "mnuDeleteActor"
        Me.mnuDeleteActor.Size = New System.Drawing.Size(112, 22)
        Me.mnuDeleteActor.Text = "Delete"
        '
        'mnuUpdateActor
        '
        Me.mnuUpdateActor.Name = "mnuUpdateActor"
        Me.mnuUpdateActor.Size = New System.Drawing.Size(112, 22)
        Me.mnuUpdateActor.Text = "Update"
        '
        'mnuCloseMoive
        '
        Me.mnuCloseMoive.Name = "mnuCloseMoive"
        Me.mnuCloseMoive.Size = New System.Drawing.Size(48, 20)
        Me.mnuCloseMoive.Text = "&Close"
        '
        'lstMoive
        '
        Me.lstMoive.FormattingEnabled = True
        Me.lstMoive.Location = New System.Drawing.Point(12, 49)
        Me.lstMoive.Name = "lstMoive"
        Me.lstMoive.Size = New System.Drawing.Size(125, 121)
        Me.lstMoive.TabIndex = 4
        '
        'lstActor
        '
        Me.lstActor.FormattingEnabled = True
        Me.lstActor.Location = New System.Drawing.Point(387, 49)
        Me.lstActor.Name = "lstActor"
        Me.lstActor.Size = New System.Drawing.Size(125, 121)
        Me.lstActor.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(152, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Title"
        '
        'lblReleaseYear
        '
        Me.lblReleaseYear.AutoSize = True
        Me.lblReleaseYear.Location = New System.Drawing.Point(152, 91)
        Me.lblReleaseYear.Name = "lblReleaseYear"
        Me.lblReleaseYear.Size = New System.Drawing.Size(71, 13)
        Me.lblReleaseYear.TabIndex = 7
        Me.lblReleaseYear.Text = "Release Year"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(152, 123)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(85, 13)
        Me.lblLength.TabIndex = 8
        Me.lblLength.Text = "Length (minutes)"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(152, 152)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(38, 13)
        Me.lblRating.TabIndex = 9
        Me.lblRating.Text = "Rating"
        '
        'txtReleaseYear
        '
        Me.txtReleaseYear.Enabled = False
        Me.txtReleaseYear.Location = New System.Drawing.Point(240, 88)
        Me.txtReleaseYear.Name = "txtReleaseYear"
        Me.txtReleaseYear.Size = New System.Drawing.Size(120, 20)
        Me.txtReleaseYear.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(240, 52)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(120, 20)
        Me.txtTitle.TabIndex = 0
        '
        'txtLength
        '
        Me.txtLength.Enabled = False
        Me.txtLength.Location = New System.Drawing.Point(240, 120)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(120, 20)
        Me.txtLength.TabIndex = 2
        '
        'cboRating
        '
        Me.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRating.DropDownWidth = 200
        Me.cboRating.Enabled = False
        Me.cboRating.FormattingEnabled = True
        Me.cboRating.Location = New System.Drawing.Point(240, 149)
        Me.cboRating.Name = "cboRating"
        Me.cboRating.Size = New System.Drawing.Size(121, 21)
        Me.cboRating.TabIndex = 3
        '
        'frmMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 182)
        Me.Controls.Add(Me.cboRating)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtReleaseYear)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblReleaseYear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstActor)
        Me.Controls.Add(Me.lstMoive)
        Me.Controls.Add(Me.mnuMoiveForm)
        Me.MainMenuStrip = Me.mnuMoiveForm
        Me.Name = "frmMovie"
        Me.Text = "frmMoive"
        Me.mnuMoiveForm.ResumeLayout(False)
        Me.mnuMoiveForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMoiveForm As MenuStrip
    Friend WithEvents mnuMoive As ToolStripMenuItem
    Friend WithEvents mnuNewMoive As ToolStripMenuItem
    Friend WithEvents mnuUpdateMoive As ToolStripMenuItem
    Friend WithEvents mnuDeleteMoive As ToolStripMenuItem
    Friend WithEvents mnuSaveMoive As ToolStripMenuItem
    Friend WithEvents mnuActor As ToolStripMenuItem
    Friend WithEvents mnuNewActor As ToolStripMenuItem
    Friend WithEvents mnuDeleteActor As ToolStripMenuItem
    Friend WithEvents mnuUpdateActor As ToolStripMenuItem
    Friend WithEvents mnuCloseMoive As ToolStripMenuItem
    Friend WithEvents lstMoive As ListBox
    Friend WithEvents lstActor As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblReleaseYear As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents txtReleaseYear As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents cboRating As ComboBox
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuSaveFile As ToolStripMenuItem
    Friend WithEvents mnuLoadFile As ToolStripMenuItem
End Class
