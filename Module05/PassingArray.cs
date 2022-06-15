namespace Module05
{
    internal partial class ArraySampleCode
    {
        public void PassingArray()
        {
            int[] temperature = new int[5];
            int[] t = new int[5];
            InputValues(temperature);

            //Array t will reference the same array as the temperature array
            t = temperature;
            t[1] = 44;
            Console.WriteLine(temperature[1]);
        }

        private static void InputValues(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("Enter Temperature {0}: ", i + 1);
                string? inValue = Console.ReadLine();
                temp[i] = int.Parse(inValue);
            }
        }
    }
}