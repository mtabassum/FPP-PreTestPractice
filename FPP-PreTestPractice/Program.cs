using System;
using System.Buffers;

namespace FPP_PreTestPractice
{
    class Program
    {

        /*2. Write a function that takes an array of integers as an argument and returns a value based on the sums of the even and odd numbers in the array. Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers.
         The function should return X - Y.
         The signature of the function is:
           int f(int[ ] a)
         */
        //static void Main(string[] args)
        //{
        //    var  r = f(new int[] { 1});
        //    Console.WriteLine(r);
        //    r = f(new int[] { 1, 2});
        //    Console.WriteLine(r);
        //    r = f(new int[] { 1, 2 , 3});
        //    Console.WriteLine(r);
        //    r = f(new int[] {1, 2, 3, 4});
        //    Console.WriteLine(r);
        //    r = f(new int[] { 1, 1 });
        //    Console.WriteLine(r);
        //    r = f(new int[] { });
        //    Console.WriteLine(r);

        //}

        //static int f(int[] f)
        //{
        //    var oddSum = 0;
        //    var evenSum = 0;

        //    for (int i = 0; i < f.Length; i++)
        //    {
        //        if (f[i] % 2 == 0)
        //        {
        //            evenSum += f[i];
        //        }
        //        else
        //        {
        //            oddSum += f[i];
        //        }
        //    }

        //    return oddSum - evenSum;

        //}

        /* Write a function that accepts a character array, a zero-based start position and a length.It should return a character array containing containing length characters starting with the start character of the input array. The function should do error checking on the start position and the length and return null if the either value is not legal.
          The function signature is:
         char[] f(char[] a, int start, int len)
        */

        //public static void Main()
        //{
        //    var result = a3(new char[] { 'a', 'b', 'c' }, 0, 4);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 0, 3);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 0, 2);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 0, 1);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 1, 3);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 1, 2);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 1, 1);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 2, 2);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 2, 1);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 3, 1);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, 1, 0);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { }, 0, 1);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, -1, 2);
        //    Console.WriteLine(result);
        //    result = a3(new char[] { 'a', 'b', 'c' }, -1, -2);
        //    Console.WriteLine(result);
        //}

        //static char[] a3(char[] a, int start, int length)
        //{
        //    if (length < 0 || start < 0 || start + length - 1 >= a.Length)
        //    {
        //        return null;
        //    }

        //    char[] sub = new char[length];
        //    for (int i = start, j = 0; j < length; i++, j++)
        //    {
        //        sub[j] = a[i];
        //    }

        //    return sub;
        //}

        /*
         * Write a function to reverse an integer using numeric operators and without using any arrays or other data structures.
           The signature of the function is:
           int f(int n)
        if the input integer is	return
           1234	    4321
           12005	50021
           1	    1
           1000	    1
           0	    0
           -12345	-54321
         */
        //    static void Main()
        //    {
        //        var result = f(1234);
        //        Console.WriteLine(result);
        //        result = f(12005);
        //        Console.WriteLine(result);
        //        result = f(1);
        //        Console.WriteLine(result);
        //        result = f(1000);
        //        Console.WriteLine(result);
        //        result = f(0);
        //        Console.WriteLine(result);
        //        result = f(-12345);
        //        Console.WriteLine(result);
        //    }


        //    static int f(int n)
        //    {
        //        var sign = 1;
        //        if (n < 0)
        //        {
        //            sign = -1;
        //            n = -n;
        //        }

        //        if (n == 0)
        //        {
        //            return 0;
        //        }

        //        var reverse = 0;

        //        while (n != 0)
        //        {
        //       var rem = n % 10; 
        //       reverse = reverse * 10 + rem;
        //            n = n / 10;
        //        }
        //        return sign * reverse;
        //    }

        //}

        /* An array with an odd number of elements is said to be centered if all elements (except the middle one) are strictly greater
        than the value of the middle element. Note that only arrays with an odd number of elements have a middle element. 
        Write a function that accepts an integer array and returns 1 if it is a centered array, otherwise it returns 0.
             */
        //static void Main()
        //{
        //    var result = f(new int[] {1, 2, 3, 4, 5});
        //    Console.WriteLine(result);
        //    result = f(new int[] {3,2,1, 4, 5});
        //    Console.WriteLine(result);
        //    result = f(new int[] {3, 2, 1, 4, 1});
        //    Console.WriteLine(result);

        //    result = f(new int[] {1, 2, 3, 4});
        //    Console.WriteLine(result);
        //    result = f(new int[] { });
        //    Console.WriteLine(result);
        //    result = f(new int[] { 10 });
        //    Console.WriteLine(result);
        //}

        //static int f(int[] arr)
        //{
        //    if (arr == null || arr.Length % 2 == 0)
        //    {
        //        return 0;
        //    }

        //    var midIndex = arr.Length / 2;
        //    var midItem = arr[midIndex];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (i != midIndex && arr[i] <= midItem)
        //        {
        //            return 0;
        //        }
        //    }

        //    return 1;
        //}

        //static void Main()
        //{
        // f(new int[] { 1, 8, 3,2 } , new int[] {4, 2, 6, 1});

        //     f(new int[] { 1, 3, 7, 9 }, new int[] {7,1, 9, 3 });

        //    f(new int[] { 1,  2 }, new int[] { 3, 4 });


        //     f(new int[] { 1, 2 }, null);

        //     f( null, new int[] {});

        //     f(null, null);

        //} 

        //static int[] f(int[] first, int[] second)
        //{
        //    if (first == null || second == null) return null;
        //    if (first.Length == 0 || second.Length == 0) return new int[0];
        //    var min = (first.Length < second.Length) ? first.Length : second.Length;
        //    int[] a, b;

        //    if (min == first.Length)
        //     {
        //        a = first;
        //        b = second;
        //    }
        //    else
        //    {
        //        a = second;
        //        b = first;
        //    }



        //    int k = 0;
        //    int[] c = new int[min];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        for (int j = 0; j < b.Length; j++)
        //        {
        //            if (a[i] == b[j])
        //            {
        //               c[k] = a[i];
        //               k++;
        //            }

        //        }

        //    }

        //    int[] newArray = new int[k];
        //    for (int i = 0; i < newArray.Length; i++)
        //    {
        //         newArray[i] = c[i];
        //    }

        //    showMethod(newArray);

        //    return newArray;

        //}


        //static void showMethod(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        // PrimeFactor of a number

        //public static void primeFactors(int n)
        //{
        //    while (n % 2 == 0)
        //    {
        //        Console.Write(2 + " ");
        //        n /= 2;
        //    }


        //    for (int i = 3; i <= Math.Sqrt(n); i += 2)
        //    {
        //        while (n % i == 0)
        //        {
        //            Console.Write(i + " ");
        //            n /= i;
        //        }
        //    }
        //    // This condition is to handle the case when 
        //    // n is a prime number greater than 2 
        //    if (n > 2)
        //        Console.Write(n);
        //}

        //public static void Main()
        //{
        //    int n = 30;
        //    primeFactors(n);
        //}


        // C# program to find if x is a perfect square.
        //static void Main()
        //{
        //    if (isPerfectSquare(25))
        //    {
        //        Console.Write("Yes\n");
        //    }
        //    else
        //        Console.Write("No");
        //}

        //static bool isPerfectSquare(double n)
        //{
        //    if (n >= 0)
        //    {
        //        var sr = Math.Sqrt(n);
        //        return (sr * sr == n);
        //    }
        //    return false;
        //}


        //static void Main()
        //{
        //    var result = arrayHasNoZeroes(new int[] {1,2,3});
        //    Console.WriteLine(result);
        //    result = arrayHasNoZeroes(new int[] { 1, 0, 4, 0 });
        //    Console.WriteLine(result);
        //    result = arrayHasNoZeroes(new int[] {  });
        //    Console.WriteLine(result);
        //}

        //static int arrayHasNoZeroes(int[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == 0)
        //            return 0;
        //    }
        //    return 1;
        //}

        //static int isFibonacci(int n)
        //{
        //    if (n == 1) return 1;

        //    var fibonacci = 0;
        //    var fibo1 = 1; var fibo2 = 1;

        //    while(fibonacci < n)
        //    {
        //        fibonacci = fibo1 + fibo2;
        //        fibo1 = fibo2;
        //        fibo2 = fibonacci;
        //    }

        //    if (fibonacci == n)
        //        return 1;
        //    return 0;
        //}


        //static void Main()
        //{
        //    var result = isNormal(4);
        //    Console.WriteLine(result);
        //    result = isNormal(5);
        //    Console.WriteLine(result);
        //    result = isNormal(9);
        //    Console.WriteLine(result);
        //}

        //static int isNormal(int n)
        //{
        //    var s = 0;
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            s = i;
        //        }
        //        if (s % 2 != 0)
        //            return 0;
        //    }
        //    return 1;
        //}
        //    class Test : MySuperClass
        //    {
        //        static void Main(string[] args)
        //        {
        //            MySuperClass cl = new Test();
        //            Console.WriteLine(cl.GetType());
        //        }

        //        public int GetType()
        //        {
        //            return 3;
        //        }
        //    }

        //    class MySuperClass
        //    {
        //        public  int GetType()
        //        {
        //            return 2;
        //        }
        //    }
        //}

        //public class Test
        //{
        //    public static void Main(String[] args)
        //    {
        //        AnotherClass a = new AnotherClass(new Test());
        //        a.anotherMethod();
        //    }

        //    public void myMethod()
        //    {
        //        Console.WriteLine("hello");
        //    }
        //}

        //public class AnotherClass
        //{
        //    Test m;

        //    public AnotherClass(Test m)
        //    {
        //        this.m = m;
        //        anotherMethod();
        //    }

        //    public void anotherMethod()
        //    {
        //        m.myMethod();
        //    }


        public class Test
        { 
            public  Test()
            {
                TheSubclass sub = new TheSubclass();
                Console.WriteLine("The Test Class constructor");
            }

            public static void Main(String[] args)
            {
                new TheSubclass();
            }
        }

        public class TheSubclass : Test
        {
            public  TheSubclass()
        {
            Console.WriteLine("The Subclass constructor");
        }
    }



    }
}
