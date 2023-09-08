using Microsoft.VisualBasic;
using System.Media;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Formats.Asn1;

namespace random_number_guesser
{
    internal class Program
    {
        static void Main(string[] args )
        {
            try
            {
                Random random = new Random();
                Players player1= new Players();
                player1.Player1();
                Players player2 = new Players();
                player2.Player2();
                int Turn = 1;
                int RNumber = random.Next(0, 100);
                int Tries = 0;
                int Guess = 0;
                Console.WriteLine("sie müssen eine zahl erraten die zufälligerweise zwischen 1 und 100 generiert wird dabei wird ihnen falls sie falsch erraten haben gesagt ob sie zu hoch geschätzt haben oder nicht (drücken sie enter fals sie es durchgelesen haben)");
                Console.ReadLine();
                while (Guess != RNumber)
                {
                    Tries++;
                    Console.WriteLine("geben sie ihre schätzung ein ");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    if (Guess > 100)
                    {
                        Console.WriteLine("die zahl ist nicht zwischen 1 und 100");
                        throw new Exception();
                    }
                    if (Guess < RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Deine Nummer ist zu klein. Versuchs nochmal {player1}");
                    }
                    else if (Guess > RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Deine Nummer ist zu gross. Versuchs nochmal{player1}");
                    }
                    if (Guess < RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Deine Nummer ist zu klein. Versuchs nochmal{player2}");
                    }
                    else if (Guess > RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Deine Nummer ist zu gross. Versuchs nochmal{player2}");
                    }

                    if (Turn== 1)
                    {
                        Turn++;
                    }
                    else 
                    {
                        Turn--; 
                    }
                }
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Glückwunsch, du hast es in " +Tries +" Versuchen richtig erraten");
                Console.WriteLine("zum das programm beenden drücke enter");
                Console.ReadLine();
            }
            catch
            {
                
            }
        }
    }
}
