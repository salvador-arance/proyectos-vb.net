Module Module1
    'Sub Main()

    '    'TODO Introducir validaciones para no repetir tanto código.
    '    MostrarMensaje("hola", ConsoleColor.Red)
    '    MostrarMensaje("Adios", ConsoleColor.Green)

    '    Dim persona As Persona
    '    Dim perMasJoven As Persona
    '    Dim mascota As Mascota
    '    Dim mascotaMasVieja As Mascota
    '    Dim entrada As String
    '    Dim tieneNoLetras As Boolean

    '    Do
    '        Console.WriteLine("DATOS PERSONA")
    '        persona = New Persona
    '        Do
    '            Console.Write("Nombre: ")
    '            entrada = Console.ReadLine
    '        Loop While CaracteresValidos(entrada) = False

    '        persona.Nombre = entrada

    '        Do
    '            Console.Write("Fecha de nacimiento: ")
    '            entrada = Console.ReadLine
    '            If Not Date.TryParse(entrada, persona.FechaNacimiento) OrElse persona.FechaNacimiento > Today Then
    '                Console.ForegroundColor = ConsoleColor.Red
    '                Console.WriteLine("Debes introducir una fecha anterior a la de hoy.")
    '                Console.ResetColor()
    '            End If
    '        Loop While Not Date.TryParse(entrada, persona.FechaNacimiento) OrElse persona.FechaNacimiento > Today

    '        If IsNothing(perMasJoven) Then
    '            perMasJoven = persona
    '        Else
    '            If persona.FechaNacimiento > perMasJoven.FechaNacimiento Then
    '                perMasJoven = persona
    '            End If
    '        End If

    '        Do
    '            Console.Write("¿Tiene mascota? (S/N): ")
    '            entrada = Console.ReadLine.ToUpper
    '            If entrada <> "S" AndAlso entrada <> "N" Then
    '                Console.ForegroundColor = ConsoleColor.Red
    '                Console.WriteLine("Introduce S o N.")
    '                Console.ResetColor()
    '            End If
    '        Loop While entrada <> "S" AndAlso entrada <> "N"

    '        If entrada = "S" Then
    '            mascota = New Mascota
    '            mascota.Dueño = persona
    '            Console.WriteLine("DATOS DE SU MASCOTA")

    '            Do
    '                Console.Write("Nombre: ")
    '                entrada = Console.ReadLine

    '                If String.IsNullOrWhiteSpace(entrada) Then
    '                    Console.ForegroundColor = ConsoleColor.Red
    '                    Console.WriteLine("El nombre no puede quedarse en blanco.")
    '                    Console.ResetColor()
    '                Else
    '                    For i = 0 To entrada.Length - 1
    '                        tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
    '                        If tieneNoLetras Then
    '                            Exit For
    '                        End If
    '                    Next
    '                    If tieneNoLetras Then
    '                        Console.ForegroundColor = ConsoleColor.Red
    '                        Console.WriteLine("El nombre solo puede tener letras o espacios en blanco.")
    '                        Console.ResetColor()
    '                    End If
    '                End If
    '            Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras
    '            mascota.Nombre = entrada

    '            Do
    '                Console.Write("Tipo: ")
    '                entrada = Console.ReadLine

    '                If String.IsNullOrWhiteSpace(entrada) Then
    '                    Console.ForegroundColor = ConsoleColor.Red
    '                    Console.WriteLine("El tipo no puede quedarse en blanco.")
    '                    Console.ResetColor()
    '                Else
    '                    For i = 0 To entrada.Length - 1
    '                        tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
    '                        If tieneNoLetras Then
    '                            Exit For
    '                        End If
    '                    Next
    '                    If tieneNoLetras Then
    '                        Console.ForegroundColor = ConsoleColor.Red
    '                        Console.WriteLine("El tipo solo puede tener letras o espacios en blanco.")
    '                        Console.ResetColor()
    '                    End If
    '                End If
    '            Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras
    '            mascota.TipoMascota = entrada

    '            Do
    '                Console.Write("Raza: ")
    '                entrada = Console.ReadLine

    '                If String.IsNullOrWhiteSpace(entrada) Then
    '                    Console.ForegroundColor = ConsoleColor.Red
    '                    Console.WriteLine("La raza no puede quedarse en blanco.")
    '                    Console.ResetColor()
    '                Else
    '                    For i = 0 To entrada.Length - 1
    '                        tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
    '                        If tieneNoLetras Then
    '                            Exit For
    '                        End If
    '                    Next
    '                    If tieneNoLetras Then
    '                        Console.ForegroundColor = ConsoleColor.Red
    '                        Console.WriteLine("La raza solo puede tener letras o espacios en blanco.")
    '                        Console.ResetColor()
    '                    End If
    '                End If
    '            Loop While String.IsNullOrWhiteSpace(entrada) OrElse tieneNoLetras
    '            mascota.Raza = entrada

    '            Do
    '                Console.Write("Fecha de nacimiento: ")
    '                entrada = Console.ReadLine
    '                If Not Date.TryParse(entrada, mascota.FechaNacimiento) OrElse mascota.FechaNacimiento > Today Then
    '                    Console.ForegroundColor = ConsoleColor.Red
    '                    Console.WriteLine("Debes introducir una fecha anterior a la de hoy.")
    '                    Console.ResetColor()
    '                End If
    '            Loop While Not Date.TryParse(entrada, mascota.FechaNacimiento) OrElse mascota.FechaNacimiento > Today

    '            If IsNothing(mascotaMasVieja) Then
    '                mascotaMasVieja = mascota
    '            Else
    '                If mascota.FechaNacimiento < mascotaMasVieja.FechaNacimiento Then
    '                    mascotaMasVieja = mascota
    '                End If
    '            End If
    '            persona.SuMascota = mascota
    '            mascota.Dueño = persona
    '        End If

    '        Do
    '            Console.Write("¿Otra persona? (S/N): ")
    '            entrada = Console.ReadLine.ToUpper
    '            If entrada <> "S" AndAlso entrada <> "N" Then
    '                Console.ForegroundColor = ConsoleColor.Red
    '                Console.WriteLine("Introduce S o N.")
    '                Console.ResetColor()
    '            End If
    '        Loop While entrada <> "S" AndAlso entrada <> "N"


    '    Loop While entrada.Equals("S")


    '    Console.WriteLine("DATOS PERSONA MÁS JOVEN")
    '    Console.ForegroundColor = ConsoleColor.Blue
    '    Console.WriteLine()
    '    Console.WriteLine("NOMBRE: " & perMasJoven.Nombre)
    '    Console.WriteLine("FECHA DE NACIMIENTO: " & perMasJoven.FechaNacimiento)
    '    If IsNothing(perMasJoven.SuMascota) Then
    '        Console.WriteLine("NO TIENE MASCOTA")
    '    Else
    '        Console.WriteLine("MASCOTA: " & perMasJoven.SuMascota.Nombre)
    '    End If
    '    Console.WriteLine()
    '    Console.ResetColor()
    '    Console.WriteLine("DATOS MASCOTA MÁS VIEJA")

    '    If IsNothing(mascotaMasVieja) Then
    '        Console.WriteLine("NADIE TIENE MASCOTAS")
    '    Else
    '        Console.ForegroundColor = ConsoleColor.Blue
    '        Console.WriteLine()
    '        Console.WriteLine("NOMBRE: " & mascotaMasVieja.Nombre)
    '        Console.WriteLine("TIPO: " & mascotaMasVieja.TipoMascota)
    '        Console.WriteLine("RAZA: " & mascotaMasVieja.Raza)
    '        Console.WriteLine("FECHA NACIMIENTO: " & mascotaMasVieja.FechaNacimiento)
    '        Console.WriteLine("DUEÑO: " & mascotaMasVieja.Dueño.Nombre)
    '        Console.ResetColor()
    '    End If
    'End Sub
    'Sub MostrarMensaje(mensaje As String, color As ConsoleColor)
    '    Console.ForegroundColor = color
    '    Console.WriteLine(mensaje)
    '    Console.ResetColor()
    'End Sub
    'Function CaracteresValidos(palabra As String) As Boolean
    '    Dim tieneNoLetras As Boolean
    '    If String.IsNullOrWhiteSpace(palabra) Then
    '        Console.ForegroundColor = ConsoleColor.Red
    '        Console.WriteLine("El nombre no puede quedarse en blanco.")
    '        Console.ResetColor()
    '        Return False
    '    Else
    '        For i = 0 To palabra.Length - 1
    '            tieneNoLetras = Not (Char.IsLetter(palabra.ElementAt(i)) OrElse Char.IsWhiteSpace(palabra.ElementAt(i)))
    '            If tieneNoLetras Then
    '                Exit For
    '            End If
    '        Next
    '        If tieneNoLetras Then
    '            Console.ForegroundColor = ConsoleColor.Red
    '            Console.WriteLine("El nombre solo puede tener letras o espacios en blanco.")
    '            Console.ResetColor()
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    End If
    'End Function
    ' TODO TERMINAR ESTO DE UNA PUTA VEZ
    Dim persona As Persona
    Dim mascota As Mascota
    Dim _perMasJoven As Persona
    Dim _mascotaMasVieja As Mascota

    Sub Main()
        Dim entrada As String
        Do
            MostrarMensaje("DATOS PERSONA", ConsoleColor.Blue)
            persona = New Persona
            Do
                MostrarMensaje("Nombre: ", ConsoleColor.White)
                entrada = Console.ReadLine
            Loop While CaracteresValidos(entrada) = False
            persona.Nombre = entrada
            Do
                MostrarMensaje("Fecha de nacimiento: ", ConsoleColor.White)
                entrada = Console.ReadLine
            Loop While FechaNacimientoValida(entrada) = False
            Date.TryParse(entrada, persona.FechaNacimiento)

            PersonaMasJoven(persona)

            Do
                MostrarMensaje("¿Tiene mascota (S/N)?: ", ConsoleColor.White)
                entrada = Console.ReadLine().ToUpper
                If Not SioNo(entrada) Then
                    MostrarMensaje("Debe introducir S / N", ConsoleColor.Red)
                End If
            Loop While SioNo(entrada) = False

            If entrada = "S" Then
                mascota = New Mascota
                mascota.Dueño = persona
                MostrarMensaje("DATOS DE SU MASCOTA", ConsoleColor.Blue)

                Do
                    MostrarMensaje("Nombre: ", ConsoleColor.White)
                    entrada = Console.ReadLine()
                Loop While CaracteresValidos(entrada) = False
                mascota.Nombre = entrada

                Do
                    MostrarMensaje("Tipo: ", ConsoleColor.White)
                    entrada = Console.ReadLine()
                Loop While CaracteresValidos(entrada) = False
                mascota.TipoMascota = entrada

                Do
                    MostrarMensaje("Raza: ", ConsoleColor.White)
                    entrada = Console.ReadLine()
                Loop While CaracteresValidos(entrada) = False
                mascota.Raza = entrada

                Do
                    MostrarMensaje("Fecha de nacimiento: ", ConsoleColor.White)
                    entrada = Console.ReadLine()
                Loop While FechaNacimientoValida(entrada) = False
                Date.TryParse(entrada, mascota.FechaNacimiento)

                MascotaMasVieja(mascota)
            End If

            Do
                MostrarMensaje("¿Otra persona? (S/N)", ConsoleColor.White)
                entrada = Console.ReadLine.ToUpper
                If Not SioNo(entrada) Then
                    MostrarMensaje("Debe introducir S / N", ConsoleColor.Red)
                End If
            Loop While SioNo(entrada) = False


        Loop While entrada = "S"

        MostrarMensaje("Datos de la mascota más vieja", ConsoleColor.Cyan)
        MostrarMensaje($"Mascota más vieja: {_mascotaMasVieja.Nombre}", ConsoleColor.Blue)
        MostrarMensaje($"Tipo: ", ConsoleColor.Blue)
        MostrarMensaje("Datos de la persona más joven", ConsoleColor.Cyan)
        MostrarMensaje($"Persona más joven: {_perMasJoven}", ConsoleColor.Blue)
    End Sub

    Sub MostrarMensaje(mensaje As String, color As ConsoleColor)
        Console.ForegroundColor = color
        If color = ConsoleColor.White Then
            Console.Write(mensaje)
        Else
            Console.WriteLine(mensaje)
        End If
        Console.ResetColor()
    End Sub

    Function CaracteresValidos(palabra As String) As Boolean
        Dim tieneNoLetras As Boolean
        If String.IsNullOrWhiteSpace(palabra) Then
            MostrarMensaje("El nombre no puede quedarse en blanco.", ConsoleColor.Red)
            Return False
        Else
            For i = 0 To palabra.Length - 1
                tieneNoLetras = Not (Char.IsLetter(palabra.ElementAt(i)) OrElse Char.IsWhiteSpace(palabra.ElementAt(i)))
                If tieneNoLetras Then
                    Exit For
                End If
            Next
            If tieneNoLetras Then
                MostrarMensaje("El nombre solo puede tener letras o espacios en blanco", ConsoleColor.Red)
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Function FechaNacimientoValida(fecha As String) As Boolean
        Dim fechaAux
        If Not Date.TryParse(fecha, fechaAux) OrElse fechaAux > Today Then
            MostrarMensaje("Debes introducir una fecha anterior a la de hoy.", ConsoleColor.Red)
            Return False
        Else
            Return True
        End If
    End Function

    Function SioNo(respuesta As String) As Boolean
        Return respuesta = "S" OrElse respuesta = "N"
    End Function

    Function PersonaMasJoven(per As Persona) As Persona
        If IsNothing(_perMasJoven) OrElse per.FechaNacimiento > _perMasJoven.FechaNacimiento Then
            _perMasJoven = per
        End If
        Return _perMasJoven
    End Function

    Function MascotaMasVieja(masc As Mascota) As Mascota
        If IsNothing(_mascotaMasVieja) OrElse masc.FechaNacimiento < _mascotaMasVieja.FechaNacimiento Then
            _mascotaMasVieja = masc
        End If
        Return _mascotaMasVieja
    End Function
End Module
