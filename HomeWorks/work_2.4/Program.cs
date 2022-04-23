using System;

namespace work_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(0, 101);
            int summ = 0;
            int totalsum = 0;
            int multipleNumer1 = 3;
            int multipleNumer2 = 5;

            for (int i = 0; i < number / multipleNumer1; i++)
            {
                summ += multipleNumer1;
                totalsum += summ;
            }

            int iterator = 0;

            while(iterator < number / multipleNumer2)
            {
                summ += multipleNumer2;
                totalsum += summ;
                iterator++;
            }

            Console.WriteLine("number : " + number + ", total summ : " + totalsum);
        }
    }
}
