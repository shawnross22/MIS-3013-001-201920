using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            List<double> examgrades = new List<double>();
            List<double> quizgrades = new List<double>();
            List<double> homeworkgrades = new List<double>();

            do
            {
                double examgrade = GetValidDoubleFromUser("Please enter your exam grade");
                examgrades.Add(examgrade);
                double quizgrade = GetValidDoubleFromUser("Please enter your quiz grade");
                quizgrades.Add(quizgrade);
                double homeworkgrade = GetValidDoubleFromUser("Please enter your homework grade");
                homeworkgrades.Add(homeworkgrade);

                Console.WriteLine("Do you have another value to enter?");
                answer = Console.ReadLine();
            } while (answer != "no");

            int sum = Add(5, 5);
            int firstNum = 3;
            int secondNum = 4;
            double difference = Subtract(firstNum, secondNum);

            Console.ReadKey();
        }

        static double Subtract(int first, int second)
        {
            return first - second;
        }

        static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        static double GetValidDoubleFromUser(string message)
        {
            Console.WriteLine("Please enter your exam grade");
            string response = Console.ReadLine();
            double grade = 0;
            
            while (double.TryParse(response, out grade) != true)
            {
                Console.WriteLine("Sorry, you must enter a valid number, please try again");
                response = Console.ReadLine();
            }
            return grade;
        }
    }

}
