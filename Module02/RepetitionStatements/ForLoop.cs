using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal static class ForLoop
    {
        internal static void InputValuesLoop()
        {

            Console.Write("This program will let you enter");
            Console.Write(" value after value. To Stop, enter");
            Console.WriteLine(" -99");

            for (string? inValue = ""; inValue != "-99"; inValue = Console.ReadLine())
            {
                Console.WriteLine("Enter value (-99 to exit)");
            }
        }
    }
}
