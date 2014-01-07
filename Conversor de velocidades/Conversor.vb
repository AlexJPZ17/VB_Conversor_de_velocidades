Public Class Conversor
    Dim velocidad As Double
    Public Sub Conversor1()
        Console.WriteLine("Introduzca una velocidad en m/s")
        velocidad = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine(velocidad & " m/s = " & velocidad * 3600 / 1000 & " km/h")
    End Sub
    Public Sub Conversor2()
        Console.WriteLine("Introduzca una velocidad en km/h")
        velocidad = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine(velocidad & " km/h = " & velocidad * 1000 / 3600 & " m/s")
    End Sub
End Class
