using System;
using System.Collections.Generic;

namespace work_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            bool enableCounter = true;

            while (enableCounter)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                string messageUser = Console.ReadLine();

                if (int.TryParse(messageUser, out int number))
                {
                    numbers.Add(number);
                }
                else if(messageUser == "sum")
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                        sum += numbers[i];

                    Console.WriteLine("Sum = " + sum);
                }
                else if(messageUser == "exit")
                {
                    enableCounter = false;
                }
            }
        }
    }
}
