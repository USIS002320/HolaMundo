Public Class Form1
    Private Sub cmdconvertir_Click(sender As Object, e As EventArgs) Handles cmdconvertir.Click

        If cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 453592
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) / 6350000.0
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 1016000000.0
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 907200000.0
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Miligramos" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) / 28350
            lblum.Text = "onz"
        End If

        If cbxentrada.Text = "Gramos" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) / 454
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) / 6350
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 1016000.0
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 907185
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Gramos" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) / 28.35
            lblum.Text = "onz"
        End If

        If cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000000
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 2.205
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) / 6.35
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 1016
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 907
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Kilogramos" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) * 35.274
            lblum.Text = "onz"
        End If


        If cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 2205
            lblum.Text = "Lb"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) * 157
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 1.016
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) * 1.102
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Toneladas" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) * 35274
            lblum.Text = "onz"
        End If

        If cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000000.0
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 453600000.0
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) / 6350000000.0
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 1016000000000.0
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 907200000000.0
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Microgramos" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) / 28350000.0
            lblum.Text = "onz"
        End If

        If cbxentrada.Text = "Libras" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 453592
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 454
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) / 2.205
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 2205
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 453600000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) / 14
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 2240
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 2000
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Libras" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) * 16
            lblum.Text = "onz"
        End If


        If cbxentrada.Text = "Stone" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 6350000.0
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 6350
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) * 6.35
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 157
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 6350000000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 14
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 160
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 143
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Stone" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) * 224
            lblum.Text = "onz"
        End If

        If cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 1016000000.0
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 1016000.0
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) * 1016
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) * 1.016
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 1016000000000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 2240
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) * 160
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) * 1.12
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Toneladas Largas" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) * 35840
            lblum.Text = "onz"
        End If

        If cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "tc"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 907200000.0
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 907185
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) * 907
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 1.102
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 907200000000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) * 2000
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) * 143
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 1.12
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Toneladas Cortas" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text) * 32000
            lblum.Text = "onz"

        End If

        If cbxentrada.Text = "Onzas" And cbxsalida.Text = "Onzas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "onz"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Miligramos" Then
            lblr.Text = Val(txtvalor.Text) * 28350
            lblum.Text = "mg"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Gramos" Then
            lblr.Text = Val(txtvalor.Text) * 28.35
            lblum.Text = "g"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Kilogramos" Then
            lblr.Text = Val(txtvalor.Text) / 35.274
            lblum.Text = "kg"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Toneladas" Then
            lblr.Text = Val(txtvalor.Text) / 35274
            lblum.Text = "tn"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Microgramos" Then
            lblr.Text = Val(txtvalor.Text) * 28350000.0
            lblum.Text = "µg"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Libras" Then
            lblr.Text = Val(txtvalor.Text) / 16
            lblum.Text = "lb"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Stone" Then
            lblr.Text = Val(txtvalor.Text) / 224
            lblum.Text = "st"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Toneladas Largas" Then
            lblr.Text = Val(txtvalor.Text) / 35840
            lblum.Text = "long ton"
        ElseIf cbxentrada.Text = "Onzas" And cbxsalida.Text = "Toneladas Cortas" Then
            lblr.Text = Val(txtvalor.Text) / 32000
            lblum.Text = "tc"








        End If
    End Sub

    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click

        lblr.Text = ""
        lblum.Text = ""
        txtvalor.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End

    End Sub


End Class
