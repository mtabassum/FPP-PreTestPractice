using System;

namespace NextPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = isPerfectSquare(6);
            Console.WriteLine(result);
            result = isPerfectSquare(36);
            Console.WriteLine(result);
            result = isPerfectSquare(0);
            Console.WriteLine(result);
            result = isPerfectSquare(-5);
            Console.WriteLine(result);
        }

        static int isPerfectSquare(int n)
        {
            var isPerfectSquare = 0;
            if (n >= 0)
            {
                var sqrtResult = Math.Sqrt(n);
                var baseNumber = (int)sqrtResult;
                var nextNumber = baseNumber + 1;
                isPerfectSquare = (int)Math.Pow(nextNumber, 2);
            }
            return isPerfectSquare;
        }
    }
}
