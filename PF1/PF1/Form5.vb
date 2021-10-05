Imports System.Data.SqlClient
Public Class Form5

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'botón agregar
        If (txtnombre.Text = "") Or (txtdire.Text = "") Then
            MsgBox("Error, debe de ingresar los daatos")

        Else
            DataGridView1.Rows.Add()
            Dim nf As Short = DataGridView1.Rows.Count - 1

            DataGridView1(0, nf).Value = txtnombre.Text
            DataGridView1(1, nf).Value = txtdire.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value = txtnombre.Text
        DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = txtdire.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201807130;" &
        "Data Source=DESKTOP-BT1RR6O;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Editorial"

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                'guardaremos la info en las variables del módulo
                Dim nom = row.ItemArray(1)
                Dim ape = row.ItemArray(2)
                Dim usr = row.ItemArray(3)

                DataGridView1.Rows.Add(nom, ape, usr)
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub
End Class