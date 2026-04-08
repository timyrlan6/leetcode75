namespace LeetCodeTests.MonotonicStack.Medium._739_DailyTemperatures
{
    //Given an array of integers temperatures representing the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature.
    //
    //If there is no future day for which this is possible, put 0 instead.
    //
    //Example 1:
    //Input: temperatures = [73,74,75,71,69,72,76,73]
    //Output: [1,1,4,2,1,1,0,0]
    //
    //Constraints:
    //1 <= temperatures.length <= 10^5
    //30 <= temperatures[i] <= 100

    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 1, 4, 2, 1, 1, 0, 0 }));
        }
    }
}