//Shawn Ross
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Shawn";
            string lastName = "Ross";

            Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your first name.");
            Console.WriteLine($"You have {lastName.Length.ToString("N0")} characters in your last name.");

            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            
            for (int i = 0; i < firstName.Length; i++)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);
            }

            foreach (char currentLetter in lastName)
            {
                Console.WriteLine(currentLetter);
            }

            for (int i = 0; i < firstName.Length; i=i+2)
            {
                char currentLetter = firstName[i];
                Console.Write(currentLetter + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");

            string name = firstName + " " + lastName;

            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }

            Console.WriteLine();
            string fName = name.Substring(0, firstName.Length);
           
            Console.WriteLine(fName);

            Console.ReadKey();

        }
    }
}
