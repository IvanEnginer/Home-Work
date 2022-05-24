using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int posiition;
            int percent;

            Console.WriteLine("Enter position");
            posiition = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter porcent");
            percent = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            CreatBar(posiition, percent);
            Console.ReadKey();
        }

        static void CreatBar(int position, int percent)
        {
            int columInBar = 10;
            int newPersent = percent / columInBar;


            string bar = "[";

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < newPersent; i++)
                bar += "#";

            for (int i = newPersent + 1; i <= columInBar; i++)
                bar += "_";

            bar += "]";

            Console.SetCursorPosition(0, position);
            Console.WriteLine(bar);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
