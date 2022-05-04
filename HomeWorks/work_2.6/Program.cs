using System;

namespace work_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultTeamName = "Team 101";
            string defaultTeamFlag = "черный";
            string defaulticretSign = "default";
            string setTeamName = defaultTeamName;
            string changeFlagCollar = defaultTeamFlag;
            string setSicretSign = defaulticretSign;
            int choisCommand;
            int setGamers = 0;
            bool whileSetGetTeamData = true;

            while(whileSetGetTeamData)
            {
                Console.WriteLine("Программа для создания вашего отряда.\n\n" +
                    "Для ввода названия команды введите 1.\n" +
                    "Для ввода числа игроков введите 2.\n" +
                    "Для выбора цвета флага команды 3.\n" +
                    "Для ввода секретного слова введите 4.\n" +
                    "Для вывода иформации о команде введите 5.\n" +
                    "Для завешения программы введите 6.");
                choisCommand = Convert.ToInt32(Console.ReadLine());

                switch(choisCommand)
                {
                    case 1:

                        Console.Write("Изменить название команды : ");
                        setTeamName = Console.ReadLine();

                        break;
                    case 2:

                        Console.Write("ВВедите введите количество игроков : ");
                        setGamers = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 3:

                        Console.Write("Выберете один из цветов зеленый или черный, по умолчанию черный: ");
                        changeFlagCollar = Console.ReadLine();

                        if (changeFlagCollar == "зеленый") 
                            Console.BackgroundColor = ConsoleColor.Green;

                            break;
                    case 4:

                        Console.Write("Изменить секретное слово, по омолчанию  секретное слово default : ");
                        setSicretSign = Console.ReadLine();

                        break;
                    case 5:

                        Console.Write("Введите секретное слово что бы просмотреть информацию о команде : ");

                        if (Console.ReadLine() == setSicretSign)
                        {
                            Console.WriteLine($"Ваша команда называеться  : {setTeamName}\n" +
                                $"Колличество игроков : {setGamers}\n" +
                                $"Цвет флага : {changeFlagCollar}\n" +
                                $"Секретное слово : {setSicretSign}");
                        }
                            else
                            {
                            Console.WriteLine("Вы ввели неправильное секретное слово");
                            }  
                        
                        break;
                    case 6:

                        whileSetGetTeamData = false;
                        break;
                }
            }
        }
    }
}
