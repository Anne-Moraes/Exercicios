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

            Console.WriteLine("Enter the number of hours from the start of the game");

            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of hours from the end of the game.");
            end = int.Parse(Console.ReadLine());

            time = 0;
                          
            if(start < end)
            {
                time = end - start;  
            }
            else if (start > end)
            {
                time = 24 - start + end;
            }
            else 
            {
                time = 24;
            }

            if (time <= 24)
            {
                Console.WriteLine($"O JOGO DUROU {time} HORA(S)");
            }
            else;
 
        }
    }
}