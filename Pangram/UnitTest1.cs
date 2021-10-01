using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Pangram
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void GivenASentenceIsEmptyString_ShouldReturn_False()
        {
            // Arrange
            const string input = "";
            
            // Act
            var isPangram = Pangram.IsPangram(input);
            
            // Assert
            Assert.False(isPangram);
        }
        
        [Fact]
        public void GivenASentenceIsASingleCharacter_ShouldReturn_False()
        {
            // Arrange
            const string input = "A";
            
            // Act
            var isPangram = Pangram.IsPangram(input);
            
            // Assert
            Assert.False(isPangram);
        }
        
        [Fact]
        public void GivenASentenceLengthHas26ButWithoutUsingEveryAlphabet_ShouldReturn_False()
        {
            // Arrange
            const string input = "ABBCDEFGHIJKLMNOPQRSTUWXYZ";
            
            // Act
            var isPangram = Pangram.IsPangram(input);
            
            // Assert
            Assert.False(isPangram);
        }
        
        [Fact]
        public void GivenASentenceHasEveryAlphabetsInLowerCases_ShouldReturn_True()
        {
            // Arrange
            const string input = "abcdefghijklmnopqrstuvwxyz";
            
            // Act
            var isPangram = Pangram.IsPangram(input);
            _testOutputHelper.WriteLine("--------");

            // Assert
            Assert.True(isPangram);
        }
        [Fact]
        public void GivenASentenceHasLowerCases_ShouldReturn_True()
        {
            // Arrange
            const string input = "the quick brown fox jumps over the lazy dog";
            
            // Act
            var isPangram = Pangram.IsPangram(input);
            _testOutputHelper.WriteLine("--------");

            // Assert
            Assert.True(isPangram);
        }
        
        [Fact]
        public void GivenASentenceHasUnderscores_ShouldReturn_True()
        {
            // Arrange
            const string input = "the_quick_brown_fox_jumps_over_the_lazy_dog";
            
            // Act
            var isPangram = Pangram.IsPangram(input);

            // Assert
            Assert.True(isPangram);
        }
        
        [Fact]
        public void GivenASentenceHasSpecialCharacters_ShouldReturn_True()
        {
            // Arrange
            const string input = "the$quick&brown@fox(jumps)over!the*lazy*dog";
            
            // Act
            var isPangram = Pangram.IsPangram(input);

            // Assert
            Assert.True(isPangram);
        }



    }
}