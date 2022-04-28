using System;

namespace work_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int starBorder = 0;
            int endBorder = 101;

            int number = random.Next(starBorder, endBorder);
            int summ = 0;
            int multipleNumer1 = 3;
            int multipleNumer2 = 5;

            for(int i = 0; i <= number; i++)
            {
                if(i % multipleNumer1 == 0 || i % multipleNumer2 == 0) 
                    summ += i;
            }

            Console.WriteLine("number : " + number + ", total summ : " + summ);

        }
    }
}
