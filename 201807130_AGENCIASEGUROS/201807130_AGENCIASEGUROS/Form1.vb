Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click




    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        Dim deducible = 0.06

        Label7.Text = txtmonto.Text * deducible


    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click


        Me.dgvResultados.Rows.Add(txtedad.Text, cbgenero.Text, cbcodigo.Text, txtmonto.Text, cbtaller.Text, Label7.Text, txtnombre.Text)







    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        txtedad.Text = ""
        txtmonto.Text = ""
        txtnombre.Text = ""
        cbcodigo.Text = ("")
        cbgenero.Text = ("")
        cbtaller.Text = ("")

    End Sub

    Private Sub dgvResultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultados.CellContentClick

    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        Label17.Text = dgvResultados.Rows.Count.ToString()

        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In dgvResultados.Rows
            total += Convert.ToDouble(fila.Cells("Column4").Value)
        Next

        Label18.Text = Convert.ToString(total)
    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click
        Label17.Text = 0
        Label18.Text = 0
        Label19.Text = 0
        Label20.Text = 0
        Label21.Text = 0
        Label22.Text = 0
    End Sub
End Class
