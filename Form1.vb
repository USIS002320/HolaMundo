Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim nTabla, i As SByte
        nTabla = txtNtabla.Text

        lstTabla.Items.Clear()

        If nTabla <= 12 Then
            For i = 1 To 10
                lstTabla.Items.Add(nTabla.ToString() + "X" + i.ToString() + "=" + (nTabla * i).ToString())

            Next
        Else
            lstTabla.Items.Add("por favor ingrese solo tablas menores o iguales a 12.")

        End If


    End Sub
End Class
