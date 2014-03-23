Imports System.Windows.Forms

Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim currentHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        If currentWidth < 1280 Then
            Me.Size = New System.Drawing.Size(currentWidth, currentHeight)
        ElseIf currentWidth > 1280 Then
            Me.Size = New System.Drawing.Size(1280, 800)
            Me.WindowState = FormWindowState.Normal
        ElseIf currentWidth = 1280 Then
            Me.Size = New System.Drawing.Size(1280, 800)
            Me.WindowState = FormWindowState.Maximized
        End If

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
