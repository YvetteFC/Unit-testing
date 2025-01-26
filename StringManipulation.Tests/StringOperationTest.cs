using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            //Arrange
            var stringOperations = new StringOperations();

            //Act
            var result = stringOperations.ConcatenateStrings("Hello", "Platzi");

            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            var stringOperations = new StringOperations();

            var result = stringOperations.IsPalindrome("radar");

            Assert.True(result,"sí");
        }

        [Fact]
        public void IsPalindrome_False()
        {
            var stringOperations = new StringOperations();

            var result = stringOperations.IsPalindrome("palíndromo");

            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            var stringOperations = new StringOperations();
            var result = stringOperations.RemoveWhitespace("t e x t o");
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("texto", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            //Arrange
            var stringOperations = new StringOperations();

            //Act
            var result = stringOperations.QuantintyInWords("gato", 10);

            //Assert
            Assert.StartsWith("diez", result);
            Assert.Contains("gato", result);
              
        }
    }
}
