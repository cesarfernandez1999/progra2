Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtchequesp.Enabled = True
        Else
            txtchequesp.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtchequesp.TextChanged
        If CheckBox1.Checked = True Then
            txtchequesp.Enabled = True
        Else
            txtchequesp.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtchequeso.Enabled = True
        Else
            txtchequeso.Enabled = False
        End If
    End Sub

    Private Sub txtchequeso_TextChanged(sender As Object, e As EventArgs) Handles txtchequeso.TextChanged
        If CheckBox2.Checked = True Then
            txtchequeso.Enabled = True
        Else
            txtchequeso.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txtefectivo.Enabled = True
        Else
            txtefectivo.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If RadioButton3.Checked = True Then
            Select Case saldo_nuevo
                Case 1.01 To 1000.99
                    interes = 1.5 / 100
                Case 1001 To 5000.99
                    interes = 2.5 / 100
                Case 5001 To 15000.99
                    interes = 7.5 / 100
                Case Is >= 15001
                    interes = 10 / 100
            End Select
            saldo_nuevo = Val(txtchequesp.Text) + Val(txtchequeso.Text) + Val(txtefectivo.Text) + Val(saldoAnterior.Text)
            saldo_nuevo = saldo_nuevo + saldo_nuevo * interes
            saldoNuevo.Text = Str(saldo_nuevo)
        End If

        If RadioButton2.Checked = True Then
            Select Case Val(saldoAnterior.Text)
                Case 1.01 To 1000.99
                    interes = 2.5 / 100
                Case 1001 To 15000.99
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100
            End Select
            saldo_nuevo = Val(txtchequesp.Text) + Val(txtchequeso.Text) + Val(txtefectivo.Text) + Val(saldoAnterior.Text) * interes
            saldoNuevo.Text = Str(saldo_nuevo)
        End If

        If RadioButton1.Checked = True Then
            saldo_nuevo = Val(txtchequesp) + Val(txtchequeso.Text) + Val(txtefectivo.Text) + Val(saldoAnterior.Text)
            saldoNuevo.Text = Str(saldo_nuevo)
        End If

        txtinteres.Text = Str(interes * 100) + "%"

    End Sub
End Class
