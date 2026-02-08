Module Module1
    Sub Main()
        Dim sign As String
        Dim a, b As Single
        Dim equals As Single
        a = 0
        b = 0
        Console.WriteLine("Enter Number :")
        a = Console.ReadLine()
        b = Console.ReadLine()
        Console.WriteLine("Enter Sign (+) (-) (*) (/) (!)")
        sign = Console.ReadLine()

        If sign = "+" Then
            equals = Add(a, b)
        ElseIf sign = "-" Then
            equals = Subtract(a, b)
        ElseIf sign = "*" Then
            equals = Multiply(a, b)
        ElseIf sign = "/" Then
            equals = Divide(a, b)
        ElseIf sign = "!" Then
            equals = Factorial(a)
        Else
            Console.WriteLine("Please Enter a Valid Sign")
        End If
        Console.WriteLine(equals)
        Console.ReadKey()
    End Sub
    Function Add(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        equals = a + b
        Return equals
    End Function
    Function Subtract(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        equals = a - b
        Return equals
    End Function
    Function Multiply(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        equals = a * b
        Return equals
    End Function
    Function Divide(ByVal a As Integer, ByVal b As Integer) As Single
        Dim equals As Single
        equals = a / b
        Return equals
    End Function
    Function Factorial(ByVal a As Integer) As Integer
        Dim equals As Integer
        Dim num As Integer
        Dim x As Integer
        x = 1
        Console.WriteLine("Enter Number (!)")
        num = Console.ReadLine()
        If num = 1 Then
            Console.WriteLine("1")
        End If
        While x = num
            num = num * x
            x = x + 1
        End While
        Return num
    End Function
End Module
