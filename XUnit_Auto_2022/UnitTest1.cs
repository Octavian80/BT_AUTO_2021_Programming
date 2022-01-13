using NUnit_Auto_2022;
using System;
using Xunit;

namespace XUnit_Auto_2022
{
    public class UnitTest1 : IDisposable

    {

        public UnitTest1()
        {
            Console.WriteLine("Setup every test");
        }

        public void Dispose()
        {
            Console.WriteLine("TearDown");
        }

        [Fact]
        public void Test1()
        {
            Console.WriteLine();
            Calculator c = new Calculator(50, 100, '-');
            Assert.Equal(-50, c.Compute());
        }
    }
}
