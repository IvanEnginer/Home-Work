using System;
using System.Collections.Generic;

namespace ListsUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {1, 1, 2, 2, 3, 4};
            int[] array2 = new int[] {3, 2, 2, 1, 7};

            List<int> list = new List<int>();

            AddToList(array1, ref list);
            AddToList(array2, ref list);
            ShowList(list);
        }

        static void AddToList(int[] array, ref List<int> list)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!list.Contains(array[i]))
                {
                    list.Add(array[i]);
                }
            }
        }

        static void ShowList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");

            Console.WriteLine();
        }
    }
}
