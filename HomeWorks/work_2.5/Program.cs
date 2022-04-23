using System;

namespace work_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int functikBankAccount, tugrikBankAccount, bunktikBankAccount;

            functikBankAccount = 100;
            tugrikBankAccount = 50;
            bunktikBankAccount = 20;

            int rateFunctikToTugrik, rateBunktikToTugrik, rateTugrikToBunktik;

            rateFunctikToTugrik = 2;
            rateBunktikToTugrik = 5;
            rateTugrikToBunktik = 10;

            int swapWalet = 0;

            int convertatinonReqwest;
            int reqwestCash;

            string exitSign = "exit";
            string reqwestForExite;

            while(true)
            {
                Console.WriteLine("Введите 1 для обмена Functik на Tugrik ");
                Console.WriteLine("Введите 2 для обмена Bunktik на Tugrik ");
                Console.WriteLine("Введите 3 для обмена Tugrik на Bunktik ");
                convertatinonReqwest = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ведите сумму ");
                reqwestCash = Convert.ToInt32(Console.ReadLine());

                switch (convertatinonReqwest)
                {
                    case 1:
                        swapWalet = rateFunctikToTugrik * reqwestCash;
                        if (swapWalet > functikBankAccount)
                        {
                            Console.WriteLine("Средст для обмена недостаточно ");
                            break;
                        }
                        functikBankAccount -= swapWalet;
                        tugrikBankAccount += swapWalet;
                        break;
                    case 2:
                        swapWalet = rateBunktikToTugrik * reqwestCash;
                        if (swapWalet > tugrikBankAccount)
                        {
                            Console.WriteLine("Средст для обмена недостаточно ");
                            break;
                        }
                        bunktikBankAccount -= swapWalet;
                        tugrikBankAccount += swapWalet;
                        break;
                    case 3:
                        swapWalet = rateTugrikToBunktik * reqwestCash;
                        if (swapWalet > bunktikBankAccount)
                        {
                            Console.WriteLine("Средст для обмена недостаточно ");
                            break;
                        }
                        tugrikBankAccount -= swapWalet;
                        bunktikBankAccount += swapWalet;
                        break;
                    
                }
                Console.WriteLine($"На ваших считах  functik {bunktikBankAccount} tugrik {tugrikBankAccount} bunktik {bunktikBankAccount}");
                Console.WriteLine("Введите exit для выхода из программы, no для продолжения");
                reqwestForExite = Console.ReadLine();
                if(reqwestForExite == exitSign) break;
            }

            Console.WriteLine("Программа завершена");
        }
    }
}
