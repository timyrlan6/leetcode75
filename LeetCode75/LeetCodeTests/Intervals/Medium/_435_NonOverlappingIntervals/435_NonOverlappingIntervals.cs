namespace LeetCodeTests.Intervals.Medium._435_NonOverlappingIntervals
{
    //Given an array of intervals intervals where intervals[i] = [starti, endi], return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.
    //
    //Example 1:
    //Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
    //Output: 1
    //Explanation: Remove [1,3] to make the rest non-overlapping.
    //
    //Example 2:
    //Input: intervals = [[1,2],[1,2],[1,2]]
    //Output: 2
    //Explanation: Remove [1,2] twice.
    //
    //Constraints:
    //1 <= intervals.length <= 10^5
    //intervals[i].length == 2
    //-10^4 <= starti < endi <= 10^4

    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().EraseOverlapIntervals(new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 3 } });
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().EraseOverlapIntervals(new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 } });
            Assert.That(result, Is.EqualTo(2));
        }
    }
}