using System;

namespace Work7
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoplsInQeua;
            int timeScope = 10;
            int hourInQuea;
            int minutsInQuea;
            int pepolsToUseInHours = 60/timeScope;

            Console.Write("Количество человек в очереди : ");
            peoplsInQeua = Convert.ToInt32(Console.ReadLine());

            hourInQuea = peoplsInQeua / pepolsToUseInHours;
            
            minutsInQuea = (peoplsInQeua - hourInQuea * pepolsToUseInHours) * timeScope;
            Console.WriteLine($"Вы должны отстоять в очереди {hourInQuea} часа и {minutsInQuea} минут.");
        }
    }
}
