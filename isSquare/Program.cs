using System;

namespace isSquare
{
    class Program
    {
		public static void Main(String[] args)
        {
            int result = isSquare(4);
            Console.WriteLine(result);
            result = isSquare(25);
            Console.WriteLine(result);
            result = isSquare(-4);
            Console.WriteLine(result);
            result = isSquare(8);
            Console.WriteLine(result);
            result = isSquare(0);
            Console.WriteLine(result);
        }

        static int isSquare(int n)
        {
            int isSquare = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    isSquare = 1;
                    break;
                }
            }
            return isSquare;
        }
	}
}
