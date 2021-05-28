using System;
using StringCalculatorApp;
using Xunit;

namespace StringCalculatorTest
{
    public class StringCalculatorShould
    {
        [Theory]
        [InlineData("")]
        [InlineData("0")]
        public void TakeEmptyStringReturnZero(string value)
        {
            // Arrange
            var fbc = new StringCalculator();
            
            // Act
            var result = fbc.StringCalculation(value);
            
            // Assert
            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        public void TakeSingleStringReturnNumber(string value, int sumOfOneValue)
        {
            // Arrange
            var fbc = new StringCalculator();
            
            // Act
            var result = fbc.StringCalculation(value);

            // Assert
            Assert.Equal(sumOfOneValue, result);
        }
        
        
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,5", 8)]
        public void TakeTwoStringsWithCommasReturnSumOfNumber(string values, int sumOfValues)
        {
            // Arrange
            var fbc = new StringCalculator();
            
            // Act
            var result = fbc.StringCalculation(values);

            // Assert
            Assert.Equal(sumOfValues, result);
        }
        
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("3,5,3,9", 20)]
        public void TakeXAmountOfStringsWithCommasReturnSumOfNumber(string values, int sumOfValues)
        {
            // Arrange
            var fbc = new StringCalculator();
            
            // Act
            var result = fbc.StringCalculation(values);
        
            // Assert
            Assert.Equal(sumOfValues, result);
        }
        
        [Theory]
        [InlineData("1,2\n3", 6)]
        [InlineData("3\n5\n3,9", 20)]
        public void TakeStringsWithLineBreaksAndCommasReturnSumOfNumber(string values, int sumOfValues)
        {
            // Arrange
            var fbc = new StringCalculator();
            
            // Act
            var result = fbc.StringCalculation(values);
        
            // Assert
            Assert.Equal(sumOfValues, result);
        }
        
        // [Theory]
        // [InlineData("//;\n1;2", 3)]
        // public void TakeStringsWithSingleCharacterDelimiter(string values, int sumOfValues)
        // {
        //     // Arrange
        //     var fbc = new StringCalculator();
        //     
        //     // Act
        //     var result = fbc.StringCalculation(values);
        //
        //     // Assert
        //     Assert.Equal(sumOfValues, result);
        // }

    }
}