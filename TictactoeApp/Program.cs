using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TictactoeApp
{
    class Program
    {
        static readonly Player PlayerOne = new Player("1", 'x');
        static readonly Player PlayerTwo = new Player("2", 'o');
        static Player _currentPlayer = PlayerOne;

        public static void Main(string[] args)
        {
            // var playerOne = new Player("1", 'x');
            // var playerTwo = new Player("2", 'o');
            // var currentPlayer = playerOne;
            
            var board = new Board();
            
            var turns = 0;
            ConsoleMessage.WelcomeMessage();
            board.InitializeBoard();
            

            
            while (turns < 9)
            {
                var userPrompt = ConsoleMessage.GetCoordinates(_currentPlayer);

                // ConsoleMessage.DuplicateEntry();
                var coord = new List<int>();
                
                // parse the coord
                foreach (string number in userPrompt.Split(','))
                {
                    // check if the same coord has been entered before (If yes, dont add, if No, parse it to int and add)
                    var tempString = userPrompt.Split(',')[0] + userPrompt.Split(',')[1];

       
                    var parsedNumber = int.Parse(number);
                    Console.WriteLine(parsedNumber);

                    coord.Add(parsedNumber);
                }
                
                

                // set the coord in board
                board.SetBoard(_currentPlayer.Symbol);
                

                // print the board after coord has been provided
                board.GetCurrentBoard();
                
                // Check winning combo
                var isVictory = board.CheckVictory(_currentPlayer.Symbol);
                if (isVictory)
                {
                    ConsoleMessage.AnnounceWinners(_currentPlayer);
                    break;
                }
                
                _currentPlayer = NextPlayer();
                turns++;
            }
        }

        public static Player NextPlayer()
        {
            if (_currentPlayer == PlayerOne)
            {
                return PlayerTwo;
            }
            return PlayerOne;
        }
    }
}