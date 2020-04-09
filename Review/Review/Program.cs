using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How much money will you save per week?");
			double amount = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("What is your interest rate per month?");
			double rate = Convert.ToDouble(Console.ReadLine())/100;
			Console.WriteLine("How many years will you save for?");
			double years = Convert.ToDouble(Console.ReadLine());

			double monthcount=1;
			double weeks = years * 12 * 4;
			double months = years * 12;
			double amountPerMonth = amount * 4;
			double sum = amountPerMonth * (rate+1);




			for (monthcount = 1; monthcount < months+1 ; monthcount++)
			{
				sum = sum * (rate+1);
				Console.WriteLine("After month " + monthcount + " you have saved " + sum);
				
			}
			Console.ReadKey();
		}

	}
}
