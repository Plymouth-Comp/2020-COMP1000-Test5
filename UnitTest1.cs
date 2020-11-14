using System;
using Xunit;

namespace Exercise.Tests
{
    public class UnitTest1
    {
        private Exercise.Program prog;
        public UnitTest1()
        {
            prog = new Program();
        }
        [Fact]
        public void Test1()
        {
            Assert.False(true,"You need to update the submodule using the batch file");
        }
    }
}
