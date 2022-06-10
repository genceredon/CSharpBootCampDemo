using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.PartialClass
{
    public partial class CalcOperator
    {
        public double Multiply(double num1, double num2)
        {
            double prod = num1 - num2;
            Console.WriteLine($"Product of {num1} and {num2}: {prod}");
            return prod;
        }
    }
}
