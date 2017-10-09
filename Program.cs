using System;

namespace Atividade3
{
    class Program
    {
        public const int SIZE = 20;
        static void Main(string[] args)
        {

            int[,] Game = new int[SIZE, SIZE];

            int[,] Game2;

            int countAlive =0;
            int countTime = 0;

            //Game = Inicialization.Inicialization1(Game);
            Game = Inicialization.RandomInicialization(Game,SIZE);

            countAlive = Inicialization.PopulationInitalSize(Game,SIZE,countAlive);

            while (true)
            {
                Program.Show(Game,countAlive,countTime);

                Game2 = (int[,])Game.Clone();

                for (int i = 1; i < SIZE - 1; i++)
                {
                    for (int j = 1; j < SIZE - 1; j++)
                    {

                        if (Game2[i, j] == 0)
                        {
                            if (Program.Neighbors(Game2, i, j) == 3)
                            {
                                Game[i, j] = 1; // Birth condition
                                countAlive++;
                            }
                        }
                        else
                        {
                            if ((Program.Neighbors(Game2, i, j) > 3) || (Program.Neighbors(Game2, i, j) < 2))
                            {
                                Game[i, j] = 0; // Death condition
                                countAlive--;
                            }
                        }

                    }
                }
                
                countTime ++;
                System.Threading.Thread.Sleep(500);
                Console.Clear();

            }



        }


        public static void Show(int[,] Game, int countAlive, int countTime)
        {
            Console.WriteLine("Conway's Game of Life    \n");
            //Console.BackgroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (Game[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write("  ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("🕷 ");
                    }

                }
                Console.WriteLine();
            }

             Console.WriteLine("Population: "+countAlive+"\nTime: "+countTime);
        }

        public static int Neighbors(int[,] Game, int i, int j)
        {
            int count = 0;

            if (Game[i - 1, j - 1] == 1)
            {
                count++;
            }
            if (Game[i - 1, j] == 1)
            {
                count++;
            }
            if (Game[i - 1, j + 1] == 1)
            {
                count++;
            }
            if (Game[i, j - 1] == 1)
            {
                count++;
            }
            if (Game[i, j + 1] == 1)
            {
                count++;
            }
            if (Game[i + 1, j - 1] == 1)
            {
                count++;
            }
            if (Game[i + 1, j] == 1)
            {
                count++;
            }
            if (Game[i + 1, j + 1] == 1)
            {
                count++;
            }


            return count;
        }
    }
}
