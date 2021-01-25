Public Class Form1
    Private Sub CmdTest_Click(sender As Object, e As EventArgs) Handles CmdTest.Click
        MessageBox.Show("Test")
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
End Class
