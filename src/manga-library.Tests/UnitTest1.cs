using System;
using Xunit;

namespace manga_library.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        public void SumTwoNumbers(int a, int b, int result)
        {
            Assert.Equal(result, a+b);
        }
    }
}
