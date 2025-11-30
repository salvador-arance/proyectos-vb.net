Module Module1

    Sub Main()
        Dim todayDate As Date = Today
        Dim birthDay As Date
        Dim name As String
        Dim readStr As String
        Dim valid As Boolean
        Dim edad As Byte
        Console.WriteLine("Fecha actual: " & todayDate)
        Console.Write("Introduce el nombre: ")
        name = Console.ReadLine
        Console.Write("Introduce tu fecha de nacimiento: ")
        readStr = Console.ReadLine
        valid = Date.TryParse(readStr, birthDay)
        If Not valid Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No has introducido una fecha válida")
            Console.ResetColor()
            Exit Sub
        ElseIf birthDay > todayDate Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("La fecha de tu nacimiento no puede ser en el futuro.")
            Console.ResetColor()
            Exit Sub
        Else
            edad = todayDate.Year - birthDay.Year
            If (birthDay.Month > todayDate.Month Or (birthDay.Month = todayDate.Month And birthDay.Day > todayDate.Day)) Then
                edad -= 1
            End If
            Console.WriteLine(name & " tienes " & edad & " años.")
            If (birthDay.Month = todayDate.Month And birthDay.Day = todayDate.Day) Then
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("¡¡Felicidades " & name & " por tu " & edad & " cumpleaños!!")
                Console.ResetColor()
            End If
        End If
    End Sub

End Module
