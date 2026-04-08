namespace LeetCodeTests.Stack.Medium._394_DecodeString
{
    //Given an encoded string, return its decoded string.
    //
    //The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is repeated exactly k times.
    //
    //Example 1:
    //Input: s = "3[a2[c]]"
    //Output: "accaccacc"
    //
    //Example 2:
    //Input: s = "3[a2[b]c]"
    //Output: "abbcabbcabbcabbcabbc"
    //
    //Constraints:
    //1 <= s.length <= 30
    //s consists of lowercase English letters, digits, and square brackets '[]'.
    //s is a valid encoding string.
    //1 <= k <= 300

    public class Solution
    {
        public string DecodeString(string s)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().DecodeString("3[a2[c]]");
            Assert.That(result, Is.EqualTo("accaccacc"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().DecodeString("3[a2[b]c]");
            Assert.That(result, Is.EqualTo("abbcabbcabbcabbcabbc"));
        }
    }
}