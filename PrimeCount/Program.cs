using System;

namespace PrimeCount
{
    class Program
    {
        static void Main(string[] args)
        {
			int result = primeCount(10, 30);
            Console.WriteLine(result);
            result = primeCount(11, 29);
            Console.WriteLine(result);
            result = primeCount(20, 22);
            Console.WriteLine(result);
            result = primeCount(1, 1);
            Console.WriteLine(result);
            result = primeCount(5, 5);
            Console.WriteLine(result);
            result = primeCount(6, 2);
            Console.WriteLine(result);
            result = primeCount(-10, 6);
            Console.WriteLine(result);
		}

        static int primeCount(int start, int end)
        {
            var primeCount = 0;
            for (int number = start; number <= end; number++)
            {
                if (number > 1)
                {
                    var isPrime = true;
                    for (int divider = 2; divider * 2 <= number; divider++)
                    {
                        if (number % divider == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeCount++;
                    }
                }
            }
            return primeCount;
        }
    }
}
