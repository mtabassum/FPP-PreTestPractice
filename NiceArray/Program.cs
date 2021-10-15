using System;

namespace NiceArray
{
    class Program
    {

        //A nice array is one in which all elements are less than or, equal to the
        //    sum of the other elements in the array.
        //    For example, { 12,2,10} is a nice array because
        //12 <= 2+10, 2 <= 12+10 & 10 <= 12+2;
        //but { 5,1,2} is not a nice array because 5 > 1+2;
        //Write a function name isNice that returns 1 if its array argument is a Nice Array, Otherwise 0.

        static void Main(string[] args)
        {

           var result = isNice(new int[] { 12, 2, 10 });
           Console.WriteLine(result);
           result =    isNice(new int[] { 5,1,2}); 
           Console.WriteLine(result);
        }
        static int isNice(int[] a)
        {
            var tempSum = 0;
            for (var i = 0; i < a.Length ; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i != j)
                    {
                        tempSum += a[j];
                    }
                }
                if (a[i] > tempSum)
                {
                    return 0;
                }
            }
            
            return 1;
        }
    }
}
