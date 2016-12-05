Module Module1
	Dim name,lang,ans As String
	Dim counter as UShort = 0
	Sub Main()
		console.writeline("Choose your language,")
		console.writeline("Press 1 for English and 2 for Arabic")
		lang = console.readline()

		while lang<>"1" and lang<>"2"

			console.writeline("PLease enter either 1 or 2 only!")

			lang = console.readline()

		end while

		if lang=1

			name = inputbox("What's your name?", "player name")

		else

			name = inputbox("ما اسمك؟","اسم اللاعب")

		end if
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
					if lang="2"
						if counter > 1 and counter < 11 and counter <> 2
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لقد أجبت على " & counter & " أسئلة بشكل صحيح.")
						elseif counter=1
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لديك إجابة صحيحة واحدة فقط!")
						elseif counter=2
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لديك إجابتان صحيحتان فقط")
						else
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لقد أجبت على " & counter & " سؤالاً بشكل صحيح.")
						end if
						'Chr(13) does the same as vbNewLine
						'MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لقد أجبت على " & counter & " أسئلة بشكل صحيح.")
					else
						MsgBox("Goodbye, " & name & "!" & chr(13) & "You answered " & counter & " question(s) correctly.")
					end if
				End If
			Case Else
				Console.WriteLine("That's wrong! The correct answer is "+Cstr(num1+num2))
				Console.WriteLine("Do you want to try again? (y/n)")
				Dim res As String = Console.ReadLine()
				If res.tolower="y"
					Game()
				Else
					if lang = "2"
						if counter > 1 and counter < 11 and counter <> 2
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لقد أجبت على " & counter & " أسئلة بشكل صحيح.")
						elseif counter=1
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لديك إجابة صحيحة واحدة فقط!")
						elseif counter=2
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لديك إجابتان صحيحتان فقط")
						else
							MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لقد أجبت على " & counter & " سؤالاً بشكل صحيح.")
						end if
						'Chr(13) does the same as vbNewLine
						'MsgBox("إلى اللقاء " & name & "!" & chr(13) & "لقد أجبت على " & counter & qnum)
					else
						MsgBox("Goodbye, " & name & "!" & chr(13) & "You answered " & counter & " question(s) correctly.")
					end if
				End If
		End Select
	End Sub
End Module
