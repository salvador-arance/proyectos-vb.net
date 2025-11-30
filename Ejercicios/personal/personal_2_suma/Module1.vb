Module Module1

    Sub Main()
        Dim x, y As Integer
        Dim readStr As String
        x = 0
        Do
            Do
                Console.Write("Introduzca un número: ")
                readStr = Console.ReadLine()
                If Not Integer.TryParse(readStr, y) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("No has introducido un número válido, vuelve a intentarlo.")
                    Console.ResetColor()
                End If
            Loop Until Integer.TryParse(readStr, y)
            x += y
            Console.WriteLine("La suma hasta ahora es: " & x)
            Console.Write("¿Quieres otro número para operar? Introduce <si>: ")
            readStr = Console.ReadLine.ToLower
        Loop While readStr = "si"
    End Sub

End Module