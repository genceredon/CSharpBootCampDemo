using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1_AngielynRivera
{
    public class PartThree
    {
        public static void PartThreeSW()
        {
            string result = "";
            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                if (x == 2)
                {
                    result = result + "b c";                
                }

                x = x - 1;
                result = result + "-";

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }   
            }

            Console.WriteLine(result);
        }
    }
}
