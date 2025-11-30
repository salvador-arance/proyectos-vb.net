Module Module1

    Sub Main()
        Dim palabras() As String = {"hola", "1ºDam", "EJemplo", "PERmiso", "ACIERTOS", "adios", "adivinanza", "comida"}
        Dim entradas(7) As String
        Dim valido As Boolean
        Dim coincidenciasExactas As Integer
        Dim coincidenciasParciales As Integer
        Dim casiCoincidencias As Integer

        Console.WriteLine("Observa las siguientes palabras")
        Console.ForegroundColor = ConsoleColor.Blue
        For i = 0 To palabras.Length - 1
            Console.Write($"{palabras(i)} ")
        Next
        Console.ResetColor()
        Console.WriteLine()

        Console.Write("Pulsa cualquier tecla y se borrarán ")

        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("¿Recuerdas cuál era la palabra que estaba en la posición que se indique?")

        For i = palabras.Length - 1 To 0 Step -1
            If i = palabras.Length - 1 Then
                Console.Write($"{i + 1}: ")
                entradas(i) = Console.ReadLine
            Else
                Do
                    Console.Write($"{i + 1}: ")
                    entradas(i) = Console.ReadLine
                    valido = Not entradas.Contains(entradas(i))
                    If Not valido Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("¡No puedes repetir la misma palabra!")
                        Console.ResetColor()
                    End If
                Loop While Not valido
            End If

        Next

        coincidenciasExactas = 0
        coincidenciasParciales = 0
        casiCoincidencias = 0

        For i = 0 To palabras.Length - 1
            If entradas(i).Equals(palabras(i)) Then
                coincidenciasExactas += 1
            Else
                If entradas(i).ToUpper.Equals(palabras(i).ToUpper) Then
                    coincidenciasParciales += 1
                Else
                    If palabras.Contains(palabras(i)) Then
                        casiCoincidencias += 1
                    End If
                End If
            End If
        Next

        Console.WriteLine()

        Console.WriteLine($"Has acertado exactamente igual escritas {coincidenciasExactas}")
        Console.WriteLine($"Has acertado aunque diferente escritas {coincidenciasParciales}")
        Console.WriteLine($"Se encontraba pero en otra posición {casiCoincidencias}")

    End Sub

End Module
