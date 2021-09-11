Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(calcularSubtotal("4", "A"))

        If indice < 9 Then
            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem
            subtotal_a_pagar(indice) = calcularSubtotal(vfuncion(indice), vcine(indice))
            vdescuento1(indice) = calculoDescuento1(vfuncion(indice), vcine(indice))

            total_pagofin = calculo_subtotal - calculo_desc1 - calculo_desc2
            
            Funcion.Items.Add(vfuncion(indice))
            Cine.Items.Add(vcine(indice))
            SubTotal.Items.Add(subtotal_a_pagar(indice))
            Descuento1.Items.Add(vdescuento1(indice))
            Descuento2.Items.Add(vdescuento1(indice))

        ElseIf indice >= 9 Then


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar_Entradas()
    End Sub
End Class
