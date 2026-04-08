namespace LeetCodeTests.BinarySearch.Easy._374_GuessNumberHigherOrLower
{
    //We are playing the Guess Game. The game is as follows:
    //
    //I pick a number from 1 to n. You guess which number I picked.
    //
    //Every time you guess a number, I will tell you whether my number is higher or lower than your guess.
    //
    //You call a pre-defined API guess(num) which returns -1, 0, or 1.
    //
    //Return the number that I picked.
    //
    //Example 1:
    //Input: n = 10, pick = 6
    //Output: 6
    //
    //Constraints:
    //1 <= n <= 2^31 - 1
    //1 <= pick <= n

    public class Solution
    {
        public int GuessNumber(int n)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().GuessNumber(10);
            Assert.That(result, Is.EqualTo(6));
        }
    }
}