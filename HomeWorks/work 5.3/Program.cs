using System;
using System.Collections.Generic;

namespace work_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            bool continueCounting = true;

            int sum = 0;

            while (continueCounting)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                string messageUser = Console.ReadLine();

                if (int.TryParse(messageUser, out int number))
                {
                    numbers.Add(number);
                }

                if(messageUser == "sum")
                {
                    for (int i = 0; i < numbers.Count; i++)
                        sum += numbers[i];

                    Console.WriteLine("Sum = " + sum);
                }
                
                if(messageUser == "exit")
                {
                    continueCounting = false;
                }
            }
        }
    }
}
