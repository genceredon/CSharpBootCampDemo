using System;

namespace Bootcamp.Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result;
            bool repeat = true;
            Addition add; // Addition class

            while (repeat) // To repeat the entire process
            {
                Console.Clear(); // Clear cmd
                DisplayUI.UserInterface(); // Display the UI
                string choice = Console.ReadLine();

                switch (choice.ToLower()) 
                {
                    case "a":
                        Console.Clear();
                        DisplayUI.UserInterfaceProblem();
                        DisplayUI.UserInterfaceFirstInput();
                        num1 = Convert.ToInt32(Console.ReadLine());
                        DisplayUI.UserInterfaceSecondInput();
                        num2 = Convert.ToInt32(Console.ReadLine());
                        add = new Addition();
                        add.DisplayResult(num1,num2);
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
                    case "e":
                        repeat = false; // To exit the process
                        break;
                    default:
                        break;
                }
            }
            
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
