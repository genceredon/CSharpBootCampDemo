namespace Module03.ParameterType
{
    public class ParameterTypeSampleCode
    {
        public int ValueParameterType(int value)
        {
            Console.WriteLine("Inside ValueParameterType()");
            value = 111;

            Console.WriteLine($"value:{value}");
            return value;
        }

        public int RefParameterType(ref int value)
        {
            Console.WriteLine("Inside RefParameterType()");
            value = 111;

            Console.WriteLine($"value:{value}");
            return value;
        }

        public int OutParameterType(out int value)
        {
            Console.WriteLine("Inside OutParameterType()");
            value = 345;

            Console.WriteLine($"value:{value}");
            return value;
        }
    }
}