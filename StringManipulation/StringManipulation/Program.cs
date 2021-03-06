using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(statement);

            string wordlook, replace;

            Console.WriteLine("");
            Console.WriteLine("Please enter the word you are looking for in the sentence above>>");
            wordlook = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("What would you like to replace it with>>");
            replace = Console.ReadLine();

            bool search = statement.Contains(wordlook, System.StringComparison.CurrentCultureIgnoreCase);

            if (search == true)
            {
                var replacement = statement.Replace(wordlook, replace);
                Console.WriteLine("");
                Console.WriteLine(replacement);
            }

            if (search == false)
            {
                Console.WriteLine($"Sorry, I could not find your word {wordlook}");

                int length;
                string reverse ="";

                length = wordlook.Length - 1;

                while (length >= 0)
                {
                    reverse = reverse + wordlook[length];
                    length--;
                }

                Console.WriteLine("");
                Console.WriteLine($"The reverse of your word is {reverse}");
            }
        }
    }
}
