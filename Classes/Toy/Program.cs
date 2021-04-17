using System;

namespace Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy item1 = new Toy();

            item1.Manufacturer = "Mattle.INC";
            item1.Name = "Birthday Wishes Barbie Doll";
            item1.Price = 46.98;
            item1.Notes = "'Barbie Birthday Wushes doll adds sweetness and fun to any birthday celebration' - Walmart";

            string Item1Information = item1.GetAisle();

            Console.WriteLine($"Item 1 - {Item1Information}");


            Toy item2 = new Toy();
            item2.Manufacturer = "Hasbro";
            item2.Name = "Play-Doh 8 Color Rainbow Pack";
            item2.Price = 4.94;
            item2.Notes = "For Ages 2 and up";

            string Item2Information = item2.GetAisle();

            Console.WriteLine($"\nItem 2 - {Item2Information}");

        }
    }
}
