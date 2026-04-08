namespace LeetCodeTests.Stack.Medium._2390_RemovingStarsFromAString
{
    //You are given a string s that contains '*' and lowercase English characters.
    //
    //A star operation removes the character preceding the '*', as well as the '*' itself.
    //
    //Return the string after applying all star operations.
    //
    //Example 1:
    //Input: s = "abc*d*e"
    //Output: "abd"
    //Explanation: The operation is performed twice: remove 'c' and 'd' from "abc*d*e" -> "ab*e" -> "abd".
    //
    //Example 2:
    //Input: s = "a*v*"
    //Output: ""
    //Explanation: "a*v*" -> "a*" -> "".
    //
    //Constraints:
    //1 <= s.length <= 10^5
    //s contains lowercase English letters and '*'.

    public class Solution
    {
        public string RemoveStars(string s)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().RemoveStars("abc*d*e");
            Assert.That(result, Is.EqualTo("abd"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().RemoveStars("a*v*");
            Assert.That(result, Is.EqualTo(""));
        }
    }
}