Module Module1

    Sub Main()
        Dim programa As Byte
        Dim entrada As String
        Dim final As Boolean

        Do
            Console.Clear()
            final = False
            Do
                Console.WriteLine("--- Menú ---")
                Console.WriteLine("1. Nombre y estación de mes")
                Console.WriteLine("2. Login")
                Console.WriteLine("3. Manejo de String")
                Console.WriteLine("4. Finalizar programa")

                Console.Write("Elige una opción (1..4): ")
                entrada = Console.ReadLine

                Byte.TryParse(entrada, programa)

                Select Case programa
                    Case 1
                        Opcion1()
                    Case 2
                        Opcion2()
                    Case 3
                        Opcion3()
                    Case 4
                        Console.ForegroundColor = ConsoleColor.Blue
                        Console.WriteLine("Adiós! Hasta pronto!")
                        Console.ResetColor()
                        final = True
                        Console.ReadKey()
                    Case Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Por favor, introduce un programa válido.")
                        Console.ResetColor()
                End Select
            Loop Until (programa > 0 AndAlso programa < 5)

            If Not programa = 4 Then
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine("Pulse cualquier tecla para volver al menú")
                Console.ResetColor()
                Console.ReadKey()
            End If

        Loop Until final
    End Sub
    Private Sub Opcion1()
        Dim entrada As String
        Dim numMes As Byte
        Dim strMes As String = ""
        Dim estacion As String = ""

        Console.WriteLine("-- Opción 1: Nombre y estación de mes tecleado ---")
        Do
            Console.Write("Número de mes: ")
            entrada = Console.ReadLine
            If Not (Byte.TryParse(entrada, numMes) AndAlso (numMes > 0 AndAlso numMes <= 12)) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("El mes debe estar entre 1 y 12.")
                Console.ResetColor()
            End If
        Loop Until Byte.TryParse(entrada, numMes) AndAlso (numMes > 0 AndAlso numMes <= 12)

        Select Case numMes
            Case 1
                strMes = "Enero"
                estacion = "Invierno"
            Case 2
                strMes = "Febrero"
                estacion = "Invierno"
            Case 3
                strMes = "Marzo"
                estacion = "Primavera"
            Case 4
                strMes = "Abril"
                estacion = "Primavera"
            Case 5
                strMes = "Mayo"
                estacion = "Primavera"
            Case 6
                strMes = "Junio"
                estacion = "Verano"
            Case 7
                strMes = "Julio"
                estacion = "Verano"
            Case 8
                strMes = "Agosto"
                estacion = "Verano"
            Case 9
                strMes = "Septiembre"
                estacion = "Otoño"
            Case 10
                strMes = "Octubre"
                estacion = "Otoño"
            Case 11
                strMes = "Noviembre"
                estacion = "Otoño"
            Case 12
                strMes = "Diciembre"
                estacion = "Invierno"
        End Select

        Console.WriteLine("El mes " & numMes & " es " & strMes & " y pertenece a la estación de " & estacion & ".")
    End Sub
    Private Sub Opcion2()
        Dim entrada As String
        Dim usuarioValido As Boolean
        Dim contraseñaValida As Boolean
        Dim acceso As Boolean
        Dim contador As Byte = 0

        Console.WriteLine("--- Opción 2: Login y password ---")
        Do
            Console.Write("Login: ")
            entrada = Console.ReadLine()

            usuarioValido = (entrada = "admin" OrElse entrada = "administrador@")

            Console.Write("Password: ")
            entrada = Console.ReadLine

            contraseñaValida = entrada = "pass123"

            contador += 1

            If Not usuarioValido AndAlso contraseñaValida Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Usuario no válido.")
                Console.ResetColor()
            End If

            If usuarioValido AndAlso Not contraseñaValida Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Contraseña no válida.")
                Console.ResetColor()
            End If

            If Not usuarioValido AndAlso Not contraseñaValida Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Ni el usuario ni la contraseña son válidos.")
                Console.ResetColor()
            End If

            If contador > 3 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Demasiados intentos, acceso denegado.")
                Console.ResetColor()
                Exit Sub
            End If

            acceso = usuarioValido AndAlso contraseñaValida

        Loop Until acceso

        Console.WriteLine("Acceso concedido. Has acertado al " & contador & " intento.")

    End Sub

    Private Sub Opcion3()
        Dim entrada As String
        Console.WriteLine("--- Opción 3: Manejo de cadenas (strings) ---")
        Console.Write("Frase: ")

        entrada = Console.ReadLine.ToUpper

        If String.IsNullOrEmpty(entrada) Then
            Console.WriteLine("Tu frase SÍ está vacía")
        Else
            Console.WriteLine("Tu frase NO está vacía")
            If entrada.Substring(0, 1) = "A" Then
                Console.WriteLine("La frase SÍ empieza por la letra 'A'.")
            Else
                Console.WriteLine("La frase NO empieza por la letra 'A'")
            End If

            If entrada.Contains("HOLA") Then
                Console.WriteLine("La frase SÍ contiene la palabra 'hola'.")
            Else
                Console.WriteLine("La frase NO contiene la palabra 'hola'.")
            End If
        End If

        Console.WriteLine("La longitud total de la cadena es de " & entrada.Length & " caractteres.")
    End Sub
End Module
