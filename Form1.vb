Public Class Form7

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim es una palabra reservada para declarar una variable
        Dim num1, num2, respuesta As Double 'Declaro las variables en linea separadas por comas del mismo tipo

        num1 = txtnumero1.Text 'capturando el dato que ingres el usuario a la caja de texto, asigno dicho valor a la variable num1.
        num2 = txtnumero2.Text

        'If -> si de condicion
        If optSumar.Checked Then
            lblrespuesta.Text = num1 + num2 'realizamos la suma
        End If

        If optRestar.Checked Then
            lblrespuesta.Text = num1 - num2 'realizamos la resta
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2 'realizamos la multiplicacion
        End If

        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2 'realizamos la division
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100 'realizar el proceso de porcentaje
        End If
        If optExponenciacion.Checked Then
            'realizar el proceso de exponenciacion
            lblrespuesta.Text = num1 ^ num2
        End If
        If optModulo.Checked Then
            'realizar el modulo de la division 
            lblrespuesta.Text = num1 Mod num2
        End If
        '...
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

