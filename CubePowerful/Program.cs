using System;

namespace CubePowerful
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = isCubePowerful(153);
            Console.WriteLine(result); 
            result = isCubePowerful(370);
            Console.WriteLine(result);
            result = isCubePowerful(87);
            Console.WriteLine(result);
            result = isCubePowerful(0);
            Console.WriteLine(result);
            result = isCubePowerful(-81);
            Console.WriteLine(result);
        }

        static int isCubePowerful(int m)
        {
            var n = m;
            if (n <= 0)
                return 0;

            var sum = 0;

            while(n != 0)
            {
                var rem = n % 10;
                n /= 10;
                var cR =(int) Math.Pow(rem, 3);
                sum += cR;
            }

            if (sum == m)
                return 1;

            return 0;
        }
    }
}
