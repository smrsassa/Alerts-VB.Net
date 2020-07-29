<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testAlert
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_success = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_success
        '
        Me.btn_success.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_success.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_success.ForeColor = System.Drawing.Color.White
        Me.btn_success.Location = New System.Drawing.Point(30, 27)
        Me.btn_success.Name = "btn_success"
        Me.btn_success.Size = New System.Drawing.Size(132, 47)
        Me.btn_success.TabIndex = 0
        Me.btn_success.Text = "Success"
        Me.btn_success.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(206, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Warning"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(30, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Danger"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(206, 113)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Alerta Padrão"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnQuestion
        '
        Me.btnQuestion.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuestion.ForeColor = System.Drawing.Color.White
        Me.btnQuestion.Location = New System.Drawing.Point(30, 187)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(132, 47)
        Me.btnQuestion.TabIndex = 4
        Me.btnQuestion.Text = "Danger"
        Me.btnQuestion.UseVisualStyleBackColor = False
        '
        'testAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 267)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_success)
        Me.Name = "testAlert"
        Me.Text = "testAlert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_success As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnQuestion As Button
End Class
