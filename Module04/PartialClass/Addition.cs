using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.PartialClass
{
    public partial class CalcOperator
    {
        public double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2}: {sum}");
            return sum;
        }
    }
}
