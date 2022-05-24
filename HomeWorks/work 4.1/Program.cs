using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] surnameNameMidleName = new string[0];
            string[] post = new string[0];
            int comandMenu;
            bool enableWorkProgram = true;
            bool dossierIsNotFound = true;

            while (enableWorkProgram)
            {
                Console.WriteLine("Menu.\n\n1 - Add dossier;\n2 - Out all dossier;\n" +
                    "3 - Delite dossier for number;\n4 - found Surname Name Midle Name ;\n5 - Escape.\n" +
                    "\nEnter comand: ");

                comandMenu = Convert.ToInt32(Console.ReadLine());

                switch (comandMenu)
                {
                    case 1:
                        surnameNameMidleName = addDataDosser(surnameNameMidleName, "Enter Surname Name Midle Name: ");
                        post = addDataDosser(post, "Enter post worker: ");
                        break;
                    case 2:

                        for (int i = 0; i < surnameNameMidleName.Length; i++)
                        {

                            Console.WriteLine("Surname Name Midle Name: " + surnameNameMidleName[i] + " Post: " + post[i]);
                        }

                        break;
                    case 3:
                        Console.Write("Enter number dosser for delite: ");
                        comandMenu = Convert.ToInt32(Console.ReadLine());
                        surnameNameMidleName = deliteDosser(surnameNameMidleName, comandMenu);
                        post = deliteDosser(post, comandMenu);
                        break;
                    case 4:
                        Console.Write("Enter Surname Name Midle Name worker: ");
                        string inputData = Console.ReadLine();

                        for (int i = 0; i < surnameNameMidleName.Length; i++)
                        {
                            if (surnameNameMidleName[i] == inputData)
                            {
                                dossierIsNotFound = false;
                                break;
                            }
                        }

                        if (dossierIsNotFound)
                        {
                            Console.WriteLine("Dosser not found");
                        }

                        break;
                    case 5:
                        enableWorkProgram = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string[] expansionArray(string[] array)
        {
            string[] modifiedArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                modifiedArray[i] = array[i];
            }

            return modifiedArray;
        }

        static string[] addDataDosser(string[] array, string massege)
        {
            Console.Write(massege);
            array = expansionArray(array);
            array[array.Length - 1] = Console.ReadLine();
            return array;
        }

        static string[] deliteDosser(string[] array, int numberDosser)
        {
            string[] modifiedArray = new string[array.Length - 1];

            for (int i = 0; i < modifiedArray.Length; i++)
            {
                if (i != numberDosser - 1)
                {
                    modifiedArray[i] = array[i];
                }
                else
                {
                    modifiedArray[i] = array[i + 1];
                }
            }

            return modifiedArray;
        }
    }
}
