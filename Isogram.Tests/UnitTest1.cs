using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(true, Program.isogram(""));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(true, Program.isogram("isogram"));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(false, Program.isogram("eleven"));
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(true, Program.isogram("subdermatoglyphic"));
        }
        [Fact]
        public void Test5()
        {
            Assert.Equal(true, Program.isogram("Alphabet"));
        }
        [Fact]
        public void Test6()
        {
            Assert.Equal(true, Program.isogram("thumbscrew-japingly"));
        }
        [Fact]
        public void Test7()
        {
            Assert.Equal(true, Program.isogram("six-year-old"));
        }
        [Fact]
        public void Test8()
        {
            Assert.Equal(true, Program.isogram(" "));
        }
    }
}
