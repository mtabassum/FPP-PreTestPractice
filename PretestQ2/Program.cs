using System;

namespace PretestQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = isNice(new int[] { 13, 6, 3, 2 });
            Console.WriteLine(result);
            result = isNice(new int[] { 11, 5, 3, 2 });
            Console.WriteLine(result);
        }


        static int isNice(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                var tempSum = 0;
                for (int j = i + 1; j < a.Length; j++)
                {
                    tempSum += a[j]; 
                }
                if (a[i] <= tempSum)
                    return 0;
            }
            return 1;

        }
    }
}
