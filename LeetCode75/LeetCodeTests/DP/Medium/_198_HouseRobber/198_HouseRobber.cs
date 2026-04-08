namespace LeetCodeTests.DP.Medium._198_HouseRobber
{
    //You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed.
    //
    //The only constraint stopping you from robbing each of them is that adjacent houses have security systems connected, so if you rob two adjacent houses, the automatic police will be alerted.
    //
    //Given an integer array nums representing the amount of money at each house, return the maximum amount of money you can rob without alerting the police.
    //
    //Example 1:
    //Input: nums = [1,2,3,1]
    //Output: 4
    //Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3). Total = 1 + 3 = 4.
    //
    //Example 2:
    //Input: nums = [2,7,9,3,1]
    //Output: 12
    //Explanation: Rob house 1 (money = 2), rob the house 3 (money = 9) and rob the house 5 (money = 1). Total = 2 + 9 + 1 = 12.
    //
    //Constraints:
    //1 <= nums.length <= 100
    //0 <= nums[i] <= 400

    public class Solution
    {
        public int Rob(int[] nums)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().Rob([1, 2, 3, 1]);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().Rob([2, 7, 9, 3, 1]);
            Assert.That(result, Is.EqualTo(12));
        }
    }
}