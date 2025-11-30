Module Module1

    Sub Main()
        Dim num1, num2, num3 As Integer
        Dim readScr As String
        Console.Write("Número 1º: ")
        readScr = Console.ReadLine
        Integer.TryParse(readScr, num1)
        Console.Write("Número 2º: ")
        readScr = Console.ReadLine
        Integer.TryParse(readScr, num2)
        Console.Write("Número 3º: ")
        readScr = Console.ReadLine
        Integer.TryParse(readScr, num3)
        Console.WriteLine("El número 1 vale:  " & num1 & ",  el número 2 vale: " & num2 & " y el número 3 vale: " & num3)
    End Sub

End Module
