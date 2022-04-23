using System;

namespace work_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMasseg;
            bool tryAgain = true;

            while (tryAgain)
            {
                Console.Write("Что бы выйти из программы введите exit: ");
                userMasseg = Console.ReadLine();
                Console.WriteLine($"Вы ввели {userMasseg}");

                if (userMasseg == "exit")
                    tryAgain = false;  
                
            }
        }
    }
}
