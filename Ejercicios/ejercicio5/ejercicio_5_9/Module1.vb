Module Module1

    Sub Main()
        Dim entrada, dni, nombre, email As String
        Dim contador As Integer = 0
        Dim nombrePersonaJoven As String = ""
        Dim dniPersonaJoven As String = ""
        Dim emailPersonaJoven As String = ""
        Dim fechaNacimiento, fechaNacimientoPersonaJoven As Date
        Dim telefono, telefonoPersonaJoven As Integer
        Dim origenLetra As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim primerosDigitosDni, restoParaLetra As Integer
        Dim letra As Char
        Dim dniValido, nombreValido, telefonoValido, emailValido, fechaNacValida, otraPersona As Boolean

        'Bucle Principal
        Do
            otraPersona = True
            'Validación DNI
            Do
                dniValido = False
                Console.Write("DNI persona " & (contador + 1) & " : ")
                dni = Console.ReadLine

                If String.IsNullOrWhiteSpace(dni) Then ' dni = "" Then
                    dniValido = True
                Else
                    If Not dni.Length = 9 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("El DNI tiene 9 caracteres, no " & dni.Length & ". Vuelve a introducirlo.")
                        Console.ResetColor()
                    Else
                        If Not (Integer.TryParse(dni.Substring(0, 8), primerosDigitosDni) AndAlso Char.IsLetter(dni.Chars(8))) Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Los primeros 8 dígitos deben ser números y el último una letra.")
                            Console.ResetColor()
                        ElseIf primerosDigitosDni < 0 Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Los primeros dígitos del DNI no pueden ser números negativos")
                            Console.ResetColor()
                        Else
                            restoParaLetra = primerosDigitosDni Mod 23
                            letra = origenLetra.Substring(restoParaLetra)
                            If letra <> Char.ToUpper(dni.Chars(8)) Then
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine("La letra no se corresponde con la que debería ser según los primeros 8 dígitos")
                                Console.ResetColor()
                            Else
                                dniValido = True
                            End If
                        End If
                    End If
                End If
            Loop Until dniValido

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("DNI válido.")
            Console.ResetColor()

            'Validación Nombre
            nombreValido = False
            Do

                Console.Write("Nombre: ")
                nombre = Console.ReadLine

                If nombre.Count < 3 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El nombre debe contener como mínimo 3 caracteres.")
                    Console.ResetColor()
                Else
                    nombreValido = True
                End If
            Loop Until nombreValido

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Nombre válido.")
            Console.ResetColor()

            'Validación teléfono 
            telefonoValido = False
            Do

                Console.Write("Teléfono: ")
                entrada = Console.ReadLine

                If Not (Integer.TryParse(entrada, telefono) AndAlso (entrada.Count = 3 OrElse ((entrada.Count = 9) AndAlso ((entrada.Chars(0) = "6") OrElse (entrada.Chars(0) = "7") OrElse (entrada.Chars(0) = "8") OrElse (entrada.Chars(0) = "9"))))) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("No has introducido un teléfono válido.")
                    Console.ResetColor()
                Else
                    telefonoValido = True
                End If
            Loop Until telefonoValido


            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Teléfono válido.")
            Console.ResetColor()


            'Validación Email
            Do
                emailValido = False
                Console.Write("Email: ")
                email = Console.ReadLine
                If Not ((email.IndexOf("@") = email.LastIndexOf("@")) AndAlso (email.LastIndexOf(".") > email.LastIndexOf("@")) AndAlso (email.Contains("@") AndAlso email.Contains("."))) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El correo no es válido.")
                    Console.ResetColor()
                Else
                    emailValido = True
                End If

            Loop Until emailValido

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Email válido.")
            Console.ResetColor()

            'Validación Fecha de Nacimiento
            Do
                fechaNacValida = False
                Console.Write("Fecha de nacimiento: ")
                entrada = Console.ReadLine
                If Not (Date.TryParse(entrada, fechaNacimiento) AndAlso (fechaNacimiento <= Today)) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("La fecha de nacimiento no es válida.")
                    Console.ResetColor()
                Else
                    fechaNacValida = True
                End If

            Loop Until fechaNacValida

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Fecha de nacimiento válida.")
            Console.ResetColor()

            'Preguntar si hay otra persona
            Do
                Console.Write("Otra persona (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If Not (entrada = "N" OrElse entrada = "S") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por Favor, introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While Not (entrada = "N" OrElse entrada = "S")
            If entrada = "N" Then
                otraPersona = False
            End If

            If contador = 0 OrElse fechaNacimiento > fechaNacimientoPersonaJoven Then
                dniPersonaJoven = dni
                nombrePersonaJoven = nombre
                telefonoPersonaJoven = telefono
                fechaNacimientoPersonaJoven = fechaNacimiento
                emailPersonaJoven = email
            End If
            contador += 1
        Loop While otraPersona
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Los datos de la persona más joven son: ")
        Console.WriteLine("DNI: " & dniPersonaJoven)
        Console.WriteLine("Nombre: " & nombrePersonaJoven)
        Console.WriteLine("Teléfono: " & telefonoPersonaJoven)
        Console.WriteLine("Email: " & emailPersonaJoven)
        Console.WriteLine("Fecha de Nacimiento: " & fechaNacimientoPersonaJoven)
        Console.ResetColor()
    End Sub

End Module
