Module Module1
    Public indice As Byte = 0
    Public nit(6) As String
    Public marca(6) As String
    Public placa(6) As String
    Public diasalquiler(6) As Double
    Public formapago(6) As String
    Public descuento(6) As Double
    Public pagoparcial(6) As Double
    Public pagofinal(6) As Double

    Public Const efectivo = 0.05
    Public Const tarjeta = 0.025
    Public calculo_pagoparcial As Double = 0

    Sub Limpiar_Entradas()
        Form1.cbmarca.SelectedIndex = -1
        Form1.txtdias.Clear()
        Form1.txtnit.Clear()
        Form1.txtplaca.Clear()
        Form1.txtefectivo.Clear()
        Form1.txttarjeta.Clear()
        Form1.txtnit.Focus()
        indice = 0

    End Sub

    Sub Limpiar_Vectores()
        indice = 0
        'Limpiar Listbox
        Form1.ListBox_descuento.Items.Clear()
        Form1.ListBox_dias.Items.Clear()
        Form1.ListBox_marca.Items.Clear()
        Form1.ListBox_pagofinal.Items.Clear()
        Form1.ListBox_pagoparcial.Items.Clear()
        Form1.ListBox_placa.Items.Clear()
    End Sub


    Function calculopagoparcial(marca As String) As Double
        Select Case marca
            Case "Honda"
                calculo_pagoparcial = 250
            Case "Mercedes Benz"
                calculo_pagoparcial = 450
            Case "Toyota"
                calculo_pagoparcial = 350
            Case "Mazda"
                calculo_pagoparcial = 300

        End Select
        Return calculo_pagoparcial
    End Function

    Function calculodescuentorecargo() As Double
        Dim descuento As Double
        Dim recargo As Double

        If (Form1.CheckBox1.Checked) Then
            If Form1.txtefectivo.Text = "100" Then
                formapago(indice) = Form1.CheckBox1.Text
                descuento = pagoparcial(indice) * efectivo
                Return descuento * -1
            End If
        ElseIf (Form1.CheckBox2.Checked) Then
            If Form1.txttarjeta.Text = "100" Then
                formapago(indice) = Form1.CheckBox2.Text
                recargo = pagoparcial(indice) * tarjeta
                Return recargo
            End If
        End If
        Return 0
    End Function

    Function pago_final() As Double
        pago_final = pagoparcial(indice) + descuento(indice)
        Return pago_final
    End Function

End Module
