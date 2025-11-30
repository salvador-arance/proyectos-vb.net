Module Module1

    Sub Main()
        Dim num1 As Decimal
        Dim readStr As String
        Do
            Console.Write("Introduce un nº positivo (estrictamente >0): ")
            readStr = Console.ReadLine
            If Not Decimal.TryParse(readStr, num1) OrElse num1 <= 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Entrada incorrecta, vuelva a intentarlo. ")
                Console.ResetColor()
            End If
        Loop Until num1 > 0
        Console.WriteLine("La raiz cuadrada de " & num1 & " es " & Math.Sqrt(num1))
    End Sub

End Module