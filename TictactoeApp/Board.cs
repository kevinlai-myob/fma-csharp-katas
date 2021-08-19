using System;
using System.Collections.Generic;
using System.Dynamic;
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
                {'.','.','.'},
                {'.','.','.'},
                {'.','.','.'}
            };
            
            return BoardGrid;
        }

        
        private readonly IList<Coordinates> playedCoordinates = new List<Coordinates>();
        private Coordinates currentCoordinate;
        
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

        // Given that it is a valid position ( not outOfBound) AND it has not been placed before
        // we want to ADD the coordinates from userPrompt
        public void SetBoard(char symbol)
        {
            playedCoordinates.Add(currentCoordinate);
            Console.WriteLine($"currentCoordinate is {currentCoordinate}");
            // BoardGrid[currentCoordinate[0] - 1, currentCoordinate[1] - 1] = symbol;
        }

        // public void SetBoard(Coordinates coordinates,char symbol)
        // {
        //     // var isCoordinateExist = playedCoordinates.Any(square => square == coordinate.ro);
        //     playedCoordinates.Add(currentCoordinate);
        //     BoardGrid[playedCoordinates[0] - 1, playedCoordinates[1] - 1] = symbol;
        // }
        
        public bool CheckVictory(char currentSymbol)
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

        public bool isValidCoordinate()
        {
            return currentCoordinate.Col > 2 || currentCoordinate.Row > 2;
        }

        // public bool isEmptyPosition()
        // {
        //     return 
        // }

        
        

    }
}