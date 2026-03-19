namespace LeetCodeTests.ArrayAndString.Easy
{
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
    }
}