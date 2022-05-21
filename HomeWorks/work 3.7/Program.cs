using System;

namespace work_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForSplit = "You win some. You lose some.";

            string[] arrayWords = stringForSplit.Split(' ');

            for(int i = 0; i < arrayWords.Length; i++)
                Console.WriteLine($"Подстрока {i} : {arrayWords[i]}");
        }
    }
}
