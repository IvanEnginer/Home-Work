using System;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string work;
            Console.Write("Введите свое имя : ");
            name = Console.ReadLine();
            Console.Write("Кем вы работаете : ");
            work = Console.ReadLine();
            Console.Write("Сколько вам лет : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой ваш знак зодиака : ");
            zodiacSign = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSign} и работаете {work}.");
        }
    }
}
