Module Module1

    Sub Main()
        Dim x As Decimal
        Dim mayor As Decimal
        Dim entrada As String
        Dim contador As Integer = 0
        Dim primerNumero As Boolean = True

        Do
            Console.WriteLine("Introduce números positivos y te diré cual es el mayor de todos ellos")
            Do
                Console.Write("Nº" & (contador + 1) & ": ")
                entrada = Console.ReadLine
                If Decimal.TryParse(entrada, x) Then
                    If primerNumero Then
                        mayor = x
                        primerNumero = False
                    ElseIf x > mayor Then
                        mayor = x
                    End If
                    Exit Do
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop
            Do
                Console.Write("¿Otro número (S/N)?: ")
                entrada = Console.ReadLine
                If Not (entrada.ToUpper = "S" OrElse entrada.ToUpper = "N") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N")
                    Console.ResetColor()
                Else
                    Exit Do
                End If
            Loop
            contador += 1
        Loop Until entrada.ToUpper = "N"
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("El número mayor de los " & contador & " que has introducido es: " & mayor)
        Console.ResetColor()
    End Sub

End Module
