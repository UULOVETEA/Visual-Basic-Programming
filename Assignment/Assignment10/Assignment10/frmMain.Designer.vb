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
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblSearchName = New System.Windows.Forms.Label()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEnter
        '
        Me.cmdEnter.Location = New System.Drawing.Point(12, 226)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnter.TabIndex = 0
        Me.cmdEnter.Text = "&Enter"
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(105, 226)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 3
        Me.cmdReset.Text = "&Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Location = New System.Drawing.Point(197, 226)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuit.TabIndex = 4
        Me.cmdQuit.Text = "&Quit"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'lblInstruction
        '
        Me.lblInstruction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInstruction.Location = New System.Drawing.Point(12, 9)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(260, 74)
        Me.lblInstruction.TabIndex = 5
        Me.lblInstruction.Text = "Click the enter button to enter names, please do not enter same names twice."
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchName
        '
        Me.lblSearchName.AutoSize = True
        Me.lblSearchName.Location = New System.Drawing.Point(12, 103)
        Me.lblSearchName.Name = "lblSearchName"
        Me.lblSearchName.Size = New System.Drawing.Size(110, 13)
        Me.lblSearchName.TabIndex = 6
        Me.lblSearchName.Text = "Name search in array:"
        Me.lblSearchName.Visible = False
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(172, 100)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchName.TabIndex = 1
        Me.txtSearchName.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(105, 132)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        Me.cmdSearch.Visible = False
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 167)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(260, 47)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Enter a name into the text box and click the search button to search in the array" &
    "."
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.lblSearchName)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdEnter)
        Me.Name = "frmMain"
        Me.Text = "Enter and search name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEnter As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdQuit As Button
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblSearchName As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents lblResult As Label
End Class
