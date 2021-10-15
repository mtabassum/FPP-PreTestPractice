using System;

namespace countSquarePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int countSquarePairs(int[] a)
        {
            int countSquarePairs = 0;
            for (int targetIndex = 0; targetIndex < a.Length; targetIndex++)
            {
                for (int compareIndex = 0; compareIndex < a.Length; compareIndex++)
                {
                    if (a[targetIndex] > 0 && a[compareIndex] > 0)
                    {
                        if (a[targetIndex] < a[compareIndex])
                        {
                            if (isPerfectSquare(a[targetIndex] + a[compareIndex]) == 1)
                            {
                                countSquarePairs++;
                            }
                        }
                    }
                }
            }
            return countSquarePairs;
        }

        static int isPerfectSquare(int element)
        {
            var isPerfectSquare = 0;
            if (element >= 0)
            {
                var sqrtResult = Math.Sqrt(element);
                var baseNumber = (int)sqrtResult;
                if ((sqrtResult - baseNumber) == 0)
                {
                    isPerfectSquare = 1;
                }
                else
                {
                    isPerfectSquare = 0;
                }
            }
            return isPerfectSquare;
        }
	}
}
