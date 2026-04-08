namespace LeetCodeTests.SlidingWindow.Medium._1493_LongestSubarrayOf1sAfterDeletingOneElement
{
    //You are given a binary array nums. You must remove exactly one element.
    //
    //Return the length of the longest subarray containing only 1's after removing exactly one element.
    //
    //Example 1:
    //Input: nums = [1,1,1]
    //Output: 2
    //Explanation: After removing one element at index 2, we get [1,1] with length 2.
    //
    //Example 2:
    //Input: nums = [1,1,0,1]
    //Output: 3
    //Explanation: After removing one element at index 2, we get [1,1,1].
    //
    //Example 3:
    //Input: nums = [0,0,0]
    //Output: 0
    //Explanation: We cannot get a subarray with only 1's after removing one element.
    //
    //Constraints:
    //1 <= nums.length <= 10^5
    //nums[i] is either 0 or 1.

    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().LongestSubarray([1, 1, 1]);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().LongestSubarray([1, 1, 0, 1]);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().LongestSubarray([0, 0, 0]);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}