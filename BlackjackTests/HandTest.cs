// using System.Collections.Generic;
// using BlackjackApp;
// using Xunit;
//
// namespace BlackjackTests
// {
//     public class HandTest
//     {
//         // write test for //
//         [Theory]
//         [InlineData(EValue.Jack,ESuits.Hearts,EValue.Four,ESuits.Hearts, 14)]
//         [InlineData(EValue.Ten,ESuits.Clubs,EValue.Three,ESuits.Spades, 13)]
//         public void Given2CardsReturnCorrectValue(EValue cardOneValue, ESuits cardOneSuit, EValue cardTwoValue, ESuits cardTwoSuit, int expectedTotalValue)
//         {
//             var cardOne = new Card(cardOneValue, cardOneSuit);
//             var cardTwo = new Card(cardTwoValue, cardTwoSuit);
//             var listOfCards = new List<Card>(){cardOne, cardTwo};
//             var hand = new Hand(listOfCards);
//             
//             Assert.Equal(expectedTotalValue, hand.Value);
//         }
//         // write test for ace (1/11)
//         // 
//         [Theory]
//         [InlineData(EValue.Ace,ESuits.Hearts,EValue.Four,ESuits.Hearts, 15)]
//         [InlineData(EValue.Ace,ESuits.Clubs,EValue.Three,ESuits.Spades, 13)]
//         public void Given2CardsReturnCorrectValue(EValue cardOneValue, ESuits cardOneSuit, EValue cardTwoValue, ESuits cardTwoSuit, int expectedTotalValue)
//         {
//             var cardOne = new Card(cardOneValue, cardOneSuit);
//             var cardTwo = new Card(cardTwoValue, cardTwoSuit);
//             var listOfCards = new List<Card>(){cardOne, cardTwo};
//             var hand = new Hand(listOfCards);
//             
//             Assert.Equal(expectedTotalValue, hand.Value);
//         }
//     }
// }