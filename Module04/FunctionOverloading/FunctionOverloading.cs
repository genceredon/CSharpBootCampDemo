namespace Module04.FunctionOverloading
{
    public class FunctionOverloadingDemo
    {
        public void Add(string a1, string a2, int num)
        {
            Console.WriteLine("Adding Two Strings: " + a1 + a2);
        }

        public void Add(int a1, int a2)
        {
            Console.WriteLine("Adding Two Integers: {0}", a1 + a2);
        }

        public void Add(int a1, double a2)
        {
            Console.WriteLine("Adding int and double: {0}", a1 + a2);
        }

        public double Add(double x, double y)
        {
            Console.WriteLine("Adding double and double: {0}", x + y);
            return x + y;
        }
    }
}