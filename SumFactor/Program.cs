using System;

namespace SumFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = sumFactor(new int[] { 3, 0, 2, -5, 0 });
            Console.WriteLine(result);
            result = sumFactor(new int[] { 9, -3, -3, -1, -1 });
            Console.WriteLine(result);
            result = sumFactor(new int[] { 1 });
            Console.WriteLine(result);
            result = sumFactor(new int[] { 0, 0, 0 });
            Console.WriteLine(result);
        }

        static int sumFactor(int[] a)
        {
            int sumFactor = 0;
            int sum = 0;
            for (int index = 0; index < a.Length; index++)
            {
                sum += a[index];
            }
            for (int index = 0; index < a.Length; index++)
            {
                if (a[index] == sum)
                {
                    sumFactor++;
                }
            }
            return sumFactor;
        }
    }
}
