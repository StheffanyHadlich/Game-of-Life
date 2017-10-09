using System;


// Diferent kinds of initializations can change the game's behaviour

public class Inicialization
{
    public static int[,] Inicialization1(int[,] Game)
    {
        Game[9, 5] = 1;
        Game[9, 6] = 1;
        Game[9, 7] = 1;
        Game[9, 8] = 1;
        Game[9, 9] = 1;
        Game[9, 10] = 1;
        Game[9, 11] = 1;
        Game[9, 12] = 1;
        Game[9, 13] = 1;
        Game[9, 14] = 1;

        return Game;
    }

    public static int[,] RandomInicialization(int[,] Game, int SIZE)
    {
        Random rd = new Random();
        int x;

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                x = rd.Next(10);

                if (x < 2)
                {
                    Game[i, j] = 1;
                }
                else
                {
                    Game[i, j] = 0;
                }

            }
        }

        return Game;
    }

     public static int PopulationInitalSize(int[,] Game, int SIZE, int countAlive)
     {
          for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                if (Game[i,j]==1)
                {
                    countAlive++;
                }
            }
        }

        return countAlive;
     }
}