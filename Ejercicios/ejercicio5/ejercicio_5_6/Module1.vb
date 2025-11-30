Module Module1

    Sub Main()
        Dim entrada As String
        Dim margenAbajo As Byte
        Dim margenArriba As Byte
        Dim rnd As New Random()
        Dim numQueAdivinar As Byte
        Dim intento As Byte
        Dim contador As Integer = 0

        Console.Clear()
        Console.WriteLine("Ejercicio 5_5")
        Console.WriteLine("Adivinar número")

        Do
            Console.Write("Introduce el margen mínimo: ")
            entrada = Console.ReadLine
            If Not Byte.TryParse(entrada, margenAbajo) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("No has introducido un número válido. Tiene que ser un entero entre el 0 y el 255.")
                Console.ResetColor()
            End If
        Loop Until Byte.TryParse(entrada, margenAbajo)

        Do
            Console.Write("Introduce el margen máximo: ")
            entrada = Console.ReadLine
            If Not Byte.TryParse(entrada, margenArriba) OrElse (margenAbajo >= margenArriba) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("No has introducido un número válido. El margen máximo debe estar entre el 0 y el 255 y además debe ser mayor al margen mínimo.")
                Console.ResetColor()
            End If
        Loop Until Byte.TryParse(entrada, margenArriba) AndAlso (margenAbajo < margenArriba)

        numQueAdivinar = rnd.Next(margenAbajo, (margenArriba + 1))

        Console.WriteLine("Ahora intenta adivinar en qué número comprendido en ese margen estoy pensando.")

        Do
            contador += 1

            Console.Write("Número: ")
            entrada = Console.ReadLine

            If Not Byte.TryParse(entrada, intento) OrElse (intento < margenAbajo OrElse intento > margenArriba) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número que esté comprendido en el margen, por favor.")
                Console.ResetColor()
            ElseIf intento < numQueAdivinar Then
                Console.WriteLine("El número que pienso es mayor al que has introducido.")
            ElseIf intento > numQueAdivinar Then
                Console.WriteLine("El número que pienso es menor al que has introducido.")
            End If

        Loop Until intento = numQueAdivinar

        If contador = 1 Then
            Console.WriteLine("Enhorabuena, lo has logrado al primer intento!.")
        Else
            Console.WriteLine("No está mal, lo has logrado a los " & contador & " intentos.")
        End If
    End Sub

End Module
