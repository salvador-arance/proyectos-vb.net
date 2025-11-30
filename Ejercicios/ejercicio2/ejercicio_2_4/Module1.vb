Module Module1

    Sub Main()
        Dim Texto As String
        Dim search As String
        Console.Write("Introduce un texto --> ")
        Console.ForegroundColor = ConsoleColor.Blue
        Texto = Console.ReadLine
        Console.ResetColor()
        Console.WriteLine("El texto introducido es -->  " & Texto)
        Console.WriteLine(" En mayúsculas es --> " & Texto.ToUpper)
        Console.WriteLine(" En minúsuclas es --> " & Texto.ToLower)
        Console.WriteLine("El texto: " & Texto & " tiene " & Texto.Count & " caracteres.")
        Console.WriteLine()
        Console.Write("Introduce un texto a buscar en el anterior: ")
        Console.ForegroundColor = ConsoleColor.Blue
        search = Console.ReadLine
        Console.ResetColor()
        Console.WriteLine("¿El texto " & Texto & " contiene " & search & "? --> " & Texto.Contains(search))
        Console.Write("Introduce un texto o caracter a reemplazar en el texto original --> ")
        Console.ForegroundColor = ConsoleColor.Blue
        Dim replaced As String = Console.ReadLine
        Console.ResetColor()
        Console.Write("Ahora introduce el texto o caracter por el que se reemplzará --> ")
        Console.ForegroundColor = ConsoleColor.Blue
        Dim replace As String = Console.ReadLine
        Console.ResetColor()
        Console.WriteLine("El texto original es -> " & Texto & " y si reemplazamos: " & replaced & " por: " & replace & " tenemos: " & Texto.Replace(replaced, replace))
        Console.WriteLine("¿La variable inicial REALMENTE ha cambiado de valor? Si escribo su valor tiene: " & Texto)
    End Sub

End Module
