/* BonusCalculator.cs	Author:	Doyle	
 * Allows the user to input their
 * gross sales for the year. This value
 * is checked to determine whether
 * a bonus is in order.  
 **************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal class BonusCalculator
    {
        internal static void BonusCalculatorDemoCode()
        {
			decimal salesForYear;
			decimal bonusAmount = 0M;

			Console.WriteLine("Do you get a bonus this year?");
			Console.WriteLine();
			Console.WriteLine("To determine if you are due one,");
			Console.Write("enter your gross sales figure: ");
			salesForYear = Convert.ToDecimal(Console.ReadLine());

			if (salesForYear > 500000.00M)
			{
				Console.WriteLine();
				Console.WriteLine("YES...you get a bonus!");
				bonusAmount = 1000.00M;
            }
            else
            {
				bonusAmount = 100.00M;
            }
			
			Console.WriteLine("Bonus for the year: {0:C}", bonusAmount);
			//Console.WriteLine($"Bonus for the year: {bonusAmount}");
			
			Console.ReadLine();
		}

		private void BonusCalculatorNestedIf()
		{
			decimal salesForYear;
			decimal bonusAmount = 0M;
			string? isHourlyEmployee;
			int hours, yearsEmployed;

			Console.WriteLine("Do you get a bonus this year?");
			Console.WriteLine();
			Console.WriteLine("To determine if you are due one,");
			Console.Write("enter your gross sales figure: ");
			salesForYear = Convert.ToDecimal(Console.ReadLine());

			if (salesForYear > 500000.00M)
			{
				Console.WriteLine();
				Console.WriteLine("YES...you get a bonus!");
				bonusAmount = 1000.00M;
			}

			Console.WriteLine("Bonus for the year: {0:C}",
								bonusAmount);

			Console.WriteLine("Additional Bonus...");
			Console.Write("Are you an hourly employee? Please input Y/y or N/n: ");
			isHourlyEmployee = Console.ReadLine();

            if (isHourlyEmployee?.ToLower() == "y")
            {
				Console.WriteLine("Enter number of hours rendered: ");
				hours = Convert.ToInt32(Console.ReadLine());
               
				if (hours > 40)
                {
					bonusAmount += 500; //bonusAmount = bonusAmount + 500
                }
                else
                {
					bonusAmount += 100;
                }
            }
            else
            {
				Console.Write("Enter number of years Employed: ");
				yearsEmployed = Convert.ToInt32(Console.ReadLine());

                if (yearsEmployed > 10)
                {
					bonusAmount +=  300;
                }
                else
                {
					bonusAmount += 200;
				}
			}

			Console.WriteLine("Total Bonus for the year + Additional bonus: {0:C}",
								bonusAmount);
			Console.ReadLine();
		}
	}
}
