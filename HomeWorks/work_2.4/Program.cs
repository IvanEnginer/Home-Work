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
            int multipleNumer1 = 3;
            int multipleNumer2 = 5;

            for(int i = 0; i <= number; i++)
            {
                if (Convert.ToBoolean(i % multipleNumer1) == false || Convert.ToBoolean(i % multipleNumer2) == false)
                    summ += i;
            }

            Console.WriteLine("number : " + number + ", total summ : " + summ);

        }
    }
}
