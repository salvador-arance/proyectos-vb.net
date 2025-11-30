Module Module1

    Sub Main()
        Dim artActual, artMasCaro, artMayorPago As Articulo
        Dim entrada As String

        Do

            Console.Write("Nombre del artículo (fin: finalizar): ")
            entrada = Console.ReadLine()

            If entrada.ToLower = "fin" Then
                Exit Do
            End If

            artActual = New Articulo
            artActual.Nombre = entrada

            Do
                Console.Write("Precio artículo: ")
                entrada = Console.ReadLine()
            Loop While Not Single.TryParse(entrada, artActual.Precio)

            Do
                Console.Write("Cantidad artículo: ")
                entrada = Console.ReadLine()
            Loop While Not Integer.TryParse(entrada, artActual.Cantidad)


            Console.WriteLine($"Total a pagar: {artActual.Pagar}")


            If artMasCaro Is Nothing Then
                artMasCaro = artActual
                artMayorPago = artActual
            Else
                If artActual.Precio > artMasCaro.Precio Then
                    artMasCaro = artActual
                End If

                If artActual.Pagar > artMayorPago.Pagar Then
                    artMayorPago = artActual
                End If

            End If
        Loop

        If artMasCaro Is Nothing Then
            Console.WriteLine("No hay artículos.")
            Exit Sub
        End If

        Console.WriteLine($"El artículo más caro es {artMasCaro.Nombre}, con una cantidad de {artMasCaro.Cantidad} undades, un precio de {artMasCaro.Precio} y un total a pagar de {artMasCaro.Pagar}.")
        Console.WriteLine($"El artículo por el que más se ha pagado es {artMayorPago.Nombre}, con una cantidad de {artMayorPago.Cantidad} undades, un precio de {artMayorPago.Precio} y un total a pagar de {artMayorPago.Pagar}.")
    End Sub

End Module
