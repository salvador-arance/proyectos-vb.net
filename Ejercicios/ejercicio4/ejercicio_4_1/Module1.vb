Module Module1

    Sub Main()
        Dim num1, num2, result As Decimal
        Dim readStr As String
        Console.WriteLine("Calculadora")
        Console.Write("Número 1: ")
        readStr = Console.ReadLine
        If Not Decimal.TryParse(readStr, num1) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Has introducido un valor no válido.")
            Exit Sub
        End If
        Console.Write("Número 2: ")
        readStr = Console.ReadLine
        If Not Decimal.TryParse(readStr, num2) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Has introducido un valor no válido.")
            Exit Sub
        End If
        Console.WriteLine("Indica la operación que deseas realizar:")
        Console.Write("Suma/Resta/Producto/División Real/División Entera: ")
        readStr = Console.ReadLine
        readStr = readStr.ToLower
        If Not (readStr = "suma" Or readStr = "resta" Or readStr = "producto" Or readStr = "división real" Or readStr = "división entera") Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("No has seleccionado una opción válida/No la has escrito bien. El programa va a finalizar.")
            Exit Sub
        End If
        Console.ForegroundColor = ConsoleColor.Blue
        Select Case readStr
            Case "suma"
                result = num1 + num2
                Console.WriteLine("Resultado: " & num1 & " + " & num2 & " = " & result)
            Case "resta"
                result = num1 - num2
                Console.WriteLine("Resultado: " & num1 & " - " & num2 & " = " & result)
            Case "producto"
                result = num1 * num2
                Console.WriteLine("Resultado: " & num1 & " * " & num2 & " = " & result)
            Case "división real"
                If (num2 = 0) Then
                    Console.WriteLine("No se puede dividir entre 0. Finalizando el programa.")
                    Exit Sub
                End If
                result = num1 / num2
                Console.WriteLine("Resultado: " & num1 & " / " & num2 & " = " & result)
            Case "división entera"
                If (num2 = 0) Then
                    Console.WriteLine("No se puede dividir entre 0. Finalizando el programa.")
                    Exit Sub
                End If
                result = num1 \ num2
                Console.WriteLine("Resultado: " & num1 & " \ " & num2 & " = " & result)
        End Select
        Console.ResetColor()
    End Sub

End Module
