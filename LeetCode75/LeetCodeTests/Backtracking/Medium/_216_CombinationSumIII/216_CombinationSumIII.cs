namespace LeetCodeTests.Backtracking.Medium._216_CombinationSumIII
{
    //Find all valid combinations of k numbers that sum up to n.
    //
    //Return the list of combinations in any order.
    //
    //Example 1:
    //Input: k = 3, n = 7
    //Output: [[1,2,4]]
    //
    //Example 2:
    //Input: k = 3, n = 9
    //Output: [[1,2,6],[1,3,5],[2,3,4]]
    //
    //Constraints:
    //1 <= k <= 9
    //1 <= n <= 60

    public class Solution
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().CombinationSum3(3, 7);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().CombinationSum3(3, 9);
            Assert.That(result.Count, Is.EqualTo(3));
        }
    }
}