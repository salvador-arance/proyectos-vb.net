Module Module2
    Sub Main()
        Dim persona As Persona
        Dim mascota As Mascota
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
            Loop While FechaNacimientoValida(entrada) = True
            persona.FechaNacimiento
            Date.TryParse(entrada, persona.FechaNacimiento)

            PersonaMasJoven(persona)

            Do
                MostrarMensaje("¿Tiene mascota (S/N)?: ")
                entrada = Console.ReadLine().ToUpper
            Loop While SioNo(entrada) = False

            If TieneMascota(entrada) Then
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

                Do
                    MostrarMensaje("Fecha de nacimiento: ", ConsoleColor.White)
                    entrada = Console.ReadLine()
                Loop While FechaNacimientoValida(entrada) = False
                Date.TryParse(entrada, mascota.FechaNacimiento)

                MascotaMasVieja(mascota)
            End If

            MostrarMensaje("¿Otra persona? (S/N)")
        Loop
    End Sub

    Sub MostrarMensaje(mensaje As String, color As ConsoleColor)
        Console.ForegroundColor = color
        Console.WriteLine(mensaje)
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
        If respuesta <> "S" AndAlso entrada <> "N" Then
            MostrarMensaje("Introduce S o N", ConsoleColor.Red)
            Return = False
        Else
            Return = True
        End If
    End Function

    Function TieneMascota(respuesta As String) As Boolean
        If respuesta = "S" Then
            Return = True
        Else
            Return = False
        End If
    End Function

    Function PersonaMasJoven(per As Persona) As Persona
        Private _PersonaMasJoven As Persona
        If IsNothing(PersonaMasJoven) OrElse per.FechaNacimiento > _PersonaMasJoven.FechaNacimiento Then
            _PersonaMasJoven = per
        End If
        Return _PersonaMasJoven
    End Function

    Function MascotaMasVieja(masc As Mascota) As Mascota
        Private _MascotaMasVieja As Persona
        If IsNothing(_MascotaMasVieja) OrElse masc.FechaNacimiento < _MascotaMasVieja.FechaNacimiento Then
            _MascotaMasVieja = masc
        End If
        Return _MascotaMasVieja
    End Function
End Module
