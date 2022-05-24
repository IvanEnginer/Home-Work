using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            chekuserMaseg();
        }

        static int chekuserMaseg()
        {
            bool tryIsWhile = true;
            int number = 0;

            while (tryIsWhile)
            {
                string massege = Console.ReadLine();

                if (int.TryParse(massege, out number))
                {
                    Console.WriteLine("You Number " + number);
                    tryIsWhile = false;
                }
                else
                {
                    Console.WriteLine("It is not number, try again");
                }

            }

            return number;
        }
    }
}
