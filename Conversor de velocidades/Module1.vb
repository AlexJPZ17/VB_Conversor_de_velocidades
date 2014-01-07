Module Module1

    Sub Main()
        Dim opcion, repetir As Integer
        Dim conv = New Conversor()
        Do
            Console.WriteLine("Escoja una de las opciones")
            Console.WriteLine("1 - Convertir m/s a km/h")
            Console.WriteLine("2 - Convertir km/h a m/s")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                Case 1
                    conv.Conversor1()
                Case 2
                    conv.Conversor2()
                Case Else
                    Console.WriteLine("Opción errónea")
            End Select
            Console.WriteLine("Si desea repetir coloque el valor de 1 o cualquier tecla para salir")
            repetir = Convert.ToInt32(Console.ReadLine())
        Loop While (repetir = 1)
    End Sub

End Module
