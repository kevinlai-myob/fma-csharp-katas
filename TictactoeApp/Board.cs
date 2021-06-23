using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;

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

        
        public void GetCurrentBoard()
        {
            // return the current board after the coordinate has been set
            for (int row = 0; row < 3; row++)
            {
                for (int col= 0; col < 3; col++)
                {
                    Console.Write(BoardGrid[row,col]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        public void SetBoard(List<int> coordinate, char symbol)
        {
            BoardGrid[coordinate[0] - 1, coordinate[1] - 1] = symbol;
            
        }

        public string CheckWinningCombinations(string currentSymbol)
        {
            // 00 01 02
            //     10 11 12
            //         20 21 22
            //             00 10 20
            //                 01 11 21
            //                     02 12 22
            //                         00 11 22
            //                             02 11 20
            BoardGrid[0][0] == BoardGrid[1][2] && BoardGrid[1][1] == BoardGrid[1][2];
        }

    }
}