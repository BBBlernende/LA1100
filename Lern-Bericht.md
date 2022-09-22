# Lern-Bericht
Carina Sutter
## Einleitung

Wir mussten ein Programm erstellen, dass eine zufällige Zahl generiert und diese muss dann der Spieler erraten.

## Was habe ich gelernt?

Ich habe gelernt wie man Try und Catch richtig anwendet, damit das Programm nicht einfach abstürzt wenn der User eine fehlerhafte Eingabe eingibt. Im Beispiel unten sehen Sie, dass wir den Qellcode userZahl "versuchen", darum ist er im try drinnen. Wenn jetzt der User anstatt einer Zahl Buchstaben eingibt, wird der "Fehler" aufgefangen durch catch und es wird "Eingabe Ungültig" gedruckt.


```csharp
int userZahl;

try
{
    Console.Write("Geben Sie eine Zahl ein: ");
    userZahl = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Eingabe Ungültig");
}

```

Bei der Ausführung würde es folgendermassen aussehen:
![Screenshot 2022-09-22 104838](https://user-images.githubusercontent.com/111045656/191702635-25326bb3-d6ae-4d67-aa3b-cb8eb8de37f1.png)


## Beschreibung

Try und Catch ist eine Ausnahmebehandlung, die dafür sorgt, dass das Programm nicht einfach abstürzt. Falls der User 

## Verifikation

Sie zeigen das ich das Wissen, das ich habe, anwenden kann und dass ich auch verstehe was ich zeige.

# Reflexion zum Arbeitsprozess

Was gut ging:
Ich konnte mir gut vorstellen wie ich beim Programmieren vorgehen musste und ich konnte mir auch gut vorstellen wie das Endresultat aussehen sollte.
Ich konnte mein geplantes sehr gut umsetzten.
Wenn wir Homeschooling hatten, konnte ich mich sehr gut konzentrieren. Obwohl es online war konnte ich immernoch Sathana kontaktieren und wir halfen uns gegenseitig.

Was nicht so gut ging:
Ich hatte Probleme mit den Schleifen, weil ich noch nicht wusste wie man von einer Schleife zur nächsten gehen kann, wenn das Programm am laufen ist.
Ich wusste nicht so genau was ich bei den User-Stories machen musste. 


**VBV**: nächstes Mal, wenn ich etwas nicht verstehe, sollte ich nochmals nachfragen.
