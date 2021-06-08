using System;
using System.Collections.Generic;

namespace TictactoeApp
{
    public class Board
    {
        public static void InitializeBoard(List<int> coord, string symbol)
        {
            var boardGrid = new string[3, 3]
            {
                {".", ".", "."},
                {".", ".", "."},
                {".", ".", "."}
            };
            Console.WriteLine(boardGrid);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    boardGrid[coord[0], coord[1]] = symbol;
                }
            }
            // Join with space
            Console.WriteLine(string.Join(" ", boardGrid));
            // for every item at the interval of 3, join a new line

        }
    }
}