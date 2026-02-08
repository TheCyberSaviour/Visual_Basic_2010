Module Module1
    '2D Array Linear Search
    Dim ClassResult(0 To 2, 0 To 3) As String   '3 Students and 3 Assessments 
    'Teacher Input the marks of students in the array.
    Sub Main()
        Dim i = 0, x = 0, digit = 999
        For i = 0 To 2   ''Initialise the 2D Array
            For x = 0 To 3
                ClassResult(i, x) = 0
            Next
        Next

        ClassResult(0, 0) = "Muhammad"
        ClassResult(0, 1) = "100"
        ClassResult(0, 2) = "100"
        ClassResult(0, 3) = "100"
        ClassResult(1, 0) = "Hassan"
        ClassResult(1, 1) = "100"
        ClassResult(1, 2) = "100"
        ClassResult(1, 3) = "100"
        ClassResult(2, 0) = "Aliha"
        ClassResult(2, 1) = "100"
        ClassResult(2, 2) = "100"
        ClassResult(2, 3) = "100"

        Call LinearSearch()
        Console.ReadKey()
    End Sub
    Sub StudentsPresent()
        For i = 0 To 2
            For x = 0 To 0
                Console.WriteLine(ClassResult(i, x))
            Next
        Next
    End Sub
    Sub LinearSearch()
        'Search the name of student in the array and return a suitable statement 
        Dim StName As String = ""
        Dim flag As Boolean = False
        Console.WriteLine("Enter Student Name to search in Class...")
        StName = Console.ReadLine()
        '*Only* Search the Student Name
        While flag = False
            For i = 0 To 2
                For x = 0 To 0
                    If StName = ClassResult(i, x) Then
                        Console.WriteLine("Student was Present in Exam")
                        flag = True
                    End If
                Next
            Next
        End While
        If flag = False Then
            Console.WriteLine("Student was Absent in Exam")
        End If
    End Sub
End Module
