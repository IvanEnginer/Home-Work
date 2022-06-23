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

            int comandMenu;
            bool enableWorkProgram = true;
            string userMassege;

            while (enableWorkProgram)
            {
                Console.WriteLine("Menu.\n\n1 - Add dossier;\n2 - Out all dossier;\n" +
                    "3 - Delite dossier for name;\n4 - Escape.\n" +
                    "\nEnter comand: ");

                userMassege = Console.ReadLine();

                int.TryParse(userMassege, out comandMenu);

                switch (comandMenu)
                {
                    case 1:
                        AddDosser(ref persens);
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

                Console.ReadKey();
                Console.Clear();
            }
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
            {
                Console.WriteLine("This worker not existe");
            }
        }

        static void AddDosser(ref Dictionary<string, string> dictionary)
        {
            string name = InputData("Enter Name: ");
            string post = InputData("Enter post: ");

            if (dictionary.ContainsKey(name) == false)
            {
                dictionary.Add(name, post);
                Console.WriteLine("Creat succefule");
            }
            else
            {
                Console.WriteLine(name + " exeste, try againe");
            }
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
        
        static string InputData(string massege)
        {
            string data;

            Console.Write(massege);
            data = Console.ReadLine();
            return data;
        }
    }
}
