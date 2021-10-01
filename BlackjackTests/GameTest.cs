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
            var game = new Game(new Player(), new Player());
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
            var game = new Game(new Player(), new Player());
            
            // Act
            game.ShuffledDeck();
            game.DealTwoCardsToPlayer();
            var playersCards = game._currentPlayer.PlayersHand;
            
            // Assert
            Assert.Equal(2, playersCards.Cards.Count);
        }
        
        [Fact]
        public void CalculateTotalValueFromPlayersCard()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            
            // Act

            var playersCards = new Hand(new List<Card>()
            { 
                new Card(EValue.Queen, ESuits.Diamonds), 
                new Card(EValue.Four, ESuits.Hearts)
            });

            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(14, result);
        }
        
        [Fact]
        public void ShouldCalculateAceAsEleven()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            
            // Act
        
            var playersCards = new Hand(new List<Card>()
            { 
                new Card(EValue.Queen, ESuits.Diamonds), 
                new Card(EValue.Ace, ESuits.Hearts)
            });
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(21, result);
        }
        
        [Fact]
        public void ShouldCalculateAceAsOne()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            
            // Act
        
            var playersCards = new Hand(new List<Card>()
            { 
                new Card(EValue.Queen, ESuits.Diamonds), 
                new Card(EValue.King, ESuits.Diamonds),
                new Card(EValue.Ace, ESuits.Hearts)
            });
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(21, result);
        }
        
        
        [Fact]
        public void GivenThreeAcesInAHand_WhenCalculatingPoints_ShouldCalculateOneOfThemAsElevenAndSubsequentAsOne()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            
            // Act
        
            var playersCards = new Hand(new List<Card>()
            {
                new Card(EValue.Ace, ESuits.Diamonds),
                new Card(EValue.Ace, ESuits.Hearts),
                new Card(EValue.Four, ESuits.Hearts),
                new Card(EValue.Ace, ESuits.Spades),
            });
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(17, result);
        }
        
                
        [Fact]
        public void GivenOnlyTwoAcesInAHand_WhenCalculatingPoints_ShouldCalculateOneOfThemAsElevenAndSubsequentAsOne()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            
            // Act

            var playersCards = new Hand(new List<Card>()
            {
                new Card(EValue.Ace, ESuits.Diamonds),
                new Card(EValue.Ace, ESuits.Hearts),

            });
        
            var result = game.GetPlayersCurrentPoints(playersCards);
            
            // Assert
            Assert.Equal(12, result);
        }
        
        // TODO: Ace, Ace, King should give 12
        
        [Fact]
        public void GivenPlayerHit_PlayerGetsAdditionalOneCard()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            game.ShuffledDeck();
            game.DealTwoCardsToPlayer();
            var numberOfCardsBeforeHitCard = game._currentPlayer.PlayersHand.Cards.Count;

            // Act
            game.HitOneCardToPlayer();
            var numberOfCardsAfterHitCard = game._currentPlayer.PlayersHand.Cards.Count;

            // Assert
            Assert.NotEqual(numberOfCardsBeforeHitCard, numberOfCardsAfterHitCard);
            Assert.Equal(1, numberOfCardsAfterHitCard - numberOfCardsBeforeHitCard);
        }
        
        // Cards has been removed from shuffledDeck and Cards has been added to playersHand after given to player/ dealer
        
        [Fact]
        public void ShouldRemoveTwoCardsFromShuffleDeckAndAddToPlayersHand()
        {
            // Arrange
            var game = new Game(new Player(), new Player());
            
            // Act

            var totalNumberOfCards = game.GetDeck().Cards.Count;
            game.DealTwoCardsToPlayer();

            // Assert
            Assert.NotEqual(totalNumberOfCards, game.GetDeck().Cards.Count);
        }
        

        
    }
}
