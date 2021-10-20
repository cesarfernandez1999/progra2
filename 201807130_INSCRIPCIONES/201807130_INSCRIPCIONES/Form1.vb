Public Class Form1
    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        'cuota de incripción
        If ComboBox3.Text = "Básico" Then
            TextBox3.Text = inscripcionbasico
        End If

        If ComboBox3.Text = "Diversificado" Then
            TextBox3.Text = inscripciondiversificado
        End If

        'primera cuota
        If ComboBox3.Text = "Básico" Then
            TextBox4.Text = primerabasico
        End If

        If ComboBox3.Text = "Diversificado" Then
            TextBox4.Text = primeradiversificado
        End If

        Me.dgvDatos.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, ComboBox3.Text, ComboBox2.Text, ComboBox1.Text)
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado2 As String
        resultado2 = (Val(TextBox3.Text) + Val(TextBox4.Text))
        TextBox5.Text = resultado2

        If (ComboBox3.Text = "Básico") Then

            TextBox7.Text = inscripcionbasico
        End If



        If (ComboBox3.Text = "Diversificado") Then

            TextBox7.Text = inscripciondiversificado
        End If

    End Sub

    Private Sub LIMPIARTOTALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARTOTALESToolStripMenuItem.Click
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
End Class
