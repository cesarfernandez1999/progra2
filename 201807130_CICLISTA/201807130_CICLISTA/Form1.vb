Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sky")
        ComboBox1.Items.Add("Movistar")
        ComboBox1.Items.Add("Pro Cycling")
        ComboBox1.Items.Add("Pro Team")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End

        End If
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        Dim fila As Integer = 0

        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0

        Select Case RadioButton1.Checked
            Case RadioButton1.Checked
                If (matriz(fila, 4)) = "guatemalteco" Then

                    matriz(fila, 4) = Val(1 + 1)
                    estadistica1 = estadistica1 + 1

                    TextBox3.Text = Val(estadistica1)
                End If
        End Select


        Select Case ComboBox1.Text
            Case "Movistar"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)

            Case "Sky"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)

            Case "Pro Cycling"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)

            Case "Pro Team"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)

                TextBox4.Text = estadistica2

        End Select

        If ComboBox1.Text = "Movistar" Then
            estadistica3 = Val(TextBox6.Text) + Val(matriz(fila, 3))
        End If


        If ComboBox1.Text = "Sky" Then
                estadistica3 = Val(TextBox6.Text) + Val(matriz(fila, 3))
            End If


        If ComboBox1.Text = "Pro Cycling" Then
            estadistica3 = Val(TextBox6.Text) + Val(matriz(fila, 3))
        End If


        If ComboBox1.Text = "Pro Team" Then
            estadistica3 = Val(TextBox6.Text) + Val(matriz(fila, 3))

        End If

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox6.Text = ""
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False


    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Dim fila As Integer = 0
        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then

                DataGridView1.Rows.Add(matriz(fila, 0), matriz(fila, 1), matriz(fila, 2), matriz(fila, 3), matriz(fila, 4), matriz(fila, 5), matriz(fila, 6))
            End If
            fila = fila + 1
        End While
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox6.Text = "") Then
            MsgBox("Los campos están vacíos")
            Exit Sub
        End If
        If (ComboBox1.SelectedIndex < -1) Then
            MsgBox("Seleccione un equipo")
            Exit Sub
        End If


        If index < 6 Then
            'columna 0 es etapa
            matriz(index, 0) = TextBox1.Text
            'columna 1 es equipo
            matriz(index, 1) = ComboBox1.Text
            'columna 2 es dias km
            matriz(index, 2) = TextBox2.Text
            'columna 3 es tiempo
            matriz(index, 3) = TextBox6.Text
            'columna 4 tipo de nacionalidad
            If (RadioButton1.Checked) Then
                matriz(index, 4) = "guatemalteco"
            End If

            If (RadioButton2.Checked) Then
                matriz(index, 4) = "extranjero"
            End If



            'columna 5 Total de penalizacion
            Select Case ComboBox1.Text
                Case "Movistar"
                    If Val(TextBox6.Text) < 85 Then
                        matriz(index, 5) = Val(TextBox6.Text) - 15
                    End If



                Case "Pro Team" 
                    matriz(index, 5) = Val(TextBox6.Text) - 10

            End Select

            index = index + 1

        Else
            MsgBox("La matriz llegó a su límite")
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    ComboBox1.Text = matriz(fila, 1)
                    TextBox2.Text = matriz(fila, 2)
                    TextBox6.Text = matriz(fila, 3)
                    RadioButton1.Checked = matriz(fila, 4)
                    RadioButton2.Checked = matriz(fila, 4)

                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

        matriz(index, 0) = TextBox1.Text
        matriz(index, 1) = ComboBox1.Text
        matriz(index, 2) = TextBox2.Text
        matriz(index, 3) = TextBox6.Text
        If (RadioButton1.Checked) Then
            matriz(index, 4) = "guatemalteco"
        End If

        If (RadioButton2.Checked) Then
            matriz(index, 4) = "extranjero"
        End If

        MsgBox("Registro actualizado correctamente en la matriz")
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
