Public Class Form1
    Private Sub cmdconvertir_Click(sender As Object, e As EventArgs) Handles cmdconvertir.Click

        If cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.046
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.039
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 0.4
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 0.16
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.0000039
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 1.59
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 4.81
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 0.35
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Peso mexicano" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 0.31
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Dolar" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 21.98
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.85
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 8.75
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 3.58
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.000086
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 34.84
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 105.8
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 7.7
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 6.91
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Euro" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 25.92
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 1.18
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 10.33
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 4.22
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.0001
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 41.1
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 124.79
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 9.09
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 8.15
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 6.14
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.28
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 2.45
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.24
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.000024
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 9.74
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 29.57
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 2.15
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Sol peruano" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 1.93
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 2.51
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.11
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.097
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 0.41
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.0000098
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 3.98
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 12.09
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 0.88
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Colon Salvadoreño" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 0.79
            lblum.Text = "¥"
        End If


        If cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 255738.9
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 11614.7
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 9847.14
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 101683.57
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 41580.9
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 404766.6
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 1229020.51
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 89494.93
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Bitcoin" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 80296.7
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 0.63
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.029
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.024
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 0.25
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 0.1
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.0000025
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 3.04
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 0.22
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Cordoba" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 0.2
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Yen" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 0.21
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.0095
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.08
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 0.83
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 0.034
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.00
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 0.33
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 0.073
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 0.066
            lblum.Text = "¥"
        End If


        If cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Q"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 2.85
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.13
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.11
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 1.14
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 0.46
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.000011
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 4.52
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 13.74
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Quetzal" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text) * 0.9
            lblum.Text = "¥"
        End If

        If cbxentrada.Text = "Yuan" And cbxsalida.Text = "Yuan" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Peso mexicano" Then
            lblr.Text = Val(txtvalor.Text) * 3.18
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.14
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.12
            lblum.Text = "€"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Colon Salvadoreño" Then
            lblr.Text = Val(txtvalor.Text) * 1.27
            lblum.Text = "$"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Sol peruano" Then
            lblr.Text = Val(txtvalor.Text) * 0.52
            lblum.Text = "S/"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Bitcoin" Then
            lblr.Text = Val(txtvalor.Text) * 0.000012
            lblum.Text = "฿"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Cordoba" Then
            lblr.Text = Val(txtvalor.Text) * 5.04
            lblum.Text = "C$"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 15.31
            lblum.Text = "¥"
        ElseIf cbxentrada.Text = "Yuan" And cbxsalida.Text = "Quetzal" Then
            lblr.Text = Val(txtvalor.Text) * 1.11
            lblum.Text = "Q"
        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        lblr.Text = ""
        lblum.Text = ""
        txtvalor.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End

    End Sub
End Class
