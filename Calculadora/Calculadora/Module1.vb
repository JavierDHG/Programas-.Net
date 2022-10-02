Module Module1

    Sub Main()
        Console.WriteLine("Escoga una opción:")
        Console.WriteLine("1. Suma")
        Console.WriteLine("2. Resta")
        Console.WriteLine("3. Multiplicacion")
        Console.WriteLine("4. Division")
        Console.WriteLine("5. Salir")
        Dim opc As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
        If opc = 1 Then
            Console.WriteLine("Escriba el un numero a sumar")
            Dim num0 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Console.WriteLine("Escriba otro numero a sumar")
            Dim num1 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Dim total As Integer = num0 + num1
            Console.WriteLine($"La suma es {total}")
            Console.ReadKey(True)
        End If
        If opc = 2 Then
            Console.WriteLine("Escriba el un numero a restar")
            Dim num0 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Console.WriteLine("Escriba otro numero a restar")
            Dim num1 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Dim total As Integer = num0 - num1
            Console.WriteLine($"La resta es {total}")
            Console.ReadKey(True)
        End If
        If opc = 3 Then
            Console.WriteLine("Escriba el un numero a multiplicar")
            Dim num0 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Console.WriteLine("Escriba otro numero a multiplicar")
            Dim num1 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Dim total As Integer = num0 * num1
            Console.WriteLine($"La multiplicacion es {total}")
            Console.ReadKey(True)
        End If
        If opc = 4 Then
            Console.WriteLine("Escriba el un numero a dividir")
            Dim num0 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Console.WriteLine("Escriba otro numero a dividir")
            Dim num1 As Integer = Console.ReadLine() 'Console.ReadLine()= leer datos ingresados
            Dim total As Integer = num0 / num1
            Console.WriteLine($"La divicion es {total}")
            Console.ReadKey(True)
        End If
        If opc = 5 Then
            Console.WriteLine("Presione cualquier tecla para salir")
            Console.ReadKey(True)
        End If
    End Sub

End Module
