using System;

namespace work_2._7
{
    class Program
    {
        static void Main(string[] args)
        {

            string userString;
            string userSign;
            string outString = "";

            int lenghUserString;
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
                outString += userSign;
            }

            Console.WriteLine(outString);
            Console.WriteLine(userSign + userString + userSign + "\n" + outString);
        }
    }
}
