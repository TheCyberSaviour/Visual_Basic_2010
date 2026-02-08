Module Module1

    Sub Main()
        Dim myarray = {"hassan", "shoaib", "shehzada", "bandashah"}
        Dim arraylen, index As Integer
        Dim name As String

        name = ""
        arraylen = (myarray.Length) - 1
        index = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\mylist.txt", OpenMode.Output)
        Console.WriteLine("Enter Student Name:")
        name = Console.ReadLine()

        For index = 0 To arraylen
            WriteLine(1, myarray(index))
        Next
        For index = 0 To arraylen
            If name = myarray(index) Then
                Console.WriteLine("Name Found")
            Else
                Console.WriteLine("Name Not Found")
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
