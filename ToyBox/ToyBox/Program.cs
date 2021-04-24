using System;

namespace ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox Box1 = new ToyBox();

            Console.WriteLine("Who is the owner of the ToyBox?");
            Box1.Owner = Console.ReadLine();

            Console.WriteLine("Where is the ToyBox?");
            Box1.Location = Console.ReadLine();

            
            do
            {
                

                Console.WriteLine("What is one of your toys in your toybox?");
                ToyBox.Toys.Add(Console.ReadLine());


                Console.WriteLine("Do you have another toy in that toybox?");
                ToyBox.Toys.Add(Console.ReadLine());

            } while (toy.ToLower()[0] = 'y');
        }
    }
}
