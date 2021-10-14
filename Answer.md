1. Hur l�ng tid spenderade du p� testet?
Svar: ca 6 timmar.

2. Varf�r valde du denna l�sningen?
Svar: Eftersom jag k�nner mig b�st p� backend valde jag att utveckla backend delen och anv�nda mig av Postman f�r att testa programmet. Och eftersom kravet var att det ska vara API s� valde jag ASP.NET. Jag skapade en klass som heter FileClass som har endast en variabel, Text av typen string s�klart en APIController som tog hand k�rdes n�r man ladda upp filen dessutom en klass som hade all logik, FileViewModel. Jag skapade �ven en JSON fil som sparade all text som kom fr�n textfilen, detta f�r att l�ttare kommunicera med texten och kunna spara resultatet. Min l�sning g�r ut p� f�ljande logik:

A: Tar emot filen fr�n anv�ndaren.
B: L�sa av texten i filen.
C: Skicka texten till JSON filen.
D: Ta ut mest anv�nda ordet.
E: L�gga till "foo" i b�rjan av ordet och "bar" i slutet.
F: Spara den nya texten i samma JSON fil.
G: Presentera resultatet f�r anv�ndaren.

I b�rjan av uppgiften t�nkte jag som en anv�ndare vad jag ska g�ra och vad som ska visas i sk�rmen, detta f�r att veta exakt vad f�rv�ntningarna g�r ut p�. D�rfeter valde jag att bygga logiken som tar upp mest anv�nda ordet utan att ladda upp en fil. Dvs en h�rdkodad text som jag skapade. S� fort jag fick en l�sning f�r att veta mest anv�nda ordet skapades API metoden och l�ste de andra delarna. Jag har spelat in min sk�rm och bifogat filmen med filen.

3. Vad som skulle kunnas l�ggas till i l�sningen?
Svar: Test metoder och att den ska veta om filnamnet existerar i mappen eller inte.

4. Vad tyckte du om testet?
Svar: Jag tycker att testet var utmanande i vissa delar men sv�righetsgraden var inte ganska h�g. D�remot s� var koncentrationen p� delar som "testar" logiken p� utvecklaren vilket jag gillade.