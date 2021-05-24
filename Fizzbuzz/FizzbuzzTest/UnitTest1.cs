using System;
using FizzbuzzApp;
using Xunit;

namespace FizzbuzzTest
{
    public class FizzbuzzAppShould
    {
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void ReturnFizzWhenNumberIsDivisibleBy3and5(int value)
        {
            // Arrange
            var fbc = new FizzbuzzCalculator();
            
            // Act
            var result = fbc.Fizzbuzz(value);
            
            // Assert
            Assert.Equal("Fizzbuzz", result);
        }
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ReturnFizz_WhenNumberIsDivisibleBy3(int value)
        {
            // Arrange
            var fbc = new FizzbuzzCalculator();
            
            // Act
            var result = fbc.Fizzbuzz(value);
            
            // Assert
            Assert.Equal("Fizz", result);
        }
        
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void ReturnFizzWhenNumberIsDivisibleBy5(int value)
        {
            // Arrange
            var fbc = new FizzbuzzCalculator();
            
            // Act
            var result = fbc.Fizzbuzz(value);
            
            // Assert
            Assert.Equal("Buzz", result);
        }
    }
}