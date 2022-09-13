#Lernbericht_Randomnuberguesser
Leonardo Grigioni

## Einleitung
Ich habe ein Spiel programmiert indem man Zahlen erraten muss.

## Was habe ich gelernt?

Ich habe gelernt wie man try throw benutzt, wie man variabeln convertiert, wie man if else/else if schleifen benutzt, wie man die farbe des Textes verändert und was  Environment.Exit(0) macht.

## Beschreibung
Ich habe als erstes dem Spieler eine Anleitung geschrieben mit console.writline.
Danach habe ich angefangen ein Randomnumber Generator zu programieren. Da ich krank war und den Input dazu nie bekommen habe, habe ich im Internet nachgeschaut und habe es mir schnell selber beigebracht.
Ich habe sofort danach angefangen alles mit den Variabeln fest zu halten. Ich habe mit einem if Loop das Programm auf die Schätzungen des Spielers reagieren lassen.
Als ich das das ertse Mal probiert habe ging es einfach nicht, ich habe dann das ganze Programm neu geschrieben und aus irgendeinem Grund ging es dann.
Als ich mit den basis Sachen fertig war, habe ich mit den Fehlermeldungen angefangen. Ich habe mit try und throw gearbeitet.

[Wo Ich den verpassten Stoff nachgeholt habe](https://www.w3schools.com/cs/cs_conditions.php)

Die Zeilen die ich am Anfang noch mal schreiben musste:
```c#
                    if (Guess < RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Deine Nummer ist zu klein. Versuchs nochmal:");



                    }
                    else if (Guess > RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Deine Nummer ist zu gross. Versuchs nochmal:");
                    }
```


## Verifikation

Text: beschreibt Schritt für Schtritt was ich gemacht habe.

Code: zeigt was Ich am Anfang geschrieben habe das nicht funktionierte.

Link: zeigt wo ich mein Wissen nachgeholt habe.

# Reflektion zum Arbeitsprozess
## gut gemacht
Ich habe am Anfang wenige Pausen gemacht und habe viel am Stück gearbeitet.
## schlecht gemacht:
Da ich am Anfang so viel gemacht habe hatte ich gegen Schluss viel Zeit und habe sie nicht gut umgesetzt.
## VBV:
Die Arbeit besser einteilen damit ich konstant in einem Handelbaren Tempo Arbeite.
