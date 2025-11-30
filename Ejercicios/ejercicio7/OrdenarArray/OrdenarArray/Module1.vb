Module Module1

    Sub Main()
        Dim numeros() As Integer = {55, 17, 300, 47, 51, 80, 4, 12, 2, -2, 27, -23}
        Dim aux As Integer
        'Dim finalArray As Integer
        Dim huboIntercambio As Boolean

        'finalArray = numeros.Length - 2

        Do
            huboIntercambio = False

            'For i = 0 To (finalArray)
            For i = 0 To numeros.Length - 2

                If numeros(i) > numeros(i + 1) Then
                    aux = numeros(i)
                    numeros(i) = numeros(i + 1)
                    numeros(i + 1) = aux
                    huboIntercambio = True
                End If

            Next

            'finalArray -= 1

            'Loop While finalArray > 0
        Loop While huboIntercambio

        For i = 0 To numeros.Length - 1
            Console.Write($"{numeros(i)} ")
        Next

    End Sub

End Module
