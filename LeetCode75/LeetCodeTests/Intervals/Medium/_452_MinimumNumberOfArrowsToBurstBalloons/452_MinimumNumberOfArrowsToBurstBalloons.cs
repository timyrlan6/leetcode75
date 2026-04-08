namespace LeetCodeTests.Intervals.Medium._452_MinimumNumberOfArrowsToBurstBalloons
{
    //Given an array points where points[i] = [xstart, xend], return the minimum number of arrows that must be shot to burst all balloons.
    //
    //Example 1:
    //Input: points = [[10,16],[2,8],[1,6],[7,12]]
    //Output: 2
    //Explanation: One arrow can burst [10,16] and another can burst [2,8] and [1,6].
    //
    //Constraints:
    //1 <= points.length <= 10^4
    //points[i].length == 2
    //-2^31 <= xstart < xend <= 2^31 - 1

    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().FindMinArrowShots(new[] { new[] { 10, 16 }, new[] { 2, 8 }, new[] { 1, 6 }, new[] { 7, 12 } });
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().FindMinArrowShots(new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } });
            Assert.That(result, Is.EqualTo(2));
        }
    }
}