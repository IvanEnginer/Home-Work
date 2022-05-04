using System;

namespace work_2._8
{
    class Program
    {
        static void Main(string[] args)
        {

            string sicretMasseg = "Hello World!";
            string password = "qwerty";

            int tryChekPassword = 3;

            for (int i = 0; i < tryChekPassword; i++)
            {
                Console.Write("Enter Password: ");

                if (Console.ReadLine() == password)
                {
                    Console.WriteLine(sicretMasseg);
                    i  = tryChekPassword;
                }
            }
        }
    }
}
