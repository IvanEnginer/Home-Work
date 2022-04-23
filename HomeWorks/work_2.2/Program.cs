using System;

namespace work_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMasseg;
            bool toTryAgain = true;
            while(toTryAgain)
            {
                Console.Write("Что бы выйти из программы введите exit: ");
                userMasseg = Console.ReadLine();
                if (userMasseg == "exit")
                {
                    toTryAgain = false;
                    break;
                } 
                Console.WriteLine($"Вы ввели {userMasseg}");
            }

        }
    }
}
