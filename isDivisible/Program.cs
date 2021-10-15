using System;

namespace isDivisible
{
    class Program
    {
		public static void main(String[] args)
        {
            int result = isDivisible(new int[] { 3, 3, 6, 36 }, 3);
            Console.WriteLine(result);
            result = isDivisible(new int[] { 4 }, 2);
            Console.WriteLine(result);
            result = isDivisible(new int[] { 3, 4, 3, 6, 36 }, 3);
            Console.WriteLine(result);
            result = isDivisible(new int[] { 6, 12, 24, 36 }, 12);
            Console.WriteLine(result);
            result = isDivisible(new int[] { }, 3);
            Console.WriteLine(result);
        }

        static int isDivisible(int[] a, int divisor)
        {
            int isDivisible = 1;
            for (int index = 0; index < a.Length; index++)
            {
                if (a[index] % divisor != 0)
                {
                    isDivisible = 0;
                    break;
                }
            }
            return isDivisible;
        }
	}
}
