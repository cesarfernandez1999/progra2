Module Module1
    Public vfuncion(8)
    Public vcine(8)

    Public subtotal_a_pagar(8)
    Public vdescuento1(8)
    Public vdescuento2(8)
    Public total_a_pagar(8)
    Public PagoTotal = 0



    Public indice = 0


    Public calculo_subtotal As Integer = 0
    Public calculo_desc1 As Integer = 0
    Public calculo_desc2 As Integer = 0

    Public total_pagofin As Double


    Function calcularSubtotal(funcion As String, cine As String) As Double
        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30
                    Case "2"
                        calculo_subtotal = 35
                    Case Else
                        calculo_subtotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24
                    Case "2"
                        calculo_subtotal = 34
                    Case Else
                        calculo_subtotal = 44
                End Select

            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35
                    Case "2"
                        calculo_subtotal = 40
                    Case Else
                        calculo_subtotal = 50
                End Select
        End Select

        Return calculo_subtotal
    End Function
    Function calculoDescuento1(funcion As String, cine As String) As Double

        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculoDescuento1 = 0.015
        End If

        Return calculoDescuento1
    End Function



    Function calculoDescuento2(funcion As String, cine As String) As Double
        If subtotal_a_pagar(indice) >= 100 And subtotal_a_pagar(indice) < 300 Then
            vdescuento2(indice) = (subtotal_a_pagar(indice) * 0.02, 2)
        ElseIf subtotal_a_pagar(indice) >= 300 And subtotal_a_pagar(indice) < 500 Then
            vdescuento2(indice) = (subtotal_a_pagar(indice) * 0.04, 2)
        ElseIf subtotal_a_pagar(indice) >= 500 And subtotal_a_pagar(indice) <= 1000 Then
            vdescuento2(indice) = (subtotal_a_pagar(indice) * 0.06, 2)
        End If

        Return calculoDescuento2
    End Function



    Sub Limpiar_Entradas()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.ComboBox3.SelectedIndex = -1



    End Sub

End Module
