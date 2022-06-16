namespace Module05
{
    internal partial class ArraySampleCode
    {
        public const string CAPTION = "System.Array Methods Illustrated";

        public void StaticMethods()
        {
            double[] waterDepth = {45, 19, 2, 16.8,
                                        190, 0.8, 510, 6, 18 };
            double[] w = new Double[20];

            DisplayOutput(waterDepth, "waterDepth Array\n\n");

            // Copies values from waterDepth to w
            Array.Copy(waterDepth, 2, w, 1, 7);

            //Sorts Array w in ascending order
            Array.Sort(w);
            DisplayOutput(w, "Array w Sorted\n\n");

            // Reverses the elements in Array w
            Array.Reverse(w);
            DisplayOutput(w, "Array w Reversed\n\n");
        }

        // Displays an array in a MessageBox 
        private void DisplayOutput(double[] anArray,
                                   string msg)
        {
            foreach (double wVal in anArray)
            {
                if (wVal > 0)
                    msg += wVal
                    + "\n";
            }
               
            Console.Title = CAPTION;
            Console.WriteLine(msg);
            
        }
    }
}