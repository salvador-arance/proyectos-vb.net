Module Module1

    Sub Main()
        Dim alumnado, votosP, votosN, votosT As Integer
        Dim porcentajeP As Decimal
        Dim readStr As String
        Console.WriteLine("Convocatoria de huelga")
        Console.Write("Alumnado matriculado: ")
        readStr = Console.ReadLine
        If Not Integer.TryParse(readStr, alumnado) OrElse alumnado <= 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No ha introducido un valor válido.")
            Exit Sub
        End If
        Console.Write("Introduzca la cantidad de votos a favor de la huelga: ")
        readStr = Console.ReadLine
        If Not Integer.TryParse(readStr, votosP) OrElse votosP < 0 OrElse votosP > alumnado Then
            Console.WriteLine("No ha introducido un valor válido.")
            Exit Sub
        End If
        Console.Write("Introduzca la cantidad de votos en contra de la huelga: ")
        readStr = Console.ReadLine
        If Not Integer.TryParse(readStr, votosN) OrElse votosN < 0 OrElse votosN > alumnado Then
            Console.WriteLine("No ha introducido un valor válido.")
            Exit Sub
        End If
        If votosN + votosP > alumnado Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Imposible, votan más personas que las que hay.")
            Exit Sub
        End If
        votosT = votosP + votosN
        porcentajeP = (votosP / votosT) * 100
        If votosT <= (alumnado / 2) OrElse porcentajeP < 50 Then
            Console.WriteLine("No hay huelga.")
        Else
            Console.WriteLine("Porcentaje de votos positivos: " & porcentajeP & "%.")
            Console.WriteLine("Hay huelga ")
            Select Case porcentajeP
                Case Is >= 50 AndAlso porcentajeP <= 60
                    Console.WriteLine("Con escaso margen.")
                Case Is > 60 AndAlso porcentajeP <= 80
                    Console.WriteLine("Con relativo margen.")
                Case Is > 80 AndAlso porcentajeP <= 89
                    Console.WriteLine("Bastante secundada la decisión.")
                Case Is > 89 AndAlso porcentajeP <= 99
                    Console.WriteLine("Por casi absoluta mayoría.")
                Case Is = 100
                    Console.WriteLine("Por decisión unánime.")
            End Select
        End If
    End Sub

End Module
