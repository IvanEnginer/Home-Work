using System;

namespace work_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMasseg;

            while(true)
            {
                Console.Write("Что бы выйти из программы введите exit: ");
                userMasseg = Console.ReadLine();

                if (userMasseg == "exit")break;

                Console.WriteLine($"Вы ввели {userMasseg}");
            }

        }
    }
}
