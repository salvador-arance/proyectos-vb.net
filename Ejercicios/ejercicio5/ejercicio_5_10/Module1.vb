Module Module1

    Sub Main()
        Dim entrada As String
        Dim num As Integer
        Dim divisor As Integer
        Dim primo As Boolean = True
        Dim resto As Integer
        Console.Clear()
        Console.WriteLine("Números primos.")

        'Validación entrada
        Do
            Console.Write("Introduce número (debe ser entero positivo): ")
            entrada = Console.ReadLine()
            If Not (Integer.TryParse(entrada, num) AndAlso num > 0) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número válido.")
                Console.ResetColor()
            End If
        Loop While Not (Integer.TryParse(entrada, num) AndAlso num > 0)

        If num = 1 Then
            primo = False
        ElseIf num = 2 Then
            Console.WriteLine("Tu número es 2.")
        Else
            divisor = 2
            Do
                resto = num Mod divisor
                If resto = 0 Then
                    primo = False
                End If
                divisor += 1
            Loop Until divisor > Math.Sqrt(num) OrElse primo
        End If

        If primo = True Then
            Console.WriteLine("Es primo.")
        Else
            Console.WriteLine("No es primo.")
        End If
    End Sub

End Module
