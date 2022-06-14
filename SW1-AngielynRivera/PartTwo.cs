using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1_AngielynRivera
{
    public class PartTwo
    {
        public static void PartTwoSW()
        {
            //Loop1 = 1 loop, result is 15.
            /*int count = 5;
            while (count > 0)
            {
                count = count * 3;
                count = count * -1;
            }
            Console.WriteLine("Loop1: " + count);*/



            //Loop2 = Infinite Loop
            /*int i = 0;
            int count = 0;
            while (i == 0)
            {
                count = count * 3;
                count = count * -1;
            }
            Console.WriteLine("Loop2: " + i);*/



            //Loop3 = (j = j - 1) will be executed 7. Result = 25 

            /*int j = 2;
            for (int i = 1; i < 100; i = i * 2)
            {
                j = j - 1;
                while (j < 25)
                {
                    j = j + 5;
                }
            }
            Console.WriteLine("Loop3: " + j);*/


            //Loop 4 = Infinite Loop
            //while (true) { int i = 1; }


            //Loop 5 = result is 16. (q = p - q) was executed 8 times. 
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
             
            }
            Console.WriteLine("Loop5: " + p);

        }
    }
}
