using System;

namespace isInertial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int isInertial(int[] a)
        {
            int isInertial = 0;
            bool containsOddValue = false;
            int maxValue = Int32.MinValue ;
            int[] oddValues = new int[a.Length];
            int[] evenValues = new int[a.Length];
            int oddValuesIndex = 0;
            int evenValuesIndex = 0;
            for (int index = 0; index < a.Length; index++)
            {
                if ((a[index] % 2) != 0)
                {
                    containsOddValue = true;
                    oddValues[oddValuesIndex] = a[index];
                    oddValuesIndex++;
                }
                else
                {
                    evenValues[evenValuesIndex] = a[index];
                    evenValuesIndex++;
                }
                if (a[index] > maxValue)
                {
                    maxValue = a[index];
                }
            }
            if (containsOddValue)
            {
                if (maxValue % 2 == 0)
                {
                    for (int oddIndex = 0; oddIndex < oddValuesIndex; oddIndex++)
                    {
                        for (int evenIndex = 0; evenIndex < evenValuesIndex; evenIndex++)
                        {
                            if (evenValues[evenIndex] != maxValue)
                            {
                                if (oddValues[oddIndex] > evenValues[evenIndex])
                                {
                                    isInertial = 1;
                                }
                                else
                                {
                                    isInertial = 0;
                                    break;
                                }
                            }
                            else
                            {
                                isInertial = 1;
                            }
                        }
                        if (isInertial == 0)
                        {
                            break;
                        }
                    }
                }
            }
            return isInertial;
        }
	}
}
