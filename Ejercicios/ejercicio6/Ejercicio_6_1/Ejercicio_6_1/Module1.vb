Module Module1

    Sub Main()
        Dim entrada As String = ""
        Dim numero As Integer = 0
        Dim secuencia As String
        Dim posX, posY As Integer
        Do
            Console.Clear()
            Do
                Console.Write("Introduce un número positivo: ")
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine
                If Not (Integer.TryParse(entrada, numero) AndAlso numero > 0) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.WriteLine("Por favor, intruduce un número positivo.")
                    Console.ResetColor()
                    Console.ReadKey()
                    Console.Clear()
                End If
            Loop While Not (Integer.TryParse(entrada, numero) AndAlso numero > 0)

            Console.WriteLine($"Los números entre 1 y {numero} son: ")

            secuencia = ""
            For i = 1 To numero Step 1
                If i < numero Then
                    secuencia &= $"  {i} "
                Else
                    secuencia &= i
                End If

            Next

            Console.WriteLine(secuencia)

            Do
                Console.Write("Otro número? S/N ")
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine.ToLower
                If Not (entrada = "s" OrElse entrada = "n") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.WriteLine("Por favor, introduce S o N")
                    Console.ResetColor()
                    Console.ReadKey()
                    Console.Clear()
                End If
            Loop While Not (entrada = "s" OrElse entrada = "n")
        Loop While Not (entrada = "n")
    End Sub

End Module
