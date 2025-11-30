Module Module1

    Sub Main()
        Dim readStr, dni As String
        Dim origenLetra As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim primerosDigitosDni, restoParaLetra As Integer
        Dim letra As Char
        Dim valid As Boolean

        Do
            Do
                valid = False
                Console.Write("Introduce tu DNI: ")
                dni = Console.ReadLine

                If Not dni.Length = 9 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El DNI tiene 9 caracteres, no " & dni.Length & ". Vuelve a introducirlo.")
                    Console.ResetColor()
                Else
                    If Not (Integer.TryParse(dni.Substring(0, 8), primerosDigitosDni) AndAlso Char.IsLetter(dni.Chars(8))) Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Los primeros 8 dígitos deben ser números y el último una letra.")
                        Console.ResetColor()
                    ElseIf primerosDigitosDni < 0 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Los primeros dígitos del DNI no pueden ser números negativos")
                        Console.ResetColor()
                    Else
                        restoParaLetra = primerosDigitosDni Mod 23
                        letra = origenLetra.Substring(restoParaLetra)
                        If Not letra = Char.ToUpper(dni.Chars(8)) Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("La letra no se corresponde con la que debería ser según los primeros 8 dígitos")
                            Console.ResetColor()
                        Else
                            valid = True
                        End If
                    End If
                End If
            Loop Until valid
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("DNI válido.")
            Console.ResetColor()
            Console.Write("Para comprobar otro DNI, introduzca <si>: ")
            readStr = Console.ReadLine
        Loop While readStr.ToLower() = "si"

        Console.WriteLine("Programa terminado.")
    End Sub

End Module
