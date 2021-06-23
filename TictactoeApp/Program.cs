using System;
using System.Collections.Generic;

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
            
            int turns = 0;
            ConsoleMessage.WelcomeMessage();
            board.InitializeBoard();

            while (turns < 9)
            {
                var userPrompt = ConsoleMessage.GetCoordinates(_currentPlayer).Split(',');
                
                var coord = new List<int>();
                // parse the coord
                foreach (string number in userPrompt)
                {
                    coord.Add(int.Parse(number));
                }
                // set the coord in board
                board.SetBoard(coord, _currentPlayer.Symbol);

                // print the board after coord has been provided
                board.GetCurrentBoard();
                
                // Check winning combo

                _currentPlayer = NextPlayer();
                turns++;
            }
            // NextMove(playerOne, playerTwo);
            
        }

        public static string NextMove(Player player)
        {
            return "yes";
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