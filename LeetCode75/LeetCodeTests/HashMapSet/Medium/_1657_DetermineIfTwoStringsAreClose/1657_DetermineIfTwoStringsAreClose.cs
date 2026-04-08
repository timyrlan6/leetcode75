namespace LeetCodeTests.HashMapSet.Medium._1657_DetermineIfTwoStringsAreClose
{
    //Two strings are considered close if you can obtain one from the other using the following operations:
    //- Swap any two existing characters.
    //- Transform every occurrence of one existing character into another character, and do the same with the other character.
    //You can use the operations on either string as many times as you like.
    //
    //Return true if word1 can be transformed into word2, or false otherwise.
    //
    //Example 1:
    //Input: word1 = "abc", word2 = "bca"
    //Output: true
    //Explanation: You can swap 'a' and 'b' in word1 to get "bac". Then swap 'a' and 'c' in word1 to get "bca".
    //
    //Example 2:
    //Input: word1 = "a", word2 = "aa"
    //Output: false
    //Explanation: You cannot transform "a" into "aa" because they have different lengths.
    //
    //Constraints:
    //1 <= word1.length <= 10^5
    //1 <= word2.length <= 10^5
    //word1 and word2 contain only lowercase English letters.

    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().CloseStrings("abc", "bca");
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().CloseStrings("a", "aa");
            Assert.That(result, Is.EqualTo(false));
        }
    }
}