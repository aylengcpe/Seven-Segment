Public Class Form1
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If monitor.Text <= 8 Then
            monitor.Text = monitor.Text + 1

        End If
    End Sub
End Class
