using System;

namespace work_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                {1, 2, 3 },
                {4, 5, 7 } };

            int summ = 0;
            int composition = 1;

            int rows = array.GetUpperBound(0) + 1;

            for (int i = 0; i < rows; i++)
            {
                composition *= array[i, 0];
            }
             
            Console.WriteLine("composition " + composition);

            for (int i = 0; i < array.GetLength(1); i++)
            {
                summ += array[1, i];
            }

            Console.WriteLine("summ " + summ);

        }
    }
}
