//Shawn Ross
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations 
    //Conditional Coin Toss
{
    class Program
    {
        static void Main(string[] args)
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




                      
          



           






            

        
            Console.ReadKey();

        }
    }
}
