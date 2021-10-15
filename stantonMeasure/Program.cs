using System;

namespace stantonMeasure
{
    class Program
    {
		public static void main(String[] args)
        {
            int result = stantonMeasure(new int[] { 1 });
            Console.WriteLine(result);
            result = stantonMeasure(new int[] { 0 });
            Console.WriteLine(result);
            result = stantonMeasure(new int[] { 3, 1, 1, 4 });
            Console.WriteLine(result);
            result = stantonMeasure(new int[] { 1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4 });
            Console.WriteLine(result);
            result = stantonMeasure(new int[] { });
            Console.WriteLine(result);
        }

        static int stantonMeasure(int[] a)
        {
            int stantonMeasure = 0;
            int occurrencesOfOne = 0;
            for (int index = 0; index < a.Length; index++)
            {
                if (a[index] == 1)
                {
                    occurrencesOfOne++;
                }
            }
            for (int index = 0; index < a.Length; index++)
            {
                if (a[index] == occurrencesOfOne)
                {
                    stantonMeasure++;
                }
            }
            return stantonMeasure;
        }
	}
}
