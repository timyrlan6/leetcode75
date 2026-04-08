namespace LeetCodeTests.HeapPriorityQueue.Medium._215_KthLargestElementInAnArray
{
    //Given an integer array nums and an integer k, return the kth largest element in the array.
    //
    //Note that it is the kth largest element in the sorted order, not the kth distinct element.
    //
    //Example 1:
    //Input: nums = [3,2,1,5,6,4], k = 2
    //Output: 5
    //
    //Example 2:
    //Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
    //Output: 4
    //
    //Constraints:
    //1 <= k <= nums.length <= 10^5
    //-10^4 <= nums[i] <= 10^4

    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().FindKthLargest([3, 2, 1, 5, 6, 4], 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().FindKthLargest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4);
            Assert.That(result, Is.EqualTo(4));
        }
    }
}