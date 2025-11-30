Imports System.Runtime.CompilerServices

Module Module1

    Sub Main()
        Dim entrada As String
        Dim numTextos As Integer = 0
        Dim datoValido As Boolean
        Dim posFrase As Integer
        Dim esElemento As Boolean
        Dim estaEnFrase As Boolean
        Dim pararBusqueda As Boolean = False

        Do
            Console.Write("Número de textos: ")

            entrada = Console.ReadLine
            datoValido = Integer.TryParse(entrada, numTextos) AndAlso numTextos > 0

            If Not datoValido Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("No has introducido un número de textos válido")
                Console.ResetColor()
            End If
        Loop While Not datoValido

        Dim textos(numTextos - 1) As String

        For i = 0 To numTextos - 1

            Do
                Console.Write($"Texto {i + 1}: ")
                textos(i) = Console.ReadLine
                datoValido = Not String.IsNullOrWhiteSpace(textos(i))
                If Not datoValido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce una frase que no esté vacía.")
                    Console.ResetColor()
                End If

            Loop While Not datoValido
        Next

        Do
            Console.Clear()

            Console.Write("Introduce el texto a buscar: ")
            entrada = Console.ReadLine

            esElemento = False
            estaEnFrase = False

            For i = 0 To numTextos - 1

                If textos(i).Equals(entrada) Then
                    esElemento = True
                    Console.WriteLine($"El texto '{entrada}' es exactamente el elemento {i + 1} del array.")
                End If



                If textos(i).Contains(entrada) AndAlso textos(i) <> entrada Then
                    estaEnFrase = True
                    posFrase = textos(i).IndexOf(entrada)
                    Console.WriteLine($"El texto '{entrada}' aparece en la frase {i + 1} en la posición {posFrase + 1}.")
                End If
            Next

            If Not esElemento AndAlso Not estaEnFrase Then
                Console.WriteLine($"El texto '{entrada}' no se encuentra en ningún elemento del array.")
            End If

            Do
                Console.Write("¿Otra búsqueda? (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If entrada <> "S" AndAlso entrada <> "N" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While (entrada <> "S" AndAlso entrada <> "N")

            If entrada = "N" Then
                pararBusqueda = True
            End If

        Loop While Not pararBusqueda



    End Sub

End Module
