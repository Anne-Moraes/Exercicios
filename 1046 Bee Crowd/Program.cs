using System;

namespace _1046_Bee_Crowd
{
    internal class GameTime
    {
        static void Main(string[] args)
        {

            /* Read the start time and end time of a game, in hours. Then calculate the duration of the game, 
            knowing that the game can begin in a day and finish in another day, with a maximum duration of 
            24 hours. The message must be printed in portuguese “O JOGO DUROU X HORA(S)” that means 
            “THE GAME LASTED X HOUR(S)”
            
            Input
            Two integer numbers representing the start and end time of a game.

            Output
            Print the duration of the game as in the sample output.
             */

            int start, end, time;

            string[] values = Console.ReadLine().Split(' ');
            start = int.Parse(values[0]);
            end = int.Parse(values[1]);

            time = 0;

            if (start < end)
            {
                time = end - start;
            }
            else
            {
                time = 24 - start + end;
            }

            Console.WriteLine($"THE GAME LASTED {time} HOUR(S)");
    }
    }
}