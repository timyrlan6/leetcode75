namespace LeetCodeTests.SlidingWindow.Medium._1456_MaximumNumberOfVowelsInASubstringOfGivenLength
{
    //Given a string s and an integer k.
    //
    //Return the maximum number of vowel letters in any substring of s with length k.
    //
    //Vowels are 'a', 'e', 'i', 'o', and 'u'.
    //
    //Example 1:
    //Input: s = "abciiidef", k = 3
    //Output: 3
    //Explanation: The substring "iii" contains 3 vowel letters.
    //
    //Example 2:
    //Input: s = "aeiou", k = 2
    //Output: 2
    //Explanation: Any substring of length 2 contains 2 vowels.
    //
    //Example 3:
    //Input: s = "leetcode", k = 3
    //Output: 2
    //Explanation: "lee", "eet", "eto" contain 2 vowels.
    //
    //Constraints:
    //1 <= s.length <= 10^5
    //1 <= k <= s.length

    public class Solution
    {
        public int MaxVowels(string s, int k)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MaxVowels("abciiidef", 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MaxVowels("aeiou", 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().MaxVowels("leetcode", 3);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}