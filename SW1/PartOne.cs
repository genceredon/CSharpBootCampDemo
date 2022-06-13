using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    public static class PartOne
    {
        public static void PartOneSW()
        {
            int result = 0; // This variable will hold the final result is 15

            int x = 6; // declare a variable x and set it to 6

            while(x > 3)
            {
                // execute these statements 3 times or as long as x is greater than 3

                result = result + x; // add x to result and it will become 6 then 11 then 15

                x = x - 1; // subtract 1 to 6 and x will become 5 then 4 then 3
            }

            for (int z = 1; z < 3; z = z + 1)
            {
                // start the loop by z = 0 and result = 0
                // keep looping as long as z is less than 3
                // after each loop, z = 1, z = 2, z = 3
                result = result + z;
            }
            // The next statement will update a TextBlock with text that says
            // The Result is 18
            //myLabel.Text = "The Result is " + result;
            Console.WriteLine("The Result is " + result);
        }
    }
}
