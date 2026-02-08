Module Module1
    Dim Nums(0 To 9) As Integer   'Globally Declared Array 
    Sub Main()
        Dim x = 0, digit = 999
        Dim num As String
        Const Dash = "-"

        For x = 0 To 9   'Initialize Nums(Array)
            Nums(x) = 0
        Next

        '---------------------------------------------------------------------------------------'
        While digit <> 0
            Console.WriteLine("----------------------------------------------------------------")
            Console.WriteLine("Enter Digit 1 to Populate the Array")
            Console.WriteLine("Enter Digit 2 to View the Array")
            Console.WriteLine("Enter Digit 3 to LinearSearch a Value in the Array")
            Console.WriteLine("Enter Digit 4 to BubbleSort Array in Ascending Order")
            Console.WriteLine("Enter Digit 5 to BubbleSort Array in Descending Order")
            Console.WriteLine("Enter Digit 6 to InsertSort Array in Ascending Order")
            Console.WriteLine("Enter Digit 7 to InsertSort Array in Descending Order")
            Console.WriteLine("Enter Digit 8 to BinarySearch a Value in the Array")
            Console.WriteLine("Enter Digit 9 to assign Random Values to the Array")
            Console.WriteLine("Enter Digit 0 to EXIT")
            Console.WriteLine("You must Populate the Array before Searching and Sorting!")
            Console.WriteLine("----------------------------------------------------------------")
            digit = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------------")
            If digit = 1 Then
                For x = 0 To 9
                    Console.WriteLine("Enter Number...(press '-' to stop)")
                    num = Console.ReadLine()
                    If num = Dash Then
                        Exit For
                    End If
                    Nums(x) = num
                Next
                Console.WriteLine("-------------------------------------")
            ElseIf digit = 2 Then
                For x = 0 To 9
                    Console.WriteLine(Nums(x))
                Next
            ElseIf digit = 3 Then
                Call LinearSearch()
            ElseIf digit = 4 Then
                Call BubbleSortAsc(Nums)
            ElseIf digit = 5 Then
                Call BubbleSortDes(Nums)
            ElseIf digit = 6 Then
                Call InsertionSortAsc(Nums)
            ElseIf digit = 7 Then
                Call InsertionSortDes(Nums)
            ElseIf digit = 8 Then
                Call BinarySearch()
            ElseIf digit = 9 Then
                Call RandomNumber()
            End If
        End While
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
    Sub BubbleSortAsc(ByVal NewArray As Array)
        'Ascending Order 
        Dim x = 0, tempvar = 999
        Dim swap As Boolean = True
        While swap = True
            swap = False
            For x = 0 To 8    ''len(myarray) - 1 
                If Nums(x + 1) < Nums(x) Then
                    tempvar = Nums(x + 1)
                    Nums(x + 1) = Nums(x)
                    Nums(x) = tempvar
                    swap = True
                End If
            Next
        End While
        Console.WriteLine("Please press '2' to view changes made to the Array")
    End Sub
    Sub BubbleSortDes(ByVal NewArray As Array)
        'Descending Order 
        Dim x = 0, tempvar = 999
        Dim swap As Boolean = True
        While swap = True
            swap = False
            For x = 0 To 8    ''len(myarray) - 1
                If Nums(x + 1) > Nums(x) Then
                    tempvar = Nums(x + 1)
                    Nums(x + 1) = Nums(x)
                    Nums(x) = tempvar
                    swap = True
                End If
            Next
        End While
        Console.WriteLine("Please press '2' to view changes made to the Array")
    End Sub
    Sub InsertionSortAsc(ByVal NewArray As Array)
        'Ascending Order
        Dim x, i, temp As Integer
        x = 0
        For x = 0 To 9
            temp = Nums(x)
            i = x
            While i > 0 AndAlso Nums(i - 1) >= temp
                Nums(i) = Nums(i - 1)
                i = i - 1
                Nums(i) = temp
            End While
        Next
        Console.WriteLine("Please press '2' to view changes made to the Array")
    End Sub
    Sub InsertionSortDes(ByVal NewArray As Array)
        Dim x, i, temp As Integer
        For x = 0 To 9
            temp = Nums(x)
            i = x
            While i > 0 AndAlso Nums(i - 1) < temp
                Nums(i) = Nums(i - 1)
                i = i - 1
                Nums(i) = temp
            End While
        Next
        Console.WriteLine("Please press '2' to view changes made to the Array")
    End Sub
    Sub BinarySearch()
        Dim found As Boolean = False
        Dim lower, upper, middle, val As Integer
        lower = 0
        upper = 9
        middle = 0
        Console.WriteLine("Make sure the array is Sorted before applying BinarySearch")
        Console.WriteLine("Enter a Number to Search in Array")
        val = Console.ReadLine()
        While upper >= lower And found = False
            middle = upper + lower / 2
            If Nums(middle) = val Then
                found = True
            ElseIf val > Nums(middle) Then
                lower = middle + 1
            ElseIf val < Nums(middle) Then
                upper = middle - 1
            End If
        End While
        If found = True Then
            Console.WriteLine("Number Found in Array")
        Else
            Console.WriteLine("Number NOT Found in Array")
        End If
    End Sub
    Sub RandomNumber()
        Dim RNum, x As Integer
        Dim ub As Integer
        Dim lb As Integer
        Console.WriteLine("Enter Maximum Value needed in Array")
        ub = Console.ReadLine()
        Console.WriteLine("Enter Minimum Value (> 0) needed in Array")
        lb = Console.ReadLine()
        For x = 0 To 9
            RNum = (Int(ub * Rnd()) * lb) + 1
            Nums(x) = RNum
        Next
        Console.WriteLine("Please press '2' to view changes made to the Array")
    End Sub
End Module
