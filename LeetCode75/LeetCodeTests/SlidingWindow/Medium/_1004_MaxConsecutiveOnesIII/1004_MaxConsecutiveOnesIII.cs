namespace LeetCodeTests.SlidingWindow.Medium._1004_MaxConsecutiveOnesIII
{
    //You are given a binary array nums. You are also given an integer k.
    //
    //You are allowed to change at most k 0's to 1's.
    //
    //Return the length of the longest subarray (contiguous subarray) containing only 1's after converting at most k zeros to ones.
    //
    //Example 1:
    //Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
    //Output: 8
    //Explanation: [1,1,1,0,0,1,1,1,1,1]
    //The bolded numbers converted: 0 -> 1, 0 -> 1.
    //Longest subarray is 8 elements long.
    //
    //Example 2:
    //Input: nums = [0,0,1,1,1,0,0,0,1,1,1,0,1,1,0,0,0,1,1,1,0,0,0,0,1,1,1,1,1,1], k = 3
    //Output: 17
    //Explanation: [0,0,1,1,1,0,0,1,1,1,1,1,1,1,0,0,0,1,1,1,0,0,0,0,1,1,1,1,1,1]
    //Converted: 0 -> 1, 0 -> 1, 0 -> 1
    //Longest subarray is 17 elements.
    //
    //Constraints:
    //1 <= nums.length <= 10^5
    //nums[i] is either 0 or 1.
    //0 <= k <= nums.length

    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().LongestOnes([0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1], 3);
            Assert.That(result, Is.EqualTo(17));
        }
    }
}