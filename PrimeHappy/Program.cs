using System;

namespace PrimeHappy
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = isPrimeHappy(5);
            Console.WriteLine(result);
            result = isPrimeHappy(25);
            Console.WriteLine(result);
            result = isPrimeHappy(32);
            Console.WriteLine(result);
            result = isPrimeHappy(8);
            Console.WriteLine(result);
            result = isPrimeHappy(2);
            Console.WriteLine(result);
        }


        static int isPrimeHappy(int n)
        {
            var sum = 0;
            var primeCount = 0;
            var number = 2;
            var primeFlag = false;

            while (number < n)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        primeFlag = false;
                    }
                }
                       primeFlag = true;
                        primeCount++;
                        sum += number;
                
                number++;
            }
            
            if (primeCount > 1 && sum % n == 0)
                return 1;

            else 
                return 0;
        }
    }
}
