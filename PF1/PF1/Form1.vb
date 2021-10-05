Imports System.Data.SqlClient

Public Class Form1
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201807130;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try
            'Open the connection.
            myConn.Open()

            If myConn.State() = 1 Then
                MsgBox("Se conectó exitosamente a la base de datos")
            Else
                MsgBox("Algo salió mal")

            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Por favor, llenar todos los campos")
            Exit Sub
        End If

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201807130;" &
        "Data Source=DESKTOP-BT1RR6O;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT TOP 1 * FROM Usuario WHERE usuario = @usr AND contrasenia = @pwd AND tipo_usr = @tipo_usr"
            myCmd.Parameters.AddWithValue("@usr", TextBox1.Text)
            myCmd.Parameters.AddWithValue("@pwd", TextBox2.Text)
            myCmd.Parameters.AddWithValue("@tipo_usr", ComboBox1.Text)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then 'Si las filas es igual a 0 es porque no se encontró nada
                MsgBox("Las credenciales no son validas")
            Else
                For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                    'guardaremos la info en las variables del módulo
                    id_usuario_sesion = row.ItemArray(0)
                    nombre_sesion = row.ItemArray(1)
                    apellido_sesion = row.ItemArray(2)
                    usuario_sesion = row.ItemArray(3)
                    tipo_usuario_sesion = row.ItemArray(4)
                    nacimiento_sesion = row.ItemArray(5)
                    Exit For 'Solo recibimos una fila, por eso nos salimos del for
                Next

                'Verificar tipo de usuario para redirigir al form correspodiente
                If tipo_usuario_sesion = "Administrador" Then
                    Form2.Show()
                    Me.Hide()
                ElseIf tipo_usuario_sesion = "Cliente" Then
                    'Mostrar form de cliente
                End If
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Por favor, llenar todos los campos")
            Exit Sub
        End If

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201807130;" &
        "Data Source=DESKTOP-BT1RR6O;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT TOP 1 * FROM Libro WHERE usuario = @usr AND contrasenia = @pwd AND tipo_usr = @tipo_usr"
            myCmd.Parameters.AddWithValue("@usr", TextBox1.Text)
            myCmd.Parameters.AddWithValue("@pwd", TextBox2.Text)
            myCmd.Parameters.AddWithValue("@tipo_usr", ComboBox1.Text)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then 'Si las filas es igual a 0 es porque no se encontró nada
                MsgBox("Las credenciales no son validas")
            Else
                For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                    'guardaremos la info en las variables del módulo
                    id_usuario_sesion = row.ItemArray(0)
                    nombre_sesion = row.ItemArray(1)
                    apellido_sesion = row.ItemArray(2)
                    usuario_sesion = row.ItemArray(3)
                    tipo_usuario_sesion = row.ItemArray(4)
                    nacimiento_sesion = row.ItemArray(5)
                    Exit For 'Solo recibimos una fila, por eso nos salimos del for
                Next

                'Verificar tipo de usuario para redirigir al form correspodiente
                If tipo_usuario_sesion = "Administrador" Then
                    Form2.Show()
                    Me.Hide()
                ElseIf tipo_usuario_sesion = "Cliente" Then
                    'Mostrar form de cliente
                End If
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
