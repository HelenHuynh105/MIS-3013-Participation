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

        static string AnimalSound(string answer)
        {
            string sound = "";

            if (answer.ToLower() == "Duck")
            {
                sound = "Quack";
            }
            if (answer.ToLower() == "Pig")
            {
                sound = "Oink";
            }
            if (answer.ToLower() == "Cow")
            {
                sound = "Moo";
            }

            return sound;
        }
    }
}
