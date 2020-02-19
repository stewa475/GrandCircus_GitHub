using System;
using Xunit;
using PrimeNum;

namespace LAB_4._3_PrimeNumbers
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        public void PrimeNumberTest(int n, int expected)
        {
            int result = PrimeNumbers.GetPrime(n);
            Assert.Equal(expected, result);
        }
    }
}
