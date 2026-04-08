namespace LeetCodeTests.TwoPointers.Easy._392_IsSubsequence
{
    //Given two strings s and t, return true if s is a subsequence of t.
    //
    //A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.
    //
    //For example, "ace" is a subsequence of "abcde" while "aec" is not.
    //
    //Example 1:
    //Input: s = "abc", t = "ahbgdc"
    //Output: true
    //
    //Example 2:
    //Input: s = "axc", t = "ahbgdc"
    //Output: false
    //
    //Constraints:
    //0 <= s.length <= 100
    //0 <= t.length <= 10^4
    //s and t consist only of lowercase English letters.

    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().IsSubsequence("abc", "ahbgdc");
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().IsSubsequence("axc", "ahbgdc");
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().IsSubsequence("", "ahbgdc");
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test4()
        {
            var result = new Solution().IsSubsequence("abc", "");
            Assert.That(result, Is.EqualTo(false));
        }
    }
}
