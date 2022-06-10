using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.DynamicPolymorphism
{
    //derived class
    class Dog : Animal
    {
        public override void DispInfo()
        {
            Console.WriteLine("Inside derived class Dog");
        }
    }
}
