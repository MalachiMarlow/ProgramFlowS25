'Malachi Marlow
'Spring 2025
'RCET2265
'ProgramFlowS25

Option Explicit On
Option Strict On

Module ProgramFlow

    Sub Main()
        Dim user As Integer '1 & 0
        Dim userInput As String

        'assign 5 to user
        'user = 5

        ''test is user greater than 6
        ''display the result on the console
        'If user > 6 Then
        '    Console.WriteLine(user > 6)
        'End If

        'If user > 3 Then
        '    Console.WriteLine(user > 3)
        'End If

        'If user > 4 Then
        '    Console.WriteLine(user > 4)
        'End If

        ''If anything evaluates to true, ends if statement
        'If user > 6 Then
        '    Console.WriteLine(user > 6)
        'ElseIf user > 3 Then
        '    Console.WriteLine(user > 3)
        'ElseIf user > 4 Then
        '    Console.WriteLine(user > 4)
        'End If

        'user -= 3
        ''If no "If" statements are true, defaults to "else" statement
        'If user > 6 Then
        '    Console.WriteLine($"{user} is such a big number!")
        'ElseIf user > 3 Then
        '    Console.WriteLine($"{user} really? that's all?")
        'ElseIf user > 4 Then
        '    Console.WriteLine($"{user}? Cmon, you can do better than that.")
        'Else
        '    Console.WriteLine($"Pathetic.")
        'End If

        Console.WriteLine("Please enter your age:")
        Console.ReadLine()
        user = CInt(userInput)

        Select Case user
            Case 0 To 3

            Case 4 To 10

            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else

        End Select
    End Sub

End Module
