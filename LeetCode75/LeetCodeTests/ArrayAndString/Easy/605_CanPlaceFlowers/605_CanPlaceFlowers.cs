namespace LeetCodeTests.ArrayAndString.Easy._605_CanPlaceFlowers
{
	//You have a long flowerbed in which some of the plots are planted, and some are not.
	//However, flowers cannot be planted in adjacent plots.
	//Given an integer array flowerbed containing 0's and 1's, and an integer n,
	//return true if n new flowers can be planted without violating the rule.
	//
	//Example 1:
	//Input: flowerbed = [1,0,0,0,1], n = 1
	//Output: true
	//
	//Example 2:
	//Input: flowerbed = [1,0,0,0,1], n = 2
	//Output: false
	//
	//Constraints:
	//1 <= flowerbed.length <= 2 * 10^4
	//flowerbed[i] is 0 or 1
	//0 <= n <= flowerbed.length

	public class Solution
	{
		public bool CanPlaceFlowers(int[] flowerbed, int n)
		{
			return default;
		}
	}

	public class Tests
	{
		[Test]
		public void Test1()
		{
			var result = new Solution().CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 1);
			Assert.That(result, Is.EqualTo(true));
		}

		[Test]
		public void Test2()
		{
			var result = new Solution().CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 2);
			Assert.That(result, Is.EqualTo(false));
		}
	}
}