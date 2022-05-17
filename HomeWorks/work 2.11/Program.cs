using System;

namespace work_2._11
{
    class Program
    {
        //"(()))(()" 
        static void Main(string[] args)
        {
            string stringForAnalis = "(()(()))";

            stringForAnalis = "(()))(()";

            char simbolTipyA = '(';
            char simbolTipyB = ')';

            int currentMaximum = 0;
            int maxmum = 0;
            int fondation = 2;
            int amountSimbolTipyA = 0;
            int amountSimbolTipyB = 0;
            int stringLenght = stringForAnalis.Length;

            bool enableChekThisString = true;

            int max = 0 ;

            for (int i = 0; i < stringLenght; i++)
            { 
                if(stringForAnalis[i] == '(')
                {
                    maxmum++;
                }
                if (stringForAnalis[i] == ')')
                {
                    maxmum--;
                }
                if (maxmum > max)
                {
                    max = maxmum;
                }

                if (max < 0)
                {
                    Console.WriteLine("fail");
                }
            }

            Console.WriteLine(max);

            //if (stringLenght % fondation == 0)
            //{
            //    enableChekThisString = true;
            //}
            //else
            //{
            //    enableChekThisString = false;
            //}

            //if(stringForAnalis[0] == simbolTipyB)
            //{
            //    enableChekThisString = false;
            //}

            //if(stringForAnalis[stringLenght - 1] == simbolTipyA)
            //{
            //    enableChekThisString = false;
            //}


            //for (int i = 0; i < stringLenght; i++)
            //{

            //    if (stringForAnalis[i] == simbolTipyA)
            //        amountSimbolTipyA++;

            //    if (stringForAnalis[i] == simbolTipyB)
            //        amountSimbolTipyB++;

            //}

            //if (amountSimbolTipyA == amountSimbolTipyB)
            //{
            //    enableChekThisString = true;
            //}
            //else
            //{
            //    enableChekThisString = false;
            //}

            //if (enableChekThisString)
            //{
            //    for (int i = 0; i < stringLenght; i++)
            //    {

            //        if (stringForAnalis[i] == simbolTipyA)
            //        {
            //            currentMaximum++;

            //            if (currentMaximum > maxmum)
            //                maxmum = currentMaximum;

            //        }
            //        else if (stringForAnalis[i] == simbolTipyB)
            //        {

            //            if (currentMaximum > 0)
            //                currentMaximum--;

            //        }
            //    }
            //    Console.WriteLine(maxmum);
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

        }
    }
}
