Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) / 60000
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) / 3600000.0
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) / 86400000.0
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) / 604800000.0
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) / 2628000000.0
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 31540000000.0
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 315400000000.0
        ElseIf cbxentrada.Text = "Milisegundo" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 3154000000000.0
        End If

        If cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Sugundo" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) / 60
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) / 3600
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) / 86400
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) / 604800000.0
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) / 2628000000.0
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 31540000000.0
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 315400000000.0
        ElseIf cbxentrada.Text = "Segundo" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 3154000000000.0
        End If

        If cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 60000
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 60
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) / 60
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) / 1440
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) / 10080
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) / 438000
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 525600
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 5256000.0
        ElseIf cbxentrada.Text = "Minuto" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 52560000.0
        End If

        If cbxentrada.Text = "Hora" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 3600000.0
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 3600
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 60
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) / 24
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) / 168
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) / 730
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 8760
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 87600
        ElseIf cbxentrada.Text = "Hora" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 876000
        End If

        If cbxentrada.Text = "Dia" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 86400000.0
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 86400
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 1440
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) * 24
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) / 7
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) / 30.417
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 365
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 3650
        ElseIf cbxentrada.Text = "Dia" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 36500
        End If

        If cbxentrada.Text = "Semana" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 604800000.0
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 604800
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 10080
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) * 168
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) * 7
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) / 4.345
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 52.143
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 521
        ElseIf cbxentrada.Text = "Semana" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 5214
        End If

        If cbxentrada.Text = "Mes" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 2628000000.0
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 628000000.0
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 43800
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) * 730
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) * 30.417
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) * 4.345
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) / 12
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 120
        ElseIf cbxentrada.Text = "Mes" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 1200
        End If

        If cbxentrada.Text = "Año" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 31540000000.0
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 31540000.0
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 525600
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) * 8760
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) * 365
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) * 52.143
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) / 10
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 100
        ElseIf cbxentrada.Text = "Año" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) * 12
        End If

        If cbxentrada.Text = "Decada" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) * 120
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 315400000000.0
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 5256000.0
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 315400000.0
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) * 87600
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) * 3650
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) * 521
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text) / 10
        ElseIf cbxentrada.Text = "Decada" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) * 10
        End If

        If cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Siglo" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Mes" Then
            lblr.Text = Val(txtvalor.Text) * 1200
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Milisegundo" Then
            lblr.Text = Val(txtvalor.Text) * 3154000000000.0
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Segundo" Then
            lblr.Text = Val(txtvalor.Text) * 3154000000.0
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Minuto" Then
            lblr.Text = Val(txtvalor.Text) * 52560000.0
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Dia" Then
            lblr.Text = Val(txtvalor.Text) * 36500
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Decada" Then
            lblr.Text = Val(txtvalor.Text) * 10
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Semana" Then
            lblr.Text = Val(txtvalor.Text) * 5214
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Hora" Then
            lblr.Text = Val(txtvalor.Text) * 876000
        ElseIf cbxentrada.Text = "Siglo" And cbxsalidad.Text = "Año" Then
            lblr.Text = Val(txtvalor.Text) * 100
        End If

    End Sub

    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click

        lblr.Text = ""
        txtvalor.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
