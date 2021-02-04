using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MagicNumber = 7.777; // Local constant Variable //

            double num1, num2, num3, sum, product;

            Console.WriteLine("Please enter your first number>>");
            string Num1 = Console.ReadLine();
            num1 = Convert.ToDouble(Num1);

            Console.WriteLine("Please enter your second number>>");
            string Num2 = Console.ReadLine();
            num2 = Convert.ToDouble(Num2);

            Console.WriteLine("Please enter your third number>>");
            string Num3 = Console.ReadLine();
            num3 = Convert.ToDouble(Num3);

            sum = num1 + num2 + num3;

            product = sum * MagicNumber;

            string output = "Hello the sum of your three numbers is " + sum.ToString("N3") + "!" + " The product of your Sum and 7.777 is "
                              + product.ToString("N3");

            Console.WriteLine(output);






        }
    }
}
