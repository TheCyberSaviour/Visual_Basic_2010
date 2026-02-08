Module Module1

    Sub Main()
        Dim emaildelete1, emaildelete2, data As String
        data = ""
        Console.WriteLine("Enter the Email to delete :")
        emaildelete1 = Console.ReadLine()
        FileOpen(1, My.Application.Info.DirectoryPath & "\EmailDetails.txt", OpenMode.Input)
        FileOpen(2, My.Application.Info.DirectoryPath & "\NewEmailDetails.txt", OpenMode.Output)
        While Not EOF(1)
            Input(1, data)
            emaildelete2 = Left(data, 4)
            If emaildelete1 <> emaildelete2 Then
                WriteLine(2, data)
            End If
        End While
        FileClose(2)
        FileClose(1)
        Kill(My.Application.Info.DirectoryPath & "\EmailDetails.txt")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\NewEmailDetails.txt", "\EmailDetails.txt")
        Console.WriteLine("Your Data has been Updated")
        Console.ReadKey()
    End Sub

End Module
