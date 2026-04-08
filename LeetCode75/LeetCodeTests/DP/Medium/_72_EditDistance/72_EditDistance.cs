namespace LeetCodeTests.DP.Medium._72_EditDistance
{
    //Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
    //
    //You have three operations: insert a character, delete a character, or replace a character.
    //
    //Example 1:
    //Input: word1 = "horse", word2 = "ros"
    //Output: 3
    //Explanation: horse -> ros (replace 'h' with 'r', delete 'e', delete 'e')
    //
    //Example 2:
    //Input: word1 = "intention", word2 = "execution"
    //Output: 5
    //
    //Constraints:
    //0 <= word1.length, word2.length <= 100
    //word1 and word2 consist of lowercase English letters.

    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MinDistance("horse", "ros");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MinDistance("intention", "execution");
            Assert.That(result, Is.EqualTo(5));
        }
    }
}