using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1_AngielynRivera
{
    public class PartOne
    {
        public static void PartOneSW()
        {
            int result = 0; //this variable will hold the final result.
            int x = 6; //declare a variable x and set it to 6

            while (x > 3) //execute these statements as long as x is greater than 3. (x is equal to 6 as we have declared)
            {
                result = result + x; //add x to result -> (As per loop = 6 -> 11 -> 15) RESULT = 15
                x = x - 1; //subtract the value of x to 1 (As per loop = 5 -> 4 -> 3) x = 3
            }

            for (int z = 1; z < 3; z = z + 1)
            {
                //start the loop by initial value of z is 1 and result is 0.
                //keep looking as long as z less than 3
                //after each loop, the value of z will increment up to 3 and will be assigned to result.

                result = result + z; //result value after each loop -> 1 -> 3
            }
            //The next statement will update a TextBlock with text that says....
 
            //myLabel.Text = "The result is " + result;
            Console.WriteLine("The result is " + result);

        }
    }
}
