namespace CodeWarsTests
{
    using CodeWars;
    using NUnit.Framework;

    [TestFixture]
    public class OddIntTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, OddInt.FindIt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}
