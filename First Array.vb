Module Module1

    Sub Main()
        Dim myarray = {"Hassan", "Shoaib", "Shehzada", "Bandeshah"}
        Dim index As Integer
        Dim arraylength As Integer

        arraylength = (myarray.Length) - 1
        index = 0

        FileOpen(1, My.Application.Info.DirectoryPath & "\myrecord.txt", OpenMode.Output)

        For index = 0 To arraylength
            WriteLine(1, myarray(index))
        Next
        FileClose(1)
        Console.WriteLine("The File is Saved")
        Console.ReadKey()

    End Sub

End Module
