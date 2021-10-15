using System;
using System.Runtime.InteropServices;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 30;
            var result = largestPrimeFactor(n);
            Console.WriteLine("\nLargest Prime Factor:" + result);
        }

        static int largestPrimeFactor(int n)
        {
            var maxPrime = -1;

            if (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n /= 2;
                maxPrime = 2;
            }


            for (int i = 3; i < Math.Sqrt(n); i += 2 )
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i +" ");
                    maxPrime = i;
                    n /= i;
                    
                }
            }

            if (n > 2)
            {
                Console.Write(n);
                maxPrime = n;
            }

            return maxPrime;
        }
    }
}
