using System;

namespace work_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Стоит собрать строку из символов через цикл string += char; и вывести строку 2 раза.

            string userString;
            string userSign;

            int lenghUserString;
            int lines = 3;
            int numberUserStringLine = 2;
            int numberStartsSimbol = 1;
            int numberEndSimbol = 1;

            Console.Write("Введите строку: ");
            userString = Console.ReadLine();
            lenghUserString = userString.Length;
            Console.Write("Введите символ для рамки: ");
            userSign = Console.ReadLine();

            lenghUserString = userString.Length;

            for(int i = 0; i < lenghUserString + numberStartsSimbol + numberEndSimbol; i++)
            {

            }

            //for(int i = 1; i < lines; i++)
            //{

            //    //if(i == numberUserStringLine)
            //    //{
            //    //    Console.WriteLine(userSign + userString + userSign);
            //    //}
            //    //else
            //    //{
            //    //    for(int j = 0; j < lenghUserString + numberStartsSimbol + numberEndSimbol; j++)
            //    //    {
            //    //        Console.Write(userSign);
            //    //    }
            //    //    Console.WriteLine();
            //    //}
            //}
        }
    }
}
