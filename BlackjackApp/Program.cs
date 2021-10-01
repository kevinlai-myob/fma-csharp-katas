using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BlackjackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new StringBuilder();
            var player = new Player();
            var dealer = new Player();
            var game = new Game(player, dealer);
            game._buildString = message;
            game._playerOne = player;
            game._dealer = dealer;
            game.ShuffledDeck();
            game.DealTwoCardsToPlayer();
            game.takeTurns(game._playerOne);
            endOfTurn(game, message);

        }

        public static void endOfTurn(Game game, StringBuilder msg)
        {
            var playersPoints = game.GetPlayersCurrentPoints(game._currentPlayer.PlayersHand);
            var currentPlayersPoints = msg.CurrentPoints(playersPoints);
            Console.WriteLine(currentPlayersPoints);
            game._currentPlayer = (game._currentPlayer == game._playerOne) ? game._dealer : game._playerOne;

        }
    }
}