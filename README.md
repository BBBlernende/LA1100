# Projekt-Dokumentation

Carina Sutter

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 25.08.2022| 0.0.1   | Habe geplant und schonmal einen rohen Aufbau des Codes geschrieben. | 
| 15.09.2022| 0.0.2   | Habe das geplante implementiert                                     |
| 22.09.2022| 1.0.0   | Alles kontrollieren und Auswerten                                   |
| 22.09.2022| 1.0.1   | Projekt-Dokumentation fertiggestellt.                               |


## 1 Informieren

### 1.1 Ihr Projekt

Ich werde ein number guessing game erstellen. Das Programm muss bei der Eingabe einer Zahle sagen können, ob sie zu hoch, zu tief oder der Benutzer die Zahl erraten hat.

### 1.2 User Stories
| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |User muss eine beliebige Zahl eingeben. | Funktionell | Als ein User möchte ich eine beliebige Zahl eingeben, damit mir das Programm sagt, ob ich sie richtig erraten habe, sie zu hoch geraten habe oder zu tief geraten habe. |
| 2    |User muss erneut eine beliebige Zahl eingeben, falls sie zu hoch oder zu tief ist. | Funktionell | Als ein User möchte ich erneut eine Zahl eingeben, falls ich sie falsch geraten habe, damit ich mehr versuche habe als User. |
| 3    |User kann am Ende entscheiden, ob er nochmal spielen möchte oder nicht. | Funktionell | Als ein User möchte ich eingeben können, ob ich erneut spielen möchte oder das Spiel beenden möchte, damit es simple bleibt. |
| 4    | User bekommt eine Verabschiedung, wenn er sich entscheidet zu gehen| Funktionell | Als ein User möchte ich verabschiedet werden damit ich mich respektiert fühle. |
| 5    | User bekommt neue Zahl, wenn er Spiel wiederholt. | Funktionell | Als User möchte ich, wenn ich das Spiel neu starte, eine neue Nummer haben und nicht die gleiche wie beim vorherigen Spiel. |
| 6    | User bekommt angegeben wie viele versuche er gebraucht hat um die Zahl zu erraten| Funktionell | als User möchte ich die Anzahl von meinen Versuchen wissen.|
| 7    | Gestaltung. | Qualität | Als User möchte ich kein langweiliges Programm sondern das es ansprechend aussieht |
| 8    | Gestaltung. | Qualität | Als User möchte ich ein Emoji wenn ich die Nummer erraten habe. |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | User startet das Spiel| beliebige Zahl| Es wird erwartet, dass das Programm entweder sagt, dass die geratene Zahl höher ist, tiefer ist als die Zahl oder der User die Zahl erraten hat.|
| 2.1  | User möchte nochmals einen Versuch haben| gibt eine erneute beliebige Zahl ein. | Es wird erwartet, dass das Programm erneut sagt das entweder die geratene Zahl höher ist, tiefer ist als die random Zahl oder der User die Zahl erraten hat.|
| 3.1 | User hat die Zahl erraten. | erneut spielen| Das Programm fängt von vorne an. |
| 4.1 | User hat die Zahl erraten. | spiel beenden| Das Programm sagt auf Wiedersehen. |
| 5.1 | User hat Zahl erraten. | spiel beendet | Programm gibt aus wie viele Versuche man hatte. |
| 6.1 | User ist Spiel am Spielen | | Jede Zeile ist Farbig. |


### 1.4 Diagramme & Dokumente

![Screenshot 2022-08-25 085923](https://user-images.githubusercontent.com/111045656/186597077-9529cbb2-0c40-45b6-8f7b-6828beafe5b0.png)
![Screenshot 2022-08-25 112943](https://user-images.githubusercontent.com/111045656/186629514-0855dbf1-5b8d-4299-aaaa-bd1dae973c5f.png)

[Lernplan LA1100 NumberGuessingGame.odt](https://github.com/BBBlernende/LA1100/files/9423356/Lernplan.LA1100.NumberGuessingGame.odt)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |25.08.2022|          | mehr Informationen finden für den Lehrplan|30 min. - 1h|
| 2.A  |25.08.2022|          | Lehrplan fertig stellen|30 min. - 45 min.|
| 3.A  |1.09.2022|           | Genauer damit ich mir das Programm und den zukünftigen Code besser vorstellen|30 min. - 45 min.|
| 4.A  |1.09.2022|           | Fertig stellen| 15 min. - 30 min.|
| 5.A  |1.09.2022|           |Nochmal alles durchgehen wenn nötig verbessern oder von mehreren Quellen Code Beispiele finden|5 min.|
| 6.A  |1.09.2022|           | Coden | 2-3 Stunden |
| 7.A  |15.09.2022|          | Gestaltung| 40 Minuten|

Total: 105 min. - 180 min. = 1h und 45 min. - 3h


## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie in Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |25.08.2022|           |30 min. - 1h|      40 min.      |
| 2.B  |1.09.2022 |           |30 - 45 min |      30 min.      |
| 3.C  |1.09.2022 |           |30 - 45 min |      20 min.      |
| 4.D  |1.09.2022 |           |15 - 30 min |      10 min.      |
| 5.E  |1.09.2022 |           |5 min       |       5 min.      |
| 6.F  |1.09.2022 |           | 2 - 3 h    |      5 Stunden    |
| 7.G  |15.09.2022|           | 40 min.    |      40 min.      |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   22.09.2022    | Funktioniert| Carina Sutter |
| 2.1  |   22.09.2022    | Funktioniert| Carina Sutter |
| 3.1  |   22.09.2022    | Funktioniert| Carina Sutter |
| 4.1  |   22.09.2022    | Funktioniert| Carina Sutter |
| 5.1  |   22.09.2022    | Funktioniert| Carina Sutter |
| 6.1  |   22.09.2022    | Funktioniert| Carina Sutter |
Test fazit: Das Programm ist so abgelaufen wie Ich es geplant habe.


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem

https://github.com/BBBlernende/LA1100/blob/main/Lern-Bericht.md#lern-bericht
