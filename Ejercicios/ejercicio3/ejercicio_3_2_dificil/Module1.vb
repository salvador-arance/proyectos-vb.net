Module Module1

    Sub Main()
        Dim a, b, c As Double
        Dim readStr As String
        Dim validD As Boolean
        Dim x1 As Double
        Dim x2 As Double
        Dim discriminant As Double
        Dim repetir As Boolean
        Do
            Console.WriteLine("Ecuación de 2º grado")
            Do
                Console.Write("a: ")
                readStr = Console.ReadLine
                validD = Double.TryParse(readStr, a)
                If Not validD Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop Until validD
            Do
                Console.Write("b: ")
                readStr = Console.ReadLine
                validD = Double.TryParse(readStr, b)
                If Not validD Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop Until validD
            Do
                Console.Write("c: ")
                readStr = Console.ReadLine
                validD = Double.TryParse(readStr, c)
                If Not validD Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop Until validD

            If a = 0 Then
                If b = 0 Then
                    If c = 0 Then
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        Console.WriteLine("La ecuación 0 = 0 es siempre verdadera.")
                        Console.ResetColor()
                    Else
                        Console.ForegroundColor = ConsoleColor.DarkYellow
                        Console.WriteLine("La ecuación " & c & " = 0 es absurda, no tiene solución.")
                        Console.ResetColor()
                    End If
                Else
                    x1 = -c / b
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("La ecuación es lineal. Su solución es: " & x1)
                    Console.ResetColor()
                End If
            ElseIf b = 0 Then
                If (-c / a) > 0 Then
                    x1 = +(Math.Sqrt(-c / a))
                    x2 = -(Math.Sqrt(-c / a))
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("La solución es " & x1 & " y " & x2 & ". (No hay b).")
                    Console.ResetColor()
                ElseIf (-c / a) = 0 Then
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("La solución es 0. (No hay b).")
                    Console.ResetColor()
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("La ecuación no tiene solución real. (No hay b).")
                    Console.ResetColor()
                End If
            Else
                Console.WriteLine("Vamos a calcular...")
                discriminant = b ^ 2 - 4 * a * c
                If discriminant > 0 Then
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a)
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a)
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("La ecuación tiene dos soluciones reales: ")
                    Console.WriteLine("x1: " & x1 & " x2: " & x2)
                    Console.ResetColor()
                ElseIf discriminant = 0 Then
                    x1 = -b / (2 * a)
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("La solución doble es: " & x1)
                    Console.ResetColor()
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("La ecuación no tiene solución real.")
                    Console.ResetColor()
                End If
            End If
            Console.Write("Para repetir el programa pulse r, para acabar pulse cualquier tecla: ")
            readStr = Console.ReadLine
            If readStr = "r" Then
                repetir = True
            Else
                repetir = False
            End If
        Loop Until repetir = False
    End Sub

End Module
