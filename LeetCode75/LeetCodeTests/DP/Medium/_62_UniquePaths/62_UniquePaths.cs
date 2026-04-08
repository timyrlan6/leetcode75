namespace LeetCodeTests.DP.Medium._62_UniquePaths
{
    //There is a robot on an m x n grid. The robot starts at the top-left corner (0, 0).
    //
    //The robot can only move either down or right at any point in time.
    //
    //How many different paths are there to reach the bottom-right corner (m-1, n-1)?
    //
    //Example 1:
    //Input: m = 3, n = 7
    //Output: 28
    //
    //Example 2:
    //Input: m = 3, n = 2
    //Output: 3
    //
    //Constraints:
    //1 <= m, n <= 100

    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().UniquePaths(3, 7);
            Assert.That(result, Is.EqualTo(28));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().UniquePaths(3, 2);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}