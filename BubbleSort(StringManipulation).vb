Module Module1
    'Bubble Sort in fixed string\\000001HassanShoaib
    Sub Main()
        Dim MyFriends As Array
        MyFriends = {"711884Hassan", "545772Meheryar", "848183Suhaib", "574884Ahmad", "448465AbdulMoiz", "844486AbdulRahman", "515815Rayyan"}
        Console.WriteLine("The Array is NOT sorted by BUBBLE SORT")
        Call DisplayArray(MyFriends)
        Call BubbleSort(MyFriends)
        Console.WriteLine("The Array is Sorted in Ascending Order by BUBBLE SORT")
        Call DisplayArray(MyFriends)

        Console.ReadKey()
    End Sub
    Sub BubbleSort(ByVal NewArray As Array)
        Dim temp As String
        Dim swap As Boolean
        temp = ""
        swap = True
        While swap = True
            swap = False
            For x = 0 To 5
                If NewArray(x + 1) < NewArray(x) Then
                    temp = NewArray(x + 1)
                    NewArray(x + 1) = NewArray(x)
                    NewArray(x) = temp
                    swap = True
                End If
            Next
        End While
    End Sub
    Sub DisplayArray(ByVal NewArray As Array)
        For x = 0 To 6
            Console.WriteLine(" " & NewArray(x))
        Next
        Console.WriteLine()
    End Sub
End Module
