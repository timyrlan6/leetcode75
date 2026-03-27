namespace LeetCodeTests.ArrayAndString.Medium._151_ReverseWordsInAString
{
    //Given an input string s, reverse the order of the words.
    //
    //A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
    //
    //Return a string of the words in reverse order concatenated by a single space.
    //
    //Note that s may contain leading or trailing spaces or multiple spaces between two words.
    //The returned string should only have a single space separating the words. Do not include any extra spaces.
    //
    //Example 1:
    //Input: s = "the sky is blue"
    //Output: "blue is sky the"
    //
    //Example 2:
    //Input: s = "  hello world  "
    //Output: "world hello"
    //
    //Example 3:
    //Input: s = "a good   example"
    //Output: "example good a"
    //
    //Constraints:
    //1 <= s.length <= 10^4
    //s contains English letters (upper-case and lower-case), digits, and spaces ' '.
    //There is at least one word in s.

    public class Solution
    {
        public string ReverseWords(string s) => string.Join(' ', s.Split(' ').Where(c => !string.Equals(c, String.Empty)).Reverse());
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().ReverseWords("the sky is blue");
            Assert.That(result, Is.EqualTo("blue is sky the"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().ReverseWords("  hello world  ");
            Assert.That(result, Is.EqualTo("world hello"));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().ReverseWords("a good   example");
            Assert.That(result, Is.EqualTo("example good a"));
        }
    }
}