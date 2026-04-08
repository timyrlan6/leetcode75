namespace LeetCodeTests.BitManipulation.Easy._136_SingleNumber
{
    //Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    //
    //You must implement a solution with a linear runtime complexity and use only constant extra space.
    //
    //Example 1:
    //Input: nums = [2,2,1]
    //Output: 1
    //
    //Example 2:
    //Input: nums = [4,1,2,1,2]
    //Output: 4
    //
    //Constraints:
    //1 <= nums.length <= 3 * 10^4
    //-3 * 10^4 <= nums[i] <= 3 * 10^4

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().SingleNumber([2, 2, 1]);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().SingleNumber([4, 1, 2, 1, 2]);
            Assert.That(result, Is.EqualTo(4));
        }
    }
}