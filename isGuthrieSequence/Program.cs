using System;

namespace isGuthrieSequence
{
    class Program
    {
		public static void main(String[] args)
        {
            int result = isGuthrieSequence(new int[] { 8, 4, 2, 1 });
            Console.WriteLine(result);
            result = isGuthrieSequence(new int[] { 8, 17, 4, 1 });
            Console.WriteLine(result);
            result = isGuthrieSequence(new int[] { 8, 4, 1 });
            Console.WriteLine(result);
            result = isGuthrieSequence(new int[] { 8, 4, 2 });
            Console.WriteLine(result);
        }

        static int isGuthrieSequence(int[] a)
        {
            int isGuthrieSequence = 0;
            int nextSequenceNumber = a[0];
            if (a[a.Length - 1] == 1)
            {
                for (int index = 0; index < a.Length; index++)
                {
                    if (nextSequenceNumber == a[index])
                    {
                        isGuthrieSequence = 1;
                        if (a[index] % 2 == 0)
                        {
                            nextSequenceNumber = a[index] / 2;
                        }
                        else
                        {
                            nextSequenceNumber = a[index] * 3 + 1;
                        }
                    }
                    else
                    {
                        isGuthrieSequence = 0;
                        break;
                    }
                }
            }
            return isGuthrieSequence;
        }
	}
}
