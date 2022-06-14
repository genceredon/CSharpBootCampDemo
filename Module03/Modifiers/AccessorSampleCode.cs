using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03
{
    internal class AccessorSampleCode
    {
        //Example of non value returning method
        public void DisplayOutput() 
        {
            Console.WriteLine($"Sum of two numbers: {SumOfTwoNumbers(50,45)}");
        }

        //Example value returning method
        private double SumOfTwoNumbers(double num1, double num2)
        {         
            Console.WriteLine("Inside SumOfTwoNumbers()");
            return num1 + num2;
        }
    }
}
