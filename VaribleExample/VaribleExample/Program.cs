using System;

namespace VaribleExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string firstname, lastname;
            double gpa;

            Console.WriteLine("Please enter your first name>>");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name>>");
            lastname = Console.ReadLine();

            Console.WriteLine("Please enter your gpa>>");
            string gpas = Console.ReadLine();
            gpa = Convert.ToDouble(gpas);

            gpa = gpa + .5;

            string output = "Hello " + firstname + " " + lastname + "!" + " We boosted your gpa to " + gpa.ToString("N2");

            Console.WriteLine(output);
        }
    }
}
