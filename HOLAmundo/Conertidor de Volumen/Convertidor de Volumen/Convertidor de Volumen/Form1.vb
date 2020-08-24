Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Metro cubito" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) * 35.315
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) * 220
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) * 880
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) * 1760
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) * 3520
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 35195
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 56312
        ElseIf cbxentrada.Text = "Metro cubico" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) * 1000
        End If

        If cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 35.315
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 28317
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) * 6.229
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) * 24.915
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) * 49.831
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) * 99.661
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 997
        ElseIf cbxentrada.Text = "Pie cubica" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 1595
        ElseIf cbxentrada.Text = "Pie cubico" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) * 28.317
        End If

        If cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 28317
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 4546
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) / 1137
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) / 568
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) / 284
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) / 28.413
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) / 17.758
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) / 1000
        End If

        If cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 220
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 6.229
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 4546
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) * 4
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) * 8
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) * 16
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 160
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 256
        ElseIf cbxentrada.Text = "Galon imperial" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) * 4.546
        End If

        If cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 880
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 24.915
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 1137
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 4
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) * 2
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) * 4
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 40
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 64
        ElseIf cbxentrada.Text = "Cuarto imperial" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) * 1.137
        End If

        If cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 1760
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 49.831
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 568
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 8
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) / 2
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) * 2
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 20
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 32
        ElseIf cbxentrada.Text = "Pinta imperial" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) / 1.76
        End If

        If cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 3520
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 3520
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 284
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 16
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) / 4
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) / 2
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 10
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 16
        ElseIf cbxentrada.Text = "Taza imperial" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) / 3.52
        End If

        If cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 35195
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 997
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 28.413
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 160
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) / 40
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) / 20
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) / 10
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 1.6
        ElseIf cbxentrada.Text = "Onza liquida imperial" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) / 35.195
        End If

        If cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 56312
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 1595
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 17.758
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 256
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) / 64
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) / 32
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) / 16
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) / 1.6
        ElseIf cbxentrada.Text = "Cucharada imperial" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text) / 56.312
        End If

        If cbxentrada.Text = "Litro" And cbxsalidad.Text = "Litro" Then
            lblr.Text = Val(txtValor.Text)
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Metro cubico" Then
            lblr.Text = Val(txtValor.Text) / 1000
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Pie cubico" Then
            lblr.Text = Val(txtValor.Text) / 28.317
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Mililitro" Then
            lblr.Text = Val(txtValor.Text) * 1000
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Galon imperial" Then
            lblr.Text = Val(txtValor.Text) / 4.546
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Cuarto imperial" Then
            lblr.Text = Val(txtValor.Text) / 1.137
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Pinta imperial" Then
            lblr.Text = Val(txtValor.Text) * 1.76
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Taza imperial" Then
            lblr.Text = Val(txtValor.Text) * 3.52
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Onza liquida imperial" Then
            lblr.Text = Val(txtValor.Text) * 35.195
        ElseIf cbxentrada.Text = "Litro" And cbxsalidad.Text = "Cucharada imperial" Then
            lblr.Text = Val(txtValor.Text) * 56.312
        End If

    End Sub

    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click

        lblr.Text = ""
        txtValor.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
