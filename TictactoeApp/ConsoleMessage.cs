using System;

namespace TictactoeApp
{
    public class ConsoleMessage
    {
        public static void AppStartMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Here's the current board:");
            Console.WriteLine(". . ." + "\r\n" + ". . ." + "\r\n" +  ". . ." + "\r\n" );
        }

        public static string AskForCoordinate()
        {
            Console.Write("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ");
            var answer= Console.ReadLine();

            return answer;
        }
    }
}