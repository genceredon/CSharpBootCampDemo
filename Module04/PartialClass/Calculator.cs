using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.PartialClass
{
    public partial class CalcOperator
    {
        public void Calculate(double num1, double num2)
        {            
            Console.WriteLine($"{Add(num1, num2)}, {Subtract(num1, num2)}, {Multiply(num1, num2)}");
            Console.WriteLine();
            Console.WriteLine("\n=====================================");
            Console.WriteLine("End of program...");
            Console.ReadKey();
        }
       
    }
}
