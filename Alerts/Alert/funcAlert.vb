Public Class funcAlert
    Function showAlert(alert As String, msg As String)
        If alert = "success" Then
            successAlert.msg = msg
            successAlert.Show()
        ElseIf alert = "warning" Then
            warningAlert.msg = msg
            warningAlert.Show()
        ElseIf alert = "danger" Then
            dangerAlert.msg = msg
            dangerAlert.Show()
        ElseIf alert = "question" Then
            Dim question = New questionAlert

            question.msg = msg
            If question.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim textBoxValue As String = question.Button1.Text
                If textBoxValue Is "Sim" Then
                    Return True
                End If
            Else
                Return False
            End If
        ElseIf alert = "input" Then
            Dim input = New textInputAlert

            input.msg = msg
            If input.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim textBoxValue As String = input.Button1.Text
                Return textBoxValue
            End If
        End If
    End Function
End Class

