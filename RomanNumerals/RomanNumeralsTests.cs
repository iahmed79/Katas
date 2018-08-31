namespace RomanNumerals
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(1, "I")]
        [TestCase(1, "II")]
        [TestCase(1, "III")]
        [TestCase(1, "IV")]
        [TestCase(1, "V")]
        [TestCase(1, "VI")]
        [TestCase(1, "VII")]
        [TestCase(1, "VIII")]
        [TestCase(1, "IX")]
        [TestCase(1, "X")]
        public void GivenArabicNumberWhenConvertThenReturnRomanNumerals(int arabicNumberToConvert, string expectedRomanNumerals)
        {
            var convertedNumber = RomanNumeralsConverter.Convert(arabicNumberToConvert);
            Assert.That(convertedNumber, Is.EqualTo(expectedRomanNumerals));
        }
    }

    public class RomanNumeralsConverter
    {
        private SortedList<int, char> romanNumeralDigits = new SortedList<int, char>
            {
                { 1, 'I' },
                { 5, 'V' },
                { 10, 'X' },
                { 50, 'L' },
                { 100, 'C' },
                { 500, 'D' },
                { 1000, 'M' }
            };

        public static string Convert(int arabicNumberToConvert)
        {

            return "I";
        }
    }
}
