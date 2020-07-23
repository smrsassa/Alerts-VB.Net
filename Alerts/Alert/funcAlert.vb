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
        End If
    End Function
End Class

