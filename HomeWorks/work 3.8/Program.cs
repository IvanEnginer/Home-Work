using System;

namespace work_3._8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayForShift = new int[] { 1, 2, 3, 4 };

            for (int i = 0; i < arrayForShift.Length; ++i)
                Console.Write("\t" + arrayForShift[i]);

            Console.WriteLine();

            int shift = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < shift; i++)
            {

                for(int j = 0; j < arrayForShift.Length - 1; j++)
                {
                    int swap = arrayForShift[j + 1];
                    arrayForShift[j + 1] = arrayForShift[j];
                    arrayForShift[j] = swap;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arrayForShift.Length; ++i)
                Console.Write("\t" + arrayForShift[i]);

        }
    }
}
