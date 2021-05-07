using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(3,4,12)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(8,2,4.0)]
        [InlineData(9, 2, 4.5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Happy()
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Happy();
           //Assert
           Assert.Equal(actual, ":)");
        }

        [Fact]
        public void Successful()
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Successful();
           //Assert
           Assert.Equal(actual, true);
        }
    }
}
