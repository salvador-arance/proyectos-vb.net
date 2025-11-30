Module Module1

    Sub Main()
        Dim fechaInicio As Date = #9/10/2025#
        Dim fechaFin As Date = #6/18/2026#
        Dim fechaAleatoria1 As Date
        Dim fechaAleatoria2 As Date
        Dim readStr As String
        Dim repetir As Boolean
        Do
            Console.WriteLine("El curso ha comenzado el " & fechaInicio & " y finalizará el " & fechaFin & " tras " & fechaFin.Subtract(fechaInicio).Days & " días.")
            Console.Write("Introduce fecha para analizar: ")
            readStr = Console.ReadLine
            Date.TryParse(readStr, fechaAleatoria1)
            Console.WriteLine("La variable de fecha vale " & fechaAleatoria1.ToString)
            Console.WriteLine("En formato corto con ToShortDateString: " & fechaAleatoria1.ToShortDateString)
            Console.WriteLine("En formato largo con ToLongDateSring: " & fechaAleatoria1.ToLongDateString)
            Console.WriteLine("Veamos ahora los datos por separado: ")
            Console.WriteLine("Día: " & fechaAleatoria1.Day)
            Console.WriteLine("Mes: " & fechaAleatoria1.Month.ToString)
            Console.WriteLine("Año: " & fechaAleatoria1.Year)
            Console.WriteLine("Día de la semana (aparece en número: " & fechaAleatoria1.DayOfWeek)
            Console.WriteLine("Día de la semana (aparece en inglés): " & fechaAleatoria1.DayOfWeek.ToString)
            Console.WriteLine("Día de la semana (aparace en español): " & fechaAleatoria1.ToString("dddd", New Globalization.CultureInfo("es-ES")))
            Console.WriteLine("Fecha larga (aparece en euskera: )" & fechaAleatoria1.ToString("dddd", New Globalization.CultureInfo("eu-ES")))
            Console.WriteLine("Si le sumamos 1 día a la nueva fecha (escrita en formato largo) es: " & fechaAleatoria1.AddDays(1).ToLongDateString)
            Console.WriteLine("Si le sumamos 1 mes será: " & fechaAleatoria1.AddMonths(1))
            Console.WriteLine("Si le sumamos 1 año será: " & fechaAleatoria1.AddYears(1))
            Console.WriteLine("La fecha finalmente es: " & fechaAleatoria1)
            Console.Write("Introduce otra fecha (que sea posterior a la anterior) para operar entre ambas: ")
            readStr = Console.ReadLine
            Date.TryParse(readStr, fechaAleatoria2)
            Console.WriteLine("Entre las dos fechas hay una diferencia de: " & fechaAleatoria2.Subtract(fechaAleatoria1).Days & " días.")
            Console.Write("Para volver a empezar, introduzca <r>, para cerrar el programa pulse cualquier otra tecla: ")
            readStr = Console.ReadLine
            If readStr = "r" Then
                repetir = True
            Else
                repetir = False
            End If
        Loop Until repetir = False
    End Sub

End Module
