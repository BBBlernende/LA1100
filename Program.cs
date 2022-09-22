// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Reflection.Metadata;

public class Program
{
    public static void Main()
    {
        Random r1 = new Random();
        int i = r1.Next(1, 100);
        int useranswer = 0;
        bool win = false;
        bool wiederspielen = true;
        int versuch = 0;

        try
        {


            do
            {

                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Erraten Sie die Zahl indem Sie hier die Zahl eingeben: ");
                    int user = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    // code falls user nummer zu gross erraten hat

                    if (user > i)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Diese Zahl ist zu Hoch.");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");
                        versuch++;
                    }

                    // code falls user nummer zu klein erraten hat

                    else if (user < i)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Diese Zahl ist zu niedrig.");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");
                        versuch++;
                    }

                    // code wenn user nummer erraten hat

                    else if (user == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Super! Sie haben die Zahl erraten! ");
                        Console.ResetColor();
                        win = true;
                        versuch++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Sie brauchten " + versuch + " Versuche um die generierte Zahl zu erraten");
                        Console.ResetColor();

                        // frage ob user nochmal spielen möchte

                        Console.Write("Möchten Sie nochmal Spielen? [y|n] ");
                        char yorn = Convert.ToChar(Console.ReadLine());

                        
                        
                        
                        // loop falls ja

                        if (yorn == 'y')
                        {
                            
                            wiederspielen = true;
                            i = r1.Next(1, 100);      
                            versuch = 0;

                        }

                        // loop falls nein

                        else
                        {
                            wiederspielen = false;
                            Console.WriteLine("Vielen Danke fürs spielen. Ich wünsche Ihnen einen schönen Tag.");
                        }
                        
                    }
                    

                } while (win == false);

                

            } while (wiederspielen);

        }

        // code falls user buchstaben oder sonstige zeichen eingibt ausser zahlen 

        catch
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Eingabe Ungültig. Starten Sie das Programm bitte neu.");
            Console.ResetColor();
            Environment.Exit(0);
        }

 

        
    }
}