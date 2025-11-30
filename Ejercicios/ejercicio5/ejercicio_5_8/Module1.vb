Module Module1

    Sub Main()
        Dim entrada As String
        Dim listaDePares As String = ""
        Dim numeroMenor, numeroMayor, ultimoPar, primerPar, total, numPar As Integer

        'Bucle de validación principal.
        Do

            'Bucle de validación 1
            Do
                Console.Write("Número menor (>0): ")
                entrada = Console.ReadLine
                If Not (Integer.TryParse(entrada, numeroMenor) AndAlso numeroMenor > 0) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop Until Integer.TryParse(entrada, numeroMenor) AndAlso numeroMenor > 0

            'Bucle de validación 2
            Do
                Console.Write("Número mayor (>" & numeroMenor & "): ")
                entrada = Console.ReadLine
                If Not (Integer.TryParse(entrada, numeroMayor) AndAlso numeroMayor > numeroMenor) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido. El número mayor debe ser mayor al menor")
                    Console.ResetColor()
                End If
            Loop Until Integer.TryParse(entrada, numeroMayor)

        Loop Until numeroMayor > numeroMenor

        'Saco el primer par y el último par.
        If numeroMenor Mod 2 = 0 Then
            primerPar = numeroMenor
        Else
            primerPar = numeroMenor + 1
        End If

        If numeroMayor Mod 2 = 0 Then
            ultimoPar = numeroMayor
        Else
            ultimoPar = numeroMayor - 1
        End If

        'Preparo las variables para los cálculos
        total = 0
        numPar = primerPar

        'Bucle para crear la lista de pares, y calcular su suma a partir de incrementos.
        Do
            If primerPar = numPar Then
                listaDePares &= " " & numPar.ToString
            Else
                listaDePares &= " + " & numPar.ToString
            End If
            total += numPar
            numPar += 2
        Loop While numPar <= ultimoPar

        Console.WriteLine("La suma de los pares entre " & numeroMenor & " y " & numeroMayor & " =" & listaDePares & " = " & total)

    End Sub

End Module
