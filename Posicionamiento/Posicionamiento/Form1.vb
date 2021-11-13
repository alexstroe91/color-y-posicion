Public Class Form1
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRojo.CheckedChanged, rbnAzul.CheckedChanged, rbnVerde.CheckedChanged, rbnAmarillo.CheckedChanged
        Select Case CType(sender, RadioButton).Name
            Case "rbnRojo"
                lblCuadro.BackColor = Color.Red
            Case "rbnAzul"
                lblCuadro.BackColor = Color.Blue
            Case "rbnVerde"
                lblCuadro.BackColor = Color.Green
            Case "rbnAmarillo"
                lblCuadro.BackColor = Color.Yellow
        End Select
    End Sub


End Class
