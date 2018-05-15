using System;
using Xunit;

namespace dotnet_docker
{
    public class Example
    {
        [Fact]
        public void two_plus_two_is_four()
        {
            var result = 2 + 2;
            Assert.Equal(4, result);
        }
    }
}