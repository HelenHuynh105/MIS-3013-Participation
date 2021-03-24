using System;
using System.Collections.Generic;

namespace CollectionsMinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ExamGrades = new List<double>();
            Dictionary<double, int> MODE = new Dictionary<double, int>();
            string answer;

            do
            {
                Console.WriteLine("What is one of your exam grades? >>");
                double answers = Convert.ToDouble(Console.ReadLine());

                ExamGrades.Add(answers);

                Console.WriteLine("Do you have another exam grade?>>");
                answer = Console.ReadLine();

                if (MODE.ContainsKey(answers) == false)
                {
                    MODE.Add(answers, 1);
                }
                else
                {
                    MODE[answers] = MODE[answers] + 1;
                }

            } while (answer.ToLower()[0] == 'y');

            double min = ExamGrades[0];
            double max = ExamGrades[0];
            double sum = 0;
            int NumCount = 1;

            foreach (var answers in ExamGrades)
            {
                if (answers < min)
                {
                    min = answers;
                }

                if (answers > max)
                {
                    max = answers;
                }

                sum += answers;
               
            }

            foreach (double key in MODE.Keys)
            {
                double answers = key;
                if (MODE[answers] > NumCount)
                {
                    NumCount++;
                    Console.WriteLine($"The mode is {answers} x {NumCount}");
                }
            }

            double average = sum / ExamGrades.Count;

            Console.WriteLine($"Your minimum exam grade is {min.ToString("N2")}");
            Console.WriteLine($"Your maximum exam grade is {max.ToString("N2")}");
            Console.WriteLine($"Your average for all your exams is {average.ToString("N2")}");
            


        }
    }
}
