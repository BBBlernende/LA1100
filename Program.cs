// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;

public class Program
{
    public static void Main()
    {
        Random myObject = new Random();
        int i = myObject.Next(1, 100);
        int useranswer = 0;
        bool win = false;
        bool wiederspielen = false;

        try
        {


            do
            {

                do
                {
                    Console.Write("Erraten Sie die Zahl indem Sie hier die Zahl eingeben: ");
                    int user = Convert.ToInt32(Console.ReadLine());

                    if (user > i)
                    {
                        Console.Write("Diese Zahl ist zu Hoch. (Enter drücken um fortzufahren)");
                        Console.ReadLine();

                    }
                    else if (user < i)
                    {
                        Console.Write("Diese Zahl ist zu niedrig. (Enter drücken um fortzufahren)");
                        Console.ReadLine();

                    }

                    else if (user == i)
                    {
                        Console.Write("Super! Sie haben die Zahl erraten! ");
                        int answer = Convert.ToInt32(Console.ReadLine());

                        win = true;
                    }

                } while (win == false);

                Console.WriteLine("Möchten Sie nochmal Spielen? [y|n] ");
                char yorn = Convert.ToChar(Console.ReadLine());

                if (yorn == 'y')
                {
                    wiederspielen = true;
                }
                else
                {
                    wiederspielen = false;
                }

            } while (wiederspielen);

        }


 

        
    }
}