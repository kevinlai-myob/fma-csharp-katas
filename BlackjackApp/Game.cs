using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace BlackjackApp
{
    public class Game
    {
        private Deck _deck { get; set; }
        public Player _playerOne { get; set; }
        public Player _dealer { get; set; }
        public Player _currentPlayer { get; set; }
        public StringBuilder _buildString { get; set; }
        // rules: give a hand of cards, under 21 / over 21 / == 21

        // If the dealer busts and the player doesn't, the player wins.
        // If the player busts, the dealer wins.
        // If the player and the dealer both don't bust, whoever is closest to 21 wins.
        
        // constructor, run once to initialize
        public Game(Player playerOne, Player dealer)
        {
            _deck = new Deck();
            _playerOne = playerOne;
            _dealer =  dealer;
            _currentPlayer = _playerOne;
        }

        public void ShuffledDeck()
        {
            var rnd = new Random();
            _deck.Cards = new List<Card>(_deck.Cards.OrderBy(item => rnd.Next()));
        }

        // If the player has blackjack, they win, unless the dealer also has blackjack, in which case the game is a tie.
        
        // [Jack, Queen, King, 5, 4 ....]

        public void DealTwoCardsToPlayer()
        {
            var firstTwoCards = _deck.Cards.Take(2).ToList();
            for ( int i = 0; i < 2 ; i ++)
            {
                _deck.Cards.RemoveAt(i);
            }
            _playerOne.PlayersHand.Cards.AddRange(firstTwoCards);
            _dealer.PlayersHand.Cards.AddRange(firstTwoCards);
        }
        
        public void HitOneCardToPlayer()
        {
            var newCard = _deck.Cards[0];
            _deck.Cards.RemoveAt(0);
            _currentPlayer.PlayersHand.Cards.Add(newCard);
        }

        public Deck GetDeck()
        {
            return _deck;
        }

        public int GetPlayersCurrentPoints(Hand playersCards)
        {
            // calculate ace as 11
            var totalPoints =playersCards.Cards.Sum(item => item.Points);
            var numberOfAceExist = playersCards.Cards.Count(item => item.Value == EValue.Ace);
            // calculate ace as 1

            var cardsWithoutAces = playersCards.Cards.Where(item => item.Value != EValue.Ace);
            var pointsWithoutAce = cardsWithoutAces.Sum(item => item.Points);

            
            // TODO: if it is less than 10, we add 11, if > 10, we add 1 for ACE
            if (numberOfAceExist > 0)
            {
                var points = pointsWithoutAce;
                for (int i = 0; i < numberOfAceExist; i++)
                {
                    var isLessThan21 = points + 11 <= 21;
                    
                    points = isLessThan21 ? points + 11 : points + 1;
                }
                return points;
            }
            return totalPoints;
        }

        public void takeTurns(Player player)
        {
            var playersCurrentPoints = GetPlayersCurrentPoints(player.PlayersHand);
            var points = _buildString.CurrentPoints(playersCurrentPoints);
            Console.WriteLine(points);

            var cards = _buildString.DisplayCards(player.PlayersHand.Cards);
            Console.WriteLine(cards);

            var x = _buildString.ChooseHitOrStay();
            Console.WriteLine(x);

            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                {
                    HitOneCardToPlayer();
                    break;
                }

                case "0":
                {
                    break;
                }
            }
        }

        // public Boolean isPlayerBust(List<Card> playersHand)
        // {
        //     return playersHand.Sum(item => item.Points) > 21;
        // }
        //
        
    }
}
