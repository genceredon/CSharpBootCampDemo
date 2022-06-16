using System;

namespace Bootcamp.Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result;

            while (true)
            {
                Console.WriteLine("Do you like to: \na. Add\nb. Subtract\nc. Multiply\nd. Divide\ne. Exit");
                string choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Calculate Numbers. Enter 2 number and we return result");
                        Console.WriteLine("Enter 1st Number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        result = Add(num1, num2);
                        Console.WriteLine("Add : " + result.ToString());
                        Console.ReadLine();
                        break;
                    case "b":
                        Console.Clear();
                        Console.WriteLine("Calculate Numbers. Enter 2 number and we return result");
                        Console.WriteLine("Enter 1st Number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        result = Subtract(num1, num2);
                        Console.WriteLine("Add : " + result.ToString());
                        Console.ReadLine();
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Calculate Numbers. Enter 2 number and we return result");
                        Console.WriteLine("Enter 1st Number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        result = Multiply(num1, num2);
                        Console.WriteLine("Add : " + result.ToString());
                        Console.ReadLine();
                        break;
                    case "d":
                        Console.Clear();
                        Console.WriteLine("Calculate Numbers. Enter 2 number and we return result");
                        Console.WriteLine("Enter 1st Number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        result = Divide(num1, num2);
                        Console.WriteLine("Add : " + result.ToString());
                        Console.ReadLine();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            
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
            return firstNumber / secondNumber;
        }
    }
}
