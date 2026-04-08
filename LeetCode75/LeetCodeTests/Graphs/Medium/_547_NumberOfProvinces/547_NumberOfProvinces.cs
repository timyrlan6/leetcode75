namespace LeetCodeTests.Graphs.Medium._547_NumberOfProvinces
{
    //You are given an n x n isConnected matrix where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and 0 otherwise.
    //
    //Return the number of provinces.
    //
    //Example 1:
    //Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
    //Output: 2
    //
    //Example 2:
    //Input: isConnected = [[1,0,0],[0,1,0],[0,0,1]]
    //Output: 3
    //
    //Constraints:
    //1 <= n <= 200
    //isConnected[i][j] is 1 or 0.
    //isConnected[i][i] == 1
    //isConnected[i][j] == isConnected[j][i]

    public class Solution
    {
        public int FindCircleNum(int[][] isConnected)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().FindCircleNum(new[] { new[] { 1, 1, 0 }, new[] { 1, 1, 0 }, new[] { 0, 0, 1 } });
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().FindCircleNum(new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } });
            Assert.That(result, Is.EqualTo(3));
        }
    }
}