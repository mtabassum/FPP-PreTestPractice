using System;

namespace zeroPlentiful
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = isZeroPlentiful(new int[] { 0, 0, 0, 0, 0});
            Console.WriteLine(result);
            result = isZeroPlentiful(new int[] { 1,2,0,0,0,0,2,-18,0,0,0,0,0,12});
            Console.WriteLine(result);
            result = isZeroPlentiful(new int[] { 0, 0, 0, 0, 0, 1, 0,0,0,0,8, 0, 0, 0, 0, 0,0 });
            Console.WriteLine(result);
            result = isZeroPlentiful(new int[] { 1,2,3,4});
            Console.WriteLine(result);
            result = isZeroPlentiful(new int[] {1,0,0,0,2,0,0,0,0 });
            Console.WriteLine(result);
            result = isZeroPlentiful(new int[] { 0 });
            Console.WriteLine(result);
            result = isZeroPlentiful(new int[] { });
            Console.WriteLine(result);
        }


        static int isZeroPlentiful(int[] a)
        {
            int count = 0;

            for (int i = 0; i < a.Length - 1;)
            {
                if (a[i] == 0 && i + 3 <= a.Length)
                {
                    int j = i;
                    int zeroCount = 0;

                    while (j < a.Length && a[j] == 0)
                    {
                        zeroCount++;
                        j++;
                    }

                    if (zeroCount < 4)
                    {
                        return 0;
                    }
                    else
                    {
                        count++;
                    }

                    i = j;
                }
                else 
                    i++;
            }

            return count;
        }
    }
}

