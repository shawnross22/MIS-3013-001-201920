using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox text1 = new TextBox();
            text1.Padding = 15;
            text1.BackColor = ConsoleColor.Green;
            text1.ForeColor = ConsoleColor.White;
            text1.Text = "Hello, my name is Shawn.";
            text1.DisplayText();

            TextBox text2 = new TextBox();
            text2.Padding = 10;
            text2.BackColor = ConsoleColor.Red;
            text2.ForeColor = ConsoleColor.Black;
            text2.Text = "Hello, my name is Shawn.";
            text2.DisplayText();





            Console.ReadKey();
        }
    }
}
