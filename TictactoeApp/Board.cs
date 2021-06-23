using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace TictactoeApp
{
    public class Board
    {
        public char[,] BoardGrid;
        public char[,] InitializeBoard()
        {
            BoardGrid = new char[3, 3]
            {
                {',',',',','},
                {',',',',','},
                {',',',',','}
            };
            return BoardGrid;
        }

        public char[,] GetCurrentBoard()
        {
            // return the current board after the coordinate has been set
            return BoardGrid;

        }

        public void SetBoard(List<int> coordinate, char symbol)
        {
            BoardGrid[coordinate[0] - 1, coordinate[1] - 1] = symbol;
        }
        
        //
        // var turnCount = 0;
        //
        // for (int row = 0; row < rowLength; row++)
        // {
        //     for (int col = 0; col < colLength; col++)
        //     {
        //         boardGrid[coord[0] - 1, coord[1] - 1] = player;
        //         // Console.Write($"{boardGrid[row, col]} ");
        //         newBoardGrid += boardGrid[row, col];
        //         Console.Write(newBoardGrid);
        //     }
        //     // print new line at the end of colLength
        //     Console.Write(Environment.NewLine);
        //     turnCount++;
        // }
        //
        // Console.WriteLine(newBoardGrid);
        //
        // // return newBoardGrid;
        //
        // // return turnCount AND the new string of boardGrid

        
    }
}