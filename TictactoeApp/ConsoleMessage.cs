using System;

namespace TictactoeApp
{
    public class ConsoleMessage
    {
        public static void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic Tac Toe!");
        }

        public static void DisplayNewBoard(Board board)
        {
            Console.WriteLine("Here's the current board:");
            // Console.WriteLine(board.GetCurrentBoard());
        }
        
        

        public static string GetCoordinates(Player player)
        {
            Console.Write($"Player {player.Name} enter a coord x,y to place your {player.Symbol} or enter 'q' to give up: ");
            var answer= Console.ReadLine();
            return answer;
        }
    }
}