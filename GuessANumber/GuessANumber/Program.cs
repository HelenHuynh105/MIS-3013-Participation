using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string answer, guess;
            int minNbr, maxNbr;
            int luckyNbr, correctNbr;

            Console.WriteLine("What is your minimum number>>");
            answer = Console.ReadLine();

            while (int.TryParse(answer, out minNbr) == false)
            {
                Console.WriteLine($"Your answer {answer} is not valid. Please enter another number");
                answer = Console.ReadLine();
            }

            Console.WriteLine("What is your maximum number>>");
            answer = Console.ReadLine();

            while (int.TryParse(answer, out maxNbr) == false)
            {
                Console.WriteLine($"Your answer {answer} is not valid. Please enter another number");
                answer = Console.ReadLine();
            }

            luckyNbr = rand.Next(minNbr, maxNbr);

            Console.WriteLine("Please enter your guess>>");
            guess = Console.ReadLine();

            while (int.TryParse(guess, out correctNbr) == false)
            {
                Console.WriteLine($"Your guess {guess} is not valid. Please enter another guess");
                guess = Console.ReadLine();
            }

            while (int.TryParse(guess, out correctNbr) == true)
            {
                if (correctNbr == luckyNbr)
                {
                    Console.WriteLine($"Your answer was correct! The number was {luckyNbr}");
                    Environment.Exit(-1);
                }
                else if (correctNbr > luckyNbr)
                {
                    Console.WriteLine($"Your answer was too high! Guess again>>");
                    guess = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your guess was too low! Guess again>>");
                    guess = Console.ReadLine();
                }
            }





        }
    }
}
