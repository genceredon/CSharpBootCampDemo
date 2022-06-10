using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.DynamicPolymorphism
{
    //base class
    class Animal
    {
        //method DispInfo()
        public virtual void DispInfo()
        {
            Console.WriteLine("Inside Base class Animal");
        }

    }
}
