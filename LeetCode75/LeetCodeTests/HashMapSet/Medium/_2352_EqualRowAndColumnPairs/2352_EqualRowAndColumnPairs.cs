namespace LeetCodeTests.HashMapSet.Medium._2352_EqualRowAndColumnPairs
{
    //Given a 0-indexed n x n integer matrix, return the number of pairs (ri, cj) such that row ri and column cj are equal.
    //
    //Two rows are considered equal if they contain the same sequence of elements.
    //Two columns are considered equal if they contain the same sequence of elements.
    //
    //Example 1:
    //Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
    //Output: 1
    //Explanation: There is only one pair (0,1) - row[0] = [3,2,1] equals column[1] = [3,2,1].
    //
    //Example 2:
    //Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,4,3],[3,1,2,3]]
    //Output: 4
    //Explanation: There are 4 pairs: (0,0), (2,2), (3,3), and (1,1).
    //
    //Constraints:
    //n == grid.length == grid[i].length
    //1 <= n <= 200
    //1 <= grid[i][j] <= 10^5

    public class Solution
    {
        public int EqualPairs(int[][] grid)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().EqualPairs(new[] { new[] { 3, 2, 1 }, new[] { 1, 7, 6 }, new[] { 2, 7, 7 } });
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().EqualPairs(new[] { new[] { 3, 1, 2, 2 }, new[] { 1, 4, 4, 5 }, new[] { 2, 4, 4, 3 }, new[] { 3, 1, 2, 3 } });
            Assert.That(result, Is.EqualTo(4));
        }
    }
}