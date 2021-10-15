using System;

namespace BalancedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBalanced(new int[] { 2, 3, 6, 7 }));
            Console.WriteLine(isBalanced(new int[] { 6, 7, 2, 3, 12 }));
            Console.WriteLine(isBalanced(new int[] { 7, 15, 2, 3 }));
            Console.WriteLine(isBalanced(new int[] { 16, 6, 2, 3 }));
        }

        static int isBalanced(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if ((i % 2 == 0 && a[i] % 2 != 0) && (i % 2 != 0 && a[i] % 2 == 0))
                    return 0;
            }
            return 1;
        }
    }
}
