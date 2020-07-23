Public Class testAlert
    Private alert As New funcAlert
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_success.Click
        alert.showAlert("success", "Atualizado com sucesso")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        alert.showAlert("warning", "Atualizado com sucesso")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        alert.showAlert("danger", "Atualizado com sucesso")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("teste")
    End Sub
End Class