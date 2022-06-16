using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Calculation
{
    internal class DisplayUI
    {
        public static void UserInterface()
        {
            Console.WriteLine("Do you like to:");
            Console.WriteLine("a. Add");
            Console.WriteLine("b. Subtract");
            Console.WriteLine("c. Multiply");
            Console.WriteLine("d. Divide");
            Console.WriteLine("e. Exit");
        }

        public static void UserInterfaceProblem()
        {
            Console.WriteLine("Calculate Numbers. Enter 2 number and we return result");
        }

        public static void UserInterfaceFirstInput()
        {
            Console.WriteLine("Enter 1st Number: ");
        }
        public static void UserInterfaceSecondInput()
        {
            Console.WriteLine("Enter 2nd Number: ");
        }
    }
}
