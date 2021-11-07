Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Then
            MsgBox("Los campos están vacíos")
            Exit Sub
        End If

        If index < 7 Then
            dpi(index) = TextBox1.Text
            nombre(index) = TextBox2.Text
            valor(index) = TextBox3.Text
            meses(index) = TextBox4.Text

            tasa(index) = calc_tasa(Val(TextBox4.Text), Val(TextBox3.Text))
            montoFinal(index) = Val(TextBox3.Text) + Val(tasa(index)) * Val(TextBox3.Text)

            index = index + 1
        Else
            MsgBox("Los vectores están llenos")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To index - 1
            DataGridView1.Rows.Add(dpi(i), nombre(i), valor(i), meses(i), tasa(i), montoFinal(i))

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6

        For i = 0 To 5
            For j = i + 1 To 6


                If (dpi(j) <> Nothing) Then
                    If (dpi(i) > dpi(j)) Then
                        temp1 = dpi(i)
                        dpi(i) = dpi(j)
                        dpi(j) = temp1

                        temp2 = nombre(i)
                        nombre(i) = nombre(j)
                        nombre(j) = temp2

                        temp3 = valor(i)
                        valor(i) = valor(j)
                        valor(j) = temp3

                        temp4 = meses(i)
                        meses(i) = meses(j)
                        meses(j) = temp4

                        temp5 = tasa(i)
                        tasa(i) = tasa(j)
                        tasa(j) = temp5

                        temp6 = montoFinal(i)
                        montoFinal(i) = montoFinal(j)
                        montoFinal(j) = temp6


                    End If
                Else

                    Exit For

                End If
            Next j
        Next i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6

        For i = 0 To 5
            For j = i + 1 To 6

                If (dpi(j) <> Nothing) Then
                    If (dpi(i) < dpi(j)) Then
                        temp1 = dpi(i)
                        dpi(i) = dpi(j)
                        dpi(j) = temp1

                        temp2 = nombre(i)
                        nombre(i) = nombre(j)
                        nombre(j) = temp2

                        temp3 = valor(i)
                        valor(i) = valor(j)
                        valor(j) = temp3

                        temp4 = meses(i)
                        meses(i) = meses(j)
                        meses(j) = temp4

                        temp5 = tasa(i)
                        tasa(i) = tasa(j)
                        tasa(j) = temp5

                        temp6 = montoFinal(i)
                        montoFinal(i) = montoFinal(j)
                        montoFinal(j) = temp6
                    End If
                Else

                    Exit For
                End If
            Next j
        Next i
    End Sub
End Class
