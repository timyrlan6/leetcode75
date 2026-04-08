namespace LeetCodeTests.TwoPointers.Medium._1679_MaxNumberOfKSumPairs
{
    //You are given an integer array nums and an integer k. In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.
    //
    //Return the maximum number of operations you can perform on the array.
    //
    //Example 1:
    //Input: nums = [1,2,3,4], k = 5
    //Output: 2
    //Explanation: Starting with nums = [1,2,3,4]:
    //- Pick the pair (1,4) and remove them, so nums becomes [2,3].
    //- Pick the pair (2,3) and remove them, so nums becomes [].
    //No more pairs can be removed. Return 2.
    //
    //Example 2:
    //Input: nums = [3,1,3,4,3], k = 6
    //Output: 1
    //Explanation: Starting with nums = [3,1,3,4,3]:
    //- Pick the pair (3,3) and remove them, so nums becomes [1,4,3].
    //No more pairs can be removed. Return 1.
    //
    //Constraints:
    //1 <= nums.length <= 10^5
    //1 <= nums[i] <= 10^9
    //1 <= k <= 10^9

    public class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MaxOperations([1, 2, 3, 4], 5);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MaxOperations([3, 1, 3, 4, 3], 6);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}