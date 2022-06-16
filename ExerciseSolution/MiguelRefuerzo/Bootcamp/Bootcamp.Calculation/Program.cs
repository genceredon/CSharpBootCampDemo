using System;

namespace Bootcamp.Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result;
            var test = 0;

            Console.WriteLine("Calculate Numbers. Enter 2 number and we return result");
            Console.WriteLine("Enter 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = Add(num1, num2);
            Console.WriteLine("Add : " + result.ToString());
            Console.ReadLine();
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
