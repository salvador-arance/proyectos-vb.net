Module Module1

    Sub Main()
        Dim cadena1 As String
        Dim cadena2 As String
        Dim cadena3 As String
        Dim buleano As Boolean
        Dim subCadena1 As String
        Dim posicion As Byte
        Dim readStr As String
        Console.WriteLine("Comenzamos introduciendo dos cadenas para comparar si son iguales")
        Console.Write("introduce cadena1: ")
        cadena1 = Console.ReadLine
        Console.Write("Introduce cadena2: ")
        cadena2 = Console.ReadLine
        buleano = (cadena1.Length = cadena2.Length)
        Console.WriteLine("¿El tamaño de ambas cadenas es el mismo? " & buleano)
        buleano = cadena1 Like cadena2
        Console.WriteLine("¿cadena1 y cadena2 son exactamente iguales? " & buleano)
        Console.WriteLine("¿cadena1 y cadena 2 son iguales pero escritas de forma distinta? " & cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase))
        Console.WriteLine()
        Console.Write("Introduce una subcadena que quieras insertar en cadena1: ")
        subCadena1 = Console.ReadLine
        Console.Write("Posición a partir de la que quieres que se inserte (En un número natural): ")
        readStr = Console.ReadLine
        Byte.TryParse(readStr, posicion)
        Console.WriteLine("Ahora cadena1 vale: " & cadena1.Insert(posicion, subCadena1))
        Console.WriteLine()
        Console.WriteLine("Las siguientes comparaciones deben funcionar como si minúsculas y mayúsculas fueran iguales")
        Console.Write("Introduce cadena2 <para ver si está en cadena1>: ")
        cadena3 = Console.ReadLine

    End Sub

End Module