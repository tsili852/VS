Public Class frmMain

    Private WithEvents m_cn As New Counter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        m_cn.CountAsync(100)
    End Sub

    Private Sub m_cn_CountChanged(ByVal sender As Object, ByVal e As CountChangedEventArgs) Handles m_cn.CountChanged
        Label1.Text = CStr(e.CurrentCount)
    End Sub

    Private Sub m_cn_CountCompleted(ByVal sender As Object, ByVal e As CountCompletedEventArgs) Handles m_cn.CountCompleted
        MsgBox(e.Message)
    End Sub
End Class