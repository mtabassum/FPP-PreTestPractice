using System;

namespace Centered15
{
    class Program
    {
		public static void main(String[] args)
        {
            int result = isCentered15(new int[] { 3, 2, 10, 4, 1, 6, 9 });
            Console.WriteLine(result);
            result = isCentered15(new int[] { 2, 10, 4, 1, 6, 9 });
            Console.WriteLine(result);
            result = isCentered15(new int[] { 3, 2, 10, 4, 1, 6 });
            Console.WriteLine(result);
            result = isCentered15(new int[] { 1, 1, 8, 3, 1, 1 });
            Console.WriteLine(result);
            result = isCentered15(new int[] { 9, 15, 6 });
            Console.WriteLine(result);
            result = isCentered15(new int[] { 1, 1, 2, 2, 1, 1 });
            Console.WriteLine(result);
            result = isCentered15(new int[] { 1, 1, 15, -1, -1 });
            Console.WriteLine(result);
        }

        static int isCentered15(int[] a)
        {
            int isCentered15 = 0;
            int lowerIndex = 0;
            int upperIndex = 0;
            int sum = 0;
            if (a.Length % 2 == 0)
            {
                lowerIndex = (a.Length / 2) - 1;
                upperIndex = a.Length / 2;
            }
            else
            {
                lowerIndex = (a.Length - 1) / 2;
                upperIndex = lowerIndex;
            }
            while (lowerIndex >= 0 && upperIndex < a.Length)
            {
                sum = 0;
                for (int index = lowerIndex; index <= upperIndex; index++)
                {
                    sum += a[index];
                }
                if (sum == 15)
                {
                    isCentered15 = 1;
                    break;
                }
                lowerIndex--;
                upperIndex++;
            }
            return isCentered15;
        }
	}
}
