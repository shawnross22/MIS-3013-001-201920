using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participations
{
    static class Program
    {
        
        static void Main()
        {
            string animal;
            string sound;
            Console.WriteLine("Pick one of these animals. (Cow, Pig, Dog)");
            animal = Console.ReadLine().ToLower();
            Speak(animal);

            Console.ReadKey();
            

        }
        static string Speak(string animal)
        {
            string sound;
            if (animal == "cow")
            {
                sound = "moo";
            }
            else if (animal == "pig")
            {
                sound = "oink";
            }
            else if (animal == "dog")
            {
                sound = "bark";
            }
            else
            {
                Console.WriteLine("You did not enter a valid animal.");
            }
            Console.WriteLine("The " + animal + " makes the sound " + sound + ".");
            return sound;

        }
    }
}
