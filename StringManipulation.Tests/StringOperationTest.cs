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
        [Fact(Skip ="Esta prueba se omite temporalmente, TICKET-001")]
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

        [Fact]
        public void GetStringLength()
        {
            var stringOperations = new StringOperations();
            var result = stringOperations.GetStringLength("Yvette");
            Assert.Equal(6, result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            //Arrange
            var stringOperations = new StringOperations();

            //Assert
            Assert.ThrowsAny<ArgumentNullException>(() =>stringOperations.GetStringLength(null));
        }

        [Fact]
        public void TruncateString()
        {
            //Arrange
            var stringOperations = new StringOperations();

            //Act
            var result = stringOperations.TruncateString("Yvette", 3);

            //Assert
            Assert.NotEmpty(result);
            Assert.NotNull(result);
            Assert.Equal("Yve", result);
        }

        [Fact]
        public void TruncateString_Exception()
        {
            //Arrange
            var stringOperations = new StringOperations();

            //Assert
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => stringOperations.TruncateString("Yvette", -3));
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("x", 10)]
        [InlineData("XVIII", 18)]

        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var stringOperations = new StringOperations();

            var result = stringOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("e sp a ci os", "espacios")]
        public void RemoveWhitespace_Theory(string texto, string expected)
        {
            var stringOperations = new StringOperations();

            var result = stringOperations.RemoveWhitespace(texto);

            Assert.Equal(expected, result);
        }

    }
}
