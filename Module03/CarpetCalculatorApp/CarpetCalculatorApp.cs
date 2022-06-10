using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03.CarpetCalculatorApp
{
    internal class CarpetCalculatorAppDemo
    {
		internal void Calculate()
        {
			CarpetCalculator berber = new CarpetCalculator(17.95);

			double roomWidth;
			double roomLength;

			DisplayInstructions();

			// Call getDimension( ) to get the length
			roomLength = GetDimension("Length");

			// Call getDimension( ) again to get the width
			roomWidth = GetDimension("Width");
			berber.SetNoOfSqYards(roomLength, roomWidth);
			berber.PricePerSqYard = 25.99;
			Console.Clear();
			Console.Write(berber.DisplayResult());
			Console.ReadLine();
		}

		static void DisplayInstructions()
		{
			Console.WriteLine("This program will "
				+ "determine how much "
				+ "carpet to purchase.");
			Console.WriteLine();
			Console.WriteLine("You will be asked to enter "
				+ "the size of the room ");
			Console.WriteLine("and the price of the carpet, "
				+ "in price per square yds.");
			Console.WriteLine();
		}

		static double GetDimension(string side)
		{
			// local variables
			// needed only by this
			// method
			int feet,            
				inches;         

			Console.Write("Enter the {0} in feet: ",
				side);
			feet = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the {0} in inches: ",
				side);
			inches = Convert.ToInt32(Console.ReadLine());

			// Note: cast required to avoid int division
			return (feet + (double)inches / 12);
		}
	}
}
