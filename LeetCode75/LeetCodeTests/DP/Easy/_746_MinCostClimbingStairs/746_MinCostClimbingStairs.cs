namespace LeetCodeTests.DP.Easy._746_MinCostClimbingStairs
{
    //You are given an integer array cost where cost[i] is the cost of ith step on a staircase.
    //
    //You can start at index 0 or index 1.
    //
    //Return the minimum cost to reach the top of the floor (index len(cost)).
    //
    //Example 1:
    //Input: cost = [10,15,20]
    //Output: 15
    //Explanation: Start at index 1, pay 15, and step on index 2 with cost 20. Total = 15.
    //
    //Example 2:
    //Input: cost = [1,100,1,1,1,100,1,1,100,1]
    //Output: 6
    //Explanation: Path: 0 -> 2 -> 4 -> 6 -> 8 -> 10 with cost 1+1+1+1+1+1 = 6.
    //
    //Constraints:
    //2 <= cost.length <= 1000
    //0 <= cost[i] <= 999

    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MinCostClimbingStairs([10, 15, 20]);
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MinCostClimbingStairs([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]);
            Assert.That(result, Is.EqualTo(6));
        }
    }
}