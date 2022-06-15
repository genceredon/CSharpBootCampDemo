using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.OperatorOverloading
{
    public class ObjectOrientedProgramming
    {
        public void OperatorOverloading()
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setWidth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setWidth(13.0);
            Box2.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows using the operator overloading function:
            Box3 = Box1 + Box2; // This can actually be visialized as:
                                //Box3 = Box.+ (Box1, Box2);

            bool isItEqual = Box1 == Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

            Console.WriteLine();
            Console.WriteLine("\n=====================================");
            Console.WriteLine("End of program...");
            Console.ReadKey();
        }
    }
}
    
