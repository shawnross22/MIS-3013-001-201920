//Shawn Ross
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string named firstName
            string firstName;



            //Assign a value to firstName (use your name)
            firstName = "Shawn";

            //Create an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 22;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Ross";

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber + " \nwhich equates to a crazy number of " + crazyNumber);
                                         
            // MAKE IT DYNAMIC
                  
            Console.ReadKey();

    
            }
    }
}
