Module Module1
	Dim name,ans As String
	Dim counter as UShort = 0
	Sub Main()
		name = inputbox("What's your name?", "player name")
		console.writeline("Hello, {0}!", name)
		Game()
	End Sub
	Sub Game()
		Dim random As New Random()
		Dim num1 As Short = random.Next(-999,1000)
		Dim num2 As Short = random.Next(-999,1000)
		Console.WriteLine("Find the sum :")
		Console.Write(Cstr(num1)+" + "+Cstr(num2)+" = ")
		ans = Console.ReadLine()
		Select Case ans
			Case Cstr(num1+num2)
				counter += 1
				Console.WriteLine("Great, " & name & "!")
				Console.Write("You have scored {0} so far..Do you want to continue? (y/n)", counter)
				Dim res As String = Console.ReadLine()
				If res.tolower="y" or res=""
					Game()
				Else
					'Chr(13) does the same as vbNewLine
					MsgBox("Goodbye, " & name & "!" & chr(13) & "You answered " & counter & " question(s) correctly.")
				End If
			Case Else
				Console.WriteLine("That's wrong! The correct answer is "+Cstr(num1+num2))
				Console.WriteLine("Do you want to try again? (y/n)")
				Dim res As String = Console.ReadLine()
				If res.tolower="y"
					Game()
				Else
					MsgBox("Goodbye, " & name & "!" & chr(13) & "You answered " & counter & " question(s) correctly.")
				End If
		End Select
	End Sub
End Module
