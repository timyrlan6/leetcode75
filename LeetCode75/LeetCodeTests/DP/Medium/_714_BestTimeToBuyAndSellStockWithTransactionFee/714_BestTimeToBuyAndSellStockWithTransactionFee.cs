namespace LeetCodeTests.DP.Medium._714_BestTimeToBuyAndSellStockWithTransactionFee
{
    //You are given an array prices where prices[i] is the price of a given stock on the ith day, and an integer fee representing a transaction fee.
    //
    //Return the maximum profit you can achieve.
    //
    //Example 1:
    //Input: prices = [1,3,2,8,4,9], fee = 2
    //Output: 8
    //Explanation: Buy on day 2 (price = 2) and sell on day 5 (price = 9), profit = 9 - 2 - 2 = 5. Then buy on day 6 (price = 4) and sell on day 7 (price = 9), profit = 9 - 4 - 2 = 3. Total = 8.
    //
    //Constraints:
    //1 <= prices.length <= 5 * 10^4
    //1 <= prices[i] < 10^5
    //0 <= fee <= 10^4

    public class Solution
    {
        public int MaxProfit(int[] prices, int fee)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MaxProfit([1, 3, 2, 8, 4, 9], 2);
            Assert.That(result, Is.EqualTo(8));
        }
    }
}