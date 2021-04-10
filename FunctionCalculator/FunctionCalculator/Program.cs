using System;

namespace FunctionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first value?");
            double val = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your second value?");
            double val2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What type of calculation do you want to perform?(Addition, Subtraction, Multiply, Divide");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "addition")
            {
                Console.WriteLine($"Your answer is: {Addition(val, val2)}!");
            }
            else if (answer.ToLower() == "subtraction")
            {
                Console.WriteLine($"Your answer is: {Subtraction(val, val2)}!");
            }
            else if (answer.ToLower() == "multiply")
            {
                Console.WriteLine($"Your answer is: {Multiply(val, val2)}!");
            }
            else
            {
                Console.WriteLine($"Your answer is: {Divide(val, val2)}!");
            }

            Console.WriteLine("Do you want a new calculation,use the previous answer and continue, or stop?");
            string NewOrContinue = Console.ReadLine();

            if (NewOrContinue.ToLower() == "new")
            {
                Console.WriteLine("What is your first value?");
                val = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your second value?");
                val2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What type of calculation do you want to perform?(Addition, Subtraction, Multiply, Divide");
                answer = Console.ReadLine();

                if (answer.ToLower() == "addition")
                {
                    Console.WriteLine($"Your answer is: {Addition(val, val2)}!");
                }
                else if (answer.ToLower() == "subtraction")
                {
                    Console.WriteLine($"Your answer is: {Subtraction(val, val2)}!");
                }
                else if (answer.ToLower() == "multiply")
                {
                    Console.WriteLine($"Your answer is: {Multiply(val, val2)}!");
                }
                else if(answer.ToLower() == "divide")
                {
                    Console.WriteLine($"Your answer is: {Divide(val, val2)}!");
                }
                else if (answer.ToLower == "stop")
                {
                    Environment.Exit(-1);
                }
            }


        }

        static double Addition(double val, double val2)
        {
            double sum = val + val2;
            return sum;
        }

        static double Subtraction(double val, double val2)
        {
            double difference = val - val2;
            return difference;
        }

        static double Multiply(double val, double val2)
        {
            double product = val * val2;
            return product;
        }

        static double Divide(double val, double val2)
        {
            double quotient = val / val2;
            return quotient;
        }

        static void DeveloperInformation()
        {
            string Name = "Helen Huynh";
            string Class = "MIS3013";
            string Date = "April 8, 2021";
            
        }
    }
}
