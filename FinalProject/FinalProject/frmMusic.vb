Public Class frmMusic
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class