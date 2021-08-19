using System;
using System.Collections.Generic;
using BlackjackApp;
using Xunit;
using System.Linq;
using DeepEqual.Syntax;


namespace BlackjackTests
{
    public class GameTest
    {
        [Fact]
        public void UnshuffleDeckReturnShuffledDeck()
        {
            // Arrange
            var game = new Game();
            var unshuffledDeck = game.GetDeck().Cards;
            
            // Act
            game.ShuffledDeck();
            var shuffledDeck = game.GetDeck().Cards;
            
            // Assert
            Assert.False(unshuffledDeck.IsDeepEqual(shuffledDeck));
        }
        
        [Fact]
        public void ShuffleDeckReturnTwoCardsForPlayer()
        {
            // Arrange
            var game = new Game();
            
            // Act
            game.ShuffledDeck();
            var playersCards = game.DealTwoCardsToPlayer();
            
            // Assert
            Assert.Equal(2, playersCards.Count);
        }
        
        [Fact]
        public void CalculateTotalValueFromPlayersCard()
        {
            // Arrange
            var game = new Game();
            
            // Act

            var playersCards = new List<Card> 
            { 
                new Card(EValue.Queen, ESuits.Diamonds), 
                new Card(EValue.Four, ESuits.Hearts)
            };

            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(14, result);
        }
        
        [Fact]
        public void ShouldCalculateAceAsEleven()
        {
            // Arrange
            var game = new Game();
            
            // Act
        
            var playersCards = new List<Card> 
            { 
                new Card(EValue.Queen, ESuits.Diamonds), 
                new Card(EValue.Ace, ESuits.Hearts)
            };
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(21, result);
        }
        
        [Fact]
        public void ShouldCalculateAceAsOne()
        {
            // Arrange
            var game = new Game();
            
            // Act
        
            var playersCards = new List<Card> 
            { 
                new Card(EValue.Queen, ESuits.Diamonds), 
                new Card(EValue.King, ESuits.Diamonds),
                new Card(EValue.Ace, ESuits.Hearts)
            };
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(21, result);
        }
        
        
        [Fact]
        public void GivenThreeAcesInAHand_WhenCalculatingPoints_ShouldCalculateOneOfThemAsElevenAndSubsequentAsOne()
        {
            // Arrange
            var game = new Game();
            
            // Act
        
            var playersCards = new List<Card> 
            {
                new Card(EValue.Ace, ESuits.Diamonds),
                new Card(EValue.Ace, ESuits.Hearts),
                new Card(EValue.Four, ESuits.Hearts),
                new Card(EValue.Ace, ESuits.Spades),
            };
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(17, result);
        }
        
                
        [Fact]
        public void GivenOnlyTwoAcesInAHand_WhenCalculatingPoints_ShouldCalculateOneOfThemAsElevenAndSubsequentAsOne()
        {
            // Arrange
            var game = new Game();
            
            // Act
        
            var playersCards = new List<Card> 
            {
                new Card(EValue.Ace, ESuits.Diamonds),
                new Card(EValue.Ace, ESuits.Hearts),

            };
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(12, result);
        }
        
    }
}
