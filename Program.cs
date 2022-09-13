using Microsoft.VisualBasic;

namespace random_number_guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();



                int RNumber = random.Next(0, 100);



                int Guess = 0;



                Console.WriteLine("sie müssen eine zahl erraten die zufälligerweise zwischen 1 und 100 generiert wird dabei wird ihnen falls sie falsch erraten haben gesagt ob sie zu hoch geschätzt haben oder nicht (drücken sie enter fals sie es durchgelesen haben)");
                Console.ReadLine();


                while (Guess != RNumber)
                {
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
                        Console.WriteLine("Deine Nummer ist zu klein. Versuchs nochmal:");



                    }
                    else if (Guess > RNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Deine Nummer ist zu gross. Versuchs nochmal:");



                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Glückwunsch, du hast es richtig erraten");
                Console.WriteLine("zum das programm beenden drücke enter");
                Console.ReadLine();
            }
            catch
            {
                Environment.Exit(0);
            }
        }
    }
}