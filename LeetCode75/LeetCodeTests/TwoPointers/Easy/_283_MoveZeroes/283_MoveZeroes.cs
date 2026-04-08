namespace LeetCodeTests.TwoPointers.Easy._283_MoveZeroes
{
    //Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    //
    //Note that you must do this in-place, meaning that you cannot allocate additional space for another array and must solve this problem without making a copy of the array.
    //
    //Example 1:
    //Input: nums = [0,1,0,3,12]
    //Output: [1,3,12,0,0]
    //
    //Example 2:
    //Input: nums = [0]
    //Output: [0]
    //
    //Constraints:
    //1 <= nums.length <= 10^4
    //-2^31 <= nums[i] <= 2^31 - 1

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int writeIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[writeIndex++] = nums[i];
                }
            }

            while (writeIndex < nums.Length)
            {
                nums[writeIndex++] = 0;
            }
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var nums = new[] { 0, 1, 0, 3, 12 };
            new Solution().MoveZeroes(nums);
            Assert.That(nums, Is.EqualTo(new[] { 1, 3, 12, 0, 0 }));
        }

        [Test]
        public void Test2()
        {
            var nums = new[] { 0 };
            new Solution().MoveZeroes(nums);
            Assert.That(nums, Is.EqualTo(new[] { 0 }));
        }
    }
}