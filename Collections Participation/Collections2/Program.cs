using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coursesubject = new string[3];
            int[] courseid = new int[3];
            string[] course = new string[3];
            for (int i = 0; i < coursesubject.Length; i++)
            {
                Console.WriteLine("Enter a course subject name");
                coursesubject[i] = Console.ReadLine();
                
                Console.WriteLine("Enter a course ID number");
                courseid[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < course.Length; i++)
            {
                course[i] = coursesubject[i] + courseid[i];
                Console.WriteLine(course[i]);
            }

            


            
            string answer;
            List<double> scores = new List<double>();
            do
            {
                Console.WriteLine("Enter your test grades.");
                double inputnum = Convert.ToDouble(Console.ReadLine());
                scores.Add(inputnum);
                

                Console.WriteLine("Do you have another score to add? (y,n) ");
                answer = Console.ReadLine();


            } while (answer.ToLower() == "y");

            //double sum = 0;
            //foreach (var score in scores)
            //{
            //    sum = sum + score;
            //}

            double average = Average(scores);
            Console.WriteLine("Your grade average is " + average.ToString("P"));

            Dictionary<string, List<double>> studentgrades = new Dictionary<string, List<double>>();
            List<double> mis3013grades = new List<double>();
            mis3013grades.Add(0.95);
            mis3013grades.Add(0.75);
            mis3013grades.Add(0.55);

            List<double> mis3213grades = new List<double>();
            mis3213grades.Add(0.95);
            mis3213grades.Add(0.25);
            mis3213grades.Add(1.00);

            List<double> mis2113grades = new List<double>();
            mis2113grades.Add(0.35);
            mis2113grades.Add(0.25);
            mis2113grades.Add(0.55);

            studentgrades.Add("MIS3013", mis3013grades);
            studentgrades.Add("MIS3213", mis3213grades);
            studentgrades.Add("MIS2113", mis2113grades);



            foreach (var coursecode in studentgrades.Keys)
            {
                List<double> currentGrades = studentgrades[coursecode];
                //double courseCodeAverage = 0;

                //foreach (double grade in currentGrades)
                //{
                //  courseCodeAverage += grade;
                // }

                double courseCodeAverage = Average(currentGrades);
                
                Console.WriteLine($"The average for {coursecode} is {courseCodeAverage/currentGrades.Count}.");
            }







            Console.ReadKey();
        }
        
        /// <summary>
        /// Provided a list of double values, this function will calculate the average
        /// </summary>
        /// <param name="values">A list of double values to calculate the average of</param>
        /// <returns>Return the average of the values</returns>
        static double Average(List<double> values)
        {
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }



            return sum/values.Count;
        }
    }
}
