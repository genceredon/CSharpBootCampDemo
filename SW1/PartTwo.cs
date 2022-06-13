using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    public static class PartTwo
    {
        public static void PartTwoSW()
        {
            // Loop #1
            //int count = 5;
            //while (count > 0)
            //{
            //    count = count * 3;
            //    count = count * -1;
            //}
            // result is -15 it executed once

            // Loop #2
            //int i = 0;
            //int count = 2;
            //while (i == 0)
            //{
            //    count = count * 3;
            //    count = count * -1;
            //}
            // result is forever loop

            // Loop #3
            //int j = 2;
            //for (int i = 1; i < 100; i = i * 2)
            //{
            //    j = j - 1;
            //    while (j < 25)
            //    {
            //        j = j + 5;
            //    }
            //}
            // result is 25 j = j - 1 executed 7 times

            // Loop #4
            //while (true)
            //{
            //    int i = 1;
            //}
            // result is forever loop

            // Loop #5
            //int p = 2;
            //for (int q = 2; q < 32; q = q * 2)
            //{
            //    while (p < q)
            //    {
            //        p = p * 2;
            //    }
            //    q = p - q;
            //}
            // result is 16, q = p - q; executed 8 times
        }
    }
}
