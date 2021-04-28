using System;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            Cereal C1 = new Cereal();

            for (int i = 1; i < lines.Length; i++)
            {
                string currentLineOfFile = lines[i];

                string[] pieces = currentLineOfFile.Split("|");

                C1.Manufacturer = pieces[1];
                C1.Name = pieces[0];
                C1.Calories = Convert.ToDouble(pieces[2]);
                C1.Cups = Convert.ToDouble(pieces[3]);

                if (C1.Cups >= 1)
                {
                    Console.WriteLine($"\n{C1.Name}|{C1.Manufacturer}|{C1.Calories}|{C1.Cups}");
                    if (C1.Calories <= 100)
                    {
                        Console.WriteLine("This ceral has 100 calories or less");
                    }
                }
            }
        }
    }
}
