Option Explicit On
Option Strict On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/AftaAnfi/SayMyName.git

Module SayMyName
    Dim inputString As String


    Sub Main()
        Console.Title = "Say My Name"
        Console.WriteLine("What is your name?")
        inputstring = Console.ReadLine()
        Console.WriteLine($"Hello there {inputString}.")
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()
    End Sub

End Module
