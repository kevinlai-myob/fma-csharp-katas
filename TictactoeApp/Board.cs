using System;
using System.Collections.Generic;

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

        public bool CheckWinningCombinations(char currentSymbol)
        {
            return IsHorizontalVictory(currentSymbol) 
                   || IsVerticalVictory(currentSymbol) 
                   || IsDiagonalVictory(currentSymbol);
        }
        
        private bool IsHorizontalVictory(char currentSymbol)
        {
            for(int row = 0; row <= 2; row++)
            {
                if(BoardGrid[0,row] == currentSymbol && BoardGrid[1,row] == currentSymbol && BoardGrid[2,row] == currentSymbol)
                    return true;
            }
            return false;
        }
        
        private bool IsVerticalVictory(char currentSymbol)
        {
            for(int col = 0; col <= 2; col++)
            {
                if(BoardGrid[col,0] == currentSymbol && BoardGrid[col,1] == currentSymbol && BoardGrid[col,2] == currentSymbol)
                    return true;
            }
            return false;
        }
        
        private bool IsDiagonalVictory(char currentSymbol)
        {
            for(int col = 0; col <= 2; col++)
            {
                if(BoardGrid[0,0] == currentSymbol && BoardGrid[1,1] == currentSymbol && BoardGrid[2,2] == currentSymbol)
                    return true;
                if(BoardGrid[0,2] == currentSymbol && BoardGrid[1,1] == currentSymbol && BoardGrid[2,0] == currentSymbol)
                    return true;
            }
            return false;
        }

        
        

    }
}