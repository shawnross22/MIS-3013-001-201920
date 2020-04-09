//Shawn Ross
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationParticipation
{
    class Program
    {
        static void Main(string[] args)
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


            





            Console.ReadKey();
        }
    }
}
