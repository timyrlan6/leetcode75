namespace LeetCodeTests.DP.Medium._790_DominoAndTrominoTiling
{
    //We have two types of tiles: a 2x1 domino, and two 2x1 L-tromino (rotations allowed).
    //
    //Given n, return the number of ways to tile a 2 x n board.
    //
    //Example 1:
    //Input: n = 3
    //Output: 5
    //
    //Constraints:
    //1 <= n <= 1000

    public class Solution
    {
        public int NumTilings(int n)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().NumTilings(3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().NumTilings(1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}