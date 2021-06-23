using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TictactoeApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var playerOne = new Player("1", 'x');
            var playerTwo = new Player("2", 'o');
            var board = new Board();
            
            int turns = 0;
            
            ConsoleMessage.WelcomeMessage();
            board.InitializeBoard();
            // print empty board
            
            // 
            
            while (turns < 9)
            {
                var userPrompt = ConsoleMessage.AskForCoordinate(playerOne).Split(',');
                
                var coord = new List<int>();
                // parse the coord
                foreach (string number in userPrompt)
                {
                    coord.Add(int.Parse(number));
                }
                // set the coord in board
                board.SetBoard(coord, playerOne.Symbol);
                
                // print the board after coord has been provided
                turns++;
            }
            // NextMove(playerOne, playerTwo);
            
        }

        public static string NextMove(Player player)
        {
            return "yes";
        }

        public static string NextPlayer(Player player)
        {
            if ()
            {
                return playerOne;
            }
            return
        }
    }
}