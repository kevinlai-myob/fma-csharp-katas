using System;
using Xunit;

namespace SpaceAge
{
    public class UnitTest1
    {
        [Fact]
        public void Age_on_earth()
        {
            var sut = new SpaceAge(1000000000);
            Assert.Equal(31.69, sut.OnEarth(), precision: 2);
        }
    }
} 