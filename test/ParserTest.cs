using NUnit.Framework;

namespace LastPass.Test
{
    [TestFixture]
    class ParserTest
    {
        [Test]
        public void Parser_doesnt_throw()
        {
            new Parser(new Blob(TestData.Blob, new byte[] {}));
        }
    }
}