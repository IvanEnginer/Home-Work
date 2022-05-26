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
                        InputDataDosser(ref surnameNameMidleName,ref post);
                        break;
                    case 2:
                        OutAllDossers(ref surnameNameMidleName, ref post);
                        break;
                    case 3:
                        DeliteDosser(ref surnameNameMidleName, ref post);
                        break;
                    case 4:
                        FoundSurnameNameMidleName(ref dossierIsNotFound, ref surnameNameMidleName);
                        break;
                    case 5:
                        enableWorkProgram = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string[] ExpansionArray(string[] array)
        {
            string[] modifiedArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                modifiedArray[i] = array[i];
            }

            return modifiedArray;
        }

        static string[] AddDataDosser(string[] array, string massege)
        {
            Console.Write(massege);
            array = ExpansionArray(array);
            array[array.Length - 1] = Console.ReadLine();
            return array;
        }

        static string[] DeliteDosser(string[] array, int numberDosser)
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

        static void InputDataDosser(ref string[] surnameNameMidleName, ref string[] post)
        {
            surnameNameMidleName = AddDataDosser(surnameNameMidleName, "Enter Surname Name Midle Name: ");
            post = AddDataDosser(post, "Enter post worker: ");
        }

        static void OutAllDossers(ref string[] surnameNameMidleName, ref string[] post)
        {

            for (int i = 0; i < surnameNameMidleName.Length; i++)
            {

                Console.WriteLine("Surname Name Midle Name: " + surnameNameMidleName[i] + " Post: " + post[i]);
            }

        }

        static void DeliteDosser( ref string[] surnameNameMidleName, ref string[] post)
        {
            Console.Write("Enter number dosser for delite: ");
            int numberOfDosser = Convert.ToInt32(Console.ReadLine());
            surnameNameMidleName = DeliteDosser(surnameNameMidleName, numberOfDosser);
            post = DeliteDosser(post, numberOfDosser);
        }

        static void FoundSurnameNameMidleName(ref bool dossierIsNotFound, ref string[] surnameNameMidleName)
        {
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

        }
    }
}
