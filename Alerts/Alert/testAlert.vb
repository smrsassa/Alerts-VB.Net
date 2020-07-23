Public Class testAlert
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alert As New funcAlert

        alert.showAlert("Atualizado com sucesso")
    End Sub
End Class