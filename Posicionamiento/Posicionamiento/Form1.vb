Public Class Form1
    Private Sub RadioButtonColor_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRojo.CheckedChanged, rbnAzul.CheckedChanged, rbnVerde.CheckedChanged, rbnAmarillo.CheckedChanged
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

    Private Sub RadioButtonPosicion_CheckedChanged(sender As Object, e As EventArgs) Handles rbnArriba.CheckedChanged, rbnAbajo.CheckedChanged, rbnCentro.CheckedChanged, rbnDerecha.CheckedChanged, rbnIzquierda.CheckedChanged
        Select Case CType(sender, RadioButton).Name
            Case "rbnArriba"
                lblCuadro.Top = 0
            Case "rbnAbajo"
                lblCuadro.Top = Me.Size.Height - lblCuadro.Height * 1.5
            Case "rbnDerecha"
                lblCuadro.Left = Me.Size.Width - lblCuadro.Width
            Case "rbnIzquierda"
                lblCuadro.Left = gbxPosicion.Width + gbxPosicion.Left
            Case "rbnCentro"
                lblCuadro.Left = ((gbxPosicion.Width + gbxPosicion.Left) + (Me.Size.Width - lblCuadro.Width)) / 2
                lblCuadro.Top = (Me.Size.Height - lblCuadro.Height * 1.5) / 2
        End Select
    End Sub
End Class
