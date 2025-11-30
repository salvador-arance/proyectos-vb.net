Imports System.Net.Sockets

Module Module1

    Sub Main()
        Dim programa As Byte
        Dim entrada As String

        Do
            Console.Clear()
            Do
                Console.Write("Introduce un número del 1 al 13 para seleccionar el programa a ejecutar: ")
                entrada = Console.ReadLine
                Byte.TryParse(entrada, programa)
                Select Case programa
                    Case 1
                        Ejercicio_5_1()
                    Case 2
                        Ejercicio_5_2()
                    Case 3
                        Ejercicio_5_3()
                    Case 4
                        Ejercicio_5_4()
                    Case 5
                        Ejercicio_5_5()
                    Case 6
                        Ejercicio_5_6()
                    Case 7
                        Ejercicio_5_7()
                    Case 8
                        Ejercicio_5_8()
                    Case 9
                        Ejercicio_5_9()
                    Case 10
                        Ejercicio_5_10()
                    Case 11
                        Ejercicio_5_11()
                    Case 12
                        Ejercicio_5_12()
                    Case 13
                        Ejercicio_5_13()
                    Case Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Por favor, introduce un número del 1 al 13.")
                        Console.ResetColor()
                End Select
            Loop Until (programa > 0 And programa < 14)
            Console.ForegroundColor = ConsoleColor.Blue
            Console.Write("Para voler a seleccionar un programa, pulse cualquier tecla.")
            Console.ResetColor()
            Console.ReadKey()
        Loop
    End Sub

    Private Sub Ejercicio_5_1()
        Dim num1 As Decimal
        Dim readStr As String
        Console.Clear()
        Console.WriteLine("Ejercicio_5_1")
        Do
            Console.Write("Introduce un número: ")
            readStr = Console.ReadLine
            If Not Decimal.TryParse(readStr, num1) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introuce un valor numérico, por favor.")
                Console.ResetColor()
            End If
        Loop Until Decimal.TryParse(readStr, num1)
        If num1 > 0 Then
            Console.WriteLine("El doble de " & num1 & " es " & num1 * 2)
        Else
            Console.Write("El valor absoluto de " & num1 & " es " & Math.Abs(num1))
        End If
    End Sub
    Private Sub Ejercicio_5_2()
        Dim num1 As Decimal
        Dim readStr As String
        Console.Clear()
        Console.WriteLine("Ejercicio_5_2")
        Do
            Console.Write("Introduce un nº positivo (estrictamente >0): ")
            readStr = Console.ReadLine
            If Not Decimal.TryParse(readStr, num1) OrElse num1 <= 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Entrada incorrecta, vuelva a intentarlo. ")
                Console.ResetColor()
            End If
        Loop Until num1 > 0
        Console.WriteLine("La raiz cuadrada de " & num1 & " es " & Math.Sqrt(num1))
    End Sub
    Private Sub Ejercicio_5_3()
        Dim suma As Decimal = 0
        Dim numero As Decimal
        Dim contador As Integer = 0
        Dim entrada As String
        Dim posX As Integer
        Dim posY As Integer
        Console.Clear()
        Console.WriteLine("Ejercicio_5_3")
        Do
            Do
                Console.Write("Introduce número" & " " & (contador + 1) & ": ")
                posX = Console.CursorLeft
                posY = Console.CursorTop
                Console.ForegroundColor = ConsoleColor.Blue
                entrada = Console.ReadLine
                Console.ResetColor()

                If Decimal.TryParse(entrada, numero) Then
                    Exit Do
                Else
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce un número correcto.")
                    Console.ResetColor()
                End If
            Loop

            Do
                Console.Write("    ¿Deseas otro número (S/N)?: ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine.ToUpper
                Console.ResetColor()
                If Not (entrada = "S" OrElse entrada = "N") Then
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N.")
                    Console.ResetColor()
                Else
                    Exit Do
                End If
            Loop

            suma += numero
            contador += 1

        Loop While entrada = "S"
        Console.WriteLine("La suma de los " & contador & " número/s es " & suma & ".")
    End Sub
    Private Sub Ejercicio_5_4()
        Dim x As Decimal
        Dim mayor As Decimal
        Dim entrada As String
        Dim contador As Integer = 0
        Dim primerNumero As Boolean = True
        Console.Clear()
        Console.WriteLine("Ejercicio_5_4")
        Console.WriteLine("Introduce números positivos y te diré cual es el mayor de todos ellos")
        Do
            Do
                Console.Write("Nº" & (contador + 1) & ": ")
                entrada = Console.ReadLine
                If Decimal.TryParse(entrada, x) Then
                    If primerNumero Then
                        mayor = x
                        primerNumero = False
                    ElseIf x > mayor Then
                        mayor = x
                    End If
                    Exit Do
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop
            Do
                Console.Write("¿Otro número (S/N)?: ")
                entrada = Console.ReadLine
                If Not (entrada.ToUpper = "S" OrElse entrada.ToUpper = "N") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N")
                    Console.ResetColor()
                Else
                    Exit Do
                End If
            Loop
            contador += 1
        Loop Until entrada.ToUpper = "N"
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("El número mayor de los " & contador & " que has introducido es: " & mayor)
        Console.ResetColor()
    End Sub
    Private Sub Ejercicio_5_5()
        Dim entrada As String
        Dim contador As Integer = 0
        Dim articulosMasCaros As Integer = 1
        Dim primerArticulo As Boolean = True
        Dim articulo As String
        Dim precioArticulo As Decimal = 0
        Dim precioMasCaro As Decimal = 0
        Dim articuloMasCaro As String = ""
        Dim articuloMasBarato As String = ""
        Dim precioMasBarato As Decimal
        Dim precioValido As Boolean
        Dim articuloValido As Boolean
        Dim mismoprecio As Boolean = False
        Dim posX As Integer
        Dim posY As Integer

        Console.Clear()
        Console.WriteLine("Ejercicio_5_5")

        Console.WriteLine("     COMPRAS")
        Do
            Do
                Console.Write("Artículo " & (contador + 1) & ": ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                articulo = Console.ReadLine
                Console.ResetColor()
                articuloValido = True
                If IsNumeric(articulo) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + articulo.Length + 1), posY)
                    Console.WriteLine("Has introducido un valor numérico en el artículo")
                    Console.ResetColor()
                    articuloValido = False
                End If
            Loop Until articuloValido

            Do
                Console.Write("Precio: ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine
                Console.ResetColor()
                If Decimal.TryParse(entrada, precioArticulo) AndAlso precioArticulo > 0 Then
                    precioValido = True
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                    precioValido = False
                End If
            Loop Until precioValido

            contador += 1

            If primerArticulo Then
                precioMasCaro = precioArticulo
                articuloMasCaro = articulo
                precioMasBarato = precioArticulo
                articuloMasBarato = articulo
                primerArticulo = False
                mismoprecio = False
            ElseIf precioArticulo > precioMasCaro Then
                precioMasCaro = precioArticulo
                articuloMasCaro = articulo
                mismoprecio = False
                articulosMasCaros = 1
            ElseIf precioArticulo = precioMasCaro Then
                articulosMasCaros += 1
                mismoprecio = True
            ElseIf precioArticulo < precioMasBarato Then
                precioMasBarato = precioArticulo
                articuloMasBarato = articulo
            End If

            Do
                Console.Write("¿Otro artículo (S/N)?: ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine
                Console.ResetColor()
                If Not (entrada.ToUpper = "S" OrElse entrada.ToUpper = "N") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.WriteLine("Por favor, introduce S o N")
                    Console.ResetColor()
                End If
            Loop While Not (entrada.ToUpper = "S" OrElse entrada.ToUpper = "N")

        Loop Until entrada.ToUpper = "N"
        Console.ForegroundColor = ConsoleColor.Green
        If mismoprecio Then
            Console.WriteLine("Hay " & articulosMasCaros & " artículos con el mismo precio máximo: " & precioMasCaro)
        Else
            Console.WriteLine("El artículo más caro de los " & contador & " que has introducido es " & articuloMasCaro & " con un precio de " & precioMasCaro & ".")
        End If
        Console.WriteLine("El artículo más barato es " & articuloMasBarato & " con un precio de " & precioMasBarato)
        Console.ResetColor()
    End Sub
    Private Sub Ejercicio_5_6()
        Dim entrada As String
        Dim margenAbajo As Byte
        Dim margenArriba As Byte
        Dim rnd As New Random()
        Dim numQueAdivinar As Byte
        Dim intento As Byte
        Dim contador As Integer = 0

        Console.Clear()
        Console.WriteLine("Ejercicio 5_5")
        Console.WriteLine("Adivinar número")

        Do
            Console.Write("Introduce el margen mínimo: ")
            entrada = Console.ReadLine
            If Not Byte.TryParse(entrada, margenAbajo) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("No has introducido un número válido. Tiene que ser un entero entre el 0 y el 255.")
                Console.ResetColor()
            End If
        Loop Until Byte.TryParse(entrada, margenAbajo)

        Do
            Console.Write("Introduce el margen máximo: ")
            entrada = Console.ReadLine
            If Not Byte.TryParse(entrada, margenArriba) OrElse (margenAbajo >= margenArriba) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("No has introducido un número válido. El margen máximo debe estar entre el 0 y el 255 y además debe ser mayor al margen mínimo.")
                Console.ResetColor()
            End If
        Loop Until Byte.TryParse(entrada, margenArriba) AndAlso (margenAbajo < margenArriba)

        numQueAdivinar = rnd.Next(margenAbajo, (margenArriba + 1))

        Console.WriteLine("Ahora intenta adivinar en qué número comprendido en ese margen estoy pensando.")

        Do
            contador += 1

            Console.Write("Número: ")
            entrada = Console.ReadLine

            If Not Byte.TryParse(entrada, intento) OrElse (intento < margenAbajo OrElse intento > margenArriba) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número que esté comprendido en el margen, por favor.")
                Console.ResetColor()
            ElseIf intento < numQueAdivinar Then
                Console.WriteLine("El número que pienso es mayor al que has introducido.")
            ElseIf intento > numQueAdivinar Then
                Console.WriteLine("El número que pienso es menor al que has introducido.")
            End If

        Loop Until intento = numQueAdivinar

        If contador = 1 Then
            Console.WriteLine("Enhorabuena, lo has logrado al primer intento!.")
        Else
            Console.WriteLine("No está mal, lo has logrado a los " & contador & " intentos.")
        End If

    End Sub
    Private Sub Ejercicio_5_7()
        Dim articulo, entrada As String
        Dim primerArticuloDelDia As Boolean = True
        Dim articuloMasCaro As String = ""
        Dim precioMasCaro As Decimal
        Dim articuloMasBarato As String = ""
        Dim precioMasBarato As Decimal
        Dim precioArticulo As Decimal
        Dim cantidad As Integer
        Dim precioArticulos As Decimal
        Dim total As Decimal
        Dim totalEstablecimiento As Decimal

        Console.Clear()
        'Bucle del día de la tienda.
        Do
            'Bucle de compra.
            Do
                'Bucle validación 1
                Do
                    Console.Write("Introduce nombre artículo (*=fin): ")
                    articulo = Console.ReadLine
                    If IsNumeric(articulo) Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("El nombre del artículo no puede ser un número.")
                        Console.ResetColor()
                    End If
                Loop Until Not IsNumeric(articulo)

                If articulo = "*" Then
                    'Aquí salgo del bucle de la compra.
                    Exit Do
                End If

                'Bucle validación 2
                Do
                    Console.Write("Introduce el precio del artículo: ")
                    entrada = Console.ReadLine
                    If Not Decimal.TryParse(entrada, precioArticulo) OrElse precioArticulo <= 0 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("No has introducido un precio válido.")
                        Console.ResetColor()
                    End If
                Loop Until Decimal.TryParse(entrada, precioArticulo) AndAlso precioArticulo > 0

                'Bucle validación 3
                Do
                    Console.Write("Introduce la cantidad del artículo: ")
                    entrada = Console.ReadLine

                    If Not Integer.TryParse(entrada, cantidad) OrElse cantidad <= 0 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("No has introducido una cantidad válida.")
                        Console.ResetColor()
                    End If

                Loop Until Integer.TryParse(entrada, cantidad) AndAlso cantidad > 0

                'Calculamos el total de la compra, primero calculamos el precio de la cantidad del mismo artículo y luego se lo incrementamos al total cada ciclo de caja, siendo total el precio de la compra de una persona
                precioArticulos = precioArticulo * cantidad
                total += precioArticulos

                'Guardamos qué artículos son los más caros y los más baratos, se actualiza cada ciclo de compra.
                If primerArticuloDelDia Then
                    precioMasCaro = precioArticulo
                    articuloMasCaro = articulo
                    precioMasBarato = precioArticulo
                    articuloMasBarato = articulo
                    primerArticuloDelDia = False
                End If

                If precioArticulo > precioMasCaro Then
                    precioMasCaro = precioArticulo
                    articuloMasCaro = articulo
                ElseIf precioArticulo < precioMasBarato Then
                    precioMasBarato = precioArticulo
                    articuloMasBarato = articulo
                End If

            Loop

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Total a pagar: " & total & " euro/s.")
            Console.ResetColor()
            'Bucle de validación 4.
            Do
                Console.Write("¿Otra persona? (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If Not (entrada = "S" OrElse entrada = "N") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduzca S o N.")
                    Console.ResetColor()
                End If
            Loop Until entrada = "S" OrElse entrada = "N"
            'Calculamos el total de la caja del día a base de incrementar totalEstablecimiento cada ciclo del día.
            totalEstablecimiento += total
            'Después de calcular el total del establecimiento, reiniciamos el total de la caja de cada individuo que compra.
            total = 0

        Loop Until entrada = "N"
        'Mensajes finales.
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Total de establecimiento: " & totalEstablecimiento & " euro/s.")
        Console.WriteLine("El artículo más caro es " & articuloMasCaro & " con un precio de " & precioMasCaro & " euro/s.")
        Console.WriteLine("El artículo más barato es " & articuloMasBarato & " con un precio de " & precioMasBarato & " euro/s.")
        Console.ResetColor()

    End Sub
    Private Sub Ejercicio_5_8()
        Dim entrada As String
        Dim listaDePares As String = ""
        Dim numeroMenor, numeroMayor, ultimoPar, primerPar, total, pares As Integer
        'Dim cantidad As Integer
        Console.Clear()
        'Bucle de validación 1
        Do
            Do
                Console.Write("Número menor (>0): ")
                entrada = Console.ReadLine
                If Not (Integer.TryParse(entrada, numeroMenor) AndAlso numeroMenor > 0) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop Until Integer.TryParse(entrada, numeroMenor) AndAlso numeroMenor > 0
            'Bucle de validación 2
            Do
                Console.Write("Número mayor (>" & numeroMenor & "): ")
                entrada = Console.ReadLine
                If Not (Integer.TryParse(entrada, numeroMayor) AndAlso numeroMayor > numeroMenor) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                End If
            Loop Until Integer.TryParse(entrada, numeroMayor)

        Loop Until numeroMayor > numeroMenor

        'Saco el primer par y el último par.
        If numeroMenor Mod 2 = 0 Then
            primerPar = numeroMenor
        Else
            primerPar = numeroMenor + 1
        End If

        If numeroMayor Mod 2 = 0 Then
            ultimoPar = numeroMayor
        Else
            ultimoPar = numeroMayor - 1
        End If

        'Calculo la cantidad de pares.
        'cantidad = ((ultimoPar - primerPar) \ 2) + 1

        'Calculo la suma de los pares que hay entre los dos números.
        'total = (cantidad * (primerPar + ultimoPar)) / 2

        'Meto la lista de los pares en un string usando un bucle For
        'For pares = primerPar To ultimoPar Step 2
        'listaDePares &= " + " & pares.ToString
        'Next

        total = 0
        pares = primerPar

        Do
            listaDePares &= " + " & pares.ToString
            total += pares
            pares += 2
        Loop While pares <= ultimoPar

        listaDePares = listaDePares.Remove(1, 1)

        Console.WriteLine("La suma de los pares entre " & numeroMenor & " y " & numeroMayor & " =" & listaDePares & " = " & total)

    End Sub
    Private Sub Ejercicio_5_9()
        Console.Clear()
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
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("Los datos de la persona más joven son: ")
        Console.WriteLine("DNI: " & dniPersonaJoven)
        Console.WriteLine("Nombre: " & nombrePersonaJoven)
        Console.WriteLine("Teléfono: " & telefonoPersonaJoven)
        Console.WriteLine("Email: " & emailPersonaJoven)
        Console.WriteLine("Fecha de Nacimiento: " & fechaNacimientoPersonaJoven)
        Console.ResetColor()
    End Sub
    Private Sub Ejercicio_5_10()
        Dim entrada As String
        Dim num As Integer
        Dim divisor As Integer
        Dim primo As Boolean = True
        Dim resto As Integer
        Console.Clear()
        Console.WriteLine("Números primos.")

        'Validación entrada
        Do
            Console.Write("Introduce número (debe ser entero positivo): ")
            entrada = Console.ReadLine()
            If Not (Integer.TryParse(entrada, num) AndAlso num > 0) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número válido.")
                Console.ResetColor()
            End If
        Loop While Not (Integer.TryParse(entrada, num) AndAlso num > 0)

        If num = 1 Then
            primo = False
        ElseIf num = 2 Then
            Console.WriteLine("Tu número es 2.")
        Else
            divisor = 2
            Do
                resto = num Mod divisor
                If resto = 0 Then
                    primo = False
                End If
                divisor += 1
            Loop Until divisor > Math.Sqrt(num) OrElse primo
        End If

        If primo = True Then
            Console.WriteLine("Es primo.")
        Else
            Console.WriteLine("No es primo.")
        End If
    End Sub
    Private Sub Ejercicio_5_11()
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
    Private Sub Ejercicio_5_12()
        Dim entrada As String
        Dim indice As Integer
        Dim l As Integer
        Dim centro As Integer
        Dim palindromo As Boolean

        Do
            Console.Write("Introduce un número o un texto y te diré si es palíndromo: ")
            entrada = Console.ReadLine().ToLower()
            l = entrada.Length - 1
            centro = entrada.Length \ 2
            indice = 0
            palindromo = True

            Do
                If (entrada.Chars(indice) <> entrada.Chars(l - indice) OrElse l = 0) Then
                    palindromo = False
                End If
                indice += 1
            Loop Until indice = centro OrElse palindromo = False

            If palindromo Then
                Console.WriteLine("Sí es")
            Else
                Console.WriteLine("No es")
            End If

            Do
                Console.Write("¿Otro número (S/N)? ")
                entrada = Console.ReadLine().ToUpper()
                If Not (entrada = "N" OrElse entrada = "S") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While Not (entrada = "N" OrElse entrada = "S")

        Loop Until entrada = "N"

    End Sub
    Private Sub Ejercicio_5_13()
        Console.Clear()
        Console.WriteLine("Ejercicio 5 13")
    End Sub
End Module
