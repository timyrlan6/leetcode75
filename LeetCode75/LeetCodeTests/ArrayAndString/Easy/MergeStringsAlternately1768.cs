namespace LeetCodeTests.ArrayAndString.Easy
{
    //You are given two strings word1 and word2.Merge the strings by adding letters in alternating order, starting with word1.If a string is longer than the other, append the additional letters onto the end of the merged string.
    //    Return the merged string.

    //Constraints:
    //1 <= word1.length, word2.length <= 100
    //word1 and word2 consist of lowercase English letters.

    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            return word1 + word2;
        }
    }

    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            var result = new Solution().MergeAlternately("abc", "pqr");
            Assert.That(result, Is.EqualTo("apbqcr"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MergeAlternately("ab", "pqrs");
            Assert.That(result, Is.EqualTo("apbqrs"));
        }
    }
}