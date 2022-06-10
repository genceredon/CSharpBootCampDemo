using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.PartialClass
{
    public partial class CalcOperator
    {
        public double Subtract(double num1, double num2)
        {
            double diff = num1 - num2;
            Console.WriteLine($"Difference of {num1} and {num2}: {diff}");
            return diff;
        }
    }
}
