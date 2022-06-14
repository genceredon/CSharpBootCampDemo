using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    static class Output
    {
        public static void Text()
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


                if (x == 1)
                {

                    result = result + "d";
                    x = x - 1;


                }




                if (x > 0)
                {
                    x = x - 1;
                    result = result + "-";
                }

            }
            Console.WriteLine(result);
        }



    }
}
