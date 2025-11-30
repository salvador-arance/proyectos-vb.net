Module Module1

    Sub Main()
        Dim number1 As Integer
        Dim number2 As Integer
        Dim readStr As String
        Console.WriteLine("Introduce dos números enteros:")
        Console.Write("Primer Número: ")
        readStr = Console.ReadLine
        Integer.TryParse(readStr, number1)
        Console.Write("Segundo Número: ")
        readStr = Console.ReadLine
        Integer.TryParse(readStr, number2)
        Console.WriteLine("El primer número vale: " & number1 & " y el segundo número:" & number2)
        Console.WriteLine("Suma: " & number1 + number2)
        Console.WriteLine("Resta: " & number1 - number2)
        Console.WriteLine("Producto: " & number1 * number2)
        Console.WriteLine("División Real: " & number1 / number2)
        Console.WriteLine("Cociente de la divisón enetera: " & number1 \ number2)
        Console.WriteLine("Resto de la división entera: " & number1 Mod number2)
        Console.WriteLine("Potencia: " & number1 ^ number2)
    End Sub

End Module
