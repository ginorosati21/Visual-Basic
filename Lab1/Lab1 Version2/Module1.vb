Module Module1

    Sub Main()

        Dim firstName As String
        Dim middleInitial As Char
        Dim lastName As String
        Dim fullName As String
        Dim age As Integer
        Dim isCitizen As Boolean
        Dim canVote As Boolean
        Dim heightFeet As Integer
        Dim heightInches As Decimal
        Dim totalHeightCM As Decimal

        Console.Write("First name        : ")
        firstName = Console.ReadLine
        Console.Write("Middle Initial    : ")
        middleInitial = Console.ReadLine
        Console.Write("Last Name         : ")
        lastName = Console.ReadLine
        fullName = firstName & " " & middleInitial & ". " & lastName

        Console.Write("Age               : ")
        age = Console.ReadLine
        Console.Write("Height Feet       : ")
        heightFeet = Console.ReadLine
        Console.Write("Height Inches     : ")
        heightInches = Console.ReadLine

        Dim totalHeightInches As Decimal = (heightFeet * 12) + heightInches
        totalHeightCM = 2.54 * totalHeightInches

        Console.Write("Citizen true/false: ")
        isCitizen = Console.ReadLine
        Dim isOldEnoughToVote As Boolean = age >= 18
        canVote = isCitizen And isOldEnoughToVote

        Console.WriteLine()
        Console.WriteLine("Full Name ---> " & fullName)
        Console.WriteLine("Height CM ---> " & totalHeightCM)
        Console.WriteLine("Can vote ---> " & canVote)
        Console.ReadKey()

    End Sub

End Module
