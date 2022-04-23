using System;

namespace work_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMasseg;
            int tryCounter;
            Console.Write("Введите сообщение: ");
            userMasseg = Console.ReadLine();
            Console.Write("Введите количсетво повторов: ");
            tryCounter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tryCounter; i++)
            {
                Console.WriteLine(userMasseg);
            }
            Console.WriteLine($"Количество повторов: {tryCounter}");
        }
    }
}
