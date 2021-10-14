1. Hur lång tid spenderade du på testet?
Svar: ca 6 timmar.

2. Varför valde du denna lösningen?
Svar: Eftersom jag känner mig bäst på backend valde jag att utveckla backend delen och använda mig av Postman för att testa programmet. Och eftersom kravet var att det ska vara API så valde jag ASP.NET. Jag skapade en klass som heter FileClass som har endast en variabel, Text av typen string såklart en APIController som tog hand kördes när man ladda upp filen dessutom en klass som hade all logik, FileViewModel. Jag skapade även en JSON fil som sparade all text som kom från textfilen, detta för att lättare kommunicera med texten och kunna spara resultatet. Min lösning går ut på följande logik:

A: Tar emot filen från användaren.
B: Läsa av texten i filen.
C: Skicka texten till JSON filen.
D: Ta ut mest använda ordet.
E: Lägga till "foo" i början av ordet och "bar" i slutet.
F: Spara den nya texten i samma JSON fil.
G: Presentera resultatet för användaren.

I början av uppgiften tänkte jag som en användare vad jag ska göra och vad som ska visas i skärmen, detta för att veta exakt vad förväntningarna går ut på. Därfeter valde jag att bygga logiken som tar upp mest använda ordet utan att ladda upp en fil. Dvs en hårdkodad text som jag skapade. Så fort jag fick en lösning för att veta mest använda ordet skapades API metoden och löste de andra delarna. Jag har spelat in min skärm och bifogat filmen med filen.

3. Vad som skulle kunnas läggas till i lösningen?
Svar: Test metoder och att den ska veta om filnamnet existerar i mappen eller inte.

4. Vad tyckte du om testet?
Svar: Jag tycker att testet var utmanande i vissa delar men svårighetsgraden var inte ganska hög. Däremot så var koncentrationen på delar som "testar" logiken på utvecklaren vilket jag gillade.