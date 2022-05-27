using System;

namespace _2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForAnalis = ")(()((())))";

            int deap = 0;
            int maximumDeap = 0;

//            bool vereficationIsAlowwed = true;

            bool vereficationIsSuccefule;


            for (int i = 0; i < stringForAnalis.Length; i++)
            {
                if (stringForAnalis[i] == '(')
                {

                    deap++;

                    if (deap > maximumDeap)
                        maximumDeap = deap;

                }
                else
                    deap--;

                if (deap < 0)
                {

                    vereficationIsSuccefule = false;
                    break;

                }
                else 
                {
                    vereficationIsSuccefule = true;
                }                
            }

            if (deap == 0)
                Console.WriteLine(maximumDeap);
            else
                Console.WriteLine("fail");
        }
    }
}
