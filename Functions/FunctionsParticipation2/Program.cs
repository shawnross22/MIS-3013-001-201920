using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsParticipation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which participation would you like to run? (StringManipulation, ConditionalCoinFlip, or both)");
            char choice = Console.ReadLine().ToLower()[0];
            
                if (choice == 's')
                {
                    StringManipulation();
                }
                else if (choice == 'c')
                {
                    ConditionalCoinFlip();
                }
                else if (choice == 'b')
                {
                    All();
                }
                else
                {
                    Console.WriteLine("Error. Please enter a valid answer.");
                    rerun = true;
                }
            Console.ReadKey();

            
        }
        static void StringManipulation()
        {
            string phrase = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(phrase);

            Console.WriteLine("What word from the above sentence do you want to replace?");
            string original = Console.ReadLine();

            Console.WriteLine("What word do you want to replace it with?");
            string replacement = Console.ReadLine();

            bool b = phrase.Contains(original);

            if (b == true)
            {
                Console.WriteLine(phrase.Replace(original, replacement));
            }

            else
            {
                string wrong = "Sorry I could not find your word " + original + ".";
                Console.WriteLine(wrong);
                for (int i = original.Length - 1; i >= 0; i--)
                {
                    Console.Write(original[i]);
                }
            }

        }
        static void ConditionalCoinFlip()
        {
            Console.WriteLine("Pick heads or tails: >>");
            string choice = Console.ReadLine().ToLower();


            Random rnd = new Random();
            string[] flip = { "heads", "tails" };

            int fIndex = rnd.Next(flip.Length);

            Console.WriteLine("The flip was {0}", flip[fIndex]);


            if (choice == flip[fIndex])
            {
                Console.WriteLine("Your guess was right!");
            }
            else
            {
                Console.WriteLine("Your guess was wrong :(");
            }

            const string developerName = "Shawn Ross";
            Console.WriteLine(developerName);

        }
        static void All()
        {
            StringManipulation();
            ConditionalCoinFlip();
        }
          
    }
}
