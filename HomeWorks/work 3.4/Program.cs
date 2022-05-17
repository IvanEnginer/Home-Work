using System;

namespace work_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = 0;
            int[] arrayNumbers = new int[lengthArray];
            int[] arrayCopyNumbers = new int[lengthArray];
            int arraySum = 0;

            int number;
            int stepArrayAdd = 1;

            bool enableTheCounter = true;

            string messageUser;

            while (enableTheCounter)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                messageUser = Console.ReadLine();

                if (messageUser != "sum" && messageUser != "exit")
                {
                    number = Convert.ToInt32(messageUser);
                    lengthArray += stepArrayAdd;
                    arrayNumbers = new int[lengthArray];

                    for (int i = 0; i < arrayCopyNumbers.Length; i++)
                    {
                        arrayNumbers[i] = arrayCopyNumbers[i];
                    }

                    arrayNumbers[lengthArray - stepArrayAdd] = number;
                    arrayCopyNumbers = new int[lengthArray];

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        arrayCopyNumbers[i] = arrayNumbers[i];
                    }

                    arrayCopyNumbers[lengthArray - stepArrayAdd] = number;
                }

                else if (messageUser == "sum")
                {
                    for (int i = 0; i < arrayNumbers.Length; i++)
                    arraySum += arrayNumbers[i];

                    Console.WriteLine("Сумма массива: " + arraySum);
                    arraySum = 0;
                }

                else if (messageUser == "exit")
                {
                    enableTheCounter = false;
                }
            }
        }
    }
}
