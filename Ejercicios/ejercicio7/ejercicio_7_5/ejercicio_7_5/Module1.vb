Module Module1

    Sub Main()
        Dim entrada As String
        Dim contador1 As Integer
        Dim contador2 As Integer

        Dim numeroDeFrases As Integer
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

            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine($"Introduce {numeroDeFrases} frases")
            Console.ResetColor()

            numeroDeFrases -= 1

            Dim frases(numeroDeFrases) As String
            Dim frasesLargas(numeroDeFrases) As String
            Dim frasesCortas(numeroDeFrases) As String

            For i = 0 To frases.Length - 1

                Do
                    Console.Write($"Frase número {i + 1}: ")

                    Console.ForegroundColor = ConsoleColor.Blue
                    frases(i) = Console.ReadLine
                    Console.ResetColor()

                    valido = Not String.IsNullOrEmpty(frases(i))

                    If Not valido Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Por favor, la frase no puede estar vacía.")
                        Console.ResetColor()
                    End If

                Loop While Not valido
            Next

            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("Las frases introducidas son: ")
            Console.ResetColor()


            For i = 0 To frases.Length - 1
                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($"{frases(i)}. ")
                Console.ResetColor()

                Console.Write("En mayúsculas es: ")

                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($"{frases(i).ToUpper} ")
                Console.ResetColor()

                Console.Write("Tiene: ")

                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($"{frases(i).Length} ")
                Console.ResetColor()

                Console.WriteLine("caracteres.")

                If i = 0 Then
                    frasesCortas(i) = frases(i)
                    frasesLargas(i) = frases(i)
                Else
                    If frases(i).Length >= frasesLargas(i - 1).Length Then

                        If frases(i).Length > frasesLargas(i - 1).Length Then
                            frasesLargas(i - 1) = frases(i)
                            contador1 = 1
                        Else
                            frasesLargas(i) = frases(i)
                            contador1 = +1
                        End If

                    End If

                    If frases(i).Length <= frasesCortas(i - 1).Length Then

                        If frases(i).Length < frasesCortas(i - 1).Length Then
                            frasesCortas(i - 1) = frases(i)
                            contador2 = 1
                        Else
                            frasesCortas(i) = frases(i)
                            contador2 += 1
                        End If

                    End If

                End If

            Next


            ReDim Preserve frasesLargas(contador1)
            ReDim Preserve frasesCortas(contador2)

            Console.Write("Frases largas: ")
            For i = 0 To frasesLargas.Length - 1
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine(frasesLargas(i))
                Console.ResetColor()
            Next
            Console.WriteLine()

            Console.Write("Frases cortas: ")
            For i = 0 To frasesCortas.Length - 1
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine(frasesCortas(i))
                Console.ResetColor()
            Next
            Console.WriteLine()

            Console.ForegroundColor = ConsoleColor.Magenta
            Console.Write("Pulsa cualquier tecla para continuar...")
            Console.ResetColor()

            Console.ReadKey()

            Console.Clear()
        Loop
    End Sub

End Module
