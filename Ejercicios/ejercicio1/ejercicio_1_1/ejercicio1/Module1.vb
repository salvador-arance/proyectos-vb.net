Module Module1

    Sub Main()
        Dim nombre As String
        Dim apellido1 As String
        Dim apellido2 As String
        Console.WriteLine("Saludando ")
        Console.Write("¿Cuál es tu nombre?: ")
        nombre = Console.ReadLine
        Console.Write("¿Cuál es tu primer apellido?: ")
        apellido1 = Console.ReadLine
        Console.Write("¿Cuál es tu segundo apellido?: ")
        apellido2 = Console.ReadLine
        Console.Write("Hola " & nombre & " " & apellido1 & " " & apellido2)
    End Sub

End Module
