Module Module1
    Public dpi(6) As String
    Public nombre(6) As String
    Public valor(6) As String
    Public meses(6) As String
    Public tasa(6) As String
    Public montoFinal(6) As String

    Public index As Integer = 0

    Public Function calc_tasa(mesesF As Integer, valorF As Decimal) As Decimal
        If mesesF = 12 And valorF > 8000 Then
            Return 0.02

        ElseIf mesesF > 12 And mesesF <= 24 Then
            Return 0.045

        ElseIf mesesF > 24 And mesesF <= 36 Then
            Return 0.055

        ElseIf mesesF >= 36 Then
            Return 0.062

        ElseIf mesesF <= 12 Then
            Return 0.03

        End If
        Return 0
    End Function




End Module
