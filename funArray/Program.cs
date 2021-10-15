using System;

namespace funArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = isFun(new int[] { 4, 5, 13, 15, 3 });
            Console.WriteLine(result);
            result = isFun(new int[] { 5, 13, 0, 5, 13, 3, 4, 6 });
            Console.WriteLine(result);
            result = isFun(new int[] { 3, 2, 3, 1, 13 });
            Console.WriteLine(result);
            result = isFun(new int[] { 1, 2, 4, 6 });
            Console.WriteLine(result);

            result = isFun(new int[] { 5, 3, 1 });
            Console.WriteLine(result);
            result = isFun(new int[] { 5, 13, 4, 5, 6 });
            Console.WriteLine(result);
            result = isFun(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result);
        }

        static int isFun(int[] a)
        {
            var len = a.Length;
            for (var i = 0; i < len; i++)
            {
                if (a[i] == 5 && ((i + 1 == len) || a[i + 1] != 13))
                    //      if (a[i] == 5 && (a[i+1] == len || a[i + 1] != 13))
                    return 0;
            }
            return 1;
        }
    }
}
