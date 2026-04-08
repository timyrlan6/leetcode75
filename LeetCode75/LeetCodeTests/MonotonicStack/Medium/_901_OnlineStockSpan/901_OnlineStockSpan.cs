namespace LeetCodeTests.MonotonicStack.Medium._901_OnlineStockSpan
{
    //Design an algorithm that collects daily price information for a stock and returns the span of that stock's price for the current day.
    //
    //The span is the maximum number of consecutive days (starting from today and going backwards) for which the price was less than or equal to today's price.
    //
    //Example 1:
    //Input: ["StockSpanner", "next", "next", "next", "next", "next", "next", "next"]
    //[[], [100], [80], [60], [70], [60], [75], [85]]
    //Output: [null, 1, 1, 1, 2, 1, 4, 6]
    //
    //Constraints:
    //1 <= price <= 10^5
    //At most 10^4 calls will be made to next.

    public class StockSpanner
    {
        public StockSpanner()
        {
        }

        public int Next(int price)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var spanner = new StockSpanner();
            Assert.That(spanner.Next(100), Is.EqualTo(1));
            Assert.That(spanner.Next(80), Is.EqualTo(1));
            Assert.That(spanner.Next(60), Is.EqualTo(1));
            Assert.That(spanner.Next(70), Is.EqualTo(2));
        }
    }
}