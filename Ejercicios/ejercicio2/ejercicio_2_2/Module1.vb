Module Module1

    Sub Main()
        Dim celsius As Decimal
        Dim fahrenheit As Decimal
        Dim kelvin As Decimal
        Dim readStr As String
        Console.Write("Introduce la temperatura en º Celsius: ")
        readStr = Console.ReadLine
        Decimal.TryParse(readStr, celsius)
        Console.WriteLine(celsius & "º Celsius en Fahrenheit es: " & celsius * 1.8 + 32 & "º y en Kelvin es: " & celsius + 273.15 & "º")
        Console.Write("Introduce la temperatura en º Fahrenheit: ")
        readStr = Console.ReadLine
        Decimal.TryParse(readStr, fahrenheit)
        Console.WriteLine(fahrenheit & "º Fahrenheit en Celsius es: " & (fahrenheit - 32) * 5 / 9 & "º y en Kelvin:" & (fahrenheit - 32) * 5 / 9 + 273.15 & "º")
        Console.Write("Introduce la temperatura en º Kelvin: ")
        readStr = Console.ReadLine
        Decimal.TryParse(readStr, kelvin)
        Console.WriteLine(kelvin & "º Kelvin en Celsius es: " & kelvin - 273.15 & "º y en Fahrenheit: " & (kelvin - 273.15) * 9 / 5 + 32 & "º")
    End Sub

End Module
