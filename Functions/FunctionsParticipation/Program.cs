//Shawn Ross
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Shawn Ross", "MIS 3013", "3/9/20");

            Console.WriteLine("What type of calculation do you want to perform?");
            string calc = Console.ReadLine().ToLower();
            Console.WriteLine("What is your first value?");
            double firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your second value?");
            double secondnum = Convert.ToDouble(Console.ReadLine());
            double result;
            string choice;

            if (calc == "add")
            {
                result = Add(firstnum, secondnum);
            }
            else if (calc == "subtract")
            {
                result = Subtract(firstnum, secondnum);
            }
            else if (calc == "multiply")
            {
                result = Multiply(firstnum, secondnum);
            }
            else/
            {
                result = Divide(firstnum, secondnum);
            }
            Console.WriteLine("Your result is " + result);
            do
            {
                Console.WriteLine("Would you like to perform a new calculation(n), use your result in a follow up calculation(f), or stop(s)?");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("What type of calculation do you want to perform?");
                    calc = Console.ReadLine().ToLower();
                    Console.WriteLine("What is your first value?");
                    firstnum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is your second value?");
                    secondnum = Convert.ToDouble(Console.ReadLine());

                    if (calc == "add")
                    {
                        result = Add(firstnum, secondnum);
                    }
                    else if (calc == "subtract")
                    {
                        result = Subtract(firstnum, secondnum);
                    }
                    else if (calc == "multiply")
                    {
                        result = Multiply(firstnum, secondnum);
                    }
                    else
                    {
                        result = Divide(firstnum, secondnum);
                    }
                    Console.WriteLine("Your result is " + result);

                }
                else if (answer == "f")
                {
                    Console.WriteLine("What is your new second value?");
                    secondnum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What new calculation would you like to perform?");
                    calc = Console.ReadLine().ToLower();

                    if (calc == "add")
                    {
                        result = Add(result, secondnum);
                    }
                    else if (calc == "subtract")
                    {
                        result = Subtract(result, secondnum);
                    }
                    else if (calc == "multiply")
                    {
                        result = Multiply(result, secondnum);
                    }
                    else if (calc == "divide")
                    {
                        result = Divide(result, secondnum);
                    }
                    Console.WriteLine("Your result is " + result);
                }
                else
                {
                    Console.WriteLine("Thank you for using the service.");

                }
                Console.WriteLine("Do you want to do another calculation? (y,n)");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");


            Console.ReadKey();
        }
        static void DeveloperInformation(string name, string classname, string date)
        {
            Console.WriteLine(name + " wrote this application for " + classname + " on " + date);
        }
        static double Add(double v1, double v2)
        {
            return v1 + v2;
        }
        static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }
        static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }
        static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }
    }
}
