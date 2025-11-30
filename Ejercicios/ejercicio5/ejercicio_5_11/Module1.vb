Module Module1

    Sub Main()
        Dim nombre, entrada As String
        Dim nombreJoven As String = ""
        Dim fechaNacimiento, fechaNacimientoJoven As Date
        Dim edad, edadJoven As Integer
        Dim contador As Integer = 0
        Dim fechaValida As Boolean = False
        Console.Clear()

        Console.WriteLine("ACCESO RESTRINGIDO A MENORES DE EDAD")
        Console.WriteLine("Para entrar aquí debes verificar tu nombre y tu edad.")
        'Bucle principal
        Do
            'Bucle para saber si tiene 18 años
            Console.WriteLine("Persona " & contador + 1 & ": ")

            Do
                'Bucle validar nombre
                Do
                    Console.Write("Nombre:")
                    nombre = Console.ReadLine()

                    If nombre.Length < 5 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("El nombre debe tener más de 5 caracteres.")
                        Console.ResetColor()
                    End If

                Loop Until nombre.Length >= 5

                'Bucle validar fecha de nacimiento
                Do
                    Console.Write("Fecha de nacimiento:")
                    entrada = Console.ReadLine()

                    fechaValida = Date.TryParse(entrada, fechaNacimiento)
                    If Not fechaValida Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Introduce una fecha válida.")
                        Console.ResetColor()
                    End If
                Loop Until fechaValida

                edad = Today.Year - fechaNacimiento.Year

                If (fechaNacimiento.Month > Today.Month Or (fechaNacimiento.Month = Today.Month And fechaNacimiento.Day > Today.Day)) Then
                    edad -= 1
                End If

                If edad < 18 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Eres menor de edad")
                    Console.ResetColor()
                End If

                If edad > 120 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Tu edad es imposible")
                    Console.ResetColor()
                End If

            Loop Until edad >= 18 AndAlso edad <= 120

            If contador = 0 OrElse fechaNacimiento > fechaNacimientoJoven Then
                nombreJoven = nombre
                fechaNacimientoJoven = fechaNacimiento
                edadJoven = edad
            End If

            contador += 1

            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Nombre: " & nombre)
            Console.WriteLine("Fecha de nacimiento: " & fechaNacimiento)
            Console.WriteLine("Edad: " & edad)
            Console.ResetColor()

            Do
                Console.Write("Otra persona (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If Not (entrada = "N" OrElse entrada = "S") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por Favor, introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While Not (entrada = "N" OrElse entrada = "S")

        Loop Until entrada = "N"

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Nombre de la persona más joven: " & nombreJoven)
        Console.WriteLine("Fecha de nacimiento de la persona más joven: " & fechaNacimientoJoven)
        Console.WriteLine("Edad de la persona más joven: " & edadJoven)
        Console.ResetColor()

    End Sub

End Module
