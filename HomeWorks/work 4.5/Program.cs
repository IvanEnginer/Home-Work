using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumColumArray = 10;

            Random random = new Random();

            int[] array = new int[random.Next(0, maximumColumArray)];

            fualArray(array);
            Console.WriteLine("Исходный массив");
            outArray(array);
            shuffleArray(array);
            Console.WriteLine("\nПеремешанный массив");
            outArray(array);
        }

        static void fualArray(int[] array)
        {
            Random random = new Random();

            int maximumNumbers = 10;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, maximumNumbers);
            }
        }

        static void outArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }

        static void shuffleArray(int[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int randomItem = random.Next(i);
                int shuffledElement = array[randomItem];
                array[randomItem] = array[i];
                array[i] = shuffledElement;
            }

        }
    }
}
