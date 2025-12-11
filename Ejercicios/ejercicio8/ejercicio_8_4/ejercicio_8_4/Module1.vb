Module Module1
    Sub Main()

        Dim persona As Persona
        Dim perMasJoven As Persona
        Dim mascota As Mascota
        Dim mascotaMasVieja As Mascota
        Dim entrada As String
        Dim tieneNoLetras As Boolean

        Do
            Console.WriteLine("DATOS PERSONA")
            persona = New Persona
            Do
                Console.Write("Nombre: ")
                entrada = Console.ReadLine

                If String.IsNullOrWhiteSpace(entrada) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El nombre no puede quedarse en blanco.")
                    Console.ResetColor()
                Else
                    For i = 0 To entrada.Length - 1
                        tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
                        If tieneNoLetras Then
                            Exit For
                        End If
                    Next
                    If tieneNoLetras Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("El nombre solo puede tener letras o espacios en blanco.")
                        Console.ResetColor()
                    End If
                End If


            Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras

            persona.Nombre = entrada

            Do
                Console.Write("Fecha de nacimiento: ")
                entrada = Console.ReadLine
                If Not Date.TryParse(entrada, persona.FechaNacimiento) OrElse persona.FechaNacimiento > Today Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Debes introducir una fecha anterior a la de hoy.")
                    Console.ResetColor()
                End If
            Loop While Not Date.TryParse(entrada, persona.FechaNacimiento) OrElse persona.FechaNacimiento > Today

            If IsNothing(perMasJoven) Then
                perMasJoven = persona
            Else
                If persona.FechaNacimiento > perMasJoven.FechaNacimiento Then
                    perMasJoven = persona
                End If
            End If

            Do
                Console.Write("¿Tiene mascota? (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If entrada <> "S" AndAlso entrada <> "N" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While entrada <> "S" AndAlso entrada <> "N"

            If entrada = "S" Then
                mascota = New Mascota
                mascota.Dueño = persona
                Console.WriteLine("DATOS DE SU MASCOTA")

                Do
                    Console.Write("Nombre: ")
                    entrada = Console.ReadLine

                    If String.IsNullOrWhiteSpace(entrada) Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("El nombre no puede quedarse en blanco.")
                        Console.ResetColor()
                    Else
                        For i = 0 To entrada.Length - 1
                            tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
                            If tieneNoLetras Then
                                Exit For
                            End If
                        Next
                        If tieneNoLetras Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("El nombre solo puede tener letras o espacios en blanco.")
                            Console.ResetColor()
                        End If
                    End If
                Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras
                mascota.Nombre = entrada

                Do
                    Console.Write("Tipo: ")
                    entrada = Console.ReadLine

                    If String.IsNullOrWhiteSpace(entrada) Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("El tipo no puede quedarse en blanco.")
                        Console.ResetColor()
                    Else
                        For i = 0 To entrada.Length - 1
                            tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
                            If tieneNoLetras Then
                                Exit For
                            End If
                        Next
                        If tieneNoLetras Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("El tipo solo puede tener letras o espacios en blanco.")
                            Console.ResetColor()
                        End If
                    End If
                Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras
                mascota.TipoMascota = entrada

                Do
                    Console.Write("Raza: ")
                    entrada = Console.ReadLine

                    If String.IsNullOrWhiteSpace(entrada) Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("La raza no puede quedarse en blanco.")
                        Console.ResetColor()
                    Else
                        For i = 0 To entrada.Length - 1
                            tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
                            If tieneNoLetras Then
                                Exit For
                            End If
                        Next
                        If tieneNoLetras Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("La raza solo puede tener letras o espacios en blanco.")
                            Console.ResetColor()
                        End If
                    End If
                Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras
                mascota.Raza = entrada

                Do
                    Console.Write("Fecha de nacimiento: ")
                    entrada = Console.ReadLine
                    If Not Date.TryParse(entrada, mascota.FechaNacimiento) OrElse mascota.FechaNacimiento > Today Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Debes introducir una fecha anterior a la de hoy.")
                        Console.ResetColor()
                    End If
                Loop While Not Date.TryParse(entrada, mascota.FechaNacimiento) OrElse mascota.FechaNacimiento > Today

                If IsNothing(mascotaMasVieja) Then
                    mascotaMasVieja = mascota
                Else
                    If mascota.FechaNacimiento < mascotaMasVieja.FechaNacimiento Then
                        mascotaMasVieja = mascota
                    End If
                End If

                persona.SuMascota = mascota
                mascota.Dueño = persona
            End If

            Do
                Console.Write("¿Otra persona? (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If entrada <> "S" AndAlso entrada <> "N" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While entrada <> "S" AndAlso entrada <> "N"


        Loop While entrada.Equals("S")


        Console.WriteLine("DATOS PERSONA MÁS JOVEN")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine()
        Console.WriteLine("NOMBRE: " & perMasJoven.Nombre)
        Console.WriteLine("FECHA DE NACIMIENTO: " & perMasJoven.FechaNacimiento)
        If IsNothing(perMasJoven.SuMascota) Then
            Console.WriteLine("NO TIENE MASCOTA")
        Else
            Console.WriteLine("MASCOTA: " & perMasJoven.SuMascota.Nombre)
        End If
        Console.WriteLine()
        Console.ResetColor()
        Console.WriteLine("DATOS MASCOTA MÁS VIEJA")

        If IsNothing(mascotaMasVieja) Then
            Console.WriteLine("NADIE TIENE MASCOTAS")
        Else
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine()
            Console.WriteLine("NOMBRE: " & mascotaMasVieja.Nombre)
            Console.WriteLine("TIPO: " & mascotaMasVieja.TipoMascota)
            Console.WriteLine("RAZA: " & mascotaMasVieja.Raza)
            Console.WriteLine("FECHA NACIMIENTO: " & mascotaMasVieja.FechaNacimiento)
            Console.WriteLine("DUEÑO: " & mascotaMasVieja.Dueño.Nombre)
            Console.ResetColor()
        End If
    End Sub

End Module
