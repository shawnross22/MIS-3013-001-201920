using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string answer;
            List<double> score = new List<double>();
            do
            {
                Console.WriteLine("Enter your test grades.");
                double inputnum = Convert.ToDouble(Console.ReadLine());
                score.Add(inputnum);
                sum += inputnum;


                Console.WriteLine("Do you have another score to add? (y,n) ");
                answer = Console.ReadLine();


            } while (answer.ToLower() == "y");

            
            double max = score[0];
            double min = score[0];
            double average= sum/score.Count;

            for (int i = 0; i < score.Count; i++)
            {   
                bool a = score[i] < min; 
                bool b = score[i] > max;
                if (b == true)
                {
                    max = score[i];
                }
                if (a == true)
                {
                    min = score[i];
                }
            }
           

            Console.WriteLine("Your max exam score is " + max + ".");
            Console.WriteLine("Your min exam score is " + min + ".");
            Console.WriteLine("Your avg exam score is " + average + ".");

            Console.ReadKey();
        }
    }
}
