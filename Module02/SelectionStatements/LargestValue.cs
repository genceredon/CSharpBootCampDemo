/* LargestValue.cs		 Author:	Doyle	
 * Allows the user to input two values.
 * Determine the largest of the two values.
 * Prints the largest and it square root.
 * **************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal static class LargestValue
    {
        internal static void LargestValueDemoCode()
        {
            int value1,
                value2,
                largestOne;

            Console.Write("Enter the first value: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second value: ");
            value2 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2)
            {
                largestOne = value1;
            }
            else
            {
                largestOne = value2;
            }

            Console.WriteLine();
            Console.WriteLine("The largest value entered was "
                + largestOne);
            Console.WriteLine("Its square root is {0:f2}",
                Math.Sqrt(largestOne));
            Console.ReadLine();
        }
    }
}
