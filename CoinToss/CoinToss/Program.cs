using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const string name = "Helen Huynh";
            string guess;
            int randomNumber = rand.Next(1,3);


            Console.WriteLine("Guess heads or tails>>");
            guess = Console.ReadLine();

            if (guess == "heads" & randomNumber == 1)
            {
                
                Console.WriteLine("The coin landed on " + randomNumber.ToString("Heads") + "! Your guess was right");
            }

            else if (guess == "heads" & randomNumber == 2)
            {
                Console.WriteLine("The coin landed on " + randomNumber.ToString("Tails") + "! Your guess was wrong");
            }

            else if (guess == "tails" & randomNumber == 2)
            {
                Console.WriteLine("The coin landed on " + randomNumber.ToString("Tails") + "! Your guess was right");
            }

            else
            {
                Console.WriteLine("The coin landed on " + randomNumber.ToString("Heads") + "! Your guess was wrong");
            }

            Console.WriteLine(name);
        }
    }
}
