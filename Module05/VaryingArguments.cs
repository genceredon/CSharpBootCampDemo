namespace Module05
{
    internal partial class ArraySampleCode
    {
        public void VaryingArguments()
        {
            DisplayItems(1, 2, 3, 5);

            int[] anArray = new int[5] { 100, 200, 300, 400, 500 };

            DisplayItems(anArray);
            DisplayItems(1500, anArray[1] * anArray[2]);
        }

        private static void DisplayItems(params int[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.Write(item[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}