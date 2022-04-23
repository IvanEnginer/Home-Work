using System;

namespace work_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int chekPoint;
            int startPoint = 5;
            int endPoint = 96;
            int iterator = 7;

            for (chekPoint = startPoint; chekPoint <= endPoint; chekPoint += iterator) 
                Console.WriteLine(chekPoint);

        }
    }
}
