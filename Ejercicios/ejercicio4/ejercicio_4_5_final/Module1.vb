Module Module1

    Sub Main()
        Dim dni As String
        Dim origenLetra As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim primerosDigitosDni, restoParaLetra As Integer
        Dim letra As Char

        Console.Write("Introduce tu DNI: ")
        dni = Console.ReadLine.ToUpper
        If Not dni.Length = 9 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("El DNI tiene 9 caracteres, no " & dni.Length & ".")
            Console.ResetColor()
            Exit Sub
        End If

        If Not (Integer.TryParse(dni.Substring(0, 8), primerosDigitosDni) AndAlso Char.IsLetter(dni.Substring(8))) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Los primeros 8 dígitos deben ser números y el último una letra.")
            Console.ResetColor()
            Exit Sub
        End If

        restoParaLetra = primerosDigitosDni Mod 23
        letra = origenLetra.Chars(restoParaLetra)

        If Not letra = dni.Chars(8) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("La letra no se corresponde con la que debería ser según los primeros 8 dígitos. La letra debería ser: " & letra)
            Console.ResetColor()
            Exit Sub
        End If

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("DNI Válido")
        Console.ResetColor()

    End Sub

End Module