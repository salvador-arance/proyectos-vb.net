Module Module1

    Sub Main()
        Dim articulos As Articulo() = {}
        Dim artMayorPago As Articulo
        Dim artMasCaro As Articulo
        Dim artMasBarato As Articulo
        Dim entrada As String

        Do
            Console.Write("Nombre del artículo (fin: finalizar): ")

            entrada = Console.ReadLine()

            If entrada.ToLower = "fin" Then
                Exit Do
            End If

            Array.Resize(articulos, articulos.Length + 1)

            articulos(articulos.Length - 1) = New Articulo
            articulos(articulos.Length - 1).Nombre = entrada

            Do
                Console.Write("Precio artículo: ")
                entrada = Console.ReadLine()
            Loop While Not Single.TryParse(entrada, articulos(articulos.Length - 1).Precio)

            Do
                Console.Write("Cantidad artículo: ")
                entrada = Console.ReadLine()
            Loop While Not Integer.TryParse(entrada, articulos(articulos.Length - 1).Cantidad)

            Console.WriteLine($"Total a pagar: {articulos(articulos.Length - 1).Pagar}")
        Loop

        If articulos.Length = 0 Then
            Console.WriteLine("No hay artículos")
            Exit Sub
        End If

        artMasCaro = articulos(0)
        artMayorPago = articulos(0)
        artMasBarato = articulos(0)

        For i = 1 To articulos.Length - 1

            If articulos(i).Precio > artMasCaro.Precio Then
                artMasCaro = articulos(i)
            End If

            If articulos(i).Pagar > artMayorPago.Pagar Then
                artMayorPago = articulos(i)
            End If

            If articulos(i).Precio < artMasBarato.Precio Then
                artMasBarato = articulos(i)
            End If

        Next

        Console.ForegroundColor = ConsoleColor.Green

        Console.WriteLine($"NOMBRE {ControlChars.Tab} PRECIO {ControlChars.Tab} CANTIDAD {ControlChars.Tab} PRECIO FINAL")

        For i = 0 To articulos.Length - 1
            Console.WriteLine($"{articulos(i).Nombre} {ControlChars.Tab} {articulos(i).Precio} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Cantidad} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Pagar}")
        Next

        Console.WriteLine()
        Console.WriteLine("ARTÍUCULOS MÁS CAROS")

        Console.WriteLine($"NOMBRE {ControlChars.Tab} PRECIO {ControlChars.Tab} CANTIDAD {ControlChars.Tab} PRECIO FINAL")

        For i = 0 To articulos.Length - 1
            If articulos(i).Precio = artMasCaro.Precio Then
                Console.WriteLine($"{articulos(i).Nombre} {ControlChars.Tab} {articulos(i).Precio} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Cantidad} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Pagar}")
            End If
        Next

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("ARTÍCULOS MÁS PAGADOS")

        Console.WriteLine($"NOMBRE {ControlChars.Tab} PRECIO {ControlChars.Tab} CANTIDAD {ControlChars.Tab} PRECIO FINAL")

        For i = 0 To articulos.Length - 1
            If articulos(i).Pagar = artMayorPago.Pagar Then
                Console.WriteLine($"{articulos(i).Nombre} {ControlChars.Tab} {articulos(i).Precio} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Cantidad} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Pagar}")
            End If
        Next

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine()
        Console.WriteLine("ARTÍCULOS MÁS BARATOS")

        Console.WriteLine($"NOMBRE {ControlChars.Tab} PRECIO {ControlChars.Tab} CANTIDAD {ControlChars.Tab} PRECIO FINAL")

        For i = 0 To articulos.Length - 1
            If articulos(i).Precio = artMasBarato.Precio Then
                Console.WriteLine($"{articulos(i).Nombre} {ControlChars.Tab} {articulos(i).Precio} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Cantidad} {ControlChars.Tab} {ControlChars.Tab} {articulos(i).Pagar}")
            End If
        Next

        Console.ResetColor()

    End Sub

End Module
