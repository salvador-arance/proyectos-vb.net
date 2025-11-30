Module Module1

    Sub Main()
        Dim date1 As Date
        Dim readStr As String
        Dim valid As Boolean
        Dim repetir As Boolean
        Dim age As Byte
        Do
            Do
                Console.Write("Dime tu fecha de nacimiento: ")
                readStr = Console.ReadLine
                valid = Date.TryParse(readStr, date1)
                If Not valid Then
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.WriteLine("Por favor, introduce una fecha válida (en formato fecha.)")
                    Console.ResetColor()
                ElseIf date1 > Today Then
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.WriteLine("Por favor, la fecha que no sea futura, porfa.")
                    Console.ResetColor()
                    valid = False
                End If
            Loop Until valid
            Console.WriteLine("Enhorabuena, fecha válida.")
            Console.WriteLine("El día de la semana era: " & date1.DayOfWeek)
            Console.WriteLine("El día de la semana era (en inglés): " & date1.DayOfWeek.ToString)
            Console.WriteLine("El día de la semana (aparace en español): " & date1.ToString("dddd", New Globalization.CultureInfo("es-ES")))
            Select Case date1.DayOfWeek
                Case 1
                    Console.WriteLine("Lunes")
                Case 2
                    Console.WriteLine("Martes")
                Case 3
                    Console.WriteLine("Miércoles")
                Case 4
                    Console.WriteLine("Jueves")
                Case 5
                    Console.WriteLine("Viernes")
                Case 6
                    Console.WriteLine("Sábado")
                Case 0
                    Console.WriteLine("Domingo")
            End Select
            age = Today.Year - date1.Year
            If (date1.Month > Today.Month) OrElse (date1.Month = Today.Month AndAlso date1.Day) > Today.Day Then
                age -= 1
            End If
            Console.WriteLine("Tienes " & age & " años.")
            If age < 2 Then
                Console.WriteLine("Eres una criatura enana.")
            ElseIf age >= 2 AndAlso age < 11 Then
                Console.WriteLine("Disfrutas de la más plena infancia")
            ElseIf age >= 12 AndAlso age < 18 Then
                Console.WriteLine("Bregas con los demonios de la adolescencia.")
            ElseIf age >= 18 AndAlso age < 25 Then
                Console.WriteLine("¿Disfrutando de la vida adulta?")
            ElseIf age >= 25 AndAlso age < 40 Then
                Console.WriteLine("Se te va a pasar el arroz")
            ElseIf age >= 40 AndAlso age < 65 Then
                Console.WriteLine("Va quedando menos para jubilarse")
            ElseIf age >= 65 AndAlso age < 123 Then
                Console.WriteLine("Va quedando menos, en general")
            ElseIf age > 122 Then
                Console.WriteLine("No me puedo creer que sigas con vida.")
            End If
            Select Case age
                Case 0, 1
                    Console.WriteLine("Eres un bebé.")
                Case 2 To 11
                    Console.WriteLine("Eres un niño. O niña.")
                Case 12 To 17
                    Console.WriteLine("Estás en la adolescencia.")
                Case 18 To 25
                    Console.WriteLine("Eres una persona joven adulta.")
                Case 26 To 60
                    Console.WriteLine("Eres una persona completamente adulta.")
                Case 61 To 122
                    Console.WriteLine("Transitas hasta la vejez.")
                Case > 123
                    Console.WriteLine("Es imposible que sigas con vida. Me has mentido :(")
            End Select
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.Write("Por favor, si quiere introducir otra fecha introduzca <r>, para finalizar el programa introduzca cualquier otra cosa: ")
            Console.ResetColor()
            readStr = Console.ReadLine
            If readStr = "r" Then
                repetir = True
            Else
                repetir = False
            End If
        Loop Until repetir = False
    End Sub

End Module
