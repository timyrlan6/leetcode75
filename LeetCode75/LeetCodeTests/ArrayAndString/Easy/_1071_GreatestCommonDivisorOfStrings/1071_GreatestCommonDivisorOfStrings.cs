namespace LeetCodeTests.ArrayAndString.Easy._1071_GreatestCommonDivisorOfStrings
{
    //For two strings str1 and str2, we say "str2 divides str1" if and only if str1 = str2 + str2 + ... + str2.
//Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
//
//Example 1:
//Input: str1 = "ABCABC", str2 = "ABC"
//Output: "ABC"
//
//Example 2:
//Input: str1 = "ABABAB", str2 = "ABAB"
//Output: "AB"
//
//Example 3:
//Input: str1 = "LEET", str2 = "CODE"
//Output: ""
//
//Constraints:
//1 <= str1.length, str2.length <= 1000
//str1 and str2 consist of uppercase English letters.

    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 == str2) return str1;
            var s1 = str1;
            var s2 = str2;
            if (str1.Length > str2.Length)
            {
                s1 = str2;
                s2 = str1;
            }

            var length = s1.Length;


            while (length > 0)
            {
                var padding = 0;
                while (padding + length <= s1.Length)
                {
                    var substr = s1.Substring(padding, length);
                    if (IsDivde(substr, s2)) return substr;
                    padding++;
                }

                length--;
            }


            return String.Empty;
        }


        private bool IsDivde(string s1, string s2)
        {
            var padding = 0;

            while (padding <= s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (padding + i >= s2.Length) return i == 0;
                    if (s2[padding + i] != s1[i]) return false;
                }

                padding += s1.Length;
            }


            return true;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().GcdOfStrings("ABCABC", "ABC");
            Assert.That(result, Is.EqualTo("ABC"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().GcdOfStrings("ABABAB", "ABAB");
            Assert.That(result, Is.EqualTo("AB"));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().GcdOfStrings("LEET", "CODE");
            Assert.That(result, Is.EqualTo(""));
        }
    }
}