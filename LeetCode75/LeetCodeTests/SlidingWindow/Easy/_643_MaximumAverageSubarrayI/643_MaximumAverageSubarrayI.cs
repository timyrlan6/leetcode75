namespace LeetCodeTests.SlidingWindow.Easy._643_MaximumAverageSubarrayI
{
    //You are given an integer array nums consisting of n elements, and an integer k.
    //
    //Return the maximum average value of the k consecutive elements in the array.
    //
    //Example 1:
    //Input: nums = [1,12,-5,-6,50,3], k = 4
    //Output: 12.75000
    //Explanation: Maximum average is (12-5-6+50)/4 = 51/4 = 12.75
    //
    //Example 2:
    //Input: nums = [5], k = 1
    //Output: 5.00000
    //
    //Constraints:
    //n == nums.length
    //1 <= k <= n <= 10^5
    //-10^4 <= nums[i] <= 10^4

    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().FindMaxAverage([1, 12, -5, -6, 50, 3], 4);
            Assert.That(result, Is.EqualTo(12.75).Within(0.001));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().FindMaxAverage([5], 1);
            Assert.That(result, Is.EqualTo(5.0).Within(0.001));
        }
    }
}