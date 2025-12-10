Module Module1
    Dim personas() As Persona = {}
    Dim mascotas() As Mascota = {}
    Sub Main()
        Dim persona As Persona
        Dim mascota As Mascota
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
            Do
                Console.WriteLine("¿Tiene mascota? (S/N)")
                entrada = Console.ReadLine.ToUpper
                If entrada <> "S" AndAlso entrada <> "N" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While entrada <> "S" AndAlso entrada <> "N"
            'TODO Terminar esto hoy en casa más tranquilo.
            If entrada = "S" Then
                mascota = New Mascota
                mascota.Dueño = persona
            End If
        Loop While entrada.equals("S")
    End Sub

End Module
