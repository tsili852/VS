Imports System.Windows.Forms

Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ScanBtn.ImageScaling = ToolStripItemImageScaling.None
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutFrm As AboutFrm = New AboutFrm
        aboutFrm.Owner = Me
        aboutFrm.MdiParent = Me
        aboutFrm.StartPosition = FormStartPosition.CenterScreen
        aboutFrm.Show()
    End Sub
End Class
