Public Class Form1

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("If a room has a Motion Sensor tick the Orange Box, If a room has a Transit Senor connecting two rooms tick the blue box.")
    End Sub

    Private Sub btnProcced_Click(sender As Object, e As EventArgs) Handles btnProcced.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
