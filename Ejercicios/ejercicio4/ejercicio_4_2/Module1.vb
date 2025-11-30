Module Module1

    Sub Main()
        Dim date1 As Date
        Dim language1 As String
        Dim readStr As String
        Dim mes As String
        Dim diaSemana As String
        Dim mesIngles As String = ""
        Dim diaIngles As String = ""

        Console.Write("Introduce una fecha: ")
        readStr = Console.ReadLine
        If Not Date.TryParse(readStr, date1) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Fecha incorrecta. El programa va a finalizar.")
            Exit Sub
        End If
        Console.Write("Introduce un idioma (<ingles> o <castellano>): ")
        language1 = Console.ReadLine
        language1 = language1.ToLower
        If Not (language1 = "ingles" Or language1 = "castellano") Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No has introducido un idioma válido. El programa se va a cerrar.")
            Exit Sub
        End If

        Select Case language1
            Case "castellano"
                Console.WriteLine(date1.ToLongDateString)
            Case "ingles"
                diaSemana = date1.DayOfWeek
                Select Case date1.DayOfWeek
                    Case DayOfWeek.Friday : diaIngles = "Friday"
                End Select
                mes = date1.ToString("MMMM").ToLower
                Select Case diaSemana.ToLower
                    Case "1" : diaIngles = "Monday"
                    Case "2" : diaIngles = "Tuesday"
                    Case "3" : diaIngles = "Wednesday"
                    Case "4" : diaIngles = "Thursday"
                    Case "5" : diaIngles = "Friday"
                    Case "6" : diaIngles = "Saturday"
                    Case "0" : diaIngles = "Sunday"
                End Select
                Select Case mes
                    Case "enero" : mesIngles = "January"
                    Case "febrero" : mesIngles = "February"
                    Case "marzo" : mesIngles = "March"
                    Case "abril" : mesIngles = "April"
                    Case "mayo" : mesIngles = "May"
                    Case "junio" : mesIngles = "June"
                    Case "julio" : mesIngles = "July"
                    Case "agosto" : mesIngles = "August"
                    Case "septiembre" : mesIngles = "September"
                    Case "octubre" : mesIngles = "October"
                    Case "noviembre" : mesIngles = "November"
                    Case "diciembre" : mesIngles = "December"
                End Select
                Console.WriteLine(diaIngles & ", " & date1.Day & " of " & mesIngles & " of " & date1.Year)

        End Select
    End Sub

End Module
