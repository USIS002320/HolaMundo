Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If cbxentrada.Text = "Bit" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "terabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 100000000000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000000000.0
        ElseIf cbxentrada.Text = "Bit" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) * 800000000000000.0
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "kilobit" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000000.0
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000.0
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000000.0
        ElseIf cbxentrada.Text = "Kilobit" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000000000.0
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000000.0
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000.0
        ElseIf cbxentrada.Text = "Megabit" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000000.0
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) * 125
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000
        ElseIf cbxentrada.Text = "Gigabit" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000000.0
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000000.0
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) * 125000
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) * 125
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8
        ElseIf cbxentrada.Text = "Terabit" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8000
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 100000000000000.0
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000000.0
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) * 125000000.0
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) * 125000
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) * 125
        ElseIf cbxentrada.Text = "Petabit" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 8
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) / 8000000.0
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 8000
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 8
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) / 125
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) / 125000
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 125000000.0
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) / 1074
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Megabyte" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000000.0
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000.0
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 8000
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) * 8
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) / 125
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 125000
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Gigabyte" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 1000000.0
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000000000.0
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000000.0
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000.0
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) * 8000
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) * 8
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) / 125
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) * 1000
        ElseIf cbxentrada.Text = "Terabyte" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text) / 1000
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Micrometro" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Petabyte" Then
            lblr.Text = Val(txtvalor.Text)
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Bit" Then
            lblr.Text = Val(txtvalor.Text) * 8.0E+15
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Kilobit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000000000.0
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Megabit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000000.0
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Gigabit" Then
            lblr.Text = Val(txtvalor.Text) * 8000000.0
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Terabit" Then
            lblr.Text = Val(txtvalor.Text) * 8000
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Petabit" Then
            lblr.Text = Val(txtvalor.Text) * 8
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Megabyte" Then
            lblr.Text = Val(txtvalor.Text) * 1000000000.0
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Gigabyte" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
        ElseIf cbxentrada.Text = "Petabyte" And cbxsalida.Text = "Terabyte" Then
            lblr.Text = Val(txtvalor.Text) * 1000

        End If

    End Sub

End Class
