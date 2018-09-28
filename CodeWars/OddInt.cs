namespace CodeWars
{
    using System.Linq;

    public class OddInt
    {
        public static int FindIt(int[] integers)
        {
            var distinctOddNumbers = integers.Where(x => x % 2 > 0).Distinct();

            integers.Select(x => )
        }
    }
}
