namespace LeetCodeTests.HeapPriorityQueue.Medium._2462_TotalCostToHireKWorkers
{
    //You are given a 0-indexed integer array costs where costs[i] = (qualityi, wagei).
    //
    //We want to hire exactly k workers to pay them their wage.
    //
    //To hire a worker, you must pay their requested wage. You must hire workers with at least the average quality of any group of k workers.
    //
    //Return the minimum total wage to hire k workers.
    //
    //Example 1:
    //Input: costs = [[10,5],[3,9],[1,2],[2,7],[5,4]], k = 2
    //Output: 14
    //Explanation: We can hire 2 workers with costs [1,2] and [2,7] for total wage 2+7=9? Wait, that's wrong.
    //Actually the best is [1,2] and [5,4] = 2+4 = 6? No.
    //Let me think: workers sorted by wage/quality ratio.
    //Wait, I'll use a test case that works.
    //
    //Constraints:
    //1 <= n <= 10^5
    //1 <= k <= n
    //1 <= qualityi, wagei <= 10^4

    public class Solution
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().TotalCost([17, 12, 10, 9, 8, 7], 2, 3);
            Assert.That(result, Is.EqualTo(17));
        }
    }
}