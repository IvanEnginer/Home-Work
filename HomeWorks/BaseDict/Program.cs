using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication30
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
            string userMassege;



            while (enableWorkProgram)
            {
                Console.WriteLine("Menu.\n\n1 - Add dossier;\n2 - Out all dossier;\n" +
                    "3 - Delite dossier for name;\n4 - Escape.\n" +
                    "\nEnter comand: ");

                userMassege = Console.ReadLine();

                if (GetNumber(userMassege, out comandMenu))
                {
                    switch (comandMenu)
                    {
                        case 1:
                            InputDataDosser(ref persens);
                            break;
                        case 2:
                            OutAllDossers(ref persens);
                            break;
                        case 3:
                            DeleteDosser(ref persens);
                            break;
                        case 4:
                            enableWorkProgram = false;
                            break;
                    }
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static bool GetNumber(string text,out int number)
        {
            return int.TryParse(text, out number);
        }

        static void DeleteDosser(ref Dictionary<string, string> dictionary)
        {
            string name;

            Console.Write("Enter name worker for delete dooser: ");
            name = Console.ReadLine();

            if (dictionary.ContainsKey(name))
            {
                dictionary.Remove(name);
                Console.WriteLine("Delete succefule");
            }
            else
                Console.WriteLine("This worker not existe");
        }

        static void InputDataDosser(ref Dictionary<string, string> dictionary)
        {
            string name = AddDataDosser("Enter Name: "); ;
            string post = AddDataDosser("Enter post: ");

            dictionary.Add(name, post);

            Console.WriteLine("Creat succefule");
        }

        static void OutAllDossers(ref Dictionary<string, string> dictionary)
        {
            int iterator = 1;

            foreach (var persen in dictionary)
            {
                Console.Write(persen.Key + " " + persen.Value);

                if (dictionary.Count > iterator)
                {
                    Console.Write(" - ");
                    iterator++;
                }
            }
        }


        static string AddDataDosser(string massege)
        {
            string data;

            Console.Write(massege);
            data = Console.ReadLine();
            return data;
        }
    }
}
