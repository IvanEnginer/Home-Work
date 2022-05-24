using System;

namespace work_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] a = new int[n] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < n; ++i)
                Console.Write("\t" + a[i]);
            Console.WriteLine();

            Console.WriteLine("Введите k");
            int k = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < k; ++i)
            {
                int aLast = a[n - 1];
                for (int j = n - 1; j > 0; j--)
                    a[j] = a[j - 1];
                a[0] = aLast;
            }

            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < n; ++i)
                Console.Write("\t" + a[i]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
