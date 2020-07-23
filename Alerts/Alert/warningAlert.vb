Public Class warningAlert
    Public msg As String
    Private Sub warningAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label.Text = msg
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Close()
    End Sub
End Class