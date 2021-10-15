using System;

namespace nUpCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = nUpCount(new int[] { 2, 3, 1, -6, 8, -3, -1, 2 }, 5);
            Console.WriteLine(result);
            result = nUpCount(new int[] { 6, 3, 1 }, 6);
            Console.WriteLine(result);
            result = nUpCount(new int[] { 1, 2, -1, 5, 3, 2, -3 }, 20);
            Console.WriteLine(result);
        }


        static int nUpCount(int[] a, int n)
        {
            var nUpCount = 0;
            var partialSum = 0;
            var previousPartialSum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                previousPartialSum = partialSum;
                partialSum += a[i];

                if (previousPartialSum <= n && partialSum > n)
                    nUpCount++;
            }
            return nUpCount;
        }
    }
}
