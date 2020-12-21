Public Class testAlert
    Private alert As New funcAlert
    Private Sub btn_success_click(sender As Object, e As EventArgs) Handles btnSuccess.Click
        alert.success("Success")
    End Sub
    Private Sub btn_warning_click(sender As Object, e As EventArgs) Handles btnWarning.Click
        alert.warning("Warning")
    End Sub
    Private Sub btn_danger_click(sender As Object, e As EventArgs) Handles btnDanger.Click
        alert.danger("Danger")
    End Sub
    Private Sub btn_padrao_click(sender As Object, e As EventArgs) Handles btnPadrao.Click
        MsgBox("teste")
    End Sub
    Private Sub btn_question_click(sender As Object, e As EventArgs) Handles btnQuestion.Click
        If alert.question("Testando...") Then
            alert.success("Sim")
        Else
            alert.danger("Não")
        End If
    End Sub
    Private Sub btn_input_texto_click(sender As Object, e As EventArgs) Handles btnInptTexto.Click
        Dim resposta = alert.inputText("Qual seu nome?")
        alert.warning(resposta)
    End Sub
End Class