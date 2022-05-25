using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameIsProcesed = true;

            int mapLenght = 15;
            int mapHight = 15;

            int userPostionX = 0;
            int userPositionY = 0;

            int difficultLavel;

            char endPoint = 'X';

            int counterHopThroughVoid = 0;

            char[,] map = new char[mapLenght, mapHight];
            
            Console.WriteLine("Enter level 1 - 5");
            difficultLavel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ruls: hop on I, if you hop mor {difficultLavel},/n on {" "} - ypu lose. If you state on X - you win. Lucky for you gamer ");

            map = CreatMap(mapLenght, mapHight, difficultLavel);

            map[map.GetLength(0) - 1, map.GetLength(1) - 1] = endPoint;

            while (gameIsProcesed)
            {
                Draw(map, counterHopThroughVoid);

                Console.SetCursorPosition(userPostionX, userPositionY);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        userPostionX--;
                        break;
                    case ConsoleKey.RightArrow:
                        userPostionX++;
                        break;
                    case ConsoleKey.UpArrow:
                        userPositionY--;
                        break;
                    case ConsoleKey.DownArrow:
                        userPositionY++;
                        break;
                }

                if (map[userPositionY, userPostionX] == 'I')
                    counterHopThroughVoid = 0;

                if (map[userPositionY, userPostionX] == ' ')
                    counterHopThroughVoid++;

                if (counterHopThroughVoid == difficultLavel)
                {
                    Console.SetCursorPosition(20, 3);
                    Console.WriteLine("Fail, maximum hop ' ' colum " + difficultLavel);
                    Console.ReadKey();
                    gameIsProcesed = false;
                }

                if (map[userPositionY, userPostionX] == 'X')
                {
                    Console.SetCursorPosition(20, 3);
                    Console.WriteLine("You Win");
                    gameIsProcesed = false;
                }
            }
        }


        static void Draw(char[,] map, int counterHopThroughVoid)
        {
            Console.SetCursorPosition(50, 0);
            Console.Write("Counter hop through void: ");
            Console.Write(counterHopThroughVoid);
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < map.GetLength(0); i++)
            {

                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();

            }
        }

        static char[,] CreatMap(int lenghtMap, int higthMap, int difficultLavel)
        {
            char[,] map = new char[lenghtMap, higthMap];

            Random random = new Random();

            for (int i = 0; i < map.GetLength(0); i++)
            {

                for (int j = 0; j < map.GetLength(1); j++)
                {

                    int pointSimbol = random.Next(0, difficultLavel);

                    if (pointSimbol == (difficultLavel - 1))
                        map[i, j] = 'I';
                    else
                        map[i, j] = ' ';

                }
            }

            return map;
        }
    }
}
