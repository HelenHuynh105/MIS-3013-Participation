using System;

namespace Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which animal sound do you want?(Duck,Pig,Cow)");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} makes this sound {AnimalSound(answer)}");
        }

        static string AnimalSound(string animal)
        {
            string sound = "";

            if (animal.ToLower() == "duck")
            {
                sound = "Quack";
            }
            else if (animal.ToLower() == "pig")
            {
                sound = "Oink";
            }
            else if (animal.ToLower() == "cow")
            {
                sound = "Moo";
            }

            return sound;
        }
    }
}
