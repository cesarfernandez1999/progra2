Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click

        Limpiar_Entradas()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (txtnombre.Text = "") Then
            MsgBox("Debe de ingresar su nombre", vbQuestion)
            Limpiar_Entradas()
            Exit Sub
            txtnombre.Focus()

        End If

        If (txtNIT.Text = "") Then
            MsgBox("Ingrese número de NIT", vbQuestion)
            Limpiar_Entradas()
            Exit Sub
            txtnombre.Focus()

        End If

        If (txtwatts.Text = "") Then
            MsgBox("Ingrese el consumo de kilowatts", vbQuestion)
            Limpiar_Entradas()
            Exit Sub
            txtnombre.Focus()

        End If

        If (txtsaldoanterior.Text = "") Then
            MsgBox("Ingrese su saldo anteior, de no tener, escribir 0", vbQuestion)
            Limpiar_Entradas()
            Exit Sub
            txtsaldoanterior.Focus()

        End If


        If (indice < 11) Then
            Cliente(indice) = txtnombre.Text
            Servicio(indice) = ComboBox_Servicio.Text
            Tarifa(indice) = ComboBox_Tarifa.Text
            SaldoAnterior(indice) = txtsaldoanterior.Text

            If Str(ComboBox_Servicio.Text = "Residencial") Then

                Select Case Val(txtwatts.Text)
                    Case 1 To 100
                        total_pagoinicial = Val(txtwatts.Text) * Residencial1
                    Case 101 To 300
                        total_pagoinicial = Val(txtwatts.Text) * Residencial2
                    Case >= 301
                        total_pagoinicial = Val(txtwatts.Text) * Residencial3

                End Select

                PagoInicial(indice) = Math.Round(total_pagoinicial, 2)

            End If
            If Str(ComboBox_Servicio.Text = "Industrial") Then

                Select Case Val(txtwatts.Text)
                    Case 1 To 100
                        total_pagoinicial = Val(txtwatts.Text) * Industrial1
                    Case 101 To 300
                        total_pagoinicial = Val(txtwatts.Text) * Industrial2
                    Case >= 301
                        total_pagoinicial = Val(txtwatts.Text) * Industrial3
                End Select

                PagoInicial(indice) = Math.Round(total_pagoinicial, 2)
            End If

            If Val(txtsaldoanterior.Text) > 0 Then
                total_recargo = (Val(txtsaldoanterior.Text) * mora_aplicada)
                Mora(indice) = (mora_aplicada * 100).ToString + "%"
            ElseIf Val(txtsaldoanterior.Text) <= 0 Then
                Mora(indice) = "No se aplicará mora"
            End If

            total_conmora = Val(txtsaldoanterior.Text) + total_recargo
            PMora(indice) = Math.Round(total_conmora, 2)

            Select Case ComboBox_Tarifa.Text
                Case "Social"

                    total_pagoparcial = (Val(txtsaldoanterior.Text) + total_pagoinicial) + total_recargo
                    PagoParcial(indice) = total_pagoparcial

                    total_tarifa = total_pagoparcial * descuentosocial
                    Descuento(indice) = (descuentosocial * 100).ToString + "%"

                    total_pagofin = total_pagoparcial + total_tarifa
                    PagoTotal(indice) = Math.Round(total_pagofin, 2)

                Case "No Social"

                    total_tarifa = total_pagoinicial - (total_pagoinicial * descuentonosocial)
                    Descuento(indice) = (descuentonosocial * 100).ToString + "%"

                    PagoInicial(indice) = Math.Round(total_tarifa, 2)

                    total_pagoparcial = total_tarifa + total_conmora
                    PagoParcial(indice) = Math.Round(total_pagoparcial, 2)

                    total_pagofin = total_pagoparcial

                    PagoTotal(indice) = Math.Round(total_pagofin, 2)

            End Select

            mostrar()

            indice = indice + 1

        End If

        If (indice > 11) Then
            MsgBox("Limite de 11 ingresos alcanzado")
        End If

        Limpiar_Entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        LimpiarV()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub
End Class
