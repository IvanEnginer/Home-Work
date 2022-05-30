using System;
using
    System.Collections.Generic;

namespace work_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> praceBays = new Queue<int>();

            praceBays.Enqueue(10);
            praceBays.Enqueue(15);
            praceBays.Enqueue(102);
            praceBays.Enqueue(1);
            praceBays.Enqueue(12);

            int totalPraceBays = 0;

            while (praceBays.Count > 0)
            {
                totalPraceBays += praceBays.Dequeue();
                Console.WriteLine("Total prace bays " + totalPraceBays);
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Queue end. Total sum = " + totalPraceBays + '.');
        }
    }
}
