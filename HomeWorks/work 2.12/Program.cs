using System;

namespace work_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int healthBoss = 100;
            int heathPlayer = 100;

            int lightHitPlayer = 10;
            int hardHitPlayer = 30;

            int lightHitBoss = 10;
            int harвtHitBoss = 40;

            string bossAction = "";

            bool enableTheGame = true;

            string actionPlaey;

            Random random = new Random();

            int numberBossAction;

            while (enableTheGame)
            {

                numberBossAction = random.Next(0, 2);

                if (healthBoss <= 0)
                {
                    enableTheGame = false;
                    Console.WriteLine("Boss fail");
                }
                else if (heathPlayer <= 0)
                {
                    enableTheGame = false;
                    Console.WriteLine("Player fail");
                }
                else
                {

                    Console.WriteLine($"Boss health {healthBoss}, Player health {heathPlayer}");
                    Console.WriteLine("hit, sheald, strike");

                    actionPlaey = Console.ReadLine();

                    switch (numberBossAction)
                    {
                        case 0:
                            bossAction = "Jump";
                            Console.WriteLine("Boss Jump");
                            break;
                        case 1:
                            bossAction = "Hard";
                            Console.WriteLine("Boss Hard strike");
                            break;
                        case 2:
                            bossAction = "Lite";
                            Console.WriteLine("Boss Lite Strike");
                            break;
                    }

                    switch (bossAction)
                    {
                        case "Jump":

                            if (actionPlaey == "strike")
                            {
                                Console.WriteLine("Player mist");
                            }
                            else if (actionPlaey == "sheald")
                            {
                                Console.WriteLine("Player Up Sheald");
                            }
                            else
                            {
                                healthBoss -= lightHitPlayer;
                                Console.WriteLine("Player light strike");
                            }

                            break;
                        case "Hard":

                            if (actionPlaey == "hit")
                            {
                                heathPlayer -= harвtHitBoss;
                                healthBoss -= lightHitPlayer;
                            }
                            else if (actionPlaey == "Sheald")
                            {
                                Console.WriteLine("Boss strike in sheald");
                            }
                            else
                            {
                                heathPlayer -= harвtHitBoss;
                                healthBoss -= hardHitPlayer;
                                Console.WriteLine("Player hard hit, Boss hard hit");
                            }

                            break;

                        case "Lite":

                            if (actionPlaey == "hit")
                            {
                                heathPlayer -= lightHitBoss;
                                healthBoss -= lightHitPlayer;
                            }
                            else if (actionPlaey == "sheald")
                            {
                                Console.WriteLine("Boss strike in sheald");
                            }
                            else
                            {
                                heathPlayer -= lightHitBoss;
                                healthBoss -= hardHitPlayer;
                                Console.WriteLine("Player mist");
                            }

                            break;
                    }
                }
            }
        }
    }
}
