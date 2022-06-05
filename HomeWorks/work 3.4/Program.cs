using System;

namespace work_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int [0];
            bool enableCounter = true;
            string messageUser;

            while(enableCounter)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                messageUser = Console.ReadLine();

                if (messageUser != "sum" && messageUser != "exit")
                {
                    int[] tempArray = new int[arrayNumbers.Length + 1];

                    for (int i = 0; i < arrayNumbers.Length; i++)
                        tempArray[i] = arrayNumbers[i];

                    tempArray[tempArray.Length - 1] = Convert.ToInt32(messageUser);
                    arrayNumbers = tempArray;    
                } else if(messageUser == "sum")
                {
                    int sum = 0;

                    for (int i = 0; i < arrayNumbers.Length; i++)
                        sum += arrayNumbers[i];

                    Console.WriteLine("Sum = " + sum);
                } else if(messageUser == "exit")
                {
                    enableCounter = false;
                }              
            }
        }
    }
}
