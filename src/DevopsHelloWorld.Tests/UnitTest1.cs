using System;
using Xunit;

namespace DevopsHelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var myClass = new MyClass();
            var data = myClass.GetHelloWorld();
            Assert.Equal(data, "Hello, World!");
        }
    }
}
