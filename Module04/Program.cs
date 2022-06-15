
using Module04.FunctionOverloading;
using Module04.OperatorOverloading;
using Module04.PartialClass;
using Module04.DynamicPolymorphism;

namespace Module04
{
    public class Program
    {
        private static void Main()
        {
            //    InheritanceSampleCode obj = new InheritanceSampleCode();
            //    obj.InheritanceDemo();

            //CalcOperator obj = new CalcOperator();
            //obj.Calculate(1.50, 2.67);

            //var obj = new FunctionOverloadingDemo();
            //obj.Add("Gen", "Joy", 9);
            //obj.Add(4,9);
            //obj.Add(8,10.50);
            //obj.Add(10.53, 76.89);

            //var x = new ObjectOrientedProgramming();
            //x.OperatorOverloading();

            var x = new DynamicPolymorphismSample();
            x.DisplayAnimalInfo();
        }
    }
}