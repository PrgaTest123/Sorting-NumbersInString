using System;
using System.Linq;
namespace Sorting_NumbersInString
{
    public class SortingNumbersInString
    {
        public static string Order(string words)
        {
            var wordsOrder = words.Split(' ').OrderBy(qq=>new String(qq.Where(ch=>char.IsDigit(ch)).Select(qq=>qq).ToArray())).ToArray();
            var theString = String.Join(" ", wordsOrder);
            return theString;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = "is2 Thi1s T4est 3a";
            Console.WriteLine(SortingNumbersInString.Order(test));
        }
    }
}
