using System;
using System.Collections.Generic;

namespace DozerCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var persens = new Dictionary<string, string>()
            {
                {"Tom", "Worker"} , { "Bom", "Medic"}
            };

            List<string> list1 = new List<string>();

            int comandMenu;
            bool enableWorkProgram = true;

            while (enableWorkProgram)
            {
                Console.WriteLine("Menu.\n\n1 - Add dossier;\n2 - Out all dossier;\n" +
                    "3 - Delite dossier for number;\n4 - found Surname Name Midle Name ;\n5 - Escape.\n" +
                    "\nEnter comand: ");

                comandMenu = Convert.ToInt32(Console.ReadLine());

                switch (comandMenu)
                {
                    case 1:
                        InputDataDosser();
                        break;
                    case 2:
                        //OutAllDossers(surnameNameMidleName, post);
                        break;
                    case 3:
                        // DeliteDosser(ref surnameNameMidleName, ref post);
                        break;
                    case 4:
                        // FoundDosserBySurname(dossierIsNotFound, surnameNameMidleName);
                        break;
                    case 5:
                        enableWorkProgram = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
