using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal static class WhileLoop
    {
        internal static void InputValuesLoop()
        {
            //Sentinel controlled loop
            //string? inValue = "";

            //Console.Write("This program will let you enter");
            //Console.Write(" value after value. To Stop, enter");
            //Console.WriteLine(" -99");


            //while (inValue != "-99")
            //{
            //    Console.WriteLine("Enter value (-99 to exit)");
            //    inValue = Console.ReadLine();
            //}

            //Counter controlled loop
            //int limit = 0;
            //while (limit < 5)
            //{
            //    Console.WriteLine("Inside counter controlled loop");
            //    limit++; //loop control variable -- limit = limit + 1
            //}

            for (int limit = 0; limit < 5; limit++)
            {
                Console.WriteLine("Inside for loop");
            }


            //State Controlled loop
            //bool flag = true;

            //decimal salesForYear;
            //decimal bonusAmount = 0M;

            //while (flag)
            //{
            //    Console.WriteLine("Inside state controlled loop");
            //    Console.WriteLine("Do you get a bonus this year?");
            //    Console.WriteLine();
            //    Console.WriteLine("To determine if you are due one,");
            //    Console.Write("enter your gross sales figure: ");
            //    salesForYear = Convert.ToDecimal(Console.ReadLine());

            //    if (salesForYear > 500000.00M)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("YES...you get a bonus!");
            //        bonusAmount = 1000.00M;
            //        flag = false; //loop control variable
            //    }                               
            //}

            //Console.WriteLine("Bonus for the year: {0:C}",
            //                   bonusAmount);
        }   
    }
}
