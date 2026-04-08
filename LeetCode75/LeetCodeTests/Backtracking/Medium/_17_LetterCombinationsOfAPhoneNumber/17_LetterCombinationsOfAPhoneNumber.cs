namespace LeetCodeTests.Backtracking.Medium._17_LetterCombinationsOfAPhoneNumber
{
    //Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
    //
    //Return the answer in any order.
    //
    //Example 1:
    //Input: digits = "23"
    //Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
    //
    //Example 2:
    //Input: digits = ""
    //Output: []
    //
    //Constraints:
    //0 <= digits.length <= 4
    //digits[i] is a digit from '2' to '9'.

    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().LetterCombinations("23");
            Assert.That(result, Is.EquivalentTo(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().LetterCombinations("");
            Assert.That(result, Is.Empty);
        }
    }
}