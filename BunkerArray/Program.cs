using System;
using System.ComponentModel.Design;

namespace BunkerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isBunker(new int[] { 7, 6, 10, 1 }));
            //Console.WriteLine(isBunker(new int[] { 7, 6, 10 }));
            Console.WriteLine(isBunker(new int[] { 6, 10, 1 }));
            Console.WriteLine(isBunker(new int[] { 3, 7, 1, 8, 1 }));
        }

        static int isBunker(int[] a)
        {
            var isPrimeFlag = false;
            var oneFlag = false;

            foreach (var item in a)
            {
                if (item == 1)
                    oneFlag = true;
                if (isPrime(item) == 1)
                    isPrimeFlag = true;
            }

            if (oneFlag && isPrimeFlag)
            {
                return 1;
            }
            return 0;
        }

        static int isPrime(int n)
        {

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return 0;
            }

            if (n == 1)
                return 0;

            return  1;
        }
    }
}
