using System;

namespace WaveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isWave(new int[] {7, 2, 9, 10, 5 }));
            Console.WriteLine(isWave(new int[] { 4, 11, 12, 1,6 }));
            Console.WriteLine(isWave(new int[] { 1, 0, 5 }));
            Console.WriteLine(isWave(new int[] { 2 }));
            Console.WriteLine(isWave(new int[] { 2, 6, 3, 4 }));
      
        }


        static int isWave(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] % 2 == 0 && a[i+1] % 2 == 0)
                {
                    return 0;
                }
                else if (a[i] % 2 != 0 && a[i + 1] % 2 != 0)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
