using System;

namespace work_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вывести имя в прямоугольник из символа, который введет сам пользователь.
            //            Вы запрашиваете имя, после запрашиваете символ, 
            //                а после отрисовываете в консоль его имя в прямоугольнике из его символов.

            //            Пример:

            //                        Alexey

            //                        %


            //                        %%%%%%
            //                        %Alexey%
            //                        %%%%%%

            //                        Примечание:

            //            Длину строки можно всегда узнать через свойство Length

            //string someString = “Hello”;

            //Console.WriteLine(someString.Length); //5 
            string userString;
            string userSign;
            int lenghUserString;
            Console.Write("Введите строку: ");
            userString = Console.ReadLine();
            lenghUserString = userString.Length;
            Console.Write("Введите символ для рамки: ");
            userSign = Console.ReadLine();


        }
    }
}
