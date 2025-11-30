Module Module1

    Sub Main()
        Dim todayDate As Date = Today
        Dim birthDay As Date
        Dim age As Byte
        Dim name As String
        Dim readStr As String
        Dim validDate As Boolean

        Console.WriteLine("Fecha actual: " & todayDate)
        Console.Write("Introduce el nombre: ")
        name = Console.ReadLine
        Do
            Console.Write("Fecha de nacimiento (formato dd/mm/aaaa): ")
            readStr = Console.ReadLine
            validDate = Date.TryParse(readStr, birthDay)
            If Not validDate Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Por favor, escribe una fecha válida!")
                Console.ResetColor()
            ElseIf birthDay > todayDate Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("La fecha introducida no puede ser futura!")
                Console.ResetColor()
                validDate = False
            End If
        Loop Until validDate
        age = todayDate.Year - birthDay.Year
        If (birthDay.Month > todayDate.Month Or (birthDay.Month = todayDate.Month And birthDay.Day > todayDate.Day)) Then
            age -= 1
        End If
        Console.WriteLine(name & " tienes " & age & " años. ")

        If (birthDay.Month = todayDate.Month And birthDay.Day = birthDay.Day) Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("¡¡Felicidades, " & name & " es tu " & age & " cumpleaños!!")
            Console.ResetColor()
        End If
    End Sub

End Module
