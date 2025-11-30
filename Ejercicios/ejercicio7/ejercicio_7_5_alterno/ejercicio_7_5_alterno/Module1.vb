Imports System.Xml.Schema

Module Module1

    Sub Main()
        Dim entrada As String
        Dim numeroDeFrases As Integer
        Dim maxLong As Integer
        Dim minLong As Integer
        Dim indiceLargas As Integer
        Dim indiceCortas As Integer
        Dim contLargas As Integer
        Dim contCortas As Integer
        Dim valido As Boolean

        Do

            Do
                Console.Write("Introduce el número de frases que quieres introducir: ")

                Console.ForegroundColor = ConsoleColor.Blue
                entrada = Console.ReadLine()
                valido = Integer.TryParse(entrada, numeroDeFrases) AndAlso numeroDeFrases > 0

                If Not valido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, debe ser un número entero positivo.")
                    Console.ResetColor()
                End If

            Loop While Not valido

            Dim frases(numeroDeFrases - 1) As String

            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine($"Introduce {numeroDeFrases} frases")
            Console.ResetColor()

            For i = 0 To frases.Length - 1
                Do
                    Console.Write($"Frase número {i + 1}: ")

                    Console.ForegroundColor = ConsoleColor.Blue
                    frases(i) = Console.ReadLine()
                    Console.ResetColor()

                    valido = Not String.IsNullOrWhiteSpace(frases(i))

                    If Not valido Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Por favor, la frase no puede estar vacía.")
                        Console.ResetColor()
                    End If
                Loop While Not valido
            Next

            For Each frase In frases
                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($"{frase}. ")
                Console.ResetColor()

                Console.Write("En mayúsculas es: ")

                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($"{frase.ToUpper} ")
                Console.ResetColor()

                Console.Write("Tiene: ")

                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($"{frase.Length} ")
                Console.ResetColor()

                Console.WriteLine("caracteres.")
            Next


            maxLong = frases(0).Length
            minLong = frases(0).Length

            For Each frase In frases
                If frase.Length > maxLong Then maxLong = frase.Length
                If frase.Length < minLong Then minLong = frase.Length
            Next

            contLargas = 0
            contCortas = 0

            For Each frase In frases
                If frase.Length = maxLong Then contLargas += 1
                If frase.Length = minLong Then contCortas += 1
            Next

            Dim frasesLargas(contLargas - 1) As String
            Dim frasesCortas(contCortas - 1) As String

            indiceLargas = 0
            indiceCortas = 0

            For Each frase In frases
                If frase.Length = maxLong Then
                    frasesLargas(indiceLargas) = frase
                    indiceLargas += 1
                End If
                If frase.Length = minLong Then
                    frasesCortas(indiceCortas) = frase
                    indiceCortas += 1
                End If
            Next

            Console.WriteLine("Frases más largas: ")
            Console.ForegroundColor = ConsoleColor.Blue

            For Each frase In frasesLargas
                Console.WriteLine(frase)
            Next
            Console.ResetColor()

            Console.WriteLine("Frases más cortas: ")

            Console.ForegroundColor = ConsoleColor.Blue

            For Each frase In frasesCortas
                Console.WriteLine(frase)
            Next
            Console.ResetColor()

            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.Write("Pulsa cualquier tecla para continuar...")
            Console.ResetColor()
            Console.ReadKey()
            Console.Clear()

        Loop


    End Sub

End Module
