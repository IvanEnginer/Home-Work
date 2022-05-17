using System;

namespace work_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number;
            int maximumRandomNumber = 10;
            int colums = 10;
            int row = 10;
            int maximum = 0;
            

            int[,] arrayNumber = new int[colums, row];


            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    number = random.Next(0, maximumRandomNumber);
                    arrayNumber[i, j] = number;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(arrayNumber[i, j] + " ");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (arrayNumber[i, j] > maximum)
                        maximum = arrayNumber[i, j];
                }
            }

            Console.WriteLine("maximum = " + maximum);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (arrayNumber[i, j] == maximum)
                        arrayNumber[i, j] = 0;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(arrayNumber[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
