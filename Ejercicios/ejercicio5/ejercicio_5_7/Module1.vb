Module Module1

    Sub Main()
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

End Module
