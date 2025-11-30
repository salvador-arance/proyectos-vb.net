Module Module1

    Sub Main()
        Dim user As String
        Dim passwd As String
        Console.WriteLine("Bienvenido")
        Console.Write("Por favor, introduzca su usuario: ")
        user = Console.ReadLine
        If String.IsNullOrWhiteSpace(user) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No has introducido un usuario válido.")
            Exit Sub
        End If
        Console.Write("Por favor, introduzca su contraseña: ")
        passwd = Console.ReadLine
        If user.ToLower = "admin" AndAlso passwd = "miContraseña" Then
            Console.WriteLine("Le damos la bienvenida a nuestro programa")
        ElseIf user.ToLower IsNot "admin" AndAlso passwd = "miContraseña" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Usuario incorrecto")
            Exit Sub
        ElseIf user.ToLower = "admin" AndAlso passwd IsNot "miContraseña" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Contraseña incorrecta")
            Exit Sub
        ElseIf user.ToLower IsNot "admin" AndAlso passwd IsNot "miContraseña" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Ni la contraseña ni el usuario son correctos.")
            Exit Sub
        End If
    End Sub

End Module
