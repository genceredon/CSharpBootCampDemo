namespace Module02
{
    internal class Output
    {
        internal static void Text()
        {
            string result = "";
            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                if (x == 2)
                {
                    result = result + "b c";
                }

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }

                if (x > 0)
                {
                    x = x - 1;
                    result = result + "-";
                }

            }
            Console.WriteLine(result);

        }

    }
}





