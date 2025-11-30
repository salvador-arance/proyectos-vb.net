Module Module1

    Sub Main()
        Dim num1 As Decimal
        Dim readStr As String
        Do
            Console.Write("Introduce un número: ")
            readStr = Console.ReadLine
            If Not Decimal.TryParse(readStr, num1) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introuce un valor numérico, por favor.")
                Console.ResetColor()
            End If
        Loop Until Decimal.TryParse(readStr, num1)
        If num1 > 0 Then
            Console.WriteLine("El doble de " & num1 & " es " & num1 * 2)
        Else
            Console.Write("El valor absoluto de " & num1 & " es " & Math.Abs(num1))
        End If
    End Sub

End Module