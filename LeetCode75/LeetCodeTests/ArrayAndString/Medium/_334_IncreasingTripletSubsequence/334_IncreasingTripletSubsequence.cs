namespace LeetCodeTests.ArrayAndString.Medium._334_IncreasingTripletSubsequence
{
	//Given an integer array nums, return true if there exists a triple of indices (i, j, k)
	//such that i < j < k and nums[i] < nums[j] < nums[k].
	//
	//Example 1:
	//Input: nums = [1,2,3,4,5]
	//Output: true
	//
	//Example 2:
	//Input: nums = [5,4,3,2,1]
	//Output: false

	public class Solution
	{
		public bool IncreasingTriplet(int[] nums)
		{
            if (nums.Length<3) return false;
            int a = int.MaxValue;
			int b = int.MaxValue;
			int c = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < a)
                {
                    a = nums[i];
                }
                else if (nums[i] < b)
                {
                    b = nums[i];
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
	}

	public class Tests
	{
		[Test]
		public void Test1()
		{
			var result = new Solution().IncreasingTriplet(new[] { 1, 2, 3, 4, 5 });
			Assert.That(result, Is.EqualTo(true));
		}

		[Test]
		public void Test2()
		{
			var result = new Solution().IncreasingTriplet(new[] { 5, 4, 3, 2, 1 });
			Assert.That(result, Is.EqualTo(false));
		}
	}
}