using System;

namespace work_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //С помощью Random получить число number, которое не больше 100.
            //Найти сумму всех положительных чисел меньше number(включая число), 
            //которые кратные 3 или 5. (К примеру, это числа 3, 5, 6, 9, 10, 12, 15 и т.д.)

            Random random = new Random();

            int number = random.Next(0, 101);
            int summ = 0;
            int totalsum = 0;
            int multipleNumer1 = 3;
            int multipleNumer2 = 5;

            int totalIterator;
            totalIterator = number / multipleNumer1 + number / multipleNumer2;

            //           if(number % multipleNumer1 + number % multipleNumer2 == 0)

            // if (number % multipleNumer1 == 0 ? number % multipleNumer2 == 0)



            Console.WriteLine(totalIterator);

            for(int i = 0; i <= number; i++)
            {
                if (i % multipleNumer1 == 0)
                {
                    summ += multipleNumer1;
                }

                else if (i % multipleNumer2 == 0)
                    summ += multipleNumer2;
            }

            Console.WriteLine("number : " + number + ", total summ : " + summ);

            //             string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

            //for (int i = 0; i < totalIterator; i++)
            //{ 

            //}

            //Random random = new Random();

            //int number = random.Next(0, 101);
            //int summ = 0;
            //int totalsum = 0;
            //int multipleNumer1 = 3;
            //int multipleNumer2 = 5;

            for (int i = 0; i < number / multipleNumer1; i++)
            {
                summ += multipleNumer1;
                totalsum += summ;
            }

            int iterator = 0;

            while (iterator < number / multipleNumer2)
            {
                summ += multipleNumer2;
                totalsum += summ;
                iterator++;
            }

            Console.WriteLine("number : " + number + ", total summ : " + totalsum);
        }
    }
}
