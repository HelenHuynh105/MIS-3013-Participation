using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess;
            string minNbr, maxNbr;
            int luckyNbr;

            Console.WriteLine("What is your minimum number>>");
            minNbr = Console.ReadLine();

            Console.WriteLine("What is your maximum number>>");
            maxNbr = Console.ReadLine();

            luckyNbr = rand.Next(minNbr, maxNbr);




        }
    }
}
