namespace RomanNumerals
{
    using System.Collections.Generic;
    using System.Linq;

    public static class RomanNumeralConverter
    {
        private static readonly SortedList<int, char> RomanNumeralSymbolMeanings = new SortedList<int, char>
        {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' },
        };

        public static string Convert(int numberToConvert)
        {
            var convertedNumeral = string.Empty;

            foreach (var unit in RomanNumeralSymbolMeanings.Keys.Reverse())
            {
                var countOf = numberToConvert / unit;
                var remainder = numberToConvert % unit;
                var nextHighestUnit = RomanNumeralSymbolMeanings.Keys.IndexOf(unit) + 1;
                var nextLowestUnit = RomanNumeralSymbolMeanings.Keys.IndexOf(unit) - 1;

                if (countOf == 4)
                {
                    convertedNumeral =
                        $"{RomanNumeralSymbolMeanings[unit]}{RomanNumeralSymbolMeanings.Values[nextHighestUnit]}";
                    numberToConvert = remainder;
                }
                else if (countOf == 0 && remainder == 4)
                {
                    convertedNumeral =
                        $"{RomanNumeralSymbolMeanings.Values[nextLowestUnit]}{RomanNumeralSymbolMeanings.Values[nextHighestUnit]}";
                    numberToConvert = 0;
                }
                else if (countOf > 0 && countOf < 4)
                {
                    convertedNumeral = convertedNumeral + new string(
                                           RomanNumeralSymbolMeanings[unit],
                                           countOf);

                    numberToConvert = remainder;
                }
            }

            return convertedNumeral;
        }
    }
}