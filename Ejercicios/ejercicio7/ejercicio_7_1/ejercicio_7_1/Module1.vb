Imports System.Runtime.InteropServices

Module Module1

    Sub Main()
        Dim numeros(7) As Integer
        Dim valido, hayPares, hayNegativos As Boolean
        Dim entrada, numIntroducidos, numPares, numNegativos As String
        Dim numMayor, numMenor, sumaParaMedia As Integer
        Dim mediaArit As Decimal

        Do
            Console.WriteLine($"Introduce {numeros.Length} números enteros.")

            sumaParaMedia = 0
            numMayor = 0
            numMenor = 0
            numPares = ""
            numNegativos = ""
            numIntroducidos = ""
            hayPares = False
            hayNegativos = False

            For i = 0 To (numeros.Length - 1)

                Do
                    Console.Write($"Numero {i + 1}: ")
                    Console.ForegroundColor = ConsoleColor.Blue
                    entrada = Console.ReadLine()
                    Console.ResetColor()

                    valido = Integer.TryParse(entrada, numeros(i))

                    If Not valido Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("No has introducido un número válido.")
                        Console.ResetColor()
                    End If
                Loop While Not valido

                numIntroducidos &= $"{numeros(i)} "

                If numeros(i) < 0 Then
                    numNegativos &= $"{numeros(i)} "
                    hayNegativos = True
                End If

                If numeros(i) Mod 2 = 0 Then
                    numPares &= $"{numeros(i)} "
                    hayPares = True
                End If

                If i = 0 Then
                    numMayor = numeros(i)
                    numMenor = numeros(i)
                Else
                    If numeros(i) > numMayor Then
                        numMayor = numeros(i)
                    End If

                    If numeros(i) < numMenor Then
                        numMenor = numeros(i)
                    End If
                End If

                sumaParaMedia += numeros(i)

            Next

            mediaArit = sumaParaMedia / numeros.Length

            Console.Write("Los números introducidos son: ")

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(numIntroducidos)
            Console.ResetColor()

            Console.Write("Los números pares son: ")

            If hayPares Then
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine(numPares)
                Console.ResetColor()
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Ninguno.")
                Console.ResetColor()
            End If

            Console.Write("Los números negativos son: ")

            If hayNegativos Then
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine(numNegativos)
                Console.ResetColor()
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Ninguno.")
                Console.ResetColor()
            End If

            Console.ForegroundColor = ConsoleColor.Green

            Console.WriteLine($"Máximo número: {numMayor}")
            Console.WriteLine($"Máximo número (MaxValue) {numeros.Max}")

            Console.WriteLine($"Mínimo número: {numMenor}")
            Console.WriteLine($"Mínimo número (MinValue): {numeros.Min}")

            Console.WriteLine($"Media aritmética: {mediaArit}")
            Console.WriteLine($"Media aritmética (Average): {numeros.Average}")

            Console.WriteLine($"La suma de todos los números es: {numeros.Sum}")

            Console.ResetColor()

            Console.ForegroundColor = ConsoleColor.Magenta
            Console.Write("Pulsa cualquier tecla para continuar...")
            Console.ResetColor()
            Console.ReadKey()

            Console.Clear()
        Loop

    End Sub

End Module
