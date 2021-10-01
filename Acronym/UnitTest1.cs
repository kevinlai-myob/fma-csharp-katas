using System;
using Xunit;
using Xunit.Abstractions;

namespace Acronym
{
    public class UnitTest1
    {
        [Fact]
        public void GivenEmptyString_ReturnEmptyString()
        {
            // Arrange 
            var phrase = "";

            // Act
            var result = Acronym.Abbreviate(phrase);
            
            // Assert
            Assert.Equal("", result);
        }
        
        [Fact]
        public void GivenPhraseWithOnlyOneWord_ReturnFirstLetterOfTheWord()
        {
            // Arrange 
            var phrase = "Moonbeam";

            // Act
            var result = Acronym.Abbreviate(phrase);

            // Assert
            Assert.Equal("M", result);
        }
        
        [Fact]
        public void GivenPhraseWithTwoWords_ReturnFirstLetterOfTwoWord()
        {
            // Arrange 
            var phrase = "Chain Link";

            // Act
            var result = Acronym.Abbreviate(phrase);

            // Assert
            Assert.Equal("CL", result);
        }
        
        [Fact]
        public void GivenPhraseWithLowercase_ReturnFirstLetterOfEveryWord()
        {
            // Arrange 
            var phrase = "Nano dimension Ltd";

            // Act
            var result = Acronym.Abbreviate(phrase);

            // Assert
            Assert.Equal("NDL", result);
        }
        
        [Fact]
        public void GivenPhrasesWithHyphenatedWord_ReturnHyphenatedWordIntoTwoWords()
        {
            // Arrange 
            var phrase = "Polkadot Launch: Para-chain Rollout";

            // Act
            var result = Acronym.Abbreviate(phrase);

            // Assert
            Assert.Equal("PLPCR", result);
        }
        
        [Fact]
        public void GivenPhrasesWithSpecialCharacterNearTheEndOfWord_ReturnFirstLetterOfEveryWord()
        {
            // Arrange 
            var phrase = "Polkadot's aunction";

            // Act
            var result = Acronym.Abbreviate(phrase);

            // Assert
            Assert.Equal("PA", result);
        }
    }
}