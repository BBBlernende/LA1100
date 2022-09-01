# Projekt-Dokumentation

Carina Sutter

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|25.08.2022| 0.0.1| Habe geplant und schonmal einen rohen Aufbau des Codes geschrieben. | 
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ich werde ein number guessing game erstellen. Das Programm muss bei der Eingabe einer Zahle sagen können, ob sie zu hoch, zu tief oder der Benutzer die Zahl erraten hat.

### 1.2 User Stories
| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |User muss eine beliebige Zahl eingeben. | Funktionell | Als ein User möchte ich eine beliebige Zahl eingeben, damit mir das Programm sagt, ob ich sie richtig erraten habe, sie zu hoch geraten habe oder zu tief geraten habe. |
| 2    |User muss erneut eine beliebige Zahl eingeben, falls sie zu hoch oder zu tief ist. | Funktionell | als ein User möchte ich erneut eine Zahl eingeben falls ich sie falsch geraten habe, damit ich mehr versuche habe als User. |
| 3    |User kann am Ende entscheiden, ob er nochmal spielen möchte oder nicht. | Qualität| Als ein User möchte ich eingeben können ob ich erneut spielen möchte oder das Spiel beenden möchte, damit es simple bleibt. |
| 4    | User bekommt eine Verabschiedung wenn er sich entscheidet zu gehen| Qualität| Als ein User möchte ich Verabschiedet werden damit ich mich respektiert fühle. |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | User startet das Spiel| beliebige Zahl| Es wird erwartet, dass das Programm entweder sagt, dass die geratene Zahl höcher ist, tiefer ist als die Zahl oder der User die Zahl erraten hat.|
| 2.1  | User möchte nochmals einen Versuch haben| gibt eine erneute beliebige Zahl ein. | Es wird erwartet, dass das Programm erneut sagt das entweder die geratene Zahl höcher ist, tiefer ist als die random Zahl oder der User die Zahl erraten hat.|
| 3.1 | User hat die Zahl erraten. | erneut spielen| Das Programm fängt von vorne an. |
| 3.2 | User hat die Zahl erraten. | spiel beenden| Das Programm sagt auf Wiedersehen. |

### 1.4 Diagramme & Dokumente

![Screenshot 2022-08-25 085923](https://user-images.githubusercontent.com/111045656/186597077-9529cbb2-0c40-45b6-8f7b-6828beafe5b0.png)
![Screenshot 2022-08-25 112943](https://user-images.githubusercontent.com/111045656/186629514-0855dbf1-5b8d-4299-aaaa-bd1dae973c5f.png)

[Lernplan LA1100 NumberGuessingGame.odt](https://github.com/BBBlernende/LA1100/files/9423356/Lernplan.LA1100.NumberGuessingGame.odt)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |25.08.2022|          | mehr Informationen finden für den Lehrplan|30 min. - 1h|
| 2.B  |25.08.2022|          | Lehrplan fertig stellen|30 min. - 45 min.|
| 3.C  |1.09.2022|           | Genauer damit ich mir das Programm und den zukünftigen Code besser vorstellen|30 min. - 45 min.|
| 4.D  |1.09.2022|           | Fertig stellen| 15 min. - 30 min.|
| 5.E  |1.09.2022|           |Nochmal alles durchgehen wenn nötig verbessern oder von mehreren Quellen Code Beispiele finden|5 min.|
| 6.F  |1.09.2022|           | Coden | 2-3 Stunden |

Total: 105 min. - 180 min. = 1h und 45 min. - 3h


## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |25.08.2022|           |30 min. - 1h|      40 min.      |
| 2.B  |1.09.2022 |           |30 - 45 min |      30 min.      |
| 3.C  |1.09.2022 |           |30 - 45 min |      20 min.      |
| 4.D  |1.09.2022 |           |15 - 30 min |      10 min.      |
| 5.E  |1.09.2022 |           |5 min       |       5 min.      |
| 6.F  |1.09.2022 |           | 2 - 3 h    |

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
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem 
