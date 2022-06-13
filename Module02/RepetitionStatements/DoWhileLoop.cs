using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal static class DoWhileLoop
    {
        internal static void InputValuesLoop()
        {
            int startValue, endValue;
            int sum = 0;
            string? inValue = "";

            Console.Write("This program will let you enter");
            Console.Write(" value after value. To Stop, enter");
            Console.WriteLine(" -99");

            do
            {
                Console.WriteLine("Enter the beginning value.");
                startValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the last value.");
                endValue = Convert.ToInt32(Console.ReadLine());

                while (startValue <= endValue)
                {
                    sum = sum + startValue;
                    startValue++;
                }

                Console.WriteLine($"Sum is {sum}");
                Console.WriteLine("Enter value (-99 to exit)");
                inValue = Console.ReadLine();

            } while (inValue != "-99");
        }
    }
}
