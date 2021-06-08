using System;
using System.Collections.Generic;

namespace TictactoeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMessage.AppStartMessage();
            var userPrompt = ConsoleMessage.AskForCoordinate();
            
            // Console.Write("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ");
            // var answer= Console.ReadLine();

            var coord = new List<int>();
            // method
            foreach (string number in userPrompt.Split(','))
            {
                coord.Add(int.Parse(number));
            }

            Console.WriteLine(coord);

            var symbol = "x";
            
            Board.InitializeBoard(coord, symbol);
            
            // var boardGrid = new string[3, 3]
            // {
            //     {".", ".", "."},
            //     {".", ".", "."},
            //     {".", ".", "."}
            // };
            // Console.WriteLine(boardGrid);
            //
            // // locate [0,1] as 'X;
            // for (int i = 0; i < 4; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         boardGrid[coord[0], coord[1]] = "x";
            //     }
            // }
            //
            // Join with space
            
            Console.WriteLine(string.Join(" ", boardGrid));
            // for every item at the interval of 3, join a new line
        }
        
    }
}