using System;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int startRandomBorder = 1;
            int endRandomBorder = 100;
            int Number = random.Next(startRandomBorder, endRandomBorder);
            int fundation = 2;
            int result = fundation;
            int degree = 1;

            while(result <= Number)
            {
                result += result;
                degree++;
            }

            Console.WriteLine($"result  {result} \n" +
                $"degree {degree}");
        }
    }
}
