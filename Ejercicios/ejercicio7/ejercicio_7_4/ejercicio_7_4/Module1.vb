Module Module1

    Sub Main()
        Dim numeros() As Integer = {30, 12, -3, -4, 25, -3, 15, 0, 28, 25}
        Dim superiores As String = ""

        Console.Write("Los núemeros del array son: ")

        Console.ForegroundColor = ConsoleColor.Blue
        For i = 0 To numeros.Length - 1

            Console.Write($"{numeros(i)} ")

        Next
        Console.WriteLine()
        Console.ResetColor()

        Console.Write("La media aritmética es: ")

        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine(numeros.Average)
        Console.ResetColor()

        Console.Write($"La diferencia entre el mayor ({numeros.Max}) y el menor ({numeros.Min}) es: ")

        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine(numeros.Max - numeros.Min)
        Console.ResetColor()

        Console.Write("Los números superiores a la media son: ")

        Console.ForegroundColor = ConsoleColor.Blue

        For i = 0 To numeros.Length - 1

            If numeros(i) > numeros.Average Then
                superiores &= $"{numeros(i)} "
            End If

        Next

        Console.WriteLine(superiores)
        Console.ResetColor()

    End Sub

End Module
