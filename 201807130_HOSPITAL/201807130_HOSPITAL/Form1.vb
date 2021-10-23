Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Los campos están vacíos")
            Exit Sub
        End If
        If (ComboBox1.SelectedIndex < -1) Or (ComboBox2.SelectedIndex < -1) Then
            MsgBox("Seleccione un elemento")
            Exit Sub
        End If

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    MsgBox("NIT ya existente")
                    Exit Sub
                End If
            End If
        Next

        If index < 6 Then
            'columna 0 es nit
            matriz(index, 0) = TextBox1.Text
            'columna 1 es nombre
            matriz(index, 1) = TextBox2.Text
            'columna 2 es dias hospitalizado
            matriz(index, 2) = TextBox3.Text
            'honorarios columna 3
            matriz(index, 3) = TextBox4.Text
            'columna 4 tipo de habitacion
            matriz(index, 4) = ComboBox1.Text

            'Total de dias por habitacion columna 6
            Select Case ComboBox1.Text
                Case "Privada"
                    matriz(index, 6) = Val(TextBox3.Text) * 350
                Case "Semiprivada"
                    matriz(index, 6) = Val(TextBox3.Text) * 250
                Case "No Privada"
                    matriz(index, 6) = Val(TextBox3.Text) * 150
            End Select

            'calcular descuento o recargo columna 7
            Select Case ComboBox2.Text
                Case "Efectivo"
                Case "Depósito"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.1 * -1
                Case "Transferencia"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.08 * -1
                Case "Tarjeta"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.015
            End Select

            'calcular total en columna 8
            matriz(index, 8) = Val(matriz(index, 6)) + Val(matriz(index, 7))

            index = index + 1

        Else
            MsgBox("La matriz llegó a su límite")
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Solo se pueden ingresar datos numéricos")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Solo se pueden ingresar datos numéricos")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Solo se pueden ingresar datos numéricos")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Dim fila As Integer = 0
        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then

                DataGridView1.Rows.Add(matriz(fila, 0), matriz(fila, 1), matriz(fila, 2), matriz(fila, 3), matriz(fila, 4), matriz(fila, 5), matriz(fila, 6), matriz(fila, 7), matriz(fila, 8))
            End If
            fila = fila + 1
        End While

    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        For fila As Integer = 0 To 5
            For columna As Integer = 0 To 8
                matriz(fila, columna) = Nothing
            Next
        Next
    End Sub

    Private Sub LIMPIARTABLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARTABLAToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("No seleccionó NIT")
            Exit Sub
        End If

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    TextBox2.Text = matriz(fila, 1)
                    TextBox3.Text = matriz(fila, 2)
                    TextBox4.Text = matriz(fila, 3)
                    ComboBox1.Text = matriz(fila, 4)
                    ComboBox2.Text = matriz(fila, 5)
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click
        Dim fila As Integer = 0

        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0

        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then
                If matriz(fila, 4) = "Privada" Then
                    estadistica1 = estadistica1 + 1
                End If

                If matriz(fila, 5) = "Transferencia" Then
                    estadistica2 = estadistica2 + Val(matriz(fila, 8))
                End If

                If matriz(fila, 4) = "No Privada" Then
                    estadistica3 = estadistica3 + Val(matriz(fila, 2))
                End If
            End If
            fila = fila + 1
        End While

        TextBox5.Text = estadistica1
        TextBox6.Text = estadistica2
        TextBox7.Text = estadistica3
    End Sub

    Private Sub LIMPIARESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADÍSTICASToolStripMenuItem.Click
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
