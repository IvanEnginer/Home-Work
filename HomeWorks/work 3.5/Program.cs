using System;

namespace work_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 5, 9, 9, 9, 5, 5 };

            int counter = 1;
            int maximumCounter = 0;
            int maximumNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("");

            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                    counter++;
                else
                    counter = 1;

                if (counter > maximumCounter)
                {
                    maximumNumber = array[i];
                    maximumCounter = counter;
                }
            }

            Console.WriteLine($"max = {maximumNumber} \ncounter = {maximumCounter}");
        }
    }
}
