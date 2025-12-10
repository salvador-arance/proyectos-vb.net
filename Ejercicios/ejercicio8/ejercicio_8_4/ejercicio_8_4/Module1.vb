Module Module1
    Dim personas() As Persona = {}
    Dim mascotas() As Mascota = {}
    Sub Main()
        Dim persona As New Persona
        Dim mascota As New Mascota
        Dim entrada As String
        Dim tieneNoLetras As Boolean

        Do
            Console.WriteLine("DATOS PERSONA")
            Do
                Console.Write("Nombre: ")
                entrada = Console.ReadLine

                For i = 0 To entrada.Length - 1
                    tieneNoLetras = Not (Char.IsLetter(entrada.ElementAt(i)) OrElse Char.IsWhiteSpace(entrada.ElementAt(i)))
                    If tieneNoLetras Then
                        Exit For
                    End If
                Next

                If String.IsNullOrWhiteSpace(entrada) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El nombre no puede quedarse en blanco.")
                    Console.ResetColor()
                End If

                If Not String.IsNullOrWhiteSpace(entrada) AndAlso tieneNoLetras Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El nombre solo puede tener letras o espacios en blanco.")
                    Console.ResetColor()
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
            Console.WriteLine("Conseguido")

        Loop While entrada.equals("S")
    End Sub

End Module
