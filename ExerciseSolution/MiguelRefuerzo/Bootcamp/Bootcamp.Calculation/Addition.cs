using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Calculation
{
    internal class Addition
    {
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void DisplayResult(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Result is {0}", Add(firstNumber, secondNumber)); ;
        }
    }
}
