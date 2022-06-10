 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.DynamicPolymorphism
{
    class Cat : Animal
    {
        public override void DispInfo()
        {
            Console.WriteLine("Inside derived class Cat");
        }
    }
}
