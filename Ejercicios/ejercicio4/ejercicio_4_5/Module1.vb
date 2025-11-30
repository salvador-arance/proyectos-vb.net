Imports System.CodeDom

Module Module1

    Sub Main()
        Dim dni As String
        Dim primerosDigitosDni As Integer
        Dim restoParaLetra As Integer
        Dim letra As Char
        Console.Write("Introduce tu DNI: ")
        dni = Console.ReadLine
        If Not dni.Length = 9 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("El DNI tiene 9 caracteres, no " & dni.Length & ".")
            Console.ResetColor()
            Exit Sub
        Else
            If Not (Integer.TryParse(dni.Substring(0, 8), primerosDigitosDni) AndAlso Char.IsLetter(dni.Substring(8))) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Los primeros 8 dígitos deben ser números y el último una letra.")
                Console.ResetColor()
                Exit Sub
            Else
                restoParaLetra = primerosDigitosDni Mod 23
                    Select Case restoParaLetra
                        Case 0
                            letra = "T"
                        Case 1
                            letra = "R"
                        Case 2
                            letra = "W"
                        Case 3
                            letra = "A"
                        Case 4
                            letra = "G"
                        Case 5
                            letra = "M"
                        Case 6
                            letra = "Y"
                        Case 7
                            letra = "F"
                        Case 8
                            letra = "P"
                        Case 9
                            letra = "D"
                        Case 10
                            letra = "X"
                        Case 11
                            letra = "B"
                        Case 12
                            letra = "N"
                        Case 13
                            letra = "J"
                        Case 14
                            letra = "Z"
                        Case 15
                            letra = "S"
                        Case 16
                            letra = "Q"
                        Case 17
                            letra = "V"
                        Case 18
                            letra = "H"
                        Case 19
                            letra = "L"
                        Case 20
                            letra = "C"
                        Case 21
                            letra = "K"
                        Case 22
                            letra = "E"
                    End Select
                If Not dni.Substring(8).ToUpper = letra Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("La letra del DNI no es válida.")
                Else
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("DNI Válido.")
                    Console.ResetColor()
                End If
                End If
            End If

    End Sub

End Module
