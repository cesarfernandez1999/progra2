Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HiloCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles HiloCrudo.CheckedChanged
        If HiloCrudo.Checked = True Then
            txtHiloCrudo.Enabled = True
            txtHiloCrudo.Text = "0"
        Else
            txtHiloCrudo.Enabled = False
            txtHiloCrudo.Text = "0"
        End If
    End Sub

    Private Sub Algodón_CheckedChanged(sender As Object, e As EventArgs) Handles Algodón.CheckedChanged
        If Algodón.Checked = True Then
            txtAlgodon.Enabled = True
            txtAlgodon.Text = "0"
        Else
            txtAlgodon.Enabled = False
            txtAlgodon.Text = "0"
        End If
    End Sub


    Private Sub Lino_CheckedChanged(sender As Object, e As EventArgs) Handles Lino.CheckedChanged
        If Lino.Checked = True Then
            txtLino.Enabled = True
            txtLino.Text = "0"
        Else
            txtLino.Enabled = False
            txtLino.Text = "0"
        End If
    End Sub



    Private Sub Seda_CheckedChanged(sender As Object, e As EventArgs) Handles Seda.CheckedChanged
        If Seda.Checked = True Then
            txtSeda.Enabled = True
            txtSeda.Text = "0"
        Else
            txtSeda.Enabled = False
            txtSeda.Text = "0"
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        lblprecioCosto.Text = "0.00"
        precioCosto = 0.00


        sumaYardas = Val(txtSeda.Text) + Val(txtAlgodon.Text) + Val(txtHiloCrudo.Text) + Val(txtLino.Text)


        If King.Checked = True Then
            If sumaYardas = matKing Then
                precioCosto = precioKing + Val(txtSeda.Text) * precioSeda + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHiloCrudo.Text) * precioHilo + Val(txtLino.Text) * precioLino
            Else
                MsgBox("¡Faltan Materiales!", MsgBoxStyle.OkOnly & vbCritical, "Advertencia")

            End If


        ElseIf Queen.Checked = True Then
            If sumaYardas = matQueen Then
                precioCosto = precioQueen + Val(txtSeda.Text) * precioSeda + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHiloCrudo.Text) * precioHilo + Val(txtLino.Text) * precioLino
            Else
                MsgBox("¡Faltan Materiales!", MsgBoxStyle.OkOnly & vbCritical, "Advertencia")
            End If


        ElseIf Matrimonial.Checked = True Then
            If sumaYardas = matMat Then
                precioCosto = precioMatrimonial + Val(txtSeda.Text) * precioSeda + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHiloCrudo.Text) * precioHilo + Val(txtLino.Text) * precioLino
            Else
                MsgBox("¡Faltan Materiales!", MsgBoxStyle.OkOnly & vbCritical, "Advertencia")
            End If


        ElseIf Imperial.Checked = True Then
            If sumaYardas = matImp Then
                precioCosto = precioImperial + Val(txtSeda.Text) * precioSeda + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHiloCrudo.Text) * precioHilo + Val(txtLino.Text) * precioLino
            Else
                MsgBox("¡Faltan Materiales!", MsgBoxStyle.OkOnly & vbCritical, "Advertencia")

            End If
        End If

        lblprecioCosto.Text = Str(precioCosto)


        precioVenta = (precioCosto * 0.65) + precioCosto
        lblprecioVenta.Text = Str(precioVenta)

        lblprecioAlgodon.Text = Str(precioAlgodon * txtAlgodon.Text)
        lblprecioHilo.Text = Str(precioHilo * txtHiloCrudo.Text)
        lblprecioLino.Text = Str(precioLino * txtLino.Text)
        lblprecioSeda.Text = Str(precioSeda * txtSeda.Text)

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        lblprecioAlgodon.Text = "0.00"
        lblprecioCosto.Text = "0.00"
        lblprecioHilo.Text = "0.00"
        lblprecioLino.Text = "0.00"
        lblprecioSeda.Text = "0.00"
        lblprecioVenta.Text = "0.00"
        txtAlgodon.Text = ""
        txtHiloCrudo.Text = ""
        txtLino.Text = ""
        txtSeda.Text = ""
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
