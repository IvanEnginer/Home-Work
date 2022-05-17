using System;

namespace work_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int sizeArray = 30;
            int number;
            int maximumRandomNumber = 100;

            int[] arrayNumber = new int[sizeArray];

            for(int i = 0; i < sizeArray; i++)
            {
                number = random.Next(0, maximumRandomNumber);
                arrayNumber[i] = number;
            }

            for(int i = 0; i < sizeArray; i++)
            {
                Console.Write(arrayNumber[i] + " ");
            }

            Console.WriteLine("");

            if(arrayNumber[0] > arrayNumber[1])
            {
                Console.WriteLine("Первый локальный максимум " + arrayNumber[0]);
            }

            if (arrayNumber[arrayNumber.Length - 1] > arrayNumber[arrayNumber.Length - 2])
            {
                Console.WriteLine("Последний локальный максимум " + arrayNumber[arrayNumber.Length - 1]);
            }

            Console.WriteLine("Локальные максимумы");

            for (int i = 1; i < sizeArray - 1; ++i)
            {
                if (arrayNumber[i - 1] < arrayNumber[i] && arrayNumber[i + 1] < arrayNumber[i])
                {
                    Console.Write(" " + arrayNumber[i]);
                }
            }
        }
    }
}
