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
                string name = Console.ReadLine();
                coursesubject[i] = name;

                Console.WriteLine("Enter a course ID number");
                int id = Convert.ToInt32(Console.ReadLine());
                courseid[i] = id;
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

            double sum = 0;
            foreach (var score in scores)
            {
                sum = sum + score;
            }

            double average = sum / scores.Count;
            Console.WriteLine("Your grade average is " + average);

            int[] grades = new int[] { 90, 92, 80, 93, 97, 99, 75, 80, 82 };
            Dictionary<string, int> finalgrades = new Dictionary<string, int>();


            finalgrades.Add(course[1], grades[0]);
            finalgrades.Add(course[1], grades[1]);
            finalgrades.Add(course[1], grades[2]);
            finalgrades.Add(course[2], grades[3]);
            finalgrades.Add(course[2], grades[4]);
            finalgrades.Add(course[2], grades[5]);
            finalgrades.Add(course[3], grades[6]);
            finalgrades.Add(course[3], grades[7]);
            finalgrades.Add(course[3], grades[8]);

            




            Console.ReadKey();
        }
    }
}
