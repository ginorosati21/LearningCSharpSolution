using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCSharp
{
    public static class Utils
    {
        public static bool IsEven(this int x)
        {
            return x % 2 == 0;
        }

        public static int CountVowels(this string phrase)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            return phrase
                .Where(vowels.Contains).Count();
        }
    }
}
