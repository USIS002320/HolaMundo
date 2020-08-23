Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) / 25.4
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 1609344
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) / 914
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 1852000.0
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) * 1000

        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 10
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 100
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 100000
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) / 2.54
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 160934
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 10000000.0
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) / 91.44
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 185200
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) / 10000

        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 39.37
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 1609
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) * 1.094
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 1852
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0

        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000000
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100000
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 39370
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 1.609
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000000.0
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) * 1094
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 1.852
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0

        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 25.4
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 2.54
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 39.37
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 39370
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 63360
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 25400000.0
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) / 36
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) * 72913
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) * 25400

        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1609000.0
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 160934
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 1609
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) * 1.609
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 63360
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 1609000000000.0
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) / 914400000.0
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 1852000000000.0
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) / 1000

        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10000000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) / 25400000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 1609000000000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) / 914400000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 1852000000000.0
        ElseIf cbxentrada.Text = "Nanometro" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) / 1000

        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 914
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 91.44
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1.094
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1094
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 36
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 1760
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 914400000.0
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 2025
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) * 914400

        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1852000.0
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 185200
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 1852
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) * 1.852
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 72913
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) * 1.151
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 1852000000000.0
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) * 2025
        ElseIf cbxentrada.Text = "Milla Nautica" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text) * 1852000000.0

        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10000
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) / 25400
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Milla" Then
            lblr.Text = Val(txtvalor.Text) / 1609000000.0
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Nanometro" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Yarda" Then
            lblr.Text = Val(txtvalor.Text) / 914400
        ElseIf cbxentrada.Text = "Micrometro" And cbxsalida.Text = "Milla Nautica" Then
            lblr.Text = Val(txtvalor.Text) / 1852000000.0
        End If

    End Sub
End Class
