Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = nombre_sesion + " " + apellido_sesion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "Administrador" Then
            Form4.Show()
            Me.Hide()
        End If


        If ComboBox1.Text = "Cliente" Then
            Form8.Show()
            Me.Hide()
        End If

    End Sub
End Class