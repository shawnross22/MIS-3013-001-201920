﻿//Shawn Ross
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name >>");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number >>");
            int favNumber = Convert.ToInt32(Console.ReadLine());

            int favNumberTimes10 = 10 * favNumber;

            string message = firstName + " you have a favorite number of " + favNumber.ToString("N3") + " and if you multiply that by 10 you get " + favNumberTimes10.ToString("C3");

            if (favNumber == 7 || favNumber==3)
            {
                Console.WriteLine("How original are you?");
            }
            else if (favNumber == 13)
            {
                Console.WriteLine("WHAT? That is an unlucky number");
            }
            else
            {
                Console.WriteLine(message);
            }

            switch (favNumber)
            {
                case 7:
                    Console.WriteLine("How original are you?");
                    break;
                case 3:
                    Console.WriteLine("How original are you?");
                    break;
                case 13:
                    Console.WriteLine("WHAT? That is an unlucky number");
                    break;
                default:
                    Console.WriteLine(message);
                    break;
            }

            if (favNumber % 2 ==0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            




            


            


            Console.ReadKey();
        }
    }
}
