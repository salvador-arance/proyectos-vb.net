Module Module1

    Sub Main()
        Dim pvp As Double
        Dim q As Byte
        Dim iva As Double
        Dim readStr As String
        Dim valid As Boolean
        Dim priceNoI As Double
        Dim priceI As Double
        Dim discount As Double
        Console.Write("PVP: ")
        readStr = Console.ReadLine
        valid = Double.TryParse(readStr, pvp)
        If Not valid Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Error en la entrada del precio, el programa va a finalizar.")
            Console.ResetColor()
            Exit Sub
        End If
        Console.Write("Cantidad: ")
        readStr = Console.ReadLine
        valid = Byte.TryParse(readStr, q)
        If Not valid Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Error en la entrada de la cantidad, el programa va a finalizar.")
            Console.ResetColor()
            Exit Sub
        End If
        Console.Write("Iva (General/Reducido/Superreducido): ")
        readStr = Console.ReadLine
        If Not (readStr.Equals("General", StringComparison.OrdinalIgnoreCase) OrElse readStr.Equals("Reducido", StringComparison.OrdinalIgnoreCase) OrElse readStr.Equals("Superreducido", StringComparison.OrdinalIgnoreCase)) Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Error en la entrada del tipo de iva, el programa va a finalizar.")
            Console.ResetColor()
            Exit Sub
        End If
        If readStr.Equals("General", StringComparison.OrdinalIgnoreCase) Then
            iva = 0.21
        ElseIf readStr.Equals("Reducido", StringComparison.OrdinalIgnoreCase) Then
            iva = 0.1
        Else
            iva = 0.4
        End If
        priceNoI = pvp * q
        priceI = priceNoI + (priceNoI * iva)
        Console.WriteLine("Tienes que pagar " & priceI & " euros, veamos si tienes descuento.")
        Console.Write("¿Estudias o trabajas en educación? Responde <s> en caso afirmativo, en caso negativo introduzca cualquier otra cosa: ")
        readStr = Console.ReadLine
        If Not readStr.Equals("s") Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Lo sentimos, no tienes descuento alguno.")
            Console.ResetColor()
            Exit Sub
        End If
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("Enhorabuena, dispones del descuento que elijas (debe ser un número entre el 0 y el 100): ")
        Console.ResetColor()
        readStr = Console.ReadLine()
        valid = Double.TryParse(readStr, discount)
        If Not valid Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Lo sentimos, no has introducido una cifra adecuada.")
            Console.ResetColor()
            Exit Sub
        ElseIf (discount < 0 OrElse discount > 100) Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("Lo sentimos, el descuento no puede ser menor que 0 o mayor que 100")
            Console.ResetColor()
            Exit Sub
        End If
        priceI -= (priceI * (discount / 100))
        Console.WriteLine("Tu precio final es de: " & priceI & " euros")
    End Sub

End Module
