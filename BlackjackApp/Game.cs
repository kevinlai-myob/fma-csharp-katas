using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace BlackjackApp
{
    public class Game
    {
        private Deck _deck;
        // rules: give a hand of cards, under 21 / over 21 / == 21

        // If the dealer busts and the player doesn't, the player wins.
        // If the player busts, the dealer wins.
        // If the player and the dealer both don't bust, whoever is closest to 21 wins.

        // playersTurn
        

        public Game()
        {
            _deck = new Deck();
        }
        
        public void ShuffledDeck()
        {
            var rnd = new Random();
            _deck.Cards = new List<Card>(_deck.Cards.OrderBy(item => rnd.Next()));
        }

        // If the player has blackjack, they win, unless the dealer also has blackjack, in which case the game is a tie.

        // public Deck IsBlackJack(Deck deck)
        // {
        //     
        // }


        public List<Card> DealTwoCardsToPlayer()
        {
            return _deck.Cards.Take(2).ToList();
        }

        public Deck GetDeck()
        {
            return _deck;
        }

        public int GetPlayersCurrentPoints(List<Card> playersCards)
        {
            // calculate ace as 11
            var totalPoints =playersCards.Sum(item => item.Points);
            var numberOfAceExist = playersCards.Count(item => item.Value == EValue.Ace);
            //
            // // calculate ace as 1
            // if (numberOfAceExist > 0)
            // {
            var cardsWithoutAces = playersCards.Where(item => item.Value != EValue.Ace);
            var pointsWithoutAce = cardsWithoutAces.Sum(item => item.Points); // 4

            if (numberOfAceExist > 0)
            {
                // 4, Ace, Ace
                var points = pointsWithoutAce;
                for (int i = 0; i < numberOfAceExist; i++)
                {
                    var isLessThan21 = points + 11 <= 21; // true
                    
                    points = isLessThan21 ? points + 11 : points + 1;
                }
                return points;
            }
            return totalPoints;

            // calculate player's card
            // this should know how to calculate ace
        }

        // public int pointsIfGreaterThan21(List<Card> playersCards)
        // {
        //     var numberOfAceExist = playersCards.Count(item => item.Value == EValue.Ace);
        //     var totalPoints =playersCards.Sum(item => item.Points);
        //     if (totalPoints > 21)
        //     {
        //         // if player 
        //         return totalPoints;
        //     }
        // }
        //
        // public int pointsIfLessThan21(List<Card> playersCards)
        // {
        //     var numberOfAceExist = playersCards.Count(item => item.Value == EValue.Ace);
        //     var totalPoints =playersCards.Sum(item => item.Points);
        //     if (totalPoints < 21)
        //     {
        //         return totalPoints;
        //     }
        // }
        
        // Try adding 1 as Ace in totalPoints first
        // if totalPoints < 21; we can add 10
        
    }
}
