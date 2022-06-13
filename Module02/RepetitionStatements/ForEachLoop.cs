using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    internal static class ForEachLoop
    {
        internal static void ForEachLoopSampleCode()
        {

            int[] number = {2 ,4, 6, 8, 10 };
            Console.WriteLine("Using ForEachLoop");
            foreach (var item in number)
            {                
                Console.WriteLine(item);
            }

            Console.WriteLine("Using ForLoop");
            for (int i = 0; i < 5; i++)
            {            
                Console.WriteLine(number[i]);
            }

            Console.WriteLine("Using WhileLoop");
            int x = 0;

            while (x < 5)
            {
                Console.WriteLine(number[x]);
                x++;
            }
        }
    }
}
