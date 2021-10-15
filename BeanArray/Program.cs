using System;

namespace BeanArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(isBean(new int[] { 2, 10, 9,3 }));
       
           Console.WriteLine(isBean(new int[] {2,2,3,3,3 }));
       
           Console.WriteLine(isBean(new int[] { 1,1,1,2,1,1 }));
            Console.WriteLine(isBean(new int[] { 0, -1, 1 }));
            Console.WriteLine(isBean(new int[] {3,4,5,7 }));
            Console.WriteLine("\n");


            Console.WriteLine(isBean1(new int[] { 1, 2, 3, 9, 6, 13 }));
            Console.WriteLine(isBean1(new int[] { 3, 4, 6, 7, 13, 15 }));
            Console.WriteLine(isBean1(new int[] { 1, 2, 3, 4, 10, 11, 12 }));
            Console.WriteLine(isBean1(new int[] { 3, 6, 9, 5, 7, 13, 6, 17 }));
            Console.WriteLine(isBean1(new int[] { 9, 6, 18 }));
            Console.WriteLine(isBean1(new int[] { 4, 7, 16 }));
        }


        static int isBean(int[] a)
        {
            for(var i = 0; i < a.Length; i++)
            {
                var niceFlag = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if(i != j)
                    {
                        if (a[j] == a[i] - 1 || a[j] == a[i] + 1)
                        {
                            niceFlag = true;
                            break;
                        }
                    }
                }
                if (!niceFlag)
                    return 0;
            }
   
            return 1;
        }

        static int isBean1(int[] a)
        {
            var flag9 = false; var flag13 = false; var flag7 = false; var flag16 = false;

            foreach (int anA in a)
            {
                if (anA == 9)
                    flag9 = true;
                else if (anA == 13)
                    flag13 = true;
                else if (anA == 7)
                    flag7 = true;
                else if (anA == 16)
                    flag16 = true;
            }

            if (flag9 && flag13 || flag7 && !flag16 || !flag9 && !flag7)
            {
                return 1;
            }

            return 0;
        }



    }
}
