using System;

namespace work_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray;
            int[] arrayNumbers;
            int[] arrayCopyNumbers;

            bool enableCounter = true;

            string messageUser;

            while (enableCounter)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                messageUser = Console.ReadLine();

                if (messageUser != "sum" && messageUser != "exit")
                {
                    int number = Convert.ToInt32(messageUser);

                    arrayCopyNumbers = new int[];

                    lengthArray += 1;
                    arrayNumbers = new int[lengthArray];

                    for (int i = 0; i < arrayCopyNumbers.Length; i++)
                    {
                        arrayNumbers[i] = arrayCopyNumbers[i];
                    }

                    arrayNumbers[lengthArray - 1] = number;
                    arrayCopyNumbers = new int[lengthArray];

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        arrayCopyNumbers[i] = arrayNumbers[i];
                    }

                    arrayCopyNumbers[lengthArray - 1] = number;
                }

                else if (messageUser == "sum")
                {
                    int arraySum = 0;

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    arraySum += arrayNumbers[i];

                    Console.WriteLine("Сумма массива: " + arraySum);
                    arraySum = 0;
                }

                else if (messageUser == "exit")
                {
                    enableCounter = false;
                }
            }
        }
    }
}
