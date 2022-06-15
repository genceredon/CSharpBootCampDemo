using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.DynamicPolymorphism
{
    internal class DynamicPolymorphismSample
    {
        public void DisplayAnimalInfo()
        {
            Animal obj1 = new Dog();
            Animal obj2 = new Cat();
            Dog obj3 = new Dog();
            obj1.DispInfo();
            obj2.DispInfo();
            obj3.DispInfo();

            Console.WriteLine();
            Console.WriteLine("\n=====================================");
            Console.WriteLine("End of program...");
            Console.ReadKey();
        }

        public void DisplayBaseClassInfo()
        {
            Base objBase;
            objBase = new Base();
            objBase.Show();//    Output ----> Show From Base Class.
            objBase.Show1();


            objBase = new Derived();
            objBase.Show(); //Output--> Show From Derived Class.
            objBase.Show1();
            Console.WriteLine();
            Console.WriteLine("\n=====================================");
            Console.WriteLine("End of program...");
            Console.ReadKey();
        }

    }

    public class Base
    {
        public virtual void Show()
        {
            Console.WriteLine("Show From Base Class.");
        }

        public void Show1()
        {
            Console.WriteLine("Hello");

        }
    }
    public class Derived : Base
    {
        public override void Show()
        {
            Console.WriteLine("Show From Derived Class.");
        }
    }
}
