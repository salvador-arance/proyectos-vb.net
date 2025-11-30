Module Module1

    Sub Main()
        Dim numeroPerros As Integer
        Dim entrada As String
        Dim datoValido As Boolean

        Do
            Console.Write("Número de perros: ")
            entrada = Console.ReadLine
            datoValido = Integer.TryParse(entrada, numeroPerros) AndAlso numeroPerros > 0
            If Not datoValido Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número de perros válido.")
                Console.ResetColor()
            End If
        Loop While Not datoValido

        Dim perros(numeroPerros - 1) As Perro

        Console.Clear()

        For i = 0 To numeroPerros - 1
            perros(i) = New Perro
            Console.Write($"Nombre Perro {i + 1}: ")
            perros(i).Nombre = Console.ReadLine
            Console.Write($"Raza Perro {i + 1}: ")
            perros(i).Raza = Console.ReadLine

            Do
                Console.Write($"Fecha de nacimiento Perro {i + 1}: ")
                entrada = Console.ReadLine
                datoValido = Date.TryParse(entrada, perros(i).FechaNacimiento) AndAlso perros(i).FechaNacimiento <= Today
                If Not datoValido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce una fecha de nacimiento válida.")
                    Console.ResetColor()
                End If
            Loop While Not datoValido

            Console.Clear()
        Next

        For i = 0 To numeroPerros - 1
            Console.WriteLine($"{perros(i).Nombre} {ControlChars.Tab} {perros(i).Raza} {ControlChars.Tab}  {perros(i).FechaNacimiento.ToShortDateString}")
        Next

    End Sub

End Module
