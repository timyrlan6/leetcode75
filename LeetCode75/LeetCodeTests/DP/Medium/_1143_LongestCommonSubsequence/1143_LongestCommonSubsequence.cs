namespace LeetCodeTests.DP.Medium._1143_LongestCommonSubsequence
{
    //Given two strings text1 and text2, return the length of their longest common subsequence.
    //
    //A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.
    //
    //Example 1:
    //Input: text1 = "abcde", text2 = "ace"
    //Output: 3
    //Explanation: "ace" is the longest common subsequence.
    //
    //Example 2:
    //Input: text1 = "abc", text2 = "abc"
    //Output: 3
    //
    //Constraints:
    //1 <= text1.length, text2.length <= 1000
    //text1 and text2 consist of only lowercase English characters.

    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().LongestCommonSubsequence("abcde", "ace");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().LongestCommonSubsequence("abc", "abc");
            Assert.That(result, Is.EqualTo(3));
        }
    }
}