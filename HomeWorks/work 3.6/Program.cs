using System;

namespace work_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumNumber = 100;
            int maximumArraySize = 10;

            int[] array = new int [maximumArraySize];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, maximumNumber);

            int temp = 0;
            
            for (int i = 0; i < array.Length; i++)
            { 
                for (int j = 0; j < array.Length - 1; j++)
                { 
                    if (array[j] > array[j + 1]) 
                    { 
                        temp = array[j + 1]; 
                        array[j + 1] = array[j]; 
                        array[j] = temp; 
                    } 
                } 
            }
            for (int i = 0; i < array.Length; i++) 
                Console.Write(array[i] + " ");
        }
    }
}
