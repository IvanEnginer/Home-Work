using System;

namespace For_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthApdateArray = 0;
            int[] arrayNumbers = new int[0];
            int[] arrayCopyNumbers = new int[0];

            bool enableIsCount = true;

            while (enableIsCount)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                string messageUser = Console.ReadLine();

                if (messageUser != "sum" && messageUser != "exit")
                {
                    int number = Convert.ToInt32(messageUser);
                    lengthApdateArray += 1;
                    arrayNumbers = new int[lengthApdateArray];

                    for (int i = 0; i < arrayCopyNumbers.Length; i++)
                        arrayNumbers[i] = arrayCopyNumbers[i];

                    arrayNumbers[arrayNumbers.Length - 1] = number;
                    arrayCopyNumbers = new int[arrayNumbers.Length];

                    for (int i = 0; i < arrayNumbers.Length; i++)
                        arrayCopyNumbers[i] = arrayNumbers[i];

                    arrayCopyNumbers[arrayNumbers.Length - 1] = number;
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
                    enableIsCount = false;
                }
            }
        }
    }
}
