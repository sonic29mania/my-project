using Xunit;
using FractionCalculator; // Додаємо простір імен основного проекту

namespace FractionCalculator.Tests
{
    public class FractionTests
    {
        [Fact]
        public void AdditionTest()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 3);
            var result = a + b;
            Assert.Equal("5/6", result.ToString());
        }

        [Fact]
        public void SubtractionTest()
        {
            var a = new Fraction(3, 4);
            var b = new Fraction(1, 4);
            var result = a - b;
            Assert.Equal("1/2", result.ToString());
        }

        [Fact]
        public void MultiplicationTest()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(3, 4);
            var result = a * b;
            Assert.Equal("1/2", result.ToString());
        }

        [Fact]
        public void DivisionTest()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(3, 4);
            var result = a / b;
            Assert.Equal("8/9", result.ToString());
        }

        [Fact]
        public void DenominatorCannotBeZero()
        {
            Assert.Throws<ArgumentException>(() => new Fraction(1, 0));
        }

        [Fact]
        public void DivisionByZeroThrowsException()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(0, 1);
            Assert.Throws<DivideByZeroException>(() => a / b);
        }
    }
}