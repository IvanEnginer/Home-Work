using System;
using System.Collections.Generic;

namespace ListsUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {1, 2, 3};
            int[] array2 = new int[] { 3, 2 };

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            ArrayToList(array1, ref list1);
            ShowList(list1);

            ArrayToList(array2, ref list2);
            ShowList(list2);

            UnitedLists(ref list1,ref list2);
        }

        static void ArrayToList(int[] array, ref List<int> list)
        {
            for (int i = 0; i < array.Length; i++)
                list.Add(array[i]);
        }

        static void ShowList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");

            Console.WriteLine();
        }

        static void UnitedLists(ref List<int> list1, ref List<int> list2)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                if (list2.Contains(list1[i]))
                {
                    list2.Remove(list1[i]);
                }
            }

            for (int i = 0; i < list2.Count; i++)
                list1.Add(list2[i]);

            for (int i = 0; i < list1.Count; i++)
                Console.Write(list1[i] + " ");
        }
    }
}
