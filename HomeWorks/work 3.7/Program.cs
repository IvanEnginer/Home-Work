using System;

namespace work_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string streingForSplit = "You win some. You lose some.";

            string[] arrayWords = streingForSplit.Split(' ');

            int position = 0;

            foreach (var Substring in arrayWords)
            {
                Console.WriteLine($"Подстрока {position} : {Substring}");
                position++;
            }
        }
    }
}
