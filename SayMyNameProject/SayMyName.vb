Option Explicit On
Option Strict On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/AftaAnfi/SayMyName.git

Module SayMyName
    Dim inputstring As String


    Sub Main()
        Console.Title = "Say My Name"
        Console.WriteLine("What is your name?")
        inputstring = Console.ReadLine()
        Console.WriteLine($"Hello there {inputstring}.")
        Console.ReadKey(False)


    End Sub

End Module
