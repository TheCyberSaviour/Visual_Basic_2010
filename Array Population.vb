Module Module1
    Dim Nums(0 To 9) As Integer   'Globally Declared Array 
    Sub Main()
        Dim x As Integer
        Dim num As String
        Const Dash = "-"

        For x = 0 To 9
            Nums(x) = 0
        Next

        For x = 0 To 9
            Console.WriteLine("Enter Number...(press '-' to stop)")
            num = Console.ReadLine()
            If num = Dash Then
                Exit For
            End If
            Nums(x) = num
        Next

        Console.WriteLine("-------------------------------------")
        For x = 0 To 9
            Console.WriteLine(Nums(x))
        Next
        Call LinearSearch()
        Console.ReadKey()
    End Sub
    Sub LinearSearch()
        Dim Val, x As Integer
        Dim flag As Boolean = False
        Console.WriteLine("Enter Value to Search in Nums(Array)...")
        Val = Console.ReadLine()
        While x <= 9 And flag = False
            If Val = Nums(x) Then
                Console.WriteLine("Value Found in Nums(Array) at index : " & x)
                flag = True
            End If
            x = x + 1
        End While
        If flag = False Then
            Console.WriteLine("Value Not Found in Nums(Array)")
        End If
    End Sub
    Sub BubbleSortAsc()
        'Ascending Order 
        Dim x = 0, tempvar = 0
        Dim swap As Boolean = True
        Dim arraylen As Integer
        arraylen = Len(Nums)
        While x <= arraylen - 1 And swap = True   'len(myarray) - 1 
            swap = False
            If Nums(x + 1) < Nums(x) Then
                tempvar = Nums(x)
                Nums(x) = Nums(x + 1)
                Nums(x + 1) = tempvar
                swap = True
            End If
            x = x + 1
        End While
    End Sub
    Sub BubbleSortDes()
        'Descending Order 
        Dim x = 0, tempvar = 0
        Dim swap As Boolean = True
        Dim arraylen As Integer
        arraylen = Len(Nums)
        While x <= arraylen - 1 And swap = True   'len(myarray) - 1 
            swap = False
            If Nums(x + 1) > Nums(x) Then
                tempvar = Nums(x)
                Nums(x) = Nums(x + 1)
                Nums(x + 1) = tempvar
                swap = True
            End If
            x = x + 1
        End While
    End Sub
End Module

