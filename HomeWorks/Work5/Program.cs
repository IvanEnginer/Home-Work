using System;

namespace Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 11;
            int month = 1960;

            int swap;

            Console.WriteLine($"year {year} month {month}");
            swap = month;
            month = year;
            year = swap;
            Console.WriteLine($"year {year} month {month}");
        }
    }
}
