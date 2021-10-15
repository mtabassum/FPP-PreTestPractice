using System;

namespace findPorcupineNumber
{
    class Program
    {
		public static void main(String[] args)
        {
            var result = findPorcupineNumber(0);
            Console.WriteLine(result);
            result = findPorcupineNumber(138);
            Console.WriteLine(result);
            result = findPorcupineNumber(139);
            Console.WriteLine(result);
        }

        static int findPorcupineNumber(int n)
        {
            var porcupineNumber = 0;
            var maxValue = Int32.MaxValue;
            var isPorcupineNumber = false;
            n++;
            while (n <= maxValue)
            {
                if (isPorcupineNumber)
                {
                    if (isPrime(n) == 1)
                    {
                        if (n % 10 == 9)
                        {
                            break;
                        }
                        else
                        {
                            isPorcupineNumber = false;
                        }
                    }
                }
                else
                {
                    if (isPrime(n) == 1)
                    {
                        if (n % 10 == 9)
                        {
                            isPorcupineNumber = true;
                            porcupineNumber = n;
                        }
                    }
                }
                n++;
            }
            return porcupineNumber;
        }

        static int isPrime(int number)
        {
            var isPrime = 0;
            if (number > 1)
            {
                isPrime = 1;
                for (int divider = 2; 2 * divider <= number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }
            }
            return isPrime;
        }
	}
}
