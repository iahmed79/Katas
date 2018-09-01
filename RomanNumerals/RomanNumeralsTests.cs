namespace RomanNumerals
{
    using NUnit.Framework;

    [TestFixture]
    public class RomanNumeralsTests
    {
        //[TestCase(1, "I")]
        //[TestCase(2, "II")]
        //[TestCase(3, "III")]
        [TestCase(4, "IV")]
        //[TestCase(5, "V")]
        //[TestCase(6, "VI")]
        //[TestCase(7, "VII")]
        //[TestCase(8, "VIII")]
        //[TestCase(9, "IX")]
        //[TestCase(525, "DXXV")]
        //[TestCase(727, "DCCXXVII")]
        //[TestCase(3322, "MMMCCCXXII")]
        public void GivenAnArabicNumberWhenConvertThenReturnRomanNumeral(
            int numberToConvert,
            string expectedRomanNumeral)
        {
            var result = RomanNumeralConverter.Convert(numberToConvert);

            Assert.That(result, Is.EqualTo(expectedRomanNumeral));
        }
    }
}
