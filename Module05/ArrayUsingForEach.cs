using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05
{
    internal partial class ArraySampleCode
    {
        public void UsingForEach()
        {
            string[] color = { "red", "green", "blue" };
            foreach (string val in color)
            {
                Console.WriteLine(val);
            }

        }
    }
}
