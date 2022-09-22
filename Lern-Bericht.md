# Lern-Bericht
Carina Sutter
## Einleitung

Wir mussten ein Programm erstellen, dass eine zufällige Zahl generiert und diese muss dann der Spieler erraten.

## Was habe ich gelernt?

Ich habe gelernt wie man Try und Catch richtig anwendet, damit das Programm nicht einfach abstürzt wenn der User eine fehlerhafte Eingabe eingibt. Im Beispiel unten sehen Sie, dass wir den Qellcode userZahl "versuchen, darum ist er im try drinnen. Wenn jetzt der User anstatt einer Zahl Buchstaben eingibt, wird der "Fehler" aufgefangen durch catch und es wird "Eingabe Ungültig" gedruckt.


```csharp
int userZahl;

try
{
  Console.Write("Geben Sie eine Zahl ein: ");
  userZahl = Console.ReadLine();  
}
catch
{
  Console.WriteLine("Eingabe ungültig");
}

```


## Beschreibung

Try und Catch ist eine Ausnahmebehandlung, die dafür sorgt, dass das Programm nicht einfach abstürzt.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
