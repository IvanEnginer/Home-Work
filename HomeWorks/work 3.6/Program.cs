using System;

namespace work_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumNumber = 100;
            int maximumArraySize = 10;

            int[] arr = new int [maximumArraySize];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int number = random.Next(0, maximumNumber);
                arr[i] = number;
            }

            int temp = 0;
            
            for (int write = 0; write < arr.Length; write++)
            { 
                for (int sort = 0; sort < arr.Length - 1; sort++)
                { 
                    if (arr[sort] > arr[sort + 1]) 
                    { 
                        temp = arr[sort + 1]; 
                        arr[sort + 1] = arr[sort]; 
                        arr[sort] = temp; 
                    } 
                } 
            }
            for (int i = 0; i < arr.Length; i++) 
                Console.Write(arr[i] + " ");
        }
    }
}
