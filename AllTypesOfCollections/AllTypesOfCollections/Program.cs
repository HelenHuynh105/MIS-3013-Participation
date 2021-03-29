using System;
using System.Collections.Generic;

namespace AllTypesOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classsubjects = new string[3];
            string[] classnumbers = new string[3];

            List<double> Grades = new List<double>();
            string answer;
            double grades;

            Dictionary<string, List<double>> coursecode = new Dictionary<string, List<double>>();

            for (int i = 0; i < classsubjects.Length; i++)
            {
                Console.WriteLine("What are your course subject?");
                classsubjects[i] = Console.ReadLine();

                Console.WriteLine("What are your course number for that subject?");
                classnumbers[i] = Console.ReadLine();

            }

            for (int i = 0; i < classnumbers.Length; i++)
            {
                string combo = classsubjects[i] + classnumbers[i];
                Console.WriteLine($"{combo}");
            }

            do
            {
                Console.WriteLine("What is one of your grades?");
                double answers = Convert.ToDouble(Console.ReadLine());

                Grades.Add(answers);

                Console.WriteLine("Do you have another grade?");
                answer = Console.ReadLine();
               
            } while (answer.ToLower()[0] == 'y');

            double sum = 0;

            foreach (var answers in Grades)
            {
                sum += answers;
            }

            double average = sum / Grades.Count;
            Console.WriteLine($"Your average for all your grades is {average}");

            Console.WriteLine("Please enter a course code?");
            string course = Console.ReadLine();

            if (coursecode.ContainsKey(course))
            {
                Console.WriteLine("This course already exists. Please try again!");
                Console.WriteLine("Please enter a course code?");
                course = Console.ReadLine();
            }
            else
            {
                coursecode.Add(course, new List<double>());
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please enter a grade");
                    string grade = Console.ReadLine();
                    while (double.TryParse(grade, out grades) == false)
                    {
                        Console.WriteLine("You did not enter a grade. Please try again!");
                        Console.WriteLine("Please enter a grade");
                        grade = Console.ReadLine();
                    }

                    coursecode[course].Add(grades);
                }
            }

            foreach (var courses in coursecode.Keys)
            {
                Console.WriteLine($"{courses}");
            }

            
        }
    }
}
