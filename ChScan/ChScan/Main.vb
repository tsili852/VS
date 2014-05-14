Imports System.Windows.Forms

Public Class FrmMain

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim foo As MsgBoxResult
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then
            foo = MsgBox("Application is already running", vbCritical)
            End
        End If
        readerini = "C:\NDPWork\HSBC\SOURCE_NDP" + "\READER.INI"
        endorseini = "C:\NDPWork\HSBC\SOURCE_NDP" + "\ENDORSE.INI"
        carSetupini = "C:\NDPWork\HSBC\SOURCE_NDP" + "\IMAGE.INI"

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

    Private Sub quitBtn_Click(sender As Object, e As EventArgs)
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutFrm As AboutFrm = New AboutFrm
        aboutFrm.Owner = Me
        aboutFrm.MdiParent = Me
        aboutFrm.StartPosition = FormStartPosition.CenterScreen
        aboutFrm.Show()
    End Sub

    Private Sub OrdinaryChecksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrdinaryChecksToolStripMenuItem1.Click
        FrmScan.Show()
    End Sub

    Private Sub TSBtnExit_Click(sender As Object, e As EventArgs) Handles TSBtnExit.Click
        End
    End Sub

    Private Sub TSBtnScan_Click(sender As Object, e As EventArgs) Handles TSBtnScan.Click
        OrdinaryChecksToolStripMenuItem1.PerformClick()
    End Sub
End Class
