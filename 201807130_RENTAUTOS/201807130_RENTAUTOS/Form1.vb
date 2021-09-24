Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            End
        Else
            Limpiar_Entradas()
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub ProcesarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarToolStripMenuItem.Click
        If cbmarca.SelectedItem = "" Or txtdias.Text = "" Or txtnit.Text = "" Or txtplaca.Text = "" Then
            MsgBox("No se han ingresado datos")
        End If

        If txtefectivo.Text = "" Or txttarjeta.Text = "" Then
            MsgBox("No se ha ingresado porcentaje a pagar")
        End If

        If Val(txtefectivo.Text) + Val(txttarjeta.Text) = 100 Then
        Else
            MsgBox("Los porcentajes ingresados no suman 100")
        End If

        If indice < 6 Then
            marca(indice) = cbmarca.SelectedItem
            pagoparcial(indice) = Val(txtdias.Text) * calculopagoparcial(marca(indice))
            descuento(indice) = calculodescuentorecargo()
            pagofinal(indice) = pago_final()
            diasalquiler(indice) = Val(txtdias.Text)
            placa(indice) = txtplaca.Text

            ListBox_placa.Items.Add(placa(indice))
            ListBox_marca.Items.Add(marca(indice))
            ListBox_dias.Items.Add(diasalquiler(indice))
            ListBox_pagoparcial.Items.Add(pagoparcial(indice))
            ListBox_descuento.Items.Add(descuento(indice))
            ListBox_pagofinal.Items.Add(pagofinal(indice))

        ElseIf indice >= 6 Then
            MsgBox("Memoria llena")
        End If
    End Sub
End Class
