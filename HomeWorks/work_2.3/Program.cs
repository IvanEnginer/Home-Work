using System;

namespace work_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            for(int i = 5; i <= 96; i += 7)Console.WriteLine($"{i}");
            int chekPoint;
            int startPoint = 5;
            int endPoint = 96;
            int iterator = 7;

            //chekPoint = startPoint;
            //Console.WriteLine(chekPoint);
            //while (chekPoint != endPoint)
            //{
            //    chekPoint = chekPoint + iterator;
            //    Console.WriteLine(chekPoint);                    
            //}

            for (chekPoint = startPoint; chekPoint <= endPoint; chekPoint += iterator) Console.WriteLine(chekPoint);

            // в for итерация происходит в условии цикла, что на мой взгял удобнее 
        }
    }
}
