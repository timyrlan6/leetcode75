namespace LeetCodeTests.ArrayAndString.Easy._1768_MergeStringsAlternately
{
	//You are given two strings word1 and word2.Merge the strings by adding letters in alternating order, starting with word1.If a string is longer than the other, append the additional letters onto the end of the merged string.
	//Return the merged string.
	//
	//Example 1:
	//Input: word1 = "abc", word2 = "pqr"
	//Output: "apbqcr"
	//
	//Example 2:
	//Input: word1 = "ab", word2 = "pqrs"
	//Output: "apbqrs"
	//
	//Example 3:
	//Input: word1 = "abcd", word2 = "pq"
	//Output: "apbqcd"
	//
	//Constraints:
	//1 <= word1.length, word2.length <= 100
	//word1 and word2 consist of lowercase English letters.

	public class Solution
	{
		public string MergeAlternately(string word1, string word2)
		{
			return default;
		}
	}

	public class Tests
	{
		[Test]
		public void Test1()
		{
			var result = new Solution().MergeAlternately("abc", "pqr");
			Assert.That(result, Is.EqualTo("apbqcr"));
		}

		[Test]
		public void Test2()
		{
			var result = new Solution().MergeAlternately("ab", "pqrs");
			Assert.That(result, Is.EqualTo("apbqrs"));
		}

		[Test]
		public void Test3()
		{
			var result = new Solution().MergeAlternately("abcd", "pq");
			Assert.That(result, Is.EqualTo("apbqcd"));
		}
	}
}