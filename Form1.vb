Public Class Form1
    Private Sub BTN_START_Click(sender As Object, e As EventArgs) Handles BTN_START.Click
        Call STARTER()
    End Sub

    Private Sub KILL_SWITCH_Click(sender As Object, e As EventArgs) Handles KILL_SWITCH.Click
        Call SHUT_DOWN()
    End Sub
    Private Sub LOCK_UNLOCK_Click(sender As Object, e As EventArgs) Handles LOCK_UNLOCK.Click
        Call UNLOCKER
    End Sub
    Private Sub LOCK_TEXT_KeyPress(sender As Object, e As KeyEventArgs) Handles LOCK_TEXT.KeyDown
        If e.KeyCode = Keys.Return Then
            Call UNLOCKER()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
