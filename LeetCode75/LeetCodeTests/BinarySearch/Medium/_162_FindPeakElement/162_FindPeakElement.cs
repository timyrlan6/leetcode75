namespace LeetCodeTests.BinarySearch.Medium._162_FindPeakElement
{
    //A peak element is an element that is strictly greater than its neighbors.
    //
    //Given a 0-indexed integer array nums, find a peak element, and return its index.
    //
    //If there are multiple peaks, return the index of any one.
    //
    //Example 1:
    //Input: nums = [1,2,3,1]
    //Output: 2
    //Explanation: 3 is a peak element.
    //
    //Example 2:
    //Input: nums = [1,2,1,3,5,6,4]
    //Output: 5
    //Explanation: 6 is a peak element.
    //
    //Constraints:
    //1 <= nums.length <= 1000
    //-2^31 <= nums[i] <= 2^31 - 1
    //nums[i] != nums[i+1] for all valid i.

    public class Solution
    {
        public int FindPeakElement(int[] nums)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().FindPeakElement([1, 2, 3, 1]);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().FindPeakElement([1, 2, 1, 3, 5, 6, 4]);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}