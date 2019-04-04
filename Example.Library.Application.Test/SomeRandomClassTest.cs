using System;
using Xunit;

namespace Example.Library.Application.Test
{
    public class SomeRandomClassTest
    {
        private readonly SomeRandomClass _testInstance;

        public SomeRandomClassTest()
        {
            _testInstance = new SomeRandomClass();
        }


        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void GiveMeReturnsBoolean(bool value)
        {
            var actual = _testInstance.GiveMe(value);
            Assert.Equal(value, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void GiveMeReturnsInteger(int value)
        {
            var actual = _testInstance.GiveMe(value);
            Assert.Equal(value, actual);
        }

        [Theory]
        [InlineData("abcde")]
        [InlineData("What!?")]
        [InlineData("안녕!")]        
        public void GiveMeReturnsString(string value)
        {
            var actual = _testInstance.GiveMe(value);
            Assert.Equal(value, actual);
        }
        
    }
}
