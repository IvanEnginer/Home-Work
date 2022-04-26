using System;

namespace Work7
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuteInHour = 60;
            int peoplsInQeua;
            int timeScope = 10;
            int hourInQuea;
            int totalMinutsInQuea;
            int minutsInQuea;

            Console.Write("Количество человек в очереди : ");
            peoplsInQeua = Convert.ToInt32(Console.ReadLine());

            totalMinutsInQuea = peoplsInQeua * timeScope;
            hourInQuea = totalMinutsInQuea / minuteInHour;
            minutsInQuea = totalMinutsInQuea - (hourInQuea * minuteInHour);

            Console.WriteLine($"Вы должны отстоять в очереди {hourInQuea} часа и {minutsInQuea} минут.");
        }
    }
}
