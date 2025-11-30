Module Module1

    Sub Main()
        Dim precioCurso As Decimal
        Dim sueldo As Decimal
        Dim situacionLaboral As String
        Dim descuentoSueldo As Decimal
        Dim descuentoFamilia As Decimal
        Dim familiares As Byte
        Dim readStr As String
        Console.Write("Precio cursillo: ")
        readStr = Console.ReadLine
        If Not Decimal.TryParse(readStr, precioCurso) OrElse precioCurso <= 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No has introducido un número coherente.")
            Exit Sub
        End If
        Console.Write("Trabajas/Estudias/Paro/Erte(T/E/P/R): ")
        readStr = Console.ReadLine
        situacionLaboral = readStr.ToUpper
        If Not (situacionLaboral = "T" Or situacionLaboral = "E" Or situacionLaboral = "P" Or situacionLaboral = "R") Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No has introducido una opción válida.")
            Exit Sub
        End If
        Select Case situacionLaboral
            Case "E", "R", "P"
                precioCurso = 0
            Case "T"
                Console.Write("¿Cuánto es tu sueldo?: ")
                readStr = Console.ReadLine
                If Not Decimal.TryParse(readStr, sueldo) Or sueldo < 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("No has introducido una cifra de sueldo correcta.")
                    Exit Sub
                End If
                Select Case sueldo
                    Case Is < 500
                        descuentoSueldo = 0.5
                    Case Is < 1000
                        descuentoSueldo = 0.2
                    Case Is < 1500
                        descuentoSueldo = 0.1
                    Case Else
                        descuentoSueldo = 0
                End Select
                Console.Write("¿Cuántos familires tienes matriculados en el instituto?: ")
                readStr = Console.ReadLine
                If Not Byte.TryParse(readStr, familiares) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Lo siento, la cantidad de familiares debe ser 0 o más.")
                    Exit Sub
                ElseIf familiares > 8 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("No es posible que tengas tantos familiares.")
                    Exit Sub
                End If
                Select Case familiares
                    Case 0
                        descuentoFamilia = 0
                    Case 1
                        descuentoFamilia = 0.1
                    Case 2
                        descuentoFamilia = 0.2
                    Case Is >= 3
                        descuentoFamilia = 0.5
                End Select
                precioCurso = precioCurso - (precioCurso * descuentoFamilia) - (precioCurso * descuentoSueldo)
        End Select
        Console.WriteLine("El precio final del curso es: " & precioCurso & " euros.")
    End Sub

End Module