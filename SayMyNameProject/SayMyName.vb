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

        'Receive user input
        Console.WriteLine("What is your name?")
        inputString = Console.ReadLine()

        'Respond to user with input in prior line
        Console.WriteLine($"Hello there {inputString}.")
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")

        'pause the console to see the above messages
        Console.ReadLine()
    End Sub

End Module
