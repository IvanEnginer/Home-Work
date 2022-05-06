using System;

namespace work_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomStartBorder = 1;
            int randomEndBorder = 27;
            int randomNumber = random.Next(randomStartBorder, randomEndBorder);
            int startPoint = randomNumber;
            int startReng = 100;
            int endReng = 1000;
            int amoundMultipelNumbers = 0;

            Console.WriteLine("Random number " + randomNumber);

            while(startPoint < startReng)
            {
                startPoint += randomNumber;
            }

            Console.WriteLine("Start POint " + startPoint);

            for (int i = startPoint; i < endReng; i += randomNumber)
            {
                amoundMultipelNumbers++;
                Console.WriteLine(i);
            }

            Console.WriteLine("Amound multipel numbers " + amoundMultipelNumbers);
        }
    }
}
