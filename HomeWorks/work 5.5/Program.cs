using System;
using System.Collections.Generic;

namespace work_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {1, 2, 1};
            int[] array2 = new int[] { 3, 2};
            //"1", "2", "1"} + {"3", "2"} => {"1", "2", "3"} 

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();

            for (int i = 0; i < array1.Length; i++)
                list1.Add(array1[i]);

            for (int i = 0; i < array2.Length; i++)
                list1.Add(array2[i]);

            for (int i = 0; i < list1.Count; i++)
                Console.Write("\t" + list1[i]);

            Console.WriteLine();

            for(int i = 0; i < list1.Count; i++)
            {
               
            }


                

            //for (int i = 0; i < list2.Count; i++)
            //    Console.Write("\t" + list2[i]);

            //Console.WriteLine(" Add ");

            //for (int i = 0; i < list2.Count; i++)
            //    list1.Add(list2[i]);

            //for (int i = 0; i < list1.Count; i++)
            //    Console.Write("\t" + list1[i]);

            Console.WriteLine();

            //if(list1.Contains(list2[1]))

            //for (int i = 0; i < list1.Count; i++)
            //{ 
            //    foreach(int number in list2)
            //    {

            //    }
            //}
        }
    }
}
