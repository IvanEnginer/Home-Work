using System;

namespace work_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int N = random.Next(1, 27);
            int startPoint = N;
            int startReng = 100;
            int endReng = 1000;
            int amoundMultipelNumbers = 0;

            Console.WriteLine("N " + N);

            while(startPoint < startReng)
            {
                startPoint += N;
            }

            Console.WriteLine("Start POint " + startPoint);

            for (int i = startPoint; i < endReng; i += N)
            {
                amoundMultipelNumbers++;
                Console.WriteLine(i);
            }

            Console.WriteLine("amoundMultipelNumbers " + amoundMultipelNumbers);
        }
    }
}
