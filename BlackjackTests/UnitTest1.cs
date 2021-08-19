using System;
using System.Collections.Generic;
using BlackjackApp;
using Xunit;

namespace BlackjackTests
{
    public class BlackjackShould
    {
        // Prove that we can get 52 cards
        [Fact]
        public void deckInitialiseReturn52Cards()
        {
            // Arrange
            var deckInitialise = new Deck();
            
            // Act
            var result = deckInitialise.Cards.Count;

            // Assert
            Assert.Equal(52, result);
        }
        
        // get 2 cards for player and dealer

        // get 2 cards and correct value
        [Theory]
        [InlineData(EValue.Ace,ESuits.Hearts,EValue.Four,ESuits.Hearts, 15)]
        [InlineData(EValue.Ten,ESuits.Clubs,EValue.Three,ESuits.Spades, 13)]
        public void Given2CardsReturnCorrectValue(EValue cardOneValue, ESuits cardOneSuit, EValue cardTwoValue, ESuits cardTwoSuit, int expectedTotalValue)
        {
            var cardOne = new Card(cardOneValue, cardOneSuit);
            var cardTwo = new Card(cardTwoValue, cardTwoSuit);
            var listOfCards = new List<Card>(){cardOne, cardTwo};
            var hand = new Hand(listOfCards);
            
            Assert.Equal(expectedTotalValue, hand.Value);
        }

    }
}