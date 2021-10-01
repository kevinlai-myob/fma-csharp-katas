using System;
using Xunit;

namespace Abc
{
    public class BlockShould
    {
        [Theory]
        [InlineData("a")]
        [InlineData("A")]
        public void GivenALetter_ReturnTrue(string value)
        {
            // Arrange
            var blockParser = new Abc();
            
            // Act
            var result = blockParser.CanMakeWord(value);
            
            // Assert
            Assert.True(result);
        }
        
        [Theory]
        [InlineData("bark")]
        [InlineData("TREAT")]
        [InlineData("CONFUSE")]
        [InlineData("SQUAD")]
        public void GivenAWord_ReturnTrue_WhenAllLettersCanBeSpelledWithTheGivenCollectionOfBlocks(string value)
        {
            // Arrange
            var blockParser = new Abc();
            
            // Act
            var result = blockParser.CanMakeWord(value);
            // Assert
            Assert.True(result);
        }
        
        [Theory]
        [InlineData("BOOK")]
        [InlineData("COMMON")]
        public void GivenAWord_ReturnFalse_WhenAllLettersCannotBeSpelledWithTheGivenCollectionOfBlocks(string value)
        {
            // Arrange
            var blockParser = new Abc();
            
            // Act
            var result = blockParser.CanMakeWord(value);
            // Assert
            Assert.False(result);
        }
        
        
    }
}