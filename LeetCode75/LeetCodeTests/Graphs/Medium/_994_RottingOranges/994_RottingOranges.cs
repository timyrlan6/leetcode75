namespace LeetCodeTests.Graphs.Medium._994_RottingOranges
{
    //You are given an m x n grid where each cell can have one of three values:
    //0: empty cell
    //1: fresh orange
    //2: rotten orange
    //
    //Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.
    //
    //Return the minimum number of minutes that must elapse until no cell contains a fresh orange. If this is impossible, return -1.
    //
    //Example 1:
    //Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
    //Output: 4
    //
    //Example 2:
    //Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
    //Output: -1
    //
    //Constraints:
    //m == grid.length
    //n == grid[i].length
    //1 <= m, n <= 10
    //grid[i][j] is 0, 1, or 2.

    public class Solution
    {
        public int OrangesRotting(int[][] grid)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().OrangesRotting(new[] { new[] { 2, 1, 1 }, new[] { 1, 1, 0 }, new[] { 0, 1, 1 } });
            Assert.That(result, Is.EqualTo(4));
        }
    }
}