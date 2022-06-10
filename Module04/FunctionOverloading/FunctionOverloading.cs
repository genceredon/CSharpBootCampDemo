namespace Module04.FunctionOverloading
{
    public class FunctionOverloadingDemo
    {
        public void Add(string a1, string a2)
        {
            Console.WriteLine("Adding Two Strings: " + a1 + a2);
        }

        public void Add(int a1, int a2)
        {
            Console.WriteLine("Adding Two Integers: " + a1 + a2);
        }

        public void Add(int a1, double a2)
        {
            Console.WriteLine("Adding int and double: " + a1 + a2);
        }
    }
}