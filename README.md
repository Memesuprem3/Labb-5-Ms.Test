# Labb-5-Ms.Test


Koden ligger i Master-Branch

Jag har tre huvudsakliga funktioner i bankapplikation som jag testar: PrintTransferHistory, GetPassword, och AddUser. 
Här är en genomgång av potentiella problem och risker för varje funktion.

1. PrintTransferHistory

Potentiella problem:
Tom lista:
 Om TransferLogs är tomt, borde metoden inte skriva ut något. Vi behöver kontrollera att ingen output sker och att inga undantag kastas.

 PrintTransferHistory_AllLogsPrinted: Kontrollera att alla loggar skrivs ut korrekt.

Felaktig data i loggar:
Om loggar innehåller null-värden eller oförväntade data, måste metoden hantera detta korrekt utan att krascha.

PrintTransferHistory_EmptyLogs_NoOutput: Kontrollera att ingen output sker för en tom lista.

Konsoloutput:
Att skriva till konsolen kan misslyckas av olika skäl, inklusive felaktiga tecken eller problem med konsolens tillstånd.

PrintTransferHistory_NoExceptionThrown: Kontrollera att inga undantag kastas.

2. GetPassword

Potentiella problem:
Tom inmatning:
Om ingen inmatning ges, ska metoden returnera "Enter password". Om detta inte hanteras korrekt kan det leda till felaktiga meddelanden eller undantag.

Jämförelse av lösenord:
Felaktig jämförelse av lösenord kan leda till att fel meddelande returneras (t.ex. "Password accepted" när det borde vara "Wrong password").

3. AddUser

Potentiella problem:
Tomma inmatningar:
Om användarnamn eller PIN-kod är tomma kan det skapa ofullständiga användare. Metoden bör hantera tomma inmatningar och visa felmeddelanden.

Dubbelregistrering:
Om samma användarnamn registreras flera gånger kan det skapa problem med unika identifierare. Metoden bör kontrollera om användarnamnet redan existerar.

Felaktig inmatning:
Inmatning som innehåller otillåtna tecken eller format kan orsaka problem. Metoden bör validera inmatning för att säkerställa korrekt format.

Lista över kundobjekt:
Om CustomerList är null kan det orsaka undantag. Metoden bör säkerställa att listan är initierad innan den används.   
