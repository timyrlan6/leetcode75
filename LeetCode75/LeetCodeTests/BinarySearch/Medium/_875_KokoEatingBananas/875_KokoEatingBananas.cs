namespace LeetCodeTests.BinarySearch.Medium._875_KokoEatingBananas
{
    //Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas.
    //
    //Koko can decide how many bananas to eat each hour. She eats at a speed of k bananas per hour.
    //
    //If Koko finishes eating all the bananas in a pile within an hour, she eats the next pile.
    //
    //Return the minimum integer k such that Koko can eat all bananas within h hours.
    //
    //Example 1:
    //Input: piles = [3,6,7,11], h = 8
    //Output: 4
    //
    //Example 2:
    //Input: piles = [30,11,23,4,20], h = 5
    //Output: 30
    //
    //Constraints:
    //1 <= piles.length <= 10^4
    //1 <= piles[i] <= 10^9
    //1 <= h <= piles.length * piles[i]

    public class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MinEatingSpeed([3, 6, 7, 11], 8);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MinEatingSpeed([30, 11, 23, 4, 20], 5);
            Assert.That(result, Is.EqualTo(30));
        }
    }
}