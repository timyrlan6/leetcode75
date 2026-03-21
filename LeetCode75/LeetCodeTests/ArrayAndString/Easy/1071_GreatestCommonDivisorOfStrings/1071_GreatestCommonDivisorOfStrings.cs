namespace LeetCodeTests.ArrayAndString.Easy._1071_GreatestCommonDivisorOfStrings
{
	//For two strings str1 and str2, we say "str2 divides str1" if and only if str1 = str2 + str2 + ... + str2.
//Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
//
//Example 1:
//Input: str1 = "ABCABC", str2 = "ABC"
//Output: "ABC"
//
//Example 2:
//Input: str1 = "ABABAB", str2 = "ABAB"
//Output: "AB"
//
//Example 3:
//Input: str1 = "LEET", str2 = "CODE"
//Output: ""
//
//Constraints:
//1 <= str1.length, str2.length <= 1000
//str1 and str2 consist of uppercase English letters.

	public class Solution
	{
		public string GcdOfStrings(string str1, string str2)
		{
			return default;
		}
	}

	public class Tests
	{
		[Test]
		public void Test1()
		{
			var result = new Solution().GcdOfStrings("ABCABC", "ABC");
			Assert.That(result, Is.EqualTo("ABC"));
		}

		[Test]
		public void Test2()
		{
			var result = new Solution().GcdOfStrings("ABABAB", "ABAB");
			Assert.That(result, Is.EqualTo("AB"));
		}

		[Test]
		public void Test3()
		{
			var result = new Solution().GcdOfStrings("LEET", "CODE");
			Assert.That(result, Is.EqualTo(""));
		}
	}
}