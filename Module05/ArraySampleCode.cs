using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05
{
    internal partial class ArraySampleCode
    {
        public void AverageDiff()
        {
            int total = 0;
            double avg;
            double distance;
            string inValue;
            int[] score = new int[10]; //0-9 index

            // Values are entered
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("Enter Score{0}: ", i + 1);
                inValue = Console.ReadLine();
                score[i] = Convert.ToInt32(inValue);
            }

            // Values are summed
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            avg = total / score.Length;

            Console.WriteLine();
            Console.WriteLine("Average: {0}",
                avg);

            // Output produced containing array
            // element and how far the value is
            // from the mean (absolute value).
            Console.WriteLine();
            Console.WriteLine("Score\tDist. from Avg.");
            for (int i = 0; i < score.Length; i++)
            {
                distance = Math.Abs((avg - score[i]));
                Console.WriteLine("{0}\t\t{1}",
                    score[i], distance);
            }
        }
    }
}
