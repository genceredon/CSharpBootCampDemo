using Module03.CarpetCalculatorApp;
using Module03.Model;
using Module03.Modifiers;
using Module03.ParameterType;

namespace Module03
{
    public class Program
    {
        private static void Main()
        {
            //var x = new CarpetCalculatorAppDemo();

            //x.Calculate();

            //Instantiate obj for AccessorSampleCode class
            //AccessorSampleCode obj = new AccessorSampleCode();
            //obj.DisplayOutput();

            //var obj2 = new AccessorSampleCode();
            //obj2.DisplayOutput();
            //Employee employee = new Employee("Joy", "Gal", "26");
            //employee.SetEmployeeInfo();

            //Parameter Type Sample 

            int testValue = 1;
            ParameterTypeSampleCode obj = new ParameterTypeSampleCode();
            Console.WriteLine($"Before ValueParameterType call:{testValue}");
            obj.ValueParameterType(testValue);
            Console.WriteLine($"After ValueParameterType call:{testValue}");
            
            Console.WriteLine("================================================");
            
            Console.WriteLine($"\nBefore RefParameterType call:{testValue}");
            obj.RefParameterType(ref testValue);
            Console.WriteLine($"After RefParameterType call:{testValue}");

            Console.WriteLine("================================================");
                        
            Console.WriteLine($"\nBefore OutParameterType call");
            obj.OutParameterType(out int value) ;
            Console.WriteLine($"After OutParameterType call:{value}");
        }
    }
}