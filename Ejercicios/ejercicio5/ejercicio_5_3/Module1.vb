
Imports System.Runtime.CompilerServices

Module Module1

    Sub Main()
        Dim suma As Decimal = 0
        Dim numero As Decimal
        Dim contador As Integer = 0
        Dim entrada As String
        Dim posX As Integer
        Dim posY As Integer
        Do
            Do
                Console.Write("Introduce número" & " " & (contador + 1) & ": ")
                posX = Console.CursorLeft
                posY = Console.CursorTop
                Console.ForegroundColor = ConsoleColor.Blue
                entrada = Console.ReadLine
                Console.ResetColor()

                If Decimal.TryParse(entrada, numero) Then
                    Exit Do
                Else
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce un número correcto.")
                    Console.ResetColor()
                End If
            Loop

            Do
                Console.Write("    ¿Deseas otro número (S/N)?: ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine.ToUpper
                Console.ResetColor()
                If Not (entrada = "S" OrElse entrada = "N") Then
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N.")
                    Console.ResetColor()
                Else
                    Exit Do
                End If
            Loop

            suma += numero
            contador += 1

        Loop While entrada = "S"
        Console.WriteLine("La suma de los " & contador & " número/s es " & suma & ".")

    End Sub

End Module
