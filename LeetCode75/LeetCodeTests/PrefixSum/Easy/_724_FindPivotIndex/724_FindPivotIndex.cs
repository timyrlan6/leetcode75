namespace LeetCodeTests.PrefixSum.Easy._724_FindPivotIndex
{
    //Given an array of integers nums, calculate the pivot index of this array.
    //
    //The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the right of the index.
    //
    //If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.
    //
    //Return the leftmost pivot index. If no such index exists, return -1.
    //
    //Example 1:
    //Input: nums = [1,7,3,6,5,6]
    //Output: 3
    //Explanation:
    //The pivot index is 3.
    //Left sum: nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
    //Right sum: nums[4] + nums[5] = 5 + 6 = 11
    //
    //Example 2:
    //Input: nums = [2,1]
    //Output: -1
    //Explanation:
    //There is no index that satisfies the conditions.
    //
    //Example 3:
    //Input: nums = [1]
    //Output: 0
    //Explanation:
    //The left sum is 0 (no elements to the left), and the right sum is also 0.
    //
    //Constraints:
    //1 <= nums.length <= 10^4
    //-1000 <= nums[i] <= 1000

    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().PivotIndex([1, 7, 3, 6, 5, 6]);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().PivotIndex([2, 1]);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().PivotIndex([1]);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}