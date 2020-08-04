using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeNumbers.Tests
{
    public class PrimeNumbersTests
    {
        [Fact]
        public void Test1()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(1);
            Assert.Equal(output.ToString(), IsPrime.False.ToString());
        }
        [Fact]
        public void Test2()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(6);
            Assert.Equal(output.ToString(), IsPrime.False.ToString());
        }
        [Fact]
        public void Test3()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(3);
            Assert.Equal(output.ToString(), IsPrime.True.ToString());
        }
        [Fact]
        public void Test4()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(33);
            Assert.Equal(output.ToString(), IsPrime.False.ToString());
        }
        [Fact]
        public void Test5()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(67);
            Assert.Equal(output.ToString(), IsPrime.True.ToString());
        }
        [Fact]
        public void Test6()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(17);
            Assert.Equal(output.ToString(), IsPrime.True.ToString());
        }
        [Fact]
        public void Test7()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(89);
            Assert.Equal(output.ToString(), IsPrime.True.ToString());
        }
        [Fact]
        public void Test8()
        {
            PrimeNumbers PrimNum = new PrimeNumbers();
            bool output = PrimNum.IsAPrime(64);
            Assert.Equal(output.ToString(), IsPrime.False.ToString());
        }



        public long GetPrimeTests()
        {
            long output = 0; // Automatically sets to False
            return output;
        }
    }
}
