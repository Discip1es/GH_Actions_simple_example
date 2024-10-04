using System;
using Xunit;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            double result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            double result = Calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            double result = Calculator.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            double result = Calculator.Divide(6, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(6, 0));
        }
    }
}
