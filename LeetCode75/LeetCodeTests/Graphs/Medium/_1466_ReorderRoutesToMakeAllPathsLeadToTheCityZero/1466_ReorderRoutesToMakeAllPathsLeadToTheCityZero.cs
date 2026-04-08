namespace LeetCodeTests.Graphs.Medium._1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero
{
    //There are n cities numbered from 0 to n - 1 and n roads. Each road connects two different cities.
    //
    //All roads are currently directed from city 0 to city n-1.
    //
    //You are given array connections where connections[i] = [a, b] represents a directed road from city a to city b.
    //
    //Return the minimum number of edges to reverse to make all paths from city 0 lead to city n-1.
    //
    //Example 1:
    //Input: n = 6, connections = [[0,1],[1,3],[2,3],[4,0],[4,5]]
    //Output: 3
    //Explanation: Reverse edges: [4,0], [1,3], [2,3].
    //
    //Example 2:
    //Input: n = 5, connections = [[4,1],[1,2],[2,3],[3,1]]
    //Output: 1
    //Explanation: Reverse edge: [4,1].
    //
    //Constraints:
    //2 <= n <= 10^5
    //1 <= connections.length <= 10^5
    //connections[i].length == 2
    //0 <= a, b <= n - 1

    public class Solution
    {
        public int MinReorder(int n, int[][] connections)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MinReorder(6, new[] { new[] { 0, 1 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 4, 0 }, new[] { 4, 5 } });
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MinReorder(5, new[] { new[] { 4, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 1 } });
            Assert.That(result, Is.EqualTo(1));
        }
    }
}