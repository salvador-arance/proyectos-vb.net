Module Module1

    Sub Main()
        Dim entrada As String
        Dim valido As Boolean
        Dim numAlumnos As Integer

        Do
            Console.Write("Número alumnos: ")
            entrada = Console.ReadLine
            valido = Integer.TryParse(entrada, numAlumnos) AndAlso numAlumnos > 0 AndAlso numAlumnos < 50
            If Not valido Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("El número de alumnos no puede ser inferior a 0 o mayor a 50")
                Console.ResetColor()
            End If
        Loop While Not valido

        Dim nombres(numAlumnos - 1) As String
        Dim notas(numAlumnos - 1) As Integer

        For i = 0 To numAlumnos - 1
            Do
                Console.Write($"Nombre: ")
                nombres(i) = Console.ReadLine
                valido = Not String.IsNullOrWhiteSpace(nombres(i)) AndAlso nombres(i).Length > 2
                If Not valido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El nombre debe contener como mínimo 3 caracteres.")
                    Console.ResetColor()
                End If

            Loop While Not valido
            Do
                Console.Write($"Nota: ")
                entrada = Console.ReadLine
                valido = Integer.TryParse(entrada, notas(i)) AndAlso notas(i) >= 0 AndAlso notas(i) <= 10
                If Not valido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("La nota debe ser un número mayor o igual a cero y menor o igual a 10.")
                    Console.ResetColor()
                End If
            Loop While Not valido
        Next

        Console.Clear()

        Console.WriteLine("NOMBRES Y NOTAS DE TODO EL ALUMNADO:")
        Console.WriteLine()
        Console.WriteLine($"NOMBRES  {ControlChars.Tab} NOTAS")


        For i = 0 To numAlumnos - 1
            Console.WriteLine($"{nombres(i)} {ControlChars.Tab} {ControlChars.Tab} {notas(i)}")
        Next

        Console.WriteLine()

        Console.WriteLine($"PERSONAS CON UNA NOTA SUPERIOR A LA MEDIA ({notas.Average})")
        Console.WriteLine()
        Console.WriteLine($"NOMBRES  {ControlChars.Tab} NOTAS")
        For i = 0 To numAlumnos - 1
            If notas(i) > notas.Average Then
                Console.WriteLine($"{nombres(i)} {ControlChars.Tab} {ControlChars.Tab} {notas(i)}")
            End If
        Next

        Console.WriteLine()
        Console.WriteLine("ALUMNADO CON LAS NOTAS MÁS ALTAS")
        Console.WriteLine()

        Console.WriteLine($"NOMBRES  {ControlChars.Tab} NOTAS")
        For i = 0 To numAlumnos - 1
            If notas(i) = notas.Max Then
                Console.WriteLine($"{nombres(i)} {ControlChars.Tab} {ControlChars.Tab} {notas(i)}")
            End If
        Next

    End Sub

End Module
