Public Class funcAlert
    Public Sub success(ByVal msg As String)
        successAlert.msg = msg
        successAlert.Show()
    End Sub
    Public Sub warning(ByVal msg As String)
        warningAlert.msg = msg
        warningAlert.Show()
    End Sub
    Public Sub danger(ByVal msg As String)
        dangerAlert.msg = msg
        dangerAlert.Show()
    End Sub
    Public Function question(ByVal msg As String) As Boolean
        Dim questionAlert = New questionAlert

        questionAlert.msg = msg
        If questionAlert.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim textBoxValue As String = questionAlert.Button1.Text
            If textBoxValue Is "Sim" Then
                Return True
            End If
        Else
            Return False
        End If
    End Function
    Public Function inputText(ByVal msg As String) As String
        Dim input = New textInputAlert

        input.msg = msg
        If input.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim textBoxValue As String = input.Button1.Text
            Return textBoxValue
        End If
    End Function
End Class

