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
        Me.btnSuccess = New System.Windows.Forms.Button()
        Me.btnWarning = New System.Windows.Forms.Button()
        Me.btnDanger = New System.Windows.Forms.Button()
        Me.btnPadrao = New System.Windows.Forms.Button()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnInptTexto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuccess
        '
        Me.btnSuccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuccess.ForeColor = System.Drawing.Color.White
        Me.btnSuccess.Location = New System.Drawing.Point(206, 34)
        Me.btnSuccess.Name = "btnSuccess"
        Me.btnSuccess.Size = New System.Drawing.Size(132, 47)
        Me.btnSuccess.TabIndex = 0
        Me.btnSuccess.Text = "Success"
        Me.btnSuccess.UseVisualStyleBackColor = False
        '
        'btnWarning
        '
        Me.btnWarning.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWarning.ForeColor = System.Drawing.Color.White
        Me.btnWarning.Location = New System.Drawing.Point(206, 113)
        Me.btnWarning.Name = "btnWarning"
        Me.btnWarning.Size = New System.Drawing.Size(132, 47)
        Me.btnWarning.TabIndex = 1
        Me.btnWarning.Text = "Warning"
        Me.btnWarning.UseVisualStyleBackColor = False
        '
        'btnDanger
        '
        Me.btnDanger.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDanger.ForeColor = System.Drawing.Color.White
        Me.btnDanger.Location = New System.Drawing.Point(30, 113)
        Me.btnDanger.Name = "btnDanger"
        Me.btnDanger.Size = New System.Drawing.Size(132, 47)
        Me.btnDanger.TabIndex = 2
        Me.btnDanger.Text = "Danger"
        Me.btnDanger.UseVisualStyleBackColor = False
        '
        'btnPadrao
        '
        Me.btnPadrao.Location = New System.Drawing.Point(30, 34)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(132, 47)
        Me.btnPadrao.TabIndex = 3
        Me.btnPadrao.Text = "Alerta Padrão"
        Me.btnPadrao.UseVisualStyleBackColor = True
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
        Me.btnQuestion.Text = "Question"
        Me.btnQuestion.UseVisualStyleBackColor = False
        '
        'btnInptTexto
        '
        Me.btnInptTexto.Location = New System.Drawing.Point(206, 187)
        Me.btnInptTexto.Name = "btnInptTexto"
        Me.btnInptTexto.Size = New System.Drawing.Size(132, 47)
        Me.btnInptTexto.TabIndex = 5
        Me.btnInptTexto.Text = "Input de texto"
        Me.btnInptTexto.UseVisualStyleBackColor = True
        '
        'testAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 267)
        Me.Controls.Add(Me.btnInptTexto)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.btnPadrao)
        Me.Controls.Add(Me.btnDanger)
        Me.Controls.Add(Me.btnWarning)
        Me.Controls.Add(Me.btnSuccess)
        Me.Name = "testAlert"
        Me.Text = "testAlert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSuccess As Button
    Friend WithEvents btnWarning As Button
    Friend WithEvents btnDanger As Button
    Friend WithEvents btnPadrao As Button
    Friend WithEvents btnQuestion As Button
    Friend WithEvents btnInptTexto As Button
End Class
