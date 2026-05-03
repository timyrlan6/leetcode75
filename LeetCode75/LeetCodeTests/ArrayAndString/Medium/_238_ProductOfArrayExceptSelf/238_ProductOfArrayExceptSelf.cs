namespace LeetCodeTests.ArrayAndString.Medium._238_ProductOfArrayExceptSelf
{
	//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
	//
	//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
	//
	//You must write an algorithm that runs in O(n) time and without using the division operation.
	//
	//Example 1:
	//Input: nums = [1,2,3,4]
	//Output: [24,12,8,6]
	//
	//Example 2:
	//Input: nums = [-1,1,0,-3,3]
	//Output: [0,0,9,0,0]
	//
	//Constraints:
	//2 <= nums.length <= 10^5
	//-30 <= nums[i] <= 30
	//The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.

	public class Solution
	{
		public int[] ProductExceptSelf(int[] nums)
		{
			var arr = new int[nums.Length][];
			var product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
				arr[i] = new int[2] {product,1};
				product *= nums[i];
            }

			product = 1;

            for (int i = nums.Length-1; i >=0; i--)
            {
				arr[i][1] = product;
				product *= nums[i];
            }

			

            return arr.Select(c => c[0] * c[1]).ToArray();
		}
	}

	public class Tests
	{
		[Test]
		public void Test1()
		{
			var result = new Solution().ProductExceptSelf([1, 2, 3, 4]);
			Assert.That(result, Is.EqualTo(new[] { 24, 12, 8, 6 }));
		}

		[Test]
		public void Test2()
		{
			var result = new Solution().ProductExceptSelf([-1, 1, 0, -3, 3]);
			Assert.That(result, Is.EqualTo(new[] { 0, 0, 9, 0, 0 }));
		}
	}
}