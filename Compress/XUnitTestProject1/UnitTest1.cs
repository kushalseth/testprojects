using System;
using Xunit;
using Compress;


namespace XUnitTestProject1
{

    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            string expected = "A3B2C3D1A2F1";

            Compress.Compress compress = new Compress.Compress();

            string actual = await compress.GetCompressedString("AAABBCCCDAAF");

            Assert.Equal(expected, actual);
        }
    }
}
