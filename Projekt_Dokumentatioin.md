# Projekt-Dokumentation


Grigioni

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | User stories                                                 |
|       | 0.0.2   | testfälle                                                    |
|       | 0.1.0   | random nuber generator                                       |
|       | 0.1.1   | abfragen der zahlen                                          |
|       | 0.1.2   | antworten ob die Zahl zu gross oder zu klein ist.            |
|       | 0.1.3   | schauen ob die Zahl zwischen 1 und 100 ist                   |
|       | 1.0.0   | die Antworten auf die zu grosse oder zu kleine Zahl sind farbig|



## 1 Informieren

### 1.1 Ihr Projekt

Ich mache ein spiel indem man zahlen erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss           |      |Das spiel ist klar formuliert in der anleitung|
| 2    |  Muss           |      |die basis des spiels funktioniert (Zahlen werden generiert und der user kann sie erraten)     |
| 3    |  Muss           |      |Wenn der spieler etwas eingibt das keine zahl zwischen 1 und 100 ist kommt eine fehlmeldung|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | das program starten: er sieht die anleitung            |enter         | das programm startet                  |
| 1.2     |er gibt die zahl ein: er gibt die zahl ein                |klickt auf das feld und gibt geewünschte zahl ein         |das program antworte ob die zahl zu gross oder zu klein ist                   |
| 1.3  | das programm beenden/neustarten:ein fenster popt auf und dann kann er es beenden          |klicken        | das programm startet neu oder schliest sich  |


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 30.08.22      |ich           |mit console.writeline eine einleitung ersschaffen           |5               |
| 2.A  | 30.08.22      |ich           |random number generator hinzufügen             |30               |
| 2.B  | 30.08.22      |ich           |abfragen der zahl              |30               |
| 2.C  | 30.08.22      |ich           |antwotren  ob die zahl zu gross oder zu klein ist              |100               |
| 3.A  | 06.09.22      |ich           |mit try und throw arbeiten und nach jeder antwort nachschauen ob die zahl zwischen 1 und 100 ist            |30               |
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |   Das Program fragt nach einer Zahl ab          |   Statt eine Zahl wurde etwas anderes eingegeben      |    Es soll scih zeigen das es flasch ist               |       Das Program beendet sich               |



## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein
